using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Banka hareketleri tablosu.
/// Banka hesaplarina yapilan tum giris/cikis hareketlerini tutar.
/// KasaHareketleri ile ayni pattern.
/// </summary>
[Table("pine_banka_hareketleri")]
public class PineBankaHareketleri : BaseEntity
{
    // ===== HESAP BILGISI =====

    [Column("bnh_hesap_kod")]
    [StringLength(25)]
    public string BnhHesapKod { get; set; } = string.Empty;

    [Column("bnh_tarih")]
    public DateTime BnhTarih { get; set; }

    /// <summary>Hareket tipi: 0=Giris, 1=Cikis</summary>
    [Column("bnh_tip")]
    public int BnhTip { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("bnh_evrak_seri")]
    [StringLength(5)]
    public string? BnhEvrakSeri { get; set; }

    [Column("bnh_evrak_sira")]
    public int BnhEvrakSira { get; set; } = 0;

    [Column("bnh_belge_no")]
    [StringLength(25)]
    public string? BnhBelgeNo { get; set; }

    [Column("bnh_belge_tarih")]
    public DateTime? BnhBelgeTarih { get; set; }

    // ===== TUTAR =====

    [Column("bnh_tutar")]
    public decimal BnhTutar { get; set; } = 0;

    // ===== DOVIZ =====

    [Column("bnh_doviz_cinsi")]
    [StringLength(5)]
    public string? BnhDovizCinsi { get; set; }

    [Column("bnh_doviz_kuru")]
    public decimal BnhDovizKuru { get; set; } = 0;

    // ===== CARI / REFERANS =====

    [Column("bnh_cari_kod")]
    [StringLength(25)]
    public string? BnhCariKod { get; set; }

    [Column("bnh_proje_kodu")]
    [StringLength(25)]
    public string? BnhProjeKodu { get; set; }

    [Column("bnh_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? BnhSorumlulukMerkezi { get; set; }

    // ===== HAREKET CINSI =====

    /// <summary>Hareket cinsi: 0=Havale, 1=EFT, 2=Virman, 3=Tahsilat, 4=Odeme</summary>
    [Column("bnh_hareket_cinsi")]
    public int BnhHareketCinsi { get; set; } = 0;

    [Column("bnh_karsi_hesap_kod")]
    [StringLength(25)]
    public string? BnhKarsiHesapKod { get; set; }

    // ===== ILISKILI BELGE =====

    [Column("bnh_fatura_uid")]
    public Guid? BnhFaturaUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("bnh_aciklama1")]
    [StringLength(500)]
    public string? BnhAciklama1 { get; set; }

    [Column("bnh_aciklama2")]
    [StringLength(500)]
    public string? BnhAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("bnh_ozelkod1")]
    [StringLength(50)]
    public string? BnhOzelkod1 { get; set; }

    [Column("bnh_ozelkod2")]
    [StringLength(50)]
    public string? BnhOzelkod2 { get; set; }

    [Column("bnh_ozelkod3")]
    [StringLength(50)]
    public string? BnhOzelkod3 { get; set; }
}
