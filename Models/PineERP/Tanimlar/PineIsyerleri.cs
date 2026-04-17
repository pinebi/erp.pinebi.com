using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_isyerleri")]
public class PineIsyerleri : BaseEntity
{
    [Column("isy_kod")]
    [StringLength(20)]
    public string? IsyKod { get; set; }

    [Column("isy_isim")]
    [StringLength(100)]
    public string? IsyIsim { get; set; }

    [Column("isy_adres")]
    [StringLength(500)]
    public string? IsyAdres { get; set; }

    [Column("isy_tel")]
    [StringLength(50)]
    public string? IsyTel { get; set; }

    [Column("isy_sorumlu")]
    [StringLength(100)]
    public string? IsySorumlu { get; set; }

    [Column("isy_aktif")]
    public bool IsyAktif { get; set; } = true;
}
