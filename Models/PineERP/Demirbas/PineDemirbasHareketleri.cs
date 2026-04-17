using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_demirbas_hareketleri")]
public class PineDemirbasHareketleri : BaseEntity
{
    [Column("dhk_demirbas_kod")]
    [StringLength(25)]
    public string? DhkDemirbasKod { get; set; }

    [Column("dhk_tarih")]
    public DateTime? DhkTarih { get; set; }

    [Column("dhk_tip")]
    [StringLength(50)]
    public string? DhkTip { get; set; }

    [Column("dhk_personel_kod")]
    [StringLength(25)]
    public string? DhkPersonelKod { get; set; }

    [Column("dhk_lokasyon")]
    [StringLength(200)]
    public string? DhkLokasyon { get; set; }

    [Column("dhk_aciklama")]
    [StringLength(500)]
    public string? DhkAciklama { get; set; }
}
