using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("meslek_tanimlari")]
public class MeslekTanimlari
{
    [Column("mslk_Guid")]
    public Guid? MslkGuid { get; set; }

    [Column("mslk_DBCno")]
    public short? MslkDBCno { get; set; }

    [Column("mslk_SpecRECno")]
    public int? MslkSpecRECno { get; set; }

    [Column("mslk_iptal")]
    public bool? MslkIptal { get; set; }

    [Column("mslk_fileid")]
    public short? MslkFileid { get; set; }

    [Column("mslk_hidden")]
    public bool? MslkHidden { get; set; }

    [Column("mslk_kilitli")]
    public bool? MslkKilitli { get; set; }

    [Column("mslk_degisti")]
    public bool? MslkDegisti { get; set; }

    [Column("mslk_checksum")]
    public int? MslkChecksum { get; set; }

    [Column("mslk_create_user")]
    public short? MslkCreateUser { get; set; }

    [Column("mslk_create_date")]
    public DateTime? MslkCreateDate { get; set; }

    [Column("mslk_lastup_user")]
    public short? MslkLastupUser { get; set; }

    [Column("mslk_lastup_date")]
    public DateTime? MslkLastupDate { get; set; }

    [Column("mslk_special1")]
    [StringLength(4)]
    public string? MslkSpecial1 { get; set; }

    [Column("mslk_special2")]
    [StringLength(4)]
    public string? MslkSpecial2 { get; set; }

    [Column("mslk_special3")]
    [StringLength(4)]
    public string? MslkSpecial3 { get; set; }

    [Column("mslk_kod")]
    [StringLength(25)]
    public string? MslkKod { get; set; }

    [Column("mslk_ismi")]
    [StringLength(127)]
    public string? MslkIsmi { get; set; }
}
