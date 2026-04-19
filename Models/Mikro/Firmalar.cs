using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firmalar")]
public class Firmalar
{
    [Column("fir_Guid")]
    public Guid? FirGuid { get; set; }

    [Column("fir_DBCno")]
    public short? FirDBCno { get; set; }

    [Column("fir_SpecRECno")]
    public int? FirSpecRECno { get; set; }

    [Column("fir_iptal")]
    public bool? FirIptal { get; set; }

    [Column("fir_fileid")]
    public short? FirFileid { get; set; }

    [Column("fir_hidden")]
    public bool? FirHidden { get; set; }

    [Column("fir_kilitli")]
    public bool? FirKilitli { get; set; }

    [Column("fir_degisti")]
    public bool? FirDegisti { get; set; }

    [Column("fir_checksum")]
    public int? FirChecksum { get; set; }

    [Column("fir_create_user")]
    public short? FirCreateUser { get; set; }

    [Column("fir_create_date")]
    public DateTime? FirCreateDate { get; set; }

    [Column("fir_lastup_user")]
    public short? FirLastupUser { get; set; }

    [Column("fir_lastup_date")]
    public DateTime? FirLastupDate { get; set; }

    [Column("fir_special1")]
    [StringLength(4)]
    public string? FirSpecial1 { get; set; }

    [Column("fir_special2")]
    [StringLength(4)]
    public string? FirSpecial2 { get; set; }

    [Column("fir_special3")]
    [StringLength(4)]
    public string? FirSpecial3 { get; set; }

    [Column("fir_sirano")]
    public int? FirSirano { get; set; }

    [Column("fir_unvan")]
    [StringLength(127)]
    public string? FirUnvan { get; set; }

    [Column("fir_unvan2")]
    [StringLength(127)]
    public string? FirUnvan2 { get; set; }

    [Column("fir_TCkimlik")]
    [StringLength(15)]
    public string? FirTCkimlik { get; set; }

    [Column("fir_Yazisma")]
    [StringLength(10)]
    public string? FirYazisma { get; set; }

    [Column("fir_Bordro")]
    [StringLength(10)]
    public string? FirBordro { get; set; }

    [Column("fir_FHesapNo")]
    [StringLength(30)]
    public string? FirFHesapNo { get; set; }

    [Column("fir_FVergiDaire")]
    [StringLength(10)]
    public string? FirFVergiDaire { get; set; }

    [Column("fir_FVergiNo")]
    [StringLength(20)]
    public string? FirFVergiNo { get; set; }

    [Column("fir_FBolgeNo")]
    [StringLength(20)]
    public string? FirFBolgeNo { get; set; }

    [Column("fir_Muhtasar")]
    public bool? FirMuhtasar { get; set; }

    [Column("fir_Isci")]
    public bool? FirIsci { get; set; }

    [Column("fir_BasTar")]
    public DateTime? FirBasTar { get; set; }

    [Column("fir_Istigal")]
    [StringLength(40)]
    public string? FirIstigal { get; set; }

    [Column("fir_Defter")]
    public bool? FirDefter { get; set; }

    [Column("fir_TicSicilNo")]
    [StringLength(25)]
    public string? FirTicSicilNo { get; set; }

    [Column("fir_IslIzn1")]
    public bool? FirIslIzn1 { get; set; }

    [Column("fir_IslIzn2")]
    public bool? FirIslIzn2 { get; set; }

    [Column("fir_IslIzn3")]
    public bool? FirIslIzn3 { get; set; }

    [Column("fir_IslIzn4")]
    public bool? FirIslIzn4 { get; set; }

    [Column("fir_IslIzn5")]
    public bool? FirIslIzn5 { get; set; }

    [Column("fir_IslIzn6")]
    public bool? FirIslIzn6 { get; set; }

    [Column("fir_IslIzn7")]
    public bool? FirIslIzn7 { get; set; }

    [Column("fir_IslIzn8")]
    public bool? FirIslIzn8 { get; set; }

    [Column("fir_IslIzn9")]
    public bool? FirIslIzn9 { get; set; }

    [Column("fir_IslIzn10")]
    public bool? FirIslIzn10 { get; set; }

    [Column("fir_IslIzn11")]
    public bool? FirIslIzn11 { get; set; }

    [Column("fir_IslIzn12")]
    public bool? FirIslIzn12 { get; set; }

    [Column("fir_IslIzn13")]
    public bool? FirIslIzn13 { get; set; }

    [Column("fir_IslIzn14")]
    public bool? FirIslIzn14 { get; set; }

    [Column("fir_IslIzn15")]
    public bool? FirIslIzn15 { get; set; }

    [Column("fir_SmmEntegrasyon")]
    public byte? FirSmmEntegrasyon { get; set; }

    [Column("fir_Mali_Mus_firmasi")]
    public bool? FirMaliMusFirmasi { get; set; }

    [Column("fir_Iso_no")]
    [StringLength(15)]
    public string? FirIsoNo { get; set; }

    [Column("fir_maasBankaKod")]
    [StringLength(25)]
    public string? FirMaasBankaKod { get; set; }

    [Column("fir_baslangic_tarihi")]
    public DateTime? FirBaslangicTarihi { get; set; }

    [Column("fir_OTVden_muaf")]
    public bool? FirOTVdenMuaf { get; set; }

    [Column("fir_krediriskyuzde1")]
    public double? FirKrediriskyuzde1 { get; set; }

    [Column("fir_krediriskneolacak1")]
    public byte? FirKrediriskneolacak1 { get; set; }

    [Column("fir_kredirisklimityuzde1hesap")]
    public byte? FirKredirisklimityuzde1hesap { get; set; }

    [Column("fir_kredirisklimityuzde1")]
    public double? FirKredirisklimityuzde1 { get; set; }

    [Column("fir_kredirisklimittipi1")]
    public byte? FirKredirisklimittipi1 { get; set; }

    [Column("fir_krediriskyuzde2")]
    public double? FirKrediriskyuzde2 { get; set; }

    [Column("fir_krediriskneolacak2")]
    public byte? FirKrediriskneolacak2 { get; set; }

    [Column("fir_kredirisklimityuzde2hesap")]
    public byte? FirKredirisklimityuzde2hesap { get; set; }

    [Column("fir_kredirisklimityuzde2")]
    public double? FirKredirisklimityuzde2 { get; set; }

    [Column("fir_kredirisklimittipi2")]
    public byte? FirKredirisklimittipi2 { get; set; }

    [Column("fir_krediriskyuzde3")]
    public double? FirKrediriskyuzde3 { get; set; }

    [Column("fir_krediriskneolacak3")]
    public byte? FirKrediriskneolacak3 { get; set; }

    [Column("fir_kredirisklimityuzde3hesap")]
    public byte? FirKredirisklimityuzde3hesap { get; set; }

    [Column("fir_kredirisklimityuzde3")]
    public double? FirKredirisklimityuzde3 { get; set; }

    [Column("fir_kredirisklimittipi3")]
    public byte? FirKredirisklimittipi3 { get; set; }

    [Column("fir_krediriskyuzde4")]
    public double? FirKrediriskyuzde4 { get; set; }

    [Column("fir_krediriskneolacak4")]
    public byte? FirKrediriskneolacak4 { get; set; }

    [Column("fir_kredirisklimityuzde4hesap")]
    public byte? FirKredirisklimityuzde4hesap { get; set; }

    [Column("fir_kredirisklimityuzde4")]
    public double? FirKredirisklimityuzde4 { get; set; }

    [Column("fir_kredirisklimittipi4")]
    public byte? FirKredirisklimittipi4 { get; set; }

    [Column("fir_krediriskyuzde5")]
    public double? FirKrediriskyuzde5 { get; set; }

    [Column("fir_krediriskneolacak5")]
    public byte? FirKrediriskneolacak5 { get; set; }

    [Column("fir_kredirisklimityuzde5hesap")]
    public byte? FirKredirisklimityuzde5hesap { get; set; }

    [Column("fir_kredirisklimityuzde5")]
    public double? FirKredirisklimityuzde5 { get; set; }

    [Column("fir_kredirisklimittipi5")]
    public byte? FirKredirisklimittipi5 { get; set; }

    [Column("fir_krediriskyuzde6")]
    public double? FirKrediriskyuzde6 { get; set; }

    [Column("fir_krediriskneolacak6")]
    public byte? FirKrediriskneolacak6 { get; set; }

    [Column("fir_kredirisklimityuzde6hesap")]
    public byte? FirKredirisklimityuzde6hesap { get; set; }

    [Column("fir_kredirisklimityuzde6")]
    public double? FirKredirisklimityuzde6 { get; set; }

    [Column("fir_kredirisklimittipi6")]
    public byte? FirKredirisklimittipi6 { get; set; }

    [Column("fir_krediriskyuzde7")]
    public double? FirKrediriskyuzde7 { get; set; }

    [Column("fir_krediriskneolacak7")]
    public byte? FirKrediriskneolacak7 { get; set; }

    [Column("fir_kredirisklimityuzde7hesap")]
    public byte? FirKredirisklimityuzde7hesap { get; set; }

    [Column("fir_kredirisklimityuzde7")]
    public double? FirKredirisklimityuzde7 { get; set; }

    [Column("fir_kredirisklimittipi7")]
    public byte? FirKredirisklimittipi7 { get; set; }

    [Column("fir_krediriskyuzde8")]
    public double? FirKrediriskyuzde8 { get; set; }

    [Column("fir_krediriskneolacak8")]
    public byte? FirKrediriskneolacak8 { get; set; }

    [Column("fir_kredirisklimityuzde8hesap")]
    public byte? FirKredirisklimityuzde8hesap { get; set; }

    [Column("fir_kredirisklimityuzde8")]
    public double? FirKredirisklimityuzde8 { get; set; }

    [Column("fir_kredirisklimittipi8")]
    public byte? FirKredirisklimittipi8 { get; set; }

    [Column("fir_krediriskyuzde9")]
    public double? FirKrediriskyuzde9 { get; set; }

    [Column("fir_krediriskneolacak9")]
    public byte? FirKrediriskneolacak9 { get; set; }

    [Column("fir_kredirisklimityuzde9hesap")]
    public byte? FirKredirisklimityuzde9hesap { get; set; }

    [Column("fir_kredirisklimityuzde9")]
    public double? FirKredirisklimityuzde9 { get; set; }

    [Column("fir_kredirisklimittipi9")]
    public byte? FirKredirisklimittipi9 { get; set; }

    [Column("fir_krediriskyuzde10")]
    public double? FirKrediriskyuzde10 { get; set; }

    [Column("fir_krediriskneolacak10")]
    public byte? FirKrediriskneolacak10 { get; set; }

    [Column("fir_kredirisklimityuzde10hesap")]
    public byte? FirKredirisklimityuzde10hesap { get; set; }

    [Column("fir_kredirisklimityuzde10")]
    public double? FirKredirisklimityuzde10 { get; set; }

    [Column("fir_kredirisklimittipi10")]
    public byte? FirKredirisklimittipi10 { get; set; }

    [Column("fir_def_kasakodu")]
    [StringLength(25)]
    public string? FirDefKasakodu { get; set; }

    [Column("fir_isletmetipi")]
    public byte? FirIsletmetipi { get; set; }

    [Column("fir_isletmefaliyetturu")]
    [StringLength(20)]
    public string? FirIsletmefaliyetturu { get; set; }

    [Column("fir_kdvucaylik")]
    public bool? FirKdvucaylik { get; set; }

    [Column("fir_EAN_kodu")]
    [StringLength(7)]
    public string? FirEANKodu { get; set; }

    [Column("fir_mukellefiyet")]
    public byte? FirMukellefiyet { get; set; }

    [Column("fir_kan_kab_ed_gider_kodu")]
    [StringLength(25)]
    public string? FirKanKabEdGiderKodu { get; set; }

    [Column("fir_web_sayfasi")]
    [StringLength(50)]
    public string? FirWebSayfasi { get; set; }

    [Column("fir_web_kullanici_adi")]
    [StringLength(20)]
    public string? FirWebKullaniciAdi { get; set; }

    [Column("fir_web_kullanici_sifresi")]
    [StringLength(127)]
    public string? FirWebKullaniciSifresi { get; set; }

    [Column("fir_web_musteri_no")]
    [StringLength(20)]
    public string? FirWebMusteriNo { get; set; }

    [Column("fir_OIVden_muaf")]
    public bool? FirOIVdenMuaf { get; set; }

    [Column("fir_maassistemikodu")]
    [StringLength(25)]
    public string? FirMaassistemikodu { get; set; }

    [Column("fir_genel_email")]
    [StringLength(80)]
    public string? FirGenelEmail { get; set; }

    [Column("fir_nace_kodu")]
    [StringLength(25)]
    public string? FirNaceKodu { get; set; }

    [Column("fir_mali_muhur_sifre")]
    [StringLength(127)]
    public string? FirMaliMuhurSifre { get; set; }

    [Column("fir_zaman_damgasi_kullanici")]
    public int? FirZamanDamgasiKullanici { get; set; }

    [Column("fir_zaman_damgasi_sifre")]
    [StringLength(127)]
    public string? FirZamanDamgasiSifre { get; set; }

    [Column("fir_edefter_sube_adi")]
    [StringLength(127)]
    public string? FirEdefterSubeAdi { get; set; }

    [Column("fir_edefter_sube_no")]
    public int? FirEdefterSubeNo { get; set; }

    [Column("fir_edefter_baslangic")]
    public DateTime? FirEdefterBaslangic { get; set; }

    [Column("fir_edefter_max_boyut")]
    public int? FirEdefterMaxBoyut { get; set; }

    [Column("fir_edefter_doviz_tipi")]
    public byte? FirEdefterDovizTipi { get; set; }

    [Column("fir_edefter_aktif_grup")]
    public byte? FirEdefterAktifGrup { get; set; }

    [Column("fir_tuik_isyerikayitno")]
    [StringLength(20)]
    public string? FirTuikIsyerikayitno { get; set; }

    [Column("fir_efatura_baslangic")]
    public DateTime? FirEfaturaBaslangic { get; set; }

    [Column("fir_earsiv_baslangic")]
    public DateTime? FirEarsivBaslangic { get; set; }

    [Column("fir_KEP_adresi")]
    [StringLength(80)]
    public string? FirKEPAdresi { get; set; }

    [Column("fir_Ticaret_Sicil_Mudurlugu")]
    [StringLength(4)]
    public string? FirTicaretSicilMudurlugu { get; set; }

    [Column("fir_edefter_smm_kodu")]
    [StringLength(25)]
    public string? FirEdefterSmmKodu { get; set; }

    [Column("fir_edefter_ymm_kodu")]
    [StringLength(25)]
    public string? FirEdefterYmmKodu { get; set; }

    [Column("fir_edefter_nace_kodu")]
    [StringLength(80)]
    public string? FirEdefterNaceKodu { get; set; }

    [Column("fir_TasfiyeTarihi")]
    public DateTime? FirTasfiyeTarihi { get; set; }

    [Column("fir_muhasebe_yetkilisi")]
    [StringLength(25)]
    public string? FirMuhasebeYetkilisi { get; set; }

    [Column("fir_edefter_yetkilisi")]
    [StringLength(25)]
    public string? FirEdefterYetkilisi { get; set; }

    [Column("fir_mali_muhur_tipi")]
    public byte? FirMaliMuhurTipi { get; set; }

    [Column("fir_mali_muhur_surucusu")]
    [StringLength(127)]
    public string? FirMaliMuhurSurucusu { get; set; }

    [Column("fir_edefter_sube_defteri_mi")]
    public bool? FirEdefterSubeDefteriMi { get; set; }

    [Column("fir_mikro_web_servis_kodu")]
    [StringLength(40)]
    public string? FirMikroWebServisKodu { get; set; }

    [Column("fir_uyelik_hopi_firma_kodu")]
    [StringLength(40)]
    public string? FirUyelikHopiFirmaKodu { get; set; }

    [Column("fir_uyelik_hopi_kullanici")]
    [StringLength(40)]
    public string? FirUyelikHopiKullanici { get; set; }

    [Column("fir_uyelik_hopi_sifre")]
    [StringLength(127)]
    public string? FirUyelikHopiSifre { get; set; }

    [Column("fir_tasfiye_hali_firmasi_mi")]
    public bool? FirTasfiyeHaliFirmasiMi { get; set; }

    [Column("fir_smtp_host")]
    [StringLength(127)]
    public string? FirSmtpHost { get; set; }

    [Column("fir_smtp_port")]
    public int? FirSmtpPort { get; set; }

    [Column("fir_smtp_enable_ssl")]
    public bool? FirSmtpEnableSsl { get; set; }

    [Column("fir_smtp_username")]
    [StringLength(127)]
    public string? FirSmtpUsername { get; set; }

    [Column("fir_smtp_sifre")]
    [StringLength(127)]
    public string? FirSmtpSifre { get; set; }

    [Column("fir_BaslangicTarihiTipi")]
    public byte? FirBaslangicTarihiTipi { get; set; }

    [Column("fir_BitisTarihiTipi")]
    public byte? FirBitisTarihiTipi { get; set; }

    [Column("fir_VergiDetayTipi")]
    public byte? FirVergiDetayTipi { get; set; }

    [Column("fir_eFaturaMukellefiyetTipi")]
    public byte? FirEFaturaMukellefiyetTipi { get; set; }

    [Column("fir_eFaturaMukellefiyetKodu")]
    [StringLength(25)]
    public string? FirEFaturaMukellefiyetKodu { get; set; }
}
