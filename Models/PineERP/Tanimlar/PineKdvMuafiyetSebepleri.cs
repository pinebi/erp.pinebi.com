using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_kdv_muafiyet_sebepleri")]
public class PineKdvMuafiyetSebepleri : BaseEntity
{
    [Column("kdm_kod")]
    [StringLength(20)]
    public string? KdmKod { get; set; }

    [Column("kdm_sebep")]
    [StringLength(500)]
    public string? KdmSebep { get; set; }

    [Column("kdm_kanun_maddesi")]
    [StringLength(200)]
    public string? KdmKanunMaddesi { get; set; }

    [Column("kdm_aktif")]
    public bool KdmAktif { get; set; } = true;
}
