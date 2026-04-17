using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok birim tanimlari (Adet, Kg, Lt, Metre, Paket vb.)
/// </summary>
[Table("pine_stok_birimleri")]
public class PineStokBirimleri : BaseEntity
{
    [Column("sbr_kod")]
    [StringLength(20)]
    public string SbrKod { get; set; } = string.Empty;

    [Column("sbr_isim")]
    [StringLength(50)]
    public string SbrIsim { get; set; } = string.Empty;

    [Column("sbr_aciklama")]
    [StringLength(200)]
    public string? SbrAciklama { get; set; }

    [Column("sbr_aktif")]
    public bool SbrAktif { get; set; } = true;
}
