using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("sikayet_tanimlari")]
public class SikayetTanimlari
{
    [Column("skyt_Guid")]
    public Guid? SkytGuid { get; set; }

    [Column("skyt_DBCno")]
    public short? SkytDBCno { get; set; }

    [Column("skyt_SpecRECno")]
    public int? SkytSpecRECno { get; set; }

    [Column("skyt_iptal")]
    public bool? SkytIptal { get; set; }

    [Column("skyt_fileid")]
    public short? SkytFileid { get; set; }

    [Column("skyt_hidden")]
    public bool? SkytHidden { get; set; }

    [Column("skyt_kilitli")]
    public bool? SkytKilitli { get; set; }

    [Column("skyt_degisti")]
    public bool? SkytDegisti { get; set; }

    [Column("skyt_checksum")]
    public int? SkytChecksum { get; set; }

    [Column("skyt_create_user")]
    public short? SkytCreateUser { get; set; }

    [Column("skyt_create_date")]
    public DateTime? SkytCreateDate { get; set; }

    [Column("skyt_lastup_user")]
    public short? SkytLastupUser { get; set; }

    [Column("skyt_lastup_date")]
    public DateTime? SkytLastupDate { get; set; }

    [Column("skyt_special1")]
    [StringLength(4)]
    public string? SkytSpecial1 { get; set; }

    [Column("skyt_special2")]
    [StringLength(4)]
    public string? SkytSpecial2 { get; set; }

    [Column("skyt_special3")]
    [StringLength(4)]
    public string? SkytSpecial3 { get; set; }

    [Column("skyt_kod")]
    [StringLength(25)]
    public string? SkytKod { get; set; }

    [Column("skyt_isim")]
    [StringLength(50)]
    public string? SkytIsim { get; set; }

    [Column("skyt_personel_kod")]
    [StringLength(25)]
    public string? SkytPersonelKod { get; set; }
}
