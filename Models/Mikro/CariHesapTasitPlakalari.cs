using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_tasit_plakalari")]
public class CariHesapTasitPlakalari
{
    [Column("plk_Guid")]
    public Guid? PlkGuid { get; set; }

    [Column("plk_DBCno")]
    public short? PlkDBCno { get; set; }

    [Column("plk_SpecRECno")]
    public int? PlkSpecRECno { get; set; }

    [Column("plk_iptal")]
    public bool? PlkIptal { get; set; }

    [Column("plk_fileid")]
    public short? PlkFileid { get; set; }

    [Column("plk_hidden")]
    public bool? PlkHidden { get; set; }

    [Column("plk_kilitli")]
    public bool? PlkKilitli { get; set; }

    [Column("plk_degisti")]
    public bool? PlkDegisti { get; set; }

    [Column("plk_checksum")]
    public int? PlkChecksum { get; set; }

    [Column("plk_create_user")]
    public short? PlkCreateUser { get; set; }

    [Column("plk_create_date")]
    public DateTime? PlkCreateDate { get; set; }

    [Column("plk_lastup_user")]
    public short? PlkLastupUser { get; set; }

    [Column("plk_lastup_date")]
    public DateTime? PlkLastupDate { get; set; }

    [Column("plk_special1")]
    [StringLength(4)]
    public string? PlkSpecial1 { get; set; }

    [Column("plk_special2")]
    [StringLength(4)]
    public string? PlkSpecial2 { get; set; }

    [Column("plk_special3")]
    [StringLength(4)]
    public string? PlkSpecial3 { get; set; }

    [Column("plk_kod")]
    [StringLength(25)]
    public string? PlkKod { get; set; }

    [Column("plk_arac")]
    [StringLength(30)]
    public string? PlkArac { get; set; }

    [Column("plk_musterikodu")]
    [StringLength(25)]
    public string? PlkMusterikodu { get; set; }
}
