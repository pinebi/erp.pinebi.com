using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cariye ozel fiyat tanimlari.
/// Belirli stok kartlari icin cariye ozel fiyat, iskonto vb. tanimlar.
/// </summary>
[Table("pine_cari_fiyatlar")]
public class PineCariFiyatlar : BaseEntity
{
    [Column("cfi_cari_kod")]
    [StringLength(25)]
    public string CfiCariKod { get; set; } = string.Empty;

    [Column("cfi_stok_kod")]
    [StringLength(25)]
    public string? CfiStokKod { get; set; }

    [Column("cfi_stok_grup_kodu")]
    [StringLength(25)]
    public string? CfiStokGrupKodu { get; set; }

    /// <summary>1=Satis, 2=Alis</summary>
    [Column("cfi_fiyat_tipi")]
    public int CfiFiyatTipi { get; set; }

    [Column("cfi_fiyat")]
    public decimal CfiFiyat { get; set; }

    [Column("cfi_doviz_cinsi")]
    [StringLength(5)]
    public string? CfiDovizCinsi { get; set; }

    [Column("cfi_iskonto_orani1")]
    public decimal CfiIskontoOrani1 { get; set; }

    [Column("cfi_iskonto_orani2")]
    public decimal CfiIskontoOrani2 { get; set; }

    [Column("cfi_iskonto_orani3")]
    public decimal CfiIskontoOrani3 { get; set; }

    [Column("cfi_baslangic_tarihi")]
    public DateTime? CfiBaslangicTarihi { get; set; }

    [Column("cfi_bitis_tarihi")]
    public DateTime? CfiBitisTarihi { get; set; }

    [Column("cfi_minimum_miktar")]
    public decimal CfiMinimumMiktar { get; set; }

    [Column("cfi_pasif_fl")]
    public bool CfiPasifFl { get; set; }

    [Column("cfi_aciklama")]
    [StringLength(500)]
    public string? CfiAciklama { get; set; }
}
