using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_odeme_tipleri")]
public class PineOdemeTipleri : BaseEntity
{
    [Column("odt_kod")]
    [StringLength(10)]
    public string? OdtKod { get; set; }

    [Column("odt_isim")]
    [StringLength(100)]
    public string? OdtIsim { get; set; }

    [Column("odt_aktif")]
    public bool OdtAktif { get; set; } = true;
}
