using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("unitcode_tanimlari")]
public class UnitcodeTanimlari
{
    [Column("UC_Guid")]
    public Guid? UCGuid { get; set; }

    [Column("UC_DBCno")]
    public short? UCDBCno { get; set; }

    [Column("UC_SpecRECno")]
    public int? UCSpecRECno { get; set; }

    [Column("UC_iptal")]
    public bool? UCIptal { get; set; }

    [Column("UC_fileid")]
    public short? UCFileid { get; set; }

    [Column("UC_hidden")]
    public bool? UCHidden { get; set; }

    [Column("UC_kilitli")]
    public bool? UCKilitli { get; set; }

    [Column("UC_degisti")]
    public bool? UCDegisti { get; set; }

    [Column("UC_checksum")]
    public int? UCChecksum { get; set; }

    [Column("UC_create_user")]
    public short? UCCreateUser { get; set; }

    [Column("UC_create_date")]
    public DateTime? UCCreateDate { get; set; }

    [Column("UC_lastup_user")]
    public short? UCLastupUser { get; set; }

    [Column("UC_lastup_date")]
    public DateTime? UCLastupDate { get; set; }

    [Column("UC_special1")]
    [StringLength(4)]
    public string? UCSpecial1 { get; set; }

    [Column("UC_special2")]
    [StringLength(4)]
    public string? UCSpecial2 { get; set; }

    [Column("UC_special3")]
    [StringLength(4)]
    public string? UCSpecial3 { get; set; }

    [Column("UC_kod")]
    [StringLength(10)]
    public string? UCKod { get; set; }

    [Column("UC_ismi")]
    [StringLength(70)]
    public string? UCIsmi { get; set; }

    [Column("UC_aciklama")]
    [StringLength(70)]
    public string? UCAciklama { get; set; }

    [Column("UC_tipi")]
    public byte? UCTipi { get; set; }
}
