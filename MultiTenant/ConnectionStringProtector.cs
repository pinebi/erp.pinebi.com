using Microsoft.AspNetCore.DataProtection;

namespace MACHINEBISS_Web.MultiTenant;

/// <summary>
/// Connection string'leri AES ile sifreler (ASP.NET Core DataProtection API).
/// Key ring sunucu disk'inde / SQL'de saklanir, otomatik rotasyon.
/// Sifreli veri 'ENC:' prefix'i ile isaretlenir (geriye doniik uyumluluk icin).
/// </summary>
public interface IConnectionStringProtector
{
    string Protect(string plainText);
    string Unprotect(string protectedText);
    bool IsProtected(string value);
}

public sealed class ConnectionStringProtector : IConnectionStringProtector
{
    private const string Prefix = "ENC:";
    private readonly IDataProtector _protector;

    public ConnectionStringProtector(IDataProtectionProvider provider)
    {
        _protector = provider.CreateProtector("Pinebi.ConnectionStrings.v1");
    }

    public string Protect(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return plainText;
        if (IsProtected(plainText)) return plainText;
        return Prefix + _protector.Protect(plainText);
    }

    public string Unprotect(string value)
    {
        if (string.IsNullOrEmpty(value)) return value;
        if (!IsProtected(value)) return value; // plain-text (legacy) - sifresiz kabul et
        return _protector.Unprotect(value.Substring(Prefix.Length));
    }

    public bool IsProtected(string value) =>
        !string.IsNullOrEmpty(value) && value.StartsWith(Prefix, StringComparison.Ordinal);
}
