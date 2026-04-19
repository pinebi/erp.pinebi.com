using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("gtip_tanimlari")]
public class GtipTanimlari
{
    [Column("gtip_Guid")]
    public Guid? GtipGuid { get; set; }

    [Column("gtip_DBCno")]
    public short? GtipDBCno { get; set; }

    [Column("gtip_SpecRecNo")]
    public int? GtipSpecRecNo { get; set; }

    [Column("gtip_iptal")]
    public bool? GtipIptal { get; set; }

    [Column("gtip_fileid")]
    public short? GtipFileid { get; set; }

    [Column("gtip_hidden")]
    public bool? GtipHidden { get; set; }

    [Column("gtip_kilitli")]
    public bool? GtipKilitli { get; set; }

    [Column("gtip_degisti")]
    public bool? GtipDegisti { get; set; }

    [Column("gtip_checksum")]
    public int? GtipChecksum { get; set; }

    [Column("gtip_create_user")]
    public short? GtipCreateUser { get; set; }

    [Column("gtip_create_date")]
    public DateTime? GtipCreateDate { get; set; }

    [Column("gtip_lastup_user")]
    public short? GtipLastupUser { get; set; }

    [Column("gtip_lastup_date")]
    public DateTime? GtipLastupDate { get; set; }

    [Column("gtip_special1")]
    [StringLength(4)]
    public string? GtipSpecial1 { get; set; }

    [Column("gtip_special2")]
    [StringLength(4)]
    public string? GtipSpecial2 { get; set; }

    [Column("gtip_special3")]
    [StringLength(4)]
    public string? GtipSpecial3 { get; set; }

    [Column("gtip_kodu")]
    [StringLength(25)]
    public string? GtipKodu { get; set; }

    [Column("gtip_aciklama")]
    [StringLength(50)]
    public string? GtipAciklama { get; set; }

    [Column("gtip_birimi")]
    [StringLength(10)]
    public string? GtipBirimi { get; set; }

    [Column("gtip_birimi2")]
    [StringLength(10)]
    public string? GtipBirimi2 { get; set; }

    [Column("gtip_detaytanim")]
    [StringLength(127)]
    public string? GtipDetaytanim { get; set; }

    [Column("gtip_detaytanim2")]
    [StringLength(127)]
    public string? GtipDetaytanim2 { get; set; }

    [Column("gtip_vergi_haddi")]
    public double? GtipVergiHaddi { get; set; }
}
