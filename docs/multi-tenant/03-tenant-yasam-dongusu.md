# 03 · Tenant Yaşam Döngüsü

## Durum Makinesi

```
  ┌──────────────┐
  │ provisioning │  tenant kaydı oluştu, DB hazırlanıyor
  └──────┬───────┘
         │  (DB hazır, şema migrate edildi)
         ▼
  ┌──────────────┐
  │    active    │  tenant kullanıcıları giriş yapabilir, yazma serbest
  └──────┬───────┘
         │  (ödeme gecikti / manuel suspend)
         ▼
  ┌──────────────┐
  │  suspended   │  giriş serbest, DB read-only, yeni işlem engellendi
  └──────┬───────┘
         │  (ödeme yapıldı → active)
         │  (30 gün sonra → deletion_pending)
         ▼
  ┌──────────────┐
  │   deleted    │  DB drop edildi, sadece audit kaldı
  └──────────────┘
```

## Provisioning (tenant oluşturma) Akışı

**Giriş:** `POST /api/platform/tenants` (Pinebi_Master'a)
```json
{
  "tenantCode": "ACME",
  "tenantName": "ACME Ltd.",
  "subdomain": "acme",
  "region": "tr",
  "tier": "starter",
  "ownerEmail": "admin@acme.com",
  "ownerName": "Ahmet Yılmaz",
  "vergiNo": "1234567890"
}
```

**Adımlar** (hedef <10 saniye):

| # | Adım | Süre |
|---|---|---|
| 1 | Validasyon: subdomain müsait mi, region aktif mi, tier geçerli mi | ~20ms |
| 2 | `tenants` tablosuna satır ekle (`status='provisioning'`) | ~30ms |
| 3 | `provisioning_jobs`'a job kaydı (`status='pending'`) | ~30ms |
| 4 | Background worker tetikle (Hangfire / IHostedService) | hemen |
| 5 | **Arka planda:** | |
| 5a | Region'daki SQL Server'a bağlan, `CREATE DATABASE pinebi_tenant_XXXX` | ~1-2s |
| 5b | **Hızlı yol:** `pinebi_template` DB'sinden BACKUP/RESTORE | ~2-3s |
| 5c | Pine şema migration'ını çalıştır (EF migrate veya SQL script) | ~3-5s |
| 5d | Seed data: default roller, döviz kurları snapshot, sistem ayarları | ~500ms |
| 5e | Tenant owner user'ı oluştur, davet maili gönder | ~200ms |
| 5f | `tenant_connections` şifrelenmiş connection string yaz | ~50ms |
| 5g | `tenants.status='active'`, `activated_at=NOW` | ~30ms |
| 6 | Audit event: `tenant.created` | ~30ms |
| 7 | Webhook / mail: owner'a "hesabın hazır" bildirimi | ~200ms |

**Template DB stratejisi (en hızlı):**

Her region'da bir `pinebi_template` DB vardır. Pine şeması + seed verisi yüklüdür.
Yeni tenant oluştururken:

```sql
BACKUP DATABASE pinebi_template TO DISK = 'C:\tmp\template.bak' WITH COPY_ONLY, INIT;
RESTORE DATABASE pinebi_tenant_XXXX FROM DISK = 'C:\tmp\template.bak'
  WITH MOVE 'template' TO 'D:\SQL\tenant_XXXX.mdf',
       MOVE 'template_log' TO 'D:\SQL\tenant_XXXX_log.ldf';
```

Bu yöntem 2-3 saniye sürer. EF migration'ı baştan koşmaktan 5x hızlıdır.

## Suspension

**Tetikleyiciler:**
- Ödeme gecikmesi (`next_billing_at` geçti, provider 'past_due')
- Manuel: platform admin `POST /api/platform/tenants/{id}/suspend`
- Usage quota aşımı (tier limit)

**Aksiyon:**
1. `tenants.status='suspended'`, `suspended_at=NOW`
2. Tenant DB'sine read-only kullanıcı set et (dokümantasyon değişikliği yapılamaz)
3. Audit event: `tenant.suspended`
4. Owner'a mail: "Hesabınız askıya alındı, ödeme yaparsanız 30 gün içinde açılır"

## Deletion

**Akış:**
1. Suspended durumda 30 gün → `deletion_pending`
2. 7 gün önceden uyarı maili
3. `deletion_pending` + 7 gün → gerçek silme:
   - `BACKUP DATABASE pinebi_tenant_XXXX TO ... (uzun vadeli arşiv)`
   - `DROP DATABASE pinebi_tenant_XXXX`
   - `tenants.status='deleted'`, `deleted_at=NOW`
   - `tenant_connections` satırı silinir
4. Audit event: `tenant.deleted`

**Backup retention:** Silinmiş tenant yedekleri 7 yıl (TR muhasebe kanunu).

## Reaktivasyon

Suspend → Active:
1. Ödeme alındı webhook'u veya manuel
2. Tenant DB'yi read-write moda al
3. `tenants.status='active'`, `suspended_at=NULL`
4. Audit event: `tenant.reactivated`

Deleted → ❌ geri getirilemez (sadece yeni tenant oluşturulabilir, backup'tan manuel restore işlemi DevOps sürecidir).

## Quota Kontrolü

Her yazma işleminde (fatura, stok hareketi) background job:
- Tenant'ın tier limit'ini aşıyor mu?
- Aşıyorsa: kullanıcıya uyarı + log

Aşım durumunda hard-block değil, soft-warning. Platform admin ile müşteri muhatap.
