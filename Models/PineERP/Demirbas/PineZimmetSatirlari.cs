using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_zimmet_satirlari")]
public class PineZimmetSatirlari : BaseEntity
{
    [Column("zms_zimmet_id")]
    public int ZmsZimmetId { get; set; }

    [Column("zms_demirbas_kod")]
    [StringLength(25)]
    public string? ZmsDemirbasKod { get; set; }

    [Column("zms_demirbas_isim")]
    [StringLength(200)]
    public string? ZmsDemirbasIsim { get; set; }

    [Column("zms_seri_no")]
    [StringLength(100)]
    public string? ZmsSeriNo { get; set; }

    [Column("zms_adet")]
    public int ZmsAdet { get; set; }

    [Column("zms_teslim_tarihi")]
    public DateTime? ZmsTeslimTarihi { get; set; }

    [Column("zms_iade_tarihi")]
    public DateTime? ZmsIadeTarihi { get; set; }

    [Column("zms_durum")]
    [StringLength(50)]
    public string? ZmsDurum { get; set; }

    [Column("zms_aciklama")]
    [StringLength(500)]
    public string? ZmsAciklama { get; set; }
}
