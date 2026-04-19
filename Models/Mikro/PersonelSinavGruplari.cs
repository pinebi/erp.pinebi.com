using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sinav_gruplari")]
public class PersonelSinavGruplari
{
    [Column("sng_Guid")]
    public Guid? SngGuid { get; set; }

    [Column("sng_DBCno")]
    public short? SngDBCno { get; set; }

    [Column("sng_SpecRECno")]
    public int? SngSpecRECno { get; set; }

    [Column("sng_iptal")]
    public bool? SngIptal { get; set; }

    [Column("sng_fileid")]
    public short? SngFileid { get; set; }

    [Column("sng_hidden")]
    public bool? SngHidden { get; set; }

    [Column("sng_kilitli")]
    public bool? SngKilitli { get; set; }

    [Column("sng_degisti")]
    public bool? SngDegisti { get; set; }

    [Column("sng_checksum")]
    public int? SngChecksum { get; set; }

    [Column("sng_create_user")]
    public short? SngCreateUser { get; set; }

    [Column("sng_create_date")]
    public DateTime? SngCreateDate { get; set; }

    [Column("sng_lastup_user")]
    public short? SngLastupUser { get; set; }

    [Column("sng_lastup_date")]
    public DateTime? SngLastupDate { get; set; }

    [Column("sng_special1")]
    [StringLength(4)]
    public string? SngSpecial1 { get; set; }

    [Column("sng_special2")]
    [StringLength(4)]
    public string? SngSpecial2 { get; set; }

    [Column("sng_special3")]
    [StringLength(4)]
    public string? SngSpecial3 { get; set; }

    [Column("sng_kodu")]
    [StringLength(25)]
    public string? SngKodu { get; set; }

    [Column("sng_adi")]
    [StringLength(40)]
    public string? SngAdi { get; set; }

    [Column("sng_anagrupkodu")]
    [StringLength(25)]
    public string? SngAnagrupkodu { get; set; }
}
