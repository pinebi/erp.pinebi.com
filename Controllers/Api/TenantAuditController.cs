using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Tenant kendi audit event'lerini goruntuler (platform genelindeki degil).
/// </summary>
[ApiController]
[Route("api/tenant/audit")]
public class TenantAuditController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly TenantAccessor _tenant;

    public TenantAuditController(IConfiguration config, TenantAccessor tenant)
    {
        _config = config; _tenant = tenant;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    [HttpGet]
    public async Task<IActionResult> List([FromQuery] int limit = 100, [FromQuery] string? eventType = null)
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        var list = new List<object>();
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        var sql = @"
SELECT TOP (@limit) occurred_at, event_type, actor_type, actor_id, details_json, ip_address
FROM control_audit_events
WHERE tenant_id = @tid
  AND (@et IS NULL OR event_type = @et)
ORDER BY event_id DESC";
        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@limit", Math.Min(limit, 500));
        cmd.Parameters.AddWithValue("@tid", ctx.TenantId);
        cmd.Parameters.AddWithValue("@et", (object?)eventType ?? DBNull.Value);

        await using var rdr = await cmd.ExecuteReaderAsync();
        while (await rdr.ReadAsync())
        {
            list.Add(new
            {
                occurredAt = rdr.GetDateTime(0),
                eventType = rdr.GetString(1),
                actorType = rdr.GetString(2),
                actorId = rdr.IsDBNull(3) ? (Guid?)null : rdr.GetGuid(3),
                details = rdr.GetString(4),
                ip = rdr.IsDBNull(5) ? null : rdr.GetString(5)
            });
        }
        return Ok(list);
    }

    [HttpGet("event-types")]
    public async Task<IActionResult> EventTypes()
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        var list = new List<object>();
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(@"
SELECT event_type, COUNT(*) AS c
FROM control_audit_events
WHERE tenant_id = @tid
GROUP BY event_type
ORDER BY c DESC", conn);
        cmd.Parameters.AddWithValue("@tid", ctx.TenantId);
        await using var rdr = await cmd.ExecuteReaderAsync();
        while (await rdr.ReadAsync())
            list.Add(new { eventType = rdr.GetString(0), count = rdr.GetInt32(1) });
        return Ok(list);
    }
}
