using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok renk tanimlari (Tekstil/hazir giyim sektorunde kullanilir)
/// </summary>
[Table("pine_stok_renk_tanimlari")]
public class PineStokRenkTanimlari : BaseEntity
{
    [Column("srn_kod")]
    [StringLength(20)]
    public string SrnKod { get; set; } = string.Empty;

    [Column("srn_isim")]
    [StringLength(50)]
    public string SrnIsim { get; set; } = string.Empty;

    [Column("srn_aktif")]
    public bool SrnAktif { get; set; } = true;
}
