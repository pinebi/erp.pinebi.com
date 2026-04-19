using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("temp")]
public class Temp
{
    [Column("Temp_Guid")]
    public Guid? TempGuid { get; set; }

    [Column("Temp_DBCno")]
    public short? TempDBCno { get; set; }

    [Column("Temp_SpecRECNo")]
    public int? TempSpecRECNo { get; set; }

    [Column("Temp_iptal")]
    public bool? TempIptal { get; set; }

    [Column("Temp_fileid")]
    public short? TempFileid { get; set; }

    [Column("Temp_hidden")]
    public bool? TempHidden { get; set; }

    [Column("Temp_kilitli")]
    public bool? TempKilitli { get; set; }

    [Column("Temp_degisti")]
    public bool? TempDegisti { get; set; }

    [Column("Temp_CheckSum")]
    public int? TempCheckSum { get; set; }

    [Column("Temp_create_user")]
    public short? TempCreateUser { get; set; }

    [Column("Temp_create_date")]
    public DateTime? TempCreateDate { get; set; }

    [Column("Temp_lastup_user")]
    public short? TempLastupUser { get; set; }

    [Column("Temp_lastup_date")]
    public DateTime? TempLastupDate { get; set; }

    [Column("Temp_special1")]
    [StringLength(4)]
    public string? TempSpecial1 { get; set; }

    [Column("Temp_special2")]
    [StringLength(4)]
    public string? TempSpecial2 { get; set; }

    [Column("Temp_special3")]
    [StringLength(4)]
    public string? TempSpecial3 { get; set; }

    [Column("Temp_Buffer")]
    [StringLength(50)]
    public string? TempBuffer { get; set; }
}
