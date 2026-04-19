using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isemri_muhasebe_gruplari")]
public class IsemriMuhasebeGruplari
{
    [Column("ismuh_Guid")]
    public Guid? IsmuhGuid { get; set; }

    [Column("ismuh_DBCno")]
    public short? IsmuhDBCno { get; set; }

    [Column("ismuh_SpecRecno")]
    public int? IsmuhSpecRecno { get; set; }

    [Column("ismuh_iptal")]
    public bool? IsmuhIptal { get; set; }

    [Column("ismuh_fileid")]
    public short? IsmuhFileid { get; set; }

    [Column("ismuh_hidden")]
    public bool? IsmuhHidden { get; set; }

    [Column("ismuh_kilitli")]
    public bool? IsmuhKilitli { get; set; }

    [Column("ismuh_degisti")]
    public bool? IsmuhDegisti { get; set; }

    [Column("ismuh_checksum")]
    public int? IsmuhChecksum { get; set; }

    [Column("ismuh_create_user")]
    public short? IsmuhCreateUser { get; set; }

    [Column("ismuh_create_date")]
    public DateTime? IsmuhCreateDate { get; set; }

    [Column("ismuh_lastup_user")]
    public short? IsmuhLastupUser { get; set; }

    [Column("ismuh_lastup_date")]
    public DateTime? IsmuhLastupDate { get; set; }

    [Column("ismuh_special1")]
    [StringLength(4)]
    public string? IsmuhSpecial1 { get; set; }

    [Column("ismuh_special2")]
    [StringLength(4)]
    public string? IsmuhSpecial2 { get; set; }

    [Column("ismuh_special3")]
    [StringLength(4)]
    public string? IsmuhSpecial3 { get; set; }

    [Column("ismuh_kod")]
    [StringLength(25)]
    public string? IsmuhKod { get; set; }

    [Column("ismuh_ismi")]
    [StringLength(40)]
    public string? IsmuhIsmi { get; set; }

    [Column("ismuh_muh_kod")]
    [StringLength(40)]
    public string? IsmuhMuhKod { get; set; }

    [Column("ismuh_StokBirikMuhKod")]
    [StringLength(40)]
    public string? IsmuhStokBirikMuhKod { get; set; }

    [Column("ismuh_HizmetBirikMuhKod")]
    [StringLength(40)]
    public string? IsmuhHizmetBirikMuhKod { get; set; }

    [Column("ismuh_StokYansitMuhKod")]
    [StringLength(40)]
    public string? IsmuhStokYansitMuhKod { get; set; }

    [Column("ismuh_HizmetYansitMuhKo")]
    [StringLength(40)]
    public string? IsmuhHizmetYansitMuhKo { get; set; }

    [Column("ismuh_yarimamulbirikimmuhko")]
    [StringLength(40)]
    public string? IsmuhYarimamulbirikimmuhko { get; set; }

    [Column("ismuh_yarimamulyansitmamuhko")]
    [StringLength(40)]
    public string? IsmuhYarimamulyansitmamuhko { get; set; }

    [Column("ismuh_MakineMalYanMuhKo")]
    [StringLength(40)]
    public string? IsmuhMakineMalYanMuhKo { get; set; }

    [Column("ismuh_ElemanMalYanMuhKo")]
    [StringLength(40)]
    public string? IsmuhElemanMalYanMuhKo { get; set; }

    [Column("ismuh_YariMamulMuhKod")]
    [StringLength(40)]
    public string? IsmuhYariMamulMuhKod { get; set; }

    [Column("ismuh_GenMalYanMuhKod_1")]
    [StringLength(40)]
    public string? IsmuhGenMalYanMuhKod1 { get; set; }

    [Column("ismuh_GenMalYanMuhKod_2")]
    [StringLength(40)]
    public string? IsmuhGenMalYanMuhKod2 { get; set; }

    [Column("ismuh_GenMalYanMuhKod_3")]
    [StringLength(40)]
    public string? IsmuhGenMalYanMuhKod3 { get; set; }

    [Column("ismuh_GenMalYanMuhKod_4")]
    [StringLength(40)]
    public string? IsmuhGenMalYanMuhKod4 { get; set; }

    [Column("ismuh_GenMalYanMuhKod_5")]
    [StringLength(40)]
    public string? IsmuhGenMalYanMuhKod5 { get; set; }

    [Column("ismuh_GenUrtMalYanMuhKod_1")]
    [StringLength(40)]
    public string? IsmuhGenUrtMalYanMuhKod1 { get; set; }

    [Column("ismuh_GenUrtMalYanMuhKod_2")]
    [StringLength(40)]
    public string? IsmuhGenUrtMalYanMuhKod2 { get; set; }

    [Column("ismuh_GenUrtMalYanMuhKod_3")]
    [StringLength(40)]
    public string? IsmuhGenUrtMalYanMuhKod3 { get; set; }

    [Column("ismuh_GenUrtMalYanMuhKod_4")]
    [StringLength(40)]
    public string? IsmuhGenUrtMalYanMuhKod4 { get; set; }

    [Column("ismuh_GenUrtMalYanMuhKod_5")]
    [StringLength(40)]
    public string? IsmuhGenUrtMalYanMuhKod5 { get; set; }
}
