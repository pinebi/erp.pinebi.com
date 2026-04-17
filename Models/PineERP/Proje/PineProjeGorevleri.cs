using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_proje_gorevleri")]
public class PineProjeGorevleri : BaseEntity
{
    [Column("pgo_proje_kod")]
    [StringLength(25)]
    public string? PgoProjeKod { get; set; }

    [Column("pgo_gorev_no")]
    public int PgoGorevNo { get; set; }

    [Column("pgo_isim")]
    [StringLength(200)]
    public string? PgoIsim { get; set; }

    [Column("pgo_sorumlu")]
    [StringLength(200)]
    public string? PgoSorumlu { get; set; }

    [Column("pgo_baslangic")]
    public DateTime? PgoBaslangic { get; set; }

    [Column("pgo_bitis")]
    public DateTime? PgoBitis { get; set; }

    [Column("pgo_durum")]
    [StringLength(50)]
    public string? PgoDurum { get; set; }

    [Column("pgo_tamamlanma_yuzdesi")]
    public int PgoTamamlanmaYuzdesi { get; set; }

    [Column("pgo_aciklama")]
    [StringLength(500)]
    public string? PgoAciklama { get; set; }
}
