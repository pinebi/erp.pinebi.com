-- Pinebi ERP: Takvim & Toplanti modulu
-- Her tenant DB'sinde calistirilir. Idempotent.

IF OBJECT_ID('dbo.pine_calendars', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_calendars (
        calendar_id     UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        owner_user_id   UNIQUEIDENTIFIER NULL,       -- NULL = kaynak takvimi (oda/arac)
        ad              NVARCHAR(100)    NOT NULL,
        renk            NVARCHAR(10)     NOT NULL DEFAULT '#3b82f6',
        tip             NVARCHAR(20)     NOT NULL DEFAULT 'kisisel', -- kisisel/kaynak
        aciklama        NVARCHAR(500)    NULL,
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
        aktif           BIT              NOT NULL DEFAULT 1
    );
    CREATE INDEX ix_pine_calendars_owner ON dbo.pine_calendars(owner_user_id);
END;

IF OBJECT_ID('dbo.pine_calendar_shares', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_calendar_shares (
        share_id        UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        calendar_id     UNIQUEIDENTIFIER NOT NULL,
        paylasim_user_id UNIQUEIDENTIFIER NOT NULL,
        yetki           NVARCHAR(20)     NOT NULL DEFAULT 'goruntule', -- sadece_mesgul / goruntule / duzenle
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
    );
    CREATE UNIQUE INDEX ux_pine_calendar_shares ON dbo.pine_calendar_shares(calendar_id, paylasim_user_id);
END;

IF OBJECT_ID('dbo.pine_rooms', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_rooms (
        room_id         UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        ad              NVARCHAR(100)    NOT NULL,
        kapasite        INT              NULL,
        konum           NVARCHAR(200)    NULL,
        renk            NVARCHAR(10)     NOT NULL DEFAULT '#8b5cf6',
        aktif           BIT              NOT NULL DEFAULT 1
    );
END;

IF OBJECT_ID('dbo.pine_events', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_events (
        event_id        UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        calendar_id     UNIQUEIDENTIFIER NOT NULL,
        baslik          NVARCHAR(200)    NOT NULL,
        aciklama        NVARCHAR(MAX)    NULL,
        baslangic       DATETIME2        NOT NULL,
        bitis           DATETIME2        NOT NULL,
        tum_gun         BIT              NOT NULL DEFAULT 0,
        konum           NVARCHAR(200)    NULL,
        renk            NVARCHAR(10)     NULL,
        cari_kod        NVARCHAR(30)     NULL,     -- Mikro cari_hesaplar.cari_kod
        proje_id        UNIQUEIDENTIFIER NULL,     -- pine_projeler.proje_id
        room_id         UNIQUEIDENTIFIER NULL,     -- pine_rooms.room_id
        olusturan_user_id UNIQUEIDENTIFIER NULL,
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
        guncellenme     DATETIME2        NULL,
        iptal           BIT              NOT NULL DEFAULT 0
    );
    CREATE INDEX ix_pine_events_cal ON dbo.pine_events(calendar_id, baslangic, bitis);
    CREATE INDEX ix_pine_events_room ON dbo.pine_events(room_id, baslangic, bitis);
    CREATE INDEX ix_pine_events_cari ON dbo.pine_events(cari_kod);
END;

IF OBJECT_ID('dbo.pine_event_participants', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_event_participants (
        participant_id  UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        event_id        UNIQUEIDENTIFIER NOT NULL,
        user_id         UNIQUEIDENTIFIER NOT NULL,
        email           NVARCHAR(200)    NULL,
        zorunlu         BIT              NOT NULL DEFAULT 1,
        yanit           NVARCHAR(20)     NOT NULL DEFAULT 'beklemede', -- beklemede/kabul/red/belki
        yanit_tarih     DATETIME2        NULL
    );
    CREATE INDEX ix_pine_event_participants_ev ON dbo.pine_event_participants(event_id);
    CREATE INDEX ix_pine_event_participants_u  ON dbo.pine_event_participants(user_id);
END;

IF OBJECT_ID('dbo.pine_event_reminders', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_event_reminders (
        reminder_id     UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        event_id        UNIQUEIDENTIFIER NOT NULL,
        user_id         UNIQUEIDENTIFIER NULL,
        dakika_once     INT              NOT NULL DEFAULT 15,
        kanal           NVARCHAR(20)     NOT NULL DEFAULT 'email', -- email/uygulama
        gonderildi      BIT              NOT NULL DEFAULT 0
    );
END;
GO
