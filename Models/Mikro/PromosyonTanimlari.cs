using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("promosyon_tanimlari")]
public class PromosyonTanimlari
{
    [Column("Promo_Guid")]
    public Guid? PromoGuid { get; set; }

    [Column("Promo_DBCno")]
    public short? PromoDBCno { get; set; }

    [Column("Promo_SpecRECNo")]
    public int? PromoSpecRECNo { get; set; }

    [Column("Promo_iptal")]
    public bool? PromoIptal { get; set; }

    [Column("Promo_fileid")]
    public short? PromoFileid { get; set; }

    [Column("Promo_hidden")]
    public bool? PromoHidden { get; set; }

    [Column("Promo_kilitli")]
    public bool? PromoKilitli { get; set; }

    [Column("Promo_degisti")]
    public bool? PromoDegisti { get; set; }

    [Column("Promo_checksum")]
    public int? PromoChecksum { get; set; }

    [Column("Promo_create_user")]
    public short? PromoCreateUser { get; set; }

    [Column("Promo_create_date")]
    public DateTime? PromoCreateDate { get; set; }

    [Column("Promo_lastup_user")]
    public short? PromoLastupUser { get; set; }

    [Column("Promo_lastup_date")]
    public DateTime? PromoLastupDate { get; set; }

    [Column("Promo_special1")]
    [StringLength(50)]
    public string? PromoSpecial1 { get; set; }

    [Column("Promo_special2")]
    [StringLength(50)]
    public string? PromoSpecial2 { get; set; }

    [Column("Promo_special3")]
    [StringLength(50)]
    public string? PromoSpecial3 { get; set; }

    [Column("Promo_kodu")]
    [StringLength(50)]
    public string? PromoKodu { get; set; }

    [Column("Promo_ismi")]
    [StringLength(50)]
    public string? PromoIsmi { get; set; }

    [Column("Promo_SiraNo")]
    public int? PromoSiraNo { get; set; }

    [Column("Promo_stok_kriter_tipi")]
    public byte? PromoStokKriterTipi { get; set; }

    [Column("Promo_stok_kriter_yapisi")]
    [StringLength(25)]
    public string? PromoStokKriterYapisi { get; set; }

    [Column("Promo_stok_sorgu_cumlesi")]
    [StringLength(125)]
    public string? PromoStokSorguCumlesi { get; set; }

    [Column("Promo_matris_stok_kriteri1")]
    [StringLength(25)]
    public string? PromoMatrisStokKriteri1 { get; set; }

    [Column("Promo_matris_stok_miktari1")]
    public double? PromoMatrisStokMiktari1 { get; set; }

    [Column("Promo_matris_stok_kriteri2")]
    [StringLength(25)]
    public string? PromoMatrisStokKriteri2 { get; set; }

    [Column("Promo_matris_stok_miktari2")]
    public double? PromoMatrisStokMiktari2 { get; set; }

    [Column("Promo_matris_stok_kriteri3")]
    [StringLength(25)]
    public string? PromoMatrisStokKriteri3 { get; set; }

    [Column("Promo_matris_stok_miktari3")]
    public double? PromoMatrisStokMiktari3 { get; set; }

    [Column("Promo_matris_stok_kriteri4")]
    [StringLength(25)]
    public string? PromoMatrisStokKriteri4 { get; set; }

    [Column("Promo_matris_stok_miktari4")]
    public double? PromoMatrisStokMiktari4 { get; set; }

    [Column("Promo_matris_stok_kriteri5")]
    [StringLength(25)]
    public string? PromoMatrisStokKriteri5 { get; set; }

    [Column("Promo_matris_stok_miktari5")]
    public double? PromoMatrisStokMiktari5 { get; set; }

    [Column("Promo_musteri_kod_yapisi")]
    [StringLength(25)]
    public string? PromoMusteriKodYapisi { get; set; }

    [Column("Promo_stok_promosyon_tipi")]
    public byte? PromoStokPromosyonTipi { get; set; }

    [Column("Promo_belge_promosyon_tipi")]
    public byte? PromoBelgePromosyonTipi { get; set; }

    [Column("Promo_zaman_promosyon_tipi")]
    public byte? PromoZamanPromosyonTipi { get; set; }

    [Column("Promo_capraz_promosyon_tipi")]
    public byte? PromoCaprazPromosyonTipi { get; set; }

    [Column("Promo_D1")]
    public double? PromoD1 { get; set; }

    [Column("Promo_D2")]
    public double? PromoD2 { get; set; }

    [Column("Promo_D3")]
    public double? PromoD3 { get; set; }

    [Column("Promo_D4")]
    public double? PromoD4 { get; set; }

    [Column("Promo_hediye_kodu")]
    [StringLength(25)]
    public string? PromoHediyeKodu { get; set; }

    [Column("Promo_hediye_D1")]
    public double? PromoHediyeD1 { get; set; }

    [Column("Promo_hediye_D2")]
    public double? PromoHediyeD2 { get; set; }

    [Column("Promo_baslangic_gunu")]
    public DateTime? PromoBaslangicGunu { get; set; }

    [Column("Promo_bitis_gunu")]
    public DateTime? PromoBitisGunu { get; set; }

    [Column("Promo_uygulama_gunleri1")]
    public bool? PromoUygulamaGunleri1 { get; set; }

    [Column("Promo_uygulama_gunleri2")]
    public bool? PromoUygulamaGunleri2 { get; set; }

    [Column("Promo_uygulama_gunleri3")]
    public bool? PromoUygulamaGunleri3 { get; set; }

    [Column("Promo_uygulama_gunleri4")]
    public bool? PromoUygulamaGunleri4 { get; set; }

    [Column("Promo_uygulama_gunleri5")]
    public bool? PromoUygulamaGunleri5 { get; set; }

    [Column("Promo_uygulama_gunleri6")]
    public bool? PromoUygulamaGunleri6 { get; set; }

    [Column("Promo_uygulama_gunleri7")]
    public bool? PromoUygulamaGunleri7 { get; set; }

    [Column("Promo_gun_ici_baslangic_saati")]
    public DateTime? PromoGunIciBaslangicSaati { get; set; }

    [Column("Promo_gun_ici_bisit_saati")]
    public DateTime? PromoGunIciBisitSaati { get; set; }

    [Column("Promo_kasaya_gidecek_mesaj")]
    [StringLength(40)]
    public string? PromoKasayaGidecekMesaj { get; set; }
}
