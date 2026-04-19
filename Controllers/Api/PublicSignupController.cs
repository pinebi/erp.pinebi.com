using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/public/signup")]
public class PublicSignupController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IConnectionStringProtector _protector;
    private readonly IAuditLogger _audit;
    private readonly IEmailService _email;
    private readonly ILogger<PublicSignupController> _log;

    public PublicSignupController(IConfiguration config, IConnectionStringProtector protector,
        IAuditLogger audit, IEmailService email, ILogger<PublicSignupController> log)
    {
        _config = config; _protector = protector; _audit = audit; _email = email; _log = log;
    }

    private string MasterConn => _config.GetConnectionString("Master")
        ?? "Server=185.210.92.248;Database=Pinebi_Master;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";

    /// <summary>Public endpoint: yeni tenant + owner kullanici olustur</summary>
    [HttpPost]
    public async Task<IActionResult> Signup([FromBody] SignupDto dto)
    {
        if (dto == null) return BadRequest(new { error = "BODY_REQUIRED" });

        // Validasyon
        var errors = new List<string>();
        if (string.IsNullOrWhiteSpace(dto.CompanyName)) errors.Add("companyName required");
        if (string.IsNullOrWhiteSpace(dto.Subdomain)) errors.Add("subdomain required");
        if (string.IsNullOrWhiteSpace(dto.Email) || !dto.Email.Contains('@')) errors.Add("valid email required");
        if (string.IsNullOrWhiteSpace(dto.Password) || dto.Password.Length < 6) errors.Add("password min 6 chars");
        if (string.IsNullOrWhiteSpace(dto.FullName)) errors.Add("fullName required");
        if (errors.Count > 0) return BadRequest(new { error = "VALIDATION", detail = errors });

        var subdomain = dto.Subdomain.ToLowerInvariant().Trim();
        if (!System.Text.RegularExpressions.Regex.IsMatch(subdomain, "^[a-z0-9][a-z0-9-]{1,30}$"))
            return BadRequest(new { error = "SUBDOMAIN_INVALID", detail = "Kucuk harf, rakam, tire; 2-30 karakter" });

        // Rezerve subdomain kontrolu
        var reserved = new[] { "www", "api", "admin", "erp", "erpapi", "webservice", "documents", "edonusum",
                               "mail", "ftp", "smtp", "audit", "fatura", "belge" };
        if (reserved.Contains(subdomain))
            return BadRequest(new { error = "SUBDOMAIN_RESERVED" });

        await using var master = new SqlConnection(MasterConn);
        await master.OpenAsync();

        // Benzersizlik kontrolu
        await using (var chk = new SqlCommand("SELECT COUNT(*) FROM tenants WHERE subdomain=@s AND status <> 'deleted'", master))
        {
            chk.Parameters.AddWithValue("@s", subdomain);
            if ((int)(await chk.ExecuteScalarAsync() ?? 0) > 0)
                return Conflict(new { error = "SUBDOMAIN_TAKEN" });
        }

        // Tier: default 'free'
        int tierId;
        await using (var t = new SqlCommand("SELECT tier_id FROM subscription_tiers WHERE tier_code='free'", master))
        {
            tierId = (int)(await t.ExecuteScalarAsync() ?? 1);
        }

        var tenantId = Guid.NewGuid();
        var tenantCode = subdomain.ToUpperInvariant();
        var dbName = $"Pinebi_Tenant_{tenantCode}";

        // Benzersiz tenant_code
        await using (var chk = new SqlCommand("SELECT COUNT(*) FROM tenants WHERE tenant_code=@c", master))
        {
            chk.Parameters.AddWithValue("@c", tenantCode);
            if ((int)(await chk.ExecuteScalarAsync() ?? 0) > 0)
                tenantCode = $"{subdomain.ToUpperInvariant()}-{Guid.NewGuid().ToString("N").Substring(0, 4).ToUpperInvariant()}";
        }

        // Tenant kaydi
        await using (var ins = new SqlCommand(@"
INSERT INTO tenants (tenant_id, tenant_code, tenant_name, subdomain, region_id, db_name, tier_id, status, contact_email, activated_at)
VALUES (@id, @code, @name, @sub, 'tr', @db, @tier, 'provisioning', @email, NULL)", master))
        {
            ins.Parameters.AddWithValue("@id", tenantId);
            ins.Parameters.AddWithValue("@code", tenantCode);
            ins.Parameters.AddWithValue("@name", dto.CompanyName);
            ins.Parameters.AddWithValue("@sub", subdomain);
            ins.Parameters.AddWithValue("@db", dbName);
            ins.Parameters.AddWithValue("@tier", tierId);
            ins.Parameters.AddWithValue("@email", dto.Email);
            await ins.ExecuteNonQueryAsync();
        }

        await _audit.LogAsync("tenant.self_signup", new { tenantId, subdomain, email = dto.Email, tier = "free" },
            tenantId: tenantId, actorType: "public",
            ipAddress: HttpContext?.Connection?.RemoteIpAddress?.ToString());

        // Background: DB provision + owner user + email
        _ = Task.Run(async () => await ProvisionAndSeedAsync(tenantId, subdomain, dbName, tenantCode, dto));

        return Accepted(new
        {
            tenantId,
            status = "provisioning",
            subdomain,
            loginUrl = $"https://{subdomain}.pinebi.com",
            message = "Hesabiniz olusturuluyor. 10 saniye icinde email'inize giris bilgileri gelecek."
        });
    }

    private async Task ProvisionAndSeedAsync(Guid tenantId, string subdomain, string dbName, string tenantCode, SignupDto dto)
    {
        try
        {
            var adminConn = MasterConn.Replace("Database=Pinebi_Master", "Database=master");
            var tplName = "Pinebi_Template";
            var tplLogical = "PineERP";
            var tplLogicalLog = "PineERP_log";

            // Template kontrol
            await using (var mc = new SqlConnection(adminConn))
            {
                await mc.OpenAsync();
                await using (var chk = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name=@n", mc))
                {
                    chk.Parameters.AddWithValue("@n", tplName);
                    if ((int)(await chk.ExecuteScalarAsync() ?? 0) == 0)
                    {
                        tplName = "PineERP_Yeni";
                        tplLogical = "PineERP_Yeni";
                        tplLogicalLog = "PineERP_Yeni_log";
                    }
                }

                var bakPath = $"C:\\Temp\\{tplName}_signup.bak";
                await using (var bk = new SqlCommand(
                    $"BACKUP DATABASE [{tplName}] TO DISK=N'{bakPath}' WITH INIT, COPY_ONLY, COMPRESSION", mc))
                {
                    bk.CommandTimeout = 120;
                    await bk.ExecuteNonQueryAsync();
                }

                var dataFile = $"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\{dbName}.mdf";
                var logFile = $"C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\{dbName}_log.ldf";

                await using (var rs = new SqlCommand($@"
RESTORE DATABASE [{dbName}] FROM DISK=N'{bakPath}'
WITH MOVE N'{tplLogical}' TO N'{dataFile}',
     MOVE N'{tplLogicalLog}' TO N'{logFile}',
     REPLACE", mc))
                {
                    rs.CommandTimeout = 300;
                    await rs.ExecuteNonQueryAsync();
                }
            }

            // Owner kullanici
            var tenantConnStr = $"Server=185.210.92.248;Database={dbName};User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;";
            await using (var tc = new SqlConnection(tenantConnStr))
            {
                await tc.OpenAsync();
                // Default admin'i guncelle
                await using (var upd = new SqlCommand(@"
DELETE FROM kullanicilar WHERE kullaniciadi <> 'admin';
UPDATE kullanicilar SET kullaniciadi='admin', email=@em, sifrehash=@h, adsoyad=@ad, rol='Admin'
WHERE kullaniciadi='admin'", tc))
                {
                    upd.Parameters.AddWithValue("@em", dto.Email);
                    upd.Parameters.AddWithValue("@h", Services.PasswordHasher.Hash(dto.Password));
                    upd.Parameters.AddWithValue("@ad", dto.FullName);
                    await upd.ExecuteNonQueryAsync();
                }
            }

            // Connection string (encrypted)
            var encryptedCs = _protector.Protect(tenantConnStr);
            await using (var m = new SqlConnection(MasterConn))
            {
                await m.OpenAsync();
                await using (var cs = new SqlCommand(@"
IF NOT EXISTS (SELECT 1 FROM tenant_connections WHERE tenant_id=@id)
    INSERT INTO tenant_connections (tenant_id, connection_string_encrypted) VALUES (@id, @cs);
ELSE
    UPDATE tenant_connections SET connection_string_encrypted=@cs WHERE tenant_id=@id;", m))
                {
                    cs.Parameters.AddWithValue("@id", tenantId);
                    cs.Parameters.AddWithValue("@cs", encryptedCs);
                    await cs.ExecuteNonQueryAsync();
                }
                await using (var upd = new SqlCommand(
                    "UPDATE tenants SET status='active', activated_at=SYSUTCDATETIME() WHERE tenant_id=@id", m))
                {
                    upd.Parameters.AddWithValue("@id", tenantId);
                    await upd.ExecuteNonQueryAsync();
                }
            }

            await _audit.LogAsync("tenant.signup_completed", new { tenantId, subdomain }, tenantId: tenantId);

            // Welcome mail
            var url = $"https://{subdomain}.pinebi.com";
            await _email.SendAsync(dto.Email,
                $"Pinebi ERP hesabiniz hazir - {subdomain}.pinebi.com",
                $@"<p>Merhaba {dto.FullName},</p>
<p><b>{dto.CompanyName}</b> icin Pinebi ERP hesabiniz hazir!</p>
<p><b>Giris URL:</b> <a href='{url}'>{url}</a></p>
<p><b>Kullanici adi:</b> admin<br/>
<b>Sifre:</b> (kayit sirasinda belirlediginiz)</p>
<p>Hesabiniz <b>Free</b> plan ile baslamistir. Ihtiyaciniza gore yukseltebilirsiniz.</p>
<p>Kolay gelsin,<br/>Pinebi ERP Ekibi</p>");
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Self-signup provisioning failed for {Id}", tenantId);
            await using var m = new SqlConnection(MasterConn);
            await m.OpenAsync();
            await using var upd = new SqlCommand(
                "UPDATE tenants SET status='provisioning_failed' WHERE tenant_id=@id", m);
            upd.Parameters.AddWithValue("@id", tenantId);
            await upd.ExecuteNonQueryAsync();
            await _audit.LogAsync("tenant.signup_failed", new { tenantId, error = ex.Message }, tenantId: tenantId);
        }
    }

    [HttpGet("check-subdomain/{subdomain}")]
    public async Task<IActionResult> CheckSubdomain(string subdomain)
    {
        subdomain = subdomain.ToLowerInvariant().Trim();
        if (!System.Text.RegularExpressions.Regex.IsMatch(subdomain, "^[a-z0-9][a-z0-9-]{1,30}$"))
            return Ok(new { available = false, reason = "INVALID_FORMAT" });

        var reserved = new[] { "www", "api", "admin", "erp", "erpapi", "webservice", "documents", "edonusum",
                               "mail", "ftp", "smtp", "audit", "fatura", "belge" };
        if (reserved.Contains(subdomain))
            return Ok(new { available = false, reason = "RESERVED" });

        await using var conn = new SqlConnection(MasterConn);
        await conn.OpenAsync();
        await using var cmd = new SqlCommand("SELECT COUNT(*) FROM tenants WHERE subdomain=@s AND status <> 'deleted'", conn);
        cmd.Parameters.AddWithValue("@s", subdomain);
        var count = (int)(await cmd.ExecuteScalarAsync() ?? 0);
        return Ok(new { available = count == 0, reason = count > 0 ? "TAKEN" : null });
    }
}

public sealed class SignupDto
{
    public string CompanyName { get; set; } = "";
    public string Subdomain { get; set; } = "";
    public string Email { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Password { get; set; } = "";
}
