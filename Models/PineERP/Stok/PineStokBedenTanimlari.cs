using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok beden tanimlari (Tekstil/hazir giyim sektorunde kullanilir: XS, S, M, L, XL vb.)
/// </summary>
[Table("pine_stok_beden_tanimlari")]
public class PineStokBedenTanimlari : BaseEntity
{
    [Column("sbd_kod")]
    [StringLength(20)]
    public string SbdKod { get; set; } = string.Empty;

    [Column("sbd_isim")]
    [StringLength(50)]
    public string SbdIsim { get; set; } = string.Empty;

    [Column("sbd_sira")]
    public int SbdSira { get; set; } = 0;

    [Column("sbd_aktif")]
    public bool SbdAktif { get; set; } = true;
}
