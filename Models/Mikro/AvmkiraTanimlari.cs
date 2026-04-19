using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmkira_tanimlari")]
public class AvmkiraTanimlari
{
    [Column("Avmk_Guid")]
    public Guid? AvmkGuid { get; set; }

    [Column("Avmk_DBCno")]
    public short? AvmkDBCno { get; set; }

    [Column("Avmk_SpecRECno")]
    public int? AvmkSpecRECno { get; set; }

    [Column("Avmk_iptal")]
    public bool? AvmkIptal { get; set; }

    [Column("Avmk_fileid")]
    public short? AvmkFileid { get; set; }

    [Column("Avmk_hidden")]
    public bool? AvmkHidden { get; set; }

    [Column("Avmk_kilitli")]
    public bool? AvmkKilitli { get; set; }

    [Column("Avmk_degisti")]
    public bool? AvmkDegisti { get; set; }

    [Column("Avmk_checksum")]
    public int? AvmkChecksum { get; set; }

    [Column("Avmk_create_user")]
    public short? AvmkCreateUser { get; set; }

    [Column("Avmk_create_date")]
    public DateTime? AvmkCreateDate { get; set; }

    [Column("Avmk_lastup_user")]
    public short? AvmkLastupUser { get; set; }

    [Column("Avmk_lastup_date")]
    public DateTime? AvmkLastupDate { get; set; }

    [Column("Avmk_special1")]
    [StringLength(4)]
    public string? AvmkSpecial1 { get; set; }

    [Column("Avmk_special2")]
    [StringLength(4)]
    public string? AvmkSpecial2 { get; set; }

    [Column("Avmk_special3")]
    [StringLength(4)]
    public string? AvmkSpecial3 { get; set; }

    [Column("Avmk_kira_kodu")]
    [StringLength(25)]
    public string? AvmkKiraKodu { get; set; }

    [Column("Avmk_kira_ismi")]
    [StringLength(50)]
    public string? AvmkKiraIsmi { get; set; }

    [Column("Avmk_baslangictarihi")]
    public DateTime? AvmkBaslangictarihi { get; set; }

    [Column("Avmk_bitistarihi")]
    public DateTime? AvmkBitistarihi { get; set; }

    [Column("Avmk_sozlesmetarihi")]
    public DateTime? AvmkSozlesmetarihi { get; set; }

    [Column("Avmk_yertestarihi")]
    public DateTime? AvmkYertestarihi { get; set; }

    [Column("Avmk_kirayontemi")]
    public byte? AvmkKirayontemi { get; set; }

    [Column("Avmk_srmrkkodu")]
    [StringLength(25)]
    public string? AvmkSrmrkkodu { get; set; }

    [Column("Avmk_Kiratan1kirablmkodu")]
    [StringLength(25)]
    public string? AvmkKiratan1kirablmkodu { get; set; }

    [Column("Avmk_Kiratan1kirablmbrutalan")]
    public double? AvmkKiratan1kirablmbrutalan { get; set; }

    [Column("Avmk_Kiratan1kirablmnetalan")]
    public double? AvmkKiratan1kirablmnetalan { get; set; }

    [Column("Avmk_Kiratan1kirablmkiratutari")]
    public double? AvmkKiratan1kirablmkiratutari { get; set; }

    [Column("Avmk_Kiratan1kirablmkiradvzcinsi")]
    public byte? AvmkKiratan1kirablmkiradvzcinsi { get; set; }

    [Column("Avmk_Kiratan1kirablmkiraperyodu")]
    public byte? AvmkKiratan1kirablmkiraperyodu { get; set; }

    [Column("Avmk_Kiratan1kirablmdvzdegerleme")]
    public byte? AvmkKiratan1kirablmdvzdegerleme { get; set; }

    [Column("Avmk_Kiratan1kirablmperyodaraligi")]
    public short? AvmkKiratan1kirablmperyodaraligi { get; set; }

    [Column("Avmk_Kiratan1kirablmHes1Bastar")]
    public DateTime? AvmkKiratan1kirablmHes1Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes1Bittar")]
    public DateTime? AvmkKiratan1kirablmHes1Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes1ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes1ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes1ArtisOrani")]
    public double? AvmkKiratan1kirablmHes1ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes1EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes2Bastar")]
    public DateTime? AvmkKiratan1kirablmHes2Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes2Bittar")]
    public DateTime? AvmkKiratan1kirablmHes2Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes2ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes2ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes2ArtisOrani")]
    public double? AvmkKiratan1kirablmHes2ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes2EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes3Bastar")]
    public DateTime? AvmkKiratan1kirablmHes3Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes3Bittar")]
    public DateTime? AvmkKiratan1kirablmHes3Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes3ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes3ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes3ArtisOrani")]
    public double? AvmkKiratan1kirablmHes3ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes3EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes4Bastar")]
    public DateTime? AvmkKiratan1kirablmHes4Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes4Bittar")]
    public DateTime? AvmkKiratan1kirablmHes4Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes4ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes4ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes4ArtisOrani")]
    public double? AvmkKiratan1kirablmHes4ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes4EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes5Bastar")]
    public DateTime? AvmkKiratan1kirablmHes5Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes5Bittar")]
    public DateTime? AvmkKiratan1kirablmHes5Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes5ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes5ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes5ArtisOrani")]
    public double? AvmkKiratan1kirablmHes5ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes5EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes6Bastar")]
    public DateTime? AvmkKiratan1kirablmHes6Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes6Bittar")]
    public DateTime? AvmkKiratan1kirablmHes6Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes6ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes6ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes6ArtisOrani")]
    public double? AvmkKiratan1kirablmHes6ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes6EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes7Bastar")]
    public DateTime? AvmkKiratan1kirablmHes7Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes7Bittar")]
    public DateTime? AvmkKiratan1kirablmHes7Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes7ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes7ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes7ArtisOrani")]
    public double? AvmkKiratan1kirablmHes7ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes7EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes8Bastar")]
    public DateTime? AvmkKiratan1kirablmHes8Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes8Bittar")]
    public DateTime? AvmkKiratan1kirablmHes8Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes8ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes8ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes8ArtisOrani")]
    public double? AvmkKiratan1kirablmHes8ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes8EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes9Bastar")]
    public DateTime? AvmkKiratan1kirablmHes9Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes9Bittar")]
    public DateTime? AvmkKiratan1kirablmHes9Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes9ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes9ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes9ArtisOrani")]
    public double? AvmkKiratan1kirablmHes9ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes9EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes10Bastar")]
    public DateTime? AvmkKiratan1kirablmHes10Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes10Bittar")]
    public DateTime? AvmkKiratan1kirablmHes10Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes10ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes10ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes10ArtisOrani")]
    public double? AvmkKiratan1kirablmHes10ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes10EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes11Bastar")]
    public DateTime? AvmkKiratan1kirablmHes11Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes11Bittar")]
    public DateTime? AvmkKiratan1kirablmHes11Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes11ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes11ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes11ArtisOrani")]
    public double? AvmkKiratan1kirablmHes11ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes11EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes12Bastar")]
    public DateTime? AvmkKiratan1kirablmHes12Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes12Bittar")]
    public DateTime? AvmkKiratan1kirablmHes12Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes12ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes12ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes12ArtisOrani")]
    public double? AvmkKiratan1kirablmHes12ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes12EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes13Bastar")]
    public DateTime? AvmkKiratan1kirablmHes13Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes13Bittar")]
    public DateTime? AvmkKiratan1kirablmHes13Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes13ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes13ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes13ArtisOrani")]
    public double? AvmkKiratan1kirablmHes13ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes13EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes14Bastar")]
    public DateTime? AvmkKiratan1kirablmHes14Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes14Bittar")]
    public DateTime? AvmkKiratan1kirablmHes14Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes14ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes14ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes14ArtisOrani")]
    public double? AvmkKiratan1kirablmHes14ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes14EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHes15Bastar")]
    public DateTime? AvmkKiratan1kirablmHes15Bastar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes15Bittar")]
    public DateTime? AvmkKiratan1kirablmHes15Bittar { get; set; }

    [Column("Avmk_Kiratan1kirablmHes15ArtisSekli")]
    public byte? AvmkKiratan1kirablmHes15ArtisSekli { get; set; }

    [Column("Avmk_Kiratan1kirablmHes15ArtisOrani")]
    public double? AvmkKiratan1kirablmHes15ArtisOrani { get; set; }

    [Column("Avmk_Kiratan1kirablmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan1kirablmHes15EndxFormul { get; set; }

    [Column("Avmk_Kiratan1kirablmHesaplamaTipi")]
    public byte? AvmkKiratan1kirablmHesaplamaTipi { get; set; }

    [Column("Avmk_Kiratan2kirablmkodu")]
    [StringLength(25)]
    public string? AvmkKiratan2kirablmkodu { get; set; }

    [Column("Avmk_Kiratan2kirablmbrutalan")]
    public double? AvmkKiratan2kirablmbrutalan { get; set; }

    [Column("Avmk_Kiratan2kirablmnetalan")]
    public double? AvmkKiratan2kirablmnetalan { get; set; }

    [Column("Avmk_Kiratan2kirablmkiratutari")]
    public double? AvmkKiratan2kirablmkiratutari { get; set; }

    [Column("Avmk_Kiratan2kirablmkiradvzcinsi")]
    public byte? AvmkKiratan2kirablmkiradvzcinsi { get; set; }

    [Column("Avmk_Kiratan2kirablmkiraperyodu")]
    public byte? AvmkKiratan2kirablmkiraperyodu { get; set; }

    [Column("Avmk_Kiratan2kirablmdvzdegerleme")]
    public byte? AvmkKiratan2kirablmdvzdegerleme { get; set; }

    [Column("Avmk_Kiratan2kirablmperyodaraligi")]
    public short? AvmkKiratan2kirablmperyodaraligi { get; set; }

    [Column("Avmk_Kiratan2kirablmHes1Bastar")]
    public DateTime? AvmkKiratan2kirablmHes1Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes1Bittar")]
    public DateTime? AvmkKiratan2kirablmHes1Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes1ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes1ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes1ArtisOrani")]
    public double? AvmkKiratan2kirablmHes1ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes1EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes2Bastar")]
    public DateTime? AvmkKiratan2kirablmHes2Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes2Bittar")]
    public DateTime? AvmkKiratan2kirablmHes2Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes2ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes2ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes2ArtisOrani")]
    public double? AvmkKiratan2kirablmHes2ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes2EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes3Bastar")]
    public DateTime? AvmkKiratan2kirablmHes3Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes3Bittar")]
    public DateTime? AvmkKiratan2kirablmHes3Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes3ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes3ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes3ArtisOrani")]
    public double? AvmkKiratan2kirablmHes3ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes3EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes4Bastar")]
    public DateTime? AvmkKiratan2kirablmHes4Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes4Bittar")]
    public DateTime? AvmkKiratan2kirablmHes4Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes4ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes4ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes4ArtisOrani")]
    public double? AvmkKiratan2kirablmHes4ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes4EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes5Bastar")]
    public DateTime? AvmkKiratan2kirablmHes5Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes5Bittar")]
    public DateTime? AvmkKiratan2kirablmHes5Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes5ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes5ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes5ArtisOrani")]
    public double? AvmkKiratan2kirablmHes5ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes5EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes6Bastar")]
    public DateTime? AvmkKiratan2kirablmHes6Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes6Bittar")]
    public DateTime? AvmkKiratan2kirablmHes6Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes6ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes6ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes6ArtisOrani")]
    public double? AvmkKiratan2kirablmHes6ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes6EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes7Bastar")]
    public DateTime? AvmkKiratan2kirablmHes7Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes7Bittar")]
    public DateTime? AvmkKiratan2kirablmHes7Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes7ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes7ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes7ArtisOrani")]
    public double? AvmkKiratan2kirablmHes7ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes7EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes8Bastar")]
    public DateTime? AvmkKiratan2kirablmHes8Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes8Bittar")]
    public DateTime? AvmkKiratan2kirablmHes8Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes8ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes8ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes8ArtisOrani")]
    public double? AvmkKiratan2kirablmHes8ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes8EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes9Bastar")]
    public DateTime? AvmkKiratan2kirablmHes9Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes9Bittar")]
    public DateTime? AvmkKiratan2kirablmHes9Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes9ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes9ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes9ArtisOrani")]
    public double? AvmkKiratan2kirablmHes9ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes9EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes10Bastar")]
    public DateTime? AvmkKiratan2kirablmHes10Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes10Bittar")]
    public DateTime? AvmkKiratan2kirablmHes10Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes10ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes10ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes10EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes10ArtisOrani")]
    public double? AvmkKiratan2kirablmHes10ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes11Bastar")]
    public DateTime? AvmkKiratan2kirablmHes11Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes11Bittar")]
    public DateTime? AvmkKiratan2kirablmHes11Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes11ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes11ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes11ArtisOrani")]
    public double? AvmkKiratan2kirablmHes11ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes11EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes12Bastar")]
    public DateTime? AvmkKiratan2kirablmHes12Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes12Bittar")]
    public DateTime? AvmkKiratan2kirablmHes12Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes12ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes12ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes12ArtisOrani")]
    public double? AvmkKiratan2kirablmHes12ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes12EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes13Bastar")]
    public DateTime? AvmkKiratan2kirablmHes13Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes13Bittar")]
    public DateTime? AvmkKiratan2kirablmHes13Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes13ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes13ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes13ArtisOrani")]
    public double? AvmkKiratan2kirablmHes13ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes13EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes14Bastar")]
    public DateTime? AvmkKiratan2kirablmHes14Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes14Bittar")]
    public DateTime? AvmkKiratan2kirablmHes14Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes14ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes14ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes14ArtisOrani")]
    public double? AvmkKiratan2kirablmHes14ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes14EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHes15Bastar")]
    public DateTime? AvmkKiratan2kirablmHes15Bastar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes15Bittar")]
    public DateTime? AvmkKiratan2kirablmHes15Bittar { get; set; }

    [Column("Avmk_Kiratan2kirablmHes15ArtisSekli")]
    public byte? AvmkKiratan2kirablmHes15ArtisSekli { get; set; }

    [Column("Avmk_Kiratan2kirablmHes15ArtisOrani")]
    public double? AvmkKiratan2kirablmHes15ArtisOrani { get; set; }

    [Column("Avmk_Kiratan2kirablmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan2kirablmHes15EndxFormul { get; set; }

    [Column("Avmk_Kiratan2kirablmHesaplamaTipi")]
    public byte? AvmkKiratan2kirablmHesaplamaTipi { get; set; }

    [Column("Avmk_Kiratan3kirablmkodu")]
    [StringLength(25)]
    public string? AvmkKiratan3kirablmkodu { get; set; }

    [Column("Avmk_Kiratan3kirablmbrutalan")]
    public double? AvmkKiratan3kirablmbrutalan { get; set; }

    [Column("Avmk_Kiratan3kirablmnetalan")]
    public double? AvmkKiratan3kirablmnetalan { get; set; }

    [Column("Avmk_Kiratan3kirablmkiratutari")]
    public double? AvmkKiratan3kirablmkiratutari { get; set; }

    [Column("Avmk_Kiratan3kirablmkiradvzcinsi")]
    public byte? AvmkKiratan3kirablmkiradvzcinsi { get; set; }

    [Column("Avmk_Kiratan3kirablmkiraperyodu")]
    public byte? AvmkKiratan3kirablmkiraperyodu { get; set; }

    [Column("Avmk_Kiratan3kirablmdvzdegerleme")]
    public byte? AvmkKiratan3kirablmdvzdegerleme { get; set; }

    [Column("Avmk_Kiratan3kirablmperyodaraligi")]
    public short? AvmkKiratan3kirablmperyodaraligi { get; set; }

    [Column("Avmk_Kiratan3kirablmHes1Bastar")]
    public DateTime? AvmkKiratan3kirablmHes1Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes1Bittar")]
    public DateTime? AvmkKiratan3kirablmHes1Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes1ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes1ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes1ArtisOrani")]
    public double? AvmkKiratan3kirablmHes1ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes1EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes2Bastar")]
    public DateTime? AvmkKiratan3kirablmHes2Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes2Bittar")]
    public DateTime? AvmkKiratan3kirablmHes2Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes2ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes2ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes2ArtisOrani")]
    public double? AvmkKiratan3kirablmHes2ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes2EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes3Bastar")]
    public DateTime? AvmkKiratan3kirablmHes3Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes3Bittar")]
    public DateTime? AvmkKiratan3kirablmHes3Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes3ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes3ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes3ArtisOrani")]
    public double? AvmkKiratan3kirablmHes3ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes3EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes4Bastar")]
    public DateTime? AvmkKiratan3kirablmHes4Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes4Bittar")]
    public DateTime? AvmkKiratan3kirablmHes4Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes4ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes4ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes4ArtisOrani")]
    public double? AvmkKiratan3kirablmHes4ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes4EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes5Bastar")]
    public DateTime? AvmkKiratan3kirablmHes5Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes5Bittar")]
    public DateTime? AvmkKiratan3kirablmHes5Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes5ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes5ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes5ArtisOrani")]
    public double? AvmkKiratan3kirablmHes5ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes5EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes6Bastar")]
    public DateTime? AvmkKiratan3kirablmHes6Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes6Bittar")]
    public DateTime? AvmkKiratan3kirablmHes6Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes6ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes6ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes6ArtisOrani")]
    public double? AvmkKiratan3kirablmHes6ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes6EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes7Bastar")]
    public DateTime? AvmkKiratan3kirablmHes7Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes7Bittar")]
    public DateTime? AvmkKiratan3kirablmHes7Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes7ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes7ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes7ArtisOrani")]
    public double? AvmkKiratan3kirablmHes7ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes7EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes8Bastar")]
    public DateTime? AvmkKiratan3kirablmHes8Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes8Bittar")]
    public DateTime? AvmkKiratan3kirablmHes8Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes8ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes8ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes8ArtisOrani")]
    public double? AvmkKiratan3kirablmHes8ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes8EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes9Bastar")]
    public DateTime? AvmkKiratan3kirablmHes9Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes9Bittar")]
    public DateTime? AvmkKiratan3kirablmHes9Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes9ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes9ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes9ArtisOrani")]
    public double? AvmkKiratan3kirablmHes9ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes9EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes10Bastar")]
    public DateTime? AvmkKiratan3kirablmHes10Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes10Bittar")]
    public DateTime? AvmkKiratan3kirablmHes10Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes10ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes10ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes10ArtisOrani")]
    public double? AvmkKiratan3kirablmHes10ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes10EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes11Bastar")]
    public DateTime? AvmkKiratan3kirablmHes11Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes11Bittar")]
    public DateTime? AvmkKiratan3kirablmHes11Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes11ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes11ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes11ArtisOrani")]
    public double? AvmkKiratan3kirablmHes11ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes11EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes12Bastar")]
    public DateTime? AvmkKiratan3kirablmHes12Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes12Bittar")]
    public DateTime? AvmkKiratan3kirablmHes12Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes12ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes12ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes12ArtisOrani")]
    public double? AvmkKiratan3kirablmHes12ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes12EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes13Bastar")]
    public DateTime? AvmkKiratan3kirablmHes13Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes13Bittar")]
    public DateTime? AvmkKiratan3kirablmHes13Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes13ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes13ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes13ArtisOrani")]
    public double? AvmkKiratan3kirablmHes13ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes13EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes14Bastar")]
    public DateTime? AvmkKiratan3kirablmHes14Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes14Bittar")]
    public DateTime? AvmkKiratan3kirablmHes14Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes14ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes14ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes14ArtisOrani")]
    public double? AvmkKiratan3kirablmHes14ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes14EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHes15Bastar")]
    public DateTime? AvmkKiratan3kirablmHes15Bastar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes15Bittar")]
    public DateTime? AvmkKiratan3kirablmHes15Bittar { get; set; }

    [Column("Avmk_Kiratan3kirablmHes15ArtisSekli")]
    public byte? AvmkKiratan3kirablmHes15ArtisSekli { get; set; }

    [Column("Avmk_Kiratan3kirablmHes15ArtisOrani")]
    public double? AvmkKiratan3kirablmHes15ArtisOrani { get; set; }

    [Column("Avmk_Kiratan3kirablmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan3kirablmHes15EndxFormul { get; set; }

    [Column("Avmk_Kiratan3kirablmHesaplamaTipi")]
    public byte? AvmkKiratan3kirablmHesaplamaTipi { get; set; }

    [Column("Avmk_Kiratan4kirablmkodu")]
    [StringLength(25)]
    public string? AvmkKiratan4kirablmkodu { get; set; }

    [Column("Avmk_Kiratan4kirablmbrutalan")]
    public double? AvmkKiratan4kirablmbrutalan { get; set; }

    [Column("Avmk_Kiratan4kirablmnetalan")]
    public double? AvmkKiratan4kirablmnetalan { get; set; }

    [Column("Avmk_Kiratan4kirablmkiratutari")]
    public double? AvmkKiratan4kirablmkiratutari { get; set; }

    [Column("Avmk_Kiratan4kirablmkiradvzcinsi")]
    public byte? AvmkKiratan4kirablmkiradvzcinsi { get; set; }

    [Column("Avmk_Kiratan4kirablmkiraperyodu")]
    public byte? AvmkKiratan4kirablmkiraperyodu { get; set; }

    [Column("Avmk_Kiratan4kirablmdvzdegerleme")]
    public byte? AvmkKiratan4kirablmdvzdegerleme { get; set; }

    [Column("Avmk_Kiratan4kirablmperyodaraligi")]
    public short? AvmkKiratan4kirablmperyodaraligi { get; set; }

    [Column("Avmk_Kiratan4kirablmHes1Bastar")]
    public DateTime? AvmkKiratan4kirablmHes1Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes1Bittar")]
    public DateTime? AvmkKiratan4kirablmHes1Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes1ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes1ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes1ArtisOrani")]
    public double? AvmkKiratan4kirablmHes1ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes1EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes2Bastar")]
    public DateTime? AvmkKiratan4kirablmHes2Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes2Bittar")]
    public DateTime? AvmkKiratan4kirablmHes2Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes2ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes2ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes2ArtisOrani")]
    public double? AvmkKiratan4kirablmHes2ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes2EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes3Bastar")]
    public DateTime? AvmkKiratan4kirablmHes3Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes3Bittar")]
    public DateTime? AvmkKiratan4kirablmHes3Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes3ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes3ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes3ArtisOrani")]
    public double? AvmkKiratan4kirablmHes3ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes3EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes4Bastar")]
    public DateTime? AvmkKiratan4kirablmHes4Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes4Bittar")]
    public DateTime? AvmkKiratan4kirablmHes4Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes4ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes4ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes4ArtisOrani")]
    public double? AvmkKiratan4kirablmHes4ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes4EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes5Bastar")]
    public DateTime? AvmkKiratan4kirablmHes5Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes5Bittar")]
    public DateTime? AvmkKiratan4kirablmHes5Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes5ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes5ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes5ArtisOrani")]
    public double? AvmkKiratan4kirablmHes5ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes5EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes6Bastar")]
    public DateTime? AvmkKiratan4kirablmHes6Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes6Bittar")]
    public DateTime? AvmkKiratan4kirablmHes6Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes6ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes6ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes6ArtisOrani")]
    public double? AvmkKiratan4kirablmHes6ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes6EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes7Bastar")]
    public DateTime? AvmkKiratan4kirablmHes7Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes7Bittar")]
    public DateTime? AvmkKiratan4kirablmHes7Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes7ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes7ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes7ArtisOrani")]
    public double? AvmkKiratan4kirablmHes7ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes7EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes8Bastar")]
    public DateTime? AvmkKiratan4kirablmHes8Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes8Bittar")]
    public DateTime? AvmkKiratan4kirablmHes8Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes8ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes8ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes8ArtisOrani")]
    public double? AvmkKiratan4kirablmHes8ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes9EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes9Bastar")]
    public DateTime? AvmkKiratan4kirablmHes9Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes9Bittar")]
    public DateTime? AvmkKiratan4kirablmHes9Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes9ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes9ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes9ArtisOrani")]
    public double? AvmkKiratan4kirablmHes9ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes10Bastar")]
    public DateTime? AvmkKiratan4kirablmHes10Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes10Bittar")]
    public DateTime? AvmkKiratan4kirablmHes10Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes10ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes10ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes10ArtisOrani")]
    public double? AvmkKiratan4kirablmHes10ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes10EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes11Bastar")]
    public DateTime? AvmkKiratan4kirablmHes11Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes11Bittar")]
    public DateTime? AvmkKiratan4kirablmHes11Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes11ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes11ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes11ArtisOrani")]
    public double? AvmkKiratan4kirablmHes11ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes11EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes12Bastar")]
    public DateTime? AvmkKiratan4kirablmHes12Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes12Bittar")]
    public DateTime? AvmkKiratan4kirablmHes12Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes12ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes12ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes12ArtisOrani")]
    public double? AvmkKiratan4kirablmHes12ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes12EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes13Bastar")]
    public DateTime? AvmkKiratan4kirablmHes13Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes13Bittar")]
    public DateTime? AvmkKiratan4kirablmHes13Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes13ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes13ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes13ArtisOrani")]
    public double? AvmkKiratan4kirablmHes13ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes13EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes14Bastar")]
    public DateTime? AvmkKiratan4kirablmHes14Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes14Bittar")]
    public DateTime? AvmkKiratan4kirablmHes14Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes14ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes14ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes14ArtisOrani")]
    public double? AvmkKiratan4kirablmHes14ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes14EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHes15Bastar")]
    public DateTime? AvmkKiratan4kirablmHes15Bastar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes15Bittar")]
    public DateTime? AvmkKiratan4kirablmHes15Bittar { get; set; }

    [Column("Avmk_Kiratan4kirablmHes15ArtisSekli")]
    public byte? AvmkKiratan4kirablmHes15ArtisSekli { get; set; }

    [Column("Avmk_Kiratan4kirablmHes15ArtisOrani")]
    public double? AvmkKiratan4kirablmHes15ArtisOrani { get; set; }

    [Column("Avmk_Kiratan4kirablmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan4kirablmHes15EndxFormul { get; set; }

    [Column("Avmk_Kiratan4kirablmHesaplamaTipi")]
    public byte? AvmkKiratan4kirablmHesaplamaTipi { get; set; }

    [Column("Avmk_Kiratan5kirablmkodu")]
    [StringLength(25)]
    public string? AvmkKiratan5kirablmkodu { get; set; }

    [Column("Avmk_Kiratan5kirablmbrutalan")]
    public double? AvmkKiratan5kirablmbrutalan { get; set; }

    [Column("Avmk_Kiratan5kirablmnetalan")]
    public double? AvmkKiratan5kirablmnetalan { get; set; }

    [Column("Avmk_Kiratan5kirablmkiratutari")]
    public double? AvmkKiratan5kirablmkiratutari { get; set; }

    [Column("Avmk_Kiratan5kirablmkiradvzcinsi")]
    public byte? AvmkKiratan5kirablmkiradvzcinsi { get; set; }

    [Column("Avmk_Kiratan5kirablmkiraperyodu")]
    public byte? AvmkKiratan5kirablmkiraperyodu { get; set; }

    [Column("Avmk_Kiratan5kirablmdvzdegerleme")]
    public byte? AvmkKiratan5kirablmdvzdegerleme { get; set; }

    [Column("Avmk_Kiratan5kirablmperyodaraligi")]
    public short? AvmkKiratan5kirablmperyodaraligi { get; set; }

    [Column("Avmk_Kiratan5kirablmHes1Bastar")]
    public DateTime? AvmkKiratan5kirablmHes1Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes1Bittar")]
    public DateTime? AvmkKiratan5kirablmHes1Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes1ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes1ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes1ArtisOrani")]
    public double? AvmkKiratan5kirablmHes1ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes1EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes2Bastar")]
    public DateTime? AvmkKiratan5kirablmHes2Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes2Bittar")]
    public DateTime? AvmkKiratan5kirablmHes2Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes2ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes2ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes2ArtisOrani")]
    public double? AvmkKiratan5kirablmHes2ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes2EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes3Bastar")]
    public DateTime? AvmkKiratan5kirablmHes3Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes3Bittar")]
    public DateTime? AvmkKiratan5kirablmHes3Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes3ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes3ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes3ArtisOrani")]
    public double? AvmkKiratan5kirablmHes3ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes3EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes4Bastar")]
    public DateTime? AvmkKiratan5kirablmHes4Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes4Bittar")]
    public DateTime? AvmkKiratan5kirablmHes4Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes4ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes4ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes4ArtisOrani")]
    public double? AvmkKiratan5kirablmHes4ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes4EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes5Bastar")]
    public DateTime? AvmkKiratan5kirablmHes5Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes5Bittar")]
    public DateTime? AvmkKiratan5kirablmHes5Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes5ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes5ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes5ArtisOrani")]
    public double? AvmkKiratan5kirablmHes5ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes5EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes6Bastar")]
    public DateTime? AvmkKiratan5kirablmHes6Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes6Bittar")]
    public DateTime? AvmkKiratan5kirablmHes6Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes6ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes6ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes6ArtisOrani")]
    public double? AvmkKiratan5kirablmHes6ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes6EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes7Bastar")]
    public DateTime? AvmkKiratan5kirablmHes7Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes7Bittar")]
    public DateTime? AvmkKiratan5kirablmHes7Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes7ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes7ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes7ArtisOrani")]
    public double? AvmkKiratan5kirablmHes7ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes7EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes8Bastar")]
    public DateTime? AvmkKiratan5kirablmHes8Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes8Bittar")]
    public DateTime? AvmkKiratan5kirablmHes8Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes8ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes8ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes8ArtisOrani")]
    public double? AvmkKiratan5kirablmHes8ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes8EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes9Bastar")]
    public DateTime? AvmkKiratan5kirablmHes9Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes9Bittar")]
    public DateTime? AvmkKiratan5kirablmHes9Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes9ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes9ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes9ArtisOrani")]
    public double? AvmkKiratan5kirablmHes9ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes9EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes10Bastar")]
    public DateTime? AvmkKiratan5kirablmHes10Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes10Bittar")]
    public DateTime? AvmkKiratan5kirablmHes10Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes10ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes10ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes10ArtisOrani")]
    public double? AvmkKiratan5kirablmHes10ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes10EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes11Bastar")]
    public DateTime? AvmkKiratan5kirablmHes11Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes11Bittar")]
    public DateTime? AvmkKiratan5kirablmHes11Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes11ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes11ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes11ArtisOrani")]
    public double? AvmkKiratan5kirablmHes11ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes11EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes12Bastar")]
    public DateTime? AvmkKiratan5kirablmHes12Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes12Bittar")]
    public DateTime? AvmkKiratan5kirablmHes12Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes12ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes12ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes12ArtisOrani")]
    public double? AvmkKiratan5kirablmHes12ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes12EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes13Bastar")]
    public DateTime? AvmkKiratan5kirablmHes13Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes13Bittar")]
    public DateTime? AvmkKiratan5kirablmHes13Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes13ArtisOrani")]
    public double? AvmkKiratan5kirablmHes13ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes13EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes14Bastar")]
    public DateTime? AvmkKiratan5kirablmHes14Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes14Bittar")]
    public DateTime? AvmkKiratan5kirablmHes14Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes14ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes14ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes14ArtisOrani")]
    public double? AvmkKiratan5kirablmHes14ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes14EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHes15Bastar")]
    public DateTime? AvmkKiratan5kirablmHes15Bastar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes15Bittar")]
    public DateTime? AvmkKiratan5kirablmHes15Bittar { get; set; }

    [Column("Avmk_Kiratan5kirablmHes15ArtisSekli")]
    public byte? AvmkKiratan5kirablmHes15ArtisSekli { get; set; }

    [Column("Avmk_Kiratan5kirablmHes15ArtisOrani")]
    public double? AvmkKiratan5kirablmHes15ArtisOrani { get; set; }

    [Column("Avmk_Kiratan5kirablmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkKiratan5kirablmHes15EndxFormul { get; set; }

    [Column("Avmk_Kiratan5kirablmHesaplamaTipi")]
    public byte? AvmkKiratan5kirablmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmkodu")]
    [StringLength(25)]
    public string? AvmkOrtGidtan1OrtGidblmkodu { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmbrutalan")]
    public double? AvmkOrtGidtan1OrtGidblmbrutalan { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmnetalan")]
    public double? AvmkOrtGidtan1OrtGidblmnetalan { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmkatbedeli")]
    public double? AvmkOrtGidtan1OrtGidblmkatbedeli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmdvzcinsi")]
    public byte? AvmkOrtGidtan1OrtGidblmdvzcinsi { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmperyodu")]
    public byte? AvmkOrtGidtan1OrtGidblmperyodu { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmdvzdegerleme")]
    public byte? AvmkOrtGidtan1OrtGidblmdvzdegerleme { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmperyodaraligi")]
    public short? AvmkOrtGidtan1OrtGidblmperyodaraligi { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes1Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes1Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes1Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes1Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes1ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes1ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes1ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes1ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes1EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes2Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes2Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes2Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes2Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes2ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes2ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes2ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes2ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes2EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes3Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes3Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes3Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes3Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes3ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes3ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes3ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes3ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes3EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes4Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes4Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes4Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes4Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes4ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes4ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes4ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes4ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes4EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes5Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes5Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes5Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes5Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes5ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes5ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes5ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes5ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes5EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes6Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes6Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes6Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes6Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes6ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes6ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes6ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes6ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes6EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes7Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes7Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes7Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes7Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes7ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes7ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes7ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes7ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes7EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes8Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes8Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes8Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes8Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes8ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes8ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes8ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes8ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes8EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes9Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes9Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes9Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes9Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes9ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes9ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes9ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes9ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes9EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes10Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes10Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes10Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes10Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes10ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes10ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes10ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes10ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes10EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes11Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes11Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes11Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes11Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes11ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes11ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes11ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes11ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes11EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes12Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes12Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes12Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes12Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes12ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes12ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes12ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes12ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes12EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes13Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes13Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes13Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes13Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes13ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes13ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes13ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes13ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes13EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes14Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes14Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes14Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes14Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes14ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes14ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes14ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes14ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes14EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes15Bastar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes15Bastar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes15Bittar")]
    public DateTime? AvmkOrtGidtan1OrtGidblmHes15Bittar { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes15ArtisSekli")]
    public byte? AvmkOrtGidtan1OrtGidblmHes15ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes15ArtisOrani")]
    public double? AvmkOrtGidtan1OrtGidblmHes15ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan1OrtGidblmHes15EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmHesaplamaTipi")]
    public byte? AvmkOrtGidtan1OrtGidblmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmOrtakAlanKatSkl")]
    public byte? AvmkOrtGidtan1OrtGidblmOrtakAlanKatSkl { get; set; }

    [Column("Avmk_OrtGidtan1OrtGidblmOrtakAlanUstLmt")]
    public double? AvmkOrtGidtan1OrtGidblmOrtakAlanUstLmt { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmkodu")]
    [StringLength(25)]
    public string? AvmkOrtGidtan2OrtGidblmkodu { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmbrutalan")]
    public double? AvmkOrtGidtan2OrtGidblmbrutalan { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmnetalan")]
    public double? AvmkOrtGidtan2OrtGidblmnetalan { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmkatbedeli")]
    public double? AvmkOrtGidtan2OrtGidblmkatbedeli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmdvzcinsi")]
    public byte? AvmkOrtGidtan2OrtGidblmdvzcinsi { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmperyodu")]
    public byte? AvmkOrtGidtan2OrtGidblmperyodu { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmdvzdegerleme")]
    public byte? AvmkOrtGidtan2OrtGidblmdvzdegerleme { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmperyodaraligi")]
    public short? AvmkOrtGidtan2OrtGidblmperyodaraligi { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes1Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes1Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes1Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes1Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes1ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes1ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes1ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes1ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes1EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes2Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes2Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes2Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes2Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes2ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes2ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes2ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes2ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes2EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes3Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes3Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes3Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes3Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes3ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes3ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes3ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes3ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes3EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes4Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes4Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes4Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes4Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes4ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes4ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes4ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes4ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes4EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes5Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes5Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes5Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes5Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes5ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes5ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes5ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes5ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes5EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes6Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes6Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes6Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes6Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes6ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes6ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes6ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes6ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes6EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes7Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes7Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes7Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes7Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes7ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes7ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes7ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes7ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes7EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes8Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes8Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes8Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes8Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes8ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes8ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes8ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes8ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes8EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes9Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes9Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes9Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes9Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes9ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes9ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes9ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes9ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes9EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes10Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes10Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes10Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes10Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes10ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes10ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes10ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes10ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes10EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes11Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes11Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes11Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes11Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes11ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes11ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes11ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes11ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes11EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes12Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes12Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes12Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes12Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes12ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes12ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes12ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes12ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes12EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes13Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes13Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes13Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes13Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes13ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes13ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes13ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes13ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes13EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes14Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes14Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes14Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes14Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes14ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes14ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes14ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes14ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes14EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes15Bastar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes15Bastar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes15Bittar")]
    public DateTime? AvmkOrtGidtan2OrtGidblmHes15Bittar { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes15ArtisSekli")]
    public byte? AvmkOrtGidtan2OrtGidblmHes15ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes15ArtisOrani")]
    public double? AvmkOrtGidtan2OrtGidblmHes15ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan2OrtGidblmHes15EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmHesaplamaTipi")]
    public byte? AvmkOrtGidtan2OrtGidblmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmOrtakAlanKatSkl")]
    public byte? AvmkOrtGidtan2OrtGidblmOrtakAlanKatSkl { get; set; }

    [Column("Avmk_OrtGidtan2OrtGidblmOrtakAlanUstLmt")]
    public double? AvmkOrtGidtan2OrtGidblmOrtakAlanUstLmt { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmkodu")]
    [StringLength(25)]
    public string? AvmkOrtGidtan3OrtGidblmkodu { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmbrutalan")]
    public double? AvmkOrtGidtan3OrtGidblmbrutalan { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmnetalan")]
    public double? AvmkOrtGidtan3OrtGidblmnetalan { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmkatbedeli")]
    public double? AvmkOrtGidtan3OrtGidblmkatbedeli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmdvzcinsi")]
    public byte? AvmkOrtGidtan3OrtGidblmdvzcinsi { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmperyodu")]
    public byte? AvmkOrtGidtan3OrtGidblmperyodu { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmdvzdegerleme")]
    public byte? AvmkOrtGidtan3OrtGidblmdvzdegerleme { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmperyodaraligi")]
    public short? AvmkOrtGidtan3OrtGidblmperyodaraligi { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes1Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes1Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes1Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes1Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes1ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes1ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes1ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes1ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes1EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes2Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes2Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes2Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes2Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes2ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes2ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes2ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes2ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes2EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes3Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes3Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes3Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes3Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes3ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes3ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes3ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes3ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes3EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes4Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes4Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes4Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes4Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes4ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes4ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes4ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes4ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes4EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes5Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes5Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes5Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes5Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes5ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes5ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes5ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes5ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes5EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes6Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes6Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes6Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes6Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes6ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes6ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes6ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes6ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes6EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes7Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes7Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes7Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes7Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes7ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes7ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes7ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes7ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes7EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes8Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes8Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes8Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes8Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes8ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes8ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes8ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes8ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes8EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes9Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes9Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes9Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes9Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes9ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes9ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes9ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes9ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes9EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes10Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes10Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes10Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes10Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes10ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes10ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes10ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes10ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes10EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes11Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes11Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes11Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes11Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes11ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes11ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes11ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes11ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes11EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes12Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes12Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes12Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes12Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes12ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes12ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes12ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes12ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes12EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes13Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes13Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes13Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes13Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes13ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes13ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes13ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes13ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes13EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes14Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes14Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes14Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes14Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes14ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes14ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes14ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes14ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes14EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes15Bastar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes15Bastar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes15Bittar")]
    public DateTime? AvmkOrtGidtan3OrtGidblmHes15Bittar { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes15ArtisSekli")]
    public byte? AvmkOrtGidtan3OrtGidblmHes15ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes15ArtisOrani")]
    public double? AvmkOrtGidtan3OrtGidblmHes15ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan3OrtGidblmHes15EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmHesaplamaTipi")]
    public byte? AvmkOrtGidtan3OrtGidblmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmOrtakAlanKatSkl")]
    public byte? AvmkOrtGidtan3OrtGidblmOrtakAlanKatSkl { get; set; }

    [Column("Avmk_OrtGidtan3OrtGidblmOrtakAlanUstLmt")]
    public double? AvmkOrtGidtan3OrtGidblmOrtakAlanUstLmt { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmkodu")]
    [StringLength(25)]
    public string? AvmkOrtGidtan4OrtGidblmkodu { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmbrutalan")]
    public double? AvmkOrtGidtan4OrtGidblmbrutalan { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmnetalan")]
    public double? AvmkOrtGidtan4OrtGidblmnetalan { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmkatbedeli")]
    public double? AvmkOrtGidtan4OrtGidblmkatbedeli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmdvzcinsi")]
    public byte? AvmkOrtGidtan4OrtGidblmdvzcinsi { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmperyodu")]
    public byte? AvmkOrtGidtan4OrtGidblmperyodu { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmdvzdegerleme")]
    public byte? AvmkOrtGidtan4OrtGidblmdvzdegerleme { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmperyodaraligi")]
    public short? AvmkOrtGidtan4OrtGidblmperyodaraligi { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes1Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes1Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes1Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes1Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes1ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes1ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes1ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes1ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes1EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes2Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes2Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes2Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes2Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes2ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes2ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes2ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes2ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes2EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes3Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes3Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes3Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes3Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes3ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes3ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes3ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes3ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes3EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes4Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes4Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes4Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes4Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes4ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes4ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes4ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes4ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes4EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes5Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes5Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes5Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes5Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes5ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes5ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes5ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes5ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes5EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes6Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes6Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes6Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes6Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes6ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes6ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes6ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes6ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes6EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes7Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes7Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes7Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes7Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes7ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes7ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes7ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes7ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes7EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes8Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes8Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes8Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes8Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes8ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes8ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes8ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes8ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes8EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes9Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes9Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes9Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes9Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes9ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes9ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes9ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes9ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes9EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes10Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes10Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes10Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes10Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes10ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes10ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes10ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes10ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes10EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes11Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes11Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes11Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes11Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes11ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes11ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes11ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes11ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes11EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes12Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes12Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes12Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes12Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes12ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes12ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes12ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes12ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes13Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes13Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes13Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes13Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes13ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes13ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes13ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes13ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes13EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes14Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes14Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes14Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes14Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes14ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes14ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes14ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes14ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes14EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes15Bastar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes15Bastar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes15Bittar")]
    public DateTime? AvmkOrtGidtan4OrtGidblmHes15Bittar { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes15ArtisSekli")]
    public byte? AvmkOrtGidtan4OrtGidblmHes15ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes15ArtisOrani")]
    public double? AvmkOrtGidtan4OrtGidblmHes15ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan4OrtGidblmHes15EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmHesaplamaTipi")]
    public byte? AvmkOrtGidtan4OrtGidblmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmOrtakAlanKatSkl")]
    public byte? AvmkOrtGidtan4OrtGidblmOrtakAlanKatSkl { get; set; }

    [Column("Avmk_OrtGidtan4OrtGidblmOrtakAlanUstLmt")]
    public double? AvmkOrtGidtan4OrtGidblmOrtakAlanUstLmt { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmkodu")]
    [StringLength(25)]
    public string? AvmkOrtGidtan5OrtGidblmkodu { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmbrutalan")]
    public double? AvmkOrtGidtan5OrtGidblmbrutalan { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmnetalan")]
    public double? AvmkOrtGidtan5OrtGidblmnetalan { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmkatbedeli")]
    public double? AvmkOrtGidtan5OrtGidblmkatbedeli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmdvzcinsi")]
    public byte? AvmkOrtGidtan5OrtGidblmdvzcinsi { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmperyodu")]
    public byte? AvmkOrtGidtan5OrtGidblmperyodu { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmdvzdegerleme")]
    public byte? AvmkOrtGidtan5OrtGidblmdvzdegerleme { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmperyodaraligi")]
    public short? AvmkOrtGidtan5OrtGidblmperyodaraligi { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes1Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes1Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes1Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes1Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes1ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes1ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes1ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes1ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes1EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes1EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes2Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes2Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes2Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes2Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes2ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes2ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes2ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes2ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes2EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes2EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes3Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes3Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes3Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes3Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes3ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes3ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes3ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes3ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes3EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes3EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes4Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes4Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes4Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes4Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes4ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes4ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes4ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes4ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes4EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes4EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes5Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes5Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes5Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes5Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes5ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes5ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes5ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes5ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes5EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes5EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes6Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes6Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes6Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes6Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes6ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes6ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes6ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes6ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes6EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes6EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes7Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes7Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes7Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes7Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes7ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes7ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes7ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes7ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes7EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes7EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes8Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes8Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes8Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes8Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes8ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes8ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes8ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes8ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes8EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes8EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes9Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes9Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes9Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes9Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes9ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes9ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes9ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes9ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes9EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes9EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes10Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes10Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes10Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes10Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes10ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes10ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes10ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes10ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes10EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes10EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes11Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes11Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes11Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes11Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes11ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes11ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes11ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes11ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes11EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes11EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes12Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes12Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes12Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes12Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes12ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes12ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes12ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes12ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes12EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes12EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes13Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes13Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes13Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes13Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes13ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes13ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes13ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes13ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes13EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes13EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes14Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes14Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes14Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes14Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes14ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes14ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes14ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes14ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes14EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes14EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes15Bastar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes15Bastar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes15Bittar")]
    public DateTime? AvmkOrtGidtan5OrtGidblmHes15Bittar { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes15ArtisSekli")]
    public byte? AvmkOrtGidtan5OrtGidblmHes15ArtisSekli { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes15ArtisOrani")]
    public double? AvmkOrtGidtan5OrtGidblmHes15ArtisOrani { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHes15EndxFormul")]
    [StringLength(15)]
    public string? AvmkOrtGidtan5OrtGidblmHes15EndxFormul { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmHesaplamaTipi")]
    public byte? AvmkOrtGidtan5OrtGidblmHesaplamaTipi { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmOrtakAlanKatSkl")]
    public byte? AvmkOrtGidtan5OrtGidblmOrtakAlanKatSkl { get; set; }

    [Column("Avmk_OrtGidtan5OrtGidblmOrtakAlanUstLmt")]
    public double? AvmkOrtGidtan5OrtGidblmOrtakAlanUstLmt { get; set; }

    [Column("Avmk_brutalan")]
    public double? AvmkBrutalan { get; set; }

    [Column("Avmk_netalan")]
    public double? AvmkNetalan { get; set; }

    [Column("Avmk_pesinkira")]
    public double? AvmkPesinkira { get; set; }

    [Column("Avmk_dvzcinsi")]
    public byte? AvmkDvzcinsi { get; set; }

    [Column("Avmk_asgkiraodemevadesi")]
    public short? AvmkAsgkiraodemevadesi { get; set; }

    [Column("Avmk_asgkiraodemevadfyuz")]
    public double? AvmkAsgkiraodemevadfyuz { get; set; }

    [Column("Avmk_ortgidodemevadesi")]
    public short? AvmkOrtgidodemevadesi { get; set; }

    [Column("Avmk_ortgidodemevadfyuz")]
    public double? AvmkOrtgidodemevadfyuz { get; set; }

    [Column("Avmk_sektorkodu")]
    [StringLength(25)]
    public string? AvmkSektorkodu { get; set; }

    [Column("Avmk_OnaylayanKulNo")]
    public short? AvmkOnaylayanKulNo { get; set; }

    [Column("Avmk_cagrilabilir_fl")]
    public bool? AvmkCagrilabilirFl { get; set; }

    [Column("Avmk_SozlesmeOlustu_fl")]
    public bool? AvmkSozlesmeOlustuFl { get; set; }

    [Column("Avmk_asgkiraodemecinsi")]
    public byte? AvmkAsgkiraodemecinsi { get; set; }

    [Column("Avmk_asgkiraodemegunu")]
    public byte? AvmkAsgkiraodemegunu { get; set; }

    [Column("Avmk_ortgidodemecinsi")]
    public byte? AvmkOrtgidodemecinsi { get; set; }

    [Column("Avmk_ortgidodemegunu")]
    public byte? AvmkOrtgidodemegunu { get; set; }

    [Column("Avmk_markakodu")]
    [StringLength(25)]
    public string? AvmkMarkakodu { get; set; }

    [Column("AvmkSozlesmeFeshedildi_fl")]
    public bool? AvmkSozlesmeFeshedildiFl { get; set; }

    [Column("AvmkSozlesmeFeshedilmeTarihi")]
    public DateTime? AvmkSozlesmeFeshedilmeTarihi { get; set; }

    [Column("Avmk_SabitGiderSozlesmeOlustu_fl")]
    public bool? AvmkSabitGiderSozlesmeOlustuFl { get; set; }

    [Column("Avmk_MagazaAcilisTarihi")]
    public DateTime? AvmkMagazaAcilisTarihi { get; set; }

    [Column("Avmk_KiraTarHesSekli")]
    public byte? AvmkKiraTarHesSekli { get; set; }

    [Column("Avmk_FaturaTebligSuresi")]
    public short? AvmkFaturaTebligSuresi { get; set; }

    [Column("Avmk_SayacFaturaVadesi")]
    public short? AvmkSayacFaturaVadesi { get; set; }

    [Column("Avmk_ProjeKodu")]
    [StringLength(25)]
    public string? AvmkProjeKodu { get; set; }

    [Column("Avmk_Malsahibi_fl")]
    public bool? AvmkMalsahibiFl { get; set; }

    [Column("AvmkKiraciSozlesmeKodu")]
    [StringLength(25)]
    public string? AvmkKiraciSozlesmeKodu { get; set; }

    [Column("Avmk_DepozitoTanimlari1DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari1DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari1DpztCinsi")]
    public byte? AvmkDepozitoTanimlari1DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari1DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari1DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari1DpztTutari")]
    public double? AvmkDepozitoTanimlari1DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari1DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari1DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari2DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari2DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari2DpztCinsi")]
    public byte? AvmkDepozitoTanimlari2DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari2DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari2DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari2DpztTutari")]
    public double? AvmkDepozitoTanimlari2DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari2DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari2DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari3DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari3DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari3DpztCinsi")]
    public byte? AvmkDepozitoTanimlari3DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari3DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari3DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari3DpztTutari")]
    public double? AvmkDepozitoTanimlari3DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari3DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari3DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari4DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari4DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari4DpztCinsi")]
    public byte? AvmkDepozitoTanimlari4DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari4DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari4DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari4DpztTutari")]
    public double? AvmkDepozitoTanimlari4DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari4DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari4DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari5DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari5DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari5DpztCinsi")]
    public byte? AvmkDepozitoTanimlari5DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari5DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari5DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari5DpztTutari")]
    public double? AvmkDepozitoTanimlari5DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari5DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari5DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari6DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari6DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari6DpztCinsi")]
    public byte? AvmkDepozitoTanimlari6DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari6DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari6DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari6DpztTutari")]
    public double? AvmkDepozitoTanimlari6DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari6DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari6DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari7DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari7DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari7DpztCinsi")]
    public byte? AvmkDepozitoTanimlari7DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari7DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari7DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari7DpztTutari")]
    public double? AvmkDepozitoTanimlari7DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari7DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari7DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari8DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari8DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari8DpztCinsi")]
    public byte? AvmkDepozitoTanimlari8DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari8DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari8DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari8DpztTutari")]
    public double? AvmkDepozitoTanimlari8DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari8DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari8DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari9DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari9DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari9DpztCinsi")]
    public byte? AvmkDepozitoTanimlari9DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari9DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari9DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari9DpztTutari")]
    public double? AvmkDepozitoTanimlari9DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari9DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari9DpztDvzCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari10DpztDuzTar")]
    public DateTime? AvmkDepozitoTanimlari10DpztDuzTar { get; set; }

    [Column("Avmk_DepozitoTanimlari10DpztCinsi")]
    public byte? AvmkDepozitoTanimlari10DpztCinsi { get; set; }

    [Column("Avmk_DepozitoTanimlari10DpztGecTar")]
    public DateTime? AvmkDepozitoTanimlari10DpztGecTar { get; set; }

    [Column("Avmk_DepozitoTanimlari10DpztTutari")]
    public double? AvmkDepozitoTanimlari10DpztTutari { get; set; }

    [Column("Avmk_DepozitoTanimlari10DpztDvzCinsi")]
    public byte? AvmkDepozitoTanimlari10DpztDvzCinsi { get; set; }
}
