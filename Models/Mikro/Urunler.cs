using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("urunler")]
public class Urunler
{
    [Column("uru_Guid")]
    public Guid? UruGuid { get; set; }

    [Column("uru_DBCno")]
    public short? UruDBCno { get; set; }

    [Column("uru_SpecRECno")]
    public int? UruSpecRECno { get; set; }

    [Column("uru_iptal")]
    public bool? UruIptal { get; set; }

    [Column("uru_fileid")]
    public short? UruFileid { get; set; }

    [Column("uru_hidden")]
    public bool? UruHidden { get; set; }

    [Column("uru_kilitli")]
    public bool? UruKilitli { get; set; }

    [Column("uru_degisti")]
    public bool? UruDegisti { get; set; }

    [Column("uru_checksum")]
    public int? UruChecksum { get; set; }

    [Column("uru_create_user")]
    public short? UruCreateUser { get; set; }

    [Column("uru_create_date")]
    public DateTime? UruCreateDate { get; set; }

    [Column("uru_lastup_user")]
    public short? UruLastupUser { get; set; }

    [Column("uru_lastup_date")]
    public DateTime? UruLastupDate { get; set; }

    [Column("uru_special1")]
    [StringLength(4)]
    public string? UruSpecial1 { get; set; }

    [Column("uru_special2")]
    [StringLength(4)]
    public string? UruSpecial2 { get; set; }

    [Column("uru_special3")]
    [StringLength(4)]
    public string? UruSpecial3 { get; set; }

    [Column("uru_stok_kod")]
    [StringLength(25)]
    public string? UruStokKod { get; set; }

    [Column("uru_gider1")]
    public double? UruGider1 { get; set; }

    [Column("uru_gider2")]
    public double? UruGider2 { get; set; }

    [Column("uru_gider3")]
    public double? UruGider3 { get; set; }

    [Column("uru_gider4")]
    public double? UruGider4 { get; set; }

    [Column("uru_gider5")]
    public double? UruGider5 { get; set; }

    [Column("uru_max_fire_yuz")]
    public double? UruMaxFireYuz { get; set; }

    [Column("uru_min_fire_yuz")]
    public double? UruMinFireYuz { get; set; }

    [Column("uru_fasonmaliyet")]
    public double? UruFasonmaliyet { get; set; }

    [Column("uru_partimiktari")]
    public double? UruPartimiktari { get; set; }

    [Column("uru_isemriID")]
    [StringLength(1)]
    public string? UruIsemriID { get; set; }

    [Column("uru_uretimortakcarpani")]
    public double? UruUretimortakcarpani { get; set; }

    [Column("uru_uretimsekli")]
    public byte? UruUretimsekli { get; set; }

    [Column("uru_formdosyaadi")]
    [StringLength(50)]
    public string? UruFormdosyaadi { get; set; }

    [Column("uru_gider6")]
    public double? UruGider6 { get; set; }

    [Column("uru_gider7")]
    public double? UruGider7 { get; set; }

    [Column("uru_gider8")]
    public double? UruGider8 { get; set; }

    [Column("uru_gider9")]
    public double? UruGider9 { get; set; }

    [Column("uru_gider10")]
    public double? UruGider10 { get; set; }

    [Column("uru_ozel_tipi")]
    public byte? UruOzelTipi { get; set; }

    [Column("uru_sabitmlyt_anauruncarpan")]
    public double? UruSabitmlytAnauruncarpan { get; set; }

    [Column("uru_masterrecete")]
    [StringLength(25)]
    public string? UruMasterrecete { get; set; }

    [Column("uru_SorumlulukMerkezi")]
    [StringLength(25)]
    public string? UruSorumlulukMerkezi { get; set; }

    [Column("uru_varsayilanismerkezi")]
    [StringLength(25)]
    public string? UruVarsayilanismerkezi { get; set; }

    [Column("uru_Muhgrup_kodu")]
    [StringLength(25)]
    public string? UruMuhgrupKodu { get; set; }

    [Column("uru_masterkalip_kodu")]
    [StringLength(25)]
    public string? UruMasterkalipKodu { get; set; }

    [Column("uru_recete_ismi1")]
    [StringLength(15)]
    public string? UruReceteIsmi1 { get; set; }

    [Column("uru_recete_ismi2")]
    [StringLength(15)]
    public string? UruReceteIsmi2 { get; set; }

    [Column("uru_recete_ismi3")]
    [StringLength(15)]
    public string? UruReceteIsmi3 { get; set; }

    [Column("uru_recete_ismi4")]
    [StringLength(15)]
    public string? UruReceteIsmi4 { get; set; }

    [Column("uru_recete_ismi5")]
    [StringLength(15)]
    public string? UruReceteIsmi5 { get; set; }

    [Column("uru_varsayilan_recete_tanim_kodu")]
    [StringLength(25)]
    public string? UruVarsayilanReceteTanimKodu { get; set; }

    [Column("uru_varsayilan_recete_cins")]
    public byte? UruVarsayilanReceteCins { get; set; }
}
