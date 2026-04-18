using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace MACHINEBISS_Web.MultiTenant;

public interface ITenantResolver
{
    Task<TenantContext?> ResolveAsync(string host, CancellationToken ct = default);
}

public sealed class SubdomainTenantResolver : ITenantResolver
{
    private readonly string _masterConnectionString;
    private readonly IMemoryCache _cache;
    private readonly ILogger<SubdomainTenantResolver> _log;
    private readonly IConnectionStringProtector _protector;
    private static readonly TimeSpan CacheTtl = TimeSpan.FromSeconds(60);

    public SubdomainTenantResolver(IConfiguration config, IMemoryCache cache, ILogger<SubdomainTenantResolver> log, IConnectionStringProtector protector)
    {
        _masterConnectionString = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _cache = cache;
        _log = log;
        _protector = protector;
    }

    public async Task<TenantContext?> ResolveAsync(string host, CancellationToken ct = default)
    {
        var subdomain = ExtractSubdomain(host);
        if (string.IsNullOrEmpty(subdomain)) return null;

        var cacheKey = $"tenant:{subdomain}";
        if (_cache.TryGetValue(cacheKey, out TenantContext? cached)) return cached;

        await using var conn = new SqlConnection(_masterConnectionString);
        await conn.OpenAsync(ct);

        const string sql = @"
SELECT TOP 1
    t.tenant_id, t.tenant_code, t.tenant_name, t.subdomain, t.db_name,
    t.region_id, t.status, t.locale, t.currency, t.logo_url, t.primary_color,
    c.connection_string_encrypted AS connection_string
FROM tenants t
JOIN tenant_connections c ON c.tenant_id = t.tenant_id
WHERE t.subdomain = @subdomain AND t.status <> 'deleted';";

        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@subdomain", subdomain);
        await using var rdr = await cmd.ExecuteReaderAsync(ct);
        if (!await rdr.ReadAsync(ct)) return null;

        var status = rdr.GetString(6).ToLowerInvariant() switch
        {
            "provisioning" => TenantStatus.Provisioning,
            "active" => TenantStatus.Active,
            "suspended" => TenantStatus.Suspended,
            "deleted" => TenantStatus.Deleted,
            _ => TenantStatus.Active
        };

        var ctx = new TenantContext
        {
            TenantId = rdr.GetGuid(0),
            TenantCode = rdr.GetString(1),
            TenantName = rdr.GetString(2),
            Subdomain = rdr.GetString(3),
            DbName = rdr.GetString(4),
            RegionId = rdr.GetString(5),
            Status = status,
            Locale = rdr.IsDBNull(7) ? "tr-TR" : rdr.GetString(7),
            Currency = rdr.IsDBNull(8) ? "TRY" : rdr.GetString(8),
            LogoUrl = rdr.IsDBNull(9) ? null : rdr.GetString(9),
            PrimaryColor = rdr.IsDBNull(10) ? "#235881" : rdr.GetString(10),
            ConnectionString = _protector.Unprotect(rdr.GetString(11))
        };

        _cache.Set(cacheKey, ctx, CacheTtl);
        _log.LogInformation("Tenant resolved: {Sub} -> {Code} ({Db})", subdomain, ctx.TenantCode, ctx.DbName);
        return ctx;
    }

    // Pinebi'nin mevcut projelerine ait subdomain'ler - tenant olarak islenmemeli
    private static readonly HashSet<string> _reservedSubdomains = new(StringComparer.OrdinalIgnoreCase)
    {
        "www", "mail", "ftp", "smtp", "pop", "imap", "admin", "api", "webservice", "erpapi",
        "documents", "edonusum", "playland", "teleferik", "update", "parkbahce",
        "playworld", "dashboardteleferik", "essen", "ecommerce", "dpeglence",
        "audit", "sinema", "fatura", "rimal", "exclusive", "videoplayer",
        "videoplayer2", "coplay", "sapancateleferik", "alanyateleferik",
        "captune", "entertainment", "playlandapi", "belpas", "report",
        "rmk", "restoran", "belge", "r", "kiosk", "gate", "sarfmalzeme",
        "lootus", "bileteko"
    };

    internal static string ExtractSubdomain(string host)
    {
        // "acme.pinebi.com"      -> "acme"
        // "erp.pinebi.com"       -> "erp"
        // "api.pinebi.com"       -> "" (reserved, tenant yok)
        // "pinebi.com"           -> ""
        // "acme.erp.pinebi.com"  -> "acme"
        if (string.IsNullOrWhiteSpace(host)) return "";
        var parts = host.Split('.');
        if (parts.Length < 3) return "";
        var sub = parts[0].ToLowerInvariant();
        if (_reservedSubdomains.Contains(sub)) return "";
        return sub;
    }
}
