using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok depo detaylari. Her stogun depo bazindaki miktar, min/max stok ve raf bilgilerini tutar.
/// </summary>
[Table("pine_stok_depo_detaylari")]
public class PineStokDepoDetaylari : BaseEntity
{
    [Column("sdd_stok_kod")]
    [StringLength(25)]
    public string SddStokKod { get; set; } = string.Empty;

    [Column("sdd_depo_no")]
    public int SddDepoNo { get; set; }

    [Column("sdd_raf_kodu")]
    [StringLength(25)]
    public string? SddRafKodu { get; set; }

    [Column("sdd_miktar")]
    public decimal SddMiktar { get; set; } = 0;

    [Column("sdd_min_stok")]
    public decimal SddMinStok { get; set; } = 0;

    [Column("sdd_max_stok")]
    public decimal SddMaxStok { get; set; } = 0;

    [Column("sdd_son_sayim_tarihi")]
    public DateTime? SddSonSayimTarihi { get; set; }
}
