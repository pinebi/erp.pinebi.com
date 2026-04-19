using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("tamamlayici_stoklar")]
public class TamamlayiciStoklar
{
    [Column("ts_Guid")]
    public Guid? TsGuid { get; set; }

    [Column("ts_DBCno")]
    public short? TsDBCno { get; set; }

    [Column("ts_SpecRECno")]
    public int? TsSpecRECno { get; set; }

    [Column("ts_iptal")]
    public bool? TsIptal { get; set; }

    [Column("ts_fileid")]
    public short? TsFileid { get; set; }

    [Column("ts_hidden")]
    public bool? TsHidden { get; set; }

    [Column("ts_kilitli")]
    public bool? TsKilitli { get; set; }

    [Column("ts_degisti")]
    public bool? TsDegisti { get; set; }

    [Column("ts_CheckSum")]
    public int? TsCheckSum { get; set; }

    [Column("ts_create_user")]
    public short? TsCreateUser { get; set; }

    [Column("ts_create_date")]
    public DateTime? TsCreateDate { get; set; }

    [Column("ts_lastup_user")]
    public short? TsLastupUser { get; set; }

    [Column("ts_lastup_date")]
    public DateTime? TsLastupDate { get; set; }

    [Column("ts_special1")]
    [StringLength(4)]
    public string? TsSpecial1 { get; set; }

    [Column("ts_special2")]
    [StringLength(4)]
    public string? TsSpecial2 { get; set; }

    [Column("ts_special3")]
    [StringLength(4)]
    public string? TsSpecial3 { get; set; }

    [Column("ts_kodu")]
    [StringLength(25)]
    public string? TsKodu { get; set; }

    [Column("ts_stokkodu")]
    [StringLength(25)]
    public string? TsStokkodu { get; set; }

    [Column("ts_miktar")]
    public double? TsMiktar { get; set; }

    [Column("ts_satirno")]
    public int? TsSatirno { get; set; }
}
