SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
GO

-- ============================================================
-- PINEBI CONTROL PLANE (Master Metadata DB)
-- DB Adı: Pinebi_Master
-- Amaç: Tenant registry, connection strings, subscriptions
-- ============================================================

-- Önce DB oluştur:
-- CREATE DATABASE Pinebi_Master;
-- GO
-- USE Pinebi_Master;
-- GO

-- ============================================================
-- 1. REGIONS — fiziksel SQL cluster konumları
-- ============================================================
CREATE TABLE regions (
    region_id       NVARCHAR(10)     NOT NULL PRIMARY KEY,  -- 'tr', 'eu', 'us'
    region_name     NVARCHAR(100)    NOT NULL,              -- 'Türkiye (İstanbul)'
    sql_server      NVARCHAR(200)    NOT NULL,              -- '10.0.1.5,1433'
    sql_admin_user  NVARCHAR(50)     NOT NULL,              -- master kullanıcı (şifrelenmiş saklanmalı)
    sql_admin_pass_encrypted VARBINARY(500) NOT NULL,       -- DPAPI ile şifreli
    max_tenants     INT              NOT NULL DEFAULT 3000,
    current_tenants INT              NOT NULL DEFAULT 0,
    active          BIT              NOT NULL DEFAULT 1,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

INSERT INTO regions (region_id, region_name, sql_server, sql_admin_user, sql_admin_pass_encrypted)
VALUES
 ('tr', N'Türkiye (İstanbul)',  '185.210.92.248', 'sa', 0x00),
 ('eu', N'Avrupa (Frankfurt)',  'TBD',            'sa', 0x00),
 ('us', N'ABD (Virginia)',       'TBD',           'sa', 0x00);

-- ============================================================
-- 2. SUBSCRIPTION TIERS — fiyatlandırma/feature paketleri
-- ============================================================
CREATE TABLE subscription_tiers (
    tier_id         INT              NOT NULL IDENTITY(1,1) PRIMARY KEY,
    tier_code       NVARCHAR(20)     NOT NULL UNIQUE,   -- 'free', 'starter', 'pro', 'enterprise'
    tier_name       NVARCHAR(100)    NOT NULL,
    max_users       INT              NOT NULL,
    max_storage_gb  INT              NOT NULL,
    max_invoices_month INT           NOT NULL,
    features_json   NVARCHAR(MAX)    NULL,              -- '{"efatura":true,"multiwarehouse":true,...}'
    monthly_price_usd DECIMAL(10,2)  NOT NULL DEFAULT 0,
    active          BIT              NOT NULL DEFAULT 1
);

INSERT INTO subscription_tiers (tier_code, tier_name, max_users, max_storage_gb, max_invoices_month, monthly_price_usd)
VALUES
 ('free',       N'Ücretsiz',       2,   1,   100,    0.00),
 ('starter',    N'Başlangıç',      5,   10,  1000,   29.00),
 ('pro',        N'Profesyonel',   25,   100, 10000,  99.00),
 ('enterprise', N'Kurumsal',     999,   1000, 999999, 499.00);

-- ============================================================
-- 3. TENANTS — her firma için bir kayıt
-- ============================================================
CREATE TABLE tenants (
    tenant_id       UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
    tenant_code     NVARCHAR(20)     NOT NULL UNIQUE,     -- kısa kod: 'PINEBI', 'ACME'
    tenant_name     NVARCHAR(200)    NOT NULL,            -- 'Pinebi Yazılım A.Ş.'
    subdomain       NVARCHAR(50)     NOT NULL UNIQUE,     -- 'pinebi' → pinebi.erp.pinebi.com
    region_id       NVARCHAR(10)     NOT NULL REFERENCES regions(region_id),
    db_name         NVARCHAR(128)    NOT NULL,            -- 'pinebi_tenant_A3F7B1'
    tier_id         INT              NOT NULL REFERENCES subscription_tiers(tier_id),
    status          NVARCHAR(20)     NOT NULL DEFAULT 'provisioning',
                      -- 'provisioning', 'active', 'suspended', 'deleted'
    vergi_no        NVARCHAR(20)     NULL,
    ulke_kodu       NVARCHAR(5)      NULL,
    timezone        NVARCHAR(50)     NOT NULL DEFAULT 'Europe/Istanbul',
    locale          NVARCHAR(10)     NOT NULL DEFAULT 'tr-TR',
    currency        NVARCHAR(5)      NOT NULL DEFAULT 'TRY',
    logo_url        NVARCHAR(500)    NULL,
    primary_color   NVARCHAR(7)      NOT NULL DEFAULT '#235881',
    contact_email   NVARCHAR(200)    NOT NULL,
    contact_phone   NVARCHAR(30)     NULL,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
    activated_at    DATETIME2        NULL,
    suspended_at    DATETIME2        NULL,
    deleted_at      DATETIME2        NULL,
    rec_guid        UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID()
);

CREATE INDEX ix_tenants_subdomain ON tenants(subdomain) WHERE status != 'deleted';
CREATE INDEX ix_tenants_region_status ON tenants(region_id, status);

-- ============================================================
-- 4. TENANT CONNECTIONS — dinamik DB bağlantısı
-- ============================================================
CREATE TABLE tenant_connections (
    tenant_id               UNIQUEIDENTIFIER NOT NULL PRIMARY KEY REFERENCES tenants(tenant_id),
    connection_string_encrypted VARBINARY(2000) NOT NULL,  -- DPAPI/Azure Key Vault
    read_replica_connection_encrypted VARBINARY(2000) NULL, -- opsiyonel read-replica
    last_used_at            DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
    last_rotation_at        DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

-- ============================================================
-- 5. PLATFORM USERS — ERP dışı (Pinebi kontrol eden personel)
-- ============================================================
CREATE TABLE platform_users (
    user_id         UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
    email           NVARCHAR(200)    NOT NULL UNIQUE,
    full_name       NVARCHAR(200)    NOT NULL,
    password_hash   NVARCHAR(500)    NOT NULL,          -- BCrypt
    role            NVARCHAR(30)     NOT NULL,          -- 'admin', 'support', 'readonly'
    mfa_secret      NVARCHAR(100)    NULL,
    active          BIT              NOT NULL DEFAULT 1,
    last_login_at   DATETIME2        NULL,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

-- ============================================================
-- 6. TENANT USERS (master copy) — Tek bir kullanıcı birden fazla tenant'a erişebilir
--    Login önce bu tablodan doğrulanır, sonra ilgili tenant DB'sine yönlendirilir
-- ============================================================
CREATE TABLE tenant_users (
    user_id         UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
    email           NVARCHAR(200)    NOT NULL UNIQUE,
    password_hash   NVARCHAR(500)    NOT NULL,
    full_name       NVARCHAR(200)    NOT NULL,
    phone           NVARCHAR(30)     NULL,
    email_verified  BIT              NOT NULL DEFAULT 0,
    active          BIT              NOT NULL DEFAULT 1,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE tenant_user_memberships (
    tenant_id       UNIQUEIDENTIFIER NOT NULL REFERENCES tenants(tenant_id),
    user_id         UNIQUEIDENTIFIER NOT NULL REFERENCES tenant_users(user_id),
    role            NVARCHAR(30)     NOT NULL,         -- 'owner', 'admin', 'user', 'readonly'
    invited_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
    accepted_at     DATETIME2        NULL,
    revoked_at      DATETIME2        NULL,
    PRIMARY KEY (tenant_id, user_id)
);

CREATE INDEX ix_memberships_user ON tenant_user_memberships(user_id) WHERE revoked_at IS NULL;

-- ============================================================
-- 7. SUBSCRIPTIONS — billing/abonelik geçmişi
-- ============================================================
CREATE TABLE subscriptions (
    subscription_id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
    tenant_id       UNIQUEIDENTIFIER NOT NULL REFERENCES tenants(tenant_id),
    tier_id         INT              NOT NULL REFERENCES subscription_tiers(tier_id),
    start_date      DATE             NOT NULL,
    end_date        DATE             NULL,
    status          NVARCHAR(20)     NOT NULL,        -- 'active','past_due','cancelled'
    next_billing_at DATETIME2        NULL,
    provider        NVARCHAR(30)     NULL,            -- 'stripe','iyzico','manual'
    provider_id     NVARCHAR(200)    NULL,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE INDEX ix_subs_tenant ON subscriptions(tenant_id);

-- ============================================================
-- 8. COMMON DATA — tüm tenant'ların paylaştığı referans veri
-- ============================================================
CREATE TABLE common_countries (
    country_code    NVARCHAR(3)      NOT NULL PRIMARY KEY,  -- 'TR', 'DE', 'US'
    country_name_tr NVARCHAR(100)    NOT NULL,
    country_name_en NVARCHAR(100)    NOT NULL,
    phone_code      NVARCHAR(10)     NOT NULL,             -- '+90'
    currency_code   NVARCHAR(5)      NOT NULL,             -- 'TRY'
    eu_member       BIT              NOT NULL DEFAULT 0
);

CREATE TABLE common_currencies (
    currency_code   NVARCHAR(5)      NOT NULL PRIMARY KEY,  -- 'USD','EUR','TRY'
    currency_name   NVARCHAR(50)     NOT NULL,
    symbol          NVARCHAR(5)      NOT NULL               -- '$','€','₺'
);

CREATE TABLE common_exchange_rates (
    rate_date       DATE             NOT NULL,
    currency_code   NVARCHAR(5)      NOT NULL REFERENCES common_currencies(currency_code),
    rate_to_usd     DECIMAL(18,8)    NOT NULL,
    source          NVARCHAR(30)     NOT NULL,              -- 'TCMB','ECB','yahoo'
    PRIMARY KEY (rate_date, currency_code)
);

-- ============================================================
-- 9. PROVISIONING JOBS — tenant oluşturma takibi
-- ============================================================
CREATE TABLE provisioning_jobs (
    job_id          UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID() PRIMARY KEY,
    tenant_id       UNIQUEIDENTIFIER NOT NULL REFERENCES tenants(tenant_id),
    status          NVARCHAR(20)     NOT NULL,        -- 'pending','running','success','failed'
    started_at      DATETIME2        NULL,
    finished_at     DATETIME2        NULL,
    error_message   NVARCHAR(MAX)    NULL,
    step_log        NVARCHAR(MAX)    NULL,            -- JSON adım log'u
    retry_count     INT              NOT NULL DEFAULT 0,
    created_at      DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE INDEX ix_prov_status ON provisioning_jobs(status) WHERE status IN ('pending','running');

-- ============================================================
-- 10. AUDIT EVENTS — kontrol düzlemi olayları (ERP içi değil)
-- ============================================================
CREATE TABLE control_audit_events (
    event_id        BIGINT           NOT NULL IDENTITY(1,1) PRIMARY KEY,
    occurred_at     DATETIME2        NOT NULL DEFAULT SYSUTCDATETIME(),
    actor_type      NVARCHAR(20)     NOT NULL,        -- 'platform_user','tenant_user','system'
    actor_id        UNIQUEIDENTIFIER NULL,
    tenant_id       UNIQUEIDENTIFIER NULL,
    event_type      NVARCHAR(50)     NOT NULL,        -- 'tenant.created','tenant.suspended', ...
    details_json    NVARCHAR(MAX)    NOT NULL,
    ip_address      NVARCHAR(45)     NULL
);

CREATE INDEX ix_audit_tenant ON control_audit_events(tenant_id, occurred_at);
CREATE INDEX ix_audit_type_time ON control_audit_events(event_type, occurred_at);
