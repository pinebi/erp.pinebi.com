using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bakim_kabul_hareketleri")]
public class BakimKabulHareketleri
{
    [Column("bkmkb_Guid")]
    public Guid? BkmkbGuid { get; set; }

    [Column("bkmkb_DBCno")]
    public short? BkmkbDBCno { get; set; }

    [Column("bkmkb_Spec_Rec_no")]
    public int? BkmkbSpecRecNo { get; set; }

    [Column("bkmkb_iptal")]
    public bool? BkmkbIptal { get; set; }

    [Column("bkmkb_fileid")]
    public short? BkmkbFileid { get; set; }

    [Column("bkmkb_hidden")]
    public bool? BkmkbHidden { get; set; }

    [Column("bkmkb_kilitli")]
    public bool? BkmkbKilitli { get; set; }

    [Column("bkmkb_degisti")]
    public bool? BkmkbDegisti { get; set; }

    [Column("bkmkb_checksum")]
    public int? BkmkbChecksum { get; set; }

    [Column("bkmkb_create_user")]
    public short? BkmkbCreateUser { get; set; }

    [Column("bkmkb_create_date")]
    public DateTime? BkmkbCreateDate { get; set; }

    [Column("bkmkb_lastup_user")]
    public short? BkmkbLastupUser { get; set; }

    [Column("bkmkb_lastup_date")]
    public DateTime? BkmkbLastupDate { get; set; }

    [Column("bkmkb_special1")]
    [StringLength(4)]
    public string? BkmkbSpecial1 { get; set; }

    [Column("bkmkb_special2")]
    [StringLength(4)]
    public string? BkmkbSpecial2 { get; set; }

    [Column("bkmkb_special3")]
    [StringLength(4)]
    public string? BkmkbSpecial3 { get; set; }

    [Column("bkmkb_firmano")]
    public int? BkmkbFirmano { get; set; }

    [Column("bkmkb_subeno")]
    public int? BkmkbSubeno { get; set; }

    [Column("bkmkb_tarihi")]
    public DateTime? BkmkbTarihi { get; set; }

    [Column("bkmkb_evrakno_seri")]
    [StringLength(50)]
    public string? BkmkbEvraknoSeri { get; set; }

    [Column("bkmkb_evrakno_sira")]
    public int? BkmkbEvraknoSira { get; set; }

    [Column("bkmkb_satirno")]
    public int? BkmkbSatirno { get; set; }

    [Column("bkmkb_belgeno")]
    [StringLength(50)]
    public string? BkmkbBelgeno { get; set; }

    [Column("bkmkb_belge_tarihi")]
    public DateTime? BkmkbBelgeTarihi { get; set; }

    [Column("bkmkb_cihaz_serino")]
    [StringLength(25)]
    public string? BkmkbCihazSerino { get; set; }

    [Column("bkmkb_fis_stok_kodu")]
    [StringLength(25)]
    public string? BkmkbFisStokKodu { get; set; }

    [Column("bkmkb_tuketici_kodu")]
    [StringLength(25)]
    public string? BkmkbTuketiciKodu { get; set; }

    [Column("bkmkb_talep_gelis_sekli")]
    public byte? BkmkbTalepGelisSekli { get; set; }

    [Column("bkmkb_gelis_kargo_kodu")]
    [StringLength(25)]
    public string? BkmkbGelisKargoKodu { get; set; }

    [Column("bkmkb_gelis_kargo_belgeno")]
    [StringLength(18)]
    public string? BkmkbGelisKargoBelgeno { get; set; }

    [Column("bkmkb_gelis_irsaliyeno")]
    [StringLength(18)]
    public string? BkmkbGelisIrsaliyeno { get; set; }

    [Column("bkmkb_servis_turu")]
    public byte? BkmkbServisTuru { get; set; }

    [Column("bkmkb_servis_yeri")]
    public byte? BkmkbServisYeri { get; set; }

    [Column("bkmkb_aksesuarlar")]
    [StringLength(92)]
    public string? BkmkbAksesuarlar { get; set; }

    [Column("bkmkb_bildirilen_arizalar")]
    [StringLength(92)]
    public string? BkmkbBildirilenArizalar { get; set; }

    [Column("bkmkb_teslim_alinma_tarihi")]
    public DateTime? BkmkbTeslimAlinmaTarihi { get; set; }

    [Column("bkmkb_teslim_edilme_tarihi")]
    public DateTime? BkmkbTeslimEdilmeTarihi { get; set; }

    [Column("bkmkb_teslim_edilme_sekli")]
    public byte? BkmkbTeslimEdilmeSekli { get; set; }

    [Column("bkmkb_ariza_kodu1")]
    [StringLength(25)]
    public string? BkmkbArizaKodu1 { get; set; }

    [Column("bkmkb_ariza_kodu2")]
    [StringLength(25)]
    public string? BkmkbArizaKodu2 { get; set; }

    [Column("bkmkb_ariza_kodu3")]
    [StringLength(25)]
    public string? BkmkbArizaKodu3 { get; set; }

    [Column("bkmkb_ariza_kodu4")]
    [StringLength(25)]
    public string? BkmkbArizaKodu4 { get; set; }

    [Column("bkmkb_ariza_kodu5")]
    [StringLength(25)]
    public string? BkmkbArizaKodu5 { get; set; }

    [Column("bkmkb_ariza_kodu6")]
    [StringLength(25)]
    public string? BkmkbArizaKodu6 { get; set; }

    [Column("bkmkb_ariza_kodu7")]
    [StringLength(25)]
    public string? BkmkbArizaKodu7 { get; set; }

    [Column("bkmkb_ariza_kodu8")]
    [StringLength(25)]
    public string? BkmkbArizaKodu8 { get; set; }

    [Column("bkmkb_ariza_kodu9")]
    [StringLength(25)]
    public string? BkmkbArizaKodu9 { get; set; }

    [Column("bkmkb_ariza_kodu10")]
    [StringLength(25)]
    public string? BkmkbArizaKodu10 { get; set; }

    [Column("bkmkb_bilgilendirme_sekli")]
    public byte? BkmkbBilgilendirmeSekli { get; set; }

    [Column("bkmkb_inceleyecek_ekip_kodu")]
    [StringLength(25)]
    public string? BkmkbInceleyecekEkipKodu { get; set; }

    [Column("bkmkb_depono")]
    public int? BkmkbDepono { get; set; }

    [Column("bkmkb_aciklama")]
    [StringLength(80)]
    public string? BkmkbAciklama { get; set; }

    [Column("bkmkb_hareket_tipi")]
    public byte? BkmkbHareketTipi { get; set; }

    [Column("bkmkb_stok_hizmet_kodu")]
    [StringLength(25)]
    public string? BkmkbStokHizmetKodu { get; set; }

    [Column("bkmkb_operasyon_suresi")]
    public int? BkmkbOperasyonSuresi { get; set; }

    [Column("bkmkb_miktari")]
    public double? BkmkbMiktari { get; set; }

    [Column("bkmkb_satir_aciklama")]
    [StringLength(50)]
    public string? BkmkbSatirAciklama { get; set; }

    [Column("bkmkb_planlandi_fl")]
    public bool? BkmkbPlanlandiFl { get; set; }

    [Column("bkmkb_adres_no")]
    public int? BkmkbAdresNo { get; set; }
}
