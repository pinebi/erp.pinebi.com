using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_markalari")]
public class StokMarkalari
{
    [Column("mrk_Guid")]
    public Guid MrkGuid { get; set; }

    [Column("mrk_DBCno")]
    public short? MrkDBCno { get; set; }

    [Column("mrk_SpecRECno")]
    public int? MrkSpecRECno { get; set; }

    [Column("mrk_iptal")]
    public bool? MrkIptal { get; set; }

    [Column("mrk_fileid")]
    public short? MrkFileid { get; set; }

    [Column("mrk_hidden")]
    public bool? MrkHidden { get; set; }

    [Column("mrk_kilitli")]
    public bool? MrkKilitli { get; set; }

    [Column("mrk_degisti")]
    public bool? MrkDegisti { get; set; }

    [Column("mrk_checksum")]
    public int? MrkChecksum { get; set; }

    [Column("mrk_create_user")]
    public short? MrkCreateUser { get; set; }

    [Column("mrk_create_date")]
    public DateTime? MrkCreateDate { get; set; }

    [Column("mrk_lastup_user")]
    public short? MrkLastupUser { get; set; }

    [Column("mrk_lastup_date")]
    public DateTime? MrkLastupDate { get; set; }

    [Column("mrk_special1")]
    [StringLength(4)]
    public string? MrkSpecial1 { get; set; }

    [Column("mrk_special2")]
    [StringLength(4)]
    public string? MrkSpecial2 { get; set; }

    [Column("mrk_special3")]
    [StringLength(4)]
    public string? MrkSpecial3 { get; set; }

    [Column("mrk_kod")]
    [StringLength(25)]
    public string? MrkKod { get; set; }

    [Column("mrk_ismi")]
    [StringLength(40)]
    public string? MrkIsmi { get; set; }
}
