using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_lisans_gecmisi")]
public class PineLisansGecmisi : BaseEntity
{
    [Column("lig_lisans_id")]
    public int LigLisansId { get; set; }

    [Column("lig_islem_tipi")]
    [StringLength(50)]
    public string? LigIslemTipi { get; set; }

    [Column("lig_eski_plan")]
    [StringLength(50)]
    public string? LigEskiPlan { get; set; }

    [Column("lig_yeni_plan")]
    [StringLength(50)]
    public string? LigYeniPlan { get; set; }

    [Column("lig_tutar")]
    public decimal LigTutar { get; set; }

    [Column("lig_aciklama")]
    [StringLength(500)]
    public string? LigAciklama { get; set; }

    [Column("lig_islem_tarihi")]
    public DateTime LigIslemTarihi { get; set; }
}
