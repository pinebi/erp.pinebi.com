using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_maliyil_bilgileri")]
public class FirmaMaliyilBilgileri
{
    [Column("fmy_Guid")]
    public Guid? FmyGuid { get; set; }

    [Column("fmy_DBCno")]
    public short? FmyDBCno { get; set; }

    [Column("fmy_SpecRECno")]
    public int? FmySpecRECno { get; set; }

    [Column("fmy_iptal")]
    public bool? FmyIptal { get; set; }

    [Column("fmy_fileid")]
    public short? FmyFileid { get; set; }

    [Column("fmy_hidden")]
    public bool? FmyHidden { get; set; }

    [Column("fmy_kilitli")]
    public bool? FmyKilitli { get; set; }

    [Column("fmy_degisti")]
    public bool? FmyDegisti { get; set; }

    [Column("fmy_checksum")]
    public int? FmyChecksum { get; set; }

    [Column("fmy_create_user")]
    public short? FmyCreateUser { get; set; }

    [Column("fmy_create_date")]
    public DateTime? FmyCreateDate { get; set; }

    [Column("fmy_lastup_user")]
    public short? FmyLastupUser { get; set; }

    [Column("fmy_lastup_date")]
    public DateTime? FmyLastupDate { get; set; }

    [Column("fmy_special1")]
    [StringLength(4)]
    public string? FmySpecial1 { get; set; }

    [Column("fmy_special2")]
    [StringLength(4)]
    public string? FmySpecial2 { get; set; }

    [Column("fmy_special3")]
    [StringLength(4)]
    public string? FmySpecial3 { get; set; }

    [Column("fmy_sirano")]
    public int? FmySirano { get; set; }

    [Column("fmy_maliyil")]
    public int? FmyMaliyil { get; set; }

    [Column("fmy_yevmiye_tarih")]
    public DateTime? FmyYevmiyeTarih { get; set; }

    [Column("fmy_faiz_orani1")]
    public double? FmyFaizOrani1 { get; set; }

    [Column("fmy_faiz_orani2")]
    public double? FmyFaizOrani2 { get; set; }

    [Column("fmy_faiz_orani3")]
    public double? FmyFaizOrani3 { get; set; }

    [Column("fmy_faiz_orani4")]
    public double? FmyFaizOrani4 { get; set; }

    [Column("fmy_faiz_orani5")]
    public double? FmyFaizOrani5 { get; set; }

    [Column("fmy_faiz_orani6")]
    public double? FmyFaizOrani6 { get; set; }

    [Column("fmy_faiz_orani7")]
    public double? FmyFaizOrani7 { get; set; }

    [Column("fmy_faiz_orani8")]
    public double? FmyFaizOrani8 { get; set; }

    [Column("fmy_faiz_orani9")]
    public double? FmyFaizOrani9 { get; set; }

    [Column("fmy_faiz_orani10")]
    public double? FmyFaizOrani10 { get; set; }

    [Column("fmy_faiz_orani11")]
    public double? FmyFaizOrani11 { get; set; }

    [Column("fmy_faiz_orani12")]
    public double? FmyFaizOrani12 { get; set; }

    [Column("fmy_evrak_ilk_tarih")]
    public DateTime? FmyEvrakIlkTarih { get; set; }

    [Column("fmy_evrak_son_tarih")]
    public DateTime? FmyEvrakSonTarih { get; set; }

    [Column("fmy_firma_muh_kodu")]
    [StringLength(25)]
    public string? FmyFirmaMuhKodu { get; set; }

    [Column("fmy_firmamuhucret")]
    public double? FmyFirmamuhucret { get; set; }

    [Column("fmy_kapali_brut_meblag_kodu")]
    [StringLength(25)]
    public string? FmyKapaliBrutMeblagKodu { get; set; }

    [Column("fmy_acik_brut_meblag_kodu")]
    [StringLength(25)]
    public string? FmyAcikBrutMeblagKodu { get; set; }

    [Column("fmy_kdv_kodu")]
    [StringLength(25)]
    public string? FmyKdvKodu { get; set; }

    [Column("fmy_net_meblag_kodu")]
    [StringLength(25)]
    public string? FmyNetMeblagKodu { get; set; }

    [Column("fmy_stopaj_kodu")]
    [StringLength(25)]
    public string? FmyStopajKodu { get; set; }

    [Column("fmy_ssdf_kodu")]
    [StringLength(25)]
    public string? FmySsdfKodu { get; set; }

    [Column("fmy_isletme_kodu")]
    [StringLength(25)]
    public string? FmyIsletmeKodu { get; set; }

    [Column("fmy_stopaj_orani")]
    public double? FmyStopajOrani { get; set; }

    [Column("fmy_ssdf_orani")]
    public double? FmySsdfOrani { get; set; }

    [Column("fmy_kdv_orani")]
    public double? FmyKdvOrani { get; set; }

    [Column("fmy_satistevkifatmuhkodu")]
    [StringLength(40)]
    public string? FmySatistevkifatmuhkodu { get; set; }

    [Column("fmy_alistevkifatmuhkodu")]
    [StringLength(40)]
    public string? FmyAlistevkifatmuhkodu { get; set; }

    [Column("fmy_karyuvarlamamuhkodu")]
    [StringLength(40)]
    public string? FmyKaryuvarlamamuhkodu { get; set; }

    [Column("fmy_zararyuvarlamamuhkodu")]
    [StringLength(40)]
    public string? FmyZararyuvarlamamuhkodu { get; set; }

    [Column("fmy_protsenetiademas1muhkodu")]
    [StringLength(40)]
    public string? FmyProtsenetiademas1muhkodu { get; set; }

    [Column("fmy_istisnaotvmuhkodu")]
    [StringLength(40)]
    public string? FmyIstisnaotvmuhkodu { get; set; }

    [Column("fmy_iadeotvmuhkodu")]
    [StringLength(40)]
    public string? FmyIadeotvmuhkodu { get; set; }

    [Column("fmy_damgapulumuhkodu")]
    [StringLength(40)]
    public string? FmyDamgapulumuhkodu { get; set; }

    [Column("fmy_mustahsilborsamuhkodu")]
    [StringLength(40)]
    public string? FmyMustahsilborsamuhkodu { get; set; }

    [Column("fmy_mustahsilbagkurmuhkodu")]
    [StringLength(40)]
    public string? FmyMustahsilbagkurmuhkodu { get; set; }

    [Column("fmy_mustahsildigermuhkodu")]
    [StringLength(40)]
    public string? FmyMustahsildigermuhkodu { get; set; }

    [Column("fmy_sebzemeyvemsdfmuhkodu")]
    [StringLength(40)]
    public string? FmySebzemeyvemsdfmuhkodu { get; set; }

    [Column("fmy_sebzemeyvehamalmuhkodu")]
    [StringLength(40)]
    public string? FmySebzemeyvehamalmuhkodu { get; set; }

    [Column("fmy_sebzemeyvestopajmuhkodu")]
    [StringLength(40)]
    public string? FmySebzemeyvestopajmuhkodu { get; set; }

    [Column("fmy_sebzemeyvekomkdvmuhkodu")]
    [StringLength(40)]
    public string? FmySebzemeyvekomkdvmuhkodu { get; set; }

    [Column("fmy_halkomisyonmuhkodu")]
    [StringLength(40)]
    public string? FmyHalkomisyonmuhkodu { get; set; }

    [Column("fmy_halnavlunmuhkodu")]
    [StringLength(40)]
    public string? FmyHalnavlunmuhkodu { get; set; }

    [Column("fmy_halnavlunkdvmuhkodu")]
    [StringLength(40)]
    public string? FmyHalnavlunkdvmuhkodu { get; set; }

    [Column("fmy_halsandikrehinmuhkodu")]
    [StringLength(40)]
    public string? FmyHalsandikrehinmuhkodu { get; set; }

    [Column("fmy_halsandikrehinkdvmuhkodu")]
    [StringLength(40)]
    public string? FmyHalsandikrehinkdvmuhkodu { get; set; }

    [Column("fmy_rusummuhkodu")]
    [StringLength(40)]
    public string? FmyRusummuhkodu { get; set; }

    [Column("fmy_yansitma_hesaplari1")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari1 { get; set; }

    [Column("fmy_yansitma_hesaplari2")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari2 { get; set; }

    [Column("fmy_yansitma_hesaplari3")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari3 { get; set; }

    [Column("fmy_yansitma_hesaplari4")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari4 { get; set; }

    [Column("fmy_yansitma_hesaplari5")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari5 { get; set; }

    [Column("fmy_yansitma_hesaplari6")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari6 { get; set; }

    [Column("fmy_yansitma_hesaplari7")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari7 { get; set; }

    [Column("fmy_yansitma_hesaplari8")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari8 { get; set; }

    [Column("fmy_yansitma_hesaplari9")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari9 { get; set; }

    [Column("fmy_yansitma_hesaplari10")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari10 { get; set; }

    [Column("fmy_yansitma_hesaplari11")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari11 { get; set; }

    [Column("fmy_yansitma_hesaplari12")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari12 { get; set; }

    [Column("fmy_yansitma_hesaplari13")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari13 { get; set; }

    [Column("fmy_yansitma_hesaplari14")]
    [StringLength(25)]
    public string? FmyYansitmaHesaplari14 { get; set; }

    [Column("fmy_odeme_emri_cariye_masraf_yansitma_muhasebe_kodu")]
    [StringLength(25)]
    public string? FmyOdemeEmriCariyeMasrafYansitmaMuhasebeKodu { get; set; }

    [Column("fmy_odeme_emri_masraf2_kodu")]
    [StringLength(25)]
    public string? FmyOdemeEmriMasraf2Kodu { get; set; }

    [Column("fmy_alis_irs_mal_bed_muhkodu")]
    [StringLength(40)]
    public string? FmyAlisIrsMalBedMuhkodu { get; set; }

    [Column("fmy_satis_irs_mal_bed_muhkodu")]
    [StringLength(40)]
    public string? FmySatisIrsMalBedMuhkodu { get; set; }

    [Column("fmy_sebzemeyvehamalkdvmuhkodu")]
    [StringLength(40)]
    public string? FmySebzemeyvehamalkdvmuhkodu { get; set; }

    [Column("fmy_ebeyankullanici")]
    [StringLength(20)]
    public string? FmyEbeyankullanici { get; set; }

    [Column("fmy_ebeyanparola")]
    [StringLength(127)]
    public string? FmyEbeyanparola { get; set; }

    [Column("fmy_ebeyansifre")]
    [StringLength(127)]
    public string? FmyEbeyansifre { get; set; }

    [Column("fmy_eVDkullanici")]
    [StringLength(20)]
    public string? FmyEVDkullanici { get; set; }

    [Column("fmy_eVDparola")]
    [StringLength(127)]
    public string? FmyEVDparola { get; set; }

    [Column("fmy_eVDsifre")]
    [StringLength(127)]
    public string? FmyEVDsifre { get; set; }

    [Column("fmy_oivmuhkodu")]
    [StringLength(40)]
    public string? FmyOivmuhkodu { get; set; }

    [Column("fmy_istisnaoivmuhkodu")]
    [StringLength(40)]
    public string? FmyIstisnaoivmuhkodu { get; set; }

    [Column("fmy_iadeoivmuhkodu")]
    [StringLength(40)]
    public string? FmyIadeoivmuhkodu { get; set; }

    [Column("fmy_alisOIVmuhkodu")]
    [StringLength(40)]
    public string? FmyAlisOIVmuhkodu { get; set; }

    [Column("fmy_alisIadeOIVmuhkodu")]
    [StringLength(40)]
    public string? FmyAlisIadeOIVmuhkodu { get; set; }

    [Column("fmy_alisOTVmuhkodu")]
    [StringLength(40)]
    public string? FmyAlisOTVmuhkodu { get; set; }

    [Column("fmy_alisIadeOTVmuhkodu")]
    [StringLength(40)]
    public string? FmyAlisIadeOTVmuhkodu { get; set; }

    [Column("fmy_tevkifat_kodu")]
    [StringLength(40)]
    public string? FmyTevkifatKodu { get; set; }

    [Column("fmy_TevkifatliFirma_muh_kodu")]
    [StringLength(25)]
    public string? FmyTevkifatliFirmaMuhKodu { get; set; }

    [Column("fmy_TevkifatUygulama")]
    public byte? FmyTevkifatUygulama { get; set; }

    [Column("fmy_mustahsilborsamuhkodu_s")]
    [StringLength(40)]
    public string? FmyMustahsilborsamuhkoduS { get; set; }

    [Column("fmy_mustahsilbagkurmuhkodu_s")]
    [StringLength(40)]
    public string? FmyMustahsilbagkurmuhkoduS { get; set; }

    [Column("fmy_mustahsildigermuhkodu_s")]
    [StringLength(40)]
    public string? FmyMustahsildigermuhkoduS { get; set; }

    [Column("fmy_sebzemeyvemsdfmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvemsdfmuhkoduS { get; set; }

    [Column("fmy_sebzemeyvehamalmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvehamalmuhkoduS { get; set; }

    [Column("fmy_sebzemeyvehamalkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvehamalkdvmuhkoduS { get; set; }

    [Column("fmy_sebzemeyvestopajmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvestopajmuhkoduS { get; set; }

    [Column("fmy_halkomisyonmuhkodu_s")]
    [StringLength(40)]
    public string? FmyHalkomisyonmuhkoduS { get; set; }

    [Column("fmy_sebzemeyvekomkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvekomkdvmuhkoduS { get; set; }

    [Column("fmy_halnavlunmuhkodu_s")]
    [StringLength(40)]
    public string? FmyHalnavlunmuhkoduS { get; set; }

    [Column("fmy_halnavlunkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmyHalnavlunkdvmuhkoduS { get; set; }

    [Column("fmy_halsandikrehinmuhkodu_s")]
    [StringLength(40)]
    public string? FmyHalsandikrehinmuhkoduS { get; set; }

    [Column("fmy_halsandikrehinkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmyHalsandikrehinkdvmuhkoduS { get; set; }

    [Column("fmy_rusummuhkodu_s")]
    [StringLength(40)]
    public string? FmyRusummuhkoduS { get; set; }

    [Column("fmy_kazanilmisfaizgelirimuhkodu")]
    [StringLength(40)]
    public string? FmyKazanilmisfaizgelirimuhkodu { get; set; }

    [Column("fmy_gerceklesmisfaizgiderimuhkodu")]
    [StringLength(40)]
    public string? FmyGerceklesmisfaizgiderimuhkodu { get; set; }

    [Column("fmy_alacaksenedireeskontmuhkodu")]
    [StringLength(40)]
    public string? FmyAlacaksenedireeskontmuhkodu { get; set; }

    [Column("fmy_borcsenedireeskontmuhkodu")]
    [StringLength(40)]
    public string? FmyBorcsenedireeskontmuhkodu { get; set; }

    [Column("fmy_kapasitemaliyetbirikimmuhkodu")]
    [StringLength(40)]
    public string? FmyKapasitemaliyetbirikimmuhkodu { get; set; }

    [Column("fmy_stokdegerdusuklugumuhkodu")]
    [StringLength(40)]
    public string? FmyStokdegerdusuklugumuhkodu { get; set; }

    [Column("fmy_stokdegerdusuklugugiderimuhkodu")]
    [StringLength(40)]
    public string? FmyStokdegerdusuklugugiderimuhkodu { get; set; }

    [Column("fmy_izingiderimuhkodu")]
    [StringLength(40)]
    public string? FmyIzingiderimuhkodu { get; set; }

    [Column("fmy_izinkarsiligimuhkodu")]
    [StringLength(40)]
    public string? FmyIzinkarsiligimuhkodu { get; set; }

    [Column("fmy_tazminatgiderimuhkodu")]
    [StringLength(40)]
    public string? FmyTazminatgiderimuhkodu { get; set; }

    [Column("fmy_tazminatkarsiligimuhkodu")]
    [StringLength(40)]
    public string? FmyTazminatkarsiligimuhkodu { get; set; }

    [Column("fmy_rusumkdvmuhkodu")]
    [StringLength(40)]
    public string? FmyRusumkdvmuhkodu { get; set; }

    [Column("fmy_rusumkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmyRusumkdvmuhkoduS { get; set; }

    [Column("fmy_sebzemeyvedigermuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvedigermuhkoduS { get; set; }

    [Column("fmy_sebzemeyvedigerkdvmuhkodu_s")]
    [StringLength(40)]
    public string? FmySebzemeyvedigerkdvmuhkoduS { get; set; }

    [Column("fmy_tecilotvmuhkodu")]
    [StringLength(40)]
    public string? FmyTecilotvmuhkodu { get; set; }

    [Column("fmy_arge_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmyArgeGiderHesapkodu { get; set; }

    [Column("fmy_pazarlama_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmyPazarlamaGiderHesapkodu { get; set; }

    [Column("fmy_yonetim_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmyYonetimGiderHesapkodu { get; set; }

    [Column("fmy_finansman_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmyFinansmanGiderHesapkodu { get; set; }

    [Column("fmy_alisotvtevkifatmuhkodu")]
    [StringLength(40)]
    public string? FmyAlisotvtevkifatmuhkodu { get; set; }

    [Column("fmy_satisotvtevkifatmuhkodu")]
    [StringLength(40)]
    public string? FmySatisotvtevkifatmuhkodu { get; set; }

    [Column("fmy_odeme_emri_karsiliksiz_masraf_kodu")]
    [StringLength(25)]
    public string? FmyOdemeEmriKarsiliksizMasrafKodu { get; set; }

    [Column("fmy_beyanname_dosya_yolu")]
    [StringLength(50)]
    public string? FmyBeyannameDosyaYolu { get; set; }
}
