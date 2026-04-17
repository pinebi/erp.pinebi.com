using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Teklif;

/// <summary>
/// Satinalma sartlari tanim tablosu.
/// Teklif ve siparis sureclerinde kullanilan satinalma kosullarini tutar.
/// SatisSartlari ile ayni yapida.
/// </summary>
[Table("pine_satinalma_sartlari")]
public class PineSatinalmaSartlari : BaseEntity
{
    [Column("sas_kod")]
    [StringLength(25)]
    public string SasKod { get; set; } = string.Empty;

    [Column("sas_isim")]
    [StringLength(200)]
    public string SasIsim { get; set; } = string.Empty;

    [Column("sas_vade_suresi")]
    public int SasVadeSuresi { get; set; } = 0;

    [Column("sas_iskonto_orani")]
    public decimal SasIskontoOrani { get; set; } = 0;

    [Column("sas_odeme_sekli")]
    [StringLength(50)]
    public string? SasOdemeSekli { get; set; }

    [Column("sas_aciklama")]
    [StringLength(500)]
    public string? SasAciklama { get; set; }

    [Column("sas_aktif")]
    public bool SasAktif { get; set; } = true;
}
