using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("gumruk_tanimlari")]
public class GumrukTanimlari
{
    [Column("gumruk_Guid")]
    public Guid? GumrukGuid { get; set; }

    [Column("gumruk_DBCno")]
    public short? GumrukDBCno { get; set; }

    [Column("gumruk_SpecRECNo")]
    public int? GumrukSpecRECNo { get; set; }

    [Column("gumruk_iptal")]
    public bool? GumrukIptal { get; set; }

    [Column("gumruk_fileid")]
    public short? GumrukFileid { get; set; }

    [Column("gumruk_hidden")]
    public bool? GumrukHidden { get; set; }

    [Column("gumruk_kilitli")]
    public bool? GumrukKilitli { get; set; }

    [Column("gumruk_degisti")]
    public bool? GumrukDegisti { get; set; }

    [Column("gumruk_CheckSum")]
    public int? GumrukCheckSum { get; set; }

    [Column("gumruk_create_user")]
    public short? GumrukCreateUser { get; set; }

    [Column("gumruk_create_date")]
    public DateTime? GumrukCreateDate { get; set; }

    [Column("gumruk_lastup_user")]
    public short? GumrukLastupUser { get; set; }

    [Column("gumruk_lastup_date")]
    public DateTime? GumrukLastupDate { get; set; }

    [Column("gumruk_special1")]
    [StringLength(4)]
    public string? GumrukSpecial1 { get; set; }

    [Column("gumruk_special2")]
    [StringLength(4)]
    public string? GumrukSpecial2 { get; set; }

    [Column("gumruk_special3")]
    [StringLength(4)]
    public string? GumrukSpecial3 { get; set; }

    [Column("gumruk_gumrukkodu")]
    [StringLength(4)]
    public string? GumrukGumrukkodu { get; set; }

    [Column("gumruk_gumrukadi")]
    [StringLength(40)]
    public string? GumrukGumrukadi { get; set; }

    [Column("gumruk_edikodu")]
    [StringLength(25)]
    public string? GumrukEdikodu { get; set; }
}
