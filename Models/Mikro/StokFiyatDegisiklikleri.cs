using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_fiyat_degisiklikleri")]
public class StokFiyatDegisiklikleri
{
    [Column("fid_Guid")]
    public Guid FidGuid { get; set; }

    [Column("fid_DBCno")]
    public short? FidDBCno { get; set; }

    [Column("fid_SpecRecNo")]
    public int? FidSpecRecNo { get; set; }

    [Column("fid_iptal")]
    public bool? FidIptal { get; set; }

    [Column("fid_fileid")]
    public short? FidFileid { get; set; }

    [Column("fid_hidden")]
    public bool? FidHidden { get; set; }

    [Column("fid_kilitli")]
    public bool? FidKilitli { get; set; }

    [Column("fid_degisti")]
    public bool? FidDegisti { get; set; }

    [Column("fid_checksum")]
    public int? FidChecksum { get; set; }

    [Column("fid_create_user")]
    public short? FidCreateUser { get; set; }

    [Column("fid_create_date")]
    public DateTime? FidCreateDate { get; set; }

    [Column("fid_lastup_user")]
    public short? FidLastupUser { get; set; }

    [Column("fid_lastup_date")]
    public DateTime? FidLastupDate { get; set; }

    [Column("fid_special1")]
    [StringLength(4)]
    public string? FidSpecial1 { get; set; }

    [Column("fid_special2")]
    [StringLength(4)]
    public string? FidSpecial2 { get; set; }

    [Column("fid_special3")]
    [StringLength(4)]
    public string? FidSpecial3 { get; set; }

    [Column("fid_evrak_satir_no")]
    public int? FidEvrakSatirNo { get; set; }

    [Column("fid_evrak_seri_no")]
    [StringLength(5)]
    public string? FidEvrakSeriNo { get; set; }

    [Column("fid_evrak_sira_no")]
    public int? FidEvrakSiraNo { get; set; }

    [Column("fid_evrak_tarih")]
    public DateTime? FidEvrakTarih { get; set; }

    [Column("fid_belge_no")]
    [StringLength(25)]
    public string? FidBelgeNo { get; set; }

    [Column("fid_belge_tarih")]
    public DateTime? FidBelgeTarih { get; set; }

    [Column("fid_stok_kod")]
    [StringLength(25)]
    public string? FidStokKod { get; set; }

    [Column("fid_tarih")]
    public DateTime? FidTarih { get; set; }

    [Column("fid_saat")]
    public byte? FidSaat { get; set; }

    [Column("fid_fiyat_deg_neden")]
    public byte? FidFiyatDegNeden { get; set; }

    [Column("fid_fiyat_no")]
    public int? FidFiyatNo { get; set; }

    [Column("fid_eskifiy_tutar")]
    public double? FidEskifiyTutar { get; set; }

    [Column("fid_eskifiy_doviz")]
    public byte? FidEskifiyDoviz { get; set; }

    [Column("fid_eskifiy_iskonto")]
    [StringLength(4)]
    public string? FidEskifiyIskonto { get; set; }

    [Column("fid_eskifiy_opno")]
    public int? FidEskifiyOpno { get; set; }

    [Column("fid_yenifiy_tutar")]
    public double? FidYenifiyTutar { get; set; }

    [Column("fid_yenifiy_doviz")]
    public byte? FidYenifiyDoviz { get; set; }

    [Column("fid_yenifiy_iskonto")]
    [StringLength(4)]
    public string? FidYenifiyIskonto { get; set; }

    [Column("fid_yenifiy_opno")]
    public int? FidYenifiyOpno { get; set; }

    [Column("fid_yapildi_fl")]
    public byte? FidYapildiFl { get; set; }

    [Column("fid_eski_karorani")]
    public double? FidEskiKarorani { get; set; }

    [Column("fid_yeni_karorani")]
    public double? FidYeniKarorani { get; set; }

    [Column("fid_depo_no")]
    public byte? FidDepoNo { get; set; }

    [Column("fid_prof_uid")]
    public Guid? FidProfUid { get; set; }
}
