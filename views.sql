USE PineERP;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'FaturalarView') DROP VIEW FaturalarView;
GO
CREATE VIEW FaturalarView AS
SELECT f.*, c.CariKodu, c.Unvani, c.Vn AS CariVn, c.Email AS CariEmail, c.Telefon1 AS CariTelefon
FROM Faturalar f
LEFT JOIN CariKart c ON f.CariId = c.Id;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'CariHareketlerView') DROP VIEW CariHareketlerView;
GO
CREATE VIEW CariHareketlerView AS
SELECT ch.*, c.CariKodu, c.Unvani
FROM CariHareketler ch
LEFT JOIN CariKart c ON ch.CariId = c.Id;
GO

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

IF EXISTS (SELECT * FROM sys.views WHERE name = 'KasaHareketleriView') DROP VIEW KasaHareketleriView;
GO
CREATE VIEW KasaHareketleriView AS
SELECT kh.*, k.KasaKodu, k.KasaAdi
FROM KasaHareketleri kh
LEFT JOIN Kasalar k ON kh.KasaId = k.Id;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'BankaHareketleriView') DROP VIEW BankaHareketleriView;
GO
CREATE VIEW BankaHareketleriView AS
SELECT bh.*, bhb.BankaAdi, bhb.Iban
FROM BankaHareketleri bh
LEFT JOIN BankaHesapBilgileri bhb ON bh.BankaId = bhb.Id;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'IrsaliyelerView') DROP VIEW IrsaliyelerView;
GO
CREATE VIEW IrsaliyelerView AS
SELECT i.*, c.CariKodu, c.Unvani
FROM Irsaliyeler i
LEFT JOIN CariKart c ON i.CariId = c.Id;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'SiparislerView') DROP VIEW SiparislerView;
GO
CREATE VIEW SiparislerView AS
SELECT s.*, c.CariKodu, c.Unvani
FROM Siparisler s
LEFT JOIN CariKart c ON s.CariId = c.Id;
GO

IF EXISTS (SELECT * FROM sys.views WHERE name = 'TekliflerView') DROP VIEW TekliflerView;
GO
CREATE VIEW TekliflerView AS
SELECT t.*, c.CariKodu, c.Unvani
FROM Teklifler t
LEFT JOIN CariKart c ON t.CariId = c.Id;
GO

PRINT 'View''ler basariyla olusturuldu!';
SELECT COUNT(*) AS ViewSayisi FROM sys.views WHERE schema_id = SCHEMA_ID('dbo');
GO
