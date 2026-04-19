using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("rakip_stok_depo_detaylari")]
public class RakipStokDepoDetaylari
{
    [Column("rsdp_Guid")]
    public Guid? RsdpGuid { get; set; }

    [Column("rsdp_DBCno")]
    public short? RsdpDBCno { get; set; }

    [Column("rsdp_SpecRECno")]
    public int? RsdpSpecRECno { get; set; }

    [Column("rsdp_iptal")]
    public bool? RsdpIptal { get; set; }

    [Column("rsdp_fileid")]
    public short? RsdpFileid { get; set; }

    [Column("rsdp_hidden")]
    public bool? RsdpHidden { get; set; }

    [Column("rsdp_kilitli")]
    public bool? RsdpKilitli { get; set; }

    [Column("rsdp_degisti")]
    public bool? RsdpDegisti { get; set; }

    [Column("rsdp_checksum")]
    public int? RsdpChecksum { get; set; }

    [Column("rsdp_create_user")]
    public short? RsdpCreateUser { get; set; }

    [Column("rsdp_create_date")]
    public DateTime? RsdpCreateDate { get; set; }

    [Column("rsdp_lastup_user")]
    public short? RsdpLastupUser { get; set; }

    [Column("rsdp_lastup_date")]
    public DateTime? RsdpLastupDate { get; set; }

    [Column("rsdp_special1")]
    [StringLength(4)]
    public string? RsdpSpecial1 { get; set; }

    [Column("rsdp_special2")]
    [StringLength(4)]
    public string? RsdpSpecial2 { get; set; }

    [Column("rsdp_special3")]
    [StringLength(4)]
    public string? RsdpSpecial3 { get; set; }

    [Column("rsdp_depo_kod")]
    [StringLength(25)]
    public string? RsdpDepoKod { get; set; }

    [Column("rsdp_depo_no")]
    public int? RsdpDepoNo { get; set; }

    [Column("rsdp_kar_orani")]
    public double? RsdpKarOrani { get; set; }

    [Column("rsdp_satisfiat")]
    public double? RsdpSatisfiat { get; set; }

    [Column("rsdp_fiat_doviz")]
    public byte? RsdpFiatDoviz { get; set; }

    [Column("rsdp_fiat_opno")]
    public int? RsdpFiatOpno { get; set; }

    [Column("rsdp_fiat_isk_kod")]
    [StringLength(4)]
    public string? RsdpFiatIskKod { get; set; }

    [Column("rsdp_kdvdahil")]
    public bool? RsdpKdvdahil { get; set; }
}
