using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_reyonlari")]
public class StokReyonlari
{
    [Column("ryn_Guid")]
    public Guid RynGuid { get; set; }

    [Column("ryn_DBCno")]
    public short? RynDBCno { get; set; }

    [Column("ryn_SpecRECno")]
    public int? RynSpecRECno { get; set; }

    [Column("ryn_iptal")]
    public bool? RynIptal { get; set; }

    [Column("ryn_fileid")]
    public short? RynFileid { get; set; }

    [Column("ryn_hidden")]
    public bool? RynHidden { get; set; }

    [Column("ryn_kilitli")]
    public bool? RynKilitli { get; set; }

    [Column("ryn_degisti")]
    public bool? RynDegisti { get; set; }

    [Column("ryn_checksum")]
    public int? RynChecksum { get; set; }

    [Column("ryn_create_user")]
    public short? RynCreateUser { get; set; }

    [Column("ryn_create_date")]
    public DateTime? RynCreateDate { get; set; }

    [Column("ryn_lastup_user")]
    public short? RynLastupUser { get; set; }

    [Column("ryn_lastup_date")]
    public DateTime? RynLastupDate { get; set; }

    [Column("ryn_special1")]
    [StringLength(4)]
    public string? RynSpecial1 { get; set; }

    [Column("ryn_special2")]
    [StringLength(4)]
    public string? RynSpecial2 { get; set; }

    [Column("ryn_special3")]
    [StringLength(4)]
    public string? RynSpecial3 { get; set; }

    [Column("ryn_kod")]
    [StringLength(25)]
    public string RynKod { get; set; }

    [Column("ryn_ismi")]
    [StringLength(40)]
    public string? RynIsmi { get; set; }
}
