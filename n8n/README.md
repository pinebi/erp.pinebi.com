# Pinebi ERP × n8n AI Ekibi

Bu klasörde n8n'e import edilecek workflow'lar var. Ekip:

- **Genel Müdür** (genel-mudur.json) — tüm iletişimin giriş noktası. Chat'ten komut alır, uzman ajanlara delege eder, sonuçları onaylar.
- **Stok/Cari Yöneticisi** (stok-cari-agent.json) — stok ve cari kartlarını yönetir, hataları tespit eder.
- **Muhasebe** (muhasebe-agent.json) — fatura girişi ve doğrulama.
- **Sipariş Yönetimi** (siparis-agent.json) — sipariş süreçleri.
- **Piyasa Analizcisi** (piyasa-analiz-agent.json) — piyasa araştırması ve kıyaslama.

## Kurulum

1. n8n'de **Credentials** → **+ New** → **OpenAI** (veya **Anthropic Claude**) seç, API key gir.
2. Workflow'ları sırayla import et:
   - Her `.json` için: **Workflows** → **+ New** → ⋯ → **Import from File**
   - Önce uzman ajanlar, sonra Genel Müdür (çünkü Genel Müdür diğerlerini tool olarak kullanır)
3. Import edilen her workflow'u aç, **AI Agent** node'unun **Model** alanından credential'ı seç.
4. **Genel Müdür** workflow'unda **Chat Trigger** → "Open Chat" ile ekibi dene.

## Güvenlik notu

Şu anda ERP API'sinde auth yok — n8n doğrudan `https://erp.pinebi.com/api/*` çağırabiliyor.
Production'da API key header (örn. `X-Api-Key`) eklenmeli, n8n credential olarak saklanmalı.

## Örnek kullanım (Chat)

```
Sen: Stok kontrolünü yap, eksik barkodu olan kartları bul.
Genel Müdür: (Stok/Cari ajanına delege eder) ...
```

```
Sen: Bugünkü satış faturalarını özetle ve hatalı olanları listele.
Genel Müdür: (Muhasebe ajanına delege eder) ...
```
