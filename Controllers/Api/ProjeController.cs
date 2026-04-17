using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/proje")]
public class ProjeController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public ProjeController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    [HttpGet("liste")]
    public async Task<IActionResult> GetListe(int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Projeler.AsNoTracking().Where(p => !p.RecGizli);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(p =>
                (p.PrjKod != null && EF.Functions.Collate(p.PrjKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (p.PrjIsim != null && EF.Functions.Collate(p.PrjIsim, "Latin1_General_CI_AI").Contains(ara)) ||
                (p.PrjSorumlu != null && EF.Functions.Collate(p.PrjSorumlu, "Latin1_General_CI_AI").Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderByDescending(p => p.PrjBaslangic)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Projeler.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        if (item == null) return Error("Proje bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("")]
    public async Task<IActionResult> Post([FromBody] PineProjeler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Projeler.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Proje kaydedildi");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] PineProjeler model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Projeler.FindAsync(id);
        if (existing == null) return Error("Proje bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Proje guncellendi");
    }

    // ===== GOREVLER =====

    [HttpGet("gorevler/{projeKod}")]
    public async Task<IActionResult> GetGorevler(string projeKod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.ProjeGorevleri.AsNoTracking()
            .Where(g => g.PgoProjeKod == projeKod && !g.RecGizli)
            .OrderBy(g => g.PgoGorevNo)
            .ToListAsync();
        return Ok(list);
    }

    [HttpPost("gorev")]
    public async Task<IActionResult> PostGorev([FromBody] PineProjeGorevleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.ProjeGorevleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Gorev kaydedildi");
    }
}
