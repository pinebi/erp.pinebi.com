using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_vergi_daireleri")]
public class PineVergiDaireleri : BaseEntity
{
    [Column("vgd_kod")]
    [StringLength(20)]
    public string? VgdKod { get; set; }

    [Column("vgd_sehir")]
    [StringLength(100)]
    public string? VgdSehir { get; set; }

    [Column("vgd_isim")]
    [StringLength(200)]
    public string? VgdIsim { get; set; }

    [Column("vgd_aktif")]
    public bool VgdAktif { get; set; } = true;
}
