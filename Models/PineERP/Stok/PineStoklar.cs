using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok/Urun ana kart tanimlari.
/// Mikro ERP STOKLAR tablosuna denk gelir.
/// Urunlerin tum temel bilgilerini, siniflandirmalarini, birim/vergi/barkod/boyut bilgilerini icerir.
/// </summary>
[Table("pine_stoklar")]
public class PineStoklar : BaseEntity
{
    // ===== TEMEL BILGILER =====

    [Column("sto_kod")]
    [StringLength(25)]
    public string StoKod { get; set; } = string.Empty;

    [Column("sto_isim")]
    [StringLength(200)]
    public string StoIsim { get; set; } = string.Empty;

    [Column("sto_kisa_isim")]
    [StringLength(50)]
    public string? StoKisaIsim { get; set; }

    [Column("sto_yabanci_isim")]
    [StringLength(200)]
    public string? StoYabanciIsim { get; set; }

    // ===== SINIFLANDIRMA =====

    /// <summary>Stok cinsi: 0=Mamul, 1=Ticari Mal, 2=Hammadde, 3=Yari Mamul, 4=Hizmet, 5=Diger, 6=Ambalaj, 7=Demirbas, 8=Masraf, 9=Sarf Malzeme, 10=Proje, 11=Sanal</summary>
    [Column("sto_cins")]
    public int StoCins { get; set; } = 0;

    [Column("sto_anagrup_kod")]
    [StringLength(25)]
    public string? StoAnagrupKod { get; set; }

    [Column("sto_altgrup_kod")]
    [StringLength(25)]
    public string? StoAltgrupKod { get; set; }

    [Column("sto_kategori_kodu")]
    [StringLength(25)]
    public string? StoKategoriKodu { get; set; }

    [Column("sto_marka_kodu")]
    [StringLength(25)]
    public string? StoMarkaKodu { get; set; }

    [Column("sto_sektor_kodu")]
    [StringLength(25)]
    public string? StoSektorKodu { get; set; }

    // ===== BIRIM BILGILERI =====

    [Column("sto_birim1_ad")]
    [StringLength(20)]
    public string StoBirim1Ad { get; set; } = "Adet";

    [Column("sto_birim2_ad")]
    [StringLength(20)]
    public string? StoBirim2Ad { get; set; }

    [Column("sto_birim3_ad")]
    [StringLength(20)]
    public string? StoBirim3Ad { get; set; }

    [Column("sto_birim2_katsayi")]
    public decimal StoBirim2Katsayi { get; set; } = 0;

    [Column("sto_birim3_katsayi")]
    public decimal StoBirim3Katsayi { get; set; } = 0;

    [Column("sto_birim4_ad")]
    [StringLength(20)]
    public string? StoBirim4Ad { get; set; }

    [Column("sto_birim4_katsayi")]
    public decimal StoBirim4Katsayi { get; set; } = 0;

    // ===== BOYUT / AGIRLIK =====

    [Column("sto_birim_agirlik")]
    public decimal StoBirimAgirlik { get; set; } = 0;

    [Column("sto_birim_en")]
    public decimal StoBirimEn { get; set; } = 0;

    [Column("sto_birim_boy")]
    public decimal StoBirimBoy { get; set; } = 0;

    [Column("sto_birim_yukseklik")]
    public decimal StoBirimYukseklik { get; set; } = 0;

    [Column("sto_birim_hacim")]
    public decimal StoBirimHacim { get; set; } = 0;

    // ===== STOK SEVIYELERI =====

    [Column("sto_min_stok")]
    public decimal StoMinStok { get; set; } = 0;

    [Column("sto_max_stok")]
    public decimal StoMaxStok { get; set; } = 0;

    [Column("sto_siparis_stok")]
    public decimal StoSiparisStok { get; set; } = 0;

    /// <summary>Siparis temin suresi (gun)</summary>
    [Column("sto_siparis_sure")]
    public int StoSiparisSure { get; set; } = 0;

    // ===== VERGI BILGILERI =====

    [Column("sto_perakende_vergi")]
    public decimal StoPerakendeVergi { get; set; } = 20;

    [Column("sto_toptan_vergi")]
    public decimal StoToptanVergi { get; set; } = 20;

    /// <summary>OTV uygulama sekli: 0=Yok, 1=Yuzde, 2=Tutar</summary>
    [Column("sto_otv_uygulama")]
    public int StoOtvUygulama { get; set; } = 0;

    [Column("sto_otv_tutari")]
    public decimal StoOtvTutari { get; set; } = 0;

    // ===== BARKOD BILGILERI =====

    [Column("sto_barkod1")]
    [StringLength(50)]
    public string? StoBarkod1 { get; set; }

    [Column("sto_barkod2")]
    [StringLength(50)]
    public string? StoBarkod2 { get; set; }

    [Column("sto_barkod3")]
    [StringLength(50)]
    public string? StoBarkod3 { get; set; }

    // ===== REFERANS KODLARI =====

    [Column("sto_uretici_kodu")]
    [StringLength(25)]
    public string? StoUreticiKodu { get; set; }

    [Column("sto_tedarikci_kodu")]
    [StringLength(25)]
    public string? StoTedarikciKodu { get; set; }

    [Column("sto_gtip_kodu")]
    [StringLength(20)]
    public string? StoGtipKodu { get; set; }

    [Column("sto_mensei")]
    [StringLength(50)]
    public string? StoMensei { get; set; }

    // ===== TAKIP BILGILERI =====

    /// <summary>Garanti suresi (ay)</summary>
    [Column("sto_garanti_suresi")]
    public int StoGarantiSuresi { get; set; } = 0;

    /// <summary>Raf omru (gun)</summary>
    [Column("sto_raf_omru")]
    public int StoRafOmru { get; set; } = 0;

    [Column("sto_seri_takibi")]
    public bool StoSeriTakibi { get; set; } = false;

    [Column("sto_lot_takibi")]
    public bool StoLotTakibi { get; set; } = false;

    /// <summary>Son kullanma tarihi takibi</summary>
    [Column("sto_skt_takibi")]
    public bool StoSktTakibi { get; set; } = false;

    // ===== DURUM BAYRAKLARI =====

    [Column("sto_pasif_fl")]
    public bool StoPasifFl { get; set; } = false;

    [Column("sto_satis_dursun")]
    public bool StoSatisDursun { get; set; } = false;

    [Column("sto_siparis_dursun")]
    public bool StoSiparisDursun { get; set; } = false;

    // ===== E-FATURA =====

    [Column("sto_efat_sinif_kodu")]
    [StringLength(20)]
    public string? StoEfatSinifKodu { get; set; }

    // ===== MEDYA =====

    [Column("sto_resim_url")]
    [StringLength(500)]
    public string? StoResimUrl { get; set; }

    // ===== NOTLAR / ACIKLAMA =====

    [Column("sto_aciklama")]
    [StringLength(500)]
    public string? StoAciklama { get; set; }

    [Column("sto_not1")]
    [StringLength(500)]
    public string? StoNot1 { get; set; }

    [Column("sto_not2")]
    [StringLength(500)]
    public string? StoNot2 { get; set; }

    [Column("sto_not3")]
    [StringLength(500)]
    public string? StoNot3 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("sto_ozelkod1")]
    [StringLength(50)]
    public string? StoOzelkod1 { get; set; }

    [Column("sto_ozelkod2")]
    [StringLength(50)]
    public string? StoOzelkod2 { get; set; }

    [Column("sto_ozelkod3")]
    [StringLength(50)]
    public string? StoOzelkod3 { get; set; }

    [Column("sto_ozelkod4")]
    [StringLength(50)]
    public string? StoOzelkod4 { get; set; }

    [Column("sto_ozelkod5")]
    [StringLength(50)]
    public string? StoOzelkod5 { get; set; }

    // ===== KOMISYON =====

    [Column("sto_komisyon_orani")]
    public decimal StoKomisyonOrani { get; set; } = 0;

    // ===== KALITE =====

    [Column("sto_kalite_kontrol")]
    public bool StoKaliteKontrol { get; set; } = false;

    // ===== AMBALAJ =====

    [Column("sto_ambalaj_tipi")]
    [StringLength(50)]
    public string? StoAmbalajTipi { get; set; }

    [Column("sto_koli_adedi")]
    public int StoKoliAdedi { get; set; } = 0;

    // =============================================
    // ===== MIKRO UYUMU: YENI ALANLAR (v2) =====
    // =============================================

    // ----- Detaylar tab -----
    /// <summary>Hedef stok seviyesi</summary>
    [Column("sto_hedef_stok")]
    public decimal StoHedefStok { get; set; } = 0;

    [Column("sto_min_seviye_belirleme_gun")]
    public int StoMinSeviyeBelirlemeGun { get; set; } = 0;

    [Column("sto_siparis_seviye_belirleme_gun")]
    public int StoSiparisSeviyeBelirlemeGun { get; set; } = 0;

    [Column("sto_hedef_seviye_belirleme_gun")]
    public int StoHedefSeviyeBelirlemeGun { get; set; } = 0;

    [Column("sto_seviye_degerlendirilmesin")]
    public bool StoSeviyeDegerlendirilmesin { get; set; } = false;

    [Column("sto_verilen_siparis_birim")]
    [StringLength(20)]
    public string? StoVerilenSiparisBirim { get; set; }

    [Column("sto_depo_adresi")]
    [StringLength(100)]
    public string? StoDepoAdresi { get; set; }

    [Column("sto_kar_orani")]
    public decimal StoKarOrani { get; set; } = 0;

    [Column("sto_prim_orani")]
    public decimal StoPrimOrani { get; set; } = 0;

    [Column("sto_puani")]
    public decimal StoPuani { get; set; } = 0;

    [Column("sto_komisyon_hizmet_kodu")]
    [StringLength(25)]
    public string? StoKomisyonHizmetKodu { get; set; }

    [Column("sto_ongorulen_garanti_birim")]
    [StringLength(10)]
    public string? StoOngorulenGarantiBirim { get; set; } = "Ay";

    [Column("sto_mikroshop_maks_iskonto")]
    public decimal StoMikroshopMaksIskonto { get; set; } = 0;

    [Column("sto_ondalikli_uretim")]
    public bool StoOndalikliUretim { get; set; } = false;

    [Column("sto_z_raporu_departman")]
    public bool StoZRaporuDepartman { get; set; } = false;

    [Column("sto_iplik_ne_numarasi")]
    public decimal StoIplikNeNumarasi { get; set; } = 0;

    [Column("sto_kanban_kasa_miktari")]
    public decimal StoKanbanKasaMiktari { get; set; } = 0;

    [Column("sto_iskonto_matrisi_kasalar")]
    public bool StoIskontoMatrisiKasalar { get; set; } = false;

    [Column("sto_iskonto_orani")]
    public decimal StoIskontoOrani { get; set; } = 0;

    [Column("sto_iskonto_tutari")]
    public decimal StoIskontoTutari { get; set; } = 0;

    [Column("sto_varsayilan_gider_kodu")]
    [StringLength(25)]
    public string? StoVarsayilanGiderKodu { get; set; }

    [Column("sto_gelir_payi")]
    public decimal StoGelirPayi { get; set; } = 0;

    // ----- Takip detaylari tab -----
    [Column("sto_skt_kullanimi")]
    public bool StoSktKullanimi { get; set; } = false;

    [Column("sto_terazi_skt")]
    public int StoTeraziSkt { get; set; } = 0;

    [Column("sto_kasada_taksitlenebilir")]
    public bool StoKasadaTaksitlenebilir { get; set; } = false;

    [Column("sto_hal_rusumu")]
    public decimal StoHalRusumu { get; set; } = 0;

    [Column("sto_kaynak_planlama_degerlendirilsin")]
    public bool StoKaynakPlanlamaDegerlendirilsin { get; set; } = true;

    [Column("sto_crm_aktarilacak")]
    public bool StoCrmAktarilacak { get; set; } = false;

    [Column("sto_uts_gonderilsin")]
    public bool StoUtsGonderilsin { get; set; } = false;

    [Column("sto_geri_kazanim_beyanname")]
    public bool StoGeriKazanimBeyanname { get; set; } = false;

    [Column("sto_gekap_kodu")]
    [StringLength(25)]
    public string? StoGekapKodu { get; set; }

    [Column("sto_gekap_birimi")]
    [StringLength(20)]
    public string? StoGekapBirimi { get; set; }

    [Column("sto_gekap_dep_onay_kodu")]
    [StringLength(50)]
    public string? StoGekapDepOnayKodu { get; set; }

    [Column("sto_stt_oncesi_kaldirma")]
    public int StoSttOncesiKaldirma { get; set; } = 0;

    [Column("sto_toplam_raf_omru")]
    public int StoToplamRafOmru { get; set; } = 0;

    [Column("sto_cabuk_bozulabilen")]
    public bool StoCabukBozulabilen { get; set; } = false;

    [Column("sto_satinalma_talep_birim")]
    [StringLength(20)]
    public string? StoSatinalmaTalepBirim { get; set; }

    [Column("sto_urun_niteligi")]
    [StringLength(50)]
    public string? StoUrunNiteligi { get; set; } = "Diger";

    [Column("sto_gtin_uno")]
    [StringLength(50)]
    public string? StoGtinUno { get; set; }

    [Column("sto_tibbi_lot_parti")]
    public bool StoTibbiLotParti { get; set; } = false;

    [Column("sto_karsi_program_kodu")]
    [StringLength(50)]
    public string? StoKarsiProgramKodu { get; set; }

    // ----- Entegrasyon kodlari tab (muhasebe hesap kodlari) -----
    [Column("sto_muh_stok")]
    [StringLength(50)]
    public string? StoMuhStok { get; set; }

    [Column("sto_muh_stok_iade")]
    [StringLength(50)]
    public string? StoMuhStokIade { get; set; }

    [Column("sto_muh_yurtici_satis")]
    [StringLength(50)]
    public string? StoMuhYurticiSatis { get; set; }

    [Column("sto_muh_satilan_mal_maliyeti")]
    [StringLength(50)]
    public string? StoMuhSatilanMalMaliyeti { get; set; }

    [Column("sto_muh_yurtdisi_satis")]
    [StringLength(50)]
    public string? StoMuhYurtdisiSatis { get; set; }

    [Column("sto_muh_yurtdisi_maliyet")]
    [StringLength(50)]
    public string? StoMuhYurtdisiMaliyet { get; set; }

    [Column("sto_muh_satis_iade")]
    [StringLength(50)]
    public string? StoMuhSatisIade { get; set; }

    [Column("sto_muh_satis_iskonto")]
    [StringLength(50)]
    public string? StoMuhSatisIskonto { get; set; }

    [Column("sto_muh_alis_iskonto")]
    [StringLength(50)]
    public string? StoMuhAlisIskonto { get; set; }

    [Column("sto_muh_ilave_masraf")]
    [StringLength(50)]
    public string? StoMuhIlaveMasraf { get; set; }

    [Column("sto_muh_yatirim_tesvik")]
    [StringLength(50)]
    public string? StoMuhYatirimTesvik { get; set; }

    [Column("sto_muh_depolar_arasi_satis")]
    [StringLength(50)]
    public string? StoMuhDepolarArasiSatis { get; set; }

    [Column("sto_muh_depolar_arasi_maliyet")]
    [StringLength(50)]
    public string? StoMuhDepolarArasiMaliyet { get; set; }

    [Column("sto_muh_bagli_ortaklik_satis")]
    [StringLength(50)]
    public string? StoMuhBagliOrtaklikSatis { get; set; }

    [Column("sto_muh_bagli_ortaklik_iade")]
    [StringLength(50)]
    public string? StoMuhBagliOrtaklikIade { get; set; }

    [Column("sto_muh_bagli_ortaklik_iskonto")]
    [StringLength(50)]
    public string? StoMuhBagliOrtaklikIskonto { get; set; }

    [Column("sto_muh_bagli_ortaklik_maliyet")]
    [StringLength(50)]
    public string? StoMuhBagliOrtaklikMaliyet { get; set; }

    [Column("sto_muh_satis_fiyat_farki")]
    [StringLength(50)]
    public string? StoMuhSatisFiyatFarki { get; set; }

    [Column("sto_muh_sifir_bedel_maliyet")]
    [StringLength(50)]
    public string? StoMuhSifirBedelMaliyet { get; set; }

    [Column("sto_muh_ihrac_kayitli_satis")]
    [StringLength(50)]
    public string? StoMuhIhracKayitliSatis { get; set; }

    [Column("sto_muh_ihrac_kayitli_maliyet")]
    [StringLength(50)]
    public string? StoMuhIhracKayitliMaliyet { get; set; }

    [Column("sto_muh_kod_artikeli")]
    [StringLength(20)]
    public string? StoMuhKodArtikeli { get; set; }

    // ----- Grup tanitim kodlari tab (ek gruplar) -----
    [Column("sto_pozisyon_grup_kodu")]
    [StringLength(25)]
    public string? StoPozisyonGrupKodu { get; set; }

    [Column("sto_ana_saglayici_kodu")]
    [StringLength(25)]
    public string? StoAnaSaglayiciKodu { get; set; }

    [Column("sto_reyon_kodu")]
    [StringLength(25)]
    public string? StoReyonKodu { get; set; }

    [Column("sto_ambalaj_kodu")]
    [StringLength(25)]
    public string? StoAmbalajKodu { get; set; }

    [Column("sto_muhasebe_grup_kodu")]
    [StringLength(25)]
    public string? StoMuhasebeGrupKodu { get; set; }

    [Column("sto_urun_sorumlusu_kodu")]
    [StringLength(25)]
    public string? StoUrunSorumlusuKodu { get; set; }

    [Column("sto_kalite_kontrol_kodu")]
    [StringLength(25)]
    public string? StoKaliteKontrolKodu { get; set; }

    [Column("sto_model_kodu")]
    [StringLength(25)]
    public string? StoModelKodu { get; set; }

    [Column("sto_sezon_kodu")]
    [StringLength(25)]
    public string? StoSezonKodu { get; set; }

    [Column("sto_anahammadde_kodu")]
    [StringLength(25)]
    public string? StoAnahammaddeKodu { get; set; }

    [Column("sto_prim_grup_kodu")]
    [StringLength(25)]
    public string? StoPrimGrupKodu { get; set; }

    [Column("sto_beden_detayli")]
    public bool StoBedenDetayli { get; set; } = false;

    [Column("sto_beden_kodu")]
    [StringLength(25)]
    public string? StoBedenKodu { get; set; }

    [Column("sto_renk_detayli")]
    public bool StoRenkDetayli { get; set; } = false;

    [Column("sto_renk_kodu")]
    [StringLength(25)]
    public string? StoRenkKodu { get; set; }

    [Column("sto_paket_kodu")]
    [StringLength(25)]
    public string? StoPaketKodu { get; set; }

    [Column("sto_tamamlayici_kodu")]
    [StringLength(25)]
    public string? StoTamamlayiciKodu { get; set; }

    // ----- Pozisyon bayraklari grup tab -----
    [Column("sto_raf_etiketi")]
    public bool StoRafEtiketi { get; set; } = false;

    [Column("sto_elektronik_etiket_tipi")]
    [StringLength(30)]
    public string? StoElektronikEtiketTipi { get; set; } = "Standart";

    [Column("sto_etiket_basilsin")]
    public bool StoEtiketBasilsin { get; set; } = true;

    [Column("sto_mal_kabul_dursun")]
    public bool StoMalKabulDursun { get; set; } = false;

    [Column("sto_mal_kabul_gunleri")]
    [StringLength(20)]
    public string? StoMalKabulGunleri { get; set; }

    [Column("sto_siparis_gunleri")]
    [StringLength(20)]
    public string? StoSiparisGunleri { get; set; }

    [Column("sto_iskonto_yapilamaz")]
    public bool StoIskontoYapilamaz { get; set; } = false;

    [Column("sto_kasada_tartilan")]
    public bool StoKasadaTartilan { get; set; } = false;

    [Column("sto_eksi_dusme_gozardi")]
    public bool StoEksiDusmeGozardi { get; set; } = false;

    [Column("sto_web_gonderilecek")]
    public bool StoWebGonderilecek { get; set; } = false;

    [Column("sto_mensei_tipi")]
    [StringLength(20)]
    public string? StoMenseiTipi { get; set; } = "Yerli";

    [Column("sto_fiyat_kasada_belirlensin")]
    public bool StoFiyatKasadaBelirlensin { get; set; } = false;

    [Column("sto_franchise_siparis_dursun")]
    public bool StoFranchiseSiparisDursun { get; set; } = false;

    [Column("sto_tasfiyede")]
    public bool StoTasfiyede { get; set; } = false;

    [Column("sto_yerlilik_orani")]
    public decimal StoYerlilikOrani { get; set; } = 0;

    // ----- Stok tanitim karti ek alanlar -----
    [Column("sto_pesin_satis_fiyati")]
    public decimal StoPesinSatisFiyati { get; set; } = 0;

    [Column("sto_pesin_satis_doviz")]
    [StringLength(10)]
    public string? StoPesinSatisDoviz { get; set; } = "TL";

    [Column("sto_iskonto_kodu")]
    [StringLength(25)]
    public string? StoIskontoKodu { get; set; }

    [Column("sto_standart_maliyet")]
    public decimal StoStandartMaliyet { get; set; } = 0;

    [Column("sto_otv_birimi")]
    [StringLength(20)]
    public string? StoOtvBirimi { get; set; } = "ADET";

    [Column("sto_otv_liste_no")]
    public int StoOtvListeNo { get; set; } = 0;

    [Column("sto_otv_tevkifat_uygulama")]
    [StringLength(20)]
    public string? StoOtvTevkifatUygulama { get; set; }

    [Column("sto_oiv_uygulama")]
    public int StoOivUygulama { get; set; } = 0;

    [Column("sto_oiv_tutar_oran")]
    public decimal StoOivTutarOran { get; set; } = 0;

    [Column("sto_oiv_turu")]
    [StringLength(20)]
    public string? StoOivTuru { get; set; } = "Yok";

    [Column("sto_oiv_vergi_tipi")]
    [StringLength(50)]
    public string? StoOivVergiTipi { get; set; }

    [Column("sto_kdv_tevkifat_uygulama")]
    [StringLength(20)]
    public string? StoKdvTevkifatUygulama { get; set; }
}
