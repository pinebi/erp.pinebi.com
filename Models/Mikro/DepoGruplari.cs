using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("depo_gruplari")]
public class DepoGruplari
{
    [Column("dgr_Guid")]
    public Guid? DgrGuid { get; set; }

    [Column("dgr_DBCno")]
    public short? DgrDBCno { get; set; }

    [Column("dgr_SpecRECno")]
    public int? DgrSpecRECno { get; set; }

    [Column("dgr_iptal")]
    public bool? DgrIptal { get; set; }

    [Column("dgr_fileid")]
    public short? DgrFileid { get; set; }

    [Column("dgr_hidden")]
    public bool? DgrHidden { get; set; }

    [Column("dgr_kilitli")]
    public bool? DgrKilitli { get; set; }

    [Column("dgr_degisti")]
    public bool? DgrDegisti { get; set; }

    [Column("dgr_checksum")]
    public int? DgrChecksum { get; set; }

    [Column("dgr_create_user")]
    public short? DgrCreateUser { get; set; }

    [Column("dgr_create_date")]
    public DateTime? DgrCreateDate { get; set; }

    [Column("dgr_lastup_user")]
    public short? DgrLastupUser { get; set; }

    [Column("dgr_lastup_date")]
    public DateTime? DgrLastupDate { get; set; }

    [Column("dgr_special1")]
    [StringLength(4)]
    public string? DgrSpecial1 { get; set; }

    [Column("dgr_special2")]
    [StringLength(4)]
    public string? DgrSpecial2 { get; set; }

    [Column("dgr_special3")]
    [StringLength(4)]
    public string? DgrSpecial3 { get; set; }

    [Column("dgr_kod")]
    [StringLength(25)]
    public string? DgrKod { get; set; }

    [Column("dgr_ismi")]
    [StringLength(50)]
    public string? DgrIsmi { get; set; }
}
