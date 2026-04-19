using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Mail;
using MACHINEBISS_Web.MultiTenant;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Pinebi Mail - per-user IMAP/SMTP mail istemcisi (Outlook style).
/// </summary>
[ApiController]
[Route("api/mail")]
public class MailController : ControllerBase
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    private readonly IConnectionStringProtector _protector;
    public MailController(IDbContextFactory<PineErpContext> factory, IConnectionStringProtector protector)
    {
        _factory = factory; _protector = protector;
    }

    // ===== HESAPLAR =====

    public class HesapDto
    {
        public Guid? AccountId { get; set; }
        public string Ad { get; set; } = "";
        public string Email { get; set; } = "";
        public string ImapHost { get; set; } = "";
        public int ImapPort { get; set; } = 993;
        public bool ImapSsl { get; set; } = true;
        public string ImapUser { get; set; } = "";
        public string? ImapPass { get; set; }
        public string SmtpHost { get; set; } = "";
        public int SmtpPort { get; set; } = 587;
        public bool SmtpSsl { get; set; } = true;
        public string SmtpUser { get; set; } = "";
        public string? SmtpPass { get; set; }
        public string? ImzaHtml { get; set; }
    }

    [HttpGet("hesaplar")]
    public async Task<IActionResult> Hesaplar()
    {
        using var db = await _factory.CreateDbContextAsync();
        var data = await db.MailAccounts.AsNoTracking().Where(a => a.Aktif)
            .Select(a => new { a.AccountId, a.Ad, a.Email, a.ImapHost, a.SmtpHost, a.ImzaHtml })
            .ToListAsync();
        return Ok(data);
    }

    [HttpPost("hesap")]
    public async Task<IActionResult> HesapKaydet([FromBody] HesapDto dto)
    {
        using var db = await _factory.CreateDbContextAsync();
        PineMailAccount acc;
        if (dto.AccountId == null || dto.AccountId == Guid.Empty)
        {
            acc = new PineMailAccount { AccountId = Guid.NewGuid() };
            db.MailAccounts.Add(acc);
        }
        else
        {
            acc = await db.MailAccounts.FirstOrDefaultAsync(a => a.AccountId == dto.AccountId)
                  ?? throw new KeyNotFoundException();
        }
        acc.Ad = dto.Ad; acc.Email = dto.Email;
        acc.ImapHost = dto.ImapHost; acc.ImapPort = dto.ImapPort; acc.ImapSsl = dto.ImapSsl;
        acc.ImapUser = dto.ImapUser;
        acc.SmtpHost = dto.SmtpHost; acc.SmtpPort = dto.SmtpPort; acc.SmtpSsl = dto.SmtpSsl;
        acc.SmtpUser = dto.SmtpUser;
        acc.ImzaHtml = dto.ImzaHtml;
        if (!string.IsNullOrEmpty(dto.ImapPass)) acc.ImapPassEnc = _protector.Protect(dto.ImapPass);
        if (!string.IsNullOrEmpty(dto.SmtpPass)) acc.SmtpPassEnc = _protector.Protect(dto.SmtpPass);
        await db.SaveChangesAsync();
        return Ok(new { acc.AccountId });
    }

    [HttpDelete("hesap/{id:guid}")]
    public async Task<IActionResult> HesapSil(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var acc = await db.MailAccounts.FirstOrDefaultAsync(a => a.AccountId == id);
        if (acc == null) return NotFound();
        acc.Aktif = false;
        await db.SaveChangesAsync();
        return Ok();
    }

    // ===== IMAP: KLASORLER =====

    [HttpGet("klasorler/{accountId:guid}")]
    public async Task<IActionResult> Klasorler(Guid accountId)
    {
        try
        {
            var acc = await GetAccountAsync(accountId);
            if (acc.ImapHost == "demo") return Ok(DemoData.Klasorler());
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));
            var folders = new List<object>();
            foreach (var f in (await client.GetFoldersAsync(client.PersonalNamespaces[0])).OrderBy(f => f.FullName))
            {
                try
                {
                    await f.OpenAsync(FolderAccess.ReadOnly);
                    folders.Add(new { name = f.Name, fullName = f.FullName, unread = f.Unread, total = f.Count });
                    await f.CloseAsync();
                }
                catch { folders.Add(new { name = f.Name, fullName = f.FullName, unread = 0, total = 0 }); }
            }
            await client.DisconnectAsync(true);
            return Ok(folders);
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== IMAP: MESAJ LISTESI =====

    [HttpGet("mesajlar/{accountId:guid}")]
    public async Task<IActionResult> Mesajlar(Guid accountId,
        [FromQuery] string folder = "INBOX", [FromQuery] int take = 50, [FromQuery] int skip = 0,
        [FromQuery] string? arama = null)
    {
        try
        {
            var acc = await GetAccountAsync(accountId);
            if (acc.ImapHost == "demo") return Ok(DemoData.Mesajlar(folder, arama));
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));

            var f = await client.GetFolderAsync(folder);
            await f.OpenAsync(FolderAccess.ReadOnly);

            IList<UniqueId> uids;
            if (!string.IsNullOrWhiteSpace(arama))
                uids = await f.SearchAsync(SearchQuery.BodyContains(arama).Or(SearchQuery.SubjectContains(arama)));
            else
                uids = await f.SearchAsync(SearchQuery.All);

            var total = uids.Count;
            // Son gelenler once (UID buyukten kucuge)
            var pageUids = uids.Reverse().Skip(skip).Take(take).ToList();

            var items = new List<object>();
            if (pageUids.Count > 0)
            {
                var summaries = await f.FetchAsync(pageUids,
                    MessageSummaryItems.Envelope | MessageSummaryItems.Flags | MessageSummaryItems.UniqueId
                    | MessageSummaryItems.BodyStructure | MessageSummaryItems.InternalDate);
                foreach (var s in summaries.OrderByDescending(x => x.Date))
                {
                    items.Add(new {
                        uid = s.UniqueId.Id,
                        konu = s.Envelope?.Subject,
                        gonderen = s.Envelope?.From?.ToString(),
                        alici = s.Envelope?.To?.ToString(),
                        tarih = s.Date.UtcDateTime,
                        okundu = (s.Flags ?? 0).HasFlag(MessageFlags.Seen),
                        cevaplandi = (s.Flags ?? 0).HasFlag(MessageFlags.Answered),
                        ekVar = (s.Attachments?.Any() == true),
                        ozet = OzetUret(s.Envelope?.Subject)
                    });
                }
            }
            await client.DisconnectAsync(true);
            return Ok(new { total, items });
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== IMAP: MESAJ DETAY =====

    [HttpGet("mesaj/{accountId:guid}/{folder}/{uid:long}")]
    public async Task<IActionResult> Mesaj(Guid accountId, string folder, uint uid)
    {
        try
        {
            var acc = await GetAccountAsync(accountId);
            if (acc.ImapHost == "demo") return Ok(DemoData.MesajDetay(uid));
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));

            var f = await client.GetFolderAsync(folder);
            await f.OpenAsync(FolderAccess.ReadWrite);
            var u = new UniqueId(uid);
            var msg = await f.GetMessageAsync(u);
            // Okundu isaretle
            try { await f.AddFlagsAsync(u, MessageFlags.Seen, true); } catch { }

            string html = msg.HtmlBody ?? ("<pre>" + System.Web.HttpUtility.HtmlEncode(msg.TextBody ?? "") + "</pre>");
            var ekler = msg.Attachments.OfType<MimePart>()
                .Select(p => new { ad = p.FileName, mime = p.ContentType.MimeType, contentId = p.ContentId })
                .ToList();

            await client.DisconnectAsync(true);
            return Ok(new {
                uid = u.Id,
                konu = msg.Subject,
                gonderen = msg.From.Mailboxes.Select(m => new { m.Name, m.Address }).ToList(),
                alici = msg.To.Mailboxes.Select(m => new { m.Name, m.Address }).ToList(),
                cc = msg.Cc.Mailboxes.Select(m => new { m.Name, m.Address }).ToList(),
                tarih = msg.Date.UtcDateTime,
                html,
                ekler
            });
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    [HttpDelete("mesaj/{accountId:guid}/{folder}/{uid:long}")]
    public async Task<IActionResult> MesajSil(Guid accountId, string folder, uint uid)
    {
        try
        {
            var acc = await GetAccountAsync(accountId);
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));
            var f = await client.GetFolderAsync(folder);
            await f.OpenAsync(FolderAccess.ReadWrite);
            await f.AddFlagsAsync(new UniqueId(uid), MessageFlags.Deleted, true);
            await f.ExpungeAsync();
            await client.DisconnectAsync(true);
            return Ok();
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== EK INDIR =====

    [HttpGet("ek/{accountId:guid}/{folder}/{uid:long}/{partIdx:int}")]
    public async Task<IActionResult> EkIndir(Guid accountId, string folder, uint uid, int partIdx)
    {
        try
        {
            var acc = await GetAccountAsync(accountId);
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));
            var f = await client.GetFolderAsync(folder);
            await f.OpenAsync(FolderAccess.ReadOnly);
            var msg = await f.GetMessageAsync(new UniqueId(uid));
            var parts = msg.Attachments.OfType<MimePart>().ToList();
            if (partIdx < 0 || partIdx >= parts.Count) return NotFound();
            var part = parts[partIdx];
            using var ms = new MemoryStream();
            await part.Content.DecodeToAsync(ms);
            await client.DisconnectAsync(true);
            ms.Position = 0;
            return File(ms.ToArray(), part.ContentType.MimeType, part.FileName ?? "ek");
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== YILDIZ / ISARETLE =====

    public class FlagDto { public Guid AccountId { get; set; } public string Folder { get; set; } = "INBOX"; public uint Uid { get; set; } public bool Yildiz { get; set; } }

    [HttpPost("yildiz")]
    public async Task<IActionResult> Yildiz([FromBody] FlagDto dto)
    {
        try
        {
            var acc = await GetAccountAsync(dto.AccountId);
            using var client = new ImapClient();
            await client.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await client.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));
            var f = await client.GetFolderAsync(dto.Folder);
            await f.OpenAsync(FolderAccess.ReadWrite);
            var u = new UniqueId(dto.Uid);
            if (dto.Yildiz) await f.AddFlagsAsync(u, MessageFlags.Flagged, true);
            else await f.RemoveFlagsAsync(u, MessageFlags.Flagged, true);
            await client.DisconnectAsync(true);
            return Ok();
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== SMTP: GONDER =====

    public class GondermeDto
    {
        public Guid AccountId { get; set; }
        public string Alici { get; set; } = "";        // virgul ayrilmis
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public string Konu { get; set; } = "";
        public string GovdeHtml { get; set; } = "";
    }

    [HttpPost("gonder")]
    [RequestSizeLimit(50_000_000)]
    public async Task<IActionResult> Gonder()
    {
        try
        {
            var form = await Request.ReadFormAsync();
            var accountId = Guid.Parse(form["AccountId"].ToString());
            var alici = form["Alici"].ToString();
            var cc = form["Cc"].ToString();
            var bcc = form["Bcc"].ToString();
            var konu = form["Konu"].ToString();
            var govdeHtml = form["GovdeHtml"].ToString();

            var acc = await GetAccountAsync(accountId);
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(acc.Ad, acc.Email));
            foreach (var a in (alici ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries))
                msg.To.Add(MailboxAddress.Parse(a.Trim()));
            foreach (var a in (cc ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries))
                msg.Cc.Add(MailboxAddress.Parse(a.Trim()));
            foreach (var a in (bcc ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries))
                msg.Bcc.Add(MailboxAddress.Parse(a.Trim()));
            msg.Subject = konu;
            var body = new BodyBuilder { HtmlBody = govdeHtml + (string.IsNullOrEmpty(acc.ImzaHtml) ? "" : "<br/><br/>" + acc.ImzaHtml) };
            foreach (var file in form.Files)
            {
                using var ms = new MemoryStream();
                await file.CopyToAsync(ms);
                body.Attachments.Add(file.FileName, ms.ToArray(),
                    MimeKit.ContentType.Parse(string.IsNullOrEmpty(file.ContentType) ? "application/octet-stream" : file.ContentType));
            }
            msg.Body = body.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(acc.SmtpHost, acc.SmtpPort,
                acc.SmtpSsl ? (acc.SmtpPort == 465 ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls) : SecureSocketOptions.Auto);
            await smtp.AuthenticateAsync(acc.SmtpUser, _protector.Unprotect(acc.SmtpPassEnc));
            await smtp.SendAsync(msg);
            await smtp.DisconnectAsync(true);

            // IMAP Sent klasorune kopyala (en iyi caba)
            try
            {
                using var imap = new ImapClient();
                await imap.ConnectAsync(acc.ImapHost, acc.ImapPort, acc.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
                await imap.AuthenticateAsync(acc.ImapUser, _protector.Unprotect(acc.ImapPassEnc));
                var sent = await imap.GetFolderAsync("Sent") ?? await imap.GetFolderAsync("Gonderilenler");
                if (sent != null) { await sent.OpenAsync(FolderAccess.ReadWrite); await sent.AppendAsync(msg); }
                await imap.DisconnectAsync(true);
            }
            catch { }

            return Ok();
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== TEST BAGLANTI =====

    [HttpPost("test-baglanti")]
    public async Task<IActionResult> TestBaglanti([FromBody] HesapDto dto)
    {
        try
        {
            using var imap = new ImapClient();
            await imap.ConnectAsync(dto.ImapHost, dto.ImapPort, dto.ImapSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.Auto);
            await imap.AuthenticateAsync(dto.ImapUser, dto.ImapPass ?? "");
            await imap.DisconnectAsync(true);

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(dto.SmtpHost, dto.SmtpPort,
                dto.SmtpSsl ? (dto.SmtpPort == 465 ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls) : SecureSocketOptions.Auto);
            await smtp.AuthenticateAsync(dto.SmtpUser, dto.SmtpPass ?? "");
            await smtp.DisconnectAsync(true);
            return Ok(new { ok = true });
        }
        catch (Exception ex) { return StatusCode(500, new { error = ex.Message }); }
    }

    // ===== HELPERS =====

    private async Task<PineMailAccount> GetAccountAsync(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var acc = await db.MailAccounts.AsNoTracking().FirstOrDefaultAsync(a => a.AccountId == id && a.Aktif)
                  ?? throw new KeyNotFoundException("HESAP_BULUNAMADI");
        return acc;
    }

    private static string? OzetUret(string? konu) =>
        string.IsNullOrWhiteSpace(konu) ? null : (konu.Length <= 120 ? konu : konu.Substring(0, 120));

    // ===== DEMO DATA =====
    private static class DemoData
    {
        public static object Klasorler() => new[]
        {
            new { name = "INBOX", fullName = "INBOX", unread = 4, total = 12 },
            new { name = "Sent", fullName = "Sent", unread = 0, total = 5 },
            new { name = "Drafts", fullName = "Drafts", unread = 0, total = 1 },
            new { name = "Trash", fullName = "Trash", unread = 0, total = 2 },
            new { name = "Spam", fullName = "Spam", unread = 2, total = 3 }
        };

        private static readonly (uint uid, string konu, string gonderen, int saatOnce, bool okundu, bool ekVar, string html)[] _inbox = new[]
        {
            (1001u, "Pinebi ERP - Haftalik performans raporu",        "Ayse Demir <ayse@pinebi.com>",       2,  false, true,  "<p>Merhaba,</p><p>Ektedir <b>haftalik rapor</b>. Satis hedeflerinin %112'si gerceklesti. Detay icin grafikleri inceleyebilirsiniz.</p><p>Iyi calismalar.</p>"),
            (1002u, "Stok uyarisi: Kritik seviye altinda 7 urun",      "Uyari Sistemi <uyari@pinebi.com>",    5,  false, false, "<div style='font-family:Arial'><h2 style='color:#dc2626'>Stok Uyarisi</h2><p>Asagidaki urunler minimum stok seviyesinin altina dustu:</p><ul><li>STK-001 Laptop Canta — <b>3 adet</b></li><li>STK-089 Klavye — <b>5 adet</b></li><li>STK-144 Mouse — <b>2 adet</b></li></ul><p><a href='#'>Siparis olustur</a></p></div>"),
            (1003u, "Toplanti notu: Mikro V16 migration",              "Mehmet Yilmaz <mehmet@firma.com>",   8,  true,  false, "<p>Selam,</p><p>Dunku toplantida konustugumuz 413 tablonun 380'i aktarildi. Kalan 33 tablo cok ozel referanslar iceriyor, manuel inceleme gerekli.</p><p>Not: backup 03:00'te calisti, 14 gun retention OK.</p>"),
            (1004u, "Yeni cari: SELCIN ONUR - DEEP FRESH",             "ERP Bildirim <noreply@pinebi.com>",   24, false, false, "<p>Yeni cari kaydi olusturuldu:</p><table style='border-collapse:collapse'><tr><td style='padding:4px 12px;background:#f1f5f9'>Kod</td><td style='padding:4px 12px'>320.02.00091</td></tr><tr><td style='padding:4px 12px;background:#f1f5f9'>Unvan</td><td style='padding:4px 12px'>SELCIN ONUR - DEEP FRESH-FAIRY</td></tr></table>"),
            (1005u, "Fatura tahsilati onaylandi #2026-0114",           "Muhasebe <muhasebe@pinebi.com>",     28, true,  true,  "<p>Sayin yetkili,</p><p>2026-0114 numarali faturanizin tahsilati <b>150.000 TL</b> olarak hesabiniza gecmistir.</p>"),
            (1006u, "Pinebi SaaS aboneligi: Enterprise plan aktif",     "Pinebi Satis <satis@pinebi.com>",    30, true,  false, "<p>Merhaba,</p><p>Enterprise plan aboneliginiz aktiflestirildi. Artik:</p><ul><li>Sinirsiz kullanici</li><li>Gunluk otomatik yedek</li><li>7/24 destek</li><li>Ozel SLA</li></ul><p>Yardima ihtiyaciniz olursa bize yazmaktan cekinmeyin.</p>"),
            (1007u, "Sifirlama: admin@pinebi.com sifresi sifirlandi",   "Guvenlik <security@pinebi.com>",     36, true,  false, "<p>Hesabinizin sifresi 19 Nisan 2026 14:03'te sifirlandi. Bu islemi siz yapmadiysaniz lutfen hemen bize ulasin.</p>"),
            (1008u, "E-Fatura gonderiminiz basarili",                   "GIB <noreply@gib.gov.tr>",           48, true,  true,  "<p>Fatura numarasi: ABC2026000001234<br/>Durum: <b>ONAYLANDI</b><br/>Tarih: 17.04.2026 16:22</p>"),
            (1009u, "Toplanti daveti: Pinebi ile ERP Toplantisi",       "Takvim <takvim@pinebi.com>",         60, true,  true,  "<p>Saat: 14 Nis Sali 12:00 - 12:30<br/>Katilimci: Mehmet, Ayse, Admin<br/>Konum: Toplanti Odasi 1</p>"),
            (1010u, "Kargo bilgi: ARAS 2026041712345",                  "Aras Kargo <bilgi@araskargo.com>",   72, true,  false, "<p>Kargonuz teslim edildi. Alici: Ahmet Kaya, 17.04.2026 15:32.</p>"),
            (1011u, "Aylik analiz: Nisan 2026 satis ozet",               "Analitik <bi@pinebi.com>",           96, true,  true,  "<p>Gecen aya gore ciro <b>%23 arti</b>, yeni musteri <b>47 kisi</b>. Detay: pano linki.</p>"),
            (1012u, "Guncelleme notu: Pinebi 4.7 yayinlandi",            "Pinebi Urun <urun@pinebi.com>",     120, true,  false, "<p>Yeni: 413 Mikro tablosu, E-Fatura, SMS gonderim, vardiya takibi.</p>")
        };

        public static object Mesajlar(string folder, string? arama)
        {
            var simdi = DateTime.UtcNow;
            var items = _inbox.Where(m => string.IsNullOrWhiteSpace(arama) || (m.konu ?? "").Contains(arama, StringComparison.OrdinalIgnoreCase))
                .Select(m => new {
                    uid = m.uid,
                    konu = m.konu,
                    gonderen = m.gonderen,
                    alici = "admin@pinebi.com",
                    tarih = simdi.AddHours(-m.saatOnce),
                    okundu = m.okundu,
                    cevaplandi = false,
                    ekVar = m.ekVar,
                    ozet = m.konu
                }).ToList();
            return new { total = items.Count, items };
        }

        public static object MesajDetay(uint uid)
        {
            var m = _inbox.FirstOrDefault(x => x.uid == uid);
            if (m.konu == null) m = _inbox[0];
            var parts = m.gonderen.Split('<');
            var ad = parts.Length > 1 ? parts[0].Trim() : m.gonderen;
            var adres = parts.Length > 1 ? parts[1].TrimEnd('>') : m.gonderen;
            return new {
                uid,
                konu = m.konu,
                gonderen = new[] { new { Name = ad, Address = adres } },
                alici = new[] { new { Name = "Admin", Address = "admin@pinebi.com" } },
                cc = Array.Empty<object>(),
                tarih = DateTime.UtcNow.AddHours(-m.saatOnce),
                html = m.html,
                ekler = m.ekVar ? new[] { new { ad = "rapor.pdf", mime = "application/pdf", contentId = (string?)null } } : Array.Empty<object>()
            };
        }
    }
}
