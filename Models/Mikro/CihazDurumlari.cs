using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cihaz_durumlari")]
public class CihazDurumlari
{
    [Column("cdr_Guid")]
    public Guid? CdrGuid { get; set; }

    [Column("cdr_DBCno")]
    public short? CdrDBCno { get; set; }

    [Column("cdr_SpecRECno")]
    public int? CdrSpecRECno { get; set; }

    [Column("cdr_iptal")]
    public bool? CdrIptal { get; set; }

    [Column("cdr_fileid")]
    public short? CdrFileid { get; set; }

    [Column("cdr_hidden")]
    public bool? CdrHidden { get; set; }

    [Column("cdr_kilitli")]
    public bool? CdrKilitli { get; set; }

    [Column("cdr_degisti")]
    public bool? CdrDegisti { get; set; }

    [Column("cdr_checksum")]
    public int? CdrChecksum { get; set; }

    [Column("cdr_create_user")]
    public short? CdrCreateUser { get; set; }

    [Column("cdr_create_date")]
    public DateTime? CdrCreateDate { get; set; }

    [Column("cdr_lastup_user")]
    public short? CdrLastupUser { get; set; }

    [Column("cdr_lastup_date")]
    public DateTime? CdrLastupDate { get; set; }

    [Column("cdr_special1")]
    [StringLength(4)]
    public string? CdrSpecial1 { get; set; }

    [Column("cdr_special2")]
    [StringLength(4)]
    public string? CdrSpecial2 { get; set; }

    [Column("cdr_special3")]
    [StringLength(4)]
    public string? CdrSpecial3 { get; set; }

    [Column("cdr_kod")]
    [StringLength(25)]
    public string? CdrKod { get; set; }

    [Column("cdr_isim")]
    [StringLength(50)]
    public string? CdrIsim { get; set; }
}
