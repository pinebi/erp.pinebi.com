using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Irsaliye;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/irsaliye")]
public class IrsaliyeController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public IrsaliyeController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    [HttpGet("liste")]
    public async Task<IActionResult> GetListe(string? tip = null, int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Irsaliyeler.AsNoTracking().Where(i => !i.RecGizli);

        if (tip == "satis") query = query.Where(i => i.IrsTip == 1);
        else if (tip == "satinalma") query = query.Where(i => i.IrsTip == 3);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(i =>
                (i.IrsCariUnvan != null && EF.Functions.Collate(i.IrsCariUnvan, "Latin1_General_CI_AI").Contains(ara)) ||
                (EF.Functions.Collate(i.IrsCariKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (i.IrsBelgeNo != null && i.IrsBelgeNo.Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(i => i.IrsTarih)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Irsaliyeler.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        if (item == null) return Error("Irsaliye bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("")]
    public async Task<IActionResult> Post([FromBody] PineIrsaliyeler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Irsaliyeler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Irsaliye kaydedildi");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] PineIrsaliyeler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Irsaliyeler.FindAsync(id);
        if (existing == null) return Error("Irsaliye bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Irsaliye guncellendi");
    }

    [HttpGet("satirlar/{irsaliyeId}")]
    public async Task<IActionResult> GetSatirlar(int irsaliyeId)
    {
        using var db = await _factory.CreateDbContextAsync();
        // Irsaliye satirlari uid bazli baglanti kullanir, once irsaliyenin uid'sini bulalim
        var irsaliye = await db.Irsaliyeler.AsNoTracking().FirstOrDefaultAsync(i => i.Id == irsaliyeId);
        if (irsaliye == null) return Error("Irsaliye bulunamadi", 404);

        var list = await db.IrsaliyeSatirlari.AsNoTracking()
            .Where(s => s.IstIrsaliyeUid == irsaliye.RecGuid && !s.RecGizli)
            .OrderBy(s => s.IstSatirNo)
            .ToListAsync();
        return Ok(list);
    }
}
