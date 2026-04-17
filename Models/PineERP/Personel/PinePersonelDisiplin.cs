using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_disiplin")]
public class PinePersonelDisiplin : BaseEntity
{
    [Column("pds_personel_kod")]
    [StringLength(25)]
    public string? PdsPersonelKod { get; set; }

    [Column("pds_adsoyad")]
    [StringLength(200)]
    public string? PdsAdsoyad { get; set; }

    [Column("pds_tarih")]
    public DateTime? PdsTarih { get; set; }

    [Column("pds_tutanak_no")]
    [StringLength(25)]
    public string? PdsTutanakNo { get; set; }

    [Column("pds_konu")]
    [StringLength(200)]
    public string? PdsKonu { get; set; }

    [Column("pds_tur")]
    [StringLength(50)]
    public string? PdsTur { get; set; }

    [Column("pds_ceza")]
    [StringLength(100)]
    public string? PdsCeza { get; set; }

    [Column("pds_aciklama")]
    [StringLength(500)]
    public string? PdsAciklama { get; set; }

    [Column("pds_taniklar")]
    [StringLength(500)]
    public string? PdsTaniklar { get; set; }

    [Column("pds_sonuc")]
    [StringLength(200)]
    public string? PdsSonuc { get; set; }
}
