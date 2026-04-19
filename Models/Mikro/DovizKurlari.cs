using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("doviz_kurlari")]
public class DovizKurlari
{
    [Column("dov_Guid")]
    public Guid? DovGuid { get; set; }

    [Column("dov_DBCno")]
    public short? DovDBCno { get; set; }

    [Column("dov_SpecRecNo")]
    public int? DovSpecRecNo { get; set; }

    [Column("dov_iptal")]
    public bool? DovIptal { get; set; }

    [Column("dov_fileid")]
    public short? DovFileid { get; set; }

    [Column("dov_hidden")]
    public bool? DovHidden { get; set; }

    [Column("dov_kilitli")]
    public bool? DovKilitli { get; set; }

    [Column("dov_degisti")]
    public bool? DovDegisti { get; set; }

    [Column("dov_checksum")]
    public int? DovChecksum { get; set; }

    [Column("dov_create_user")]
    public short? DovCreateUser { get; set; }

    [Column("dov_create_date")]
    public DateTime? DovCreateDate { get; set; }

    [Column("dov_lastup_user")]
    public short? DovLastupUser { get; set; }

    [Column("dov_lastup_date")]
    public DateTime? DovLastupDate { get; set; }

    [Column("dov_special1")]
    [StringLength(4)]
    public string? DovSpecial1 { get; set; }

    [Column("dov_special2")]
    [StringLength(4)]
    public string? DovSpecial2 { get; set; }

    [Column("dov_special3")]
    [StringLength(4)]
    public string? DovSpecial3 { get; set; }

    [Column("dov_no")]
    public byte? DovNo { get; set; }

    [Column("dov_tarih")]
    public DateTime? DovTarih { get; set; }

    [Column("dov_fiyat1")]
    public double? DovFiyat1 { get; set; }

    [Column("dov_fiyat2")]
    public double? DovFiyat2 { get; set; }

    [Column("dov_fiyat3")]
    public double? DovFiyat3 { get; set; }

    [Column("dov_fiyat4")]
    public double? DovFiyat4 { get; set; }
}
