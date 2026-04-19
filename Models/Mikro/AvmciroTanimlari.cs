using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmciro_tanimlari")]
public class AvmciroTanimlari
{
    [Column("Avmc_Guid")]
    public Guid? AvmcGuid { get; set; }

    [Column("Avmc_DBCno")]
    public short? AvmcDBCno { get; set; }

    [Column("Avmc_SpecRECno")]
    public int? AvmcSpecRECno { get; set; }

    [Column("Avmc_iptal")]
    public bool? AvmcIptal { get; set; }

    [Column("Avmc_fileid")]
    public short? AvmcFileid { get; set; }

    [Column("Avmc_hidden")]
    public bool? AvmcHidden { get; set; }

    [Column("Avmc_kilitli")]
    public bool? AvmcKilitli { get; set; }

    [Column("Avmc_degisti")]
    public bool? AvmcDegisti { get; set; }

    [Column("Avmc_checksum")]
    public int? AvmcChecksum { get; set; }

    [Column("Avmc_create_user")]
    public short? AvmcCreateUser { get; set; }

    [Column("Avmc_create_date")]
    public DateTime? AvmcCreateDate { get; set; }

    [Column("Avmc_lastup_user")]
    public short? AvmcLastupUser { get; set; }

    [Column("Avmc_lastup_date")]
    public DateTime? AvmcLastupDate { get; set; }

    [Column("Avmc_special1")]
    [StringLength(4)]
    public string? AvmcSpecial1 { get; set; }

    [Column("Avmc_special2")]
    [StringLength(4)]
    public string? AvmcSpecial2 { get; set; }

    [Column("Avmc_special3")]
    [StringLength(4)]
    public string? AvmcSpecial3 { get; set; }

    [Column("Avmc_cirokira_kodu")]
    [StringLength(25)]
    public string? AvmcCirokiraKodu { get; set; }

    [Column("Avmc_cirobildirimperiyodu")]
    public byte? AvmcCirobildirimperiyodu { get; set; }

    [Column("Avmc_cirodegperyodu")]
    public byte? AvmcCirodegperyodu { get; set; }

    [Column("Avmc_cirodegdvzkriteri")]
    public byte? AvmcCirodegdvzkriteri { get; set; }

    [Column("Avmc_cirodvzdegerleme")]
    public byte? AvmcCirodvzdegerleme { get; set; }

    [Column("Avmc_cirobildirimgecikmesuresi")]
    public short? AvmcCirobildirimgecikmesuresi { get; set; }

    [Column("Avmc_cirobildirimsuresi")]
    public short? AvmcCirobildirimsuresi { get; set; }

    [Column("Avmc_cirokiraodemevadesi")]
    public short? AvmcCirokiraodemevadesi { get; set; }

    [Column("Avmc_cirokiraodemevadfyuz")]
    public double? AvmcCirokiraodemevadfyuz { get; set; }

    [Column("Avmc_cirokirahizmetkodu")]
    [StringLength(25)]
    public string? AvmcCirokirahizmetkodu { get; set; }

    [Column("Avmc_cirokiraodemecinsi")]
    public byte? AvmcCirokiraodemecinsi { get; set; }

    [Column("Avmc_cirokiraodemegunu")]
    public byte? AvmcCirokiraodemegunu { get; set; }

    [Column("Avmc_cirokirasiperyodu")]
    public byte? AvmcCirokirasiperyodu { get; set; }

    [Column("Avmc_cirokirasiperyodaraligi")]
    public short? AvmcCirokirasiperyodaraligi { get; set; }

    [Column("Avmc_CiroKirasiHesYontemi")]
    public byte? AvmcCiroKirasiHesYontemi { get; set; }

    [Column("Avmc_cirokirasiorani")]
    public double? AvmcCirokirasiorani { get; set; }

    [Column("Avmc_cirokirasiorani2")]
    public double? AvmcCirokirasiorani2 { get; set; }

    [Column("Avmc_cirokirasiorani3")]
    public double? AvmcCirokirasiorani3 { get; set; }

    [Column("Avmc_cirokirasi1Bastar")]
    public DateTime? AvmcCirokirasi1Bastar { get; set; }

    [Column("Avmc_cirokirasi1Bittar")]
    public DateTime? AvmcCirokirasi1Bittar { get; set; }

    [Column("Avmc_cirokirasi1Orani")]
    public double? AvmcCirokirasi1Orani { get; set; }

    [Column("Avmc_cirokirasi1Tavan11")]
    public double? AvmcCirokirasi1Tavan11 { get; set; }

    [Column("Avmc_cirokirasi1Tavan12")]
    public double? AvmcCirokirasi1Tavan12 { get; set; }

    [Column("Avmc_cirokirasi1Tavan13")]
    public double? AvmcCirokirasi1Tavan13 { get; set; }

    [Column("Avmc_cirokirasi1Carpani11")]
    public double? AvmcCirokirasi1Carpani11 { get; set; }

    [Column("Avmc_cirokirasi1Carpani12")]
    public double? AvmcCirokirasi1Carpani12 { get; set; }

    [Column("Avmc_cirokirasi1Carpani13")]
    public double? AvmcCirokirasi1Carpani13 { get; set; }

    [Column("Avmc_cirokirasi1TavanAyriDeg_fl1")]
    public bool? AvmcCirokirasi1TavanAyriDegFl1 { get; set; }

    [Column("Avmc_cirokirasi1Orani2")]
    public double? AvmcCirokirasi1Orani2 { get; set; }

    [Column("Avmc_cirokirasi1Tavan21")]
    public double? AvmcCirokirasi1Tavan21 { get; set; }

    [Column("Avmc_cirokirasi1Tavan22")]
    public double? AvmcCirokirasi1Tavan22 { get; set; }

    [Column("Avmc_cirokirasi1Tavan23")]
    public double? AvmcCirokirasi1Tavan23 { get; set; }

    [Column("Avmc_cirokirasi1Carpani21")]
    public double? AvmcCirokirasi1Carpani21 { get; set; }

    [Column("Avmc_cirokirasi1Carpani22")]
    public double? AvmcCirokirasi1Carpani22 { get; set; }

    [Column("Avmc_cirokirasi1Carpani23")]
    public double? AvmcCirokirasi1Carpani23 { get; set; }

    [Column("Avmc_cirokirasi1TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi1TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi1Orani3")]
    public double? AvmcCirokirasi1Orani3 { get; set; }

    [Column("Avmc_cirokirasi1Tavan31")]
    public double? AvmcCirokirasi1Tavan31 { get; set; }

    [Column("Avmc_cirokirasi1Tavan32")]
    public double? AvmcCirokirasi1Tavan32 { get; set; }

    [Column("Avmc_cirokirasi1Tavan33")]
    public double? AvmcCirokirasi1Tavan33 { get; set; }

    [Column("Avmc_cirokirasi1Carpani31")]
    public double? AvmcCirokirasi1Carpani31 { get; set; }

    [Column("Avmc_cirokirasi1Carpani32")]
    public double? AvmcCirokirasi1Carpani32 { get; set; }

    [Column("Avmc_cirokirasi1Carpani33")]
    public double? AvmcCirokirasi1Carpani33 { get; set; }

    [Column("Avmc_cirokirasi1TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi1TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi2Bastar")]
    public DateTime? AvmcCirokirasi2Bastar { get; set; }

    [Column("Avmc_cirokirasi2Bittar")]
    public DateTime? AvmcCirokirasi2Bittar { get; set; }

    [Column("Avmc_cirokirasi2Orani")]
    public double? AvmcCirokirasi2Orani { get; set; }

    [Column("Avmc_cirokirasi2Tavan1")]
    public double? AvmcCirokirasi2Tavan1 { get; set; }

    [Column("Avmc_cirokirasi2Tavan2")]
    public double? AvmcCirokirasi2Tavan2 { get; set; }

    [Column("Avmc_cirokirasi2Tavan3")]
    public double? AvmcCirokirasi2Tavan3 { get; set; }

    [Column("Avmc_cirokirasi2Carpani1")]
    public double? AvmcCirokirasi2Carpani1 { get; set; }

    [Column("Avmc_cirokirasi2Carpani2")]
    public double? AvmcCirokirasi2Carpani2 { get; set; }

    [Column("Avmc_cirokirasi2Carpani3")]
    public double? AvmcCirokirasi2Carpani3 { get; set; }

    [Column("Avmc_cirokirasi2TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi2TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi2Orani2")]
    public double? AvmcCirokirasi2Orani2 { get; set; }

    [Column("Avmc_cirokirasi2Tavan21")]
    public double? AvmcCirokirasi2Tavan21 { get; set; }

    [Column("Avmc_cirokirasi2Tavan22")]
    public double? AvmcCirokirasi2Tavan22 { get; set; }

    [Column("Avmc_cirokirasi2Tavan23")]
    public double? AvmcCirokirasi2Tavan23 { get; set; }

    [Column("Avmc_cirokirasi2Carpani21")]
    public double? AvmcCirokirasi2Carpani21 { get; set; }

    [Column("Avmc_cirokirasi2Carpani22")]
    public double? AvmcCirokirasi2Carpani22 { get; set; }

    [Column("Avmc_cirokirasi2Carpani23")]
    public double? AvmcCirokirasi2Carpani23 { get; set; }

    [Column("Avmc_cirokirasi2TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi2TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi2Orani3")]
    public double? AvmcCirokirasi2Orani3 { get; set; }

    [Column("Avmc_cirokirasi2Tavan31")]
    public double? AvmcCirokirasi2Tavan31 { get; set; }

    [Column("Avmc_cirokirasi2Tavan32")]
    public double? AvmcCirokirasi2Tavan32 { get; set; }

    [Column("Avmc_cirokirasi2Tavan33")]
    public double? AvmcCirokirasi2Tavan33 { get; set; }

    [Column("Avmc_cirokirasi2Carpani31")]
    public double? AvmcCirokirasi2Carpani31 { get; set; }

    [Column("Avmc_cirokirasi2Carpani32")]
    public double? AvmcCirokirasi2Carpani32 { get; set; }

    [Column("Avmc_cirokirasi2Carpani33")]
    public double? AvmcCirokirasi2Carpani33 { get; set; }

    [Column("Avmc_cirokirasi2TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi2TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi3Bastar")]
    public DateTime? AvmcCirokirasi3Bastar { get; set; }

    [Column("Avmc_cirokirasi3Bittar")]
    public DateTime? AvmcCirokirasi3Bittar { get; set; }

    [Column("Avmc_cirokirasi3Orani")]
    public double? AvmcCirokirasi3Orani { get; set; }

    [Column("Avmc_cirokirasi3Tavan1")]
    public double? AvmcCirokirasi3Tavan1 { get; set; }

    [Column("Avmc_cirokirasi3Tavan2")]
    public double? AvmcCirokirasi3Tavan2 { get; set; }

    [Column("Avmc_cirokirasi3Tavan3")]
    public double? AvmcCirokirasi3Tavan3 { get; set; }

    [Column("Avmc_cirokirasi3Carpani1")]
    public double? AvmcCirokirasi3Carpani1 { get; set; }

    [Column("Avmc_cirokirasi3Carpani2")]
    public double? AvmcCirokirasi3Carpani2 { get; set; }

    [Column("Avmc_cirokirasi3Carpani3")]
    public double? AvmcCirokirasi3Carpani3 { get; set; }

    [Column("Avmc_cirokirasi3TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi3TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi3Orani2")]
    public double? AvmcCirokirasi3Orani2 { get; set; }

    [Column("Avmc_cirokirasi3Tavan21")]
    public double? AvmcCirokirasi3Tavan21 { get; set; }

    [Column("Avmc_cirokirasi3Tavan22")]
    public double? AvmcCirokirasi3Tavan22 { get; set; }

    [Column("Avmc_cirokirasi3Tavan23")]
    public double? AvmcCirokirasi3Tavan23 { get; set; }

    [Column("Avmc_cirokirasi3Carpani21")]
    public double? AvmcCirokirasi3Carpani21 { get; set; }

    [Column("Avmc_cirokirasi3Carpani22")]
    public double? AvmcCirokirasi3Carpani22 { get; set; }

    [Column("Avmc_cirokirasi3Carpani23")]
    public double? AvmcCirokirasi3Carpani23 { get; set; }

    [Column("Avmc_cirokirasi3TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi3TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi3Orani3")]
    public double? AvmcCirokirasi3Orani3 { get; set; }

    [Column("Avmc_cirokirasi3Tavan31")]
    public double? AvmcCirokirasi3Tavan31 { get; set; }

    [Column("Avmc_cirokirasi3Tavan32")]
    public double? AvmcCirokirasi3Tavan32 { get; set; }

    [Column("Avmc_cirokirasi3Tavan33")]
    public double? AvmcCirokirasi3Tavan33 { get; set; }

    [Column("Avmc_cirokirasi3Carpani31")]
    public double? AvmcCirokirasi3Carpani31 { get; set; }

    [Column("Avmc_cirokirasi3Carpani32")]
    public double? AvmcCirokirasi3Carpani32 { get; set; }

    [Column("Avmc_cirokirasi3Carpani33")]
    public double? AvmcCirokirasi3Carpani33 { get; set; }

    [Column("Avmc_cirokirasi3TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi3TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi4Bastar")]
    public DateTime? AvmcCirokirasi4Bastar { get; set; }

    [Column("Avmc_cirokirasi4Bittar")]
    public DateTime? AvmcCirokirasi4Bittar { get; set; }

    [Column("Avmc_cirokirasi4Orani")]
    public double? AvmcCirokirasi4Orani { get; set; }

    [Column("Avmc_cirokirasi4Tavan1")]
    public double? AvmcCirokirasi4Tavan1 { get; set; }

    [Column("Avmc_cirokirasi4Tavan2")]
    public double? AvmcCirokirasi4Tavan2 { get; set; }

    [Column("Avmc_cirokirasi4Tavan3")]
    public double? AvmcCirokirasi4Tavan3 { get; set; }

    [Column("Avmc_cirokirasi4Carpani1")]
    public double? AvmcCirokirasi4Carpani1 { get; set; }

    [Column("Avmc_cirokirasi4Carpani2")]
    public double? AvmcCirokirasi4Carpani2 { get; set; }

    [Column("Avmc_cirokirasi4Carpani3")]
    public double? AvmcCirokirasi4Carpani3 { get; set; }

    [Column("Avmc_cirokirasi4TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi4TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi4Orani2")]
    public double? AvmcCirokirasi4Orani2 { get; set; }

    [Column("Avmc_cirokirasi4Tavan21")]
    public double? AvmcCirokirasi4Tavan21 { get; set; }

    [Column("Avmc_cirokirasi4Tavan22")]
    public double? AvmcCirokirasi4Tavan22 { get; set; }

    [Column("Avmc_cirokirasi4Tavan23")]
    public double? AvmcCirokirasi4Tavan23 { get; set; }

    [Column("Avmc_cirokirasi4Carpani21")]
    public double? AvmcCirokirasi4Carpani21 { get; set; }

    [Column("Avmc_cirokirasi4Carpani22")]
    public double? AvmcCirokirasi4Carpani22 { get; set; }

    [Column("Avmc_cirokirasi4Carpani23")]
    public double? AvmcCirokirasi4Carpani23 { get; set; }

    [Column("Avmc_cirokirasi4TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi4TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi4Orani3")]
    public double? AvmcCirokirasi4Orani3 { get; set; }

    [Column("Avmc_cirokirasi4Tavan31")]
    public double? AvmcCirokirasi4Tavan31 { get; set; }

    [Column("Avmc_cirokirasi4Tavan32")]
    public double? AvmcCirokirasi4Tavan32 { get; set; }

    [Column("Avmc_cirokirasi4Tavan33")]
    public double? AvmcCirokirasi4Tavan33 { get; set; }

    [Column("Avmc_cirokirasi4Carpani31")]
    public double? AvmcCirokirasi4Carpani31 { get; set; }

    [Column("Avmc_cirokirasi4Carpani32")]
    public double? AvmcCirokirasi4Carpani32 { get; set; }

    [Column("Avmc_cirokirasi4Carpani33")]
    public double? AvmcCirokirasi4Carpani33 { get; set; }

    [Column("Avmc_cirokirasi5Bastar")]
    public DateTime? AvmcCirokirasi5Bastar { get; set; }

    [Column("Avmc_cirokirasi5Bittar")]
    public DateTime? AvmcCirokirasi5Bittar { get; set; }

    [Column("Avmc_cirokirasi5Orani")]
    public double? AvmcCirokirasi5Orani { get; set; }

    [Column("Avmc_cirokirasi5Tavan1")]
    public double? AvmcCirokirasi5Tavan1 { get; set; }

    [Column("Avmc_cirokirasi5Tavan2")]
    public double? AvmcCirokirasi5Tavan2 { get; set; }

    [Column("Avmc_cirokirasi5Tavan3")]
    public double? AvmcCirokirasi5Tavan3 { get; set; }

    [Column("Avmc_cirokirasi5Carpani1")]
    public double? AvmcCirokirasi5Carpani1 { get; set; }

    [Column("Avmc_cirokirasi5Carpani2")]
    public double? AvmcCirokirasi5Carpani2 { get; set; }

    [Column("Avmc_cirokirasi5Carpani3")]
    public double? AvmcCirokirasi5Carpani3 { get; set; }

    [Column("Avmc_cirokirasi5TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi5TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi5Orani2")]
    public double? AvmcCirokirasi5Orani2 { get; set; }

    [Column("Avmc_cirokirasi5Tavan21")]
    public double? AvmcCirokirasi5Tavan21 { get; set; }

    [Column("Avmc_cirokirasi5Tavan22")]
    public double? AvmcCirokirasi5Tavan22 { get; set; }

    [Column("Avmc_cirokirasi5Tavan23")]
    public double? AvmcCirokirasi5Tavan23 { get; set; }

    [Column("Avmc_cirokirasi5Carpani21")]
    public double? AvmcCirokirasi5Carpani21 { get; set; }

    [Column("Avmc_cirokirasi5Carpani22")]
    public double? AvmcCirokirasi5Carpani22 { get; set; }

    [Column("Avmc_cirokirasi5Carpani23")]
    public double? AvmcCirokirasi5Carpani23 { get; set; }

    [Column("Avmc_cirokirasi5TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi5TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi5Orani3")]
    public double? AvmcCirokirasi5Orani3 { get; set; }

    [Column("Avmc_cirokirasi5Tavan31")]
    public double? AvmcCirokirasi5Tavan31 { get; set; }

    [Column("Avmc_cirokirasi5Tavan32")]
    public double? AvmcCirokirasi5Tavan32 { get; set; }

    [Column("Avmc_cirokirasi5Tavan33")]
    public double? AvmcCirokirasi5Tavan33 { get; set; }

    [Column("Avmc_cirokirasi5Carpani31")]
    public double? AvmcCirokirasi5Carpani31 { get; set; }

    [Column("Avmc_cirokirasi5Carpani32")]
    public double? AvmcCirokirasi5Carpani32 { get; set; }

    [Column("Avmc_cirokirasi5Carpani33")]
    public double? AvmcCirokirasi5Carpani33 { get; set; }

    [Column("Avmc_cirokirasi5TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi5TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi6Bastar")]
    public DateTime? AvmcCirokirasi6Bastar { get; set; }

    [Column("Avmc_cirokirasi6Bittar")]
    public DateTime? AvmcCirokirasi6Bittar { get; set; }

    [Column("Avmc_cirokirasi6Orani")]
    public double? AvmcCirokirasi6Orani { get; set; }

    [Column("Avmc_cirokirasi6Tavan1")]
    public double? AvmcCirokirasi6Tavan1 { get; set; }

    [Column("Avmc_cirokirasi6Tavan2")]
    public double? AvmcCirokirasi6Tavan2 { get; set; }

    [Column("Avmc_cirokirasi6Tavan3")]
    public double? AvmcCirokirasi6Tavan3 { get; set; }

    [Column("Avmc_cirokirasi6Carpani1")]
    public double? AvmcCirokirasi6Carpani1 { get; set; }

    [Column("Avmc_cirokirasi6Carpani2")]
    public double? AvmcCirokirasi6Carpani2 { get; set; }

    [Column("Avmc_cirokirasi6Carpani3")]
    public double? AvmcCirokirasi6Carpani3 { get; set; }

    [Column("Avmc_cirokirasi6TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi6TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi6Orani2")]
    public double? AvmcCirokirasi6Orani2 { get; set; }

    [Column("Avmc_cirokirasi6Tavan21")]
    public double? AvmcCirokirasi6Tavan21 { get; set; }

    [Column("Avmc_cirokirasi6Tavan22")]
    public double? AvmcCirokirasi6Tavan22 { get; set; }

    [Column("Avmc_cirokirasi6Tavan23")]
    public double? AvmcCirokirasi6Tavan23 { get; set; }

    [Column("Avmc_cirokirasi6Carpani21")]
    public double? AvmcCirokirasi6Carpani21 { get; set; }

    [Column("Avmc_cirokirasi6Carpani22")]
    public double? AvmcCirokirasi6Carpani22 { get; set; }

    [Column("Avmc_cirokirasi6Carpani23")]
    public double? AvmcCirokirasi6Carpani23 { get; set; }

    [Column("Avmc_cirokirasi6TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi6TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi6Orani3")]
    public double? AvmcCirokirasi6Orani3 { get; set; }

    [Column("Avmc_cirokirasi6Tavan31")]
    public double? AvmcCirokirasi6Tavan31 { get; set; }

    [Column("Avmc_cirokirasi6Tavan32")]
    public double? AvmcCirokirasi6Tavan32 { get; set; }

    [Column("Avmc_cirokirasi6Tavan33")]
    public double? AvmcCirokirasi6Tavan33 { get; set; }

    [Column("Avmc_cirokirasi6Carpani31")]
    public double? AvmcCirokirasi6Carpani31 { get; set; }

    [Column("Avmc_cirokirasi6Carpani32")]
    public double? AvmcCirokirasi6Carpani32 { get; set; }

    [Column("Avmc_cirokirasi6Carpani33")]
    public double? AvmcCirokirasi6Carpani33 { get; set; }

    [Column("Avmc_cirokirasi6TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi6TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi7Bastar")]
    public DateTime? AvmcCirokirasi7Bastar { get; set; }

    [Column("Avmc_cirokirasi7Bittar")]
    public DateTime? AvmcCirokirasi7Bittar { get; set; }

    [Column("Avmc_cirokirasi7Orani")]
    public double? AvmcCirokirasi7Orani { get; set; }

    [Column("Avmc_cirokirasi7Tavan1")]
    public double? AvmcCirokirasi7Tavan1 { get; set; }

    [Column("Avmc_cirokirasi7Tavan2")]
    public double? AvmcCirokirasi7Tavan2 { get; set; }

    [Column("Avmc_cirokirasi7Tavan3")]
    public double? AvmcCirokirasi7Tavan3 { get; set; }

    [Column("Avmc_cirokirasi7Carpani1")]
    public double? AvmcCirokirasi7Carpani1 { get; set; }

    [Column("Avmc_cirokirasi7Carpani2")]
    public double? AvmcCirokirasi7Carpani2 { get; set; }

    [Column("Avmc_cirokirasi7Carpani3")]
    public double? AvmcCirokirasi7Carpani3 { get; set; }

    [Column("Avmc_cirokirasi7TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi7TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi7Orani2")]
    public double? AvmcCirokirasi7Orani2 { get; set; }

    [Column("Avmc_cirokirasi7Tavan21")]
    public double? AvmcCirokirasi7Tavan21 { get; set; }

    [Column("Avmc_cirokirasi7Tavan22")]
    public double? AvmcCirokirasi7Tavan22 { get; set; }

    [Column("Avmc_cirokirasi7Tavan23")]
    public double? AvmcCirokirasi7Tavan23 { get; set; }

    [Column("Avmc_cirokirasi7Carpani21")]
    public double? AvmcCirokirasi7Carpani21 { get; set; }

    [Column("Avmc_cirokirasi7Carpani22")]
    public double? AvmcCirokirasi7Carpani22 { get; set; }

    [Column("Avmc_cirokirasi7Carpani23")]
    public double? AvmcCirokirasi7Carpani23 { get; set; }

    [Column("Avmc_cirokirasi7TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi7TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi7Orani3")]
    public double? AvmcCirokirasi7Orani3 { get; set; }

    [Column("Avmc_cirokirasi7Tavan31")]
    public double? AvmcCirokirasi7Tavan31 { get; set; }

    [Column("Avmc_cirokirasi7Tavan32")]
    public double? AvmcCirokirasi7Tavan32 { get; set; }

    [Column("Avmc_cirokirasi7Tavan33")]
    public double? AvmcCirokirasi7Tavan33 { get; set; }

    [Column("Avmc_cirokirasi7Carpani31")]
    public double? AvmcCirokirasi7Carpani31 { get; set; }

    [Column("Avmc_cirokirasi7Carpani32")]
    public double? AvmcCirokirasi7Carpani32 { get; set; }

    [Column("Avmc_cirokirasi7Carpani33")]
    public double? AvmcCirokirasi7Carpani33 { get; set; }

    [Column("Avmc_cirokirasi7TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi7TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi8Bastar")]
    public DateTime? AvmcCirokirasi8Bastar { get; set; }

    [Column("Avmc_cirokirasi8Bittar")]
    public DateTime? AvmcCirokirasi8Bittar { get; set; }

    [Column("Avmc_cirokirasi8Orani")]
    public double? AvmcCirokirasi8Orani { get; set; }

    [Column("Avmc_cirokirasi8Tavan1")]
    public double? AvmcCirokirasi8Tavan1 { get; set; }

    [Column("Avmc_cirokirasi8Tavan2")]
    public double? AvmcCirokirasi8Tavan2 { get; set; }

    [Column("Avmc_cirokirasi8Tavan3")]
    public double? AvmcCirokirasi8Tavan3 { get; set; }

    [Column("Avmc_cirokirasi8Carpani1")]
    public double? AvmcCirokirasi8Carpani1 { get; set; }

    [Column("Avmc_cirokirasi8Carpani2")]
    public double? AvmcCirokirasi8Carpani2 { get; set; }

    [Column("Avmc_cirokirasi8Carpani3")]
    public double? AvmcCirokirasi8Carpani3 { get; set; }

    [Column("Avmc_cirokirasi8TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi8TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi8Orani2")]
    public double? AvmcCirokirasi8Orani2 { get; set; }

    [Column("Avmc_cirokirasi8Tavan21")]
    public double? AvmcCirokirasi8Tavan21 { get; set; }

    [Column("Avmc_cirokirasi8Tavan22")]
    public double? AvmcCirokirasi8Tavan22 { get; set; }

    [Column("Avmc_cirokirasi8Tavan23")]
    public double? AvmcCirokirasi8Tavan23 { get; set; }

    [Column("Avmc_cirokirasi8Carpani21")]
    public double? AvmcCirokirasi8Carpani21 { get; set; }

    [Column("Avmc_cirokirasi8Carpani22")]
    public double? AvmcCirokirasi8Carpani22 { get; set; }

    [Column("Avmc_cirokirasi8Carpani23")]
    public double? AvmcCirokirasi8Carpani23 { get; set; }

    [Column("Avmc_cirokirasi8TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi8TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi8Orani3")]
    public double? AvmcCirokirasi8Orani3 { get; set; }

    [Column("Avmc_cirokirasi8Tavan31")]
    public double? AvmcCirokirasi8Tavan31 { get; set; }

    [Column("Avmc_cirokirasi8Tavan32")]
    public double? AvmcCirokirasi8Tavan32 { get; set; }

    [Column("Avmc_cirokirasi8Tavan33")]
    public double? AvmcCirokirasi8Tavan33 { get; set; }

    [Column("Avmc_cirokirasi8Carpani31")]
    public double? AvmcCirokirasi8Carpani31 { get; set; }

    [Column("Avmc_cirokirasi8Carpani32")]
    public double? AvmcCirokirasi8Carpani32 { get; set; }

    [Column("Avmc_cirokirasi8Carpani33")]
    public double? AvmcCirokirasi8Carpani33 { get; set; }

    [Column("Avmc_cirokirasi8TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi8TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi9Bastar")]
    public DateTime? AvmcCirokirasi9Bastar { get; set; }

    [Column("Avmc_cirokirasi9Bittar")]
    public DateTime? AvmcCirokirasi9Bittar { get; set; }

    [Column("Avmc_cirokirasi9Orani")]
    public double? AvmcCirokirasi9Orani { get; set; }

    [Column("Avmc_cirokirasi9Tavan1")]
    public double? AvmcCirokirasi9Tavan1 { get; set; }

    [Column("Avmc_cirokirasi9Tavan2")]
    public double? AvmcCirokirasi9Tavan2 { get; set; }

    [Column("Avmc_cirokirasi9Tavan3")]
    public double? AvmcCirokirasi9Tavan3 { get; set; }

    [Column("Avmc_cirokirasi9Carpani1")]
    public double? AvmcCirokirasi9Carpani1 { get; set; }

    [Column("Avmc_cirokirasi9Carpani2")]
    public double? AvmcCirokirasi9Carpani2 { get; set; }

    [Column("Avmc_cirokirasi9Carpani3")]
    public double? AvmcCirokirasi9Carpani3 { get; set; }

    [Column("Avmc_cirokirasi9TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi9TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi9Orani2")]
    public double? AvmcCirokirasi9Orani2 { get; set; }

    [Column("Avmc_cirokirasi9Tavan21")]
    public double? AvmcCirokirasi9Tavan21 { get; set; }

    [Column("Avmc_cirokirasi9Tavan22")]
    public double? AvmcCirokirasi9Tavan22 { get; set; }

    [Column("Avmc_cirokirasi9Tavan23")]
    public double? AvmcCirokirasi9Tavan23 { get; set; }

    [Column("Avmc_cirokirasi9Carpani21")]
    public double? AvmcCirokirasi9Carpani21 { get; set; }

    [Column("Avmc_cirokirasi9Carpani22")]
    public double? AvmcCirokirasi9Carpani22 { get; set; }

    [Column("Avmc_cirokirasi9Carpani23")]
    public double? AvmcCirokirasi9Carpani23 { get; set; }

    [Column("Avmc_cirokirasi9TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi9TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi9Orani3")]
    public double? AvmcCirokirasi9Orani3 { get; set; }

    [Column("Avmc_cirokirasi9Tavan31")]
    public double? AvmcCirokirasi9Tavan31 { get; set; }

    [Column("Avmc_cirokirasi9Tavan32")]
    public double? AvmcCirokirasi9Tavan32 { get; set; }

    [Column("Avmc_cirokirasi9Tavan33")]
    public double? AvmcCirokirasi9Tavan33 { get; set; }

    [Column("Avmc_cirokirasi9Carpani31")]
    public double? AvmcCirokirasi9Carpani31 { get; set; }

    [Column("Avmc_cirokirasi9Carpani32")]
    public double? AvmcCirokirasi9Carpani32 { get; set; }

    [Column("Avmc_cirokirasi9Carpani33")]
    public double? AvmcCirokirasi9Carpani33 { get; set; }

    [Column("Avmc_cirokirasi9TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi9TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi10Bastar")]
    public DateTime? AvmcCirokirasi10Bastar { get; set; }

    [Column("Avmc_cirokirasi10Bittar")]
    public DateTime? AvmcCirokirasi10Bittar { get; set; }

    [Column("Avmc_cirokirasi10Orani")]
    public double? AvmcCirokirasi10Orani { get; set; }

    [Column("Avmc_cirokirasi10Tavan1")]
    public double? AvmcCirokirasi10Tavan1 { get; set; }

    [Column("Avmc_cirokirasi10Tavan2")]
    public double? AvmcCirokirasi10Tavan2 { get; set; }

    [Column("Avmc_cirokirasi10Tavan3")]
    public double? AvmcCirokirasi10Tavan3 { get; set; }

    [Column("Avmc_cirokirasi10Carpani1")]
    public double? AvmcCirokirasi10Carpani1 { get; set; }

    [Column("Avmc_cirokirasi10Carpani2")]
    public double? AvmcCirokirasi10Carpani2 { get; set; }

    [Column("Avmc_cirokirasi10Carpani3")]
    public double? AvmcCirokirasi10Carpani3 { get; set; }

    [Column("Avmc_cirokirasi10TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi10TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi10Orani2")]
    public double? AvmcCirokirasi10Orani2 { get; set; }

    [Column("Avmc_cirokirasi10Tavan21")]
    public double? AvmcCirokirasi10Tavan21 { get; set; }

    [Column("Avmc_cirokirasi10Tavan22")]
    public double? AvmcCirokirasi10Tavan22 { get; set; }

    [Column("Avmc_cirokirasi10Tavan23")]
    public double? AvmcCirokirasi10Tavan23 { get; set; }

    [Column("Avmc_cirokirasi10Carpani21")]
    public double? AvmcCirokirasi10Carpani21 { get; set; }

    [Column("Avmc_cirokirasi10Carpani22")]
    public double? AvmcCirokirasi10Carpani22 { get; set; }

    [Column("Avmc_cirokirasi10Carpani23")]
    public double? AvmcCirokirasi10Carpani23 { get; set; }

    [Column("Avmc_cirokirasi10TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi10TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi10Orani3")]
    public double? AvmcCirokirasi10Orani3 { get; set; }

    [Column("Avmc_cirokirasi10Tavan31")]
    public double? AvmcCirokirasi10Tavan31 { get; set; }

    [Column("Avmc_cirokirasi10Tavan32")]
    public double? AvmcCirokirasi10Tavan32 { get; set; }

    [Column("Avmc_cirokirasi10Tavan33")]
    public double? AvmcCirokirasi10Tavan33 { get; set; }

    [Column("Avmc_cirokirasi10Carpani31")]
    public double? AvmcCirokirasi10Carpani31 { get; set; }

    [Column("Avmc_cirokirasi10Carpani32")]
    public double? AvmcCirokirasi10Carpani32 { get; set; }

    [Column("Avmc_cirokirasi10Carpani33")]
    public double? AvmcCirokirasi10Carpani33 { get; set; }

    [Column("Avmc_cirokirasi10TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi10TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi11Bastar")]
    public DateTime? AvmcCirokirasi11Bastar { get; set; }

    [Column("Avmc_cirokirasi11Bittar")]
    public DateTime? AvmcCirokirasi11Bittar { get; set; }

    [Column("Avmc_cirokirasi11Orani")]
    public double? AvmcCirokirasi11Orani { get; set; }

    [Column("Avmc_cirokirasi11Tavan1")]
    public double? AvmcCirokirasi11Tavan1 { get; set; }

    [Column("Avmc_cirokirasi11Tavan2")]
    public double? AvmcCirokirasi11Tavan2 { get; set; }

    [Column("Avmc_cirokirasi11Tavan3")]
    public double? AvmcCirokirasi11Tavan3 { get; set; }

    [Column("Avmc_cirokirasi11Carpani1")]
    public double? AvmcCirokirasi11Carpani1 { get; set; }

    [Column("Avmc_cirokirasi11Carpani2")]
    public double? AvmcCirokirasi11Carpani2 { get; set; }

    [Column("Avmc_cirokirasi11Carpani3")]
    public double? AvmcCirokirasi11Carpani3 { get; set; }

    [Column("Avmc_cirokirasi11TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi11TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi11Orani2")]
    public double? AvmcCirokirasi11Orani2 { get; set; }

    [Column("Avmc_cirokirasi11Tavan21")]
    public double? AvmcCirokirasi11Tavan21 { get; set; }

    [Column("Avmc_cirokirasi11Tavan22")]
    public double? AvmcCirokirasi11Tavan22 { get; set; }

    [Column("Avmc_cirokirasi11Tavan23")]
    public double? AvmcCirokirasi11Tavan23 { get; set; }

    [Column("Avmc_cirokirasi11Carpani21")]
    public double? AvmcCirokirasi11Carpani21 { get; set; }

    [Column("Avmc_cirokirasi11Carpani22")]
    public double? AvmcCirokirasi11Carpani22 { get; set; }

    [Column("Avmc_cirokirasi11Carpani23")]
    public double? AvmcCirokirasi11Carpani23 { get; set; }

    [Column("Avmc_cirokirasi11TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi11TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi11Orani3")]
    public double? AvmcCirokirasi11Orani3 { get; set; }

    [Column("Avmc_cirokirasi11Tavan31")]
    public double? AvmcCirokirasi11Tavan31 { get; set; }

    [Column("Avmc_cirokirasi11Tavan32")]
    public double? AvmcCirokirasi11Tavan32 { get; set; }

    [Column("Avmc_cirokirasi11Tavan33")]
    public double? AvmcCirokirasi11Tavan33 { get; set; }

    [Column("Avmc_cirokirasi11Carpani31")]
    public double? AvmcCirokirasi11Carpani31 { get; set; }

    [Column("Avmc_cirokirasi11Carpani32")]
    public double? AvmcCirokirasi11Carpani32 { get; set; }

    [Column("Avmc_cirokirasi11Carpani33")]
    public double? AvmcCirokirasi11Carpani33 { get; set; }

    [Column("Avmc_cirokirasi11TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi11TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi12Bastar")]
    public DateTime? AvmcCirokirasi12Bastar { get; set; }

    [Column("Avmc_cirokirasi12Bittar")]
    public DateTime? AvmcCirokirasi12Bittar { get; set; }

    [Column("Avmc_cirokirasi12Orani")]
    public double? AvmcCirokirasi12Orani { get; set; }

    [Column("Avmc_cirokirasi12Tavan1")]
    public double? AvmcCirokirasi12Tavan1 { get; set; }

    [Column("Avmc_cirokirasi12Tavan2")]
    public double? AvmcCirokirasi12Tavan2 { get; set; }

    [Column("Avmc_cirokirasi12Tavan3")]
    public double? AvmcCirokirasi12Tavan3 { get; set; }

    [Column("Avmc_cirokirasi12Carpani1")]
    public double? AvmcCirokirasi12Carpani1 { get; set; }

    [Column("Avmc_cirokirasi12Carpani2")]
    public double? AvmcCirokirasi12Carpani2 { get; set; }

    [Column("Avmc_cirokirasi12Carpani3")]
    public double? AvmcCirokirasi12Carpani3 { get; set; }

    [Column("Avmc_cirokirasi12TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi12TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi12Orani2")]
    public double? AvmcCirokirasi12Orani2 { get; set; }

    [Column("Avmc_cirokirasi12Tavan21")]
    public double? AvmcCirokirasi12Tavan21 { get; set; }

    [Column("Avmc_cirokirasi12Tavan22")]
    public double? AvmcCirokirasi12Tavan22 { get; set; }

    [Column("Avmc_cirokirasi12Tavan23")]
    public double? AvmcCirokirasi12Tavan23 { get; set; }

    [Column("Avmc_cirokirasi12Carpani21")]
    public double? AvmcCirokirasi12Carpani21 { get; set; }

    [Column("Avmc_cirokirasi12Carpani22")]
    public double? AvmcCirokirasi12Carpani22 { get; set; }

    [Column("Avmc_cirokirasi12Carpani23")]
    public double? AvmcCirokirasi12Carpani23 { get; set; }

    [Column("Avmc_cirokirasi12TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi12TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi12Orani3")]
    public double? AvmcCirokirasi12Orani3 { get; set; }

    [Column("Avmc_cirokirasi12Tavan31")]
    public double? AvmcCirokirasi12Tavan31 { get; set; }

    [Column("Avmc_cirokirasi12Tavan32")]
    public double? AvmcCirokirasi12Tavan32 { get; set; }

    [Column("Avmc_cirokirasi12Tavan33")]
    public double? AvmcCirokirasi12Tavan33 { get; set; }

    [Column("Avmc_cirokirasi12Carpani31")]
    public double? AvmcCirokirasi12Carpani31 { get; set; }

    [Column("Avmc_cirokirasi12Carpani32")]
    public double? AvmcCirokirasi12Carpani32 { get; set; }

    [Column("Avmc_cirokirasi12Carpani33")]
    public double? AvmcCirokirasi12Carpani33 { get; set; }

    [Column("Avmc_cirokirasi12TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi12TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi13Bastar")]
    public DateTime? AvmcCirokirasi13Bastar { get; set; }

    [Column("Avmc_cirokirasi13Bittar")]
    public DateTime? AvmcCirokirasi13Bittar { get; set; }

    [Column("Avmc_cirokirasi13Orani")]
    public double? AvmcCirokirasi13Orani { get; set; }

    [Column("Avmc_cirokirasi13Tavan1")]
    public double? AvmcCirokirasi13Tavan1 { get; set; }

    [Column("Avmc_cirokirasi13Tavan2")]
    public double? AvmcCirokirasi13Tavan2 { get; set; }

    [Column("Avmc_cirokirasi13Tavan3")]
    public double? AvmcCirokirasi13Tavan3 { get; set; }

    [Column("Avmc_cirokirasi13Carpani1")]
    public double? AvmcCirokirasi13Carpani1 { get; set; }

    [Column("Avmc_cirokirasi13Carpani2")]
    public double? AvmcCirokirasi13Carpani2 { get; set; }

    [Column("Avmc_cirokirasi13Carpani3")]
    public double? AvmcCirokirasi13Carpani3 { get; set; }

    [Column("Avmc_cirokirasi13TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi13TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi13Orani2")]
    public double? AvmcCirokirasi13Orani2 { get; set; }

    [Column("Avmc_cirokirasi13Tavan21")]
    public double? AvmcCirokirasi13Tavan21 { get; set; }

    [Column("Avmc_cirokirasi13Tavan22")]
    public double? AvmcCirokirasi13Tavan22 { get; set; }

    [Column("Avmc_cirokirasi13Tavan23")]
    public double? AvmcCirokirasi13Tavan23 { get; set; }

    [Column("Avmc_cirokirasi13Carpani21")]
    public double? AvmcCirokirasi13Carpani21 { get; set; }

    [Column("Avmc_cirokirasi13Carpani22")]
    public double? AvmcCirokirasi13Carpani22 { get; set; }

    [Column("Avmc_cirokirasi13Carpani23")]
    public double? AvmcCirokirasi13Carpani23 { get; set; }

    [Column("Avmc_cirokirasi13TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi13TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi13Orani3")]
    public double? AvmcCirokirasi13Orani3 { get; set; }

    [Column("Avmc_cirokirasi13Tavan31")]
    public double? AvmcCirokirasi13Tavan31 { get; set; }

    [Column("Avmc_cirokirasi13Tavan32")]
    public double? AvmcCirokirasi13Tavan32 { get; set; }

    [Column("Avmc_cirokirasi13Tavan33")]
    public double? AvmcCirokirasi13Tavan33 { get; set; }

    [Column("Avmc_cirokirasi13Carpani31")]
    public double? AvmcCirokirasi13Carpani31 { get; set; }

    [Column("Avmc_cirokirasi13Carpani32")]
    public double? AvmcCirokirasi13Carpani32 { get; set; }

    [Column("Avmc_cirokirasi13Carpani33")]
    public double? AvmcCirokirasi13Carpani33 { get; set; }

    [Column("Avmc_cirokirasi13TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi13TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi14Bastar")]
    public DateTime? AvmcCirokirasi14Bastar { get; set; }

    [Column("Avmc_cirokirasi14Bittar")]
    public DateTime? AvmcCirokirasi14Bittar { get; set; }

    [Column("Avmc_cirokirasi14Orani")]
    public double? AvmcCirokirasi14Orani { get; set; }

    [Column("Avmc_cirokirasi14Tavan1")]
    public double? AvmcCirokirasi14Tavan1 { get; set; }

    [Column("Avmc_cirokirasi14Tavan2")]
    public double? AvmcCirokirasi14Tavan2 { get; set; }

    [Column("Avmc_cirokirasi14Tavan3")]
    public double? AvmcCirokirasi14Tavan3 { get; set; }

    [Column("Avmc_cirokirasi14Carpani1")]
    public double? AvmcCirokirasi14Carpani1 { get; set; }

    [Column("Avmc_cirokirasi14Carpani2")]
    public double? AvmcCirokirasi14Carpani2 { get; set; }

    [Column("Avmc_cirokirasi14Carpani3")]
    public double? AvmcCirokirasi14Carpani3 { get; set; }

    [Column("Avmc_cirokirasi14TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi14TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi14Orani2")]
    public double? AvmcCirokirasi14Orani2 { get; set; }

    [Column("Avmc_cirokirasi14Tavan21")]
    public double? AvmcCirokirasi14Tavan21 { get; set; }

    [Column("Avmc_cirokirasi14Tavan22")]
    public double? AvmcCirokirasi14Tavan22 { get; set; }

    [Column("Avmc_cirokirasi14Tavan23")]
    public double? AvmcCirokirasi14Tavan23 { get; set; }

    [Column("Avmc_cirokirasi14Carpani21")]
    public double? AvmcCirokirasi14Carpani21 { get; set; }

    [Column("Avmc_cirokirasi14Carpani22")]
    public double? AvmcCirokirasi14Carpani22 { get; set; }

    [Column("Avmc_cirokirasi14Carpani23")]
    public double? AvmcCirokirasi14Carpani23 { get; set; }

    [Column("Avmc_cirokirasi14TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi14TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi14Orani3")]
    public double? AvmcCirokirasi14Orani3 { get; set; }

    [Column("Avmc_cirokirasi14Tavan31")]
    public double? AvmcCirokirasi14Tavan31 { get; set; }

    [Column("Avmc_cirokirasi14Tavan32")]
    public double? AvmcCirokirasi14Tavan32 { get; set; }

    [Column("Avmc_cirokirasi14Tavan33")]
    public double? AvmcCirokirasi14Tavan33 { get; set; }

    [Column("Avmc_cirokirasi14Carpani31")]
    public double? AvmcCirokirasi14Carpani31 { get; set; }

    [Column("Avmc_cirokirasi14Carpani32")]
    public double? AvmcCirokirasi14Carpani32 { get; set; }

    [Column("Avmc_cirokirasi14Carpani33")]
    public double? AvmcCirokirasi14Carpani33 { get; set; }

    [Column("Avmc_cirokirasi14TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi14TavanAyriDegFl3 { get; set; }

    [Column("Avmc_cirokirasi15Bastar")]
    public DateTime? AvmcCirokirasi15Bastar { get; set; }

    [Column("Avmc_cirokirasi15Bittar")]
    public DateTime? AvmcCirokirasi15Bittar { get; set; }

    [Column("Avmc_cirokirasi15Orani")]
    public double? AvmcCirokirasi15Orani { get; set; }

    [Column("Avmc_cirokirasi15Tavan1")]
    public double? AvmcCirokirasi15Tavan1 { get; set; }

    [Column("Avmc_cirokirasi15Tavan2")]
    public double? AvmcCirokirasi15Tavan2 { get; set; }

    [Column("Avmc_cirokirasi15Tavan3")]
    public double? AvmcCirokirasi15Tavan3 { get; set; }

    [Column("Avmc_cirokirasi15Carpani1")]
    public double? AvmcCirokirasi15Carpani1 { get; set; }

    [Column("Avmc_cirokirasi15Carpani2")]
    public double? AvmcCirokirasi15Carpani2 { get; set; }

    [Column("Avmc_cirokirasi15Carpani3")]
    public double? AvmcCirokirasi15Carpani3 { get; set; }

    [Column("Avmc_cirokirasi15TavanAyriDeg_fl")]
    public bool? AvmcCirokirasi15TavanAyriDegFl { get; set; }

    [Column("Avmc_cirokirasi15Orani2")]
    public double? AvmcCirokirasi15Orani2 { get; set; }

    [Column("Avmc_cirokirasi15Tavan21")]
    public double? AvmcCirokirasi15Tavan21 { get; set; }

    [Column("Avmc_cirokirasi15Tavan22")]
    public double? AvmcCirokirasi15Tavan22 { get; set; }

    [Column("Avmc_cirokirasi15Tavan23")]
    public double? AvmcCirokirasi15Tavan23 { get; set; }

    [Column("Avmc_cirokirasi15Carpani21")]
    public double? AvmcCirokirasi15Carpani21 { get; set; }

    [Column("Avmc_cirokirasi15Carpani22")]
    public double? AvmcCirokirasi15Carpani22 { get; set; }

    [Column("Avmc_cirokirasi15Carpani23")]
    public double? AvmcCirokirasi15Carpani23 { get; set; }

    [Column("Avmc_cirokirasi15TavanAyriDeg_fl2")]
    public bool? AvmcCirokirasi15TavanAyriDegFl2 { get; set; }

    [Column("Avmc_cirokirasi15Orani3")]
    public double? AvmcCirokirasi15Orani3 { get; set; }

    [Column("Avmc_cirokirasi15Tavan31")]
    public double? AvmcCirokirasi15Tavan31 { get; set; }

    [Column("Avmc_cirokirasi15Tavan32")]
    public double? AvmcCirokirasi15Tavan32 { get; set; }

    [Column("Avmc_cirokirasi15Tavan33")]
    public double? AvmcCirokirasi15Tavan33 { get; set; }

    [Column("Avmc_cirokirasi15Carpani31")]
    public double? AvmcCirokirasi15Carpani31 { get; set; }

    [Column("Avmc_cirokirasi15Carpani32")]
    public double? AvmcCirokirasi15Carpani32 { get; set; }

    [Column("Avmc_cirokirasi15Carpani33")]
    public double? AvmcCirokirasi15Carpani33 { get; set; }

    [Column("Avmc_cirokirasi15TavanAyriDeg_fl3")]
    public bool? AvmcCirokirasi15TavanAyriDegFl3 { get; set; }
}
