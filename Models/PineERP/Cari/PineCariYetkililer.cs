using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesaba ait yetkili kisi bilgileri.
/// </summary>
[Table("pine_cari_yetkililer")]
public class PineCariYetkililer : BaseEntity
{
    [Column("cay_cari_kod")]
    [StringLength(25)]
    public string CayCariKod { get; set; } = string.Empty;

    [Column("cay_ad")]
    [StringLength(100)]
    public string? CayAd { get; set; }

    [Column("cay_soyad")]
    [StringLength(100)]
    public string? CaySoyad { get; set; }

    [Column("cay_unvan")]
    [StringLength(100)]
    public string? CayUnvan { get; set; }

    [Column("cay_gorev")]
    [StringLength(100)]
    public string? CayGorev { get; set; }

    [Column("cay_departman")]
    [StringLength(100)]
    public string? CayDepartman { get; set; }

    [Column("cay_tel")]
    [StringLength(50)]
    public string? CayTel { get; set; }

    [Column("cay_dahili")]
    [StringLength(20)]
    public string? CayDahili { get; set; }

    [Column("cay_gsm")]
    [StringLength(50)]
    public string? CayGsm { get; set; }

    [Column("cay_email")]
    [StringLength(200)]
    public string? CayEmail { get; set; }

    [Column("cay_dogum_tarihi")]
    public DateTime? CayDogumTarihi { get; set; }

    [Column("cay_cinsiyet")]
    public int CayCinsiyet { get; set; }

    [Column("cay_varsayilan_fl")]
    public bool CayVarsayilanFl { get; set; }

    [Column("cay_pasif_fl")]
    public bool CayPasifFl { get; set; }

    [Column("cay_aciklama")]
    [StringLength(500)]
    public string? CayAciklama { get; set; }
}
