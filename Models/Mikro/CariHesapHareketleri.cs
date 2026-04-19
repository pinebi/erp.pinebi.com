using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_hareketleri")]
public class CariHesapHareketleri
{
    [Column("cha_Guid")]
    public Guid? ChaGuid { get; set; }

    [Column("cha_DBCno")]
    public short? ChaDBCno { get; set; }

    [Column("cha_SpecRecNo")]
    public int? ChaSpecRecNo { get; set; }

    [Column("cha_iptal")]
    public bool? ChaIptal { get; set; }

    [Column("cha_fileid")]
    public short? ChaFileid { get; set; }

    [Column("cha_hidden")]
    public bool? ChaHidden { get; set; }

    [Column("cha_kilitli")]
    public bool? ChaKilitli { get; set; }

    [Column("cha_degisti")]
    public bool? ChaDegisti { get; set; }

    [Column("cha_CheckSum")]
    public int? ChaCheckSum { get; set; }

    [Column("cha_create_user")]
    public short? ChaCreateUser { get; set; }

    [Column("cha_create_date")]
    public DateTime? ChaCreateDate { get; set; }

    [Column("cha_lastup_user")]
    public short? ChaLastupUser { get; set; }

    [Column("cha_lastup_date")]
    public DateTime? ChaLastupDate { get; set; }

    [Column("cha_special1")]
    [StringLength(4)]
    public string? ChaSpecial1 { get; set; }

    [Column("cha_special2")]
    [StringLength(4)]
    public string? ChaSpecial2 { get; set; }

    [Column("cha_special3")]
    [StringLength(4)]
    public string? ChaSpecial3 { get; set; }

    [Column("cha_firmano")]
    public int? ChaFirmano { get; set; }

    [Column("cha_subeno")]
    public int? ChaSubeno { get; set; }

    [Column("cha_evrak_tip")]
    public byte? ChaEvrakTip { get; set; }

    [Column("cha_evrakno_seri")]
    [StringLength(50)]
    public string? ChaEvraknoSeri { get; set; }

    [Column("cha_evrakno_sira")]
    public int? ChaEvraknoSira { get; set; }

    [Column("cha_satir_no")]
    public int? ChaSatirNo { get; set; }

    [Column("cha_tarihi")]
    public DateTime? ChaTarihi { get; set; }

    [Column("cha_tip")]
    public byte? ChaTip { get; set; }

    [Column("cha_cinsi")]
    public byte? ChaCinsi { get; set; }

    [Column("cha_normal_Iade")]
    public byte? ChaNormalIade { get; set; }

    [Column("cha_tpoz")]
    public byte? ChaTpoz { get; set; }

    [Column("cha_ticaret_turu")]
    public byte? ChaTicaretTuru { get; set; }

    [Column("cha_belge_no")]
    [StringLength(50)]
    public string? ChaBelgeNo { get; set; }

    [Column("cha_belge_tarih")]
    public DateTime? ChaBelgeTarih { get; set; }

    [Column("cha_aciklama")]
    [StringLength(40)]
    public string? ChaAciklama { get; set; }

    [Column("cha_satici_kodu")]
    [StringLength(25)]
    public string? ChaSaticiKodu { get; set; }

    [Column("cha_EXIMkodu")]
    [StringLength(25)]
    public string? ChaEXIMkodu { get; set; }

    [Column("cha_projekodu")]
    [StringLength(25)]
    public string? ChaProjekodu { get; set; }

    [Column("cha_yat_tes_kodu")]
    [StringLength(25)]
    public string? ChaYatTesKodu { get; set; }

    [Column("cha_cari_cins")]
    public byte? ChaCariCins { get; set; }

    [Column("cha_kod")]
    [StringLength(25)]
    public string? ChaKod { get; set; }

    [Column("cha_ciro_cari_kodu")]
    [StringLength(25)]
    public string? ChaCiroCariKodu { get; set; }

    [Column("cha_d_cins")]
    public byte? ChaDCins { get; set; }

    [Column("cha_d_kur")]
    public double? ChaDKur { get; set; }

    [Column("cha_altd_kur")]
    public double? ChaAltdKur { get; set; }

    [Column("cha_grupno")]
    public byte? ChaGrupno { get; set; }

    [Column("cha_srmrkkodu")]
    [StringLength(25)]
    public string? ChaSrmrkkodu { get; set; }

    [Column("cha_kasa_hizmet")]
    public byte? ChaKasaHizmet { get; set; }

    [Column("cha_kasa_hizkod")]
    [StringLength(25)]
    public string? ChaKasaHizkod { get; set; }

    [Column("cha_karsidcinsi")]
    public byte? ChaKarsidcinsi { get; set; }

    [Column("cha_karsid_kur")]
    public double? ChaKarsidKur { get; set; }

    [Column("cha_karsidgrupno")]
    public byte? ChaKarsidgrupno { get; set; }

    [Column("cha_karsisrmrkkodu")]
    [StringLength(25)]
    public string? ChaKarsisrmrkkodu { get; set; }

    [Column("cha_miktari")]
    public double? ChaMiktari { get; set; }

    [Column("cha_meblag")]
    public double? ChaMeblag { get; set; }

    [Column("cha_aratoplam")]
    public double? ChaAratoplam { get; set; }

    [Column("cha_vade")]
    public int? ChaVade { get; set; }

    [Column("cha_Vade_Farki_Yuz")]
    public double? ChaVadeFarkiYuz { get; set; }

    [Column("cha_ft_iskonto1")]
    public double? ChaFtIskonto1 { get; set; }

    [Column("cha_ft_iskonto2")]
    public double? ChaFtIskonto2 { get; set; }

    [Column("cha_ft_iskonto3")]
    public double? ChaFtIskonto3 { get; set; }

    [Column("cha_ft_iskonto4")]
    public double? ChaFtIskonto4 { get; set; }

    [Column("cha_ft_iskonto5")]
    public double? ChaFtIskonto5 { get; set; }

    [Column("cha_ft_iskonto6")]
    public double? ChaFtIskonto6 { get; set; }

    [Column("cha_ft_masraf1")]
    public double? ChaFtMasraf1 { get; set; }

    [Column("cha_ft_masraf2")]
    public double? ChaFtMasraf2 { get; set; }

    [Column("cha_ft_masraf3")]
    public double? ChaFtMasraf3 { get; set; }

    [Column("cha_ft_masraf4")]
    public double? ChaFtMasraf4 { get; set; }

    [Column("cha_isk_mas1")]
    public byte? ChaIskMas1 { get; set; }

    [Column("cha_isk_mas2")]
    public byte? ChaIskMas2 { get; set; }

    [Column("cha_isk_mas3")]
    public byte? ChaIskMas3 { get; set; }

    [Column("cha_isk_mas4")]
    public byte? ChaIskMas4 { get; set; }

    [Column("cha_isk_mas5")]
    public byte? ChaIskMas5 { get; set; }

    [Column("cha_isk_mas6")]
    public byte? ChaIskMas6 { get; set; }

    [Column("cha_isk_mas7")]
    public byte? ChaIskMas7 { get; set; }

    [Column("cha_isk_mas8")]
    public byte? ChaIskMas8 { get; set; }

    [Column("cha_isk_mas9")]
    public byte? ChaIskMas9 { get; set; }

    [Column("cha_isk_mas10")]
    public byte? ChaIskMas10 { get; set; }

    [Column("cha_sat_iskmas1")]
    public bool? ChaSatIskmas1 { get; set; }

    [Column("cha_sat_iskmas2")]
    public bool? ChaSatIskmas2 { get; set; }

    [Column("cha_sat_iskmas3")]
    public bool? ChaSatIskmas3 { get; set; }

    [Column("cha_sat_iskmas4")]
    public bool? ChaSatIskmas4 { get; set; }

    [Column("cha_sat_iskmas5")]
    public bool? ChaSatIskmas5 { get; set; }

    [Column("cha_sat_iskmas6")]
    public bool? ChaSatIskmas6 { get; set; }

    [Column("cha_sat_iskmas7")]
    public bool? ChaSatIskmas7 { get; set; }

    [Column("cha_sat_iskmas8")]
    public bool? ChaSatIskmas8 { get; set; }

    [Column("cha_sat_iskmas9")]
    public bool? ChaSatIskmas9 { get; set; }

    [Column("cha_sat_iskmas10")]
    public bool? ChaSatIskmas10 { get; set; }

    [Column("cha_yuvarlama")]
    public double? ChaYuvarlama { get; set; }

    [Column("cha_StFonPntr")]
    public byte? ChaStFonPntr { get; set; }

    [Column("cha_stopaj")]
    public double? ChaStopaj { get; set; }

    [Column("cha_savsandesfonu")]
    public double? ChaSavsandesfonu { get; set; }

    [Column("cha_avansmak_damgapul")]
    public double? ChaAvansmakDamgapul { get; set; }

    [Column("cha_vergipntr")]
    public byte? ChaVergipntr { get; set; }

    [Column("cha_vergi1")]
    public double? ChaVergi1 { get; set; }

    [Column("cha_vergi2")]
    public double? ChaVergi2 { get; set; }

    [Column("cha_vergi3")]
    public double? ChaVergi3 { get; set; }

    [Column("cha_vergi4")]
    public double? ChaVergi4 { get; set; }

    [Column("cha_vergi5")]
    public double? ChaVergi5 { get; set; }

    [Column("cha_vergi6")]
    public double? ChaVergi6 { get; set; }

    [Column("cha_vergi7")]
    public double? ChaVergi7 { get; set; }

    [Column("cha_vergi8")]
    public double? ChaVergi8 { get; set; }

    [Column("cha_vergi9")]
    public double? ChaVergi9 { get; set; }

    [Column("cha_vergi10")]
    public double? ChaVergi10 { get; set; }

    [Column("cha_vergisiz_fl")]
    public bool? ChaVergisizFl { get; set; }

    [Column("cha_otvtutari")]
    public double? ChaOtvtutari { get; set; }

    [Column("cha_otvvergisiz_fl")]
    public bool? ChaOtvvergisizFl { get; set; }

    [Column("cha_oiv_pntr")]
    public byte? ChaOivPntr { get; set; }

    [Column("cha_oivtutari")]
    public double? ChaOivtutari { get; set; }

    [Column("cha_oiv_vergi")]
    public double? ChaOivVergi { get; set; }

    [Column("cha_oivvergisiz_fl")]
    public bool? ChaOivvergisizFl { get; set; }

    [Column("cha_fis_tarih")]
    public DateTime? ChaFisTarih { get; set; }

    [Column("cha_fis_sirano")]
    public int? ChaFisSirano { get; set; }

    [Column("cha_trefno")]
    [StringLength(25)]
    public string? ChaTrefno { get; set; }

    [Column("cha_sntck_poz")]
    public byte? ChaSntckPoz { get; set; }

    [Column("cha_reftarihi")]
    public DateTime? ChaReftarihi { get; set; }

    [Column("cha_istisnakodu")]
    public byte? ChaIstisnakodu { get; set; }

    [Column("cha_pos_hareketi")]
    public bool? ChaPosHareketi { get; set; }

    [Column("cha_meblag_ana_doviz_icin_gecersiz_fl")]
    public byte? ChaMeblagAnaDovizIcinGecersizFl { get; set; }

    [Column("cha_meblag_alt_doviz_icin_gecersiz_fl")]
    public byte? ChaMeblagAltDovizIcinGecersizFl { get; set; }

    [Column("cha_meblag_orj_doviz_icin_gecersiz_fl")]
    public byte? ChaMeblagOrjDovizIcinGecersizFl { get; set; }

    [Column("cha_sip_uid")]
    public Guid? ChaSipUid { get; set; }

    [Column("cha_kirahar_uid")]
    public Guid? ChaKiraharUid { get; set; }

    [Column("cha_vardiya_tarihi")]
    public DateTime? ChaVardiyaTarihi { get; set; }

    [Column("cha_vardiya_no")]
    public byte? ChaVardiyaNo { get; set; }

    [Column("cha_vardiya_evrak_ti")]
    public byte? ChaVardiyaEvrakTi { get; set; }

    [Column("cha_ebelge_cinsi")]
    public byte? ChaEbelgeCinsi { get; set; }

    [Column("cha_tevkifat_toplam")]
    public double? ChaTevkifatToplam { get; set; }

    [Column("cha_ilave_edilecek_kdv1")]
    public double? ChaIlaveEdilecekKdv1 { get; set; }

    [Column("cha_ilave_edilecek_kdv2")]
    public double? ChaIlaveEdilecekKdv2 { get; set; }

    [Column("cha_ilave_edilecek_kdv3")]
    public double? ChaIlaveEdilecekKdv3 { get; set; }

    [Column("cha_ilave_edilecek_kdv4")]
    public double? ChaIlaveEdilecekKdv4 { get; set; }

    [Column("cha_ilave_edilecek_kdv5")]
    public double? ChaIlaveEdilecekKdv5 { get; set; }

    [Column("cha_ilave_edilecek_kdv6")]
    public double? ChaIlaveEdilecekKdv6 { get; set; }

    [Column("cha_ilave_edilecek_kdv7")]
    public double? ChaIlaveEdilecekKdv7 { get; set; }

    [Column("cha_ilave_edilecek_kdv8")]
    public double? ChaIlaveEdilecekKdv8 { get; set; }

    [Column("cha_ilave_edilecek_kdv9")]
    public double? ChaIlaveEdilecekKdv9 { get; set; }

    [Column("cha_ilave_edilecek_kdv10")]
    public double? ChaIlaveEdilecekKdv10 { get; set; }

    [Column("cha_e_islem_turu")]
    public byte? ChaEIslemTuru { get; set; }

    [Column("cha_fatura_belge_turu")]
    public byte? ChaFaturaBelgeTuru { get; set; }

    [Column("cha_diger_belge_adi")]
    [StringLength(50)]
    public string? ChaDigerBelgeAdi { get; set; }

    [Column("cha_uuid")]
    [StringLength(40)]
    public string? ChaUuid { get; set; }

    [Column("cha_adres_no")]
    public int? ChaAdresNo { get; set; }

    [Column("cha_vergifon_toplam")]
    public double? ChaVergifonToplam { get; set; }

    [Column("cha_ilk_belge_tarihi")]
    public DateTime? ChaIlkBelgeTarihi { get; set; }

    [Column("cha_ilk_belge_doviz_kuru")]
    public double? ChaIlkBelgeDovizKuru { get; set; }
}
