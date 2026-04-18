# 01 · Multi-Tenant Mimari (Genel Bakış)

## Amaç

Pinebi ERP'yi global ölçekte **binlerce firma**ya hizmet verebilecek
multi-tenant mimariye geçirmek. Her firma (tenant) kendi izole
veritabanına sahip, bölgesel SQL cluster'larda çalışan, saniyeler içinde
provisioning edilebilen bir yapı.

## Seçilen Strateji

**Database-per-Tenant + Regional Sharding + Central Control Plane**

```
┌─────────────────────────────────────────────────────────┐
│              CONTROL PLANE (Pinebi_Master)              │
│  - tenants, tenant_connections, subscriptions           │
│  - common_data (iller, ülkeler, döviz kurları)          │
│  - audit_events (ortak audit)                           │
│  Konum: Her bölgeden erişilebilir primary region        │
└─────────────────────────────────────────────────────────┘
                        │
        ┌───────────────┼───────────────┐
        ▼               ▼               ▼
   ┌──────────┐    ┌──────────┐    ┌──────────┐
   │ REGION   │    │ REGION   │    │ REGION   │
   │   TR     │    │   EU     │    │   US     │
   ├──────────┤    ├──────────┤    ├──────────┤
   │ tenant_1 │    │ tenant_7 │    │ tenant_9 │
   │ tenant_2 │    │ tenant_8 │    │ tenant_10│
   │ tenant_3 │    │  ...     │    │  ...     │
   │ tenant_N │    │          │    │          │
   └──────────┘    └──────────┘    └──────────┘
   SQL Server      SQL Server      SQL Server
   İstanbul        Frankfurt       Virginia
```

## Bileşenler

### 1. Control Plane DB (`Pinebi_Master`)
- **Tek** global veritabanı
- Tenant metadata, connection string, abonelik bilgileri
- Ortak referans verisi (ülkeler, para birimleri, döviz kurları)

### 2. Tenant DB'leri (Pine şeması)
- Her firma için **ayrı SQL database**
- İsimlendirme: `pinebi_tenant_{tenantId}` (örn. `pinebi_tenant_A3F7`)
- Mikro-uyumlu Pine şema (340+ tablo)

### 3. Blazor Uygulaması
- Gelen istek → subdomain/header'dan tenant tespit
- `DynamicDbContextFactory` ile doğru tenant DB'sine bağlanır
- Login'de Control Plane'den user doğrulama, sonra tenant DB'de yetki kontrolü

### 4. Provisioning Service
- REST API: `POST /api/tenant`
- Background job (Hangfire veya .NET Task): tenant DB oluştur, şema migrate et, seed ekle
- Hedef: **<10 saniye**

### 5. Audit Store (gelecek aşama)
- TimescaleDB veya ClickHouse ayrı cluster
- Tüm tenant'ların audit event'leri tek yerde (compliance, soruşturma)

## Tenant Yaşam Döngüsü

```
  [YENI]          [ACTIVE]         [SUSPENDED]        [DELETED]
 Provisioning  → DB hazır, kul   → Ödeme gecikti,  → 30 gün sonra
 başladı (5s)    lanıcı giriyor    DB read-only      DB drop edilir
```

## Scale Hedefleri

| Metrik | Hedef |
|---|---|
| Tenant sayısı | 10,000+ |
| Region başına DB | ~3,000 |
| Provisioning süresi | <10 sn |
| Tenant izolasyonu | Fiziksel (ayrı DB) |
| Data residency | Region-specific |
| SLA | %99.9 uptime |
| Backup | Her tenant bağımsız, nightly |

## Tech Stack

- **Backend:** ASP.NET Core 10, Blazor Server
- **ORM:** EF Core 10
- **DB:** Microsoft SQL Server 2022+ (each region)
- **Background jobs:** Hangfire veya built-in IHostedService
- **Cache:** Redis (session + tenant connection cache)
- **Proxy:** Cloudflare / Nginx (subdomain routing)
