using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_cari_iskonto_tanimlari")]
public class StokCariIskontoTanimlari
{
    [Column("isk_Guid")]
    public Guid IskGuid { get; set; }

    [Column("isk_DBCno")]
    public short? IskDBCno { get; set; }

    [Column("isk_SpecRecno")]
    public int? IskSpecRecno { get; set; }

    [Column("isk_iptal")]
    public bool? IskIptal { get; set; }

    [Column("isk_fileid")]
    public short? IskFileid { get; set; }

    [Column("isk_hidden")]
    public bool? IskHidden { get; set; }

    [Column("isk_kilitli")]
    public bool? IskKilitli { get; set; }

    [Column("isk_degisti")]
    public bool? IskDegisti { get; set; }

    [Column("isk_checksum")]
    public int? IskChecksum { get; set; }

    [Column("isk_create_user")]
    public short? IskCreateUser { get; set; }

    [Column("isk_create_date")]
    public DateTime? IskCreateDate { get; set; }

    [Column("isk_lastup_user")]
    public short? IskLastupUser { get; set; }

    [Column("isk_lastup_date")]
    public DateTime? IskLastupDate { get; set; }

    [Column("isk_special1")]
    [StringLength(4)]
    public string? IskSpecial1 { get; set; }

    [Column("isk_special2")]
    [StringLength(4)]
    public string? IskSpecial2 { get; set; }

    [Column("isk_special3")]
    [StringLength(4)]
    public string? IskSpecial3 { get; set; }

    [Column("isk_stok_kod")]
    [StringLength(25)]
    public string? IskStokKod { get; set; }

    [Column("isk_cari_kod")]
    [StringLength(25)]
    public string? IskCariKod { get; set; }

    [Column("isk_isim")]
    [StringLength(50)]
    public string? IskIsim { get; set; }

    [Column("isk_uygulama_odeme_plani")]
    public int? IskUygulamaOdemePlani { get; set; }

    [Column("isk_bedelsiz_referans_miktar")]
    public double? IskBedelsizReferansMiktar { get; set; }

    [Column("isk_isk1_aciklama")]
    [StringLength(20)]
    public string? IskIsk1Aciklama { get; set; }

    [Column("isk_isk1_uygulama")]
    public byte? IskIsk1Uygulama { get; set; }

    [Column("isk_isk1_yuzde")]
    public double? IskIsk1Yuzde { get; set; }

    [Column("isk_isk2_aciklama")]
    [StringLength(20)]
    public string? IskIsk2Aciklama { get; set; }

    [Column("isk_isk2_uygulama")]
    public byte? IskIsk2Uygulama { get; set; }

    [Column("isk_isk2_yuzde")]
    public double? IskIsk2Yuzde { get; set; }

    [Column("isk_isk3_aciklama")]
    [StringLength(20)]
    public string? IskIsk3Aciklama { get; set; }

    [Column("isk_isk3_uygulama")]
    public byte? IskIsk3Uygulama { get; set; }

    [Column("isk_isk3_yuzde")]
    public double? IskIsk3Yuzde { get; set; }

    [Column("isk_isk4_aciklama")]
    [StringLength(20)]
    public string? IskIsk4Aciklama { get; set; }

    [Column("isk_isk4_uygulama")]
    public byte? IskIsk4Uygulama { get; set; }

    [Column("isk_isk4_yuzde")]
    public double? IskIsk4Yuzde { get; set; }

    [Column("isk_isk5_aciklama")]
    [StringLength(20)]
    public string? IskIsk5Aciklama { get; set; }

    [Column("isk_isk5_uygulama")]
    public byte? IskIsk5Uygulama { get; set; }

    [Column("isk_isk5_yuzde")]
    public double? IskIsk5Yuzde { get; set; }

    [Column("isk_isk6_aciklama")]
    [StringLength(20)]
    public string? IskIsk6Aciklama { get; set; }

    [Column("isk_isk6_uygulama")]
    public byte? IskIsk6Uygulama { get; set; }

    [Column("isk_isk6_yuzde")]
    public double? IskIsk6Yuzde { get; set; }

    [Column("isk_mas1_aciklama")]
    [StringLength(20)]
    public string? IskMas1Aciklama { get; set; }

    [Column("isk_mas1_uygulama")]
    public byte? IskMas1Uygulama { get; set; }

    [Column("isk_mas1_yuzde")]
    public double? IskMas1Yuzde { get; set; }

    [Column("isk_mas2_aciklama")]
    [StringLength(20)]
    public string? IskMas2Aciklama { get; set; }

    [Column("isk_mas2_uygulama")]
    public byte? IskMas2Uygulama { get; set; }

    [Column("isk_mas2_yuzde")]
    public double? IskMas2Yuzde { get; set; }

    [Column("isk_mas3_aciklama")]
    [StringLength(20)]
    public string? IskMas3Aciklama { get; set; }

    [Column("isk_mas3_uygulama")]
    public byte? IskMas3Uygulama { get; set; }

    [Column("isk_mas3_yuzde")]
    public double? IskMas3Yuzde { get; set; }

    [Column("isk_mas4_aciklama")]
    [StringLength(20)]
    public string? IskMas4Aciklama { get; set; }

    [Column("isk_mas4_uygulama")]
    public byte? IskMas4Uygulama { get; set; }

    [Column("isk_mas4_yuzde")]
    public double? IskMas4Yuzde { get; set; }
}
