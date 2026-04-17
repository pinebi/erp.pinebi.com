using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.Sistem;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Services;

public class LisansBilgiDto
{
    public bool Gecerli { get; set; }
    public string? PlanTipi { get; set; }
    public DateTime? BaslangicTarihi { get; set; }
    public DateTime? BitisTarihi { get; set; }
    public int KalanGun { get; set; }
    public int? MaxFaturaAylik { get; set; }
    public int? MaxCari { get; set; }
    public int? MaxStok { get; set; }
    public int? MaxKullanici { get; set; }
    public int MevcutFatura { get; set; }
    public int MevcutCari { get; set; }
    public int MevcutStok { get; set; }
    public int MevcutKullanici { get; set; }
    public bool? EFaturaAktif { get; set; }
    public bool? EIrsaliyeAktif { get; set; }
    public bool? EArsivAktif { get; set; }
    public string? LisansKodu { get; set; }
}

public class LisansService
{
    private readonly IDbContextFactory<FirmaContext> _firmaFactory;
    private readonly AuthService _auth;

    public LisansService(IDbContextFactory<FirmaContext> firmaFactory, AuthService auth)
    {
        _firmaFactory = firmaFactory;
        _auth = auth;
    }

    public async Task<LisansBilgiDto> LisansBilgileriGetir()
    {
        var bilgi = new LisansBilgiDto();

        try
        {
            using var db = await _firmaFactory.CreateDbContextAsync();

            var lisans = await db.Lisanslar
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.FirmaId == _auth.FirmaId && l.Aktif == true);

            if (lisans == null)
            {
                bilgi.Gecerli = false;
                bilgi.PlanTipi = "Lisans Bulunamadi";
                return bilgi;
            }

            bilgi.LisansKodu = lisans.LisansKodu?.ToString();
            bilgi.PlanTipi = lisans.PlanTipi;
            bilgi.BaslangicTarihi = lisans.BaslangicTarihi;
            bilgi.BitisTarihi = lisans.BitisTarihi;
            bilgi.MaxFaturaAylik = lisans.MaxFaturaAylik;
            bilgi.MaxCari = lisans.MaxCari;
            bilgi.MaxStok = lisans.MaxStok;
            bilgi.MaxKullanici = lisans.MaxKullanici;
            bilgi.EFaturaAktif = lisans.EFaturaAktif;
            bilgi.EIrsaliyeAktif = lisans.EIrsaliyeAktif;
            bilgi.EArsivAktif = lisans.EArsivAktif;

            // Kalan gun hesapla
            if (lisans.BitisTarihi.HasValue)
            {
                var kalan = (lisans.BitisTarihi.Value - DateTime.Today).Days;
                bilgi.KalanGun = kalan > 0 ? kalan : 0;
                bilgi.Gecerli = kalan > 0;
            }
            else
            {
                bilgi.Gecerli = true;
                bilgi.KalanGun = 9999;
            }

            // Mevcut kullanim istatistikleri
            try { bilgi.MevcutFatura = await db.Faturalar.CountAsync(); } catch { }
            try { bilgi.MevcutCari = await db.Cariler.CountAsync(); } catch { }
            try { bilgi.MevcutStok = await db.StokKart.CountAsync(); } catch { }
            try { bilgi.MevcutKullanici = await db.Kullanicilar.CountAsync(k => k.Aktif == true); } catch { }
        }
        catch { }

        return bilgi;
    }

    public async Task<bool> LisansGecerliMi()
    {
        try
        {
            var bilgi = await LisansBilgileriGetir();
            return bilgi.Gecerli;
        }
        catch
        {
            return false;
        }
    }

    public async Task<int> KalanGun()
    {
        try
        {
            var bilgi = await LisansBilgileriGetir();
            return bilgi.KalanGun;
        }
        catch
        {
            return 0;
        }
    }
}
