using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_ureticileri")]
public class StokUreticileri
{
    [Column("urt_Guid")]
    public Guid UrtGuid { get; set; }

    [Column("urt_DBCno")]
    public short? UrtDBCno { get; set; }

    [Column("urt_SpecRECno")]
    public int? UrtSpecRECno { get; set; }

    [Column("urt_iptal")]
    public bool? UrtIptal { get; set; }

    [Column("urt_fileid")]
    public short? UrtFileid { get; set; }

    [Column("urt_hidden")]
    public bool? UrtHidden { get; set; }

    [Column("urt_kilitli")]
    public bool? UrtKilitli { get; set; }

    [Column("urt_degisti")]
    public bool? UrtDegisti { get; set; }

    [Column("urt_checksum")]
    public int? UrtChecksum { get; set; }

    [Column("urt_create_user")]
    public short? UrtCreateUser { get; set; }

    [Column("urt_create_date")]
    public DateTime? UrtCreateDate { get; set; }

    [Column("urt_lastup_user")]
    public short? UrtLastupUser { get; set; }

    [Column("urt_lastup_date")]
    public DateTime? UrtLastupDate { get; set; }

    [Column("urt_special1")]
    [StringLength(4)]
    public string? UrtSpecial1 { get; set; }

    [Column("urt_special2")]
    [StringLength(4)]
    public string? UrtSpecial2 { get; set; }

    [Column("urt_special3")]
    [StringLength(4)]
    public string? UrtSpecial3 { get; set; }

    [Column("urt_kod")]
    [StringLength(25)]
    public string UrtKod { get; set; }

    [Column("urt_ismi")]
    [StringLength(40)]
    public string? UrtIsmi { get; set; }
}
