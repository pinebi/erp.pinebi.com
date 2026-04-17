using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_tasiyici_bilgileri")]
public class PineTasiyiciBilgileri : BaseEntity
{
    [Column("tsb_kod")]
    [StringLength(25)]
    public string? TsbKod { get; set; }

    [Column("tsb_unvan")]
    [StringLength(300)]
    public string? TsbUnvan { get; set; }

    [Column("tsb_vergi_dairesi")]
    [StringLength(100)]
    public string? TsbVergiDairesi { get; set; }

    [Column("tsb_vergi_no")]
    [StringLength(20)]
    public string? TsbVergiNo { get; set; }

    [Column("tsb_tel")]
    [StringLength(50)]
    public string? TsbTel { get; set; }

    [Column("tsb_email")]
    [StringLength(200)]
    public string? TsbEmail { get; set; }

    [Column("tsb_adres")]
    [StringLength(500)]
    public string? TsbAdres { get; set; }

    [Column("tsb_aktif")]
    public bool TsbAktif { get; set; } = true;
}
