using System.Security.Cryptography;
using System.Text;
using MACHINEBISS_Web.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.MultiTenant;

public sealed record PlatformUser(Guid UserId, string Email, string FullName, string Role);

public interface IPlatformAuthService
{
    Task<PlatformUser?> LoginAsync(string email, string password, CancellationToken ct = default);
    string IssueCookie(PlatformUser user);
    PlatformUser? ReadCookie(string? cookieValue);
}

/// <summary>
/// Platform admin icin cookie-based basit auth.
/// platform_users tablosuyla dogrular; PasswordHasher (BCrypt + legacy plain).
/// Cookie DataProtection ile sifrelidir (anti-tamper).
/// </summary>
public sealed class PlatformAuthService : IPlatformAuthService
{
    private readonly string _masterConn;
    private readonly IDataProtector _protector;

    public PlatformAuthService(IConfiguration config, IDataProtectionProvider dp)
    {
        _masterConn = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _protector = dp.CreateProtector("Pinebi.Platform.Auth.v1");
    }

    public async Task<PlatformUser?> LoginAsync(string email, string password, CancellationToken ct = default)
    {
        await using var conn = new SqlConnection(_masterConn);
        await conn.OpenAsync(ct);
        await using var cmd = new SqlCommand(@"
SELECT user_id, email, full_name, password_hash, role, active FROM platform_users WHERE email = @email", conn);
        cmd.Parameters.AddWithValue("@email", email);
        Guid id; string storedHash, role, fullName; bool active;
        await using (var rdr = await cmd.ExecuteReaderAsync(ct))
        {
            if (!await rdr.ReadAsync(ct)) return null;
            id = rdr.GetGuid(0);
            fullName = rdr.GetString(2);
            storedHash = rdr.GetString(3);
            role = rdr.GetString(4);
            active = rdr.GetBoolean(5);
        }

        if (!active) return null;
        if (!PasswordHasher.Verify(password, storedHash, out var needsMigration)) return null;

        if (needsMigration)
        {
            var newHash = PasswordHasher.Hash(password);
            await using var upd = new SqlCommand(
                "UPDATE platform_users SET password_hash=@h, last_login_at=SYSUTCDATETIME() WHERE user_id=@id", conn);
            upd.Parameters.AddWithValue("@h", newHash);
            upd.Parameters.AddWithValue("@id", id);
            await upd.ExecuteNonQueryAsync(ct);
        }
        else
        {
            await using var upd = new SqlCommand(
                "UPDATE platform_users SET last_login_at=SYSUTCDATETIME() WHERE user_id=@id", conn);
            upd.Parameters.AddWithValue("@id", id);
            await upd.ExecuteNonQueryAsync(ct);
        }

        return new PlatformUser(id, email, fullName, role);
    }

    public string IssueCookie(PlatformUser user)
    {
        var payload = $"{user.UserId}|{user.Email}|{user.Role}|{DateTimeOffset.UtcNow.AddHours(12).ToUnixTimeSeconds()}";
        return _protector.Protect(payload);
    }

    public PlatformUser? ReadCookie(string? cookieValue)
    {
        if (string.IsNullOrEmpty(cookieValue)) return null;
        try
        {
            var payload = _protector.Unprotect(cookieValue);
            var parts = payload.Split('|');
            if (parts.Length != 4) return null;
            var expUnix = long.Parse(parts[3]);
            if (DateTimeOffset.FromUnixTimeSeconds(expUnix) < DateTimeOffset.UtcNow) return null;
            return new PlatformUser(Guid.Parse(parts[0]), parts[1], "", parts[2]);
        }
        catch { return null; }
    }
}

/// <summary>
/// /platform/* altindaki sayfa ve API'leri platform auth cookie'siyle korur.
/// /platform/login ve /api/platform/auth/login haric.
/// </summary>
public sealed class PlatformAuthMiddleware
{
    private readonly RequestDelegate _next;
    public PlatformAuthMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext ctx, IPlatformAuthService auth)
    {
        var path = ctx.Request.Path.Value ?? "";
        var host = ctx.Request.Host.Host;

        // Platform admin sadece root domain'de (erp.pinebi.com / localhost)
        var isPlatformPath = path.StartsWith("/platform/", StringComparison.OrdinalIgnoreCase)
                          || path.Equals("/platform", StringComparison.OrdinalIgnoreCase)
                          || path.StartsWith("/api/platform/", StringComparison.OrdinalIgnoreCase);

        if (!isPlatformPath)
        {
            await _next(ctx);
            return;
        }

        // Subdomain uzerinden platform path'ine erisim engellensin
        if (!host.Equals("erp.pinebi.com", StringComparison.OrdinalIgnoreCase)
            && !host.Equals("localhost", StringComparison.OrdinalIgnoreCase))
        {
            ctx.Response.StatusCode = 404;
            await ctx.Response.WriteAsync("Not found");
            return;
        }

        // Public: login page ve login API
        if (path.Equals("/platform/login", StringComparison.OrdinalIgnoreCase) ||
            path.StartsWith("/api/platform/auth/", StringComparison.OrdinalIgnoreCase))
        {
            await _next(ctx);
            return;
        }

        // Cookie dogrula
        var cookie = ctx.Request.Cookies["pinebi_platform"];
        var user = auth.ReadCookie(cookie);
        if (user == null)
        {
            // API mi sayfa mi?
            if (path.StartsWith("/api/", StringComparison.OrdinalIgnoreCase))
            {
                ctx.Response.StatusCode = 401;
                await ctx.Response.WriteAsJsonAsync(new { error = "AUTH_REQUIRED" });
                return;
            }
            ctx.Response.Redirect($"/platform/login?returnUrl={Uri.EscapeDataString(path)}");
            return;
        }

        ctx.Items["PlatformUser"] = user;
        await _next(ctx);
    }
}

public static class PlatformAuthExtensions
{
    public static IApplicationBuilder UsePlatformAuth(this IApplicationBuilder app) =>
        app.UseMiddleware<PlatformAuthMiddleware>();
}
