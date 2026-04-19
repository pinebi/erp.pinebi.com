using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kat_tanimlari")]
public class KatTanimlari
{
    [Column("kat_Guid")]
    public Guid? KatGuid { get; set; }

    [Column("kat_DBCno")]
    public short? KatDBCno { get; set; }

    [Column("kat_SpecRECno")]
    public int? KatSpecRECno { get; set; }

    [Column("kat_iptal")]
    public bool? KatIptal { get; set; }

    [Column("kat_fileid")]
    public short? KatFileid { get; set; }

    [Column("kat_hidden")]
    public bool? KatHidden { get; set; }

    [Column("kat_kilitli")]
    public bool? KatKilitli { get; set; }

    [Column("kat_degisti")]
    public bool? KatDegisti { get; set; }

    [Column("kat_checksum")]
    public int? KatChecksum { get; set; }

    [Column("kat_create_user")]
    public short? KatCreateUser { get; set; }

    [Column("kat_create_date")]
    public DateTime? KatCreateDate { get; set; }

    [Column("kat_lastup_user")]
    public short? KatLastupUser { get; set; }

    [Column("kat_lastup_date")]
    public DateTime? KatLastupDate { get; set; }

    [Column("kat_special1")]
    [StringLength(4)]
    public string? KatSpecial1 { get; set; }

    [Column("kat_special2")]
    [StringLength(4)]
    public string? KatSpecial2 { get; set; }

    [Column("kat_special3")]
    [StringLength(4)]
    public string? KatSpecial3 { get; set; }

    [Column("kat_sitekod")]
    [StringLength(25)]
    public string? KatSitekod { get; set; }

    [Column("kat_blokkod")]
    [StringLength(25)]
    public string? KatBlokkod { get; set; }

    [Column("kat_kod")]
    [StringLength(25)]
    public string? KatKod { get; set; }

    [Column("kat_ismi")]
    [StringLength(50)]
    public string? KatIsmi { get; set; }
}
