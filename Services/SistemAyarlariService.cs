using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.BlockBiss;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Services;

public class YetkiBilgileri
{
    public bool SirketProfili { get; set; }
    public bool FirmaBilgileri { get; set; }
    public bool EnvarterYonetimi { get; set; }
    public bool PersonelYonetimi { get; set; }
    public bool FirmaAnalizi { get; set; }
    public bool MuhasebeIslemleri { get; set; }
    public bool CariIslemler { get; set; }
    public bool SatisIslemleri { get; set; }
    public bool SatinalmaIslemleri { get; set; }
    public bool EFaturaIslemleri { get; set; }
    public bool EFaturaGonder { get; set; }
}

public class SistemAyarlariService
{
    private readonly IDbContextFactory<NetworkContext> _networkFactory;
    private readonly IDbContextFactory<FirmaContext> _firmaFactory;
    private readonly AuthService _auth;

    public string SirketNo { get; set; } = "";
    public string SirketAdi { get; set; } = "";

    public SistemAyarlariService(
        IDbContextFactory<NetworkContext> networkFactory,
        IDbContextFactory<FirmaContext> firmaFactory,
        AuthService auth)
    {
        _networkFactory = networkFactory;
        _firmaFactory = firmaFactory;
        _auth = auth;
    }

    public async Task AyarlariYukle()
    {
        try
        {
            using var db = await _networkFactory.CreateDbContextAsync();
            int.TryParse(_auth.SirketKodu, out int sirketKoduInt);
            var sirket = await db.SirketBilgileri.FirstOrDefaultAsync(s => s.SirketNo == sirketKoduInt);
            if (sirket != null)
            {
                SirketNo = sirket.SirketNo?.ToString() ?? "";
                SirketAdi = sirket.FirmaUnvani ?? "";
            }
        }
        catch { }
    }

    public async Task<YetkiBilgileri> YetkileriGetir()
    {
        var yetki = new YetkiBilgileri
        {
            SirketProfili = true,
            FirmaBilgileri = true,
            EnvarterYonetimi = true,
            PersonelYonetimi = true,
            FirmaAnalizi = true,
            MuhasebeIslemleri = true,
            CariIslemler = true,
            SatisIslemleri = true,
            SatinalmaIslemleri = true,
            EFaturaIslemleri = true,
            EFaturaGonder = true
        };

        try
        {
            using var db = await _networkFactory.CreateDbContextAsync();

            // ErpKapaliModuller kontrolu
            int.TryParse(_auth.SirketKodu, out int sirketKoduInt);
            var erp = await db.ErpKapaliModuller.FirstOrDefaultAsync(s => s.SirketKodu == sirketKoduInt);
            if (erp != null)
            {
                yetki.EnvarterYonetimi = erp.EnvanterYonetimi ?? true;
                yetki.PersonelYonetimi = erp.PersonelYonetimi ?? true;
                yetki.FirmaAnalizi = erp.FirmaAnalizi ?? true;
            }
        }
        catch { }

        return yetki;
    }
}
