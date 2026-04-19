using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ithalat_muhasebe_gruplari")]
public class IthalatMuhasebeGruplari
{
    [Column("IthMuh_Guid")]
    public Guid? IthMuhGuid { get; set; }

    [Column("IthMuh_DBCno")]
    public short? IthMuhDBCno { get; set; }

    [Column("IthMuh_SpecRECno")]
    public int? IthMuhSpecRECno { get; set; }

    [Column("IthMuh_iptal")]
    public bool? IthMuhIptal { get; set; }

    [Column("IthMuh_fileid")]
    public short? IthMuhFileid { get; set; }

    [Column("IthMuh_hidden")]
    public bool? IthMuhHidden { get; set; }

    [Column("IthMuh_kilitli")]
    public bool? IthMuhKilitli { get; set; }

    [Column("IthMuh_degistir")]
    public bool? IthMuhDegistir { get; set; }

    [Column("IthMuh_checksum")]
    public int? IthMuhChecksum { get; set; }

    [Column("IthMuh_create_user")]
    public short? IthMuhCreateUser { get; set; }

    [Column("IthMuh_create_date")]
    public DateTime? IthMuhCreateDate { get; set; }

    [Column("IthMuh_lastup_user")]
    public short? IthMuhLastupUser { get; set; }

    [Column("IthMuh_lastup_date")]
    public DateTime? IthMuhLastupDate { get; set; }

    [Column("IthMuh_special1")]
    [StringLength(4)]
    public string? IthMuhSpecial1 { get; set; }

    [Column("IthMuh_special2")]
    [StringLength(4)]
    public string? IthMuhSpecial2 { get; set; }

    [Column("IthMuh_special3")]
    [StringLength(4)]
    public string? IthMuhSpecial3 { get; set; }

    [Column("IthMuh_kod")]
    [StringLength(25)]
    public string? IthMuhKod { get; set; }

    [Column("IthMuh_ismi")]
    [StringLength(40)]
    public string? IthMuhIsmi { get; set; }

    [Column("IthMuh_navlun_muh_kod")]
    [StringLength(40)]
    public string? IthMuhNavlunMuhKod { get; set; }

    [Column("IthMuh_sigorta_muh_kod")]
    [StringLength(40)]
    public string? IthMuhSigortaMuhKod { get; set; }

    [Column("IthMuh_gumruk_muh_kod")]
    [StringLength(40)]
    public string? IthMuhGumrukMuhKod { get; set; }

    [Column("IthMuh_banka_muh_kod")]
    [StringLength(40)]
    public string? IthMuhBankaMuhKod { get; set; }

    [Column("IthMuh_diger1_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger1MuhKod { get; set; }

    [Column("IthMuh_diger2_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger2MuhKod { get; set; }

    [Column("IthMuh_diger3_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger3MuhKod { get; set; }

    [Column("IthMuh_diger4_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger4MuhKod { get; set; }

    [Column("IthMuh_diger5_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger5MuhKod { get; set; }

    [Column("IthMuh_diger6_muh_kod")]
    [StringLength(40)]
    public string? IthMuhDiger6MuhKod { get; set; }

    [Column("IthMuh_MalBedeliMuhKodu")]
    [StringLength(40)]
    public string? IthMuhMalBedeliMuhKodu { get; set; }
}
