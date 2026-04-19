using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesaplar")]
public class CariHesaplar
{
    [Column("cari_Guid")]
    public Guid? CariGuid { get; set; }

    [Column("cari_DBCno")]
    public short? CariDBCno { get; set; }

    [Column("cari_SpecRECno")]
    public int? CariSpecRECno { get; set; }

    [Column("cari_iptal")]
    public bool? CariIptal { get; set; }

    [Column("cari_fileid")]
    public short? CariFileid { get; set; }

    [Column("cari_hidden")]
    public bool? CariHidden { get; set; }

    [Column("cari_kilitli")]
    public bool? CariKilitli { get; set; }

    [Column("cari_degisti")]
    public bool? CariDegisti { get; set; }

    [Column("cari_checksum")]
    public int? CariChecksum { get; set; }

    [Column("cari_create_user")]
    public short? CariCreateUser { get; set; }

    [Column("cari_create_date")]
    public DateTime? CariCreateDate { get; set; }

    [Column("cari_lastup_user")]
    public short? CariLastupUser { get; set; }

    [Column("cari_lastup_date")]
    public DateTime? CariLastupDate { get; set; }

    [Column("cari_special1")]
    [StringLength(4)]
    public string? CariSpecial1 { get; set; }

    [Column("cari_special2")]
    [StringLength(4)]
    public string? CariSpecial2 { get; set; }

    [Column("cari_special3")]
    [StringLength(4)]
    public string? CariSpecial3 { get; set; }

    [Column("cari_kod")]
    [StringLength(25)]
    public string? CariKod { get; set; }

    [Column("cari_unvan1")]
    [StringLength(127)]
    public string? CariUnvan1 { get; set; }

    [Column("cari_unvan2")]
    [StringLength(127)]
    public string? CariUnvan2 { get; set; }

    [Column("cari_hareket_tipi")]
    public byte? CariHareketTipi { get; set; }

    [Column("cari_baglanti_tipi")]
    public byte? CariBaglantiTipi { get; set; }

    [Column("cari_stok_alim_cinsi")]
    public byte? CariStokAlimCinsi { get; set; }

    [Column("cari_stok_satim_cinsi")]
    public byte? CariStokSatimCinsi { get; set; }

    [Column("cari_muh_kod")]
    [StringLength(40)]
    public string? CariMuhKod { get; set; }

    [Column("cari_muh_kod1")]
    [StringLength(40)]
    public string? CariMuhKod1 { get; set; }

    [Column("cari_muh_kod2")]
    [StringLength(40)]
    public string? CariMuhKod2 { get; set; }

    [Column("cari_doviz_cinsi")]
    public byte? CariDovizCinsi { get; set; }

    [Column("cari_doviz_cinsi1")]
    public byte? CariDovizCinsi1 { get; set; }

    [Column("cari_doviz_cinsi2")]
    public byte? CariDovizCinsi2 { get; set; }

    [Column("cari_vade_fark_yuz")]
    public double? CariVadeFarkYuz { get; set; }

    [Column("cari_vade_fark_yuz1")]
    public double? CariVadeFarkYuz1 { get; set; }

    [Column("cari_vade_fark_yuz2")]
    public double? CariVadeFarkYuz2 { get; set; }

    [Column("cari_KurHesapSekli")]
    public byte? CariKurHesapSekli { get; set; }

    [Column("cari_vdaire_adi")]
    [StringLength(50)]
    public string? CariVdaireAdi { get; set; }

    [Column("cari_vdaire_no")]
    [StringLength(15)]
    public string? CariVdaireNo { get; set; }

    [Column("cari_sicil_no")]
    [StringLength(15)]
    public string? CariSicilNo { get; set; }

    [Column("cari_VergiKimlikNo")]
    [StringLength(10)]
    public string? CariVergiKimlikNo { get; set; }

    [Column("cari_satis_fk")]
    public int? CariSatisFk { get; set; }

    [Column("cari_odeme_cinsi")]
    public byte? CariOdemeCinsi { get; set; }

    [Column("cari_odeme_gunu")]
    public byte? CariOdemeGunu { get; set; }

    [Column("cari_odemeplan_no")]
    public int? CariOdemeplanNo { get; set; }

    [Column("cari_opsiyon_gun")]
    public int? CariOpsiyonGun { get; set; }

    [Column("cari_cariodemetercihi")]
    public byte? CariCariodemetercihi { get; set; }

    [Column("cari_fatura_adres_no")]
    public int? CariFaturaAdresNo { get; set; }

    [Column("cari_sevk_adres_no")]
    public int? CariSevkAdresNo { get; set; }

    [Column("cari_banka_tcmb_kod1")]
    [StringLength(4)]
    public string? CariBankaTcmbKod1 { get; set; }

    [Column("cari_banka_tcmb_subekod1")]
    [StringLength(8)]
    public string? CariBankaTcmbSubekod1 { get; set; }

    [Column("cari_banka_tcmb_ilkod1")]
    [StringLength(3)]
    public string? CariBankaTcmbIlkod1 { get; set; }

    [Column("cari_banka_hesapno1")]
    [StringLength(30)]
    public string? CariBankaHesapno1 { get; set; }

    [Column("cari_banka_tcmb_kod2")]
    [StringLength(4)]
    public string? CariBankaTcmbKod2 { get; set; }

    [Column("cari_banka_tcmb_subekod2")]
    [StringLength(8)]
    public string? CariBankaTcmbSubekod2 { get; set; }

    [Column("cari_banka_tcmb_ilkod2")]
    [StringLength(3)]
    public string? CariBankaTcmbIlkod2 { get; set; }

    [Column("cari_banka_hesapno2")]
    [StringLength(30)]
    public string? CariBankaHesapno2 { get; set; }

    [Column("cari_banka_tcmb_kod3")]
    [StringLength(4)]
    public string? CariBankaTcmbKod3 { get; set; }

    [Column("cari_banka_tcmb_subekod3")]
    [StringLength(8)]
    public string? CariBankaTcmbSubekod3 { get; set; }

    [Column("cari_banka_tcmb_ilkod3")]
    [StringLength(3)]
    public string? CariBankaTcmbIlkod3 { get; set; }

    [Column("cari_banka_hesapno3")]
    [StringLength(30)]
    public string? CariBankaHesapno3 { get; set; }

    [Column("cari_EftHesapNum")]
    public byte? CariEftHesapNum { get; set; }

    [Column("cari_Ana_cari_kodu")]
    [StringLength(25)]
    public string? CariAnaCariKodu { get; set; }

    [Column("cari_satis_isk_kod")]
    [StringLength(4)]
    public string? CariSatisIskKod { get; set; }

    [Column("cari_sektor_kodu")]
    [StringLength(25)]
    public string? CariSektorKodu { get; set; }

    [Column("cari_bolge_kodu")]
    [StringLength(25)]
    public string? CariBolgeKodu { get; set; }

    [Column("cari_grup_kodu")]
    [StringLength(25)]
    public string? CariGrupKodu { get; set; }

    [Column("cari_temsilci_kodu")]
    [StringLength(25)]
    public string? CariTemsilciKodu { get; set; }

    [Column("cari_muhartikeli")]
    [StringLength(10)]
    public string? CariMuhartikeli { get; set; }

    [Column("cari_firma_acik_kapal")]
    public bool? CariFirmaAcikKapal { get; set; }

    [Column("cari_BUV_tabi_fl")]
    public bool? CariBUVTabiFl { get; set; }

    [Column("cari_cari_kilitli_flg")]
    public bool? CariCariKilitliFlg { get; set; }

    [Column("cari_etiket_bas_fl")]
    public bool? CariEtiketBasFl { get; set; }

    [Column("cari_Detay_incele_flg")]
    public bool? CariDetayInceleFlg { get; set; }

    [Column("cari_efatura_fl")]
    public bool? CariEfaturaFl { get; set; }

    [Column("cari_POS_ongpesyuzde")]
    public double? CariPOSOngpesyuzde { get; set; }

    [Column("cari_POS_ongtaksayi")]
    public double? CariPOSOngtaksayi { get; set; }

    [Column("cari_POS_ongIskOran")]
    public double? CariPOSOngIskOran { get; set; }

    [Column("cari_kaydagiristarihi")]
    public DateTime? CariKaydagiristarihi { get; set; }

    [Column("cari_KabEdFCekTutar")]
    public double? CariKabEdFCekTutar { get; set; }

    [Column("cari_hal_caritip")]
    public byte? CariHalCaritip { get; set; }

    [Column("cari_HalKomYuzdesi")]
    public double? CariHalKomYuzdesi { get; set; }

    [Column("cari_TeslimSuresi")]
    public short? CariTeslimSuresi { get; set; }

    [Column("cari_wwwadresi")]
    [StringLength(30)]
    public string? CariWwwadresi { get; set; }

    [Column("cari_EMail")]
    [StringLength(80)]
    public string? CariEMail { get; set; }

    [Column("cari_CepTel")]
    [StringLength(20)]
    public string? CariCepTel { get; set; }

    [Column("cari_VarsayilanGirisDepo")]
    public int? CariVarsayilanGirisDepo { get; set; }

    [Column("cari_VarsayilanCikisDepo")]
    public int? CariVarsayilanCikisDepo { get; set; }

    [Column("cari_Portal_Enabled")]
    public bool? CariPortalEnabled { get; set; }

    [Column("cari_Portal_PW")]
    [StringLength(127)]
    public string? CariPortalPW { get; set; }

    [Column("cari_BagliOrtaklisa_Firma")]
    public int? CariBagliOrtaklisaFirma { get; set; }

    [Column("cari_kampanyakodu")]
    [StringLength(4)]
    public string? CariKampanyakodu { get; set; }

    [Column("cari_b_bakiye_degerlendirilmesin_fl")]
    public bool? CariBBakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_a_bakiye_degerlendirilmesin_fl")]
    public bool? CariABakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_b_irsbakiye_degerlendirilmesin_fl")]
    public bool? CariBIrsbakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_a_irsbakiye_degerlendirilmesin_fl")]
    public bool? CariAIrsbakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_b_sipbakiye_degerlendirilmesin_fl")]
    public bool? CariBSipbakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_a_sipbakiye_degerlendirilmesin_fl")]
    public bool? CariASipbakiyeDegerlendirilmesinFl { get; set; }

    [Column("cari_AvmBilgileri1KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri1KiraKodu { get; set; }

    [Column("cari_AvmBilgileri1TebligatSekli")]
    public byte? CariAvmBilgileri1TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri2KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri2KiraKodu { get; set; }

    [Column("cari_AvmBilgileri2TebligatSekli")]
    public byte? CariAvmBilgileri2TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri3KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri3KiraKodu { get; set; }

    [Column("cari_AvmBilgileri3TebligatSekli")]
    public byte? CariAvmBilgileri3TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri4KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri4KiraKodu { get; set; }

    [Column("cari_AvmBilgileri4TebligatSekli")]
    public byte? CariAvmBilgileri4TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri5KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri5KiraKodu { get; set; }

    [Column("cari_AvmBilgileri5TebligatSekli")]
    public byte? CariAvmBilgileri5TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri6KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri6KiraKodu { get; set; }

    [Column("cari_AvmBilgileri6TebligatSekli")]
    public byte? CariAvmBilgileri6TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri7KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri7KiraKodu { get; set; }

    [Column("cari_AvmBilgileri7TebligatSekli")]
    public byte? CariAvmBilgileri7TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri8KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri8KiraKodu { get; set; }

    [Column("cari_AvmBilgileri8TebligatSekli")]
    public byte? CariAvmBilgileri8TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri9KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri9KiraKodu { get; set; }

    [Column("cari_AvmBilgileri9TebligatSekli")]
    public byte? CariAvmBilgileri9TebligatSekli { get; set; }

    [Column("cari_AvmBilgileri10KiraKodu")]
    [StringLength(25)]
    public string? CariAvmBilgileri10KiraKodu { get; set; }

    [Column("cari_AvmBilgileri10TebligatSekli")]
    public byte? CariAvmBilgileri10TebligatSekli { get; set; }

    [Column("cari_KrediRiskTakibiVar_flg")]
    public bool? CariKrediRiskTakibiVarFlg { get; set; }

    [Column("cari_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? CariUfrsFarkMuhKod { get; set; }

    [Column("cari_ufrs_fark_muh_kod1")]
    [StringLength(40)]
    public string? CariUfrsFarkMuhKod1 { get; set; }

    [Column("cari_ufrs_fark_muh_kod2")]
    [StringLength(40)]
    public string? CariUfrsFarkMuhKod2 { get; set; }

    [Column("cari_odeme_sekli")]
    public byte? CariOdemeSekli { get; set; }

    [Column("cari_TeminatMekAlacakMuhKodu")]
    [StringLength(40)]
    public string? CariTeminatMekAlacakMuhKodu { get; set; }

    [Column("cari_TeminatMekAlacakMuhKodu1")]
    [StringLength(40)]
    public string? CariTeminatMekAlacakMuhKodu1 { get; set; }

    [Column("cari_TeminatMekAlacakMuhKodu2")]
    [StringLength(40)]
    public string? CariTeminatMekAlacakMuhKodu2 { get; set; }

    [Column("cari_TeminatMekBorcMuhKodu")]
    [StringLength(40)]
    public string? CariTeminatMekBorcMuhKodu { get; set; }

    [Column("cari_TeminatMekBorcMuhKodu1")]
    [StringLength(40)]
    public string? CariTeminatMekBorcMuhKodu1 { get; set; }

    [Column("cari_TeminatMekBorcMuhKodu2")]
    [StringLength(40)]
    public string? CariTeminatMekBorcMuhKodu2 { get; set; }

    [Column("cari_VerilenDepozitoTeminatMuhKodu")]
    [StringLength(40)]
    public string? CariVerilenDepozitoTeminatMuhKodu { get; set; }

    [Column("cari_VerilenDepozitoTeminatMuhKodu1")]
    [StringLength(40)]
    public string? CariVerilenDepozitoTeminatMuhKodu1 { get; set; }

    [Column("cari_VerilenDepozitoTeminatMuhKodu2")]
    [StringLength(40)]
    public string? CariVerilenDepozitoTeminatMuhKodu2 { get; set; }

    [Column("cari_AlinanDepozitoTeminatMuhKodu")]
    [StringLength(40)]
    public string? CariAlinanDepozitoTeminatMuhKodu { get; set; }

    [Column("cari_AlinanDepozitoTeminatMuhKodu1")]
    [StringLength(40)]
    public string? CariAlinanDepozitoTeminatMuhKodu1 { get; set; }

    [Column("cari_AlinanDepozitoTeminatMuhKodu2")]
    [StringLength(40)]
    public string? CariAlinanDepozitoTeminatMuhKodu2 { get; set; }

    [Column("cari_def_efatura_cinsi")]
    public byte? CariDefEfaturaCinsi { get; set; }

    [Column("cari_otv_tevkifatina_tabii_fl")]
    public bool? CariOtvTevkifatinaTabiiFl { get; set; }

    [Column("cari_KEP_adresi")]
    [StringLength(80)]
    public string? CariKEPAdresi { get; set; }

    [Column("cari_efatura_baslangic_tarihi")]
    public DateTime? CariEfaturaBaslangicTarihi { get; set; }

    [Column("cari_mutabakat_mail_adresi")]
    [StringLength(80)]
    public string? CariMutabakatMailAdresi { get; set; }

    [Column("cari_mersis_no")]
    [StringLength(25)]
    public string? CariMersisNo { get; set; }

    [Column("cari_istasyon_cari_kodu")]
    [StringLength(25)]
    public string? CariIstasyonCariKodu { get; set; }

    [Column("cari_gonderionayi_sms")]
    public bool? CariGonderionayiSms { get; set; }

    [Column("cari_gonderionayi_email")]
    public bool? CariGonderionayiEmail { get; set; }

    [Column("cari_eirsaliye_fl")]
    public bool? CariEirsaliyeFl { get; set; }

    [Column("cari_eirsaliye_baslangic_tarihi")]
    public DateTime? CariEirsaliyeBaslangicTarihi { get; set; }
}
