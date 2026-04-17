using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_ilceler")]
public class PineIlceler : BaseEntity
{
    [Column("ilc_sehir_id")]
    public int IlcSehirId { get; set; }

    [Column("ilc_isim")]
    [StringLength(100)]
    public string? IlcIsim { get; set; }

    [Column("ilc_aktif")]
    public bool IlcAktif { get; set; } = true;
}
