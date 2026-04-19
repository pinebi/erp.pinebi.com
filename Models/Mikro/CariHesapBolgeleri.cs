using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_bolgeleri")]
public class CariHesapBolgeleri
{
    [Column("bol_Guid")]
    public Guid? BolGuid { get; set; }

    [Column("bol_DBCno")]
    public short? BolDBCno { get; set; }

    [Column("bol_SpecRECno")]
    public int? BolSpecRECno { get; set; }

    [Column("bol_iptal")]
    public bool? BolIptal { get; set; }

    [Column("bol_fileid")]
    public short? BolFileid { get; set; }

    [Column("bol_hidden")]
    public bool? BolHidden { get; set; }

    [Column("bol_kilitli")]
    public bool? BolKilitli { get; set; }

    [Column("bol_degisti")]
    public bool? BolDegisti { get; set; }

    [Column("bol_checksum")]
    public int? BolChecksum { get; set; }

    [Column("bol_create_user")]
    public short? BolCreateUser { get; set; }

    [Column("bol_create_date")]
    public DateTime? BolCreateDate { get; set; }

    [Column("bol_lastup_user")]
    public short? BolLastupUser { get; set; }

    [Column("bol_lastup_date")]
    public DateTime? BolLastupDate { get; set; }

    [Column("bol_special1")]
    [StringLength(4)]
    public string? BolSpecial1 { get; set; }

    [Column("bol_special2")]
    [StringLength(4)]
    public string? BolSpecial2 { get; set; }

    [Column("bol_special3")]
    [StringLength(4)]
    public string? BolSpecial3 { get; set; }

    [Column("bol_kod")]
    [StringLength(25)]
    public string? BolKod { get; set; }

    [Column("bol_ismi")]
    [StringLength(40)]
    public string? BolIsmi { get; set; }
}
