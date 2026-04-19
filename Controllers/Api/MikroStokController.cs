using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Mikro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Mikro V16 stoklar tablosu uzerinden CRUD.
/// Route: /api/mikro/stok
/// </summary>
[ApiController]
[Route("api/mikro/stok")]
public class MikroStokController : ControllerBase
{
    private readonly IDbContextFactory<MikroContext> _factory;
    public MikroStokController(IDbContextFactory<MikroContext> factory) => _factory = factory;

    [HttpGet("ara")]
    public async Task<IActionResult> Ara([FromQuery] string? q = null, [FromQuery] string? alan = null, [FromQuery] int limit = 20)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Stoklar.AsNoTracking().Where(s => s.StoIptal != true && s.StoHidden != true);

        if (!string.IsNullOrWhiteSpace(q))
        {
            var arama = q.Trim();
            var kapsam = (alan ?? "hepsi").ToLowerInvariant();
            if (kapsam == "isim")
                query = query.Where(s => s.StoIsim != null && s.StoIsim.Contains(arama));
            else if (kapsam == "kod")
                query = query.Where(s => s.StoKod != null && s.StoKod.Contains(arama));
            else
                query = query.Where(s =>
                    (s.StoKod != null && s.StoKod.Contains(arama)) ||
                    (s.StoIsim != null && s.StoIsim.Contains(arama)));
        }

        var data = await query
            .OrderBy(s => s.StoKod)
            .Take(limit)
            .Select(s => new
            {
                guid = s.StoGuid,
                stoKod = s.StoKod,
                stoIsim = s.StoIsim,
                stoBirim = s.StoBirim1Ad,
                stoCins = s.StoCins,
                stoDovizCinsi = s.StoDovizCinsi
            })
            .ToListAsync();

        return Ok(new { count = data.Count, items = data });
    }

    [HttpGet("kart/{kod}")]
    public async Task<IActionResult> GetByKod(string kod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var s = await db.Stoklar.AsNoTracking().FirstOrDefaultAsync(x => x.StoKod == kod);
        if (s == null) return NotFound(new { error = "STOK_BULUNAMADI" });

        return Ok(new
        {
            guid = s.StoGuid,
            stoKod = s.StoKod,
            stoIsim = s.StoIsim,
            stoKisaIsmi = s.StoKisaIsmi,
            stoYabanciIsim = s.StoYabanciIsim,
            stoBirim = s.StoBirim1Ad,
            stoCins = s.StoCins,
            stoDovizCinsi = s.StoDovizCinsi,
            stoIptal = s.StoIptal,
            stoHidden = s.StoHidden
        });
    }

    [HttpGet("count")]
    public async Task<IActionResult> Count()
    {
        using var db = await _factory.CreateDbContextAsync();
        var total = await db.Stoklar.Where(s => s.StoIptal != true && s.StoHidden != true).CountAsync();
        var iptal = await db.Stoklar.Where(s => s.StoIptal == true).CountAsync();
        var hidden = await db.Stoklar.Where(s => s.StoHidden == true).CountAsync();
        return Ok(new { total, iptal, hidden });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] StokDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.StoKod)) return BadRequest(new { error = "STO_KOD_ZORUNLU" });
        if (string.IsNullOrWhiteSpace(dto.StoIsim)) return BadRequest(new { error = "STO_ISIM_ZORUNLU" });

        using var db = await _factory.CreateDbContextAsync();
        if (await db.Stoklar.AnyAsync(s => s.StoKod == dto.StoKod))
            return Conflict(new { error = "STO_KOD_MEVCUT" });

        var s = new Stoklar
        {
            StoKod = dto.StoKod,
            StoGuid = Guid.NewGuid(),
            StoIsim = dto.StoIsim,
            StoKisaIsmi = dto.StoKisaIsmi,
            StoYabanciIsim = dto.StoYabanciIsim,
            StoBirim1Ad = dto.StoBirim,
            StoCins = dto.StoCins ?? 0,
            StoDovizCinsi = dto.StoDovizCinsi ?? 0,
            StoIptal = false,
            StoHidden = false,
            StoKilitli = false,
            StoDegisti = false,
            StoCreateDate = DateTime.UtcNow,
            StoLastupDate = DateTime.UtcNow
        };
        db.Stoklar.Add(s);
        await db.SaveChangesAsync();
        return Ok(new { stoKod = s.StoKod, guid = s.StoGuid });
    }

    [HttpPut("{kod}")]
    public async Task<IActionResult> Update(string kod, [FromBody] StokDto dto)
    {
        using var db = await _factory.CreateDbContextAsync();
        var s = await db.Stoklar.FirstOrDefaultAsync(x => x.StoKod == kod);
        if (s == null) return NotFound();

        s.StoIsim = dto.StoIsim ?? s.StoIsim;
        s.StoKisaIsmi = dto.StoKisaIsmi ?? s.StoKisaIsmi;
        s.StoYabanciIsim = dto.StoYabanciIsim ?? s.StoYabanciIsim;
        s.StoBirim1Ad = dto.StoBirim ?? s.StoBirim1Ad;
        if (dto.StoCins.HasValue) s.StoCins = dto.StoCins.Value;
        if (dto.StoDovizCinsi.HasValue) s.StoDovizCinsi = dto.StoDovizCinsi.Value;
        s.StoLastupDate = DateTime.UtcNow;

        await db.SaveChangesAsync();
        return Ok(new { stoKod = s.StoKod });
    }

    [HttpDelete("{kod}")]
    public async Task<IActionResult> Delete(string kod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var s = await db.Stoklar.FirstOrDefaultAsync(x => x.StoKod == kod);
        if (s == null) return NotFound();
        s.StoIptal = true; // soft delete
        s.StoLastupDate = DateTime.UtcNow;
        await db.SaveChangesAsync();
        return Ok(new { stoKod = s.StoKod, iptal = true });
    }
}

public sealed class StokDto
{
    public string StoKod { get; set; } = "";
    public string? StoIsim { get; set; }
    public string? StoKisaIsmi { get; set; }
    public string? StoYabanciIsim { get; set; }
    public string? StoBirim { get; set; }
    public byte? StoCins { get; set; }
    public byte? StoDovizCinsi { get; set; }
}
