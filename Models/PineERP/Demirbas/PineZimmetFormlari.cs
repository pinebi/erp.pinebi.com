using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_zimmet_formlari")]
public class PineZimmetFormlari : BaseEntity
{
    [Column("zmf_no")]
    [StringLength(25)]
    public string? ZmfNo { get; set; }

    [Column("zmf_tarih")]
    public DateTime? ZmfTarih { get; set; }

    [Column("zmf_personel_kod")]
    [StringLength(25)]
    public string? ZmfPersonelKod { get; set; }

    [Column("zmf_personel_adsoyad")]
    [StringLength(200)]
    public string? ZmfPersonelAdsoyad { get; set; }

    [Column("zmf_departman")]
    [StringLength(100)]
    public string? ZmfDepartman { get; set; }

    [Column("zmf_durum")]
    [StringLength(50)]
    public string? ZmfDurum { get; set; }

    [Column("zmf_aciklama")]
    [StringLength(500)]
    public string? ZmfAciklama { get; set; }
}
