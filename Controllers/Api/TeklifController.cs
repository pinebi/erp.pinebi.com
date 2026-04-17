using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Teklif;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/teklif")]
public class TeklifController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public TeklifController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    [HttpGet("liste")]
    public async Task<IActionResult> GetListe(string? tip = null, int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Teklifler.AsNoTracking().Where(t => !t.RecGizli);

        if (tip == "verilen") query = query.Where(t => t.TekTeklifTipi == 0);
        else if (tip == "alinan") query = query.Where(t => t.TekTeklifTipi == 1);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(t =>
                (t.TekCariUnvan != null && EF.Functions.Collate(t.TekCariUnvan, "Latin1_General_CI_AI").Contains(ara)) ||
                (EF.Functions.Collate(t.TekCariKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (t.TekBelgeNo != null && t.TekBelgeNo.Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(t => t.TekTarih)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Teklifler.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
        if (item == null) return Error("Teklif bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("")]
    public async Task<IActionResult> Post([FromBody] PineTeklifler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Teklifler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Teklif kaydedildi");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] PineTeklifler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Teklifler.FindAsync(id);
        if (existing == null) return Error("Teklif bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Teklif guncellendi");
    }

    [HttpGet("satirlar/{teklifId}")]
    public async Task<IActionResult> GetSatirlar(int teklifId)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.TeklifSatirlari.AsNoTracking()
            .Where(s => s.TksTeklifId == teklifId && !s.RecGizli)
            .OrderBy(s => s.TksSatirNo)
            .ToListAsync();
        return Ok(list);
    }
}
