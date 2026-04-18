namespace MACHINEBISS_Web.MultiTenant;

public enum TenantStatus
{
    Provisioning,
    Active,
    Suspended,
    Deleted
}

public sealed class TenantContext
{
    public Guid TenantId { get; init; }
    public string TenantCode { get; init; } = "";
    public string TenantName { get; init; } = "";
    public string Subdomain { get; init; } = "";
    public string DbName { get; init; } = "";
    public string ConnectionString { get; init; } = "";
    public string RegionId { get; init; } = "";
    public TenantStatus Status { get; init; }
    public string Locale { get; init; } = "tr-TR";
    public string Currency { get; init; } = "TRY";
    public string? LogoUrl { get; init; }
    public string PrimaryColor { get; init; } = "#235881";

    public bool IsReadOnly => Status == TenantStatus.Suspended;
}

public sealed class TenantAccessor
{
    private static readonly AsyncLocal<TenantContext?> _current = new();
    public TenantContext? Current { get => _current.Value; set => _current.Value = value; }
    public TenantContext Require() => Current ?? throw new InvalidOperationException(
        "TenantContext bu istek icin tespit edilemedi. TenantMiddleware cagrildi mi?");
}
