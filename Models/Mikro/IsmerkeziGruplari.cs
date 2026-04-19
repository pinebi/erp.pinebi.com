using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ismerkezi_gruplari")]
public class IsmerkeziGruplari
{
    [Column("imgr_Guid")]
    public Guid? ImgrGuid { get; set; }

    [Column("imgr_DBCno")]
    public short? ImgrDBCno { get; set; }

    [Column("imgr_SpecRECNo")]
    public int? ImgrSpecRECNo { get; set; }

    [Column("imgr_iptal")]
    public bool? ImgrIptal { get; set; }

    [Column("imgr_fileid")]
    public short? ImgrFileid { get; set; }

    [Column("imgr_hidden")]
    public bool? ImgrHidden { get; set; }

    [Column("imgr_kilitli")]
    public bool? ImgrKilitli { get; set; }

    [Column("imgr_degisti")]
    [StringLength(9)]
    public string? ImgrDegisti { get; set; }

    [Column("imgr_CheckSum")]
    public int? ImgrCheckSum { get; set; }

    [Column("imgr_create_user")]
    public short? ImgrCreateUser { get; set; }

    [Column("imgr_create_date")]
    public DateTime? ImgrCreateDate { get; set; }

    [Column("imgr_lastup_user")]
    public short? ImgrLastupUser { get; set; }

    [Column("imgr_lastup_date")]
    public DateTime? ImgrLastupDate { get; set; }

    [Column("imgr_special1")]
    [StringLength(4)]
    public string? ImgrSpecial1 { get; set; }

    [Column("imgr_special2")]
    [StringLength(4)]
    public string? ImgrSpecial2 { get; set; }

    [Column("imgr_special3")]
    [StringLength(4)]
    public string? ImgrSpecial3 { get; set; }

    [Column("imgr_kod")]
    [StringLength(4)]
    public string? ImgrKod { get; set; }

    [Column("imgr_isim")]
    [StringLength(40)]
    public string? ImgrIsim { get; set; }
}
