using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_ozel_kodlar")]
public class PineOzelKodlar : BaseEntity
{
    [Column("ozk_tip")]
    public int OzkTip { get; set; }

    [Column("ozk_kod")]
    [StringLength(50)]
    public string? OzkKod { get; set; }

    [Column("ozk_isim")]
    [StringLength(200)]
    public string? OzkIsim { get; set; }

    [Column("ozk_aciklama")]
    [StringLength(500)]
    public string? OzkAciklama { get; set; }

    [Column("ozk_aktif")]
    public bool OzkAktif { get; set; } = true;
}
