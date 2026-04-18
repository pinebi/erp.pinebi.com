using MACHINEBISS_Web.Components;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// MSSQL PineERP - Tek veritabani baglantisi
var connStr = "Server=185.210.92.248;Database=PineERP;User Id=EDonusum;Password=150399AA-DB5B-47D9-BF31-69EB984CB5DF;TrustServerCertificate=True;Connection Timeout=30;Command Timeout=60;";

builder.Services.AddDbContextFactory<FirmaContext>(options =>
    options.UseSqlServer(connStr));

builder.Services.AddDbContextFactory<NetworkContext>(options =>
    options.UseSqlServer(connStr));

// PineERP - Yeni profesyonel DB context
builder.Services.AddDbContextFactory<PineErpContext>(options =>
    options.UseSqlServer(connStr));

// API Controllers
builder.Services.AddControllers();

// Services
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<SistemAyarlariService>();
builder.Services.AddScoped<TabService>();
builder.Services.AddScoped<ConfirmService>();
builder.Services.AddScoped<IlIlceService>();
builder.Services.AddScoped<FaturaAlanAyarlariService>();
builder.Services.AddScoped<LisansService>();
builder.Services.AddSingleton<DovizKuruService>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<DovizKuruService>());

// Güvenlik servisleri
builder.Services.AddSingleton<LoginAttemptTracker>();
builder.Services.AddHttpContextAccessor();

// HSTS (HTTP Strict Transport Security) yapılandırması
builder.Services.AddHsts(options =>
{
    options.Preload = true;
    options.IncludeSubDomains = true;
    options.MaxAge = TimeSpan.FromDays(365);
});

// HttpClient for Blazor Server -> API calls
builder.Services.AddScoped(sp =>
{
    var navigationManager = sp.GetRequiredService<Microsoft.AspNetCore.Components.NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(navigationManager.BaseUri) };
});

var app = builder.Build();

// PineERP - Yeni tablo yapisi olustur (113 tablo)
try
{
    using var pineScope = app.Services.CreateScope();
    var pineFactory = pineScope.ServiceProvider.GetRequiredService<IDbContextFactory<PineErpContext>>();
    using var pineDb = pineFactory.CreateDbContext();

    // EnsureCreated mevcut DB'de calismaz - RelationalDatabaseCreator ile sadece tablolari olustur
    var dbCreator = pineDb.GetService<Microsoft.EntityFrameworkCore.Storage.IRelationalDatabaseCreator>();
    try { dbCreator.CreateTables(); Console.WriteLine("PineERP tablolari olusturuldu (113 tablo)."); }
    catch (Exception exT) { Console.WriteLine($"PineERP tablolar zaten mevcut veya hata: {exT.Message?.Substring(0, Math.Min(100, exT.Message?.Length ?? 0))}"); }

    // Auto-migration: mevcut tablolara modelde eklenmis eksik kolonlari ALTER TABLE ile ekle
    try
    {
        MACHINEBISS_Web.Services.AutoMigrator.SyncMissingColumns(pineDb);
    }
    catch (Exception exM) { Console.WriteLine($"AutoMigrator hatasi: {exM.Message}"); }

    // Seed: Fiyat Gruplari
    if (!pineDb.FiyatGruplari.Any())
    {
        pineDb.FiyatGruplari.AddRange(
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineFiyatGruplari { FgrGrupNo = 1, FgrIsim = "Perakende", FgrOncelikSirasi = 1, FgrAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineFiyatGruplari { FgrGrupNo = 2, FgrIsim = "Toptan", FgrOncelikSirasi = 2, FgrAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineFiyatGruplari { FgrGrupNo = 3, FgrIsim = "Bayi", FgrOncelikSirasi = 3, FgrAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineFiyatGruplari { FgrGrupNo = 4, FgrIsim = "Ozel", FgrOncelikSirasi = 4, FgrAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineFiyatGruplari { FgrGrupNo = 5, FgrIsim = "VIP", FgrOncelikSirasi = 5, FgrAktif = true }
        );
        pineDb.SaveChanges();
        Console.WriteLine("Fiyat gruplari seed edildi.");
    }

    // Seed: Birimler
    if (!pineDb.Birimler.Any())
    {
        pineDb.Birimler.AddRange(
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "AD", BirIsim = "Adet", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "KG", BirIsim = "Kilogram", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "LT", BirIsim = "Litre", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "MT", BirIsim = "Metre", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "M2", BirIsim = "Metrekare", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "PK", BirIsim = "Paket", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "KL", BirIsim = "Koli", BirAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineBirimler { BirKod = "TN", BirIsim = "Ton", BirAktif = true }
        );
        pineDb.SaveChanges();
        Console.WriteLine("Birimler seed edildi.");
    }

    // Seed: KDV Oranlari
    if (!pineDb.KdvOranlari.Any())
    {
        pineDb.KdvOranlari.AddRange(
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineKdvOranlari { KdoOran = 0, KdoAciklama = "%0 KDV", KdoAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineKdvOranlari { KdoOran = 1, KdoAciklama = "%1 KDV", KdoAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineKdvOranlari { KdoOran = 10, KdoAciklama = "%10 KDV", KdoAktif = true },
            new MACHINEBISS_Web.Models.PineERP.Tanimlar.PineKdvOranlari { KdoOran = 20, KdoAciklama = "%20 KDV", KdoAktif = true }
        );
        pineDb.SaveChanges();
        Console.WriteLine("KDV oranlari seed edildi.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"PineERP tablo olusturma hatasi: {ex.Message}");
}

// İl/İlçe seed + internetten güncelle
try
{
    using var ilScope = app.Services.CreateScope();
    var ilSvc = ilScope.ServiceProvider.GetRequiredService<IlIlceService>();
    await ilSvc.SeedAsync();
    _ = Task.Run(async () => { try { await ilSvc.InternettenGuncelleAsync(); } catch { } });
}
catch (Exception ex) { Console.WriteLine($"İl/İlçe hatası: {ex.Message}"); }

// MSSQL PineERP baglanti testi (eski tablolar)
try
{
    using var scope = app.Services.CreateScope();
    var firmaFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<FirmaContext>>();
    using var firmaDb = firmaFactory.CreateDbContext();

    // Baglanti testi
    await firmaDb.Database.CanConnectAsync();
    Console.WriteLine("MSSQL PineERP connected!");

    // EF Core ile cari/stok test
    try
    {
        var testCariler = firmaDb.Cariler.AsNoTracking().Take(3).ToList();
        Console.WriteLine($"EF Cariler test: {testCariler.Count} kayit yuklendi");
        foreach (var c in testCariler)
            Console.WriteLine($"  Cari: {c.CariKodu} - {c.Unvani}");
    }
    catch (Exception ex2) { Console.WriteLine($"EF Cariler HATA: {ex2.Message}"); }

    try
    {
        var testStok = firmaDb.StokKart.AsNoTracking().Take(3).ToList();
        Console.WriteLine($"EF StokKart test: {testStok.Count} kayit yuklendi");
        foreach (var s in testStok)
            Console.WriteLine($"  Stok: {s.StokKodu} - {s.StokCinsi}");
    }
    catch (Exception ex3) { Console.WriteLine($"EF StokKart HATA: {ex3.Message}"); }

    // Eksik kolonlari ekle (migration yerine)
    try
    {
        var alterSqls = new List<string>();

        // ==========================================
        // SISTEM TABLOLARI (Firmalar, Kullanicilar, KullaniciYetkileri, Lisanslar, LisansGecmisi)
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Firmalar') CREATE TABLE Firmalar (Id INT IDENTITY(1,1) PRIMARY KEY, FirmaKodu NVARCHAR(50), FirmaUnvani NVARCHAR(300), VergiNo NVARCHAR(50), VergiDairesi NVARCHAR(200), Telefon NVARCHAR(50), Email NVARCHAR(200), Adres NVARCHAR(500), Sehir NVARCHAR(100), Ilce NVARCHAR(100), PostaKodu NVARCHAR(20), WebSitesi NVARCHAR(200), LogoUrl NVARCHAR(500), Aktif BIT DEFAULT 1, OlusturmaTarihi DATETIME2, GuncellemeTarihi DATETIME2)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','FirmaKodu') IS NULL ALTER TABLE Firmalar ADD FirmaKodu NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','FirmaUnvani') IS NULL ALTER TABLE Firmalar ADD FirmaUnvani NVARCHAR(300)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','VergiNo') IS NULL ALTER TABLE Firmalar ADD VergiNo NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','VergiDairesi') IS NULL ALTER TABLE Firmalar ADD VergiDairesi NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Telefon') IS NULL ALTER TABLE Firmalar ADD Telefon NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Email') IS NULL ALTER TABLE Firmalar ADD Email NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Adres') IS NULL ALTER TABLE Firmalar ADD Adres NVARCHAR(500)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Sehir') IS NULL ALTER TABLE Firmalar ADD Sehir NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Ilce') IS NULL ALTER TABLE Firmalar ADD Ilce NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','PostaKodu') IS NULL ALTER TABLE Firmalar ADD PostaKodu NVARCHAR(20)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','WebSitesi') IS NULL ALTER TABLE Firmalar ADD WebSitesi NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','LogoUrl') IS NULL ALTER TABLE Firmalar ADD LogoUrl NVARCHAR(500)");
        alterSqls.Add("IF COL_LENGTH('Firmalar','Aktif') IS NULL ALTER TABLE Firmalar ADD Aktif BIT DEFAULT 1");
        alterSqls.Add("IF COL_LENGTH('Firmalar','OlusturmaTarihi') IS NULL ALTER TABLE Firmalar ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Firmalar','GuncellemeTarihi') IS NULL ALTER TABLE Firmalar ADD GuncellemeTarihi DATETIME2");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar') CREATE TABLE Kullanicilar (Id INT IDENTITY(1,1) PRIMARY KEY, FirmaId INT, KullaniciAdi NVARCHAR(100), SifreHash NVARCHAR(500), AdSoyad NVARCHAR(200), Email NVARCHAR(200), Telefon NVARCHAR(50), Rol NVARCHAR(50), Gorevi NVARCHAR(200), Aktif BIT DEFAULT 1, SonGirisTarihi DATETIME2, OlusturmaTarihi DATETIME2, GuncellemeTarihi DATETIME2)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','FirmaId') IS NULL ALTER TABLE Kullanicilar ADD FirmaId INT");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','KullaniciAdi') IS NULL ALTER TABLE Kullanicilar ADD KullaniciAdi NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','SifreHash') IS NULL ALTER TABLE Kullanicilar ADD SifreHash NVARCHAR(500)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','AdSoyad') IS NULL ALTER TABLE Kullanicilar ADD AdSoyad NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','Email') IS NULL ALTER TABLE Kullanicilar ADD Email NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','Telefon') IS NULL ALTER TABLE Kullanicilar ADD Telefon NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','Rol') IS NULL ALTER TABLE Kullanicilar ADD Rol NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','Gorevi') IS NULL ALTER TABLE Kullanicilar ADD Gorevi NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','Aktif') IS NULL ALTER TABLE Kullanicilar ADD Aktif BIT DEFAULT 1");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','SonGirisTarihi') IS NULL ALTER TABLE Kullanicilar ADD SonGirisTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','OlusturmaTarihi') IS NULL ALTER TABLE Kullanicilar ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Kullanicilar','GuncellemeTarihi') IS NULL ALTER TABLE Kullanicilar ADD GuncellemeTarihi DATETIME2");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KullaniciYetkileri') CREATE TABLE KullaniciYetkileri (Id INT IDENTITY(1,1) PRIMARY KEY, KullaniciId INT, SirketProfili BIT, FirmaBilgileri BIT, EnvanterYonetimi BIT, PersonelYonetimi BIT, MuhasebeIslemleri BIT, CariIslemler BIT, SatisIslemleri BIT, SatinalmaIslemleri BIT, EFaturaIslemleri BIT, EFaturaGonder BIT, StokYonetimi BIT, RaporGorme BIT, KullaniciTanimlama BIT, AyarlarDuzenleme BIT)");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','KullaniciId') IS NULL ALTER TABLE KullaniciYetkileri ADD KullaniciId INT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','SirketProfili') IS NULL ALTER TABLE KullaniciYetkileri ADD SirketProfili BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','FirmaBilgileri') IS NULL ALTER TABLE KullaniciYetkileri ADD FirmaBilgileri BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','EnvanterYonetimi') IS NULL ALTER TABLE KullaniciYetkileri ADD EnvanterYonetimi BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','PersonelYonetimi') IS NULL ALTER TABLE KullaniciYetkileri ADD PersonelYonetimi BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','MuhasebeIslemleri') IS NULL ALTER TABLE KullaniciYetkileri ADD MuhasebeIslemleri BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','CariIslemler') IS NULL ALTER TABLE KullaniciYetkileri ADD CariIslemler BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','SatisIslemleri') IS NULL ALTER TABLE KullaniciYetkileri ADD SatisIslemleri BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','SatinalmaIslemleri') IS NULL ALTER TABLE KullaniciYetkileri ADD SatinalmaIslemleri BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','EFaturaIslemleri') IS NULL ALTER TABLE KullaniciYetkileri ADD EFaturaIslemleri BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','EFaturaGonder') IS NULL ALTER TABLE KullaniciYetkileri ADD EFaturaGonder BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','StokYonetimi') IS NULL ALTER TABLE KullaniciYetkileri ADD StokYonetimi BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','RaporGorme') IS NULL ALTER TABLE KullaniciYetkileri ADD RaporGorme BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','KullaniciTanimlama') IS NULL ALTER TABLE KullaniciYetkileri ADD KullaniciTanimlama BIT");
        alterSqls.Add("IF COL_LENGTH('KullaniciYetkileri','AyarlarDuzenleme') IS NULL ALTER TABLE KullaniciYetkileri ADD AyarlarDuzenleme BIT");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Lisanslar') CREATE TABLE Lisanslar (Id INT IDENTITY(1,1) PRIMARY KEY, FirmaId INT, LisansKodu UNIQUEIDENTIFIER, PlanTipi NVARCHAR(50), BaslangicTarihi DATETIME2, BitisTarihi DATETIME2, MaxKullanici INT, MaxFaturaAylik INT, MaxStok INT, MaxCari INT, EFaturaAktif BIT, EIrsaliyeAktif BIT, EArsivAktif BIT, Tutar DECIMAL(18,2), ParaBirimi NVARCHAR(10), OdemeDurumu NVARCHAR(50), OtomatikYenileme BIT, YenilemePeriyodu NVARCHAR(50), Aktif BIT DEFAULT 1, OlusturmaTarihi DATETIME2, GuncellemeTarihi DATETIME2)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','FirmaId') IS NULL ALTER TABLE Lisanslar ADD FirmaId INT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','LisansKodu') IS NULL ALTER TABLE Lisanslar ADD LisansKodu UNIQUEIDENTIFIER");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','PlanTipi') IS NULL ALTER TABLE Lisanslar ADD PlanTipi NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','BaslangicTarihi') IS NULL ALTER TABLE Lisanslar ADD BaslangicTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','BitisTarihi') IS NULL ALTER TABLE Lisanslar ADD BitisTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','MaxKullanici') IS NULL ALTER TABLE Lisanslar ADD MaxKullanici INT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','MaxFaturaAylik') IS NULL ALTER TABLE Lisanslar ADD MaxFaturaAylik INT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','MaxStok') IS NULL ALTER TABLE Lisanslar ADD MaxStok INT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','MaxCari') IS NULL ALTER TABLE Lisanslar ADD MaxCari INT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','EFaturaAktif') IS NULL ALTER TABLE Lisanslar ADD EFaturaAktif BIT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','EIrsaliyeAktif') IS NULL ALTER TABLE Lisanslar ADD EIrsaliyeAktif BIT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','EArsivAktif') IS NULL ALTER TABLE Lisanslar ADD EArsivAktif BIT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','Tutar') IS NULL ALTER TABLE Lisanslar ADD Tutar DECIMAL(18,2)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','ParaBirimi') IS NULL ALTER TABLE Lisanslar ADD ParaBirimi NVARCHAR(10)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','OdemeDurumu') IS NULL ALTER TABLE Lisanslar ADD OdemeDurumu NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','OtomatikYenileme') IS NULL ALTER TABLE Lisanslar ADD OtomatikYenileme BIT");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','YenilemePeriyodu') IS NULL ALTER TABLE Lisanslar ADD YenilemePeriyodu NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','Aktif') IS NULL ALTER TABLE Lisanslar ADD Aktif BIT DEFAULT 1");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','OlusturmaTarihi') IS NULL ALTER TABLE Lisanslar ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Lisanslar','GuncellemeTarihi') IS NULL ALTER TABLE Lisanslar ADD GuncellemeTarihi DATETIME2");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LisansGecmisi') CREATE TABLE LisansGecmisi (Id INT IDENTITY(1,1) PRIMARY KEY, LisansId INT, IslemTipi NVARCHAR(50), EskiPlan NVARCHAR(50), YeniPlan NVARCHAR(50), EskiBitisTarihi DATETIME2, YeniBitisTarihi DATETIME2, Tutar DECIMAL(18,2), Aciklama NVARCHAR(500), IslemTarihi DATETIME2)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','LisansId') IS NULL ALTER TABLE LisansGecmisi ADD LisansId INT");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','IslemTipi') IS NULL ALTER TABLE LisansGecmisi ADD IslemTipi NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','EskiPlan') IS NULL ALTER TABLE LisansGecmisi ADD EskiPlan NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','YeniPlan') IS NULL ALTER TABLE LisansGecmisi ADD YeniPlan NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','EskiBitisTarihi') IS NULL ALTER TABLE LisansGecmisi ADD EskiBitisTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','YeniBitisTarihi') IS NULL ALTER TABLE LisansGecmisi ADD YeniBitisTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','Tutar') IS NULL ALTER TABLE LisansGecmisi ADD Tutar DECIMAL(18,2)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','Aciklama') IS NULL ALTER TABLE LisansGecmisi ADD Aciklama NVARCHAR(500)");
        alterSqls.Add("IF COL_LENGTH('LisansGecmisi','IslemTarihi') IS NULL ALTER TABLE LisansGecmisi ADD IslemTarihi DATETIME2");

        // ==========================================
        // FATURALAR TABLOSU
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('Faturalar','OlusturanKullanici') IS NULL ALTER TABLE Faturalar ADD OlusturanKullanici INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','GuncellemeTarihi') IS NULL ALTER TABLE Faturalar ADD GuncellemeTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','GuncelleyenKullanici') IS NULL ALTER TABLE Faturalar ADD GuncelleyenKullanici INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','OlusturmaTarihi') IS NULL ALTER TABLE Faturalar ADD OlusturmaTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','IptalTarihi') IS NULL ALTER TABLE Faturalar ADD IptalTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','IptalEden') IS NULL ALTER TABLE Faturalar ADD IptalEden NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','FisTipi') IS NULL ALTER TABLE Faturalar ADD FisTipi NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TrCode') IS NULL ALTER TABLE Faturalar ADD TrCode INT DEFAULT 0");
        alterSqls.Add("IF COL_LENGTH('Faturalar','FaturaTuru') IS NULL ALTER TABLE Faturalar ADD FaturaTuru NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','IhracatTasimaKodu') IS NULL ALTER TABLE Faturalar ADD IhracatTasimaKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','EvrakTipi') IS NULL ALTER TABLE Faturalar ADD EvrakTipi INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','IslemTipi') IS NULL ALTER TABLE Faturalar ADD IslemTipi NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','SevkTarihi') IS NULL ALTER TABLE Faturalar ADD SevkTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','OzelKod1') IS NULL ALTER TABLE Faturalar ADD OzelKod1 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','OzelKod2') IS NULL ALTER TABLE Faturalar ADD OzelKod2 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','OzelKod3') IS NULL ALTER TABLE Faturalar ADD OzelKod3 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','KapayanHesapId') IS NULL ALTER TABLE Faturalar ADD KapayanHesapId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TemlikTarihi') IS NULL ALTER TABLE Faturalar ADD TemlikTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','OpsiyonTarihi') IS NULL ALTER TABLE Faturalar ADD OpsiyonTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','SiparisNo') IS NULL ALTER TABLE Faturalar ADD SiparisNo NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','SiparisTarihi') IS NULL ALTER TABLE Faturalar ADD SiparisTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','IsyeriNo') IS NULL ALTER TABLE Faturalar ADD IsyeriNo INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','AmbarNo') IS NULL ALTER TABLE Faturalar ADD AmbarNo INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','DovizKodu') IS NULL ALTER TABLE Faturalar ADD DovizKodu NVARCHAR(10) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','DovizTuru') IS NULL ALTER TABLE Faturalar ADD DovizTuru INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','DovizKuru') IS NULL ALTER TABLE Faturalar ADD DovizKuru DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','SatinalmaSorumlusu') IS NULL ALTER TABLE Faturalar ADD SatinalmaSorumlusu NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','BolumSatinAlmaSorumlusu') IS NULL ALTER TABLE Faturalar ADD BolumSatinAlmaSorumlusu NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','ProformaNo') IS NULL ALTER TABLE Faturalar ADD ProformaNo NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','ProjeId') IS NULL ALTER TABLE Faturalar ADD ProjeId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','PlasiyerId') IS NULL ALTER TABLE Faturalar ADD PlasiyerId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','SorumlulukMerkeziId') IS NULL ALTER TABLE Faturalar ADD SorumlulukMerkeziId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','Aciklama4') IS NULL ALTER TABLE Faturalar ADD Aciklama4 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','Aciklama5') IS NULL ALTER TABLE Faturalar ADD Aciklama5 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TevkifatMuafiyeti') IS NULL ALTER TABLE Faturalar ADD TevkifatMuafiyeti DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLTutar') IS NULL ALTER TABLE Faturalar ADD TLTutar DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLToplamIndirim') IS NULL ALTER TABLE Faturalar ADD TLToplamIndirim DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLKdvMatrahi') IS NULL ALTER TABLE Faturalar ADD TLKdvMatrahi DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLKdvTutari') IS NULL ALTER TABLE Faturalar ADD TLKdvTutari DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLToplamTutar') IS NULL ALTER TABLE Faturalar ADD TLToplamTutar DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','TLOdenecekTutar') IS NULL ALTER TABLE Faturalar ADD TLOdenecekTutar DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','GibGonderimDurumu') IS NULL ALTER TABLE Faturalar ADD GibGonderimDurumu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','FaturaDurumu') IS NULL ALTER TABLE Faturalar ADD FaturaDurumu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','ETTN') IS NULL ALTER TABLE Faturalar ADD ETTN NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','ZarfDurumu') IS NULL ALTER TABLE Faturalar ADD ZarfDurumu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','ZarfDurumAciklama') IS NULL ALTER TABLE Faturalar ADD ZarfDurumAciklama NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Faturalar','Iptal') IS NULL ALTER TABLE Faturalar ADD Iptal BIT NULL");

        // ==========================================
        // FATURALAR TEMP TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturalarTemp') CREATE TABLE FaturalarTemp (Id INT IDENTITY(1,1) PRIMARY KEY, FisTipi NVARCHAR(50), TrCode INT DEFAULT 0, FaturaTuru NVARCHAR(100), IhracatTasimaKodu NVARCHAR(50), EvrakTipi INT, IslemTipi NVARCHAR(50), Tarih DATETIME2, SevkTarihi DATETIME2, FisNo NVARCHAR(100), BelgeNo NVARCHAR(100), OzelKod1 NVARCHAR(100), OzelKod2 NVARCHAR(100), OzelKod3 NVARCHAR(100), CariId INT DEFAULT 0, FaturaTipi INT, OdemeTipi INT, KapayanHesapId INT, VadeTarihi DATETIME2, TemlikTarihi DATETIME2, OpsiyonTarihi DATETIME2, SiparisNo NVARCHAR(100), SiparisTarihi DATETIME2, IsyeriNo INT, AmbarNo INT, DovizKodu NVARCHAR(10), DovizTuru INT, DovizKuru DECIMAL(18,4), Personel NVARCHAR(200), Aciklama1 NVARCHAR(500), Aciklama2 NVARCHAR(500), Aciklama3 NVARCHAR(500), Aciklama4 NVARCHAR(500), Aciklama5 NVARCHAR(500), Tutar DECIMAL(18,4), ToplamIndirim DECIMAL(18,4), KdvMatrahi DECIMAL(18,4), KdvTutari DECIMAL(18,4), TevkifatMuafiyeti DECIMAL(18,4), ToplamTutar DECIMAL(18,4), OdenecekTutar DECIMAL(18,4), TLTutar DECIMAL(18,4), TLToplamIndirim DECIMAL(18,4), TLKdvMatrahi DECIMAL(18,4), TLKdvTutari DECIMAL(18,4), TLToplamTutar DECIMAL(18,4), TLOdenecekTutar DECIMAL(18,4), GibGonderimDurumu NVARCHAR(100), FaturaDurumu NVARCHAR(100), ETTN NVARCHAR(200), ZarfDurumu NVARCHAR(100), ZarfDurumAciklama NVARCHAR(500), Iptal BIT)");

        // ==========================================
        // FATURA IPTAL LOG TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaIptalLog') CREATE TABLE FaturaIptalLog (Id INT IDENTITY(1,1) PRIMARY KEY, FaturaTipi INT, FaturaTuru NVARCHAR(100), FaturaTarihi DATETIME2, FaturaNo NVARCHAR(100), IptalTarihi DATETIME2, IptalEden NVARCHAR(200))");

        // ==========================================
        // IRSALIYELER TABLOSU
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','SevkAdresId') IS NULL ALTER TABLE Irsaliyeler ADD SevkAdresId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciFirmaKodu') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciFirmaKodu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciFirmaUnvani') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciFirmaUnvani NVARCHAR(300) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciSoforAdi') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciSoforAdi NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciSoforSoyadi') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciSoforSoyadi NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciSoforTckNo') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciSoforTckNo NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','TasiyiciAracPlakaNo') IS NULL ALTER TABLE Irsaliyeler ADD TasiyiciAracPlakaNo NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','FaturaTuruId') IS NULL ALTER TABLE Irsaliyeler ADD FaturaTuruId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','Guid') IS NULL ALTER TABLE Irsaliyeler ADD Guid NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','GibGonderimDurumu') IS NULL ALTER TABLE Irsaliyeler ADD GibGonderimDurumu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','GibDurumKodu') IS NULL ALTER TABLE Irsaliyeler ADD GibDurumKodu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Irsaliyeler','Iptal') IS NULL ALTER TABLE Irsaliyeler ADD Iptal INT NULL");

        // ==========================================
        // SIPARISLER TABLOSU
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('Siparisler','TemlikTarihi') IS NULL ALTER TABLE Siparisler ADD TemlikTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Siparisler','DovizKuru') IS NULL ALTER TABLE Siparisler ADD DovizKuru FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Siparisler','UsdKur') IS NULL ALTER TABLE Siparisler ADD UsdKur FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Siparisler','EuroKur') IS NULL ALTER TABLE Siparisler ADD EuroKur FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Siparisler','Guid') IS NULL ALTER TABLE Siparisler ADD Guid NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Siparisler','Iptal') IS NULL ALTER TABLE Siparisler ADD Iptal INT NULL");

        // ==========================================
        // FAT_IRS_SATIRLAR TABLOSU
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','Aciklama2') IS NULL ALTER TABLE FatIrsSatirlar ADD Aciklama2 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','Aciklama3') IS NULL ALTER TABLE FatIrsSatirlar ADD Aciklama3 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','Aciklama4') IS NULL ALTER TABLE FatIrsSatirlar ADD Aciklama4 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','TevkifatKodu') IS NULL ALTER TABLE FatIrsSatirlar ADD TevkifatKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','KdvMuafiyetSebebi') IS NULL ALTER TABLE FatIrsSatirlar ADD KdvMuafiyetSebebi NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('FatIrsSatirlar','GTipKodu') IS NULL ALTER TABLE FatIrsSatirlar ADD GTipKodu NVARCHAR(50) NULL");

        // ==========================================
        // TEKLIFLER TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Teklifler') CREATE TABLE Teklifler (Id INT IDENTITY(1,1) PRIMARY KEY, FisTipi NVARCHAR(50), TrCode INT DEFAULT 0, FaturaTuru NVARCHAR(100), Tarih DATETIME2, SevkTarihi DATETIME2, FisNo NVARCHAR(100), BelgeNo NVARCHAR(100), ProjeNo NVARCHAR(100), OzelKod1 NVARCHAR(100), OzelKod2 NVARCHAR(100), OzelKod3 NVARCHAR(100), CariId INT DEFAULT 0, FaturaTipi INT, OdemeTipi INT, VadeTarihi DATETIME2, TemlikTarihi DATETIME2, OpsiyonTarihi DATETIME2, SiparisNo NVARCHAR(100), SiparisTarihi DATETIME2, IsyeriNo INT, AmbarNo INT, DovizKodu NVARCHAR(10), Personel NVARCHAR(200), Aciklama1 NVARCHAR(500), Aciklama2 NVARCHAR(500), Aciklama3 NVARCHAR(500), Aciklama4 NVARCHAR(500), Aciklama5 NVARCHAR(500), Tutar FLOAT, ToplamIndirim FLOAT, KdvMatrahi FLOAT, KdvTutari FLOAT, TevkifatMuafiyeti FLOAT, ToplamTutar FLOAT, OdenecekTutar FLOAT, TLTutar FLOAT, TLToplamIndirim FLOAT, TLKdvMatrahi FLOAT, TLKdvTutari FLOAT, TLTevkifatMuafiyeti FLOAT, TLToplamTutar FLOAT, TLOdenecekTutar FLOAT, FaturaTuruId INT, DovizKuru FLOAT, Guid NVARCHAR(100), Status INT, GibGonderimDurumu NVARCHAR(100), GibDurumKodu NVARCHAR(100), InvoiceStatus NVARCHAR(100), InvoiceStatusDescription NVARCHAR(500), EnvelopeStatus NVARCHAR(100), EnvelopeStatusDescription NVARCHAR(500), Iptal INT, GelenFaturaId INT, ProformaNo NVARCHAR(100), SatinalmaSorumlusu NVARCHAR(200), BolumSatinAlmaSorumlusu NVARCHAR(200), SevkAdresId INT, FaturaDurumu NVARCHAR(100))");
        alterSqls.Add("IF COL_LENGTH('Teklifler','ProjeNo') IS NULL ALTER TABLE Teklifler ADD ProjeNo NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLTutar') IS NULL ALTER TABLE Teklifler ADD TLTutar FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLToplamIndirim') IS NULL ALTER TABLE Teklifler ADD TLToplamIndirim FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLKdvMatrahi') IS NULL ALTER TABLE Teklifler ADD TLKdvMatrahi FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLKdvTutari') IS NULL ALTER TABLE Teklifler ADD TLKdvTutari FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLTevkifatMuafiyeti') IS NULL ALTER TABLE Teklifler ADD TLTevkifatMuafiyeti FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLToplamTutar') IS NULL ALTER TABLE Teklifler ADD TLToplamTutar FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','TLOdenecekTutar') IS NULL ALTER TABLE Teklifler ADD TLOdenecekTutar FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','Status') IS NULL ALTER TABLE Teklifler ADD Status INT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','InvoiceStatus') IS NULL ALTER TABLE Teklifler ADD InvoiceStatus NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','InvoiceStatusDescription') IS NULL ALTER TABLE Teklifler ADD InvoiceStatusDescription NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','EnvelopeStatus') IS NULL ALTER TABLE Teklifler ADD EnvelopeStatus NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','EnvelopeStatusDescription') IS NULL ALTER TABLE Teklifler ADD EnvelopeStatusDescription NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','GelenFaturaId') IS NULL ALTER TABLE Teklifler ADD GelenFaturaId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','ProformaNo') IS NULL ALTER TABLE Teklifler ADD ProformaNo NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','SatinalmaSorumlusu') IS NULL ALTER TABLE Teklifler ADD SatinalmaSorumlusu NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','BolumSatinAlmaSorumlusu') IS NULL ALTER TABLE Teklifler ADD BolumSatinAlmaSorumlusu NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','SevkAdresId') IS NULL ALTER TABLE Teklifler ADD SevkAdresId INT NULL");
        alterSqls.Add("IF COL_LENGTH('Teklifler','FaturaDurumu') IS NULL ALTER TABLE Teklifler ADD FaturaDurumu NVARCHAR(100) NULL");

        // ==========================================
        // TEKLIF SATIRLAR TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TeklifSatirlar') CREATE TABLE TeklifSatirlar (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, TrCode INT DEFAULT 0, FaturaId INT, IrsaliyeId INT, FaturaTipi INT, CariId INT, StokId INT, Barkod NVARCHAR(100), StokKodu NVARCHAR(100), StokCinsi NVARCHAR(300), Aciklama NVARCHAR(500), IsyeriNo INT, AmbarNo INT, Birim NVARCHAR(50), Miktar FLOAT DEFAULT 0, OnaylananMiktar FLOAT, DovizKodu NVARCHAR(10), Fiyat FLOAT DEFAULT 0, Indirim1 FLOAT DEFAULT 0, Indirim2 FLOAT DEFAULT 0, Indirim3 FLOAT DEFAULT 0, IndirimTutari FLOAT DEFAULT 0, Tutar FLOAT DEFAULT 0, Kdv FLOAT DEFAULT 0, KdvMatrahi FLOAT DEFAULT 0, KdvTutari FLOAT DEFAULT 0, NetTutar FLOAT DEFAULT 0, KdvMuafiyetSebebi NVARCHAR(200), TevkifatId SMALLINT, TevkifatKodu NVARCHAR(50), TevkifatCarpan FLOAT, TevkifatBolen FLOAT, TevkifatMuafiyeti FLOAT, Iptal INT DEFAULT 0)");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','OnaylananMiktar') IS NULL ALTER TABLE TeklifSatirlar ADD OnaylananMiktar FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','TevkifatId') IS NULL ALTER TABLE TeklifSatirlar ADD TevkifatId SMALLINT NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','TevkifatKodu') IS NULL ALTER TABLE TeklifSatirlar ADD TevkifatKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','TevkifatCarpan') IS NULL ALTER TABLE TeklifSatirlar ADD TevkifatCarpan FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','TevkifatBolen') IS NULL ALTER TABLE TeklifSatirlar ADD TevkifatBolen FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','TevkifatMuafiyeti') IS NULL ALTER TABLE TeklifSatirlar ADD TevkifatMuafiyeti FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('TeklifSatirlar','IrsaliyeId') IS NULL ALTER TABLE TeklifSatirlar ADD IrsaliyeId INT NULL");

        // ==========================================
        // CARI TABLOLARI
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('CariKart','EFatura') IS NULL ALTER TABLE CariKart ADD EFatura BIT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','SahisSirketi') IS NULL ALTER TABLE CariKart ADD SahisSirketi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','YurtDisi') IS NULL ALTER TABLE CariKart ADD YurtDisi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','CariGrubu') IS NULL ALTER TABLE CariKart ADD CariGrubu NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Ad') IS NULL ALTER TABLE CariKart ADD Ad NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Soyad') IS NULL ALTER TABLE CariKart ADD Soyad NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','TckNo') IS NULL ALTER TABLE CariKart ADD TckNo NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Yetkili2') IS NULL ALTER TABLE CariKart ADD Yetkili2 NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','VdSehirId') IS NULL ALTER TABLE CariKart ADD VdSehirId INT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','VdSehir') IS NULL ALTER TABLE CariKart ADD VdSehir NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','VdKodu') IS NULL ALTER TABLE CariKart ADD VdKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','GsmNo') IS NULL ALTER TABLE CariKart ADD GsmNo NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Telefon2') IS NULL ALTER TABLE CariKart ADD Telefon2 NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Faks') IS NULL ALTER TABLE CariKart ADD Faks NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Adres2') IS NULL ALTER TABLE CariKart ADD Adres2 NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','PostaKodu') IS NULL ALTER TABLE CariKart ADD PostaKodu NVARCHAR(20) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','UlkeId') IS NULL ALTER TABLE CariKart ADD UlkeId INT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Ulke') IS NULL ALTER TABLE CariKart ADD Ulke NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','IlceId') IS NULL ALTER TABLE CariKart ADD IlceId INT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Ilce') IS NULL ALTER TABLE CariKart ADD Ilce NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','SehirId') IS NULL ALTER TABLE CariKart ADD SehirId INT NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Sehir') IS NULL ALTER TABLE CariKart ADD Sehir NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','OzelKod1') IS NULL ALTER TABLE CariKart ADD OzelKod1 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','OzelKod2') IS NULL ALTER TABLE CariKart ADD OzelKod2 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','OzelKod3') IS NULL ALTER TABLE CariKart ADD OzelKod3 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','OzelKod4') IS NULL ALTER TABLE CariKart ADD OzelKod4 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','OzelKod5') IS NULL ALTER TABLE CariKart ADD OzelKod5 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','EFaturaUrnMail') IS NULL ALTER TABLE CariKart ADD EFaturaUrnMail NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','EIrsaliyeUrnMail') IS NULL ALTER TABLE CariKart ADD EIrsaliyeUrnMail NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariKart','Aktif') IS NULL ALTER TABLE CariKart ADD Aktif BIT NULL");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariGruplar') CREATE TABLE CariGruplar (Id INT IDENTITY(1,1) PRIMARY KEY, CariGrubu NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariCalisanlar') CREATE TABLE CariCalisanlar (Id INT IDENTITY(1,1) PRIMARY KEY, CariId INT, AdSoyad NVARCHAR(200), Birim NVARCHAR(200), Telefon NVARCHAR(50), EPosta NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariSevkAdresleri') CREATE TABLE CariSevkAdresleri (Id INT IDENTITY(1,1) PRIMARY KEY, SevkBaslik NVARCHAR(200), Telefon NVARCHAR(50), CariId INT, Adres NVARCHAR(500), PostaKodu NVARCHAR(20), UlkeId INT, SehirId INT, IlceId INT)");
        alterSqls.Add("IF COL_LENGTH('CariSevkAdresleri','SevkBaslik') IS NULL ALTER TABLE CariSevkAdresleri ADD SevkBaslik NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariSevkAdresleri','Telefon') IS NULL ALTER TABLE CariSevkAdresleri ADD Telefon NVARCHAR(50) NULL");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariGorusmeler') CREATE TABLE CariGorusmeler (Id INT IDENTITY(1,1) PRIMARY KEY, CariId INT, GorusmeTarihi DATETIME2, GorusulenKisi NVARCHAR(200), Aciklama NVARCHAR(1000))");

        // ==========================================
        // CARI HAREKETLER TABLOSU
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('CariHareketler','TarihSaat') IS NULL ALTER TABLE CariHareketler ADD TarihSaat DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','IptalEden') IS NULL ALTER TABLE CariHareketler ADD IptalEden NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','Kaynak') IS NULL ALTER TABLE CariHareketler ADD Kaynak NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','VirmanCekId') IS NULL ALTER TABLE CariHareketler ADD VirmanCekId INT NULL");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','DovizId') IS NULL ALTER TABLE CariHareketler ADD DovizId NVARCHAR(10) NULL");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','Doviz') IS NULL ALTER TABLE CariHareketler ADD Doviz NVARCHAR(50) NULL");

        // ==========================================
        // CEK SENET HAREKETLERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CekSenetHareketleri') CREATE TABLE CekSenetHareketleri (Id INT IDENTITY(1,1) PRIMARY KEY, IslemId INT DEFAULT 0, Tarih DATETIME2, VadeTarihi DATETIME2, Tip NVARCHAR(50), Cs NVARCHAR(50), FisId INT, FisNo NVARCHAR(100), CariId INT, Banka NVARCHAR(200), Ciro NVARCHAR(200), SeriNo NVARCHAR(100), Aciklama1 NVARCHAR(500), Aciklama2 NVARCHAR(500), Tutar FLOAT DEFAULT 0, DovizId NVARCHAR(10), Durumu NVARCHAR(50), Iptal INT DEFAULT 0)");

        // ==========================================
        // BANKA HAREKETLERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaHareketleri') CREATE TABLE BankaHareketleri (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, IslemTipi INT, FisId INT, FisNo NVARCHAR(100), IslemId INT DEFAULT 0, CariId INT, BankaId INT DEFAULT 0, Aciklama1 NVARCHAR(500), Aciklama2 NVARCHAR(500), Tutar FLOAT DEFAULT 0, DovizId NVARCHAR(10), Iptal INT DEFAULT 0)");

        // ==========================================
        // BANKA KREDI BILGILERI TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaKrediBilgileri') CREATE TABLE BankaKrediBilgileri (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, KrediTuru NVARCHAR(100), BankaId INT, BankaAdi NVARCHAR(200), KrediTutari FLOAT, KrediVadesi INT, KrediFaizTutari FLOAT, GeriOdenecekTutar FLOAT, IlkOdemeTarihi DATETIME2, AylikOdemeTutari FLOAT, Kapandi BIT, Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BankaKrediBilgileriDetay') CREATE TABLE BankaKrediBilgileriDetay (Id INT IDENTITY(1,1) PRIMARY KEY, Sira NVARCHAR(10), Tarih DATETIME2, IslemId INT, BankaAdi NVARCHAR(200), Yil INT, Ay NVARCHAR(20), AyAdi NVARCHAR(50), Tutar FLOAT, Odendi BIT, Okundu INT)");

        // ==========================================
        // ODEME PLANI TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OdemePlani') CREATE TABLE OdemePlani (Id INT IDENTITY(1,1) PRIMARY KEY, IslemTipi NVARCHAR(50), FisNo NVARCHAR(100), BelgeNo NVARCHAR(100), CariId INT, CariUnvan NVARCHAR(300), OdemeTipi NVARCHAR(50), ToplamTutar FLOAT, OnOdemeTutari FLOAT, KalanTutar FLOAT, OnOdemeTarihi DATETIME2, TaksitSayisi INT, Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OdemePlaniDetay') CREATE TABLE OdemePlaniDetay (Id INT IDENTITY(1,1) PRIMARY KEY, IslemId INT, Tarih DATETIME2, TaksitTutari FLOAT, Durumu NVARCHAR(50))");

        // ==========================================
        // KASA HAREKETLERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KasaHareketleri') CREATE TABLE KasaHareketleri (Id INT IDENTITY(1,1) PRIMARY KEY, FisId INT, Tarih DATETIME2, FisNo NVARCHAR(100), KasaId INT DEFAULT 0, IslemId INT DEFAULT 0, Aciklama1 NVARCHAR(500), Aciklama2 NVARCHAR(500), Tutar FLOAT DEFAULT 0, DovizId NVARCHAR(10), Iptal INT DEFAULT 0)");

        // ==========================================
        // FATURA TAHSILAT ODEME TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaTahsilatOdeme') CREATE TABLE FaturaTahsilatOdeme (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, FisId INT, FaturaId INT, IslemId INT, FaturaTutari FLOAT DEFAULT 0, IslemTutari FLOAT DEFAULT 0, Personel NVARCHAR(200), Iptal INT)");
        alterSqls.Add("IF COL_LENGTH('FaturaTahsilatOdeme','Personel') IS NULL ALTER TABLE FaturaTahsilatOdeme ADD Personel NVARCHAR(200) NULL");

        // ==========================================
        // STOK TABLOLARI
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('StokKart','Barkod') IS NULL ALTER TABLE StokKart ADD Barkod NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','Aciklama') IS NULL ALTER TABLE StokKart ADD Aciklama NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','DovizKodu') IS NULL ALTER TABLE StokKart ADD DovizKodu NVARCHAR(10) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','KdvHaricSatisFiyati') IS NULL ALTER TABLE StokKart ADD KdvHaricSatisFiyati DECIMAL(18,4) DEFAULT 0");
        alterSqls.Add("IF COL_LENGTH('StokKart','UrunGrubu') IS NULL ALTER TABLE StokKart ADD UrunGrubu NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','OzelKod1') IS NULL ALTER TABLE StokKart ADD OzelKod1 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','OzelKod2') IS NULL ALTER TABLE StokKart ADD OzelKod2 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','OzelKod3') IS NULL ALTER TABLE StokKart ADD OzelKod3 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','OzelKod4') IS NULL ALTER TABLE StokKart ADD OzelKod4 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','OzelKod5') IS NULL ALTER TABLE StokKart ADD OzelKod5 NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','TevkifatId') IS NULL ALTER TABLE StokKart ADD TevkifatId SMALLINT NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','TevkifatKodu') IS NULL ALTER TABLE StokKart ADD TevkifatKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','TevkifatCarpan') IS NULL ALTER TABLE StokKart ADD TevkifatCarpan DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','TevkifatBolen') IS NULL ALTER TABLE StokKart ADD TevkifatBolen DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','MinimumSeviye') IS NULL ALTER TABLE StokKart ADD MinimumSeviye DECIMAL(18,4) NULL");
        alterSqls.Add("IF COL_LENGTH('StokKart','KullanimDisi') IS NULL ALTER TABLE StokKart ADD KullanimDisi BIT DEFAULT 0");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UrunGruplari') CREATE TABLE UrunGruplari (Id INT IDENTITY(1,1) PRIMARY KEY, UrunGrubu NVARCHAR(200))");

        // ==========================================
        // BIRIMLER TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Birimler') CREATE TABLE Birimler (Id INT IDENTITY(1,1) PRIMARY KEY, BirimKodu NVARCHAR(50), BirimAdi NVARCHAR(200))");

        // ==========================================
        // ISYERLERI, AMBARLAR, DOVIZ TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Isyerleri') CREATE TABLE Isyerleri (Id INT IDENTITY(1,1) PRIMARY KEY, IsyeriNo NVARCHAR(50), IsyeriAdi NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Ambarlar') CREATE TABLE Ambarlar (Id INT IDENTITY(1,1) PRIMARY KEY, AmbarNo NVARCHAR(50), AmbarAdi NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DovizTurleri') CREATE TABLE DovizTurleri (Id INT IDENTITY(1,1) PRIMARY KEY, DovizKodu NVARCHAR(10), DovizTuru NVARCHAR(100))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DovizKurlari') CREATE TABLE DovizKurlari (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, DovizKodu NVARCHAR(10), DovizTuru NVARCHAR(100), DovizKuru FLOAT DEFAULT 0)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Numarator') CREATE TABLE Numarator (Id INT IDENTITY(1,1) PRIMARY KEY, Tip NVARCHAR(50), OnEk NVARCHAR(50), Numara INT DEFAULT 0)");

        // ==========================================
        // OZEL KODLAR, GIDER TIPLERI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OzelKodlar') CREATE TABLE OzelKodlar (Id INT IDENTITY(1,1) PRIMARY KEY, Kod INT DEFAULT 0, OzelKod NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GiderTipleri') CREATE TABLE GiderTipleri (Id INT IDENTITY(1,1) PRIMARY KEY, GiderTipi NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaParametreleri') CREATE TABLE FaturaParametreleri (Id INT IDENTITY(1,1) PRIMARY KEY, Aciklama BIT DEFAULT 0, Birim BIT DEFAULT 0, Indirim BIT DEFAULT 0, Kdv BIT DEFAULT 0)");

        // ==========================================
        // EMAIL AYARLARI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EMailAyarlari') CREATE TABLE EMailAyarlari (Id INT IDENTITY(1,1) PRIMARY KEY, EMailServer NVARCHAR(200), EMailUserName NVARCHAR(200), EMailPassword NVARCHAR(200), EMailPort INT, SSL BIT)");

        // ==========================================
        // SIRKET YETKILI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketYetkili') CREATE TABLE SirketYetkili (Id INT IDENTITY(1,1) PRIMARY KEY, SirketId INT DEFAULT 0, AdiSoyadi NVARCHAR(200), Gsm NVARCHAR(50), EMail NVARCHAR(200))");

        // ==========================================
        // SIRKET ORTAKLARI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketOrtaklari') CREATE TABLE SirketOrtaklari (Id INT IDENTITY(1,1) PRIMARY KEY, AdSoyad NVARCHAR(200), Gorevi NVARCHAR(200), Telefon NVARCHAR(50), DahiliTel NVARCHAR(50), EPosta NVARCHAR(200), Adres NVARCHAR(500), Sehir NVARCHAR(100), Ilce NVARCHAR(100), DogumTarihi DATETIME2, OrtaklikPayi FLOAT DEFAULT 0)");

        // ==========================================
        // PERSONELLER, PERSONEL YETKILERI TABLOLARI
        // ==========================================
        alterSqls.Add("IF COL_LENGTH('Personeller','Resim') IS NULL ALTER TABLE Personeller ADD Resim VARBINARY(MAX) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','ErpKullanicisi') IS NULL ALTER TABLE Personeller ADD ErpKullanicisi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SGKNo') IS NULL ALTER TABLE Personeller ADD SGKNo NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','PersonelOzluk') IS NULL ALTER TABLE Personeller ADD PersonelOzluk NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','DogumTarihi') IS NULL ALTER TABLE Personeller ADD DogumTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','OrtaklikPayi') IS NULL ALTER TABLE Personeller ADD OrtaklikPayi FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','MaasTuru') IS NULL ALTER TABLE Personeller ADD MaasTuru NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','MedeniDurumu') IS NULL ALTER TABLE Personeller ADD MedeniDurumu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','EsiCalisiyormu') IS NULL ALTER TABLE Personeller ADD EsiCalisiyormu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','CocukSayisi') IS NULL ALTER TABLE Personeller ADD CocukSayisi SMALLINT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','NetMaas') IS NULL ALTER TABLE Personeller ADD NetMaas FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','BrutMaas') IS NULL ALTER TABLE Personeller ADD BrutMaas FLOAT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','GorevVeSorumluluklar') IS NULL ALTER TABLE Personeller ADD GorevVeSorumluluklar NVARCHAR(1000) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','KasaKodu') IS NULL ALTER TABLE Personeller ADD KasaKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IstenAyrildi') IS NULL ALTER TABLE Personeller ADD IstenAyrildi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IseGirisTarihi') IS NULL ALTER TABLE Personeller ADD IseGirisTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IsiBirakmaTarihi') IS NULL ALTER TABLE Personeller ADD IsiBirakmaTarihi DATETIME2 NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IsiBirakmaSebebi') IS NULL ALTER TABLE Personeller ADD IsiBirakmaSebebi NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','Iptal') IS NULL ALTER TABLE Personeller ADD Iptal SMALLINT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SatisTeklifi') IS NULL ALTER TABLE Personeller ADD SatisTeklifi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','Planlama') IS NULL ALTER TABLE Personeller ADD Planlama BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SatinalmaTalep') IS NULL ALTER TABLE Personeller ADD SatinalmaTalep BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SatinalmaEmri') IS NULL ALTER TABLE Personeller ADD SatinalmaEmri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','ProjeGorme') IS NULL ALTER TABLE Personeller ADD ProjeGorme BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','MuhasebeIslemleri') IS NULL ALTER TABLE Personeller ADD MuhasebeIslemleri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','CariIslemler') IS NULL ALTER TABLE Personeller ADD CariIslemler BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SatisIslemleri') IS NULL ALTER TABLE Personeller ADD SatisIslemleri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SatinalmaIslemleri') IS NULL ALTER TABLE Personeller ADD SatinalmaIslemleri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','NetworkGorme') IS NULL ALTER TABLE Personeller ADD NetworkGorme BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','NetworkKullanimi') IS NULL ALTER TABLE Personeller ADD NetworkKullanimi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IlanVerme') IS NULL ALTER TABLE Personeller ADD IlanVerme BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','IzinTalepleriOnay') IS NULL ALTER TABLE Personeller ADD IzinTalepleriOnay BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','KullaniciTanimlama') IS NULL ALTER TABLE Personeller ADD KullaniciTanimlama BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','PersonelIslemleri') IS NULL ALTER TABLE Personeller ADD PersonelIslemleri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','EFaturaIslemleri') IS NULL ALTER TABLE Personeller ADD EFaturaIslemleri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','EFaturaGonder') IS NULL ALTER TABLE Personeller ADD EFaturaGonder BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','EFaturaOnay') IS NULL ALTER TABLE Personeller ADD EFaturaOnay BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','SirketProfili') IS NULL ALTER TABLE Personeller ADD SirketProfili BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','FirmaBilgileri') IS NULL ALTER TABLE Personeller ADD FirmaBilgileri BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','EnvarterYonetimi') IS NULL ALTER TABLE Personeller ADD EnvarterYonetimi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','PersonelYonetimi') IS NULL ALTER TABLE Personeller ADD PersonelYonetimi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('Personeller','FirmaAnalizi') IS NULL ALTER TABLE Personeller ADD FirmaAnalizi BIT NULL");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PersonelYetkileri') CREATE TABLE PersonelYetkileri (Id INT IDENTITY(1,1) PRIMARY KEY, PersonelID BIT DEFAULT 0, Teklif BIT DEFAULT 0, Planlama BIT DEFAULT 0, [SatınAlmaTalep] BIT DEFAULT 0, [SatınAlmaEmri] BIT DEFAULT 0, ProjeGorme BIT DEFAULT 0, Muhasebe BIT DEFAULT 0, NetworkGorme BIT DEFAULT 0, NetworkKullanim BIT DEFAULT 0, IlanVerme BIT DEFAULT 0)");

        // ==========================================
        // IZIN FORMLARI, SAGLIK RAPORLARI, DISIPLIN TUTANAKLARI, GENEL TUTANAKLAR, GORUS VE ONERILER
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'IzinFormlari') CREATE TABLE IzinFormlari (Id INT IDENTITY(1,1) PRIMARY KEY, PersonelId INT, AdiSoyadi NVARCHAR(200), Gorevi NVARCHAR(200), IzinTuru NVARCHAR(100), IzinTalepTarihi DATETIME2, BaslangicTarihi DATETIME2, IzinGunu INT, BitisTarihi DATETIME2, IseBaslamaTarihi DATETIME2, PersonelAciklama NVARCHAR(500), YoneticiAciklama NVARCHAR(500), OnayDurumu NVARCHAR(50), OnayAciklama NVARCHAR(500), Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SaglikRaporlari') CREATE TABLE SaglikRaporlari (Id INT IDENTITY(1,1) PRIMARY KEY, IslemTarihi DATETIME2, PersonelId INT, AdiSoyadi NVARCHAR(200), Gorevi NVARCHAR(200), HastalikTanisi NVARCHAR(500), BaslangicTarihi DATETIME2, RaporGunu INT, BitisTarihi DATETIME2, IseBaslamaTarihi DATETIME2, YoneticiAciklama NVARCHAR(500), Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DisiplinTutanaklari') CREATE TABLE DisiplinTutanaklari (Id INT IDENTITY(1,1) PRIMARY KEY, PersonelId INT, PersonelAdi NVARCHAR(200), PersonelGorevi NVARCHAR(200), TCKimlikNo NVARCHAR(50), SGKSicilNo NVARCHAR(50), Tarih DATETIME2, Konu NVARCHAR(500), Duzenleyen NVARCHAR(200), DuzenleyenGorevi NVARCHAR(200), Tanik NVARCHAR(200), DosyaEki NVARCHAR(500), Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GenelTutanaklar') CREATE TABLE GenelTutanaklar (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, Konu NVARCHAR(500), Duzenleyen NVARCHAR(200), DuzenleyenGorevi NVARCHAR(200), DosyaEki NVARCHAR(500), Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GorusVeOneriler') CREATE TABLE GorusVeOneriler (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, Konu NVARCHAR(500), Duzenleyen NVARCHAR(200), DuzenleyenGorevi NVARCHAR(200), DosyaEki NVARCHAR(500), Iptal INT)");

        // ==========================================
        // ZIMMET TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ZimmetBaslik') CREATE TABLE ZimmetBaslik (Id INT IDENTITY(1,1) PRIMARY KEY, DokumanNo NVARCHAR(100), Tarih DATETIME2, DuzenlemeTarihi DATETIME2, PersonelKodu INT, PersonelAdi NVARCHAR(200), PersonelTckNo NVARCHAR(50), PersonelGorevi NVARCHAR(200), TeslimEden NVARCHAR(200), TeslimEdenGorevi NVARCHAR(200), Aciklama NVARCHAR(500), Iptal INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ZimmetSatir') CREATE TABLE ZimmetSatir (Id INT IDENTITY(1,1) PRIMARY KEY, ZimmetId INT, DonanimAdi NVARCHAR(200), MarkaModel NVARCHAR(200), SeriNo NVARCHAR(200), Miktar INT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ZimmetListesi') CREATE TABLE ZimmetListesi (Id INT IDENTITY(1,1) PRIMARY KEY, DonanimTuru NVARCHAR(200))");

        // ==========================================
        // PUANTAJ TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Puantaj') CREATE TABLE Puantaj (Id INT IDENTITY(1,1) PRIMARY KEY, PersId INT, Personel NVARCHAR(200), Yil INT, Ay INT, AyAdi NVARCHAR(50), AyGun INT, _1_ NVARCHAR(10), _2_ NVARCHAR(10), _3_ NVARCHAR(10), _4_ NVARCHAR(10), _5_ NVARCHAR(10), _6_ NVARCHAR(10), _7_ NVARCHAR(10), _8_ NVARCHAR(10), _9_ NVARCHAR(10), _10_ NVARCHAR(10), _11_ NVARCHAR(10), _12_ NVARCHAR(10), _13_ NVARCHAR(10), _14_ NVARCHAR(10), _15_ NVARCHAR(10), _16_ NVARCHAR(10), _17_ NVARCHAR(10), _18_ NVARCHAR(10), _19_ NVARCHAR(10), _20_ NVARCHAR(10), _21_ NVARCHAR(10), _22_ NVARCHAR(10), _23_ NVARCHAR(10), _24_ NVARCHAR(10), _25_ NVARCHAR(10), _26_ NVARCHAR(10), _27_ NVARCHAR(10), _28_ NVARCHAR(10), _29_ NVARCHAR(10), _30_ NVARCHAR(10), _31_ NVARCHAR(10))");

        // ==========================================
        // MASRAF KALEMLERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MasrafKalemleri') CREATE TABLE MasrafKalemleri (Id INT IDENTITY(1,1) PRIMARY KEY, TrCode INT DEFAULT 0, FaturaTipi INT DEFAULT 0, OzelKod3 NVARCHAR(100), Tutar FLOAT DEFAULT 0)");

        // ==========================================
        // TASIYICI BILGILERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TasiyiciBilgileri') CREATE TABLE TasiyiciBilgileri (Id INT IDENTITY(1,1) PRIMARY KEY, Kod NVARCHAR(50), Unvan NVARCHAR(300), Vd NVARCHAR(200), Vn NVARCHAR(50), Iptal INT)");

        // ==========================================
        // HATIRLATMALAR TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hatirlatmalar') CREATE TABLE Hatirlatmalar (Id INT IDENTITY(1,1) PRIMARY KEY, PersId INT, Personel NVARCHAR(200), Tarih DATETIME2, HatirlatmaTarihi DATETIME2, Aciklama NVARCHAR(500), SmsBilgi BIT, Okundu BIT, Iptal INT)");

        // ==========================================
        // FATURA BANKA BILGILERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FaturaBankaBilgileri') CREATE TABLE FaturaBankaBilgileri (Id INT IDENTITY(1,1) PRIMARY KEY, Sec BIT DEFAULT 0, FaturaId INT DEFAULT 0, Banka NVARCHAR(200), ParaBirimi NVARCHAR(10), Sube NVARCHAR(200), Iban NVARCHAR(50), SwiftKodu NVARCHAR(50))");

        // ==========================================
        // GIDEN E-FATURALAR TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GidenEFaturalar') CREATE TABLE GidenEFaturalar (Id INT IDENTITY(1,1) PRIMARY KEY, headerMessage NVARCHAR(500), headerResponseCode NVARCHAR(50), headerStatus NVARCHAR(50), invoiceId INT, invoiceType INT, invoiceDescription NVARCHAR(500), createdAt DATETIME2, invoiceDate DATETIME2, itemReferenceNumber INT, itemInvoiceNumber NVARCHAR(100), itemResponseCode NVARCHAR(50), [İtemResponseDescription] NVARCHAR(500), itemResponseStatus NVARCHAR(50), OnayDurumu NVARCHAR(50), InvoiceStatus NVARCHAR(100), InvoiceStatusDescription NVARCHAR(500), EnvelopeStatus NVARCHAR(100), EnvelopeStatusDescription NVARCHAR(500), itemTrackNumber NVARCHAR(100), itemUUID NVARCHAR(200), itemViewUrl NVARCHAR(500))");
        alterSqls.Add("IF COL_LENGTH('GidenEFaturalar','InvoiceStatus') IS NULL ALTER TABLE GidenEFaturalar ADD InvoiceStatus NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('GidenEFaturalar','InvoiceStatusDescription') IS NULL ALTER TABLE GidenEFaturalar ADD InvoiceStatusDescription NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('GidenEFaturalar','EnvelopeStatus') IS NULL ALTER TABLE GidenEFaturalar ADD EnvelopeStatus NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('GidenEFaturalar','EnvelopeStatusDescription') IS NULL ALTER TABLE GidenEFaturalar ADD EnvelopeStatusDescription NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('GidenEFaturalar','OnayDurumu') IS NULL ALTER TABLE GidenEFaturalar ADD OnayDurumu NVARCHAR(50) NULL");

        // ==========================================
        // GELEN FATURALAR TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GelenFaturalar') CREATE TABLE GelenFaturalar (Id INT IDENTITY(1,1) PRIMARY KEY, RequestNumber INT, ReferenceNo INT, Tarih DATETIME2, ProfileID INT, FaturaTipi INT, FaturaNo NVARCHAR(100), Tedarikci NVARCHAR(300), VergiDairesi NVARCHAR(200), VergiNo NVARCHAR(50), PostaKutusu NVARCHAR(200), Adres NVARCHAR(500), Ilce NVARCHAR(100), Sehir NVARCHAR(100), Ulke NVARCHAR(100), Doviz NVARCHAR(10), FiyatlandirilanDovizKodu NVARCHAR(10), OdemeYapilacakDovizKodu NVARCHAR(10), KdvMatrahi FLOAT, ToplamIskonto FLOAT, KdvTutari FLOAT, ToplamTutar FLOAT, ETTN NVARCHAR(200), ReceiverAlias NVARCHAR(200), SenderAlias NVARCHAR(200), ResponseCode NVARCHAR(50), Durumu NVARCHAR(50), FatUrl NVARCHAR(500), TevkifatKodu NVARCHAR(50), TevkifatAciklama NVARCHAR(500), TevkifatYuzdesi DECIMAL(18,4) DEFAULT 0)");
        alterSqls.Add("IF COL_LENGTH('GelenFaturalar','TevkifatKodu') IS NULL ALTER TABLE GelenFaturalar ADD TevkifatKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('GelenFaturalar','TevkifatAciklama') IS NULL ALTER TABLE GelenFaturalar ADD TevkifatAciklama NVARCHAR(500) NULL");
        alterSqls.Add("IF COL_LENGTH('GelenFaturalar','TevkifatYuzdesi') IS NULL ALTER TABLE GelenFaturalar ADD TevkifatYuzdesi DECIMAL(18,4) DEFAULT 0");

        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GelenFaturalarSatirlar') CREATE TABLE GelenFaturalarSatirlar (Id INT IDENTITY(1,1) PRIMARY KEY, FatId INT DEFAULT 0, MalzemeKodu NVARCHAR(100), MalzemeAdi NVARCHAR(300), Miktar DECIMAL(18,4) DEFAULT 0, BirimKodu NVARCHAR(50), Fiyat DECIMAL(18,4) DEFAULT 0, Tutar DECIMAL(18,4) DEFAULT 0, Indirim1 DECIMAL(18,4) DEFAULT 0, Indirim2 DECIMAL(18,4) DEFAULT 0, Indirim3 DECIMAL(18,4) DEFAULT 0, Artirim DECIMAL(18,4) DEFAULT 0, IndirimTutari DECIMAL(18,4) DEFAULT 0, KdvMatrahi DECIMAL(18,4) DEFAULT 0, KdvOrani NVARCHAR(20), KdvTutari DECIMAL(18,4) DEFAULT 0, MalHizmetTutari DECIMAL(18,4) DEFAULT 0, ParaBirimi NVARCHAR(10), VergiMuafiyetKodu NVARCHAR(50), VergiMuafiyetNedeni NVARCHAR(500), TevkifatKodu NVARCHAR(50), TevkifatAciklama NVARCHAR(500), TevkifatYuzdesi DECIMAL(18,4) DEFAULT 0)");

        // ==========================================
        // PROJELER, SATINALMA TALEPLERI TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Projeler') CREATE TABLE Projeler (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, FirmaKodu NVARCHAR(50), FirmaUnvani NVARCHAR(300), ProjeKodu NVARCHAR(100), ProjeAdi NVARCHAR(300), ProjeBaslangicTarihi DATETIME2, ProjeBitisTarihi DATETIME2, ProjeyiOlusturan NVARCHAR(200), Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SatinAlmaTalepleri') CREATE TABLE SatinAlmaTalepleri (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, ProformaId INT, FisNo NVARCHAR(100), BelgeNo NVARCHAR(100), ProjeId INT, ProjeKodu NVARCHAR(100), ProjeAdi NVARCHAR(300), Aciklama NVARCHAR(500), TalepEden NVARCHAR(200))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SatinAlmaTalepleriSatirlar') CREATE TABLE SatinAlmaTalepleriSatirlar (Id INT IDENTITY(1,1) PRIMARY KEY, TalepId INT, StokId INT, MalzemeKodu NVARCHAR(100), MalzemeAdi NVARCHAR(300), Birim NVARCHAR(50), Miktar FLOAT, TalepEdilenMiktar FLOAT DEFAULT 0, Durumu NVARCHAR(50), TeklifId INT)");

        // ==========================================
        // VARSAYILAN DEGERLER TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'VarsayilanDegerler') CREATE TABLE VarsayilanDegerler (Id INT IDENTITY(1,1) PRIMARY KEY, Ulke INT DEFAULT 0, Sehir INT DEFAULT 0, ParaBirimi NVARCHAR(10), CariTakibi BIT DEFAULT 0, StokTakibi BIT DEFAULT 0)");
        alterSqls.Add("IF COL_LENGTH('VarsayilanDegerler','CariTakibi') IS NULL ALTER TABLE VarsayilanDegerler ADD CariTakibi BIT DEFAULT 0");
        alterSqls.Add("IF COL_LENGTH('VarsayilanDegerler','StokTakibi') IS NULL ALTER TABLE VarsayilanDegerler ADD StokTakibi BIT DEFAULT 0");

        // ==========================================
        // RANDEVU (Test) TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Randevu') CREATE TABLE Randevu (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, BaslangicTarihi DATETIME2, BitisTarihi DATETIME2, Tc NVARCHAR(50), Ad NVARCHAR(200), Tel NVARCHAR(50), Doktor NVARCHAR(200))");

        // ==========================================
        // PLASIYERLER TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Plasiyerler') CREATE TABLE Plasiyerler (Id INT IDENTITY(1,1) PRIMARY KEY, Kodu NVARCHAR(50), Adi NVARCHAR(200), Telefon NVARCHAR(50), Email NVARCHAR(200), Bolge NVARCHAR(200), Aciklama NVARCHAR(500), Aktif BIT DEFAULT 1, OlusturmaTarihi DATETIME2 DEFAULT GETDATE(), OlusturanKullanici NVARCHAR(100), GuncellemeTarihi DATETIME2, GuncelleyenKullanici NVARCHAR(100))");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','OlusturanKullanici') IS NULL ALTER TABLE Plasiyerler ADD OlusturanKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','GuncellemeTarihi') IS NULL ALTER TABLE Plasiyerler ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','GuncelleyenKullanici') IS NULL ALTER TABLE Plasiyerler ADD GuncelleyenKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','OlusturmaTarihi') IS NULL ALTER TABLE Plasiyerler ADD OlusturmaTarihi DATETIME2 DEFAULT GETDATE()");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','Telefon') IS NULL ALTER TABLE Plasiyerler ADD Telefon NVARCHAR(50)");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','Email') IS NULL ALTER TABLE Plasiyerler ADD Email NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','Bolge') IS NULL ALTER TABLE Plasiyerler ADD Bolge NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('Plasiyerler','Aciklama') IS NULL ALTER TABLE Plasiyerler ADD Aciklama NVARCHAR(500)");

        // ==========================================
        // PROJELER2 TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Projeler2') CREATE TABLE Projeler2 (Id INT IDENTITY(1,1) PRIMARY KEY, Kodu NVARCHAR(50), Adi NVARCHAR(200), Musteri NVARCHAR(200), Sorumlu NVARCHAR(200), BaslangicTarihi DATETIME2, BitisTarihi DATETIME2, Durumu NVARCHAR(50) DEFAULT 'Aktif', Butce FLOAT, Aciklama NVARCHAR(500), Aktif BIT DEFAULT 1, OlusturmaTarihi DATETIME2 DEFAULT GETDATE(), OlusturanKullanici NVARCHAR(100), GuncellemeTarihi DATETIME2, GuncelleyenKullanici NVARCHAR(100))");
        alterSqls.Add("IF COL_LENGTH('Projeler2','OlusturanKullanici') IS NULL ALTER TABLE Projeler2 ADD OlusturanKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Projeler2','GuncellemeTarihi') IS NULL ALTER TABLE Projeler2 ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('Projeler2','GuncelleyenKullanici') IS NULL ALTER TABLE Projeler2 ADD GuncelleyenKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('Projeler2','OlusturmaTarihi') IS NULL ALTER TABLE Projeler2 ADD OlusturmaTarihi DATETIME2 DEFAULT GETDATE()");

        // ==========================================
        // SORUMLULUK MERKEZLERI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SorumlulukMerkezleri') CREATE TABLE SorumlulukMerkezleri (Id INT IDENTITY(1,1) PRIMARY KEY, Kodu NVARCHAR(50), Adi NVARCHAR(200), UstMerkez NVARCHAR(200), Sorumlu NVARCHAR(200), Aciklama NVARCHAR(500), Aktif BIT DEFAULT 1, OlusturmaTarihi DATETIME2 DEFAULT GETDATE(), OlusturanKullanici NVARCHAR(100), GuncellemeTarihi DATETIME2, GuncelleyenKullanici NVARCHAR(100))");
        alterSqls.Add("IF COL_LENGTH('SorumlulukMerkezleri','OlusturanKullanici') IS NULL ALTER TABLE SorumlulukMerkezleri ADD OlusturanKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('SorumlulukMerkezleri','GuncellemeTarihi') IS NULL ALTER TABLE SorumlulukMerkezleri ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('SorumlulukMerkezleri','GuncelleyenKullanici') IS NULL ALTER TABLE SorumlulukMerkezleri ADD GuncelleyenKullanici NVARCHAR(100)");
        alterSqls.Add("IF COL_LENGTH('SorumlulukMerkezleri','OlusturmaTarihi') IS NULL ALTER TABLE SorumlulukMerkezleri ADD OlusturmaTarihi DATETIME2 DEFAULT GETDATE()");

        // ==========================================
        // GRID KOLON AYARLARI TABLOSU (updated model)
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GridKolonAyarlar') CREATE TABLE GridKolonAyarlar (Id INT IDENTITY(1,1) PRIMARY KEY, SirketKodu NVARCHAR(50), KullaniciId INT DEFAULT 0, FormAdi NVARCHAR(100), KolonId NVARCHAR(100), Gorunur BIT DEFAULT 1)");
        alterSqls.Add("IF COL_LENGTH('GridKolonAyarlar','SirketKodu') IS NULL ALTER TABLE GridKolonAyarlar ADD SirketKodu NVARCHAR(50) NULL");
        alterSqls.Add("IF COL_LENGTH('GridKolonAyarlar','KullaniciId') IS NULL ALTER TABLE GridKolonAyarlar ADD KullaniciId INT DEFAULT 0");
        alterSqls.Add("IF COL_LENGTH('GridKolonAyarlar','FormAdi') IS NULL ALTER TABLE GridKolonAyarlar ADD FormAdi NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('GridKolonAyarlar','KolonId') IS NULL ALTER TABLE GridKolonAyarlar ADD KolonId NVARCHAR(100) NULL");
        alterSqls.Add("IF COL_LENGTH('GridKolonAyarlar','Gorunur') IS NULL ALTER TABLE GridKolonAyarlar ADD Gorunur BIT DEFAULT 1");

        // ==========================================
        // ARAC SIGORTA MUAYENE TAKIBI TABLOSU
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AracSigortaMuayeneTakibi') CREATE TABLE AracSigortaMuayeneTakibi (Id INT IDENTITY(1,1) PRIMARY KEY, EnvanterId INT, Tarih DATETIME2, IslemTuru NVARCHAR(100), PlakaNo NVARCHAR(50), Aciklama NVARCHAR(500), BaslangicTarihi DATETIME2, BitisTarihi DATETIME2, Tutar FLOAT DEFAULT 0, Iptal BIT)");

        // ==========================================
        // ARAC BAKIM TAKIBI TABLOLARI
        // ==========================================
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AracBakimTakibi') CREATE TABLE AracBakimTakibi (Id INT IDENTITY(1,1) PRIMARY KEY, Tarih DATETIME2, EnvanterId INT, FisNo NVARCHAR(100), PlakaNo NVARCHAR(50), Aciklama NVARCHAR(500), Tutar FLOAT DEFAULT 0, Iptal BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AracBakimTakibiListe') CREATE TABLE AracBakimTakibiListe (Id INT IDENTITY(1,1) PRIMARY KEY, FisId INT DEFAULT 0, Aciklama NVARCHAR(500), Adet FLOAT DEFAULT 0, Fiyat FLOAT DEFAULT 0, Tutar FLOAT DEFAULT 0, Iptal BIT)");

        // ==========================================
        // NETWORK CONTEXT TABLOLARI (hepsi ayni PineERP DB)
        // ==========================================

        // ErpKapaliModuller
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ErpKapaliModuller') CREATE TABLE ErpKapaliModuller (Id INT IDENTITY(1,1) PRIMARY KEY, SirketKodu INT, KullaniciLimiti INT, EnvanterYonetimi BIT, PersonelYonetimi BIT, FirmaAnalizi BIT, CariTakibi BIT, StokTakibi BIT)");
        alterSqls.Add("IF COL_LENGTH('ErpKapaliModuller','CariTakibi') IS NULL ALTER TABLE ErpKapaliModuller ADD CariTakibi BIT NULL");
        alterSqls.Add("IF COL_LENGTH('ErpKapaliModuller','StokTakibi') IS NULL ALTER TABLE ErpKapaliModuller ADD StokTakibi BIT NULL");

        // LoginTablo
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LoginTablo') CREATE TABLE LoginTablo (Id INT IDENTITY(1,1) PRIMARY KEY, SirketKodu INT DEFAULT 0, SirketAdi NVARCHAR(300), KullaniciId BIT, ErpKullaniciAdi NVARCHAR(200), KullaniciAdi NVARCHAR(200), Sifre NVARCHAR(200), ServerName NVARCHAR(200), [Database] NVARCHAR(200), UserName NVARCHAR(200), Password NVARCHAR(200), Port INT DEFAULT 0, SatisTeklifi BIT, Planlama BIT, SatinalmaTalep BIT, SatinalmaEmri BIT, ProjeGorme BIT, MuhasebeIslemleri BIT, CariIslemler BIT, SatisIslemleri BIT, SatinalmaIslemleri BIT, NetworkGorme BIT, NetworkKullanimi BIT, IlanVerme BIT, IzinTalepleriOnay BIT, KullaniciTanimlama BIT, PersonelIslemleri BIT, EFaturaIslemleri BIT, EFaturaGonder BIT, EFaturaOnay BIT, SirketProfili BIT, FirmaBilgileri BIT, EnvarterYonetimi BIT, PersonelYonetimi BIT, FirmaAnalizi BIT)");

        // SirketBilgileri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketBilgileri') CREATE TABLE SirketBilgileri (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT, FirmaUnvani NVARCHAR(300), Adres NVARCHAR(500), IlceId INT, Ilce NVARCHAR(100), SehirId INT, Sehir NVARCHAR(100), Ulke NVARCHAR(100), UlkeId INT, VdKodu NVARCHAR(50), Vd NVARCHAR(200), Vn NVARCHAR(50), MersisNo NVARCHAR(50), TicaretSicilNo NVARCHAR(50), Telefon NVARCHAR(50), Gsm NVARCHAR(50), Faks NVARCHAR(50), Web NVARCHAR(200), EPosta NVARCHAR(200), EFaturaMukellefi BIT DEFAULT 0, EIrsaliyeMukellefi BIT DEFAULT 0, EFaturaGelenUrnMail NVARCHAR(200), EFaturaGidenUrnMail NVARCHAR(200), EArsivUrnMail NVARCHAR(200), EIrsaliyeUrnMail NVARCHAR(200), ApiInstitutionId NVARCHAR(200), ApiKullaniciAdi NVARCHAR(200), ApiKullaniciSifresi NVARCHAR(200))");
        alterSqls.Add("IF COL_LENGTH('SirketBilgileri','ApiInstitutionId') IS NULL ALTER TABLE SirketBilgileri ADD ApiInstitutionId NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('SirketBilgileri','ApiKullaniciAdi') IS NULL ALTER TABLE SirketBilgileri ADD ApiKullaniciAdi NVARCHAR(200) NULL");
        alterSqls.Add("IF COL_LENGTH('SirketBilgileri','ApiKullaniciSifresi') IS NULL ALTER TABLE SirketBilgileri ADD ApiKullaniciSifresi NVARCHAR(200) NULL");

        // SirketBelgeleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketBelgeleri') CREATE TABLE SirketBelgeleri (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT, FirmaLogosu VARBINARY(MAX), ImzaSirkusu VARBINARY(MAX), FaaliyetBelgesi VARBINARY(MAX), TicaretSicilGazetesi VARBINARY(MAX), VergiLevhasi VARBINARY(MAX), ImzaKasesi VARBINARY(MAX))");

        // SirketDahiliTel
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketDahiliTel') CREATE TABLE SirketDahiliTel (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT, Birim NVARCHAR(200), TelefonNo NVARCHAR(50))");

        // SirketMail
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketMail') CREATE TABLE SirketMail (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT DEFAULT 0, Birim NVARCHAR(200), EMail NVARCHAR(200), DahiliTel NVARCHAR(50), Paylas BIT)");

        // SirketBankaBilgileri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SirketBankaBilgileri') CREATE TABLE SirketBankaBilgileri (Id INT IDENTITY(1,1) PRIMARY KEY, Sec BIT DEFAULT 0, SirketNo INT DEFAULT 0, Banka NVARCHAR(200), ParaBirimi NVARCHAR(10), Sube NVARCHAR(200), Iban NVARCHAR(50), SwiftKodu NVARCHAR(50))");

        // TumBankalar
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TumBankalar') CREATE TABLE TumBankalar (Id INT IDENTITY(1,1) PRIMARY KEY, Kod NVARCHAR(10), Banka NVARCHAR(200))");

        // ParaBirimleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ParaBirimleri') CREATE TABLE ParaBirimleri (Id INT IDENTITY(1,1) PRIMARY KEY, ParaBirimi NVARCHAR(10), Simge NVARCHAR(10))");

        // Sektorler
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Sektorler') CREATE TABLE Sektorler (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT DEFAULT 0, SektorKodu NVARCHAR(50), SektorAdi NVARCHAR(200), Aktif BIT DEFAULT 1)");

        // Hizmetler
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hizmetler') CREATE TABLE Hizmetler (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT DEFAULT 0, HizmetKodu NVARCHAR(50), HizmetAdi NVARCHAR(200), Aktif BIT DEFAULT 1)");

        // IzinSebepleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'IzinSebepleri') CREATE TABLE IzinSebepleri (Id INT IDENTITY(1,1) PRIMARY KEY, IzinKodu NVARCHAR(50), IzinSebebi NVARCHAR(200), Gun INT DEFAULT 0)");

        // OdemeTipleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OdemeTipleri') CREATE TABLE OdemeTipleri (Id INT IDENTITY(1,1) PRIMARY KEY, OdemeKodu NVARCHAR(50), OdemeTipi NVARCHAR(200))");

        // Gorevler
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Gorevler') CREATE TABLE Gorevler (Id INT IDENTITY(1,1) PRIMARY KEY, Gorev NVARCHAR(200), Yetkili INT DEFAULT 0)");

        // Ulkeler, Sehirler, Ilceler
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Ulkeler') CREATE TABLE Ulkeler (Id INT IDENTITY(1,1) PRIMARY KEY, Simge NVARCHAR(10), Ulke NVARCHAR(200), AlanKodu NVARCHAR(10))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Sehirler') CREATE TABLE Sehirler (Id INT IDENTITY(1,1) PRIMARY KEY, UlkeId INT, SehirAdi NVARCHAR(200), Duzenle NVARCHAR(50))");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Ilceler') CREATE TABLE Ilceler (Id INT IDENTITY(1,1) PRIMARY KEY, IlceAdi NVARCHAR(200), SehirId INT DEFAULT 0, Duzenle NVARCHAR(50))");

        // VergiDaireleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'VergiDaireleri') CREATE TABLE VergiDaireleri (Id INT IDENTITY(1,1) PRIMARY KEY, VdKodu NVARCHAR(50), Sehir NVARCHAR(100), VergiDairesi NVARCHAR(200))");

        // KdvMuafiyetSebepleri
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KdvMuafiyetSebepleri') CREATE TABLE KdvMuafiyetSebepleri (Id INT IDENTITY(1,1) PRIMARY KEY, MuafiyetKodu NVARCHAR(50), MuafiyetSebebi NVARCHAR(500))");

        // KdvOranlari
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KdvOranlari') CREATE TABLE KdvOranlari (Id INT IDENTITY(1,1) PRIMARY KEY, KdvOrani FLOAT)");

        // EFaturaUluslararasiBirimKodlari
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EFaturaUluslararasiBirimKodlari') CREATE TABLE EFaturaUluslararasiBirimKodlari (Id INT IDENTITY(1,1) PRIMARY KEY, BirimKodu NVARCHAR(50), DonusumKodu NVARCHAR(50), DonusumAciklama NVARCHAR(500))");

        // TevkifatKodlari
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TevkifatKodlari') CREATE TABLE TevkifatKodlari (Id INT IDENTITY(1,1) PRIMARY KEY, TevkifatKodu NVARCHAR(50), TevkifatAciklama NVARCHAR(500), TevkifatCarpani FLOAT, TevkifatBoleni FLOAT)");

        // EFaturaHataKodlari
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'EFaturaHataKodları') CREATE TABLE [EFaturaHataKodları] (Id INT IDENTITY(1,1) PRIMARY KEY, HataKodu NVARCHAR(50), Aciklama NVARCHAR(500))");

        // Doviz
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Doviz') CREATE TABLE Doviz (Id INT IDENTITY(1,1) PRIMARY KEY, DovizKodu NVARCHAR(10), DovizCinsi NVARCHAR(100), Aciklama NVARCHAR(200), Simge NVARCHAR(10))");

        // Envanter tablolari
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Envanterler') CREATE TABLE Envanterler (Id INT IDENTITY(1,1) PRIMARY KEY, EnvanterAdi NVARCHAR(200), Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EnvanterTanimlari') CREATE TABLE EnvanterTanimlari (Id INT IDENTITY(1,1) PRIMARY KEY, EnvanterId INT DEFAULT 0, Tanim NVARCHAR(200), Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EnvanterTanimlariIcerik') CREATE TABLE EnvanterTanimlariIcerik (Id INT IDENTITY(1,1) PRIMARY KEY, TanimId INT DEFAULT 0, Aciklama NVARCHAR(200), Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EnvanterTanimlariIcerikOzellikler') CREATE TABLE EnvanterTanimlariIcerikOzellikler (Id INT IDENTITY(1,1) PRIMARY KEY, TanimIcerikId INT, Aciklama NVARCHAR(200), Deger NVARCHAR(200), Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FirmaEnvanterListesi') CREATE TABLE FirmaEnvanterListesi (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT DEFAULT 0, EnvanterId INT DEFAULT 0, TanimId INT DEFAULT 0, AciklamaId INT DEFAULT 0, OzelKod NVARCHAR(100), Degeri DECIMAL(18,4), Network BIT, Aktif BIT)");
        alterSqls.Add("IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FirmaEnvanterIcerik') CREATE TABLE FirmaEnvanterIcerik (Id INT IDENTITY(1,1) PRIMARY KEY, SirketNo INT, EnvanterId INT, Aciklama NVARCHAR(200), Deger NVARCHAR(200), Aktif BIT)");

        // ==========================================
        // HAREKET/ISLEM TABLOLARI - Audit Alanlari
        // ==========================================
        // CariHareketler
        alterSqls.Add("IF COL_LENGTH('CariHareketler','OlusturmaTarihi') IS NULL ALTER TABLE CariHareketler ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','OlusturanKullanici') IS NULL ALTER TABLE CariHareketler ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','GuncellemeTarihi') IS NULL ALTER TABLE CariHareketler ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('CariHareketler','GuncelleyenKullanici') IS NULL ALTER TABLE CariHareketler ADD GuncelleyenKullanici NVARCHAR(200)");
        // KasaHareketleri
        alterSqls.Add("IF COL_LENGTH('KasaHareketleri','OlusturmaTarihi') IS NULL ALTER TABLE KasaHareketleri ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('KasaHareketleri','OlusturanKullanici') IS NULL ALTER TABLE KasaHareketleri ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('KasaHareketleri','GuncellemeTarihi') IS NULL ALTER TABLE KasaHareketleri ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('KasaHareketleri','GuncelleyenKullanici') IS NULL ALTER TABLE KasaHareketleri ADD GuncelleyenKullanici NVARCHAR(200)");
        // BankaHareketleri
        alterSqls.Add("IF COL_LENGTH('BankaHareketleri','OlusturmaTarihi') IS NULL ALTER TABLE BankaHareketleri ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('BankaHareketleri','OlusturanKullanici') IS NULL ALTER TABLE BankaHareketleri ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('BankaHareketleri','GuncellemeTarihi') IS NULL ALTER TABLE BankaHareketleri ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('BankaHareketleri','GuncelleyenKullanici') IS NULL ALTER TABLE BankaHareketleri ADD GuncelleyenKullanici NVARCHAR(200)");
        // CekSenetHareketleri
        alterSqls.Add("IF COL_LENGTH('CekSenetHareketleri','OlusturmaTarihi') IS NULL ALTER TABLE CekSenetHareketleri ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('CekSenetHareketleri','OlusturanKullanici') IS NULL ALTER TABLE CekSenetHareketleri ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('CekSenetHareketleri','GuncellemeTarihi') IS NULL ALTER TABLE CekSenetHareketleri ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('CekSenetHareketleri','GuncelleyenKullanici') IS NULL ALTER TABLE CekSenetHareketleri ADD GuncelleyenKullanici NVARCHAR(200)");
        // FaturaTahsilatOdeme
        alterSqls.Add("IF COL_LENGTH('FaturaTahsilatOdeme','OlusturmaTarihi') IS NULL ALTER TABLE FaturaTahsilatOdeme ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('FaturaTahsilatOdeme','OlusturanKullanici') IS NULL ALTER TABLE FaturaTahsilatOdeme ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('FaturaTahsilatOdeme','GuncellemeTarihi') IS NULL ALTER TABLE FaturaTahsilatOdeme ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('FaturaTahsilatOdeme','GuncelleyenKullanici') IS NULL ALTER TABLE FaturaTahsilatOdeme ADD GuncelleyenKullanici NVARCHAR(200)");
        // BankaKrediBilgileri
        alterSqls.Add("IF COL_LENGTH('BankaKrediBilgileri','OlusturmaTarihi') IS NULL ALTER TABLE BankaKrediBilgileri ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('BankaKrediBilgileri','OlusturanKullanici') IS NULL ALTER TABLE BankaKrediBilgileri ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('BankaKrediBilgileri','GuncellemeTarihi') IS NULL ALTER TABLE BankaKrediBilgileri ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('BankaKrediBilgileri','GuncelleyenKullanici') IS NULL ALTER TABLE BankaKrediBilgileri ADD GuncelleyenKullanici NVARCHAR(200)");
        // OdemePlani
        alterSqls.Add("IF COL_LENGTH('OdemePlani','OlusturmaTarihi') IS NULL ALTER TABLE OdemePlani ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('OdemePlani','OlusturanKullanici') IS NULL ALTER TABLE OdemePlani ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('OdemePlani','GuncellemeTarihi') IS NULL ALTER TABLE OdemePlani ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('OdemePlani','GuncelleyenKullanici') IS NULL ALTER TABLE OdemePlani ADD GuncelleyenKullanici NVARCHAR(200)");
        // OdemePlaniDetay
        alterSqls.Add("IF COL_LENGTH('OdemePlaniDetay','OlusturmaTarihi') IS NULL ALTER TABLE OdemePlaniDetay ADD OlusturmaTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('OdemePlaniDetay','OlusturanKullanici') IS NULL ALTER TABLE OdemePlaniDetay ADD OlusturanKullanici NVARCHAR(200)");
        alterSqls.Add("IF COL_LENGTH('OdemePlaniDetay','GuncellemeTarihi') IS NULL ALTER TABLE OdemePlaniDetay ADD GuncellemeTarihi DATETIME2");
        alterSqls.Add("IF COL_LENGTH('OdemePlaniDetay','GuncelleyenKullanici') IS NULL ALTER TABLE OdemePlaniDetay ADD GuncelleyenKullanici NVARCHAR(200)");

        // StokFiyatlar tablosu
        alterSqls.Add(@"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StokFiyatlar')
CREATE TABLE StokFiyatlar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StokId INT NOT NULL,
    FiyatGrubu INT DEFAULT 1,
    Fiyat DECIMAL(18,4) DEFAULT 0,
    EskiFiyat DECIMAL(18,4),
    MinFiyat DECIMAL(18,4),
    MaxFiyat DECIMAL(18,4),
    KarMarji DECIMAL(18,4),
    AlisFiyati DECIMAL(18,4),
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    DovizKuru DECIMAL(18,4) DEFAULT 1,
    TLKarsiligi DECIMAL(18,4),
    KdvDahil BIT DEFAULT 0,
    KdvOrani DECIMAL(18,4),
    KdvTutari DECIMAL(18,4),
    KdvDahilFiyat DECIMAL(18,4),
    KdvHaricFiyat DECIMAL(18,4),
    IskontoOrani1 DECIMAL(18,4),
    IskontoOrani2 DECIMAL(18,4),
    IskontoOrani3 DECIMAL(18,4),
    IskontoTutari DECIMAL(18,4),
    NetFiyat DECIMAL(18,4),
    GecerlilikBaslangic DATETIME2,
    GecerlilikBitis DATETIME2,
    Aktif BIT DEFAULT 1,
    BirimKodu NVARCHAR(20),
    BirimCarpani DECIMAL(18,4) DEFAULT 1,
    MinMiktar DECIMAL(18,4),
    MaxMiktar DECIMAL(18,4),
    KampanyaFiyati BIT DEFAULT 0,
    KampanyaKodu NVARCHAR(50),
    KampanyaAciklama NVARCHAR(500),
    Aciklama NVARCHAR(500),
    Not1 NVARCHAR(500),
    Not2 NVARCHAR(500),
    Onaylandi BIT DEFAULT 0,
    OnaylayanKullanici NVARCHAR(200),
    OnayTarihi DATETIME2,
    OlusturmaTarihi DATETIME2,
    OlusturanKullanici NVARCHAR(200),
    GuncellemeTarihi DATETIME2,
    GuncelleyenKullanici NVARCHAR(200)
)");

        // FiyatGruplari tablosu + seed data
        alterSqls.Add(@"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FiyatGruplari')
BEGIN
    CREATE TABLE FiyatGruplari (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        GrupNo INT NOT NULL,
        GrupAdi NVARCHAR(100),
        Aciklama NVARCHAR(500),
        VarsayilanIskontoOrani DECIMAL(18,4),
        VarsayilanDovizKodu NVARCHAR(10) DEFAULT 'TL',
        KdvDahil BIT DEFAULT 0,
        OncelikSirasi INT,
        Aktif BIT DEFAULT 1,
        OlusturmaTarihi DATETIME2 DEFAULT GETDATE(),
        OlusturanKullanici NVARCHAR(200),
        GuncellemeTarihi DATETIME2,
        GuncelleyenKullanici NVARCHAR(200)
    );
    INSERT INTO FiyatGruplari (GrupNo, GrupAdi, OncelikSirasi) VALUES (1, 'Perakende', 1);
    INSERT INTO FiyatGruplari (GrupNo, GrupAdi, OncelikSirasi) VALUES (2, 'Toptan', 2);
    INSERT INTO FiyatGruplari (GrupNo, GrupAdi, OncelikSirasi) VALUES (3, 'Bayi', 3);
    INSERT INTO FiyatGruplari (GrupNo, GrupAdi, OncelikSirasi) VALUES (4, 'Ozel', 4);
    INSERT INTO FiyatGruplari (GrupNo, GrupAdi, OncelikSirasi) VALUES (5, 'VIP', 5);
END");

        // CariFiyatlar tablosu
        alterSqls.Add(@"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CariFiyatlar')
CREATE TABLE CariFiyatlar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CariId INT NOT NULL,
    StokId INT NOT NULL,
    Fiyat DECIMAL(18,4) DEFAULT 0,
    DovizKodu NVARCHAR(10) DEFAULT 'TL',
    KdvDahil BIT DEFAULT 0,
    IskontoOrani1 DECIMAL(18,4),
    IskontoOrani2 DECIMAL(18,4),
    GecerlilikBaslangic DATETIME2,
    GecerlilikBitis DATETIME2,
    Aktif BIT DEFAULT 1,
    Aciklama NVARCHAR(500),
    OlusturmaTarihi DATETIME2,
    OlusturanKullanici NVARCHAR(200),
    GuncellemeTarihi DATETIME2,
    GuncelleyenKullanici NVARCHAR(200)
)");

        // StokFiyatGecmisi tablosu
        alterSqls.Add(@"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StokFiyatGecmisi')
CREATE TABLE StokFiyatGecmisi (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StokId INT,
    FiyatGrubu INT,
    EskiFiyat DECIMAL(18,4),
    YeniFiyat DECIMAL(18,4),
    DegisimOrani DECIMAL(18,4),
    DovizKodu NVARCHAR(10),
    DegisiklikNedeni NVARCHAR(500),
    DegisiklikTarihi DATETIME2 DEFAULT GETDATE(),
    DegistirenKullanici NVARCHAR(200)
)");

        // CariKart FiyatGrubu kolonu
        alterSqls.Add("IF COL_LENGTH('CariKart','FiyatGrubu') IS NULL ALTER TABLE CariKart ADD FiyatGrubu INT DEFAULT 1");

        foreach (var sql in alterSqls)
        {
            try { firmaDb.Database.ExecuteSqlRaw(sql); }
            catch (Exception exAlt) { Console.WriteLine($"ALTER skip: {exAlt.Message}"); }
        }
        Console.WriteLine($"Eksik kolonlar/tablolar kontrol edildi. ({alterSqls.Count} SQL ifadesi calistirildi)");
    }
    catch (Exception exMig) { Console.WriteLine($"Migration hatasi: {exMig.Message}"); }
}
catch (Exception ex)
{
    Console.WriteLine($"MSSQL baglanti hatasi: {ex.Message}");
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

// Güvenli başlıklar — her yanıta eklenir
app.Use(async (context, next) =>
{
    context.Response.Headers["X-Content-Type-Options"] = "nosniff";
    context.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
    context.Response.Headers["Referrer-Policy"] = "strict-origin-when-cross-origin";
    context.Response.Headers["X-XSS-Protection"] = "1; mode=block";
    await next();
});

app.UseStatusCodePagesWithReExecute("/not-found");

app.UseAntiforgery();

// API endpoints
app.MapControllers();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
