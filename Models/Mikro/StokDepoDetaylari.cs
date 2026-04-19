using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_depo_detaylari")]
public class StokDepoDetaylari
{
    [Column("sdp_Guid")]
    public Guid SdpGuid { get; set; }

    [Column("sdp_DBCno")]
    public short? SdpDBCno { get; set; }

    [Column("sdp_SpecRECno")]
    public int? SdpSpecRECno { get; set; }

    [Column("sdp_iptal")]
    public bool? SdpIptal { get; set; }

    [Column("sdp_fileid")]
    public short? SdpFileid { get; set; }

    [Column("sdp_hidden")]
    public bool? SdpHidden { get; set; }

    [Column("sdp_kilitli")]
    public bool? SdpKilitli { get; set; }

    [Column("sdp_degisti")]
    public bool? SdpDegisti { get; set; }

    [Column("sdp_checksum")]
    public int? SdpChecksum { get; set; }

    [Column("sdp_create_user")]
    public short? SdpCreateUser { get; set; }

    [Column("sdp_create_date")]
    public DateTime? SdpCreateDate { get; set; }

    [Column("sdp_lastup_user")]
    public short? SdpLastupUser { get; set; }

    [Column("sdp_lastup_date")]
    public DateTime? SdpLastupDate { get; set; }

    [Column("sdp_special1")]
    [StringLength(4)]
    public string? SdpSpecial1 { get; set; }

    [Column("sdp_special2")]
    [StringLength(4)]
    public string? SdpSpecial2 { get; set; }

    [Column("sdp_special3")]
    [StringLength(4)]
    public string? SdpSpecial3 { get; set; }

    [Column("sdp_depo_kod")]
    [StringLength(25)]
    public string? SdpDepoKod { get; set; }

    [Column("sdp_depo_no")]
    public byte? SdpDepoNo { get; set; }

    [Column("sdp_kar_orani")]
    public double? SdpKarOrani { get; set; }

    [Column("sdp_min_stok")]
    public double? SdpMinStok { get; set; }

    [Column("sdp_sip_stok")]
    public double? SdpSipStok { get; set; }

    [Column("sdp_max_stok")]
    public double? SdpMaxStok { get; set; }

    [Column("sdp_ver_sipbirimpntr")]
    public byte? SdpVerSipbirimpntr { get; set; }

    [Column("sdp_al_sipbirimpntr")]
    public byte? SdpAlSipbirimpntr { get; set; }

    [Column("sdp_sipsure")]
    public short? SdpSipsure { get; set; }

    [Column("sdp_yerkodu")]
    [StringLength(10)]
    public string? SdpYerkodu { get; set; }

    [Column("sdp_satisdursun")]
    public byte? SdpSatisdursun { get; set; }

    [Column("sdp_sipdursun")]
    public byte? SdpSipdursun { get; set; }

    [Column("sdp_malkabuldursun")]
    public byte? SdpMalkabuldursun { get; set; }

    [Column("sdp_MalKabulGun1")]
    public bool? SdpMalKabulGun1 { get; set; }

    [Column("sdp_MalKabulGun2")]
    public bool? SdpMalKabulGun2 { get; set; }

    [Column("sdp_MalKabulGun3")]
    public bool? SdpMalKabulGun3 { get; set; }

    [Column("sdp_MalKabulGun4")]
    public bool? SdpMalKabulGun4 { get; set; }

    [Column("sdp_MalKabulGun5")]
    public bool? SdpMalKabulGun5 { get; set; }

    [Column("sdp_MalKabulGun6")]
    public bool? SdpMalKabulGun6 { get; set; }

    [Column("sdp_MalKabulGun7")]
    public bool? SdpMalKabulGun7 { get; set; }

    [Column("sdp_siparisGun1")]
    public bool? SdpSiparisGun1 { get; set; }

    [Column("sdp_siparisGun2")]
    public bool? SdpSiparisGun2 { get; set; }

    [Column("sdp_siparisGun3")]
    public bool? SdpSiparisGun3 { get; set; }

    [Column("sdp_siparisGun4")]
    public bool? SdpSiparisGun4 { get; set; }

    [Column("sdp_siparisGun5")]
    public bool? SdpSiparisGun5 { get; set; }

    [Column("sdp_siparisGun6")]
    public bool? SdpSiparisGun6 { get; set; }

    [Column("sdp_siparisGun7")]
    public bool? SdpSiparisGun7 { get; set; }

    [Column("sdp_IskontoYapilamaz")]
    public bool? SdpIskontoYapilamaz { get; set; }

    [Column("sdp_Tasfiyede_Fl")]
    public bool? SdpTasfiyedeFl { get; set; }

    [Column("sdp_Pasif_fl")]
    public bool? SdpPasifFl { get; set; }

    [Column("sdp_sat_cari_kod")]
    [StringLength(25)]
    public string? SdpSatCariKod { get; set; }

    [Column("sdpKasaIskontoOrani")]
    public double? SdpKasaIskontoOrani { get; set; }

    [Column("sdpKasaIskontoTutari")]
    public double? SdpKasaIskontoTutari { get; set; }

    [Column("sdp_eksiyedusebilir_fl")]
    public bool? SdpEksiyedusebilirFl { get; set; }

    [Column("sdp_UrunSorumlusuKodu")]
    [StringLength(25)]
    public string? SdpUrunSorumlusuKodu { get; set; }

    [Column("sdp_KasadaTaksitlenebilir_fl")]
    public bool? SdpKasadaTaksitlenebilirFl { get; set; }

    [Column("sdp_siparisyeri")]
    public byte? SdpSiparisyeri { get; set; }

    [Column("sdp_muhkod_artikeli")]
    [StringLength(10)]
    public string? SdpMuhkodArtikeli { get; set; }

    [Column("sdp_pozisyonbayrak_kodu")]
    [StringLength(25)]
    public string? SdpPozisyonbayrakKodu { get; set; }

    [Column("sdp_min_stok_belirleme_gun")]
    public short? SdpMinStokBelirlemeGun { get; set; }

    [Column("sdp_sip_stok_belirleme_gun")]
    public short? SdpSipStokBelirlemeGun { get; set; }

    [Column("sdp_max_stok_belirleme_gun")]
    public short? SdpMaxStokBelirlemeGun { get; set; }

    [Column("sdp_sev_bel_opr_degerlendime_fl")]
    public bool? SdpSevBelOprDegerlendimeFl { get; set; }
}
