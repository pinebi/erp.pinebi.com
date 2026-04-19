using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sinav_sorulari")]
public class PersonelSinavSorulari
{
    [Column("pss_Guid")]
    public Guid? PssGuid { get; set; }

    [Column("pss_DBCno")]
    public short? PssDBCno { get; set; }

    [Column("pss_SpecRECno")]
    public int? PssSpecRECno { get; set; }

    [Column("pss_iptal")]
    public bool? PssIptal { get; set; }

    [Column("pss_fileid")]
    public short? PssFileid { get; set; }

    [Column("pss_hidden")]
    public bool? PssHidden { get; set; }

    [Column("pss_kilitli")]
    public bool? PssKilitli { get; set; }

    [Column("pss_degisti")]
    public bool? PssDegisti { get; set; }

    [Column("pss_checksum")]
    public int? PssChecksum { get; set; }

    [Column("pss_create_user")]
    public short? PssCreateUser { get; set; }

    [Column("pss_create_date")]
    public DateTime? PssCreateDate { get; set; }

    [Column("pss_lastup_user")]
    public short? PssLastupUser { get; set; }

    [Column("pss_lastup_date")]
    public DateTime? PssLastupDate { get; set; }

    [Column("pss_special1")]
    [StringLength(4)]
    public string? PssSpecial1 { get; set; }

    [Column("pss_special2")]
    [StringLength(4)]
    public string? PssSpecial2 { get; set; }

    [Column("pss_special3")]
    [StringLength(4)]
    public string? PssSpecial3 { get; set; }

    [Column("pss_tipi")]
    public byte? PssTipi { get; set; }

    [Column("pss_kodu")]
    [StringLength(25)]
    public string? PssKodu { get; set; }

    [Column("pss_sorukodu")]
    [StringLength(25)]
    public string? PssSorukodu { get; set; }

    [Column("pss_puan")]
    public double? PssPuan { get; set; }

    [Column("pss_olculennitelik")]
    [StringLength(25)]
    public string? PssOlculennitelik { get; set; }
}
