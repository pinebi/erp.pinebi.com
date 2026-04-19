using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_ssk_tanimlari")]
public class PersonelSskTanimlari
{
    [Column("ssk_Guid")]
    public Guid? SskGuid { get; set; }

    [Column("ssk_DBCno")]
    public short? SskDBCno { get; set; }

    [Column("ssk_SpecRECno")]
    public int? SskSpecRECno { get; set; }

    [Column("ssk_iptal")]
    public bool? SskIptal { get; set; }

    [Column("ssk_fileid")]
    public short? SskFileid { get; set; }

    [Column("ssk_hidden")]
    public bool? SskHidden { get; set; }

    [Column("ssk_kilitli")]
    public bool? SskKilitli { get; set; }

    [Column("ssk_degisti")]
    public bool? SskDegisti { get; set; }

    [Column("ssk_checksum")]
    public int? SskChecksum { get; set; }

    [Column("ssk_create_user")]
    public short? SskCreateUser { get; set; }

    [Column("ssk_create_date")]
    public DateTime? SskCreateDate { get; set; }

    [Column("ssk_lastup_user")]
    public short? SskLastupUser { get; set; }

    [Column("ssk_lastup_date")]
    public DateTime? SskLastupDate { get; set; }

    [Column("ssk_special1")]
    [StringLength(4)]
    public string? SskSpecial1 { get; set; }

    [Column("ssk_special2")]
    [StringLength(4)]
    public string? SskSpecial2 { get; set; }

    [Column("ssk_special3")]
    [StringLength(4)]
    public string? SskSpecial3 { get; set; }

    [Column("ssk_Sira_No")]
    public int? SskSiraNo { get; set; }

    [Column("ssk_ismi")]
    [StringLength(25)]
    public string? SskIsmi { get; set; }

    [Column("ssk_TehlikeDerecesi")]
    public byte? SskTehlikeDerecesi { get; set; }

    [Column("ssk_KazaYuzdesi")]
    public double? SskKazaYuzdesi { get; set; }

    [Column("ssk_subekodu")]
    [StringLength(2)]
    public string? SskSubekodu { get; set; }

    [Column("ssk_BolCalDosNo")]
    [StringLength(20)]
    public string? SskBolCalDosNo { get; set; }

    [Column("ssk_cadde")]
    [StringLength(50)]
    public string? SskCadde { get; set; }

    [Column("ssk_mahalle")]
    [StringLength(50)]
    public string? SskMahalle { get; set; }

    [Column("ssk_sokak")]
    [StringLength(50)]
    public string? SskSokak { get; set; }

    [Column("ssk_Adr_Semt")]
    [StringLength(25)]
    public string? SskAdrSemt { get; set; }

    [Column("ssk_Apt_No")]
    [StringLength(10)]
    public string? SskAptNo { get; set; }

    [Column("ssk_Daire_No")]
    [StringLength(10)]
    public string? SskDaireNo { get; set; }

    [Column("ssk_posta_kodu")]
    [StringLength(8)]
    public string? SskPostaKodu { get; set; }

    [Column("ssk_ilce")]
    [StringLength(50)]
    public string? SskIlce { get; set; }

    [Column("ssk_il")]
    [StringLength(50)]
    public string? SskIl { get; set; }

    [Column("ssk_ulke")]
    [StringLength(50)]
    public string? SskUlke { get; set; }

    [Column("ssk_adres_kodu")]
    [StringLength(10)]
    public string? SskAdresKodu { get; set; }

    [Column("ssk_iysinifi")]
    public byte? SskIysinifi { get; set; }

    [Column("ssk_iykapino")]
    [StringLength(5)]
    public string? SskIykapino { get; set; }

    [Column("ssk_maasbankakodu")]
    [StringLength(25)]
    public string? SskMaasbankakodu { get; set; }

    [Column("ssk_sskno_Mahiyet")]
    [StringLength(1)]
    public string? SskSsknoMahiyet { get; set; }

    [Column("ssk_sskno_Iskolu")]
    [StringLength(4)]
    public string? SskSsknoIskolu { get; set; }

    [Column("ssk_sskno_SubeKodu")]
    [StringLength(2)]
    public string? SskSsknoSubeKodu { get; set; }

    [Column("ssk_sskno_TehlikeKodu")]
    [StringLength(2)]
    public string? SskSsknoTehlikeKodu { get; set; }

    [Column("ssk_sskno_SiraNo")]
    [StringLength(7)]
    public string? SskSsknoSiraNo { get; set; }

    [Column("ssk_sskno_IlKodu")]
    [StringLength(3)]
    public string? SskSsknoIlKodu { get; set; }

    [Column("ssk_sskno_Ilce")]
    [StringLength(2)]
    public string? SskSsknoIlce { get; set; }

    [Column("ssk_sskno_Kontrol_No")]
    [StringLength(2)]
    public string? SskSsknoKontrolNo { get; set; }

    [Column("ssk_AraciKodu")]
    [StringLength(3)]
    public string? SskAraciKodu { get; set; }

    [Column("ssk_BolgeMudurlukNo")]
    [StringLength(3)]
    public string? SskBolgeMudurlukNo { get; set; }

    [Column("ssk_Iskur_uid")]
    public Guid? SskIskurUid { get; set; }

    [Column("ssk_Semt")]
    [StringLength(25)]
    public string? SskSemt { get; set; }

    [Column("ssk_N_SSK_Yuzde")]
    public double? SskNSSKYuzde { get; set; }

    [Column("ssk_E_SSK_Yuzde")]
    public double? SskESSKYuzde { get; set; }

    [Column("ssk_C_SSK_Yuzde")]
    public double? SskCSSKYuzde { get; set; }

    [Column("ssk_Y_SSK_Yuzde")]
    public double? SskYSSKYuzde { get; set; }

    [Column("ssk_Ana_Sig")]
    public double? SskAnaSig { get; set; }

    [Column("ssk_N_Hast_Sig")]
    public double? SskNHastSig { get; set; }

    [Column("ssk_C_Hast_Sig")]
    public double? SskCHastSig { get; set; }

    [Column("ssk_Yas_Ol_Hast_Sig")]
    public double? SskYasOlHastSig { get; set; }

    [Column("ssk_SGDP_Orani")]
    public double? SskSGDPOrani { get; set; }

    [Column("ssk_Calisma_Kodu")]
    [StringLength(25)]
    public string? SskCalismaKodu { get; set; }

    [Column("ssk_FirmaUnvani")]
    [StringLength(127)]
    public string? SskFirmaUnvani { get; set; }

    [Column("ssk_FirmaUnvani2")]
    [StringLength(127)]
    public string? SskFirmaUnvani2 { get; set; }

    [Column("ssk_ebildirge_username")]
    [StringLength(11)]
    public string? SskEbildirgeUsername { get; set; }

    [Column("ssk_ebildirge_isyerikod")]
    [StringLength(4)]
    public string? SskEbildirgeIsyerikod { get; set; }

    [Column("ssk_ebildirge_password")]
    [StringLength(127)]
    public string? SskEbildirgePassword { get; set; }

    [Column("ssk_ebildirge_isyerisifre")]
    [StringLength(127)]
    public string? SskEbildirgeIsyerisifre { get; set; }

    [Column("ssk_yasolum_itibarihizmet")]
    public double? SskYasolumItibarihizmet { get; set; }

    [Column("ssk_isverentipi")]
    public byte? SskIsverentipi { get; set; }

    [Column("ssk_genel_saglik_sigortasi")]
    public double? SskGenelSaglikSigortasi { get; set; }

    [Column("ssk_malulluk_muafiyet")]
    public double? SskMalullukMuafiyet { get; set; }

    [Column("ssk_5225BelgeTuru")]
    public byte? Ssk5225BelgeTuru { get; set; }

    [Column("ssk_5225BelgeTarihi")]
    [StringLength(50)]
    public string? Ssk5225BelgeTarihi { get; set; }

    [Column("ssk_5225BelgeSayisi")]
    [StringLength(25)]
    public string? Ssk5225BelgeSayisi { get; set; }

    [Column("ssk_GVK80BelgeTarih")]
    [StringLength(50)]
    public string? SskGVK80BelgeTarih { get; set; }

    [Column("ssk_GVK80BelgeNo")]
    [StringLength(10)]
    public string? SskGVK80BelgeNo { get; set; }

    [Column("ssk_iskolukodu")]
    public byte? SskIskolukodu { get; set; }

    [Column("ssk_Pasif_fl")]
    public bool? SskPasifFl { get; set; }

    [Column("ssk_AcilisTarihi")]
    public DateTime? SskAcilisTarihi { get; set; }

    [Column("ssk_KapanisTarihi")]
    public DateTime? SskKapanisTarihi { get; set; }

    [Column("ssk_muhtasarisyeri_adi")]
    [StringLength(50)]
    public string? SskMuhtasarisyeriAdi { get; set; }

    [Column("ssk_muhtasarisyeri_turu")]
    public byte? SskMuhtasarisyeriTuru { get; set; }

    [Column("ssk_muhtasarisyeri_kodu")]
    [StringLength(10)]
    public string? SskMuhtasarisyeriKodu { get; set; }

    [Column("ssk_muhtasarisyeri_mulkiyet")]
    public byte? SskMuhtasarisyeriMulkiyet { get; set; }

    [Column("ssk_Ticaret_Sicil_No")]
    [StringLength(25)]
    public string? SskTicaretSicilNo { get; set; }

    [Column("ssk_Ticaret_Sicil_Mudurlugu")]
    [StringLength(4)]
    public string? SskTicaretSicilMudurlugu { get; set; }

    [Column("ssk_Nace_Kodu")]
    [StringLength(25)]
    public string? SskNaceKodu { get; set; }

    [Column("ssk_FirmaNo")]
    public int? SskFirmaNo { get; set; }

    [Column("ssk_SubeNo")]
    public int? SskSubeNo { get; set; }

    [Column("ssk_gecici_madde_17_gunluk_destek")]
    public double? SskGeciciMadde17GunlukDestek { get; set; }
}
