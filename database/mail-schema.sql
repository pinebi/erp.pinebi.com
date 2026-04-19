-- Pinebi ERP: Mail modulu (Outlook style)
-- Her tenant DB'sine uygulanir. Idempotent.

IF OBJECT_ID('dbo.pine_mail_accounts', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_mail_accounts (
        account_id      UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        user_id         UNIQUEIDENTIFIER NULL,
        ad              NVARCHAR(100)    NOT NULL,        -- gosterim adi
        email           NVARCHAR(200)    NOT NULL,
        -- IMAP
        imap_host       NVARCHAR(200)    NOT NULL,
        imap_port       INT              NOT NULL DEFAULT 993,
        imap_ssl        BIT              NOT NULL DEFAULT 1,
        imap_user       NVARCHAR(200)    NOT NULL,
        imap_pass_enc   NVARCHAR(1000)   NOT NULL,        -- DataProtection ile sifreli
        -- SMTP
        smtp_host       NVARCHAR(200)    NOT NULL,
        smtp_port       INT              NOT NULL DEFAULT 587,
        smtp_ssl        BIT              NOT NULL DEFAULT 1,
        smtp_user       NVARCHAR(200)    NOT NULL,
        smtp_pass_enc   NVARCHAR(1000)   NOT NULL,
        imza_html       NVARCHAR(MAX)    NULL,
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
        aktif           BIT              NOT NULL DEFAULT 1
    );
    CREATE INDEX ix_pine_mail_accounts_user ON dbo.pine_mail_accounts(user_id);
END;

IF OBJECT_ID('dbo.pine_mail_drafts', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.pine_mail_drafts (
        draft_id        UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
        account_id      UNIQUEIDENTIFIER NOT NULL,
        konu            NVARCHAR(500)    NULL,
        alici           NVARCHAR(MAX)    NULL,    -- virgul ile ayrilmis
        cc              NVARCHAR(MAX)    NULL,
        bcc             NVARCHAR(MAX)    NULL,
        govde_html      NVARCHAR(MAX)    NULL,
        olusturulma     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
        guncellenme     DATETIME2        NULL
    );
    CREATE INDEX ix_pine_mail_drafts_acc ON dbo.pine_mail_drafts(account_id);
END;
GO
