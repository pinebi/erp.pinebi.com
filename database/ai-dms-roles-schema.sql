-- AI suite + DMS + Rol/yetki + Stok tahmin cache

-- === DMS ===
IF OBJECT_ID('dbo.pine_documents', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_documents (
        document_id     UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        ad              NVARCHAR(300)    NOT NULL,
        mime            NVARCHAR(100)    NULL,
        boyut           BIGINT           NOT NULL,
        icerik          VARBINARY(MAX)   NULL,   -- DB icinde (kucuk dosyalar)
        disk_yol        NVARCHAR(500)    NULL,   -- Buyukler icin
        hash_sha256     VARBINARY(32)    NULL,
        etiketler       NVARCHAR(500)    NULL,   -- virgulle ayrilmis / AI uretir
        icerik_ozeti    NVARCHAR(MAX)    NULL,   -- AI OCR sonucu
        baglanti_tip    NVARCHAR(30)     NULL,   -- cari / fatura / stok / event / genel
        baglanti_id     NVARCHAR(50)     NULL,   -- cari_kod / fatura_no / stok_kod / event_id
        yukleyen        NVARCHAR(200)    NULL,
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
    );
    CREATE INDEX ix_pine_documents_baglanti ON dbo.pine_documents(baglanti_tip, baglanti_id);
    CREATE INDEX ix_pine_documents_hash ON dbo.pine_documents(hash_sha256);
END;

-- === ROLLER ===
IF OBJECT_ID('dbo.pine_roles', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_roles (
        role_id         UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        ad              NVARCHAR(50)     NOT NULL UNIQUE,
        aciklama        NVARCHAR(300)    NULL,
        yetki_json      NVARCHAR(MAX)    NULL,   -- JSON: { "fatura.goruntule":true, "stok.maliyet.goster":false }
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
    );
    -- Varsayilanlar
    INSERT INTO dbo.pine_roles (role_id, ad, aciklama, yetki_json) VALUES
        (NEWID(), 'admin',     'Tam yetki', N'{"*":true}'),
        (NEWID(), 'muhasebeci','Sadece fatura/cari',        N'{"fatura.*":true,"cari.*":true,"stok.goruntule":true,"stok.maliyet.goster":false}'),
        (NEWID(), 'depocu',    'Sadece stok',               N'{"stok.*":true,"cari.goruntule":true,"fatura.goruntule":false,"stok.maliyet.goster":false}'),
        (NEWID(), 'satis',     'Satis + fiyat (maliyetsiz)',N'{"cari.*":true,"fatura.*":true,"stok.goruntule":true,"stok.maliyet.goster":false}');
END;

IF COL_LENGTH('dbo.pine_kullanicilar', 'role_adi') IS NULL
    AND OBJECT_ID('dbo.pine_kullanicilar', 'U') IS NOT NULL
BEGIN
    ALTER TABLE dbo.pine_kullanicilar ADD role_adi NVARCHAR(50) NULL;
END;

-- === STOK TAHMIN CACHE ===
IF OBJECT_ID('dbo.pine_stok_tahmin', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_stok_tahmin (
        stok_kod        NVARCHAR(30)     NOT NULL PRIMARY KEY,
        gunluk_hareket  DECIMAL(18,3)    NOT NULL DEFAULT 0,
        kalan_gun       INT              NOT NULL DEFAULT 999,
        son_hesap       DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
        oneri           NVARCHAR(500)    NULL
    );
END;

-- === AI OLAY GUNLUGU ===
IF OBJECT_ID('dbo.pine_ai_log', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_ai_log (
        log_id          UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        islem           NVARCHAR(50)     NOT NULL,   -- fatura_oku / cari_analiz / mail_duzelt / stok_tahmin
        giris_ozet      NVARCHAR(500)    NULL,
        cikis_ozet      NVARCHAR(MAX)    NULL,
        token_in        INT              NULL,
        token_out       INT              NULL,
        saglayici       NVARCHAR(30)     NULL,
        kullanici       NVARCHAR(200)    NULL,
        tarih           DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
    );
    CREATE INDEX ix_pine_ai_log_tarih ON dbo.pine_ai_log(tarih DESC);
END;

-- === BILDIRIMLER ===
IF OBJECT_ID('dbo.pine_bildirimler', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_bildirimler (
        bildirim_id     UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        user_id         UNIQUEIDENTIFIER NULL,
        tip             NVARCHAR(30)     NOT NULL,  -- takvim/mail/fatura/stok/sistem
        baslik          NVARCHAR(200)    NOT NULL,
        govde           NVARCHAR(MAX)    NULL,
        url             NVARCHAR(500)    NULL,
        okundu          BIT              NOT NULL DEFAULT 0,
        onem            NVARCHAR(10)     NOT NULL DEFAULT 'info', -- info/uyari/kritik
        tarih           DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
    );
    CREATE INDEX ix_pine_bildirimler_user ON dbo.pine_bildirimler(user_id, okundu, tarih DESC);
END;
GO
