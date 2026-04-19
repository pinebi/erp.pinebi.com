using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_talep_hareketleri")]
public class KiralamaTalepHareketleri
{
    [Column("ktlp_Guid")]
    public Guid? KtlpGuid { get; set; }

    [Column("ktlp_DBCno")]
    public short? KtlpDBCno { get; set; }

    [Column("ktlp_Spec_Rec_no")]
    public int? KtlpSpecRecNo { get; set; }

    [Column("ktlp_iptal")]
    public bool? KtlpIptal { get; set; }

    [Column("ktlp_fileid")]
    public short? KtlpFileid { get; set; }

    [Column("ktlp_hidden")]
    public bool? KtlpHidden { get; set; }

    [Column("ktlp_kilitli")]
    public bool? KtlpKilitli { get; set; }

    [Column("ktlp_degisti")]
    public bool? KtlpDegisti { get; set; }

    [Column("ktlp_checksum")]
    public int? KtlpChecksum { get; set; }

    [Column("ktlp_create_user")]
    public short? KtlpCreateUser { get; set; }

    [Column("ktlp_create_date")]
    public DateTime? KtlpCreateDate { get; set; }

    [Column("ktlp_lastup_user")]
    public short? KtlpLastupUser { get; set; }

    [Column("ktlp_lastup_date")]
    public DateTime? KtlpLastupDate { get; set; }

    [Column("ktlp_special1")]
    [StringLength(4)]
    public string? KtlpSpecial1 { get; set; }

    [Column("ktlp_special2")]
    [StringLength(4)]
    public string? KtlpSpecial2 { get; set; }

    [Column("ktlp_special3")]
    [StringLength(4)]
    public string? KtlpSpecial3 { get; set; }

    [Column("ktlp_firmano")]
    public int? KtlpFirmano { get; set; }

    [Column("ktlp_subeno")]
    public int? KtlpSubeno { get; set; }

    [Column("ktlp_tarihi")]
    public DateTime? KtlpTarihi { get; set; }

    [Column("ktlp_evrakno_seri")]
    [StringLength(50)]
    public string? KtlpEvraknoSeri { get; set; }

    [Column("ktlp_evrakno_sira")]
    public int? KtlpEvraknoSira { get; set; }

    [Column("ktlp_satirno")]
    public int? KtlpSatirno { get; set; }

    [Column("ktlp_belgeno")]
    [StringLength(50)]
    public string? KtlpBelgeno { get; set; }

    [Column("ktlp_belge_tarihi")]
    public DateTime? KtlpBelgeTarihi { get; set; }

    [Column("ktlp_cari_kodu")]
    [StringLength(25)]
    public string? KtlpCariKodu { get; set; }

    [Column("ktlp_talep_gelis_sekli")]
    public byte? KtlpTalepGelisSekli { get; set; }

    [Column("ktlp_aciklama")]
    [StringLength(60)]
    public string? KtlpAciklama { get; set; }

    [Column("ktlp_adres_no")]
    public int? KtlpAdresNo { get; set; }

    [Column("ktlp_temsilci_kodu")]
    [StringLength(25)]
    public string? KtlpTemsilciKodu { get; set; }

    [Column("ktlp_yetkili_uid")]
    public Guid? KtlpYetkiliUid { get; set; }

    [Column("ktlp_hareket_tipi")]
    public byte? KtlpHareketTipi { get; set; }

    [Column("ktlp_hareket_kodu")]
    [StringLength(25)]
    public string? KtlpHareketKodu { get; set; }

    [Column("ktlp_satir_aciklama")]
    [StringLength(60)]
    public string? KtlpSatirAciklama { get; set; }

    [Column("ktlp_kiralama_suresi")]
    public int? KtlpKiralamaSuresi { get; set; }

    [Column("ktlp_miktari")]
    public int? KtlpMiktari { get; set; }

    [Column("ktlp_talep_durumu")]
    public byte? KtlpTalepDurumu { get; set; }

    [Column("ktlp_kapama_nedeni_kodu")]
    [StringLength(25)]
    public string? KtlpKapamaNedeniKodu { get; set; }

    [Column("ktlp_sip_tip")]
    public byte? KtlpSipTip { get; set; }

    [Column("ktlp_sip_uid")]
    public Guid? KtlpSipUid { get; set; }

    [Column("ktlp_onaylayan_kul_no")]
    public short? KtlpOnaylayanKulNo { get; set; }

    [Column("ktlp_cagrilabilir_fl")]
    public bool? KtlpCagrilabilirFl { get; set; }
}
