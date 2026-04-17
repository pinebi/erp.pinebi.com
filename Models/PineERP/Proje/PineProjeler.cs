using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_projeler")]
public class PineProjeler : BaseEntity
{
    [Column("prj_kod")]
    [StringLength(25)]
    public string? PrjKod { get; set; }

    [Column("prj_isim")]
    [StringLength(200)]
    public string? PrjIsim { get; set; }

    [Column("prj_cari_kod")]
    [StringLength(25)]
    public string? PrjCariKod { get; set; }

    [Column("prj_sorumlu")]
    [StringLength(200)]
    public string? PrjSorumlu { get; set; }

    [Column("prj_baslangic")]
    public DateTime? PrjBaslangic { get; set; }

    [Column("prj_bitis")]
    public DateTime? PrjBitis { get; set; }

    [Column("prj_butce")]
    public decimal PrjButce { get; set; }

    [Column("prj_harcanan")]
    public decimal PrjHarcanan { get; set; }

    [Column("prj_kalan")]
    public decimal PrjKalan { get; set; }

    [Column("prj_durum")]
    [StringLength(50)]
    public string? PrjDurum { get; set; }

    [Column("prj_oncelik")]
    [StringLength(50)]
    public string? PrjOncelik { get; set; }

    [Column("prj_aciklama")]
    [StringLength(500)]
    public string? PrjAciklama { get; set; }
}
