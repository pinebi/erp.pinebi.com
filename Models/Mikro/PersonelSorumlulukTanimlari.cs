using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sorumluluk_tanimlari")]
public class PersonelSorumlulukTanimlari
{
    [Column("sr_Guid")]
    public Guid? SrGuid { get; set; }

    [Column("sr_DBCno")]
    public short? SrDBCno { get; set; }

    [Column("sr_SpecRECno")]
    public int? SrSpecRECno { get; set; }

    [Column("sr_iptal")]
    public bool? SrIptal { get; set; }

    [Column("sr_fileid")]
    public short? SrFileid { get; set; }

    [Column("sr_hidden")]
    public bool? SrHidden { get; set; }

    [Column("sr_kilitli")]
    public bool? SrKilitli { get; set; }

    [Column("sr_degisti")]
    public bool? SrDegisti { get; set; }

    [Column("sr_checksum")]
    public int? SrChecksum { get; set; }

    [Column("sr_create_user")]
    public short? SrCreateUser { get; set; }

    [Column("sr_lastup_user")]
    public short? SrLastupUser { get; set; }

    [Column("sr_lastup_date")]
    public DateTime? SrLastupDate { get; set; }

    [Column("sr_special1")]
    [StringLength(4)]
    public string? SrSpecial1 { get; set; }

    [Column("sr_special2")]
    [StringLength(4)]
    public string? SrSpecial2 { get; set; }

    [Column("sr_special3")]
    [StringLength(4)]
    public string? SrSpecial3 { get; set; }

    [Column("sr_kod")]
    [StringLength(25)]
    public string? SrKod { get; set; }

    [Column("sr_aciklama")]
    [StringLength(40)]
    public string? SrAciklama { get; set; }
}
