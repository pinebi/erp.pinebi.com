using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Masraf kalemleri tablosu.
/// Sirket masraf kalemlerinin tanimlanmasini ve takibini saglar.
/// </summary>
[Table("pine_masraf_kalemleri")]
public class PineMasrafKalemleri : BaseEntity
{
    [Column("msk_kod")]
    [StringLength(25)]
    public string MskKod { get; set; } = string.Empty;

    [Column("msk_isim")]
    [StringLength(200)]
    public string MskIsim { get; set; } = string.Empty;

    [Column("msk_gider_tipi_kod")]
    [StringLength(25)]
    public string? MskGiderTipiKod { get; set; }

    [Column("msk_tarih")]
    public DateTime MskTarih { get; set; }

    [Column("msk_tutar")]
    public decimal MskTutar { get; set; } = 0;

    [Column("msk_kdv_orani")]
    public decimal MskKdvOrani { get; set; } = 0;

    [Column("msk_kdv_tutari")]
    public decimal MskKdvTutari { get; set; } = 0;

    [Column("msk_toplam_tutar")]
    public decimal MskToplamTutar { get; set; } = 0;

    [Column("msk_doviz_cinsi")]
    [StringLength(5)]
    public string? MskDovizCinsi { get; set; }

    [Column("msk_doviz_kuru")]
    public decimal MskDovizKuru { get; set; } = 0;

    [Column("msk_cari_kod")]
    [StringLength(25)]
    public string? MskCariKod { get; set; }

    [Column("msk_proje_kodu")]
    [StringLength(25)]
    public string? MskProjeKodu { get; set; }

    [Column("msk_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? MskSorumlulukMerkezi { get; set; }

    [Column("msk_belge_no")]
    [StringLength(25)]
    public string? MskBelgeNo { get; set; }

    [Column("msk_belge_tarih")]
    public DateTime? MskBelgeTarih { get; set; }

    [Column("msk_odeme_sekli")]
    [StringLength(50)]
    public string? MskOdemeSekli { get; set; }

    [Column("msk_aciklama")]
    [StringLength(500)]
    public string? MskAciklama { get; set; }

    [Column("msk_aktif")]
    public bool MskAktif { get; set; } = true;
}
