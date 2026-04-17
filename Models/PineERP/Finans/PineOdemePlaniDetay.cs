using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Odeme plani taksit detaylari tablosu.
/// Her odeme planinin taksit satirlarini tutar.
/// </summary>
[Table("pine_odeme_plani_detay")]
public class PineOdemePlaniDetay : BaseEntity
{
    [Column("opd_plan_id")]
    public int OpdPlanId { get; set; }

    [Column("opd_sira")]
    public int OpdSira { get; set; }

    [Column("opd_vade_tarihi")]
    public DateTime? OpdVadeTarihi { get; set; }

    [Column("opd_tutar")]
    public decimal OpdTutar { get; set; } = 0;

    [Column("opd_odenen_tutar")]
    public decimal OpdOdenenTutar { get; set; } = 0;

    [Column("opd_kalan_tutar")]
    public decimal OpdKalanTutar { get; set; } = 0;

    /// <summary>Odeme sekli: Nakit, Havale, EFT, Cek, Senet, KrediKarti</summary>
    [Column("opd_odeme_sekli")]
    [StringLength(50)]
    public string? OpdOdemeSekli { get; set; }

    [Column("opd_odeme_tarihi")]
    public DateTime? OpdOdemeTarihi { get; set; }

    [Column("opd_odendi")]
    public bool OpdOdendi { get; set; } = false;

    [Column("opd_aciklama")]
    [StringLength(500)]
    public string? OpdAciklama { get; set; }
}
