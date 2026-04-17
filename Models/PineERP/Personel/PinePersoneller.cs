using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personeller")]
public class PinePersoneller : BaseEntity
{
    // Identity
    [Column("per_kod")]
    [StringLength(25)]
    public string? PerKod { get; set; }

    [Column("per_adsoyad")]
    [StringLength(200)]
    public string? PerAdsoyad { get; set; }

    [Column("per_tc_kimlik")]
    [StringLength(15)]
    public string? PerTcKimlik { get; set; }

    [Column("per_sgk_no")]
    [StringLength(20)]
    public string? PerSgkNo { get; set; }

    [Column("per_ozluk_no")]
    [StringLength(20)]
    public string? PerOzlukNo { get; set; }

    // Job
    [Column("per_unvan")]
    [StringLength(100)]
    public string? PerUnvan { get; set; }

    [Column("per_departman_kodu")]
    [StringLength(25)]
    public string? PerDepartmanKodu { get; set; }

    [Column("per_pozisyon_kodu")]
    [StringLength(25)]
    public string? PerPozisyonKodu { get; set; }

    [Column("per_gorev")]
    [StringLength(200)]
    public string? PerGorev { get; set; }

    // Personal
    [Column("per_cinsiyet")]
    [StringLength(5)]
    public string? PerCinsiyet { get; set; }

    [Column("per_uyruk")]
    [StringLength(50)]
    public string? PerUyruk { get; set; }

    [Column("per_kan_grubu")]
    [StringLength(10)]
    public string? PerKanGrubu { get; set; }

    [Column("per_medeni_durum")]
    [StringLength(20)]
    public string? PerMedeniDurum { get; set; }

    [Column("per_dogum_tarihi")]
    public DateTime? PerDogumTarihi { get; set; }

    [Column("per_dogum_yeri")]
    [StringLength(100)]
    public string? PerDogumYeri { get; set; }

    // Contact
    [Column("per_tel")]
    [StringLength(50)]
    public string? PerTel { get; set; }

    [Column("per_gsm")]
    [StringLength(50)]
    public string? PerGsm { get; set; }

    [Column("per_email")]
    [StringLength(200)]
    public string? PerEmail { get; set; }

    [Column("per_adres")]
    [StringLength(500)]
    public string? PerAdres { get; set; }

    [Column("per_sehir")]
    [StringLength(50)]
    public string? PerSehir { get; set; }

    [Column("per_ilce")]
    [StringLength(50)]
    public string? PerIlce { get; set; }

    // Employment
    [Column("per_ise_giris")]
    public DateTime? PerIseGiris { get; set; }

    [Column("per_ise_bitis")]
    public DateTime? PerIseBitis { get; set; }

    [Column("per_ayrilma_sebebi")]
    [StringLength(500)]
    public string? PerAyrilmaSebebi { get; set; }

    [Column("per_calisma_sekli")]
    [StringLength(50)]
    public string? PerCalismaSekli { get; set; }

    // Salary
    [Column("per_maas_turu")]
    [StringLength(50)]
    public string? PerMaasTuru { get; set; }

    [Column("per_net_maas")]
    public decimal PerNetMaas { get; set; }

    [Column("per_brut_maas")]
    public decimal PerBrutMaas { get; set; }

    // Banking
    [Column("per_banka_adi")]
    [StringLength(100)]
    public string? PerBankaAdi { get; set; }

    [Column("per_iban_no")]
    [StringLength(50)]
    public string? PerIbanNo { get; set; }

    // Personal2
    [Column("per_ehliyet_sinifi")]
    [StringLength(20)]
    public string? PerEhliyetSinifi { get; set; }

    [Column("per_askerlik_durumu")]
    [StringLength(50)]
    public string? PerAskerlikDurumu { get; set; }

    [Column("per_acil_kisi")]
    [StringLength(200)]
    public string? PerAcilKisi { get; set; }

    [Column("per_acil_tel")]
    [StringLength(50)]
    public string? PerAcilTel { get; set; }

    // Family
    [Column("per_esi_calisiyormu")]
    public bool PerEsiCalisiyormu { get; set; }

    [Column("per_cocuk_sayisi")]
    public int PerCocukSayisi { get; set; }

    // System
    [Column("per_kasa_kodu")]
    [StringLength(25)]
    public string? PerKasaKodu { get; set; }

    [Column("per_resim_url")]
    [StringLength(500)]
    public string? PerResimUrl { get; set; }

    [Column("per_gorev_sorumluluklar")]
    public string? PerGorevSorumluluklar { get; set; }

    // Flags
    [Column("per_pasif_fl")]
    public bool PerPasifFl { get; set; }

    [Column("per_erp_kullanicisi")]
    public bool PerErpKullanicisi { get; set; }

    [Column("per_isten_ayrildi")]
    public bool PerIstenAyrildi { get; set; }

    // Permissions
    [Column("per_satis_teklifi")]
    public bool PerSatisTeklifi { get; set; }

    [Column("per_planlama")]
    public bool PerPlanlama { get; set; }

    [Column("per_satinalma_talep")]
    public bool PerSatinalmaTalep { get; set; }

    [Column("per_satinalma_emri")]
    public bool PerSatinalmaEmri { get; set; }

    [Column("per_proje_gorme")]
    public bool PerProjeGorme { get; set; }

    [Column("per_muhasebe")]
    public bool PerMuhasebe { get; set; }

    [Column("per_cari_islemler")]
    public bool PerCariIslemler { get; set; }

    [Column("per_satis_islemleri")]
    public bool PerSatisIslemleri { get; set; }

    [Column("per_satinalma_islemleri")]
    public bool PerSatinalmaIslemleri { get; set; }

    [Column("per_personel_islemleri")]
    public bool PerPersonelIslemleri { get; set; }

    [Column("per_efatura_islemleri")]
    public bool PerEfaturaIslemleri { get; set; }

    [Column("per_efatura_gonder")]
    public bool PerEfaturaGonder { get; set; }

    [Column("per_efatura_onay")]
    public bool PerEfaturaOnay { get; set; }

    [Column("per_sirket_profili")]
    public bool PerSirketProfili { get; set; }

    [Column("per_firma_bilgileri")]
    public bool PerFirmaBilgileri { get; set; }

    [Column("per_envanter_yonetimi")]
    public bool PerEnvanterYonetimi { get; set; }

    [Column("per_personel_yonetimi")]
    public bool PerPersonelYonetimi { get; set; }

    [Column("per_firma_analizi")]
    public bool PerFirmaAnalizi { get; set; }

    [Column("per_kullanici_tanimlama")]
    public bool PerKullaniciTanimlama { get; set; }
}
