using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("departmanlar")]
public class Departmanlar
{
    [Column("pdp_Guid")]
    public Guid? PdpGuid { get; set; }

    [Column("pdp_DBCno")]
    public short? PdpDBCno { get; set; }

    [Column("pdp_SpecRECno")]
    public int? PdpSpecRECno { get; set; }

    [Column("pdp_iptal")]
    public bool? PdpIptal { get; set; }

    [Column("pdp_fileid")]
    public short? PdpFileid { get; set; }

    [Column("pdp_hidden")]
    public bool? PdpHidden { get; set; }

    [Column("pdp_kilitli")]
    public bool? PdpKilitli { get; set; }

    [Column("pdp_degisti")]
    public bool? PdpDegisti { get; set; }

    [Column("pdp_checksum")]
    public int? PdpChecksum { get; set; }

    [Column("pdp_create_user")]
    public short? PdpCreateUser { get; set; }

    [Column("pdp_create_date")]
    public DateTime? PdpCreateDate { get; set; }

    [Column("pdp_lastup_user")]
    public short? PdpLastupUser { get; set; }

    [Column("pdp_lastup_date")]
    public DateTime? PdpLastupDate { get; set; }

    [Column("pdp_special1")]
    [StringLength(4)]
    public string? PdpSpecial1 { get; set; }

    [Column("pdp_special2")]
    [StringLength(4)]
    public string? PdpSpecial2 { get; set; }

    [Column("pdp_special3")]
    [StringLength(4)]
    public string? PdpSpecial3 { get; set; }

    [Column("pdp_kodu")]
    [StringLength(25)]
    public string? PdpKodu { get; set; }

    [Column("pdp_adi")]
    [StringLength(40)]
    public string? PdpAdi { get; set; }

    [Column("pdp_muhkodu")]
    [StringLength(10)]
    public string? PdpMuhkodu { get; set; }

    [Column("pdp_sormer")]
    [StringLength(25)]
    public string? PdpSormer { get; set; }

    [Column("pdp_KTprimyuzde")]
    public double? PdpKTprimyuzde { get; set; }

    [Column("pdp_TTprimyuzde")]
    public double? PdpTTprimyuzde { get; set; }

    [Column("pdp_projekodu")]
    [StringLength(25)]
    public string? PdpProjekodu { get; set; }

    [Column("pdp_calismakodu")]
    [StringLength(25)]
    public string? PdpCalismakodu { get; set; }
}
