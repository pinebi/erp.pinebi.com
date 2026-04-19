using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_teklif_revizyonlari")]
public class KiralamaTeklifRevizyonlari
{
    [Column("ktrv_Guid")]
    public Guid? KtrvGuid { get; set; }

    [Column("ktrv_DBCno")]
    public short? KtrvDBCno { get; set; }

    [Column("ktrv_Spec_Rec_no")]
    public int? KtrvSpecRecNo { get; set; }

    [Column("ktrv_iptal")]
    public bool? KtrvIptal { get; set; }

    [Column("ktrv_fileid")]
    public short? KtrvFileid { get; set; }

    [Column("ktrv_hidden")]
    public bool? KtrvHidden { get; set; }

    [Column("ktrv_kilitli")]
    public bool? KtrvKilitli { get; set; }

    [Column("ktrv_degisti")]
    public bool? KtrvDegisti { get; set; }

    [Column("ktrv_checksum")]
    public int? KtrvChecksum { get; set; }

    [Column("ktrv_create_user")]
    public short? KtrvCreateUser { get; set; }

    [Column("ktrv_create_date")]
    public DateTime? KtrvCreateDate { get; set; }

    [Column("ktrv_lastup_user")]
    public short? KtrvLastupUser { get; set; }

    [Column("ktrv_lastup_date")]
    public DateTime? KtrvLastupDate { get; set; }

    [Column("ktrv_special1")]
    [StringLength(4)]
    public string? KtrvSpecial1 { get; set; }

    [Column("ktrv_special2")]
    [StringLength(4)]
    public string? KtrvSpecial2 { get; set; }

    [Column("ktrv_special3")]
    [StringLength(4)]
    public string? KtrvSpecial3 { get; set; }

    [Column("ktrv_firmano")]
    public int? KtrvFirmano { get; set; }

    [Column("ktrv_subeno")]
    public int? KtrvSubeno { get; set; }

    [Column("ktrv_tarihi")]
    public DateTime? KtrvTarihi { get; set; }

    [Column("ktrv_evrakno_seri")]
    [StringLength(50)]
    public string? KtrvEvraknoSeri { get; set; }

    [Column("ktrv_evrakno_sira")]
    public int? KtrvEvraknoSira { get; set; }

    [Column("ktrv_revizyonno")]
    public int? KtrvRevizyonno { get; set; }

    [Column("ktrv_satirno")]
    public int? KtrvSatirno { get; set; }

    [Column("ktrv_hareket_tipi")]
    public byte? KtrvHareketTipi { get; set; }

    [Column("ktrv_hareket_kodu")]
    [StringLength(25)]
    public string? KtrvHareketKodu { get; set; }

    [Column("ktrv_seri_no")]
    [StringLength(25)]
    public string? KtrvSeriNo { get; set; }

    [Column("ktrv_kiralama_suresi")]
    public int? KtrvKiralamaSuresi { get; set; }

    [Column("ktrv_miktari")]
    public int? KtrvMiktari { get; set; }

    [Column("ktrv_gunluk_liste_fiyati")]
    public double? KtrvGunlukListeFiyati { get; set; }

    [Column("ktrv_haftalik_liste_fiyati")]
    public double? KtrvHaftalikListeFiyati { get; set; }

    [Column("ktrv_aylik_liste_fiyati")]
    public double? KtrvAylikListeFiyati { get; set; }

    [Column("ktrv_isktutari")]
    public double? KtrvIsktutari { get; set; }

    [Column("ktrv_tutar")]
    public double? KtrvTutar { get; set; }

    [Column("ktrv_satir_aciklama")]
    [StringLength(60)]
    public string? KtrvSatirAciklama { get; set; }

    [Column("ktrv_ktlp_uid")]
    public Guid? KtrvKtlpUid { get; set; }
}
