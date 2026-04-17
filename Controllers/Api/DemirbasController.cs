using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/demirbas")]
public class DemirbasController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public DemirbasController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    // ===== DEMIRBAS KARTLARI =====

    [HttpGet("kartlar")]
    public async Task<IActionResult> GetKartlar(int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Demirbaslar.AsNoTracking().Where(d => !d.RecGizli);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(d =>
                (d.DmrKod != null && EF.Functions.Collate(d.DmrKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (d.DmrIsim != null && EF.Functions.Collate(d.DmrIsim, "Latin1_General_CI_AI").Contains(ara)) ||
                (d.DmrSeriNo != null && d.DmrSeriNo.Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderBy(d => d.DmrIsim)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("kart/{id}")]
    public async Task<IActionResult> GetKart(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Demirbaslar.AsNoTracking().FirstOrDefaultAsync(d => d.Id == id);
        if (item == null) return Error("Demirbas bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("kart")]
    public async Task<IActionResult> PostKart([FromBody] PineDemirbaslar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Demirbaslar.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Demirbas kaydedildi");
    }

    [HttpPut("kart/{id}")]
    public async Task<IActionResult> PutKart(int id, [FromBody] PineDemirbaslar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Demirbaslar.FindAsync(id);
        if (existing == null) return Error("Demirbas bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Demirbas guncellendi");
    }

    [HttpDelete("kart/{id}")]
    public async Task<IActionResult> DeleteKart(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Demirbaslar.FindAsync(id);
        if (existing == null) return Error("Demirbas bulunamadi", 404);

        existing.RecGizli = true;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return OkMessage("Demirbas silindi");
    }

    // ===== HAREKETLER =====

    [HttpGet("hareketler/{demirbasKod}")]
    public async Task<IActionResult> GetHareketler(string demirbasKod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.DemirbasHareketleri.AsNoTracking()
            .Where(h => h.DhkDemirbasKod == demirbasKod && !h.RecGizli)
            .OrderByDescending(h => h.DhkTarih)
            .ToListAsync();
        return Ok(list);
    }

    [HttpPost("hareket")]
    public async Task<IActionResult> PostHareket([FromBody] PineDemirbasHareketleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.DemirbasHareketleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Hareket kaydedildi");
    }

    // ===== ZIMMETLER =====

    [HttpGet("zimmetler")]
    public async Task<IActionResult> GetZimmetler(int sayfa = 1, int sayfaBoyutu = 50)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.ZimmetFormlari.AsNoTracking().Where(z => !z.RecGizli);
        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(z => z.ZmfTarih)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();
        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpPost("zimmet")]
    public async Task<IActionResult> PostZimmet([FromBody] PineZimmetFormlari model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.ZimmetFormlari.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Zimmet kaydedildi");
    }
}
