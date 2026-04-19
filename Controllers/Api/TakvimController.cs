using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Takvim;
using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Pinebi Takvim & Toplanti modulu API.
/// </summary>
[ApiController]
[Route("api/takvim")]
public class TakvimController : ControllerBase
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    private readonly IEmailService? _email;
    public TakvimController(IDbContextFactory<PineErpContext> factory, IEmailService? email = null)
    {
        _factory = factory; _email = email;
    }

    // ===== TAKVIMLER =====

    [HttpGet("takvimler")]
    public async Task<IActionResult> Takvimler([FromQuery] Guid? userId = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var q = db.Calendars.AsNoTracking().Where(c => c.Aktif);
        if (userId.HasValue)
            q = q.Where(c => c.OwnerUserId == userId || c.Tip == "kaynak"
                || db.CalendarShares.Any(s => s.CalendarId == c.CalendarId && s.PaylasimUserId == userId));
        var items = await q.OrderBy(c => c.Tip).ThenBy(c => c.Ad).ToListAsync();
        return Ok(items);
    }

    [HttpPost("takvim")]
    public async Task<IActionResult> TakvimOlustur([FromBody] PineCalendar model)
    {
        using var db = await _factory.CreateDbContextAsync();
        model.CalendarId = Guid.NewGuid();
        model.Olusturulma = DateTime.UtcNow;
        db.Calendars.Add(model);
        await db.SaveChangesAsync();
        return Ok(model);
    }

    [HttpPost("takvim/{id}/paylas")]
    public async Task<IActionResult> Paylas(Guid id, [FromBody] PineCalendarShare s)
    {
        using var db = await _factory.CreateDbContextAsync();
        s.ShareId = Guid.NewGuid();
        s.CalendarId = id;
        s.Olusturulma = DateTime.UtcNow;
        db.CalendarShares.Add(s);
        await db.SaveChangesAsync();
        return Ok(s);
    }

    // ===== ETKINLIKLER =====

    [HttpGet("etkinlikler")]
    public async Task<IActionResult> Etkinlikler(
        [FromQuery] DateTime start, [FromQuery] DateTime end,
        [FromQuery] string? calendarIds = null)
    {
        using var db = await _factory.CreateDbContextAsync();
        var q = db.Events.AsNoTracking()
            .Where(e => !e.Iptal && e.Bitis > start && e.Baslangic < end);

        if (!string.IsNullOrWhiteSpace(calendarIds))
        {
            var ids = calendarIds.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Guid.Parse).ToArray();
            q = q.Where(e => ids.Contains(e.CalendarId));
        }

        var data = await q.Select(e => new {
            id = e.EventId,
            calendarId = e.CalendarId,
            title = e.Baslik,
            start = e.Baslangic,
            end = e.Bitis,
            allDay = e.TumGun,
            color = e.Renk,
            location = e.Konum,
            cariKod = e.CariKod,
            projeId = e.ProjeId,
            roomId = e.RoomId
        }).ToListAsync();
        return Ok(data);
    }

    public class EventDto
    {
        public Guid? EventId { get; set; }
        public Guid CalendarId { get; set; }
        public string Baslik { get; set; } = "";
        public string? Aciklama { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public bool TumGun { get; set; }
        public string? Konum { get; set; }
        public string? Renk { get; set; }
        public string? CariKod { get; set; }
        public Guid? ProjeId { get; set; }
        public Guid? RoomId { get; set; }
        public List<ParticipantDto>? Katilimcilar { get; set; }
    }
    public class ParticipantDto
    {
        public Guid UserId { get; set; }
        public string? Email { get; set; }
        public bool Zorunlu { get; set; } = true;
    }

    [HttpPost("etkinlik")]
    public async Task<IActionResult> EtkinlikKaydet([FromBody] EventDto dto)
    {
        if (dto.Bitis <= dto.Baslangic)
            return BadRequest(new { error = "BITIS_BASLANGICTAN_SONRA_OLMALI" });

        using var db = await _factory.CreateDbContextAsync();

        // Oda cakisma kontrolu
        if (dto.RoomId.HasValue)
        {
            var cakisma = await db.Events.AnyAsync(e =>
                !e.Iptal && e.RoomId == dto.RoomId &&
                (dto.EventId == null || e.EventId != dto.EventId) &&
                e.Bitis > dto.Baslangic && e.Baslangic < dto.Bitis);
            if (cakisma) return Conflict(new { error = "ODA_DOLU", detay = "Secilen oda bu saatte baska etkinlikte kullaniliyor." });
        }

        PineEvent ev;
        bool yeni = dto.EventId == null || dto.EventId == Guid.Empty;
        if (yeni)
        {
            ev = new PineEvent { EventId = Guid.NewGuid(), Olusturulma = DateTime.UtcNow };
            db.Events.Add(ev);
        }
        else
        {
            ev = await db.Events.FirstOrDefaultAsync(e => e.EventId == dto.EventId!.Value)
                 ?? throw new KeyNotFoundException();
            ev.Guncellenme = DateTime.UtcNow;
        }

        ev.CalendarId = dto.CalendarId;
        ev.Baslik = dto.Baslik;
        ev.Aciklama = dto.Aciklama;
        ev.Baslangic = dto.Baslangic;
        ev.Bitis = dto.Bitis;
        ev.TumGun = dto.TumGun;
        ev.Konum = dto.Konum;
        ev.Renk = dto.Renk;
        ev.CariKod = dto.CariKod;
        ev.ProjeId = dto.ProjeId;
        ev.RoomId = dto.RoomId;

        await db.SaveChangesAsync();

        if (dto.Katilimcilar != null)
        {
            var eskiler = db.EventParticipants.Where(p => p.EventId == ev.EventId);
            db.EventParticipants.RemoveRange(eskiler);
            foreach (var k in dto.Katilimcilar)
            {
                db.EventParticipants.Add(new PineEventParticipant {
                    ParticipantId = Guid.NewGuid(),
                    EventId = ev.EventId,
                    UserId = k.UserId,
                    Email = k.Email,
                    Zorunlu = k.Zorunlu,
                    Yanit = "beklemede"
                });
            }
            await db.SaveChangesAsync();

            // ICS + email davet (en iyi caba — basarisiz olursa sessizce gec)
            if (_email != null)
            {
                foreach (var k in dto.Katilimcilar.Where(x => !string.IsNullOrWhiteSpace(x.Email)))
                {
                    try
                    {
                        var ics = BuildIcs(ev, dto.Katilimcilar);
                        var body = $"<p><b>{ev.Baslik}</b></p><p>{ev.Baslangic:yyyy-MM-dd HH:mm} - {ev.Bitis:HH:mm}</p><p>{ev.Aciklama}</p>";
                        await _email.SendAsync(k.Email!, $"Toplanti Daveti: {ev.Baslik}", body);
                    }
                    catch { }
                }
            }
        }

        return Ok(new { ev.EventId });
    }

    [HttpDelete("etkinlik/{id:guid}")]
    public async Task<IActionResult> EtkinlikSil(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var ev = await db.Events.FirstOrDefaultAsync(e => e.EventId == id);
        if (ev == null) return NotFound();
        ev.Iptal = true;
        ev.Guncellenme = DateTime.UtcNow;
        await db.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("etkinlik/{id:guid}")]
    public async Task<IActionResult> EtkinlikDetay(Guid id)
    {
        using var db = await _factory.CreateDbContextAsync();
        var ev = await db.Events.AsNoTracking().FirstOrDefaultAsync(e => e.EventId == id);
        if (ev == null) return NotFound();
        var k = await db.EventParticipants.AsNoTracking().Where(p => p.EventId == id).ToListAsync();
        return Ok(new { ev, katilimcilar = k });
    }

    [HttpPost("etkinlik/{id:guid}/yanit")]
    public async Task<IActionResult> Yanit(Guid id, [FromQuery] Guid userId, [FromQuery] string yanit)
    {
        using var db = await _factory.CreateDbContextAsync();
        var p = await db.EventParticipants.FirstOrDefaultAsync(x => x.EventId == id && x.UserId == userId);
        if (p == null) return NotFound();
        p.Yanit = yanit;
        p.YanitTarih = DateTime.UtcNow;
        await db.SaveChangesAsync();
        return Ok();
    }

    // ===== AKILLI SAAT ONERISI =====

    public class UygunSaatIstek
    {
        public DateTime AraligiBaslat { get; set; }
        public DateTime AraligiBitir { get; set; }
        public int DakikaSure { get; set; } = 30;
        public List<Guid> UserIds { get; set; } = new();
        public Guid? RoomId { get; set; }
        public int CalismaSaatiBaslangic { get; set; } = 9;
        public int CalismaSaatiBitis { get; set; } = 18;
    }

    /// <summary>
    /// Katilimci ve oda uygunluguna gore ilk 10 uygun saat dilimini doner.
    /// </summary>
    [HttpPost("uygun-saat")]
    public async Task<IActionResult> UygunSaat([FromBody] UygunSaatIstek req)
    {
        using var db = await _factory.CreateDbContextAsync();

        // Tum mesguliyetler (kullanici + oda)
        var mesgul = await db.Events.AsNoTracking()
            .Where(e => !e.Iptal && e.Bitis > req.AraligiBaslat && e.Baslangic < req.AraligiBitir)
            .Select(e => new { e.EventId, e.Baslangic, e.Bitis, e.RoomId })
            .ToListAsync();

        var katilimMesgul = await db.EventParticipants.AsNoTracking()
            .Where(p => req.UserIds.Contains(p.UserId) && p.Yanit != "red")
            .Join(db.Events, p => p.EventId, e => e.EventId, (p, e) => new { e.Baslangic, e.Bitis })
            .Where(x => x.Bitis > req.AraligiBaslat && x.Baslangic < req.AraligiBitir)
            .ToListAsync();

        var bloklar = mesgul
            .Where(m => req.RoomId.HasValue && m.RoomId == req.RoomId)
            .Select(m => (m.Baslangic, m.Bitis))
            .Concat(katilimMesgul.Select(k => (k.Baslangic, k.Bitis)))
            .OrderBy(x => x.Item1)
            .ToList();

        var oneriler = new List<object>();
        var adim = TimeSpan.FromMinutes(30);
        var sure = TimeSpan.FromMinutes(req.DakikaSure);
        var t = req.AraligiBaslat;

        while (t.AddMinutes(req.DakikaSure) <= req.AraligiBitir && oneriler.Count < 10)
        {
            if (t.Hour < req.CalismaSaatiBaslangic || t.AddMinutes(req.DakikaSure).Hour > req.CalismaSaatiBitis
                || t.DayOfWeek == DayOfWeek.Saturday || t.DayOfWeek == DayOfWeek.Sunday)
            {
                t = t.Add(adim); continue;
            }

            var bitis = t.Add(sure);
            bool cakisiyor = bloklar.Any(b => b.Item2 > t && b.Item1 < bitis);
            if (!cakisiyor)
                oneriler.Add(new { baslangic = t, bitis });
            t = t.Add(adim);
        }

        return Ok(new { oneriler });
    }

    // ===== ODALAR =====

    [HttpGet("odalar")]
    public async Task<IActionResult> Odalar()
    {
        using var db = await _factory.CreateDbContextAsync();
        return Ok(await db.Rooms.AsNoTracking().Where(r => r.Aktif).OrderBy(r => r.Ad).ToListAsync());
    }

    [HttpPost("oda")]
    public async Task<IActionResult> OdaOlustur([FromBody] PineRoom r)
    {
        using var db = await _factory.CreateDbContextAsync();
        r.RoomId = Guid.NewGuid();
        db.Rooms.Add(r);
        await db.SaveChangesAsync();
        return Ok(r);
    }

    // ===== ICS =====

    private static string BuildIcs(PineEvent ev, List<ParticipantDto> katilimcilar)
    {
        string Fmt(DateTime d) => d.ToUniversalTime().ToString("yyyyMMddTHHmmssZ");
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("BEGIN:VCALENDAR");
        sb.AppendLine("VERSION:2.0");
        sb.AppendLine("PRODID:-//Pinebi ERP//Takvim//TR");
        sb.AppendLine("METHOD:REQUEST");
        sb.AppendLine("BEGIN:VEVENT");
        sb.AppendLine($"UID:{ev.EventId}@pinebi.com");
        sb.AppendLine($"DTSTAMP:{Fmt(DateTime.UtcNow)}");
        sb.AppendLine($"DTSTART:{Fmt(ev.Baslangic)}");
        sb.AppendLine($"DTEND:{Fmt(ev.Bitis)}");
        sb.AppendLine($"SUMMARY:{ev.Baslik}");
        if (!string.IsNullOrEmpty(ev.Konum)) sb.AppendLine($"LOCATION:{ev.Konum}");
        if (!string.IsNullOrEmpty(ev.Aciklama)) sb.AppendLine($"DESCRIPTION:{ev.Aciklama?.Replace("\n","\\n")}");
        foreach (var k in katilimcilar.Where(x => !string.IsNullOrWhiteSpace(x.Email)))
            sb.AppendLine($"ATTENDEE;RSVP=TRUE:mailto:{k.Email}");
        sb.AppendLine("END:VEVENT");
        sb.AppendLine("END:VCALENDAR");
        return sb.ToString();
    }
}
