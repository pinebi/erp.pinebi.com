# 05 · C# / ASP.NET Core Kod İskeletleri

Mimarinin çekirdeğini oluşturacak sınıflar. Gerçek implementasyonda
EF Core, dependency injection, logging, auth middleware'ler eklenir.

## 1. TenantContext (HTTP istek boyunca geçerli)

```csharp
namespace Pinebi.MultiTenant;

public sealed class TenantContext
{
    public Guid TenantId { get; init; }
    public string TenantCode { get; init; } = "";
    public string DbName { get; init; } = "";
    public string ConnectionString { get; init; } = "";
    public string Region { get; init; } = "";
    public string Tier { get; init; } = "";
    public TenantStatus Status { get; init; }
    public string Locale { get; init; } = "tr-TR";
    public string Currency { get; init; } = "TRY";
}

public enum TenantStatus
{
    Provisioning,
    Active,
    Suspended,
    Deleted
}
```

## 2. ITenantResolver — her istekte tenant'ı tespit et

```csharp
public interface ITenantResolver
{
    Task<TenantContext?> ResolveAsync(HttpContext http, CancellationToken ct);
}

public sealed class SubdomainTenantResolver : ITenantResolver
{
    private readonly IMasterDbContextFactory _masterFactory;
    private readonly IMemoryCache _cache;

    public SubdomainTenantResolver(IMasterDbContextFactory masterFactory, IMemoryCache cache)
    {
        _masterFactory = masterFactory;
        _cache = cache;
    }

    public async Task<TenantContext?> ResolveAsync(HttpContext http, CancellationToken ct)
    {
        // 1) Host'tan subdomain çıkar: "acme.erp.pinebi.com" → "acme"
        var host = http.Request.Host.Host;
        var subdomain = ExtractSubdomain(host);
        if (string.IsNullOrEmpty(subdomain)) return null;

        // 2) Cache kontrol (60 sn TTL)
        if (_cache.TryGetValue($"tenant:{subdomain}", out TenantContext? cached))
            return cached;

        // 3) Master DB'den çek
        await using var master = await _masterFactory.CreateAsync(ct);
        var tenant = await master.Tenants
            .Join(master.TenantConnections, t => t.TenantId, c => c.TenantId,
                  (t, c) => new { Tenant = t, Conn = c })
            .Where(x => x.Tenant.Subdomain == subdomain && x.Tenant.Status != "deleted")
            .FirstOrDefaultAsync(ct);

        if (tenant == null) return null;

        var ctx = new TenantContext
        {
            TenantId = tenant.Tenant.TenantId,
            TenantCode = tenant.Tenant.TenantCode,
            DbName = tenant.Tenant.DbName,
            Region = tenant.Tenant.RegionId,
            Status = Enum.Parse<TenantStatus>(tenant.Tenant.Status, true),
            ConnectionString = DecryptConnString(tenant.Conn.ConnectionStringEncrypted),
            Locale = tenant.Tenant.Locale,
            Currency = tenant.Tenant.Currency,
        };

        _cache.Set($"tenant:{subdomain}", ctx, TimeSpan.FromSeconds(60));
        return ctx;
    }

    private static string ExtractSubdomain(string host)
    {
        // "acme.erp.pinebi.com" → "acme"
        // "erp.pinebi.com" → "" (kök domain, platform admin için)
        var parts = host.Split('.');
        return parts.Length > 3 ? parts[0] : "";
    }

    private static string DecryptConnString(byte[] encrypted)
    {
        // DPAPI veya Azure Key Vault ile decrypt
        throw new NotImplementedException("Üretimde Azure Key Vault / DPAPI kullan");
    }
}
```

## 3. TenantMiddleware — pipeline'a bağla

```csharp
public sealed class TenantMiddleware
{
    private readonly RequestDelegate _next;
    public TenantMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext ctx, ITenantResolver resolver, TenantAccessor accessor)
    {
        // Platform admin veya public path'lerde tenant aranmaz
        if (IsPublicPath(ctx.Request.Path))
        {
            await _next(ctx);
            return;
        }

        var tenant = await resolver.ResolveAsync(ctx, ctx.RequestAborted);
        if (tenant == null)
        {
            ctx.Response.StatusCode = 404;
            await ctx.Response.WriteAsync("Tenant not found");
            return;
        }

        if (tenant.Status == TenantStatus.Suspended && IsWriteOperation(ctx))
        {
            ctx.Response.StatusCode = 423;
            await ctx.Response.WriteAsync("Tenant suspended (read-only)");
            return;
        }

        accessor.Current = tenant;
        await _next(ctx);
    }

    static bool IsPublicPath(PathString path) =>
        path.StartsWithSegments("/_framework") ||
        path.StartsWithSegments("/health") ||
        path.StartsWithSegments("/favicon.ico");

    static bool IsWriteOperation(HttpContext ctx) =>
        ctx.Request.Method is "POST" or "PUT" or "DELETE" or "PATCH";
}

public sealed class TenantAccessor
{
    private static readonly AsyncLocal<TenantContext?> _current = new();
    public TenantContext? Current { get => _current.Value; set => _current.Value = value; }
}
```

## 4. Dynamic DbContext Factory

```csharp
public interface ITenantDbContextFactory
{
    Task<PineDbContext> CreateAsync(CancellationToken ct = default);
}

public sealed class TenantDbContextFactory : ITenantDbContextFactory
{
    private readonly TenantAccessor _tenant;

    public TenantDbContextFactory(TenantAccessor tenant) => _tenant = tenant;

    public Task<PineDbContext> CreateAsync(CancellationToken ct = default)
    {
        var tenant = _tenant.Current
            ?? throw new InvalidOperationException("Tenant bu istek için tespit edilemedi.");

        var options = new DbContextOptionsBuilder<PineDbContext>()
            .UseSqlServer(tenant.ConnectionString, sql =>
            {
                sql.EnableRetryOnFailure(3);
                sql.CommandTimeout(60);
            })
            .Options;

        return Task.FromResult(new PineDbContext(options));
    }
}

// PineDbContext - tenant şeması için (Mikro-uyumlu tablolar)
public sealed class PineDbContext : DbContext
{
    public PineDbContext(DbContextOptions<PineDbContext> opts) : base(opts) { }

    public DbSet<Stok> Stoklar => Set<Stok>();
    public DbSet<CariHesap> CariHesaplar => Set<CariHesap>();
    public DbSet<Fatura> Faturalar => Set<Fatura>();
    // ... tüm Mikro-uyumlu entity'ler
}
```

## 5. Provisioning Service

```csharp
public interface IProvisioningService
{
    Task<Guid> CreateTenantAsync(CreateTenantRequest req, CancellationToken ct);
}

public sealed class ProvisioningService : IProvisioningService
{
    private readonly IMasterDbContextFactory _master;
    private readonly ISqlAdminClient _sqlAdmin;
    private readonly ISchemaMigrator _migrator;
    private readonly IConnectionStringEncryptor _crypto;
    private readonly ILogger<ProvisioningService> _log;

    public async Task<Guid> CreateTenantAsync(CreateTenantRequest req, CancellationToken ct)
    {
        // 1) Doğrulama
        ValidateRequest(req);

        await using var master = await _master.CreateAsync(ct);

        if (await master.Tenants.AnyAsync(t => t.Subdomain == req.Subdomain && t.Status != "deleted", ct))
            throw new ConflictException("SUBDOMAIN_TAKEN");

        // 2) Tenant kaydı
        var tenantId = Guid.NewGuid();
        var dbName = $"pinebi_tenant_{tenantId:N}".Substring(0, 40);
        var tenant = new Tenant
        {
            TenantId = tenantId,
            TenantCode = req.TenantCode,
            TenantName = req.TenantName,
            Subdomain = req.Subdomain,
            RegionId = req.Region,
            DbName = dbName,
            TierId = req.TierId,
            Status = "provisioning",
            ContactEmail = req.OwnerEmail,
            CreatedAt = DateTime.UtcNow
        };
        master.Tenants.Add(tenant);

        // 3) Job kaydı
        var jobId = Guid.NewGuid();
        master.ProvisioningJobs.Add(new ProvisioningJob
        {
            JobId = jobId, TenantId = tenantId, Status = "pending", CreatedAt = DateTime.UtcNow
        });
        await master.SaveChangesAsync(ct);

        // 4) Arka plan tetikle (Hangfire veya Channel)
        _ = Task.Run(() => RunProvisioningJobAsync(jobId, tenantId, req), CancellationToken.None);

        return tenantId;
    }

    private async Task RunProvisioningJobAsync(Guid jobId, Guid tenantId, CreateTenantRequest req)
    {
        var stopwatch = Stopwatch.StartNew();
        try
        {
            await using var master = await _master.CreateAsync(CancellationToken.None);
            var tenant = await master.Tenants.FindAsync(tenantId);
            var region = await master.Regions.FindAsync(tenant!.RegionId);

            // 5a) DB oluştur (template'ten restore)
            await _sqlAdmin.RestoreFromTemplateAsync(region!, tenant.DbName);

            // 5b) Migration (varsa gerekli)
            await _migrator.EnsureUpToDateAsync(region, tenant.DbName);

            // 5c) Seed
            await SeedTenantDataAsync(region, tenant, req);

            // 5d) Connection string şifrele ve kaydet
            var connStr = BuildConnectionString(region, tenant.DbName);
            master.TenantConnections.Add(new TenantConnection
            {
                TenantId = tenantId,
                ConnectionStringEncrypted = _crypto.Encrypt(connStr),
                LastRotationAt = DateTime.UtcNow
            });

            // 5e) Tenant aktif
            tenant.Status = "active";
            tenant.ActivatedAt = DateTime.UtcNow;

            // 5f) Job success
            var job = await master.ProvisioningJobs.FindAsync(jobId);
            job!.Status = "success";
            job.FinishedAt = DateTime.UtcNow;

            await master.SaveChangesAsync();

            _log.LogInformation("Tenant {Id} provisioned in {Ms}ms", tenantId, stopwatch.ElapsedMilliseconds);

            // 5g) Webhook / mail
            await SendWelcomeEmailAsync(tenant, req);
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Provisioning failed for tenant {Id}", tenantId);
            await MarkJobFailedAsync(jobId, ex.Message);
        }
    }
}
```

## 6. Startup / Program.cs değişiklikleri

```csharp
// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Master DB
builder.Services.AddSingleton<IMasterDbContextFactory>(_ =>
    new MasterDbContextFactory(builder.Configuration.GetConnectionString("Master")!));

// Tenant infrastructure
builder.Services.AddScoped<TenantAccessor>();
builder.Services.AddScoped<ITenantResolver, SubdomainTenantResolver>();
builder.Services.AddScoped<ITenantDbContextFactory, TenantDbContextFactory>();
builder.Services.AddMemoryCache();

// Provisioning
builder.Services.AddSingleton<ISqlAdminClient, SqlAdminClient>();
builder.Services.AddSingleton<ISchemaMigrator, EfCoreSchemaMigrator>();
builder.Services.AddSingleton<IConnectionStringEncryptor, DpapiConnectionStringEncryptor>();
builder.Services.AddScoped<IProvisioningService, ProvisioningService>();

var app = builder.Build();

// Middleware order önemli
app.UseRouting();
app.UseAuthentication();
app.UseMiddleware<TenantMiddleware>();   // AUTH'DAN SONRA
app.UseAuthorization();
app.MapControllers();
```

## 7. Var olan Controller'larda kullanım

Mevcut controller'lar `IDbContextFactory<FirmaContext>` kullanıyor. Değişiklik:

```csharp
// ÖNCESI
public class StokController : BaseApiController
{
    private readonly IDbContextFactory<FirmaContext> _factory;
    public StokController(IDbContextFactory<FirmaContext> factory) => _factory = factory;
}

// SONRASI
public class StokController : BaseApiController
{
    private readonly ITenantDbContextFactory _factory;
    public StokController(ITenantDbContextFactory factory) => _factory = factory;

    [HttpGet("ara")]
    public async Task<IActionResult> StokAra(...)
    {
        await using var db = await _factory.CreateAsync();
        // db artık tenant'a özel DB'ye bağlı, kod aynı kalır
    }
}
```

## 8. Geçiş Stratejisi (Mevcut Sistemden)

1. **Control Plane DB'yi oluştur** (02-control-plane-schema.sql)
2. Mevcut `PineERP` DB'sini **tek tenant** olarak Control Plane'e kaydet
   (tenant_code='DEMO', subdomain='demo', region='tr')
3. `TenantResolver` + `TenantMiddleware` kodu ekle, **varolan istekleri bozmadan**
   varsayılan tenant'a yönlendir (subdomain yoksa → 'demo' tenant)
4. Controller'ları aşama aşama `ITenantDbContextFactory`'e çevir
5. Provisioning API'yi hizmete al
6. Cloudflare'da wildcard DNS (`*.erp.pinebi.com`) ayarla
7. İlk gerçek tenant'ı oluştur, test et
8. Üretime al

## 9. Test Stratejisi

- **Unit:** TenantResolver, ConnectionEncryptor, ProvisioningService
- **Integration:** Gerçek MSSQL instance üzerinde tenant oluştur + sil
- **Load:** 100 paralel tenant oluşturma testi (provisioning SLA kontrolü)
- **Security:** Bir tenant'ın başka tenant'ın verisine erişim denemesi (404 bekleniyor)
