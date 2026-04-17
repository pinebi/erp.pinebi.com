using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Banka kredi taksit detaylari tablosu.
/// Kredinin aylik odeme planini tutar.
/// </summary>
[Table("pine_banka_kredi_detay")]
public class PineBankaKrediDetay : BaseEntity
{
    [Column("bkd_kredi_id")]
    public int BkdKrediId { get; set; }

    [Column("bkd_sira")]
    public int BkdSira { get; set; }

    [Column("bkd_tarih")]
    public DateTime? BkdTarih { get; set; }

    [Column("bkd_yil")]
    public int BkdYil { get; set; }

    [Column("bkd_ay")]
    public int BkdAy { get; set; }

    [Column("bkd_ay_adi")]
    [StringLength(20)]
    public string? BkdAyAdi { get; set; }

    [Column("bkd_tutar")]
    public decimal BkdTutar { get; set; } = 0;

    [Column("bkd_odendi")]
    public bool BkdOdendi { get; set; } = false;
}
