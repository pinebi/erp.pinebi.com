using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Teklif;

/// <summary>
/// Teklif ana tablosu.
/// Verilen ve alinan teklifleri tutar.
/// Faturalar tablosu ile benzer yapida, ek teklif alanlari icerir.
/// </summary>
[Table("pine_teklifler")]
public class PineTeklifler : BaseEntity
{
    // ===== TEMEL BILGILER =====

    /// <summary>Teklif tipi: 0=Verilen, 1=Alinan</summary>
    [Column("tek_teklif_tipi")]
    public int TekTeklifTipi { get; set; }

    /// <summary>0=Normal, 1=Iade</summary>
    [Column("tek_normal_iade")]
    public int TekNormalIade { get; set; } = 0;

    [Column("tek_cari_kod")]
    [StringLength(25)]
    public string TekCariKod { get; set; } = string.Empty;

    [Column("tek_cari_unvan")]
    [StringLength(300)]
    public string? TekCariUnvan { get; set; }

    // ===== TARIH =====

    [Column("tek_tarih")]
    public DateTime TekTarih { get; set; }

    [Column("tek_gecerlilik_tarihi")]
    public DateTime? TekGecerlilikTarihi { get; set; }

    // ===== ONAY =====

    /// <summary>Onay durumu: Beklemede, Onaylandi, Reddedildi, Revize</summary>
    [Column("tek_onay_durumu")]
    [StringLength(50)]
    public string? TekOnayDurumu { get; set; }

    [Column("tek_onay_tarihi")]
    public DateTime? TekOnayTarihi { get; set; }

    [Column("tek_onay_kullanici")]
    [StringLength(200)]
    public string? TekOnayKullanici { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("tek_evrak_seri")]
    [StringLength(5)]
    public string? TekEvrakSeri { get; set; }

    [Column("tek_evrak_sira")]
    public int TekEvrakSira { get; set; } = 0;

    [Column("tek_belge_no")]
    [StringLength(25)]
    public string? TekBelgeNo { get; set; }

    [Column("tek_belge_tarih")]
    public DateTime? TekBelgeTarih { get; set; }

    // ===== SEVK BILGILERI =====

    [Column("tek_sevk_adres1")]
    [StringLength(500)]
    public string? TekSevkAdres1 { get; set; }

    [Column("tek_sevk_adres2")]
    [StringLength(500)]
    public string? TekSevkAdres2 { get; set; }

    [Column("tek_sevk_sehir")]
    [StringLength(50)]
    public string? TekSevkSehir { get; set; }

    [Column("tek_sevk_ilce")]
    [StringLength(50)]
    public string? TekSevkIlce { get; set; }

    [Column("tek_sevk_posta_kodu")]
    [StringLength(10)]
    public string? TekSevkPostaKodu { get; set; }

    [Column("tek_sevk_ulke")]
    [StringLength(50)]
    public string? TekSevkUlke { get; set; }

    // ===== ODEME / VADE =====

    [Column("tek_odeme_sekli")]
    [StringLength(50)]
    public string? TekOdemeSekli { get; set; }

    [Column("tek_vade_gun")]
    public int TekVadeGun { get; set; } = 0;

    [Column("tek_vade_tarihi")]
    public DateTime? TekVadeTarihi { get; set; }

    // ===== DOVIZ =====

    [Column("tek_doviz_cinsi")]
    [StringLength(5)]
    public string? TekDovizCinsi { get; set; }

    [Column("tek_doviz_kuru")]
    public decimal TekDovizKuru { get; set; } = 0;

    // ===== TOPLAM TUTARLAR =====

    [Column("tek_toplam")]
    public decimal TekToplam { get; set; } = 0;

    [Column("tek_iskonto")]
    public decimal TekIskonto { get; set; } = 0;

    [Column("tek_toplam_iskonto")]
    public decimal TekToplamIskonto { get; set; } = 0;

    [Column("tek_kdv")]
    public decimal TekKdv { get; set; } = 0;

    [Column("tek_otv")]
    public decimal TekOtv { get; set; } = 0;

    [Column("tek_tevkifat")]
    public decimal TekTevkifat { get; set; } = 0;

    [Column("tek_genel_toplam")]
    public decimal TekGenelToplam { get; set; } = 0;

    // ===== REFERANS BILGILERI =====

    [Column("tek_proje_kodu")]
    [StringLength(25)]
    public string? TekProjeKodu { get; set; }

    [Column("tek_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? TekSorumlulukMerkezi { get; set; }

    [Column("tek_plasiyer_kodu")]
    [StringLength(25)]
    public string? TekPlasiyerKodu { get; set; }

    [Column("tek_depo_no")]
    public int TekDepoNo { get; set; } = 0;

    // ===== VERGI BILGILERI =====

    [Column("tek_vergi_dairesi")]
    [StringLength(100)]
    public string? TekVergiDairesi { get; set; }

    [Column("tek_vergi_no")]
    [StringLength(20)]
    public string? TekVergiNo { get; set; }

    // ===== ILISKILI BELGELER =====

    [Column("tek_siparis_uid")]
    public Guid? TekSiparisUid { get; set; }

    [Column("tek_fatura_uid")]
    public Guid? TekFaturaUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("tek_aciklama1")]
    [StringLength(500)]
    public string? TekAciklama1 { get; set; }

    [Column("tek_aciklama2")]
    [StringLength(500)]
    public string? TekAciklama2 { get; set; }

    [Column("tek_aciklama3")]
    [StringLength(500)]
    public string? TekAciklama3 { get; set; }

    [Column("tek_aciklama4")]
    [StringLength(500)]
    public string? TekAciklama4 { get; set; }

    [Column("tek_aciklama5")]
    [StringLength(500)]
    public string? TekAciklama5 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("tek_ozelkod1")]
    [StringLength(50)]
    public string? TekOzelkod1 { get; set; }

    [Column("tek_ozelkod2")]
    [StringLength(50)]
    public string? TekOzelkod2 { get; set; }

    [Column("tek_ozelkod3")]
    [StringLength(50)]
    public string? TekOzelkod3 { get; set; }

    [Column("tek_ozelkod4")]
    [StringLength(50)]
    public string? TekOzelkod4 { get; set; }

    [Column("tek_ozelkod5")]
    [StringLength(50)]
    public string? TekOzelkod5 { get; set; }

    // ===== YAZDIRMA =====

    [Column("tek_basildi")]
    public bool TekBasildi { get; set; } = false;

    [Column("tek_email_gonderildi")]
    public bool TekEmailGonderildi { get; set; } = false;
}
