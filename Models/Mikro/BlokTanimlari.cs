using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("blok_tanimlari")]
public class BlokTanimlari
{
    [Column("blok_Guid")]
    public Guid? BlokGuid { get; set; }

    [Column("blok_DBCno")]
    public short? BlokDBCno { get; set; }

    [Column("blok_SpecRECno")]
    public int? BlokSpecRECno { get; set; }

    [Column("blok_iptal")]
    public bool? BlokIptal { get; set; }

    [Column("blok_fileid")]
    public short? BlokFileid { get; set; }

    [Column("blok_hidden")]
    public bool? BlokHidden { get; set; }

    [Column("blok_kilitli")]
    public bool? BlokKilitli { get; set; }

    [Column("blok_degisti")]
    public bool? BlokDegisti { get; set; }

    [Column("blok_checksum")]
    public int? BlokChecksum { get; set; }

    [Column("blok_create_user")]
    public short? BlokCreateUser { get; set; }

    [Column("blok_create_date")]
    public DateTime? BlokCreateDate { get; set; }

    [Column("blok_lastup_user")]
    public short? BlokLastupUser { get; set; }

    [Column("blok_lastup_date")]
    public DateTime? BlokLastupDate { get; set; }

    [Column("blok_special1")]
    [StringLength(4)]
    public string? BlokSpecial1 { get; set; }

    [Column("blok_special2")]
    [StringLength(4)]
    public string? BlokSpecial2 { get; set; }

    [Column("blok_special3")]
    [StringLength(4)]
    public string? BlokSpecial3 { get; set; }

    [Column("blok_sitekod")]
    [StringLength(25)]
    public string? BlokSitekod { get; set; }

    [Column("blok_kod")]
    [StringLength(25)]
    public string? BlokKod { get; set; }

    [Column("blok_ismi")]
    [StringLength(50)]
    public string? BlokIsmi { get; set; }
}
