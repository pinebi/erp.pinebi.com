using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("shop_promosyon_tanimlari")]
public class ShopPromosyonTanimlari
{
    [Column("sp_Guid")]
    public Guid? SpGuid { get; set; }

    [Column("sp_DBCno")]
    public short? SpDBCno { get; set; }

    [Column("sp_SpecRECNo")]
    public int? SpSpecRECNo { get; set; }

    [Column("sp_iptal")]
    public bool? SpIptal { get; set; }

    [Column("sp_fileid")]
    public short? SpFileid { get; set; }

    [Column("sp_hidden")]
    public bool? SpHidden { get; set; }

    [Column("sp_kilitli")]
    public bool? SpKilitli { get; set; }

    [Column("sp_degisti")]
    public bool? SpDegisti { get; set; }

    [Column("sp_checksum")]
    public int? SpChecksum { get; set; }

    [Column("sp_create_user")]
    public short? SpCreateUser { get; set; }

    [Column("sp_create_date")]
    public DateTime? SpCreateDate { get; set; }

    [Column("sp_lastup_user")]
    public short? SpLastupUser { get; set; }

    [Column("sp_lastup_date")]
    public DateTime? SpLastupDate { get; set; }

    [Column("sp_special1")]
    [StringLength(4)]
    public string? SpSpecial1 { get; set; }

    [Column("sp_special2")]
    [StringLength(4)]
    public string? SpSpecial2 { get; set; }

    [Column("sp_special3")]
    [StringLength(4)]
    public string? SpSpecial3 { get; set; }

    [Column("sp_kodu")]
    [StringLength(25)]
    public string? SpKodu { get; set; }

    [Column("sp_ismi")]
    [StringLength(50)]
    public string? SpIsmi { get; set; }

    [Column("sp_promosyon_evraktipi")]
    public byte? SpPromosyonEvraktipi { get; set; }

    [Column("sp_pos_tipleri")]
    public byte? SpPosTipleri { get; set; }

    [Column("sp_aktif")]
    public bool? SpAktif { get; set; }

    [Column("sp_matrah_grubu")]
    public short? SpMatrahGrubu { get; set; }

    [Column("sp_matrah_grubu_SiraNo")]
    public short? SpMatrahGrubuSiraNo { get; set; }

    [Column("sp_baslangic_zamani")]
    public DateTime? SpBaslangicZamani { get; set; }

    [Column("sp_bitis_zamani")]
    public DateTime? SpBitisZamani { get; set; }

    [Column("sp_gun_ici_baslangic_saati")]
    public DateTime? SpGunIciBaslangicSaati { get; set; }

    [Column("sp_gun_ici_bitis_saati")]
    public DateTime? SpGunIciBitisSaati { get; set; }

    [Column("sp_uygulama_gunleri")]
    public byte? SpUygulamaGunleri { get; set; }

    [Column("sp_depo_kisit_tipi")]
    public byte? SpDepoKisitTipi { get; set; }

    [Column("sp_depo_listesi")]
    [StringLength(127)]
    public string? SpDepoListesi { get; set; }

    [Column("sp_uygulama_zorunlu")]
    public bool? SpUygulamaZorunlu { get; set; }

    [Column("sp_maksimum_iterasyon")]
    public int? SpMaksimumIterasyon { get; set; }

    [Column("sp_Musteri_kisitlari_PromoTip")]
    public int? SpMusteriKisitlariPromoTip { get; set; }

    [Column("sp_Musteri_kisitlari_Sorgu")]
    [StringLength(25)]
    public string? SpMusteriKisitlariSorgu { get; set; }

    [Column("sp_Musteri_kisitlari_StrData")]
    [StringLength(127)]
    public string? SpMusteriKisitlariStrData { get; set; }

    [Column("sp_Musteri_kisitlari_DblData")]
    public double? SpMusteriKisitlariDblData { get; set; }

    [Column("sp_Musteri_kisitlari_IntData")]
    public int? SpMusteriKisitlariIntData { get; set; }

    [Column("sp_Urun_kisitlari_PromoTip")]
    public int? SpUrunKisitlariPromoTip { get; set; }

    [Column("sp_Urun_Kosullar1_Tip")]
    public int? SpUrunKosullar1Tip { get; set; }

    [Column("sp_Urun_Kosullar1_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar1Sorgu { get; set; }

    [Column("sp_Urun_Kosullar1_Min")]
    public double? SpUrunKosullar1Min { get; set; }

    [Column("sp_Urun_Kosullar1_Max")]
    public double? SpUrunKosullar1Max { get; set; }

    [Column("sp_Urun_Kosullar1_Haric")]
    public double? SpUrunKosullar1Haric { get; set; }

    [Column("sp_Urun_Kosullar1_Group")]
    public double? SpUrunKosullar1Group { get; set; }

    [Column("sp_Urun_Kosullar1_Deger")]
    public double? SpUrunKosullar1Deger { get; set; }

    [Column("sp_Urun_Kosullar1_Yakin_Tip")]
    public int? SpUrunKosullar1YakinTip { get; set; }

    [Column("sp_Urun_Kosullar1_Yakin_Deger")]
    public double? SpUrunKosullar1YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar2_Tip")]
    public int? SpUrunKosullar2Tip { get; set; }

    [Column("sp_Urun_Kosullar2_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar2Sorgu { get; set; }

    [Column("sp_Urun_Kosullar2_Min")]
    public double? SpUrunKosullar2Min { get; set; }

    [Column("sp_Urun_Kosullar2_Max")]
    public double? SpUrunKosullar2Max { get; set; }

    [Column("sp_Urun_Kosullar2_Haric")]
    public double? SpUrunKosullar2Haric { get; set; }

    [Column("sp_Urun_Kosullar2_Group")]
    public double? SpUrunKosullar2Group { get; set; }

    [Column("sp_Urun_Kosullar2_Deger")]
    public double? SpUrunKosullar2Deger { get; set; }

    [Column("sp_Urun_Kosullar2_Yakin_Tip")]
    public int? SpUrunKosullar2YakinTip { get; set; }

    [Column("sp_Urun_Kosullar2_Yakin_Deger")]
    public double? SpUrunKosullar2YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar3_Tip")]
    public int? SpUrunKosullar3Tip { get; set; }

    [Column("sp_Urun_Kosullar3_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar3Sorgu { get; set; }

    [Column("sp_Urun_Kosullar3_Min")]
    public double? SpUrunKosullar3Min { get; set; }

    [Column("sp_Urun_Kosullar3_Max")]
    public double? SpUrunKosullar3Max { get; set; }

    [Column("sp_Urun_Kosullar3_Haric")]
    public double? SpUrunKosullar3Haric { get; set; }

    [Column("sp_Urun_Kosullar3_Group")]
    public double? SpUrunKosullar3Group { get; set; }

    [Column("sp_Urun_Kosullar3_Deger")]
    public double? SpUrunKosullar3Deger { get; set; }

    [Column("sp_Urun_Kosullar3_Yakin_Tip")]
    public int? SpUrunKosullar3YakinTip { get; set; }

    [Column("sp_Urun_Kosullar3_Yakin_Deger")]
    public double? SpUrunKosullar3YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar4_Tip")]
    public int? SpUrunKosullar4Tip { get; set; }

    [Column("sp_Urun_Kosullar4_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar4Sorgu { get; set; }

    [Column("sp_Urun_Kosullar4_Min")]
    public double? SpUrunKosullar4Min { get; set; }

    [Column("sp_Urun_Kosullar4_Max")]
    public double? SpUrunKosullar4Max { get; set; }

    [Column("sp_Urun_Kosullar4_Haric")]
    public double? SpUrunKosullar4Haric { get; set; }

    [Column("sp_Urun_Kosullar4_Group")]
    public double? SpUrunKosullar4Group { get; set; }

    [Column("sp_Urun_Kosullar4_Deger")]
    public double? SpUrunKosullar4Deger { get; set; }

    [Column("sp_Urun_Kosullar4_Yakin_Tip")]
    public int? SpUrunKosullar4YakinTip { get; set; }

    [Column("sp_Urun_Kosullar4_Yakin_Deger")]
    public double? SpUrunKosullar4YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar5_Tip")]
    public int? SpUrunKosullar5Tip { get; set; }

    [Column("sp_Urun_Kosullar5_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar5Sorgu { get; set; }

    [Column("sp_Urun_Kosullar5_Min")]
    public double? SpUrunKosullar5Min { get; set; }

    [Column("sp_Urun_Kosullar5_Max")]
    public double? SpUrunKosullar5Max { get; set; }

    [Column("sp_Urun_Kosullar5_Haric")]
    public double? SpUrunKosullar5Haric { get; set; }

    [Column("sp_Urun_Kosullar5_Group")]
    public double? SpUrunKosullar5Group { get; set; }

    [Column("sp_Urun_Kosullar5_Deger")]
    public double? SpUrunKosullar5Deger { get; set; }

    [Column("sp_Urun_Kosullar5_Yakin_Tip")]
    public int? SpUrunKosullar5YakinTip { get; set; }

    [Column("sp_Urun_Kosullar5_Yakin_Deger")]
    public double? SpUrunKosullar5YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar6_Tip")]
    public int? SpUrunKosullar6Tip { get; set; }

    [Column("sp_Urun_Kosullar6_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar6Sorgu { get; set; }

    [Column("sp_Urun_Kosullar6_Min")]
    public double? SpUrunKosullar6Min { get; set; }

    [Column("sp_Urun_Kosullar6_Max")]
    public double? SpUrunKosullar6Max { get; set; }

    [Column("sp_Urun_Kosullar6_Haric")]
    public double? SpUrunKosullar6Haric { get; set; }

    [Column("sp_Urun_Kosullar6_Group")]
    public double? SpUrunKosullar6Group { get; set; }

    [Column("sp_Urun_Kosullar6_Deger")]
    public double? SpUrunKosullar6Deger { get; set; }

    [Column("sp_Urun_Kosullar6_Yakin_Tip")]
    public int? SpUrunKosullar6YakinTip { get; set; }

    [Column("sp_Urun_Kosullar6_Yakin_Deger")]
    public double? SpUrunKosullar6YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar7_Tip")]
    public int? SpUrunKosullar7Tip { get; set; }

    [Column("sp_Urun_Kosullar7_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar7Sorgu { get; set; }

    [Column("sp_Urun_Kosullar7_Min")]
    public double? SpUrunKosullar7Min { get; set; }

    [Column("sp_Urun_Kosullar7_Max")]
    public double? SpUrunKosullar7Max { get; set; }

    [Column("sp_Urun_Kosullar7_Haric")]
    public double? SpUrunKosullar7Haric { get; set; }

    [Column("sp_Urun_Kosullar7_Group")]
    public double? SpUrunKosullar7Group { get; set; }

    [Column("sp_Urun_Kosullar7_Deger")]
    public double? SpUrunKosullar7Deger { get; set; }

    [Column("sp_Urun_Kosullar7_Yakin_Tip")]
    public int? SpUrunKosullar7YakinTip { get; set; }

    [Column("sp_Urun_Kosullar7_Yakin_Deger")]
    public double? SpUrunKosullar7YakinDeger { get; set; }

    [Column("sp_Urun_Kosullar8_Tip")]
    public int? SpUrunKosullar8Tip { get; set; }

    [Column("sp_Urun_Kosullar8_Sorgu")]
    [StringLength(127)]
    public string? SpUrunKosullar8Sorgu { get; set; }

    [Column("sp_Urun_Kosullar8_Min")]
    public double? SpUrunKosullar8Min { get; set; }

    [Column("sp_Urun_Kosullar8_Max")]
    public double? SpUrunKosullar8Max { get; set; }

    [Column("sp_Urun_Kosullar8_Haric")]
    public double? SpUrunKosullar8Haric { get; set; }

    [Column("sp_Urun_Kosullar8_Group")]
    public double? SpUrunKosullar8Group { get; set; }

    [Column("sp_Urun_Kosullar8_Deger")]
    public double? SpUrunKosullar8Deger { get; set; }

    [Column("sp_Urun_Kosullar8_Yakin_Tip")]
    public int? SpUrunKosullar8YakinTip { get; set; }

    [Column("sp_Urun_Kosullar8_Yakin_Deger")]
    public double? SpUrunKosullar8YakinDeger { get; set; }

    [Column("sp_StdUygulama_Kodu")]
    public int? SpStdUygulamaKodu { get; set; }

    [Column("sp_StdUygulama_Urunler")]
    [StringLength(25)]
    public string? SpStdUygulamaUrunler { get; set; }

    [Column("sp_StdUygulama_MiktarDbl")]
    public double? SpStdUygulamaMiktarDbl { get; set; }

    [Column("sp_StdUygulama_DegerDbl")]
    public double? SpStdUygulamaDegerDbl { get; set; }

    [Column("sp_StdUygulama_OzelDurum")]
    public byte? SpStdUygulamaOzelDurum { get; set; }

    [Column("sp_StdUygulama_iskonto_dagitim_sekli")]
    public byte? SpStdUygulamaIskontoDagitimSekli { get; set; }

    [Column("sp_StdUygulama_iskonto_index")]
    public byte? SpStdUygulamaIskontoIndex { get; set; }

    [Column("sp_StdUygulama_yuvarlama_tipi")]
    public byte? SpStdUygulamaYuvarlamaTipi { get; set; }

    [Column("sp_StdUygulama_yuvarlama_miktar")]
    public double? SpStdUygulamaYuvarlamaMiktar { get; set; }

    [Column("sp_StdUygulama_eksikse_mesaj")]
    [StringLength(127)]
    public string? SpStdUygulamaEksikseMesaj { get; set; }

    [Column("sp_StdUygulama_kasa_mesaji")]
    [StringLength(127)]
    public string? SpStdUygulamaKasaMesaji { get; set; }

    [Column("sp_StdUygulama_ekbilgi")]
    [StringLength(127)]
    public string? SpStdUygulamaEkbilgi { get; set; }

    [Column("sp_Kazanma_Kriteri")]
    [StringLength(127)]
    public string? SpKazanmaKriteri { get; set; }

    [Column("sp_Uygulama_Sekli")]
    [StringLength(127)]
    public string? SpUygulamaSekli { get; set; }

    [Column("sp_KazanmayaYakin_Kriteri")]
    [StringLength(127)]
    public string? SpKazanmayaYakinKriteri { get; set; }
}
