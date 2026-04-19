using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ik_kriter_gruplari")]
public class IkKriterGruplari
{
    [Column("ikg_Guid")]
    public Guid? IkgGuid { get; set; }

    [Column("ikg_DBCno")]
    public short? IkgDBCno { get; set; }

    [Column("ikg_SpecRECno")]
    public int? IkgSpecRECno { get; set; }

    [Column("ikg_iptal")]
    public bool? IkgIptal { get; set; }

    [Column("ikg_fileid")]
    public short? IkgFileid { get; set; }

    [Column("ikg_hidden")]
    public bool? IkgHidden { get; set; }

    [Column("ikg_kilitli")]
    public bool? IkgKilitli { get; set; }

    [Column("ikg_degisti")]
    public bool? IkgDegisti { get; set; }

    [Column("ikg_checksum")]
    public int? IkgChecksum { get; set; }

    [Column("ikg_create_user")]
    public short? IkgCreateUser { get; set; }

    [Column("ikg_create_date")]
    public DateTime? IkgCreateDate { get; set; }

    [Column("ikg_lastup_user")]
    public short? IkgLastupUser { get; set; }

    [Column("ikg_lastup_date")]
    public DateTime? IkgLastupDate { get; set; }

    [Column("ikg_special1")]
    [StringLength(4)]
    public string? IkgSpecial1 { get; set; }

    [Column("ikg_special2")]
    [StringLength(4)]
    public string? IkgSpecial2 { get; set; }

    [Column("ikg_special3")]
    [StringLength(4)]
    public string? IkgSpecial3 { get; set; }

    [Column("ikg_firmano")]
    public int? IkgFirmano { get; set; }

    [Column("ikg_subeno")]
    public int? IkgSubeno { get; set; }

    [Column("ikg_tipi")]
    public byte? IkgTipi { get; set; }

    [Column("ikg_kod")]
    [StringLength(25)]
    public string? IkgKod { get; set; }

    [Column("ikg_adi")]
    [StringLength(40)]
    public string? IkgAdi { get; set; }

    [Column("ikg_kriter_kod")]
    [StringLength(25)]
    public string? IkgKriterKod { get; set; }
}
