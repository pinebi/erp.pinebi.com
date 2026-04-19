using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Platform admin: tenant bazinda Pine -> Mikro veri migration'i calistir.
/// </summary>
[ApiController]
[Route("api/platform/migration")]
public class PlatformMigrationController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IConnectionStringProtector _protector;
    private readonly IAuditLogger _audit;

    public PlatformMigrationController(IConfiguration config, IConnectionStringProtector protector, IAuditLogger audit)
    {
        _config = config; _protector = protector; _audit = audit;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    [HttpPost("pine-to-mikro/{tenantId:guid}")]
    public async Task<IActionResult> RunPineToMikro(Guid tenantId)
    {
        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();

        string? dbName = null, encConn = null;
        await using (var q = new SqlCommand(@"
SELECT t.db_name, c.connection_string_encrypted FROM tenants t
JOIN tenant_connections c ON c.tenant_id = t.tenant_id
WHERE t.tenant_id = @id", master))
        {
            q.Parameters.AddWithValue("@id", tenantId);
            await using var rdr = await q.ExecuteReaderAsync();
            if (!await rdr.ReadAsync()) return NotFound();
            dbName = rdr.GetString(0);
            encConn = rdr.GetString(1);
        }

        var conn = _protector.Unprotect(encConn!);
        var started = DateTime.UtcNow;
        int stoklarBefore = 0, cariBefore = 0, stoklarAfter = 0, cariAfter = 0;

        try
        {
            await using var tc = new SqlConnection(conn);
            await tc.OpenAsync();

            // Before counts
            await using (var c = new SqlCommand("SELECT COUNT(*) FROM stoklar", tc))
                stoklarBefore = (int)(await c.ExecuteScalarAsync() ?? 0);
            await using (var c = new SqlCommand("SELECT COUNT(*) FROM cari_hesaplar", tc))
                cariBefore = (int)(await c.ExecuteScalarAsync() ?? 0);

            // Stoklar MERGE
            await using (var cmd = new SqlCommand(@"
MERGE INTO stoklar AS tgt
USING (
    SELECT sto_kod,
           LEFT(sto_isim, 50) AS sto_isim,
           LEFT(sto_kisa_isim, 25) AS sto_kisa_ismi,
           LEFT(sto_yabanci_isim, 50) AS sto_yabanci_isim,
           LEFT(sto_birim1_ad, 10) AS sto_birim1_ad,
           sto_perakende_vergi,
           NEWID() AS sto_Guid
    FROM pine_stoklar
    WHERE rec_iptal = 0 AND rec_gizli = 0 AND sto_kod IS NOT NULL
) AS src
ON tgt.sto_kod = src.sto_kod
WHEN MATCHED THEN
    UPDATE SET sto_isim = src.sto_isim, sto_kisa_ismi = src.sto_kisa_ismi,
               sto_yabanci_isim = src.sto_yabanci_isim, sto_birim1_ad = src.sto_birim1_ad,
               sto_perakende_vergi = src.sto_perakende_vergi
WHEN NOT MATCHED THEN
    INSERT (sto_kod, sto_isim, sto_kisa_ismi, sto_yabanci_isim, sto_birim1_ad, sto_perakende_vergi, sto_Guid, sto_iptal, sto_hidden, sto_kilitli, sto_degisti)
    VALUES (src.sto_kod, src.sto_isim, src.sto_kisa_ismi, src.sto_yabanci_isim, src.sto_birim1_ad, src.sto_perakende_vergi, src.sto_Guid, 0, 0, 0, 0);", tc))
            {
                cmd.CommandTimeout = 300;
                await cmd.ExecuteNonQueryAsync();
            }

            // Cari MERGE
            await using (var cmd = new SqlCommand(@"
MERGE INTO cari_hesaplar AS tgt
USING (
    SELECT car_kod AS cari_kod, car_unvan1 AS cari_unvan1, car_unvan2 AS cari_unvan2, NEWID() AS cari_Guid
    FROM pine_cari_hesaplar
    WHERE rec_iptal = 0 AND rec_gizli = 0 AND car_kod IS NOT NULL
) AS src
ON tgt.cari_kod = src.cari_kod
WHEN MATCHED THEN
    UPDATE SET cari_unvan1 = src.cari_unvan1, cari_unvan2 = src.cari_unvan2
WHEN NOT MATCHED THEN
    INSERT (cari_kod, cari_unvan1, cari_unvan2, cari_Guid, cari_iptal, cari_hidden, cari_kilitli, cari_degisti)
    VALUES (src.cari_kod, src.cari_unvan1, src.cari_unvan2, src.cari_Guid, 0, 0, 0, 0);", tc))
            {
                cmd.CommandTimeout = 300;
                await cmd.ExecuteNonQueryAsync();
            }

            // After counts
            await using (var c = new SqlCommand("SELECT COUNT(*) FROM stoklar", tc))
                stoklarAfter = (int)(await c.ExecuteScalarAsync() ?? 0);
            await using (var c = new SqlCommand("SELECT COUNT(*) FROM cari_hesaplar", tc))
                cariAfter = (int)(await c.ExecuteScalarAsync() ?? 0);
        }
        catch (Exception ex)
        {
            await _audit.LogAsync("migration.pine_to_mikro_failed", new { tenantId, error = ex.Message }, tenantId: tenantId);
            return StatusCode(500, new { error = ex.Message });
        }

        var duration = (DateTime.UtcNow - started).TotalSeconds;

        await _audit.LogAsync("migration.pine_to_mikro", new
        {
            tenantId,
            dbName,
            stoklar = new { before = stoklarBefore, after = stoklarAfter, added = stoklarAfter - stoklarBefore },
            cari = new { before = cariBefore, after = cariAfter, added = cariAfter - cariBefore },
            durationSeconds = duration
        }, tenantId: tenantId);

        return Ok(new
        {
            tenantId, dbName,
            stoklar = new { before = stoklarBefore, after = stoklarAfter, added = stoklarAfter - stoklarBefore },
            cari = new { before = cariBefore, after = cariAfter, added = cariAfter - cariBefore },
            durationSeconds = duration
        });
    }

    [HttpPost("pine-to-mikro-all")]
    public async Task<IActionResult> RunAll()
    {
        var results = new List<object>();
        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();

        var tenants = new List<Guid>();
        await using (var q = new SqlCommand("SELECT tenant_id FROM tenants WHERE status IN ('active','suspended')", master))
        await using (var rdr = await q.ExecuteReaderAsync())
            while (await rdr.ReadAsync()) tenants.Add(rdr.GetGuid(0));

        foreach (var tid in tenants)
        {
            try
            {
                var url = Url.Action(nameof(RunPineToMikro), new { tenantId = tid });
                using var http = new HttpClient { BaseAddress = new Uri($"{Request.Scheme}://{Request.Host}") };
                // Forward cookies
                if (Request.Headers.Cookie.Count > 0)
                    http.DefaultRequestHeaders.Add("Cookie", Request.Headers.Cookie.ToString());
                var resp = await http.PostAsync($"/api/platform/migration/pine-to-mikro/{tid}", new StringContent("{}", System.Text.Encoding.UTF8, "application/json"));
                var body = await resp.Content.ReadAsStringAsync();
                results.Add(new { tenantId = tid, success = resp.IsSuccessStatusCode, body });
            }
            catch (Exception ex)
            {
                results.Add(new { tenantId = tid, error = ex.Message });
            }
        }
        return Ok(new { total = tenants.Count, results });
    }
}
