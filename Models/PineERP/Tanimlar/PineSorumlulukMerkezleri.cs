using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_sorumluluk_merkezleri")]
public class PineSorumlulukMerkezleri : BaseEntity
{
    [Column("srm_kod")]
    [StringLength(25)]
    public string? SrmKod { get; set; }

    [Column("srm_isim")]
    [StringLength(200)]
    public string? SrmIsim { get; set; }

    [Column("srm_ust_merkez_kod")]
    [StringLength(25)]
    public string? SrmUstMerkezKod { get; set; }

    [Column("srm_sorumlu")]
    [StringLength(200)]
    public string? SrmSorumlu { get; set; }

    [Column("srm_tip")]
    [StringLength(50)]
    public string? SrmTip { get; set; }

    [Column("srm_aciklama")]
    [StringLength(500)]
    public string? SrmAciklama { get; set; }

    [Column("srm_aktif")]
    public bool SrmAktif { get; set; } = true;
}
