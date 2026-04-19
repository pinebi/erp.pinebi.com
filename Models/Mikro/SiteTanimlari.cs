using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("site_tanimlari")]
public class SiteTanimlari
{
    [Column("site_Guid")]
    public Guid? SiteGuid { get; set; }

    [Column("site_DBCno")]
    public short? SiteDBCno { get; set; }

    [Column("site_SpecRECno")]
    public int? SiteSpecRECno { get; set; }

    [Column("site_iptal")]
    public bool? SiteIptal { get; set; }

    [Column("site_fileid")]
    public short? SiteFileid { get; set; }

    [Column("site_hidden")]
    public bool? SiteHidden { get; set; }

    [Column("site_kilitli")]
    public bool? SiteKilitli { get; set; }

    [Column("site_degisti")]
    public bool? SiteDegisti { get; set; }

    [Column("site_checksum")]
    public int? SiteChecksum { get; set; }

    [Column("site_create_user")]
    public short? SiteCreateUser { get; set; }

    [Column("site_create_date")]
    public DateTime? SiteCreateDate { get; set; }

    [Column("site_lastup_user")]
    public short? SiteLastupUser { get; set; }

    [Column("site_lastup_date")]
    public DateTime? SiteLastupDate { get; set; }

    [Column("site_special1")]
    [StringLength(4)]
    public string? SiteSpecial1 { get; set; }

    [Column("site_special2")]
    [StringLength(4)]
    public string? SiteSpecial2 { get; set; }

    [Column("site_special3")]
    [StringLength(4)]
    public string? SiteSpecial3 { get; set; }

    [Column("site_kod")]
    [StringLength(25)]
    public string? SiteKod { get; set; }

    [Column("site_ismi")]
    [StringLength(50)]
    public string? SiteIsmi { get; set; }

    [Column("site_otoparkacikalan")]
    public double? SiteOtoparkacikalan { get; set; }

    [Column("site_otoparkkapalialan")]
    public double? SiteOtoparkkapalialan { get; set; }

    [Column("site_toplamacikalan")]
    public double? SiteToplamacikalan { get; set; }

    [Column("site_toplamkapalialan")]
    public double? SiteToplamkapalialan { get; set; }
}
