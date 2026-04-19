using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("asorti_tanim_kodlari")]
public class AsortiTanimKodlari
{
    [Column("AsortiTan_Guid")]
    public Guid? AsortiTanGuid { get; set; }

    [Column("AsortiTan_DBCno")]
    public short? AsortiTanDBCno { get; set; }

    [Column("AsortiTan_SpecRECno")]
    public int? AsortiTanSpecRECno { get; set; }

    [Column("AsortiTan_iptal")]
    public bool? AsortiTanIptal { get; set; }

    [Column("AsortiTan_fileid")]
    public short? AsortiTanFileid { get; set; }

    [Column("AsortiTan_hidden")]
    public bool? AsortiTanHidden { get; set; }

    [Column("AsortiTan_kilitli")]
    public bool? AsortiTanKilitli { get; set; }

    [Column("AsortiTan_degisti")]
    public bool? AsortiTanDegisti { get; set; }

    [Column("AsortiTan_checksum")]
    public int? AsortiTanChecksum { get; set; }

    [Column("AsortiTan_create_user")]
    public short? AsortiTanCreateUser { get; set; }

    [Column("AsortiTan_create_date")]
    public DateTime? AsortiTanCreateDate { get; set; }

    [Column("AsortiTan_lastup_user")]
    public short? AsortiTanLastupUser { get; set; }

    [Column("AsortiTan_lastup_date")]
    public DateTime? AsortiTanLastupDate { get; set; }

    [Column("AsortiTan_special1")]
    [StringLength(4)]
    public string? AsortiTanSpecial1 { get; set; }

    [Column("AsortiTan_special2")]
    [StringLength(4)]
    public string? AsortiTanSpecial2 { get; set; }

    [Column("AsortiTan_special3")]
    [StringLength(4)]
    public string? AsortiTanSpecial3 { get; set; }

    [Column("AsortiTan_Kodu")]
    [StringLength(25)]
    public string? AsortiTanKodu { get; set; }

    [Column("AsortiTan_Aciklama")]
    [StringLength(127)]
    public string? AsortiTanAciklama { get; set; }
}
