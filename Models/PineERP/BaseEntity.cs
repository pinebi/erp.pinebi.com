using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

/// <summary>
/// Tum PineERP tablolarinin temel sinifi.
/// Mikro ERP benzeri sistem alanlari icerir.
/// Her tablo bu siniftan turetilir.
/// </summary>
public abstract class BaseEntity
{
    [Key]
    [Column("rec_id")]
    public int Id { get; set; }

    [Column("rec_guid")]
    public Guid RecGuid { get; set; } = Guid.NewGuid();

    /// <summary>Firma/Sirket No (multi-tenant). 0=Ana sirket, 1+=Sube</summary>
    [Column("rec_firmano")]
    public int RecFirmaNo { get; set; } = 0;

    /// <summary>Sube No</summary>
    [Column("rec_subeno")]
    public int RecSubeNo { get; set; } = 0;

    /// <summary>Iptal/Void flag - true ise kayit iptal edilmis</summary>
    [Column("rec_iptal")]
    public bool RecIptal { get; set; } = false;

    /// <summary>Gizli/Soft-delete flag - true ise kayit gizlenmis</summary>
    [Column("rec_gizli")]
    public bool RecGizli { get; set; } = false;

    /// <summary>Kilitli flag - true ise kayit duzenlenemez</summary>
    [Column("rec_kilitli")]
    public bool RecKilitli { get; set; } = false;

    /// <summary>Olusturan kullanici adi</summary>
    [Column("rec_create_user")]
    [StringLength(200)]
    public string? RecCreateUser { get; set; }

    /// <summary>Olusturma tarihi</summary>
    [Column("rec_create_date")]
    public DateTime? RecCreateDate { get; set; }

    /// <summary>Son guncelleyen kullanici adi</summary>
    [Column("rec_lastup_user")]
    [StringLength(200)]
    public string? RecLastupUser { get; set; }

    /// <summary>Son guncelleme tarihi</summary>
    [Column("rec_lastup_date")]
    public DateTime? RecLastupDate { get; set; }
}
