using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("aday_cari_hesaplar")]
public class AdayCariHesaplar
{
    [Column("adaycr_Guid")]
    public Guid? AdaycrGuid { get; set; }

    [Column("adaycr_DBCno")]
    public short? AdaycrDBCno { get; set; }

    [Column("adaycr_SpecRECno")]
    public int? AdaycrSpecRECno { get; set; }

    [Column("adaycr_iptal")]
    public bool? AdaycrIptal { get; set; }

    [Column("adaycr_fileid")]
    public short? AdaycrFileid { get; set; }

    [Column("adaycr_hidden")]
    public bool? AdaycrHidden { get; set; }

    [Column("adaycr_kilitli")]
    public bool? AdaycrKilitli { get; set; }

    [Column("adaycr_degisti")]
    public bool? AdaycrDegisti { get; set; }

    [Column("adaycr_checksum")]
    public int? AdaycrChecksum { get; set; }

    [Column("adaycr_create_user")]
    public short? AdaycrCreateUser { get; set; }

    [Column("adaycr_create_date")]
    public DateTime? AdaycrCreateDate { get; set; }

    [Column("adaycr_lastup_user")]
    public short? AdaycrLastupUser { get; set; }

    [Column("adaycr_lastup_date")]
    public DateTime? AdaycrLastupDate { get; set; }

    [Column("adaycr_special1")]
    [StringLength(4)]
    public string? AdaycrSpecial1 { get; set; }

    [Column("adaycr_special2")]
    [StringLength(4)]
    public string? AdaycrSpecial2 { get; set; }

    [Column("adaycr_special3")]
    [StringLength(4)]
    public string? AdaycrSpecial3 { get; set; }

    [Column("adaycr_kod")]
    [StringLength(25)]
    public string? AdaycrKod { get; set; }

    [Column("adaycr_unvan1")]
    [StringLength(127)]
    public string? AdaycrUnvan1 { get; set; }

    [Column("adaycr_unvan2")]
    [StringLength(127)]
    public string? AdaycrUnvan2 { get; set; }

    [Column("adaycr_sektor_kodu")]
    [StringLength(25)]
    public string? AdaycrSektorKodu { get; set; }

    [Column("adaycr_bolge_kodu")]
    [StringLength(25)]
    public string? AdaycrBolgeKodu { get; set; }

    [Column("adaycr_grup_kodu")]
    [StringLength(25)]
    public string? AdaycrGrupKodu { get; set; }

    [Column("adaycr_temsilci_kodu")]
    [StringLength(25)]
    public string? AdaycrTemsilciKodu { get; set; }

    [Column("adaycr_wwwadresi")]
    [StringLength(30)]
    public string? AdaycrWwwadresi { get; set; }

    [Column("adaycr_EMail")]
    [StringLength(80)]
    public string? AdaycrEMail { get; set; }

    [Column("adaycr_adr1_cadde")]
    [StringLength(50)]
    public string? AdaycrAdr1Cadde { get; set; }

    [Column("adaycr_adr1_mahalle")]
    [StringLength(50)]
    public string? AdaycrAdr1Mahalle { get; set; }

    [Column("adaycr_adr1_sokak")]
    [StringLength(50)]
    public string? AdaycrAdr1Sokak { get; set; }

    [Column("adaycr_adr1_Semt")]
    [StringLength(25)]
    public string? AdaycrAdr1Semt { get; set; }

    [Column("adaycr_adr1_Apt_No")]
    [StringLength(10)]
    public string? AdaycrAdr1AptNo { get; set; }

    [Column("adaycr_adr1_Daire_No")]
    [StringLength(10)]
    public string? AdaycrAdr1DaireNo { get; set; }

    [Column("adaycr_adr1_posta_kodu")]
    [StringLength(8)]
    public string? AdaycrAdr1PostaKodu { get; set; }

    [Column("adaycr_adr1_ilce")]
    [StringLength(50)]
    public string? AdaycrAdr1Ilce { get; set; }

    [Column("adaycr_adr1_il")]
    [StringLength(50)]
    public string? AdaycrAdr1Il { get; set; }

    [Column("adaycr_adr1_ulke")]
    [StringLength(50)]
    public string? AdaycrAdr1Ulke { get; set; }

    [Column("adaycr_adr1_adres_kodu")]
    [StringLength(10)]
    public string? AdaycrAdr1AdresKodu { get; set; }

    [Column("adaycr_adr1_tel_ulke_kodu")]
    [StringLength(5)]
    public string? AdaycrAdr1TelUlkeKodu { get; set; }

    [Column("adaycr_adr1_tel_bolge_kodu")]
    [StringLength(5)]
    public string? AdaycrAdr1TelBolgeKodu { get; set; }

    [Column("adaycr_adr1_tel_no1")]
    [StringLength(10)]
    public string? AdaycrAdr1TelNo1 { get; set; }

    [Column("adaycr_adr2_cadde")]
    [StringLength(50)]
    public string? AdaycrAdr2Cadde { get; set; }

    [Column("adaycr_adr2_mahalle")]
    [StringLength(50)]
    public string? AdaycrAdr2Mahalle { get; set; }

    [Column("adaycr_adr2_sokak")]
    [StringLength(50)]
    public string? AdaycrAdr2Sokak { get; set; }

    [Column("adaycr_adr2_Semt")]
    [StringLength(25)]
    public string? AdaycrAdr2Semt { get; set; }

    [Column("adaycr_adr2_Apt_No")]
    [StringLength(10)]
    public string? AdaycrAdr2AptNo { get; set; }

    [Column("adaycr_adr2_Daire_No")]
    [StringLength(10)]
    public string? AdaycrAdr2DaireNo { get; set; }

    [Column("adaycr_adr2_posta_kodu")]
    [StringLength(8)]
    public string? AdaycrAdr2PostaKodu { get; set; }

    [Column("adaycr_adr2_ilce")]
    [StringLength(50)]
    public string? AdaycrAdr2Ilce { get; set; }

    [Column("adaycr_adr2_il")]
    [StringLength(50)]
    public string? AdaycrAdr2Il { get; set; }

    [Column("adaycr_adr2_ulke")]
    [StringLength(50)]
    public string? AdaycrAdr2Ulke { get; set; }

    [Column("adaycr_adr2_adres_kodu")]
    [StringLength(10)]
    public string? AdaycrAdr2AdresKodu { get; set; }

    [Column("adaycr_adr2_tel_ulke_kodu")]
    [StringLength(5)]
    public string? AdaycrAdr2TelUlkeKodu { get; set; }

    [Column("adaycr_adr2_tel_bolge_kodu")]
    [StringLength(5)]
    public string? AdaycrAdr2TelBolgeKodu { get; set; }

    [Column("adaycr_adr2_tel_no1")]
    [StringLength(10)]
    public string? AdaycrAdr2TelNo1 { get; set; }

    [Column("adaycr_yetkili1_isim")]
    [StringLength(60)]
    public string? AdaycrYetkili1Isim { get; set; }

    [Column("adaycr_yetkili1_dahili_telno")]
    [StringLength(5)]
    public string? AdaycrYetkili1DahiliTelno { get; set; }

    [Column("adaycr_yetkili1_email_adres")]
    [StringLength(50)]
    public string? AdaycrYetkili1EmailAdres { get; set; }

    [Column("adaycr_yetkili1_cep_telno")]
    [StringLength(17)]
    public string? AdaycrYetkili1CepTelno { get; set; }

    [Column("adaycr_yetkili2_isim")]
    [StringLength(60)]
    public string? AdaycrYetkili2Isim { get; set; }

    [Column("adaycr_yetkili2_dahili_telno")]
    [StringLength(5)]
    public string? AdaycrYetkili2DahiliTelno { get; set; }

    [Column("adaycr_yetkili2_email_adres")]
    [StringLength(50)]
    public string? AdaycrYetkili2EmailAdres { get; set; }

    [Column("adaycr_yetkili2_cep_telno")]
    [StringLength(17)]
    public string? AdaycrYetkili2CepTelno { get; set; }

    [Column("adaycr_yetkili3_isim")]
    [StringLength(60)]
    public string? AdaycrYetkili3Isim { get; set; }

    [Column("adaycr_yetkili3_dahili_telno")]
    [StringLength(5)]
    public string? AdaycrYetkili3DahiliTelno { get; set; }

    [Column("adaycr_yetkili3_email_adres")]
    [StringLength(50)]
    public string? AdaycrYetkili3EmailAdres { get; set; }

    [Column("adaycr_yetkili3_cep_telno")]
    [StringLength(17)]
    public string? AdaycrYetkili3CepTelno { get; set; }

    [Column("adaycr_yetkili4_isim")]
    [StringLength(60)]
    public string? AdaycrYetkili4Isim { get; set; }

    [Column("adaycr_yetkili4_dahili_telno")]
    [StringLength(5)]
    public string? AdaycrYetkili4DahiliTelno { get; set; }

    [Column("adaycr_yetkili4_email_adres")]
    [StringLength(50)]
    public string? AdaycrYetkili4EmailAdres { get; set; }

    [Column("adaycr_yetkili4_cep_telno")]
    [StringLength(17)]
    public string? AdaycrYetkili4CepTelno { get; set; }

    [Column("adaycr_yetkili5_isim")]
    [StringLength(60)]
    public string? AdaycrYetkili5Isim { get; set; }

    [Column("adaycr_yetkili5_dahili_telno")]
    [StringLength(5)]
    public string? AdaycrYetkili5DahiliTelno { get; set; }

    [Column("adaycr_yetkili5_email_adres")]
    [StringLength(50)]
    public string? AdaycrYetkili5EmailAdres { get; set; }

    [Column("adaycr_yetkili5_cep_telno")]
    [StringLength(17)]
    public string? AdaycrYetkili5CepTelno { get; set; }
}
