using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_tanimlari")]
public class PersonelKadroTanimlari
{
    [Column("kdr_Guid")]
    public Guid? KdrGuid { get; set; }

    [Column("kdr_DBCno")]
    public short? KdrDBCno { get; set; }

    [Column("kdr_SpecRECno")]
    public int? KdrSpecRECno { get; set; }

    [Column("kdr_iptal")]
    public bool? KdrIptal { get; set; }

    [Column("kdr_fileid")]
    public short? KdrFileid { get; set; }

    [Column("kdr_hidden")]
    public bool? KdrHidden { get; set; }

    [Column("kdr_kilitli")]
    public bool? KdrKilitli { get; set; }

    [Column("kdr_degisti")]
    public bool? KdrDegisti { get; set; }

    [Column("kdr_checksum")]
    public int? KdrChecksum { get; set; }

    [Column("kdr_create_user")]
    public short? KdrCreateUser { get; set; }

    [Column("kdr_create_date")]
    public DateTime? KdrCreateDate { get; set; }

    [Column("kdr_lastup_user")]
    public short? KdrLastupUser { get; set; }

    [Column("kdr_lastup_date")]
    public DateTime? KdrLastupDate { get; set; }

    [Column("kdr_special1")]
    [StringLength(4)]
    public string? KdrSpecial1 { get; set; }

    [Column("kdr_special2")]
    [StringLength(4)]
    public string? KdrSpecial2 { get; set; }

    [Column("kdr_special3")]
    [StringLength(4)]
    public string? KdrSpecial3 { get; set; }

    [Column("kdr_kod")]
    [StringLength(25)]
    public string? KdrKod { get; set; }

    [Column("kdr_aciklama")]
    [StringLength(50)]
    public string? KdrAciklama { get; set; }

    [Column("kdr_rutbe")]
    [StringLength(50)]
    public string? KdrRutbe { get; set; }

    [Column("kdr_kadrosayisi")]
    public int? KdrKadrosayisi { get; set; }

    [Column("kdr_bagli_idari_amir")]
    [StringLength(25)]
    public string? KdrBagliIdariAmir { get; set; }

    [Column("kdr_bagli_teknik_amir")]
    [StringLength(25)]
    public string? KdrBagliTeknikAmir { get; set; }

    [Column("kdr_minimum_egitim")]
    public byte? KdrMinimumEgitim { get; set; }

    [Column("kdr_hedef_kadro1")]
    [StringLength(25)]
    public string? KdrHedefKadro1 { get; set; }

    [Column("kdr_hedef_kadro2")]
    [StringLength(25)]
    public string? KdrHedefKadro2 { get; set; }

    [Column("kdr_hedef_kadro3")]
    [StringLength(25)]
    public string? KdrHedefKadro3 { get; set; }

    [Column("kdr_gorev_tanimi")]
    [StringLength(80)]
    public string? KdrGorevTanimi { get; set; }

    [Column("kdr_sorumluluk_tanimi")]
    [StringLength(120)]
    public string? KdrSorumlulukTanimi { get; set; }

    [Column("kdr_semada_gosterme")]
    public bool? KdrSemadaGosterme { get; set; }

    [Column("kdr_min_ucret")]
    public double? KdrMinUcret { get; set; }

    [Column("kdr_max_ucret")]
    public double? KdrMaxUcret { get; set; }

    [Column("kdr_ucret_dcinsi")]
    public byte? KdrUcretDcinsi { get; set; }

    [Column("kdr_unvan_kodu")]
    [StringLength(25)]
    public string? KdrUnvanKodu { get; set; }

    [Column("kdr_gorev_kodu")]
    [StringLength(25)]
    public string? KdrGorevKodu { get; set; }

    [Column("kdr_raporlama_yap_kadro_kodu")]
    [StringLength(25)]
    public string? KdrRaporlamaYapKadroKodu { get; set; }

    [Column("kdr_vekalet_kadro_kodu")]
    [StringLength(25)]
    public string? KdrVekaletKadroKodu { get; set; }
}
