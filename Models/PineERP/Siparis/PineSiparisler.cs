using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Siparis;

/// <summary>
/// Siparis ana tablosu.
/// Satis ve satinalma siparislerini tutar.
/// Faturalar tablosu ile ayni yapida, ek siparis alanlari icerir.
/// </summary>
[Table("pine_siparisler")]
public class PineSiparisler : BaseEntity
{
    // ===== TEMEL BILGILER =====

    /// <summary>Siparis tipi: 0=Satis, 1=Satinalma</summary>
    [Column("sip_tip")]
    public int SipTip { get; set; }

    /// <summary>0=Normal, 1=Iade</summary>
    [Column("sip_normal_iade")]
    public int SipNormalIade { get; set; } = 0;

    [Column("sip_cari_kod")]
    [StringLength(25)]
    public string SipCariKod { get; set; } = string.Empty;

    [Column("sip_cari_unvan")]
    [StringLength(300)]
    public string? SipCariUnvan { get; set; }

    // ===== TARIH =====

    [Column("sip_tarih")]
    public DateTime SipTarih { get; set; }

    [Column("sip_teslim_tarihi")]
    public DateTime? SipTeslimTarihi { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("sip_evrak_seri")]
    [StringLength(5)]
    public string? SipEvrakSeri { get; set; }

    [Column("sip_evrak_sira")]
    public int SipEvrakSira { get; set; } = 0;

    [Column("sip_belge_no")]
    [StringLength(25)]
    public string? SipBelgeNo { get; set; }

    [Column("sip_belge_tarih")]
    public DateTime? SipBelgeTarih { get; set; }

    // ===== SIPARIS DURUMU =====

    /// <summary>Acik, Kapali, KismiTeslim, Iptal</summary>
    [Column("sip_siparis_durumu")]
    [StringLength(50)]
    public string SipSiparisDurumu { get; set; } = "Acik";

    [Column("sip_teslim_sekli")]
    [StringLength(50)]
    public string? SipTeslimSekli { get; set; }

    // ===== SEVK BILGILERI =====

    [Column("sip_sevk_adres1")]
    [StringLength(500)]
    public string? SipSevkAdres1 { get; set; }

    [Column("sip_sevk_adres2")]
    [StringLength(500)]
    public string? SipSevkAdres2 { get; set; }

    [Column("sip_sevk_sehir")]
    [StringLength(50)]
    public string? SipSevkSehir { get; set; }

    [Column("sip_sevk_ilce")]
    [StringLength(50)]
    public string? SipSevkIlce { get; set; }

    [Column("sip_sevk_posta_kodu")]
    [StringLength(10)]
    public string? SipSevkPostaKodu { get; set; }

    [Column("sip_sevk_ulke")]
    [StringLength(50)]
    public string? SipSevkUlke { get; set; }

    // ===== ODEME / VADE =====

    [Column("sip_odeme_sekli")]
    [StringLength(50)]
    public string? SipOdemeSekli { get; set; }

    [Column("sip_vade_gun")]
    public int SipVadeGun { get; set; } = 0;

    [Column("sip_vade_tarihi")]
    public DateTime? SipVadeTarihi { get; set; }

    // ===== DOVIZ =====

    [Column("sip_doviz_cinsi")]
    [StringLength(5)]
    public string? SipDovizCinsi { get; set; }

    [Column("sip_doviz_kuru")]
    public decimal SipDovizKuru { get; set; } = 0;

    // ===== TOPLAM TUTARLAR =====

    [Column("sip_toplam")]
    public decimal SipToplam { get; set; } = 0;

    [Column("sip_iskonto")]
    public decimal SipIskonto { get; set; } = 0;

    [Column("sip_toplam_iskonto")]
    public decimal SipToplamIskonto { get; set; } = 0;

    [Column("sip_kdv")]
    public decimal SipKdv { get; set; } = 0;

    [Column("sip_otv")]
    public decimal SipOtv { get; set; } = 0;

    [Column("sip_tevkifat")]
    public decimal SipTevkifat { get; set; } = 0;

    [Column("sip_genel_toplam")]
    public decimal SipGenelToplam { get; set; } = 0;

    [Column("sip_teslim_edilen_tutar")]
    public decimal SipTeslimEdilenTutar { get; set; } = 0;

    [Column("sip_kalan_tutar")]
    public decimal SipKalanTutar { get; set; } = 0;

    // ===== REFERANS BILGILERI =====

    [Column("sip_proje_kodu")]
    [StringLength(25)]
    public string? SipProjeKodu { get; set; }

    [Column("sip_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? SipSorumlulukMerkezi { get; set; }

    [Column("sip_plasiyer_kodu")]
    [StringLength(25)]
    public string? SipPlasiyerKodu { get; set; }

    [Column("sip_depo_no")]
    public int SipDepoNo { get; set; } = 0;

    // ===== VERGI BILGILERI =====

    [Column("sip_vergi_dairesi")]
    [StringLength(100)]
    public string? SipVergiDairesi { get; set; }

    [Column("sip_vergi_no")]
    [StringLength(20)]
    public string? SipVergiNo { get; set; }

    // ===== ILISKILI BELGELER =====

    [Column("sip_fatura_uid")]
    public Guid? SipFaturaUid { get; set; }

    [Column("sip_irsaliye_uid")]
    public Guid? SipIrsaliyeUid { get; set; }

    [Column("sip_teklif_uid")]
    public Guid? SipTeklifUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("sip_aciklama1")]
    [StringLength(500)]
    public string? SipAciklama1 { get; set; }

    [Column("sip_aciklama2")]
    [StringLength(500)]
    public string? SipAciklama2 { get; set; }

    [Column("sip_aciklama3")]
    [StringLength(500)]
    public string? SipAciklama3 { get; set; }

    [Column("sip_aciklama4")]
    [StringLength(500)]
    public string? SipAciklama4 { get; set; }

    [Column("sip_aciklama5")]
    [StringLength(500)]
    public string? SipAciklama5 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("sip_ozelkod1")]
    [StringLength(50)]
    public string? SipOzelkod1 { get; set; }

    [Column("sip_ozelkod2")]
    [StringLength(50)]
    public string? SipOzelkod2 { get; set; }

    [Column("sip_ozelkod3")]
    [StringLength(50)]
    public string? SipOzelkod3 { get; set; }

    [Column("sip_ozelkod4")]
    [StringLength(50)]
    public string? SipOzelkod4 { get; set; }

    [Column("sip_ozelkod5")]
    [StringLength(50)]
    public string? SipOzelkod5 { get; set; }

    // ===== YAZDIRMA =====

    [Column("sip_basildi")]
    public bool SipBasildi { get; set; } = false;

    [Column("sip_email_gonderildi")]
    public bool SipEmailGonderildi { get; set; } = false;

    // ===== ONAY =====

    [Column("sip_onaylandi")]
    public bool SipOnaylandi { get; set; } = false;

    [Column("sip_onay_tarihi")]
    public DateTime? SipOnayTarihi { get; set; }

    [Column("sip_onay_kullanici")]
    [StringLength(200)]
    public string? SipOnayKullanici { get; set; }
}
