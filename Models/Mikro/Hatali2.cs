using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hatali2")]
public class Hatali2
{
    [Column("Online_Guid")]
    public Guid? OnlineGuid { get; set; }

    [Column("Online_DBCno")]
    public short? OnlineDBCno { get; set; }

    [Column("Online_SpecRECNo")]
    public int? OnlineSpecRECNo { get; set; }

    [Column("Online_iptal")]
    public bool? OnlineIptal { get; set; }

    [Column("Online_fileid")]
    public short? OnlineFileid { get; set; }

    [Column("Online_hidden")]
    public bool? OnlineHidden { get; set; }

    [Column("Online_kilitli")]
    public bool? OnlineKilitli { get; set; }

    [Column("Online_degisti")]
    public bool? OnlineDegisti { get; set; }

    [Column("Online_CheckSum")]
    public int? OnlineCheckSum { get; set; }

    [Column("Online_create_user")]
    public short? OnlineCreateUser { get; set; }

    [Column("Online_create_date")]
    public DateTime? OnlineCreateDate { get; set; }

    [Column("Online_lastup_user")]
    public short? OnlineLastupUser { get; set; }

    [Column("Online_lastup_date")]
    public DateTime? OnlineLastupDate { get; set; }

    [Column("Online_special1")]
    [StringLength(4)]
    public string? OnlineSpecial1 { get; set; }

    [Column("Online_special2")]
    [StringLength(4)]
    public string? OnlineSpecial2 { get; set; }

    [Column("Online_special3")]
    [StringLength(4)]
    public string? OnlineSpecial3 { get; set; }

    [Column("Online_Buffer")]
    [StringLength(50)]
    public string? OnlineBuffer { get; set; }
}
