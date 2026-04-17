using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Finans;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Finans API - Kasa, Banka, Cek/Senet islemleri.
/// Route: /api/finans
/// </summary>
[Route("api/finans")]
public class FinansController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;

    public FinansController(IDbContextFactory<PineErpContext> factory)
    {
        _factory = factory;
    }

    // ═════════════════════════════════════════════════════════════
    //  KASALAR
    // ═════════════════════════════════════════════════════════════

    /// <summary>GET api/finans/kasalar - Kasa listesi</summary>
    [HttpGet("kasalar")]
    public async Task<IActionResult> KasaListesi()
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var kasalar = await db.Kasalar.AsNoTracking()
                .Where(k => !k.RecGizli && !k.RecIptal)
                .OrderBy(k => k.KasKod)
                .ToListAsync();
            return Ok(kasalar);
        }
        catch (Exception ex)
        {
            return Error($"Kasa listesi hatasi: {ex.Message}");
        }
    }

    /// <summary>POST api/finans/kasalar - Yeni kasa ekle</summary>
    [HttpPost("kasalar")]
    public async Task<IActionResult> KasaEkle([FromBody] PineKasalar kasa)
    {
        try
        {
            if (kasa == null || string.IsNullOrWhiteSpace(kasa.KasKod))
                return Error("Kasa kodu bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();

            var mevcutMu = await db.Kasalar.AnyAsync(k => k.KasKod == kasa.KasKod && !k.RecGizli);
            if (mevcutMu) return Error("Bu kasa kodu zaten mevcut!");

            kasa.RecGuid = Guid.NewGuid();
            kasa.RecCreateDate = DateTime.Now;
            db.Kasalar.Add(kasa);
            await db.SaveChangesAsync();

            return Ok(new { kasa.Id, kasa.KasKod }, "Kasa basariyla eklendi");
        }
        catch (Exception ex)
        {
            return Error($"Kasa ekleme hatasi: {ex.Message}");
        }
    }

    // ═════════════════════════════════════════════════════════════
    //  KASA HAREKETLERI
    // ═════════════════════════════════════════════════════════════

    /// <summary>GET api/finans/kasa/hareketler?kasaKod=&baslangic=&bitis=</summary>
    [HttpGet("kasa/hareketler")]
    public async Task<IActionResult> KasaHareketleri(
        [FromQuery] string? kasaKod = null,
        [FromQuery] string? baslangic = null,
        [FromQuery] string? bitis = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();

            var basTarih = string.IsNullOrEmpty(baslangic) ? DateTime.Today.AddDays(-30) : DateTime.Parse(baslangic);
            var bitTarih = string.IsNullOrEmpty(bitis) ? DateTime.Today : DateTime.Parse(bitis);

            var query = db.KasaHareketleri.AsNoTracking()
                .Where(k => !k.RecIptal && !k.RecGizli
                    && k.KshTarih >= basTarih && k.KshTarih <= bitTarih);

            if (!string.IsNullOrWhiteSpace(kasaKod))
                query = query.Where(k => k.KshKasaKod == kasaKod);

            var liste = await query
                .OrderByDescending(k => k.KshTarih)
                .ThenByDescending(k => k.Id)
                .Take(500)
                .Select(k => new KasaHareketDto
                {
                    Id = k.Id,
                    RecGuid = k.RecGuid,
                    KasaKod = k.KshKasaKod,
                    Tarih = k.KshTarih,
                    Tip = k.KshTip,
                    EvrakSeri = k.KshEvrakSeri,
                    EvrakSira = k.KshEvrakSira,
                    BelgeNo = k.KshBelgeNo,
                    Tutar = k.KshTutar,
                    DovizCinsi = k.KshDovizCinsi,
                    DovizKuru = k.KshDovizKuru,
                    CariKod = k.KshCariKod,
                    HareketCinsi = k.KshHareketCinsi,
                    Aciklama1 = k.KshAciklama1,
                    Aciklama2 = k.KshAciklama2,
                    Giris = k.KshTip == 0 ? k.KshTutar : 0,
                    Cikis = k.KshTip == 1 ? k.KshTutar : 0
                })
                .ToListAsync();

            var toplamGiris = liste.Sum(x => x.Giris);
            var toplamCikis = liste.Sum(x => x.Cikis);

            return Ok(new { Hareketler = liste, ToplamGiris = toplamGiris, ToplamCikis = toplamCikis, Bakiye = toplamGiris - toplamCikis });
        }
        catch (Exception ex)
        {
            return Error($"Kasa hareketleri hatasi: {ex.Message}");
        }
    }

    /// <summary>POST api/finans/kasa/hareket - Kasa hareketi kaydet</summary>
    [HttpPost("kasa/hareket")]
    public async Task<IActionResult> KasaHareketKaydet([FromBody] KasaHareketKaydetDto dto)
    {
        try
        {
            if (dto == null) return Error("Veri bos!");
            if (dto.Tutar <= 0) return Error("Tutar sifirdan buyuk olmalidir!");
            if (string.IsNullOrWhiteSpace(dto.KasaKod)) return Error("Kasa kodu bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();

            var hareket = new PineKasaHareketleri
            {
                RecGuid = Guid.NewGuid(),
                KshKasaKod = dto.KasaKod,
                KshTarih = dto.Tarih ?? DateTime.Today,
                KshTip = dto.Tip, // 0=Giris, 1=Cikis
                KshTutar = dto.Tutar,
                KshDovizCinsi = dto.DovizCinsi ?? "TL",
                KshDovizKuru = dto.DovizKuru > 0 ? dto.DovizKuru : 1,
                KshCariKod = dto.CariKod,
                KshHareketCinsi = dto.HareketCinsi,
                KshBelgeNo = dto.BelgeNo,
                KshAciklama1 = dto.Aciklama1,
                KshAciklama2 = dto.Aciklama2,
                RecCreateDate = DateTime.Now,
                RecCreateUser = dto.Kullanici ?? "System"
            };

            db.KasaHareketleri.Add(hareket);
            await db.SaveChangesAsync();

            return Ok(new { hareket.Id }, "Kasa hareketi basariyla kaydedildi");
        }
        catch (Exception ex)
        {
            return Error($"Kasa hareketi kayit hatasi: {ex.Message}");
        }
    }

    // ═════════════════════════════════════════════════════════════
    //  BANKA HESAPLARI
    // ═════════════════════════════════════════════════════════════

    /// <summary>GET api/finans/banka/hesaplar - Banka hesap listesi</summary>
    [HttpGet("banka/hesaplar")]
    public async Task<IActionResult> BankaHesapListesi()
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var hesaplar = await db.BankaHesaplari.AsNoTracking()
                .Where(b => !b.RecGizli && !b.RecIptal && b.BhsAktif)
                .OrderBy(b => b.BhsKod)
                .ToListAsync();
            return Ok(hesaplar);
        }
        catch (Exception ex)
        {
            return Error($"Banka hesaplari hatasi: {ex.Message}");
        }
    }

    /// <summary>POST api/finans/banka/hesaplar - Yeni banka hesabi ekle</summary>
    [HttpPost("banka/hesaplar")]
    public async Task<IActionResult> BankaHesapEkle([FromBody] PineBankaHesaplari hesap)
    {
        try
        {
            if (hesap == null || string.IsNullOrWhiteSpace(hesap.BhsKod))
                return Error("Hesap kodu bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();

            var mevcutMu = await db.BankaHesaplari.AnyAsync(b => b.BhsKod == hesap.BhsKod && !b.RecGizli);
            if (mevcutMu) return Error("Bu hesap kodu zaten mevcut!");

            hesap.RecGuid = Guid.NewGuid();
            hesap.RecCreateDate = DateTime.Now;
            db.BankaHesaplari.Add(hesap);
            await db.SaveChangesAsync();

            return Ok(new { hesap.Id, hesap.BhsKod }, "Banka hesabi basariyla eklendi");
        }
        catch (Exception ex)
        {
            return Error($"Banka hesap ekleme hatasi: {ex.Message}");
        }
    }

    // ═════════════════════════════════════════════════════════════
    //  BANKA HAREKETLERI
    // ═════════════════════════════════════════════════════════════

    /// <summary>GET api/finans/banka/hareketler?hesapKod=&baslangic=&bitis=</summary>
    [HttpGet("banka/hareketler")]
    public async Task<IActionResult> BankaHareketleri(
        [FromQuery] string? hesapKod = null,
        [FromQuery] string? baslangic = null,
        [FromQuery] string? bitis = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();

            var basTarih = string.IsNullOrEmpty(baslangic) ? DateTime.Today.AddDays(-30) : DateTime.Parse(baslangic);
            var bitTarih = string.IsNullOrEmpty(bitis) ? DateTime.Today : DateTime.Parse(bitis);

            var query = db.BankaHareketleri.AsNoTracking()
                .Where(b => !b.RecIptal && !b.RecGizli
                    && b.BnhTarih >= basTarih && b.BnhTarih <= bitTarih);

            if (!string.IsNullOrWhiteSpace(hesapKod))
                query = query.Where(b => b.BnhHesapKod == hesapKod);

            var liste = await query
                .OrderByDescending(b => b.BnhTarih)
                .ThenByDescending(b => b.Id)
                .Take(500)
                .Select(b => new BankaHareketDto
                {
                    Id = b.Id,
                    RecGuid = b.RecGuid,
                    HesapKod = b.BnhHesapKod,
                    Tarih = b.BnhTarih,
                    Tip = b.BnhTip,
                    EvrakSeri = b.BnhEvrakSeri,
                    EvrakSira = b.BnhEvrakSira,
                    BelgeNo = b.BnhBelgeNo,
                    Tutar = b.BnhTutar,
                    DovizCinsi = b.BnhDovizCinsi,
                    DovizKuru = b.BnhDovizKuru,
                    CariKod = b.BnhCariKod,
                    HareketCinsi = b.BnhHareketCinsi,
                    Aciklama1 = b.BnhAciklama1,
                    Aciklama2 = b.BnhAciklama2,
                    Giren = b.BnhTip == 0 ? b.BnhTutar : 0,
                    Cikan = b.BnhTip == 1 ? b.BnhTutar : 0
                })
                .ToListAsync();

            var toplamGiren = liste.Sum(x => x.Giren);
            var toplamCikan = liste.Sum(x => x.Cikan);

            return Ok(new { Hareketler = liste, ToplamGiren = toplamGiren, ToplamCikan = toplamCikan, Bakiye = toplamGiren - toplamCikan });
        }
        catch (Exception ex)
        {
            return Error($"Banka hareketleri hatasi: {ex.Message}");
        }
    }

    /// <summary>POST api/finans/banka/hareket - Banka hareketi kaydet</summary>
    [HttpPost("banka/hareket")]
    public async Task<IActionResult> BankaHareketKaydet([FromBody] BankaHareketKaydetDto dto)
    {
        try
        {
            if (dto == null) return Error("Veri bos!");
            if (dto.Tutar <= 0) return Error("Tutar sifirdan buyuk olmalidir!");
            if (string.IsNullOrWhiteSpace(dto.HesapKod)) return Error("Hesap kodu bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();

            var hareket = new PineBankaHareketleri
            {
                RecGuid = Guid.NewGuid(),
                BnhHesapKod = dto.HesapKod,
                BnhTarih = dto.Tarih ?? DateTime.Today,
                BnhTip = dto.Tip, // 0=Giris, 1=Cikis
                BnhTutar = dto.Tutar,
                BnhDovizCinsi = dto.DovizCinsi ?? "TL",
                BnhDovizKuru = dto.DovizKuru > 0 ? dto.DovizKuru : 1,
                BnhCariKod = dto.CariKod,
                BnhHareketCinsi = dto.HareketCinsi,
                BnhBelgeNo = dto.BelgeNo,
                BnhAciklama1 = dto.Aciklama1,
                BnhAciklama2 = dto.Aciklama2,
                RecCreateDate = DateTime.Now,
                RecCreateUser = dto.Kullanici ?? "System"
            };

            db.BankaHareketleri.Add(hareket);
            await db.SaveChangesAsync();

            return Ok(new { hareket.Id }, "Banka hareketi basariyla kaydedildi");
        }
        catch (Exception ex)
        {
            return Error($"Banka hareketi kayit hatasi: {ex.Message}");
        }
    }

    // ═════════════════════════════════════════════════════════════
    //  CEK / SENET
    // ═════════════════════════════════════════════════════════════

    /// <summary>GET api/finans/ceksenet?tip=&cins=&baslangic=&bitis=</summary>
    [HttpGet("ceksenet")]
    public async Task<IActionResult> CekSenetListesi(
        [FromQuery] char? tip = null,
        [FromQuery] char? cins = null,
        [FromQuery] string? baslangic = null,
        [FromQuery] string? bitis = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();

            var basTarih = string.IsNullOrEmpty(baslangic) ? DateTime.Today.AddDays(-90) : DateTime.Parse(baslangic);
            var bitTarih = string.IsNullOrEmpty(bitis) ? DateTime.Today : DateTime.Parse(bitis);

            var query = db.CekSenetHareketleri.AsNoTracking()
                .Where(c => !c.RecIptal && !c.RecGizli
                    && c.CshTarih >= basTarih && c.CshTarih <= bitTarih);

            if (tip.HasValue)
                query = query.Where(c => c.CshTip == tip.Value);
            if (cins.HasValue)
                query = query.Where(c => c.CshCins == cins.Value);

            var liste = await query
                .OrderByDescending(c => c.CshTarih)
                .Take(500)
                .ToListAsync();

            return Ok(liste);
        }
        catch (Exception ex)
        {
            return Error($"Cek/Senet listesi hatasi: {ex.Message}");
        }
    }

    /// <summary>POST api/finans/ceksenet - Yeni cek/senet kaydi</summary>
    [HttpPost("ceksenet")]
    public async Task<IActionResult> CekSenetEkle([FromBody] PineCekSenetHareketleri cekSenet)
    {
        try
        {
            if (cekSenet == null) return Error("Veri bos!");
            if (cekSenet.CshTutar <= 0) return Error("Tutar sifirdan buyuk olmalidir!");

            using var db = await _factory.CreateDbContextAsync();

            cekSenet.RecGuid = Guid.NewGuid();
            cekSenet.RecCreateDate = DateTime.Now;

            if (string.IsNullOrEmpty(cekSenet.CshDurumu))
                cekSenet.CshDurumu = "Portfoyde";

            db.CekSenetHareketleri.Add(cekSenet);
            await db.SaveChangesAsync();

            return Ok(new { cekSenet.Id }, "Cek/Senet basariyla kaydedildi");
        }
        catch (Exception ex)
        {
            return Error($"Cek/Senet kayit hatasi: {ex.Message}");
        }
    }

    /// <summary>PUT api/finans/ceksenet/{id}/durum - Cek/Senet durum guncelle</summary>
    [HttpPut("ceksenet/{id:int}/durum")]
    public async Task<IActionResult> CekSenetDurumGuncelle(int id, [FromBody] CekSenetDurumDto dto)
    {
        try
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.YeniDurum))
                return Error("Yeni durum bos olamaz!");

            using var db = await _factory.CreateDbContextAsync();

            var kayit = await db.CekSenetHareketleri.FirstOrDefaultAsync(c => c.Id == id);
            if (kayit == null) return Error("Kayit bulunamadi", 404);

            var eskiDurum = kayit.CshDurumu;
            kayit.CshDurumu = dto.YeniDurum;
            kayit.RecLastupDate = DateTime.Now;
            kayit.RecLastupUser = dto.Kullanici ?? "System";

            // Ciro bilgileri
            if (dto.YeniDurum == "Ciroya" && !string.IsNullOrEmpty(dto.CiroCariKod))
            {
                kayit.CshCiroCariKod = dto.CiroCariKod;
                kayit.CshCiroTarih = DateTime.Now;
            }

            // Banka hesabina tahsil
            if (dto.YeniDurum == "TahsilEdildi" && !string.IsNullOrEmpty(dto.BankaHesapKod))
            {
                kayit.CshBankaHesapKod = dto.BankaHesapKod;
            }

            await db.SaveChangesAsync();

            return OkMessage($"Durum guncellendi: {eskiDurum} -> {dto.YeniDurum}");
        }
        catch (Exception ex)
        {
            return Error($"Durum guncelleme hatasi: {ex.Message}");
        }
    }
}

// ═════════════════════════════════════════════════════════════
// Finans DTOs
// ═════════════════════════════════════════════════════════════

public class KasaHareketDto
{
    public int Id { get; set; }
    public Guid RecGuid { get; set; }
    public string KasaKod { get; set; } = "";
    public DateTime Tarih { get; set; }
    public int Tip { get; set; }
    public string? EvrakSeri { get; set; }
    public int EvrakSira { get; set; }
    public string? BelgeNo { get; set; }
    public decimal Tutar { get; set; }
    public string? DovizCinsi { get; set; }
    public decimal DovizKuru { get; set; }
    public string? CariKod { get; set; }
    public int HareketCinsi { get; set; }
    public string? Aciklama1 { get; set; }
    public string? Aciklama2 { get; set; }
    public decimal Giris { get; set; }
    public decimal Cikis { get; set; }
}

public class KasaHareketKaydetDto
{
    public string KasaKod { get; set; } = "";
    public DateTime? Tarih { get; set; }
    /// <summary>0=Giris, 1=Cikis</summary>
    public int Tip { get; set; }
    public decimal Tutar { get; set; }
    public string? DovizCinsi { get; set; }
    public decimal DovizKuru { get; set; }
    public string? CariKod { get; set; }
    /// <summary>0=Nakit, 1=Virman, 2=Tahsilat, 3=Odeme</summary>
    public int HareketCinsi { get; set; }
    public string? BelgeNo { get; set; }
    public string? Aciklama1 { get; set; }
    public string? Aciklama2 { get; set; }
    public string? Kullanici { get; set; }
}

public class BankaHareketDto
{
    public int Id { get; set; }
    public Guid RecGuid { get; set; }
    public string HesapKod { get; set; } = "";
    public DateTime Tarih { get; set; }
    public int Tip { get; set; }
    public string? EvrakSeri { get; set; }
    public int EvrakSira { get; set; }
    public string? BelgeNo { get; set; }
    public decimal Tutar { get; set; }
    public string? DovizCinsi { get; set; }
    public decimal DovizKuru { get; set; }
    public string? CariKod { get; set; }
    public int HareketCinsi { get; set; }
    public string? Aciklama1 { get; set; }
    public string? Aciklama2 { get; set; }
    public decimal Giren { get; set; }
    public decimal Cikan { get; set; }
}

public class BankaHareketKaydetDto
{
    public string HesapKod { get; set; } = "";
    public DateTime? Tarih { get; set; }
    /// <summary>0=Giris, 1=Cikis</summary>
    public int Tip { get; set; }
    public decimal Tutar { get; set; }
    public string? DovizCinsi { get; set; }
    public decimal DovizKuru { get; set; }
    public string? CariKod { get; set; }
    /// <summary>0=Havale, 1=EFT, 2=Virman, 3=Tahsilat, 4=Odeme</summary>
    public int HareketCinsi { get; set; }
    public string? BelgeNo { get; set; }
    public string? Aciklama1 { get; set; }
    public string? Aciklama2 { get; set; }
    public string? Kullanici { get; set; }
}

public class CekSenetDurumDto
{
    /// <summary>Portfoyde, Tahsile, Teminata, Ciroya, TahsilEdildi, Karsilansiz</summary>
    public string YeniDurum { get; set; } = "";
    public string? CiroCariKod { get; set; }
    public string? BankaHesapKod { get; set; }
    public string? Kullanici { get; set; }
}
