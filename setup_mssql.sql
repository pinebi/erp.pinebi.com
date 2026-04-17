-- PineERP MSSQL Database Setup Script
-- Server: 185.210.92.248
-- User: EDonusum

-- 1. DATABASE OLUSTUR
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PineERP')
BEGIN
    CREATE DATABASE PineERP
    COLLATE Turkish_CI_AS;
END
GO

USE PineERP;
GO

-- =============================================
-- SISTEM TABLOLARI
-- =============================================

-- Firma/Tenant Yonetimi
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Firmalar')
CREATE TABLE Firmalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaKodu NVARCHAR(20) UNIQUE,
    FirmaUnvani NVARCHAR(300),
    VergiNo NVARCHAR(20),
    VergiDairesi NVARCHAR(100),
    Telefon NVARCHAR(50),
    Email NVARCHAR(100),
    Adres NVARCHAR(500),
    Sehir NVARCHAR(50),
    Ilce NVARCHAR(50),
    PostaKodu NVARCHAR(10),
    WebSitesi NVARCHAR(200),
    LogoUrl NVARCHAR(500),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    GuncellemeTarihi DATETIME2
);

-- Lisans Yonetimi
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Lisanslar')
CREATE TABLE Lisanslar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT FOREIGN KEY REFERENCES Firmalar(Id),
    LisansKodu UNIQUEIDENTIFIER DEFAULT NEWID(),
    PlanTipi NVARCHAR(50) DEFAULT 'Starter', -- Starter, Professional, Enterprise
    BaslangicTarihi DATE,
    BitisTarihi DATE,
    MaxKullanici INT DEFAULT 1,
    MaxFaturaAylik INT DEFAULT 200,
    MaxStok INT DEFAULT 1000,
    MaxCari INT DEFAULT 500,
    EFaturaAktif BIT DEFAULT 0,
    EIrsaliyeAktif BIT DEFAULT 0,
    EArsivAktif BIT DEFAULT 0,
    Tutar DECIMAL(18,2) DEFAULT 0,
    ParaBirimi NVARCHAR(10) DEFAULT 'TRY',
    OdemeDurumu NVARCHAR(20) DEFAULT 'Bekliyor', -- Odendi, Bekliyor, Gecikti
    OtomatikYenileme BIT DEFAULT 1,
    YenilemePeriyodu NVARCHAR(10) DEFAULT 'Yillik', -- Aylik, Yillik
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    GuncellemeTarihi DATETIME2
);

-- Lisans Gecmisi
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LisansGecmisi')
CREATE TABLE LisansGecmisi (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    LisansId INT FOREIGN KEY REFERENCES Lisanslar(Id),
    IslemTipi NVARCHAR(50), -- YeniLisans, Yenileme, PlanDegisikligi, Iptal
    EskiPlan NVARCHAR(50),
    YeniPlan NVARCHAR(50),
    EskiBitisTarihi DATE,
    YeniBitisTarihi DATE,
    Tutar DECIMAL(18,2),
    Aciklama NVARCHAR(500),
    IslemTarihi DATETIME2 DEFAULT GETDATE()
);

-- Kullanici Yonetimi
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar')
CREATE TABLE Kullanicilar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT FOREIGN KEY REFERENCES Firmalar(Id),
    KullaniciAdi NVARCHAR(100) NOT NULL,
    Email NVARCHAR(200),
    SifreHash NVARCHAR(500),
    AdSoyad NVARCHAR(200),
    Telefon NVARCHAR(50),
    Rol NVARCHAR(50) DEFAULT 'Kullanici', -- SuperAdmin, Admin, Muhasebeci, SatisPersoneli, Depocu, Kullanici
    ProfilResmiUrl NVARCHAR(500),
    Aktif BIT DEFAULT 1,
    SonGirisTarihi DATETIME2,
    SonGirisIP NVARCHAR(50),
    GirisDenemeSayisi INT DEFAULT 0,
    HesapKilitli BIT DEFAULT 0,
    SifreDegistirmeTarihi DATETIME2,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    GuncellemeTarihi DATETIME2
);

-- Kullanici Yetkileri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KullaniciYetkileri')
CREATE TABLE KullaniciYetkileri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciId INT FOREIGN KEY REFERENCES Kullanicilar(Id),
    SirketProfili BIT DEFAULT 1,
    FirmaBilgileri BIT DEFAULT 1,
    EnvanterYonetimi BIT DEFAULT 1,
    PersonelYonetimi BIT DEFAULT 1,
    MuhasebeIslemleri BIT DEFAULT 1,
    CariIslemler BIT DEFAULT 1,
    SatisIslemleri BIT DEFAULT 1,
    SatinalmaIslemleri BIT DEFAULT 1,
    EFaturaIslemleri BIT DEFAULT 1,
    EFaturaGonder BIT DEFAULT 0,
    StokYonetimi BIT DEFAULT 1,
    RaporGorme BIT DEFAULT 1,
    KullaniciTanimlama BIT DEFAULT 0,
    AyarlarDuzenleme BIT DEFAULT 0
);

-- =============================================
-- IS TABLOLARI
-- =============================================

-- Cari Hesap Karti
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariKart')
CREATE TABLE CariKart (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    CariKodu NVARCHAR(50),
    Unvani NVARCHAR(300),
    CariGrubu NVARCHAR(50),
    CariTipi INT DEFAULT 0, -- 0:Musteri 1:Tedarikci 2:HerIkisi
    EFatura BIT DEFAULT 0,
    SahisSirketi BIT DEFAULT 0,
    YurtDisi BIT DEFAULT 0,
    Ad NVARCHAR(100),
    Soyad NVARCHAR(100),
    TckNo NVARCHAR(20),
    Yetkili1 NVARCHAR(100),
    Yetkili2 NVARCHAR(100),
    VdSehirId INT,
    VdSehir NVARCHAR(50),
    VdKodu NVARCHAR(20),
    Vd NVARCHAR(100),
    Vn NVARCHAR(20),
    GsmNo NVARCHAR(50),
    Telefon1 NVARCHAR(50),
    Telefon2 NVARCHAR(50),
    Faks NVARCHAR(50),
    Email NVARCHAR(200),
    Adres1 NVARCHAR(500),
    Adres2 NVARCHAR(500),
    PostaKodu NVARCHAR(10),
    UlkeId INT,
    Ulke NVARCHAR(50),
    IlceId INT,
    Ilce NVARCHAR(50),
    SehirId INT,
    Sehir NVARCHAR(50),
    OzelKod1 NVARCHAR(50),
    OzelKod2 NVARCHAR(50),
    OzelKod3 NVARCHAR(50),
    OzelKod4 NVARCHAR(50),
    OzelKod5 NVARCHAR(50),
    EFaturaUrnMail NVARCHAR(200),
    EIrsaliyeUrnMail NVARCHAR(200),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    OlusturanKullanici INT,
    GuncellemeTarihi DATETIME2,
    GuncelleyenKullanici INT
);

-- Stok Karti
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StokKart')
CREATE TABLE StokKart (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    StokKodu NVARCHAR(50),
    StokCinsi NVARCHAR(300),
    Barkod NVARCHAR(50),
    Birim NVARCHAR(20) DEFAULT 'Adet',
    Kdv DECIMAL(5,2) DEFAULT 20,
    KdvHaricSatisFiyati DECIMAL(18,2) DEFAULT 0,
    KdvHaricAlisFiyati DECIMAL(18,2) DEFAULT 0,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    UrunGrubu NVARCHAR(50),
    Aciklama NVARCHAR(500),
    OzelKod1 NVARCHAR(50),
    OzelKod2 NVARCHAR(50),
    OzelKod3 NVARCHAR(50),
    OzelKod4 NVARCHAR(50),
    OzelKod5 NVARCHAR(50),
    TevkifatId SMALLINT,
    TevkifatKodu NVARCHAR(20),
    TevkifatCarpan DECIMAL(5,2),
    TevkifatBolen DECIMAL(5,2),
    MinimumSeviye DECIMAL(18,2),
    KullanimDisi BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    OlusturanKullanici INT,
    GuncellemeTarihi DATETIME2,
    GuncelleyenKullanici INT
);

-- Faturalar
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Faturalar')
CREATE TABLE Faturalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FisTipi NVARCHAR(10),
    TrCode INT DEFAULT 8,
    FaturaTuru NVARCHAR(50),
    IhracatTasimaKodu NVARCHAR(50),
    EvrakTipi INT DEFAULT 0,
    IslemTipi NVARCHAR(10) DEFAULT 'Normal',
    Tarih DATE,
    SevkTarihi DATE,
    FisNo NVARCHAR(50),
    BelgeNo NVARCHAR(50),
    OzelKod1 NVARCHAR(50),
    OzelKod2 NVARCHAR(50),
    OzelKod3 NVARCHAR(50),
    CariId INT,
    FaturaTipi INT,
    OdemeTipi INT DEFAULT 0,
    KapayanHesapId INT,
    VadeTarihi DATE,
    TemlikTarihi DATE,
    OpsiyonTarihi DATE,
    SiparisNo NVARCHAR(50),
    SiparisTarihi DATE,
    IsyeriNo INT,
    AmbarNo INT,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    DovizTuru INT DEFAULT 0,
    DovizKuru DECIMAL(18,4) DEFAULT 1,
    Personel NVARCHAR(100),
    SatinalmaSorumlusu NVARCHAR(100),
    BolumSatinalmaSorumlusu NVARCHAR(100),
    ProformaNo NVARCHAR(50),
    ProjeId INT,
    PlasiyerId INT,
    SorumlulukMerkeziId INT,
    Aciklama1 NVARCHAR(500),
    Aciklama2 NVARCHAR(500),
    Aciklama3 NVARCHAR(500),
    Aciklama4 NVARCHAR(500),
    Aciklama5 NVARCHAR(500),
    Tutar DECIMAL(18,2),
    ToplamIndirim DECIMAL(18,2),
    KdvMatrahi DECIMAL(18,2),
    KdvTutari DECIMAL(18,2),
    TevkifatMuafiyeti DECIMAL(18,2),
    ToplamTutar DECIMAL(18,2),
    OdenecekTutar DECIMAL(18,2),
    TLTutar DECIMAL(18,2),
    TLToplamIndirim DECIMAL(18,2),
    TLKdvMatrahi DECIMAL(18,2),
    TLKdvTutari DECIMAL(18,2),
    TLToplamTutar DECIMAL(18,2),
    TLOdenecekTutar DECIMAL(18,2),
    GibGonderimDurumu NVARCHAR(50),
    FaturaDurumu NVARCHAR(50),
    ETTN NVARCHAR(100),
    ZarfDurumu NVARCHAR(50),
    ZarfDurumAciklama NVARCHAR(200),
    Iptal BIT DEFAULT 0,
    IptalTarihi DATETIME2,
    IptalEden NVARCHAR(100),
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    OlusturanKullanici INT,
    GuncellemeTarihi DATETIME2,
    GuncelleyenKullanici INT
);

-- Fatura/Irsaliye Satirlari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FatIrsSatirlar')
CREATE TABLE FatIrsSatirlar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FaturaId INT,
    SiraNo INT DEFAULT 0,
    StokId INT,
    StokKodu NVARCHAR(50),
    StokCinsi NVARCHAR(300),
    Barkod NVARCHAR(50),
    Aciklama1 NVARCHAR(500),
    Aciklama2 NVARCHAR(500),
    Aciklama3 NVARCHAR(500),
    Aciklama4 NVARCHAR(500),
    Miktar DECIMAL(18,4) DEFAULT 0,
    Birim NVARCHAR(20) DEFAULT 'Adet',
    Fiyat DECIMAL(18,4) DEFAULT 0,
    KdvOrani DECIMAL(5,2) DEFAULT 20,
    Tutar DECIMAL(18,2) DEFAULT 0,
    IskontoOrani DECIMAL(5,2) DEFAULT 0,
    IskontoTutari DECIMAL(18,2) DEFAULT 0,
    KdvMatrahi DECIMAL(18,2) DEFAULT 0,
    KdvTutari DECIMAL(18,2) DEFAULT 0,
    NetTutar DECIMAL(18,2) DEFAULT 0,
    TevkifatKodu NVARCHAR(20),
    KdvMuafiyetSebebi NVARCHAR(200),
    GTipKodu NVARCHAR(20),
    Iptal BIT DEFAULT 0
);

-- Irsaliyeler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Irsaliyeler')
CREATE TABLE Irsaliyeler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    TrCode INT DEFAULT 7,
    Tarih DATE,
    SevkTarihi DATE,
    FisNo NVARCHAR(50),
    BelgeNo NVARCHAR(50),
    CariId INT,
    VadeTarihi DATE,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    DovizKuru DECIMAL(18,4) DEFAULT 1,
    Personel NVARCHAR(100),
    Aciklama1 NVARCHAR(500),
    TasiyiciFirma NVARCHAR(200),
    SoforAdi NVARCHAR(100),
    PlakaNo NVARCHAR(20),
    SevkiyatBaslik NVARCHAR(200),
    Tutar DECIMAL(18,2),
    ToplamIndirim DECIMAL(18,2),
    KdvMatrahi DECIMAL(18,2),
    KdvTutari DECIMAL(18,2),
    ToplamTutar DECIMAL(18,2),
    OdenecekTutar DECIMAL(18,2),
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
    OlusturanKullanici INT
);

-- Siparisler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Siparisler')
CREATE TABLE Siparisler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    TrCode INT DEFAULT 1,
    Tarih DATE,
    FisNo NVARCHAR(50),
    BelgeNo NVARCHAR(50),
    CariId INT,
    VadeTarihi DATE,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    Personel NVARCHAR(100),
    Aciklama1 NVARCHAR(500),
    Tutar DECIMAL(18,2),
    KdvMatrahi DECIMAL(18,2),
    KdvTutari DECIMAL(18,2),
    ToplamTutar DECIMAL(18,2),
    Durumu NVARCHAR(20) DEFAULT 'Beklemede',
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Teklifler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Teklifler')
CREATE TABLE Teklifler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    TrCode INT DEFAULT 12,
    Tarih DATE,
    FisNo NVARCHAR(50),
    BelgeNo NVARCHAR(50),
    CariId INT,
    VadeTarihi DATE,
    OpsiyonTarihi DATE,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    Personel NVARCHAR(100),
    Aciklama1 NVARCHAR(500),
    Tutar DECIMAL(18,2),
    KdvMatrahi DECIMAL(18,2),
    KdvTutari DECIMAL(18,2),
    ToplamTutar DECIMAL(18,2),
    Durumu NVARCHAR(20) DEFAULT 'Beklemede',
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Cari Hareketler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariHareketler')
CREATE TABLE CariHareketler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FisNo NVARCHAR(50),
    Tarih DATE,
    Saat DATETIME2,
    CariId INT,
    FisId INT,
    BelgeTarihi DATE,
    BelgeNo NVARCHAR(50),
    Aciklama1 NVARCHAR(500),
    Aciklama2 NVARCHAR(500),
    IslemId INT DEFAULT 0, -- 0:Borc 1:Alacak
    OdemeId INT DEFAULT 0,
    Tutar DECIMAL(18,2) DEFAULT 0,
    DovizId NVARCHAR(10),
    Doviz NVARCHAR(10),
    DovizKuru DECIMAL(18,4) DEFAULT 1,
    Iptal BIT DEFAULT 0,
    IptalEden NVARCHAR(100),
    Kaynak NVARCHAR(50), -- Fatura, Kasa, Banka, Virman
    VirmanCekId INT,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Kasa Hareketleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KasaHareketleri')
CREATE TABLE KasaHareketleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FisId INT,
    Tarih DATE,
    FisNo NVARCHAR(50),
    KasaId INT DEFAULT 1,
    IslemId INT DEFAULT 0, -- 0:Giris 1:Cikis
    Aciklama1 NVARCHAR(500),
    Aciklama2 NVARCHAR(500),
    Tutar DECIMAL(18,2) DEFAULT 0,
    DovizId NVARCHAR(10),
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Kasalar
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kasalar')
CREATE TABLE Kasalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    KasaKodu NVARCHAR(20),
    KasaAdi NVARCHAR(100),
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    Aktif BIT DEFAULT 1
);

-- Banka Hareketleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaHareketleri')
CREATE TABLE BankaHareketleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Tarih DATE,
    IslemTipi INT, -- 1:Havale 2:KrediKarti
    FisId INT,
    FisNo NVARCHAR(50),
    IslemId INT DEFAULT 0,
    CariId INT,
    BankaId INT DEFAULT 1,
    Aciklama1 NVARCHAR(500),
    Aciklama2 NVARCHAR(500),
    Tutar DECIMAL(18,2) DEFAULT 0,
    DovizId NVARCHAR(10),
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Banka Hesap Bilgileri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaHesapBilgileri')
CREATE TABLE BankaHesapBilgileri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    BankaAdi NVARCHAR(100),
    SubeAdi NVARCHAR(100),
    HesapNo NVARCHAR(50),
    Iban NVARCHAR(50),
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    Aktif BIT DEFAULT 1
);

-- Banka Kredi Bilgileri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaKrediBilgileri')
CREATE TABLE BankaKrediBilgileri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    BankaAdi NVARCHAR(100),
    KrediTuru NVARCHAR(50),
    KrediTutari DECIMAL(18,2),
    FaizOrani DECIMAL(5,2),
    BaslangicTarihi DATE,
    BitisTarihi DATE,
    TaksitSayisi INT,
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Cek/Senet Hareketleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CekSenetHareketleri')
CREATE TABLE CekSenetHareketleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    IslemId INT,
    Tarih DATE,
    FisNo NVARCHAR(50),
    VadeTarihi DATE,
    CariId INT,
    Banka NVARCHAR(100),
    SeriNo NVARCHAR(50),
    Aciklama1 NVARCHAR(500),
    Tutar DECIMAL(18,2),
    DovizId NVARCHAR(10),
    Durumu NVARCHAR(20),
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Odeme Plani
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OdemePlani')
CREATE TABLE OdemePlani (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    CariId INT,
    CariUnvan NVARCHAR(300),
    IslemTipi NVARCHAR(50),
    OdemeTipi NVARCHAR(50),
    ToplamTutar DECIMAL(18,2),
    OnOdeme DECIMAL(18,2),
    KalanTutar DECIMAL(18,2),
    TaksitSayisi INT,
    FisNo NVARCHAR(50),
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Odeme Plani Detay
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OdemePlaniDetay')
CREATE TABLE OdemePlaniDetay (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IslemId INT FOREIGN KEY REFERENCES OdemePlani(Id),
    Sira INT,
    Tarih DATE,
    TaksitTutari DECIMAL(18,2),
    Durumu NVARCHAR(20) DEFAULT 'Bekliyor'
);

-- Birimler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Birimler')
CREATE TABLE Birimler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    BirimKodu NVARCHAR(10),
    BirimAdi NVARCHAR(50)
);

-- Doviz Kurlari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DovizKurlari')
CREATE TABLE DovizKurlari (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Tarih DATE,
    DovizKodu NVARCHAR(10),
    DovizTuru NVARCHAR(20),
    DovizKuru DECIMAL(18,4)
);

-- Gider Tipleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GiderTipleri')
CREATE TABLE GiderTipleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    GiderKodu NVARCHAR(20),
    GiderAdi NVARCHAR(100)
);

-- Ozel Kodlar
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OzelKodlar')
CREATE TABLE OzelKodlar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Grup NVARCHAR(50),
    Kod NVARCHAR(50),
    Aciklama NVARCHAR(200)
);

-- Numarator
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Numarator')
CREATE TABLE Numarator (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Tip NVARCHAR(50),
    Prefix NVARCHAR(20),
    Numara INT DEFAULT 1,
    Yil INT
);

-- Urun Gruplari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UrunGruplari')
CREATE TABLE UrunGruplari (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    GrupKodu NVARCHAR(20),
    GrupAdi NVARCHAR(100)
);

-- Personeller
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Personeller')
CREATE TABLE Personeller (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    SicilNo NVARCHAR(20),
    AdSoyad NVARCHAR(200),
    TckNo NVARCHAR(20),
    Email NVARCHAR(200),
    Telefon NVARCHAR(50),
    Unvan NVARCHAR(100),
    Departman NVARCHAR(100),
    BaslangicTarihi DATE,
    AyrilisTarihi DATE,
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Plasiyerler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Plasiyerler')
CREATE TABLE Plasiyerler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Kodu NVARCHAR(50),
    Adi NVARCHAR(200),
    Telefon NVARCHAR(50),
    Email NVARCHAR(100),
    Bolge NVARCHAR(100),
    Aciklama NVARCHAR(500),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Projeler
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Projeler')
CREATE TABLE Projeler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Kodu NVARCHAR(50),
    Adi NVARCHAR(200),
    Musteri NVARCHAR(200),
    Sorumlu NVARCHAR(200),
    BaslangicTarihi DATE,
    BitisTarihi DATE,
    Durumu NVARCHAR(50) DEFAULT 'Aktif',
    Butce DECIMAL(18,2),
    Aciklama NVARCHAR(500),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Sorumluluk Merkezleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SorumlulukMerkezleri')
CREATE TABLE SorumlulukMerkezleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    Kodu NVARCHAR(50),
    Adi NVARCHAR(200),
    UstMerkez NVARCHAR(200),
    Sorumlu NVARCHAR(200),
    Aciklama NVARCHAR(500),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Grid Kolon Ayarlari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GridKolonAyarlar')
CREATE TABLE GridKolonAyarlar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    KullaniciId INT,
    FormAdi NVARCHAR(50),
    KolonId NVARCHAR(50),
    Gorunur BIT DEFAULT 1
);

-- Hatirlatmalar
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hatirlatmalar')
CREATE TABLE Hatirlatmalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    PersId INT,
    Konu NVARCHAR(200),
    Aciklama NVARCHAR(500),
    HatirlatmaTarihi DATETIME2,
    Okundu BIT DEFAULT 0,
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Fatura Tahsilat/Odeme
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaTahsilatOdeme')
CREATE TABLE FaturaTahsilatOdeme (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FaturaId INT,
    Tarih DATE,
    Tutar DECIMAL(18,2),
    OdemeTipi NVARCHAR(50),
    HesapId INT,
    Aciklama NVARCHAR(500),
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- E-Fatura Tablolari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GidenEFaturalar')
CREATE TABLE GidenEFaturalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    FaturaId INT,
    ETTN NVARCHAR(100),
    FaturaNo NVARCHAR(50),
    Tarih DATE,
    CariUnvani NVARCHAR(300),
    VergiNo NVARCHAR(20),
    ToplamTutar DECIMAL(18,2),
    GonderimDurumu NVARCHAR(50),
    GibDurumKodu NVARCHAR(20),
    GibDurumAciklama NVARCHAR(500),
    InvoiceStatus NVARCHAR(10),
    ZarfDurumu NVARCHAR(10),
    ZarfDurumAciklama NVARCHAR(200),
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GelenFaturalar')
CREATE TABLE GelenFaturalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    RequestNumber INT,
    ETTN NVARCHAR(100),
    FaturaNo NVARCHAR(50),
    Tarih DATE,
    GonderenUnvan NVARCHAR(300),
    GonderenVkn NVARCHAR(20),
    FaturaTipi NVARCHAR(50),
    ToplamTutar DECIMAL(18,2),
    KdvTutari DECIMAL(18,2),
    Durumu NVARCHAR(50),
    CevapTarihi DATETIME2,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Satinalma Talepleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SatinAlmaTalepleri')
CREATE TABLE SatinAlmaTalepleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirmaId INT,
    TalepNo NVARCHAR(50),
    Tarih DATE,
    TalepEden NVARCHAR(100),
    Departman NVARCHAR(100),
    Aciklama NVARCHAR(500),
    Durumu NVARCHAR(20) DEFAULT 'Beklemede',
    Onaylayan NVARCHAR(100),
    OnayTarihi DATE,
    Iptal BIT DEFAULT 0,
    OlusturmaTarihi DATETIME2 DEFAULT GETDATE()
);

-- Cari Sevk Adresleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariSevkAdresleri')
CREATE TABLE CariSevkAdresleri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CariId INT,
    Baslik NVARCHAR(100),
    Telefon NVARCHAR(50),
    Adres NVARCHAR(500),
    PostaKodu NVARCHAR(10),
    Ulke NVARCHAR(50),
    Sehir NVARCHAR(50),
    Ilce NVARCHAR(50)
);

-- Fatura Banka Bilgileri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaBankaBilgileri')
CREATE TABLE FaturaBankaBilgileri (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FaturaId INT,
    BankaAdi NVARCHAR(100),
    SubeAdi NVARCHAR(100),
    HesapNo NVARCHAR(50),
    Iban NVARCHAR(50),
    ParaBirimi NVARCHAR(10)
);

-- ErpKapaliModuller (Modul Yetki Kontrolu)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ErpKapaliModuller')
CREATE TABLE ErpKapaliModuller (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SirketKodu INT,
    KullaniciLimiti INT,
    EnvanterYonetimi BIT DEFAULT 1,
    PersonelYonetimi BIT DEFAULT 1,
    FirmaAnalizi BIT DEFAULT 1,
    CariTakibi BIT DEFAULT 1,
    StokTakibi BIT DEFAULT 1
);

-- =============================================
-- VIEW'LER
-- =============================================

-- FaturalarView
IF EXISTS (SELECT * FROM sys.views WHERE name = 'FaturalarView') DROP VIEW FaturalarView;
GO
CREATE VIEW FaturalarView AS
SELECT f.*, c.CariKodu, c.Unvani, c.Vn AS CariVn, c.Email AS CariEmail, c.Telefon1 AS CariTelefon
FROM Faturalar f
LEFT JOIN CariKart c ON f.CariId = c.Id;
GO

-- CariHareketlerView
IF EXISTS (SELECT * FROM sys.views WHERE name = 'CariHareketlerView') DROP VIEW CariHareketlerView;
GO
CREATE VIEW CariHareketlerView AS
SELECT ch.*, c.CariKodu, c.Unvani
FROM CariHareketler ch
LEFT JOIN CariKart c ON ch.CariId = c.Id;
GO

-- BorcAlacakRaporu
IF EXISTS (SELECT * FROM sys.views WHERE name = 'BorcAlacakRaporu') DROP VIEW BorcAlacakRaporu;
GO
CREATE VIEW BorcAlacakRaporu AS
SELECT c.Id, c.Id AS CariId, c.CariKodu, c.Unvani,
    ISNULL(SUM(CASE WHEN ch.IslemId = 1 THEN ch.Tutar ELSE 0 END), 0) AS Borc,
    ISNULL(SUM(CASE WHEN ch.IslemId = 2 THEN ch.Tutar ELSE 0 END), 0) AS Alacak,
    ISNULL(SUM(CASE WHEN ch.IslemId = 1 THEN ch.Tutar ELSE 0 END), 0) - ISNULL(SUM(CASE WHEN ch.IslemId = 2 THEN ch.Tutar ELSE 0 END), 0) AS Bakiye,
    'TL' AS Doviz,
    0 AS Iptal
FROM CariKart c
LEFT JOIN CariHareketler ch ON c.Id = ch.CariId AND ch.Iptal = 0
GROUP BY c.Id, c.CariKodu, c.Unvani;
GO

-- KasaHareketleriView
IF EXISTS (SELECT * FROM sys.views WHERE name = 'KasaHareketleriView') DROP VIEW KasaHareketleriView;
GO
CREATE VIEW KasaHareketleriView AS
SELECT kh.*, k.KasaKodu, k.KasaAdi
FROM KasaHareketleri kh
LEFT JOIN Kasalar k ON kh.KasaId = k.Id;
GO

-- BankaHareketleriView
IF EXISTS (SELECT * FROM sys.views WHERE name = 'BankaHareketleriView') DROP VIEW BankaHareketleriView;
GO
CREATE VIEW BankaHareketleriView AS
SELECT bh.*, bhb.BankaAdi, bhb.Iban
FROM BankaHareketleri bh
LEFT JOIN BankaHesapBilgileri bhb ON bh.BankaId = bhb.Id;
GO

-- =============================================
-- ORNEK VERI
-- =============================================

-- Ornek Firma
IF NOT EXISTS (SELECT * FROM Firmalar WHERE FirmaKodu = 'PINEBI')
INSERT INTO Firmalar (FirmaKodu, FirmaUnvani, VergiNo, VergiDairesi, Telefon, Email, Sehir)
VALUES ('PINEBI', N'Pinebi Bilişim Çözümleri San. ve Tic. Ltd. Şti.', '7300724382', N'Düzce', '0380 524 24 24', 'info@pinebi.com', N'Düzce');

-- Ornek Lisans (1 yillik Enterprise)
DECLARE @FirmaId INT = (SELECT Id FROM Firmalar WHERE FirmaKodu = 'PINEBI');
IF NOT EXISTS (SELECT * FROM Lisanslar WHERE FirmaId = @FirmaId)
INSERT INTO Lisanslar (FirmaId, PlanTipi, BaslangicTarihi, BitisTarihi, MaxKullanici, MaxFaturaAylik, MaxStok, MaxCari, EFaturaAktif, EIrsaliyeAktif, EArsivAktif, Tutar, OdemeDurumu)
VALUES (@FirmaId, 'Enterprise', GETDATE(), DATEADD(YEAR, 1, GETDATE()), 10, 999999, 999999, 999999, 1, 1, 1, 9990.00, 'Odendi');

-- Ornek Kullanici (admin)
IF NOT EXISTS (SELECT * FROM Kullanicilar WHERE KullaniciAdi = 'admin')
INSERT INTO Kullanicilar (FirmaId, KullaniciAdi, Email, SifreHash, AdSoyad, Rol)
VALUES (@FirmaId, 'admin', 'admin@pinebi.com', 'admin123', N'Sistem Yöneticisi', 'Admin');

-- Demo Kullanici
IF NOT EXISTS (SELECT * FROM Kullanicilar WHERE KullaniciAdi = 'demo')
INSERT INTO Kullanicilar (FirmaId, KullaniciAdi, Email, SifreHash, AdSoyad, Rol)
VALUES (@FirmaId, 'demo', 'demo@pinebi.com', 'demo', N'Demo Kullanıcı', 'Kullanici');

-- Kullanici Yetkileri
DECLARE @AdminId INT = (SELECT Id FROM Kullanicilar WHERE KullaniciAdi = 'admin');
IF NOT EXISTS (SELECT * FROM KullaniciYetkileri WHERE KullaniciId = @AdminId)
INSERT INTO KullaniciYetkileri (KullaniciId, SirketProfili, FirmaBilgileri, EnvanterYonetimi, PersonelYonetimi, MuhasebeIslemleri, CariIslemler, SatisIslemleri, SatinalmaIslemleri, EFaturaIslemleri, EFaturaGonder, StokYonetimi, RaporGorme, KullaniciTanimlama, AyarlarDuzenleme)
VALUES (@AdminId, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

DECLARE @DemoId INT = (SELECT Id FROM Kullanicilar WHERE KullaniciAdi = 'demo');
IF NOT EXISTS (SELECT * FROM KullaniciYetkileri WHERE KullaniciId = @DemoId)
INSERT INTO KullaniciYetkileri (KullaniciId, SirketProfili, FirmaBilgileri, EnvanterYonetimi, PersonelYonetimi, MuhasebeIslemleri, CariIslemler, SatisIslemleri, SatinalmaIslemleri, EFaturaIslemleri, EFaturaGonder, StokYonetimi, RaporGorme, KullaniciTanimlama, AyarlarDuzenleme)
VALUES (@DemoId, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0);

-- Ornek Birimler
IF NOT EXISTS (SELECT * FROM Birimler)
BEGIN
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'AD', 'Adet');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'KG', 'Kilogram');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'LT', 'Litre');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'MT', 'Metre');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'KT', 'Kutu');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'PK', 'Paket');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'TK', N'Takım');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'M2', N'Metrekare');
END;

-- Ornek Kasalar
IF NOT EXISTS (SELECT * FROM Kasalar)
BEGIN
    INSERT INTO Kasalar (FirmaId, KasaKodu, KasaAdi, DovizKodu) VALUES (@FirmaId, 'KASA-TL', 'Ana Kasa TL', 'TL');
    INSERT INTO Kasalar (FirmaId, KasaKodu, KasaAdi, DovizKodu) VALUES (@FirmaId, 'KASA-USD', 'Dolar Kasasi', 'USD');
END;

-- Numarator
IF NOT EXISTS (SELECT * FROM Numarator)
BEGIN
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'SatisFatura', 'STA', 1, 2026);
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'AlisFatura', 'ALS', 1, 2026);
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'Irsaliye', 'IRS', 1, 2026);
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'Siparis', 'SIP', 1, 2026);
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'Teklif', 'TEK', 1, 2026);
    INSERT INTO Numarator (FirmaId, Tip, Prefix, Numara, Yil) VALUES (@FirmaId, 'Tahsilat', 'THS', 1, 2026);
END;

PRINT 'PineERP Database basariyla olusturuldu!';
PRINT 'Tablolar: ' + CAST((SELECT COUNT(*) FROM sys.tables) AS NVARCHAR);
PRINT 'View''ler: ' + CAST((SELECT COUNT(*) FROM sys.views WHERE schema_id = SCHEMA_ID('dbo')) AS NVARCHAR);
GO
