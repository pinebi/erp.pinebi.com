using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("makina_sorunlari")]
public class MakinaSorunlari
{
    [Column("mks_Guid")]
    public Guid? MksGuid { get; set; }

    [Column("mks_DBCno")]
    public short? MksDBCno { get; set; }

    [Column("mks_SpecRECno")]
    public int? MksSpecRECno { get; set; }

    [Column("mks_iptal")]
    public bool? MksIptal { get; set; }

    [Column("mks_fileid")]
    public short? MksFileid { get; set; }

    [Column("mks_hidden")]
    public bool? MksHidden { get; set; }

    [Column("mks_kilitli")]
    public bool? MksKilitli { get; set; }

    [Column("mks_degisti")]
    public bool? MksDegisti { get; set; }

    [Column("mks_checksum")]
    public int? MksChecksum { get; set; }

    [Column("mks_create_user")]
    public short? MksCreateUser { get; set; }

    [Column("mks_create_date")]
    public DateTime? MksCreateDate { get; set; }

    [Column("mks_lastup_user")]
    public short? MksLastupUser { get; set; }

    [Column("mks_lastup_date")]
    public DateTime? MksLastupDate { get; set; }

    [Column("mks_special1")]
    [StringLength(4)]
    public string? MksSpecial1 { get; set; }

    [Column("mks_special2")]
    [StringLength(4)]
    public string? MksSpecial2 { get; set; }

    [Column("mks_special3")]
    [StringLength(4)]
    public string? MksSpecial3 { get; set; }

    [Column("mks_kod")]
    [StringLength(25)]
    public string? MksKod { get; set; }

    [Column("mks_ismi")]
    [StringLength(40)]
    public string? MksIsmi { get; set; }
}
