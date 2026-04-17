using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_urun_rotalari")]
public class PineUrunRotalari : BaseEntity
{
    [Column("uro_recete_id")]
    public int UroReceteId { get; set; }

    [Column("uro_sira_no")]
    public int UroSiraNo { get; set; }

    [Column("uro_operasyon_kod")]
    [StringLength(25)]
    public string? UroOperasyonKod { get; set; }

    [Column("uro_is_merkezi")]
    [StringLength(100)]
    public string? UroIsMerkezi { get; set; }

    [Column("uro_sure_dakika")]
    public decimal UroSureDakika { get; set; }

    [Column("uro_hazirlik_sure")]
    public decimal UroHazirlikSure { get; set; }

    [Column("uro_aciklama")]
    [StringLength(500)]
    public string? UroAciklama { get; set; }
}
