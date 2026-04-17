using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Kasa hareketleri tablosu.
/// Kasaya yapilan tum giris/cikis hareketlerini tutar.
/// </summary>
[Table("pine_kasa_hareketleri")]
public class PineKasaHareketleri : BaseEntity
{
    // ===== KASA BILGISI =====

    [Column("ksh_kasa_kod")]
    [StringLength(25)]
    public string KshKasaKod { get; set; } = string.Empty;

    [Column("ksh_tarih")]
    public DateTime KshTarih { get; set; }

    /// <summary>Hareket tipi: 0=Giris, 1=Cikis</summary>
    [Column("ksh_tip")]
    public int KshTip { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("ksh_evrak_seri")]
    [StringLength(5)]
    public string? KshEvrakSeri { get; set; }

    [Column("ksh_evrak_sira")]
    public int KshEvrakSira { get; set; } = 0;

    [Column("ksh_belge_no")]
    [StringLength(25)]
    public string? KshBelgeNo { get; set; }

    [Column("ksh_belge_tarih")]
    public DateTime? KshBelgeTarih { get; set; }

    // ===== TUTAR =====

    [Column("ksh_tutar")]
    public decimal KshTutar { get; set; } = 0;

    // ===== DOVIZ =====

    [Column("ksh_doviz_cinsi")]
    [StringLength(5)]
    public string? KshDovizCinsi { get; set; }

    [Column("ksh_doviz_kuru")]
    public decimal KshDovizKuru { get; set; } = 0;

    // ===== CARI / REFERANS =====

    [Column("ksh_cari_kod")]
    [StringLength(25)]
    public string? KshCariKod { get; set; }

    [Column("ksh_proje_kodu")]
    [StringLength(25)]
    public string? KshProjeKodu { get; set; }

    [Column("ksh_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? KshSorumlulukMerkezi { get; set; }

    // ===== HAREKET CINSI =====

    /// <summary>Hareket cinsi: 0=Nakit, 1=Virman, 2=Tahsilat, 3=Odeme</summary>
    [Column("ksh_hareket_cinsi")]
    public int KshHareketCinsi { get; set; } = 0;

    [Column("ksh_karsi_kasa_kod")]
    [StringLength(25)]
    public string? KshKarsiKasaKod { get; set; }

    // ===== ILISKILI BELGE =====

    [Column("ksh_fatura_uid")]
    public Guid? KshFaturaUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("ksh_aciklama1")]
    [StringLength(500)]
    public string? KshAciklama1 { get; set; }

    [Column("ksh_aciklama2")]
    [StringLength(500)]
    public string? KshAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("ksh_ozelkod1")]
    [StringLength(50)]
    public string? KshOzelkod1 { get; set; }

    [Column("ksh_ozelkod2")]
    [StringLength(50)]
    public string? KshOzelkod2 { get; set; }

    [Column("ksh_ozelkod3")]
    [StringLength(50)]
    public string? KshOzelkod3 { get; set; }
}
