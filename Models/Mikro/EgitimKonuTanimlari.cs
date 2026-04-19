using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("egitim_konu_tanimlari")]
public class EgitimKonuTanimlari
{
    [Column("ekonu_Guid")]
    public Guid? EkonuGuid { get; set; }

    [Column("ekonu_DBCno")]
    public short? EkonuDBCno { get; set; }

    [Column("ekonu_SpecRECno")]
    public int? EkonuSpecRECno { get; set; }

    [Column("ekonu_iptal")]
    public bool? EkonuIptal { get; set; }

    [Column("ekonu_fileid")]
    public short? EkonuFileid { get; set; }

    [Column("ekonu_hidden")]
    public bool? EkonuHidden { get; set; }

    [Column("ekonu_kilitli")]
    public bool? EkonuKilitli { get; set; }

    [Column("ekonu_degisti")]
    public bool? EkonuDegisti { get; set; }

    [Column("ekonu_checksum")]
    public int? EkonuChecksum { get; set; }

    [Column("ekonu_create_user")]
    public short? EkonuCreateUser { get; set; }

    [Column("ekonu_create_date")]
    public DateTime? EkonuCreateDate { get; set; }

    [Column("ekonu_lastup_user")]
    public short? EkonuLastupUser { get; set; }

    [Column("ekonu_lastup_date")]
    public DateTime? EkonuLastupDate { get; set; }

    [Column("ekonu_special1")]
    [StringLength(4)]
    public string? EkonuSpecial1 { get; set; }

    [Column("ekonu_special2")]
    [StringLength(4)]
    public string? EkonuSpecial2 { get; set; }

    [Column("ekonu_special3")]
    [StringLength(4)]
    public string? EkonuSpecial3 { get; set; }

    [Column("ekonu_kodu")]
    [StringLength(25)]
    public string? EkonuKodu { get; set; }

    [Column("ekonu_adi")]
    [StringLength(40)]
    public string? EkonuAdi { get; set; }

    [Column("ekonu_tip")]
    public byte? EkonuTip { get; set; }

    [Column("eaciklama1")]
    [StringLength(120)]
    public string? Eaciklama1 { get; set; }

    [Column("eaciklama2")]
    [StringLength(120)]
    public string? Eaciklama2 { get; set; }

    [Column("eaciklama3")]
    [StringLength(120)]
    public string? Eaciklama3 { get; set; }
}
