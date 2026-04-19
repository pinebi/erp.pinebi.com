using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yasal_parametreler")]
public class YasalParametreler
{
    [Column("ysl_Guid")]
    public Guid? YslGuid { get; set; }

    [Column("ysl_DBCno")]
    public short? YslDBCno { get; set; }

    [Column("ysl_SpecRECno")]
    public int? YslSpecRECno { get; set; }

    [Column("ysl_iptal")]
    public bool? YslIptal { get; set; }

    [Column("ysl_fileid")]
    public short? YslFileid { get; set; }

    [Column("ysl_hidden")]
    public bool? YslHidden { get; set; }

    [Column("ysl_kilitli")]
    public bool? YslKilitli { get; set; }

    [Column("ysl_degisti")]
    public bool? YslDegisti { get; set; }

    [Column("ysl_checksum")]
    public int? YslChecksum { get; set; }

    [Column("ysl_create_user")]
    public short? YslCreateUser { get; set; }

    [Column("ysl_create_date")]
    public DateTime? YslCreateDate { get; set; }

    [Column("ysl_lastup_user")]
    public short? YslLastupUser { get; set; }

    [Column("ysl_lastup_date")]
    public DateTime? YslLastupDate { get; set; }

    [Column("ysl_special1")]
    [StringLength(4)]
    public string? YslSpecial1 { get; set; }

    [Column("ysl_special2")]
    [StringLength(4)]
    public string? YslSpecial2 { get; set; }

    [Column("ysl_special3")]
    [StringLength(4)]
    public string? YslSpecial3 { get; set; }

    [Column("ysl_gecerlilik tarihi")]
    public DateTime? YslGecerlilikTarihi { get; set; }

    [Column("ysl_gunluk_cal_saati")]
    public double? YslGunlukCalSaati { get; set; }

    [Column("ysl_ver_muaf_cocuk_adedi")]
    public short? YslVerMuafCocukAdedi { get; set; }

    [Column("ysl_cocuk_yard_muafiyeti")]
    public double? YslCocukYardMuafiyeti { get; set; }

    [Column("ysl_subat_sskgun_esit_calgun")]
    public bool? YslSubatSskgunEsitCalgun { get; set; }

    [Column("ysl_ay_basinda_girene_kf_yok")]
    public bool? YslAyBasindaGireneKfYok { get; set; }

    [Column("ysl_ver_firma_top_yuvarla")]
    public bool? YslVerFirmaTopYuvarla { get; set; }

    [Column("ysl_ssk_matrahi_31_gunden")]
    public bool? YslSskMatrahi31Gunden { get; set; }

    [Column("ysl_ssk_matrahi_31_gunden1")]
    public bool? YslSskMatrahi31Gunden1 { get; set; }

    [Column("ysl_ssk_matrahi_31_gunden2")]
    public bool? YslSskMatrahi31Gunden2 { get; set; }

    [Column("ysl_tutarlari_brut_goster")]
    public bool? YslTutarlariBrutGoster { get; set; }

    [Column("ysl_kazanc_aciklamasi1")]
    [StringLength(20)]
    public string? YslKazancAciklamasi1 { get; set; }

    [Column("ysl_kazanc_aciklamasi2")]
    [StringLength(20)]
    public string? YslKazancAciklamasi2 { get; set; }

    [Column("ysl_kazanc_aciklamasi3")]
    [StringLength(20)]
    public string? YslKazancAciklamasi3 { get; set; }

    [Column("ysl_kazanc_aciklamasi4")]
    [StringLength(20)]
    public string? YslKazancAciklamasi4 { get; set; }

    [Column("ysl_kazanc_aciklamasi5")]
    [StringLength(20)]
    public string? YslKazancAciklamasi5 { get; set; }

    [Column("ysl_kazanc_aciklamasi6")]
    [StringLength(20)]
    public string? YslKazancAciklamasi6 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi1")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi1 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi2")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi2 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi3")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi3 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi4")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi4 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi5")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi5 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi6")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi6 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi7")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi7 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi8")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi8 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi9")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi9 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi10")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi10 { get; set; }

    [Column("ysl_ek_kazanc_aciklamasi11")]
    [StringLength(20)]
    public string? YslEkKazancAciklamasi11 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi1")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi1 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi2")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi2 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi3")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi3 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi4")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi4 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi5")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi5 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi6")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi6 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi7")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi7 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi8")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi8 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi9")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi9 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi10")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi10 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi11")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi11 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi12")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi12 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi13")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi13 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi14")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi14 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi15")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi15 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi16")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi16 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi17")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi17 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi18")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi18 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi19")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi19 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi20")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi20 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi21")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi21 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi22")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi22 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi23")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi23 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi24")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi24 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi25")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi25 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi26")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi26 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi27")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi27 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi28")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi28 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi29")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi29 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi30")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi30 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi31")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi31 { get; set; }

    [Column("ysl_sosyal_yardim_aciklamasi32")]
    [StringLength(20)]
    public string? YslSosyalYardimAciklamasi32 { get; set; }

    [Column("ysl_kesinti_aciklamasi1")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi1 { get; set; }

    [Column("ysl_kesinti_aciklamasi2")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi2 { get; set; }

    [Column("ysl_kesinti_aciklamasi3")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi3 { get; set; }

    [Column("ysl_kesinti_aciklamasi4")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi4 { get; set; }

    [Column("ysl_kesinti_aciklamasi5")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi5 { get; set; }

    [Column("ysl_kesinti_aciklamasi6")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi6 { get; set; }

    [Column("ysl_kesinti_aciklamasi7")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi7 { get; set; }

    [Column("ysl_kesinti_aciklamasi8")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi8 { get; set; }

    [Column("ysl_kesinti_aciklamasi9")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi9 { get; set; }

    [Column("ysl_kesinti_aciklamasi10")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi10 { get; set; }

    [Column("ysl_kesinti_aciklamasi11")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi11 { get; set; }

    [Column("ysl_kesinti_aciklamasi12")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi12 { get; set; }

    [Column("ysl_kesinti_aciklamasi13")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi13 { get; set; }

    [Column("ysl_kesinti_aciklamasi14")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi14 { get; set; }

    [Column("ysl_kesinti_aciklamasi15")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi15 { get; set; }

    [Column("ysl_kesinti_aciklamasi16")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi16 { get; set; }

    [Column("ysl_kesinti_aciklamasi17")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi17 { get; set; }

    [Column("ysl_kesinti_aciklamasi18")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi18 { get; set; }

    [Column("ysl_kesinti_aciklamasi19")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi19 { get; set; }

    [Column("ysl_kesinti_aciklamasi20")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi20 { get; set; }

    [Column("ysl_kesinti_aciklamasi21")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi21 { get; set; }

    [Column("ysl_kesinti_aciklamasi22")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi22 { get; set; }

    [Column("ysl_kesinti_aciklamasi23")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi23 { get; set; }

    [Column("ysl_kesinti_aciklamasi24")]
    [StringLength(20)]
    public string? YslKesintiAciklamasi24 { get; set; }

    [Column("ysl_sosyal_yar_netten_hesapla")]
    public bool? YslSosyalYarNettenHesapla { get; set; }

    [Column("ysl_vakif_aidat_tavani")]
    public double? YslVakifAidatTavani { get; set; }

    [Column("ysl_vakif_tavan_ustu_aidat")]
    public double? YslVakifTavanUstuAidat { get; set; }

    [Column("ysl_vakif_aidat_orani")]
    public double? YslVakifAidatOrani { get; set; }

    [Column("ysl_tah_ucret_hesabi_30_gunden")]
    public byte? YslTahUcretHesabi30Gunden { get; set; }

    [Column("ysl_ogrencide_dv_hesapla")]
    public bool? YslOgrencideDvHesapla { get; set; }

    [Column("ysl_hastada_tutar_hesapla")]
    public bool? YslHastadaTutarHesapla { get; set; }

    [Column("ysl_issizlik_sigortasi_var")]
    public bool? YslIssizlikSigortasiVar { get; set; }

    [Column("ysl_issizlik_sigortasi_per_payi")]
    public double? YslIssizlikSigortasiPerPayi { get; set; }

    [Column("ysl_issizlik_sigortasi_isv_payi")]
    public double? YslIssizlikSigortasiIsvPayi { get; set; }

    [Column("ysl_isz_pers_pay_vergi_matr_dus")]
    public bool? YslIszPersPayVergiMatrDus { get; set; }

    [Column("ysl_maz_izin_kaz_sskya_dahil")]
    public bool? YslMazIzinKazSskyaDahil { get; set; }

    [Column("ysl_hasta_izn_kazanc_ssk_dahil")]
    public bool? YslHastaIznKazancSskDahil { get; set; }

    [Column("ysl_net_ucret_yuvarlama_sekli")]
    public byte? YslNetUcretYuvarlamaSekli { get; set; }

    [Column("ysl_net_yuvarlama_limiti")]
    public double? YslNetYuvarlamaLimiti { get; set; }

    [Column("ysl_oncekiay_kusurati_ilave")]
    public bool? YslOncekiayKusuratiIlave { get; set; }

    [Column("ysl_tahakkuk_yuvarlama_tipi")]
    public byte? YslTahakkukYuvarlamaTipi { get; set; }

    [Column("ysl_banka_bil_sskdan_okunsun")]
    public bool? YslBankaBilSskdanOkunsun { get; set; }

    [Column("ysl_izin_mat_taban_tavandan")]
    public bool? YslIzinMatTabanTavandan { get; set; }

    [Column("ysl_tahakkukta_netmaas_goster")]
    public bool? YslTahakkuktaNetmaasGoster { get; set; }

    [Column("ysl_kazanci_ekkazanca_dagit")]
    public bool? YslKazanciEkkazancaDagit { get; set; }

    [Column("ysl_ssk_gun_kabulu")]
    public byte? YslSskGunKabulu { get; set; }

    [Column("ysl_subat_pergorev_kod_ssk_gun")]
    public bool? YslSubatPergorevKodSskGun { get; set; }

    [Column("ysl_gecmis_yil_izin_hesapla")]
    public bool? YslGecmisYilIzinHesapla { get; set; }

    [Column("ysl_kesin_olmayan_puantaj_uyar")]
    public bool? YslKesinOlmayanPuantajUyar { get; set; }

    [Column("ysl_ekkazanc_limit_faz_sos_yaz")]
    public bool? YslEkkazancLimitFazSosYaz { get; set; }

    [Column("ysl_puantaj_eksik_cal_neden_sor")]
    public bool? YslPuantajEksikCalNedenSor { get; set; }

    [Column("ysl_ssk_matrah_yuvarlama_limiti")]
    public double? YslSskMatrahYuvarlamaLimiti { get; set; }

    [Column("ysl_ssk_matrah_yuvarlama_sekli")]
    public byte? YslSskMatrahYuvarlamaSekli { get; set; }

    [Column("ysl_serzarf_dokum_adres_tipi")]
    public byte? YslSerzarfDokumAdresTipi { get; set; }

    [Column("ysl_tahakkuk_uyari_listele")]
    public bool? YslTahakkukUyariListele { get; set; }

    [Column("ysl_ozel_Ind_nete_eklensin")]
    public byte? YslOzelIndNeteEklensin { get; set; }

    [Column("ysl_dvergi_ind_nete_eklensin")]
    public byte? YslDvergiIndNeteEklensin { get; set; }

    [Column("ysl_sakat_ind_nete_eklensin")]
    public byte? YslSakatIndNeteEklensin { get; set; }

    [Column("ysl_gocmen_ind_nete_eklensin")]
    public byte? YslGocmenIndNeteEklensin { get; set; }

    [Column("ysl_digsigisv_ind_nete_eklensin")]
    public byte? YslDigsigisvIndNeteEklensin { get; set; }

    [Column("ysl_digsigcls_ind_nete_eklensin")]
    public byte? YslDigsigclsIndNeteEklensin { get; set; }

    [Column("ysl_birsigisv_ind_nete_eklensin")]
    public byte? YslBirsigisvIndNeteEklensin { get; set; }

    [Column("ysl_birsigcls_ind_nete_eklensin")]
    public byte? YslBirsigclsIndNeteEklensin { get; set; }

    [Column("ysl_askerlik_ind_nete_eklensin")]
    public byte? YslAskerlikIndNeteEklensin { get; set; }

    [Column("ysl_hakedis_once_yil_izin")]
    public bool? YslHakedisOnceYilIzin { get; set; }

    [Column("ysl_hakedis_kideme_gore_hesapla")]
    public byte? YslHakedisKidemeGoreHesapla { get; set; }

    [Column("ysl_avans_yuvarlama_limiti")]
    public double? YslAvansYuvarlamaLimiti { get; set; }

    [Column("ysl_avans_yuvarlama_sekli")]
    public byte? YslAvansYuvarlamaSekli { get; set; }

    [Column("ysl_ikramiye_yuvarlama_sekli")]
    public byte? YslIkramiyeYuvarlamaSekli { get; set; }

    [Column("ysl_ikramiye_yuvarlama_limiti")]
    public double? YslIkramiyeYuvarlamaLimiti { get; set; }

    [Column("ysl_normal_asgari_ucret")]
    public double? YslNormalAsgariUcret { get; set; }

    [Column("ysl_kucuk16_asgari_ucre")]
    public double? YslKucuk16AsgariUcre { get; set; }

    [Column("ysl_yillik_asgari_ucret")]
    public double? YslYillikAsgariUcret { get; set; }

    [Column("ysl_kidem_tazminat_tavani")]
    public double? YslKidemTazminatTavani { get; set; }

    [Column("ysl_ihbar_baslangic_ayi1")]
    public short? YslIhbarBaslangicAyi1 { get; set; }

    [Column("ysl_ihbar_bitis_ayi1")]
    public short? YslIhbarBitisAyi1 { get; set; }

    [Column("ysl_ihbar_gun1")]
    public short? YslIhbarGun1 { get; set; }

    [Column("ysl_ihbar_baslangic_ayi2")]
    public short? YslIhbarBaslangicAyi2 { get; set; }

    [Column("ysl_ihbar_bitis_ayi2")]
    public short? YslIhbarBitisAyi2 { get; set; }

    [Column("ysl_ihbar_gun2")]
    public short? YslIhbarGun2 { get; set; }

    [Column("ysl_ihbar_baslangic_ayi3")]
    public short? YslIhbarBaslangicAyi3 { get; set; }

    [Column("ysl_ihbar_bitis_ayi3")]
    public short? YslIhbarBitisAyi3 { get; set; }

    [Column("ysl_ihbar_gun4")]
    public short? YslIhbarGun4 { get; set; }

    [Column("ysl_ihbar_baslangic_ayi4")]
    public short? YslIhbarBaslangicAyi4 { get; set; }

    [Column("ysl_ihbar_bitis_ayi4")]
    public short? YslIhbarBitisAyi4 { get; set; }

    [Column("ysl_ihbar_baslangic_ayi5")]
    public short? YslIhbarBaslangicAyi5 { get; set; }

    [Column("ysl_ihbar_bitis_ayi5")]
    public short? YslIhbarBitisAyi5 { get; set; }

    [Column("ysl_ihbar_gun5")]
    public short? YslIhbarGun5 { get; set; }

    [Column("ysl_diger_sigorta_yuzdesi")]
    public double? YslDigerSigortaYuzdesi { get; set; }

    [Column("ysl_bireysel_sigorta_yuzdesi")]
    public double? YslBireyselSigortaYuzdesi { get; set; }

    [Column("ysl_vizite_ekkaz_sosyar_yaz")]
    public bool? YslViziteEkkazSosyarYaz { get; set; }

    [Column("ysl_tab_tav_hes_kaz_hesapla")]
    public bool? YslTabTavHesKazHesapla { get; set; }

    [Column("ysl_tab_tav_hes_tah_no")]
    public byte? YslTabTavHesTahNo { get; set; }

    [Column("ysl_ihbar_kidem_tum_sos_hesapla")]
    public bool? YslIhbarKidemTumSosHesapla { get; set; }

    [Column("ysl_aylik_ayni_odeme")]
    public double? YslAylikAyniOdeme { get; set; }

    [Column("ysl_kont_sakatlik1")]
    public short? YslKontSakatlik1 { get; set; }

    [Column("ysl_kont_eskihuk1")]
    public short? YslKontEskihuk1 { get; set; }

    [Column("ysl_kont_terormuc1")]
    public short? YslKontTerormuc1 { get; set; }

    [Column("ysl_kont_sakatlik2")]
    public short? YslKontSakatlik2 { get; set; }

    [Column("ysl_kont_eskihuk2")]
    public short? YslKontEskihuk2 { get; set; }

    [Column("ysl_kont_terormuc2")]
    public short? YslKontTerormuc2 { get; set; }

    [Column("ysl_ozel_indirim_normal")]
    public double? YslOzelIndirimNormal { get; set; }

    [Column("ysl_gocmen_indirimi")]
    public double? YslGocmenIndirimi { get; set; }

    [Column("ysl_sakatlik1_indirimi")]
    public double? YslSakatlik1Indirimi { get; set; }

    [Column("ysl_sakatlik2_indirimi")]
    public double? YslSakatlik2Indirimi { get; set; }

    [Column("ysl_sakatlik3_indirimi")]
    public double? YslSakatlik3Indirimi { get; set; }

    [Column("ysl_ind_uyg_aylik_gunluk")]
    [StringLength(1)]
    public string? YslIndUygAylikGunluk { get; set; }

    [Column("ysl_aylik_fazla_mesai_limiti")]
    public double? YslAylikFazlaMesaiLimiti { get; set; }

    [Column("ysl_kucuk16_matrah_tabani")]
    public double? YslKucuk16MatrahTabani { get; set; }

    [Column("ysl_kucuk16_matrah_tavani")]
    public double? YslKucuk16MatrahTavani { get; set; }

    [Column("ysl_normal_matrah_tabani")]
    public double? YslNormalMatrahTabani { get; set; }

    [Column("ysl_normal_matrah_tavani")]
    public double? YslNormalMatrahTavani { get; set; }

    [Column("ysl_damga_vergisi_orani")]
    public double? YslDamgaVergisiOrani { get; set; }

    [Column("ysl_ver_iad_dv_orani")]
    public double? YslVerIadDvOrani { get; set; }

    [Column("ysl_ozel_indirim_kalk_onc")]
    public double? YslOzelIndirimKalkOnc { get; set; }

    [Column("ysl_asgariucret_fark_hazine_ode")]
    public bool? YslAsgariucretFarkHazineOde { get; set; }

    [Column("ysl_yilik_fazla_mesai_limiti")]
    public double? YslYilikFazlaMesaiLimiti { get; set; }

    [Column("ysl_tahno_kazanc1")]
    public byte? YslTahnoKazanc1 { get; set; }

    [Column("ysl_tahno_kazanc2")]
    public byte? YslTahnoKazanc2 { get; set; }

    [Column("ysl_tahno_ekkazanc1")]
    public byte? YslTahnoEkkazanc1 { get; set; }

    [Column("ysl_tahno_ekkazanc2")]
    public byte? YslTahnoEkkazanc2 { get; set; }

    [Column("ysl_tahno_sosyard2")]
    public byte? YslTahnoSosyard2 { get; set; }

    [Column("ysl_tahno_ozelkes1")]
    public byte? YslTahnoOzelkes1 { get; set; }

    [Column("ysl_tahno_ozelkes2")]
    public byte? YslTahnoOzelkes2 { get; set; }

    [Column("ysl_tah_kur_tarihi_nereden")]
    public byte? YslTahKurTarihiNereden { get; set; }

    [Column("ysl_gelirver_gustsinir1")]
    public double? YslGelirverGustsinir1 { get; set; }

    [Column("ysl_gelirver_gveror1")]
    public double? YslGelirverGveror1 { get; set; }

    [Column("ysl_gelirver_gelirver1")]
    public double? YslGelirverGelirver1 { get; set; }

    [Column("ysl_gelirver_kademesiz1")]
    public bool? YslGelirverKademesiz1 { get; set; }

    [Column("ysl_gelirver_gustsinir2")]
    public double? YslGelirverGustsinir2 { get; set; }

    [Column("ysl_gelirver_gveror2")]
    public double? YslGelirverGveror2 { get; set; }

    [Column("ysl_gelirver_gelirver2")]
    public double? YslGelirverGelirver2 { get; set; }

    [Column("ysl_gelirver_kademesiz2")]
    public bool? YslGelirverKademesiz2 { get; set; }

    [Column("ysl_gelirver_gustsinir3")]
    public double? YslGelirverGustsinir3 { get; set; }

    [Column("ysl_gelirver_gveror3")]
    public double? YslGelirverGveror3 { get; set; }

    [Column("ysl_gelirver_gelirver3")]
    public double? YslGelirverGelirver3 { get; set; }

    [Column("ysl_gelirver_kademesiz3")]
    public bool? YslGelirverKademesiz3 { get; set; }

    [Column("ysl_gelirver_gustsinir4")]
    public double? YslGelirverGustsinir4 { get; set; }

    [Column("ysl_gelirver_gveror4")]
    public double? YslGelirverGveror4 { get; set; }

    [Column("ysl_gelirver_gelirver4")]
    public double? YslGelirverGelirver4 { get; set; }

    [Column("ysl_gelirver_kademesiz4")]
    public bool? YslGelirverKademesiz4 { get; set; }

    [Column("ysl_gelirver_gustsinir5")]
    public double? YslGelirverGustsinir5 { get; set; }

    [Column("ysl_gelirver_gveror5")]
    public double? YslGelirverGveror5 { get; set; }

    [Column("ysl_gelirver_gelirver5")]
    public double? YslGelirverGelirver5 { get; set; }

    [Column("ysl_gelirver_kademesiz5")]
    public bool? YslGelirverKademesiz5 { get; set; }

    [Column("ysl_gelirver_gustsinir6")]
    public double? YslGelirverGustsinir6 { get; set; }

    [Column("ysl_gelirver_gveror6")]
    public double? YslGelirverGveror6 { get; set; }

    [Column("ysl_gelirver_gelirver6")]
    public double? YslGelirverGelirver6 { get; set; }

    [Column("ysl_gelirver_kademesiz6")]
    public bool? YslGelirverKademesiz6 { get; set; }

    [Column("ysl_gelirver_gustsinir7")]
    public double? YslGelirverGustsinir7 { get; set; }

    [Column("ysl_gelirver_gveror7")]
    public double? YslGelirverGveror7 { get; set; }

    [Column("ysl_gelirver_gelirver7")]
    public double? YslGelirverGelirver7 { get; set; }

    [Column("ysl_gelirver_kademesiz7")]
    public bool? YslGelirverKademesiz7 { get; set; }

    [Column("ysl_gelirver_gustsinir8")]
    public double? YslGelirverGustsinir8 { get; set; }

    [Column("ysl_gelirver_gveror8")]
    public double? YslGelirverGveror8 { get; set; }

    [Column("ysl_gelirver_gelirver8")]
    public double? YslGelirverGelirver8 { get; set; }

    [Column("ysl_gelirver_kademesiz8")]
    public bool? YslGelirverKademesiz8 { get; set; }

    [Column("ysl_vergi_iade_tutar1")]
    public double? YslVergiIadeTutar1 { get; set; }

    [Column("ysl_vergi_iade_yuzde1")]
    public double? YslVergiIadeYuzde1 { get; set; }

    [Column("ysl_vergi_iade_tutar2")]
    public double? YslVergiIadeTutar2 { get; set; }

    [Column("ysl_vergi_iade_yuzde2")]
    public double? YslVergiIadeYuzde2 { get; set; }

    [Column("ysl_vergi_iade_tutar3")]
    public double? YslVergiIadeTutar3 { get; set; }

    [Column("ysl_vergi_iade_yuzde3")]
    public double? YslVergiIadeYuzde3 { get; set; }

    [Column("ysl_digersigisv_sosyar_index")]
    public byte? YslDigersigisvSosyarIndex { get; set; }

    [Column("ysl_digersigisv_kesinti_index")]
    public byte? YslDigersigisvKesintiIndex { get; set; }

    [Column("ysl_bireysigisv_sosyar_index")]
    public byte? YslBireysigisvSosyarIndex { get; set; }

    [Column("ysl_bireysigisv_kesinti_index")]
    public byte? YslBireysigisvKesintiIndex { get; set; }

    [Column("ysl_izinmatrahi_toplamsskdan_fl")]
    public bool? YslIzinmatrahiToplamsskdanFl { get; set; }

    [Column("ysl_eksikgun_aykacgun_tahgun_fl1")]
    public bool? YslEksikgunAykacgunTahgunFl1 { get; set; }

    [Column("ysl_eksikgun_aykacgun_tahgun_fl2")]
    public bool? YslEksikgunAykacgunTahgunFl2 { get; set; }

    [Column("ysl_eksikgun_aykacgun_tahgun_fl3")]
    public bool? YslEksikgunAykacgunTahgunFl3 { get; set; }

    [Column("ysl_sakat_ind_ay_top_deger_fl1")]
    public bool? YslSakatIndAyTopDegerFl1 { get; set; }

    [Column("ysl_sakat_ind_ay_top_deger_fl2")]
    public bool? YslSakatIndAyTopDegerFl2 { get; set; }

    [Column("ysl_sakat_ind_ay_top_deger_fl3")]
    public bool? YslSakatIndAyTopDegerFl3 { get; set; }

    [Column("ysl_sinyority_sosyalyardim_index")]
    public byte? YslSinyoritySosyalyardimIndex { get; set; }

    [Column("ysl_izinparasi_sosyalyardim_index")]
    public byte? YslIzinparasiSosyalyardimIndex { get; set; }

    [Column("ysl_personel_sicilno_kodyapisi")]
    [StringLength(25)]
    public string? YslPersonelSicilnoKodyapisi { get; set; }

    [Column("ysl_cari_pers_veri_aktar_fl0")]
    public byte? YslCariPersVeriAktarFl0 { get; set; }

    [Column("ysl_cari_pers_veri_aktar_fl1")]
    public byte? YslCariPersVeriAktarFl1 { get; set; }

    [Column("ysl_cari_pers_veri_aktar_fl2")]
    public byte? YslCariPersVeriAktarFl2 { get; set; }

    [Column("ysl_cari_pers_veri_aktar_fl3")]
    public byte? YslCariPersVeriAktarFl3 { get; set; }

    [Column("ysl_cari_pers_veri_aktar_fl4")]
    public byte? YslCariPersVeriAktarFl4 { get; set; }

    [Column("ysl_odeme_haric_vizite_yaziile_fl")]
    public bool? YslOdemeHaricViziteYaziileFl { get; set; }

    [Column("ysl_izin_talep_bilgilendirme")]
    public byte? YslIzinTalepBilgilendirme { get; set; }

    [Column("ysl_avans_talep_bilgilendirme")]
    public byte? YslAvansTalepBilgilendirme { get; set; }

    [Column("ysl_digerindnetekle_sosyar_gec_fl")]
    public bool? YslDigerindnetekleSosyarGecFl { get; set; }

    [Column("ysl_sigorindnetekle_sosyar_gec_fl")]
    public bool? YslSigorindnetekleSosyarGecFl { get; set; }

    [Column("ysl_tum_gecmis_yil_izin_hesapla")]
    public bool? YslTumGecmisYilIzinHesapla { get; set; }

    [Column("ysl_digs_sy_sinirustuvergilendir")]
    public bool? YslDigsSySinirustuvergilendir { get; set; }

    [Column("ysl_birs_sy_sinirustuvergilendir")]
    public bool? YslBirsSySinirustuvergilendir { get; set; }

    [Column("ysl_digs_sosyar_kazancdisi_fl")]
    public bool? YslDigsSosyarKazancdisiFl { get; set; }

    [Column("ysl_birs_sosyar_kazancdisi_fl")]
    public bool? YslBirsSosyarKazancdisiFl { get; set; }

    [Column("ysl_asgarigecimindirimi_aktif_fl")]
    public bool? YslAsgarigecimindirimiAktifFl { get; set; }

    [Column("ysl_asggecimindorani_calisan")]
    public double? YslAsggecimindoraniCalisan { get; set; }

    [Column("ysl_asggecimindorani_es")]
    public double? YslAsggecimindoraniEs { get; set; }

    [Column("ysl_asggecimindorani_2cocuk")]
    public double? YslAsggecimindorani2cocuk { get; set; }

    [Column("ysl_asggecimindorani_3cocuk")]
    public double? YslAsggecimindorani3cocuk { get; set; }

    [Column("ysl_asggecimindorani_digercocuklar")]
    public double? YslAsggecimindoraniDigercocuklar { get; set; }

    [Column("ysl_asggecimind_asgariucret")]
    public double? YslAsggecimindAsgariucret { get; set; }

    [Column("ysl_asggecimind_nete_eklensin")]
    public byte? YslAsggecimindNeteEklensin { get; set; }

    [Column("ysl_tahakkukta_SSK_sorulsun_fl")]
    public bool? YslTahakkuktaSSKSorulsunFl { get; set; }

    [Column("ysl_asggecimind_aylikmaxtutar")]
    public double? YslAsggecimindAylikmaxtutar { get; set; }

    [Column("ysl_personeldokum_formtipi")]
    public byte? YslPersoneldokumFormtipi { get; set; }

    [Column("ysl_kapicida_dv_hesapla")]
    public bool? YslKapicidaDvHesapla { get; set; }

    [Column("ysl_arge_5746_doktora_gv_muafiyet")]
    public double? YslArge5746DoktoraGvMuafiyet { get; set; }

    [Column("ysl_arge_5746_diger_gv_muafiyet")]
    public double? YslArge5746DigerGvMuafiyet { get; set; }

    [Column("ysl_arge_5746_isvhis_muafiyet")]
    public double? YslArge5746IsvhisMuafiyet { get; set; }

    [Column("ysl_arge_5746_GVind_nete_eklensin")]
    public bool? YslArge5746GVindNeteEklensin { get; set; }

    [Column("ysl_arge_5746_DV_hesaplanmasin")]
    public bool? YslArge5746DVHesaplanmasin { get; set; }

    [Column("ysl_ist_5763_kdoz_isvhis_muafiyet")]
    public double? YslIst5763KdozIsvhisMuafiyet { get; set; }

    [Column("ysl_ist_5763_kfoz_isvhis_muafiyet")]
    public double? YslIst5763KfozIsvhisMuafiyet { get; set; }

    [Column("ysl_ist_5763_yasli_olum_muafiyet")]
    public double? YslIst5763YasliOlumMuafiyet { get; set; }

    [Column("ysl_ucr_izin_kv_sig_kolu_kesilsin")]
    public double? YslUcrIzinKvSigKoluKesilsin { get; set; }

    [Column("ysl_calisma_yoksa_sgk_matrahi")]
    public byte? YslCalismaYoksaSgkMatrahi { get; set; }

    [Column("ysl_cocuk_yard_muafiyeti_0_6")]
    public double? YslCocukYardMuafiyeti06 { get; set; }

    [Column("ysl_gunluk_yemek_gv_muafiyeti")]
    public double? YslGunlukYemekGvMuafiyeti { get; set; }

    [Column("ysl_kultur_5225_yat_gv_muafiyet")]
    public double? YslKultur5225YatGvMuafiyet { get; set; }

    [Column("ysl_kultur_5225_isl_gv_muafiyet")]
    public double? YslKultur5225IslGvMuafiyet { get; set; }

    [Column("ysl_kultur_5225_GVind_nete_eklensin")]
    public bool? YslKultur5225GVindNeteEklensin { get; set; }

    [Column("ysl_gecmis_yil_izin_eksi_devir")]
    public bool? YslGecmisYilIzinEksiDevir { get; set; }

    [Column("ysl_hazine_kanunu_uygulama_5084")]
    public byte? YslHazineKanunuUygulama5084 { get; set; }

    [Column("ysl_hazine_kanunu_uygulama_5350")]
    public byte? YslHazineKanunuUygulama5350 { get; set; }

    [Column("ysl_hazine_kanunu_uygulama_5615")]
    public byte? YslHazineKanunuUygulama5615 { get; set; }

    [Column("ysl_digsigisv_ind_isverene_yansit")]
    public byte? YslDigsigisvIndIsvereneYansit { get; set; }

    [Column("ysl_birsigisv_ind_isverene_yansit")]
    public byte? YslBirsigisvIndIsvereneYansit { get; set; }

    [Column("ysl_5746_tesvik_disi_sgk_hesabi")]
    public byte? Ysl5746TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_5763_tesvik_disi_sgk_hesabi")]
    public byte? Ysl5763TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_5921_tesvik_disi_sgk_hesabi")]
    public byte? Ysl5921TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_gelirver_muafiyet1")]
    public double? YslGelirverMuafiyet1 { get; set; }

    [Column("ysl_gelirver_muafiyet2")]
    public double? YslGelirverMuafiyet2 { get; set; }

    [Column("ysl_gelirver_muafiyet3")]
    public double? YslGelirverMuafiyet3 { get; set; }

    [Column("ysl_gelirver_muafiyet4")]
    public double? YslGelirverMuafiyet4 { get; set; }

    [Column("ysl_gelirver_muafiyet5")]
    public double? YslGelirverMuafiyet5 { get; set; }

    [Column("ysl_gelirver_muafiyet6")]
    public double? YslGelirverMuafiyet6 { get; set; }

    [Column("ysl_gelirver_muafiyet7")]
    public double? YslGelirverMuafiyet7 { get; set; }

    [Column("ysl_gelirver_muafiyet8")]
    public double? YslGelirverMuafiyet8 { get; set; }

    [Column("ysl_verindnetihesaplamatipi")]
    public byte? YslVerindnetihesaplamatipi { get; set; }

    [Column("ysl_6111_tesvik_disi_sgk_hesabi")]
    public byte? Ysl6111TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_5763_tesvike_ilave_indirim")]
    public byte? Ysl5763TesvikeIlaveIndirim { get; set; }

    [Column("ysl_yarim_isgunu_calisma_saati")]
    public double? YslYarimIsgunuCalismaSaati { get; set; }

    [Column("ysl_sosyal_yardim_hesabi")]
    public byte? YslSosyalYardimHesabi { get; set; }

    [Column("ysl_ekkazanc_ucret_hesabi")]
    public byte? YslEkkazancUcretHesabi { get; set; }

    [Column("ysl_6322_kanun_uygulama")]
    public byte? Ysl6322KanunUygulama { get; set; }

    [Column("ysl_gv_muafiyeti_nete_eklensin")]
    public byte? YslGvMuafiyetiNeteEklensin { get; set; }

    [Column("ysl_dv_muafiyeti_nete_eklensin")]
    public byte? YslDvMuafiyetiNeteEklensin { get; set; }

    [Column("ysl_6322_tesvik_disi_sgk_hesabi")]
    public byte? Ysl6322TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_55225_isvhis_muafiyet")]
    public double? Ysl55225IsvhisMuafiyet { get; set; }

    [Column("ysl_25225_isvhis_muafiyet")]
    public double? Ysl25225IsvhisMuafiyet { get; set; }

    [Column("ysl_55225_tesvik_disi_sgk_hesabi")]
    public byte? Ysl55225TesvikDisiSgkHesabi { get; set; }

    [Column("ysl_izin1_kazanc_ssk_dahil")]
    public bool? YslIzin1KazancSskDahil { get; set; }

    [Column("ysl_izin2_kazanc_ssk_dahil")]
    public bool? YslIzin2KazancSskDahil { get; set; }

    [Column("ysl_izin3_kazanc_ssk_dahil")]
    public bool? YslIzin3KazancSskDahil { get; set; }

    [Column("ysl_izin4_kazanc_ssk_dahil")]
    public bool? YslIzin4KazancSskDahil { get; set; }

    [Column("ysl_izin5_kazanc_ssk_dahil")]
    public bool? YslIzin5KazancSskDahil { get; set; }

    [Column("ysl_izin6_kazanc_ssk_dahil")]
    public bool? YslIzin6KazancSskDahil { get; set; }

    [Column("ysl_izin7_kazanc_ssk_dahil")]
    public bool? YslIzin7KazancSskDahil { get; set; }

    [Column("ysl_izin8_kazanc_ssk_dahil")]
    public bool? YslIzin8KazancSskDahil { get; set; }

    [Column("ysl_izin9_kazanc_ssk_dahil")]
    public bool? YslIzin9KazancSskDahil { get; set; }

    [Column("ysl_izin10_kazanc_ssk_dahil")]
    public bool? YslIzin10KazancSskDahil { get; set; }

    [Column("ysl_izin11_kazanc_ssk_dahil")]
    public bool? YslIzin11KazancSskDahil { get; set; }

    [Column("ysl_izin12_kazanc_ssk_dahil")]
    public bool? YslIzin12KazancSskDahil { get; set; }

    [Column("ysl_izin13_kazanc_ssk_dahil")]
    public bool? YslIzin13KazancSskDahil { get; set; }

    [Column("ysl_izin14_kazanc_ssk_dahil")]
    public bool? YslIzin14KazancSskDahil { get; set; }

    [Column("ysl_izin15_kazanc_ssk_dahil")]
    public bool? YslIzin15KazancSskDahil { get; set; }

    [Column("ysl_izin16_kazanc_ssk_dahil")]
    public bool? YslIzin16KazancSskDahil { get; set; }

    [Column("ysl_haysigisv_ind_nete_eklensin")]
    public byte? YslHaysigisvIndNeteEklensin { get; set; }

    [Column("ysl_haysigcls_ind_nete_eklensin")]
    public byte? YslHaysigclsIndNeteEklensin { get; set; }

    [Column("ysl_hayat_sigorta_yuzdesi")]
    public double? YslHayatSigortaYuzdesi { get; set; }

    [Column("ysl_hayatsigisv_sosyar_index")]
    public byte? YslHayatsigisvSosyarIndex { get; set; }

    [Column("ysl_hayatsigisv_kesinti_index")]
    public byte? YslHayatsigisvKesintiIndex { get; set; }

    [Column("ysl_hays_sy_sinirustuvergilendir")]
    public bool? YslHaysSySinirustuvergilendir { get; set; }

    [Column("ysl_hays_sosyar_kazancdisi_fl")]
    public bool? YslHaysSosyarKazancdisiFl { get; set; }

    [Column("ysl_haysigisv_ind_isverene_yansit")]
    public byte? YslHaysigisvIndIsvereneYansit { get; set; }

    [Column("ysl_kidemtazminati_sosyar_index")]
    public byte? YslKidemtazminatiSosyarIndex { get; set; }

    [Column("ysl_ihbartazminati_sosyar_index")]
    public byte? YslIhbartazminatiSosyarIndex { get; set; }

    [Column("ysl_huzurhakki_sosyar_index")]
    public byte? YslHuzurhakkiSosyarIndex { get; set; }

    [Column("ysl_isv_sig_sgk_ind_tutari")]
    public double? YslIsvSigSgkIndTutari { get; set; }

    [Column("ysl_kanun_gv_ind_isverene_yansit")]
    public byte? YslKanunGvIndIsvereneYansit { get; set; }

    [Column("ysl_6486_isvhis_muafiyet")]
    public double? Ysl6486IsvhisMuafiyet { get; set; }

    [Column("ysl_06486_isvhis_muafiyet")]
    public double? Ysl06486IsvhisMuafiyet { get; set; }

    [Column("ysl_donserm_ekodeme_sosyar_index")]
    public byte? YslDonsermEkodemeSosyarIndex { get; set; }

    [Column("ysl_hazine_gunluk_ust_brut")]
    public double? YslHazineGunlukUstBrut { get; set; }

    [Column("ysl_hazine_gunluk_destek")]
    public double? YslHazineGunlukDestek { get; set; }

    [Column("ysl_hazine_kanunu_uygulama_6645")]
    public byte? YslHazineKanunuUygulama6645 { get; set; }

    [Column("ysl_ogrenci_muhtasar_kodu")]
    public short? YslOgrenciMuhtasarKodu { get; set; }

    [Column("ysl_icrakesinti_Index")]
    public byte? YslIcrakesintiIndex { get; set; }

    [Column("ysl_max_icraorani")]
    public double? YslMaxIcraorani { get; set; }

    [Column("ysl_max_kamuicraorani")]
    public double? YslMaxKamuicraorani { get; set; }

    [Column("ysl_arge_5746_ylisans_gv_muafiyet")]
    public double? YslArge5746YlisansGvMuafiyet { get; set; }

    [Column("ysl_cocukadeti_hesaplama_sekli")]
    public byte? YslCocukadetiHesaplamaSekli { get; set; }

    [Column("ysl_ilave_agi_konusu_min_net_ucret")]
    public double? YslIlaveAgiKonusuMinNetUcret { get; set; }

    [Column("ysl_ilave_agi_konusu_max_brut_ucret")]
    public double? YslIlaveAgiKonusuMaxBrutUcret { get; set; }

    [Column("ysl_otobes_baslangic_tarihi")]
    public DateTime? YslOtobesBaslangicTarihi { get; set; }

    [Column("ysl_otobes_orani")]
    public double? YslOtobesOrani { get; set; }

    [Column("ysl_otobes_min_tutar")]
    public double? YslOtobesMinTutar { get; set; }

    [Column("ysl_otobes_max_tutar")]
    public double? YslOtobesMaxTutar { get; set; }

    [Column("ysl_yillik_izin_sgk_tesvik_kapsaminda")]
    public bool? YslYillikIzinSgkTesvikKapsaminda { get; set; }

    [Column("ysl_gecici_madde_17_gunluk_destek")]
    public double? YslGeciciMadde17GunlukDestek { get; set; }

    [Column("ysl_sendika_ind_nete_eklensin")]
    public byte? YslSendikaIndNeteEklensin { get; set; }

    [Column("ysl_sgk_muaf_cocuk_adedi")]
    public short? YslSgkMuafCocukAdedi { get; set; }

    [Column("ysl_5746_tesvikli_ekkazanc_id")]
    public byte? Ysl5746TesvikliEkkazancId { get; set; }

    [Column("ysl_sgk_per_ind_isverene_yansit")]
    public byte? YslSgkPerIndIsvereneYansit { get; set; }
}
