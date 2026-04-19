using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_unvan_tanimlari")]
public class PersonelUnvanTanimlari
{
    [Column("un_Guid")]
    public Guid? UnGuid { get; set; }

    [Column("un_DBCno")]
    public short? UnDBCno { get; set; }

    [Column("un_SpecRECno")]
    public int? UnSpecRECno { get; set; }

    [Column("un_iptal")]
    public bool? UnIptal { get; set; }

    [Column("un_fileid")]
    public short? UnFileid { get; set; }

    [Column("un_hidden")]
    public bool? UnHidden { get; set; }

    [Column("un_kilitli")]
    public bool? UnKilitli { get; set; }

    [Column("un_degisti")]
    public bool? UnDegisti { get; set; }

    [Column("un_checksum")]
    public int? UnChecksum { get; set; }

    [Column("un_create_user")]
    public short? UnCreateUser { get; set; }

    [Column("un_create_date")]
    public DateTime? UnCreateDate { get; set; }

    [Column("un_lastup_user")]
    public short? UnLastupUser { get; set; }

    [Column("un_lastup_date")]
    public DateTime? UnLastupDate { get; set; }

    [Column("un_special1")]
    [StringLength(4)]
    public string? UnSpecial1 { get; set; }

    [Column("un_special2")]
    [StringLength(4)]
    public string? UnSpecial2 { get; set; }

    [Column("un_special3")]
    [StringLength(4)]
    public string? UnSpecial3 { get; set; }

    [Column("un_kod")]
    [StringLength(25)]
    public string? UnKod { get; set; }

    [Column("un_aciklama")]
    [StringLength(40)]
    public string? UnAciklama { get; set; }
}
