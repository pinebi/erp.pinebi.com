using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Odeme planlari ana tablosu.
/// Fatura ve siparis bazinda odeme planlarini tutar.
/// </summary>
[Table("pine_odeme_planlari")]
public class PineOdemePlanlari : BaseEntity
{
    [Column("opl_kod")]
    [StringLength(25)]
    public string OplKod { get; set; } = string.Empty;

    [Column("opl_tarih")]
    public DateTime OplTarih { get; set; }

    [Column("opl_cari_kod")]
    [StringLength(25)]
    public string? OplCariKod { get; set; }

    [Column("opl_cari_unvan")]
    [StringLength(300)]
    public string? OplCariUnvan { get; set; }

    /// <summary>0=Tahsilat, 1=Odeme</summary>
    [Column("opl_tip")]
    public int OplTip { get; set; }

    [Column("opl_toplam_tutar")]
    public decimal OplToplamTutar { get; set; } = 0;

    [Column("opl_odenen_tutar")]
    public decimal OplOdenenTutar { get; set; } = 0;

    [Column("opl_kalan_tutar")]
    public decimal OplKalanTutar { get; set; } = 0;

    [Column("opl_taksit_sayisi")]
    public int OplTaksitSayisi { get; set; } = 0;

    [Column("opl_doviz_cinsi")]
    [StringLength(5)]
    public string? OplDovizCinsi { get; set; }

    [Column("opl_doviz_kuru")]
    public decimal OplDovizKuru { get; set; } = 0;

    // ===== ILISKILI BELGE =====

    [Column("opl_fatura_uid")]
    public Guid? OplFaturaUid { get; set; }

    [Column("opl_siparis_uid")]
    public Guid? OplSiparisUid { get; set; }

    // ===== DURUM =====

    [Column("opl_kapandi")]
    public bool OplKapandi { get; set; } = false;

    // ===== ACIKLAMA =====

    [Column("opl_aciklama")]
    [StringLength(500)]
    public string? OplAciklama { get; set; }
}
