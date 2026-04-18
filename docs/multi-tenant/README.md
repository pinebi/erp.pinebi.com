# Pinebi Multi-Tenant Mimari — Aşama 1 Dokümantasyonu

Bu klasördeki 5 doküman, Pinebi ERP'nin global ölçekte multi-tenant
yapıya geçişinin temel plan ve tasarımını içerir.

| # | Doküman | İçerik |
|---|---|---|
| 01 | [mimari.md](01-mimari.md) | Genel mimari, diyagram, tech stack |
| 02 | [control-plane-schema.sql](02-control-plane-schema.sql) | Master DB tablo şemaları |
| 03 | [tenant-yasam-dongusu.md](03-tenant-yasam-dongusu.md) | Provisioning, suspend, delete akışları |
| 04 | [provisioning-api.md](04-provisioning-api.md) | REST API sözleşmesi |
| 05 | [kod-iskelet.md](05-kod-iskelet.md) | C# implementasyon iskeletleri |

## Seçilen Strateji (özet)

- **Database-per-Tenant** (her firma ayrı SQL DB)
- **Regional Sharding** (TR / EU / US cluster'ları)
- **Central Control Plane** (`Pinebi_Master` - tenant metadata)
- **Template DB restore** ile 2-3 saniyede provisioning
- **Subdomain routing** (`acme.erp.pinebi.com` → tenant 'acme')

## Aşama Planı

### ✅ Aşama 1: Dokümantasyon (bu klasör)
- Mimari, şema, API, kod iskeleti

### ⏭ Aşama 2: Control Plane DB + Dynamic Connection
1. `Pinebi_Master` DB'yi oluştur (02-control-plane-schema.sql)
2. Ortak veri yükle (ülkeler, para birimleri)
3. `TenantContext`, `TenantResolver`, `TenantMiddleware` kodla
4. `ITenantDbContextFactory` ekle
5. Mevcut `PineERP` DB'sini tek tenant olarak migrate et
6. Subdomain routing test (Cloudflare wildcard)

### ⏭ Aşama 3: Provisioning API
1. `POST /api/platform/tenants` endpoint
2. Background job worker (IHostedService / Hangfire)
3. Template DB stratejisi (template backup + restore script)
4. Seed data (default roller, sistem ayarları)

### ⏭ Aşama 4: Mikro Şema Geçişi
1. `PineERP_Yeni` (413 Mikro tablosu) template olarak kullan
2. EF Core entity'lerini Mikro şemasına göre yeniden üret
3. Mevcut veriyi migration script ile taşı

### ⏭ Aşama 5: Production Hardening
1. Encryption: connection string, Azure Key Vault
2. Audit log (TimescaleDB / ClickHouse)
3. Quota/rate limit enforcement
4. Monitoring (Prometheus + Grafana)
5. Backup otomasyonu (her tenant gecelik)
