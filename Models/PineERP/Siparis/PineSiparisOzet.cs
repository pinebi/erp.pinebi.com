using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Siparis;

/// <summary>
/// Siparis ozet/summary tablosu.
/// Cari bazinda donemsel siparis istatistiklerini tutar.
/// </summary>
[Table("pine_siparis_ozet")]
public class PineSiparisOzet : BaseEntity
{
    [Column("soz_cari_kod")]
    [StringLength(25)]
    public string SozCariKod { get; set; } = string.Empty;

    [Column("soz_donem_yil")]
    public int SozDonemYil { get; set; }

    [Column("soz_donem_ay")]
    public int SozDonemAy { get; set; }

    [Column("soz_siparis_adedi")]
    public int SozSiparisAdedi { get; set; } = 0;

    [Column("soz_toplam_tutar")]
    public decimal SozToplamTutar { get; set; } = 0;

    [Column("soz_teslim_edilen_tutar")]
    public decimal SozTeslimEdilenTutar { get; set; } = 0;

    [Column("soz_kalan_tutar")]
    public decimal SozKalanTutar { get; set; } = 0;
}
