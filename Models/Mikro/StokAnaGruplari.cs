using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_ana_gruplari")]
public class StokAnaGruplari
{
    [Column("san_Guid")]
    public Guid SanGuid { get; set; }

    [Column("san_DBCno")]
    public short? SanDBCno { get; set; }

    [Column("san_SpecRECno")]
    public int? SanSpecRECno { get; set; }

    [Column("san_iptal")]
    public bool? SanIptal { get; set; }

    [Column("san_fileid")]
    public short? SanFileid { get; set; }

    [Column("san_hidden")]
    public bool? SanHidden { get; set; }

    [Column("san_kilitli")]
    public bool? SanKilitli { get; set; }

    [Column("san_degisti")]
    public bool? SanDegisti { get; set; }

    [Column("san_checksum")]
    public int? SanChecksum { get; set; }

    [Column("san_create_user")]
    public short? SanCreateUser { get; set; }

    [Column("san_create_date")]
    public DateTime? SanCreateDate { get; set; }

    [Column("san_lastup_user")]
    public short? SanLastupUser { get; set; }

    [Column("san_lastup_date")]
    public DateTime? SanLastupDate { get; set; }

    [Column("san_special1")]
    [StringLength(4)]
    public string? SanSpecial1 { get; set; }

    [Column("san_special2")]
    [StringLength(4)]
    public string? SanSpecial2 { get; set; }

    [Column("san_special3")]
    [StringLength(4)]
    public string? SanSpecial3 { get; set; }

    [Column("san_kod")]
    [StringLength(25)]
    public string SanKod { get; set; }

    [Column("san_isim")]
    [StringLength(40)]
    public string? SanIsim { get; set; }
}
