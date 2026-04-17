using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/uretim")]
public class UretimController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public UretimController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    // ===== RECETELER =====

    [HttpGet("receteler")]
    public async Task<IActionResult> GetReceteler(int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.UrunReceteleri.AsNoTracking().Where(r => !r.RecGizli);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(r =>
                (r.UrcStokKod != null && EF.Functions.Collate(r.UrcStokKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (r.UrcIsim != null && EF.Functions.Collate(r.UrcIsim, "Latin1_General_CI_AI").Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderBy(r => r.UrcStokKod)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpPost("recete")]
    public async Task<IActionResult> PostRecete([FromBody] PineUrunReceteleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.UrunReceteleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Recete kaydedildi");
    }

    // ===== IS EMIRLERI =====

    [HttpGet("isemirleri")]
    public async Task<IActionResult> GetIsEmirleri(int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.IsEmirleri.AsNoTracking().Where(i => !i.RecGizli);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(i =>
                (i.IseNo != null && i.IseNo.Contains(ara)) ||
                (i.IseStokKod != null && EF.Functions.Collate(i.IseStokKod, "Latin1_General_CI_AI").Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(i => i.IseTarih)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpPost("isemri")]
    public async Task<IActionResult> PostIsEmri([FromBody] PineIsEmirleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.IsEmirleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Is emri kaydedildi");
    }

    // ===== OPERASYONLAR =====

    [HttpGet("operasyonlar")]
    public async Task<IActionResult> GetOperasyonlar(int sayfa = 1, int sayfaBoyutu = 50)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.UretimOperasyonlari.AsNoTracking().Where(o => !o.RecGizli);

        var toplam = await query.CountAsync();
        var list = await query
            .OrderBy(o => o.UopIsim)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpPost("operasyon")]
    public async Task<IActionResult> PostOperasyon([FromBody] PineUretimOperasyonlari model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.UretimOperasyonlari.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Operasyon kaydedildi");
    }
}
