using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_degerlendirme_formu")]
public class CariDegerlendirmeFormu
{
    [Column("cdf_Guid")]
    public Guid? CdfGuid { get; set; }

    [Column("cdf_DBCno")]
    public short? CdfDBCno { get; set; }

    [Column("cdf_SpecRECno")]
    public int? CdfSpecRECno { get; set; }

    [Column("cdf_iptal")]
    public bool? CdfIptal { get; set; }

    [Column("cdf_fileid")]
    public short? CdfFileid { get; set; }

    [Column("cdf_hidden")]
    public bool? CdfHidden { get; set; }

    [Column("cdf_kilitli")]
    public bool? CdfKilitli { get; set; }

    [Column("cdf_degisti")]
    public bool? CdfDegisti { get; set; }

    [Column("cdf_checksum")]
    public int? CdfChecksum { get; set; }

    [Column("cdf_create_user")]
    public short? CdfCreateUser { get; set; }

    [Column("cdf_create_date")]
    public DateTime? CdfCreateDate { get; set; }

    [Column("cdf_lastup_user")]
    public short? CdfLastupUser { get; set; }

    [Column("cdf_lastup_date")]
    public DateTime? CdfLastupDate { get; set; }

    [Column("cdf_special1")]
    [StringLength(4)]
    public string? CdfSpecial1 { get; set; }

    [Column("cdf_special2")]
    [StringLength(4)]
    public string? CdfSpecial2 { get; set; }

    [Column("cdf_special3")]
    [StringLength(4)]
    public string? CdfSpecial3 { get; set; }

    [Column("cdf_form_kodu")]
    [StringLength(25)]
    public string? CdfFormKodu { get; set; }

    [Column("cdf_cari_kodu")]
    [StringLength(25)]
    public string? CdfCariKodu { get; set; }

    [Column("cdf_satirno")]
    public int? CdfSatirno { get; set; }

    [Column("cdf_tarih")]
    public DateTime? CdfTarih { get; set; }

    [Column("cdf_kriter_kodu")]
    [StringLength(25)]
    public string? CdfKriterKodu { get; set; }

    [Column("cdf_puan")]
    public double? CdfPuan { get; set; }

    [Column("cdf_sozelpuan")]
    public byte? CdfSozelpuan { get; set; }
}
