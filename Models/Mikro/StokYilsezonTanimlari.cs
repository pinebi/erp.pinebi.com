using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_yilsezon_tanimlari")]
public class StokYilsezonTanimlari
{
    [Column("ysn_Guid")]
    public Guid? YsnGuid { get; set; }

    [Column("ysn_DBCno")]
    public short? YsnDBCno { get; set; }

    [Column("ysn_SpecRECNo")]
    public int? YsnSpecRECNo { get; set; }

    [Column("ysn_iptal")]
    public bool? YsnIptal { get; set; }

    [Column("ysn_fileid")]
    public short? YsnFileid { get; set; }

    [Column("ysn_hidden")]
    public bool? YsnHidden { get; set; }

    [Column("ysn_kilitli")]
    public bool? YsnKilitli { get; set; }

    [Column("ysn_degisti")]
    public bool? YsnDegisti { get; set; }

    [Column("ysn_CheckSum")]
    public int? YsnCheckSum { get; set; }

    [Column("ysn_create_user")]
    public short? YsnCreateUser { get; set; }

    [Column("ysn_create_date")]
    public DateTime? YsnCreateDate { get; set; }

    [Column("ysn_lastup_user")]
    public short? YsnLastupUser { get; set; }

    [Column("ysn_lastup_date")]
    public DateTime? YsnLastupDate { get; set; }

    [Column("ysn_special1")]
    [StringLength(4)]
    public string? YsnSpecial1 { get; set; }

    [Column("ysn_special2")]
    [StringLength(4)]
    public string? YsnSpecial2 { get; set; }

    [Column("ysn_special3")]
    [StringLength(4)]
    public string? YsnSpecial3 { get; set; }

    [Column("ysn_kodu")]
    [StringLength(25)]
    public string? YsnKodu { get; set; }

    [Column("ysn_ismi")]
    [StringLength(40)]
    public string? YsnIsmi { get; set; }
}
