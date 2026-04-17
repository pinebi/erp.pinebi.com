using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Gider tipleri tanim tablosu.
/// Masraf kalemlerinin siniflandirilmasini saglar.
/// </summary>
[Table("pine_gider_tipleri")]
public class PineGiderTipleri : BaseEntity
{
    [Column("gdt_kod")]
    [StringLength(25)]
    public string GdtKod { get; set; } = string.Empty;

    [Column("gdt_isim")]
    [StringLength(200)]
    public string GdtIsim { get; set; } = string.Empty;

    [Column("gdt_hesap_kodu")]
    [StringLength(25)]
    public string? GdtHesapKodu { get; set; }

    [Column("gdt_aciklama")]
    [StringLength(500)]
    public string? GdtAciklama { get; set; }

    [Column("gdt_aktif")]
    public bool GdtAktif { get; set; } = true;
}
