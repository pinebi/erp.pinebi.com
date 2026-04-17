using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_sehirler")]
public class PineSehirler : BaseEntity
{
    [Column("seh_ulke_kodu")]
    [StringLength(5)]
    public string? SehUlkeKodu { get; set; }

    [Column("seh_plaka_kodu")]
    public int SehPlakaKodu { get; set; }

    [Column("seh_isim")]
    [StringLength(100)]
    public string? SehIsim { get; set; }

    [Column("seh_aktif")]
    public bool SehAktif { get; set; } = true;
}
