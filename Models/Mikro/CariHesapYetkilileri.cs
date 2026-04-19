using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_yetkilileri")]
public class CariHesapYetkilileri
{
    [Column("mye_Guid")]
    public Guid? MyeGuid { get; set; }

    [Column("mye_DBCno")]
    public short? MyeDBCno { get; set; }

    [Column("mye_SpecRECno")]
    public int? MyeSpecRECno { get; set; }

    [Column("mye_iptal")]
    public bool? MyeIptal { get; set; }

    [Column("mye_fileid")]
    public short? MyeFileid { get; set; }

    [Column("mye_hidden")]
    public bool? MyeHidden { get; set; }

    [Column("mye_kilitli")]
    public bool? MyeKilitli { get; set; }

    [Column("mye_degisti")]
    public bool? MyeDegisti { get; set; }

    [Column("mye_checksum")]
    public int? MyeChecksum { get; set; }

    [Column("mye_create_user")]
    public short? MyeCreateUser { get; set; }

    [Column("mye_create_date")]
    public DateTime? MyeCreateDate { get; set; }

    [Column("mye_lastup_user")]
    public short? MyeLastupUser { get; set; }

    [Column("mye_lastup_date")]
    public DateTime? MyeLastupDate { get; set; }

    [Column("mye_special1")]
    [StringLength(4)]
    public string? MyeSpecial1 { get; set; }

    [Column("mye_special2")]
    [StringLength(4)]
    public string? MyeSpecial2 { get; set; }

    [Column("mye_special3")]
    [StringLength(4)]
    public string? MyeSpecial3 { get; set; }

    [Column("mye_cari_kod")]
    [StringLength(25)]
    public string? MyeCariKod { get; set; }

    [Column("mye_adres_no")]
    public int? MyeAdresNo { get; set; }

    [Column("mye_isim")]
    [StringLength(30)]
    public string? MyeIsim { get; set; }

    [Column("mye_soyisim")]
    [StringLength(30)]
    public string? MyeSoyisim { get; set; }

    [Column("mye_dogum_tarihi")]
    public DateTime? MyeDogumTarihi { get; set; }

    [Column("mye_evlilik_tarih")]
    public DateTime? MyeEvlilikTarih { get; set; }

    [Column("mye_es_isim")]
    [StringLength(30)]
    public string? MyeEsIsim { get; set; }

    [Column("mye_es_dogum_tarih")]
    public DateTime? MyeEsDogumTarih { get; set; }

    [Column("mye_unvan")]
    public byte? MyeUnvan { get; set; }

    [Column("mye_hitap")]
    public byte? MyeHitap { get; set; }

    [Column("mye_hisse")]
    public byte? MyeHisse { get; set; }

    [Column("mye_tahsil")]
    public byte? MyeTahsil { get; set; }

    [Column("mye_dahili_telno")]
    [StringLength(5)]
    public string? MyeDahiliTelno { get; set; }

    [Column("mye_email_adres")]
    [StringLength(50)]
    public string? MyeEmailAdres { get; set; }

    [Column("mye_cep_telno")]
    [StringLength(17)]
    public string? MyeCepTelno { get; set; }

    [Column("mye_tc_kimlikno")]
    [StringLength(20)]
    public string? MyeTcKimlikno { get; set; }

    [Column("mye_vergi_dairesi")]
    [StringLength(20)]
    public string? MyeVergiDairesi { get; set; }

    [Column("mye_vergi_kimlikno")]
    [StringLength(20)]
    public string? MyeVergiKimlikno { get; set; }

    [Column("mye_dogum_yeri")]
    [StringLength(30)]
    public string? MyeDogumYeri { get; set; }

    [Column("mye_ev_cadde")]
    [StringLength(50)]
    public string? MyeEvCadde { get; set; }

    [Column("mye_ev_mahalle")]
    [StringLength(50)]
    public string? MyeEvMahalle { get; set; }

    [Column("mye_ev_sokak")]
    [StringLength(50)]
    public string? MyeEvSokak { get; set; }

    [Column("mye_ev_Semt")]
    [StringLength(25)]
    public string? MyeEvSemt { get; set; }

    [Column("mye_ev_Apt_No")]
    [StringLength(10)]
    public string? MyeEvAptNo { get; set; }

    [Column("mye_ev_Daire_No")]
    [StringLength(10)]
    public string? MyeEvDaireNo { get; set; }

    [Column("mye_ev_posta_kodu")]
    [StringLength(8)]
    public string? MyeEvPostaKodu { get; set; }

    [Column("mye_ev_ilce")]
    [StringLength(50)]
    public string? MyeEvIlce { get; set; }

    [Column("mye_ev_il")]
    [StringLength(50)]
    public string? MyeEvIl { get; set; }

    [Column("mye_ev_ulke")]
    [StringLength(50)]
    public string? MyeEvUlke { get; set; }

    [Column("mye_ev_adres_kodu")]
    [StringLength(10)]
    public string? MyeEvAdresKodu { get; set; }

    [Column("mye_is_telno")]
    [StringLength(17)]
    public string? MyeIsTelno { get; set; }

    [Column("mye_ev_telno")]
    [StringLength(17)]
    public string? MyeEvTelno { get; set; }

    [Column("mye_KEP_adresi")]
    [StringLength(80)]
    public string? MyeKEPAdresi { get; set; }

    [Column("mye_mutabakat_yetkilisi_fl")]
    public bool? MyeMutabakatYetkilisiFl { get; set; }
}
