using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_doviz_turleri")]
public class PineDovizTurleri : BaseEntity
{
    [Column("dvt_kod")]
    [StringLength(10)]
    public string? DvtKod { get; set; }

    [Column("dvt_isim")]
    [StringLength(50)]
    public string? DvtIsim { get; set; }

    [Column("dvt_simge")]
    [StringLength(5)]
    public string? DvtSimge { get; set; }

    [Column("dvt_ondalik_basamak")]
    public int DvtOndalikBasamak { get; set; } = 2;

    [Column("dvt_aktif")]
    public bool DvtAktif { get; set; } = true;
}
