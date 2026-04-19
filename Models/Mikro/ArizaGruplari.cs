using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ariza_gruplari")]
public class ArizaGruplari
{
    [Column("agr_Guid")]
    public Guid? AgrGuid { get; set; }

    [Column("agr_DBCno")]
    public short? AgrDBCno { get; set; }

    [Column("agr_SpecRECno")]
    public int? AgrSpecRECno { get; set; }

    [Column("agr_iptal")]
    public bool? AgrIptal { get; set; }

    [Column("agr_fileid")]
    public short? AgrFileid { get; set; }

    [Column("agr_hidden")]
    public bool? AgrHidden { get; set; }

    [Column("agr_kilitli")]
    public bool? AgrKilitli { get; set; }

    [Column("agr_degisti")]
    public bool? AgrDegisti { get; set; }

    [Column("agr_checksum")]
    public int? AgrChecksum { get; set; }

    [Column("agr_create_user")]
    public short? AgrCreateUser { get; set; }

    [Column("agr_create_date")]
    public DateTime? AgrCreateDate { get; set; }

    [Column("agr_lastup_user")]
    public short? AgrLastupUser { get; set; }

    [Column("agr_lastup_date")]
    public DateTime? AgrLastupDate { get; set; }

    [Column("agr_special1")]
    [StringLength(4)]
    public string? AgrSpecial1 { get; set; }

    [Column("agr_special2")]
    [StringLength(4)]
    public string? AgrSpecial2 { get; set; }

    [Column("agr_special3")]
    [StringLength(4)]
    public string? AgrSpecial3 { get; set; }

    [Column("agr_kodu")]
    [StringLength(25)]
    public string? AgrKodu { get; set; }

    [Column("agr_adi")]
    [StringLength(50)]
    public string? AgrAdi { get; set; }
}
