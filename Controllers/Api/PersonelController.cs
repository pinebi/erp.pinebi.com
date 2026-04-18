using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/personel")]
public class PersonelController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public PersonelController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    // ===== PERSONEL KARTLARI =====

    [HttpGet("kartlar")]
    public async Task<IActionResult> GetKartlar(int sayfa = 1, int sayfaBoyutu = 50, string? ara = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Personeller.AsNoTracking().Where(p => !p.RecGizli);

        if (!string.IsNullOrWhiteSpace(ara))
            query = query.Where(p =>
                (p.PerKod != null && EF.Functions.Collate(p.PerKod, "Latin1_General_CI_AI").Contains(ara)) ||
                (p.PerAdsoyad != null && EF.Functions.Collate(p.PerAdsoyad, "Latin1_General_CI_AI").Contains(ara)) ||
                (p.PerTcKimlik != null && p.PerTcKimlik.Contains(ara)));

        var toplam = await query.CountAsync();
        var list = await query
            .OrderBy(p => p.PerAdsoyad)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .ToListAsync();

        return OkPaged(list, toplam, sayfa, sayfaBoyutu);
    }

    [HttpGet("ara")]
    public async Task<IActionResult> PersonelAra([FromQuery] string? q = null, [FromQuery] int limit = 15, [FromQuery] string? alan = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var query = db.Personeller.AsNoTracking().Where(p => !p.RecGizli && !p.RecIptal);

        if (!string.IsNullOrWhiteSpace(q))
        {
            var kapsam = (alan ?? "hepsi").ToLowerInvariant();
            if (kapsam == "isim")
                query = query.Where(p => p.PerAdsoyad != null && EF.Functions.Collate(p.PerAdsoyad, "Latin1_General_CI_AI").Contains(q));
            else if (kapsam == "kod")
                query = query.Where(p =>
                    (p.PerKod != null && EF.Functions.Collate(p.PerKod, "Latin1_General_CI_AI").Contains(q)) ||
                    (p.PerTcKimlik != null && p.PerTcKimlik.Contains(q)));
            else
                query = query.Where(p =>
                    (p.PerKod != null && EF.Functions.Collate(p.PerKod, "Latin1_General_CI_AI").Contains(q)) ||
                    (p.PerAdsoyad != null && EF.Functions.Collate(p.PerAdsoyad, "Latin1_General_CI_AI").Contains(q)) ||
                    (p.PerTcKimlik != null && p.PerTcKimlik.Contains(q)));
        }

        var data = await query
            .OrderBy(p => p.PerKod)
            .Take(limit)
            .Select(p => new { Id = p.Id, PerKod = p.PerKod ?? "", PerAdsoyad = p.PerAdsoyad ?? "" })
            .ToListAsync();

        return Ok(data);
    }

    [HttpGet("kart/{id}")]
    public async Task<IActionResult> GetKart(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var item = await db.Personeller.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        if (item == null) return Error("Personel bulunamadi", 404);
        return Ok(item);
    }

    [HttpPost("kart")]
    public async Task<IActionResult> PostKart([FromBody] PinePersoneller model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.Personeller.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Personel kaydedildi");
    }

    [HttpPut("kart/{id}")]
    public async Task<IActionResult> PutKart(int id, [FromBody] PinePersoneller model)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Personeller.FindAsync(id);
        if (existing == null) return Error("Personel bulunamadi", 404);

        db.Entry(existing).CurrentValues.SetValues(model);
        existing.Id = id;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return Ok(existing, "Personel guncellendi");
    }

    [HttpDelete("kart/{id}")]
    public async Task<IActionResult> DeleteKart(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var existing = await db.Personeller.FindAsync(id);
        if (existing == null) return Error("Personel bulunamadi", 404);

        existing.RecGizli = true;
        existing.RecLastupDate = DateTime.Now;
        existing.RecLastupUser = User.Identity?.Name ?? "system";
        await db.SaveChangesAsync();
        return OkMessage("Personel silindi");
    }

    // ===== IZINLER =====

    [HttpGet("izinler/{personelKod}")]
    public async Task<IActionResult> GetIzinler(string personelKod)
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.PersonelIzinleri.AsNoTracking()
            .Where(i => i.PizPersonelKod == personelKod && !i.RecGizli)
            .OrderByDescending(i => i.PizBaslangic)
            .ToListAsync();
        return Ok(list);
    }

    [HttpPost("izin")]
    public async Task<IActionResult> PostIzin([FromBody] PinePersonelIzinleri model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.RecCreateDate = DateTime.Now;
        model.RecCreateUser = User.Identity?.Name ?? "system";
        db.PersonelIzinleri.Add(model);
        await db.SaveChangesAsync();
        return Ok(model, "Izin kaydedildi");
    }

    // ===== DEPARTMANLAR =====

    [HttpGet("departmanlar")]
    public async Task<IActionResult> GetDepartmanlar()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.PersonelDepartmanlar.AsNoTracking()
            .Where(d => !d.RecGizli)
            .OrderBy(d => d.PdeIsim)
            .ToListAsync();
        return Ok(list);
    }

    // ===== POZISYONLAR =====

    [HttpGet("pozisyonlar")]
    public async Task<IActionResult> GetPozisyonlar()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.PersonelPozisyonlar.AsNoTracking()
            .Where(p => !p.RecGizli)
            .OrderBy(p => p.PpoIsim)
            .ToListAsync();
        return Ok(list);
    }
}
