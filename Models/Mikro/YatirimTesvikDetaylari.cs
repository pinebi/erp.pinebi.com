using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yatirim_tesvik_detaylari")]
public class YatirimTesvikDetaylari
{
    [Column("YTD_Guid")]
    public Guid? YTDGuid { get; set; }

    [Column("YTD_DBCno")]
    public short? YTDDBCno { get; set; }

    [Column("YTD_SpecRECno")]
    public int? YTDSpecRECno { get; set; }

    [Column("YTD_iptal")]
    public bool? YTDIptal { get; set; }

    [Column("YTD_fileid")]
    public short? YTDFileid { get; set; }

    [Column("YTD_hidden")]
    public bool? YTDHidden { get; set; }

    [Column("YTD_kilitli")]
    public bool? YTDKilitli { get; set; }

    [Column("YTD_degisti")]
    public bool? YTDDegisti { get; set; }

    [Column("YTD_checksum")]
    public int? YTDChecksum { get; set; }

    [Column("YTD_create_user")]
    public short? YTDCreateUser { get; set; }

    [Column("YTD_create_date")]
    public DateTime? YTDCreateDate { get; set; }

    [Column("YTD_lastup_user")]
    public short? YTDLastupUser { get; set; }

    [Column("YTD_lastup_date")]
    public DateTime? YTDLastupDate { get; set; }

    [Column("YTD_special1")]
    [StringLength(4)]
    public string? YTDSpecial1 { get; set; }

    [Column("YTD_special2")]
    [StringLength(4)]
    public string? YTDSpecial2 { get; set; }

    [Column("YTD_special3")]
    [StringLength(4)]
    public string? YTDSpecial3 { get; set; }

    [Column("YTD_YTKodu")]
    [StringLength(25)]
    public string? YTDYTKodu { get; set; }

    [Column("YTD_SatirNo")]
    public int? YTDSatirNo { get; set; }

    [Column("YTD_Cinsi")]
    public byte? YTDCinsi { get; set; }

    [Column("YTD_CinsKodu")]
    [StringLength(25)]
    public string? YTDCinsKodu { get; set; }

    [Column("YTD_TeminCinsi")]
    public byte? YTDTeminCinsi { get; set; }

    [Column("YTD_Miktar")]
    public double? YTDMiktar { get; set; }

    [Column("YTD_Tutari")]
    public double? YTDTutari { get; set; }

    [Column("YTD_KDVTutari")]
    public double? YTDKDVTutari { get; set; }

    [Column("YTD_KDVIstKap_fl")]
    public bool? YTDKDVIstKapFl { get; set; }

    [Column("YTD_MenseDoviz")]
    public byte? YTDMenseDoviz { get; set; }

    [Column("YTD_MenseKuru")]
    [StringLength(50)]
    public string? YTDMenseKuru { get; set; }

    [Column("YTD_FobKuru")]
    public double? YTDFobKuru { get; set; }

    [Column("YTD_muhkodartikeli")]
    [StringLength(10)]
    public string? YTDMuhkodartikeli { get; set; }

    [Column("YTD_faturalasmismiktar")]
    public double? YTDFaturalasmismiktar { get; set; }
}
