USE PineERP;

-- Ornek Firma ekle
IF NOT EXISTS (SELECT * FROM Firmalar WHERE FirmaKodu = 'PINEBI')
INSERT INTO Firmalar (FirmaKodu, FirmaUnvani, VergiNo, VergiDairesi, Telefon, Email, Sehir)
VALUES ('PINEBI', N'Pinebi Bilisim Cozumleri San. ve Tic. Ltd. Sti.', '7300724382', N'Duzce', '0380 524 24 24', 'info@pinebi.com', N'Duzce');

DECLARE @FirmaId INT = (SELECT Id FROM Firmalar WHERE FirmaKodu = 'PINEBI');

-- Lisans (1 yillik Enterprise)
IF NOT EXISTS (SELECT * FROM Lisanslar WHERE FirmaId = @FirmaId)
INSERT INTO Lisanslar (FirmaId, PlanTipi, BaslangicTarihi, BitisTarihi, MaxKullanici, MaxFaturaAylik, MaxStok, MaxCari, EFaturaAktif, EIrsaliyeAktif, EArsivAktif, Tutar, OdemeDurumu, Aktif)
VALUES (@FirmaId, 'Enterprise', GETDATE(), DATEADD(YEAR, 1, GETDATE()), 10, 999999, 999999, 999999, 1, 1, 1, 9990.00, 'Odendi', 1);

-- Admin
IF NOT EXISTS (SELECT * FROM Kullanicilar WHERE KullaniciAdi = 'admin')
INSERT INTO Kullanicilar (FirmaId, KullaniciAdi, Email, SifreHash, AdSoyad, Rol)
VALUES (@FirmaId, 'admin', 'admin@pinebi.com', 'admin123', N'Sistem Yoneticisi', 'Admin');

-- Demo
IF NOT EXISTS (SELECT * FROM Kullanicilar WHERE KullaniciAdi = 'demo')
INSERT INTO Kullanicilar (FirmaId, KullaniciAdi, Email, SifreHash, AdSoyad, Rol)
VALUES (@FirmaId, 'demo', 'demo@pinebi.com', 'demo', N'Demo Kullanici', 'Kullanici');

-- Admin yetkileri
DECLARE @AdminId INT = (SELECT Id FROM Kullanicilar WHERE KullaniciAdi = 'admin');
IF @AdminId IS NOT NULL AND NOT EXISTS (SELECT * FROM KullaniciYetkileri WHERE KullaniciId = @AdminId)
INSERT INTO KullaniciYetkileri (KullaniciId) VALUES (@AdminId);

-- Demo yetkileri
DECLARE @DemoId INT = (SELECT Id FROM Kullanicilar WHERE KullaniciAdi = 'demo');
IF @DemoId IS NOT NULL AND NOT EXISTS (SELECT * FROM KullaniciYetkileri WHERE KullaniciId = @DemoId)
INSERT INTO KullaniciYetkileri (KullaniciId) VALUES (@DemoId);

-- Birimler
IF NOT EXISTS (SELECT * FROM Birimler)
BEGIN
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'AD', 'Adet');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'KG', 'Kilogram');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'LT', 'Litre');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'MT', 'Metre');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'KT', 'Kutu');
    INSERT INTO Birimler (FirmaId, BirimKodu, BirimAdi) VALUES (@FirmaId, 'PK', 'Paket');
END;

-- Kasalar
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

-- Ornek Cariler
IF NOT EXISTS (SELECT * FROM CariKart)
BEGIN
    INSERT INTO CariKart (FirmaId, CariKodu, Unvani, CariGrubu, EFatura, Yetkili1, Telefon1, Email, Vd, Vn, Adres1, Sehir, Ilce) VALUES
    (@FirmaId, 'C-001', N'Pinebi Bilisim Teknolojileri A.S.', 'Musteri', 1, 'Ahmet Yilmaz', '0212 555 1001', 'info@pinebi.com', 'Mecidiyekoy', '1234567890', N'Buyukdere Cad. No:123', 'Istanbul', N'Sisli');
    INSERT INTO CariKart (FirmaId, CariKodu, Unvani, CariGrubu, EFatura, Yetkili1, Telefon1, Email, Vd, Vn, Adres1, Sehir, Ilce) VALUES
    (@FirmaId, 'C-002', N'BlockBiss Yazilim Ltd. Sti.', 'Musteri', 1, 'Mehmet Demir', '0216 444 2002', 'info@blockbiss.com', 'Kadikoy', '9876543210', N'Bagdat Cad. No:456', 'Istanbul', N'Kadikoy');
    INSERT INTO CariKart (FirmaId, CariKodu, Unvani, CariGrubu, EFatura, Yetkili1, Telefon1, Email, Vd, Vn, Adres1, Sehir, Ilce) VALUES
    (@FirmaId, 'C-003', N'Anadolu Makina Sanayi A.S.', 'Tedarikci', 1, 'Ali Kaya', '0312 333 3003', 'satis@anadolumakina.com.tr', 'Ostim', '5678901234', N'OSB 7. Cad. No:89', 'Ankara', 'Yenimahalle');
    INSERT INTO CariKart (FirmaId, CariKodu, Unvani, CariGrubu, EFatura, Yetkili1, Telefon1, Email, Vd, Vn, Adres1, Sehir, Ilce) VALUES
    (@FirmaId, 'C-004', N'Ege Elektronik Tic. Ltd. Sti.', 'Musteri', 0, 'Fatma Ozturk', '0232 222 4004', 'fatma@egeelektronik.com', 'Konak', '3456789012', N'Ataturk Cad. No:567', 'Izmir', 'Konak');
    INSERT INTO CariKart (FirmaId, CariKodu, Unvani, CariGrubu, EFatura, Yetkili1, Telefon1, Email, Vd, Vn, Adres1, Sehir, Ilce) VALUES
    (@FirmaId, 'C-005', N'Karadeniz Gida Pazarlama A.S.', 'Tedarikci', 1, 'Hasan Celik', '0462 111 5005', 'hasan@karadenizgida.com.tr', 'Trabzon', '7890123456', N'Sahil Yolu No:12', 'Trabzon', 'Ortahisar');
END;

-- Ornek Stok Kartlari
IF NOT EXISTS (SELECT * FROM StokKart)
BEGIN
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-001', 'Laptop Dell Inspiron 15', '8690001000011', 'Adet', 20, 35000, 'TL', 'Bilgisayar', 'Dell Inspiron 15 i7 16GB');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-002', 'Samsung Monitor 27 inch', '8690001000028', 'Adet', 20, 12000, 'TL', 'Monitor', 'Samsung Odyssey G5 27 QHD');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-003', 'Logitech MX Keys Klavye', '8690001000035', 'Adet', 20, 4500, 'TL', 'Aksesuar', 'MX Keys kablosuz');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-004', 'Cat6 Network Kablosu 305m', '8690001000042', 'Kutu', 20, 2800, 'TL', 'Kablo', 'Cat6 UTP 305m');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-005', 'HP LaserJet Pro M404dn', '8690001000059', 'Adet', 20, 18500, 'TL', 'Yazici', 'HP LaserJet mono lazer');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-006', 'Apple MacBook Pro 14 M3', '8690001000066', 'Adet', 20, 95000, 'TL', 'Bilgisayar', 'MacBook Pro 14 M3 Pro');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-007', 'Epson L3250 Yazici', '8690001000073', 'Adet', 20, 8500, 'TL', 'Yazici', 'EcoTank L3250 Renkli');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-008', 'TP-Link Archer AX73 Router', '8690001000080', 'Adet', 20, 3200, 'TL', 'Network', 'AX5400 WiFi 6 Router');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-009', 'Microsoft Office 2024', '8690001000097', 'Adet', 20, 6500, 'TL', 'Yazilim', 'Office 2024 Pro Plus');
    INSERT INTO StokKart (FirmaId, StokKodu, StokCinsi, Barkod, Birim, Kdv, KdvHaricSatisFiyati, DovizKodu, UrunGrubu, Aciklama) VALUES
    (@FirmaId, 'STK-010', 'UPS APC 1500VA', '8690001000104', 'Adet', 20, 7800, 'TL', 'Guc', 'APC Back-UPS Pro 1500VA');
END;

SELECT 'TAMAMLANDI' AS Durum,
    (SELECT COUNT(*) FROM Firmalar) AS Firma,
    (SELECT COUNT(*) FROM Lisanslar) AS Lisans,
    (SELECT COUNT(*) FROM Kullanicilar) AS Kullanici,
    (SELECT COUNT(*) FROM CariKart) AS Cari,
    (SELECT COUNT(*) FROM StokKart) AS Stok,
    (SELECT COUNT(*) FROM Birimler) AS Birim,
    (SELECT COUNT(*) FROM Kasalar) AS Kasa,
    (SELECT COUNT(*) FROM Numarator) AS Numarator;
