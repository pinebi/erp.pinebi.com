using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesap ana karti.
/// Musteri, tedarikci ve diger cari hesap bilgilerini tutar.
/// </summary>
[Table("pine_cari_hesaplar")]
public class PineCariHesaplar : BaseEntity
{
    // ── Identity ──────────────────────────────────────────
    [Column("car_kod")]
    [StringLength(25)]
    public string CarKod { get; set; } = string.Empty;

    [Column("car_unvan1")]
    [StringLength(300)]
    public string? CarUnvan1 { get; set; }

    [Column("car_unvan2")]
    [StringLength(300)]
    public string? CarUnvan2 { get; set; }

    [Column("car_kisa_isim")]
    [StringLength(50)]
    public string? CarKisaIsim { get; set; }

    // ── Type ──────────────────────────────────────────────
    /// <summary>0=Musteri, 1=Tedarikci, 2=Her ikisi</summary>
    [Column("car_tipi")]
    public int CarTipi { get; set; }

    [Column("car_hareket_tipi")]
    public int CarHareketTipi { get; set; }

    /// <summary>0=Musteri, 1=Bayi, 2=Temsilci, 3=Distributor</summary>
    [Column("car_baglanti_tipi")]
    public int CarBaglantiTipi { get; set; }

    // ── Groups ────────────────────────────────────────────
    [Column("car_grup_kodu")]
    [StringLength(25)]
    public string? CarGrupKodu { get; set; }

    [Column("car_sektor_kodu")]
    [StringLength(25)]
    public string? CarSektorKodu { get; set; }

    [Column("car_bolge_kodu")]
    [StringLength(25)]
    public string? CarBolgeKodu { get; set; }

    [Column("car_plasiyer_kodu")]
    [StringLength(25)]
    public string? CarPlasiyerKodu { get; set; }

    // ── Price ─────────────────────────────────────────────
    [Column("car_fiyat_grubu")]
    public int CarFiyatGrubu { get; set; } = 1;

    [Column("car_iskonto_orani")]
    public decimal CarIskontoOrani { get; set; }

    // ── Finance ───────────────────────────────────────────
    /// <summary>Vade suresi (gun)</summary>
    [Column("car_vade_suresi")]
    public int CarVadeSuresi { get; set; }

    [Column("car_risk_limiti")]
    public decimal CarRiskLimiti { get; set; }

    [Column("car_para_birimi")]
    [StringLength(5)]
    public string? CarParaBirimi { get; set; }

    [Column("car_odeme_sekli")]
    [StringLength(50)]
    public string? CarOdemeSekli { get; set; }

    // ── Tax ───────────────────────────────────────────────
    [Column("car_vergi_dairesi")]
    [StringLength(100)]
    public string? CarVergiDairesi { get; set; }

    [Column("car_vergi_no")]
    [StringLength(20)]
    public string? CarVergiNo { get; set; }

    [Column("car_tc_kimlik")]
    [StringLength(15)]
    public string? CarTcKimlik { get; set; }

    [Column("car_mersis_no")]
    [StringLength(20)]
    public string? CarMersisNo { get; set; }

    [Column("car_kep_adresi")]
    [StringLength(200)]
    public string? CarKepAdresi { get; set; }

    [Column("car_nace_kodu")]
    [StringLength(20)]
    public string? CarNaceKodu { get; set; }

    // ── Address ───────────────────────────────────────────
    [Column("car_adres1")]
    [StringLength(500)]
    public string? CarAdres1 { get; set; }

    [Column("car_adres2")]
    [StringLength(500)]
    public string? CarAdres2 { get; set; }

    [Column("car_posta_kodu")]
    [StringLength(10)]
    public string? CarPostaKodu { get; set; }

    [Column("car_ulke_kodu")]
    [StringLength(5)]
    public string? CarUlkeKodu { get; set; }

    [Column("car_sehir_kodu")]
    public int CarSehirKodu { get; set; }

    [Column("car_ilce_kodu")]
    public int CarIlceKodu { get; set; }

    [Column("car_il")]
    [StringLength(50)]
    public string? CarIl { get; set; }

    [Column("car_ilce")]
    [StringLength(50)]
    public string? CarIlce { get; set; }

    [Column("car_ulke")]
    [StringLength(50)]
    public string? CarUlke { get; set; }

    // ── Contact ───────────────────────────────────────────
    [Column("car_tel1")]
    [StringLength(50)]
    public string? CarTel1 { get; set; }

    [Column("car_tel2")]
    [StringLength(50)]
    public string? CarTel2 { get; set; }

    [Column("car_faks")]
    [StringLength(50)]
    public string? CarFaks { get; set; }

    [Column("car_gsm")]
    [StringLength(50)]
    public string? CarGsm { get; set; }

    [Column("car_email")]
    [StringLength(200)]
    public string? CarEmail { get; set; }

    [Column("car_web")]
    [StringLength(200)]
    public string? CarWeb { get; set; }

    // ── Bank 1 ────────────────────────────────────────────
    [Column("car_banka1_adi")]
    [StringLength(100)]
    public string? CarBanka1Adi { get; set; }

    [Column("car_banka1_sube")]
    [StringLength(100)]
    public string? CarBanka1Sube { get; set; }

    [Column("car_banka1_hesap")]
    [StringLength(50)]
    public string? CarBanka1Hesap { get; set; }

    [Column("car_banka1_iban")]
    [StringLength(50)]
    public string? CarBanka1Iban { get; set; }

    [Column("car_banka1_swift")]
    [StringLength(20)]
    public string? CarBanka1Swift { get; set; }

    // ── Bank 2 ────────────────────────────────────────────
    [Column("car_banka2_adi")]
    [StringLength(100)]
    public string? CarBanka2Adi { get; set; }

    [Column("car_banka2_sube")]
    [StringLength(100)]
    public string? CarBanka2Sube { get; set; }

    [Column("car_banka2_hesap")]
    [StringLength(50)]
    public string? CarBanka2Hesap { get; set; }

    [Column("car_banka2_iban")]
    [StringLength(50)]
    public string? CarBanka2Iban { get; set; }

    [Column("car_banka2_swift")]
    [StringLength(20)]
    public string? CarBanka2Swift { get; set; }

    // ── Bank 3 ────────────────────────────────────────────
    [Column("car_banka3_adi")]
    [StringLength(100)]
    public string? CarBanka3Adi { get; set; }

    [Column("car_banka3_sube")]
    [StringLength(100)]
    public string? CarBanka3Sube { get; set; }

    [Column("car_banka3_hesap")]
    [StringLength(50)]
    public string? CarBanka3Hesap { get; set; }

    [Column("car_banka3_iban")]
    [StringLength(50)]
    public string? CarBanka3Iban { get; set; }

    [Column("car_banka3_swift")]
    [StringLength(20)]
    public string? CarBanka3Swift { get; set; }

    // ── E-Invoice ─────────────────────────────────────────
    [Column("car_efatura_fl")]
    public bool CarEfaturaFl { get; set; }

    [Column("car_eirsaliye_fl")]
    public bool CarEirsaliyeFl { get; set; }

    [Column("car_efatura_urn_mail")]
    [StringLength(200)]
    public string? CarEfaturaUrnMail { get; set; }

    [Column("car_eirsaliye_urn_mail")]
    [StringLength(200)]
    public string? CarEirsaliyeUrnMail { get; set; }

    // ── Flags ─────────────────────────────────────────────
    [Column("car_sahis_sirketi")]
    public bool CarSahisSirketi { get; set; }

    [Column("car_yurt_disi")]
    public bool CarYurtDisi { get; set; }

    [Column("car_pasif_fl")]
    public bool CarPasifFl { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("car_aciklama")]
    [StringLength(500)]
    public string? CarAciklama { get; set; }

    [Column("car_not1")]
    [StringLength(500)]
    public string? CarNot1 { get; set; }

    [Column("car_not2")]
    [StringLength(500)]
    public string? CarNot2 { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("car_ozelkod1")]
    [StringLength(50)]
    public string? CarOzelkod1 { get; set; }

    [Column("car_ozelkod2")]
    [StringLength(50)]
    public string? CarOzelkod2 { get; set; }

    [Column("car_ozelkod3")]
    [StringLength(50)]
    public string? CarOzelkod3 { get; set; }

    [Column("car_ozelkod4")]
    [StringLength(50)]
    public string? CarOzelkod4 { get; set; }

    [Column("car_ozelkod5")]
    [StringLength(50)]
    public string? CarOzelkod5 { get; set; }

    // ── Denormalized Balances ─────────────────────────────
    [Column("car_son_islem_tarihi")]
    public DateTime? CarSonIslemTarihi { get; set; }

    [Column("car_toplam_borc")]
    public decimal CarToplamBorc { get; set; }

    [Column("car_toplam_alacak")]
    public decimal CarToplamAlacak { get; set; }

    // ── Map ───────────────────────────────────────────────
    [Column("car_latitude")]
    public decimal? CarLatitude { get; set; }

    [Column("car_longitude")]
    public decimal? CarLongitude { get; set; }
}
