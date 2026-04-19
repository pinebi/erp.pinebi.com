using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("iller")]
public class Iller
{
    [Column("iller_Guid")]
    public Guid? IllerGuid { get; set; }

    [Column("iller_DBCno")]
    public short? IllerDBCno { get; set; }

    [Column("iller_SpecRECNo")]
    public int? IllerSpecRECNo { get; set; }

    [Column("iller_iptal")]
    public bool? IllerIptal { get; set; }

    [Column("iller_fileid")]
    public short? IllerFileid { get; set; }

    [Column("iller_hidden")]
    public bool? IllerHidden { get; set; }

    [Column("iller_kilitli")]
    public bool? IllerKilitli { get; set; }

    [Column("iller_degisti")]
    public bool? IllerDegisti { get; set; }

    [Column("iller_CheckSum")]
    public int? IllerCheckSum { get; set; }

    [Column("iller_create_user")]
    public short? IllerCreateUser { get; set; }

    [Column("iller_create_date")]
    public DateTime? IllerCreateDate { get; set; }

    [Column("iller_lastup_user")]
    public short? IllerLastupUser { get; set; }

    [Column("iller_lastup_date")]
    public DateTime? IllerLastupDate { get; set; }

    [Column("iller_special1")]
    [StringLength(4)]
    public string? IllerSpecial1 { get; set; }

    [Column("iller_special2")]
    [StringLength(4)]
    public string? IllerSpecial2 { get; set; }

    [Column("iller_special3")]
    [StringLength(4)]
    public string? IllerSpecial3 { get; set; }

    [Column("iller_ilkodu")]
    [StringLength(3)]
    public string? IllerIlkodu { get; set; }

    [Column("iller_iladi")]
    [StringLength(25)]
    public string? IllerIladi { get; set; }

    [Column("iller_bolgekodu")]
    [StringLength(5)]
    public string? IllerBolgekodu { get; set; }

    [Column("iller_e_beyankod")]
    [StringLength(5)]
    public string? IllerEBeyankod { get; set; }

    [Column("iller_ulke")]
    [StringLength(5)]
    public string? IllerUlke { get; set; }
}
