using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura iptal islem kayitlari.
/// Iptal edilen faturalarin loglari.
/// </summary>
[Table("pine_fatura_iptal_log")]
public class PineFaturaIptalLog : BaseEntity
{
    [Column("fil_fatura_uid")]
    public Guid FilFaturaUid { get; set; }

    [Column("fil_iptal_tarihi")]
    public DateTime FilIptalTarihi { get; set; }

    [Column("fil_iptal_eden")]
    [StringLength(200)]
    public string? FilIptalEden { get; set; }

    /// <summary>1=Kullanici Iptali, 2=GIB Iptali, 3=Red, 4=Sistem</summary>
    [Column("fil_iptal_tipi")]
    public int FilIptalTipi { get; set; }

    [Column("fil_iptal_sebebi")]
    [StringLength(500)]
    public string? FilIptalSebebi { get; set; }

    [Column("fil_fatura_no")]
    [StringLength(25)]
    public string? FilFaturaNo { get; set; }

    [Column("fil_ettn")]
    [StringLength(100)]
    public string? FilEttn { get; set; }

    [Column("fil_gib_yanit")]
    [StringLength(500)]
    public string? FilGibYanit { get; set; }

    [Column("fil_aciklama")]
    [StringLength(500)]
    public string? FilAciklama { get; set; }
}
