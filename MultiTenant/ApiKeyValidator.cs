using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace MACHINEBISS_Web.MultiTenant;

public interface IApiKeyValidator
{
    Task<ApiKeyResult?> ValidateAsync(string apiKey, CancellationToken ct = default);
}

public sealed record ApiKeyResult(Guid TenantId, string TenantSubdomain, string Scopes);

public sealed class SqlApiKeyValidator : IApiKeyValidator
{
    private readonly string _masterConnStr;
    private readonly IMemoryCache _cache;
    private static readonly TimeSpan CacheTtl = TimeSpan.FromMinutes(5);

    public SqlApiKeyValidator(IConfiguration config, IMemoryCache cache)
    {
        _masterConnStr = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _cache = cache;
    }

    public async Task<ApiKeyResult?> ValidateAsync(string apiKey, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Length < 12) return null;

        var cacheKey = $"apikey:{apiKey}";
        if (_cache.TryGetValue(cacheKey, out ApiKeyResult? cached)) return cached;

        var prefix = apiKey.Substring(0, 9);
        var hash = HashKey(apiKey);

        await using var conn = new SqlConnection(_masterConnStr);
        await conn.OpenAsync(ct);

        const string sql = @"
SELECT TOP 1 k.tenant_id, t.subdomain, k.scopes
FROM api_keys k
JOIN tenants t ON k.tenant_id = t.tenant_id
WHERE k.key_prefix = @prefix
  AND k.key_hash = @hash
  AND k.active = 1
  AND (k.expires_at IS NULL OR k.expires_at > SYSUTCDATETIME())
  AND t.status = 'active';";

        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@prefix", prefix);
        cmd.Parameters.AddWithValue("@hash", hash);

        await using var rdr = await cmd.ExecuteReaderAsync(ct);
        if (!await rdr.ReadAsync(ct)) return null;

        var result = new ApiKeyResult(rdr.GetGuid(0), rdr.GetString(1), rdr.GetString(2));
        _cache.Set(cacheKey, result, CacheTtl);

        // Update last_used_at async (fire and forget)
        _ = UpdateLastUsedAsync(prefix, hash);
        return result;
    }

    private async Task UpdateLastUsedAsync(string prefix, string hash)
    {
        try
        {
            await using var conn = new SqlConnection(_masterConnStr);
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(
                "UPDATE api_keys SET last_used_at = SYSUTCDATETIME() WHERE key_prefix=@p AND key_hash=@h", conn);
            cmd.Parameters.AddWithValue("@p", prefix);
            cmd.Parameters.AddWithValue("@h", hash);
            await cmd.ExecuteNonQueryAsync();
        }
        catch { /* best-effort */ }
    }

    private static string HashKey(string key)
    {
        var bytes = Encoding.Unicode.GetBytes(key); // NVARCHAR icin Unicode
        var hash = SHA256.HashData(bytes);
        return Convert.ToHexString(hash); // uppercase hex
    }
}
