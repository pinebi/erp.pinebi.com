using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_calisma_tanimlari")]
public class PersonelCalismaTanimlari
{
    [Column("PC_Guid")]
    public Guid? PCGuid { get; set; }

    [Column("PC_DBCno")]
    public short? PCDBCno { get; set; }

    [Column("PC_SpecRECno")]
    public int? PCSpecRECno { get; set; }

    [Column("PC_iptal")]
    public bool? PCIptal { get; set; }

    [Column("PC_fileid")]
    public short? PCFileid { get; set; }

    [Column("PC_hidden")]
    public bool? PCHidden { get; set; }

    [Column("PC_kilitli")]
    public bool? PCKilitli { get; set; }

    [Column("PC_degisti")]
    public bool? PCDegisti { get; set; }

    [Column("PC_checksum")]
    public int? PCChecksum { get; set; }

    [Column("PC_create_user")]
    public short? PCCreateUser { get; set; }

    [Column("PC_create_date")]
    public DateTime? PCCreateDate { get; set; }

    [Column("PC_lastup_user")]
    public short? PCLastupUser { get; set; }

    [Column("PC_lastup_date")]
    public DateTime? PCLastupDate { get; set; }

    [Column("PC_special1")]
    [StringLength(4)]
    public string? PCSpecial1 { get; set; }

    [Column("PC_special2")]
    [StringLength(4)]
    public string? PCSpecial2 { get; set; }

    [Column("PC_special3")]
    [StringLength(4)]
    public string? PCSpecial3 { get; set; }

    [Column("PC_Kodu")]
    [StringLength(25)]
    public string? PCKodu { get; set; }

    [Column("PC_Ismi")]
    [StringLength(50)]
    public string? PCIsmi { get; set; }

    [Column("PC_Doviz_Cinsi")]
    public byte? PCDovizCinsi { get; set; }

    [Column("PC_Gun_Calis_Saat")]
    public double? PCGunCalisSaat { get; set; }

    [Column("PC_Ikr_Aylari1")]
    public bool? PCIkrAylari1 { get; set; }

    [Column("PC_Ikr_Aylari2")]
    public bool? PCIkrAylari2 { get; set; }

    [Column("PC_Ikr_Aylari3")]
    public bool? PCIkrAylari3 { get; set; }

    [Column("PC_Ikr_Aylari4")]
    public bool? PCIkrAylari4 { get; set; }

    [Column("PC_Ikr_Aylari5")]
    public bool? PCIkrAylari5 { get; set; }

    [Column("PC_Ikr_Aylari6")]
    public bool? PCIkrAylari6 { get; set; }

    [Column("PC_Ikr_Aylari7")]
    public bool? PCIkrAylari7 { get; set; }

    [Column("PC_Ikr_Aylari8")]
    public bool? PCIkrAylari8 { get; set; }

    [Column("PC_Ikr_Aylari9")]
    public bool? PCIkrAylari9 { get; set; }

    [Column("PC_Ikr_Aylari10")]
    public bool? PCIkrAylari10 { get; set; }

    [Column("PC_Ikr_Aylari11")]
    public bool? PCIkrAylari11 { get; set; }

    [Column("PC_Ikr_Aylari12")]
    public bool? PCIkrAylari12 { get; set; }

    [Column("PC_Yak_Aylari1")]
    public bool? PCYakAylari1 { get; set; }

    [Column("PC_Yak_Aylari2")]
    public bool? PCYakAylari2 { get; set; }

    [Column("PC_Yak_Aylari3")]
    public bool? PCYakAylari3 { get; set; }

    [Column("PC_Yak_Aylari4")]
    public bool? PCYakAylari4 { get; set; }

    [Column("PC_Yak_Aylari5")]
    public bool? PCYakAylari5 { get; set; }

    [Column("PC_Yak_Aylari6")]
    public bool? PCYakAylari6 { get; set; }

    [Column("PC_Yak_Aylari7")]
    public bool? PCYakAylari7 { get; set; }

    [Column("PC_Yak_Aylari8")]
    public bool? PCYakAylari8 { get; set; }

    [Column("PC_Yak_Aylari9")]
    public bool? PCYakAylari9 { get; set; }

    [Column("PC_Yak_Aylari10")]
    public bool? PCYakAylari10 { get; set; }

    [Column("PC_Yak_Aylari11")]
    public bool? PCYakAylari11 { get; set; }

    [Column("PC_Yak_Aylari12")]
    public bool? PCYakAylari12 { get; set; }

    [Column("PC_Bay_Aylari1")]
    public bool? PCBayAylari1 { get; set; }

    [Column("PC_Bay_Aylari2")]
    public bool? PCBayAylari2 { get; set; }

    [Column("PC_Bay_Aylari3")]
    public bool? PCBayAylari3 { get; set; }

    [Column("PC_Bay_Aylari4")]
    public bool? PCBayAylari4 { get; set; }

    [Column("PC_Bay_Aylari5")]
    public bool? PCBayAylari5 { get; set; }

    [Column("PC_Bay_Aylari6")]
    public bool? PCBayAylari6 { get; set; }

    [Column("PC_Bay_Aylari7")]
    public bool? PCBayAylari7 { get; set; }

    [Column("PC_Bay_Aylari8")]
    public bool? PCBayAylari8 { get; set; }

    [Column("PC_Bay_Aylari9")]
    public bool? PCBayAylari9 { get; set; }

    [Column("PC_Bay_Aylari10")]
    public bool? PCBayAylari10 { get; set; }

    [Column("PC_Bay_Aylari11")]
    public bool? PCBayAylari11 { get; set; }

    [Column("PC_Bay_Aylari12")]
    public bool? PCBayAylari12 { get; set; }

    [Column("PC_Ikr_Yuzde")]
    public double? PCIkrYuzde { get; set; }

    [Column("PC_Ikr_hesap_sekli")]
    public bool? PCIkrHesapSekli { get; set; }

    [Column("PC_Ikr_Kes_At")]
    public bool? PCIkrKesAt { get; set; }

    [Column("PC_Ong_Izin_Gunu0")]
    public short? PCOngIzinGunu0 { get; set; }

    [Column("PC_Ong_Izin_Gunu1")]
    public short? PCOngIzinGunu1 { get; set; }

    [Column("PC_Ong_Izin_Gunu2")]
    public short? PCOngIzinGunu2 { get; set; }

    [Column("PC_Ong_Izin_Gunu3")]
    public short? PCOngIzinGunu3 { get; set; }

    [Column("PC_Ong_Izin_Gunu4")]
    public short? PCOngIzinGunu4 { get; set; }

    [Column("PC_Av_Maas_Oran")]
    public double? PCAvMaasOran { get; set; }

    [Column("PC_Av_Hesap_Sekli")]
    public byte? PCAvHesapSekli { get; set; }

    [Column("PC_Sinyority_AltSinirGunu1")]
    public short? PCSinyorityAltSinirGunu1 { get; set; }

    [Column("PC_Sinyority_UstSinirGunu1")]
    public short? PCSinyorityUstSinirGunu1 { get; set; }

    [Column("PC_Sinyority_Oran1")]
    public double? PCSinyorityOran1 { get; set; }

    [Column("PC_Sinyority_AltSinirGunu2")]
    public short? PCSinyorityAltSinirGunu2 { get; set; }

    [Column("PC_Sinyority_UstSinirGunu2")]
    public short? PCSinyorityUstSinirGunu2 { get; set; }

    [Column("PC_Sinyority_Oran2")]
    public double? PCSinyorityOran2 { get; set; }

    [Column("PC_Sinyority_AltSinirGunu3")]
    public short? PCSinyorityAltSinirGunu3 { get; set; }

    [Column("PC_Sinyority_UstSinirGunu3")]
    public short? PCSinyorityUstSinirGunu3 { get; set; }

    [Column("PC_Sinyority_Oran3")]
    public double? PCSinyorityOran3 { get; set; }

    [Column("PC_Sinyority_AltSinirGunu4")]
    public short? PCSinyorityAltSinirGunu4 { get; set; }

    [Column("PC_Sinyority_UstSinirGunu4")]
    public short? PCSinyorityUstSinirGunu4 { get; set; }

    [Column("PC_Sinyority_Oran4")]
    public double? PCSinyorityOran4 { get; set; }

    [Column("PC_Sinyority_AltSinirGunu5")]
    public short? PCSinyorityAltSinirGunu5 { get; set; }

    [Column("PC_Sinyority_UstSinirGunu5")]
    public short? PCSinyorityUstSinirGunu5 { get; set; }

    [Column("PC_Sinyority_Oran5")]
    public double? PCSinyorityOran5 { get; set; }

    [Column("PC_IzinPara_HakedisGun")]
    public short? PCIzinParaHakedisGun { get; set; }

    [Column("PC_IzinPara_Orani")]
    public double? PCIzinParaOrani { get; set; }

    [Column("PC_IzinPara_KacGunSonraOdeme")]
    public short? PCIzinParaKacGunSonraOdeme { get; set; }

    [Column("PC_CocukEgitimYardimiBir")]
    public bool? PCCocukEgitimYardimiBir { get; set; }

    [Column("PC_IkramiyeKazancHesabi30gun")]
    public bool? PCIkramiyeKazancHesabi30gun { get; set; }

    [Column("PC_Vardiya_Takvim")]
    [StringLength(4)]
    public string? PCVardiyaTakvim { get; set; }

    [Column("PC_Ong_Yillik_Izin_Gunu")]
    public short? PCOngYillikIzinGunu { get; set; }

    [Column("PC_Ong_Ucretli_Izin_Gunu")]
    public short? PCOngUcretliIzinGunu { get; set; }

    [Column("PC_Ong_Hastalik_Izin_Gunu")]
    public short? PCOngHastalikIzinGunu { get; set; }

    [Column("PC_Ong_Askerlik_Izin_Gunu")]
    public short? PCOngAskerlikIzinGunu { get; set; }

    [Column("PC_Ong_Zorunluluk_Izin_Gunu")]
    public short? PCOngZorunlulukIzinGunu { get; set; }

    [Column("PC_Ong_Devamsizlik_Izin_Gunu")]
    public short? PCOngDevamsizlikIzinGunu { get; set; }

    [Column("PC_Ong_Araverme_Izin_Gunu")]
    public short? PCOngAravermeIzinGunu { get; set; }

    [Column("PC_Ong_Diger_Izin_Gunu")]
    public short? PCOngDigerIzinGunu { get; set; }

    [Column("PC_Ong_Ucretsiz_Izin_Gunu")]
    public short? PCOngUcretsizIzinGunu { get; set; }

    [Column("PC_Ong_Sua_Izin_Gunu")]
    public short? PCOngSuaIzinGunu { get; set; }

    [Column("PC_Ong_Evlilik_Izin_Gunu")]
    public short? PCOngEvlilikIzinGunu { get; set; }

    [Column("PC_Ong_Dogum_Izin_Gunu")]
    public short? PCOngDogumIzinGunu { get; set; }

    [Column("PC_Ong_Babalik_Izin_Gunu")]
    public short? PCOngBabalikIzinGunu { get; set; }

    [Column("PC_Ong_Sut_Izin_Gunu")]
    public short? PCOngSutIzinGunu { get; set; }

    [Column("PC_Ong_Olum_Izin_Gunu")]
    public short? PCOngOlumIzinGunu { get; set; }

    [Column("PC_Ong_IsArama_Izin_Gunu")]
    public short? PCOngIsAramaIzinGunu { get; set; }

    [Column("PC_DKS_Puantaja_Aktarilmasin")]
    public bool? PCDKSPuantajaAktarilmasin { get; set; }

    [Column("PC_DKS_PuantajHesaplamaSekli")]
    public byte? PCDKSPuantajHesaplamaSekli { get; set; }

    [Column("PC_DKS_Toplam_Ise_EkKazancNo")]
    public byte? PCDKSToplamIseEkKazancNo { get; set; }

    [Column("PC_YarimIsGunu_Calisma_Saati")]
    public double? PCYarimIsGunuCalismaSaati { get; set; }

    [Column("PC_Hastalik_Oran0")]
    public double? PCHastalikOran0 { get; set; }

    [Column("PC_Hastalik_Oran1")]
    public double? PCHastalikOran1 { get; set; }

    [Column("PC_Hastalik_Oran2")]
    public double? PCHastalikOran2 { get; set; }

    [Column("PC_Hastalik_Oran3")]
    public double? PCHastalikOran3 { get; set; }

    [Column("PC_IzinHesaplamaSekli")]
    public byte? PCIzinHesaplamaSekli { get; set; }

    [Column("PC_HastalikHesaplamaSekli")]
    public byte? PCHastalikHesaplamaSekli { get; set; }

    [Column("PC_IkramiyeAyindaTaksitArtisOrani")]
    public double? PCIkramiyeAyindaTaksitArtisOrani { get; set; }

    [Column("PC_damga_vergisi_orani")]
    public double? PCDamgaVergisiOrani { get; set; }

    [Column("PC_kazanc_hesabi")]
    public byte? PCKazancHesabi { get; set; }

    [Column("PC_ekkazanc_hesabi")]
    public byte? PCEkkazancHesabi { get; set; }

    [Column("PC_sosyal_yardim_hesabi")]
    public byte? PCSosyalYardimHesabi { get; set; }

    [Column("PC_aktarimda_eksik_gun_izin")]
    public byte? PCAktarimdaEksikGunIzin { get; set; }

    [Column("PC_aktarimda_eksik_gun_izin_tip")]
    public byte? PCAktarimdaEksikGunIzinTip { get; set; }
}
