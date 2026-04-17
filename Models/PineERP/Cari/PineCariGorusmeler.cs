using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesap ile yapilan gorusme kayitlari (CRM).
/// </summary>
[Table("pine_cari_gorusmeler")]
public class PineCariGorusmeler : BaseEntity
{
    [Column("cag_cari_kod")]
    [StringLength(25)]
    public string CagCariKod { get; set; } = string.Empty;

    [Column("cag_tarih")]
    public DateTime CagTarih { get; set; }

    /// <summary>1=Telefon, 2=Email, 3=Yuz yuze, 4=Video, 5=Diger</summary>
    [Column("cag_gorusme_tipi")]
    public int CagGorusmeTipi { get; set; }

    [Column("cag_konu")]
    [StringLength(200)]
    public string? CagKonu { get; set; }

    [Column("cag_icerik")]
    [StringLength(2000)]
    public string? CagIcerik { get; set; }

    [Column("cag_sonuc")]
    [StringLength(500)]
    public string? CagSonuc { get; set; }

    [Column("cag_yetkili_ad")]
    [StringLength(100)]
    public string? CagYetkiliAd { get; set; }

    [Column("cag_personel_kodu")]
    [StringLength(25)]
    public string? CagPersonelKodu { get; set; }

    [Column("cag_sonraki_gorusme_tarihi")]
    public DateTime? CagSonrakiGorusmeTarihi { get; set; }

    [Column("cag_hatirlatma_fl")]
    public bool CagHatirlatmaFl { get; set; }

    [Column("cag_durum")]
    public int CagDurum { get; set; }

    [Column("cag_aciklama")]
    [StringLength(500)]
    public string? CagAciklama { get; set; }
}
