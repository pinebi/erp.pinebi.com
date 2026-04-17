using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_is_emirleri")]
public class PineIsEmirleri : BaseEntity
{
    [Column("ise_no")]
    [StringLength(25)]
    public string? IseNo { get; set; }

    [Column("ise_tarih")]
    public DateTime? IseTarih { get; set; }

    [Column("ise_recete_id")]
    public int IseReceteId { get; set; }

    [Column("ise_stok_kod")]
    [StringLength(25)]
    public string? IseStokKod { get; set; }

    [Column("ise_miktar")]
    public decimal IseMiktar { get; set; }

    [Column("ise_tamamlanan")]
    public decimal IseTamamlanan { get; set; }

    [Column("ise_baslangic")]
    public DateTime? IseBaslangic { get; set; }

    [Column("ise_bitis")]
    public DateTime? IseBitis { get; set; }

    [Column("ise_durum")]
    [StringLength(50)]
    public string? IseDurum { get; set; }

    [Column("ise_sorumlu")]
    [StringLength(200)]
    public string? IseSorumlu { get; set; }

    [Column("ise_aciklama")]
    [StringLength(500)]
    public string? IseAciklama { get; set; }
}
