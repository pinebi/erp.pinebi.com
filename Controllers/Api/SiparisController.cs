using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Siparis;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/siparis")]
public class SiparisController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public SiparisController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    [HttpGet("liste")]
    public async Task<IActionResult> GetListe(string? tip = null, int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Siparisler.AsNoTracking().Where(s => !s.RecGizli);

        if (tip == "satis") query = query.Where(s => s.SipTip == 0);
        else if (tip == "satinalma") query = query.Where(s => s.SipTip == 1);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(s =>
                (s.SipCariUnvan != null && EF.Functions.Collate(s.SipCariUnvan, "Latin1_General_CI_AI").Contains(ara)) ||
                (EF.Functions.Collate(s.SipCariKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (s.SipBelgeNo != null && s.SipBelgeNo.Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(s => s.SipTarih)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Siparisler.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
        if (item == null) return Error("Siparis bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("")]
    public async Task<IActionResult> Post([FromBody] PineSiparisler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Siparisler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Siparis kaydedildi");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] PineSiparisler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Siparisler.FindAsync(id);
        if (existing == null) return Error("Siparis bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Siparis guncellendi");
    }

    [HttpGet("satirlar/{siparisId}")]
    public async Task<IActionResult> GetSatirlar(int siparisId)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.SiparisSatirlari.AsNoTracking()
            .Where(s => s.SstSiparisId == siparisId && !s.RecGizli)
            .OrderBy(s => s.SstSatirNo)
            .ToListAsync();
        return Ok(list);
    }
}
