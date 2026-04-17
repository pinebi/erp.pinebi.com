using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_email_ayarlari")]
public class PineEmailAyarlari : BaseEntity
{
    [Column("ema_server")]
    [StringLength(200)]
    public string? EmaServer { get; set; }

    [Column("ema_kullanici")]
    [StringLength(200)]
    public string? EmaKullanici { get; set; }

    [Column("ema_sifre")]
    [StringLength(200)]
    public string? EmaSifre { get; set; }

    [Column("ema_port")]
    public int EmaPort { get; set; }

    [Column("ema_ssl")]
    public bool EmaSsl { get; set; }

    [Column("ema_gonderen_isim")]
    [StringLength(200)]
    public string? EmaGonderenIsim { get; set; }

    [Column("ema_gonderen_email")]
    [StringLength(200)]
    public string? EmaGonderenEmail { get; set; }
}
