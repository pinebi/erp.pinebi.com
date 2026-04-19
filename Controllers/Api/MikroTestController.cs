using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Mikro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Mikro sema uzerinden smoke test + istatistik endpoint'leri.
/// Geri kalan controller'lar Pine semasinda; bu yeni Mikro'yi dogrular.
/// </summary>
[ApiController]
[Route("api/mikro")]
public class MikroTestController : ControllerBase
{
    private readonly IDbContextFactory<MikroContext> _factory;

    public MikroTestController(IDbContextFactory<MikroContext> factory) => _factory = factory;

    /// <summary>Mikro semasindaki tablo kayit sayilari (her tenant DB kendi semasina bakar)</summary>
    [HttpGet("stats")]
    public async Task<IActionResult> Stats()
    {
        using var db = await _factory.CreateDbContextAsync();
        var result = new
        {
            stoklar = await db.Stoklar.CountAsync(),
            cariHesaplar = await db.CariHesaplar.CountAsync(),
            stokHareketleri = await db.StokHareketleri.CountAsync(),
            cariHesapHareketleri = await db.CariHesapHareketleri.CountAsync(),
            siparisler = await db.Siparisler.CountAsync(),
            muhasebeFisleri = await db.MuhasebeFisleri.CountAsync(),
            personeller = await db.Personeller.CountAsync(),
            depolar = await db.Depolar.CountAsync(),
            bankalar = await db.Bankalar.CountAsync(),
            kasalar = await db.Kasalar.CountAsync()
        };
        return Ok(result);
    }

    [HttpGet("stoklar")]
    public async Task<IActionResult> Stoklar([FromQuery] int limit = 10)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Stoklar.AsNoTracking().Take(limit)
            .Select(s => new { s.StoKod })
            .ToListAsync();
        return Ok(list);
    }

    [HttpGet("cari-hesaplar")]
    public async Task<IActionResult> CariHesaplar([FromQuery] int limit = 10)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.CariHesaplar.AsNoTracking().Take(limit)
            .Select(c => new { c.CariKod, c.CariUnvan1 })
            .ToListAsync();
        return Ok(list);
    }
}
