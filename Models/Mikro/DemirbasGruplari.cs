using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("demirbas_gruplari")]
public class DemirbasGruplari
{
    [Column("grp_Guid")]
    public Guid? GrpGuid { get; set; }

    [Column("grp_DBCno")]
    public short? GrpDBCno { get; set; }

    [Column("grp_SpecRECno")]
    public int? GrpSpecRECno { get; set; }

    [Column("grp_iptal")]
    public bool? GrpIptal { get; set; }

    [Column("grp_fileid")]
    public short? GrpFileid { get; set; }

    [Column("grp_hidden")]
    public bool? GrpHidden { get; set; }

    [Column("grp_kilitli")]
    public bool? GrpKilitli { get; set; }

    [Column("grp_degisti")]
    public bool? GrpDegisti { get; set; }

    [Column("grp_checksum")]
    public int? GrpChecksum { get; set; }

    [Column("grp_create_user")]
    public short? GrpCreateUser { get; set; }

    [Column("grp_create_date")]
    public DateTime? GrpCreateDate { get; set; }

    [Column("grp_lastup_user")]
    public short? GrpLastupUser { get; set; }

    [Column("grp_lastup_date")]
    public DateTime? GrpLastupDate { get; set; }

    [Column("grp_special1")]
    [StringLength(4)]
    public string? GrpSpecial1 { get; set; }

    [Column("grp_special2")]
    [StringLength(4)]
    public string? GrpSpecial2 { get; set; }

    [Column("grp_special3")]
    [StringLength(4)]
    public string? GrpSpecial3 { get; set; }

    [Column("grp_kod")]
    [StringLength(25)]
    public string? GrpKod { get; set; }

    [Column("grp_ismi")]
    [StringLength(40)]
    public string? GrpIsmi { get; set; }
}
