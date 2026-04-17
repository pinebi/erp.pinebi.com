using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok hareketleri ozet tablosu.
/// Aylik bazda depo/stok bazinda giren/cikan miktar ve tutar toplamlari.
/// Hizli raporlama icin kullanilir.
/// </summary>
[Table("pine_stok_hareketleri_ozet")]
public class PineStokHareketleriOzet : BaseEntity
{
    [Column("sho_stok_kod")]
    [StringLength(25)]
    public string ShoStokKod { get; set; } = string.Empty;

    [Column("sho_depo_no")]
    public int ShoDepoNo { get; set; }

    [Column("sho_donem_yil")]
    public int ShoDonemYil { get; set; }

    [Column("sho_donem_ay")]
    public int ShoDonemAy { get; set; }

    [Column("sho_giren_miktar")]
    public decimal ShoGirenMiktar { get; set; } = 0;

    [Column("sho_cikan_miktar")]
    public decimal ShoCikanMiktar { get; set; } = 0;

    [Column("sho_giren_tutar")]
    public decimal ShoGirenTutar { get; set; } = 0;

    [Column("sho_cikan_tutar")]
    public decimal ShoCikanTutar { get; set; } = 0;
}
