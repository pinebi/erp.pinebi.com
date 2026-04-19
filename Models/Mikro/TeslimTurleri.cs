using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("teslim_turleri")]
public class TeslimTurleri
{
    [Column("tslt_Guid")]
    public Guid? TsltGuid { get; set; }

    [Column("tslt_DBCno")]
    public short? TsltDBCno { get; set; }

    [Column("tslt_SpecRECno")]
    public int? TsltSpecRECno { get; set; }

    [Column("tslt_iptal")]
    public bool? TsltIptal { get; set; }

    [Column("tslt_fileid")]
    public short? TsltFileid { get; set; }

    [Column("tslt_hidden")]
    public bool? TsltHidden { get; set; }

    [Column("tslt_kilitli")]
    public bool? TsltKilitli { get; set; }

    [Column("tslt_degisti")]
    public bool? TsltDegisti { get; set; }

    [Column("tslt_checksum")]
    public int? TsltChecksum { get; set; }

    [Column("tslt_create_user")]
    public short? TsltCreateUser { get; set; }

    [Column("tslt_create_date")]
    public DateTime? TsltCreateDate { get; set; }

    [Column("tslt_lastup_user")]
    public short? TsltLastupUser { get; set; }

    [Column("tslt_lastup_date")]
    public DateTime? TsltLastupDate { get; set; }

    [Column("tslt_special1")]
    [StringLength(4)]
    public string? TsltSpecial1 { get; set; }

    [Column("tslt_special2")]
    [StringLength(4)]
    public string? TsltSpecial2 { get; set; }

    [Column("tslt_special3")]
    [StringLength(4)]
    public string? TsltSpecial3 { get; set; }

    [Column("tslt_kod")]
    [StringLength(4)]
    public string? TsltKod { get; set; }

    [Column("tslt_ismi")]
    [StringLength(40)]
    public string? TsltIsmi { get; set; }
}
