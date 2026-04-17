using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_saglik_raporlari")]
public class PinePersonelSaglikRaporlari : BaseEntity
{
    [Column("psr_personel_kod")]
    [StringLength(25)]
    public string? PsrPersonelKod { get; set; }

    [Column("psr_adsoyad")]
    [StringLength(200)]
    public string? PsrAdsoyad { get; set; }

    [Column("psr_rapor_tarihi")]
    public DateTime? PsrRaporTarihi { get; set; }

    [Column("psr_rapor_bitis")]
    public DateTime? PsrRaporBitis { get; set; }

    [Column("psr_gun_sayisi")]
    public int PsrGunSayisi { get; set; }

    [Column("psr_rapor_turu")]
    [StringLength(100)]
    public string? PsrRaporTuru { get; set; }

    [Column("psr_hastane")]
    [StringLength(200)]
    public string? PsrHastane { get; set; }

    [Column("psr_doktor")]
    [StringLength(200)]
    public string? PsrDoktor { get; set; }

    [Column("psr_tani")]
    [StringLength(500)]
    public string? PsrTani { get; set; }

    [Column("psr_aciklama")]
    [StringLength(500)]
    public string? PsrAciklama { get; set; }
}
