using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personeller")]
public class Personeller
{
    [Column("per_Guid")]
    public Guid? PerGuid { get; set; }

    [Column("per_DBCno")]
    public short? PerDBCno { get; set; }

    [Column("per_SpecRECno")]
    public int? PerSpecRECno { get; set; }

    [Column("per_iptal")]
    public bool? PerIptal { get; set; }

    [Column("per_fileid")]
    public short? PerFileid { get; set; }

    [Column("per_hidden")]
    public bool? PerHidden { get; set; }

    [Column("per_kilitli")]
    public bool? PerKilitli { get; set; }

    [Column("per_degisti")]
    public bool? PerDegisti { get; set; }

    [Column("per_checksum")]
    public int? PerChecksum { get; set; }

    [Column("per_create_user")]
    public short? PerCreateUser { get; set; }

    [Column("per_create_date")]
    public DateTime? PerCreateDate { get; set; }

    [Column("per_lastup_user")]
    public short? PerLastupUser { get; set; }

    [Column("per_lastup_date")]
    public DateTime? PerLastupDate { get; set; }

    [Column("per_special1")]
    [StringLength(4)]
    public string? PerSpecial1 { get; set; }

    [Column("per_special2")]
    [StringLength(4)]
    public string? PerSpecial2 { get; set; }

    [Column("per_special3")]
    [StringLength(4)]
    public string? PerSpecial3 { get; set; }

    [Column("per_kod")]
    [StringLength(25)]
    public string? PerKod { get; set; }

    [Column("per_adi")]
    [StringLength(50)]
    public string? PerAdi { get; set; }

    [Column("per_soyadi")]
    [StringLength(50)]
    public string? PerSoyadi { get; set; }

    [Column("per_orjdildeadisoyadi")]
    [StringLength(80)]
    public string? PerOrjdildeadisoyadi { get; set; }

    [Column("per_sicil_no")]
    [StringLength(25)]
    public string? PerSicilNo { get; set; }

    [Column("per_firma_no")]
    public int? PerFirmaNo { get; set; }

    [Column("per_sube_no")]
    public int? PerSubeNo { get; set; }

    [Column("per_caripers_kodu")]
    [StringLength(25)]
    public string? PerCaripersKodu { get; set; }

    [Column("per_tip")]
    public byte? PerTip { get; set; }

    [Column("per_dept_kod")]
    [StringLength(25)]
    public string? PerDeptKod { get; set; }

    [Column("per_is_grup")]
    public byte? PerIsGrup { get; set; }

    [Column("per_giris_tar")]
    public DateTime? PerGirisTar { get; set; }

    [Column("per_cikis_tar")]
    public DateTime? PerCikisTar { get; set; }

    [Column("per_cikis_neden")]
    [StringLength(40)]
    public string? PerCikisNeden { get; set; }

    [Column("per_muh_kod")]
    [StringLength(40)]
    public string? PerMuhKod { get; set; }

    [Column("per_kim_tahsil")]
    public byte? PerKimTahsil { get; set; }

    [Column("per_kim_meslek")]
    [StringLength(20)]
    public string? PerKimMeslek { get; set; }

    [Column("per_kim_gorev")]
    [StringLength(25)]
    public string? PerKimGorev { get; set; }

    [Column("per_kim_sakat_derece")]
    public byte? PerKimSakatDerece { get; set; }

    [Column("per_kim_gocmen")]
    public byte? PerKimGocmen { get; set; }

    [Column("per_kim_gorev_kod")]
    public byte? PerKimGorevKod { get; set; }

    [Column("per_kim_SGK_kod")]
    public byte? PerKimSGKKod { get; set; }

    [Column("per_kim_cocuk")]
    public byte? PerKimCocuk { get; set; }

    [Column("per_kim_okuloncesi")]
    public byte? PerKimOkuloncesi { get; set; }

    [Column("per_kim_ilkokul")]
    public byte? PerKimIlkokul { get; set; }

    [Column("per_kim_ortaokul")]
    public byte? PerKimOrtaokul { get; set; }

    [Column("per_kim_lise")]
    public byte? PerKimLise { get; set; }

    [Column("per_kim_yuksek")]
    public byte? PerKimYuksek { get; set; }

    [Column("per_nuf_uyruk")]
    [StringLength(15)]
    public string? PerNufUyruk { get; set; }

    [Column("per_nuf_cinsiyet")]
    public byte? PerNufCinsiyet { get; set; }

    [Column("per_nuf_medeni_hal")]
    public byte? PerNufMedeniHal { get; set; }

    [Column("per_nuf_din")]
    [StringLength(15)]
    public string? PerNufDin { get; set; }

    [Column("per_nuf_dogum_tarih")]
    public DateTime? PerNufDogumTarih { get; set; }

    [Column("per_nuf_dogum_yer")]
    [StringLength(40)]
    public string? PerNufDogumYer { get; set; }

    [Column("per_nuf_kangrup")]
    public byte? PerNufKangrup { get; set; }

    [Column("per_nuf_seri_no")]
    [StringLength(15)]
    public string? PerNufSeriNo { get; set; }

    [Column("per_nuf_il")]
    [StringLength(20)]
    public string? PerNufIl { get; set; }

    [Column("per_nuf_ilce")]
    [StringLength(20)]
    public string? PerNufIlce { get; set; }

    [Column("per_nuf_mahalle")]
    [StringLength(20)]
    public string? PerNufMahalle { get; set; }

    [Column("per_nuf_koy")]
    [StringLength(20)]
    public string? PerNufKoy { get; set; }

    [Column("per_nuf_ciltno")]
    [StringLength(10)]
    public string? PerNufCiltno { get; set; }

    [Column("per_nuf_sayfano")]
    [StringLength(10)]
    public string? PerNufSayfano { get; set; }

    [Column("per_nuf_kutukno")]
    [StringLength(10)]
    public string? PerNufKutukno { get; set; }

    [Column("per_nuf_ver_neden")]
    [StringLength(20)]
    public string? PerNufVerNeden { get; set; }

    [Column("per_nuf_ver_yer")]
    [StringLength(20)]
    public string? PerNufVerYer { get; set; }

    [Column("per_nuf_ver_tarih")]
    public DateTime? PerNufVerTarih { get; set; }

    [Column("per_nuf_cuz_kayitno")]
    [StringLength(15)]
    public string? PerNufCuzKayitno { get; set; }

    [Column("per_ucr_tip")]
    public byte? PerUcrTip { get; set; }

    [Column("per_ucret")]
    public double? PerUcret { get; set; }

    [Column("per_Brut_net")]
    public byte? PerBrutNet { get; set; }

    [Column("per_ucr_send_durum")]
    public byte? PerUcrSendDurum { get; set; }

    [Column("per_ucr_send")]
    public byte? PerUcrSend { get; set; }

    [Column("per_ucr_PSSK_sube")]
    public byte? PerUcrPSSKSube { get; set; }

    [Column("per_ucr_hesapno")]
    [StringLength(30)]
    public string? PerUcrHesapno { get; set; }

    [Column("per_ucr_sig_yuzde_gr")]
    public byte? PerUcrSigYuzdeGr { get; set; }

    [Column("per_ucr_bode_yapilma")]
    public byte? PerUcrBodeYapilma { get; set; }

    [Column("per_ucr_vdaire")]
    [StringLength(14)]
    public string? PerUcrVdaire { get; set; }

    [Column("per_ucr_vkarneno")]
    [StringLength(12)]
    public string? PerUcrVkarneno { get; set; }

    [Column("per_ucr_vkarne_tarih")]
    public DateTime? PerUcrVkarneTarih { get; set; }

    [Column("per_ucr_konutfon")]
    public byte? PerUcrKonutfon { get; set; }

    [Column("per_ucr_onceod")]
    public short? PerUcrOnceod { get; set; }

    [Column("per_ozelavansorani")]
    public double? PerOzelavansorani { get; set; }

    [Column("per_yard_yol")]
    public byte? PerYardYol { get; set; }

    [Column("per_yard_yemek")]
    public byte? PerYardYemek { get; set; }

    [Column("per_yard_yakacak")]
    public byte? PerYardYakacak { get; set; }

    [Column("per_yard_bayram")]
    public byte? PerYardBayram { get; set; }

    [Column("per_yard_cocuk")]
    public byte? PerYardCocuk { get; set; }

    [Column("per_yard_aile")]
    public byte? PerYardAile { get; set; }

    [Column("per_yard_ozelindirim")]
    public byte? PerYardOzelindirim { get; set; }

    [Column("per_adr_cadde")]
    [StringLength(50)]
    public string? PerAdrCadde { get; set; }

    [Column("per_adr_mahalle")]
    [StringLength(50)]
    public string? PerAdrMahalle { get; set; }

    [Column("per_adr_sokak")]
    [StringLength(50)]
    public string? PerAdrSokak { get; set; }

    [Column("per_adr_semt")]
    [StringLength(25)]
    public string? PerAdrSemt { get; set; }

    [Column("per_adr_apartman_no")]
    [StringLength(10)]
    public string? PerAdrApartmanNo { get; set; }

    [Column("per_adr_daire_no")]
    [StringLength(10)]
    public string? PerAdrDaireNo { get; set; }

    [Column("per_adr_posta_kod")]
    [StringLength(8)]
    public string? PerAdrPostaKod { get; set; }

    [Column("per_adr_ilce")]
    [StringLength(50)]
    public string? PerAdrIlce { get; set; }

    [Column("per_adr_il")]
    [StringLength(50)]
    public string? PerAdrIl { get; set; }

    [Column("per_adr_ulke")]
    [StringLength(50)]
    public string? PerAdrUlke { get; set; }

    [Column("per_adr_adres_kodu")]
    [StringLength(10)]
    public string? PerAdrAdresKodu { get; set; }

    [Column("per_tel_ulke_kod")]
    [StringLength(5)]
    public string? PerTelUlkeKod { get; set; }

    [Column("per_tel_bolge_kod")]
    [StringLength(5)]
    public string? PerTelBolgeKod { get; set; }

    [Column("per_tel_no1")]
    [StringLength(10)]
    public string? PerTelNo1 { get; set; }

    [Column("per_tel_no2")]
    [StringLength(10)]
    public string? PerTelNo2 { get; set; }

    [Column("per_tel_faxno")]
    [StringLength(10)]
    public string? PerTelFaxno { get; set; }

    [Column("per_tel_cepno")]
    [StringLength(10)]
    public string? PerTelCepno { get; set; }

    [Column("per_doviz_cinsi")]
    public byte? PerDovizCinsi { get; set; }

    [Column("per_muh_grpkod")]
    [StringLength(25)]
    public string? PerMuhGrpkod { get; set; }

    [Column("per_muh_ozelc1")]
    [StringLength(25)]
    public string? PerMuhOzelc1 { get; set; }

    [Column("per_muh_ozelc2")]
    [StringLength(25)]
    public string? PerMuhOzelc2 { get; set; }

    [Column("per_muh_ozelc3")]
    [StringLength(25)]
    public string? PerMuhOzelc3 { get; set; }

    [Column("per_muh_ozelc4")]
    [StringLength(25)]
    public string? PerMuhOzelc4 { get; set; }

    [Column("per_muh_ozelc5")]
    [StringLength(25)]
    public string? PerMuhOzelc5 { get; set; }

    [Column("per_muh_ozelc6")]
    [StringLength(25)]
    public string? PerMuhOzelc6 { get; set; }

    [Column("per_muh_ozelc7")]
    [StringLength(25)]
    public string? PerMuhOzelc7 { get; set; }

    [Column("per_muh_ozelc8")]
    [StringLength(25)]
    public string? PerMuhOzelc8 { get; set; }

    [Column("per_muh_ozelc9")]
    [StringLength(25)]
    public string? PerMuhOzelc9 { get; set; }

    [Column("per_muh_ozelc10")]
    [StringLength(25)]
    public string? PerMuhOzelc10 { get; set; }

    [Column("per_muh_ozelc11")]
    [StringLength(25)]
    public string? PerMuhOzelc11 { get; set; }

    [Column("per_muh_ozelc12")]
    [StringLength(25)]
    public string? PerMuhOzelc12 { get; set; }

    [Column("per_muh_ozelc13")]
    [StringLength(25)]
    public string? PerMuhOzelc13 { get; set; }

    [Column("per_muh_ozelc14")]
    [StringLength(25)]
    public string? PerMuhOzelc14 { get; set; }

    [Column("per_muh_ozelc15")]
    [StringLength(25)]
    public string? PerMuhOzelc15 { get; set; }

    [Column("per_muh_ozelc16")]
    [StringLength(25)]
    public string? PerMuhOzelc16 { get; set; }

    [Column("per_muh_ozelc17")]
    [StringLength(25)]
    public string? PerMuhOzelc17 { get; set; }

    [Column("per_muh_ozelc18")]
    [StringLength(25)]
    public string? PerMuhOzelc18 { get; set; }

    [Column("per_muh_ozelc19")]
    [StringLength(25)]
    public string? PerMuhOzelc19 { get; set; }

    [Column("per_muh_ozelc20")]
    [StringLength(25)]
    public string? PerMuhOzelc20 { get; set; }

    [Column("per_muh_ozelc21")]
    [StringLength(25)]
    public string? PerMuhOzelc21 { get; set; }

    [Column("per_muh_ozelc22")]
    [StringLength(25)]
    public string? PerMuhOzelc22 { get; set; }

    [Column("per_muh_ozelc23")]
    [StringLength(25)]
    public string? PerMuhOzelc23 { get; set; }

    [Column("per_muh_ozelc24")]
    [StringLength(25)]
    public string? PerMuhOzelc24 { get; set; }

    [Column("per_old_ucret")]
    public double? PerOldUcret { get; set; }

    [Column("per_old_tarih")]
    public DateTime? PerOldTarih { get; set; }

    [Column("per_maas_ikramiye")]
    public byte? PerMaasIkramiye { get; set; }

    [Column("per_ozel_not")]
    [StringLength(12)]
    public string? PerOzelNot { get; set; }

    [Column("per_VkfKesOd_fl")]
    public bool? PerVkfKesOdFl { get; set; }

    [Column("per_Kidem_Tarih")]
    public DateTime? PerKidemTarih { get; set; }

    [Column("per_iszlksig")]
    public byte? PerIszlksig { get; set; }

    [Column("per_Calismatipi")]
    public byte? PerCalismatipi { get; set; }

    [Column("per_dil1")]
    public bool? PerDil1 { get; set; }

    [Column("per_dil2")]
    public bool? PerDil2 { get; set; }

    [Column("per_dil3")]
    public bool? PerDil3 { get; set; }

    [Column("per_dil4")]
    public bool? PerDil4 { get; set; }

    [Column("per_dil5")]
    public bool? PerDil5 { get; set; }

    [Column("per_dil6")]
    public bool? PerDil6 { get; set; }

    [Column("per_dil7")]
    public bool? PerDil7 { get; set; }

    [Column("per_dil8")]
    public bool? PerDil8 { get; set; }

    [Column("per_dil9")]
    public bool? PerDil9 { get; set; }

    [Column("per_dil10")]
    public bool? PerDil10 { get; set; }

    [Column("per_dil11")]
    public bool? PerDil11 { get; set; }

    [Column("per_dil12")]
    public bool? PerDil12 { get; set; }

    [Column("per_mevsim")]
    public byte? PerMevsim { get; set; }

    [Column("per_kapsam")]
    public byte? PerKapsam { get; set; }

    [Column("per_asgari_ucretli")]
    public bool? PerAsgariUcretli { get; set; }

    [Column("Per_PerCariCins1")]
    public byte? PerPerCariCins1 { get; set; }

    [Column("Per_PerCariCins2")]
    public byte? PerPerCariCins2 { get; set; }

    [Column("Per_PerCariCins3")]
    public byte? PerPerCariCins3 { get; set; }

    [Column("Per_PerCariCins4")]
    public byte? PerPerCariCins4 { get; set; }

    [Column("Per_PerCariCins5")]
    public byte? PerPerCariCins5 { get; set; }

    [Column("Per_PerCariCins6")]
    public byte? PerPerCariCins6 { get; set; }

    [Column("Per_PerCariCins7")]
    public byte? PerPerCariCins7 { get; set; }

    [Column("Per_PerCariCins8")]
    public byte? PerPerCariCins8 { get; set; }

    [Column("Per_PerCariCins9")]
    public byte? PerPerCariCins9 { get; set; }

    [Column("Per_PerCariCins10")]
    public byte? PerPerCariCins10 { get; set; }

    [Column("Per_PerCariCins11")]
    public byte? PerPerCariCins11 { get; set; }

    [Column("Per_PerCariCins12")]
    public byte? PerPerCariCins12 { get; set; }

    [Column("Per_PerCariCins13")]
    public byte? PerPerCariCins13 { get; set; }

    [Column("Per_PerCariCins14")]
    public byte? PerPerCariCins14 { get; set; }

    [Column("Per_PerCariCins15")]
    public byte? PerPerCariCins15 { get; set; }

    [Column("Per_PerCariCins16")]
    public byte? PerPerCariCins16 { get; set; }

    [Column("Per_PerCariCins17")]
    public byte? PerPerCariCins17 { get; set; }

    [Column("Per_PerCariCins18")]
    public byte? PerPerCariCins18 { get; set; }

    [Column("Per_PerCariCins19")]
    public byte? PerPerCariCins19 { get; set; }

    [Column("Per_PerCariCins20")]
    public byte? PerPerCariCins20 { get; set; }

    [Column("Per_PerCariCins21")]
    public byte? PerPerCariCins21 { get; set; }

    [Column("Per_PerCariCins22")]
    public byte? PerPerCariCins22 { get; set; }

    [Column("Per_PerCariCins23")]
    public byte? PerPerCariCins23 { get; set; }

    [Column("Per_PerCariCins24")]
    public byte? PerPerCariCins24 { get; set; }

    [Column("Per_PerCariCins_grupno1")]
    public byte? PerPerCariCinsGrupno1 { get; set; }

    [Column("Per_PerCariCins_grupno2")]
    public byte? PerPerCariCinsGrupno2 { get; set; }

    [Column("Per_PerCariCins_grupno3")]
    public byte? PerPerCariCinsGrupno3 { get; set; }

    [Column("Per_PerCariCins_grupno4")]
    public byte? PerPerCariCinsGrupno4 { get; set; }

    [Column("Per_PerCariCins_grupno5")]
    public byte? PerPerCariCinsGrupno5 { get; set; }

    [Column("Per_PerCariCins_grupno6")]
    public byte? PerPerCariCinsGrupno6 { get; set; }

    [Column("Per_PerCariCins_grupno7")]
    public byte? PerPerCariCinsGrupno7 { get; set; }

    [Column("Per_PerCariCins_grupno8")]
    public byte? PerPerCariCinsGrupno8 { get; set; }

    [Column("Per_PerCariCins_grupno9")]
    public byte? PerPerCariCinsGrupno9 { get; set; }

    [Column("Per_PerCariCins_grupno10")]
    public byte? PerPerCariCinsGrupno10 { get; set; }

    [Column("Per_PerCariCins_grupno11")]
    public byte? PerPerCariCinsGrupno11 { get; set; }

    [Column("Per_PerCariCins_grupno12")]
    public byte? PerPerCariCinsGrupno12 { get; set; }

    [Column("Per_PerCariCins_grupno13")]
    public byte? PerPerCariCinsGrupno13 { get; set; }

    [Column("Per_PerCariCins_grupno14")]
    public byte? PerPerCariCinsGrupno14 { get; set; }

    [Column("Per_PerCariCins_grupno15")]
    public byte? PerPerCariCinsGrupno15 { get; set; }

    [Column("Per_PerCariCins_grupno16")]
    public byte? PerPerCariCinsGrupno16 { get; set; }

    [Column("Per_PerCariCins_grupno17")]
    public byte? PerPerCariCinsGrupno17 { get; set; }

    [Column("Per_PerCariCins_grupno18")]
    public byte? PerPerCariCinsGrupno18 { get; set; }

    [Column("Per_PerCariCins_grupno19")]
    public byte? PerPerCariCinsGrupno19 { get; set; }

    [Column("Per_PerCariCins_grupno20")]
    public byte? PerPerCariCinsGrupno20 { get; set; }

    [Column("Per_PerCariCins_grupno21")]
    public byte? PerPerCariCinsGrupno21 { get; set; }

    [Column("Per_PerCariCins_grupno22")]
    public byte? PerPerCariCinsGrupno22 { get; set; }

    [Column("Per_PerCariCins_grupno23")]
    public byte? PerPerCariCinsGrupno23 { get; set; }

    [Column("Per_PerCariCins_grupno24")]
    public byte? PerPerCariCinsGrupno24 { get; set; }

    [Column("Per_TCKimlikNo")]
    [StringLength(11)]
    public string? PerTCKimlikNo { get; set; }

    [Column("Per_PersMailAddress")]
    [StringLength(50)]
    public string? PerPersMailAddress { get; set; }

    [Column("Per_Aylik_calisma_saati")]
    public double? PerAylikCalismaSaati { get; set; }

    [Column("Per_Muh_Grup_Kodu")]
    [StringLength(25)]
    public string? PerMuhGrupKodu { get; set; }

    [Column("per_bolge_kodu")]
    [StringLength(25)]
    public string? PerBolgeKodu { get; set; }

    [Column("per_okul_ad")]
    [StringLength(40)]
    public string? PerOkulAd { get; set; }

    [Column("per_IdariAmirKodu")]
    [StringLength(25)]
    public string? PerIdariAmirKodu { get; set; }

    [Column("per_TeknikAmirKodu")]
    [StringLength(25)]
    public string? PerTeknikAmirKodu { get; set; }

    [Column("per_CikisSebebiSecimli")]
    public byte? PerCikisSebebiSecimli { get; set; }

    [Column("per_ilksoyad")]
    [StringLength(25)]
    public string? PerIlksoyad { get; set; }

    [Column("per_tabiioldugukanun")]
    public byte? PerTabiioldugukanun { get; set; }

    [Column("per_semada_gosterme_fl")]
    public bool? PerSemadaGostermeFl { get; set; }

    [Column("per_Ehl_Bel_No")]
    [StringLength(20)]
    public string? PerEhlBelNo { get; set; }

    [Column("per_Ehl_Bel_Tar")]
    public DateTime? PerEhlBelTar { get; set; }

    [Column("per_Ehl_Sinif")]
    [StringLength(10)]
    public string? PerEhlSinif { get; set; }

    [Column("per_Ehl_Ver_Tar")]
    public DateTime? PerEhlVerTar { get; set; }

    [Column("per_Ehl_Ver_Il")]
    [StringLength(25)]
    public string? PerEhlVerIl { get; set; }

    [Column("per_Ehl_Ver_Ilce")]
    [StringLength(25)]
    public string? PerEhlVerIlce { get; set; }

    [Column("per_Ehl_Kart_No")]
    [StringLength(20)]
    public string? PerEhlKartNo { get; set; }

    [Column("per_Pasaprot_No")]
    [StringLength(20)]
    public string? PerPasaprotNo { get; set; }

    [Column("per_Pas_Alindigi_Tar")]
    public DateTime? PerPasAlindigiTar { get; set; }

    [Column("per_Pas_Gec_Tar")]
    public DateTime? PerPasGecTar { get; set; }

    [Column("per_nuf_asker_cuzdan")]
    [StringLength(20)]
    public string? PerNufAskerCuzdan { get; set; }

    [Column("per_nuf_asker_bastarih")]
    public DateTime? PerNufAskerBastarih { get; set; }

    [Column("per_nuf_asker_bittarih")]
    public DateTime? PerNufAskerBittarih { get; set; }

    [Column("per_nuf_asker_durum")]
    public byte? PerNufAskerDurum { get; set; }

    [Column("per_Isy_KimlikNo")]
    [StringLength(20)]
    public string? PerIsyKimlikNo { get; set; }

    [Column("per_boyu")]
    public double? PerBoyu { get; set; }

    [Column("per_kilo")]
    public double? PerKilo { get; set; }

    [Column("per_gomlek_bed")]
    [StringLength(10)]
    public string? PerGomlekBed { get; set; }

    [Column("per_pant_bed")]
    [StringLength(10)]
    public string? PerPantBed { get; set; }

    [Column("per_etek_bed")]
    [StringLength(10)]
    public string? PerEtekBed { get; set; }

    [Column("per_ayak_no")]
    [StringLength(10)]
    public string? PerAyakNo { get; set; }

    [Column("per_sapka_bed")]
    [StringLength(10)]
    public string? PerSapkaBed { get; set; }

    [Column("per_onluk_bed")]
    [StringLength(10)]
    public string? PerOnlukBed { get; set; }

    [Column("per_diger_bed1")]
    [StringLength(10)]
    public string? PerDigerBed1 { get; set; }

    [Column("per_diger_bed2")]
    [StringLength(10)]
    public string? PerDigerBed2 { get; set; }

    [Column("per_diger_bed3")]
    [StringLength(10)]
    public string? PerDigerBed3 { get; set; }

    [Column("per_UserNo")]
    public int? PerUserNo { get; set; }

    [Column("per_uye_dernek")]
    [StringLength(50)]
    public string? PerUyeDernek { get; set; }

    [Column("per_uye_dernek_sicil_no")]
    [StringLength(25)]
    public string? PerUyeDernekSicilNo { get; set; }

    [Column("per_sinyority_uygulamasi_fl")]
    public bool? PerSinyorityUygulamasiFl { get; set; }

    [Column("per_izinparasi_uygulamasi_fl")]
    public bool? PerIzinparasiUygulamasiFl { get; set; }

    [Column("per_YemekKarti_ID")]
    [StringLength(30)]
    public string? PerYemekKartiID { get; set; }

    [Column("per_srmmrkbaglanti_tip")]
    public byte? PerSrmmrkbaglantiTip { get; set; }

    [Column("per_srmmrkdaganah_kodu")]
    [StringLength(25)]
    public string? PerSrmmrkdaganahKodu { get; set; }

    [Column("per_maas_banka")]
    public byte? PerMaasBanka { get; set; }

    [Column("per_calisma_kodu")]
    [StringLength(25)]
    public string? PerCalismaKodu { get; set; }

    [Column("per_meslek_kodu")]
    [StringLength(25)]
    public string? PerMeslekKodu { get; set; }

    [Column("per_servis_guzergahi")]
    [StringLength(60)]
    public string? PerServisGuzergahi { get; set; }

    [Column("per_vize_no")]
    [StringLength(25)]
    public string? PerVizeNo { get; set; }

    [Column("per_vize_alindigi_tarih")]
    public DateTime? PerVizeAlindigiTarih { get; set; }

    [Column("per_vize_tarihi")]
    public DateTime? PerVizeTarihi { get; set; }

    [Column("per_sskbelge_turu")]
    public byte? PerSskbelgeTuru { get; set; }

    [Column("per_agine_tabii")]
    public byte? PerAgineTabii { get; set; }

    [Column("per_ozur_5763_kont_dahili_fl")]
    public bool? PerOzur5763KontDahiliFl { get; set; }

    [Column("per_yabanci_ulke")]
    [StringLength(30)]
    public string? PerYabanciUlke { get; set; }

    [Column("per_sigortalilik_turu")]
    public byte? PerSigortalilikTuru { get; set; }

    [Column("per_eski_sicil_no")]
    [StringLength(25)]
    public string? PerEskiSicilNo { get; set; }

    [Column("per_tabiioldugukanun2")]
    public byte? PerTabiioldugukanun2 { get; set; }

    [Column("per_maaskiminhesabina")]
    public byte? PerMaaskiminhesabina { get; set; }

    [Column("per_maassistemikodu")]
    [StringLength(25)]
    public string? PerMaassistemikodu { get; set; }

    [Column("per_is_grup_kodu")]
    [StringLength(25)]
    public string? PerIsGrupKodu { get; set; }

    [Column("per_unvan_kodu")]
    [StringLength(25)]
    public string? PerUnvanKodu { get; set; }

    [Column("per_raporlama_yapacagi_per_kod")]
    [StringLength(25)]
    public string? PerRaporlamaYapacagiPerKod { get; set; }

    [Column("per_okul_kodu")]
    [StringLength(25)]
    public string? PerOkulKodu { get; set; }

    [Column("per_okul_bolum_kodu")]
    [StringLength(25)]
    public string? PerOkulBolumKodu { get; set; }

    [Column("per_bolum_kodu")]
    [StringLength(25)]
    public string? PerBolumKodu { get; set; }

    [Column("per_alt_dept_kod")]
    [StringLength(25)]
    public string? PerAltDeptKod { get; set; }

    [Column("per_kanun_gecerlilik_tarihi")]
    public DateTime? PerKanunGecerlilikTarihi { get; set; }

    [Column("per_tabiioldugukanun3")]
    public byte? PerTabiioldugukanun3 { get; set; }

    [Column("per_mezuniyetyili")]
    public short? PerMezuniyetyili { get; set; }

    [Column("per_proje_kodu")]
    [StringLength(25)]
    public string? PerProjeKodu { get; set; }

    [Column("per_hazine_destegine_tabi_fl")]
    public bool? PerHazineDestegineTabiFl { get; set; }

    [Column("per_KEP_adresi")]
    [StringLength(80)]
    public string? PerKEPAdresi { get; set; }

    [Column("per_sigara_fl")]
    public bool? PerSigaraFl { get; set; }

    [Column("per_otobes_fl")]
    public bool? PerOtobesFl { get; set; }

    [Column("per_otobes_sigorta")]
    public byte? PerOtobesSigorta { get; set; }

    [Column("per_otobes_orani")]
    public double? PerOtobesOrani { get; set; }

    [Column("per_otobes_hesap_no")]
    [StringLength(30)]
    public string? PerOtobesHesapNo { get; set; }

    [Column("per_otobes_grup_sozlesme_no")]
    [StringLength(25)]
    public string? PerOtobesGrupSozlesmeNo { get; set; }

    [Column("per_otobes_fon_tercihi")]
    public byte? PerOtobesFonTercihi { get; set; }

    [Column("per_otobes_giris")]
    public DateTime? PerOtobesGiris { get; set; }

    [Column("per_otobes_ayrilis")]
    public DateTime? PerOtobesAyrilis { get; set; }

    [Column("per_sosyal_linkedin")]
    [StringLength(50)]
    public string? PerSosyalLinkedin { get; set; }

    [Column("per_sosyal_webadresi")]
    [StringLength(50)]
    public string? PerSosyalWebadresi { get; set; }

    [Column("per_sosyal_youtube")]
    [StringLength(50)]
    public string? PerSosyalYoutube { get; set; }

    [Column("per_sosyal_twitter")]
    [StringLength(50)]
    public string? PerSosyalTwitter { get; set; }

    [Column("per_sosyal_facebook")]
    [StringLength(50)]
    public string? PerSosyalFacebook { get; set; }

    [Column("per_sosyal_google")]
    [StringLength(50)]
    public string? PerSosyalGoogle { get; set; }

    [Column("per_sosyal_pinterest")]
    [StringLength(50)]
    public string? PerSosyalPinterest { get; set; }

    [Column("per_sosyal_instagram")]
    [StringLength(50)]
    public string? PerSosyalInstagram { get; set; }

    [Column("per_sosyal_snapchat")]
    [StringLength(50)]
    public string? PerSosyalSnapchat { get; set; }
}
