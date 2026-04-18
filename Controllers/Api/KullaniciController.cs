using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Sistem;
using MACHINEBISS_Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/sistem/kullanicilar")]
public class KullaniciController : ControllerBase
{
    private readonly IDbContextFactory<FirmaContext> _factory;

    public KullaniciController(IDbContextFactory<FirmaContext> factory) => _factory = factory;

    [HttpGet]
    public async Task<IActionResult> List()
    {
        using var db = await _factory.CreateDbContextAsync();
        var list = await db.Kullanicilar.AsNoTracking()
            .OrderBy(k => k.KullaniciAdi)
            .Select(k => new
            {
                id = k.Id,
                kullaniciAdi = k.KullaniciAdi,
                adSoyad = k.AdSoyad,
                email = k.Email,
                telefon = k.Telefon,
                rol = k.Rol,
                gorevi = k.Gorevi,
                aktif = k.Aktif,
                sonGirisTarihi = k.SonGirisTarihi,
                olusturmaTarihi = k.OlusturmaTarihi
            })
            .ToListAsync();
        return Ok(list);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var k = await db.Kullanicilar.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        if (k == null) return NotFound();
        return Ok(new {
            id = k.Id, kullaniciAdi = k.KullaniciAdi, adSoyad = k.AdSoyad, email = k.Email,
            telefon = k.Telefon, rol = k.Rol, gorevi = k.Gorevi, aktif = k.Aktif
        });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] KullaniciDto dto)
    {
        if (dto == null || string.IsNullOrWhiteSpace(dto.KullaniciAdi) || string.IsNullOrWhiteSpace(dto.Sifre))
            return BadRequest(new { error = "KULLANICI_ADI_VE_SIFRE_ZORUNLU" });

        using var db = await _factory.CreateDbContextAsync();
        var mevcut = await db.Kullanicilar.AnyAsync(k => k.KullaniciAdi == dto.KullaniciAdi);
        if (mevcut) return Conflict(new { error = "KULLANICI_ADI_KULLANIMDA" });

        var k = new Kullanicilar
        {
            KullaniciAdi = dto.KullaniciAdi,
            AdSoyad = dto.AdSoyad ?? dto.KullaniciAdi,
            Email = dto.Email,
            Telefon = dto.Telefon,
            Rol = dto.Rol ?? "Kullanici",
            Gorevi = dto.Gorevi,
            Aktif = dto.Aktif ?? true,
            SifreHash = PasswordHasher.Hash(dto.Sifre),
            OlusturmaTarihi = DateTime.UtcNow
        };
        db.Kullanicilar.Add(k);
        await db.SaveChangesAsync();
        return Ok(new { id = k.Id });
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] KullaniciDto dto)
    {
        using var db = await _factory.CreateDbContextAsync();
        var k = await db.Kullanicilar.FirstOrDefaultAsync(x => x.Id == id);
        if (k == null) return NotFound();

        k.AdSoyad = dto.AdSoyad ?? k.AdSoyad;
        k.Email = dto.Email ?? k.Email;
        k.Telefon = dto.Telefon ?? k.Telefon;
        k.Rol = dto.Rol ?? k.Rol;
        k.Gorevi = dto.Gorevi ?? k.Gorevi;
        if (dto.Aktif.HasValue) k.Aktif = dto.Aktif.Value;
        k.GuncellemeTarihi = DateTime.UtcNow;

        if (!string.IsNullOrWhiteSpace(dto.Sifre))
            k.SifreHash = PasswordHasher.Hash(dto.Sifre);

        await db.SaveChangesAsync();
        return Ok(new { id = k.Id });
    }

    [HttpPost("{id:int}/sifre-sifirla")]
    public async Task<IActionResult> SifreSifirla(int id, [FromBody] SifreDto dto)
    {
        if (dto == null || string.IsNullOrWhiteSpace(dto.YeniSifre))
            return BadRequest(new { error = "YENI_SIFRE_ZORUNLU" });

        using var db = await _factory.CreateDbContextAsync();
        var k = await db.Kullanicilar.FirstOrDefaultAsync(x => x.Id == id);
        if (k == null) return NotFound();

        k.SifreHash = PasswordHasher.Hash(dto.YeniSifre);
        k.GuncellemeTarihi = DateTime.UtcNow;
        await db.SaveChangesAsync();
        return Ok(new { message = "Sifre sifirlandi" });
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var k = await db.Kullanicilar.FirstOrDefaultAsync(x => x.Id == id);
        if (k == null) return NotFound();

        // Admin'i pasif yap silinmesin
        if (string.Equals(k.KullaniciAdi, "admin", StringComparison.OrdinalIgnoreCase))
            return BadRequest(new { error = "ADMIN_SILINEMEZ" });

        k.Aktif = false; // soft delete
        await db.SaveChangesAsync();
        return Ok(new { message = "Kullanici pasif yapildi" });
    }
}

public sealed class KullaniciDto
{
    public string KullaniciAdi { get; set; } = "";
    public string? AdSoyad { get; set; }
    public string? Email { get; set; }
    public string? Telefon { get; set; }
    public string? Rol { get; set; }
    public string? Gorevi { get; set; }
    public bool? Aktif { get; set; }
    public string? Sifre { get; set; }
}

public sealed class SifreDto
{
    public string YeniSifre { get; set; } = "";
}
