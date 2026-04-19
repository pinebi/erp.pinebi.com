using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("shop_promosyon_kontrol")]
public class ShopPromosyonKontrol
{
    [Column("spk_Guid")]
    public Guid? SpkGuid { get; set; }

    [Column("spk_DBCno")]
    public short? SpkDBCno { get; set; }

    [Column("spk_SpecRECNo")]
    public int? SpkSpecRECNo { get; set; }

    [Column("spk_iptal")]
    public bool? SpkIptal { get; set; }

    [Column("spk_fileid")]
    public short? SpkFileid { get; set; }

    [Column("spk_hidden")]
    public bool? SpkHidden { get; set; }

    [Column("spk_kilitli")]
    public bool? SpkKilitli { get; set; }

    [Column("spk_degisti")]
    public bool? SpkDegisti { get; set; }

    [Column("spk_checksum")]
    public int? SpkChecksum { get; set; }

    [Column("spk_create_user")]
    public short? SpkCreateUser { get; set; }

    [Column("spk_create_date")]
    public DateTime? SpkCreateDate { get; set; }

    [Column("spk_lastup_user")]
    public short? SpkLastupUser { get; set; }

    [Column("spk_lastup_date")]
    public DateTime? SpkLastupDate { get; set; }

    [Column("spk_special1")]
    [StringLength(4)]
    public string? SpkSpecial1 { get; set; }

    [Column("spk_special2")]
    [StringLength(4)]
    public string? SpkSpecial2 { get; set; }

    [Column("spk_special3")]
    [StringLength(4)]
    public string? SpkSpecial3 { get; set; }

    [Column("spk_testid")]
    public int? SpkTestid { get; set; }

    [Column("spk_datatip")]
    public byte? SpkDatatip { get; set; }

    [Column("spk_OrnekKodu")]
    [StringLength(25)]
    public string? SpkOrnekKodu { get; set; }

    [Column("spk_PromosyonKodu")]
    [StringLength(25)]
    public string? SpkPromosyonKodu { get; set; }

    [Column("spk_satirno")]
    public int? SpkSatirno { get; set; }

    [Column("spk_stok_kod")]
    [StringLength(25)]
    public string? SpkStokKod { get; set; }

    [Column("spk_stok_barkod")]
    [StringLength(50)]
    public string? SpkStokBarkod { get; set; }

    [Column("spk_stok_renkID")]
    public int? SpkStokRenkID { get; set; }

    [Column("spk_stok_bedenID")]
    public int? SpkStokBedenID { get; set; }

    [Column("spk_cari_cinsi")]
    public byte? SpkCariCinsi { get; set; }

    [Column("spk_cari_kodu")]
    [StringLength(25)]
    public string? SpkCariKodu { get; set; }

    [Column("spk_cari_grup_no")]
    public byte? SpkCariGrupNo { get; set; }

    [Column("spk_miktar")]
    public double? SpkMiktar { get; set; }

    [Column("spk_tutar")]
    public double? SpkTutar { get; set; }

    [Column("spk_iskontoSatir")]
    public double? SpkIskontoSatir { get; set; }

    [Column("spk_iskontoGenel")]
    public double? SpkIskontoGenel { get; set; }

    [Column("spk_masrafSatir")]
    public double? SpkMasrafSatir { get; set; }

    [Column("spk_masrafGenel")]
    public double? SpkMasrafGenel { get; set; }

    [Column("spk_vergi")]
    public double? SpkVergi { get; set; }

    [Column("spk_masraf_vergi")]
    public double? SpkMasrafVergi { get; set; }

    [Column("spk_otv_vergi")]
    public double? SpkOtvVergi { get; set; }

    [Column("spk_otvtutari")]
    public double? SpkOtvtutari { get; set; }

    [Column("spk_oiv_vergi")]
    public double? SpkOivVergi { get; set; }

    [Column("spk_oivtutari")]
    public double? SpkOivtutari { get; set; }

    [Column("spk_OdemeTipi")]
    public int? SpkOdemeTipi { get; set; }

    [Column("spk_TaksitTipi")]
    public int? SpkTaksitTipi { get; set; }

    [Column("spk_PuanKodu")]
    [StringLength(25)]
    public string? SpkPuanKodu { get; set; }

    [Column("spk_OdemeToplam")]
    public double? SpkOdemeToplam { get; set; }

    [Column("spk_PromoOK")]
    public bool? SpkPromoOK { get; set; }
}
