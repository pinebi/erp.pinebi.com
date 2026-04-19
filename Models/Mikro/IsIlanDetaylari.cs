using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("is_ilan_detaylari")]
public class IsIlanDetaylari
{
    [Column("ild_Guid")]
    public Guid? IldGuid { get; set; }

    [Column("ild_DBCno")]
    public short? IldDBCno { get; set; }

    [Column("ild_SpecRECno")]
    public int? IldSpecRECno { get; set; }

    [Column("ild_iptal")]
    public bool? IldIptal { get; set; }

    [Column("ild_fileid")]
    public short? IldFileid { get; set; }

    [Column("ild_hidden")]
    public bool? IldHidden { get; set; }

    [Column("ild_kilitli")]
    public bool? IldKilitli { get; set; }

    [Column("ild_degisti")]
    public bool? IldDegisti { get; set; }

    [Column("ild_checksum")]
    public int? IldChecksum { get; set; }

    [Column("ild_create_user")]
    public short? IldCreateUser { get; set; }

    [Column("ild_create_date")]
    public DateTime? IldCreateDate { get; set; }

    [Column("ild_lastup_user")]
    public short? IldLastupUser { get; set; }

    [Column("ild_lastup_date")]
    public DateTime? IldLastupDate { get; set; }

    [Column("ild_special1")]
    [StringLength(4)]
    public string? IldSpecial1 { get; set; }

    [Column("ild_special2")]
    [StringLength(4)]
    public string? IldSpecial2 { get; set; }

    [Column("ild_special3")]
    [StringLength(4)]
    public string? IldSpecial3 { get; set; }

    [Column("ild_ilan_kodu")]
    [StringLength(25)]
    public string? IldIlanKodu { get; set; }

    [Column("ild_tipi")]
    public byte? IldTipi { get; set; }

    [Column("ild_kodu")]
    [StringLength(25)]
    public string? IldKodu { get; set; }

    [Column("ild_ilcekodu")]
    [StringLength(25)]
    public string? IldIlcekodu { get; set; }

    [Column("ild_aciklama1")]
    [StringLength(120)]
    public string? IldAciklama1 { get; set; }

    [Column("ild_aciklama2")]
    [StringLength(120)]
    public string? IldAciklama2 { get; set; }

    [Column("ild_aciklama3")]
    [StringLength(120)]
    public string? IldAciklama3 { get; set; }
}
