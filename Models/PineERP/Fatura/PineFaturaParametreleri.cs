using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura parametreleri / ayarlari.
/// Firma bazinda fatura olusturma davranislarini belirler.
/// </summary>
[Table("pine_fatura_parametreleri")]
public class PineFaturaParametreleri : BaseEntity
{
    [Column("fpr_kod")]
    [StringLength(25)]
    public string FprKod { get; set; } = string.Empty;

    [Column("fpr_adi")]
    [StringLength(200)]
    public string? FprAdi { get; set; }

    [Column("fpr_varsayilan_doviz")]
    [StringLength(5)]
    public string? FprVarsayilanDoviz { get; set; }

    [Column("fpr_varsayilan_depo")]
    public int FprVarsayilanDepo { get; set; }

    [Column("fpr_varsayilan_isyeri")]
    public int FprVarsayilanIsyeri { get; set; }

    [Column("fpr_kdv_dahil_fl")]
    public bool FprKdvDahilFl { get; set; }

    [Column("fpr_stok_kontrol_fl")]
    public bool FprStokKontrolFl { get; set; }

    [Column("fpr_negatif_stok_fl")]
    public bool FprNegatifStokFl { get; set; }

    [Column("fpr_cari_risk_kontrol_fl")]
    public bool FprCariRiskKontrolFl { get; set; }

    [Column("fpr_otomatik_cari_hareket_fl")]
    public bool FprOtomatikCariHareketFl { get; set; } = true;

    [Column("fpr_otomatik_stok_hareket_fl")]
    public bool FprOtomatikStokHareketFl { get; set; } = true;

    [Column("fpr_efatura_entegrasyon_fl")]
    public bool FprEfaturaEntegrasyonFl { get; set; }

    [Column("fpr_varsayilan_seri")]
    [StringLength(5)]
    public string? FprVarsayilanSeri { get; set; }

    [Column("fpr_aciklama")]
    [StringLength(500)]
    public string? FprAciklama { get; set; }
}
