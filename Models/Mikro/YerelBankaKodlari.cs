using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yerel_banka_kodlari")]
public class YerelBankaKodlari
{
    [Column("bankkod_Guid")]
    public Guid? BankkodGuid { get; set; }

    [Column("bankkod_DBCno")]
    public short? BankkodDBCno { get; set; }

    [Column("bankkod_SpecRECNo")]
    public int? BankkodSpecRECNo { get; set; }

    [Column("bankkod_iptal")]
    public bool? BankkodIptal { get; set; }

    [Column("bankkod_fileid")]
    public short? BankkodFileid { get; set; }

    [Column("bankkod_hidden")]
    public bool? BankkodHidden { get; set; }

    [Column("bankkod_kilitli")]
    public bool? BankkodKilitli { get; set; }

    [Column("bankkod_degisti")]
    public bool? BankkodDegisti { get; set; }

    [Column("bankkod_CheckSum")]
    public int? BankkodCheckSum { get; set; }

    [Column("bankkod_create_user")]
    public short? BankkodCreateUser { get; set; }

    [Column("bankkod_create_date")]
    public DateTime? BankkodCreateDate { get; set; }

    [Column("bankkod_lastup_user")]
    public short? BankkodLastupUser { get; set; }

    [Column("bankkod_lastup_date")]
    public DateTime? BankkodLastupDate { get; set; }

    [Column("bankkod_special1")]
    [StringLength(4)]
    public string? BankkodSpecial1 { get; set; }

    [Column("bankkod_special2")]
    [StringLength(4)]
    public string? BankkodSpecial2 { get; set; }

    [Column("bankkod_special3")]
    [StringLength(4)]
    public string? BankkodSpecial3 { get; set; }

    [Column("bankkod_kod")]
    [StringLength(4)]
    public string? BankkodKod { get; set; }

    [Column("bankkod_subekodu")]
    [StringLength(8)]
    public string? BankkodSubekodu { get; set; }

    [Column("bankkod_ilkodu")]
    [StringLength(3)]
    public string? BankkodIlkodu { get; set; }

    [Column("bankkod_bankadi")]
    [StringLength(50)]
    public string? BankkodBankadi { get; set; }

    [Column("bankkod_subeadi")]
    [StringLength(50)]
    public string? BankkodSubeadi { get; set; }
}
