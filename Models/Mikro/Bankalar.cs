using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bankalar")]
public class Bankalar
{
    [Column("ban_Guid")]
    public Guid? BanGuid { get; set; }

    [Column("ban_DBCno")]
    public short? BanDBCno { get; set; }

    [Column("ban_SpecRECNo")]
    public int? BanSpecRECNo { get; set; }

    [Column("ban_iptal")]
    public bool? BanIptal { get; set; }

    [Column("ban_fileid")]
    public short? BanFileid { get; set; }

    [Column("ban_hidden")]
    public bool? BanHidden { get; set; }

    [Column("ban_kilitli")]
    public bool? BanKilitli { get; set; }

    [Column("ban_degisti")]
    public bool? BanDegisti { get; set; }

    [Column("ban_CheckSum")]
    public int? BanCheckSum { get; set; }

    [Column("ban_create_user")]
    public short? BanCreateUser { get; set; }

    [Column("ban_create_date")]
    public DateTime? BanCreateDate { get; set; }

    [Column("ban_lastup_user")]
    public short? BanLastupUser { get; set; }

    [Column("ban_lastup_date")]
    public DateTime? BanLastupDate { get; set; }

    [Column("ban_special1")]
    [StringLength(4)]
    public string? BanSpecial1 { get; set; }

    [Column("ban_special2")]
    [StringLength(4)]
    public string? BanSpecial2 { get; set; }

    [Column("ban_special3")]
    [StringLength(4)]
    public string? BanSpecial3 { get; set; }

    [Column("ban_kod")]
    [StringLength(25)]
    public string? BanKod { get; set; }

    [Column("ban_ismi")]
    [StringLength(50)]
    public string? BanIsmi { get; set; }

    [Column("ban_sube")]
    [StringLength(50)]
    public string? BanSube { get; set; }

    [Column("ban_SwiftKodu")]
    [StringLength(25)]
    public string? BanSwiftKodu { get; set; }

    [Column("ban_IBANKodu")]
    [StringLength(40)]
    public string? BanIBANKodu { get; set; }

    [Column("ban_hesapno")]
    [StringLength(30)]
    public string? BanHesapno { get; set; }

    [Column("ban_firma_no")]
    public int? BanFirmaNo { get; set; }

    [Column("ban_hesap_tip")]
    public byte? BanHesapTip { get; set; }

    [Column("ban_mevduat_tip")]
    public byte? BanMevduatTip { get; set; }

    [Column("ban_kredi_tip")]
    public byte? BanKrediTip { get; set; }

    [Column("ban_muh_kod")]
    [StringLength(40)]
    public string? BanMuhKod { get; set; }

    [Column("ban_ver_cek_muh_kod")]
    [StringLength(40)]
    public string? BanVerCekMuhKod { get; set; }

    [Column("ban_tah_cek_muh_kod")]
    [StringLength(40)]
    public string? BanTahCekMuhKod { get; set; }

    [Column("ban_tah_sen_muh_kod")]
    [StringLength(40)]
    public string? BanTahSenMuhKod { get; set; }

    [Column("ban_tem_cek_muh_kod")]
    [StringLength(40)]
    public string? BanTemCekMuhKod { get; set; }

    [Column("ban_tem_sen_muh_kod")]
    [StringLength(40)]
    public string? BanTemSenMuhKod { get; set; }

    [Column("ban_mus_krdrkart_muh_kod")]
    [StringLength(40)]
    public string? BanMusKrdrkartMuhKod { get; set; }

    [Column("ban_frm_krdrkart_muh_kod")]
    [StringLength(40)]
    public string? BanFrmKrdrkartMuhKod { get; set; }

    [Column("ban_must_havale_sozu_muh_kodu")]
    [StringLength(40)]
    public string? BanMustHavaleSozuMuhKodu { get; set; }

    [Column("ban_firma_havale_emri_muh_kodu")]
    [StringLength(40)]
    public string? BanFirmaHavaleEmriMuhKodu { get; set; }

    [Column("ban_tem_muh_kodu")]
    [StringLength(40)]
    public string? BanTemMuhKodu { get; set; }

    [Column("ban_doviz_cinsi")]
    public byte? BanDovizCinsi { get; set; }

    [Column("ban_vade_fark_yuzde")]
    public double? BanVadeFarkYuzde { get; set; }

    [Column("ban_kredi_tavan")]
    public double? BanKrediTavan { get; set; }

    [Column("ban_risk_tavan")]
    public double? BanRiskTavan { get; set; }

    [Column("ban_nakakincelenmesi")]
    public bool? BanNakakincelenmesi { get; set; }

    [Column("ban_TCMB_Kodu")]
    [StringLength(4)]
    public string? BanTCMBKodu { get; set; }

    [Column("ban_TCMB_Sube_Kodu")]
    [StringLength(8)]
    public string? BanTCMBSubeKodu { get; set; }

    [Column("ban_TCMB_Il_Kodu")]
    [StringLength(3)]
    public string? BanTCMBIlKodu { get; set; }

    [Column("ban_musteri_no")]
    [StringLength(30)]
    public string? BanMusteriNo { get; set; }

    [Column("ban_Ayni_banka_tahsil_suresi")]
    public byte? BanAyniBankaTahsilSuresi { get; set; }

    [Column("ban_baska_banka_tahsil_suresi")]
    public byte? BanBaskaBankaTahsilSuresi { get; set; }

    [Column("ban_odul_katkisi_hesap_cinsi")]
    public byte? BanOdulKatkisiHesapCinsi { get; set; }

    [Column("ban_odul_katkisi_hesabi")]
    [StringLength(25)]
    public string? BanOdulKatkisiHesabi { get; set; }

    [Column("ban_servis_komisyon_hesap_cinsi")]
    public byte? BanServisKomisyonHesapCinsi { get; set; }

    [Column("ban_servis_komisyon_hesabi")]
    [StringLength(25)]
    public string? BanServisKomisyonHesabi { get; set; }

    [Column("ban_erken_odm_faiz_hesap_cinsi")]
    public byte? BanErkenOdmFaizHesapCinsi { get; set; }

    [Column("ban_erken_odm_faiz_hesabi")]
    [StringLength(25)]
    public string? BanErkenOdmFaizHesabi { get; set; }

    [Column("ban_pos_tahsilat_cari_hesabi")]
    [StringLength(25)]
    public string? BanPosTahsilatCariHesabi { get; set; }

    [Column("ban_adr_cadde")]
    [StringLength(50)]
    public string? BanAdrCadde { get; set; }

    [Column("ban_adr_mahalle")]
    [StringLength(50)]
    public string? BanAdrMahalle { get; set; }

    [Column("ban_adr_sokak")]
    [StringLength(50)]
    public string? BanAdrSokak { get; set; }

    [Column("ban_adr_Semt")]
    [StringLength(25)]
    public string? BanAdrSemt { get; set; }

    [Column("ban_adr_Apt_No")]
    [StringLength(10)]
    public string? BanAdrAptNo { get; set; }

    [Column("ban_adr_Daire_No")]
    [StringLength(10)]
    public string? BanAdrDaireNo { get; set; }

    [Column("ban_adr_posta_kodu")]
    [StringLength(8)]
    public string? BanAdrPostaKodu { get; set; }

    [Column("ban_adr_ilce")]
    [StringLength(50)]
    public string? BanAdrIlce { get; set; }

    [Column("ban_adr_il")]
    [StringLength(50)]
    public string? BanAdrIl { get; set; }

    [Column("ban_adr_ulke")]
    [StringLength(50)]
    public string? BanAdrUlke { get; set; }

    [Column("ban_adr_adres_kodu")]
    [StringLength(10)]
    public string? BanAdrAdresKodu { get; set; }

    [Column("ban_tel_ulke_kodu")]
    [StringLength(5)]
    public string? BanTelUlkeKodu { get; set; }

    [Column("ban_tel_bolge_kodu")]
    [StringLength(5)]
    public string? BanTelBolgeKodu { get; set; }

    [Column("ban_tel_no1")]
    [StringLength(10)]
    public string? BanTelNo1 { get; set; }

    [Column("ban_tel_no2")]
    [StringLength(10)]
    public string? BanTelNo2 { get; set; }

    [Column("ban_tel_faxno")]
    [StringLength(10)]
    public string? BanTelFaxno { get; set; }

    [Column("ban_tel_modem")]
    [StringLength(10)]
    public string? BanTelModem { get; set; }

    [Column("ban_temsilci")]
    [StringLength(50)]
    public string? BanTemsilci { get; set; }

    [Column("ban_temsilci_email")]
    [StringLength(80)]
    public string? BanTemsilciEmail { get; set; }

    [Column("ban_ufrs_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsMuhKod { get; set; }

    [Column("ban_ufrs_ver_cek_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsVerCekMuhKod { get; set; }

    [Column("ban_ufrs_tah_cek_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsTahCekMuhKod { get; set; }

    [Column("ban_ufrs_tah_sen_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsTahSenMuhKod { get; set; }

    [Column("ban_ufrs_tem_cek_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsTemCekMuhKod { get; set; }

    [Column("ban_ufrs_tem_sen_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsTemSenMuhKod { get; set; }

    [Column("ban_ufrs_mus_krdrkart_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsMusKrdrkartMuhKod { get; set; }

    [Column("ban_ufrs_frm_krdrkart_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsFrmKrdrkartMuhKod { get; set; }

    [Column("ban_ufrs_must_havale_sozu_muh_kodu")]
    [StringLength(40)]
    public string? BanUfrsMustHavaleSozuMuhKodu { get; set; }

    [Column("ban_ufrs_firma_havale_emri_muh_kodu")]
    [StringLength(40)]
    public string? BanUfrsFirmaHavaleEmriMuhKodu { get; set; }

    [Column("ban_ufrs_ver_cek_sinif_muh_kod")]
    [StringLength(40)]
    public string? BanUfrsVerCekSinifMuhKod { get; set; }

    [Column("ban_ufrs_frm_hav_emri_sinif_muh_kodu")]
    [StringLength(40)]
    public string? BanUfrsFrmHavEmriSinifMuhKodu { get; set; }

    [Column("ban_ufrs_tem_muh_kodu")]
    [StringLength(40)]
    public string? BanUfrsTemMuhKodu { get; set; }
}
