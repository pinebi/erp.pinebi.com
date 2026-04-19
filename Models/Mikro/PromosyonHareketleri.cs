using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("promosyon_hareketleri")]
public class PromosyonHareketleri
{
    [Column("prh_Guid")]
    public Guid? PrhGuid { get; set; }

    [Column("prh_DBCno")]
    public short? PrhDBCno { get; set; }

    [Column("prh_Spec_Rec_no")]
    public int? PrhSpecRecNo { get; set; }

    [Column("prh_iptal")]
    public bool? PrhIptal { get; set; }

    [Column("prh_fileid")]
    public short? PrhFileid { get; set; }

    [Column("prh_hidden")]
    public bool? PrhHidden { get; set; }

    [Column("prh_kilitli")]
    public bool? PrhKilitli { get; set; }

    [Column("prh_degisti")]
    public bool? PrhDegisti { get; set; }

    [Column("prh_checksum")]
    public int? PrhChecksum { get; set; }

    [Column("prh_create_user")]
    public short? PrhCreateUser { get; set; }

    [Column("prh_create_date")]
    public DateTime? PrhCreateDate { get; set; }

    [Column("prh_lastup_user")]
    public short? PrhLastupUser { get; set; }

    [Column("prh_lastup_date")]
    public DateTime? PrhLastupDate { get; set; }

    [Column("prh_special1")]
    [StringLength(4)]
    public string? PrhSpecial1 { get; set; }

    [Column("prh_special2")]
    [StringLength(4)]
    public string? PrhSpecial2 { get; set; }

    [Column("prh_special3")]
    [StringLength(4)]
    public string? PrhSpecial3 { get; set; }

    [Column("prh_firmano")]
    public int? PrhFirmano { get; set; }

    [Column("prh_subeno")]
    public int? PrhSubeno { get; set; }

    [Column("prh_promo_kodu")]
    [StringLength(25)]
    public string? PrhPromoKodu { get; set; }

    [Column("prh_evrak_kaynak")]
    public byte? PrhEvrakKaynak { get; set; }

    [Column("prh_sth_evraktip")]
    public byte? PrhSthEvraktip { get; set; }

    [Column("prh_evrak_cins")]
    public byte? PrhEvrakCins { get; set; }

    [Column("prh_sth_evrakno_seri")]
    [StringLength(50)]
    public string? PrhSthEvraknoSeri { get; set; }

    [Column("prh_sth_evrakno_sira")]
    public int? PrhSthEvraknoSira { get; set; }

    [Column("prh_sth_satirno")]
    public int? PrhSthSatirno { get; set; }

    [Column("prh_urun_cinsi")]
    public byte? PrhUrunCinsi { get; set; }

    [Column("prh_stok_kodu")]
    [StringLength(25)]
    public string? PrhStokKodu { get; set; }

    [Column("prh_cari_kodu")]
    [StringLength(25)]
    public string? PrhCariKodu { get; set; }

    [Column("prh_tarih")]
    public DateTime? PrhTarih { get; set; }

    [Column("prh_plasiyer_kodu")]
    [StringLength(25)]
    public string? PrhPlasiyerKodu { get; set; }

    [Column("prh_miktar")]
    public double? PrhMiktar { get; set; }

    [Column("prh_tutar")]
    public double? PrhTutar { get; set; }

    [Column("prh_yansiyan_promo_tutari")]
    public double? PrhYansiyanPromoTutari { get; set; }

    [Column("prh_promosyon_tipi")]
    public short? PrhPromosyonTipi { get; set; }

    [Column("prh_uygulama_tipi")]
    public short? PrhUygulamaTipi { get; set; }
}
