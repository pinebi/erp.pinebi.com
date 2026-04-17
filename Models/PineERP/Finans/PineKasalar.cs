using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Kasa tanim tablosu.
/// Nakit kasalarin tanimlanmasini saglar.
/// </summary>
[Table("pine_kasalar")]
public class PineKasalar : BaseEntity
{
    [Column("kas_kod")]
    [StringLength(25)]
    public string KasKod { get; set; } = string.Empty;

    [Column("kas_isim")]
    [StringLength(100)]
    public string KasIsim { get; set; } = string.Empty;

    [Column("kas_para_birimi")]
    [StringLength(5)]
    public string? KasParaBirimi { get; set; }

    [Column("kas_sorumlu")]
    [StringLength(100)]
    public string? KasSorumlu { get; set; }

    [Column("kas_aciklama")]
    [StringLength(500)]
    public string? KasAciklama { get; set; }

    [Column("kas_aktif")]
    public bool KasAktif { get; set; } = true;
}
