using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("urun_receteleri")]
public class UrunReceteleri
{
    [Column("rec_Guid")]
    public Guid RecGuid { get; set; }

    [Column("rec_DBCno")]
    public short? RecDBCno { get; set; }

    [Column("rec_SpecRECno")]
    public int? RecSpecRECno { get; set; }

    [Column("rec_iptal")]
    public bool? RecIptal { get; set; }

    [Column("rec_fileid")]
    public short? RecFileid { get; set; }

    [Column("rec_hidden")]
    public bool? RecHidden { get; set; }

    [Column("rec_kilitli")]
    public bool? RecKilitli { get; set; }

    [Column("rec_degisti")]
    public bool? RecDegisti { get; set; }

    [Column("rec_checksum")]
    public int? RecChecksum { get; set; }

    [Column("rec_create_user")]
    public short? RecCreateUser { get; set; }

    [Column("rec_create_date")]
    public DateTime? RecCreateDate { get; set; }

    [Column("rec_lastup_user")]
    public short? RecLastupUser { get; set; }

    [Column("rec_lastup_date")]
    public DateTime? RecLastupDate { get; set; }

    [Column("rec_special1")]
    [StringLength(4)]
    public string? RecSpecial1 { get; set; }

    [Column("rec_special2")]
    [StringLength(4)]
    public string? RecSpecial2 { get; set; }

    [Column("rec_special3")]
    [StringLength(4)]
    public string? RecSpecial3 { get; set; }

    [Column("rec_anatipi")]
    public byte? RecAnatipi { get; set; }

    [Column("rec_anakod")]
    [StringLength(25)]
    public string? RecAnakod { get; set; }

    [Column("rec_tanimkod")]
    [StringLength(25)]
    public string? RecTanimkod { get; set; }

    [Column("rec_cinsi")]
    public byte? RecCinsi { get; set; }

    [Column("rec_tarih")]
    public DateTime? RecTarih { get; set; }

    [Column("rec_aciklama")]
    [StringLength(127)]
    public string? RecAciklama { get; set; }

    [Column("rec_anabirim")]
    public byte? RecAnabirim { get; set; }

    [Column("rec_anamiktar")]
    public double? RecAnamiktar { get; set; }

    [Column("rec_tuketim_tur")]
    public byte? RecTuketimTur { get; set; }

    [Column("rec_tuketim_kod")]
    [StringLength(25)]
    public string? RecTuketimKod { get; set; }

    [Column("rec_tuketim_tanim_kodu")]
    [StringLength(25)]
    public string? RecTuketimTanimKodu { get; set; }

    [Column("rec_tuketim_recete_cinsi")]
    public byte? RecTuketimReceteCinsi { get; set; }

    [Column("rec_tuketim_miktar")]
    public double? RecTuketimMiktar { get; set; }

    [Column("rec_tuketim_birim")]
    public byte? RecTuketimBirim { get; set; }

    [Column("rec_uretim_tuketim")]
    public byte? RecUretimTuketim { get; set; }

    [Column("rec_satirno")]
    public int? RecSatirno { get; set; }

    [Column("rec_satir_acik")]
    [StringLength(127)]
    public string? RecSatirAcik { get; set; }

    [Column("rec_depono")]
    public int? RecDepono { get; set; }

    [Column("rec_fireyuzde")]
    public double? RecFireyuzde { get; set; }

    [Column("rec_baslama_tarihi")]
    public DateTime? RecBaslamaTarihi { get; set; }

    [Column("rec_bitis_tarihi")]
    public DateTime? RecBitisTarihi { get; set; }

    [Column("rec_alt_tukkod1")]
    [StringLength(25)]
    public string? RecAltTukkod1 { get; set; }

    [Column("rec_alt_1_katsayi")]
    public double? RecAlt1Katsayi { get; set; }

    [Column("rec_alt_tukkod2")]
    [StringLength(25)]
    public string? RecAltTukkod2 { get; set; }

    [Column("rec_alt_2_katsayi")]
    public double? RecAlt2Katsayi { get; set; }

    [Column("rec_alt_tukkod3")]
    [StringLength(25)]
    public string? RecAltTukkod3 { get; set; }

    [Column("rec_alt_3_katsayi")]
    public double? RecAlt3Katsayi { get; set; }

    [Column("rec_alt_tukkod4")]
    [StringLength(25)]
    public string? RecAltTukkod4 { get; set; }

    [Column("rec_alt_4_katsayi")]
    public double? RecAlt4Katsayi { get; set; }

    [Column("rec_alt_tukkod5")]
    [StringLength(25)]
    public string? RecAltTukkod5 { get; set; }

    [Column("rec_alt_5_katsayi")]
    public double? RecAlt5Katsayi { get; set; }

    [Column("rec_safha_no")]
    public short? RecSafhaNo { get; set; }

    [Column("rec_safha_turu")]
    public byte? RecSafhaTuru { get; set; }

    [Column("rec_ana_renk_no")]
    public byte? RecAnaRenkNo { get; set; }

    [Column("rec_ana_beden_no")]
    public byte? RecAnaBedenNo { get; set; }

    [Column("rec_tuketim_renk_no")]
    public byte? RecTuketimRenkNo { get; set; }

    [Column("rec_tuketim_beden_no")]
    public byte? RecTuketimBedenNo { get; set; }

    [Column("rec_PlanlamaTipi")]
    public byte? RecPlanlamaTipi { get; set; }

    [Column("rec_eklenme_sarti")]
    public byte? RecEklenmeSarti { get; set; }

    [Column("rec_miktar_fonksiyon_adi")]
    [StringLength(70)]
    public string? RecMiktarFonksiyonAdi { get; set; }
}
