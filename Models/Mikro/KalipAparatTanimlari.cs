using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kalip_aparat_tanimlari")]
public class KalipAparatTanimlari
{
    [Column("klp_Guid")]
    public Guid? KlpGuid { get; set; }

    [Column("klp_DBCno")]
    public short? KlpDBCno { get; set; }

    [Column("klp_SpecRECno")]
    public int? KlpSpecRECno { get; set; }

    [Column("klp_iptal")]
    public bool? KlpIptal { get; set; }

    [Column("klp_fileid")]
    public short? KlpFileid { get; set; }

    [Column("klp_hidden")]
    public bool? KlpHidden { get; set; }

    [Column("klp_kilitli")]
    public bool? KlpKilitli { get; set; }

    [Column("klp_degisti")]
    public bool? KlpDegisti { get; set; }

    [Column("klp_checksum")]
    public int? KlpChecksum { get; set; }

    [Column("klp_create_user")]
    public short? KlpCreateUser { get; set; }

    [Column("klp_create_date")]
    public DateTime? KlpCreateDate { get; set; }

    [Column("klp_lastup_user")]
    public short? KlpLastupUser { get; set; }

    [Column("klp_lastup_date")]
    public DateTime? KlpLastupDate { get; set; }

    [Column("klp_special1")]
    [StringLength(4)]
    public string? KlpSpecial1 { get; set; }

    [Column("klp_special2")]
    [StringLength(4)]
    public string? KlpSpecial2 { get; set; }

    [Column("klp_special3")]
    [StringLength(4)]
    public string? KlpSpecial3 { get; set; }

    [Column("klp_kodu")]
    [StringLength(25)]
    public string? KlpKodu { get; set; }

    [Column("klp_adi")]
    [StringLength(40)]
    public string? KlpAdi { get; set; }

    [Column("klp_urunkodu")]
    [StringLength(25)]
    public string? KlpUrunkodu { get; set; }

    [Column("klp_uretim_miktari")]
    public double? KlpUretimMiktari { get; set; }

    [Column("klp_aktif_fl")]
    public bool? KlpAktifFl { get; set; }

    [Column("klp_calisma_takvimkodu")]
    [StringLength(4)]
    public string? KlpCalismaTakvimkodu { get; set; }

    [Column("klp_kurulum_vardiya_nosu1")]
    public bool? KlpKurulumVardiyaNosu1 { get; set; }

    [Column("klp_kurulum_vardiya_nosu2")]
    public bool? KlpKurulumVardiyaNosu2 { get; set; }

    [Column("klp_kurulum_vardiya_nosu3")]
    public bool? KlpKurulumVardiyaNosu3 { get; set; }

    [Column("klp_kurulum_vardiya_nosu4")]
    public bool? KlpKurulumVardiyaNosu4 { get; set; }

    [Column("klp_kurulum_suresi")]
    public int? KlpKurulumSuresi { get; set; }

    [Column("klp_kurulum_yetkilisi")]
    [StringLength(25)]
    public string? KlpKurulumYetkilisi { get; set; }

    [Column("klp_bakim_yetkilisi")]
    [StringLength(25)]
    public string? KlpBakimYetkilisi { get; set; }

    [Column("klp_srmmrk_kodu")]
    [StringLength(25)]
    public string? KlpSrmmrkKodu { get; set; }

    [Column("klp_master_kalip_kodu")]
    [StringLength(25)]
    public string? KlpMasterKalipKodu { get; set; }

    [Column("klp_sabit_kiymet_kodu")]
    [StringLength(25)]
    public string? KlpSabitKiymetKodu { get; set; }

    [Column("klp_bakim_periyodu")]
    public short? KlpBakimPeriyodu { get; set; }

    [Column("klp_son_bakim_tarihi")]
    public DateTime? KlpSonBakimTarihi { get; set; }

    [Column("klp_renk")]
    public int? KlpRenk { get; set; }

    [Column("klp_yolluk_fire_katsayisi")]
    public double? KlpYollukFireKatsayisi { get; set; }

    [Column("klp_goz_sayisi")]
    public short? KlpGozSayisi { get; set; }

    [Column("klp_imalatci_kodu")]
    [StringLength(25)]
    public string? KlpImalatciKodu { get; set; }

    [Column("klp_imal_tarihi")]
    public DateTime? KlpImalTarihi { get; set; }

    [Column("klp_en")]
    public int? KlpEn { get; set; }

    [Column("klp_boy")]
    public int? KlpBoy { get; set; }

    [Column("klp_yukseklik")]
    public int? KlpYukseklik { get; set; }

    [Column("klp_agirlik")]
    public double? KlpAgirlik { get; set; }
}
