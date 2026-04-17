using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_doviz_kurlari")]
public class PineDovizKurlari : BaseEntity
{
    [Column("dvk_tarih")]
    public DateTime DvkTarih { get; set; }

    [Column("dvk_doviz_kodu")]
    [StringLength(10)]
    public string? DvkDovizKodu { get; set; }

    [Column("dvk_doviz_isim")]
    [StringLength(50)]
    public string? DvkDovizIsim { get; set; }

    [Column("dvk_alis")]
    public decimal DvkAlis { get; set; }

    [Column("dvk_satis")]
    public decimal DvkSatis { get; set; }

    [Column("dvk_efektif_alis")]
    public decimal? DvkEfektifAlis { get; set; }

    [Column("dvk_efektif_satis")]
    public decimal? DvkEfektifSatis { get; set; }

    [Column("dvk_kaynak")]
    [StringLength(100)]
    public string? DvkKaynak { get; set; }
}
