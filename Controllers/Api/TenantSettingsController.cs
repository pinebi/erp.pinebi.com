using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Tenant kendi ayarlarini yonetir (firma adi, logo, renk, vergi no vb)
/// Master DB'deki tenants tablosunu gunceller.
/// </summary>
[ApiController]
[Route("api/tenant/settings")]
public class TenantSettingsController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly TenantAccessor _tenant;
    private readonly IAuditLogger _audit;

    public TenantSettingsController(IConfiguration config, TenantAccessor tenant, IAuditLogger audit)
    {
        _config = config; _tenant = tenant; _audit = audit;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(@"
SELECT tenant_name, subdomain, vergi_no, ulke_kodu, timezone, locale, currency,
       logo_url, primary_color, contact_email, contact_phone
FROM tenants WHERE tenant_id = @id", conn);
        cmd.Parameters.AddWithValue("@id", ctx.TenantId);
        await using var rdr = await cmd.ExecuteReaderAsync();
        if (!await rdr.ReadAsync()) return NotFound();

        return Ok(new
        {
            tenantName = rdr.GetString(0),
            subdomain = rdr.GetString(1),
            vergiNo = rdr.IsDBNull(2) ? null : rdr.GetString(2),
            ulkeKodu = rdr.IsDBNull(3) ? null : rdr.GetString(3),
            timezone = rdr.GetString(4),
            locale = rdr.GetString(5),
            currency = rdr.GetString(6),
            logoUrl = rdr.IsDBNull(7) ? null : rdr.GetString(7),
            primaryColor = rdr.GetString(8),
            contactEmail = rdr.GetString(9),
            contactPhone = rdr.IsDBNull(10) ? null : rdr.GetString(10)
        });
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SettingsDto dto)
    {
        var ctx = _tenant.Current;
        if (ctx == null) return BadRequest();

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(@"
UPDATE tenants SET
    tenant_name = ISNULL(@name, tenant_name),
    vergi_no = @vergi,
    ulke_kodu = ISNULL(@ulke, ulke_kodu),
    timezone = ISNULL(@tz, timezone),
    locale = ISNULL(@loc, locale),
    currency = ISNULL(@cur, currency),
    logo_url = @logo,
    primary_color = ISNULL(@color, primary_color),
    contact_email = ISNULL(@email, contact_email),
    contact_phone = @phone
WHERE tenant_id = @id", conn);
        cmd.Parameters.AddWithValue("@id", ctx.TenantId);
        cmd.Parameters.AddWithValue("@name", (object?)dto.TenantName ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@vergi", (object?)dto.VergiNo ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ulke", (object?)dto.UlkeKodu ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@tz", (object?)dto.Timezone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@loc", (object?)dto.Locale ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@cur", (object?)dto.Currency ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@logo", (object?)dto.LogoUrl ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@color", (object?)dto.PrimaryColor ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@email", (object?)dto.ContactEmail ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@phone", (object?)dto.ContactPhone ?? DBNull.Value);
        await cmd.ExecuteNonQueryAsync();

        await _audit.LogAsync("tenant.settings_updated", new { tenantId = ctx.TenantId }, tenantId: ctx.TenantId);
        return Ok(new { updated = true });
    }
}

public sealed class SettingsDto
{
    public string? TenantName { get; set; }
    public string? VergiNo { get; set; }
    public string? UlkeKodu { get; set; }
    public string? Timezone { get; set; }
    public string? Locale { get; set; }
    public string? Currency { get; set; }
    public string? LogoUrl { get; set; }
    public string? PrimaryColor { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
}
