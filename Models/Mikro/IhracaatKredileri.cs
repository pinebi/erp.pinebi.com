using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ihracaat_kredileri")]
public class IhracaatKredileri
{
    [Column("ihk_Guid")]
    public Guid? IhkGuid { get; set; }

    [Column("ihk_DBCno")]
    public short? IhkDBCno { get; set; }

    [Column("ihk_SpecRECNo")]
    public int? IhkSpecRECNo { get; set; }

    [Column("ihk_iptal")]
    public bool? IhkIptal { get; set; }

    [Column("ihk_fileid")]
    public short? IhkFileid { get; set; }

    [Column("ihk_hidden")]
    public bool? IhkHidden { get; set; }

    [Column("ihk_kilitli")]
    public bool? IhkKilitli { get; set; }

    [Column("ihk_degisti")]
    public bool? IhkDegisti { get; set; }

    [Column("ihk_checksum")]
    public int? IhkChecksum { get; set; }

    [Column("ihk_create_user")]
    public short? IhkCreateUser { get; set; }

    [Column("ihk_create_date")]
    public DateTime? IhkCreateDate { get; set; }

    [Column("ihk_lastup_user")]
    public short? IhkLastupUser { get; set; }

    [Column("ihk_lastup_date")]
    public DateTime? IhkLastupDate { get; set; }

    [Column("ihk_special1")]
    [StringLength(4)]
    public string? IhkSpecial1 { get; set; }

    [Column("ihk_special2")]
    [StringLength(4)]
    public string? IhkSpecial2 { get; set; }

    [Column("ihk_special3")]
    [StringLength(4)]
    public string? IhkSpecial3 { get; set; }

    [Column("ihk_kodu")]
    [StringLength(4)]
    public string? IhkKodu { get; set; }

    [Column("ihk_adi")]
    [StringLength(40)]
    public string? IhkAdi { get; set; }

    [Column("ihk_bankakodu")]
    [StringLength(25)]
    public string? IhkBankakodu { get; set; }

    [Column("ihk_tutar")]
    public double? IhkTutar { get; set; }

    [Column("ihk_dovizcinsi")]
    public byte? IhkDovizcinsi { get; set; }

    [Column("ihk_doviztutar")]
    public double? IhkDoviztutar { get; set; }

    [Column("ihk_usdtutar")]
    public double? IhkUsdtutar { get; set; }

    [Column("ihk_faizorani")]
    public double? IhkFaizorani { get; set; }

    [Column("ihk_faiztutari")]
    public double? IhkFaiztutari { get; set; }

    [Column("ihk_alindigitarih")]
    public DateTime? IhkAlindigitarih { get; set; }

    [Column("ihk_odemetarih")]
    public DateTime? IhkOdemetarih { get; set; }

    [Column("ihk_kapananusdtutar")]
    public double? IhkKapananusdtutar { get; set; }
}
