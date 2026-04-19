using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_teklif_hareketleri")]
public class KiralamaTeklifHareketleri
{
    [Column("ktkf_Guid")]
    public Guid? KtkfGuid { get; set; }

    [Column("ktkf_DBCno")]
    public short? KtkfDBCno { get; set; }

    [Column("ktkf_Spec_Rec_no")]
    public int? KtkfSpecRecNo { get; set; }

    [Column("ktkf_iptal")]
    public bool? KtkfIptal { get; set; }

    [Column("ktkf_fileid")]
    public short? KtkfFileid { get; set; }

    [Column("ktkf_hidden")]
    public bool? KtkfHidden { get; set; }

    [Column("ktkf_kilitli")]
    public bool? KtkfKilitli { get; set; }

    [Column("ktkf_degisti")]
    public bool? KtkfDegisti { get; set; }

    [Column("ktkf_checksum")]
    public int? KtkfChecksum { get; set; }

    [Column("ktkf_create_user")]
    public short? KtkfCreateUser { get; set; }

    [Column("ktkf_create_date")]
    public DateTime? KtkfCreateDate { get; set; }

    [Column("ktkf_lastup_user")]
    public short? KtkfLastupUser { get; set; }

    [Column("ktkf_lastup_date")]
    public DateTime? KtkfLastupDate { get; set; }

    [Column("ktkf_special1")]
    [StringLength(4)]
    public string? KtkfSpecial1 { get; set; }

    [Column("ktkf_special2")]
    [StringLength(4)]
    public string? KtkfSpecial2 { get; set; }

    [Column("ktkf_special3")]
    [StringLength(4)]
    public string? KtkfSpecial3 { get; set; }

    [Column("ktkf_firmano")]
    public int? KtkfFirmano { get; set; }

    [Column("ktkf_subeno")]
    public int? KtkfSubeno { get; set; }

    [Column("ktkf_tarihi")]
    public DateTime? KtkfTarihi { get; set; }

    [Column("ktkf_evrakno_seri")]
    [StringLength(50)]
    public string? KtkfEvraknoSeri { get; set; }

    [Column("ktkf_evrakno_sira")]
    public int? KtkfEvraknoSira { get; set; }

    [Column("ktkf_satirno")]
    public int? KtkfSatirno { get; set; }

    [Column("ktkf_revizyonno")]
    public int? KtkfRevizyonno { get; set; }

    [Column("ktkf_belgeno")]
    [StringLength(50)]
    public string? KtkfBelgeno { get; set; }

    [Column("ktkf_belge_tarihi")]
    public DateTime? KtkfBelgeTarihi { get; set; }

    [Column("ktkf_cari_kodu")]
    [StringLength(25)]
    public string? KtkfCariKodu { get; set; }

    [Column("ktkf_doviz_cinsi")]
    public byte? KtkfDovizCinsi { get; set; }

    [Column("ktkf_aciklama")]
    [StringLength(60)]
    public string? KtkfAciklama { get; set; }

    [Column("ktkf_adres_no")]
    public int? KtkfAdresNo { get; set; }

    [Column("ktkf_depono")]
    public int? KtkfDepono { get; set; }

    [Column("ktkf_temsilci_kodu")]
    [StringLength(25)]
    public string? KtkfTemsilciKodu { get; set; }

    [Column("ktkf_yetkili_uid")]
    public Guid? KtkfYetkiliUid { get; set; }

    [Column("ktkf_opno")]
    public int? KtkfOpno { get; set; }

    [Column("ktkf_hareket_tipi")]
    public byte? KtkfHareketTipi { get; set; }

    [Column("ktkf_hareket_kodu")]
    [StringLength(25)]
    public string? KtkfHareketKodu { get; set; }

    [Column("ktkf_seri_no")]
    [StringLength(25)]
    public string? KtkfSeriNo { get; set; }

    [Column("ktkf_kiralama_suresi")]
    public int? KtkfKiralamaSuresi { get; set; }

    [Column("ktkf_miktari")]
    public double? KtkfMiktari { get; set; }

    [Column("ktkf_gunluk_liste_fiyati")]
    public double? KtkfGunlukListeFiyati { get; set; }

    [Column("ktkf_haftalik_liste_fiyati")]
    public double? KtkfHaftalikListeFiyati { get; set; }

    [Column("ktkf_aylik_liste_fiyati")]
    public double? KtkfAylikListeFiyati { get; set; }

    [Column("ktkf_isktutari")]
    public double? KtkfIsktutari { get; set; }

    [Column("ktkf_tutar")]
    public double? KtkfTutar { get; set; }

    [Column("ktkf_satir_aciklama")]
    [StringLength(60)]
    public string? KtkfSatirAciklama { get; set; }

    [Column("ktkf_ktlp_uid")]
    public Guid? KtkfKtlpUid { get; set; }

    [Column("ktkf_teklif_durumu")]
    public bool? KtkfTeklifDurumu { get; set; }

    [Column("ktkf_kapama_nedeni_kodu")]
    [StringLength(25)]
    public string? KtkfKapamaNedeniKodu { get; set; }
}
