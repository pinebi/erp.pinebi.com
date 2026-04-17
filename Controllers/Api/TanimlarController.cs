using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP;
using MACHINEBISS_Web.Models.PineERP.Tanimlar;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/tanimlar")]
public class TanimlarController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public TanimlarController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    // ===== BIRIMLER =====

    [HttpGet("birimler")]
    public async Task<IActionResult> GetBirimler()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Birimler.AsNoTracking().Where(b => !b.RecGizli).OrderBy(b => b.BirIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("birim")]
    public async Task<IActionResult> PostBirim([FromBody] PineBirimler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Birimler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Birim kaydedildi");
    }

    [HttpPut("birim/{id}")]
    public async Task<IActionResult> PutBirim(int id, [FromBody] PineBirimler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Birimler.FindAsync(id);
        if (existing == null) return Error("Birim bulunamadi", 404);
        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Birim guncellendi");
    }

    // ===== KDV ORANLARI =====

    [HttpGet("kdvoranlari")]
    public async Task<IActionResult> GetKdvOranlari()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.KdvOranlari.AsNoTracking().Where(k => !k.RecGizli).OrderBy(k => k.KdoOran).ToListAsync();
        return Ok(list);
    }

    [HttpPost("kdvorani")]
    public async Task<IActionResult> PostKdvOrani([FromBody] PineKdvOranlari model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.KdvOranlari.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "KDV orani kaydedildi");
    }

    // ===== VERGI DAIRELERI =====

    [HttpGet("vergidaireleri")]
    public async Task<IActionResult> GetVergiDaireleri()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.VergiDaireleri.AsNoTracking().Where(v => !v.RecGizli).OrderBy(v => v.VgdIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("vergidairesi")]
    public async Task<IActionResult> PostVergiDairesi([FromBody] PineVergiDaireleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.VergiDaireleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Vergi dairesi kaydedildi");
    }

    // ===== ULKELER =====

    [HttpGet("ulkeler")]
    public async Task<IActionResult> GetUlkeler()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Ulkeler.AsNoTracking().Where(u => !u.RecGizli).OrderBy(u => u.UlkIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("ulke")]
    public async Task<IActionResult> PostUlke([FromBody] PineUlkeler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Ulkeler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Ulke kaydedildi");
    }

    // ===== SEHIRLER =====

    [HttpGet("sehirler")]
    public async Task<IActionResult> GetSehirler(string? ulkeKodu = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Sehirler.AsNoTracking().Where(s => !s.RecGizli);
        if (!string.IsNullOrWhiteSpace(ulkeKodu))
            query = query.Where(s => s.SehUlkeKodu == ulkeKodu);
        var list = await query.OrderBy(s => s.SehIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("sehir")]
    public async Task<IActionResult> PostSehir([FromBody] PineSehirler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Sehirler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Sehir kaydedildi");
    }

    // ===== ILCELER =====

    [HttpGet("ilceler")]
    public async Task<IActionResult> GetIlceler(int? sehirId = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Ilceler.AsNoTracking().Where(i => !i.RecGizli);
        if (sehirId.HasValue)
            query = query.Where(i => i.IlcSehirId == sehirId.Value);
        var list = await query.OrderBy(i => i.IlcIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("ilce")]
    public async Task<IActionResult> PostIlce([FromBody] PineIlceler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Ilceler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Ilce kaydedildi");
    }

    // ===== BANKALAR =====

    [HttpGet("bankalar")]
    public async Task<IActionResult> GetBankalar()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Bankalar.AsNoTracking().Where(b => !b.RecGizli).OrderBy(b => b.BnkIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("banka")]
    public async Task<IActionResult> PostBanka([FromBody] PineBankalar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Bankalar.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Banka kaydedildi");
    }

    // ===== FIYAT GRUPLARI =====

    [HttpGet("fiyatgruplari")]
    public async Task<IActionResult> GetFiyatGruplari()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.FiyatGruplari.AsNoTracking().Where(f => !f.RecGizli).OrderBy(f => f.FgrGrupNo).ToListAsync();
        return Ok(list);
    }

    [HttpPost("fiyatgrubu")]
    public async Task<IActionResult> PostFiyatGrubu([FromBody] PineFiyatGruplari model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.FiyatGruplari.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Fiyat grubu kaydedildi");
    }

    [HttpPut("fiyatgrubu/{id}")]
    public async Task<IActionResult> PutFiyatGrubu(int id, [FromBody] PineFiyatGruplari model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.FiyatGruplari.FindAsync(id);
        if (existing == null) return Error("Fiyat grubu bulunamadi", 404);
        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Fiyat grubu guncellendi");
    }

    // ===== ODEME TIPLERI =====

    [HttpGet("odemetipleri")]
    public async Task<IActionResult> GetOdemeTipleri()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.OdemeTipleri.AsNoTracking().Where(o => !o.RecGizli).OrderBy(o => o.OdtIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("odemetipi")]
    public async Task<IActionResult> PostOdemeTipi([FromBody] PineOdemeTipleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.OdemeTipleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Odeme tipi kaydedildi");
    }

    // ===== OZEL KODLAR =====

    [HttpGet("ozelkodlar")]
    public async Task<IActionResult> GetOzelKodlar(int? tip = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.OzelKodlar.AsNoTracking().Where(o => !o.RecGizli);
        if (tip.HasValue)
            query = query.Where(o => o.OzkTip == tip.Value);
        var list = await query.OrderBy(o => o.OzkKod).ToListAsync();
        return Ok(list);
    }

    [HttpPost("ozelkod")]
    public async Task<IActionResult> PostOzelKod([FromBody] PineOzelKodlar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.OzelKodlar.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Ozel kod kaydedildi");
    }

    // ===== PLASIYERLER =====

    [HttpGet("plasiyerler")]
    public async Task<IActionResult> GetPlasiyerler()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Plasiyerler.AsNoTracking().Where(p => !p.RecGizli).OrderBy(p => p.PlsIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("plasiyer")]
    public async Task<IActionResult> PostPlasiyer([FromBody] PinePlasiyerler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Plasiyerler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Plasiyer kaydedildi");
    }

    [HttpPut("plasiyer/{id}")]
    public async Task<IActionResult> PutPlasiyer(int id, [FromBody] PinePlasiyerler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Plasiyerler.FindAsync(id);
        if (existing == null) return Error("Plasiyer bulunamadi", 404);
        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Plasiyer guncellendi");
    }

    // ===== SORUMLULUK MERKEZLERI =====

    [HttpGet("sorumlulukmerkezleri")]
    public async Task<IActionResult> GetSorumlulukMerkezleri()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.SorumlulukMerkezleri.AsNoTracking().Where(s => !s.RecGizli).OrderBy(s => s.SrmIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("sorumlulukmerkezi")]
    public async Task<IActionResult> PostSorumlulukMerkezi([FromBody] PineSorumlulukMerkezleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.SorumlulukMerkezleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Sorumluluk merkezi kaydedildi");
    }

    // ===== ILLER =====

    [HttpGet("iller")]
    public async Task<IActionResult> GetIller()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Iller.AsNoTracking().OrderBy(i => i.IlPlaka).ToListAsync();
        return Ok(list);
    }

    [HttpGet("iller/{plaka}/ilceler")]
    public async Task<IActionResult> GetIlceler(int plaka)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Ilceler.AsNoTracking().Where(i => i.IlcSehirId == plaka).OrderBy(i => i.IlcIsim).ToListAsync();
        return Ok(list);
    }

    [HttpPost("ililce/guncelle")]
    public async Task<IActionResult> IlIlceGuncelle([FromServices] MACHINEBISS_Web.Services.IlIlceService svc)
    {
        await svc.InternettenGuncelleAsync();
        return Ok(true, "Il/Ilce internetten guncellendi");
    }
}
