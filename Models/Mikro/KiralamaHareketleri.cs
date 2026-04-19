using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_hareketleri")]
public class KiralamaHareketleri
{
    [Column("khar_Guid")]
    public Guid? KharGuid { get; set; }

    [Column("khar_DBCno")]
    public short? KharDBCno { get; set; }

    [Column("khar_Spec_Rec_no")]
    public int? KharSpecRecNo { get; set; }

    [Column("khar_iptal")]
    public bool? KharIptal { get; set; }

    [Column("khar_fileid")]
    public short? KharFileid { get; set; }

    [Column("khar_hidden")]
    public bool? KharHidden { get; set; }

    [Column("khar_kilitli")]
    public bool? KharKilitli { get; set; }

    [Column("khar_degisti")]
    public bool? KharDegisti { get; set; }

    [Column("khar_checksum")]
    public int? KharChecksum { get; set; }

    [Column("khar_create_user")]
    public short? KharCreateUser { get; set; }

    [Column("khar_create_date")]
    public DateTime? KharCreateDate { get; set; }

    [Column("khar_lastup_user")]
    public short? KharLastupUser { get; set; }

    [Column("khar_lastup_date")]
    public DateTime? KharLastupDate { get; set; }

    [Column("khar_special1")]
    [StringLength(4)]
    public string? KharSpecial1 { get; set; }

    [Column("khar_special2")]
    [StringLength(4)]
    public string? KharSpecial2 { get; set; }

    [Column("khar_special3")]
    [StringLength(4)]
    public string? KharSpecial3 { get; set; }

    [Column("khar_firmano")]
    public int? KharFirmano { get; set; }

    [Column("khar_subeno")]
    public int? KharSubeno { get; set; }

    [Column("khar_kodu")]
    [StringLength(25)]
    public string? KharKodu { get; set; }

    [Column("khar_tarihi")]
    public DateTime? KharTarihi { get; set; }

    [Column("khar_cari_kodu")]
    [StringLength(25)]
    public string? KharCariKodu { get; set; }

    [Column("khar_doviz_cinsi")]
    public byte? KharDovizCinsi { get; set; }

    [Column("khar_fat_doviz_cinsi")]
    public byte? KharFatDovizCinsi { get; set; }

    [Column("khar_aciklama")]
    [StringLength(60)]
    public string? KharAciklama { get; set; }

    [Column("khar_aciklama2")]
    [StringLength(60)]
    public string? KharAciklama2 { get; set; }

    [Column("khar_fat_adres_no")]
    public int? KharFatAdresNo { get; set; }

    [Column("khar_sevk_adres_no")]
    public int? KharSevkAdresNo { get; set; }

    [Column("khar_depono")]
    public int? KharDepono { get; set; }

    [Column("khar_temsilci_kodu")]
    [StringLength(25)]
    public string? KharTemsilciKodu { get; set; }

    [Column("khar_yetkili_uid")]
    public Guid? KharYetkiliUid { get; set; }

    [Column("khar_srm_merkezi_kodu")]
    [StringLength(25)]
    public string? KharSrmMerkeziKodu { get; set; }

    [Column("khar_proje_kodu")]
    [StringLength(25)]
    public string? KharProjeKodu { get; set; }

    [Column("khar_kullanim_alani_kodu")]
    [StringLength(25)]
    public string? KharKullanimAlaniKodu { get; set; }

    [Column("khar_yapilan_is_kodu")]
    [StringLength(25)]
    public string? KharYapilanIsKodu { get; set; }

    [Column("khar_opno")]
    public int? KharOpno { get; set; }

    [Column("khar_baslangic_tarihi")]
    public DateTime? KharBaslangicTarihi { get; set; }

    [Column("khar_fatura_peryodu")]
    public byte? KharFaturaPeryodu { get; set; }

    [Column("khar_fatura_gunu")]
    public short? KharFaturaGunu { get; set; }

    [Column("khar_kiralama_cinsi")]
    public byte? KharKiralamaCinsi { get; set; }

    [Column("khar_son_faturano_seri")]
    [StringLength(50)]
    public string? KharSonFaturanoSeri { get; set; }

    [Column("khar_son_faturano_sira")]
    public int? KharSonFaturanoSira { get; set; }

    [Column("khar_satirno")]
    public int? KharSatirno { get; set; }

    [Column("khar_hareket_tipi")]
    public byte? KharHareketTipi { get; set; }

    [Column("khar_hareket_kodu")]
    [StringLength(25)]
    public string? KharHareketKodu { get; set; }

    [Column("khar_seri_no")]
    [StringLength(25)]
    public string? KharSeriNo { get; set; }

    [Column("khar_kiralama_suresi")]
    public int? KharKiralamaSuresi { get; set; }

    [Column("khar_isk_tutari")]
    public double? KharIskTutari { get; set; }

    [Column("khar_tutar")]
    public double? KharTutar { get; set; }

    [Column("khar_satir_aciklama")]
    [StringLength(60)]
    public string? KharSatirAciklama { get; set; }

    [Column("khar_durumu")]
    public byte? KharDurumu { get; set; }

    [Column("khar_revize_sure")]
    public int? KharRevizeSure { get; set; }

    [Column("khar_revize_tutar")]
    public double? KharRevizeTutar { get; set; }

    [Column("khar_bitis_tarihi")]
    public DateTime? KharBitisTarihi { get; set; }

    [Column("khar_tahmini_donus_tarihi")]
    public DateTime? KharTahminiDonusTarihi { get; set; }

    [Column("khar_faturalanan_son_tarih")]
    public DateTime? KharFaturalananSonTarih { get; set; }

    [Column("khar_hizmet_faturano_seri")]
    [StringLength(50)]
    public string? KharHizmetFaturanoSeri { get; set; }

    [Column("khar_hizmet_faturano_sira")]
    public int? KharHizmetFaturanoSira { get; set; }

    [Column("khar_ktkf_uid")]
    public Guid? KharKtkfUid { get; set; }
}
