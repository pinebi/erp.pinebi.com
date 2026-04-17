using MACHINEBISS_Web.Models.BlockBiss;
using MACHINEBISS_Web.Models.BlockBiss.Envanter;
using MACHINEBISS_Web.Models.EFatura;
using MACHINEBISS_Web.Models.MachineBiss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Db
{
    public class NetworkContext : DbContext
    {
        public NetworkContext(DbContextOptions<NetworkContext> options) : base(options)
        {
        }

        public DbSet<ErpKapaliModuller> ErpKapaliModuller { get; set; }
        public DbSet<LoginTablo> LoginTablo { get; set; }
        public DbSet<SirketBilgileri> SirketBilgileri { get; set; }
        public DbSet<SirketBelgeleri> SirketBelgeleri { get; set; }
        public DbSet<SirketDahiliTel> SirketDahiliTel { get; set; }
        public DbSet<SirketMail> SirketMail { get; set; }
        public DbSet<SirketBankaBilgileri> SirketBankaBilgileri { get; set; }
        public DbSet<TumBankalar> TumBankalar { get; set; }
        public DbSet<ParaBirimleri> ParaBirimleri { get; set; }
        public DbSet<Sektorler> Sektorler { get; set; }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<IzinSebepleri> IzinSebepleri { get; set; }
        public DbSet<OdemeTipleri> OdemeTipleri { get; set; }

        public DbSet<Gorevler> Gorevler { get; set; }
        public DbSet<Ulkeler> Ulkeler { get; set; }
        public DbSet<Sehirler> Sehirler { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<VergiDaireleri> VergiDaireleri { get; set; }

        public DbSet<KdvMuafiyetSebepleri> KdvMuafiyetSebepleri { get; set; }
        public DbSet<KdvOranlari> KdvOranlari { get; set; }
        public DbSet<EFaturaUluslararasiBirimKodlari> EFaturaUluslararasiBirimKodlari { get; set; }
        public DbSet<TevkifatKodlari> TevkifatKodlari { get; set; }
        public DbSet<EFaturaHataKodlari> EFaturaHataKodlari { get; set; }

        public DbSet<Doviz> Doviz { get; set; }

        public DbSet<Envanterler> Envanterler { get; set; }
        public DbSet<EnvanterTanimlari> EnvanterTanimlari { get; set; }
        public DbSet<EnvanterTanimlariIcerik> EnvanterTanimlariIcerik { get; set; }
        public DbSet<EnvanterTanimlariIcerikOzellikler> EnvanterTanimlariIcerikOzellikler { get; set; }

        public DbSet<FirmaEnvanterListesi> FirmaEnvanterListesi { get; set; }
        public DbSet<FirmaEnvanterListesiView> FirmaEnvanterListesiView { get; set; }
        public DbSet<FirmaEnvanterIcerik> FirmaEnvanterIcerik { get; set; }
    }
}
