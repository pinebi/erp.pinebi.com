using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_satinalma_talep_satirlari")]
public class PineSatinalmaTalepSatirlari : BaseEntity
{
    [Column("sts_talep_id")]
    public int StsTalepId { get; set; }

    [Column("sts_stok_kod")]
    [StringLength(25)]
    public string? StsStokKod { get; set; }

    [Column("sts_stok_isim")]
    [StringLength(200)]
    public string? StsStokIsim { get; set; }

    [Column("sts_miktar")]
    public decimal StsMiktar { get; set; }

    [Column("sts_birim")]
    [StringLength(20)]
    public string? StsBirim { get; set; }

    [Column("sts_tahmini_fiyat")]
    public decimal StsTahminiFiyat { get; set; }

    [Column("sts_tedarikci")]
    [StringLength(200)]
    public string? StsTedarikci { get; set; }

    [Column("sts_aciklama")]
    [StringLength(500)]
    public string? StsAciklama { get; set; }
}
