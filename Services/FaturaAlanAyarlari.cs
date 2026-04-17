using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.MachineBiss;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Services;

public class FaturaKolonAyar
{
    public string KolonId { get; set; } = "";
    public string KolonAdi { get; set; } = "";
    public bool Gorunur { get; set; } = true;
    public string Grup { get; set; } = "";
}

public class FaturaAlanAyarlariService
{
    private readonly IDbContextFactory<FirmaContext> _dbFactory;
    private readonly AuthService _auth;

    // Varsayilan kolon tanimlari
    private static readonly List<FaturaKolonAyar> _varsayilanKolonlar = new()
    {
        new() { KolonId = "malHizmetKodu", KolonAdi = "Mal/Hizmet Kodu", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "malHizmet", KolonAdi = "Mal/Hizmet", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "aciklama1", KolonAdi = "Aciklama 1", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "aciklama2", KolonAdi = "Aciklama 2", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "aciklama3", KolonAdi = "Aciklama 3", Gorunur = false, Grup = "fatura" },
        new() { KolonId = "aciklama4", KolonAdi = "Aciklama 4", Gorunur = false, Grup = "fatura" },
        new() { KolonId = "miktar", KolonAdi = "Miktar", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "birim", KolonAdi = "Birim", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "fiyat", KolonAdi = "Fiyat", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "kdv", KolonAdi = "KDV", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "tutar", KolonAdi = "Tutar", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "iskonto", KolonAdi = "Isk%", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "iskontoTutari", KolonAdi = "Iskonto Tutari", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "kdvMatrahi", KolonAdi = "KDV Matrahi", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "kdvTutari", KolonAdi = "KDV Tutari", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "netTutar", KolonAdi = "Net Tutar", Gorunur = true, Grup = "fatura" },
        new() { KolonId = "kdvMuafiyet", KolonAdi = "KDV Muafiyet Sebebi", Gorunur = false, Grup = "fatura" },
        new() { KolonId = "tevkifat", KolonAdi = "Tevkifat Kodu", Gorunur = false, Grup = "fatura" },
        new() { KolonId = "gtipKodu", KolonAdi = "GTip Kodu", Gorunur = false, Grup = "fatura" },
    };

    // Bellekte tutulan kullanici ayarlari (DB'den yuklenir)
    private Dictionary<string, bool> _kullaniciAyarlari = new();
    private bool _yuklendi = false;

    public event Action? OnAyarlarDegisti;

    public FaturaAlanAyarlariService(IDbContextFactory<FirmaContext> dbFactory, AuthService auth)
    {
        _dbFactory = dbFactory;
        _auth = auth;
    }

    public List<FaturaKolonAyar> KolonlariGetir(string grup = "fatura")
    {
        if (!_yuklendi) AyarlariYukle();

        return _varsayilanKolonlar
            .Where(k => k.Grup == grup)
            .Select(k => new FaturaKolonAyar
            {
                KolonId = k.KolonId,
                KolonAdi = k.KolonAdi,
                Grup = k.Grup,
                Gorunur = _kullaniciAyarlari.ContainsKey(k.KolonId) ? _kullaniciAyarlari[k.KolonId] : k.Gorunur
            })
            .ToList();
    }

    public bool KolonGorunurMu(string kolonId)
    {
        if (!_yuklendi) AyarlariYukle();

        if (_kullaniciAyarlari.ContainsKey(kolonId))
            return _kullaniciAyarlari[kolonId];

        var varsayilan = _varsayilanKolonlar.FirstOrDefault(k => k.KolonId == kolonId);
        return varsayilan?.Gorunur ?? true;
    }

    public void KolonGorunurlukDegistir(string kolonId, bool gorunur)
    {
        _kullaniciAyarlari[kolonId] = gorunur;

        // DB'ye kaydet
        try
        {
            using var db = _dbFactory.CreateDbContext();
            var sirketKodu = _auth.SirketKodu ?? "";
            var kullaniciId = _auth.ErpKullaniciId;

            var mevcut = db.GridKolonAyarlar.FirstOrDefault(g =>
                g.SirketKodu == sirketKodu &&
                g.KullaniciId == kullaniciId &&
                g.FormAdi == "fatura" &&
                g.KolonId == kolonId);

            if (mevcut != null)
            {
                mevcut.Gorunur = gorunur;
            }
            else
            {
                db.GridKolonAyarlar.Add(new GridKolonAyar
                {
                    SirketKodu = sirketKodu,
                    KullaniciId = kullaniciId,
                    FormAdi = "fatura",
                    KolonId = kolonId,
                    Gorunur = gorunur
                });
            }
            db.SaveChanges();
        }
        catch { }

        OnAyarlarDegisti?.Invoke();
    }

    private void AyarlariYukle()
    {
        try
        {
            using var db = _dbFactory.CreateDbContext();
            var sirketKodu = _auth.SirketKodu ?? "";
            var kullaniciId = _auth.ErpKullaniciId;

            var kayitlar = db.GridKolonAyarlar
                .Where(g => g.SirketKodu == sirketKodu && g.KullaniciId == kullaniciId && g.FormAdi == "fatura")
                .ToList();

            _kullaniciAyarlari = kayitlar.ToDictionary(k => k.KolonId, k => k.Gorunur);
        }
        catch { }

        _yuklendi = true;
    }
}
