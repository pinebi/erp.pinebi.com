using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("butce_master")]
public class ButceMaster
{
    [Column("bm_Guid")]
    public Guid? BmGuid { get; set; }

    [Column("bm_DBCno")]
    public short? BmDBCno { get; set; }

    [Column("bm_SpecRECno")]
    public int? BmSpecRECno { get; set; }

    [Column("bm_iptal")]
    public bool? BmIptal { get; set; }

    [Column("bm_fileid")]
    public short? BmFileid { get; set; }

    [Column("bm_hidden")]
    public bool? BmHidden { get; set; }

    [Column("bm_kilitli")]
    public bool? BmKilitli { get; set; }

    [Column("bm_degisti")]
    public bool? BmDegisti { get; set; }

    [Column("bm_checksum")]
    public int? BmChecksum { get; set; }

    [Column("bm_create_user")]
    public short? BmCreateUser { get; set; }

    [Column("bm_create_date")]
    public DateTime? BmCreateDate { get; set; }

    [Column("bm_lastup_user")]
    public short? BmLastupUser { get; set; }

    [Column("bm_lastup_date")]
    public DateTime? BmLastupDate { get; set; }

    [Column("bm_special1")]
    [StringLength(4)]
    public string? BmSpecial1 { get; set; }

    [Column("bm_special2")]
    [StringLength(4)]
    public string? BmSpecial2 { get; set; }

    [Column("bm_special3")]
    [StringLength(4)]
    public string? BmSpecial3 { get; set; }

    [Column("bm_butcekodu")]
    [StringLength(25)]
    public string? BmButcekodu { get; set; }

    [Column("bm_butceadi")]
    [StringLength(40)]
    public string? BmButceadi { get; set; }

    [Column("bm_firmano")]
    public int? BmFirmano { get; set; }

    [Column("bm_butcetipi")]
    public byte? BmButcetipi { get; set; }

    [Column("bm_stok_detayi")]
    public byte? BmStokDetayi { get; set; }

    [Column("bm_hizmet_detayi")]
    public byte? BmHizmetDetayi { get; set; }

    [Column("bm_masraf_detayi")]
    public byte? BmMasrafDetayi { get; set; }

    [Column("bm_cari_detayi")]
    public byte? BmCariDetayi { get; set; }

    [Column("bm_sorumlu_detayi")]
    public byte? BmSorumluDetayi { get; set; }

    [Column("bm_depo_detayi")]
    public byte? BmDepoDetayi { get; set; }

    [Column("bm_sormrk_detayi")]
    public byte? BmSormrkDetayi { get; set; }

    [Column("bm_proje_detayi")]
    public byte? BmProjeDetayi { get; set; }

    [Column("bm_donem_tipi")]
    public byte? BmDonemTipi { get; set; }

    [Column("bm_deger_detayi1")]
    public byte? BmDegerDetayi1 { get; set; }

    [Column("bm_deger_detayi2")]
    public byte? BmDegerDetayi2 { get; set; }

    [Column("bm_deger_detayi3")]
    public byte? BmDegerDetayi3 { get; set; }

    [Column("bm_deger_detayi4")]
    public byte? BmDegerDetayi4 { get; set; }

    [Column("bm_deger_detayi5")]
    public byte? BmDegerDetayi5 { get; set; }

    [Column("bm_MaxTanimliDonem")]
    public byte? BmMaxTanimliDonem { get; set; }

    [Column("bm_Donem1_adi")]
    [StringLength(25)]
    public string? BmDonem1Adi { get; set; }

    [Column("bm_Donem2_adi")]
    [StringLength(25)]
    public string? BmDonem2Adi { get; set; }

    [Column("bm_Donem3_adi")]
    [StringLength(25)]
    public string? BmDonem3Adi { get; set; }

    [Column("bm_Donem4_adi")]
    [StringLength(25)]
    public string? BmDonem4Adi { get; set; }

    [Column("bm_Donem5_adi")]
    [StringLength(25)]
    public string? BmDonem5Adi { get; set; }

    [Column("bm_Donem6_adi")]
    [StringLength(25)]
    public string? BmDonem6Adi { get; set; }

    [Column("bm_Donem7_adi")]
    [StringLength(25)]
    public string? BmDonem7Adi { get; set; }

    [Column("bm_Donem8_adi")]
    [StringLength(25)]
    public string? BmDonem8Adi { get; set; }

    [Column("bm_Donem9_adi")]
    [StringLength(25)]
    public string? BmDonem9Adi { get; set; }

    [Column("bm_Donem10_adi")]
    [StringLength(25)]
    public string? BmDonem10Adi { get; set; }

    [Column("bm_Donem11_adi")]
    [StringLength(25)]
    public string? BmDonem11Adi { get; set; }

    [Column("bm_Donem12_adi")]
    [StringLength(25)]
    public string? BmDonem12Adi { get; set; }

    [Column("bm_Donem13_adi")]
    [StringLength(25)]
    public string? BmDonem13Adi { get; set; }

    [Column("bm_Donem14_adi")]
    [StringLength(25)]
    public string? BmDonem14Adi { get; set; }

    [Column("bm_Donem15_adi")]
    [StringLength(25)]
    public string? BmDonem15Adi { get; set; }

    [Column("bm_Donem16_adi")]
    [StringLength(25)]
    public string? BmDonem16Adi { get; set; }

    [Column("bm_Donem1_bas")]
    public DateTime? BmDonem1Bas { get; set; }

    [Column("bm_Donem1_bit")]
    public DateTime? BmDonem1Bit { get; set; }

    [Column("bm_Donem2_bas")]
    public DateTime? BmDonem2Bas { get; set; }

    [Column("bm_Donem2_bit")]
    public DateTime? BmDonem2Bit { get; set; }

    [Column("bm_Donem3_bas")]
    public DateTime? BmDonem3Bas { get; set; }

    [Column("bm_Donem3_bit")]
    public DateTime? BmDonem3Bit { get; set; }

    [Column("bm_Donem4_bas")]
    public DateTime? BmDonem4Bas { get; set; }

    [Column("bm_Donem4_bit")]
    public DateTime? BmDonem4Bit { get; set; }

    [Column("bm_Donem5_bas")]
    public DateTime? BmDonem5Bas { get; set; }

    [Column("bm_Donem5_bit")]
    public DateTime? BmDonem5Bit { get; set; }

    [Column("bm_Donem6_bas")]
    public DateTime? BmDonem6Bas { get; set; }

    [Column("bm_Donem6_bit")]
    public DateTime? BmDonem6Bit { get; set; }

    [Column("bm_Donem7_bas")]
    public DateTime? BmDonem7Bas { get; set; }

    [Column("bm_Donem7_bit")]
    public DateTime? BmDonem7Bit { get; set; }

    [Column("bm_Donem8_bas")]
    public DateTime? BmDonem8Bas { get; set; }

    [Column("bm_Donem8_bit")]
    public DateTime? BmDonem8Bit { get; set; }

    [Column("bm_Donem9_bas")]
    public DateTime? BmDonem9Bas { get; set; }

    [Column("bm_Donem9_bit")]
    public DateTime? BmDonem9Bit { get; set; }

    [Column("bm_Donem10_bas")]
    public DateTime? BmDonem10Bas { get; set; }

    [Column("bm_Donem10_bit")]
    public DateTime? BmDonem10Bit { get; set; }

    [Column("bm_Donem11_bas")]
    public DateTime? BmDonem11Bas { get; set; }

    [Column("bm_Donem11_bit")]
    public DateTime? BmDonem11Bit { get; set; }

    [Column("bm_Donem12_bas")]
    public DateTime? BmDonem12Bas { get; set; }

    [Column("bm_Donem12_bit")]
    public DateTime? BmDonem12Bit { get; set; }

    [Column("bm_Donem13_bas")]
    public DateTime? BmDonem13Bas { get; set; }

    [Column("bm_Donem13_bit")]
    public DateTime? BmDonem13Bit { get; set; }

    [Column("bm_Donem14_bas")]
    public DateTime? BmDonem14Bas { get; set; }

    [Column("bm_Donem14_bit")]
    public DateTime? BmDonem14Bit { get; set; }

    [Column("bm_Donem15_bas")]
    public DateTime? BmDonem15Bas { get; set; }

    [Column("bm_Donem15_bit")]
    public DateTime? BmDonem15Bit { get; set; }

    [Column("bm_Donem16_bas")]
    public DateTime? BmDonem16Bas { get; set; }

    [Column("bm_Donem16_bit")]
    public DateTime? BmDonem16Bit { get; set; }

    [Column("bm_stok_detay_str")]
    [StringLength(50)]
    public string? BmStokDetayStr { get; set; }

    [Column("bm_hizmet_detay_str")]
    [StringLength(50)]
    public string? BmHizmetDetayStr { get; set; }

    [Column("bm_masraf_detay_str")]
    [StringLength(50)]
    public string? BmMasrafDetayStr { get; set; }

    [Column("bm_cari_detay_str")]
    [StringLength(50)]
    public string? BmCariDetayStr { get; set; }

    [Column("bm_sorumlu_detay_str")]
    [StringLength(50)]
    public string? BmSorumluDetayStr { get; set; }

    [Column("bm_depo_detay_str")]
    [StringLength(50)]
    public string? BmDepoDetayStr { get; set; }

    [Column("bm_sormrk_detay_str")]
    [StringLength(50)]
    public string? BmSormrkDetayStr { get; set; }

    [Column("bm_proje_detay_str")]
    [StringLength(50)]
    public string? BmProjeDetayStr { get; set; }

    [Column("bm_donem_detay_str")]
    [StringLength(50)]
    public string? BmDonemDetayStr { get; set; }
}
