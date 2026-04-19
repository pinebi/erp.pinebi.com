using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sinav_soru_tanimlari")]
public class PersonelSinavSoruTanimlari
{
    [Column("pst_Guid")]
    public Guid? PstGuid { get; set; }

    [Column("pst_DBCno")]
    public short? PstDBCno { get; set; }

    [Column("pst_SpecRECno")]
    public int? PstSpecRECno { get; set; }

    [Column("pst_iptal")]
    public bool? PstIptal { get; set; }

    [Column("pst_fileid")]
    public short? PstFileid { get; set; }

    [Column("pst_hidden")]
    public bool? PstHidden { get; set; }

    [Column("pst_kilitli")]
    public bool? PstKilitli { get; set; }

    [Column("pst_degisti")]
    public bool? PstDegisti { get; set; }

    [Column("pst_checksum")]
    public int? PstChecksum { get; set; }

    [Column("pst_create_user")]
    public short? PstCreateUser { get; set; }

    [Column("pst_create_date")]
    public DateTime? PstCreateDate { get; set; }

    [Column("pst_lastup_user")]
    public short? PstLastupUser { get; set; }

    [Column("pst_lastup_date")]
    public DateTime? PstLastupDate { get; set; }

    [Column("pst_special1")]
    [StringLength(4)]
    public string? PstSpecial1 { get; set; }

    [Column("pst_special2")]
    [StringLength(4)]
    public string? PstSpecial2 { get; set; }

    [Column("pst_special3")]
    [StringLength(4)]
    public string? PstSpecial3 { get; set; }

    [Column("pst_kodu")]
    [StringLength(25)]
    public string? PstKodu { get; set; }

    [Column("pst_soru")]
    [StringLength(120)]
    public string? PstSoru { get; set; }

    [Column("pst_sorutipi")]
    public byte? PstSorutipi { get; set; }
}
