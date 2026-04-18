using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace MACHINEBISS_Web.MultiTenant;

public sealed record QuotaInfo(int MaxUsers, int MaxStorageGb, int MaxInvoicesMonth, string TierCode);

public interface IQuotaService
{
    Task<QuotaInfo?> GetLimitsAsync(Guid tenantId, CancellationToken ct = default);
    Task<int> GetInvoicesThisMonthAsync(string tenantConnectionString, CancellationToken ct = default);
}

public sealed class QuotaService : IQuotaService
{
    private readonly string _masterConn;
    private readonly IMemoryCache _cache;

    public QuotaService(IConfiguration config, IMemoryCache cache)
    {
        _masterConn = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _cache = cache;
    }

    public async Task<QuotaInfo?> GetLimitsAsync(Guid tenantId, CancellationToken ct = default)
    {
        if (_cache.TryGetValue($"quota:{tenantId}", out QuotaInfo? cached)) return cached;

        await using var conn = new SqlConnection(_masterConn);
        await conn.OpenAsync(ct);
        await using var cmd = new SqlCommand(@"
SELECT st.max_users, st.max_storage_gb, st.max_invoices_month, st.tier_code
FROM tenants t JOIN subscription_tiers st ON t.tier_id = st.tier_id
WHERE t.tenant_id = @id", conn);
        cmd.Parameters.AddWithValue("@id", tenantId);
        await using var rdr = await cmd.ExecuteReaderAsync(ct);
        if (!await rdr.ReadAsync(ct)) return null;

        var info = new QuotaInfo(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr.GetString(3));
        _cache.Set($"quota:{tenantId}", info, TimeSpan.FromMinutes(10));
        return info;
    }

    public async Task<int> GetInvoicesThisMonthAsync(string tenantConnStr, CancellationToken ct = default)
    {
        try
        {
            await using var conn = new SqlConnection(tenantConnStr);
            await conn.OpenAsync(ct);
            await using var cmd = new SqlCommand(@"
SELECT COUNT(*) FROM pine_faturalar
WHERE rec_iptal=0 AND rec_gizli=0
  AND fat_tarih >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)", conn);
            return (int)(await cmd.ExecuteScalarAsync(ct) ?? 0);
        }
        catch { return 0; }
    }
}

public sealed class QuotaEnforcementMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<QuotaEnforcementMiddleware> _log;

    public QuotaEnforcementMiddleware(RequestDelegate next, ILogger<QuotaEnforcementMiddleware> log)
    {
        _next = next; _log = log;
    }

    public async Task InvokeAsync(HttpContext ctx, TenantAccessor tenant, IQuotaService quotaSvc, IAuditLogger audit)
    {
        // Sadece yazma API'larinda fatura quotasi kontrol et
        var path = ctx.Request.Path.Value ?? "";
        var method = ctx.Request.Method;

        if (method == "POST" && path.StartsWith("/api/fatura", StringComparison.OrdinalIgnoreCase))
        {
            var ctx2 = tenant.Current;
            if (ctx2 != null && !ctx2.IsReadOnly)
            {
                var limits = await quotaSvc.GetLimitsAsync(ctx2.TenantId, ctx.RequestAborted);
                if (limits != null)
                {
                    var current = await quotaSvc.GetInvoicesThisMonthAsync(ctx2.ConnectionString, ctx.RequestAborted);
                    if (current >= limits.MaxInvoicesMonth)
                    {
                        await audit.LogAsync("quota.exceeded", new {
                            resource = "invoices", current, limit = limits.MaxInvoicesMonth, tier = limits.TierCode
                        }, tenantId: ctx2.TenantId);

                        ctx.Response.StatusCode = 402; // Payment Required
                        await ctx.Response.WriteAsJsonAsync(new {
                            error = "QUOTA_EXCEEDED",
                            resource = "invoices_per_month",
                            current,
                            limit = limits.MaxInvoicesMonth,
                            tier = limits.TierCode,
                            message = $"Tier limiti asildi ({current}/{limits.MaxInvoicesMonth} fatura). Yukseltme yapiniz."
                        });
                        return;
                    }
                }
            }
        }

        await _next(ctx);
    }
}

public static class QuotaEnforcementMiddlewareExtensions
{
    public static IApplicationBuilder UseQuotaEnforcement(this IApplicationBuilder app) =>
        app.UseMiddleware<QuotaEnforcementMiddleware>();
}
