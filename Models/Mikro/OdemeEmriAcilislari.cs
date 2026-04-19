using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("odeme_emri_acilislari")]
public class OdemeEmriAcilislari
{
    [Column("sca_Guid")]
    public Guid? ScaGuid { get; set; }

    [Column("sca_DBCno")]
    public short? ScaDBCno { get; set; }

    [Column("sca_SpecRecNo")]
    public int? ScaSpecRecNo { get; set; }

    [Column("sca_iptal")]
    public bool? ScaIptal { get; set; }

    [Column("sca_fileid")]
    public short? ScaFileid { get; set; }

    [Column("sca_hidden")]
    public bool? ScaHidden { get; set; }

    [Column("sca_kilitli")]
    public bool? ScaKilitli { get; set; }

    [Column("sca_degisti")]
    public bool? ScaDegisti { get; set; }

    [Column("sca_CheckSum")]
    public int? ScaCheckSum { get; set; }

    [Column("sca_create_user")]
    public short? ScaCreateUser { get; set; }

    [Column("sca_create_date")]
    public DateTime? ScaCreateDate { get; set; }

    [Column("sca_lastup_user")]
    public short? ScaLastupUser { get; set; }

    [Column("sca_lastup_date")]
    public DateTime? ScaLastupDate { get; set; }

    [Column("sca_special1")]
    [StringLength(4)]
    public string? ScaSpecial1 { get; set; }

    [Column("sca_special2")]
    [StringLength(4)]
    public string? ScaSpecial2 { get; set; }

    [Column("sca_special3")]
    [StringLength(4)]
    public string? ScaSpecial3 { get; set; }

    [Column("sca_firmano")]
    public int? ScaFirmano { get; set; }

    [Column("sca_subeno")]
    public int? ScaSubeno { get; set; }

    [Column("sca_evrak_tip")]
    public byte? ScaEvrakTip { get; set; }

    [Column("sca_evrakno_seri")]
    [StringLength(50)]
    public string? ScaEvraknoSeri { get; set; }

    [Column("sca_evrakno_sira")]
    public int? ScaEvraknoSira { get; set; }

    [Column("sca_satir_no")]
    public int? ScaSatirNo { get; set; }

    [Column("sca_tarihi")]
    public DateTime? ScaTarihi { get; set; }

    [Column("sca_tip")]
    public byte? ScaTip { get; set; }

    [Column("sca_cinsi")]
    public byte? ScaCinsi { get; set; }

    [Column("sca_normal_Iade")]
    public byte? ScaNormalIade { get; set; }

    [Column("sca_tpoz")]
    public byte? ScaTpoz { get; set; }

    [Column("sca_ticaret_turu")]
    public byte? ScaTicaretTuru { get; set; }

    [Column("sca_belge_no")]
    [StringLength(50)]
    public string? ScaBelgeNo { get; set; }

    [Column("sca_belge_tarih")]
    public DateTime? ScaBelgeTarih { get; set; }

    [Column("sca_aciklama")]
    [StringLength(40)]
    public string? ScaAciklama { get; set; }

    [Column("sca_satici_kodu")]
    [StringLength(25)]
    public string? ScaSaticiKodu { get; set; }

    [Column("sca_EXIMkodu")]
    [StringLength(25)]
    public string? ScaEXIMkodu { get; set; }

    [Column("sca_projekodu")]
    [StringLength(25)]
    public string? ScaProjekodu { get; set; }

    [Column("sca_yat_tes_kodu")]
    [StringLength(25)]
    public string? ScaYatTesKodu { get; set; }

    [Column("sca_cari_cins")]
    public byte? ScaCariCins { get; set; }

    [Column("sca_kod")]
    [StringLength(25)]
    public string? ScaKod { get; set; }

    [Column("sca_ciro_cari_kodu")]
    [StringLength(25)]
    public string? ScaCiroCariKodu { get; set; }

    [Column("sca_d_cins")]
    public byte? ScaDCins { get; set; }

    [Column("sca_d_kur")]
    public double? ScaDKur { get; set; }

    [Column("sca_altd_kur")]
    public double? ScaAltdKur { get; set; }

    [Column("sca_grupno")]
    public byte? ScaGrupno { get; set; }

    [Column("sca_srmrkkodu")]
    [StringLength(25)]
    public string? ScaSrmrkkodu { get; set; }

    [Column("sca_kasa_hizmet")]
    public byte? ScaKasaHizmet { get; set; }

    [Column("sca_kasa_hizkod")]
    [StringLength(25)]
    public string? ScaKasaHizkod { get; set; }

    [Column("sca_karsidcinsi")]
    public byte? ScaKarsidcinsi { get; set; }

    [Column("sca_karsid_kur")]
    public double? ScaKarsidKur { get; set; }

    [Column("sca_karsidgrupno")]
    public byte? ScaKarsidgrupno { get; set; }

    [Column("sca_karsisrmrkkodu")]
    [StringLength(25)]
    public string? ScaKarsisrmrkkodu { get; set; }

    [Column("sca_miktari")]
    public double? ScaMiktari { get; set; }

    [Column("sca_meblag")]
    public double? ScaMeblag { get; set; }

    [Column("sca_aratoplam")]
    public double? ScaAratoplam { get; set; }

    [Column("sca_vade")]
    public int? ScaVade { get; set; }

    [Column("sca_Vade_Farki_Yuz")]
    public double? ScaVadeFarkiYuz { get; set; }

    [Column("sca_ft_iskonto1")]
    public double? ScaFtIskonto1 { get; set; }

    [Column("sca_ft_iskonto2")]
    public double? ScaFtIskonto2 { get; set; }

    [Column("sca_ft_iskonto3")]
    public double? ScaFtIskonto3 { get; set; }

    [Column("sca_ft_iskonto4")]
    public double? ScaFtIskonto4 { get; set; }

    [Column("sca_ft_iskonto5")]
    public double? ScaFtIskonto5 { get; set; }

    [Column("sca_ft_iskonto6")]
    public double? ScaFtIskonto6 { get; set; }

    [Column("sca_ft_masraf1")]
    public double? ScaFtMasraf1 { get; set; }

    [Column("sca_ft_masraf2")]
    public double? ScaFtMasraf2 { get; set; }

    [Column("sca_ft_masraf3")]
    public double? ScaFtMasraf3 { get; set; }

    [Column("sca_ft_masraf4")]
    public double? ScaFtMasraf4 { get; set; }

    [Column("sca_isk_mas1")]
    public byte? ScaIskMas1 { get; set; }

    [Column("sca_isk_mas2")]
    public byte? ScaIskMas2 { get; set; }

    [Column("sca_isk_mas3")]
    public byte? ScaIskMas3 { get; set; }

    [Column("sca_isk_mas4")]
    public byte? ScaIskMas4 { get; set; }

    [Column("sca_isk_mas5")]
    public byte? ScaIskMas5 { get; set; }

    [Column("sca_isk_mas6")]
    public byte? ScaIskMas6 { get; set; }

    [Column("sca_isk_mas7")]
    public byte? ScaIskMas7 { get; set; }

    [Column("sca_isk_mas8")]
    public byte? ScaIskMas8 { get; set; }

    [Column("sca_isk_mas9")]
    public byte? ScaIskMas9 { get; set; }

    [Column("sca_isk_mas10")]
    public byte? ScaIskMas10 { get; set; }

    [Column("sca_sat_iskmas1")]
    public bool? ScaSatIskmas1 { get; set; }

    [Column("sca_sat_iskmas2")]
    public bool? ScaSatIskmas2 { get; set; }

    [Column("sca_sat_iskmas3")]
    public bool? ScaSatIskmas3 { get; set; }

    [Column("sca_sat_iskmas4")]
    public bool? ScaSatIskmas4 { get; set; }

    [Column("sca_sat_iskmas5")]
    public bool? ScaSatIskmas5 { get; set; }

    [Column("sca_sat_iskmas6")]
    public bool? ScaSatIskmas6 { get; set; }

    [Column("sca_sat_iskmas7")]
    public bool? ScaSatIskmas7 { get; set; }

    [Column("sca_sat_iskmas8")]
    public bool? ScaSatIskmas8 { get; set; }

    [Column("sca_sat_iskmas9")]
    public bool? ScaSatIskmas9 { get; set; }

    [Column("sca_sat_iskmas10")]
    public bool? ScaSatIskmas10 { get; set; }

    [Column("sca_yuvarlama")]
    public double? ScaYuvarlama { get; set; }

    [Column("sca_StFonPntr")]
    public byte? ScaStFonPntr { get; set; }

    [Column("sca_stopaj")]
    public double? ScaStopaj { get; set; }

    [Column("sca_savsandesfonu")]
    public double? ScaSavsandesfonu { get; set; }

    [Column("sca_avansmak_damgapul")]
    public double? ScaAvansmakDamgapul { get; set; }

    [Column("sca_vergipntr")]
    public byte? ScaVergipntr { get; set; }

    [Column("sca_vergi1")]
    public double? ScaVergi1 { get; set; }

    [Column("sca_vergi2")]
    public double? ScaVergi2 { get; set; }

    [Column("sca_vergi3")]
    public double? ScaVergi3 { get; set; }

    [Column("sca_vergi4")]
    public double? ScaVergi4 { get; set; }

    [Column("sca_vergi5")]
    public double? ScaVergi5 { get; set; }

    [Column("sca_vergi6")]
    public double? ScaVergi6 { get; set; }

    [Column("sca_vergi7")]
    public double? ScaVergi7 { get; set; }

    [Column("sca_vergi8")]
    public double? ScaVergi8 { get; set; }

    [Column("sca_vergi9")]
    public double? ScaVergi9 { get; set; }

    [Column("sca_vergi10")]
    public double? ScaVergi10 { get; set; }

    [Column("sca_vergisiz_fl")]
    public bool? ScaVergisizFl { get; set; }

    [Column("sca_otvtutari")]
    public double? ScaOtvtutari { get; set; }

    [Column("sca_otvvergisiz_fl")]
    public bool? ScaOtvvergisizFl { get; set; }

    [Column("sca_oiv_pntr")]
    public byte? ScaOivPntr { get; set; }

    [Column("sca_oivtutari")]
    public double? ScaOivtutari { get; set; }

    [Column("sca_oiv_vergi")]
    public double? ScaOivVergi { get; set; }

    [Column("sca_oivvergisiz_fl")]
    public bool? ScaOivvergisizFl { get; set; }

    [Column("sca_fis_tarih")]
    public DateTime? ScaFisTarih { get; set; }

    [Column("sca_fis_sirano")]
    public int? ScaFisSirano { get; set; }

    [Column("sca_trefno")]
    [StringLength(25)]
    public string? ScaTrefno { get; set; }

    [Column("sca_sntck_poz")]
    public byte? ScaSntckPoz { get; set; }

    [Column("sca_reftarihi")]
    public DateTime? ScaReftarihi { get; set; }

    [Column("sca_istisnakodu")]
    public byte? ScaIstisnakodu { get; set; }

    [Column("sca_pos_hareketi")]
    public bool? ScaPosHareketi { get; set; }

    [Column("sca_meblag_ana_doviz_icin_gecersiz_fl")]
    public byte? ScaMeblagAnaDovizIcinGecersizFl { get; set; }

    [Column("sca_meblag_alt_doviz_icin_gecersiz_fl")]
    public byte? ScaMeblagAltDovizIcinGecersizFl { get; set; }

    [Column("sca_meblag_orj_doviz_icin_gecersiz_fl")]
    public byte? ScaMeblagOrjDovizIcinGecersizFl { get; set; }

    [Column("sca_sip_uid")]
    public Guid? ScaSipUid { get; set; }

    [Column("sca_kirahar_uid")]
    public Guid? ScaKiraharUid { get; set; }

    [Column("sca_vardiya_tarihi")]
    public DateTime? ScaVardiyaTarihi { get; set; }

    [Column("sca_vardiya_no")]
    public byte? ScaVardiyaNo { get; set; }

    [Column("sca_vardiya_evrak_ti")]
    public byte? ScaVardiyaEvrakTi { get; set; }

    [Column("sca_ebelge_cinsi")]
    public byte? ScaEbelgeCinsi { get; set; }

    [Column("sca_tevkifat_toplam")]
    public double? ScaTevkifatToplam { get; set; }

    [Column("sca_ilave_edilecek_kdv1")]
    public double? ScaIlaveEdilecekKdv1 { get; set; }

    [Column("sca_ilave_edilecek_kdv2")]
    public double? ScaIlaveEdilecekKdv2 { get; set; }

    [Column("sca_ilave_edilecek_kdv3")]
    public double? ScaIlaveEdilecekKdv3 { get; set; }

    [Column("sca_ilave_edilecek_kdv4")]
    public double? ScaIlaveEdilecekKdv4 { get; set; }

    [Column("sca_ilave_edilecek_kdv5")]
    public double? ScaIlaveEdilecekKdv5 { get; set; }

    [Column("sca_ilave_edilecek_kdv6")]
    public double? ScaIlaveEdilecekKdv6 { get; set; }

    [Column("sca_ilave_edilecek_kdv7")]
    public double? ScaIlaveEdilecekKdv7 { get; set; }

    [Column("sca_ilave_edilecek_kdv8")]
    public double? ScaIlaveEdilecekKdv8 { get; set; }

    [Column("sca_ilave_edilecek_kdv9")]
    public double? ScaIlaveEdilecekKdv9 { get; set; }

    [Column("sca_ilave_edilecek_kdv10")]
    public double? ScaIlaveEdilecekKdv10 { get; set; }

    [Column("sca_e_islem_turu")]
    public byte? ScaEIslemTuru { get; set; }

    [Column("sca_fatura_belge_turu")]
    public byte? ScaFaturaBelgeTuru { get; set; }

    [Column("sca_diger_belge_adi")]
    [StringLength(50)]
    public string? ScaDigerBelgeAdi { get; set; }

    [Column("sca_uuid")]
    [StringLength(40)]
    public string? ScaUuid { get; set; }

    [Column("sca_adres_no")]
    public int? ScaAdresNo { get; set; }

    [Column("sca_vergifon_toplam")]
    public double? ScaVergifonToplam { get; set; }

    [Column("sca_ilk_belge_tarihi")]
    public DateTime? ScaIlkBelgeTarihi { get; set; }

    [Column("sca_ilk_belge_doviz_kuru")]
    public double? ScaIlkBelgeDovizKuru { get; set; }
}
