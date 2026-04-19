using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("depolar")]
public class Depolar
{
    [Column("dep_Guid")]
    public Guid? DepGuid { get; set; }

    [Column("dep_DBCno")]
    public short? DepDBCno { get; set; }

    [Column("dep_SpecRECno")]
    public int? DepSpecRECno { get; set; }

    [Column("dep_iptal")]
    public bool? DepIptal { get; set; }

    [Column("dep_fileid")]
    public short? DepFileid { get; set; }

    [Column("dep_hidden")]
    public bool? DepHidden { get; set; }

    [Column("dep_kilitli")]
    public bool? DepKilitli { get; set; }

    [Column("dep_degisti")]
    public bool? DepDegisti { get; set; }

    [Column("dep_checksum")]
    public int? DepChecksum { get; set; }

    [Column("dep_create_user")]
    public short? DepCreateUser { get; set; }

    [Column("dep_create_date")]
    public DateTime? DepCreateDate { get; set; }

    [Column("dep_lastup_user")]
    public short? DepLastupUser { get; set; }

    [Column("dep_lastup_date")]
    public DateTime? DepLastupDate { get; set; }

    [Column("dep_special1")]
    [StringLength(4)]
    public string? DepSpecial1 { get; set; }

    [Column("dep_special2")]
    [StringLength(4)]
    public string? DepSpecial2 { get; set; }

    [Column("dep_special3")]
    [StringLength(4)]
    public string? DepSpecial3 { get; set; }

    [Column("dep_firmano")]
    public int? DepFirmano { get; set; }

    [Column("dep_subeno")]
    public int? DepSubeno { get; set; }

    [Column("dep_no")]
    public int? DepNo { get; set; }

    [Column("dep_adi")]
    [StringLength(50)]
    public string? DepAdi { get; set; }

    [Column("dep_grup_kodu")]
    [StringLength(25)]
    public string? DepGrupKodu { get; set; }

    [Column("dep_tipi")]
    public byte? DepTipi { get; set; }

    [Column("dep_DepoSevkOtoFiyat")]
    public byte? DepDepoSevkOtoFiyat { get; set; }

    [Column("dep_hareket_tipi")]
    public byte? DepHareketTipi { get; set; }

    [Column("dep_muh_kodu")]
    [StringLength(10)]
    public string? DepMuhKodu { get; set; }

    [Column("dep_sor_mer_kodu")]
    [StringLength(25)]
    public string? DepSorMerKodu { get; set; }

    [Column("dep_proje_kodu")]
    [StringLength(25)]
    public string? DepProjeKodu { get; set; }

    [Column("dep_DepoSevkUygFiyat")]
    public int? DepDepoSevkUygFiyat { get; set; }

    [Column("dep_KilitTarihi")]
    public DateTime? DepKilitTarihi { get; set; }

    [Column("dep_cadde")]
    [StringLength(50)]
    public string? DepCadde { get; set; }

    [Column("dep_mahalle")]
    [StringLength(50)]
    public string? DepMahalle { get; set; }

    [Column("dep_sokak")]
    [StringLength(50)]
    public string? DepSokak { get; set; }

    [Column("dep_Semt")]
    [StringLength(25)]
    public string? DepSemt { get; set; }

    [Column("dep_Apt_No")]
    [StringLength(10)]
    public string? DepAptNo { get; set; }

    [Column("dep_Daire_No")]
    [StringLength(10)]
    public string? DepDaireNo { get; set; }

    [Column("dep_posta_Kodu")]
    [StringLength(8)]
    public string? DepPostaKodu { get; set; }

    [Column("dep_Ilce")]
    [StringLength(50)]
    public string? DepIlce { get; set; }

    [Column("dep_Il")]
    [StringLength(50)]
    public string? DepIl { get; set; }

    [Column("dep_Ulke")]
    [StringLength(50)]
    public string? DepUlke { get; set; }

    [Column("dep_Adres_kodu")]
    [StringLength(10)]
    public string? DepAdresKodu { get; set; }

    [Column("dep_gps_enlem")]
    public double? DepGpsEnlem { get; set; }

    [Column("dep_gps_boylam")]
    public double? DepGpsBoylam { get; set; }

    [Column("dep_alani")]
    public double? DepAlani { get; set; }

    [Column("dep_rafhacmi")]
    public double? DepRafhacmi { get; set; }

    [Column("dep_yetkili_email")]
    [StringLength(50)]
    public string? DepYetkiliEmail { get; set; }

    [Column("dep_satis_alani")]
    public double? DepSatisAlani { get; set; }

    [Column("dep_sergi_alani")]
    public double? DepSergiAlani { get; set; }

    [Column("dep_otopark_alani")]
    public double? DepOtoparkAlani { get; set; }

    [Column("dep_otopark_kapasite")]
    public int? DepOtoparkKapasite { get; set; }

    [Column("dep_kasa_sayisi")]
    public int? DepKasaSayisi { get; set; }

    [Column("dep_kamyon_kasa_hacmi")]
    public double? DepKamyonKasaHacmi { get; set; }

    [Column("dep_kamyon_istiab_haddi")]
    public double? DepKamyonIstiabHaddi { get; set; }

    [Column("dep_dizin_adi")]
    [StringLength(50)]
    public string? DepDizinAdi { get; set; }

    [Column("dep_tel_ulke_kodu")]
    [StringLength(5)]
    public string? DepTelUlkeKodu { get; set; }

    [Column("dep_tel_bolge_kodu")]
    [StringLength(5)]
    public string? DepTelBolgeKodu { get; set; }

    [Column("dep_tel_no1")]
    [StringLength(10)]
    public string? DepTelNo1 { get; set; }

    [Column("dep_tel_no2")]
    [StringLength(10)]
    public string? DepTelNo2 { get; set; }

    [Column("dep_tel_faxno")]
    [StringLength(10)]
    public string? DepTelFaxno { get; set; }

    [Column("dep_tel_modem")]
    [StringLength(10)]
    public string? DepTelModem { get; set; }

    [Column("dep_envanter_harici_fl")]
    public bool? DepEnvanterHariciFl { get; set; }

    [Column("dep_detay_takibi")]
    public byte? DepDetayTakibi { get; set; }

    [Column("dep_barkod_yazici_yolu")]
    [StringLength(50)]
    public string? DepBarkodYaziciYolu { get; set; }

    [Column("dep_fason_sor_mer_kodu")]
    [StringLength(25)]
    public string? DepFasonSorMerKodu { get; set; }

    [Column("dep_EksiyeDusurenStkHar")]
    public byte? DepEksiyeDusurenStkHar { get; set; }

    [Column("dep_BagliOrtakliklaraSatisUygFiyat")]
    public byte? DepBagliOrtakliklaraSatisUygFiyat { get; set; }

    [Column("dep_bolge_kodu")]
    [StringLength(25)]
    public string? DepBolgeKodu { get; set; }

    [Column("dep_NakliyefisiSatisFiyatTipi")]
    public byte? DepNakliyefisiSatisFiyatTipi { get; set; }
}
