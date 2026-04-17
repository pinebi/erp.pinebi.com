using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_genel_tutanak")]
public class PinePersonelGenelTutanak : BaseEntity
{
    [Column("pgt_personel_kod")]
    [StringLength(25)]
    public string? PgtPersonelKod { get; set; }

    [Column("pgt_adsoyad")]
    [StringLength(200)]
    public string? PgtAdsoyad { get; set; }

    [Column("pgt_tarih")]
    public DateTime? PgtTarih { get; set; }

    [Column("pgt_tutanak_no")]
    [StringLength(25)]
    public string? PgtTutanakNo { get; set; }

    [Column("pgt_konu")]
    [StringLength(200)]
    public string? PgtKonu { get; set; }

    [Column("pgt_tur")]
    [StringLength(50)]
    public string? PgtTur { get; set; }

    [Column("pgt_aciklama")]
    [StringLength(500)]
    public string? PgtAciklama { get; set; }

    [Column("pgt_taniklar")]
    [StringLength(500)]
    public string? PgtTaniklar { get; set; }

    [Column("pgt_sonuc")]
    [StringLength(200)]
    public string? PgtSonuc { get; set; }
}
