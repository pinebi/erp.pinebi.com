using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.EFatura;

[Table("pine_efatura_gelen_satirlar")]
public class PineEFaturaGelenSatirlar : BaseEntity
{
    [Column("efs_fatura_id")]
    public int EfsFaturaId { get; set; }

    [Column("efs_malzeme_kodu")]
    [StringLength(50)]
    public string? EfsMalzemeKodu { get; set; }

    [Column("efs_malzeme_adi")]
    [StringLength(300)]
    public string? EfsMalzemeAdi { get; set; }

    [Column("efs_miktar")]
    public decimal EfsMiktar { get; set; }

    [Column("efs_birim")]
    [StringLength(20)]
    public string? EfsBirim { get; set; }

    [Column("efs_fiyat")]
    public decimal EfsFiyat { get; set; }

    [Column("efs_tutar")]
    public decimal EfsTutar { get; set; }

    [Column("efs_iskonto")]
    public decimal EfsIskonto { get; set; }

    [Column("efs_kdv_orani")]
    public decimal EfsKdvOrani { get; set; }

    [Column("efs_kdv_tutari")]
    public decimal EfsKdvTutari { get; set; }
}
