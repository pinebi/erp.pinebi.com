using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Fatura;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Fatura API - Satis, Satinalma, Proforma fatura islemleri.
/// Route: /api/fatura
/// </summary>
[Route("api/fatura")]
public class FaturaController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;

    public FaturaController(IDbContextFactory<PineErpContext> factory)
    {
        _factory = factory;
    }

    // ═══════════════════════════════════════════════════════════════
    // GET api/fatura/liste?tip=1&sayfa=1&boyut=50&baslangic=&bitis=&arama=
    // ═══════════════════════════════════════════════════════════════
    [HttpGet("liste")]
    public async Task<IActionResult> Liste(
        [FromQuery] int tip = 1,
        [FromQuery] int sayfa = 1,
        [FromQuery] int boyut = 50,
        [FromQuery] string? baslangic = null,
        [FromQuery] string? bitis = null,
        [FromQuery] string? arama = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();

            var basTarih = string.IsNullOrEmpty(baslangic) ? DateTime.Today.AddDays(-90) : DateTime.Parse(baslangic);
            var bitTarih = string.IsNullOrEmpty(bitis) ? DateTime.Today : DateTime.Parse(bitis);

            var query = db.Faturalar.AsNoTracking()
                .Where(f => f.FatTip == tip
                    && !f.RecGizli
                    && f.FatTarih >= basTarih
                    && f.FatTarih <= bitTarih);

            // Arama filtresi
            if (!string.IsNullOrWhiteSpace(arama))
            {
                var q = arama.Trim();
                query = query.Where(f =>
                    (f.FatEvrakSeri != null && f.FatEvrakSeri.Contains(q)) ||
                    (f.FatBelgeNo != null && f.FatBelgeNo.Contains(q)) ||
                    (f.FatCariKod != null && EF.Functions.Collate(f.FatCariKod, "Latin1_General_CI_AI").Contains(q)) ||
                    (f.FatCariUnvan != null && EF.Functions.Collate(f.FatCariUnvan, "Latin1_General_CI_AI").Contains(q)));
            }

            var toplam = await query.CountAsync();
            var liste = await query
                .OrderByDescending(f => f.FatTarih)
                .ThenByDescending(f => f.Id)
                .Skip((sayfa - 1) * boyut)
                .Take(boyut)
                .Select(f => new FaturaListeDto
                {
                    Id = f.Id,
                    RecGuid = f.RecGuid,
                    FatTip = f.FatTip,
                    FatFaturaTipi = f.FatFaturaTipi,
                    FatTarih = f.FatTarih,
                    FatSevkTarihi = f.FatSevkTarihi,
                    FatVadeTarihi = f.FatVadeTarihi,
                    FatEvrakSeri = f.FatEvrakSeri,
                    FatEvrakSira = f.FatEvrakSira,
                    FisNo = (f.FatEvrakSeri ?? "") + f.FatEvrakSira.ToString("D6"),
                    FatBelgeNo = f.FatBelgeNo,
                    FatCariKod = f.FatCariKod,
                    FatCariUnvan = f.FatCariUnvan,
                    FatDovizCinsi = f.FatDovizCinsi,
                    FatDovizKuru = f.FatDovizKuru,
                    FatPlasiyerKodu = f.FatPlasiyerKodu,
                    FatTutar = f.FatTutar,
                    FatToplamIskonto = f.FatToplamIskonto,
                    FatKdvMatrahi = f.FatKdvMatrahi,
                    FatKdvTutari = f.FatKdvTutari,
                    FatToplamTutar = f.FatToplamTutar,
                    FatOdenecekTutar = f.FatOdenecekTutar,
                    FatTlTutar = f.FatTlTutar,
                    FatTlKdvTutari = f.FatTlKdvTutari,
                    FatTlToplamTutar = f.FatTlToplamTutar,
                    FatTlOdenecekTutar = f.FatTlOdenecekTutar,
                    FatDurumu = f.FatDurumu,
                    FatKapandiFl = f.FatKapandiFl,
                    FatGibDurumu = f.FatGibDurumu,
                    FatAciklama1 = f.FatAciklama1,
                    RecIptal = f.RecIptal
                })
                .ToListAsync();

            return OkPaged(liste, toplam, sayfa, boyut);
        }
        catch (Exception ex)
        {
            return Error($"Fatura listesi hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // GET api/fatura/{id}
    // ═══════════════════════════════════════════════════════════════
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var fatura = await db.Faturalar.AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);
            if (fatura == null) return Error("Fatura bulunamadi", 404);

            var satirlar = await db.FaturaSatirlari.AsNoTracking()
                .Where(s => s.FtsFaturaUid == fatura.RecGuid)
                .OrderBy(s => s.FtsSatirNo)
                .ToListAsync();

            return Ok(new { fatura, satirlar });
        }
        catch (Exception ex)
        {
            return Error($"Fatura detay hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // POST api/fatura (header + satirlar tek islemde)
    // ═══════════════════════════════════════════════════════════════
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] FaturaKaydetDto dto)
    {
        try
        {
            if (dto == null) return Error("Fatura verisi bos!");
            if (string.IsNullOrWhiteSpace(dto.Fatura.FatCariKod)) return Error("Cari kodu bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();
            using var tx = await db.Database.BeginTransactionAsync();

            // Numarator: otomatik evrak no uret
            var seri = dto.Fatura.FatEvrakSeri ?? "A";
            var numarator = await db.FaturaNumarator.FirstOrDefaultAsync(n =>
                n.FnuSeri == seri && n.FnuFaturaTipi == dto.Fatura.FatTip && !n.FnuPasifFl);
            int sira;
            if (numarator != null)
            {
                numarator.FnuSonSira++;
                sira = numarator.FnuSonSira;
            }
            else
            {
                var maxSira = await db.Faturalar
                    .Where(f => f.FatEvrakSeri == seri && f.FatTip == dto.Fatura.FatTip)
                    .MaxAsync(f => (int?)f.FatEvrakSira) ?? 0;
                sira = maxSira + 1;
            }

            // Fatura header
            var fatura = dto.Fatura;
            fatura.RecGuid = Guid.NewGuid();
            fatura.FatEvrakSeri = seri;
            fatura.FatEvrakSira = sira;
            fatura.RecCreateDate = DateTime.Now;
            fatura.RecCreateUser = dto.Kullanici ?? "System";

            db.Faturalar.Add(fatura);
            await db.SaveChangesAsync();

            // Fatura satirlari
            if (dto.Satirlar != null)
            {
                int satNo = 1;
                foreach (var satir in dto.Satirlar)
                {
                    satir.FtsFaturaUid = fatura.RecGuid;
                    satir.FtsSatirNo = satNo++;
                    satir.FtsTip = fatura.FatTip;
                    satir.RecGuid = Guid.NewGuid();
                    satir.RecCreateDate = DateTime.Now;
                    satir.RecCreateUser = dto.Kullanici ?? "System";
                    db.FaturaSatirlari.Add(satir);
                }
                await db.SaveChangesAsync();
            }

            await tx.CommitAsync();

            return Ok(new { fatura.Id, fatura.RecGuid, FisNo = seri + sira.ToString("D6") },
                "Fatura basariyla kaydedildi");
        }
        catch (Exception ex)
        {
            return Error($"Fatura kayit hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // PUT api/fatura/{id}
    // ═══════════════════════════════════════════════════════════════
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] FaturaKaydetDto dto)
    {
        try
        {
            if (dto == null) return Error("Fatura verisi bos!");

            using var db = await _factory.CreateDbContextAsync();
            using var tx = await db.Database.BeginTransactionAsync();

            var existing = await db.Faturalar.FirstOrDefaultAsync(f => f.Id == id);
            if (existing == null) return Error("Fatura bulunamadi", 404);
            if (existing.RecKilitli) return Error("Bu fatura kilitli, duzenlenemez!");

            // Header guncelle
            existing.FatTarih = dto.Fatura.FatTarih;
            existing.FatSevkTarihi = dto.Fatura.FatSevkTarihi;
            existing.FatVadeTarihi = dto.Fatura.FatVadeTarihi;
            existing.FatBelgeNo = dto.Fatura.FatBelgeNo;
            existing.FatCariKod = dto.Fatura.FatCariKod;
            existing.FatCariUnvan = dto.Fatura.FatCariUnvan;
            existing.FatOdemeSekli = dto.Fatura.FatOdemeSekli;
            existing.FatDovizCinsi = dto.Fatura.FatDovizCinsi;
            existing.FatDovizKuru = dto.Fatura.FatDovizKuru;
            existing.FatDepoNo = dto.Fatura.FatDepoNo;
            existing.FatPlasiyerKodu = dto.Fatura.FatPlasiyerKodu;
            existing.FatProjeKodu = dto.Fatura.FatProjeKodu;
            existing.FatTutar = dto.Fatura.FatTutar;
            existing.FatToplamIskonto = dto.Fatura.FatToplamIskonto;
            existing.FatKdvMatrahi = dto.Fatura.FatKdvMatrahi;
            existing.FatKdvTutari = dto.Fatura.FatKdvTutari;
            existing.FatToplamTutar = dto.Fatura.FatToplamTutar;
            existing.FatOdenecekTutar = dto.Fatura.FatOdenecekTutar;
            existing.FatTlTutar = dto.Fatura.FatTlTutar;
            existing.FatTlKdvMatrahi = dto.Fatura.FatTlKdvMatrahi;
            existing.FatTlKdvTutari = dto.Fatura.FatTlKdvTutari;
            existing.FatTlToplamTutar = dto.Fatura.FatTlToplamTutar;
            existing.FatTlOdenecekTutar = dto.Fatura.FatTlOdenecekTutar;
            existing.FatAciklama1 = dto.Fatura.FatAciklama1;
            existing.FatAciklama2 = dto.Fatura.FatAciklama2;
            existing.FatDurumu = dto.Fatura.FatDurumu;
            existing.RecLastupDate = DateTime.Now;
            existing.RecLastupUser = dto.Kullanici ?? "System";

            // Satirlari sil ve yeniden ekle
            var eskiSatirlar = await db.FaturaSatirlari
                .Where(s => s.FtsFaturaUid == existing.RecGuid)
                .ToListAsync();
            db.FaturaSatirlari.RemoveRange(eskiSatirlar);

            if (dto.Satirlar != null)
            {
                int satNo = 1;
                foreach (var satir in dto.Satirlar)
                {
                    satir.Id = 0; // yeni kayit
                    satir.FtsFaturaUid = existing.RecGuid;
                    satir.FtsSatirNo = satNo++;
                    satir.FtsTip = existing.FatTip;
                    satir.RecGuid = Guid.NewGuid();
                    satir.RecCreateDate = DateTime.Now;
                    satir.RecCreateUser = dto.Kullanici ?? "System";
                    db.FaturaSatirlari.Add(satir);
                }
            }

            await db.SaveChangesAsync();
            await tx.CommitAsync();

            return OkMessage("Fatura basariyla guncellendi");
        }
        catch (Exception ex)
        {
            return Error($"Fatura guncelleme hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // DELETE api/fatura/{id} (soft delete + iptal log)
    // ═══════════════════════════════════════════════════════════════
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, [FromQuery] string? sebep = null, [FromQuery] string? kullanici = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            using var tx = await db.Database.BeginTransactionAsync();

            var fatura = await db.Faturalar.FirstOrDefaultAsync(f => f.Id == id);
            if (fatura == null) return Error("Fatura bulunamadi", 404);
            if (fatura.RecIptal) return Error("Bu fatura zaten iptal edilmis!");

            // Soft delete
            fatura.RecIptal = true;
            fatura.RecGizli = true;
            fatura.RecLastupDate = DateTime.Now;
            fatura.RecLastupUser = kullanici ?? "System";

            // Iptal log
            db.FaturaIptalLog.Add(new PineFaturaIptalLog
            {
                RecGuid = Guid.NewGuid(),
                FilFaturaUid = fatura.RecGuid,
                FilIptalTarihi = DateTime.Now,
                FilIptalEden = kullanici ?? "System",
                FilIptalTipi = 1, // Kullanici Iptali
                FilIptalSebebi = sebep ?? "Kullanici tarafindan iptal edildi",
                FilFaturaNo = (fatura.FatEvrakSeri ?? "") + fatura.FatEvrakSira.ToString("D6"),
                FilEttn = fatura.FatEttn,
                RecCreateDate = DateTime.Now,
                RecCreateUser = kullanici ?? "System"
            });

            // Satirlari da iptal et
            var satirlar = await db.FaturaSatirlari
                .Where(s => s.FtsFaturaUid == fatura.RecGuid)
                .ToListAsync();
            foreach (var s in satirlar)
            {
                s.RecIptal = true;
            }

            await db.SaveChangesAsync();
            await tx.CommitAsync();

            return OkMessage("Fatura basariyla iptal edildi");
        }
        catch (Exception ex)
        {
            return Error($"Fatura iptal hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // GET api/fatura/satirlar/{faturaId}
    // ═══════════════════════════════════════════════════════════════
    [HttpGet("satirlar/{faturaId:int}")]
    public async Task<IActionResult> Satirlar(int faturaId)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var fatura = await db.Faturalar.AsNoTracking().FirstOrDefaultAsync(f => f.Id == faturaId);
            if (fatura == null) return Error("Fatura bulunamadi", 404);

            var satirlar = await db.FaturaSatirlari.AsNoTracking()
                .Where(s => s.FtsFaturaUid == fatura.RecGuid && !s.RecIptal)
                .OrderBy(s => s.FtsSatirNo)
                .ToListAsync();

            return Ok(satirlar);
        }
        catch (Exception ex)
        {
            return Error($"Fatura satirlari hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // GET api/fatura/tahsilat/{faturaId}
    // ═══════════════════════════════════════════════════════════════
    [HttpGet("tahsilat/{faturaId:int}")]
    public async Task<IActionResult> TahsilatListesi(int faturaId)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var fatura = await db.Faturalar.AsNoTracking().FirstOrDefaultAsync(f => f.Id == faturaId);
            if (fatura == null) return Error("Fatura bulunamadi", 404);

            var tahsilatlar = await db.FaturaTahsilat.AsNoTracking()
                .Where(t => t.FthFaturaUid == fatura.RecGuid && !t.RecIptal)
                .OrderByDescending(t => t.FthTarih)
                .ToListAsync();

            var toplamTahsilat = tahsilatlar.Sum(t => t.FthTutar);

            return Ok(new
            {
                FaturaId = faturaId,
                FaturaTutar = fatura.FatOdenecekTutar,
                ToplamTahsilat = toplamTahsilat,
                Kalan = fatura.FatOdenecekTutar - toplamTahsilat,
                Tahsilatlar = tahsilatlar
            });
        }
        catch (Exception ex)
        {
            return Error($"Tahsilat listesi hatasi: {ex.Message}");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // POST api/fatura/tahsilat
    // ═══════════════════════════════════════════════════════════════
    [HttpPost("tahsilat")]
    public async Task<IActionResult> TahsilatKaydet([FromBody] TahsilatKaydetDto dto)
    {
        try
        {
            if (dto == null) return Error("Tahsilat verisi bos!");
            if (dto.Tutar <= 0) return Error("Tutar sifirdan buyuk olmalidir!");

            using var db = await _factory.CreateDbContextAsync();

            var fatura = await db.Faturalar.FirstOrDefaultAsync(f => f.Id == dto.FaturaId);
            if (fatura == null) return Error("Fatura bulunamadi", 404);

            var tahsilat = new PineFaturaTahsilat
            {
                RecGuid = Guid.NewGuid(),
                FthFaturaUid = fatura.RecGuid,
                FthTarih = DateTime.Now,
                FthTip = dto.Tip,
                FthOdemeSekli = dto.OdemeSekli,
                FthTutar = dto.Tutar,
                FthDovizCinsi = dto.DovizCinsi ?? fatura.FatDovizCinsi ?? "TL",
                FthDovizKuru = dto.DovizKuru > 0 ? dto.DovizKuru : 1,
                FthTlTutar = dto.DovizKuru > 0 ? dto.Tutar * dto.DovizKuru : dto.Tutar,
                FthKasaKodu = dto.KasaKodu,
                FthBankaKodu = dto.BankaKodu,
                FthBelgeNo = dto.BelgeNo,
                FthAciklama = dto.Aciklama,
                RecCreateDate = DateTime.Now,
                RecCreateUser = dto.Kullanici ?? "System"
            };

            db.FaturaTahsilat.Add(tahsilat);
            await db.SaveChangesAsync();

            return Ok(new { tahsilat.Id }, "Tahsilat basariyla kaydedildi");
        }
        catch (Exception ex)
        {
            return Error($"Tahsilat kayit hatasi: {ex.Message}");
        }
    }
}

// ═══════════════════════════════════════════════════════════════
// DTOs
// ═══════════════════════════════════════════════════════════════

public class FaturaListeDto
{
    public int Id { get; set; }
    public Guid RecGuid { get; set; }
    public int FatTip { get; set; }
    public int FatFaturaTipi { get; set; }
    public DateTime FatTarih { get; set; }
    public DateTime? FatSevkTarihi { get; set; }
    public DateTime? FatVadeTarihi { get; set; }
    public string? FatEvrakSeri { get; set; }
    public int FatEvrakSira { get; set; }
    public string FisNo { get; set; } = "";
    public string? FatBelgeNo { get; set; }
    public string FatCariKod { get; set; } = "";
    public string? FatCariUnvan { get; set; }
    public string? FatDovizCinsi { get; set; }
    public decimal FatDovizKuru { get; set; }
    public string? FatPlasiyerKodu { get; set; }
    public decimal FatTutar { get; set; }
    public decimal FatToplamIskonto { get; set; }
    public decimal FatKdvMatrahi { get; set; }
    public decimal FatKdvTutari { get; set; }
    public decimal FatToplamTutar { get; set; }
    public decimal FatOdenecekTutar { get; set; }
    public decimal FatTlTutar { get; set; }
    public decimal FatTlKdvTutari { get; set; }
    public decimal FatTlToplamTutar { get; set; }
    public decimal FatTlOdenecekTutar { get; set; }
    public string? FatDurumu { get; set; }
    public bool FatKapandiFl { get; set; }
    public string? FatGibDurumu { get; set; }
    public string? FatAciklama1 { get; set; }
    public bool RecIptal { get; set; }
}

public class FaturaKaydetDto
{
    public PineFaturalar Fatura { get; set; } = new();
    public List<PineFaturaSatirlari>? Satirlar { get; set; }
    public string? Kullanici { get; set; }
}

public class TahsilatKaydetDto
{
    public int FaturaId { get; set; }
    /// <summary>0=Tahsilat, 1=Odeme</summary>
    public int Tip { get; set; }
    /// <summary>1=Nakit, 2=Havale, 3=KrediKarti, 4=Cek, 5=Senet</summary>
    public int OdemeSekli { get; set; }
    public decimal Tutar { get; set; }
    public string? DovizCinsi { get; set; }
    public decimal DovizKuru { get; set; }
    public string? KasaKodu { get; set; }
    public string? BankaKodu { get; set; }
    public string? BelgeNo { get; set; }
    public string? Aciklama { get; set; }
    public string? Kullanici { get; set; }
}
