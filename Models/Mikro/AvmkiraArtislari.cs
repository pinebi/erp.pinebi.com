using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmkira_artislari")]
public class AvmkiraArtislari
{
    [Column("AvmKA_Guid")]
    public Guid? AvmKAGuid { get; set; }

    [Column("AvmKA_DBCno")]
    public short? AvmKADBCno { get; set; }

    [Column("AvmKA_SpecRECno")]
    public int? AvmKASpecRECno { get; set; }

    [Column("AvmKA_iptal")]
    public bool? AvmKAIptal { get; set; }

    [Column("AvmKA_fileid")]
    public short? AvmKAFileid { get; set; }

    [Column("AvmKA_hidden")]
    public bool? AvmKAHidden { get; set; }

    [Column("AvmKA_kilitli")]
    public bool? AvmKAKilitli { get; set; }

    [Column("AvmKA_degisti")]
    public bool? AvmKADegisti { get; set; }

    [Column("AvmKA_checksum")]
    public int? AvmKAChecksum { get; set; }

    [Column("AvmKA_create_user")]
    public short? AvmKACreateUser { get; set; }

    [Column("AvmKA_create_date")]
    public DateTime? AvmKACreateDate { get; set; }

    [Column("AvmKA_lastup_user")]
    public short? AvmKALastupUser { get; set; }

    [Column("AvmKA_lastup_date")]
    public DateTime? AvmKALastupDate { get; set; }

    [Column("AvmKA_special1")]
    [StringLength(4)]
    public string? AvmKASpecial1 { get; set; }

    [Column("AvmKA_special2")]
    [StringLength(4)]
    public string? AvmKASpecial2 { get; set; }

    [Column("AvmKA_special3")]
    [StringLength(4)]
    public string? AvmKASpecial3 { get; set; }

    [Column("AvmKA_kodu")]
    [StringLength(25)]
    public string? AvmKAKodu { get; set; }

    [Column("AvmKA_ismi")]
    [StringLength(50)]
    public string? AvmKAIsmi { get; set; }

    [Column("AvmKA_aciklama")]
    [StringLength(40)]
    public string? AvmKAAciklama { get; set; }

    [Column("AvmKA_orani")]
    public double? AvmKAOrani { get; set; }
}
