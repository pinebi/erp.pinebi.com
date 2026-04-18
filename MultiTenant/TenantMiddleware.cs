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
