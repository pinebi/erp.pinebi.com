# 04 · Provisioning API Sözleşmesi

Control Plane'in sunduğu REST API. Tenant yönetimi, kullanıcı davet,
abonelik yönetimi.

**Base URL:** `https://admin.pinebi.com/api/platform`
**Auth:** Bearer token (platform user JWT)

## Endpoints

### Tenant

#### `POST /tenants` · Yeni tenant oluştur
```
Request:
{
  "tenantCode": "ACME",           // string, 3-20 chars, unique
  "tenantName": "ACME Ltd.",      // string
  "subdomain": "acme",            // string, DNS-safe, unique
  "region": "tr",                 // 'tr'|'eu'|'us'
  "tier": "starter",              // tier_code
  "ownerEmail": "admin@acme.com",
  "ownerName": "Ahmet Yılmaz",
  "ownerPassword": "...",         // opsiyonel; yoksa davet maili gider
  "vergiNo": "1234567890",
  "ulkeKodu": "TR",
  "contactPhone": "+90..."
}

Response 202 Accepted:
{
  "tenantId": "guid",
  "status": "provisioning",
  "jobId": "guid",
  "subdomainUrl": "https://acme.erp.pinebi.com",
  "estimatedReadyAt": "2026-04-18T12:34:56Z"
}
```

#### `GET /tenants/{id}/status` · Provisioning durumu
```
Response:
{
  "tenantId": "guid",
  "status": "provisioning" | "active" | "suspended" | "deleted",
  "currentStep": "schema_migration",
  "progress": 0.65,
  "error": null
}
```

#### `GET /tenants` · Liste (sayfalı)
```
Query: ?status=active&region=tr&tier=pro&page=1&size=50
Response:
{
  "total": 1234,
  "page": 1,
  "items": [
    { "tenantId":"...", "tenantName":"...", "subdomain":"...", "status":"active", "tier":"pro", "region":"tr", "activatedAt":"..." },
    ...
  ]
}
```

#### `POST /tenants/{id}/suspend`
```
Request: { "reason": "Payment overdue" }
Response 200: { "status": "suspended", "suspendedAt": "..." }
```

#### `POST /tenants/{id}/reactivate`
```
Response 200: { "status": "active" }
```

#### `DELETE /tenants/{id}`
Soft delete → `deletion_pending`, 30 gün sonra gerçek silme.
```
Response 202: { "status":"deletion_pending", "scheduledDeleteAt":"..." }
```

#### `POST /tenants/{id}/change-tier`
```
Request: { "newTier": "pro", "effectiveDate": "2026-05-01" }
Response: { "subscriptionId": "...", "newTier": "pro" }
```

### Tenant Users

#### `POST /tenants/{tenantId}/users/invite`
```
Request:
{ "email": "ayse@acme.com", "role": "admin", "fullName": "Ayşe Yılmaz" }

Response 201:
{ "userId":"...", "inviteToken":"...", "inviteUrl":"https://..." }
```

#### `GET /tenants/{tenantId}/users`
Tenant'ın kullanıcılarını listele.

#### `DELETE /tenants/{tenantId}/users/{userId}`
Kullanıcıyı tenant'tan çıkar (`revoked_at` set).

### Regions

#### `GET /regions`
```
Response:
[
  { "id":"tr", "name":"Türkiye (İstanbul)", "active":true, "tenantCount":234, "capacity":3000 },
  ...
]
```

### Health & Ops

#### `GET /health`
```
{ "status":"healthy", "controlPlane":"ok", "regions": { "tr":"ok", "eu":"ok", "us":"degraded" } }
```

## Hata Kodları

| HTTP | Kod | Açıklama |
|---|---|---|
| 400 | `VALIDATION_FAILED` | Alan validasyonu |
| 400 | `SUBDOMAIN_TAKEN` | Subdomain kullanımda |
| 402 | `PAYMENT_REQUIRED` | Ödeme gerekli (tier upgrade için) |
| 404 | `TENANT_NOT_FOUND` | |
| 409 | `TENANT_EXISTS` | tenant_code zaten var |
| 423 | `REGION_AT_CAPACITY` | Bölge dolu, başka seç |
| 500 | `PROVISIONING_FAILED` | DB oluşturulamadı, retry cron'u devreye girer |

## Rate Limits

- `POST /tenants` → 5/dakika per platform user (spam koruması)
- `GET /*` → 100/dakika

## Webhook Olayları

Müşteri sistemlerine gönderilecek webhook'lar (opsiyonel):
- `tenant.activated`
- `tenant.suspended`
- `tenant.reactivated`
- `tenant.deleted`
- `subscription.upgraded`, `subscription.downgraded`, `subscription.payment_failed`

Payload:
```json
{
  "event": "tenant.activated",
  "tenantId": "guid",
  "timestamp": "...",
  "data": { ... }
}
```

İmza: HMAC-SHA256 header `X-Pinebi-Signature`.
