using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_urun_receteleri")]
public class PineUrunReceteleri : BaseEntity
{
    [Column("urc_stok_kod")]
    [StringLength(25)]
    public string? UrcStokKod { get; set; }

    [Column("urc_recete_no")]
    public int UrcReceteNo { get; set; }

    [Column("urc_isim")]
    [StringLength(200)]
    public string? UrcIsim { get; set; }

    [Column("urc_miktar")]
    public decimal UrcMiktar { get; set; }

    [Column("urc_birim")]
    [StringLength(20)]
    public string? UrcBirim { get; set; }

    [Column("urc_aciklama")]
    [StringLength(500)]
    public string? UrcAciklama { get; set; }

    [Column("urc_aktif")]
    public bool UrcAktif { get; set; }
}
