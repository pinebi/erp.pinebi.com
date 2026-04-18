using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// Uygulama acilisinda mevcut plain-text connection string'leri sifreler.
/// Bir kez calisir, zaten sifreli olanlari dokunmaz.
/// </summary>
public sealed class ConnectionStringEncryptionStartupService : IHostedService
{
    private readonly IConnectionStringProtector _protector;
    private readonly IConfiguration _config;
    private readonly ILogger<ConnectionStringEncryptionStartupService> _log;

    public ConnectionStringEncryptionStartupService(
        IConnectionStringProtector protector,
        IConfiguration config,
        ILogger<ConnectionStringEncryptionStartupService> log)
    {
        _protector = protector;
        _config = config;
        _log = log;
    }

    public async Task StartAsync(CancellationToken ct)
    {
        try
        {
            var masterConn = _config.GetConnectionString("Master")
                ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

            await using var conn = new SqlConnection(masterConn);
            await conn.OpenAsync(ct);

            // Select all connection strings
            var rows = new List<(Guid id, string cs)>();
            await using (var sel = new SqlCommand("SELECT tenant_id, connection_string_encrypted FROM tenant_connections", conn))
            await using (var rdr = await sel.ExecuteReaderAsync(ct))
            {
                while (await rdr.ReadAsync(ct))
                    rows.Add((rdr.GetGuid(0), rdr.GetString(1)));
            }

            int encrypted = 0;
            foreach (var (id, cs) in rows)
            {
                if (_protector.IsProtected(cs)) continue;
                var enc = _protector.Protect(cs);
                await using var upd = new SqlCommand(
                    "UPDATE tenant_connections SET connection_string_encrypted=@cs, last_rotation_at=SYSUTCDATETIME() WHERE tenant_id=@id", conn);
                upd.Parameters.AddWithValue("@cs", enc);
                upd.Parameters.AddWithValue("@id", id);
                await upd.ExecuteNonQueryAsync(ct);
                encrypted++;
            }

            if (encrypted > 0)
                _log.LogInformation("Migrated {N} tenant connection string(s) to encrypted form", encrypted);
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Connection string encryption migration failed");
        }
    }

    public Task StopAsync(CancellationToken ct) => Task.CompletedTask;
}
