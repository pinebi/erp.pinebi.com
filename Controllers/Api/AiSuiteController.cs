using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Ai;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Json;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// AI ERP Suite: Fatura Okuma, Cari 360, Stok Tahmin, DMS, Bildirimler, Dashboard KPI.
/// </summary>
[ApiController]
[Route("api/mail-yardim")]  // Ayni Cloudflare-friendly route grubu altinda
public class AiSuiteController : ControllerBase
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    private readonly IConfiguration _config;
    private readonly IHttpClientFactory _httpFactory;

    public AiSuiteController(IDbContextFactory<PineErpContext> factory, IConfiguration config, IHttpClientFactory httpFactory)
    {
        _factory = factory; _config = config; _httpFactory = httpFactory;
    }

    // ========================================================
    // AI FATURA OKUMA (Gemini Vision)
    // ========================================================
    [HttpPost("fatura-oku")]
    [RequestSizeLimit(30_000_000)]
    public async Task<IActionResult> FaturaOku()
    {
        if (!Request.HasFormContentType || Request.Form.Files.Count == 0)
            return BadRequest(new { error = "DOSYA_YOK" });
        var file = Request.Form.Files[0];

        using var ms = new MemoryStream();
        await file.CopyToAsync(ms);
        var bytes = ms.ToArray();

        var key = _config["AI:Gemini:ApiKey"];
        if (string.IsNullOrWhiteSpace(key))
            return BadRequest(new { error = "AI_KEY_YOK", detay = "appsettings.json > AI:Gemini:ApiKey bos" });

        var prompt = @"Bu bir Turk fatura/irsaliye dosyasi. Asagidaki alanlari JSON olarak cikar (yoksa null):
{
  ""faturaNo"": string,
  ""tarih"": ""YYYY-MM-DD"",
  ""cariUnvan"": string,
  ""cariVergiNo"": string,
  ""kalemler"": [ { ""ad"": string, ""miktar"": number, ""birim"": string, ""birimFiyat"": number, ""kdvOran"": number, ""tutar"": number } ],
  ""araToplam"": number,
  ""kdvToplam"": number,
  ""genelToplam"": number,
  ""paraBirimi"": string
}
Sadece JSON dondur, baska metin yok.";

        var body = new
        {
            contents = new[] { new {
                role = "user",
                parts = new object[] {
                    new { text = prompt },
                    new { inline_data = new { mime_type = file.ContentType ?? "application/octet-stream", data = Convert.ToBase64String(bytes) } }
                }
            }},
            generationConfig = new { temperature = 0.1, responseMimeType = "application/json" }
        };

        try
        {
            var model = _config["AI:Gemini:Model"] ?? "gemini-2.5-flash";
            using var http = _httpFactory.CreateClient();
            http.Timeout = TimeSpan.FromSeconds(120);
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/{model}:generateContent?key={key}";
            using var resp = await http.PostAsync(url, new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json"));
            var text = await resp.Content.ReadAsStringAsync();
            if (!resp.IsSuccessStatusCode) return StatusCode(500, new { error = "Gemini: " + text });

            using var doc = JsonDocument.Parse(text);
            var metin = doc.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString() ?? "{}";

            await LogAsync("fatura_oku", file.FileName, metin.Substring(0, Math.Min(500, metin.Length)), "gemini");

            JsonElement parsed;
            try { parsed = JsonDocument.Parse(metin).RootElement; }
            catch { parsed = JsonDocument.Parse("{}").RootElement; }

            return Ok(new { ham = metin, parsed });
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ========================================================
    // CARI 360 AI ANALIZ
    // ========================================================
    [HttpGet("cari-360/{cariKod}")]
    public async Task<IActionResult> Cari360(string cariKod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var cari = await db.CariHesaplar.AsNoTracking().FirstOrDefaultAsync(c => c.CarKod == cariKod);
        if (cari == null) return NotFound();

        // Ozet veri
        var faturalar = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatCariKod == cariKod && !f.RecIptal)
            .OrderByDescending(f => f.FatTarih)
            .Take(50)
            .Select(f => new { f.FatBelgeNo, f.FatTarih, f.FatTutar, f.FatTip })
            .ToListAsync();

        var toplamCiro = faturalar.Sum(f => f.FatTutar);
        var faturaAdedi = faturalar.Count;
        var ilkTarih = faturalar.LastOrDefault()?.FatTarih;
        var sonTarih = faturalar.FirstOrDefault()?.FatTarih;
        var ortGun = (ilkTarih != null && sonTarih != null && faturaAdedi > 1)
            ? (int)((sonTarih.Value - ilkTarih.Value).TotalDays / (faturaAdedi - 1)) : 0;

        // Son 12 ay dagilimi
        var on2Ay = faturalar.Where(f => f.FatTarih >= DateTime.Now.AddMonths(-12))
            .GroupBy(f => new { f.FatTarih.Year, f.FatTarih.Month })
            .Select(g => new { ay = $"{g.Key.Year}-{g.Key.Month:D2}", ciro = g.Sum(x => x.FatTutar) })
            .OrderBy(x => x.ay).ToList();

        // AI ozet + risk + mail taslagi
        var key = _config["AI:Gemini:ApiKey"];
        string? aiOzet = null, riskSkor = null, mailTaslak = null;
        if (!string.IsNullOrEmpty(key))
        {
            var prompt = $@"Sen bir B2B satis analistisisin. Asagidaki Turk musteri verisi uzerinden:
1. Durum ozeti (3-4 cumle, Turkce)
2. Risk skoru (dusuk/orta/yuksek) ve neden
3. Bu cariyle tekrar iletisim icin onerilen kisa mail taslagi (maksimum 4 satir)

MUSTERI: {cari.CarUnvan1}
Kod: {cari.CarKod}
Vergi no: {cari.CarVergiNo}
Toplam fatura: {faturaAdedi}
Toplam ciro: {toplamCiro:N0} TL
Ilk islem: {ilkTarih:yyyy-MM-dd}
Son islem: {sonTarih:yyyy-MM-dd}
Ortalama siklik: {ortGun} gun
Son 12 ay: {string.Join(", ", on2Ay.Select(x => $"{x.ay}:{x.ciro:N0}"))}

JSON dondur: {{""ozet"":string,""risk"":""dusuk|orta|yuksek"",""riskNeden"":string,""mailTaslak"":string}}";
            try
            {
                var res = await CallGeminiJson(prompt);
                if (res != null)
                {
                    aiOzet = res.Value.TryGetProperty("ozet", out var o) ? o.GetString() : null;
                    riskSkor = res.Value.TryGetProperty("risk", out var r) ? r.GetString() : null;
                    mailTaslak = res.Value.TryGetProperty("mailTaslak", out var m) ? m.GetString() : null;
                    await LogAsync("cari_analiz", cariKod, aiOzet, "gemini");
                }
            }
            catch { }
        }

        return Ok(new {
            cari = new { cari.CarKod, cari.CarUnvan1, cari.CarVergiNo, cari.CarTel1, cari.CarEmail, cari.CarAdres1 },
            ozet = new { toplamCiro, faturaAdedi, ilkTarih, sonTarih, ortalamaSiklikGun = ortGun },
            trend = on2Ay,
            sonFaturalar = faturalar.Take(10),
            ai = new { ozet = aiOzet, risk = riskSkor, mailTaslak }
        });
    }

    // ========================================================
    // STOK TAHMINI
    // ========================================================
    [HttpPost("stok-tahmin/hesapla")]
    public async Task<IActionResult> StokTahminHesapla()
    {
        using var db = await _factory.CreateDbContextAsync();
        var sonrasi = DateTime.Now.AddMonths(-3);

        // Son 90 gun cikis hareketleri (tip=1 cikis)
        var cikis = await db.StokHareketleri.AsNoTracking()
            .Where(h => h.SthTip == 1 && h.SthTarih >= sonrasi)
            .GroupBy(h => h.SthStokKod)
            .Select(g => new { kod = g.Key, toplam = g.Sum(x => x.SthMiktar) })
            .ToListAsync();

        // Giris - cikis netleme (mevcut stok hesabi)
        var giris = await db.StokHareketleri.AsNoTracking()
            .Where(h => h.SthTip == 0)
            .GroupBy(h => h.SthStokKod)
            .Select(g => new { kod = g.Key, net = g.Sum(x => x.SthMiktar) })
            .ToListAsync();
        var girisMap = giris.ToDictionary(x => x.kod, x => x.net);
        var toplamCikisMap = await db.StokHareketleri.AsNoTracking()
            .Where(h => h.SthTip == 1)
            .GroupBy(h => h.SthStokKod)
            .Select(g => new { kod = g.Key, net = g.Sum(x => x.SthMiktar) })
            .ToDictionaryAsync(x => x.kod, x => x.net);

        var tahminler = new List<object>();
        foreach (var c in cikis)
        {
            if (string.IsNullOrEmpty(c.kod)) continue;
            var gunluk = c.toplam / 90m;
            if (gunluk <= 0) continue;
            var stok = (girisMap.TryGetValue(c.kod, out var g1) ? g1 : 0)
                     - (toplamCikisMap.TryGetValue(c.kod, out var c1) ? c1 : 0);
            var kalanGun = stok > 0 ? (int)(stok / gunluk) : 0;

            string oneri = kalanGun switch
            {
                <= 3  => "KRITIK: Hemen siparis verin",
                <= 7  => "ACIL: Bir hafta icinde siparis",
                <= 14 => "PLANLAYIN: Iki hafta icinde",
                _ => "OK"
            };

            // Upsert cache
            var ex = await db.StokTahmin.FirstOrDefaultAsync(t => t.StokKod == c.kod);
            if (ex == null)
                db.StokTahmin.Add(new PineStokTahmin { StokKod = c.kod, GunlukHareket = gunluk, KalanGun = kalanGun, Oneri = oneri });
            else { ex.GunlukHareket = gunluk; ex.KalanGun = kalanGun; ex.Oneri = oneri; ex.SonHesap = DateTime.UtcNow; }

            if (kalanGun <= 14)
                tahminler.Add(new { stokKod = c.kod, gunlukHareket = gunluk, mevcutStok = stok, kalanGun, oneri });
        }
        await db.SaveChangesAsync();
        return Ok(new { hesaplandi = cikis.Count, uyarilar = tahminler.OrderBy(x => ((dynamic)x).kalanGun).Take(100) });
    }

    [HttpGet("stok-tahmin")]
    public async Task<IActionResult> StokTahminListe()
    {
        using var db = await _factory.CreateDbContextAsync();
        var items = await db.StokTahmin.AsNoTracking().Where(t => t.KalanGun <= 30)
            .OrderBy(t => t.KalanGun).Take(200).ToListAsync();
        return Ok(items);
    }

    // ========================================================
    // DMS - BELGE
    // ========================================================
    [HttpPost("belge")]
    [RequestSizeLimit(100_000_000)]
    public async Task<IActionResult> BelgeYukle([FromQuery] string? baglantiTip = null, [FromQuery] string? baglantiId = null)
    {
        if (!Request.HasFormContentType || Request.Form.Files.Count == 0) return BadRequest();
        var file = Request.Form.Files[0];
        using var db = await _factory.CreateDbContextAsync();
        using var ms = new MemoryStream();
        await file.CopyToAsync(ms);
        var bytes = ms.ToArray();
        var hash = System.Security.Cryptography.SHA256.HashData(bytes);

        var d = new PineDocument
        {
            DocumentId = Guid.NewGuid(),
            Ad = file.FileName,
            Mime = file.ContentType,
            Boyut = bytes.Length,
            Icerik = bytes.Length < 5_000_000 ? bytes : null,
            HashSha256 = hash,
            BaglantiTip = baglantiTip,
            BaglantiId = baglantiId
        };
        if (d.Icerik == null)
        {
            var dir = Path.Combine(@"C:\Pinebi\docs", DateTime.Now.ToString("yyyy-MM"));
            Directory.CreateDirectory(dir);
            var yol = Path.Combine(dir, d.DocumentId + Path.GetExtension(file.FileName));
            await System.IO.File.WriteAllBytesAsync(yol, bytes);
            d.DiskYol = yol;
        }
        db.Documents.Add(d);
        await db.SaveChangesAsync();
        return Ok(new { d.DocumentId, d.Ad, d.Boyut });
    }

    [HttpGet("belgeler")]
    public async Task<IActionResult> BelgeListe([FromQuery] string? baglantiTip = null, [FromQuery] string? baglantiId = null, [FromQuery] int take = 100)
    {
        using var db = await _factory.CreateDbContextAsync();
        var q = db.Documents.AsNoTracking().OrderByDescending(d => d.Olusturulma).AsQueryable();
        if (!string.IsNullOrEmpty(baglantiTip)) q = q.Where(d => d.BaglantiTip == baglantiTip);
        if (!string.IsNullOrEmpty(baglantiId)) q = q.Where(d => d.BaglantiId == baglantiId);
        var items = await q.Take(take).Select(d => new {
            d.DocumentId, d.Ad, d.Mime, d.Boyut, d.Etiketler, d.BaglantiTip, d.BaglantiId, d.Olusturulma
        }).ToListAsync();
        return Ok(items);
    }

    [HttpGet("belge/{id:guid}")]
    public async Task<IActionResult> BelgeIndir(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var d = await db.Documents.AsNoTracking().FirstOrDefaultAsync(x => x.DocumentId == id);
        if (d == null) return NotFound();
        byte[] bytes;
        if (d.Icerik != null) bytes = d.Icerik;
        else if (!string.IsNullOrEmpty(d.DiskYol) && System.IO.File.Exists(d.DiskYol)) bytes = await System.IO.File.ReadAllBytesAsync(d.DiskYol);
        else return NotFound();
        return File(bytes, d.Mime ?? "application/octet-stream", d.Ad);
    }

    [HttpDelete("belge/{id:guid}")]
    public async Task<IActionResult> BelgeSil(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var d = await db.Documents.FirstOrDefaultAsync(x => x.DocumentId == id);
        if (d == null) return NotFound();
        if (!string.IsNullOrEmpty(d.DiskYol) && System.IO.File.Exists(d.DiskYol))
            try { System.IO.File.Delete(d.DiskYol); } catch { }
        db.Documents.Remove(d);
        await db.SaveChangesAsync();
        return Ok();
    }

    // ========================================================
    // DASHBOARD KPI
    // ========================================================
    [HttpGet("panel-kpi")]
    public async Task<IActionResult> PanelKpi()
    {
        using var db = await _factory.CreateDbContextAsync();
        var bugun = DateTime.Today;
        var ayBaslangic = new DateTime(bugun.Year, bugun.Month, 1);
        var gecenAy = ayBaslangic.AddMonths(-1);

        var bugunCiro = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatTarih >= bugun && !f.RecIptal && f.FatTip == 1)
            .SumAsync(f => (decimal?)f.FatTutar) ?? 0;
        var ayCiro = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatTarih >= ayBaslangic && !f.RecIptal && f.FatTip == 1)
            .SumAsync(f => (decimal?)f.FatTutar) ?? 0;
        var gecenAyCiro = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatTarih >= gecenAy && f.FatTarih < ayBaslangic && !f.RecIptal && f.FatTip == 1)
            .SumAsync(f => (decimal?)f.FatTutar) ?? 0;

        var fatura30g = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatTarih >= bugun.AddDays(-30) && !f.RecIptal && f.FatTip == 1)
            .GroupBy(f => f.FatTarih.Date)
            .Select(g => new { g.Key, t = g.Sum(x => x.FatTutar) })
            .OrderBy(x => x.Key).ToListAsync();

        var stokSayisi = await db.Stoklar.CountAsync(s => !s.RecIptal && !s.RecGizli);
        var cariSayisi = await db.CariHesaplar.CountAsync(c => !c.RecIptal && !c.RecGizli);
        var kritikStok = await db.StokTahmin.CountAsync(t => t.KalanGun <= 7);

        var topCari = await db.Faturalar.AsNoTracking()
            .Where(f => f.FatTarih >= bugun.AddMonths(-3) && !f.RecIptal && f.FatTip == 1)
            .GroupBy(f => f.FatCariKod)
            .Select(g => new { cariKod = g.Key, ciro = g.Sum(x => x.FatTutar), adet = g.Count() })
            .OrderByDescending(x => x.ciro).Take(10).ToListAsync();

        var topCariKodlari = topCari.Select(x => x.cariKod).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        var cariMap = topCariKodlari.Length > 0
            ? await db.CariHesaplar.AsNoTracking().Where(c => topCariKodlari.Contains(c.CarKod))
                .ToDictionaryAsync(c => c.CarKod, c => c.CarUnvan1 ?? "")
            : new Dictionary<string, string>();

        return Ok(new {
            bugunCiro, ayCiro, gecenAyCiro,
            degisimYuzde = gecenAyCiro > 0 ? (double)((ayCiro - gecenAyCiro) / gecenAyCiro) * 100 : 0,
            stokSayisi, cariSayisi, kritikStok,
            ciroGrafik = fatura30g.Select(x => new { x.Key, x.t }),
            topCari = topCari.Select(x => new { x.cariKod, unvan = cariMap.ContainsKey(x.cariKod) ? cariMap[x.cariKod] : x.cariKod, x.ciro, x.adet })
        });
    }

    // ========================================================
    // BILDIRIMLER
    // ========================================================
    [HttpGet("bildirimler")]
    public async Task<IActionResult> Bildirimler([FromQuery] bool sadeceOkunmamis = false)
    {
        using var db = await _factory.CreateDbContextAsync();
        var q = db.Bildirimler.AsNoTracking().OrderByDescending(b => b.Tarih).AsQueryable();
        if (sadeceOkunmamis) q = q.Where(b => !b.Okundu);
        var items = await q.Take(50).ToListAsync();
        var okunmamisSayi = await db.Bildirimler.CountAsync(b => !b.Okundu);
        return Ok(new { okunmamisSayi, items });
    }

    [HttpPost("bildirimler/{id:guid}/okundu")]
    public async Task<IActionResult> BildirimOkundu(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var b = await db.Bildirimler.FirstOrDefaultAsync(x => x.BildirimId == id);
        if (b == null) return NotFound();
        b.Okundu = true;
        await db.SaveChangesAsync();
        return Ok();
    }

    // ========================================================
    // ROLLER / YETKI
    // ========================================================
    [HttpGet("roller")]
    public async Task<IActionResult> Roller()
    {
        using var db = await _factory.CreateDbContextAsync();
        return Ok(await db.Roles.AsNoTracking().ToListAsync());
    }

    [HttpPost("rol-atama")]
    public async Task<IActionResult> RolAta([FromBody] RolAtamaDto dto)
    {
        using var db = await _factory.CreateDbContextAsync();
        await db.Database.ExecuteSqlRawAsync(
            "UPDATE pine_kullanicilar SET role_adi = {0} WHERE kullanici_adi = {1}", dto.RoleAdi, dto.KullaniciAdi);
        return Ok();
    }
    public class RolAtamaDto { public string KullaniciAdi { get; set; } = ""; public string RoleAdi { get; set; } = ""; }

    // ========================================================
    // HELPERS
    // ========================================================
    private async Task<JsonElement?> CallGeminiJson(string prompt)
    {
        var key = _config["AI:Gemini:ApiKey"];
        if (string.IsNullOrEmpty(key)) return null;
        var model = _config["AI:Gemini:Model"] ?? "gemini-2.5-flash";
        var body = new
        {
            contents = new[] { new { role = "user", parts = new[] { new { text = prompt } } } },
            generationConfig = new { temperature = 0.3, responseMimeType = "application/json", maxOutputTokens = 1024 }
        };
        using var http = _httpFactory.CreateClient();
        http.Timeout = TimeSpan.FromSeconds(60);
        using var resp = await http.PostAsync(
            $"https://generativelanguage.googleapis.com/v1beta/models/{model}:generateContent?key={key}",
            new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json"));
        var txt = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode) return null;
        using var doc = JsonDocument.Parse(txt);
        var mt = doc.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString() ?? "{}";
        try { return JsonDocument.Parse(mt).RootElement.Clone(); } catch { return null; }
    }

    private async Task LogAsync(string islem, string? girisOzet, string? cikisOzet, string saglayici)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            db.AiLog.Add(new PineAiLog { LogId = Guid.NewGuid(), Islem = islem,
                GirisOzet = girisOzet?.Substring(0, Math.Min(500, girisOzet.Length)),
                CikisOzet = cikisOzet, Saglayici = saglayici, Tarih = DateTime.UtcNow });
            await db.SaveChangesAsync();
        }
        catch { }
    }
}
