using System.Text.Json;
using Microsoft.JSInterop;

namespace MACHINEBISS_Web.Services;

public class AuthService
{
    private const string StorageKey = "pine_auth_v1";

    public bool IsAuthenticated { get; private set; }
    public int UserId { get; private set; }
    public int FirmaId { get; private set; }
    public int KullaniciId { get; private set; }
    public string KullaniciAdi { get; private set; } = "";
    public string ErpKullaniciAdi { get; private set; } = "";
    public string ErpKullaniciGorevi { get; private set; } = "";
    public int ErpKullaniciId { get; private set; }
    public string SirketKodu { get; private set; } = "";
    public string Rol { get; private set; } = "";

    public event Action? OnAuthStateChanged;

    public void Login(int userId, string kullaniciAdi, string erpKullaniciAdi, string erpKullaniciGorevi, int erpKullaniciId, string sirketKodu, int firmaId = 0, int kullaniciId = 0, string rol = "")
    {
        UserId = userId;
        KullaniciAdi = kullaniciAdi;
        ErpKullaniciAdi = erpKullaniciAdi;
        ErpKullaniciGorevi = erpKullaniciGorevi;
        ErpKullaniciId = erpKullaniciId;
        SirketKodu = sirketKodu;
        FirmaId = firmaId;
        KullaniciId = kullaniciId;
        Rol = rol;
        IsAuthenticated = true;
        OnAuthStateChanged?.Invoke();
    }

    public void Logout()
    {
        IsAuthenticated = false;
        UserId = 0;
        FirmaId = 0;
        KullaniciId = 0;
        KullaniciAdi = "";
        ErpKullaniciAdi = "";
        ErpKullaniciGorevi = "";
        ErpKullaniciId = 0;
        SirketKodu = "";
        Rol = "";
        OnAuthStateChanged?.Invoke();
    }

    /// <summary>
    /// Login bilgisini tarayici localStorage'a kaydeder. Login.razor'da Login() sonrasi cagrilir.
    /// </summary>
    public async Task SaveToBrowserAsync(IJSRuntime js)
    {
        try
        {
            var data = new AuthSnapshot
            {
                UserId = UserId, FirmaId = FirmaId, KullaniciId = KullaniciId,
                KullaniciAdi = KullaniciAdi, ErpKullaniciAdi = ErpKullaniciAdi,
                ErpKullaniciGorevi = ErpKullaniciGorevi, ErpKullaniciId = ErpKullaniciId,
                SirketKodu = SirketKodu, Rol = Rol
            };
            var json = JsonSerializer.Serialize(data);
            await js.InvokeVoidAsync("localStorage.setItem", StorageKey, json);
        }
        catch { }
    }

    /// <summary>
    /// Sayfa acilisinda localStorage'dan auth bilgisini geri yukler. Layout OnAfterRenderAsync ilk render'da cagrilir.
    /// </summary>
    public async Task<bool> RestoreFromBrowserAsync(IJSRuntime js)
    {
        if (IsAuthenticated) return true;
        try
        {
            var json = await js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
            if (string.IsNullOrWhiteSpace(json)) return false;

            var data = JsonSerializer.Deserialize<AuthSnapshot>(json);
            if (data == null || data.UserId <= 0) return false;

            Login(data.UserId, data.KullaniciAdi, data.ErpKullaniciAdi, data.ErpKullaniciGorevi,
                  data.ErpKullaniciId, data.SirketKodu, data.FirmaId, data.KullaniciId, data.Rol);
            return true;
        }
        catch { return false; }
    }

    /// <summary>
    /// Logout sirasinda cagrilir.
    /// </summary>
    public async Task ClearBrowserAsync(IJSRuntime js)
    {
        try { await js.InvokeVoidAsync("localStorage.removeItem", StorageKey); } catch { }
        Logout();
    }

    private class AuthSnapshot
    {
        public int UserId { get; set; }
        public int FirmaId { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; } = "";
        public string ErpKullaniciAdi { get; set; } = "";
        public string ErpKullaniciGorevi { get; set; } = "";
        public int ErpKullaniciId { get; set; }
        public string SirketKodu { get; set; } = "";
        public string Rol { get; set; } = "";
    }
}
