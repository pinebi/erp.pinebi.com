using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Mail;

[Table("pine_mail_accounts")]
public class PineMailAccount
{
    [Key] [Column("account_id")] public Guid AccountId { get; set; } = Guid.NewGuid();
    [Column("user_id")]       public Guid? UserId { get; set; }
    [Column("ad")]            public string Ad { get; set; } = "";
    [Column("email")]         public string Email { get; set; } = "";
    [Column("imap_host")]     public string ImapHost { get; set; } = "";
    [Column("imap_port")]     public int ImapPort { get; set; } = 993;
    [Column("imap_ssl")]      public bool ImapSsl { get; set; } = true;
    [Column("imap_user")]     public string ImapUser { get; set; } = "";
    [Column("imap_pass_enc")] public string ImapPassEnc { get; set; } = "";
    [Column("smtp_host")]     public string SmtpHost { get; set; } = "";
    [Column("smtp_port")]     public int SmtpPort { get; set; } = 587;
    [Column("smtp_ssl")]      public bool SmtpSsl { get; set; } = true;
    [Column("smtp_user")]     public string SmtpUser { get; set; } = "";
    [Column("smtp_pass_enc")] public string SmtpPassEnc { get; set; } = "";
    [Column("imza_html")]     public string? ImzaHtml { get; set; }
    [Column("olusturulma")]   public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
    [Column("aktif")]         public bool Aktif { get; set; } = true;
}

[Table("pine_mail_drafts")]
public class PineMailDraft
{
    [Key] [Column("draft_id")] public Guid DraftId { get; set; } = Guid.NewGuid();
    [Column("account_id")]     public Guid AccountId { get; set; }
    [Column("konu")]           public string? Konu { get; set; }
    [Column("alici")]          public string? Alici { get; set; }
    [Column("cc")]             public string? Cc { get; set; }
    [Column("bcc")]            public string? Bcc { get; set; }
    [Column("govde_html")]     public string? GovdeHtml { get; set; }
    [Column("olusturulma")]    public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
    [Column("guncellenme")]    public DateTime? Guncellenme { get; set; }
}
