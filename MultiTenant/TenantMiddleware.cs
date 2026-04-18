namespace MACHINEBISS_Web.MultiTenant;

public sealed class TenantMiddleware
{
    private readonly RequestDelegate _next;
    public TenantMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext ctx, ITenantResolver resolver, TenantAccessor accessor)
    {
        if (IsPublicPath(ctx.Request.Path))
        {
            await _next(ctx);
            return;
        }

        var host = ctx.Request.Host.Host;

        // API gateway: erpapi.pinebi.com
        // Once API key, ardindan X-Tenant header (key'in ait oldugu tenant ile esleşmeli)
        if (host.Equals("erpapi.pinebi.com", StringComparison.OrdinalIgnoreCase))
        {
            var apiKey = ctx.Request.Headers["X-Api-Key"].FirstOrDefault()
                      ?? ExtractBearer(ctx.Request.Headers["Authorization"].FirstOrDefault());

            if (string.IsNullOrEmpty(apiKey))
            {
                ctx.Response.StatusCode = 401;
                await ctx.Response.WriteAsync("X-Api-Key header veya Authorization: Bearer <key> gereklidir");
                return;
            }

            var validator = ctx.RequestServices.GetRequiredService<IApiKeyValidator>();
            var result = await validator.ValidateAsync(apiKey, ctx.RequestAborted);
            if (result == null)
            {
                ctx.Response.StatusCode = 401;
                await ctx.Response.WriteAsync("Gecersiz veya pasif API key");
                return;
            }

            // X-Tenant header opsiyonel; verildiyse API key ile eslesmeli
            var requestedTenant = ctx.Request.Headers["X-Tenant"].FirstOrDefault()
                               ?? ctx.Request.Query["tenant"].FirstOrDefault();
            if (!string.IsNullOrEmpty(requestedTenant) &&
                !string.Equals(requestedTenant, result.TenantSubdomain, StringComparison.OrdinalIgnoreCase))
            {
                ctx.Response.StatusCode = 403;
                await ctx.Response.WriteAsync($"API key bu tenant icin yetkili degil: {requestedTenant}");
                return;
            }

            var apiTenant = await resolver.ResolveAsync($"{result.TenantSubdomain}.pinebi.com", ctx.RequestAborted);
            if (apiTenant == null)
            {
                ctx.Response.StatusCode = 404;
                await ctx.Response.WriteAsync("Tenant bulunamadi");
                return;
            }
            accessor.Current = apiTenant;
            ctx.Items["Tenant"] = apiTenant;
            await _next(ctx);
            return;
        }

        var tenant = await resolver.ResolveAsync(host, ctx.RequestAborted);

        if (tenant == null)
        {
            // Fallback: erp.pinebi.com veya bilinmeyen host -> DEMO tenant
            tenant = await resolver.ResolveAsync("erp.pinebi.com", ctx.RequestAborted);
        }

        if (tenant != null)
        {
            accessor.Current = tenant;
            ctx.Items["Tenant"] = tenant;
        }

        await _next(ctx);
    }

    static bool IsPublicPath(PathString path) =>
        path.StartsWithSegments("/_framework") ||
        path.StartsWithSegments("/_blazor") ||
        path.StartsWithSegments("/images") ||
        path.StartsWithSegments("/css") ||
        path.StartsWithSegments("/js") ||
        path.Value == "/favicon.ico";

    private static string? ExtractBearer(string? authHeader)
    {
        if (string.IsNullOrEmpty(authHeader)) return null;
        const string prefix = "Bearer ";
        return authHeader.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)
            ? authHeader.Substring(prefix.Length).Trim()
            : null;
    }
}

public static class TenantMiddlewareExtensions
{
    public static IApplicationBuilder UseTenantResolution(this IApplicationBuilder app) =>
        app.UseMiddleware<TenantMiddleware>();
}
