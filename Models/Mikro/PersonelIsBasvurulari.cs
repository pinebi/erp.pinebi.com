using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_is_basvurulari")]
public class PersonelIsBasvurulari
{
    [Column("bas_Guid")]
    public Guid? BasGuid { get; set; }

    [Column("bas_DBCno")]
    public short? BasDBCno { get; set; }

    [Column("bas_SpecRECno")]
    public int? BasSpecRECno { get; set; }

    [Column("bas_iptal")]
    public bool? BasIptal { get; set; }

    [Column("bas_fileid")]
    public short? BasFileid { get; set; }

    [Column("bas_hidden")]
    public bool? BasHidden { get; set; }

    [Column("bas_kilitli")]
    public bool? BasKilitli { get; set; }

    [Column("bas_degisti")]
    public bool? BasDegisti { get; set; }

    [Column("bas_checksum")]
    public int? BasChecksum { get; set; }

    [Column("bas_create_user")]
    public short? BasCreateUser { get; set; }

    [Column("bas_create_date")]
    public DateTime? BasCreateDate { get; set; }

    [Column("bas_lastup_user")]
    public short? BasLastupUser { get; set; }

    [Column("bas_lastup_date")]
    public DateTime? BasLastupDate { get; set; }

    [Column("bas_special1")]
    [StringLength(4)]
    public string? BasSpecial1 { get; set; }

    [Column("bas_special2")]
    [StringLength(4)]
    public string? BasSpecial2 { get; set; }

    [Column("bas_special3")]
    [StringLength(4)]
    public string? BasSpecial3 { get; set; }

    [Column("bas_kodu")]
    [StringLength(25)]
    public string? BasKodu { get; set; }

    [Column("bas_adi")]
    [StringLength(50)]
    public string? BasAdi { get; set; }

    [Column("bas_soyadi")]
    [StringLength(50)]
    public string? BasSoyadi { get; set; }

    [Column("bas_tarih")]
    public DateTime? BasTarih { get; set; }

    [Column("bas_cinsiyet")]
    public byte? BasCinsiyet { get; set; }

    [Column("bas_medeni_hal")]
    public byte? BasMedeniHal { get; set; }

    [Column("bas_dogum_tarih")]
    public DateTime? BasDogumTarih { get; set; }

    [Column("bas_dogum_yer")]
    [StringLength(40)]
    public string? BasDogumYer { get; set; }

    [Column("bas_tahsil_tipi")]
    public byte? BasTahsilTipi { get; set; }

    [Column("bas_askerlik")]
    public byte? BasAskerlik { get; set; }

    [Column("bas_tecil")]
    public byte? BasTecil { get; set; }

    [Column("bas_ehliyet")]
    public byte? BasEhliyet { get; set; }

    [Column("bas_hobi")]
    [StringLength(80)]
    public string? BasHobi { get; set; }

    [Column("bas_ekbilgi")]
    [StringLength(80)]
    public string? BasEkbilgi { get; set; }

    [Column("bas_ulas_cadde")]
    [StringLength(50)]
    public string? BasUlasCadde { get; set; }

    [Column("bas_ulas_mahalle")]
    [StringLength(50)]
    public string? BasUlasMahalle { get; set; }

    [Column("bas_ulas_sokak")]
    [StringLength(50)]
    public string? BasUlasSokak { get; set; }

    [Column("bas_ulas_Semt")]
    [StringLength(25)]
    public string? BasUlasSemt { get; set; }

    [Column("bas_ulas_Apt_No")]
    [StringLength(10)]
    public string? BasUlasAptNo { get; set; }

    [Column("bas_ulas_Daire_No")]
    [StringLength(10)]
    public string? BasUlasDaireNo { get; set; }

    [Column("bas_ulas_posta_kod")]
    [StringLength(8)]
    public string? BasUlasPostaKod { get; set; }

    [Column("bas_ulas_ilce")]
    [StringLength(50)]
    public string? BasUlasIlce { get; set; }

    [Column("bas_ulas_il")]
    [StringLength(50)]
    public string? BasUlasIl { get; set; }

    [Column("bas_ulas_ulke")]
    [StringLength(50)]
    public string? BasUlasUlke { get; set; }

    [Column("bas_ulas_adres_kodu")]
    [StringLength(10)]
    public string? BasUlasAdresKodu { get; set; }

    [Column("bas_ulas_tel1_ulke_kod")]
    [StringLength(5)]
    public string? BasUlasTel1UlkeKod { get; set; }

    [Column("bas_ulas_tel1_bolge_kod")]
    [StringLength(5)]
    public string? BasUlasTel1BolgeKod { get; set; }

    [Column("bas_ulas_tel1_no")]
    [StringLength(10)]
    public string? BasUlasTel1No { get; set; }

    [Column("bas_ulas_tel2_ulke_kod")]
    [StringLength(5)]
    public string? BasUlasTel2UlkeKod { get; set; }

    [Column("bas_ulas_tel2_bolge_kod")]
    [StringLength(5)]
    public string? BasUlasTel2BolgeKod { get; set; }

    [Column("bas_ulas_tel2_no")]
    [StringLength(10)]
    public string? BasUlasTel2No { get; set; }

    [Column("bas_ulas_fax_ulke_kod")]
    [StringLength(5)]
    public string? BasUlasFaxUlkeKod { get; set; }

    [Column("bas_ulas_fax_bolge_kod")]
    [StringLength(5)]
    public string? BasUlasFaxBolgeKod { get; set; }

    [Column("bas_ulas_fax_no")]
    [StringLength(10)]
    public string? BasUlasFaxNo { get; set; }

    [Column("bas_ulas_mail")]
    [StringLength(50)]
    public string? BasUlasMail { get; set; }

    [Column("bas_okul1_tipi")]
    public byte? BasOkul1Tipi { get; set; }

    [Column("bas_okul1_kodu")]
    [StringLength(25)]
    public string? BasOkul1Kodu { get; set; }

    [Column("bas_okul1_adi")]
    [StringLength(40)]
    public string? BasOkul1Adi { get; set; }

    [Column("bas_okul1_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul1BolumKodu { get; set; }

    [Column("bas_okul1_bolumu")]
    [StringLength(40)]
    public string? BasOkul1Bolumu { get; set; }

    [Column("bas_okul1_mezyil")]
    public short? BasOkul1Mezyil { get; set; }

    [Column("bas_okul1_derece")]
    public double? BasOkul1Derece { get; set; }

    [Column("bas_okul2_tipi")]
    public byte? BasOkul2Tipi { get; set; }

    [Column("bas_okul2_kodu")]
    [StringLength(25)]
    public string? BasOkul2Kodu { get; set; }

    [Column("bas_okul2_adi")]
    [StringLength(40)]
    public string? BasOkul2Adi { get; set; }

    [Column("bas_okul2_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul2BolumKodu { get; set; }

    [Column("bas_okul2_bolumu")]
    [StringLength(40)]
    public string? BasOkul2Bolumu { get; set; }

    [Column("bas_okul2_mezyil")]
    public short? BasOkul2Mezyil { get; set; }

    [Column("bas_okul2_derece")]
    public double? BasOkul2Derece { get; set; }

    [Column("bas_okul3_tipi")]
    public byte? BasOkul3Tipi { get; set; }

    [Column("bas_okul3_kodu")]
    [StringLength(25)]
    public string? BasOkul3Kodu { get; set; }

    [Column("bas_okul3_adi")]
    [StringLength(40)]
    public string? BasOkul3Adi { get; set; }

    [Column("bas_okul3_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul3BolumKodu { get; set; }

    [Column("bas_okul3_bolumu")]
    [StringLength(40)]
    public string? BasOkul3Bolumu { get; set; }

    [Column("bas_okul3_mezyil")]
    public short? BasOkul3Mezyil { get; set; }

    [Column("bas_okul3_derece")]
    public double? BasOkul3Derece { get; set; }

    [Column("bas_okul4_tipi")]
    public byte? BasOkul4Tipi { get; set; }

    [Column("bas_okul4_kodu")]
    [StringLength(25)]
    public string? BasOkul4Kodu { get; set; }

    [Column("bas_okul4_adi")]
    [StringLength(40)]
    public string? BasOkul4Adi { get; set; }

    [Column("bas_okul4_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul4BolumKodu { get; set; }

    [Column("bas_okul4_bolumu")]
    [StringLength(40)]
    public string? BasOkul4Bolumu { get; set; }

    [Column("bas_okul4_mezyil")]
    public short? BasOkul4Mezyil { get; set; }

    [Column("bas_okul4_derece")]
    public double? BasOkul4Derece { get; set; }

    [Column("bas_okul5_tipi")]
    public byte? BasOkul5Tipi { get; set; }

    [Column("bas_okul5_kodu")]
    [StringLength(25)]
    public string? BasOkul5Kodu { get; set; }

    [Column("bas_okul5_adi")]
    [StringLength(40)]
    public string? BasOkul5Adi { get; set; }

    [Column("bas_okul5_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul5BolumKodu { get; set; }

    [Column("bas_okul5_bolumu")]
    [StringLength(40)]
    public string? BasOkul5Bolumu { get; set; }

    [Column("bas_okul5_mezyil")]
    public short? BasOkul5Mezyil { get; set; }

    [Column("bas_okul5_derece")]
    public double? BasOkul5Derece { get; set; }

    [Column("bas_okul6_tipi")]
    public byte? BasOkul6Tipi { get; set; }

    [Column("bas_okul6_kodu")]
    [StringLength(25)]
    public string? BasOkul6Kodu { get; set; }

    [Column("bas_okul6_adi")]
    [StringLength(40)]
    public string? BasOkul6Adi { get; set; }

    [Column("bas_okul6_bolum_kodu")]
    [StringLength(25)]
    public string? BasOkul6BolumKodu { get; set; }

    [Column("bas_okul6_bolumu")]
    [StringLength(40)]
    public string? BasOkul6Bolumu { get; set; }

    [Column("bas_okul6_mezyil")]
    public short? BasOkul6Mezyil { get; set; }

    [Column("bas_okul6_derece")]
    public double? BasOkul6Derece { get; set; }

    [Column("bas_dil1_tipi")]
    public byte? BasDil1Tipi { get; set; }

    [Column("bas_dil1_seviye")]
    public byte? BasDil1Seviye { get; set; }

    [Column("bas_dil1_konusma")]
    public byte? BasDil1Konusma { get; set; }

    [Column("bas_dil2_tipi")]
    public byte? BasDil2Tipi { get; set; }

    [Column("bas_dil2_seviye")]
    public byte? BasDil2Seviye { get; set; }

    [Column("bas_dil2_konusma")]
    public byte? BasDil2Konusma { get; set; }

    [Column("bas_dil3_tipi")]
    public byte? BasDil3Tipi { get; set; }

    [Column("bas_dil3_seviye")]
    public byte? BasDil3Seviye { get; set; }

    [Column("bas_dil3_konusma")]
    public byte? BasDil3Konusma { get; set; }

    [Column("bas_dil4_tipi")]
    public byte? BasDil4Tipi { get; set; }

    [Column("bas_dil4_seviye")]
    public byte? BasDil4Seviye { get; set; }

    [Column("bas_dil4_konusma")]
    public byte? BasDil4Konusma { get; set; }

    [Column("bas_dil5_tipi")]
    public byte? BasDil5Tipi { get; set; }

    [Column("bas_dil5_seviye")]
    public byte? BasDil5Seviye { get; set; }

    [Column("bas_dil5_konusma")]
    public byte? BasDil5Konusma { get; set; }

    [Column("bas_kurs1_konusu")]
    [StringLength(40)]
    public string? BasKurs1Konusu { get; set; }

    [Column("bas_kurs1_kurumu")]
    [StringLength(40)]
    public string? BasKurs1Kurumu { get; set; }

    [Column("bas_kurs1_yil")]
    public short? BasKurs1Yil { get; set; }

    [Column("bas_kurs1_aciklama")]
    [StringLength(80)]
    public string? BasKurs1Aciklama { get; set; }

    [Column("bas_kurs1_egitim_kodu")]
    [StringLength(25)]
    public string? BasKurs1EgitimKodu { get; set; }

    [Column("bas_kurs1_sertifika_fl")]
    public bool? BasKurs1SertifikaFl { get; set; }

    [Column("bas_kurs2_konusu")]
    [StringLength(40)]
    public string? BasKurs2Konusu { get; set; }

    [Column("bas_kurs2_kurumu")]
    [StringLength(40)]
    public string? BasKurs2Kurumu { get; set; }

    [Column("bas_kurs2_yil")]
    public short? BasKurs2Yil { get; set; }

    [Column("bas_kurs2_aciklama")]
    [StringLength(80)]
    public string? BasKurs2Aciklama { get; set; }

    [Column("bas_kurs2_egitim_kodu")]
    [StringLength(25)]
    public string? BasKurs2EgitimKodu { get; set; }

    [Column("bas_kurs2_sertifika_fl")]
    public bool? BasKurs2SertifikaFl { get; set; }

    [Column("bas_kurs3_konusu")]
    [StringLength(40)]
    public string? BasKurs3Konusu { get; set; }

    [Column("bas_kurs3_kurumu")]
    [StringLength(40)]
    public string? BasKurs3Kurumu { get; set; }

    [Column("bas_kurs3_yil")]
    public short? BasKurs3Yil { get; set; }

    [Column("bas_kurs3_aciklama")]
    [StringLength(80)]
    public string? BasKurs3Aciklama { get; set; }

    [Column("bas_kurs3_egitim_kodu")]
    [StringLength(25)]
    public string? BasKurs3EgitimKodu { get; set; }

    [Column("bas_kurs3_sertifika_fl")]
    public bool? BasKurs3SertifikaFl { get; set; }

    [Column("bas_kurs4_konusu")]
    [StringLength(40)]
    public string? BasKurs4Konusu { get; set; }

    [Column("bas_kurs4_kurumu")]
    [StringLength(40)]
    public string? BasKurs4Kurumu { get; set; }

    [Column("bas_kurs4_yil")]
    public short? BasKurs4Yil { get; set; }

    [Column("bas_kurs4_aciklama")]
    [StringLength(80)]
    public string? BasKurs4Aciklama { get; set; }

    [Column("bas_kurs4_egitim_kodu")]
    [StringLength(25)]
    public string? BasKurs4EgitimKodu { get; set; }

    [Column("bas_kurs4_sertifika_fl")]
    public bool? BasKurs4SertifikaFl { get; set; }

    [Column("bas_kurs5_konusu")]
    [StringLength(40)]
    public string? BasKurs5Konusu { get; set; }

    [Column("bas_kurs5_kurumu")]
    [StringLength(40)]
    public string? BasKurs5Kurumu { get; set; }

    [Column("bas_kurs5_yil")]
    public short? BasKurs5Yil { get; set; }

    [Column("bas_kurs5_aciklama")]
    [StringLength(80)]
    public string? BasKurs5Aciklama { get; set; }

    [Column("bas_kurs5_egitim_kodu")]
    [StringLength(25)]
    public string? BasKurs5EgitimKodu { get; set; }

    [Column("bas_kurs5_sertifika_fl")]
    public bool? BasKurs5SertifikaFl { get; set; }

    [Column("bas_sirk1_adi")]
    [StringLength(40)]
    public string? BasSirk1Adi { get; set; }

    [Column("bas_sirk1_gorevi")]
    [StringLength(40)]
    public string? BasSirk1Gorevi { get; set; }

    [Column("bas_sirk1_girisyil")]
    public DateTime? BasSirk1Girisyil { get; set; }

    [Column("bas_sirk1_cikisyil")]
    public DateTime? BasSirk1Cikisyil { get; set; }

    [Column("bas_sirk1_cikissebebi")]
    [StringLength(40)]
    public string? BasSirk1Cikissebebi { get; set; }

    [Column("bas_sirk1_ucret")]
    public double? BasSirk1Ucret { get; set; }

    [Column("bas_sirk1_cikissebepsecimli")]
    public byte? BasSirk1Cikissebepsecimli { get; set; }

    [Column("bas_sirk2_adi")]
    [StringLength(40)]
    public string? BasSirk2Adi { get; set; }

    [Column("bas_sirk2_gorevi")]
    [StringLength(40)]
    public string? BasSirk2Gorevi { get; set; }

    [Column("bas_sirk2_girisyil")]
    public DateTime? BasSirk2Girisyil { get; set; }

    [Column("bas_sirk2_cikisyil")]
    public DateTime? BasSirk2Cikisyil { get; set; }

    [Column("bas_sirk2_cikissebebi")]
    [StringLength(40)]
    public string? BasSirk2Cikissebebi { get; set; }

    [Column("bas_sirk2_ucret")]
    public double? BasSirk2Ucret { get; set; }

    [Column("bas_sirk2_cikissebepsecimli")]
    public byte? BasSirk2Cikissebepsecimli { get; set; }

    [Column("bas_sirk3_adi")]
    [StringLength(40)]
    public string? BasSirk3Adi { get; set; }

    [Column("bas_sirk3_gorevi")]
    [StringLength(40)]
    public string? BasSirk3Gorevi { get; set; }

    [Column("bas_sirk3_girisyil")]
    public DateTime? BasSirk3Girisyil { get; set; }

    [Column("bas_sirk3_cikisyil")]
    public DateTime? BasSirk3Cikisyil { get; set; }

    [Column("bas_sirk3_cikissebebi")]
    [StringLength(40)]
    public string? BasSirk3Cikissebebi { get; set; }

    [Column("bas_sirk3_ucret")]
    public double? BasSirk3Ucret { get; set; }

    [Column("bas_sirk3_cikissebepsecimli")]
    public byte? BasSirk3Cikissebepsecimli { get; set; }

    [Column("bas_sirk4_adi")]
    [StringLength(40)]
    public string? BasSirk4Adi { get; set; }

    [Column("bas_sirk4_girisyil")]
    public DateTime? BasSirk4Girisyil { get; set; }

    [Column("bas_sirk4_cikisyil")]
    public DateTime? BasSirk4Cikisyil { get; set; }

    [Column("bas_sirk4_cikissebebi")]
    [StringLength(40)]
    public string? BasSirk4Cikissebebi { get; set; }

    [Column("bas_sirk4_ucret")]
    public double? BasSirk4Ucret { get; set; }

    [Column("bas_sirk4_cikissebepsecimli")]
    public byte? BasSirk4Cikissebepsecimli { get; set; }

    [Column("bas_sirk5_adi")]
    [StringLength(40)]
    public string? BasSirk5Adi { get; set; }

    [Column("bas_sirk5_gorevi")]
    [StringLength(40)]
    public string? BasSirk5Gorevi { get; set; }

    [Column("bas_sirk5_girisyil")]
    public DateTime? BasSirk5Girisyil { get; set; }

    [Column("bas_sirk5_cikisyil")]
    public DateTime? BasSirk5Cikisyil { get; set; }

    [Column("bas_sirk5_cikissebebi")]
    [StringLength(40)]
    public string? BasSirk5Cikissebebi { get; set; }

    [Column("bas_sirk5_ucret")]
    public double? BasSirk5Ucret { get; set; }

    [Column("bas_sirk5_cikissebepsecimli")]
    public byte? BasSirk5Cikissebepsecimli { get; set; }

    [Column("bas_refr1_adi")]
    [StringLength(40)]
    public string? BasRefr1Adi { get; set; }

    [Column("bas_refr1_meslek")]
    [StringLength(40)]
    public string? BasRefr1Meslek { get; set; }

    [Column("bas_refr1_iletisim")]
    [StringLength(40)]
    public string? BasRefr1Iletisim { get; set; }

    [Column("bas_refr2_adi")]
    [StringLength(40)]
    public string? BasRefr2Adi { get; set; }

    [Column("bas_refr2_meslek")]
    [StringLength(40)]
    public string? BasRefr2Meslek { get; set; }

    [Column("bas_refr2_iletisim")]
    [StringLength(40)]
    public string? BasRefr2Iletisim { get; set; }

    [Column("bas_refr3_adi")]
    [StringLength(40)]
    public string? BasRefr3Adi { get; set; }

    [Column("bas_refr3_meslek")]
    [StringLength(40)]
    public string? BasRefr3Meslek { get; set; }

    [Column("bas_refr3_iletisim")]
    [StringLength(40)]
    public string? BasRefr3Iletisim { get; set; }

    [Column("bas_refr4_adi")]
    [StringLength(40)]
    public string? BasRefr4Adi { get; set; }

    [Column("bas_refr4_meslek")]
    [StringLength(40)]
    public string? BasRefr4Meslek { get; set; }

    [Column("bas_refr4_iletisim")]
    [StringLength(40)]
    public string? BasRefr4Iletisim { get; set; }

    [Column("bas_refr5_adi")]
    [StringLength(40)]
    public string? BasRefr5Adi { get; set; }

    [Column("bas_refr5_meslek")]
    [StringLength(40)]
    public string? BasRefr5Meslek { get; set; }

    [Column("bas_refr5_iletisim")]
    [StringLength(40)]
    public string? BasRefr5Iletisim { get; set; }

    [Column("bas_refr6_adi")]
    [StringLength(40)]
    public string? BasRefr6Adi { get; set; }

    [Column("bas_refr6_meslek")]
    [StringLength(40)]
    public string? BasRefr6Meslek { get; set; }

    [Column("bas_refr6_iletisim")]
    [StringLength(40)]
    public string? BasRefr6Iletisim { get; set; }

    [Column("bas_refr7_adi")]
    [StringLength(40)]
    public string? BasRefr7Adi { get; set; }

    [Column("bas_refr7_meslek")]
    [StringLength(40)]
    public string? BasRefr7Meslek { get; set; }

    [Column("bas_refr7_iletisim")]
    [StringLength(40)]
    public string? BasRefr7Iletisim { get; set; }

    [Column("bas_refr8_adi")]
    [StringLength(40)]
    public string? BasRefr8Adi { get; set; }

    [Column("bas_refr8_meslek")]
    [StringLength(40)]
    public string? BasRefr8Meslek { get; set; }

    [Column("bas_refr8_iletisim")]
    [StringLength(40)]
    public string? BasRefr8Iletisim { get; set; }

    [Column("bas_refr9_adi")]
    [StringLength(40)]
    public string? BasRefr9Adi { get; set; }

    [Column("bas_refr9_meslek")]
    [StringLength(40)]
    public string? BasRefr9Meslek { get; set; }

    [Column("bas_refr9_iletisim")]
    [StringLength(40)]
    public string? BasRefr9Iletisim { get; set; }

    [Column("bas_refr10_adi")]
    [StringLength(40)]
    public string? BasRefr10Adi { get; set; }

    [Column("bas_refr10_meslek")]
    [StringLength(40)]
    public string? BasRefr10Meslek { get; set; }

    [Column("bas_refr10_iletisim")]
    [StringLength(40)]
    public string? BasRefr10Iletisim { get; set; }

    [Column("bas_bvis1_depkodu")]
    [StringLength(25)]
    public string? BasBvis1Depkodu { get; set; }

    [Column("bas_bvis1_gorkodu")]
    [StringLength(25)]
    public string? BasBvis1Gorkodu { get; set; }

    [Column("bas_bvis1_aciklama")]
    [StringLength(80)]
    public string? BasBvis1Aciklama { get; set; }

    [Column("bas_bvis1_kadrokodu")]
    [StringLength(25)]
    public string? BasBvis1Kadrokodu { get; set; }

    [Column("bas_bvis1_isilankodu")]
    [StringLength(25)]
    public string? BasBvis1Isilankodu { get; set; }

    [Column("bas_bvis2_depkodu")]
    [StringLength(25)]
    public string? BasBvis2Depkodu { get; set; }

    [Column("bas_bvis2_gorkodu")]
    [StringLength(25)]
    public string? BasBvis2Gorkodu { get; set; }

    [Column("bas_bvis2_aciklama")]
    [StringLength(80)]
    public string? BasBvis2Aciklama { get; set; }

    [Column("bas_bvis2_kadrokodu")]
    [StringLength(25)]
    public string? BasBvis2Kadrokodu { get; set; }

    [Column("bas_bvis2_isilankodu")]
    [StringLength(25)]
    public string? BasBvis2Isilankodu { get; set; }

    [Column("bas_bvis3_depkodu")]
    [StringLength(25)]
    public string? BasBvis3Depkodu { get; set; }

    [Column("bas_bvis3_gorkodu")]
    [StringLength(25)]
    public string? BasBvis3Gorkodu { get; set; }

    [Column("bas_bvis3_aciklama")]
    [StringLength(80)]
    public string? BasBvis3Aciklama { get; set; }

    [Column("bas_bvis3_kadrokodu")]
    [StringLength(25)]
    public string? BasBvis3Kadrokodu { get; set; }

    [Column("bas_bvis3_isilankodu")]
    [StringLength(25)]
    public string? BasBvis3Isilankodu { get; set; }

    [Column("bas_bvis4_depkodu")]
    [StringLength(25)]
    public string? BasBvis4Depkodu { get; set; }

    [Column("bas_bvis4_gorkodu")]
    [StringLength(25)]
    public string? BasBvis4Gorkodu { get; set; }

    [Column("bas_bvis4_aciklama")]
    [StringLength(80)]
    public string? BasBvis4Aciklama { get; set; }

    [Column("bas_bvis4_kadrokodu")]
    [StringLength(25)]
    public string? BasBvis4Kadrokodu { get; set; }

    [Column("bas_bvis4_isilankodu")]
    [StringLength(25)]
    public string? BasBvis4Isilankodu { get; set; }

    [Column("bas_ucret_talep")]
    public double? BasUcretTalep { get; set; }

    [Column("bas_ucret_talep_doviz")]
    public byte? BasUcretTalepDoviz { get; set; }

    [Column("bas_ucret_talep_tip")]
    public byte? BasUcretTalepTip { get; set; }

    [Column("bas_ucret_talep_brutnet")]
    public byte? BasUcretTalepBrutnet { get; set; }

    [Column("bas_ucret_oneri")]
    public double? BasUcretOneri { get; set; }

    [Column("bas_ucret_oneri_doviz")]
    public byte? BasUcretOneriDoviz { get; set; }

    [Column("bas_ucret_oneri_tip")]
    public byte? BasUcretOneriTip { get; set; }

    [Column("bas_ucret_oneri_brutnet")]
    public byte? BasUcretOneriBrutnet { get; set; }

    [Column("bas_durum")]
    public byte? BasDurum { get; set; }

    [Column("bas_iskurno")]
    [StringLength(25)]
    public string? BasIskurno { get; set; }

    [Column("bas_ozurlu")]
    public bool? BasOzurlu { get; set; }

    [Column("bas_ozurderecesi")]
    public byte? BasOzurderecesi { get; set; }

    [Column("bas_ozurgrubu")]
    public byte? BasOzurgrubu { get; set; }

    [Column("bas_sigortagrubu")]
    public byte? BasSigortagrubu { get; set; }

    [Column("bas_kapsam")]
    public byte? BasKapsam { get; set; }

    [Column("bas_perskodu")]
    [StringLength(25)]
    public string? BasPerskodu { get; set; }

    [Column("bas_tckimlikno")]
    [StringLength(11)]
    public string? BasTckimlikno { get; set; }

    [Column("bas_nitelik1_kodu")]
    [StringLength(25)]
    public string? BasNitelik1Kodu { get; set; }

    [Column("bas_nitelik2_kodu")]
    [StringLength(25)]
    public string? BasNitelik2Kodu { get; set; }

    [Column("bas_nitelik3_kodu")]
    [StringLength(25)]
    public string? BasNitelik3Kodu { get; set; }

    [Column("bas_nitelik4_kodu")]
    [StringLength(25)]
    public string? BasNitelik4Kodu { get; set; }

    [Column("bas_nitelik5_kodu")]
    [StringLength(25)]
    public string? BasNitelik5Kodu { get; set; }

    [Column("bas_nitelik6_kodu")]
    [StringLength(25)]
    public string? BasNitelik6Kodu { get; set; }

    [Column("bas_nitelik7_kodu")]
    [StringLength(25)]
    public string? BasNitelik7Kodu { get; set; }

    [Column("bas_nitelik8_kodu")]
    [StringLength(25)]
    public string? BasNitelik8Kodu { get; set; }

    [Column("bas_nitelik9_kodu")]
    [StringLength(25)]
    public string? BasNitelik9Kodu { get; set; }

    [Column("bas_nitelik10_kodu")]
    [StringLength(25)]
    public string? BasNitelik10Kodu { get; set; }

    [Column("bas_talep_uid")]
    public short? BasTalepUid { get; set; }

    [Column("bas_kabul_isilankodu")]
    [StringLength(25)]
    public string? BasKabulIsilankodu { get; set; }

    [Column("bas_sigara_fl")]
    public bool? BasSigaraFl { get; set; }
}
