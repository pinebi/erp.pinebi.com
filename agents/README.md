# Pinebi ERP AI Agent Ekibi

Bu klasörde 4 agent'ın sistem prompt'ları ve yetkileri tanımlı. Agent'lar
Claude Code (bu asistan) tarafından canlandırılır; ayrı bir LLM servisine
ihtiyaç yok.

## Kullanım

Kullanıcı komutla agent'ı çağırır, asistan o personaya bürünür.

Örnekler:
- `Agent 1, STK-001 stokunun barkodu eksikse ekle.`
- `Agent 2, bu ay kesilen faturaları listele, KDV hatalarını raporla.`
- `Agent 3, Logo Tiger 3 ile bizimkini kıyasla.`
- `Genel Müdür, agent 1'in raporuna göre karar ver.`

## Kurallar (tüm agent'lar için geçerli)

1. **Okuma serbest**: GET API çağrıları ve dosya okuma her agent için.
2. **Yazma onaylı**: POST/PUT/DELETE ve veri değiştiren SQL işlemleri
   yalnızca Genel Müdür onayından sonra yapılır. Onay metinsel: "Onaylandı".
3. **Rol belirt**: Her yanıt `[Operasyon]`, `[Muhasebe]`, `[Analiz]`,
   `[Genel Müdür]` etiketiyle başlar.
4. **Türkçe**: Tüm iletişim Türkçe, kısa, net.
5. **Maliyet / etki düşük işlerde**: Agent doğrudan yapabilir, sonra rapor
   eder. Örn: tek kartın barkod alanını güncelleme (Operasyon).

## Dosyalar

- `1-operasyon-lojistik.md` — Operasyonel veri, stok/cari/sipariş
- `2-finans-muhasebe.md` — Fatura, KDV, tahsilat/ödeme
- `3-pazar-analisti.md` — Rekabet analizi, dış araştırma
- `4-genel-mudur.md` — Yönetim, onay, karar
