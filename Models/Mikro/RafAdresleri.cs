using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("raf_adresleri")]
public class RafAdresleri
{
    [Column("ra_Guid")]
    public Guid? RaGuid { get; set; }

    [Column("ra_DBCno")]
    public short? RaDBCno { get; set; }

    [Column("ra_SpecRECno")]
    public int? RaSpecRECno { get; set; }

    [Column("ra_iptal")]
    public bool? RaIptal { get; set; }

    [Column("ra_fileid")]
    public short? RaFileid { get; set; }

    [Column("ra_hidden")]
    public bool? RaHidden { get; set; }

    [Column("ra_kilitli")]
    public bool? RaKilitli { get; set; }

    [Column("ra_degisti")]
    public bool? RaDegisti { get; set; }

    [Column("ra_checksum")]
    public int? RaChecksum { get; set; }

    [Column("ra_create_user")]
    public short? RaCreateUser { get; set; }

    [Column("ra_create_date")]
    public DateTime? RaCreateDate { get; set; }

    [Column("ra_lastup_user")]
    public short? RaLastupUser { get; set; }

    [Column("ra_lastup_date")]
    public DateTime? RaLastupDate { get; set; }

    [Column("ra_special1")]
    [StringLength(4)]
    public string? RaSpecial1 { get; set; }

    [Column("ra_special2")]
    [StringLength(4)]
    public string? RaSpecial2 { get; set; }

    [Column("ra_special3")]
    [StringLength(4)]
    public string? RaSpecial3 { get; set; }

    [Column("ra_kod")]
    [StringLength(25)]
    public string? RaKod { get; set; }

    [Column("ra_cins")]
    public byte? RaCins { get; set; }

    [Column("ra_depo")]
    public int? RaDepo { get; set; }

    [Column("ra_koridor")]
    [StringLength(4)]
    public string? RaKoridor { get; set; }

    [Column("ra_yon")]
    public byte? RaYon { get; set; }

    [Column("ra_blok")]
    [StringLength(4)]
    public string? RaBlok { get; set; }

    [Column("ra_kat")]
    [StringLength(4)]
    public string? RaKat { get; set; }

    [Column("ra_en")]
    public short? RaEn { get; set; }

    [Column("ra_boy")]
    public short? RaBoy { get; set; }

    [Column("ra_yukseklik")]
    public short? RaYukseklik { get; set; }

    [Column("ra_hacim")]
    public int? RaHacim { get; set; }

    [Column("ra_kapasite")]
    public int? RaKapasite { get; set; }

    [Column("ra_bolumsayisi")]
    public byte? RaBolumsayisi { get; set; }
}
