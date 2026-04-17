using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Kredi karti hareketleri tablosu.
/// Kredi karti ile yapilan tahsilat/odeme hareketlerini tutar.
/// BankaHareketleri ile benzer yapida.
/// </summary>
[Table("pine_kredi_karti_hareketleri")]
public class PineKrediKartiHareketleri : BaseEntity
{
    // ===== HESAP BILGISI =====

    [Column("kkh_hesap_kod")]
    [StringLength(25)]
    public string KkhHesapKod { get; set; } = string.Empty;

    [Column("kkh_tarih")]
    public DateTime KkhTarih { get; set; }

    /// <summary>Hareket tipi: 0=Giris(Tahsilat), 1=Cikis(Odeme)</summary>
    [Column("kkh_tip")]
    public int KkhTip { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("kkh_evrak_seri")]
    [StringLength(5)]
    public string? KkhEvrakSeri { get; set; }

    [Column("kkh_evrak_sira")]
    public int KkhEvrakSira { get; set; } = 0;

    [Column("kkh_belge_no")]
    [StringLength(25)]
    public string? KkhBelgeNo { get; set; }

    [Column("kkh_belge_tarih")]
    public DateTime? KkhBelgeTarih { get; set; }

    // ===== TUTAR =====

    [Column("kkh_tutar")]
    public decimal KkhTutar { get; set; } = 0;

    [Column("kkh_taksit_sayisi")]
    public int KkhTaksitSayisi { get; set; } = 1;

    // ===== DOVIZ =====

    [Column("kkh_doviz_cinsi")]
    [StringLength(5)]
    public string? KkhDovizCinsi { get; set; }

    [Column("kkh_doviz_kuru")]
    public decimal KkhDovizKuru { get; set; } = 0;

    // ===== CARI / REFERANS =====

    [Column("kkh_cari_kod")]
    [StringLength(25)]
    public string? KkhCariKod { get; set; }

    [Column("kkh_proje_kodu")]
    [StringLength(25)]
    public string? KkhProjeKodu { get; set; }

    [Column("kkh_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? KkhSorumlulukMerkezi { get; set; }

    // ===== POS / KART =====

    [Column("kkh_pos_no")]
    [StringLength(25)]
    public string? KkhPosNo { get; set; }

    [Column("kkh_provizyon_no")]
    [StringLength(50)]
    public string? KkhProvizyonNo { get; set; }

    // ===== ILISKILI BELGE =====

    [Column("kkh_fatura_uid")]
    public Guid? KkhFaturaUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("kkh_aciklama1")]
    [StringLength(500)]
    public string? KkhAciklama1 { get; set; }

    [Column("kkh_aciklama2")]
    [StringLength(500)]
    public string? KkhAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("kkh_ozelkod1")]
    [StringLength(50)]
    public string? KkhOzelkod1 { get; set; }

    [Column("kkh_ozelkod2")]
    [StringLength(50)]
    public string? KkhOzelkod2 { get; set; }

    [Column("kkh_ozelkod3")]
    [StringLength(50)]
    public string? KkhOzelkod3 { get; set; }
}
