using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_gorus_onerileri")]
public class PinePersonelGorusOnerileri : BaseEntity
{
    [Column("pgo_personel_kod")]
    [StringLength(25)]
    public string? PgoPersonelKod { get; set; }

    [Column("pgo_adsoyad")]
    [StringLength(200)]
    public string? PgoAdsoyad { get; set; }

    [Column("pgo_tarih")]
    public DateTime? PgoTarih { get; set; }

    [Column("pgo_konu")]
    [StringLength(200)]
    public string? PgoKonu { get; set; }

    [Column("pgo_kategori")]
    [StringLength(100)]
    public string? PgoKategori { get; set; }

    [Column("pgo_aciklama")]
    [StringLength(500)]
    public string? PgoAciklama { get; set; }

    [Column("pgo_yanit")]
    [StringLength(500)]
    public string? PgoYanit { get; set; }

    [Column("pgo_durum")]
    [StringLength(50)]
    public string? PgoDurum { get; set; }
}
