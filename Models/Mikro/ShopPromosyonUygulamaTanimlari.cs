using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("shop_promosyon_uygulama_tanimlari")]
public class ShopPromosyonUygulamaTanimlari
{
    [Column("pru_Guid")]
    public Guid? PruGuid { get; set; }

    [Column("pru_DBCno")]
    public short? PruDBCno { get; set; }

    [Column("pru_SpecRECNo")]
    public int? PruSpecRECNo { get; set; }

    [Column("pru_iptal")]
    public bool? PruIptal { get; set; }

    [Column("pru_fileid")]
    public short? PruFileid { get; set; }

    [Column("pru_hidden")]
    public bool? PruHidden { get; set; }

    [Column("pru_kilitli")]
    public bool? PruKilitli { get; set; }

    [Column("pru_degisti")]
    public bool? PruDegisti { get; set; }

    [Column("pru_checksum")]
    public int? PruChecksum { get; set; }

    [Column("pru_create_user")]
    public short? PruCreateUser { get; set; }

    [Column("pru_create_date")]
    public DateTime? PruCreateDate { get; set; }

    [Column("pru_lastup_user")]
    public short? PruLastupUser { get; set; }

    [Column("pru_lastup_date")]
    public DateTime? PruLastupDate { get; set; }

    [Column("pru_special1")]
    [StringLength(4)]
    public string? PruSpecial1 { get; set; }

    [Column("pru_special2")]
    [StringLength(4)]
    public string? PruSpecial2 { get; set; }

    [Column("pru_special3")]
    [StringLength(4)]
    public string? PruSpecial3 { get; set; }

    [Column("pru_Promosyon")]
    [StringLength(25)]
    public string? PruPromosyon { get; set; }

    [Column("pru_Kod")]
    [StringLength(25)]
    public string? PruKod { get; set; }

    [Column("pru_Aciklama")]
    [StringLength(100)]
    public string? PruAciklama { get; set; }

    [Column("pru_UygulamaKodu")]
    public int? PruUygulamaKodu { get; set; }

    [Column("pru_Urunler")]
    [StringLength(127)]
    public string? PruUrunler { get; set; }

    [Column("pru_XXXDbl_aktif")]
    public bool? PruXXXDblAktif { get; set; }

    [Column("pru_Miktar")]
    [StringLength(127)]
    public string? PruMiktar { get; set; }

    [Column("pru_Deger")]
    [StringLength(127)]
    public string? PruDeger { get; set; }

    [Column("pru_MiktarDbl")]
    public double? PruMiktarDbl { get; set; }

    [Column("pru_DegerDbl")]
    public double? PruDegerDbl { get; set; }

    [Column("pru_OzelDurum")]
    public byte? PruOzelDurum { get; set; }

    [Column("pru_Ozellikler")]
    public byte? PruOzellikler { get; set; }

    [Column("pru_iskonto_dagitim_sekli")]
    public byte? PruIskontoDagitimSekli { get; set; }

    [Column("pru_iskonto_index")]
    public byte? PruIskontoIndex { get; set; }

    [Column("pru_yuvarlama_tipi")]
    public byte? PruYuvarlamaTipi { get; set; }

    [Column("pru_yuvarlama_miktar")]
    public double? PruYuvarlamaMiktar { get; set; }

    [Column("pru_eksikse_mesaj")]
    [StringLength(127)]
    public string? PruEksikseMesaj { get; set; }

    [Column("pru_kasa_mesaji")]
    [StringLength(127)]
    public string? PruKasaMesaji { get; set; }

    [Column("pru_ekbilgi")]
    [StringLength(127)]
    public string? PruEkbilgi { get; set; }
}
