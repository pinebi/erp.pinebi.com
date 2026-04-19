using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("e_fatura_tanimlari")]
public class EFaturaTanimlari
{
    [Column("efp_Guid")]
    public Guid? EfpGuid { get; set; }

    [Column("efp_DBCno")]
    public short? EfpDBCno { get; set; }

    [Column("efp_SpecRECno")]
    public int? EfpSpecRECno { get; set; }

    [Column("efp_iptal")]
    public bool? EfpIptal { get; set; }

    [Column("efp_fileid")]
    public short? EfpFileid { get; set; }

    [Column("efp_hidden")]
    public bool? EfpHidden { get; set; }

    [Column("efp_kilitli")]
    public bool? EfpKilitli { get; set; }

    [Column("efp_degisti")]
    public bool? EfpDegisti { get; set; }

    [Column("efp_checksum")]
    public int? EfpChecksum { get; set; }

    [Column("efp_create_user")]
    public short? EfpCreateUser { get; set; }

    [Column("efp_create_date")]
    public DateTime? EfpCreateDate { get; set; }

    [Column("efp_lastup_user")]
    public short? EfpLastupUser { get; set; }

    [Column("efp_lastup_date")]
    public DateTime? EfpLastupDate { get; set; }

    [Column("efp_special1")]
    [StringLength(4)]
    public string? EfpSpecial1 { get; set; }

    [Column("efp_special2")]
    [StringLength(4)]
    public string? EfpSpecial2 { get; set; }

    [Column("efp_special3")]
    [StringLength(4)]
    public string? EfpSpecial3 { get; set; }

    [Column("efp_firmano")]
    public int? EfpFirmano { get; set; }

    [Column("efp_subeno")]
    public int? EfpSubeno { get; set; }

    [Column("efp_kullanici")]
    [StringLength(25)]
    public string? EfpKullanici { get; set; }

    [Column("efp_sifre")]
    [StringLength(127)]
    public string? EfpSifre { get; set; }

    [Column("efp_entegrator_id")]
    public byte? EfpEntegratorId { get; set; }

    [Column("efp_ucnokta_url_set")]
    public byte? EfpUcnoktaUrlSet { get; set; }

    [Column("efp_fp_alias")]
    [StringLength(40)]
    public string? EfpFpAlias { get; set; }

    [Column("efp_fp_sifre")]
    [StringLength(127)]
    public string? EfpFpSifre { get; set; }

    [Column("efp_portal_izin")]
    [StringLength(127)]
    public string? EfpPortalIzin { get; set; }

    [Column("efp_portal_fatura_dosya")]
    [StringLength(127)]
    public string? EfpPortalFaturaDosya { get; set; }

    [Column("efp_portal_birim_kodu")]
    [StringLength(3)]
    public string? EfpPortalBirimKodu { get; set; }

    [Column("efp_baslangic_degeri")]
    public int? EfpBaslangicDegeri { get; set; }

    [Column("efp_aciklama_aktarilsin_fl")]
    public bool? EfpAciklamaAktarilsinFl { get; set; }

    [Column("efp_kabul_irs_karsila_fl")]
    public bool? EfpKabulIrsKarsilaFl { get; set; }

    [Column("efp_kabul_sip_karsila_fl")]
    public bool? EfpKabulSipKarsilaFl { get; set; }

    [Column("efp_carievrak_kilitle_fl")]
    public bool? EfpCarievrakKilitleFl { get; set; }

    [Column("efp_belgetarihini_evraktarihi_kaydet_fl")]
    public bool? EfpBelgetarihiniEvraktarihiKaydetFl { get; set; }

    [Column("efp_irsaliye_belgeno_gonder_fl")]
    public bool? EfpIrsaliyeBelgenoGonderFl { get; set; }

    [Column("efp_siparis_belgeno_gonder_fl")]
    public bool? EfpSiparisBelgenoGonderFl { get; set; }

    [Column("efp_satis_fat_stokbirlestir_fl")]
    public bool? EfpSatisFatStokbirlestirFl { get; set; }

    [Column("efp_ana_dovizle_gonder_fl")]
    public bool? EfpAnaDovizleGonderFl { get; set; }

    [Column("efp_detayli_goster_fl")]
    public bool? EfpDetayliGosterFl { get; set; }

    [Column("efp_satis_fat_hizmetbirlestir_fl")]
    public bool? EfpSatisFatHizmetbirlestirFl { get; set; }

    [Column("efp_srmllk_prje_ayirdtmdn_hizm_brlstr")]
    public bool? EfpSrmllkPrjeAyirdtmdnHizmBrlstr { get; set; }

    [Column("efp_sevk_adresi_kullan_fl")]
    public bool? EfpSevkAdresiKullanFl { get; set; }

    [Column("efp_yetkili_eposta_kullan_fl")]
    public bool? EfpYetkiliEpostaKullanFl { get; set; }

    [Column("efp_alis_fat_efatura_kullanicisi_fl")]
    public bool? EfpAlisFatEfaturaKullanicisiFl { get; set; }

    [Column("efp_srmllk_prje_ayirdtmdn_stok_brlstr")]
    public bool? EfpSrmllkPrjeAyirdtmdnStokBrlstr { get; set; }

    [Column("efp_VarsayilanIstisna_aciklama")]
    [StringLength(127)]
    public string? EfpVarsayilanIstisnaAciklama { get; set; }

    [Column("efp_custom_irsaliye_field_count")]
    public int? EfpCustomIrsaliyeFieldCount { get; set; }

    [Column("efp_KDVFarkitutari")]
    public double? EfpKDVFarkitutari { get; set; }

    [Column("efp_EkMasraflarinKodu")]
    [StringLength(25)]
    public string? EfpEkMasraflarinKodu { get; set; }

    [Column("efp_FatBaglama_BelgeNoGuncelle_fl")]
    public bool? EfpFatBaglamaBelgeNoGuncelleFl { get; set; }

    [Column("efp_YenidenEntegreFisAciklamaBelgeno_fl")]
    public bool? EfpYenidenEntegreFisAciklamaBelgenoFl { get; set; }

    [Column("efp_NotHareketAciklamayaAktarilMAsin_fl")]
    public byte? EfpNotHareketAciklamayaAktarilMAsinFl { get; set; }

    [Column("efp_EvrakSiraGirilsin_fl")]
    public bool? EfpEvrakSiraGirilsinFl { get; set; }

    [Column("efp_VKNSorguGlbVeritabanindan_fl")]
    public bool? EfpVKNSorguGlbVeritabanindanFl { get; set; }

    [Column("efp_detay_takipsiz_stok_birlestir_fl")]
    public bool? EfpDetayTakipsizStokBirlestirFl { get; set; }

    [Column("efp_gonderimde_log_olustur_fl")]
    public bool? EfpGonderimdeLogOlusturFl { get; set; }

    [Column("efp_irsaliye_siparis_eklentileri")]
    public byte? EfpIrsaliyeSiparisEklentileri { get; set; }

    [Column("efp_varsayilan_araci_kodu")]
    [StringLength(25)]
    public string? EfpVarsayilanAraciKodu { get; set; }

    [Column("efp_SGK_cari_kodu")]
    [StringLength(25)]
    public string? EfpSGKCariKodu { get; set; }

    [Column("efp_subeye_gore_filtrele")]
    public bool? EfpSubeyeGoreFiltrele { get; set; }

    [Column("efp_navlun_masraf_tip")]
    public byte? EfpNavlunMasrafTip { get; set; }

    [Column("efp_sigorta_masraf_tip")]
    public byte? EfpSigortaMasrafTip { get; set; }

    [Column("efp_komisyon_masraf_tip")]
    public byte? EfpKomisyonMasrafTip { get; set; }

    [Column("efp_diger_masraf_tip")]
    public byte? EfpDigerMasrafTip { get; set; }

    [Column("efp_diger_aciklama")]
    [StringLength(50)]
    public string? EfpDigerAciklama { get; set; }

    [Column("efp_KullaniciYetkiKontroluNereden")]
    public byte? EfpKullaniciYetkiKontroluNereden { get; set; }
}
