using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("onayli_evraklar")]
public class OnayliEvraklar
{
    [Column("oe_Guid")]
    public Guid? OeGuid { get; set; }

    [Column("oe_DBCno")]
    public short? OeDBCno { get; set; }

    [Column("oe_SpecRECno")]
    public int? OeSpecRECno { get; set; }

    [Column("oe_iptal")]
    public bool? OeIptal { get; set; }

    [Column("oe_fileid")]
    public short? OeFileid { get; set; }

    [Column("oe_hidden")]
    public bool? OeHidden { get; set; }

    [Column("oe_kilitli")]
    public bool? OeKilitli { get; set; }

    [Column("oe_degisti")]
    public bool? OeDegisti { get; set; }

    [Column("oe_checksum")]
    public int? OeChecksum { get; set; }

    [Column("oe_create_user")]
    public short? OeCreateUser { get; set; }

    [Column("oe_create_date")]
    public DateTime? OeCreateDate { get; set; }

    [Column("oe_lastup_user")]
    public short? OeLastupUser { get; set; }

    [Column("oe_lastup_date")]
    public DateTime? OeLastupDate { get; set; }

    [Column("oe_special1")]
    [StringLength(4)]
    public string? OeSpecial1 { get; set; }

    [Column("oe_special2")]
    [StringLength(4)]
    public string? OeSpecial2 { get; set; }

    [Column("oe_special3")]
    [StringLength(4)]
    public string? OeSpecial3 { get; set; }

    [Column("oe_tablo_no")]
    public short? OeTabloNo { get; set; }

    [Column("oe_firma_no")]
    public int? OeFirmaNo { get; set; }

    [Column("oe_evrak_tip")]
    public byte? OeEvrakTip { get; set; }

    [Column("oe_cins_tip")]
    public byte? OeCinsTip { get; set; }

    [Column("oe_evrak_seri")]
    [StringLength(50)]
    public string? OeEvrakSeri { get; set; }

    [Column("oe_evrak_sira")]
    public int? OeEvrakSira { get; set; }

    [Column("oe_evrak_kodu")]
    [StringLength(25)]
    public string? OeEvrakKodu { get; set; }

    [Column("oe_onaylayan_1")]
    public int? OeOnaylayan1 { get; set; }

    [Column("oe_onaylama_tarihi_1")]
    public DateTime? OeOnaylamaTarihi1 { get; set; }

    [Column("oe_onay_aciklamasi1_1")]
    [StringLength(127)]
    public string? OeOnayAciklamasi11 { get; set; }

    [Column("oe_onay_aciklamasi2_1")]
    [StringLength(127)]
    public string? OeOnayAciklamasi21 { get; set; }

    [Column("oe_kullanici_limiti_1")]
    public double? OeKullaniciLimiti1 { get; set; }

    [Column("oe_kullanici_yetki_tipi_1")]
    public byte? OeKullaniciYetkiTipi1 { get; set; }

    [Column("oe_evrak_yekun_1")]
    public double? OeEvrakYekun1 { get; set; }

    [Column("oe_onaylayan_2")]
    public int? OeOnaylayan2 { get; set; }

    [Column("oe_onaylama_tarihi_2")]
    public DateTime? OeOnaylamaTarihi2 { get; set; }

    [Column("oe_onay_aciklamasi1_2")]
    [StringLength(127)]
    public string? OeOnayAciklamasi12 { get; set; }

    [Column("oe_onay_aciklamasi2_2")]
    [StringLength(127)]
    public string? OeOnayAciklamasi22 { get; set; }

    [Column("oe_kullanici_limiti_2")]
    public double? OeKullaniciLimiti2 { get; set; }

    [Column("oe_kullanici_yetki_tipi_2")]
    public byte? OeKullaniciYetkiTipi2 { get; set; }

    [Column("oe_onaylayan_3")]
    public int? OeOnaylayan3 { get; set; }

    [Column("oe_onaylama_tarihi_3")]
    public DateTime? OeOnaylamaTarihi3 { get; set; }

    [Column("oe_onay_aciklamasi1_3")]
    [StringLength(127)]
    public string? OeOnayAciklamasi13 { get; set; }

    [Column("oe_onay_aciklamasi2_3")]
    [StringLength(127)]
    public string? OeOnayAciklamasi23 { get; set; }

    [Column("oe_kullanici_limiti_3")]
    public double? OeKullaniciLimiti3 { get; set; }

    [Column("oe_kullanici_yetki_tipi_3")]
    public byte? OeKullaniciYetkiTipi3 { get; set; }

    [Column("oe_onaylayan_4")]
    public int? OeOnaylayan4 { get; set; }

    [Column("oe_onaylama_tarihi_4")]
    public DateTime? OeOnaylamaTarihi4 { get; set; }

    [Column("oe_onay_aciklamasi1_4")]
    [StringLength(127)]
    public string? OeOnayAciklamasi14 { get; set; }

    [Column("oe_onay_aciklamasi2_4")]
    [StringLength(127)]
    public string? OeOnayAciklamasi24 { get; set; }

    [Column("oe_kullanici_limiti_4")]
    public double? OeKullaniciLimiti4 { get; set; }

    [Column("oe_kullanici_yetki_tipi_4")]
    public byte? OeKullaniciYetkiTipi4 { get; set; }

    [Column("oe_onaylayan_5")]
    public int? OeOnaylayan5 { get; set; }

    [Column("oe_onaylama_tarihi_5")]
    public DateTime? OeOnaylamaTarihi5 { get; set; }

    [Column("oe_onay_aciklamasi1_5")]
    [StringLength(127)]
    public string? OeOnayAciklamasi15 { get; set; }

    [Column("oe_onay_aciklamasi2_5")]
    [StringLength(127)]
    public string? OeOnayAciklamasi25 { get; set; }

    [Column("oe_kullanici_limiti_5")]
    public double? OeKullaniciLimiti5 { get; set; }

    [Column("oe_evrak_yekun_5")]
    public double? OeEvrakYekun5 { get; set; }

    [Column("oe_onay_tamamlandi_fl")]
    public bool? OeOnayTamamlandiFl { get; set; }

    [Column("oe_kaynak_uid")]
    public Guid? OeKaynakUid { get; set; }
}
