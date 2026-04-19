using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Mikro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>Mikro V16 cari_hesaplar tablosu uzerinden CRUD.</summary>
[ApiController]
[Route("api/mikro/cari")]
public class MikroCariController : ControllerBase
{
    private readonly IDbContextFactory<MikroContext> _factory;
    public MikroCariController(IDbContextFactory<MikroContext> factory) => _factory = factory;

    [HttpGet("ara")]
    public async Task<IActionResult> Ara([FromQuery] string? q = null, [FromQuery] string? alan = null, [FromQuery] int limit = 20)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.CariHesaplar.AsNoTracking().Where(c => c.CariIptal != true && c.CariHidden != true);

        if (!string.IsNullOrWhiteSpace(q))
        {
            var arama = q.Trim();
            var kapsam = (alan ?? "hepsi").ToLowerInvariant();
            if (kapsam == "isim")
                query = query.Where(c => c.CariUnvan1 != null && c.CariUnvan1.Contains(arama));
            else if (kapsam == "kod")
                query = query.Where(c => c.CariKod != null && c.CariKod.Contains(arama));
            else
                query = query.Where(c =>
                    (c.CariKod != null && c.CariKod.Contains(arama)) ||
                    (c.CariUnvan1 != null && c.CariUnvan1.Contains(arama)));
        }

        var data = await query
            .OrderBy(c => c.CariKod)
            .Take(limit)
            .Select(c => new { guid = c.CariGuid, cariKod = c.CariKod, cariUnvan1 = c.CariUnvan1, cariUnvan2 = c.CariUnvan2 })
            .ToListAsync();

        return Ok(new { count = data.Count, items = data });
    }

    [HttpGet("hesap/{kod}")]
    public async Task<IActionResult> GetByKod(string kod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var c = await db.CariHesaplar.AsNoTracking().FirstOrDefaultAsync(x => x.CariKod == kod);
        if (c == null) return NotFound(new { error = "CARI_BULUNAMADI" });

        return Ok(new
        {
            guid = c.CariGuid,
            cariKod = c.CariKod,
            cariUnvan1 = c.CariUnvan1,
            cariUnvan2 = c.CariUnvan2,
            cariIptal = c.CariIptal
        });
    }

    [HttpGet("count")]
    public async Task<IActionResult> Count()
    {
        using var db = await _factory.CreateDbContextAsync();
        var total = await db.CariHesaplar.Where(c => c.CariIptal != true && c.CariHidden != true).CountAsync();
        return Ok(new { total });
    }
}
