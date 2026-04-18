using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.MultiTenant;

public interface IAuditLogger
{
    Task LogAsync(string eventType, object? details = null, Guid? tenantId = null,
                  string actorType = "system", Guid? actorId = null, string? ipAddress = null,
                  CancellationToken ct = default);
}

public sealed class AuditLogger : IAuditLogger
{
    private readonly string _masterConn;
    private readonly ILogger<AuditLogger> _log;

    public AuditLogger(IConfiguration config, ILogger<AuditLogger> log)
    {
        _masterConn = config.GetConnectionString("Master")
            ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
        _log = log;
    }

    public async Task LogAsync(string eventType, object? details = null, Guid? tenantId = null,
                               string actorType = "system", Guid? actorId = null, string? ipAddress = null,
                               CancellationToken ct = default)
    {
        try
        {
            await using var conn = new SqlConnection(_masterConn);
            await conn.OpenAsync(ct);
            await using var cmd = new SqlCommand(@"
INSERT INTO control_audit_events (occurred_at, actor_type, actor_id, tenant_id, event_type, details_json, ip_address)
VALUES (SYSUTCDATETIME(), @actorType, @actorId, @tenantId, @eventType, @details, @ip)", conn);
            cmd.Parameters.AddWithValue("@actorType", actorType);
            cmd.Parameters.AddWithValue("@actorId", (object?)actorId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@tenantId", (object?)tenantId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@eventType", eventType);
            cmd.Parameters.AddWithValue("@details", JsonSerializer.Serialize(details ?? new { }));
            cmd.Parameters.AddWithValue("@ip", (object?)ipAddress ?? DBNull.Value);
            await cmd.ExecuteNonQueryAsync(ct);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Audit log yazilamadi: {EventType}", eventType);
        }
    }
}
