using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_birimleri")]
public class StokBirimleri
{
    [Column("unit_Guid")]
    [StringLength(50)]
    public string? UnitGuid { get; set; }

    [Column("unit_DBCno")]
    public short? UnitDBCno { get; set; }

    [Column("unit_SpecRECno")]
    public int? UnitSpecRECno { get; set; }

    [Column("unit_iptal")]
    public bool? UnitIptal { get; set; }

    [Column("unit_fileid")]
    public short? UnitFileid { get; set; }

    [Column("unit_hidden")]
    public bool? UnitHidden { get; set; }

    [Column("unit_kilitli")]
    public bool? UnitKilitli { get; set; }

    [Column("unit_degisti")]
    public bool? UnitDegisti { get; set; }

    [Column("unit_checksum")]
    public int? UnitChecksum { get; set; }

    [Column("unit_create_user")]
    public short? UnitCreateUser { get; set; }

    [Column("unit_create_date")]
    public DateTime? UnitCreateDate { get; set; }

    [Column("unit_lastup_user")]
    public short? UnitLastupUser { get; set; }

    [Column("unit_lastup_date")]
    public DateTime? UnitLastupDate { get; set; }

    [Column("unit_special1")]
    [StringLength(4)]
    public string? UnitSpecial1 { get; set; }

    [Column("unit_special2")]
    [StringLength(4)]
    public string? UnitSpecial2 { get; set; }

    [Column("unit_special3")]
    [StringLength(4)]
    public string? UnitSpecial3 { get; set; }

    [Column("unit_ismi")]
    [StringLength(10)]
    public string? UnitIsmi { get; set; }

    [Column("unit_tipi")]
    public byte? UnitTipi { get; set; }

    [Column("unit_UC_kod")]
    [StringLength(10)]
    public string? UnitUCKod { get; set; }
}
