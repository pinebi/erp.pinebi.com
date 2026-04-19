using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_hesaplari")]
public class HizmetHesaplari
{
    [Column("hiz_Guid")]
    public Guid? HizGuid { get; set; }

    [Column("hiz_DBCno")]
    public short? HizDBCno { get; set; }

    [Column("hiz_SpecRecno")]
    public int? HizSpecRecno { get; set; }

    [Column("hiz_iptal")]
    public bool? HizIptal { get; set; }

    [Column("hiz_fileid")]
    public short? HizFileid { get; set; }

    [Column("hiz_hidden")]
    public bool? HizHidden { get; set; }

    [Column("hiz_kilitli")]
    public bool? HizKilitli { get; set; }

    [Column("hiz_degisti")]
    public bool? HizDegisti { get; set; }

    [Column("hiz_checksum")]
    public int? HizChecksum { get; set; }

    [Column("hiz_create_user")]
    public short? HizCreateUser { get; set; }

    [Column("hiz_create_date")]
    public DateTime? HizCreateDate { get; set; }

    [Column("hiz_lastup_user")]
    public short? HizLastupUser { get; set; }

    [Column("hiz_lastup_date")]
    public DateTime? HizLastupDate { get; set; }

    [Column("hiz_special1")]
    [StringLength(4)]
    public string? HizSpecial1 { get; set; }

    [Column("hiz_special2")]
    [StringLength(4)]
    public string? HizSpecial2 { get; set; }

    [Column("hiz_special3")]
    [StringLength(4)]
    public string? HizSpecial3 { get; set; }

    [Column("hiz_tip")]
    public byte? HizTip { get; set; }

    [Column("hiz_kod")]
    [StringLength(25)]
    public string? HizKod { get; set; }

    [Column("hiz_isim")]
    [StringLength(40)]
    public string? HizIsim { get; set; }

    [Column("hiz_yabanci_isim")]
    [StringLength(50)]
    public string? HizYabanciIsim { get; set; }

    [Column("hiz_tipkod")]
    [StringLength(25)]
    public string? HizTipkod { get; set; }

    [Column("hiz_sinifkod")]
    [StringLength(25)]
    public string? HizSinifkod { get; set; }

    [Column("hiz_grupkod")]
    [StringLength(25)]
    public string? HizGrupkod { get; set; }

    [Column("hiz_sat_muh_kod")]
    [StringLength(40)]
    public string? HizSatMuhKod { get; set; }

    [Column("hiz_sat_iade_muh_kod")]
    [StringLength(40)]
    public string? HizSatIadeMuhKod { get; set; }

    [Column("hiz_mal_muh_kod")]
    [StringLength(40)]
    public string? HizMalMuhKod { get; set; }

    [Column("hiz_sat_mal_muh_kod")]
    [StringLength(40)]
    public string? HizSatMalMuhKod { get; set; }

    [Column("hiz_mal_yan_muh_kod")]
    [StringLength(40)]
    public string? HizMalYanMuhKod { get; set; }

    [Column("hiz_fiyat")]
    public double? HizFiyat { get; set; }

    [Column("hiz_doviz_cinsi")]
    public byte? HizDovizCinsi { get; set; }

    [Column("hiz_isk_grup")]
    [StringLength(4)]
    public string? HizIskGrup { get; set; }

    [Column("hiz_KDV")]
    public byte? HizKDV { get; set; }

    [Column("hiz_muh_sat_isk_kod")]
    [StringLength(40)]
    public string? HizMuhSatIskKod { get; set; }

    [Column("hiz_muh_aIiskmuhkod")]
    [StringLength(40)]
    public string? HizMuhAIiskmuhkod { get; set; }

    [Column("hiz_ilavemasmuhkod")]
    [StringLength(40)]
    public string? HizIlavemasmuhkod { get; set; }

    [Column("hiz_operasyon_suresi")]
    public int? HizOperasyonSuresi { get; set; }

    [Column("hiz_oivuygulama")]
    public byte? HizOivuygulama { get; set; }

    [Column("hiz_oivtutar")]
    public double? HizOivtutar { get; set; }

    [Column("hiz_oivturu")]
    public byte? HizOivturu { get; set; }

    [Column("hiz_sat_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? HizSatUfrsFarkMuhKod { get; set; }

    [Column("hiz_sat_iade_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? HizSatIadeUfrsFarkMuhKod { get; set; }

    [Column("hiz_mal_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? HizMalUfrsFarkMuhKod { get; set; }

    [Column("hiz_sat_mal_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? HizSatMalUfrsFarkMuhKod { get; set; }

    [Column("hiz_mal_yan_ufrs_fark_muh_kod")]
    [StringLength(40)]
    public string? HizMalYanUfrsFarkMuhKod { get; set; }

    [Column("hiz_muh_sat_ufrs_fark_isk_kod")]
    [StringLength(40)]
    public string? HizMuhSatUfrsFarkIskKod { get; set; }

    [Column("hiz_muh_aIiskufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HizMuhAIiskufrsFarkMuhkod { get; set; }

    [Column("hiz_ilavemasufrs_fark_muhkod")]
    [StringLength(40)]
    public string? HizIlavemasufrsFarkMuhkod { get; set; }

    [Column("hiz_birim_ad")]
    [StringLength(10)]
    public string? HizBirimAd { get; set; }

    [Column("hiz_bsbayadahil")]
    public byte? HizBsbayadahil { get; set; }

    [Column("hiz_vergifonid_1")]
    public short? HizVergifonid1 { get; set; }

    [Column("hiz_vergifonid_2")]
    public short? HizVergifonid2 { get; set; }

    [Column("hiz_vergifonid_3")]
    public short? HizVergifonid3 { get; set; }

    [Column("hiz_vergifonid_4")]
    public short? HizVergifonid4 { get; set; }

    [Column("hiz_vergifonid_5")]
    public short? HizVergifonid5 { get; set; }
}
