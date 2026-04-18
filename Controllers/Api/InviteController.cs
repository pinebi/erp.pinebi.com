using System.Security.Cryptography;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Sistem;
using MACHINEBISS_Web.MultiTenant;
using MACHINEBISS_Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/invites")]
public class InviteController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IConnectionStringProtector _protector;
    private readonly IAuditLogger _audit;
    private readonly IDbContextFactory<FirmaContext> _factory;
    private readonly TenantAccessor _tenant;

    public InviteController(IConfiguration config, IConnectionStringProtector protector,
        IAuditLogger audit, IDbContextFactory<FirmaContext> factory, TenantAccessor tenant)
    {
        _config = config; _protector = protector; _audit = audit;
        _factory = factory; _tenant = tenant;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    /// <summary>Mevcut tenant icin davet olustur</summary>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] InviteCreateDto dto)
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest(new { error = "TENANT_CONTEXT_YOK" });
        if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.KullaniciAdi))
            return BadRequest(new { error = "EMAIL_VE_KULLANICI_ADI_ZORUNLU" });

        // Tenant DB'de kullanici var mi kontrol
        await using (var db = await _factory.CreateDbContextAsync())
        {
            if (await db.Kullanicilar.AnyAsync(k => k.KullaniciAdi == dto.KullaniciAdi))
                return Conflict(new { error = "KULLANICI_ADI_KULLANIMDA" });
        }

        var token = GenerateToken();
        var inviteId = Guid.NewGuid();
        var expiresAt = DateTime.UtcNow.AddDays(7);

        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();
        await using (var cmd = new SqlCommand(@"
INSERT INTO user_invites (invite_id, tenant_id, email, kullanici_adi, ad_soyad, rol, token, expires_at, created_by)
VALUES (@id, @tid, @email, @kul, @ad, @rol, @tok, @exp, @by)", master))
        {
            cmd.Parameters.AddWithValue("@id", inviteId);
            cmd.Parameters.AddWithValue("@tid", ctx.TenantId);
            cmd.Parameters.AddWithValue("@email", dto.Email);
            cmd.Parameters.AddWithValue("@kul", dto.KullaniciAdi);
            cmd.Parameters.AddWithValue("@ad", (object?)dto.AdSoyad ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@rol", dto.Rol ?? "Kullanici");
            cmd.Parameters.AddWithValue("@tok", token);
            cmd.Parameters.AddWithValue("@exp", expiresAt);
            cmd.Parameters.AddWithValue("@by", (object?)(User.Identity?.Name) ?? DBNull.Value);
            await cmd.ExecuteNonQueryAsync();
        }

        await _audit.LogAsync("invite.created", new { inviteId, email = dto.Email, subdomain = ctx.Subdomain, rol = dto.Rol },
            tenantId: ctx.TenantId);

        var host = Request.Host.Host;
        var url = $"https://{host}/davet/kabul?token={token}";

        return Ok(new
        {
            inviteId,
            email = dto.Email,
            token,
            inviteUrl = url,
            expiresAt,
            note = "Bu linki davetlinin email adresine gonder. 7 gun gecerli."
        });
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        var list = new List<object>();
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(@"
SELECT invite_id, email, kullanici_adi, ad_soyad, rol, expires_at, accepted_at, revoked_at, created_at
FROM user_invites WHERE tenant_id = @tid ORDER BY created_at DESC", conn);
        cmd.Parameters.AddWithValue("@tid", ctx.TenantId);
        await using var rdr = await cmd.ExecuteReaderAsync();
        while (await rdr.ReadAsync())
        {
            list.Add(new
            {
                inviteId = rdr.GetGuid(0),
                email = rdr.GetString(1),
                kullaniciAdi = rdr.GetString(2),
                adSoyad = rdr.IsDBNull(3) ? null : rdr.GetString(3),
                rol = rdr.GetString(4),
                expiresAt = rdr.GetDateTime(5),
                acceptedAt = rdr.IsDBNull(6) ? (DateTime?)null : rdr.GetDateTime(6),
                revokedAt = rdr.IsDBNull(7) ? (DateTime?)null : rdr.GetDateTime(7),
                createdAt = rdr.GetDateTime(8),
                durum = !rdr.IsDBNull(7) ? "iptal"
                      : !rdr.IsDBNull(6) ? "kabul"
                      : rdr.GetDateTime(5) < DateTime.UtcNow ? "suresi_doldu"
                      : "beklemede"
            });
        }
        return Ok(list);
    }

    /// <summary>Davet linkini tokenla dogrula - davetli bilgilerini dondur (kabul etmeden)</summary>
    [HttpGet("verify/{token}")]
    public async Task<IActionResult> Verify(string token)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(@"
SELECT i.invite_id, i.email, i.kullanici_adi, i.ad_soyad, i.rol, i.expires_at,
       i.accepted_at, i.revoked_at, t.tenant_name, t.subdomain
FROM user_invites i JOIN tenants t ON i.tenant_id = t.tenant_id
WHERE i.token = @tok", conn);
        cmd.Parameters.AddWithValue("@tok", token);
        await using var rdr = await cmd.ExecuteReaderAsync();
        if (!await rdr.ReadAsync()) return NotFound(new { error = "INVITE_NOT_FOUND" });

        if (!rdr.IsDBNull(7)) return BadRequest(new { error = "INVITE_REVOKED" });
        if (!rdr.IsDBNull(6)) return BadRequest(new { error = "INVITE_ALREADY_USED" });
        if (rdr.GetDateTime(5) < DateTime.UtcNow) return BadRequest(new { error = "INVITE_EXPIRED" });

        return Ok(new
        {
            inviteId = rdr.GetGuid(0),
            email = rdr.GetString(1),
            kullaniciAdi = rdr.GetString(2),
            adSoyad = rdr.IsDBNull(3) ? null : rdr.GetString(3),
            rol = rdr.GetString(4),
            tenantName = rdr.GetString(8),
            subdomain = rdr.GetString(9)
        });
    }

    /// <summary>Davet tokenla kabul et - tenant DB'ye kullanici olustur</summary>
    [HttpPost("accept")]
    public async Task<IActionResult> Accept([FromBody] InviteAcceptDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Token) || string.IsNullOrWhiteSpace(dto.Sifre))
            return BadRequest(new { error = "TOKEN_VE_SIFRE_ZORUNLU" });

        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();

        Guid inviteId, tenantId;
        string email, kullaniciAdi, rol;
        string? adSoyad, encConnStr;

        await using (var cmd = new SqlCommand(@"
SELECT i.invite_id, i.tenant_id, i.email, i.kullanici_adi, i.ad_soyad, i.rol,
       c.connection_string_encrypted, i.expires_at, i.accepted_at, i.revoked_at
FROM user_invites i
JOIN tenant_connections c ON i.tenant_id = c.tenant_id
WHERE i.token = @tok", master))
        {
            cmd.Parameters.AddWithValue("@tok", dto.Token);
            await using var rdr = await cmd.ExecuteReaderAsync();
            if (!await rdr.ReadAsync()) return NotFound(new { error = "INVITE_NOT_FOUND" });
            if (!rdr.IsDBNull(9)) return BadRequest(new { error = "INVITE_REVOKED" });
            if (!rdr.IsDBNull(8)) return BadRequest(new { error = "INVITE_ALREADY_USED" });
            if (rdr.GetDateTime(7) < DateTime.UtcNow) return BadRequest(new { error = "INVITE_EXPIRED" });

            inviteId = rdr.GetGuid(0);
            tenantId = rdr.GetGuid(1);
            email = rdr.GetString(2);
            kullaniciAdi = rdr.GetString(3);
            adSoyad = rdr.IsDBNull(4) ? null : rdr.GetString(4);
            rol = rdr.GetString(5);
            encConnStr = rdr.GetString(6);
        }

        var tenantConnStr = _protector.Unprotect(encConnStr);

        // Tenant DB'de kullanici olustur
        await using (var tconn = new SqlConnection(tenantConnStr))
        {
            await tconn.OpenAsync();
            await using var check = new SqlCommand("SELECT COUNT(*) FROM kullanicilar WHERE kullaniciadi=@k", tconn);
            check.Parameters.AddWithValue("@k", kullaniciAdi);
            if ((int)(await check.ExecuteScalarAsync() ?? 0) > 0)
                return Conflict(new { error = "KULLANICI_ADI_KULLANIMDA" });

            var hash = PasswordHasher.Hash(dto.Sifre);
            await using var ins = new SqlCommand(@"
INSERT INTO kullanicilar (kullaniciadi, email, sifrehash, adsoyad, rol, aktif, olusturmatarihi)
VALUES (@k, @e, @h, @a, @r, 1, SYSUTCDATETIME())", tconn);
            ins.Parameters.AddWithValue("@k", kullaniciAdi);
            ins.Parameters.AddWithValue("@e", email);
            ins.Parameters.AddWithValue("@h", hash);
            ins.Parameters.AddWithValue("@a", (object?)adSoyad ?? (object)kullaniciAdi);
            ins.Parameters.AddWithValue("@r", rol);
            await ins.ExecuteNonQueryAsync();
        }

        // Invite'i kapat
        await using (var upd = new SqlCommand(
            "UPDATE user_invites SET accepted_at = SYSUTCDATETIME() WHERE invite_id = @id", master))
        {
            upd.Parameters.AddWithValue("@id", inviteId);
            await upd.ExecuteNonQueryAsync();
        }

        await _audit.LogAsync("invite.accepted", new { inviteId, email, kullaniciAdi }, tenantId: tenantId);
        return Ok(new { message = "Davet kabul edildi. Artik giris yapabilirsiniz." });
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Revoke(Guid id)
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(
            "UPDATE user_invites SET revoked_at = SYSUTCDATETIME() WHERE invite_id=@id AND tenant_id=@tid AND accepted_at IS NULL", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@tid", ctx.TenantId);
        var n = await cmd.ExecuteNonQueryAsync();
        if (n == 0) return NotFound();
        await _audit.LogAsync("invite.revoked", new { inviteId = id }, tenantId: ctx.TenantId);
        return Ok(new { revoked = true });
    }

    private static string GenerateToken()
    {
        var bytes = RandomNumberGenerator.GetBytes(32);
        return Convert.ToHexString(bytes).ToLowerInvariant();
    }
}

public sealed class InviteCreateDto
{
    public string Email { get; set; } = "";
    public string KullaniciAdi { get; set; } = "";
    public string? AdSoyad { get; set; }
    public string? Rol { get; set; }
}

public sealed class InviteAcceptDto
{
    public string Token { get; set; } = "";
    public string Sifre { get; set; } = "";
}
