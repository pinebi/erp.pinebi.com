using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// Her gece 03:00'te tum aktif tenant DB'lerini yedekler.
/// Konum: C:\Pinebi\backups\yyyy-MM-dd\*.bak
/// Retention: son 14 gun.
/// </summary>
public sealed class TenantBackupService : BackgroundService
{
    private readonly string _masterConn;
    private readonly IAuditLogger _audit;
    private readonly ILogger<TenantBackupService> _log;
    private readonly string _backupRoot = @"C:\Pinebi\backups";
    private readonly TimeSpan _runAt = new(3, 0, 0); // 03:00
    private readonly int _retentionDays = 14;

    public TenantBackupService(IConfiguration config, IAuditLogger audit, ILogger<TenantBackupService> log)
    {
        _masterConn = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _audit = audit;
        _log = log;
        Directory.CreateDirectory(_backupRoot);
    }

    protected override async Task ExecuteAsync(CancellationToken stop)
    {
        while (!stop.IsCancellationRequested)
        {
            var now = DateTime.Now;
            var next = now.Date.Add(_runAt);
            if (next <= now) next = next.AddDays(1);
            var wait = next - now;

            _log.LogInformation("Next tenant backup run in {Wait}", wait);
            try { await Task.Delay(wait, stop); }
            catch (TaskCanceledException) { return; }

            await RunBackupsAsync(stop);
            await CleanOldBackupsAsync(stop);
        }
    }

    private async Task RunBackupsAsync(CancellationToken ct)
    {
        var started = DateTime.UtcNow;
        var folder = Path.Combine(_backupRoot, DateTime.Now.ToString("yyyy-MM-dd"));
        Directory.CreateDirectory(folder);

        var tenants = new List<(Guid id, string code, string dbName)>();
        try
        {
            await using var conn = new SqlConnection(_masterConn);
            await conn.OpenAsync(ct);
            await using var cmd = new SqlCommand(
                "SELECT tenant_id, tenant_code, db_name FROM tenants WHERE status IN ('active','suspended')", conn);
            await using var rdr = await cmd.ExecuteReaderAsync(ct);
            while (await rdr.ReadAsync(ct))
                tenants.Add((rdr.GetGuid(0), rdr.GetString(1), rdr.GetString(2)));
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Backup: tenant listesi alinamadi");
            return;
        }

        var adminConn = _masterConn.Replace("Database=Pinebi_Master", "Database=master");
        int ok = 0, fail = 0;

        foreach (var t in tenants)
        {
            try
            {
                var bakFile = Path.Combine(folder, $"{t.dbName}_{DateTime.Now:HHmmss}.bak");
                await using var sc = new SqlConnection(adminConn);
                await sc.OpenAsync(ct);
                await using var bk = new SqlCommand(
                    $"BACKUP DATABASE [{t.dbName}] TO DISK = N'{bakFile}' WITH INIT, COPY_ONLY, COMPRESSION", sc);
                bk.CommandTimeout = 300;
                await bk.ExecuteNonQueryAsync(ct);
                ok++;
                _log.LogInformation("Backup OK: {Db} -> {File}", t.dbName, bakFile);
            }
            catch (Exception ex)
            {
                fail++;
                _log.LogError(ex, "Backup FAIL: {Db}", t.dbName);
                await _audit.LogAsync("backup.failed", new { tenantId = t.id, db = t.dbName, error = ex.Message });
            }
        }

        await _audit.LogAsync("backup.completed", new
        {
            durationSeconds = (DateTime.UtcNow - started).TotalSeconds,
            totalTenants = tenants.Count,
            success = ok,
            failed = fail,
            folder
        });
    }

    private Task CleanOldBackupsAsync(CancellationToken ct)
    {
        try
        {
            var cutoff = DateTime.Now.AddDays(-_retentionDays);
            var dirs = Directory.GetDirectories(_backupRoot);
            foreach (var dir in dirs)
            {
                var name = Path.GetFileName(dir);
                if (!DateTime.TryParseExact(name, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out var date))
                    continue;
                if (date < cutoff)
                {
                    try { Directory.Delete(dir, true); _log.LogInformation("Old backup deleted: {Dir}", dir); }
                    catch (Exception ex) { _log.LogWarning(ex, "Cannot delete old backup: {Dir}", dir); }
                }
            }
        }
        catch (Exception ex) { _log.LogWarning(ex, "Backup cleanup failed"); }
        return Task.CompletedTask;
    }
}
