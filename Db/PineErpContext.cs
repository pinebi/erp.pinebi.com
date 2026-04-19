using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Models.PineERP;
using MACHINEBISS_Web.Models.PineERP.Stok;
using MACHINEBISS_Web.Models.PineERP.Cari;
using MACHINEBISS_Web.Models.PineERP.Fatura;
using MACHINEBISS_Web.Models.PineERP.Irsaliye;
using MACHINEBISS_Web.Models.PineERP.Siparis;
using MACHINEBISS_Web.Models.PineERP.Teklif;
using MACHINEBISS_Web.Models.PineERP.Finans;
using MACHINEBISS_Web.Models.PineERP.Arac;
using MACHINEBISS_Web.Models.PineERP.EFatura;
using MACHINEBISS_Web.Models.PineERP.Tanimlar;
using MACHINEBISS_Web.Models.PineERP.Sistem;
using MACHINEBISS_Web.Models.PineERP.Takvim;
using MACHINEBISS_Web.Models.PineERP.Mail;
using MACHINEBISS_Web.Models.PineERP.Ai;

namespace MACHINEBISS_Web.Db;

public class PineErpContext : DbContext
{
    public PineErpContext(DbContextOptions<PineErpContext> options) : base(options) { }

    // ===== TAKVIM (6) =====
    public DbSet<PineCalendar> Calendars { get; set; } = null!;
    public DbSet<PineCalendarShare> CalendarShares { get; set; } = null!;
    public DbSet<PineRoom> Rooms { get; set; } = null!;
    public DbSet<PineEvent> Events { get; set; } = null!;
    public DbSet<PineEventParticipant> EventParticipants { get; set; } = null!;
    public DbSet<PineEventReminder> EventReminders { get; set; } = null!;

    // ===== MAIL (2) =====
    public DbSet<PineMailAccount> MailAccounts { get; set; } = null!;
    public DbSet<PineMailDraft> MailDrafts { get; set; } = null!;

    // ===== AI SUITE + DMS + ROLLER (5) =====
    public DbSet<PineDocument> Documents { get; set; } = null!;
    public DbSet<PineRole> Roles { get; set; } = null!;
    public DbSet<PineStokTahmin> StokTahmin { get; set; } = null!;
    public DbSet<PineAiLog> AiLog { get; set; } = null!;
    public DbSet<PineBildirim> Bildirimler { get; set; } = null!;

    // ===== STOK (14) =====
    public DbSet<PineStoklar> Stoklar { get; set; }
    public DbSet<PineStokBarkodlari> StokBarkodlari { get; set; }
    public DbSet<PineStokHareketleri> StokHareketleri { get; set; }
    public DbSet<PineStokHareketleriOzet> StokHareketleriOzet { get; set; }
    public DbSet<PineStokGruplari> StokGruplari { get; set; }
    public DbSet<PineStokBirimleri> StokBirimleri { get; set; }
    public DbSet<PineStokFiyatlari> StokFiyatlari { get; set; }
    public DbSet<PineStokFiyatGecmisi> StokFiyatGecmisi { get; set; }
    public DbSet<PineStokDepoDetaylari> StokDepoDetaylari { get; set; }
    public DbSet<PineStokReyonlari> StokReyonlari { get; set; }
    public DbSet<PineStokUreticileri> StokUreticileri { get; set; }
    public DbSet<PineStokBedenTanimlari> StokBedenTanimlari { get; set; }
    public DbSet<PineStokRenkTanimlari> StokRenkTanimlari { get; set; }
    public DbSet<PineBarkodTanimlari> BarkodTanimlari { get; set; }
    public DbSet<PineDepolar> Depolar { get; set; }

    // ===== CARI (7) =====
    public DbSet<PineCariHesaplar> CariHesaplar { get; set; }
    public DbSet<PineCariHesapHareketleri> CariHesapHareketleri { get; set; }
    public DbSet<PineCariGruplari> CariGruplari { get; set; }
    public DbSet<PineCariAdresler> CariAdresler { get; set; }
    public DbSet<PineCariYetkililer> CariYetkililer { get; set; }
    public DbSet<PineCariGorusmeler> CariGorusmeler { get; set; }
    public DbSet<PineCariFiyatlar> CariFiyatlar { get; set; }

    // ===== FATURA (8) =====
    public DbSet<PineFaturalar> Faturalar { get; set; }
    public DbSet<PineFaturaSatirlari> FaturaSatirlari { get; set; }
    public DbSet<PineFaturaBankaBilgileri> FaturaBankaBilgileri { get; set; }
    public DbSet<PineFaturaTahsilat> FaturaTahsilat { get; set; }
    public DbSet<PineFaturaParametreleri> FaturaParametreleri { get; set; }
    public DbSet<PineFaturaNumarator> FaturaNumarator { get; set; }
    public DbSet<PineFaturaIptalLog> FaturaIptalLog { get; set; }
    public DbSet<PineFaturaSecenekleri> FaturaSecenekleri { get; set; }

    // ===== IRSALIYE (2) =====
    public DbSet<PineIrsaliyeler> Irsaliyeler { get; set; }
    public DbSet<PineIrsaliyeSatirlari> IrsaliyeSatirlari { get; set; }

    // ===== SIPARIS (3) =====
    public DbSet<PineSiparisler> Siparisler { get; set; }
    public DbSet<PineSiparisSatirlari> SiparisSatirlari { get; set; }
    public DbSet<PineSiparisOzet> SiparisOzet { get; set; }

    // ===== TEKLIF (4) =====
    public DbSet<PineTeklifler> Teklifler { get; set; }
    public DbSet<PineTeklifSatirlari> TeklifSatirlari { get; set; }
    public DbSet<PineSatisSartlari> SatisSartlari { get; set; }
    public DbSet<PineSatinalmaSartlari> SatinalmaSartlari { get; set; }

    // ===== FINANS (13) =====
    public DbSet<PineKasalar> Kasalar { get; set; }
    public DbSet<PineKasaHareketleri> KasaHareketleri { get; set; }
    public DbSet<PineBankaHesaplari> BankaHesaplari { get; set; }
    public DbSet<PineBankaHareketleri> BankaHareketleri { get; set; }
    public DbSet<PineBankaKrediBilgileri> BankaKrediBilgileri { get; set; }
    public DbSet<PineBankaKrediDetay> BankaKrediDetay { get; set; }
    public DbSet<PineCekSenetHareketleri> CekSenetHareketleri { get; set; }
    public DbSet<PineKrediKartiHareketleri> KrediKartiHareketleri { get; set; }
    public DbSet<PineGiderTipleri> GiderTipleri { get; set; }
    public DbSet<PineMasrafKalemleri> MasrafKalemleri { get; set; }
    public DbSet<PineOdemePlanlari> OdemePlanlari { get; set; }
    public DbSet<PineOdemePlaniDetay> OdemePlaniDetay { get; set; }

    // ===== PERSONEL (14) =====
    public DbSet<PinePersoneller> Personeller { get; set; }
    public DbSet<PinePersonelYetkileri> PersonelYetkileri { get; set; }
    public DbSet<PinePersonelIzinleri> PersonelIzinleri { get; set; }
    public DbSet<PinePersonelPuantaj> PersonelPuantaj { get; set; }
    public DbSet<PinePersonelPuantajGunluk> PersonelPuantajGunluk { get; set; }
    public DbSet<PinePersonelTahakkuklari> PersonelTahakkuklari { get; set; }
    public DbSet<PinePersonelDisiplin> PersonelDisiplin { get; set; }
    public DbSet<PinePersonelGenelTutanak> PersonelGenelTutanak { get; set; }
    public DbSet<PinePersonelSaglikRaporlari> PersonelSaglikRaporlari { get; set; }
    public DbSet<PinePersonelGorusOnerileri> PersonelGorusOnerileri { get; set; }
    public DbSet<PinePersonelDepartmanlar> PersonelDepartmanlar { get; set; }
    public DbSet<PinePersonelPozisyonlar> PersonelPozisyonlar { get; set; }
    public DbSet<PinePersonelAlinanEgitimler> PersonelAlinanEgitimler { get; set; }
    public DbSet<PinePersonelEgitimTanimlari> PersonelEgitimTanimlari { get; set; }

    // ===== DEMIRBAS (5) =====
    public DbSet<PineDemirbaslar> Demirbaslar { get; set; }
    public DbSet<PineDemirbasHareketleri> DemirbasHareketleri { get; set; }
    public DbSet<PineDemirbasBakimKayitlari> DemirbasBakimKayitlari { get; set; }
    public DbSet<PineZimmetFormlari> ZimmetFormlari { get; set; }
    public DbSet<PineZimmetSatirlari> ZimmetSatirlari { get; set; }

    // ===== PROJE (4) =====
    public DbSet<PineProjeler> Projeler { get; set; }
    public DbSet<PineProjeGorevleri> ProjeGorevleri { get; set; }
    public DbSet<PineSatinalmaTalepleri> SatinalmaTalepleri { get; set; }
    public DbSet<PineSatinalmaTalepSatirlari> SatinalmaTalepSatirlari { get; set; }

    // ===== URETIM (7) =====
    public DbSet<PineIsEmirleri> IsEmirleri { get; set; }
    public DbSet<PineIsEmriStokTuketimleri> IsEmriStokTuketimleri { get; set; }
    public DbSet<PineUrunReceteleri> UrunReceteleri { get; set; }
    public DbSet<PineUrunRotalari> UrunRotalari { get; set; }
    public DbSet<PineUretimOperasyonlari> UretimOperasyonlari { get; set; }
    public DbSet<PineUretimOperasyonHareketleri> UretimOperasyonHareketleri { get; set; }
    public DbSet<PineUretimMalzemePlanlama> UretimMalzemePlanlama { get; set; }

    // ===== ARAC (2) =====
    public DbSet<PineAracTakip> AracTakip { get; set; }
    public DbSet<PineAracBakimKayitlari> AracBakimKayitlari { get; set; }

    // ===== E-FATURA (4) =====
    public DbSet<PineEFaturaGelen> EFaturaGelen { get; set; }
    public DbSet<PineEFaturaGelenSatirlar> EFaturaGelenSatirlar { get; set; }
    public DbSet<PineEFaturaGiden> EFaturaGiden { get; set; }
    public DbSet<PineEFaturaHataKodlari> EFaturaHataKodlari { get; set; }

    // ===== TANIMLAR (19) =====
    public DbSet<PineBirimler> Birimler { get; set; }
    public DbSet<PineBankalar> Bankalar { get; set; }
    public DbSet<PineDovizTurleri> DovizTurleri { get; set; }
    public DbSet<PineDovizKurlari> DovizKurlari { get; set; }
    public DbSet<PineKdvOranlari> KdvOranlari { get; set; }
    public DbSet<PineKdvMuafiyetSebepleri> KdvMuafiyetSebepleri { get; set; }
    public DbSet<PineTevkifatKodlari> TevkifatKodlari { get; set; }
    public DbSet<PineVergiDaireleri> VergiDaireleri { get; set; }
    public DbSet<PineSehirler> Sehirler { get; set; }
    public DbSet<PineIller> Iller { get; set; }
    public DbSet<PineIlceler> Ilceler { get; set; }
    public DbSet<PineUlkeler> Ulkeler { get; set; }
    public DbSet<PineIsyerleri> Isyerleri { get; set; }
    public DbSet<PineOzelKodlar> OzelKodlar { get; set; }
    public DbSet<PineHatirlatmalar> Hatirlatmalar { get; set; }
    public DbSet<PineTasiyiciBilgileri> TasiyiciBilgileri { get; set; }
    public DbSet<PineOdemeTipleri> OdemeTipleri { get; set; }
    public DbSet<PineFiyatGruplari> FiyatGruplari { get; set; }
    public DbSet<PinePlasiyerler> Plasiyerler { get; set; }
    public DbSet<PineSorumlulukMerkezleri> SorumlulukMerkezleri { get; set; }

    // ===== SISTEM (8) =====
    public DbSet<PineFirmalar> Firmalar { get; set; }
    public DbSet<PineKullanicilar> Kullanicilar { get; set; }
    public DbSet<PineKullaniciYetkileri> KullaniciYetkileri { get; set; }
    public DbSet<PineLisanslar> Lisanslar { get; set; }
    public DbSet<PineLisansGecmisi> LisansGecmisi { get; set; }
    public DbSet<PineEmailAyarlari> EmailAyarlari { get; set; }
    public DbSet<PineVarsayilanDegerler> VarsayilanDegerler { get; set; }
    public DbSet<PineGridKolonAyarlari> GridKolonAyarlari { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // All decimal properties: precision 18,4
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(decimal) || property.ClrType == typeof(decimal?))
                {
                    property.SetPrecision(18);
                    property.SetScale(4);
                }
            }
        }

        // ===== INDEXES =====

        // Stok
        modelBuilder.Entity<PineStoklar>().HasIndex(e => e.StoKod).IsUnique();
        modelBuilder.Entity<PineStokHareketleri>().HasIndex(e => e.SthStokKod);

        // Cari
        modelBuilder.Entity<PineCariHesaplar>().HasIndex(e => e.CarKod).IsUnique();
        modelBuilder.Entity<PineCariHesapHareketleri>().HasIndex(e => e.ChaCariKod);

        // Fatura
        modelBuilder.Entity<PineFaturalar>().HasIndex(e => e.FatEvrakSeri);

        // Finans
        modelBuilder.Entity<PineKasaHareketleri>().HasIndex(e => e.KshKasaKod);
        modelBuilder.Entity<PineBankaHareketleri>().HasIndex(e => e.BnhHesapKod);

        // Personel
        modelBuilder.Entity<PinePersoneller>().HasIndex(e => e.PerKod).IsUnique();
    }
}
