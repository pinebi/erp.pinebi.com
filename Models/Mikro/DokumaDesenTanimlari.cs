using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("dokuma_desen_tanimlari")]
public class DokumaDesenTanimlari
{
    [Column("dd_Guid")]
    public Guid? DdGuid { get; set; }

    [Column("dd_DBCno")]
    public short? DdDBCno { get; set; }

    [Column("dd_SpecRECno")]
    public int? DdSpecRECno { get; set; }

    [Column("dd_iptal")]
    public bool? DdIptal { get; set; }

    [Column("dd_fileid")]
    public short? DdFileid { get; set; }

    [Column("dd_hidden")]
    public bool? DdHidden { get; set; }

    [Column("dd_kilitli")]
    public bool? DdKilitli { get; set; }

    [Column("dd_degisti")]
    public bool? DdDegisti { get; set; }

    [Column("dd_checksum")]
    public int? DdChecksum { get; set; }

    [Column("dd_create_user")]
    public short? DdCreateUser { get; set; }

    [Column("dd_create_date")]
    public DateTime? DdCreateDate { get; set; }

    [Column("dd_lastup_user")]
    public short? DdLastupUser { get; set; }

    [Column("dd_lastup_date")]
    public DateTime? DdLastupDate { get; set; }

    [Column("dd_special1")]
    [StringLength(4)]
    public string? DdSpecial1 { get; set; }

    [Column("dd_special2")]
    [StringLength(4)]
    public string? DdSpecial2 { get; set; }

    [Column("dd_special3")]
    [StringLength(4)]
    public string? DdSpecial3 { get; set; }

    [Column("dd_stok_kodu")]
    [StringLength(25)]
    public string? DdStokKodu { get; set; }

    [Column("dd_aciklama")]
    [StringLength(50)]
    public string? DdAciklama { get; set; }

    [Column("dd_tanim_tarihi")]
    public DateTime? DdTanimTarihi { get; set; }

    [Column("dd_tanimlayan_kisi")]
    [StringLength(25)]
    public string? DdTanimlayanKisi { get; set; }

    [Column("dd_enden_cekme_yuzdesi")]
    public double? DdEndenCekmeYuzdesi { get; set; }

    [Column("dd_boydan_cekme_yuzdesi")]
    public double? DdBoydanCekmeYuzdesi { get; set; }

    [Column("dd_musteri_1")]
    [StringLength(25)]
    public string? DdMusteri1 { get; set; }

    [Column("dd_musteri_2")]
    [StringLength(25)]
    public string? DdMusteri2 { get; set; }

    [Column("dd_musteri_3")]
    [StringLength(25)]
    public string? DdMusteri3 { get; set; }

    [Column("dd_zemin_cozgu_stok_kodu")]
    [StringLength(25)]
    public string? DdZeminCozguStokKodu { get; set; }

    [Column("dd_zemin_cozgu_sikligi")]
    public double? DdZeminCozguSikligi { get; set; }

    [Column("dd_hav_cozgu_stok_kodu")]
    [StringLength(25)]
    public string? DdHavCozguStokKodu { get; set; }

    [Column("dd_hav_cozgu_sikligi")]
    public double? DdHavCozguSikligi { get; set; }

    [Column("dd_hav_orani_hesaplanan")]
    public double? DdHavOraniHesaplanan { get; set; }

    [Column("dd_hav_orani_olculen")]
    public double? DdHavOraniOlculen { get; set; }

    [Column("dd_boyhavorani_hesaplanandan")]
    public double? DdBoyhavoraniHesaplanandan { get; set; }

    [Column("dd_boyhavorani_olculenden")]
    public double? DdBoyhavoraniOlculenden { get; set; }

    [Column("dd_uretim_gramaji")]
    public double? DdUretimGramaji { get; set; }

    [Column("dd_mamul_gramaji")]
    public double? DdMamulGramaji { get; set; }

    [Column("dd_mamul_eni_cm")]
    public double? DdMamulEniCm { get; set; }

    [Column("dd_uretim_eni_cm")]
    public double? DdUretimEniCm { get; set; }

    [Column("dd_dokuma_en_sayisi")]
    public short? DdDokumaEnSayisi { get; set; }

    [Column("dd_uretim_boyu")]
    public double? DdUretimBoyu { get; set; }

    [Column("dd_mamul_boyu")]
    public double? DdMamulBoyu { get; set; }

    [Column("dd_faydali_tarak_eni")]
    public double? DdFaydaliTarakEni { get; set; }

    [Column("dd_ilmek_atki_sayisi")]
    public short? DdIlmekAtkiSayisi { get; set; }

    [Column("dd_havdan_hava_boy")]
    public double? DdHavdanHavaBoy { get; set; }

    [Column("dd_havdan_hava_en")]
    public double? DdHavdanHavaEn { get; set; }
}
