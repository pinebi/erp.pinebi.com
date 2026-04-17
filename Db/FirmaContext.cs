using MACHINEBISS_Web.Models.BlockBiss;
using MACHINEBISS_Web.Models.BlockBiss.Envanter;
using MACHINEBISS_Web.Models.EFatura.EFaturaGiden;
using MACHINEBISS_Web.Models.MachineBiss;
using MACHINEBISS_Web.Models.Sistem;
using MACHINEBISS_Web.Models.Test;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Db
{
    public class FirmaContext : DbContext
    {
        public FirmaContext(DbContextOptions<FirmaContext> options) : base(options)
        {
        }

        public DbSet<EMailAyarlari> EMailAyarlari { get; set; }
        public DbSet<SirketYetkili> SirketYetkili { get; set; }
        public DbSet<FaturaParametreleri> FaturaParametreleri { get; set; }
        public DbSet<Isyerleri> Isyerleri { get; set; }
        public DbSet<Ambarlar> Ambarlar { get; set; }
        public DbSet<OzelKodlar> OzelKodlar { get; set; }
        public DbSet<GiderTipleri> GiderTipleri { get; set; }
        public DbSet<DovizTurleri> DovizTurleri { get; set; }
        public DbSet<DovizKurlari> DovizKurlari { get; set; }
        public DbSet<Numarator> Numarator { get; set; }
        public DbSet<SirketOrtaklari> SirketOrtaklari { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
        public DbSet<PersonelYetkileri> PersonelYetkileri { get; set; }
        public DbSet<IzinFormlari> IzinFormlari { get; set; }
        public DbSet<SaglikRaporlari> SaglikRaporlari { get; set; }
        public DbSet<DisiplinTutanaklari> DisiplinTutanaklari { get; set; }
        public DbSet<GenelTutanaklar> GenelTutanaklar { get; set; }
        public DbSet<GorusVeOneriler> GorusVeOneriler { get; set; }

        public DbSet<ZimmetBaslik> ZimmetBaslik { get; set; }
        public DbSet<ZimmetSatir> ZimmetSatir { get; set; }
        public DbSet<ZimmetListesi> ZimmetListesi { get; set; }
        public DbSet<Puantaj> Puantaj { get; set; }

        public DbSet<CariGruplar> CariGruplar { get; set; }
        public DbSet<Cariler> Cariler { get; set; }
        public DbSet<CarikartView> CarikartView { get; set; }
        public DbSet<CariCalisanlar> CariCalisanlar { get; set; }
        public DbSet<CariSevkAdresleri> CariSevkAdresleri { get; set; }
        public DbSet<CariSevkAdresleriView> CariSevkAdresleriView { get; set; }
        public DbSet<CariHareketler> CariHareketler { get; set; }
        public DbSet<CariHareketlerView> CariHareketlerView { get; set; }
        public DbSet<CariHesapEkstresi> CariHesapEkstresi { get; set; }
        public DbSet<BorcAlacakRaporu> BorcAlacakRaporu { get; set; }
        public DbSet<CariGorusmeler> CariGorusmeler { get; set; }

        public DbSet<CekSenetHareketleri> CekSenetHareketleri { get; set; }
        public DbSet<CekSenetHareketleriView> CekSenetHareketleriView { get; set; }

        public DbSet<OdemePlani> OdemePlani { get; set; }
        public DbSet<OdemePlaniDetay> OdemePlaniDetay { get; set; }
        public DbSet<OdemePlaniDetayView> OdemePlaniDetayView { get; set; }
        public DbSet<OdemePlaniDetayHatirlatma> OdemePlaniDetayHatirlatma { get; set; }

        public DbSet<KasaHareketleri> KasaHareketleri { get; set; }
        public DbSet<KasaHareketleriView> KasaHareketleriView { get; set; }

        public DbSet<BankaHareketleri> BankaHareketleri { get; set; }
        public DbSet<BankaHareketleriView> BankaHareketleriView { get; set; }

        public DbSet<BankaKrediBilgileri> BankaKrediBilgileri { get; set; }
        public DbSet<BankaKrediBilgileriDetay> BankaKrediBilgileriDetay { get; set; }

        public DbSet<FaturaTahsilatOdeme> FaturaTahsilatOdeme { get; set; }
        public DbSet<FaturaTahsilatOdemeGecmisi> FaturaTahsilatOdemeGecmisi { get; set; }
        public DbSet<OzetFaturaHareketleri> OzetFaturaHareketleri { get; set; }

        public DbSet<StokKart> StokKart { get; set; }
        public DbSet<StokKartlariView> StokKartlariView { get; set; }
        public DbSet<UrunGruplari> UrunGruplari { get; set; }
        public DbSet<StokBakiye> StokBakiye { get; set; }
        public DbSet<StokMinimumSeviye> StokMinimumSeviye { get; set; }
        public DbSet<MalzemeHareketleri> MalzemeHareketleri { get; set; }
        public DbSet<Birimler> Birimler { get; set; }

        public DbSet<FaturalarTemp> FaturalarTemp { get; set; }
        public DbSet<FaturaIptalLog> FaturaIptalLog { get; set; }
        public DbSet<Faturalar> Faturalar { get; set; }
        public DbSet<FaturalarView> FaturalarView { get; set; }
        public DbSet<Irsaliyeler> Irsaliyeler { get; set; }
        public DbSet<IrsaliyelerView> IrsaliyelerView { get; set; }
        public DbSet<Siparisler> Siparisler { get; set; }
        public DbSet<SiparislerView> SiparislerView { get; set; }
        public DbSet<FatIrsSatirlar> FatIrsSatirlar { get; set; }
        public DbSet<FatIrsSatirlarView> FatIrsSatirlarView { get; set; }

        public DbSet<Teklifler> Teklifler { get; set; }
        public DbSet<TekliflerView> TekliflerView { get; set; }
        public DbSet<TeklifSatirlar> TeklifSatirlar { get; set; }
        public DbSet<TeklifSatirlarView> TeklifSatirlarView { get; set; }

        public DbSet<FaturaBankaBilgileri> FaturaBankaBilgileri { get; set; }

        public DbSet<GidenEFaturalar> GidenEFaturalar { get; set; }
        public DbSet<GidenEFaturalarView> GidenEFaturalarView { get; set; }
        public DbSet<GidenEIrsaliyelerView> GidenEIrsaliyelerView { get; set; }
        public DbSet<GidenFaturaKontrolView> GidenFaturaKontrolView { get; set; }

        public DbSet<GelenFaturalar> GelenFaturalar { get; set; }
        public DbSet<GelenFaturalarView> GelenFaturalarView { get; set; }
        public DbSet<GelenFaturalarSatirlar> GelenFaturalarSatirlar { get; set; }

        public DbSet<MasrafKalemleri> MasrafKalemleri { get; set; }

        public DbSet<OzetKdvRaporu> OzetKdvRaporu { get; set; }

        public DbSet<TasiyiciBilgileri> TasiyiciBilgileri { get; set; }

        public DbSet<Hatirlatmalar> Hatirlatmalar { get; set; }
        public DbSet<GridKolonAyar> GridKolonAyarlar { get; set; }
        public DbSet<Plasiyerler> Plasiyerler { get; set; }
        public DbSet<Projeler2> Projeler2 { get; set; }
        public DbSet<SorumlulukMerkezleri> SorumlulukMerkezleri { get; set; }

        public DbSet<AracSigortaMuayeneTakibi> AracSigortaMuayeneTakibi { get; set; }
        public DbSet<AracBakimTakibi> AracBakimTakibi { get; set; }
        public DbSet<AracBakimTakibiListe> AracBakimTakibiListe { get; set; }

        public DbSet<Projeler> Projeler { get; set; }
        public DbSet<SatinAlmaTalepleri> SatinAlmaTalepleri { get; set; }
        public DbSet<SatinAlmaTalepleriSatirlar> SatinAlmaTalepleriSatirlar { get; set; }
        public DbSet<SatinAlmaTalepleriSatirlarView> SatinAlmaTalepleriSatirlarView { get; set; }

        public DbSet<VarsayilanDegerler> VarsayilanDegerler { get; set; }

        // System tables (MSSQL PineERP)
        public DbSet<Firmalar> Firmalar { get; set; }
        public DbSet<Lisanslar> Lisanslar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciYetkileri> KullaniciYetkileri { get; set; }
        public DbSet<LisansGecmisi> LisansGecmisi { get; set; }

        // Stok Fiyat Sistemi
        public DbSet<StokFiyatlar> StokFiyatlar { get; set; }
        public DbSet<FiyatGruplari> FiyatGruplari { get; set; }
        public DbSet<CariFiyatlar> CariFiyatlar { get; set; }
        public DbSet<StokFiyatGecmisi> StokFiyatGecmisi { get; set; }

        //test
        public DbSet<Randevu> Randevu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tum double property'ler icin decimal(18,4) SQL tip eslemesi yap
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(double) || property.ClrType == typeof(double?))
                    {
                        property.SetColumnType("float");
                    }
                }
            }
        }
    }
}
