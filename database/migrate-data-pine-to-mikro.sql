-- ============================================================
-- Pine -> Mikro data migration: Stoklar
-- ============================================================
-- pine_stoklar → stoklar kopyalama
-- Calistirilan DB uzerinde calisir. Mevcut Mikro stoklar silinmez,
-- yeni kayitlar INSERT edilir. Key: sto_kod (cakisanlar guncellenir).
-- ============================================================

-- Stoklar
MERGE INTO stoklar AS tgt
USING (
    SELECT
        sto_kod       AS sto_kod,
        LEFT(sto_isim, 50)      AS sto_isim,
        LEFT(sto_kisa_isim, 25) AS sto_kisa_ismi,
        LEFT(sto_yabanci_isim, 50) AS sto_yabanci_isim,
        LEFT(sto_birim1_ad, 10) AS sto_birim1_ad,
        sto_perakende_vergi AS sto_perakende_vergi,
        NEWID() AS sto_Guid
    FROM pine_stoklar
    WHERE rec_iptal = 0 AND rec_gizli = 0 AND sto_kod IS NOT NULL
) AS src
ON tgt.sto_kod = src.sto_kod
WHEN MATCHED THEN
    UPDATE SET
        sto_isim = src.sto_isim,
        sto_kisa_ismi = src.sto_kisa_ismi,
        sto_yabanci_isim = src.sto_yabanci_isim,
        sto_birim1_ad = src.sto_birim1_ad,
        sto_perakende_vergi = src.sto_perakende_vergi
WHEN NOT MATCHED THEN
    INSERT (sto_kod, sto_isim, sto_kisa_ismi, sto_yabanci_isim, sto_birim1_ad, sto_perakende_vergi, sto_Guid, sto_iptal, sto_hidden, sto_kilitli, sto_degisti)
    VALUES (src.sto_kod, src.sto_isim, src.sto_kisa_ismi, src.sto_yabanci_isim, src.sto_birim1_ad, src.sto_perakende_vergi, src.sto_Guid, 0, 0, 0, 0);

DECLARE @cnt INT = (SELECT COUNT(*) FROM stoklar);
PRINT 'stoklar kayit sayisi: ' + CAST(@cnt AS VARCHAR);

-- Cari Hesaplar (minimal set: kod + unvan)
MERGE INTO cari_hesaplar AS tgt
USING (
    SELECT
        car_kod AS cari_kod,
        car_unvan1 AS cari_unvan1,
        car_unvan2 AS cari_unvan2,
        NEWID() AS cari_Guid
    FROM pine_cari_hesaplar
    WHERE rec_iptal = 0 AND rec_gizli = 0 AND car_kod IS NOT NULL
) AS src
ON tgt.cari_kod = src.cari_kod
WHEN MATCHED THEN
    UPDATE SET cari_unvan1 = src.cari_unvan1, cari_unvan2 = src.cari_unvan2
WHEN NOT MATCHED THEN
    INSERT (cari_kod, cari_unvan1, cari_unvan2, cari_Guid, cari_iptal, cari_hidden, cari_kilitli, cari_degisti)
    VALUES (src.cari_kod, src.cari_unvan1, src.cari_unvan2, src.cari_Guid, 0, 0, 0, 0);

SET @cnt = (SELECT COUNT(*) FROM cari_hesaplar);
PRINT 'cari_hesaplar kayit sayisi: ' + CAST(@cnt AS VARCHAR);
