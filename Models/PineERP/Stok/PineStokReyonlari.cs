using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok reyon tanimlari (Magazacilik sektorunde kullanilir)
/// </summary>
[Table("pine_stok_reyonlari")]
public class PineStokReyonlari : BaseEntity
{
    [Column("sry_kod")]
    [StringLength(20)]
    public string SryKod { get; set; } = string.Empty;

    [Column("sry_isim")]
    [StringLength(100)]
    public string SryIsim { get; set; } = string.Empty;

    [Column("sry_aktif")]
    public bool SryAktif { get; set; } = true;
}
