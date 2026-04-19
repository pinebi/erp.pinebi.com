using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_hareketleri_ek")]
public class CariHesapHareketleriEk
{
    [Column("chaek_Guid")]
    public Guid? ChaekGuid { get; set; }

    [Column("chaek_DBCno")]
    public short? ChaekDBCno { get; set; }

    [Column("chaek_SpecRecNo")]
    public int? ChaekSpecRecNo { get; set; }

    [Column("chaek_iptal")]
    public bool? ChaekIptal { get; set; }

    [Column("chaek_fileid")]
    public short? ChaekFileid { get; set; }

    [Column("chaek_hidden")]
    public bool? ChaekHidden { get; set; }

    [Column("chaek_kilitli")]
    public bool? ChaekKilitli { get; set; }

    [Column("chaek_degisti")]
    public bool? ChaekDegisti { get; set; }

    [Column("chaek_checksum")]
    public int? ChaekChecksum { get; set; }

    [Column("chaek_create_user")]
    public short? ChaekCreateUser { get; set; }

    [Column("chaek_create_date")]
    public DateTime? ChaekCreateDate { get; set; }

    [Column("chaek_lastup_user")]
    public short? ChaekLastupUser { get; set; }

    [Column("chaek_lastup_date")]
    public DateTime? ChaekLastupDate { get; set; }

    [Column("chaek_special1")]
    [StringLength(4)]
    public string? ChaekSpecial1 { get; set; }

    [Column("chaek_special2")]
    [StringLength(4)]
    public string? ChaekSpecial2 { get; set; }

    [Column("chaek_special3")]
    [StringLength(4)]
    public string? ChaekSpecial3 { get; set; }

    [Column("chaek_related_uid")]
    public Guid? ChaekRelatedUid { get; set; }

    [Column("cha_mustahsil_borsa")]
    public double? ChaMustahsilBorsa { get; set; }

    [Column("cha_mustahsil_bagkur")]
    public double? ChaMustahsilBagkur { get; set; }

    [Column("cha_mustahsil_diger")]
    public double? ChaMustahsilDiger { get; set; }

    [Column("cha_HalMSDF")]
    public double? ChaHalMSDF { get; set; }

    [Column("cha_HalHamaliye")]
    public double? ChaHalHamaliye { get; set; }

    [Column("cha_HalStopaj")]
    public double? ChaHalStopaj { get; set; }

    [Column("cha_HalKomisyonu")]
    public double? ChaHalKomisyonu { get; set; }

    [Column("cha_HalRusum")]
    public double? ChaHalRusum { get; set; }

    [Column("cha_HalNavlunTut")]
    public double? ChaHalNavlunTut { get; set; }

    [Column("cha_HalRehinFuture")]
    public double? ChaHalRehinFuture { get; set; }

    [Column("cha_HalKomisyon")]
    public double? ChaHalKomisyon { get; set; }

    [Column("cha_HalRehinSandikmiktari")]
    public double? ChaHalRehinSandikmiktari { get; set; }

    [Column("cha_HalSandikVrMiktar")]
    public double? ChaHalSandikVrMiktar { get; set; }

    [Column("cha_HalSandikTutari")]
    public double? ChaHalSandikTutari { get; set; }

    [Column("cha_HalSandikKDVTutari")]
    public double? ChaHalSandikKDVTutari { get; set; }

    [Column("cha_HalrehinSandikTutari")]
    public double? ChaHalrehinSandikTutari { get; set; }

    [Column("cha_HalHamaliyeKdv")]
    public double? ChaHalHamaliyeKdv { get; set; }

    [Column("cha_HalHamaliyeVergisiz_fl")]
    public bool? ChaHalHamaliyeVergisizFl { get; set; }

    [Column("cha_HalRusumKdv")]
    public double? ChaHalRusumKdv { get; set; }

    [Column("cha_HalDiger")]
    public double? ChaHalDiger { get; set; }

    [Column("cha_HalDigerKdv")]
    public double? ChaHalDigerKdv { get; set; }

    [Column("cha_HalDigerVergisiz_fl")]
    public bool? ChaHalDigerVergisizFl { get; set; }

    [Column("cha_HalrusumVergisiz_fl")]
    public bool? ChaHalrusumVergisizFl { get; set; }

    [Column("cha_Halrusumsuz_fl")]
    public bool? ChaHalrusumsuzFl { get; set; }

    [Column("cha_sozlesme_uid")]
    public Guid? ChaSozlesmeUid { get; set; }

    [Column("cha_ciroprim_uid")]
    public Guid? ChaCiroprimUid { get; set; }

    [Column("cha_bakimhar_uid")]
    public Guid? ChaBakimharUid { get; set; }

    [Column("cha_avanstalep_uid")]
    public Guid? ChaAvanstalepUid { get; set; }

    [Column("cha_gidkatsoz_uid")]
    public Guid? ChaGidkatsozUid { get; set; }

    [Column("cha_Tevkifat_turu")]
    public byte? ChaTevkifatTuru { get; set; }

    [Column("cha_tevkifat1Yok")]
    public double? ChaTevkifat1Yok { get; set; }

    [Column("cha_tevkifat131")]
    public double? ChaTevkifat131 { get; set; }

    [Column("cha_tevkifat191")]
    public double? ChaTevkifat191 { get; set; }

    [Column("cha_tevkifat121")]
    public double? ChaTevkifat121 { get; set; }

    [Column("cha_tevkifat132")]
    public double? ChaTevkifat132 { get; set; }

    [Column("cha_tevkifat161")]
    public double? ChaTevkifat161 { get; set; }

    [Column("cha_tevkifat145")]
    public double? ChaTevkifat145 { get; set; }

    [Column("cha_tevkifat1Tam")]
    public double? ChaTevkifat1Tam { get; set; }

    [Column("cha_tevkifat1102")]
    public double? ChaTevkifat1102 { get; set; }

    [Column("cha_tevkifat1105")]
    public double? ChaTevkifat1105 { get; set; }

    [Column("cha_tevkifat1107")]
    public double? ChaTevkifat1107 { get; set; }

    [Column("cha_tevkifat2Yok")]
    public double? ChaTevkifat2Yok { get; set; }

    [Column("cha_tevkifat231")]
    public double? ChaTevkifat231 { get; set; }

    [Column("cha_tevkifat291")]
    public double? ChaTevkifat291 { get; set; }

    [Column("cha_tevkifat221")]
    public double? ChaTevkifat221 { get; set; }

    [Column("cha_tevkifat232")]
    public double? ChaTevkifat232 { get; set; }

    [Column("cha_tevkifat261")]
    public double? ChaTevkifat261 { get; set; }

    [Column("cha_tevkifat245")]
    public double? ChaTevkifat245 { get; set; }

    [Column("cha_tevkifat2Tam")]
    public double? ChaTevkifat2Tam { get; set; }

    [Column("cha_tevkifat2102")]
    public double? ChaTevkifat2102 { get; set; }

    [Column("cha_tevkifat2105")]
    public double? ChaTevkifat2105 { get; set; }

    [Column("cha_tevkifat2107")]
    public double? ChaTevkifat2107 { get; set; }

    [Column("cha_tevkifat3Yok")]
    public double? ChaTevkifat3Yok { get; set; }

    [Column("cha_tevkifat331")]
    public double? ChaTevkifat331 { get; set; }

    [Column("cha_tevkifat391")]
    public double? ChaTevkifat391 { get; set; }

    [Column("cha_tevkifat321")]
    public double? ChaTevkifat321 { get; set; }

    [Column("cha_tevkifat332")]
    public double? ChaTevkifat332 { get; set; }

    [Column("cha_tevkifat361")]
    public double? ChaTevkifat361 { get; set; }

    [Column("cha_tevkifat345")]
    public double? ChaTevkifat345 { get; set; }

    [Column("cha_tevkifat3Tam")]
    public double? ChaTevkifat3Tam { get; set; }

    [Column("cha_tevkifat3102")]
    public double? ChaTevkifat3102 { get; set; }

    [Column("cha_tevkifat3105")]
    public double? ChaTevkifat3105 { get; set; }

    [Column("cha_tevkifat3107")]
    public double? ChaTevkifat3107 { get; set; }

    [Column("cha_tevkifat4Yok")]
    public double? ChaTevkifat4Yok { get; set; }

    [Column("cha_tevkifat431")]
    public double? ChaTevkifat431 { get; set; }

    [Column("cha_tevkifat491")]
    public double? ChaTevkifat491 { get; set; }

    [Column("cha_tevkifat421")]
    public double? ChaTevkifat421 { get; set; }

    [Column("cha_tevkifat432")]
    public double? ChaTevkifat432 { get; set; }

    [Column("cha_tevkifat461")]
    public double? ChaTevkifat461 { get; set; }

    [Column("cha_tevkifat445")]
    public double? ChaTevkifat445 { get; set; }

    [Column("cha_tevkifat4Tam")]
    public double? ChaTevkifat4Tam { get; set; }

    [Column("cha_tevkifat4102")]
    public double? ChaTevkifat4102 { get; set; }

    [Column("cha_tevkifat4105")]
    public double? ChaTevkifat4105 { get; set; }

    [Column("cha_tevkifat4107")]
    public double? ChaTevkifat4107 { get; set; }

    [Column("cha_tevkifat5Yok")]
    public double? ChaTevkifat5Yok { get; set; }

    [Column("cha_tevkifat531")]
    public double? ChaTevkifat531 { get; set; }

    [Column("cha_tevkifat591")]
    public double? ChaTevkifat591 { get; set; }

    [Column("cha_tevkifat521")]
    public double? ChaTevkifat521 { get; set; }

    [Column("cha_tevkifat532")]
    public double? ChaTevkifat532 { get; set; }

    [Column("cha_tevkifat561")]
    public double? ChaTevkifat561 { get; set; }

    [Column("cha_tevkifat545")]
    public double? ChaTevkifat545 { get; set; }

    [Column("cha_tevkifat5Tam")]
    public double? ChaTevkifat5Tam { get; set; }

    [Column("cha_tevkifat5102")]
    public double? ChaTevkifat5102 { get; set; }

    [Column("cha_tevkifat5105")]
    public double? ChaTevkifat5105 { get; set; }

    [Column("cha_tevkifat5107")]
    public double? ChaTevkifat5107 { get; set; }

    [Column("cha_tevkifat6Yok")]
    public double? ChaTevkifat6Yok { get; set; }

    [Column("cha_tevkifat631")]
    public double? ChaTevkifat631 { get; set; }

    [Column("cha_tevkifat691")]
    public double? ChaTevkifat691 { get; set; }

    [Column("cha_tevkifat621")]
    public double? ChaTevkifat621 { get; set; }

    [Column("cha_tevkifat632")]
    public double? ChaTevkifat632 { get; set; }

    [Column("cha_tevkifat661")]
    public double? ChaTevkifat661 { get; set; }

    [Column("cha_tevkifat645")]
    public double? ChaTevkifat645 { get; set; }

    [Column("cha_tevkifat6Tam")]
    public double? ChaTevkifat6Tam { get; set; }

    [Column("cha_tevkifat6102")]
    public double? ChaTevkifat6102 { get; set; }

    [Column("cha_tevkifat6105")]
    public double? ChaTevkifat6105 { get; set; }

    [Column("cha_tevkifat6107")]
    public double? ChaTevkifat6107 { get; set; }

    [Column("cha_tevkifat7Yok")]
    public double? ChaTevkifat7Yok { get; set; }

    [Column("cha_tevkifat731")]
    public double? ChaTevkifat731 { get; set; }

    [Column("cha_tevkifat791")]
    public double? ChaTevkifat791 { get; set; }

    [Column("cha_tevkifat721")]
    public double? ChaTevkifat721 { get; set; }

    [Column("cha_tevkifat732")]
    public double? ChaTevkifat732 { get; set; }

    [Column("cha_tevkifat761")]
    public double? ChaTevkifat761 { get; set; }

    [Column("cha_tevkifat745")]
    public double? ChaTevkifat745 { get; set; }

    [Column("cha_tevkifat7Tam")]
    public double? ChaTevkifat7Tam { get; set; }

    [Column("cha_tevkifat7102")]
    public double? ChaTevkifat7102 { get; set; }

    [Column("cha_tevkifat7105")]
    public double? ChaTevkifat7105 { get; set; }

    [Column("cha_tevkifat7107")]
    public double? ChaTevkifat7107 { get; set; }

    [Column("cha_tevkifat8Yok")]
    public double? ChaTevkifat8Yok { get; set; }

    [Column("cha_tevkifat831")]
    public double? ChaTevkifat831 { get; set; }

    [Column("cha_tevkifat891")]
    public double? ChaTevkifat891 { get; set; }

    [Column("cha_tevkifat821")]
    public double? ChaTevkifat821 { get; set; }

    [Column("cha_tevkifat832")]
    public double? ChaTevkifat832 { get; set; }

    [Column("cha_tevkifat861")]
    public double? ChaTevkifat861 { get; set; }

    [Column("cha_tevkifat845")]
    public double? ChaTevkifat845 { get; set; }

    [Column("cha_tevkifat8Tam")]
    public double? ChaTevkifat8Tam { get; set; }

    [Column("cha_tevkifat8102")]
    public double? ChaTevkifat8102 { get; set; }

    [Column("cha_tevkifat8105")]
    public double? ChaTevkifat8105 { get; set; }

    [Column("cha_tevkifat8107")]
    public double? ChaTevkifat8107 { get; set; }

    [Column("cha_tevkifat9Yok")]
    public double? ChaTevkifat9Yok { get; set; }

    [Column("cha_tevkifat931")]
    public double? ChaTevkifat931 { get; set; }

    [Column("cha_tevkifat991")]
    public double? ChaTevkifat991 { get; set; }

    [Column("cha_tevkifat921")]
    public double? ChaTevkifat921 { get; set; }

    [Column("cha_tevkifat932")]
    public double? ChaTevkifat932 { get; set; }

    [Column("cha_tevkifat961")]
    public double? ChaTevkifat961 { get; set; }

    [Column("cha_tevkifat945")]
    public double? ChaTevkifat945 { get; set; }

    [Column("cha_tevkifat9Tam")]
    public double? ChaTevkifat9Tam { get; set; }

    [Column("cha_tevkifat9102")]
    public double? ChaTevkifat9102 { get; set; }

    [Column("cha_tevkifat9105")]
    public double? ChaTevkifat9105 { get; set; }

    [Column("cha_tevkifat9107")]
    public double? ChaTevkifat9107 { get; set; }

    [Column("cha_tevkifat10Yok")]
    public double? ChaTevkifat10Yok { get; set; }

    [Column("cha_tevkifat1031")]
    public double? ChaTevkifat1031 { get; set; }

    [Column("cha_tevkifat1091")]
    public double? ChaTevkifat1091 { get; set; }

    [Column("cha_tevkifat1021")]
    public double? ChaTevkifat1021 { get; set; }

    [Column("cha_tevkifat1032")]
    public double? ChaTevkifat1032 { get; set; }

    [Column("cha_tevkifat1061")]
    public double? ChaTevkifat1061 { get; set; }

    [Column("cha_tevkifat1045")]
    public double? ChaTevkifat1045 { get; set; }

    [Column("cha_tevkifat10Tam")]
    public double? ChaTevkifat10Tam { get; set; }

    [Column("cha_tevkifat10102")]
    public double? ChaTevkifat10102 { get; set; }

    [Column("cha_tevkifat10105")]
    public double? ChaTevkifat10105 { get; set; }

    [Column("cha_tevkifat10107")]
    public double? ChaTevkifat10107 { get; set; }

    [Column("cha_istisna1")]
    [StringLength(5)]
    public string? ChaIstisna1 { get; set; }

    [Column("cha_istisna2")]
    [StringLength(5)]
    public string? ChaIstisna2 { get; set; }

    [Column("cha_istisna3")]
    [StringLength(5)]
    public string? ChaIstisna3 { get; set; }

    [Column("cha_istisna4")]
    [StringLength(5)]
    public string? ChaIstisna4 { get; set; }

    [Column("cha_istisna5")]
    [StringLength(5)]
    public string? ChaIstisna5 { get; set; }

    [Column("cha_istisna6")]
    [StringLength(5)]
    public string? ChaIstisna6 { get; set; }

    [Column("cha_istisna7")]
    [StringLength(5)]
    public string? ChaIstisna7 { get; set; }

    [Column("cha_istisna8")]
    [StringLength(5)]
    public string? ChaIstisna8 { get; set; }

    [Column("cha_istisna9")]
    [StringLength(5)]
    public string? ChaIstisna9 { get; set; }

    [Column("cha_istisna10")]
    [StringLength(5)]
    public string? ChaIstisna10 { get; set; }

    [Column("cha_otv_tevkifat_turu")]
    public byte? ChaOtvTevkifatTuru { get; set; }

    [Column("cha_otv_tevkifat_tam")]
    public double? ChaOtvTevkifatTam { get; set; }

    [Column("cha_servishar_uid")]
    public Guid? ChaServisharUid { get; set; }

    [Column("cha_ozel_matrah_kodu")]
    [StringLength(5)]
    public string? ChaOzelMatrahKodu { get; set; }

    [Column("cha_periyodik_uid")]
    public Guid? ChaPeriyodikUid { get; set; }

    [Column("cha_periyodik_donem_no")]
    public int? ChaPeriyodikDonemNo { get; set; }

    [Column("cha_vergifonid_1")]
    public short? ChaVergifonid1 { get; set; }

    [Column("cha_vergifontutari_1")]
    public double? ChaVergifontutari1 { get; set; }

    [Column("cha_vergifonid_2")]
    public short? ChaVergifonid2 { get; set; }

    [Column("cha_vergifontutari_2")]
    public double? ChaVergifontutari2 { get; set; }

    [Column("cha_vergifonid_3")]
    public short? ChaVergifonid3 { get; set; }

    [Column("cha_vergifontutari_3")]
    public double? ChaVergifontutari3 { get; set; }

    [Column("cha_vergifonid_4")]
    public short? ChaVergifonid4 { get; set; }

    [Column("cha_vergifontutari_4")]
    public double? ChaVergifontutari4 { get; set; }

    [Column("cha_vergifonid_5")]
    public short? ChaVergifonid5 { get; set; }

    [Column("cha_vergifontutari_5")]
    public double? ChaVergifontutari5 { get; set; }

    [Column("cha_yolcuberaber_kodu")]
    [StringLength(25)]
    public string? ChaYolcuberaberKodu { get; set; }

    [Column("cha_yetkiliaracikurumkodu")]
    [StringLength(25)]
    public string? ChaYetkiliaracikurumkodu { get; set; }

    [Column("cha_icraodeme_uid")]
    public Guid? ChaIcraodemeUid { get; set; }
}
