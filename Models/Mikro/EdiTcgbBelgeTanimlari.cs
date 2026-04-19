using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("edi_tcgb_belge_tanimlari")]
public class EdiTcgbBelgeTanimlari
{
    [Column("edibel_Guid")]
    public Guid? EdibelGuid { get; set; }

    [Column("edibel_DBCno")]
    public short? EdibelDBCno { get; set; }

    [Column("edibel_SpecRECno")]
    public int? EdibelSpecRECno { get; set; }

    [Column("edibel_iptal")]
    public bool? EdibelIptal { get; set; }

    [Column("edibel_fileid")]
    public short? EdibelFileid { get; set; }

    [Column("edibel_hidden")]
    public bool? EdibelHidden { get; set; }

    [Column("edibel_kilitli")]
    public bool? EdibelKilitli { get; set; }

    [Column("edibel_degisti")]
    public bool? EdibelDegisti { get; set; }

    [Column("edibel_checksum")]
    public int? EdibelChecksum { get; set; }

    [Column("edibel_create_user")]
    public short? EdibelCreateUser { get; set; }

    [Column("edibel_create_date")]
    public DateTime? EdibelCreateDate { get; set; }

    [Column("edibel_lastup_user")]
    public short? EdibelLastupUser { get; set; }

    [Column("edibel_lastup_date")]
    public DateTime? EdibelLastupDate { get; set; }

    [Column("edibel_special1")]
    [StringLength(4)]
    public string? EdibelSpecial1 { get; set; }

    [Column("edibel_special2")]
    [StringLength(4)]
    public string? EdibelSpecial2 { get; set; }

    [Column("edibel_special3")]
    [StringLength(4)]
    public string? EdibelSpecial3 { get; set; }

    [Column("edibel_belgekodu")]
    public short? EdibelBelgekodu { get; set; }

    [Column("edibel_belgeadi")]
    [StringLength(60)]
    public string? EdibelBelgeadi { get; set; }
}
