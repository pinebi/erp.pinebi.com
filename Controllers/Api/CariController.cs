using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Cari;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Cari hesap islemleri API controller'i.
/// Musteri/tedarikci hesap yonetimi, adres, yetkili, gorusme ve grup islemleri.
/// </summary>
[Route("api/cari")]
public class CariController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;

    public CariController(IDbContextFactory<PineErpContext> factory)
    {
        _factory = factory;
    }

    // ================================================================
    // HESAPLAR
    // ================================================================

    /// <summary>Cari hesap listesi (sayfalamali)</summary>
    [HttpGet("hesaplar")]
    public async Task<IActionResult> GetHesaplar(
        [FromQuery] int sayfa = 1,
        [FromQuery] int boyut = 50,
        [FromQuery] string? arama = null,
        [FromQuery] int? tip = null,
        [FromQuery] string? grup = null)
    {
        using var db = await _factory.CreateDbContextAsync();

        var query = db.CariHesaplar.AsNoTracking()
            .Where(c => !c.RecGizli && !c.RecIptal);

        // Tip filtresi
        if (tip.HasValue)
            query = query.Where(c => c.CarTipi == tip.Value);

        // Grup filtresi
        if (!string.IsNullOrWhiteSpace(grup))
            query = query.Where(c => c.CarGrupKodu == grup);

        // Arama filtresi
        if (!string.IsNullOrWhiteSpace(arama))
        {
            query = query.Where(c =>
                EF.Functions.Collate(c.CarKod, "Latin1_General_CI_AI").Contains(arama) ||
                (c.CarUnvan1 != null && EF.Functions.Collate(c.CarUnvan1, "Latin1_General_CI_AI").Contains(arama)) ||
                (c.CarVergiNo != null && c.CarVergiNo.Contains(arama)) ||
                (c.CarTel1 != null && c.CarTel1.Contains(arama)) ||
                (c.CarEmail != null && EF.Functions.Collate(c.CarEmail, "Latin1_General_CI_AI").Contains(arama)));
        }

        var toplam = await query.CountAsync();

        var data = await query
            .OrderBy(c => c.CarKod)
            .Skip((sayfa - 1) * boyut)
            .Take(boyut)
            .ToListAsync();

        return OkPaged(data, toplam, sayfa, boyut);
    }

    /// <summary>Cari arama (Fatura formu icin)</summary>
    [HttpGet("ara")]
    public async Task<IActionResult> CariAra([FromQuery] string? q = null, [FromQuery] int limit = 50, [FromQuery] string? alan = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.CariHesaplar.AsNoTracking()
            .Where(c => !c.RecGizli && !c.RecIptal);

        if (!string.IsNullOrWhiteSpace(q))
        {
            var kapsam = (alan ?? "hepsi").ToLowerInvariant();
            if (kapsam == "isim")
            {
                query = query.Where(c =>
                    c.CarUnvan1 != null && EF.Functions.Collate(c.CarUnvan1, "Latin1_General_CI_AI").Contains(q));
            }
            else if (kapsam == "kod")
            {
                query = query.Where(c =>
                    EF.Functions.Collate(c.CarKod, "Latin1_General_CI_AI").Contains(q) ||
                    (c.CarVergiNo != null && c.CarVergiNo.Contains(q)));
            }
            else
            {
                query = query.Where(c =>
                    EF.Functions.Collate(c.CarKod, "Latin1_General_CI_AI").Contains(q) ||
                    (c.CarUnvan1 != null && EF.Functions.Collate(c.CarUnvan1, "Latin1_General_CI_AI").Contains(q)) ||
                    (c.CarVergiNo != null && c.CarVergiNo.Contains(q)));
            }
        }

        var data = await query
            .OrderBy(c => c.CarKod)
            .Take(limit)
            .Select(c => new { Id = c.Id, CarKod = c.CarKod, CarUnvan = c.CarUnvan1 ?? "", CarVergiNo = c.CarVergiNo })
            .ToListAsync();

        return Ok(data);
    }

    /// <summary>Tek cari hesap (ID ile)</summary>
    [HttpGet("hesap/{id:int}")]
    public async Task<IActionResult> GetHesap(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var hesap = await db.CariHesaplar.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id && !c.RecGizli);

        if (hesap == null)
            return Error("Cari hesap bulunamadi", 404);

        return Ok(hesap);
    }

    /// <summary>Tek cari hesap (Kod ile)</summary>
    [HttpGet("hesap/kod/{kod}")]
    public async Task<IActionResult> GetHesapByKod(string kod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var hesap = await db.CariHesaplar.AsNoTracking()
            .FirstOrDefaultAsync(c => c.CarKod == kod && !c.RecGizli);

        if (hesap == null)
            return Error("Cari hesap bulunamadi", 404);

        return Ok(hesap);
    }

    /// <summary>Yeni cari hesap olustur</summary>
    [HttpPost("hesap")]
    public async Task<IActionResult> CreateHesap([FromBody] PineCariHesaplar model)
    {
        if (string.IsNullOrWhiteSpace(model.CarKod))
            return Error("Cari kodu bos olamaz");

        using var db = await _factory.CreateDbContextAsync();

        // Kod tekrar kontrolu
        var exists = await db.CariHesaplar
            .AnyAsync(c => c.CarKod == model.CarKod && !c.RecGizli);
        if (exists)
            return Error("Bu cari kodu zaten kullaniliyor");

        model.Id = 0;
        model.RecGuid = Guid.NewGuid();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = "web";
        model.RecGizli = false;
        model.RecIptal = false;

        db.CariHesaplar.Add(model);
        await db.SaveChangesAsync();

        return Ok(model, "Cari hesap olusturuldu");
    }

    /// <summary>Cari hesap guncelle</summary>
    [HttpPut("hesap/{id:int}")]
    public async Task<IActionResult> UpdateHesap(int id, [FromBody] PineCariHesaplar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.CariHesaplar.FindAsync(id);

        if (existing == null || existing.RecGizli)
            return Error("Cari hesap bulunamadi", 404);

        if (existing.RecKilitli)
            return Error("Bu kayit kilitli, duzenlenemez");

        // Kod degismisse tekrar kontrolu
        if (model.CarKod != existing.CarKod)
        {
            var kodExists = await db.CariHesaplar
                .AnyAsync(c => c.CarKod == model.CarKod && c.Id != id && !c.RecGizli);
            if (kodExists)
                return Error("Bu cari kodu zaten kullaniliyor");
        }

        // Alan guncelleme
        existing.CarKod = model.CarKod;
        existing.CarUnvan1 = model.CarUnvan1;
        existing.CarUnvan2 = model.CarUnvan2;
        existing.CarKisaIsim = model.CarKisaIsim;
        existing.CarTipi = model.CarTipi;
        existing.CarHareketTipi = model.CarHareketTipi;
        existing.CarBaglantiTipi = model.CarBaglantiTipi;
        existing.CarGrupKodu = model.CarGrupKodu;
        existing.CarSektorKodu = model.CarSektorKodu;
        existing.CarBolgeKodu = model.CarBolgeKodu;
        existing.CarPlasiyerKodu = model.CarPlasiyerKodu;
        existing.CarFiyatGrubu = model.CarFiyatGrubu;
        existing.CarIskontoOrani = model.CarIskontoOrani;
        existing.CarVadeSuresi = model.CarVadeSuresi;
        existing.CarRiskLimiti = model.CarRiskLimiti;
        existing.CarParaBirimi = model.CarParaBirimi;
        existing.CarOdemeSekli = model.CarOdemeSekli;
        existing.CarVergiDairesi = model.CarVergiDairesi;
        existing.CarVergiNo = model.CarVergiNo;
        existing.CarTcKimlik = model.CarTcKimlik;
        existing.CarMersisNo = model.CarMersisNo;
        existing.CarKepAdresi = model.CarKepAdresi;
        existing.CarNaceKodu = model.CarNaceKodu;
        existing.CarAdres1 = model.CarAdres1;
        existing.CarAdres2 = model.CarAdres2;
        existing.CarPostaKodu = model.CarPostaKodu;
        existing.CarUlkeKodu = model.CarUlkeKodu;
        existing.CarSehirKodu = model.CarSehirKodu;
        existing.CarIlceKodu = model.CarIlceKodu;
        existing.CarTel1 = model.CarTel1;
        existing.CarTel2 = model.CarTel2;
        existing.CarFaks = model.CarFaks;
        existing.CarGsm = model.CarGsm;
        existing.CarEmail = model.CarEmail;
        existing.CarWeb = model.CarWeb;
        existing.CarBanka1Adi = model.CarBanka1Adi;
        existing.CarBanka1Sube = model.CarBanka1Sube;
        existing.CarBanka1Hesap = model.CarBanka1Hesap;
        existing.CarBanka1Iban = model.CarBanka1Iban;
        existing.CarBanka1Swift = model.CarBanka1Swift;
        existing.CarBanka2Adi = model.CarBanka2Adi;
        existing.CarBanka2Sube = model.CarBanka2Sube;
        existing.CarBanka2Hesap = model.CarBanka2Hesap;
        existing.CarBanka2Iban = model.CarBanka2Iban;
        existing.CarBanka2Swift = model.CarBanka2Swift;
        existing.CarBanka3Adi = model.CarBanka3Adi;
        existing.CarBanka3Sube = model.CarBanka3Sube;
        existing.CarBanka3Hesap = model.CarBanka3Hesap;
        existing.CarBanka3Iban = model.CarBanka3Iban;
        existing.CarBanka3Swift = model.CarBanka3Swift;
        existing.CarEfaturaFl = model.CarEfaturaFl;
        existing.CarEirsaliyeFl = model.CarEirsaliyeFl;
        existing.CarEfaturaUrnMail = model.CarEfaturaUrnMail;
        existing.CarEirsaliyeUrnMail = model.CarEirsaliyeUrnMail;
        existing.CarSahisSirketi = model.CarSahisSirketi;
        existing.CarYurtDisi = model.CarYurtDisi;
        existing.CarPasifFl = model.CarPasifFl;
        existing.CarAciklama = model.CarAciklama;
        existing.CarNot1 = model.CarNot1;
        existing.CarNot2 = model.CarNot2;
        existing.CarOzelkod1 = model.CarOzelkod1;
        existing.CarOzelkod2 = model.CarOzelkod2;
        existing.CarOzelkod3 = model.CarOzelkod3;
        existing.CarOzelkod4 = model.CarOzelkod4;
        existing.CarOzelkod5 = model.CarOzelkod5;
        existing.CarLatitude = model.CarLatitude;
        existing.CarLongitude = model.CarLongitude;

        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = "web";

        await db.SaveChangesAsync();
        return Ok(existing, "Cari hesap guncellendi");
    }

    /// <summary>Cari hesap sil (soft delete)</summary>
    [HttpDelete("hesap/{id:int}")]
    public async Task<IActionResult> DeleteHesap(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.CariHesaplar.FindAsync(id);

        if (existing == null || existing.RecGizli)
            return Error("Cari hesap bulunamadi", 404);

        if (existing.RecKilitli)
            return Error("Bu kayit kilitli, silinemez");

        existing.RecGizli = true;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = "web";

        await db.SaveChangesAsync();
        return OkMessage("Cari hesap silindi");
    }

    // ================================================================
    // HAREKETLER
    // ================================================================

    /// <summary>Cari hesap hareketleri listesi</summary>
    [HttpGet("hareketler")]
    public async Task<IActionResult> GetHareketler(
        [FromQuery] string? cariKod = null,
        [FromQuery] DateTime? baslangic = null,
        [FromQuery] DateTime? bitis = null)
    {
        using var db = await _factory.CreateDbContextAsync();

        var query = db.CariHesapHareketleri.AsNoTracking()
            .Where(h => !h.RecGizli && !h.RecIptal);

        if (!string.IsNullOrWhiteSpace(cariKod))
            query = query.Where(h => h.ChaCariKod == cariKod);

        if (baslangic.HasValue)
            query = query.Where(h => h.ChaTarih >= baslangic.Value);

        if (bitis.HasValue)
            query = query.Where(h => h.ChaTarih <= bitis.Value);

        var data = await query
            .OrderByDescending(h => h.ChaTarih)
            .ThenByDescending(h => h.Id)
            .Take(500)
            .ToListAsync();

        return Ok(data);
    }

    // ================================================================
    // ADRESLER
    // ================================================================

    /// <summary>Cari hesaba ait adresler</summary>
    [HttpGet("adresler/{cariId:int}")]
    public async Task<IActionResult> GetAdresler(int cariId)
    {
        using var db = await _factory.CreateDbContextAsync();

        // Oncelikle cari hesabin kodunu bul
        var cari = await db.CariHesaplar.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == cariId && !c.RecGizli);
        if (cari == null)
            return Error("Cari hesap bulunamadi", 404);

        var data = await db.CariAdresler.AsNoTracking()
            .Where(a => a.CadCariKod == cari.CarKod && !a.RecGizli)
            .OrderBy(a => a.CadAdresTipi)
            .ThenBy(a => a.Id)
            .ToListAsync();

        return Ok(data);
    }

    /// <summary>Yeni adres olustur</summary>
    [HttpPost("adres")]
    public async Task<IActionResult> CreateAdres([FromBody] PineCariAdresler model)
    {
        if (string.IsNullOrWhiteSpace(model.CadCariKod))
            return Error("Cari kodu bos olamaz");

        using var db = await _factory.CreateDbContextAsync();

        model.Id = 0;
        model.RecGuid = Guid.NewGuid();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = "web";

        db.CariAdresler.Add(model);
        await db.SaveChangesAsync();

        return Ok(model, "Adres olusturuldu");
    }

    /// <summary>Adres guncelle</summary>
    [HttpPut("adres/{id:int}")]
    public async Task<IActionResult> UpdateAdres(int id, [FromBody] PineCariAdresler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.CariAdresler.FindAsync(id);

        if (existing == null || existing.RecGizli)
            return Error("Adres bulunamadi", 404);

        existing.CadAdresTipi = model.CadAdresTipi;
        existing.CadAdresBasligi = model.CadAdresBasligi;
        existing.CadAdres1 = model.CadAdres1;
        existing.CadAdres2 = model.CadAdres2;
        existing.CadPostaKodu = model.CadPostaKodu;
        existing.CadUlkeKodu = model.CadUlkeKodu;
        existing.CadSehirKodu = model.CadSehirKodu;
        existing.CadIlceKodu = model.CadIlceKodu;
        existing.CadSehirAdi = model.CadSehirAdi;
        existing.CadIlceAdi = model.CadIlceAdi;
        existing.CadTel = model.CadTel;
        existing.CadFaks = model.CadFaks;
        existing.CadYetkili = model.CadYetkili;
        existing.CadVarsayilanFl = model.CadVarsayilanFl;
        existing.CadAciklama = model.CadAciklama;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = "web";

        await db.SaveChangesAsync();
        return Ok(existing, "Adres guncellendi");
    }

    /// <summary>Adres sil (soft delete)</summary>
    [HttpDelete("adres/{id:int}")]
    public async Task<IActionResult> DeleteAdres(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.CariAdresler.FindAsync(id);

        if (existing == null || existing.RecGizli)
            return Error("Adres bulunamadi", 404);

        existing.RecGizli = true;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = "web";

        await db.SaveChangesAsync();
        return OkMessage("Adres silindi");
    }

    // ================================================================
    // YETKILILER
    // ================================================================

    /// <summary>Cari hesaba ait yetkililer</summary>
    [HttpGet("yetkililer/{cariId:int}")]
    public async Task<IActionResult> GetYetkililer(int cariId)
    {
        using var db = await _factory.CreateDbContextAsync();

        var cari = await db.CariHesaplar.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == cariId && !c.RecGizli);
        if (cari == null)
            return Error("Cari hesap bulunamadi", 404);

        var data = await db.CariYetkililer.AsNoTracking()
            .Where(y => y.CayCariKod == cari.CarKod && !y.RecGizli)
            .OrderBy(y => y.Id)
            .ToListAsync();

        return Ok(data);
    }

    /// <summary>Yeni yetkili olustur</summary>
    [HttpPost("yetkili")]
    public async Task<IActionResult> CreateYetkili([FromBody] PineCariYetkililer model)
    {
        if (string.IsNullOrWhiteSpace(model.CayCariKod))
            return Error("Cari kodu bos olamaz");

        using var db = await _factory.CreateDbContextAsync();

        model.Id = 0;
        model.RecGuid = Guid.NewGuid();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = "web";

        db.CariYetkililer.Add(model);
        await db.SaveChangesAsync();

        return Ok(model, "Yetkili olusturuldu");
    }

    [HttpDelete("yetkili/{id:int}")]
    public async Task<IActionResult> DeleteYetkili(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var y = await db.CariYetkililer.FirstOrDefaultAsync(x => x.Id == id);
        if (y == null) return Error("Yetkili bulunamadi", 404);
        y.RecIptal = true;
        y.RecLastupDate = DateTime.Now;
        await db.SaveChangesAsync();
        return Ok(true, "Yetkili silindi");
    }

    // ================================================================
    // GORUSMELER
    // ================================================================

    /// <summary>Cari hesaba ait gorusmeler</summary>
    [HttpGet("gorusmeler/{cariId:int}")]
    public async Task<IActionResult> GetGorusmeler(int cariId)
    {
        using var db = await _factory.CreateDbContextAsync();

        var cari = await db.CariHesaplar.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == cariId && !c.RecGizli);
        if (cari == null)
            return Error("Cari hesap bulunamadi", 404);

        var data = await db.CariGorusmeler.AsNoTracking()
            .Where(g => g.CagCariKod == cari.CarKod && !g.RecGizli)
            .OrderByDescending(g => g.CagTarih)
            .ToListAsync();

        return Ok(data);
    }

    /// <summary>Yeni gorusme olustur</summary>
    [HttpPost("gorusme")]
    public async Task<IActionResult> CreateGorusme([FromBody] PineCariGorusmeler model)
    {
        if (string.IsNullOrWhiteSpace(model.CagCariKod))
            return Error("Cari kodu bos olamaz");

        using var db = await _factory.CreateDbContextAsync();

        model.Id = 0;
        model.RecGuid = Guid.NewGuid();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = "web";

        db.CariGorusmeler.Add(model);
        await db.SaveChangesAsync();

        return Ok(model, "Gorusme olusturuldu");
    }

    // ================================================================
    // GRUPLAR
    // ================================================================

    /// <summary>Cari grup listesi</summary>
    [HttpGet("gruplar")]
    public async Task<IActionResult> GetGruplar()
    {
        using var db = await _factory.CreateDbContextAsync();

        var data = await db.CariGruplari.AsNoTracking()
            .Where(g => !g.RecGizli && !g.CgrPasifFl)
            .OrderBy(g => g.CgrSiraNo)
            .ThenBy(g => g.CgrKod)
            .ToListAsync();

        return Ok(data);
    }

    /// <summary>Yeni cari grup olustur</summary>
    [HttpPost("grup")]
    public async Task<IActionResult> CreateGrup([FromBody] PineCariGruplari model)
    {
        if (string.IsNullOrWhiteSpace(model.CgrKod))
            return Error("Grup kodu bos olamaz");

        using var db = await _factory.CreateDbContextAsync();

        var exists = await db.CariGruplari
            .AnyAsync(g => g.CgrKod == model.CgrKod && !g.RecGizli);
        if (exists)
            return Error("Bu grup kodu zaten kullaniliyor");

        model.Id = 0;
        model.RecGuid = Guid.NewGuid();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = "web";

        db.CariGruplari.Add(model);
        await db.SaveChangesAsync();

        return Ok(model, "Cari grup olusturuldu");
    }
}
