using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Teklif;

/// <summary>
/// Satis sartlari tanim tablosu.
/// Teklif ve siparis sureclerinde kullanilan satis kosullarini tutar.
/// </summary>
[Table("pine_satis_sartlari")]
public class PineSatisSartlari : BaseEntity
{
    [Column("ssa_kod")]
    [StringLength(25)]
    public string SsaKod { get; set; } = string.Empty;

    [Column("ssa_isim")]
    [StringLength(200)]
    public string SsaIsim { get; set; } = string.Empty;

    [Column("ssa_vade_suresi")]
    public int SsaVadeSuresi { get; set; } = 0;

    [Column("ssa_iskonto_orani")]
    public decimal SsaIskontoOrani { get; set; } = 0;

    [Column("ssa_odeme_sekli")]
    [StringLength(50)]
    public string? SsaOdemeSekli { get; set; }

    [Column("ssa_aciklama")]
    [StringLength(500)]
    public string? SsaAciklama { get; set; }

    [Column("ssa_aktif")]
    public bool SsaAktif { get; set; } = true;
}
