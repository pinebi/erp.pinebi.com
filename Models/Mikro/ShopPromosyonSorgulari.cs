using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("shop_promosyon_sorgulari")]
public class ShopPromosyonSorgulari
{
    [Column("prq_Guid")]
    public Guid? PrqGuid { get; set; }

    [Column("prq_DBCno")]
    public short? PrqDBCno { get; set; }

    [Column("prq_SpecRECNo")]
    public int? PrqSpecRECNo { get; set; }

    [Column("prq_iptal")]
    public bool? PrqIptal { get; set; }

    [Column("prq_fileid")]
    public short? PrqFileid { get; set; }

    [Column("prq_hidden")]
    public bool? PrqHidden { get; set; }

    [Column("prq_kilitli")]
    public bool? PrqKilitli { get; set; }

    [Column("prq_degisti")]
    public bool? PrqDegisti { get; set; }

    [Column("prq_checksum")]
    public int? PrqChecksum { get; set; }

    [Column("prq_create_user")]
    public short? PrqCreateUser { get; set; }

    [Column("prq_create_date")]
    public DateTime? PrqCreateDate { get; set; }

    [Column("prq_lastup_user")]
    public short? PrqLastupUser { get; set; }

    [Column("prq_lastup_date")]
    public DateTime? PrqLastupDate { get; set; }

    [Column("prq_special1")]
    [StringLength(4)]
    public string? PrqSpecial1 { get; set; }

    [Column("prq_special2")]
    [StringLength(4)]
    public string? PrqSpecial2 { get; set; }

    [Column("prq_special3")]
    [StringLength(4)]
    public string? PrqSpecial3 { get; set; }

    [Column("prq_kodu")]
    [StringLength(50)]
    public string? PrqKodu { get; set; }

    [Column("prq_ismi")]
    [StringLength(100)]
    public string? PrqIsmi { get; set; }

    [Column("prq_tipi")]
    public byte? PrqTipi { get; set; }

    [Column("prq_pos_tipleri")]
    public byte? PrqPosTipleri { get; set; }

    [Column("prq_ozellikler")]
    public byte? PrqOzellikler { get; set; }
}
