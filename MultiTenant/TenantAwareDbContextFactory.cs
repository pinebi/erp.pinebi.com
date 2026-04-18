using MACHINEBISS_Web.Db;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// IDbContextFactory<T> arayuzunu tenant connection string'i ile dolduran jenerik fabrika.
/// TenantAccessor.Current varsa o tenant'in DB'si, yoksa varsayilan connection kullanilir.
/// Kontroller/componentlerin kodu DEGISMEDEN calisir.
/// </summary>
public sealed class TenantAwareDbContextFactory<TContext> : IDbContextFactory<TContext>
    where TContext : DbContext
{
    private readonly TenantAccessor _tenant;
    private readonly string _defaultConnectionString;
    private readonly Func<DbContextOptions<TContext>, TContext> _ctorFactory;

    public TenantAwareDbContextFactory(
        TenantAccessor tenant,
        string defaultConnectionString,
        Func<DbContextOptions<TContext>, TContext> ctorFactory)
    {
        _tenant = tenant;
        _defaultConnectionString = defaultConnectionString;
        _ctorFactory = ctorFactory;
    }

    public TContext CreateDbContext()
    {
        var connStr = _tenant.Current?.ConnectionString;
        if (string.IsNullOrEmpty(connStr)) connStr = _defaultConnectionString;

        var opts = new DbContextOptionsBuilder<TContext>()
            .UseSqlServer(connStr, sql =>
            {
                sql.EnableRetryOnFailure(3);
                sql.CommandTimeout(60);
            })
            .Options;

        return _ctorFactory(opts);
    }

    public Task<TContext> CreateDbContextAsync(CancellationToken ct = default)
        => Task.FromResult(CreateDbContext());
}
