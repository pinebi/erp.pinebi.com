using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_izinleri")]
public class PinePersonelIzinleri : BaseEntity
{
    [Column("piz_personel_kod")]
    [StringLength(25)]
    public string? PizPersonelKod { get; set; }

    [Column("piz_adsoyad")]
    [StringLength(200)]
    public string? PizAdsoyad { get; set; }

    [Column("piz_gorevi")]
    [StringLength(100)]
    public string? PizGorevi { get; set; }

    [Column("piz_izin_turu")]
    [StringLength(50)]
    public string? PizIzinTuru { get; set; }

    [Column("piz_talep_tarihi")]
    public DateTime? PizTalepTarihi { get; set; }

    [Column("piz_baslangic")]
    public DateTime? PizBaslangic { get; set; }

    [Column("piz_izin_gunu")]
    public int PizIzinGunu { get; set; }

    [Column("piz_bitis")]
    public DateTime? PizBitis { get; set; }

    [Column("piz_ise_baslama")]
    public DateTime? PizIseBaslama { get; set; }

    [Column("piz_personel_aciklama")]
    [StringLength(500)]
    public string? PizPersonelAciklama { get; set; }

    [Column("piz_yonetici_aciklama")]
    [StringLength(500)]
    public string? PizYoneticiAciklama { get; set; }

    [Column("piz_onay_durumu")]
    [StringLength(50)]
    public string? PizOnayDurumu { get; set; }

    [Column("piz_onay_aciklama")]
    [StringLength(500)]
    public string? PizOnayAciklama { get; set; }
}
