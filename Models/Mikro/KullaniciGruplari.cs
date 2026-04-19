using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kullanici_gruplari")]
public class KullaniciGruplari
{
    [Column("kg_Guid")]
    public Guid? KgGuid { get; set; }

    [Column("kg_DBCno")]
    public short? KgDBCno { get; set; }

    [Column("kg_SpecRECno")]
    public int? KgSpecRECno { get; set; }

    [Column("kg_iptal")]
    public bool? KgIptal { get; set; }

    [Column("kg_fileid")]
    public short? KgFileid { get; set; }

    [Column("kg_hidden")]
    public bool? KgHidden { get; set; }

    [Column("kg_kilitli")]
    public bool? KgKilitli { get; set; }

    [Column("kg_degisti")]
    public bool? KgDegisti { get; set; }

    [Column("kg_checksum")]
    public int? KgChecksum { get; set; }

    [Column("kg_create_user")]
    public short? KgCreateUser { get; set; }

    [Column("kg_create_date")]
    public DateTime? KgCreateDate { get; set; }

    [Column("kg_lastup_user")]
    public short? KgLastupUser { get; set; }

    [Column("kg_lastup_date")]
    public DateTime? KgLastupDate { get; set; }

    [Column("kg_special1")]
    [StringLength(4)]
    public string? KgSpecial1 { get; set; }

    [Column("kg_special2")]
    [StringLength(4)]
    public string? KgSpecial2 { get; set; }

    [Column("kg_special3")]
    [StringLength(4)]
    public string? KgSpecial3 { get; set; }

    [Column("kg_no")]
    public int? KgNo { get; set; }

    [Column("kg_adi")]
    [StringLength(25)]
    public string? KgAdi { get; set; }

    [Column("kg_aciklama")]
    [StringLength(127)]
    public string? KgAciklama { get; set; }
}
