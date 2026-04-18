using MACHINEBISS_Web.Db;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// FirmaContext'i tenant connection string'i ile uretir.
/// Mevcut IDbContextFactory<FirmaContext>'in yerini tutar.
/// </summary>
public interface ITenantFirmaContextFactory
{
    FirmaContext Create();
    Task<FirmaContext> CreateAsync(CancellationToken ct = default);
}

public sealed class TenantFirmaContextFactory : ITenantFirmaContextFactory
{
    private readonly TenantAccessor _tenant;
    private readonly IDbContextFactory<FirmaContext> _fallback;

    public TenantFirmaContextFactory(TenantAccessor tenant, IDbContextFactory<FirmaContext> fallback)
    {
        _tenant = tenant;
        _fallback = fallback;
    }

    public FirmaContext Create()
    {
        var ctx = _tenant.Current;
        if (ctx == null) return _fallback.CreateDbContext();

        var options = new DbContextOptionsBuilder<FirmaContext>()
            .UseSqlServer(ctx.ConnectionString, sql =>
            {
                sql.EnableRetryOnFailure(3);
                sql.CommandTimeout(60);
            })
            .Options;
        return new FirmaContext(options);
    }

    public Task<FirmaContext> CreateAsync(CancellationToken ct = default) => Task.FromResult(Create());
}
