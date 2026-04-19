using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yatirim_tesvikleri")]
public class YatirimTesvikleri
{
    [Column("YTTS_Guid")]
    public Guid? YTTSGuid { get; set; }

    [Column("YTTS_DBCno")]
    public short? YTTSDBCno { get; set; }

    [Column("YTTS_Spec_Rec_no")]
    public int? YTTSSpecRecNo { get; set; }

    [Column("YTTS_iptal")]
    public bool? YTTSIptal { get; set; }

    [Column("YTTS_fileid")]
    public short? YTTSFileid { get; set; }

    [Column("YTTS_hidden")]
    public bool? YTTSHidden { get; set; }

    [Column("YTTS_kilitli")]
    public bool? YTTSKilitli { get; set; }

    [Column("YTTS_degisti")]
    public bool? YTTSDegisti { get; set; }

    [Column("YTTS_checksum")]
    public int? YTTSChecksum { get; set; }

    [Column("YTTS_create_user")]
    public short? YTTSCreateUser { get; set; }

    [Column("YTTS_create_date")]
    public DateTime? YTTSCreateDate { get; set; }

    [Column("YTTS_lastup_user")]
    public short? YTTSLastupUser { get; set; }

    [Column("YTTS_lastup_date")]
    public DateTime? YTTSLastupDate { get; set; }

    [Column("YTTS_special1")]
    [StringLength(4)]
    public string? YTTSSpecial1 { get; set; }

    [Column("YTTS_special2")]
    [StringLength(4)]
    public string? YTTSSpecial2 { get; set; }

    [Column("YTTS_special3")]
    [StringLength(4)]
    public string? YTTSSpecial3 { get; set; }

    [Column("YTTS_kodu")]
    [StringLength(25)]
    public string? YTTSKodu { get; set; }

    [Column("YTTS_ismi")]
    [StringLength(50)]
    public string? YTTSIsmi { get; set; }

    [Column("YTTS_muhkodartikeli")]
    [StringLength(10)]
    public string? YTTSMuhkodartikeli { get; set; }

    [Column("YTTS_yurtici_muhartikeli")]
    [StringLength(10)]
    public string? YTTSYurticiMuhartikeli { get; set; }

    [Column("YTTS_yurtdisi_muhartikeli")]
    [StringLength(10)]
    public string? YTTSYurtdisiMuhartikeli { get; set; }

    [Column("YTTS_tarihi")]
    public DateTime? YTTSTarihi { get; set; }

    [Column("YTTS_sayisi")]
    [StringLength(15)]
    public string? YTTSSayisi { get; set; }

    [Column("YTTS_fobdoviz")]
    public byte? YTTSFobdoviz { get; set; }
}
