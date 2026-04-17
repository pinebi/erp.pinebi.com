using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok grup tanimlari (Ana Grup, Alt Grup, Kategori, Marka, Sektor vb.)
/// Grup tipi ile ayirt edilir.
/// </summary>
[Table("pine_stok_gruplari")]
public class PineStokGruplari : BaseEntity
{
    /// <summary>Grup tipi: 1=AnaGrup, 2=AltGrup, 3=Kategori, 4=Marka, 5=Sektor</summary>
    [Column("sgr_tip")]
    public int SgrTip { get; set; }

    [Column("sgr_kod")]
    [StringLength(25)]
    public string SgrKod { get; set; } = string.Empty;

    [Column("sgr_isim")]
    [StringLength(100)]
    public string SgrIsim { get; set; } = string.Empty;

    [Column("sgr_ust_kod")]
    [StringLength(25)]
    public string? SgrUstKod { get; set; }

    [Column("sgr_aciklama")]
    [StringLength(500)]
    public string? SgrAciklama { get; set; }

    [Column("sgr_sira")]
    public int SgrSira { get; set; } = 0;

    [Column("sgr_aktif")]
    public bool SgrAktif { get; set; } = true;
}
