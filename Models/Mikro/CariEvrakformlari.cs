using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_evrakformlari")]
public class CariEvrakformlari
{
    [Column("cf_Guid")]
    public Guid? CfGuid { get; set; }

    [Column("cf_DBCno")]
    public short? CfDBCno { get; set; }

    [Column("cf_SpecRECno")]
    public int? CfSpecRECno { get; set; }

    [Column("cf_iptal")]
    public bool? CfIptal { get; set; }

    [Column("cf_fileid")]
    public short? CfFileid { get; set; }

    [Column("cf_hidden")]
    public bool? CfHidden { get; set; }

    [Column("cf_kilitli")]
    public bool? CfKilitli { get; set; }

    [Column("cf_degisti")]
    public bool? CfDegisti { get; set; }

    [Column("cf_checksum")]
    public int? CfChecksum { get; set; }

    [Column("cf_create_user")]
    public short? CfCreateUser { get; set; }

    [Column("cf_create_date")]
    public DateTime? CfCreateDate { get; set; }

    [Column("cf_lastup_user")]
    public short? CfLastupUser { get; set; }

    [Column("cf_lastup_date")]
    public DateTime? CfLastupDate { get; set; }

    [Column("cf_special1")]
    [StringLength(4)]
    public string? CfSpecial1 { get; set; }

    [Column("cf_special2")]
    [StringLength(4)]
    public string? CfSpecial2 { get; set; }

    [Column("cf_special3")]
    [StringLength(4)]
    public string? CfSpecial3 { get; set; }

    [Column("cf_formtipi")]
    public byte? CfFormtipi { get; set; }

    [Column("cf_carikodu")]
    [StringLength(25)]
    public string? CfCarikodu { get; set; }

    [Column("cf_yenitipformadi")]
    [StringLength(80)]
    public string? CfYenitipformadi { get; set; }

    [Column("cf_eskitipformadi")]
    [StringLength(80)]
    public string? CfEskitipformadi { get; set; }
}
