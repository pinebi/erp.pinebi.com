using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ik_kriter_tanimlari")]
public class IkKriterTanimlari
{
    [Column("ikk_Guid")]
    public Guid? IkkGuid { get; set; }

    [Column("ikk_DBCno")]
    public short? IkkDBCno { get; set; }

    [Column("ikk_SpecRECno")]
    public int? IkkSpecRECno { get; set; }

    [Column("ikk_iptal")]
    public bool? IkkIptal { get; set; }

    [Column("ikk_fileid")]
    public short? IkkFileid { get; set; }

    [Column("ikk_hidden")]
    public bool? IkkHidden { get; set; }

    [Column("ikk_kilitli")]
    public bool? IkkKilitli { get; set; }

    [Column("ikk_degisti")]
    public bool? IkkDegisti { get; set; }

    [Column("ikk_checksum")]
    public int? IkkChecksum { get; set; }

    [Column("ikk_create_user")]
    public short? IkkCreateUser { get; set; }

    [Column("ikk_create_date")]
    public DateTime? IkkCreateDate { get; set; }

    [Column("ikk_lastup_user")]
    public short? IkkLastupUser { get; set; }

    [Column("ikk_lastup_date")]
    public DateTime? IkkLastupDate { get; set; }

    [Column("ikk_special1")]
    [StringLength(4)]
    public string? IkkSpecial1 { get; set; }

    [Column("ikk_special2")]
    [StringLength(4)]
    public string? IkkSpecial2 { get; set; }

    [Column("ikk_special3")]
    [StringLength(4)]
    public string? IkkSpecial3 { get; set; }

    [Column("ikk_firmano")]
    public int? IkkFirmano { get; set; }

    [Column("ikk_subeno")]
    public int? IkkSubeno { get; set; }

    [Column("ikk_tipi")]
    public byte? IkkTipi { get; set; }

    [Column("ikk_kodu")]
    [StringLength(25)]
    public string? IkkKodu { get; set; }

    [Column("ikk_adi")]
    [StringLength(70)]
    public string? IkkAdi { get; set; }

    [Column("ikk_uzunadi")]
    [StringLength(120)]
    public string? IkkUzunadi { get; set; }

    [Column("ikk_aciklama1")]
    [StringLength(120)]
    public string? IkkAciklama1 { get; set; }

    [Column("ikk_aciklama2")]
    [StringLength(120)]
    public string? IkkAciklama2 { get; set; }

    [Column("ikk_aciklama3")]
    [StringLength(120)]
    public string? IkkAciklama3 { get; set; }

    [Column("ikk_maxpuan")]
    public double? IkkMaxpuan { get; set; }

    [Column("ikk_agirlikort")]
    public double? IkkAgirlikort { get; set; }
}
