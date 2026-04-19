using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ulkeler")]
public class Ulkeler
{
    [Column("ulke_Guid")]
    public Guid? UlkeGuid { get; set; }

    [Column("ulke_DBCno")]
    public short? UlkeDBCno { get; set; }

    [Column("ulke_SpecRECNo")]
    public int? UlkeSpecRECNo { get; set; }

    [Column("ulke_iptal")]
    public bool? UlkeIptal { get; set; }

    [Column("ulke_fileid")]
    public short? UlkeFileid { get; set; }

    [Column("ulke_hidden")]
    public bool? UlkeHidden { get; set; }

    [Column("ulke_kilitli")]
    public bool? UlkeKilitli { get; set; }

    [Column("ulke_degisti")]
    public bool? UlkeDegisti { get; set; }

    [Column("ulke_CheckSum")]
    public int? UlkeCheckSum { get; set; }

    [Column("ulke_create_user")]
    public short? UlkeCreateUser { get; set; }

    [Column("ulke_create_date")]
    public DateTime? UlkeCreateDate { get; set; }

    [Column("ulke_lastup_user")]
    public short? UlkeLastupUser { get; set; }

    [Column("ulke_lastup_date")]
    public DateTime? UlkeLastupDate { get; set; }

    [Column("ulke_special1")]
    [StringLength(4)]
    public string? UlkeSpecial1 { get; set; }

    [Column("ulke_special2")]
    [StringLength(4)]
    public string? UlkeSpecial2 { get; set; }

    [Column("ulke_special3")]
    [StringLength(4)]
    public string? UlkeSpecial3 { get; set; }

    [Column("ulke_ulkekodu")]
    [StringLength(4)]
    public string? UlkeUlkekodu { get; set; }

    [Column("ulke_ulkeadi")]
    [StringLength(30)]
    public string? UlkeUlkeadi { get; set; }

    [Column("ulke_ulkeingadi")]
    [StringLength(30)]
    public string? UlkeUlkeingadi { get; set; }

    [Column("ulke_ulkenumkodu")]
    [StringLength(4)]
    public string? UlkeUlkenumkodu { get; set; }

    [Column("ulke_ulkesureleri")]
    public short? UlkeUlkesureleri { get; set; }

    [Column("ulke_ebeyanulkenumkodu")]
    [StringLength(4)]
    public string? UlkeEbeyanulkenumkodu { get; set; }

    [Column("ulke_efaturaulkekisakodu")]
    [StringLength(5)]
    public string? UlkeEfaturaulkekisakodu { get; set; }
}
