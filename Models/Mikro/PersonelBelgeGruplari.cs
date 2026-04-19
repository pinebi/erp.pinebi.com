using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_belge_gruplari")]
public class PersonelBelgeGruplari
{
    [Column("bgr_Guid")]
    public Guid? BgrGuid { get; set; }

    [Column("bgr_DBCno")]
    public short? BgrDBCno { get; set; }

    [Column("bgr_SpecRECno")]
    public int? BgrSpecRECno { get; set; }

    [Column("bgr_iptal")]
    public bool? BgrIptal { get; set; }

    [Column("bgr_fileid")]
    public short? BgrFileid { get; set; }

    [Column("bgr_hidden")]
    public bool? BgrHidden { get; set; }

    [Column("bgr_kilitli")]
    public bool? BgrKilitli { get; set; }

    [Column("bgr_degisti")]
    public bool? BgrDegisti { get; set; }

    [Column("bgr_checksum")]
    public int? BgrChecksum { get; set; }

    [Column("bgr_create_user")]
    public short? BgrCreateUser { get; set; }

    [Column("bgr_create_date")]
    public DateTime? BgrCreateDate { get; set; }

    [Column("bgr_lastup_user")]
    public short? BgrLastupUser { get; set; }

    [Column("bgr_lastup_date")]
    public DateTime? BgrLastupDate { get; set; }

    [Column("bgr_special1")]
    [StringLength(4)]
    public string? BgrSpecial1 { get; set; }

    [Column("bgr_special2")]
    [StringLength(4)]
    public string? BgrSpecial2 { get; set; }

    [Column("bgr_special3")]
    [StringLength(4)]
    public string? BgrSpecial3 { get; set; }

    [Column("bgr_firmano")]
    public int? BgrFirmano { get; set; }

    [Column("bgr_subeno")]
    public int? BgrSubeno { get; set; }

    [Column("bgr_kod")]
    [StringLength(25)]
    public string? BgrKod { get; set; }

    [Column("bgr_isim")]
    [StringLength(40)]
    public string? BgrIsim { get; set; }

    [Column("bgr_belge_kod")]
    [StringLength(25)]
    public string? BgrBelgeKod { get; set; }

    [Column("bgr_zorunlu_fl")]
    public bool? BgrZorunluFl { get; set; }
}
