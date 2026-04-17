using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_tevkifat_kodlari")]
public class PineTevkifatKodlari : BaseEntity
{
    [Column("tvk_kod")]
    [StringLength(20)]
    public string? TvkKod { get; set; }

    [Column("tvk_aciklama")]
    [StringLength(500)]
    public string? TvkAciklama { get; set; }

    [Column("tvk_carpan")]
    public decimal TvkCarpan { get; set; }

    [Column("tvk_bolen")]
    public decimal TvkBolen { get; set; }

    [Column("tvk_hesap_kodu")]
    [StringLength(25)]
    public string? TvkHesapKodu { get; set; }

    [Column("tvk_baslangic_tarihi")]
    public DateTime? TvkBaslangicTarihi { get; set; }

    [Column("tvk_bitis_tarihi")]
    public DateTime? TvkBitisTarihi { get; set; }

    [Column("tvk_aktif")]
    public bool TvkAktif { get; set; } = true;
}
