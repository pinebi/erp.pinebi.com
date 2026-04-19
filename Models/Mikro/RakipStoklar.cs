using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("rakip_stoklar")]
public class RakipStoklar
{
    [Column("raks_Guid")]
    public Guid? RaksGuid { get; set; }

    [Column("raks_DBCno")]
    public short? RaksDBCno { get; set; }

    [Column("raks_SpecRECno")]
    public int? RaksSpecRECno { get; set; }

    [Column("raks_iptal")]
    public bool? RaksIptal { get; set; }

    [Column("raks_fileid")]
    public short? RaksFileid { get; set; }

    [Column("raks_hidden")]
    public bool? RaksHidden { get; set; }

    [Column("raks_kilitli")]
    public bool? RaksKilitli { get; set; }

    [Column("raks_degisti")]
    public bool? RaksDegisti { get; set; }

    [Column("raks_checksum")]
    public int? RaksChecksum { get; set; }

    [Column("raks_create_user")]
    public short? RaksCreateUser { get; set; }

    [Column("raks_create_date")]
    public DateTime? RaksCreateDate { get; set; }

    [Column("raks_lastup_user")]
    public short? RaksLastupUser { get; set; }

    [Column("raks_lastup_date")]
    public DateTime? RaksLastupDate { get; set; }

    [Column("raks_special1")]
    [StringLength(4)]
    public string? RaksSpecial1 { get; set; }

    [Column("raks_special2")]
    [StringLength(4)]
    public string? RaksSpecial2 { get; set; }

    [Column("raks_special3")]
    [StringLength(4)]
    public string? RaksSpecial3 { get; set; }

    [Column("raks_kod")]
    [StringLength(25)]
    public string? RaksKod { get; set; }

    [Column("raks_isim")]
    [StringLength(50)]
    public string? RaksIsim { get; set; }

    [Column("raks_sat_cari_kod")]
    [StringLength(25)]
    public string? RaksSatCariKod { get; set; }

    [Column("raks_cins")]
    public byte? RaksCins { get; set; }

    [Column("raks_doviz_cinsi")]
    public byte? RaksDovizCinsi { get; set; }

    [Column("raks_birim1_ad")]
    [StringLength(10)]
    public string? RaksBirim1Ad { get; set; }

    [Column("raks_birim1_katsayi")]
    public double? RaksBirim1Katsayi { get; set; }

    [Column("raks_birim1_agirlik")]
    public double? RaksBirim1Agirlik { get; set; }

    [Column("raks_birim1_en")]
    public double? RaksBirim1En { get; set; }

    [Column("raks_birim1_boy")]
    public double? RaksBirim1Boy { get; set; }

    [Column("raks_birim1_yuksekli")]
    public double? RaksBirim1Yuksekli { get; set; }

    [Column("raks_birim1_dara")]
    public double? RaksBirim1Dara { get; set; }

    [Column("raks_birim2_ad")]
    [StringLength(10)]
    public string? RaksBirim2Ad { get; set; }

    [Column("raks_birim2_katsayi")]
    public double? RaksBirim2Katsayi { get; set; }

    [Column("raks_birim2_agirlik")]
    public double? RaksBirim2Agirlik { get; set; }

    [Column("raks_birim2_en")]
    public double? RaksBirim2En { get; set; }

    [Column("raks_birim2_boy")]
    public double? RaksBirim2Boy { get; set; }

    [Column("raks_birim2_yuksekli")]
    public double? RaksBirim2Yuksekli { get; set; }

    [Column("raks_birim2_dara")]
    public double? RaksBirim2Dara { get; set; }

    [Column("raks_birim3_ad")]
    [StringLength(10)]
    public string? RaksBirim3Ad { get; set; }

    [Column("raks_birim3_katsayi")]
    public double? RaksBirim3Katsayi { get; set; }

    [Column("raks_birim3_agirlik")]
    public double? RaksBirim3Agirlik { get; set; }

    [Column("raks_birim3_en")]
    public double? RaksBirim3En { get; set; }

    [Column("raks_birim3_boy")]
    public double? RaksBirim3Boy { get; set; }

    [Column("raks_birim3_yuksekli")]
    public double? RaksBirim3Yuksekli { get; set; }

    [Column("raks_birim3_dara")]
    public double? RaksBirim3Dara { get; set; }

    [Column("raks_birim4_ad")]
    [StringLength(10)]
    public string? RaksBirim4Ad { get; set; }

    [Column("raks_birim4_katsayi")]
    public double? RaksBirim4Katsayi { get; set; }

    [Column("raks_birim4_agirlik")]
    public double? RaksBirim4Agirlik { get; set; }

    [Column("raks_birim4_en")]
    public double? RaksBirim4En { get; set; }

    [Column("raks_birim4_boy")]
    public double? RaksBirim4Boy { get; set; }

    [Column("raks_birim4_yuksekli")]
    public double? RaksBirim4Yuksekli { get; set; }

    [Column("raks_birim4_dara")]
    public double? RaksBirim4Dara { get; set; }

    [Column("raks_karorani")]
    public double? RaksKarorani { get; set; }

    [Column("raks_reyon_kodu")]
    [StringLength(25)]
    public string? RaksReyonKodu { get; set; }

    [Column("raks_ambalaj_kodu")]
    [StringLength(25)]
    public string? RaksAmbalajKodu { get; set; }

    [Column("raks_biz_stok_kodu")]
    [StringLength(25)]
    public string? RaksBizStokKodu { get; set; }

    [Column("raks_satisfiat")]
    public double? RaksSatisfiat { get; set; }

    [Column("raks_fiat_doviz")]
    public byte? RaksFiatDoviz { get; set; }

    [Column("raks_fiat_opno")]
    public int? RaksFiatOpno { get; set; }

    [Column("raks_fiat_iskonto")]
    [StringLength(4)]
    public string? RaksFiatIskonto { get; set; }

    [Column("raks_kdvdahil")]
    public bool? RaksKdvdahil { get; set; }
}
