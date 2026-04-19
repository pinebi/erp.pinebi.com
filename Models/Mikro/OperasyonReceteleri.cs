using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("operasyon_receteleri")]
public class OperasyonReceteleri
{
    [Column("opr_Guid")]
    public Guid? OprGuid { get; set; }

    [Column("opr_DBCno")]
    public short? OprDBCno { get; set; }

    [Column("opr_SpecRECno")]
    public int? OprSpecRECno { get; set; }

    [Column("opr_iptal")]
    public bool? OprIptal { get; set; }

    [Column("opr_fileid")]
    public short? OprFileid { get; set; }

    [Column("opr_hidden")]
    public bool? OprHidden { get; set; }

    [Column("opr_kilitli")]
    public bool? OprKilitli { get; set; }

    [Column("opr_degisti")]
    public bool? OprDegisti { get; set; }

    [Column("opr_checksum")]
    public int? OprChecksum { get; set; }

    [Column("opr_create_user")]
    public short? OprCreateUser { get; set; }

    [Column("opr_create_date")]
    public DateTime? OprCreateDate { get; set; }

    [Column("opr_lastup_user")]
    public short? OprLastupUser { get; set; }

    [Column("opr_lastup_date")]
    public DateTime? OprLastupDate { get; set; }

    [Column("opr_special1")]
    [StringLength(4)]
    public string? OprSpecial1 { get; set; }

    [Column("opr_special2")]
    [StringLength(4)]
    public string? OprSpecial2 { get; set; }

    [Column("opr_special3")]
    [StringLength(4)]
    public string? OprSpecial3 { get; set; }

    [Column("opr_operasyon_kodu")]
    [StringLength(25)]
    public string? OprOperasyonKodu { get; set; }

    [Column("opr_duzenleme_tarihi")]
    public DateTime? OprDuzenlemeTarihi { get; set; }

    [Column("opr_aciklama")]
    [StringLength(50)]
    public string? OprAciklama { get; set; }

    [Column("opr_tuketim_kodu")]
    [StringLength(25)]
    public string? OprTuketimKodu { get; set; }

    [Column("opr_tuketim_miktari")]
    public double? OprTuketimMiktari { get; set; }

    [Column("opr_tuketim_birim")]
    public byte? OprTuketimBirim { get; set; }

    [Column("opr_hesap_tipi")]
    public byte? OprHesapTipi { get; set; }

    [Column("opr_ana_miktar_sure")]
    public double? OprAnaMiktarSure { get; set; }

    [Column("opr_uretim_tuketim")]
    public byte? OprUretimTuketim { get; set; }

    [Column("opr_satirno")]
    public int? OprSatirno { get; set; }

    [Column("opr_satir_aciklamasi")]
    [StringLength(50)]
    public string? OprSatirAciklamasi { get; set; }

    [Column("opr_depono")]
    public int? OprDepono { get; set; }

    [Column("opr_alt_tukkod1")]
    [StringLength(25)]
    public string? OprAltTukkod1 { get; set; }

    [Column("opr_alt_1_katsayi")]
    public double? OprAlt1Katsayi { get; set; }

    [Column("opr_alt_tukkod2")]
    [StringLength(25)]
    public string? OprAltTukkod2 { get; set; }

    [Column("opr_alt_2_katsayi")]
    public double? OprAlt2Katsayi { get; set; }

    [Column("opr_alt_tukkod3")]
    [StringLength(25)]
    public string? OprAltTukkod3 { get; set; }

    [Column("opr_alt_3_katsayi")]
    public double? OprAlt3Katsayi { get; set; }

    [Column("opr_alt_tukkod4")]
    [StringLength(25)]
    public string? OprAltTukkod4 { get; set; }

    [Column("opr_alt_4_katsayi")]
    public double? OprAlt4Katsayi { get; set; }

    [Column("opr_alt_tukkod5")]
    [StringLength(25)]
    public string? OprAltTukkod5 { get; set; }

    [Column("opr_alt_5_katsayi")]
    public double? OprAlt5Katsayi { get; set; }

    [Column("opr_sarf_turu")]
    public byte? OprSarfTuru { get; set; }
}
