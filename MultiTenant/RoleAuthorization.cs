namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// Role hiyerarsisi: Admin > Yonetici > Kullanici > Okuyucu
/// </summary>
public static class Roles
{
    public const string Admin = "Admin";
    public const string Yonetici = "Yonetici";
    public const string Kullanici = "Kullanici";
    public const string Okuyucu = "Okuyucu";

    private static readonly Dictionary<string, int> _levels = new(StringComparer.OrdinalIgnoreCase)
    {
        { Admin, 4 },
        { Yonetici, 3 },
        { Kullanici, 2 },
        { Okuyucu, 1 }
    };

    public static int Level(string? rol) =>
        rol != null && _levels.TryGetValue(rol, out var l) ? l : 0;

    /// <summary>Kullanicinin rolu gerekli rolu karsiliyor mu?</summary>
    public static bool Has(string? userRol, string gerekenRol) =>
        Level(userRol) >= Level(gerekenRol);
}

/// <summary>
/// API route'larinda rol kontrolu:
///   /api/sistem/*          -> Admin
///   /api/invites POST/DELETE -> Yonetici+
///   /api/platform/*         -> Admin (sadece platform admin erp.pinebi.com subdomaininden)
/// </summary>
public sealed class RoleAuthorizationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RoleAuthorizationMiddleware> _log;

    public RoleAuthorizationMiddleware(RequestDelegate next, ILogger<RoleAuthorizationMiddleware> log)
    {
        _next = next;
        _log = log;
    }

    public async Task InvokeAsync(HttpContext ctx, Services.AuthService auth)
    {
        var path = ctx.Request.Path.Value ?? "";
        var method = ctx.Request.Method;

        string? gerekenRol = null;

        // Admin icin kisitlanacak pathler
        if (path.StartsWith("/api/sistem/kullanicilar", StringComparison.OrdinalIgnoreCase))
            gerekenRol = Roles.Admin;

        // Invite create/delete yalnizca Yonetici+
        if (path.StartsWith("/api/invites", StringComparison.OrdinalIgnoreCase))
        {
            if (method is "POST" or "DELETE") gerekenRol = Roles.Yonetici;
        }

        // Platform admin endpoint'leri sadece root subdomain'den (erp.pinebi.com)
        if (path.StartsWith("/api/platform/", StringComparison.OrdinalIgnoreCase))
        {
            var host = ctx.Request.Host.Host;
            if (!host.Equals("erp.pinebi.com", StringComparison.OrdinalIgnoreCase) &&
                !host.Equals("localhost", StringComparison.OrdinalIgnoreCase))
            {
                ctx.Response.StatusCode = 404;
                await ctx.Response.WriteAsync("Not found");
                return;
            }
        }

        if (gerekenRol != null)
        {
            if (!auth.IsAuthenticated)
            {
                ctx.Response.StatusCode = 401;
                await ctx.Response.WriteAsJsonAsync(new { error = "AUTH_REQUIRED" });
                return;
            }
            if (!Roles.Has(auth.Rol, gerekenRol))
            {
                ctx.Response.StatusCode = 403;
                await ctx.Response.WriteAsJsonAsync(new
                {
                    error = "FORBIDDEN",
                    required = gerekenRol,
                    current = auth.Rol
                });
                return;
            }
        }

        await _next(ctx);
    }
}

public static class RoleAuthorizationMiddlewareExtensions
{
    public static IApplicationBuilder UseRoleAuthorization(this IApplicationBuilder app) =>
        app.UseMiddleware<RoleAuthorizationMiddleware>();
}
