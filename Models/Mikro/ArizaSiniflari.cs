using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ariza_siniflari")]
public class ArizaSiniflari
{
    [Column("asn_Guid")]
    public Guid? AsnGuid { get; set; }

    [Column("asn_DBCno")]
    public short? AsnDBCno { get; set; }

    [Column("asn_SpecRECno")]
    public int? AsnSpecRECno { get; set; }

    [Column("asn_iptal")]
    public bool? AsnIptal { get; set; }

    [Column("asn_fileid")]
    public short? AsnFileid { get; set; }

    [Column("asn_hidden")]
    public bool? AsnHidden { get; set; }

    [Column("asn_kilitli")]
    public bool? AsnKilitli { get; set; }

    [Column("asn_degisti")]
    public bool? AsnDegisti { get; set; }

    [Column("asn_checksum")]
    public int? AsnChecksum { get; set; }

    [Column("asn_create_user")]
    public short? AsnCreateUser { get; set; }

    [Column("asn_create_date")]
    public DateTime? AsnCreateDate { get; set; }

    [Column("asn_lastup_user")]
    public short? AsnLastupUser { get; set; }

    [Column("asn_lastup_date")]
    public DateTime? AsnLastupDate { get; set; }

    [Column("asn_special1")]
    [StringLength(4)]
    public string? AsnSpecial1 { get; set; }

    [Column("asn_special2")]
    [StringLength(4)]
    public string? AsnSpecial2 { get; set; }

    [Column("asn_special3")]
    [StringLength(4)]
    public string? AsnSpecial3 { get; set; }

    [Column("asn_kodu")]
    [StringLength(25)]
    public string? AsnKodu { get; set; }

    [Column("asn_adi")]
    [StringLength(50)]
    public string? AsnAdi { get; set; }
}
