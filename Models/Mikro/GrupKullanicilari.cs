using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("grup_kullanicilari")]
public class GrupKullanicilari
{
    [Column("gk_Guid")]
    public Guid? GkGuid { get; set; }

    [Column("gk_DBCno")]
    public short? GkDBCno { get; set; }

    [Column("gk_SpecRECno")]
    public int? GkSpecRECno { get; set; }

    [Column("gk_iptal")]
    public bool? GkIptal { get; set; }

    [Column("gk_fileid")]
    public short? GkFileid { get; set; }

    [Column("gk_hidden")]
    public bool? GkHidden { get; set; }

    [Column("gk_kilitli")]
    public bool? GkKilitli { get; set; }

    [Column("gk_degisti")]
    public bool? GkDegisti { get; set; }

    [Column("gk_checksum")]
    public int? GkChecksum { get; set; }

    [Column("gk_create_user")]
    public short? GkCreateUser { get; set; }

    [Column("gk_create_date")]
    public DateTime? GkCreateDate { get; set; }

    [Column("gk_lastup_user")]
    public short? GkLastupUser { get; set; }

    [Column("gk_lastup_date")]
    public DateTime? GkLastupDate { get; set; }

    [Column("gk_special1")]
    [StringLength(4)]
    public string? GkSpecial1 { get; set; }

    [Column("gk_special2")]
    [StringLength(4)]
    public string? GkSpecial2 { get; set; }

    [Column("gk_special3")]
    [StringLength(4)]
    public string? GkSpecial3 { get; set; }

    [Column("gk_groupno")]
    public int? GkGroupno { get; set; }

    [Column("gk_userno")]
    public int? GkUserno { get; set; }
}
