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

        // API gateway: erpapi.pinebi.com - tenant header'dan gelir
        if (host.Equals("erpapi.pinebi.com", StringComparison.OrdinalIgnoreCase))
        {
            var tenantCode = ctx.Request.Headers["X-Tenant"].FirstOrDefault()
                          ?? ctx.Request.Query["tenant"].FirstOrDefault();
            if (string.IsNullOrEmpty(tenantCode))
            {
                ctx.Response.StatusCode = 400;
                await ctx.Response.WriteAsync("X-Tenant header or ?tenant= query param required on erpapi.pinebi.com");
                return;
            }
            var apiTenant = await resolver.ResolveAsync($"{tenantCode}.pinebi.com", ctx.RequestAborted);
            if (apiTenant == null)
            {
                ctx.Response.StatusCode = 404;
                await ctx.Response.WriteAsync($"Tenant not found: {tenantCode}");
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
}

public static class TenantMiddlewareExtensions
{
    public static IApplicationBuilder UseTenantResolution(this IApplicationBuilder app) =>
        app.UseMiddleware<TenantMiddleware>();
}
