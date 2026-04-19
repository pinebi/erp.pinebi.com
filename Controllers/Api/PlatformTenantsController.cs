using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/platform/tenants")]
public class PlatformTenantsController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly ILogger<PlatformTenantsController> _log;
    private readonly IConnectionStringProtector _protector;
    private readonly IAuditLogger _audit;

    public PlatformTenantsController(IConfiguration config, ILogger<PlatformTenantsController> log,
        IConnectionStringProtector protector, IAuditLogger audit)
    {
        _config = config;
        _log = log;
        _protector = protector;
        _audit = audit;
    }

    private string? ClientIp => HttpContext?.Connection?.RemoteIpAddress?.ToString();

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    [HttpGet]
    public async Task<IActionResult> List([FromQuery] string? status = null, [FromQuery] int limit = 50)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        var sql = @"SELECT TOP (@limit) tenant_id, tenant_code, tenant_name, subdomain, db_name, region_id, status,
                    contact_email, activated_at, created_at FROM tenants
                    WHERE (@status IS NULL OR status = @status)
                    ORDER BY created_at DESC";
        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@limit", limit);
        cmd.Parameters.AddWithValue("@status", (object?)status ?? DBNull.Value);

        var list = new List<object>();
        await using var rdr = await cmd.ExecuteReaderAsync();
        while (await rdr.ReadAsync())
        {
            list.Add(new
            {
                tenantId = rdr.GetGuid(0),
                tenantCode = rdr.GetString(1),
                tenantName = rdr.GetString(2),
                subdomain = rdr.GetString(3),
                dbName = rdr.GetString(4),
                regionId = rdr.GetString(5),
                status = rdr.GetString(6),
                contactEmail = rdr.GetString(7),
                activatedAt = rdr.IsDBNull(8) ? (DateTime?)null : rdr.GetDateTime(8),
                createdAt = rdr.GetDateTime(9)
            });
        }
        return Ok(new { total = list.Count, items = list });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTenantDto dto)
    {
        if (dto == null) return BadRequest(new { error = "BODY_REQUIRED" });
        if (string.IsNullOrWhiteSpace(dto.TenantCode)) return BadRequest(new { error = "TENANT_CODE_REQUIRED" });
        if (string.IsNullOrWhiteSpace(dto.Subdomain)) return BadRequest(new { error = "SUBDOMAIN_REQUIRED" });
        if (string.IsNullOrWhiteSpace(dto.TenantName)) return BadRequest(new { error = "TENANT_NAME_REQUIRED" });

        var subdomain = dto.Subdomain.ToLowerInvariant().Trim();
        if (!System.Text.RegularExpressions.Regex.IsMatch(subdomain, "^[a-z0-9][a-z0-9-]{1,30}$"))
            return BadRequest(new { error = "SUBDOMAIN_INVALID", detail = "Kucuk harf, rakam, tire; 2-30 karakter" });

        var region = (dto.Region ?? "tr").ToLowerInvariant();
        var tierCode = (dto.Tier ?? "starter").ToLowerInvariant();

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();

        // Validate unique
        await using (var check = new SqlCommand("SELECT COUNT(*) FROM tenants WHERE subdomain=@s OR tenant_code=@c", conn))
        {
            check.Parameters.AddWithValue("@s", subdomain);
            check.Parameters.AddWithValue("@c", dto.TenantCode);
            if ((int)(await check.ExecuteScalarAsync() ?? 0) > 0)
                return Conflict(new { error = "TENANT_EXISTS" });
        }

        // Resolve tier
        int tierId;
        await using (var t = new SqlCommand("SELECT tier_id FROM subscription_tiers WHERE tier_code=@t", conn))
        {
            t.Parameters.AddWithValue("@t", tierCode);
            var r = await t.ExecuteScalarAsync();
            if (r == null) return BadRequest(new { error = "TIER_INVALID" });
            tierId = (int)r;
        }

        // Region check
        await using (var rg = new SqlCommand("SELECT COUNT(*) FROM regions WHERE region_id=@r AND active=1", conn))
        {
            rg.Parameters.AddWithValue("@r", region);
            if ((int)(await rg.ExecuteScalarAsync() ?? 0) == 0)
                return BadRequest(new { error = "REGION_INVALID" });
        }

        var tenantId = Guid.NewGuid();
        var dbName = $"Pinebi_Tenant_{dto.TenantCode.ToUpperInvariant()}".Replace(" ", "");

        // Insert tenant (status=provisioning)
        await using (var ins = new SqlCommand(@"
INSERT INTO tenants (tenant_id, tenant_code, tenant_name, subdomain, region_id, db_name, tier_id, status, contact_email, activated_at)
VALUES (@id, @code, @name, @sub, @reg, @db, @tier, 'provisioning', @email, NULL)", conn))
        {
            ins.Parameters.AddWithValue("@id", tenantId);
            ins.Parameters.AddWithValue("@code", dto.TenantCode);
            ins.Parameters.AddWithValue("@name", dto.TenantName);
            ins.Parameters.AddWithValue("@sub", subdomain);
            ins.Parameters.AddWithValue("@reg", region);
            ins.Parameters.AddWithValue("@db", dbName);
            ins.Parameters.AddWithValue("@tier", tierId);
            ins.Parameters.AddWithValue("@email", dto.OwnerEmail ?? "");
            await ins.ExecuteNonQueryAsync();
        }

        _log.LogInformation("Tenant row created: {Id} / {Sub}. Starting provisioning...", tenantId, subdomain);
        await _audit.LogAsync("tenant.created", new { tenantId, subdomain, dbName, tier = tierCode, region },
            tenantId: tenantId, ipAddress: ClientIp);

        // Kick off provisioning (background)
        var sqlAdminConn = MasterConn.Replace("Database=Pinebi_Master", "Database=master");
        _ = Task.Run(async () => await ProvisionAsync(tenantId, subdomain, dbName, sqlAdminConn, dto));

        return Accepted(new
        {
            tenantId,
            status = "provisioning",
            subdomain,
            dbName,
            subdomainUrl = $"https://{subdomain}.pinebi.com",
            estimatedReadyAt = DateTime.UtcNow.AddSeconds(10)
        });
    }

    [HttpGet("{id:guid}/detail")]
    public async Task<IActionResult> Detail(Guid id)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();

        // Tenant + tier bilgisi
        object? tenant = null;
        await using (var t = new SqlCommand(@"
SELECT t.tenant_code, t.tenant_name, t.subdomain, t.db_name, t.region_id, t.status, t.contact_email,
       t.created_at, t.activated_at, t.suspended_at, t.vergi_no, st.tier_code, st.tier_name,
       st.max_users, st.max_storage_gb, st.max_invoices_month, st.monthly_price_usd
FROM tenants t JOIN subscription_tiers st ON t.tier_id = st.tier_id
WHERE t.tenant_id = @id", conn))
        {
            t.Parameters.AddWithValue("@id", id);
            await using var rdr = await t.ExecuteReaderAsync();
            if (!await rdr.ReadAsync()) return NotFound();
            tenant = new
            {
                tenantCode = rdr.GetString(0),
                tenantName = rdr.GetString(1),
                subdomain = rdr.GetString(2),
                dbName = rdr.GetString(3),
                regionId = rdr.GetString(4),
                status = rdr.GetString(5),
                contactEmail = rdr.GetString(6),
                createdAt = rdr.GetDateTime(7),
                activatedAt = rdr.IsDBNull(8) ? (DateTime?)null : rdr.GetDateTime(8),
                suspendedAt = rdr.IsDBNull(9) ? (DateTime?)null : rdr.GetDateTime(9),
                vergiNo = rdr.IsDBNull(10) ? null : rdr.GetString(10),
                tier = new
                {
                    code = rdr.GetString(11),
                    name = rdr.GetString(12),
                    maxUsers = rdr.GetInt32(13),
                    maxStorageGb = rdr.GetInt32(14),
                    maxInvoicesMonth = rdr.GetInt32(15),
                    monthlyPriceUsd = rdr.GetDecimal(16)
                }
            };
        }

        // API keyleri
        var apiKeys = new List<object>();
        await using (var k = new SqlCommand(@"
SELECT api_key_id, key_prefix, description, scopes, active, created_at, last_used_at
FROM api_keys WHERE tenant_id=@id ORDER BY created_at DESC", conn))
        {
            k.Parameters.AddWithValue("@id", id);
            await using var rdr = await k.ExecuteReaderAsync();
            while (await rdr.ReadAsync())
                apiKeys.Add(new
                {
                    keyId = rdr.GetGuid(0),
                    prefix = rdr.GetString(1),
                    description = rdr.IsDBNull(2) ? null : rdr.GetString(2),
                    scopes = rdr.GetString(3),
                    active = rdr.GetBoolean(4),
                    createdAt = rdr.GetDateTime(5),
                    lastUsedAt = rdr.IsDBNull(6) ? (DateTime?)null : rdr.GetDateTime(6)
                });
        }

        // Son audit olaylari
        var events = new List<object>();
        await using (var e = new SqlCommand(@"
SELECT TOP 20 occurred_at, event_type, actor_type, details_json
FROM control_audit_events WHERE tenant_id=@id ORDER BY event_id DESC", conn))
        {
            e.Parameters.AddWithValue("@id", id);
            await using var rdr = await e.ExecuteReaderAsync();
            while (await rdr.ReadAsync())
                events.Add(new
                {
                    occurredAt = rdr.GetDateTime(0),
                    eventType = rdr.GetString(1),
                    actorType = rdr.GetString(2),
                    details = rdr.GetString(3).Length > 120 ? rdr.GetString(3).Substring(0, 120) + "..." : rdr.GetString(3)
                });
        }

        // Davetler
        var invites = new List<object>();
        await using (var i = new SqlCommand(@"
SELECT invite_id, email, kullanici_adi, rol, expires_at, accepted_at, revoked_at, created_at
FROM user_invites WHERE tenant_id=@id ORDER BY created_at DESC", conn))
        {
            i.Parameters.AddWithValue("@id", id);
            await using var rdr = await i.ExecuteReaderAsync();
            while (await rdr.ReadAsync())
                invites.Add(new
                {
                    inviteId = rdr.GetGuid(0),
                    email = rdr.GetString(1),
                    kullaniciAdi = rdr.GetString(2),
                    rol = rdr.GetString(3),
                    expiresAt = rdr.GetDateTime(4),
                    acceptedAt = rdr.IsDBNull(5) ? (DateTime?)null : rdr.GetDateTime(5),
                    revokedAt = rdr.IsDBNull(6) ? (DateTime?)null : rdr.GetDateTime(6),
                    createdAt = rdr.GetDateTime(7)
                });
        }

        return Ok(new { tenant, apiKeys, events, invites });
    }

    [HttpPost("{id:guid}/change-tier")]
    public async Task<IActionResult> ChangeTier(Guid id, [FromBody] ChangeTierDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.NewTier)) return BadRequest(new { error = "NEW_TIER_REQUIRED" });

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();

        int newTierId;
        await using (var q = new SqlCommand("SELECT tier_id FROM subscription_tiers WHERE tier_code=@t AND active=1", conn))
        {
            q.Parameters.AddWithValue("@t", dto.NewTier.ToLowerInvariant());
            var r = await q.ExecuteScalarAsync();
            if (r == null) return BadRequest(new { error = "TIER_INVALID" });
            newTierId = (int)r;
        }

        await using (var upd = new SqlCommand(
            "UPDATE tenants SET tier_id=@t WHERE tenant_id=@id", conn))
        {
            upd.Parameters.AddWithValue("@t", newTierId);
            upd.Parameters.AddWithValue("@id", id);
            var n = await upd.ExecuteNonQueryAsync();
            if (n == 0) return NotFound();
        }

        await _audit.LogAsync("tenant.tier_changed", new { tenantId = id, newTier = dto.NewTier },
            tenantId: id, ipAddress: ClientIp);

        return Ok(new { tenantId = id, newTier = dto.NewTier });
    }

    [HttpGet("{id:guid}/status")]
    public async Task<IActionResult> Status(Guid id)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(
            "SELECT tenant_code, subdomain, status, activated_at FROM tenants WHERE tenant_id=@id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        await using var rdr = await cmd.ExecuteReaderAsync();
        if (!await rdr.ReadAsync()) return NotFound();
        return Ok(new
        {
            tenantCode = rdr.GetString(0),
            subdomain = rdr.GetString(1),
            status = rdr.GetString(2),
            activatedAt = rdr.IsDBNull(3) ? (DateTime?)null : rdr.GetDateTime(3)
        });
    }

    [HttpPost("{id:guid}/suspend")]
    public async Task<IActionResult> Suspend(Guid id, [FromBody] TenantActionDto? dto)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(
            "UPDATE tenants SET status='suspended', suspended_at=SYSUTCDATETIME() WHERE tenant_id=@id AND status <> 'deleted'", conn);
        cmd.Parameters.AddWithValue("@id", id);
        var n = await cmd.ExecuteNonQueryAsync();
        if (n == 0) return NotFound();
        await _audit.LogAsync("tenant.suspended", new { tenantId = id, reason = dto?.Reason }, tenantId: id, ipAddress: ClientIp);
        return Ok(new { status = "suspended", suspendedAt = DateTime.UtcNow });
    }

    [HttpPost("{id:guid}/reactivate")]
    public async Task<IActionResult> Reactivate(Guid id)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand(
            "UPDATE tenants SET status='active', suspended_at=NULL WHERE tenant_id=@id AND status='suspended'", conn);
        cmd.Parameters.AddWithValue("@id", id);
        var n = await cmd.ExecuteNonQueryAsync();
        if (n == 0) return NotFound(new { error = "NOT_SUSPENDED_OR_NOT_FOUND" });
        await _audit.LogAsync("tenant.reactivated", new { tenantId = id }, tenantId: id, ipAddress: ClientIp);
        return Ok(new { status = "active" });
    }

    /// <summary>Soft delete: status=deleted, 30 gun sonra DROP DATABASE cronla yapilir</summary>
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, [FromQuery] bool hard = false)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();

        // Tenant ve db adi oku
        string? dbName = null;
        string? subdomain = null;
        await using (var q = new SqlCommand("SELECT db_name, subdomain FROM tenants WHERE tenant_id=@id", conn))
        {
            q.Parameters.AddWithValue("@id", id);
            await using var rdr = await q.ExecuteReaderAsync();
            if (!await rdr.ReadAsync()) return NotFound();
            dbName = rdr.GetString(0);
            subdomain = rdr.GetString(1);
        }

        await using (var upd = new SqlCommand(
            "UPDATE tenants SET status='deleted', deleted_at=SYSUTCDATETIME() WHERE tenant_id=@id", conn))
        {
            upd.Parameters.AddWithValue("@id", id);
            await upd.ExecuteNonQueryAsync();
        }

        if (hard)
        {
            var adminConn = MasterConn.Replace("Database=Pinebi_Master", "Database=master");
            try
            {
                await using var mc = new SqlConnection(adminConn);
                await mc.OpenAsync();

                // Son yedek al
                var bakPath = $"C:\\Temp\\deleted_{subdomain}_{DateTime.UtcNow:yyyyMMdd_HHmmss}.bak";
                await using (var bk = new SqlCommand($"BACKUP DATABASE [{dbName}] TO DISK=N'{bakPath}' WITH INIT, COPY_ONLY, COMPRESSION", mc))
                {
                    bk.CommandTimeout = 120;
                    await bk.ExecuteNonQueryAsync();
                }

                await using (var drop = new SqlCommand($"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [{dbName}];", mc))
                {
                    drop.CommandTimeout = 60;
                    await drop.ExecuteNonQueryAsync();
                }

                await _audit.LogAsync("tenant.hard_deleted", new { tenantId = id, dbName, backupPath = bakPath }, tenantId: id, ipAddress: ClientIp);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Hard delete failed for {Id}", id);
                return StatusCode(500, new { error = "HARD_DELETE_FAILED", detail = ex.Message });
            }
        }
        else
        {
            await _audit.LogAsync("tenant.soft_deleted", new { tenantId = id, dbName }, tenantId: id, ipAddress: ClientIp);
        }

        return Ok(new { status = "deleted", hard });
    }

    [HttpPost("{id:guid}/api-key")]
    public async Task<IActionResult> CreateApiKey(Guid id, [FromBody] CreateApiKeyDto? dto)
    {
        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();

        string subdomain;
        await using (var q = new SqlCommand("SELECT subdomain FROM tenants WHERE tenant_id=@id", conn))
        {
            q.Parameters.AddWithValue("@id", id);
            var r = await q.ExecuteScalarAsync() as string;
            if (r == null) return NotFound();
            subdomain = r;
        }

        var random = RandomKey(24);
        var fullKey = $"pbk_{subdomain}_{random}";
        var prefix = fullKey.Length >= 9 ? fullKey.Substring(0, 9) : fullKey;
        var hash = HashKey(fullKey);

        await using var ins = new SqlCommand(@"
INSERT INTO api_keys (tenant_id, key_prefix, key_hash, description, scopes)
VALUES (@id, @p, @h, @d, @s)", conn);
        ins.Parameters.AddWithValue("@id", id);
        ins.Parameters.AddWithValue("@p", prefix);
        ins.Parameters.AddWithValue("@h", hash);
        ins.Parameters.AddWithValue("@d", (object?)dto?.Description ?? DBNull.Value);
        ins.Parameters.AddWithValue("@s", dto?.Scopes ?? "read,write");
        await ins.ExecuteNonQueryAsync();

        await _audit.LogAsync("apikey.created", new { tenantId = id, prefix, description = dto?.Description },
            tenantId: id, ipAddress: ClientIp);

        return Ok(new { apiKey = fullKey, note = "Bu anahtari simdi kaydet, tekrar gosterilmez." });
    }

    // ============ Private provisioning ============

    private async Task ProvisionAsync(Guid tenantId, string subdomain, string dbName, string adminConnStr, CreateTenantDto dto)
    {
        try
        {
            var tplName = "Pinebi_Template";
            var tplLogicalName = "PineERP";      // Pinebi_Template backup icindeki logical adlar
            var tplLogicalLogName = "PineERP_log";

            await using (var masterConn = new SqlConnection(adminConnStr))
            {
                await masterConn.OpenAsync();

                await using (var chk = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name=@n", masterConn))
                {
                    chk.Parameters.AddWithValue("@n", tplName);
                    if ((int)(await chk.ExecuteScalarAsync() ?? 0) == 0)
                    {
                        tplName = "PineERP_Yeni"; // fallback
                        tplLogicalName = "PineERP_Yeni";
                        tplLogicalLogName = "PineERP_Yeni_log";
                    }
                }

                // Template backup -> restore as new DB
                var bakPath = $"C:\\Temp\\{tplName}_tpl.bak";
                await using (var bk = new SqlCommand($"BACKUP DATABASE [{tplName}] TO DISK=N'{bakPath}' WITH INIT, COPY_ONLY, COMPRESSION", masterConn))
                {
                    bk.CommandTimeout = 120;
                    await bk.ExecuteNonQueryAsync();
                }

                var dataFile = $"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\{dbName}.mdf";
                var logFile = $"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\{dbName}_log.ldf";

                var restoreSql = $@"
RESTORE DATABASE [{dbName}] FROM DISK=N'{bakPath}'
WITH MOVE N'{tplLogicalName}' TO N'{dataFile}',
     MOVE N'{tplLogicalLogName}' TO N'{logFile}',
     REPLACE";
                await using (var rs = new SqlCommand(restoreSql, masterConn))
                {
                    rs.CommandTimeout = 300;
                    await rs.ExecuteNonQueryAsync();
                }
            }

            // Insert connection string
            await using (var mc = new SqlConnection(MasterConn))
            {
                await mc.OpenAsync();
                var tenantConnStr = $"Server=185.210.92.248;Database={dbName};User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
                var encrypted = _protector.Protect(tenantConnStr);
                await using (var cs = new SqlCommand(@"
IF NOT EXISTS (SELECT 1 FROM tenant_connections WHERE tenant_id=@id)
    INSERT INTO tenant_connections (tenant_id, connection_string_encrypted)
    VALUES (@id, @cs);
ELSE
    UPDATE tenant_connections SET connection_string_encrypted=@cs WHERE tenant_id=@id;", mc))
                {
                    cs.Parameters.AddWithValue("@id", tenantId);
                    cs.Parameters.AddWithValue("@cs", encrypted);
                    await cs.ExecuteNonQueryAsync();
                }

                // Mark active
                await using (var upd = new SqlCommand(
                    "UPDATE tenants SET status='active', activated_at=SYSUTCDATETIME() WHERE tenant_id=@id", mc))
                {
                    upd.Parameters.AddWithValue("@id", tenantId);
                    await upd.ExecuteNonQueryAsync();
                }
            }

            _log.LogInformation("Tenant {Id} provisioned: {Db}", tenantId, dbName);
            await _audit.LogAsync("tenant.provisioned", new { tenantId, dbName, subdomain }, tenantId: tenantId);

            // IIS binding otomatik ekle (subdomain.pinebi.com)
            await TryAddIisBindingAsync(subdomain);
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Provisioning failed for {Id}", tenantId);
            try
            {
                await using var mc = new SqlConnection(MasterConn);
                await mc.OpenAsync();
                await using var upd = new SqlCommand(
                    "UPDATE tenants SET status='provisioning_failed' WHERE tenant_id=@id", mc);
                upd.Parameters.AddWithValue("@id", tenantId);
                await upd.ExecuteNonQueryAsync();
            }
            catch { }
        }
    }

    private async Task TryAddIisBindingAsync(string subdomain)
    {
        try
        {
            var host = $"{subdomain}.pinebi.com";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = @"C:\Windows\System32\inetsrv\appcmd.exe",
                Arguments = $"set site \"erp.pinebi.com\" \"/+bindings.[protocol='http',bindingInformation='*:80:{host}']\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            using var proc = System.Diagnostics.Process.Start(psi);
            if (proc != null)
            {
                await proc.WaitForExitAsync();
                var output = await proc.StandardOutput.ReadToEndAsync();
                var err = await proc.StandardError.ReadToEndAsync();
                if (proc.ExitCode == 0)
                {
                    _log.LogInformation("IIS binding eklendi: {Host}", host);
                    await _audit.LogAsync("iis.binding_added", new { subdomain, host });
                }
                else
                {
                    _log.LogWarning("IIS binding eklenemedi {Host}. ExitCode={Code} Stdout={Out} Err={Err}", host, proc.ExitCode, output, err);
                    await _audit.LogAsync("iis.binding_failed", new { subdomain, host, exitCode = proc.ExitCode, output, err });
                }
            }
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "IIS binding hatasi (zararsiz): {Subdomain}", subdomain);
        }
    }

    private static string HashKey(string key)
    {
        var bytes = Encoding.Unicode.GetBytes(key);
        var hash = SHA256.HashData(bytes);
        return Convert.ToHexString(hash);
    }

    private static string RandomKey(int chars)
    {
        const string alphabet = "abcdefghijkmnpqrstuvwxyz23456789";
        var bytes = RandomNumberGenerator.GetBytes(chars);
        var sb = new StringBuilder(chars);
        foreach (var b in bytes) sb.Append(alphabet[b % alphabet.Length]);
        return sb.ToString();
    }
}

public sealed class CreateTenantDto
{
    public string TenantCode { get; set; } = "";
    public string TenantName { get; set; } = "";
    public string Subdomain { get; set; } = "";
    public string? Region { get; set; }
    public string? Tier { get; set; }
    public string? OwnerEmail { get; set; }
    public string? OwnerName { get; set; }
}

public sealed class CreateApiKeyDto
{
    public string? Description { get; set; }
    public string? Scopes { get; set; }
}

public sealed class TenantActionDto
{
    public string? Reason { get; set; }
}

public sealed class ChangeTierDto
{
    public string NewTier { get; set; } = "";
}
