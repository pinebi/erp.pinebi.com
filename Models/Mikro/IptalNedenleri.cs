using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("iptal_nedenleri")]
public class IptalNedenleri
{
    [Column("ipt_Guid")]
    public Guid? IptGuid { get; set; }

    [Column("ipt_DBCno")]
    public short? IptDBCno { get; set; }

    [Column("ipt_SpecRECno")]
    public int? IptSpecRECno { get; set; }

    [Column("ipt_iptal")]
    public bool? IptIptal { get; set; }

    [Column("ipt_fileid")]
    public short? IptFileid { get; set; }

    [Column("ipt_hidden")]
    public bool? IptHidden { get; set; }

    [Column("ipt_kilitli")]
    public bool? IptKilitli { get; set; }

    [Column("ipt_degisti")]
    public bool? IptDegisti { get; set; }

    [Column("ipt_checksum")]
    public int? IptChecksum { get; set; }

    [Column("ipt_create_user")]
    public short? IptCreateUser { get; set; }

    [Column("ipt_create_date")]
    public DateTime? IptCreateDate { get; set; }

    [Column("ipt_lastup_user")]
    public short? IptLastupUser { get; set; }

    [Column("ipt_lastup_date")]
    public DateTime? IptLastupDate { get; set; }

    [Column("ipt_special1")]
    [StringLength(4)]
    public string? IptSpecial1 { get; set; }

    [Column("ipt_special2")]
    [StringLength(4)]
    public string? IptSpecial2 { get; set; }

    [Column("ipt_special3")]
    [StringLength(4)]
    public string? IptSpecial3 { get; set; }

    [Column("ipt_kodu")]
    [StringLength(25)]
    public string? IptKodu { get; set; }

    [Column("ipt_adi")]
    [StringLength(50)]
    public string? IptAdi { get; set; }
}
