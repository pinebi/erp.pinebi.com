using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("barkod_tanimlari")]
public class BarkodTanimlari
{
    [Column("bar_Guid")]
    public Guid BarGuid { get; set; }

    [Column("bar_DBCno")]
    public short? BarDBCno { get; set; }

    [Column("bar_SpecRECno")]
    public int? BarSpecRECno { get; set; }

    [Column("bar_iptal")]
    public bool? BarIptal { get; set; }

    [Column("bar_fileid")]
    public short? BarFileid { get; set; }

    [Column("bar_hidden")]
    public bool? BarHidden { get; set; }

    [Column("bar_kilitli")]
    public bool? BarKilitli { get; set; }

    [Column("bar_degisti")]
    public bool? BarDegisti { get; set; }

    [Column("bar_checksum")]
    public int? BarChecksum { get; set; }

    [Column("bar_create_user")]
    public short? BarCreateUser { get; set; }

    [Column("bar_create_date")]
    public DateTime? BarCreateDate { get; set; }

    [Column("bar_lastup_user")]
    public short? BarLastupUser { get; set; }

    [Column("bar_lastup_date")]
    public DateTime? BarLastupDate { get; set; }

    [Column("bar_special1")]
    [StringLength(4)]
    public string? BarSpecial1 { get; set; }

    [Column("bar_special2")]
    [StringLength(4)]
    public string? BarSpecial2 { get; set; }

    [Column("bar_special3")]
    [StringLength(4)]
    public string? BarSpecial3 { get; set; }

    [Column("bar_kodu")]
    [StringLength(50)]
    public string? BarKodu { get; set; }

    [Column("bar_stokkodu")]
    [StringLength(25)]
    public string? BarStokkodu { get; set; }

    [Column("bar_partikodu")]
    [StringLength(25)]
    public string? BarPartikodu { get; set; }

    [Column("bar_lotno")]
    public int? BarLotno { get; set; }

    [Column("bar_serino_veya_bagkodu")]
    [StringLength(25)]
    public string? BarSerinoVeyaBagkodu { get; set; }

    [Column("bar_barkodtipi")]
    public byte? BarBarkodtipi { get; set; }

    [Column("bar_icerigi")]
    public byte? BarIcerigi { get; set; }

    [Column("bar_birimpntr")]
    public byte? BarBirimpntr { get; set; }

    [Column("bar_master")]
    public bool? BarMaster { get; set; }

    [Column("bar_bedenpntr")]
    public byte? BarBedenpntr { get; set; }

    [Column("bar_renkpntr")]
    public byte? BarRenkpntr { get; set; }

    [Column("bar_baglantitipi")]
    public byte? BarBaglantitipi { get; set; }

    [Column("bar_har_uid")]
    public Guid? BarHarUid { get; set; }

    [Column("bar_asortitanimkodu")]
    [StringLength(25)]
    public string? BarAsortitanimkodu { get; set; }
}
