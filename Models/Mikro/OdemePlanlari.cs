using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("odeme_planlari")]
public class OdemePlanlari
{
    [Column("odp_Guid")]
    public Guid? OdpGuid { get; set; }

    [Column("odp_DBCno")]
    public short? OdpDBCno { get; set; }

    [Column("odp_SpecRECno")]
    public int? OdpSpecRECno { get; set; }

    [Column("odp_iptal")]
    public bool? OdpIptal { get; set; }

    [Column("odp_fileid")]
    public short? OdpFileid { get; set; }

    [Column("odp_hidden")]
    public bool? OdpHidden { get; set; }

    [Column("odp_kilitli")]
    public bool? OdpKilitli { get; set; }

    [Column("odp_degisti")]
    public bool? OdpDegisti { get; set; }

    [Column("odp_checksum")]
    public int? OdpChecksum { get; set; }

    [Column("odp_create_user")]
    public short? OdpCreateUser { get; set; }

    [Column("odp_create_date")]
    public DateTime? OdpCreateDate { get; set; }

    [Column("odp_lastup_user")]
    public short? OdpLastupUser { get; set; }

    [Column("odp_lastup_date")]
    public DateTime? OdpLastupDate { get; set; }

    [Column("odp_special1")]
    [StringLength(4)]
    public string? OdpSpecial1 { get; set; }

    [Column("odp_special2")]
    [StringLength(4)]
    public string? OdpSpecial2 { get; set; }

    [Column("odp_special3")]
    [StringLength(4)]
    public string? OdpSpecial3 { get; set; }

    [Column("odp_no")]
    public int? OdpNo { get; set; }

    [Column("odp_kodu")]
    [StringLength(25)]
    public string? OdpKodu { get; set; }

    [Column("odp_adi")]
    [StringLength(50)]
    public string? OdpAdi { get; set; }

    [Column("odp_aratop")]
    [StringLength(127)]
    public string? OdpAratop { get; set; }

    [Column("odp_masraf")]
    [StringLength(127)]
    public string? OdpMasraf { get; set; }

    [Column("odp_vergi")]
    [StringLength(127)]
    public string? OdpVergi { get; set; }

    [Column("odp_ortgun")]
    public int? OdpOrtgun { get; set; }
}
