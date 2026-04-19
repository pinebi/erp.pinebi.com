using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_sektorleri")]
public class StokSektorleri
{
    [Column("sktr_Guid")]
    public Guid SktrGuid { get; set; }

    [Column("sktr_DBCno")]
    public short? SktrDBCno { get; set; }

    [Column("sktr_SpecRECno")]
    public int? SktrSpecRECno { get; set; }

    [Column("sktr_iptal")]
    public bool? SktrIptal { get; set; }

    [Column("sktr_fileid")]
    public short? SktrFileid { get; set; }

    [Column("sktr_hidden")]
    public bool? SktrHidden { get; set; }

    [Column("sktr_kilitli")]
    public bool? SktrKilitli { get; set; }

    [Column("sktr_degisti")]
    public bool? SktrDegisti { get; set; }

    [Column("sktr_checksum")]
    public int? SktrChecksum { get; set; }

    [Column("sktr_create_user")]
    public short? SktrCreateUser { get; set; }

    [Column("sktr_create_date")]
    public DateTime? SktrCreateDate { get; set; }

    [Column("sktr_lastup_user")]
    public short? SktrLastupUser { get; set; }

    [Column("sktr_lastup_date")]
    public DateTime? SktrLastupDate { get; set; }

    [Column("sktr_special1")]
    [StringLength(4)]
    public string? SktrSpecial1 { get; set; }

    [Column("sktr_special2")]
    [StringLength(4)]
    public string? SktrSpecial2 { get; set; }

    [Column("sktr_special3")]
    [StringLength(4)]
    public string? SktrSpecial3 { get; set; }

    [Column("sktr_kod")]
    [StringLength(25)]
    public string SktrKod { get; set; }

    [Column("sktr_ismi")]
    [StringLength(40)]
    public string? SktrIsmi { get; set; }

    [Column("sktr_muhkodu")]
    [StringLength(4)]
    public string? SktrMuhkodu { get; set; }
}
