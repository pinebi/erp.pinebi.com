using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("puan_hediye_ceki_hareketleri")]
public class PuanHediyeCekiHareketleri
{
    [Column("phc_Guid")]
    public Guid? PhcGuid { get; set; }

    [Column("phc_DBCno")]
    public short? PhcDBCno { get; set; }

    [Column("phc_Spec_Rec_no")]
    public int? PhcSpecRecNo { get; set; }

    [Column("phc_iptal")]
    public bool? PhcIptal { get; set; }

    [Column("phc_fileid")]
    public short? PhcFileid { get; set; }

    [Column("phc_hidden")]
    public bool? PhcHidden { get; set; }

    [Column("phc_kilitli")]
    public bool? PhcKilitli { get; set; }

    [Column("phc_degisti")]
    public bool? PhcDegisti { get; set; }

    [Column("phc_checksum")]
    public int? PhcChecksum { get; set; }

    [Column("phc_create_user")]
    public short? PhcCreateUser { get; set; }

    [Column("phc_create_date")]
    public DateTime? PhcCreateDate { get; set; }

    [Column("phc_lastup_user")]
    public short? PhcLastupUser { get; set; }

    [Column("phc_lastup_date")]
    public DateTime? PhcLastupDate { get; set; }

    [Column("phc_special1")]
    [StringLength(4)]
    public string? PhcSpecial1 { get; set; }

    [Column("phc_special2")]
    [StringLength(4)]
    public string? PhcSpecial2 { get; set; }

    [Column("phc_special3")]
    [StringLength(4)]
    public string? PhcSpecial3 { get; set; }

    [Column("phc_firmano")]
    public int? PhcFirmano { get; set; }

    [Column("phc_subeno")]
    public int? PhcSubeno { get; set; }

    [Column("phc_EvrTip")]
    public byte? PhcEvrTip { get; set; }

    [Column("phc_evrakno_seri")]
    [StringLength(50)]
    public string? PhcEvraknoSeri { get; set; }

    [Column("phc_evrakno_sira")]
    public int? PhcEvraknoSira { get; set; }

    [Column("phc_satir_no")]
    public int? PhcSatirNo { get; set; }

    [Column("phc_puanhcek_tipi")]
    public byte? PhcPuanhcekTipi { get; set; }

    [Column("phc_puanhcek_kodu")]
    [StringLength(25)]
    public string? PhcPuanhcekKodu { get; set; }

    [Column("phc_hcek_seri_no")]
    [StringLength(25)]
    public string? PhcHcekSeriNo { get; set; }

    [Column("phc_cari_kodu")]
    [StringLength(25)]
    public string? PhcCariKodu { get; set; }

    [Column("phc_tarih")]
    public DateTime? PhcTarih { get; set; }

    [Column("phc_DepoNo")]
    public int? PhcDepoNo { get; set; }

    [Column("phc_hareket_tipi")]
    public byte? PhcHareketTipi { get; set; }

    [Column("phc_ilk_kullanim_tarih")]
    public DateTime? PhcIlkKullanimTarih { get; set; }

    [Column("phc_son_kullanim_tarih")]
    public DateTime? PhcSonKullanimTarih { get; set; }

    [Column("phc_miktari")]
    public double? PhcMiktari { get; set; }

    [Column("phc_tutari")]
    public double? PhcTutari { get; set; }

    [Column("phc_KaynakTablo")]
    public short? PhcKaynakTablo { get; set; }

    [Column("phc_Kaynak_evraktip")]
    public byte? PhcKaynakEvraktip { get; set; }

    [Column("phc_Kaynak_evrakno_seri")]
    [StringLength(50)]
    public string? PhcKaynakEvraknoSeri { get; set; }

    [Column("phc_Kaynak_evrakno_sira")]
    public int? PhcKaynakEvraknoSira { get; set; }

    [Column("phc_Kaynak_evrak_satirno")]
    public int? PhcKaynakEvrakSatirno { get; set; }

    [Column("phc_Kaynak_promosyon")]
    [StringLength(25)]
    public string? PhcKaynakPromosyon { get; set; }

    [Column("phc_belge_no")]
    [StringLength(50)]
    public string? PhcBelgeNo { get; set; }

    [Column("phc_belge_tarih")]
    public DateTime? PhcBelgeTarih { get; set; }

    [Column("phc_Plasiyer")]
    [StringLength(25)]
    public string? PhcPlasiyer { get; set; }

    [Column("phc_Aciklama")]
    [StringLength(50)]
    public string? PhcAciklama { get; set; }

    [Column("phc_ProvizyonID")]
    [StringLength(25)]
    public string? PhcProvizyonID { get; set; }
}
