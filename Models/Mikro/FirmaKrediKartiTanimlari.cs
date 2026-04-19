using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_kredi_karti_tanimlari")]
public class FirmaKrediKartiTanimlari
{
    [Column("fkk_Guid")]
    public Guid? FkkGuid { get; set; }

    [Column("fkk_DBCno")]
    public short? FkkDBCno { get; set; }

    [Column("fkk_SpecRecno")]
    public int? FkkSpecRecno { get; set; }

    [Column("fkk_iptal")]
    public bool? FkkIptal { get; set; }

    [Column("fkk_fileid")]
    public short? FkkFileid { get; set; }

    [Column("fkk_hidden")]
    public bool? FkkHidden { get; set; }

    [Column("fkk_kilitli")]
    public bool? FkkKilitli { get; set; }

    [Column("fkk_degisti")]
    public bool? FkkDegisti { get; set; }

    [Column("fkk_checksum")]
    public int? FkkChecksum { get; set; }

    [Column("fkk_create_user")]
    public short? FkkCreateUser { get; set; }

    [Column("fkk_create_date")]
    public DateTime? FkkCreateDate { get; set; }

    [Column("fkk_lastup_user")]
    public short? FkkLastupUser { get; set; }

    [Column("fkk_lastup_date")]
    public DateTime? FkkLastupDate { get; set; }

    [Column("fkk_special1")]
    [StringLength(4)]
    public string? FkkSpecial1 { get; set; }

    [Column("fkk_special2")]
    [StringLength(4)]
    public string? FkkSpecial2 { get; set; }

    [Column("fkk_special3")]
    [StringLength(4)]
    public string? FkkSpecial3 { get; set; }

    [Column("fkk_firma_no")]
    public int? FkkFirmaNo { get; set; }

    [Column("fkk_kod")]
    [StringLength(25)]
    public string? FkkKod { get; set; }

    [Column("fkk_isim")]
    [StringLength(40)]
    public string? FkkIsim { get; set; }

    [Column("fkk_kartno")]
    [StringLength(25)]
    public string? FkkKartno { get; set; }

    [Column("fkk_tip")]
    public byte? FkkTip { get; set; }

    [Column("fkk_cins")]
    public byte? FkkCins { get; set; }

    [Column("fkk_bagli_asil_kart_kodu")]
    [StringLength(25)]
    public string? FkkBagliAsilKartKodu { get; set; }

    [Column("fkk_bagli_banka_kodu")]
    [StringLength(25)]
    public string? FkkBagliBankaKodu { get; set; }

    [Column("fkk_bagli_cari_pers_kodu")]
    [StringLength(25)]
    public string? FkkBagliCariPersKodu { get; set; }

    [Column("fkk_sonkullanim_tarihi")]
    public DateTime? FkkSonkullanimTarihi { get; set; }

    [Column("fkk_hesap_kesim_gunu")]
    public short? FkkHesapKesimGunu { get; set; }

    [Column("fkk_doviz_cinsi")]
    public byte? FkkDovizCinsi { get; set; }

    [Column("fkk_harcama_limiti")]
    public double? FkkHarcamaLimiti { get; set; }

    [Column("fkk_nakit_limiti")]
    public double? FkkNakitLimiti { get; set; }

    [Column("fkk_donem_ici_muh_kod")]
    [StringLength(40)]
    public string? FkkDonemIciMuhKod { get; set; }

    [Column("fkk_gerceklesmis_donem_muh_kod")]
    [StringLength(40)]
    public string? FkkGerceklesmisDonemMuhKod { get; set; }

    [Column("fkk_bagli_kredi_kart_kod")]
    [StringLength(25)]
    public string? FkkBagliKrediKartKod { get; set; }

    [Column("fkk_durumu")]
    public byte? FkkDurumu { get; set; }
}
