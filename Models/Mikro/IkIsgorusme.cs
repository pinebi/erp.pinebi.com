using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ik_isgorusme")]
public class IkIsgorusme
{
    [Column("ikg_Guid")]
    public Guid? IkgGuid { get; set; }

    [Column("ikg_DBCno")]
    public short? IkgDBCno { get; set; }

    [Column("ikg_SpecRECno")]
    public int? IkgSpecRECno { get; set; }

    [Column("ikg_iptal")]
    public bool? IkgIptal { get; set; }

    [Column("ikg_fileid")]
    public short? IkgFileid { get; set; }

    [Column("ikg_hidden")]
    public bool? IkgHidden { get; set; }

    [Column("ikg_kilitli")]
    public bool? IkgKilitli { get; set; }

    [Column("ikg_degisti")]
    public bool? IkgDegisti { get; set; }

    [Column("ikg_checksum")]
    public int? IkgChecksum { get; set; }

    [Column("ikg_create_user")]
    public short? IkgCreateUser { get; set; }

    [Column("ikg_create_date")]
    public DateTime? IkgCreateDate { get; set; }

    [Column("ikg_lastup_user")]
    public short? IkgLastupUser { get; set; }

    [Column("ikg_lastup_date")]
    public DateTime? IkgLastupDate { get; set; }

    [Column("ikg_special1")]
    [StringLength(4)]
    public string? IkgSpecial1 { get; set; }

    [Column("ikg_special2")]
    [StringLength(4)]
    public string? IkgSpecial2 { get; set; }

    [Column("ikg_special3")]
    [StringLength(4)]
    public string? IkgSpecial3 { get; set; }

    [Column("ikg_firmano")]
    public int? IkgFirmano { get; set; }

    [Column("ikg_subeno")]
    public int? IkgSubeno { get; set; }

    [Column("ikg_tarih")]
    public DateTime? IkgTarih { get; set; }

    [Column("ikg_bas_uid")]
    public Guid? IkgBasUid { get; set; }

    [Column("ikg_pers_kod")]
    [StringLength(25)]
    public string? IkgPersKod { get; set; }

    [Column("ikg_satirno")]
    public int? IkgSatirno { get; set; }

    [Column("ikg_ikd_kodu")]
    [StringLength(25)]
    public string? IkgIkdKodu { get; set; }

    [Column("ikg_puan")]
    public double? IkgPuan { get; set; }

    [Column("ikg_degerNotu")]
    [StringLength(80)]
    public string? IkgDegerNotu { get; set; }

    [Column("ikg_ilan_kodu")]
    [StringLength(25)]
    public string? IkgIlanKodu { get; set; }

    [Column("ikg_kadro_kodu")]
    [StringLength(25)]
    public string? IkgKadroKodu { get; set; }
}
