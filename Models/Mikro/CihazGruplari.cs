using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cihaz_gruplari")]
public class CihazGruplari
{
    [Column("cg_Guid")]
    public Guid? CgGuid { get; set; }

    [Column("cg_DBCno")]
    public short? CgDBCno { get; set; }

    [Column("cg_SpecRECno")]
    public int? CgSpecRECno { get; set; }

    [Column("cg_iptal")]
    public bool? CgIptal { get; set; }

    [Column("cg_fileid")]
    public short? CgFileid { get; set; }

    [Column("cg_hidden")]
    public bool? CgHidden { get; set; }

    [Column("cg_kilitli")]
    public bool? CgKilitli { get; set; }

    [Column("cg_degisti")]
    public bool? CgDegisti { get; set; }

    [Column("cg_checksum")]
    public int? CgChecksum { get; set; }

    [Column("cg_create_user")]
    public short? CgCreateUser { get; set; }

    [Column("cg_create_date")]
    public DateTime? CgCreateDate { get; set; }

    [Column("cg_lastup_user")]
    public short? CgLastupUser { get; set; }

    [Column("cg_lastup_date")]
    public DateTime? CgLastupDate { get; set; }

    [Column("cg_special1")]
    [StringLength(4)]
    public string? CgSpecial1 { get; set; }

    [Column("cg_special2")]
    [StringLength(4)]
    public string? CgSpecial2 { get; set; }

    [Column("cg_special3")]
    [StringLength(4)]
    public string? CgSpecial3 { get; set; }

    [Column("cg_kod")]
    [StringLength(25)]
    public string? CgKod { get; set; }

    [Column("cg_aciklama")]
    [StringLength(80)]
    public string? CgAciklama { get; set; }
}
