using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/platform/backup")]
public class PlatformBackupController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IAuditLogger _audit;
    private readonly ILogger<PlatformBackupController> _log;

    public PlatformBackupController(IConfiguration config, IAuditLogger audit, ILogger<PlatformBackupController> log)
    {
        _config = config; _audit = audit; _log = log;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    [HttpGet]
    public IActionResult List()
    {
        var root = @"C:\Pinebi\backups";
        if (!Directory.Exists(root)) return Ok(new { folders = Array.Empty<object>() });

        var folders = Directory.GetDirectories(root)
            .OrderByDescending(d => d)
            .Take(14)
            .Select(d => new
            {
                date = Path.GetFileName(d),
                path = d,
                files = Directory.GetFiles(d, "*.bak").Select(f => new {
                    file = Path.GetFileName(f),
                    sizeMb = new FileInfo(f).Length / 1024 / 1024
                }).ToList()
            })
            .ToList();
        return Ok(new { total = folders.Count, folders });
    }

    [HttpPost("run-now")]
    public async Task<IActionResult> RunNow()
    {
        var started = DateTime.UtcNow;
        var root = @"C:\Pinebi\backups";
        var folder = Path.Combine(root, DateTime.Now.ToString("yyyy-MM-dd"));
        Directory.CreateDirectory(folder);

        var tenants = new List<(string code, string dbName)>();
        await using (var conn = new SqlConnection(MasterConn))
        {
            await conn.OpenAsync();
            await using var cmd = new SqlCommand(
                "SELECT tenant_code, db_name FROM tenants WHERE status IN ('active','suspended')", conn);
            await using var rdr = await cmd.ExecuteReaderAsync();
            while (await rdr.ReadAsync())
                tenants.Add((rdr.GetString(0), rdr.GetString(1)));
        }

        var adminConn = MasterConn.Replace("Database=Pinebi_Master", "Database=master");
        var results = new List<object>();
        int ok = 0, fail = 0;

        foreach (var t in tenants)
        {
            var bakFile = Path.Combine(folder, $"{t.dbName}_{DateTime.Now:HHmmss}.bak");
            try
            {
                await using var sc = new SqlConnection(adminConn);
                await sc.OpenAsync();
                await using var bk = new SqlCommand(
                    $"BACKUP DATABASE [{t.dbName}] TO DISK = N'{bakFile}' WITH INIT, COPY_ONLY, COMPRESSION", sc);
                bk.CommandTimeout = 300;
                await bk.ExecuteNonQueryAsync();
                var size = new FileInfo(bakFile).Length / 1024 / 1024;
                results.Add(new { tenant = t.code, db = t.dbName, status = "ok", file = bakFile, sizeMb = size });
                ok++;
            }
            catch (Exception ex)
            {
                results.Add(new { tenant = t.code, db = t.dbName, status = "fail", error = ex.Message });
                fail++;
            }
        }

        await _audit.LogAsync("backup.manual", new
        {
            triggeredBy = "admin_ui",
            durationSeconds = (DateTime.UtcNow - started).TotalSeconds,
            total = tenants.Count, ok, fail
        });

        return Ok(new
        {
            folder,
            totalTenants = tenants.Count,
            success = ok,
            failed = fail,
            durationSeconds = (DateTime.UtcNow - started).TotalSeconds,
            results
        });
    }
}
