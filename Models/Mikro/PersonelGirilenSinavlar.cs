using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_girilen_sinavlar")]
public class PersonelGirilenSinavlar
{
    [Column("asn_Guid")]
    public Guid? AsnGuid { get; set; }

    [Column("asn_DBCno")]
    public short? AsnDBCno { get; set; }

    [Column("asn_SpecRECno")]
    public int? AsnSpecRECno { get; set; }

    [Column("asn_iptal")]
    public bool? AsnIptal { get; set; }

    [Column("asn_fileid")]
    public short? AsnFileid { get; set; }

    [Column("asn_hidden")]
    public bool? AsnHidden { get; set; }

    [Column("asn_kilitli")]
    public bool? AsnKilitli { get; set; }

    [Column("asn_degisti")]
    public bool? AsnDegisti { get; set; }

    [Column("asn_checksum")]
    public int? AsnChecksum { get; set; }

    [Column("asn_create_user")]
    public short? AsnCreateUser { get; set; }

    [Column("asn_create_date")]
    public DateTime? AsnCreateDate { get; set; }

    [Column("asn_lastup_user")]
    public short? AsnLastupUser { get; set; }

    [Column("asn_lastup_date")]
    public DateTime? AsnLastupDate { get; set; }

    [Column("asn_special1")]
    [StringLength(4)]
    public string? AsnSpecial1 { get; set; }

    [Column("asn_special2")]
    [StringLength(4)]
    public string? AsnSpecial2 { get; set; }

    [Column("asn_special3")]
    [StringLength(4)]
    public string? AsnSpecial3 { get; set; }

    [Column("asn_tarih")]
    public DateTime? AsnTarih { get; set; }

    [Column("asn_kapsam")]
    public byte? AsnKapsam { get; set; }

    [Column("asn_per_kodu")]
    [StringLength(25)]
    public string? AsnPerKodu { get; set; }

    [Column("asn_sinav_kodu")]
    [StringLength(25)]
    public string? AsnSinavKodu { get; set; }

    [Column("asn_puan")]
    public double? AsnPuan { get; set; }

    [Column("asn_aciklama")]
    [StringLength(80)]
    public string? AsnAciklama { get; set; }

    [Column("asn_sinav_yeri")]
    [StringLength(25)]
    public string? AsnSinavYeri { get; set; }

    [Column("asn_sinavi_yapan_tipi")]
    public byte? AsnSinaviYapanTipi { get; set; }

    [Column("asn_sinavi_yapan")]
    [StringLength(25)]
    public string? AsnSinaviYapan { get; set; }
}
