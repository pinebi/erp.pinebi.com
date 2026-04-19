using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Takvim;

[Table("pine_calendars")]
public class PineCalendar
{
    [Key] [Column("calendar_id")]     public Guid CalendarId { get; set; } = Guid.NewGuid();
    [Column("owner_user_id")]   public Guid? OwnerUserId { get; set; }
    [Column("ad")]              public string Ad { get; set; } = "";
    [Column("renk")]            public string Renk { get; set; } = "#3b82f6";
    [Column("tip")]             public string Tip { get; set; } = "kisisel";
    [Column("aciklama")]        public string? Aciklama { get; set; }
    [Column("olusturulma")]     public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
    [Column("aktif")]           public bool Aktif { get; set; } = true;
}

[Table("pine_calendar_shares")]
public class PineCalendarShare
{
    [Key] [Column("share_id")]         public Guid ShareId { get; set; } = Guid.NewGuid();
    [Column("calendar_id")]      public Guid CalendarId { get; set; }
    [Column("paylasim_user_id")] public Guid PaylasimUserId { get; set; }
    [Column("yetki")]            public string Yetki { get; set; } = "goruntule";
    [Column("olusturulma")]      public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
}

[Table("pine_rooms")]
public class PineRoom
{
    [Key] [Column("room_id")]  public Guid RoomId { get; set; } = Guid.NewGuid();
    [Column("ad")]       public string Ad { get; set; } = "";
    [Column("kapasite")] public int? Kapasite { get; set; }
    [Column("konum")]    public string? Konum { get; set; }
    [Column("renk")]     public string Renk { get; set; } = "#8b5cf6";
    [Column("aktif")]    public bool Aktif { get; set; } = true;
}

[Table("pine_events")]
public class PineEvent
{
    [Key] [Column("event_id")]    public Guid EventId { get; set; } = Guid.NewGuid();
    [Column("calendar_id")]       public Guid CalendarId { get; set; }
    [Column("baslik")]            public string Baslik { get; set; } = "";
    [Column("aciklama")]          public string? Aciklama { get; set; }
    [Column("baslangic")]         public DateTime Baslangic { get; set; }
    [Column("bitis")]             public DateTime Bitis { get; set; }
    [Column("tum_gun")]           public bool TumGun { get; set; }
    [Column("konum")]             public string? Konum { get; set; }
    [Column("renk")]              public string? Renk { get; set; }
    [Column("cari_kod")]          public string? CariKod { get; set; }
    [Column("proje_id")]          public Guid? ProjeId { get; set; }
    [Column("room_id")]           public Guid? RoomId { get; set; }
    [Column("olusturan_user_id")] public Guid? OlusturanUserId { get; set; }
    [Column("olusturulma")]       public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
    [Column("guncellenme")]       public DateTime? Guncellenme { get; set; }
    [Column("iptal")]             public bool Iptal { get; set; }
}

[Table("pine_event_participants")]
public class PineEventParticipant
{
    [Key] [Column("participant_id")] public Guid ParticipantId { get; set; } = Guid.NewGuid();
    [Column("event_id")]       public Guid EventId { get; set; }
    [Column("user_id")]        public Guid UserId { get; set; }
    [Column("email")]          public string? Email { get; set; }
    [Column("zorunlu")]        public bool Zorunlu { get; set; } = true;
    [Column("yanit")]          public string Yanit { get; set; } = "beklemede";
    [Column("yanit_tarih")]    public DateTime? YanitTarih { get; set; }
}

[Table("pine_event_reminders")]
public class PineEventReminder
{
    [Key] [Column("reminder_id")] public Guid ReminderId { get; set; } = Guid.NewGuid();
    [Column("event_id")]    public Guid EventId { get; set; }
    [Column("user_id")]     public Guid? UserId { get; set; }
    [Column("dakika_once")] public int DakikaOnce { get; set; } = 15;
    [Column("kanal")]       public string Kanal { get; set; } = "email";
    [Column("gonderildi")]  public bool Gonderildi { get; set; }
}
