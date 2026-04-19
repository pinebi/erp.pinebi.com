using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_vardiya_satislari")]
public class IstasyonVardiyaSatislari
{
    [Column("vp_Guid")]
    public Guid? VpGuid { get; set; }

    [Column("vp_DBCno")]
    public short? VpDBCno { get; set; }

    [Column("vp_SpecRECno")]
    public int? VpSpecRECno { get; set; }

    [Column("vp_iptal")]
    public bool? VpIptal { get; set; }

    [Column("vp_fileid")]
    public short? VpFileid { get; set; }

    [Column("vp_hidden")]
    public bool? VpHidden { get; set; }

    [Column("vp_kilitli")]
    public bool? VpKilitli { get; set; }

    [Column("vp_degisti")]
    public bool? VpDegisti { get; set; }

    [Column("vp_checksum")]
    public int? VpChecksum { get; set; }

    [Column("vp_create_user")]
    public short? VpCreateUser { get; set; }

    [Column("vp_create_date")]
    public DateTime? VpCreateDate { get; set; }

    [Column("vp_lastup_user")]
    public short? VpLastupUser { get; set; }

    [Column("vp_lastup_date")]
    public DateTime? VpLastupDate { get; set; }

    [Column("vp_special1")]
    [StringLength(4)]
    public string? VpSpecial1 { get; set; }

    [Column("vp_special2")]
    [StringLength(4)]
    public string? VpSpecial2 { get; set; }

    [Column("vp_special3")]
    [StringLength(4)]
    public string? VpSpecial3 { get; set; }

    [Column("vp_firmano")]
    public int? VpFirmano { get; set; }

    [Column("vp_subeno")]
    public int? VpSubeno { get; set; }

    [Column("vp_tarihi")]
    public DateTime? VpTarihi { get; set; }

    [Column("vp_Numarasi")]
    public byte? VpNumarasi { get; set; }

    [Column("vp_pers_kodu")]
    [StringLength(10)]
    public string? VpPersKodu { get; set; }

    [Column("vp_stok_kodu")]
    [StringLength(25)]
    public string? VpStokKodu { get; set; }

    [Column("vp_satis_miktari")]
    public double? VpSatisMiktari { get; set; }

    [Column("vp_satis_tutari")]
    public double? VpSatisTutari { get; set; }
}
