using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Banka kredi bilgileri tablosu.
/// Cekilen banka kredilerinin ana bilgilerini tutar.
/// </summary>
[Table("pine_banka_kredi_bilgileri")]
public class PineBankaKrediBilgileri : BaseEntity
{
    [Column("bkr_tarih")]
    public DateTime BkrTarih { get; set; }

    [Column("bkr_kredi_turu")]
    [StringLength(50)]
    public string? BkrKrediTuru { get; set; }

    [Column("bkr_banka_kodu")]
    [StringLength(25)]
    public string? BkrBankaKodu { get; set; }

    [Column("bkr_banka_adi")]
    [StringLength(100)]
    public string? BkrBankaAdi { get; set; }

    [Column("bkr_kredi_tutari")]
    public decimal BkrKrediTutari { get; set; } = 0;

    [Column("bkr_kredi_vadesi")]
    public int BkrKrediVadesi { get; set; } = 0;

    [Column("bkr_faiz_tutari")]
    public decimal BkrFaizTutari { get; set; } = 0;

    [Column("bkr_geri_odenecek")]
    public decimal BkrGeriOdenecek { get; set; } = 0;

    [Column("bkr_ilk_odeme_tarihi")]
    public DateTime? BkrIlkOdemeTarihi { get; set; }

    [Column("bkr_aylik_odeme")]
    public decimal BkrAylikOdeme { get; set; } = 0;

    [Column("bkr_kapandi")]
    public bool BkrKapandi { get; set; } = false;
}
