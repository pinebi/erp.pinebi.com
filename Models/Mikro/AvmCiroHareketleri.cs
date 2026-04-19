using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avm_ciro_hareketleri")]
public class AvmCiroHareketleri
{
    [Column("ach_Guid")]
    public Guid? AchGuid { get; set; }

    [Column("ach_DBCno")]
    public short? AchDBCno { get; set; }

    [Column("ach_Spec_Rec_no")]
    public int? AchSpecRecNo { get; set; }

    [Column("ach_iptal")]
    public bool? AchIptal { get; set; }

    [Column("ach_fileid")]
    public short? AchFileid { get; set; }

    [Column("ach_hidden")]
    public bool? AchHidden { get; set; }

    [Column("ach_kilitli")]
    public bool? AchKilitli { get; set; }

    [Column("ach_degisti")]
    public bool? AchDegisti { get; set; }

    [Column("ach_checksum")]
    public int? AchChecksum { get; set; }

    [Column("ach_create_user")]
    public short? AchCreateUser { get; set; }

    [Column("ach_create_date")]
    public DateTime? AchCreateDate { get; set; }

    [Column("ach_lastup_user")]
    public short? AchLastupUser { get; set; }

    [Column("ach_lastup_date")]
    public DateTime? AchLastupDate { get; set; }

    [Column("ach_special1")]
    [StringLength(4)]
    public string? AchSpecial1 { get; set; }

    [Column("ach_special2")]
    [StringLength(4)]
    public string? AchSpecial2 { get; set; }

    [Column("ach_special3")]
    [StringLength(4)]
    public string? AchSpecial3 { get; set; }

    [Column("ach_firmano")]
    public int? AchFirmano { get; set; }

    [Column("ach_subeno")]
    public int? AchSubeno { get; set; }

    [Column("ach_cari_kodu")]
    [StringLength(25)]
    public string? AchCariKodu { get; set; }

    [Column("ach_kira_kodu")]
    [StringLength(25)]
    public string? AchKiraKodu { get; set; }

    [Column("ach_tarih")]
    public DateTime? AchTarih { get; set; }

    [Column("ach_fis_sayisi")]
    public int? AchFisSayisi { get; set; }

    [Column("ach_tutar")]
    public double? AchTutar { get; set; }

    [Column("ach_CH_uid")]
    public Guid? AchCHUid { get; set; }

    [Column("ach_CH2_uid")]
    public Guid? AchCH2Uid { get; set; }

    [Column("ach_CH3_uid")]
    public Guid? AchCH3Uid { get; set; }

    [Column("ach_fis_sayisi2")]
    public int? AchFisSayisi2 { get; set; }

    [Column("ach_tutar2")]
    public double? AchTutar2 { get; set; }

    [Column("ach_fis_sayisi3")]
    public int? AchFisSayisi3 { get; set; }

    [Column("ach_tutar3")]
    public double? AchTutar3 { get; set; }
}
