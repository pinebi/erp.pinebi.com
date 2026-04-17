using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_ulkeler")]
public class PineUlkeler : BaseEntity
{
    [Column("ulk_kod")]
    [StringLength(5)]
    public string? UlkKod { get; set; }

    [Column("ulk_isim")]
    [StringLength(100)]
    public string? UlkIsim { get; set; }

    [Column("ulk_simge")]
    [StringLength(5)]
    public string? UlkSimge { get; set; }

    [Column("ulk_alan_kodu")]
    [StringLength(10)]
    public string? UlkAlanKodu { get; set; }

    [Column("ulk_aktif")]
    public bool UlkAktif { get; set; } = true;
}
