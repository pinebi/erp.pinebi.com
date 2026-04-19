using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("proforma_fiyat_degisiklikleri")]
public class ProformaFiyatDegisiklikleri
{
    [Column("prfd_Guid")]
    public Guid? PrfdGuid { get; set; }

    [Column("prfd_DBCno")]
    public short? PrfdDBCno { get; set; }

    [Column("prfd_SpecRecNo")]
    public int? PrfdSpecRecNo { get; set; }

    [Column("prfd_iptal")]
    public bool? PrfdIptal { get; set; }

    [Column("prfd_fileid")]
    public short? PrfdFileid { get; set; }

    [Column("prfd_hidden")]
    public bool? PrfdHidden { get; set; }

    [Column("prfd_kilitli")]
    public bool? PrfdKilitli { get; set; }

    [Column("prfd_degisti")]
    public bool? PrfdDegisti { get; set; }

    [Column("prfd_checksum")]
    public int? PrfdChecksum { get; set; }

    [Column("prfd_create_user")]
    public short? PrfdCreateUser { get; set; }

    [Column("prfd_create_date")]
    public DateTime? PrfdCreateDate { get; set; }

    [Column("prfd_lastup_user")]
    public short? PrfdLastupUser { get; set; }

    [Column("prfd_lastup_date")]
    public DateTime? PrfdLastupDate { get; set; }

    [Column("prfd_special1")]
    [StringLength(4)]
    public string? PrfdSpecial1 { get; set; }

    [Column("prfd_special2")]
    [StringLength(4)]
    public string? PrfdSpecial2 { get; set; }

    [Column("prfd_special3")]
    [StringLength(4)]
    public string? PrfdSpecial3 { get; set; }

    [Column("prfd_evrak_satir_no")]
    public int? PrfdEvrakSatirNo { get; set; }

    [Column("prfd_evrak_seri_no")]
    [StringLength(50)]
    public string? PrfdEvrakSeriNo { get; set; }

    [Column("prfd_evrak_sira_no")]
    public int? PrfdEvrakSiraNo { get; set; }

    [Column("prfd_evrak_tarih")]
    public DateTime? PrfdEvrakTarih { get; set; }

    [Column("prfd_belge_no")]
    [StringLength(50)]
    public string? PrfdBelgeNo { get; set; }

    [Column("prfd_belge_tarih")]
    public DateTime? PrfdBelgeTarih { get; set; }

    [Column("prfd_stok_kod")]
    [StringLength(25)]
    public string? PrfdStokKod { get; set; }

    [Column("prfd_tarih")]
    public DateTime? PrfdTarih { get; set; }

    [Column("prfd_saat")]
    public byte? PrfdSaat { get; set; }

    [Column("prfd_fiyat_deg_neden")]
    public byte? PrfdFiyatDegNeden { get; set; }

    [Column("prfd_fiyat_no")]
    public int? PrfdFiyatNo { get; set; }

    [Column("prfd_eskifiy_tutar")]
    public double? PrfdEskifiyTutar { get; set; }

    [Column("prfd_eskifiy_doviz")]
    public byte? PrfdEskifiyDoviz { get; set; }

    [Column("prfd_eskifiy_iskonto")]
    [StringLength(4)]
    public string? PrfdEskifiyIskonto { get; set; }

    [Column("prfd_eskifiy_opno")]
    public int? PrfdEskifiyOpno { get; set; }

    [Column("prfd_yenifiy_tutar")]
    public double? PrfdYenifiyTutar { get; set; }

    [Column("prfd_yenifiy_doviz")]
    public byte? PrfdYenifiyDoviz { get; set; }

    [Column("prfd_yenifiy_iskonto")]
    [StringLength(4)]
    public string? PrfdYenifiyIskonto { get; set; }

    [Column("prfd_yenkifiy_opno")]
    public int? PrfdYenkifiyOpno { get; set; }

    [Column("prfd_eski_karorani")]
    public double? PrfdEskiKarorani { get; set; }

    [Column("prfd_yeni_karorani")]
    public double? PrfdYeniKarorani { get; set; }

    [Column("prfd_depo_no")]
    public int? PrfdDepoNo { get; set; }

    [Column("prfd_OnaylayanKulNo")]
    public byte? PrfdOnaylayanKulNo { get; set; }

    [Column("prfd_cagrilabilir_fl")]
    public bool? PrfdCagrilabilirFl { get; set; }

    [Column("prfd_kapat_fl")]
    public bool? PrfdKapatFl { get; set; }

    [Column("prfd_oncekifiy_tutar")]
    public double? PrfdOncekifiyTutar { get; set; }

    [Column("prfd_oncekifiy_doviz")]
    public byte? PrfdOncekifiyDoviz { get; set; }

    [Column("prfd_oncekifiy_iskonto")]
    [StringLength(4)]
    public string? PrfdOncekifiyIskonto { get; set; }

    [Column("prfd_oncekifiy_opno")]
    public int? PrfdOncekifiyOpno { get; set; }

    [Column("prfd_kapatmanedenkod")]
    [StringLength(25)]
    public string? PrfdKapatmanedenkod { get; set; }
}
