using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Barkod tanimlari. Bir stok kartina birden fazla barkod tanimlanabilir.
/// Farkli birimlere farkli barkodlar atanabilir.
/// </summary>
[Table("pine_barkod_tanimlari")]
public class PineBarkodTanimlari : BaseEntity
{
    [Column("brk_stok_kod")]
    [StringLength(25)]
    public string BrkStokKod { get; set; } = string.Empty;

    [Column("brk_barkod")]
    [StringLength(50)]
    public string BrkBarkod { get; set; } = string.Empty;

    [Column("brk_birim")]
    [StringLength(20)]
    public string? BrkBirim { get; set; }

    [Column("brk_birim_katsayi")]
    public decimal BrkBirimKatsayi { get; set; } = 1;

    [Column("brk_aktif")]
    public bool BrkAktif { get; set; } = true;
}
