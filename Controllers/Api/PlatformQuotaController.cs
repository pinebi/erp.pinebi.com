using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/platform/quota")]
public class PlatformQuotaController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IConnectionStringProtector _protector;
    private readonly ILogger<PlatformQuotaController> _log;

    public PlatformQuotaController(IConfiguration config, IConnectionStringProtector protector, ILogger<PlatformQuotaController> log)
    {
        _config = config;
        _protector = protector;
        _log = log;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    /// <summary>Tum tenant'lar icin kullanim istatistikleri + tier limitleri</summary>
    [HttpGet]
    public async Task<IActionResult> All()
    {
        var list = new List<object>();
        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();

        // Tenantlari + tier bilgilerini cek
        var tenants = new List<(Guid id, string code, string subdomain, string dbName, string status, string tierCode, int maxUsers, int maxStorageGb, int maxInvMonth, string? encCs)>();
        await using (var cmd = new SqlCommand(@"
SELECT t.tenant_id, t.tenant_code, t.subdomain, t.db_name, t.status,
       st.tier_code, st.max_users, st.max_storage_gb, st.max_invoices_month,
       c.connection_string_encrypted
FROM tenants t
JOIN subscription_tiers st ON t.tier_id = st.tier_id
LEFT JOIN tenant_connections c ON c.tenant_id = t.tenant_id
WHERE t.status IN ('active','suspended')", master))
        await using (var rdr = await cmd.ExecuteReaderAsync())
        {
            while (await rdr.ReadAsync())
            {
                tenants.Add((
                    rdr.GetGuid(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4),
                    rdr.GetString(5), rdr.GetInt32(6), rdr.GetInt32(7), rdr.GetInt32(8),
                    rdr.IsDBNull(9) ? null : rdr.GetString(9)
                ));
            }
        }

        foreach (var t in tenants)
        {
            int users = 0, stoks = 0, cariler = 0, faturalarThisMonth = 0, faturalarTotal = 0;
            long dbSizeMb = 0;
            string? err = null;

            try
            {
                if (!string.IsNullOrEmpty(t.encCs))
                {
                    var cs = _protector.Unprotect(t.encCs);
                    await using var tconn = new SqlConnection(cs);
                    await tconn.OpenAsync();

                    await using (var c = new SqlCommand(@"
SELECT
  (SELECT COUNT(*) FROM kullanicilar WHERE aktif=1) AS users,
  (SELECT COUNT(*) FROM pine_stoklar WHERE rec_iptal=0 AND rec_gizli=0) AS stoks,
  (SELECT COUNT(*) FROM pine_cari_hesaplar WHERE rec_iptal=0 AND rec_gizli=0) AS cariler,
  (SELECT COUNT(*) FROM pine_faturalar WHERE rec_iptal=0 AND rec_gizli=0 AND fat_tarih >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) AS fatMonth,
  (SELECT COUNT(*) FROM pine_faturalar WHERE rec_iptal=0 AND rec_gizli=0) AS fatTotal,
  (SELECT CAST(SUM(size) * 8 / 1024 AS BIGINT) FROM sys.database_files) AS sizeMb", tconn))
                    await using (var r = await c.ExecuteReaderAsync())
                    {
                        if (await r.ReadAsync())
                        {
                            users = r.IsDBNull(0) ? 0 : r.GetInt32(0);
                            stoks = r.IsDBNull(1) ? 0 : r.GetInt32(1);
                            cariler = r.IsDBNull(2) ? 0 : r.GetInt32(2);
                            faturalarThisMonth = r.IsDBNull(3) ? 0 : r.GetInt32(3);
                            faturalarTotal = r.IsDBNull(4) ? 0 : r.GetInt32(4);
                            dbSizeMb = r.IsDBNull(5) ? 0 : r.GetInt64(5);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                _log.LogWarning(ex, "Quota stats alinamadi: {Tenant}", t.code);
            }

            list.Add(new
            {
                tenantId = t.id,
                tenantCode = t.code,
                subdomain = t.subdomain,
                status = t.status,
                tier = t.tierCode,
                usage = new
                {
                    users,
                    stoks,
                    cariler,
                    invoicesThisMonth = faturalarThisMonth,
                    invoicesTotal = faturalarTotal,
                    dbSizeMb
                },
                limits = new
                {
                    maxUsers = t.maxUsers,
                    maxStorageGb = t.maxStorageGb,
                    maxInvoicesMonth = t.maxInvMonth
                },
                quotaStatus = new
                {
                    usersOverLimit = users > t.maxUsers,
                    storageOverLimit = dbSizeMb > t.maxStorageGb * 1024L,
                    invoicesOverLimit = faturalarThisMonth > t.maxInvMonth
                },
                error = err
            });
        }
        return Ok(new { total = list.Count, items = list });
    }
}
