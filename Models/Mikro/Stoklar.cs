using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stoklar")]
public class Stoklar
{
    [Column("sto_kod")]
    [StringLength(25)]
    public string StoKod { get; set; }

    [Column("sto_Guid")]
    public Guid? StoGuid { get; set; }

    [Column("sto_DBCno")]
    public short? StoDBCno { get; set; }

    [Column("sto_SpecRECno")]
    public int? StoSpecRECno { get; set; }

    [Column("sto_iptal")]
    public bool? StoIptal { get; set; }

    [Column("sto_fileid")]
    public short? StoFileid { get; set; }

    [Column("sto_hidden")]
    public bool? StoHidden { get; set; }

    [Column("sto_kilitli")]
    public bool? StoKilitli { get; set; }

    [Column("sto_degisti")]
    public bool? StoDegisti { get; set; }

    [Column("sto_checksum")]
    public int? StoChecksum { get; set; }

    [Column("sto_create_user")]
    public short? StoCreateUser { get; set; }

    [Column("sto_create_date")]
    public DateTime? StoCreateDate { get; set; }

    [Column("sto_lastup_user")]
    public short? StoLastupUser { get; set; }

    [Column("sto_lastup_date")]
    public DateTime? StoLastupDate { get; set; }

    [Column("sto_special1")]
    [StringLength(4)]
    public string? StoSpecial1 { get; set; }

    [Column("sto_special2")]
    [StringLength(4)]
    public string? StoSpecial2 { get; set; }

    [Column("sto_special3")]
    [StringLength(4)]
    public string? StoSpecial3 { get; set; }

    [Column("sto_isim")]
    [StringLength(50)]
    public string? StoIsim { get; set; }

    [Column("sto_kisa_ismi")]
    [StringLength(25)]
    public string? StoKisaIsmi { get; set; }

    [Column("sto_yabanci_isim")]
    [StringLength(50)]
    public string? StoYabanciIsim { get; set; }

    [Column("sto_sat_cari_kod")]
    [StringLength(25)]
    public string? StoSatCariKod { get; set; }

    [Column("sto_cins")]
    public byte? StoCins { get; set; }

    [Column("sto_doviz_cinsi")]
    public byte? StoDovizCinsi { get; set; }

    [Column("sto_detay_takip")]
    public byte? StoDetayTakip { get; set; }

    [Column("sto_birim1_ad")]
    [StringLength(10)]
    public string? StoBirim1Ad { get; set; }

    [Column("sto_birim1_katsayi")]
    public double? StoBirim1Katsayi { get; set; }

    [Column("sto_birim1_agirlik")]
    public double? StoBirim1Agirlik { get; set; }

    [Column("sto_birim1_en")]
    public double? StoBirim1En { get; set; }

    [Column("sto_birim1_boy")]
    public double? StoBirim1Boy { get; set; }

    [Column("sto_birim1_yukseklik")]
    public double? StoBirim1Yukseklik { get; set; }

    [Column("sto_birim1_dara")]
    public double? StoBirim1Dara { get; set; }

    [Column("sto_birim2_ad")]
    [StringLength(10)]
    public string? StoBirim2Ad { get; set; }

    [Column("sto_birim2_katsayi")]
    public double? StoBirim2Katsayi { get; set; }

    [Column("sto_birim2_agirlik")]
    public double? StoBirim2Agirlik { get; set; }

    [Column("sto_birim2_en")]
    public double? StoBirim2En { get; set; }

    [Column("sto_birim2_boy")]
    public double? StoBirim2Boy { get; set; }

    [Column("sto_birim2_yukseklik")]
    public double? StoBirim2Yukseklik { get; set; }

    [Column("sto_birim2_dara")]
    public double? StoBirim2Dara { get; set; }

    [Column("sto_birim3_ad")]
    [StringLength(10)]
    public string? StoBirim3Ad { get; set; }

    [Column("sto_birim3_katsayi")]
    public double? StoBirim3Katsayi { get; set; }

    [Column("sto_birim3_agirlik")]
    public double? StoBirim3Agirlik { get; set; }

    [Column("sto_birim3_en")]
    public double? StoBirim3En { get; set; }

    [Column("sto_birim3_boy")]
    public double? StoBirim3Boy { get; set; }

    [Column("sto_birim3_yukseklik")]
    public double? StoBirim3Yukseklik { get; set; }

    [Column("sto_birim3_dara")]
    public double? StoBirim3Dara { get; set; }

    [Column("sto_birim4_ad")]
    [StringLength(10)]
    public string? StoBirim4Ad { get; set; }

    [Column("sto_birim4_katsayi")]
    public double? StoBirim4Katsayi { get; set; }

    [Column("sto_birim4_agirlik")]
    public double? StoBirim4Agirlik { get; set; }

    [Column("sto_birim4_en")]
    public double? StoBirim4En { get; set; }

    [Column("sto_birim4_boy")]
    public double? StoBirim4Boy { get; set; }

    [Column("sto_birim4_yukseklik")]
    public double? StoBirim4Yukseklik { get; set; }

    [Column("sto_birim4_dara")]
    public double? StoBirim4Dara { get; set; }

    [Column("sto_muh_kod")]
    [StringLength(40)]
    public string? StoMuhKod { get; set; }

    [Column("sto_muh_Iade_kod")]
    [StringLength(40)]
    public string? StoMuhIadeKod { get; set; }

    [Column("sto_muh_sat_muh_kod")]
    [StringLength(40)]
    public string? StoMuhSatMuhKod { get; set; }

    [Column("sto_muh_satIadmuhkod")]
    [StringLength(40)]
    public string? StoMuhSatIadmuhkod { get; set; }

    [Column("sto_muh_sat_isk_kod")]
    [StringLength(40)]
    public string? StoMuhSatIskKod { get; set; }

    [Column("sto_muh_aIiskmuhkod")]
    [StringLength(40)]
    public string? StoMuhAIiskmuhkod { get; set; }

    [Column("sto_muh_satmalmuhkod")]
    [StringLength(40)]
    public string? StoMuhSatmalmuhkod { get; set; }

    [Column("sto_yurtdisi_satmuhk")]
    [StringLength(40)]
    public string? StoYurtdisiSatmuhk { get; set; }

    [Column("sto_ilavemasmuhkod")]
    [StringLength(40)]
    public string? StoIlavemasmuhkod { get; set; }

    [Column("sto_yatirimtesmuhkod")]
    [StringLength(40)]
    public string? StoYatirimtesmuhkod { get; set; }

    [Column("sto_depsatmuhkod")]
    [StringLength(40)]
    public string? StoDepsatmuhkod { get; set; }

    [Column("sto_depsatmalmuhkod")]
    [StringLength(40)]
    public string? StoDepsatmalmuhkod { get; set; }

    [Column("sto_bagortsatmuhkod")]
    [StringLength(40)]
    public string? StoBagortsatmuhkod { get; set; }

    [Column("sto_bagortsatIadmuhkod")]
    [StringLength(40)]
    public string? StoBagortsatIadmuhkod { get; set; }

    [Column("sto_bagortsatIskmuhkod")]
    [StringLength(40)]
    public string? StoBagortsatIskmuhkod { get; set; }

    [Column("sto_satfiyfarksmuhkod")]
    [StringLength(40)]
    public string? StoSatfiyfarksmuhkod { get; set; }

    [Column("sto_yurtdisisatmalmuhkod")]
    [StringLength(40)]
    public string? StoYurtdisisatmalmuhkod { get; set; }

    [Column("sto_bagortsatmalmuhkod")]
    [StringLength(40)]
    public string? StoBagortsatmalmuhkod { get; set; }

    [Column("sto_sifirbedsatmalmuhkod")]
    [StringLength(40)]
    public string? StoSifirbedsatmalmuhkod { get; set; }

    [Column("sto_karorani")]
    public double? StoKarorani { get; set; }

    [Column("sto_min_stok")]
    public double? StoMinStok { get; set; }

    [Column("sto_siparis_stok")]
    public double? StoSiparisStok { get; set; }

    [Column("sto_max_stok")]
    public double? StoMaxStok { get; set; }

    [Column("sto_ver_sip_birim")]
    public byte? StoVerSipBirim { get; set; }

    [Column("sto_al_sip_birim")]
    public byte? StoAlSipBirim { get; set; }

    [Column("sto_siparis_sure")]
    public short? StoSiparisSure { get; set; }

    [Column("sto_perakende_vergi")]
    public byte? StoPerakendeVergi { get; set; }

    [Column("sto_toptan_vergi")]
    public byte? StoToptanVergi { get; set; }

    [Column("sto_yer_kod")]
    [StringLength(25)]
    public string? StoYerKod { get; set; }

    [Column("sto_elk_etk_tipi")]
    public byte? StoElkEtkTipi { get; set; }

    [Column("sto_raf_etiketli")]
    public byte? StoRafEtiketli { get; set; }

    [Column("sto_etiket_bas")]
    public byte? StoEtiketBas { get; set; }

    [Column("sto_satis_dursun")]
    public byte? StoSatisDursun { get; set; }

    [Column("sto_siparis_dursun")]
    public byte? StoSiparisDursun { get; set; }

    [Column("sto_malkabul_dursun")]
    public byte? StoMalkabulDursun { get; set; }

    [Column("sto_malkabul_gun1")]
    public bool? StoMalkabulGun1 { get; set; }

    [Column("sto_malkabul_gun2")]
    public bool? StoMalkabulGun2 { get; set; }

    [Column("sto_malkabul_gun3")]
    public bool? StoMalkabulGun3 { get; set; }

    [Column("sto_malkabul_gun4")]
    public bool? StoMalkabulGun4 { get; set; }

    [Column("sto_malkabul_gun5")]
    public bool? StoMalkabulGun5 { get; set; }

    [Column("sto_malkabul_gun6")]
    public bool? StoMalkabulGun6 { get; set; }

    [Column("sto_malkabul_gun7")]
    public bool? StoMalkabulGun7 { get; set; }

    [Column("sto_siparis_gun1")]
    public bool? StoSiparisGun1 { get; set; }

    [Column("sto_siparis_gun2")]
    public bool? StoSiparisGun2 { get; set; }

    [Column("sto_siparis_gun3")]
    public bool? StoSiparisGun3 { get; set; }

    [Column("sto_siparis_gun4")]
    public bool? StoSiparisGun4 { get; set; }

    [Column("sto_siparis_gun5")]
    public bool? StoSiparisGun5 { get; set; }

    [Column("sto_siparis_gun6")]
    public bool? StoSiparisGun6 { get; set; }

    [Column("sto_siparis_gun7")]
    public bool? StoSiparisGun7 { get; set; }

    [Column("sto_iskon_yapilamaz")]
    public bool? StoIskonYapilamaz { get; set; }

    [Column("sto_tasfiyede")]
    public bool? StoTasfiyede { get; set; }

    [Column("sto_alt_grup_no")]
    public short? StoAltGrupNo { get; set; }

    [Column("sto_kategori_kodu")]
    [StringLength(25)]
    public string? StoKategoriKodu { get; set; }

    [Column("sto_urun_sorkod")]
    [StringLength(25)]
    public string? StoUrunSorkod { get; set; }

    [Column("sto_altgrup_kod")]
    [StringLength(25)]
    public string? StoAltgrupKod { get; set; }

    [Column("sto_anagrup_kod")]
    [StringLength(25)]
    public string? StoAnagrupKod { get; set; }

    [Column("sto_uretici_kodu")]
    [StringLength(25)]
    public string? StoUreticiKodu { get; set; }

    [Column("sto_sektor_kodu")]
    [StringLength(25)]
    public string? StoSektorKodu { get; set; }

    [Column("sto_reyon_kodu")]
    [StringLength(25)]
    public string? StoReyonKodu { get; set; }

    [Column("sto_muhgrup_kodu")]
    [StringLength(25)]
    public string? StoMuhgrupKodu { get; set; }

    [Column("sto_ambalaj_kodu")]
    [StringLength(25)]
    public string? StoAmbalajKodu { get; set; }

    [Column("sto_marka_kodu")]
    [StringLength(25)]
    public string? StoMarkaKodu { get; set; }

    [Column("sto_beden_kodu")]
    [StringLength(25)]
    public string? StoBedenKodu { get; set; }

    [Column("sto_renk_kodu")]
    [StringLength(25)]
    public string? StoRenkKodu { get; set; }

    [Column("sto_model_kodu")]
    [StringLength(25)]
    public string? StoModelKodu { get; set; }

    [Column("sto_sezon_kodu")]
    [StringLength(25)]
    public string? StoSezonKodu { get; set; }

    [Column("sto_hammadde_kodu")]
    [StringLength(25)]
    public string? StoHammaddeKodu { get; set; }

    [Column("sto_prim_kodu")]
    [StringLength(25)]
    public string? StoPrimKodu { get; set; }

    [Column("sto_kalkon_kodu")]
    [StringLength(25)]
    public string? StoKalkonKodu { get; set; }

    [Column("sto_paket_kodu")]
    [StringLength(25)]
    public string? StoPaketKodu { get; set; }

    [Column("sto_pozisyonbayrak_kodu")]
    [StringLength(25)]
    public string? StoPozisyonbayrakKodu { get; set; }

    [Column("sto_mkod_artik")]
    [StringLength(10)]
    public string? StoMkodArtik { get; set; }

    [Column("sto_kasa_tarti_fl")]
    public bool? StoKasaTartiFl { get; set; }

    [Column("sto_bedenli_takip")]
    public bool? StoBedenliTakip { get; set; }

    [Column("sto_renkDetayli")]
    public bool? StoRenkDetayli { get; set; }

    [Column("sto_miktarondalikli_fl")]
    public bool? StoMiktarondalikliFl { get; set; }

    [Column("sto_pasif_fl")]
    public bool? StoPasifFl { get; set; }

    [Column("sto_eksiyedusebilir_fl")]
    public bool? StoEksiyedusebilirFl { get; set; }

    [Column("sto_GtipNo")]
    [StringLength(25)]
    public string? StoGtipNo { get; set; }

    [Column("sto_puan")]
    public double? StoPuan { get; set; }

    [Column("sto_komisyon_hzmkodu")]
    [StringLength(25)]
    public string? StoKomisyonHzmkodu { get; set; }

    [Column("sto_komisyon_orani")]
    public double? StoKomisyonOrani { get; set; }

    [Column("sto_otvuygulama")]
    public byte? StoOtvuygulama { get; set; }

    [Column("sto_otvtutar")]
    public double? StoOtvtutar { get; set; }

    [Column("sto_otvliste")]
    public byte? StoOtvliste { get; set; }

    [Column("sto_otvbirimi")]
    public byte? StoOtvbirimi { get; set; }

    [Column("sto_prim_orani")]
    public double? StoPrimOrani { get; set; }

    [Column("sto_garanti_sure")]
    public short? StoGarantiSure { get; set; }

    [Column("sto_garanti_sure_tipi")]
    public byte? StoGarantiSureTipi { get; set; }

    [Column("sto_iplik_Ne_no")]
    public double? StoIplikNeNo { get; set; }

    [Column("sto_standartmaliyet")]
    public double? StoStandartmaliyet { get; set; }

    [Column("sto_kanban_kasa_miktari")]
    public double? StoKanbanKasaMiktari { get; set; }

    [Column("sto_oivuygulama")]
    public byte? StoOivuygulama { get; set; }

    [Column("sto_zraporu_stoku_fl")]
    public bool? StoZraporuStokuFl { get; set; }

    [Column("sto_maxiskonto_orani")]
    public double? StoMaxiskontoOrani { get; set; }

    [Column("sto_detay_takibinde_depo_kontrolu_fl")]
    public bool? StoDetayTakibindeDepoKontroluFl { get; set; }

    [Column("sto_tamamlayici_kodu")]
    [StringLength(25)]
    public string? StoTamamlayiciKodu { get; set; }

    [Column("sto_oto_barkod_acma_sekli")]
    public byte? StoOtoBarkodAcmaSekli { get; set; }

    [Column("sto_oto_barkod_kod_yapisi")]
    [StringLength(5)]
    public string? StoOtoBarkodKodYapisi { get; set; }

    [Column("sto_KasaIskontoOrani")]
    public double? StoKasaIskontoOrani { get; set; }

    [Column("sto_KasaIskontoTutari")]
    public double? StoKasaIskontoTutari { get; set; }

    [Column("sto_gelirpayi")]
    public double? StoGelirpayi { get; set; }

    [Column("sto_oivtutar")]
    public double? StoOivtutar { get; set; }

    [Column("sto_oivturu")]
    public byte? StoOivturu { get; set; }

    [Column("sto_giderkodu")]
    [StringLength(25)]
    public string? StoGiderkodu { get; set; }

    [Column("sto_oivvergipntr")]
    public byte? StoOivvergipntr { get; set; }

    [Column("sto_Tevkifat_turu")]
    public byte? StoTevkifatTuru { get; set; }

    [Column("sto_SKT_fl")]
    public bool? StoSKTFl { get; set; }

    [Column("sto_terazi_SKT")]
    public short? StoTeraziSKT { get; set; }

    [Column("sto_RafOmru")]
    public short? StoRafOmru { get; set; }

    [Column("sto_KasadaTaksitlenebilir_fl")]
    public bool? StoKasadaTaksitlenebilirFl { get; set; }

    [Column("sto_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoUfrsfarkKod { get; set; }

    [Column("sto_iade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoIadeUfrsfarkKod { get; set; }

    [Column("sto_yurticisat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoYurticisatUfrsfarkKod { get; set; }

    [Column("sto_satiade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoSatiadeUfrsfarkKod { get; set; }

    [Column("sto_satisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoSatiskUfrsfarkKod { get; set; }

    [Column("sto_alisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoAliskUfrsfarkKod { get; set; }

    [Column("sto_satmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoSatmalUfrsfarkKod { get; set; }

    [Column("sto_yurtdisisat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoYurtdisisatUfrsfarkKod { get; set; }

    [Column("sto_ilavemas_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoIlavemasUfrsfarkKod { get; set; }

    [Column("sto_yatirimtes_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoYatirimtesUfrsfarkKod { get; set; }

    [Column("sto_depsat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoDepsatUfrsfarkKod { get; set; }

    [Column("sto_depsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoDepsatmalUfrsfarkKod { get; set; }

    [Column("sto_bagortsat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoBagortsatUfrsfarkKod { get; set; }

    [Column("sto_bagortsatiade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoBagortsatiadeUfrsfarkKod { get; set; }

    [Column("sto_bagortsatisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoBagortsatiskUfrsfarkKod { get; set; }

    [Column("sto_satfiyfark_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoSatfiyfarkUfrsfarkKod { get; set; }

    [Column("sto_yurtdisisatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoYurtdisisatmalUfrsfarkKod { get; set; }

    [Column("sto_bagortsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoBagortsatmalUfrsfarkKod { get; set; }

    [Column("sto_sifirbedsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoSifirbedsatmalUfrsfarkKod { get; set; }

    [Column("sto_uretimmaliyet_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoUretimmaliyetUfrsfarkKod { get; set; }

    [Column("sto_uretimkapasite_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoUretimkapasiteUfrsfarkKod { get; set; }

    [Column("sto_degerdusuklugu_ufrsfark_kod")]
    [StringLength(40)]
    public string? StoDegerdusukluguUfrsfarkKod { get; set; }

    [Column("sto_halrusumyudesi")]
    public double? StoHalrusumyudesi { get; set; }

    [Column("sto_webe_gonderilecek_fl")]
    public bool? StoWebeGonderilecekFl { get; set; }

    [Column("sto_min_stok_belirleme_gun")]
    public short? StoMinStokBelirlemeGun { get; set; }

    [Column("sto_sip_stok_belirleme_gun")]
    public short? StoSipStokBelirlemeGun { get; set; }

    [Column("sto_max_stok_belirleme_gun")]
    public short? StoMaxStokBelirlemeGun { get; set; }

    [Column("sto_sev_bel_opr_degerlendime_fl")]
    public bool? StoSevBelOprDegerlendimeFl { get; set; }

    [Column("sto_otv_tevkifat_turu")]
    public byte? StoOtvTevkifatTuru { get; set; }

    [Column("sto_kay_plan_degerlendir")]
    public byte? StoKayPlanDegerlendir { get; set; }
}
