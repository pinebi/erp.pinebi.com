# Pinebi ERP — Veritabanı Yedekleri

Bu klasörde SQL Server 2019+ için tam DB backup dosyaları var. Projeyi
yeni bir sunucuda ayağa kaldırmak için gereken tüm veritabanlarını içerir.

## Dosyalar

| Dosya | İçerik | Boyut |
|---|---|---|
| `Pinebi_Master.bak` | Control Plane (tenant metadata) | ~570KB |
| `PineERP.bak` | Varsayılan tenant (demo) — 581 stok, 70 cari | ~1.7MB |
| `Pinebi_Tenant_ACME.bak` | ACME tenant örneği (PineERP klonu) | ~1.7MB |
| `PineERP_Yeni.bak` | Mikro V16 uyumlu 413 tablo (boş şema) | ~1.9MB |

## Kurulum

### Önkoşullar
- SQL Server 2019 veya 2022
- `EDonusum` kullanıcısı (CREATE DATABASE yetkili)

### Restore adımları

```sql
-- Pinebi_Master
RESTORE DATABASE Pinebi_Master FROM DISK = N'/tmp/Pinebi_Master.bak'
  WITH MOVE 'Pinebi_Master' TO '/var/opt/mssql/data/Pinebi_Master.mdf',
       MOVE 'Pinebi_Master_log' TO '/var/opt/mssql/data/Pinebi_Master_log.ldf',
       REPLACE;

-- PineERP (demo tenant)
RESTORE DATABASE PineERP FROM DISK = N'/tmp/PineERP.bak'
  WITH MOVE 'PineERP' TO '/var/opt/mssql/data/PineERP.mdf',
       MOVE 'PineERP_log' TO '/var/opt/mssql/data/PineERP_log.ldf',
       REPLACE;

-- Pinebi_Tenant_ACME
RESTORE DATABASE Pinebi_Tenant_ACME FROM DISK = N'/tmp/Pinebi_Tenant_ACME.bak'
  WITH MOVE 'PineERP' TO '/var/opt/mssql/data/Pinebi_Tenant_ACME.mdf',
       MOVE 'PineERP_log' TO '/var/opt/mssql/data/Pinebi_Tenant_ACME_log.ldf',
       REPLACE;

-- PineERP_Yeni (Mikro şeması, ileride kullanılacak)
RESTORE DATABASE PineERP_Yeni FROM DISK = N'/tmp/PineERP_Yeni.bak'
  WITH MOVE 'PineERP_Yeni' TO '/var/opt/mssql/data/PineERP_Yeni.mdf',
       MOVE 'PineERP_Yeni_log' TO '/var/opt/mssql/data/PineERP_Yeni_log.ldf',
       REPLACE;
```

Windows sunucuda yol: `C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\`

### Master DB yapılandırması

Restore sonrası `Pinebi_Master.tenant_connections` tablosundaki connection
string'leri yeni sunucu IP'sine göre güncelle:

```sql
USE Pinebi_Master;
UPDATE tenant_connections
SET connection_string_encrypted = CAST(
  'Server=YENI_IP;Database=' + t.db_name +
  ';User Id=EDonusum;Password=YENI_SIFRE;TrustServerCertificate=True;' AS VARBINARY(2000))
FROM tenant_connections c
JOIN tenants t ON c.tenant_id = t.tenant_id;
```

### Uygulama yapılandırması

`Program.cs:13`'teki hardcoded connection string'i yeni sunucuya göre
güncelle (veya `appsettings.json`'a taşı).

## Varsayılan Giriş

- **URL:** https://erp.pinebi.com
- **Kullanıcı:** `admin`
- **Şifre:** `admin`
