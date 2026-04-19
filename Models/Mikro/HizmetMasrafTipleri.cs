using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_masraf_tipleri")]
public class HizmetMasrafTipleri
{
    [Column("hmtip_Guid")]
    public Guid? HmtipGuid { get; set; }

    [Column("hmtip_DBCno")]
    public short? HmtipDBCno { get; set; }

    [Column("hmtip_SpecRECno")]
    public int? HmtipSpecRECno { get; set; }

    [Column("hmtip_iptal")]
    public bool? HmtipIptal { get; set; }

    [Column("hmtip_fileid")]
    public short? HmtipFileid { get; set; }

    [Column("hmtip_hidden")]
    public bool? HmtipHidden { get; set; }

    [Column("hmtip_kilitli")]
    public bool? HmtipKilitli { get; set; }

    [Column("hmtip_degisti")]
    public bool? HmtipDegisti { get; set; }

    [Column("hmtip_checksum")]
    public int? HmtipChecksum { get; set; }

    [Column("hmtip_create_user")]
    public short? HmtipCreateUser { get; set; }

    [Column("hmtip_create_date")]
    public DateTime? HmtipCreateDate { get; set; }

    [Column("hmtip_lastup_user")]
    public short? HmtipLastupUser { get; set; }

    [Column("hmtip_lastup_date")]
    public DateTime? HmtipLastupDate { get; set; }

    [Column("hmtip_special1")]
    [StringLength(4)]
    public string? HmtipSpecial1 { get; set; }

    [Column("hmtip_special2")]
    [StringLength(4)]
    public string? HmtipSpecial2 { get; set; }

    [Column("hmtip_special3")]
    [StringLength(4)]
    public string? HmtipSpecial3 { get; set; }

    [Column("hmtip_kod")]
    [StringLength(25)]
    public string? HmtipKod { get; set; }

    [Column("hmtip_ismi")]
    [StringLength(40)]
    public string? HmtipIsmi { get; set; }
}
