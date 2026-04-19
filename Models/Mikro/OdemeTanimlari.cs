using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("odeme_tanimlari")]
public class OdemeTanimlari
{
    [Column("odm_Guid")]
    public Guid? OdmGuid { get; set; }

    [Column("odm_DBCno")]
    public short? OdmDBCno { get; set; }

    [Column("odm_SpecRECNo")]
    public int? OdmSpecRECNo { get; set; }

    [Column("odm_iptal")]
    public bool? OdmIptal { get; set; }

    [Column("odm_fileid")]
    public short? OdmFileid { get; set; }

    [Column("odm_hidden")]
    public bool? OdmHidden { get; set; }

    [Column("odm_kilitli")]
    public bool? OdmKilitli { get; set; }

    [Column("odm_degisti")]
    public bool? OdmDegisti { get; set; }

    [Column("odm_checksum")]
    public int? OdmChecksum { get; set; }

    [Column("odm_create_user")]
    public short? OdmCreateUser { get; set; }

    [Column("odm_create_date")]
    public DateTime? OdmCreateDate { get; set; }

    [Column("odm_lastup_user")]
    public short? OdmLastupUser { get; set; }

    [Column("odm_lastup_date")]
    public DateTime? OdmLastupDate { get; set; }

    [Column("odm_special1")]
    [StringLength(4)]
    public string? OdmSpecial1 { get; set; }

    [Column("odm_special2")]
    [StringLength(4)]
    public string? OdmSpecial2 { get; set; }

    [Column("odm_special3")]
    [StringLength(4)]
    public string? OdmSpecial3 { get; set; }

    [Column("odm_kodu")]
    [StringLength(4)]
    public string? OdmKodu { get; set; }

    [Column("odm_tanimi")]
    [StringLength(120)]
    public string? OdmTanimi { get; set; }
}
