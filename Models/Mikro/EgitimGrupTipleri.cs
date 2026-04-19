using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("egitim_grup_tipleri")]
public class EgitimGrupTipleri
{
    [Column("egt_Guid")]
    public Guid? EgtGuid { get; set; }

    [Column("egt_DBCno")]
    public short? EgtDBCno { get; set; }

    [Column("egt_SpecRECno")]
    public int? EgtSpecRECno { get; set; }

    [Column("egt_iptal")]
    public bool? EgtIptal { get; set; }

    [Column("egt_fileid")]
    public short? EgtFileid { get; set; }

    [Column("egt_hidden")]
    public bool? EgtHidden { get; set; }

    [Column("egt_kilitli")]
    public bool? EgtKilitli { get; set; }

    [Column("egt_degisti")]
    public bool? EgtDegisti { get; set; }

    [Column("egt_checksum")]
    public int? EgtChecksum { get; set; }

    [Column("egt_create_user")]
    public short? EgtCreateUser { get; set; }

    [Column("egt_create_date")]
    public DateTime? EgtCreateDate { get; set; }

    [Column("egt_lastup_user")]
    public short? EgtLastupUser { get; set; }

    [Column("egt_lastup_date")]
    public DateTime? EgtLastupDate { get; set; }

    [Column("egt_special1")]
    [StringLength(4)]
    public string? EgtSpecial1 { get; set; }

    [Column("egt_special2")]
    [StringLength(4)]
    public string? EgtSpecial2 { get; set; }

    [Column("egt_special3")]
    [StringLength(4)]
    public string? EgtSpecial3 { get; set; }

    [Column("egt_kodu")]
    [StringLength(25)]
    public string? EgtKodu { get; set; }

    [Column("egt_adi")]
    [StringLength(40)]
    public string? EgtAdi { get; set; }
}
