using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_hesap_butcesi")]
public class MuhasebeHesapButcesi
{
    [Column("hesbut_Guid")]
    public Guid HesbutGuid { get; set; }

    [Column("hesbut_DBCno")]
    public short? HesbutDBCno { get; set; }

    [Column("hesbut_SpecRECNo")]
    public int? HesbutSpecRECNo { get; set; }

    [Column("hesbut_iptal")]
    public bool? HesbutIptal { get; set; }

    [Column("hesbut_fileid")]
    public short? HesbutFileid { get; set; }

    [Column("hesbut_hidden")]
    public bool? HesbutHidden { get; set; }

    [Column("hesbut_kilitli")]
    public bool? HesbutKilitli { get; set; }

    [Column("hesbut_degisti")]
    public bool? HesbutDegisti { get; set; }

    [Column("hesbut_CheckSum")]
    public int? HesbutCheckSum { get; set; }

    [Column("hesbut_create_user")]
    public short? HesbutCreateUser { get; set; }

    [Column("hesbut_create_date")]
    public DateTime? HesbutCreateDate { get; set; }

    [Column("hesbut_lastup_user")]
    public short? HesbutLastupUser { get; set; }

    [Column("hesbut_lastup_date")]
    public DateTime? HesbutLastupDate { get; set; }

    [Column("hesbut_special1")]
    [StringLength(4)]
    public string? HesbutSpecial1 { get; set; }

    [Column("hesbut_special2")]
    [StringLength(4)]
    public string? HesbutSpecial2 { get; set; }

    [Column("hesbut_special3")]
    [StringLength(4)]
    public string? HesbutSpecial3 { get; set; }

    [Column("hesbut_HesapKodu")]
    [StringLength(25)]
    public string? HesbutHesapKodu { get; set; }

    [Column("hesbut_FirmaNo")]
    public int? HesbutFirmaNo { get; set; }

    [Column("hesbut_MaliYil")]
    public int? HesbutMaliYil { get; set; }

    [Column("hesbut_Donemler1")]
    public double? HesbutDonemler1 { get; set; }

    [Column("hesbut_Donemler1Grup1")]
    public double? HesbutDonemler1Grup1 { get; set; }

    [Column("hesbut_Donemler1Grup2")]
    public double? HesbutDonemler1Grup2 { get; set; }

    [Column("hesbut_Donemler1Grup3")]
    public double? HesbutDonemler1Grup3 { get; set; }

    [Column("hesbut_Donemler1Grup4")]
    public double? HesbutDonemler1Grup4 { get; set; }

    [Column("hesbut_Donemler1Grup5")]
    public double? HesbutDonemler1Grup5 { get; set; }

    [Column("hesbut_Donemler1Grup6")]
    public double? HesbutDonemler1Grup6 { get; set; }

    [Column("hesbut_Donemler2")]
    public double? HesbutDonemler2 { get; set; }

    [Column("hesbut_Donemler2Grup1")]
    public double? HesbutDonemler2Grup1 { get; set; }

    [Column("hesbut_Donemler2Grup2")]
    public double? HesbutDonemler2Grup2 { get; set; }

    [Column("hesbut_Donemler2Grup3")]
    public double? HesbutDonemler2Grup3 { get; set; }

    [Column("hesbut_Donemler2Grup4")]
    public double? HesbutDonemler2Grup4 { get; set; }

    [Column("hesbut_Donemler2Grup5")]
    public double? HesbutDonemler2Grup5 { get; set; }

    [Column("hesbut_Donemler2Grup6")]
    public double? HesbutDonemler2Grup6 { get; set; }

    [Column("hesbut_Donemler3")]
    public double? HesbutDonemler3 { get; set; }

    [Column("hesbut_Donemler3Grup1")]
    public double? HesbutDonemler3Grup1 { get; set; }

    [Column("hesbut_Donemler3Grup2")]
    public double? HesbutDonemler3Grup2 { get; set; }

    [Column("hesbut_Donemler3Grup3")]
    public double? HesbutDonemler3Grup3 { get; set; }

    [Column("hesbut_Donemler3Grup4")]
    public double? HesbutDonemler3Grup4 { get; set; }

    [Column("hesbut_Donemler3Grup5")]
    public double? HesbutDonemler3Grup5 { get; set; }

    [Column("hesbut_Donemler3Grup6")]
    public double? HesbutDonemler3Grup6 { get; set; }

    [Column("hesbut_Donemler4")]
    public double? HesbutDonemler4 { get; set; }

    [Column("hesbut_Donemler4Grup1")]
    public double? HesbutDonemler4Grup1 { get; set; }

    [Column("hesbut_Donemler4Grup2")]
    public double? HesbutDonemler4Grup2 { get; set; }

    [Column("hesbut_Donemler4Grup3")]
    public double? HesbutDonemler4Grup3 { get; set; }

    [Column("hesbut_Donemler4Grup4")]
    public double? HesbutDonemler4Grup4 { get; set; }

    [Column("hesbut_Donemler4Grup5")]
    public double? HesbutDonemler4Grup5 { get; set; }

    [Column("hesbut_Donemler4Grup6")]
    public double? HesbutDonemler4Grup6 { get; set; }

    [Column("hesbut_Donemler5")]
    public double? HesbutDonemler5 { get; set; }

    [Column("hesbut_Donemler5Grup1")]
    public double? HesbutDonemler5Grup1 { get; set; }

    [Column("hesbut_Donemler5Grup2")]
    public double? HesbutDonemler5Grup2 { get; set; }

    [Column("hesbut_Donemler5Grup3")]
    public double? HesbutDonemler5Grup3 { get; set; }

    [Column("hesbut_Donemler5Grup4")]
    public double? HesbutDonemler5Grup4 { get; set; }

    [Column("hesbut_Donemler5Grup5")]
    public double? HesbutDonemler5Grup5 { get; set; }

    [Column("hesbut_Donemler5Grup6")]
    public double? HesbutDonemler5Grup6 { get; set; }

    [Column("hesbut_Donemler6")]
    public double? HesbutDonemler6 { get; set; }

    [Column("hesbut_Donemler6Grup1")]
    public double? HesbutDonemler6Grup1 { get; set; }

    [Column("hesbut_Donemler6Grup2")]
    public double? HesbutDonemler6Grup2 { get; set; }

    [Column("hesbut_Donemler6Grup3")]
    public double? HesbutDonemler6Grup3 { get; set; }

    [Column("hesbut_Donemler6Grup4")]
    public double? HesbutDonemler6Grup4 { get; set; }

    [Column("hesbut_Donemler6Grup5")]
    public double? HesbutDonemler6Grup5 { get; set; }

    [Column("hesbut_Donemler6Grup6")]
    public double? HesbutDonemler6Grup6 { get; set; }

    [Column("hesbut_Donemler7")]
    public double? HesbutDonemler7 { get; set; }

    [Column("hesbut_Donemler7Grup1")]
    public double? HesbutDonemler7Grup1 { get; set; }

    [Column("hesbut_Donemler7Grup2")]
    public double? HesbutDonemler7Grup2 { get; set; }

    [Column("hesbut_Donemler7Grup3")]
    public double? HesbutDonemler7Grup3 { get; set; }

    [Column("hesbut_Donemler7Grup4")]
    public double? HesbutDonemler7Grup4 { get; set; }

    [Column("hesbut_Donemler7Grup5")]
    public double? HesbutDonemler7Grup5 { get; set; }

    [Column("hesbut_Donemler7Grup6")]
    public double? HesbutDonemler7Grup6 { get; set; }

    [Column("hesbut_Donemler8")]
    public double? HesbutDonemler8 { get; set; }

    [Column("hesbut_Donemler8Grup1")]
    public double? HesbutDonemler8Grup1 { get; set; }

    [Column("hesbut_Donemler8Grup2")]
    public double? HesbutDonemler8Grup2 { get; set; }

    [Column("hesbut_Donemler8Grup3")]
    public double? HesbutDonemler8Grup3 { get; set; }

    [Column("hesbut_Donemler8Grup4")]
    public double? HesbutDonemler8Grup4 { get; set; }

    [Column("hesbut_Donemler8Grup5")]
    public double? HesbutDonemler8Grup5 { get; set; }

    [Column("hesbut_Donemler8Grup6")]
    public double? HesbutDonemler8Grup6 { get; set; }

    [Column("hesbut_Donemler9")]
    public double? HesbutDonemler9 { get; set; }

    [Column("hesbut_Donemler9Grup1")]
    public double? HesbutDonemler9Grup1 { get; set; }

    [Column("hesbut_Donemler9Grup2")]
    public double? HesbutDonemler9Grup2 { get; set; }

    [Column("hesbut_Donemler9Grup3")]
    public double? HesbutDonemler9Grup3 { get; set; }

    [Column("hesbut_Donemler9Grup4")]
    public double? HesbutDonemler9Grup4 { get; set; }

    [Column("hesbut_Donemler9Grup5")]
    public double? HesbutDonemler9Grup5 { get; set; }

    [Column("hesbut_Donemler9Grup6")]
    public double? HesbutDonemler9Grup6 { get; set; }

    [Column("hesbut_Donemler10")]
    public double? HesbutDonemler10 { get; set; }

    [Column("hesbut_Donemler10Grup1")]
    public double? HesbutDonemler10Grup1 { get; set; }

    [Column("hesbut_Donemler10Grup2")]
    public double? HesbutDonemler10Grup2 { get; set; }

    [Column("hesbut_Donemler10Grup3")]
    public double? HesbutDonemler10Grup3 { get; set; }

    [Column("hesbut_Donemler10Grup4")]
    public double? HesbutDonemler10Grup4 { get; set; }

    [Column("hesbut_Donemler10Grup5")]
    public double? HesbutDonemler10Grup5 { get; set; }

    [Column("hesbut_Donemler10Grup6")]
    public double? HesbutDonemler10Grup6 { get; set; }

    [Column("hesbut_Donemler11")]
    public double? HesbutDonemler11 { get; set; }

    [Column("hesbut_Donemler11Grup1")]
    public double? HesbutDonemler11Grup1 { get; set; }

    [Column("hesbut_Donemler11Grup2")]
    public double? HesbutDonemler11Grup2 { get; set; }

    [Column("hesbut_Donemler11Grup3")]
    public double? HesbutDonemler11Grup3 { get; set; }

    [Column("hesbut_Donemler11Grup4")]
    public double? HesbutDonemler11Grup4 { get; set; }

    [Column("hesbut_Donemler11Grup5")]
    public double? HesbutDonemler11Grup5 { get; set; }

    [Column("hesbut_Donemler11Grup6")]
    public double? HesbutDonemler11Grup6 { get; set; }

    [Column("hesbut_Donemler12")]
    public double? HesbutDonemler12 { get; set; }

    [Column("hesbut_Donemler12Grup1")]
    public double? HesbutDonemler12Grup1 { get; set; }

    [Column("hesbut_Donemler12Grup2")]
    public double? HesbutDonemler12Grup2 { get; set; }

    [Column("hesbut_Donemler12Grup3")]
    public double? HesbutDonemler12Grup3 { get; set; }

    [Column("hesbut_Donemler12Grup4")]
    public double? HesbutDonemler12Grup4 { get; set; }

    [Column("hesbut_Donemler12Grup5")]
    public double? HesbutDonemler12Grup5 { get; set; }

    [Column("hesbut_Donemler12Grup6")]
    public double? HesbutDonemler12Grup6 { get; set; }

    [Column("hesbut_SrmKodu")]
    [StringLength(25)]
    public string? HesbutSrmKodu { get; set; }

    [Column("hesbut_projekodu")]
    [StringLength(25)]
    public string? HesbutProjekodu { get; set; }
}
