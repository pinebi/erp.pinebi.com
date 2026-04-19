using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("makina_gruplari")]
public class MakinaGruplari
{
    [Column("makg_Guid")]
    public Guid? MakgGuid { get; set; }

    [Column("makg_DBCno")]
    public short? MakgDBCno { get; set; }

    [Column("makg_SpecRECno")]
    public int? MakgSpecRECno { get; set; }

    [Column("makg_iptal")]
    public bool? MakgIptal { get; set; }

    [Column("makg_fileid")]
    public short? MakgFileid { get; set; }

    [Column("makg_hidden")]
    public bool? MakgHidden { get; set; }

    [Column("makg_kilitli")]
    public bool? MakgKilitli { get; set; }

    [Column("makg_degisti")]
    public bool? MakgDegisti { get; set; }

    [Column("makg_checksum")]
    public int? MakgChecksum { get; set; }

    [Column("makg_create_user")]
    public short? MakgCreateUser { get; set; }

    [Column("makg_create_date")]
    public DateTime? MakgCreateDate { get; set; }

    [Column("makg_lastup_user")]
    public short? MakgLastupUser { get; set; }

    [Column("makg_lastup_date")]
    public DateTime? MakgLastupDate { get; set; }

    [Column("makg_special1")]
    [StringLength(4)]
    public string? MakgSpecial1 { get; set; }

    [Column("makg_special2")]
    [StringLength(4)]
    public string? MakgSpecial2 { get; set; }

    [Column("makg_special3")]
    [StringLength(4)]
    public string? MakgSpecial3 { get; set; }

    [Column("makg_kodu")]
    [StringLength(25)]
    public string? MakgKodu { get; set; }

    [Column("makg_aciklama")]
    [StringLength(40)]
    public string? MakgAciklama { get; set; }
}
