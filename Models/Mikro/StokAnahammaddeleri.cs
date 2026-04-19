using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_anahammaddeleri")]
public class StokAnahammaddeleri
{
    [Column("ahm_Guid")]
    public Guid? AhmGuid { get; set; }

    [Column("ahm_DBCno")]
    public short? AhmDBCno { get; set; }

    [Column("ahm_SpecRECNo")]
    public int? AhmSpecRECNo { get; set; }

    [Column("ahm_iptal")]
    public bool? AhmIptal { get; set; }

    [Column("ahm_fileid")]
    public short? AhmFileid { get; set; }

    [Column("ahm_hidden")]
    public bool? AhmHidden { get; set; }

    [Column("ahm_kilitli")]
    public bool? AhmKilitli { get; set; }

    [Column("ahm_degisti")]
    public bool? AhmDegisti { get; set; }

    [Column("ahm_CheckSum")]
    public int? AhmCheckSum { get; set; }

    [Column("ahm_create_user")]
    public short? AhmCreateUser { get; set; }

    [Column("ahm_create_date")]
    public DateTime? AhmCreateDate { get; set; }

    [Column("ahm_lastup_user")]
    public short? AhmLastupUser { get; set; }

    [Column("ahm_lastup_date")]
    public DateTime? AhmLastupDate { get; set; }

    [Column("ahm_special1")]
    [StringLength(4)]
    public string? AhmSpecial1 { get; set; }

    [Column("ahm_special2")]
    [StringLength(4)]
    public string? AhmSpecial2 { get; set; }

    [Column("ahm_special3")]
    [StringLength(4)]
    public string? AhmSpecial3 { get; set; }

    [Column("ahm_kodu")]
    [StringLength(25)]
    public string? AhmKodu { get; set; }

    [Column("ahm_ismi")]
    [StringLength(40)]
    public string? AhmIsmi { get; set; }
}
