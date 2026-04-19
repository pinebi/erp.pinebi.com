using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("masraf_hesaplari")]
public class MasrafHesaplari
{
    [Column("his_Guid")]
    public Guid? HisGuid { get; set; }

    [Column("his_DBCno")]
    public short? HisDBCno { get; set; }

    [Column("his_Spec_Rec_no")]
    public int? HisSpecRecNo { get; set; }

    [Column("his_iptal")]
    public bool? HisIptal { get; set; }

    [Column("his_fileid")]
    public short? HisFileid { get; set; }

    [Column("his_hidden")]
    public bool? HisHidden { get; set; }

    [Column("his_kilitli")]
    public bool? HisKilitli { get; set; }

    [Column("his_degisti")]
    public bool? HisDegisti { get; set; }

    [Column("his_checksum")]
    public int? HisChecksum { get; set; }

    [Column("his_create_user")]
    public short? HisCreateUser { get; set; }

    [Column("his_create_date")]
    public DateTime? HisCreateDate { get; set; }

    [Column("his_lastup_user")]
    public short? HisLastupUser { get; set; }

    [Column("his_lastup_date")]
    public DateTime? HisLastupDate { get; set; }

    [Column("his_special1")]
    [StringLength(4)]
    public string? HisSpecial1 { get; set; }

    [Column("his_special2")]
    [StringLength(4)]
    public string? HisSpecial2 { get; set; }

    [Column("his_special3")]
    [StringLength(4)]
    public string? HisSpecial3 { get; set; }

    [Column("his_kod")]
    [StringLength(25)]
    public string? HisKod { get; set; }

    [Column("his_isim")]
    [StringLength(40)]
    public string? HisIsim { get; set; }

    [Column("his_yabanci_isim")]
    [StringLength(50)]
    public string? HisYabanciIsim { get; set; }

    [Column("his_tipkod")]
    [StringLength(25)]
    public string? HisTipkod { get; set; }

    [Column("his_sinifkod")]
    [StringLength(25)]
    public string? HisSinifkod { get; set; }

    [Column("his_grupkod")]
    [StringLength(25)]
    public string? HisGrupkod { get; set; }

    [Column("his_muhkod")]
    [StringLength(40)]
    public string? HisMuhkod { get; set; }

    [Column("his_mal_yan_muhkod")]
    [StringLength(40)]
    public string? HisMalYanMuhkod { get; set; }

    [Column("his_gel_tablo_muhkod")]
    [StringLength(40)]
    public string? HisGelTabloMuhkod { get; set; }

    [Column("his_dovcinsi")]
    public byte? HisDovcinsi { get; set; }

    [Column("his_muh_sat_isk_kod")]
    [StringLength(40)]
    public string? HisMuhSatIskKod { get; set; }

    [Column("his_muh_aIiskmuhkod")]
    [StringLength(40)]
    public string? HisMuhAIiskmuhkod { get; set; }

    [Column("his_ilavemasmuhkod")]
    [StringLength(40)]
    public string? HisIlavemasmuhkod { get; set; }

    [Column("his_oivuygulama")]
    public byte? HisOivuygulama { get; set; }

    [Column("his_oivtutar")]
    public double? HisOivtutar { get; set; }

    [Column("his_oivturu")]
    public byte? HisOivturu { get; set; }

    [Column("his_ufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HisUfrsFarkMuhkod { get; set; }

    [Column("his_mal_yan_ufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HisMalYanUfrsFarkMuhkod { get; set; }

    [Column("his_gel_tablo_ufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HisGelTabloUfrsFarkMuhkod { get; set; }

    [Column("his_muh_sat_isk_ufrs_fark_kod")]
    [StringLength(40)]
    public string? HisMuhSatIskUfrsFarkKod { get; set; }

    [Column("his_muh_aIiskufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HisMuhAIiskufrsFarkMuhkod { get; set; }

    [Column("his_his_ilavemasufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HisHisIlavemasufrsFarkMuhkod { get; set; }

    [Column("his_birim_ad")]
    [StringLength(10)]
    public string? HisBirimAd { get; set; }

    [Column("his_bsbayadahil")]
    public byte? HisBsbayadahil { get; set; }

    [Column("his_vergifonid_1")]
    public short? HisVergifonid1 { get; set; }

    [Column("his_vergifonid_2")]
    public short? HisVergifonid2 { get; set; }

    [Column("his_vergifonid_3")]
    public short? HisVergifonid3 { get; set; }

    [Column("his_vergifonid_4")]
    public short? HisVergifonid4 { get; set; }

    [Column("his_vergifonid_5")]
    public short? HisVergifonid5 { get; set; }
}
