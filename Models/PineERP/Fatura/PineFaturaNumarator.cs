using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura numarator / seri-sira yonetimi.
/// Otomatik fatura numarasi uretmek icin kullanilir.
/// </summary>
[Table("pine_fatura_numarator")]
public class PineFaturaNumarator : BaseEntity
{
    [Column("fnu_seri")]
    [StringLength(5)]
    public string FnuSeri { get; set; } = string.Empty;

    [Column("fnu_adi")]
    [StringLength(200)]
    public string? FnuAdi { get; set; }

    /// <summary>1=Satis, 2=SatisIade, 3=Satinalma, 4=SatinalmaIade, 5=Proforma</summary>
    [Column("fnu_fatura_tipi")]
    public int FnuFaturaTipi { get; set; }

    [Column("fnu_son_sira")]
    public int FnuSonSira { get; set; }

    [Column("fnu_baslangic_no")]
    public int FnuBaslangicNo { get; set; } = 1;

    [Column("fnu_bitis_no")]
    public int FnuBitisNo { get; set; } = 999999;

    [Column("fnu_yil")]
    public int FnuYil { get; set; }

    [Column("fnu_prefix")]
    [StringLength(20)]
    public string? FnuPrefix { get; set; }

    [Column("fnu_suffix")]
    [StringLength(20)]
    public string? FnuSuffix { get; set; }

    [Column("fnu_hane_sayisi")]
    public int FnuHaneSayisi { get; set; } = 6;

    [Column("fnu_pasif_fl")]
    public bool FnuPasifFl { get; set; }

    [Column("fnu_aciklama")]
    [StringLength(500)]
    public string? FnuAciklama { get; set; }
}
