using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Banka hesap tanimlari tablosu.
/// Sirketin banka hesap bilgilerini tutar.
/// </summary>
[Table("pine_banka_hesaplari")]
public class PineBankaHesaplari : BaseEntity
{
    [Column("bhs_kod")]
    [StringLength(25)]
    public string BhsKod { get; set; } = string.Empty;

    [Column("bhs_banka_adi")]
    [StringLength(100)]
    public string BhsBankaAdi { get; set; } = string.Empty;

    [Column("bhs_sube")]
    [StringLength(100)]
    public string? BhsSube { get; set; }

    [Column("bhs_hesap_no")]
    [StringLength(50)]
    public string? BhsHesapNo { get; set; }

    [Column("bhs_iban")]
    [StringLength(50)]
    public string? BhsIban { get; set; }

    [Column("bhs_swift")]
    [StringLength(20)]
    public string? BhsSwift { get; set; }

    [Column("bhs_para_birimi")]
    [StringLength(5)]
    public string? BhsParaBirimi { get; set; }

    [Column("bhs_hesap_tipi")]
    [StringLength(50)]
    public string? BhsHesapTipi { get; set; }

    [Column("bhs_hesap_sahibi")]
    [StringLength(200)]
    public string? BhsHesapSahibi { get; set; }

    [Column("bhs_sorumlu")]
    [StringLength(100)]
    public string? BhsSorumlu { get; set; }

    [Column("bhs_aktif")]
    public bool BhsAktif { get; set; } = true;

    [Column("bhs_ana_hesap")]
    public bool BhsAnaHesap { get; set; } = false;
}
