using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("servis_isemirleri")]
public class ServisIsemirleri
{
    [Column("sis_Guid")]
    public Guid? SisGuid { get; set; }

    [Column("sis_DBCno")]
    public short? SisDBCno { get; set; }

    [Column("sis_SpecRECNo")]
    public int? SisSpecRECNo { get; set; }

    [Column("sis_iptal")]
    public bool? SisIptal { get; set; }

    [Column("sis_fileid")]
    public short? SisFileid { get; set; }

    [Column("sis_hidden")]
    public bool? SisHidden { get; set; }

    [Column("sis_kilitli")]
    public bool? SisKilitli { get; set; }

    [Column("sis_degisti")]
    public bool? SisDegisti { get; set; }

    [Column("sis_checksum")]
    public int? SisChecksum { get; set; }

    [Column("sis_create_user")]
    public short? SisCreateUser { get; set; }

    [Column("sis_create_date")]
    public DateTime? SisCreateDate { get; set; }

    [Column("sis_lastup_user")]
    public short? SisLastupUser { get; set; }

    [Column("sis_lastup_date")]
    public DateTime? SisLastupDate { get; set; }

    [Column("sis_special1")]
    [StringLength(4)]
    public string? SisSpecial1 { get; set; }

    [Column("sis_special2")]
    [StringLength(4)]
    public string? SisSpecial2 { get; set; }

    [Column("sis_special3")]
    [StringLength(4)]
    public string? SisSpecial3 { get; set; }

    [Column("sis_kodu")]
    [StringLength(25)]
    public string? SisKodu { get; set; }

    [Column("sis_adi")]
    [StringLength(50)]
    public string? SisAdi { get; set; }

    [Column("sis_tarih")]
    public DateTime? SisTarih { get; set; }

    [Column("sis_tuketici_kodu")]
    [StringLength(25)]
    public string? SisTuketiciKodu { get; set; }

    [Column("sis_cihaz_serino")]
    [StringLength(25)]
    public string? SisCihazSerino { get; set; }

    [Column("sis_stok_kodu")]
    [StringLength(25)]
    public string? SisStokKodu { get; set; }

    [Column("sis_servis_tarihi")]
    public DateTime? SisServisTarihi { get; set; }

    [Column("sis_servis_bitis_tarihi")]
    public DateTime? SisServisBitisTarihi { get; set; }

    [Column("sis_yetkili")]
    [StringLength(50)]
    public string? SisYetkili { get; set; }

    [Column("sis_servis_yeri")]
    public byte? SisServisYeri { get; set; }

    [Column("sis_servis_turu")]
    public byte? SisServisTuru { get; set; }

    [Column("sis_istek_gelis_sekli")]
    public byte? SisIstekGelisSekli { get; set; }

    [Column("sis_isemri_kapanis_tarihi")]
    public DateTime? SisIsemriKapanisTarihi { get; set; }

    [Column("sis_ariza_tespiti_yapan_tipi")]
    public byte? SisArizaTespitiYapanTipi { get; set; }

    [Column("sis_ariza_tespiti_yapan_ekip")]
    [StringLength(25)]
    public string? SisArizaTespitiYapanEkip { get; set; }

    [Column("sis_ise_atanan_tipi")]
    public byte? SisIseAtananTipi { get; set; }

    [Column("sis_ise_atanan_ekip")]
    [StringLength(25)]
    public string? SisIseAtananEkip { get; set; }

    [Column("sis_isi_yapan_tipi")]
    public byte? SisIsiYapanTipi { get; set; }

    [Column("sis_isi_yapan_ekip")]
    [StringLength(25)]
    public string? SisIsiYapanEkip { get; set; }

    [Column("sis_isemri_durumu")]
    public byte? SisIsemriDurumu { get; set; }

    [Column("sis_bakim_kabul_evrak_seri")]
    [StringLength(50)]
    public string? SisBakimKabulEvrakSeri { get; set; }

    [Column("sis_bakim_kabul_evrak_sira")]
    public int? SisBakimKabulEvrakSira { get; set; }

    [Column("sis_incelemede_tarihi")]
    public DateTime? SisIncelemedeTarihi { get; set; }

    [Column("sis_onay_bekliyor_tarihi")]
    public DateTime? SisOnayBekliyorTarihi { get; set; }

    [Column("sis_onaylandi_tarihi")]
    public DateTime? SisOnaylandiTarihi { get; set; }

    [Column("sis_servise_alindi_tarihi")]
    public DateTime? SisServiseAlindiTarihi { get; set; }

    [Column("sis_tamamlandi_tarihi")]
    public DateTime? SisTamamlandiTarihi { get; set; }

    [Column("sis_kapatildi_tarihi")]
    public DateTime? SisKapatildiTarihi { get; set; }

    [Column("sis_iptal_edildi_tarihi")]
    public DateTime? SisIptalEdildiTarihi { get; set; }

    [Column("sis_incelemede_aciklama")]
    [StringLength(70)]
    public string? SisIncelemedeAciklama { get; set; }

    [Column("sis_onay_bekliyor_aciklama")]
    [StringLength(70)]
    public string? SisOnayBekliyorAciklama { get; set; }

    [Column("sis_onaylandi_aciklama")]
    [StringLength(70)]
    public string? SisOnaylandiAciklama { get; set; }

    [Column("sis_servise_alindi_aciklama")]
    [StringLength(70)]
    public string? SisServiseAlindiAciklama { get; set; }

    [Column("sis_tamamlandi_aciklama")]
    [StringLength(70)]
    public string? SisTamamlandiAciklama { get; set; }

    [Column("sis_kapatildi_aciklama")]
    [StringLength(70)]
    public string? SisKapatildiAciklama { get; set; }

    [Column("sis_iptal_edildi_aciklama")]
    [StringLength(70)]
    public string? SisIptalEdildiAciklama { get; set; }

    [Column("sis_isemri_iptal_nedeni")]
    [StringLength(25)]
    public string? SisIsemriIptalNedeni { get; set; }

    [Column("sis_aciklama1")]
    [StringLength(70)]
    public string? SisAciklama1 { get; set; }

    [Column("sis_aciklama2")]
    [StringLength(70)]
    public string? SisAciklama2 { get; set; }

    [Column("sis_aciklama3")]
    [StringLength(70)]
    public string? SisAciklama3 { get; set; }

    [Column("sis_ariza_kodu1")]
    [StringLength(25)]
    public string? SisArizaKodu1 { get; set; }

    [Column("sis_ariza_kodu2")]
    [StringLength(25)]
    public string? SisArizaKodu2 { get; set; }

    [Column("sis_ariza_kodu3")]
    [StringLength(25)]
    public string? SisArizaKodu3 { get; set; }

    [Column("sis_ariza_kodu4")]
    [StringLength(25)]
    public string? SisArizaKodu4 { get; set; }

    [Column("sis_ariza_kodu5")]
    [StringLength(25)]
    public string? SisArizaKodu5 { get; set; }

    [Column("sis_ariza_kodu6")]
    [StringLength(25)]
    public string? SisArizaKodu6 { get; set; }

    [Column("sis_ariza_kodu7")]
    [StringLength(25)]
    public string? SisArizaKodu7 { get; set; }

    [Column("sis_ariza_kodu8")]
    [StringLength(25)]
    public string? SisArizaKodu8 { get; set; }

    [Column("sis_ariza_kodu9")]
    [StringLength(25)]
    public string? SisArizaKodu9 { get; set; }

    [Column("sis_ariza_kodu10")]
    [StringLength(25)]
    public string? SisArizaKodu10 { get; set; }

    [Column("sis_kiralamadan_dusulecek_sure")]
    public int? SisKiralamadanDusulecekSure { get; set; }

    [Column("sis_kiralamadan_dusulen_sure")]
    public int? SisKiralamadanDusulenSure { get; set; }

    [Column("sis_servis_islem_turu")]
    public byte? SisServisIslemTuru { get; set; }

    [Column("sis_kaynak_evrak_tipi")]
    public byte? SisKaynakEvrakTipi { get; set; }

    [Column("sis_ktlp_uid")]
    public Guid? SisKtlpUid { get; set; }

    [Column("sis_adres_no")]
    public int? SisAdresNo { get; set; }
}
