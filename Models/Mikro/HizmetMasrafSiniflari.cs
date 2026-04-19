using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_masraf_siniflari")]
public class HizmetMasrafSiniflari
{
    [Column("hmsnf_Guid")]
    public Guid? HmsnfGuid { get; set; }

    [Column("hmsnf_DBCno")]
    public short? HmsnfDBCno { get; set; }

    [Column("hmsnf_SpecRECno")]
    public int? HmsnfSpecRECno { get; set; }

    [Column("hmsnf_iptal")]
    public bool? HmsnfIptal { get; set; }

    [Column("hmsnf_fileid")]
    public short? HmsnfFileid { get; set; }

    [Column("hmsnf_hidden")]
    public bool? HmsnfHidden { get; set; }

    [Column("hmsnf_kilitli")]
    public bool? HmsnfKilitli { get; set; }

    [Column("hmsnf_degisti")]
    public bool? HmsnfDegisti { get; set; }

    [Column("hmsnf_checksum")]
    public int? HmsnfChecksum { get; set; }

    [Column("hmsnf_create_user")]
    public short? HmsnfCreateUser { get; set; }

    [Column("hmsnf_create_date")]
    public DateTime? HmsnfCreateDate { get; set; }

    [Column("hmsnf_lastup_user")]
    public short? HmsnfLastupUser { get; set; }

    [Column("hmsnf_lastup_date")]
    public DateTime? HmsnfLastupDate { get; set; }

    [Column("hmsnf_special1")]
    [StringLength(4)]
    public string? HmsnfSpecial1 { get; set; }

    [Column("hmsnf_special2")]
    [StringLength(4)]
    public string? HmsnfSpecial2 { get; set; }

    [Column("hmsnf_special3")]
    [StringLength(4)]
    public string? HmsnfSpecial3 { get; set; }

    [Column("hmsnf_kod")]
    [StringLength(25)]
    public string? HmsnfKod { get; set; }

    [Column("hmsnf_ismi")]
    [StringLength(40)]
    public string? HmsnfIsmi { get; set; }
}
