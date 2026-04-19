using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_adresleri")]
public class CariHesapAdresleri
{
    [Column("adr_Guid")]
    public Guid? AdrGuid { get; set; }

    [Column("adr_DBCno")]
    public short? AdrDBCno { get; set; }

    [Column("adr_SpecRECno")]
    public int? AdrSpecRECno { get; set; }

    [Column("adr_iptal")]
    public bool? AdrIptal { get; set; }

    [Column("adr_fileid")]
    public short? AdrFileid { get; set; }

    [Column("adr_hidden")]
    public bool? AdrHidden { get; set; }

    [Column("adr_kilitli")]
    public bool? AdrKilitli { get; set; }

    [Column("adr_degisti")]
    public bool? AdrDegisti { get; set; }

    [Column("adr_checksum")]
    public int? AdrChecksum { get; set; }

    [Column("adr_create_user")]
    public short? AdrCreateUser { get; set; }

    [Column("adr_create_date")]
    public DateTime? AdrCreateDate { get; set; }

    [Column("adr_lastup_user")]
    public short? AdrLastupUser { get; set; }

    [Column("adr_lastup_date")]
    public DateTime? AdrLastupDate { get; set; }

    [Column("adr_special1")]
    [StringLength(4)]
    public string? AdrSpecial1 { get; set; }

    [Column("adr_special2")]
    [StringLength(4)]
    public string? AdrSpecial2 { get; set; }

    [Column("adr_special3")]
    [StringLength(4)]
    public string? AdrSpecial3 { get; set; }

    [Column("adr_cari_kod")]
    [StringLength(25)]
    public string? AdrCariKod { get; set; }

    [Column("adr_adres_no")]
    public int? AdrAdresNo { get; set; }

    [Column("adr_aprint_fl")]
    public bool? AdrAprintFl { get; set; }

    [Column("adr_cadde")]
    [StringLength(50)]
    public string? AdrCadde { get; set; }

    [Column("adr_mahalle")]
    [StringLength(50)]
    public string? AdrMahalle { get; set; }

    [Column("adr_sokak")]
    [StringLength(50)]
    public string? AdrSokak { get; set; }

    [Column("adr_Semt")]
    [StringLength(25)]
    public string? AdrSemt { get; set; }

    [Column("adr_Apt_No")]
    [StringLength(10)]
    public string? AdrAptNo { get; set; }

    [Column("adr_Daire_No")]
    [StringLength(10)]
    public string? AdrDaireNo { get; set; }

    [Column("adr_posta_kodu")]
    [StringLength(8)]
    public string? AdrPostaKodu { get; set; }

    [Column("adr_ilce")]
    [StringLength(50)]
    public string? AdrIlce { get; set; }

    [Column("adr_il")]
    [StringLength(50)]
    public string? AdrIl { get; set; }

    [Column("adr_ulke")]
    [StringLength(50)]
    public string? AdrUlke { get; set; }

    [Column("adr_Adres_kodu")]
    [StringLength(10)]
    public string? AdrAdresKodu { get; set; }

    [Column("adr_tel_ulke_kodu")]
    [StringLength(5)]
    public string? AdrTelUlkeKodu { get; set; }

    [Column("adr_tel_bolge_kodu")]
    [StringLength(5)]
    public string? AdrTelBolgeKodu { get; set; }

    [Column("adr_tel_no1")]
    [StringLength(10)]
    public string? AdrTelNo1 { get; set; }

    [Column("adr_tel_no2")]
    [StringLength(10)]
    public string? AdrTelNo2 { get; set; }

    [Column("adr_tel_faxno")]
    [StringLength(10)]
    public string? AdrTelFaxno { get; set; }

    [Column("adr_tel_modem")]
    [StringLength(10)]
    public string? AdrTelModem { get; set; }

    [Column("adr_yon_kodu")]
    [StringLength(4)]
    public string? AdrYonKodu { get; set; }

    [Column("adr_uzaklik_kodu")]
    public short? AdrUzaklikKodu { get; set; }

    [Column("adr_temsilci_kodu")]
    [StringLength(25)]
    public string? AdrTemsilciKodu { get; set; }

    [Column("adr_ozel_not")]
    [StringLength(50)]
    public string? AdrOzelNot { get; set; }

    [Column("adr_ziyaretperyodu")]
    public byte? AdrZiyaretperyodu { get; set; }

    [Column("adr_ziyaretgunu")]
    public double? AdrZiyaretgunu { get; set; }

    [Column("adr_gps_enlem")]
    public double? AdrGpsEnlem { get; set; }

    [Column("adr_gps_boylam")]
    public double? AdrGpsBoylam { get; set; }

    [Column("adr_ziyarethaftasi")]
    public byte? AdrZiyarethaftasi { get; set; }

    [Column("adr_ziygunu2_1")]
    public bool? AdrZiygunu21 { get; set; }

    [Column("adr_ziygunu2_2")]
    public bool? AdrZiygunu22 { get; set; }

    [Column("adr_ziygunu2_3")]
    public bool? AdrZiygunu23 { get; set; }

    [Column("adr_ziygunu2_4")]
    public bool? AdrZiygunu24 { get; set; }

    [Column("adr_ziygunu2_5")]
    public bool? AdrZiygunu25 { get; set; }

    [Column("adr_ziygunu2_6")]
    public bool? AdrZiygunu26 { get; set; }

    [Column("adr_ziygunu2_7")]
    public bool? AdrZiygunu27 { get; set; }

    [Column("adr_efatura_alias")]
    [StringLength(120)]
    public string? AdrEfaturaAlias { get; set; }

    [Column("adr_eirsaliye_alias")]
    [StringLength(120)]
    public string? AdrEirsaliyeAlias { get; set; }
}
