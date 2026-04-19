using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("iade_talepleri")]
public class IadeTalepleri
{
    [Column("itlp_Guid")]
    public Guid? ItlpGuid { get; set; }

    [Column("itlp_DBCno")]
    public short? ItlpDBCno { get; set; }

    [Column("itlp_SpecRECno")]
    public int? ItlpSpecRECno { get; set; }

    [Column("itlp_iptal")]
    public bool? ItlpIptal { get; set; }

    [Column("itlp_fileid")]
    public short? ItlpFileid { get; set; }

    [Column("itlp_hidden")]
    public bool? ItlpHidden { get; set; }

    [Column("itlp_kilitli")]
    public bool? ItlpKilitli { get; set; }

    [Column("itlp_degisti")]
    public bool? ItlpDegisti { get; set; }

    [Column("itlp_CheckSum")]
    public int? ItlpCheckSum { get; set; }

    [Column("itlp_create_user")]
    public short? ItlpCreateUser { get; set; }

    [Column("itlp_create_date")]
    public DateTime? ItlpCreateDate { get; set; }

    [Column("itlp_lastup_user")]
    public short? ItlpLastupUser { get; set; }

    [Column("itlp_lastup_date")]
    public DateTime? ItlpLastupDate { get; set; }

    [Column("itlp_special1")]
    [StringLength(4)]
    public string? ItlpSpecial1 { get; set; }

    [Column("itlp_special2")]
    [StringLength(4)]
    public string? ItlpSpecial2 { get; set; }

    [Column("itlp_special3")]
    [StringLength(4)]
    public string? ItlpSpecial3 { get; set; }

    [Column("itlp_firmano")]
    public int? ItlpFirmano { get; set; }

    [Column("itlp_subeno")]
    public int? ItlpSubeno { get; set; }

    [Column("itlp_tarihi")]
    public DateTime? ItlpTarihi { get; set; }

    [Column("itlp_teslim_tarihi")]
    public DateTime? ItlpTeslimTarihi { get; set; }

    [Column("itlp_tip")]
    public byte? ItlpTip { get; set; }

    [Column("itlp_evrak_seri")]
    [StringLength(50)]
    public string? ItlpEvrakSeri { get; set; }

    [Column("itlp_evrak_sira")]
    public int? ItlpEvrakSira { get; set; }

    [Column("itlp_satir_no")]
    public int? ItlpSatirNo { get; set; }

    [Column("itlp_belge_no")]
    [StringLength(50)]
    public string? ItlpBelgeNo { get; set; }

    [Column("itlp_belge_tarihi")]
    public DateTime? ItlpBelgeTarihi { get; set; }

    [Column("itlp_musteri_kodu")]
    [StringLength(25)]
    public string? ItlpMusteriKodu { get; set; }

    [Column("itlp_sor_merk_kodu")]
    [StringLength(25)]
    public string? ItlpSorMerkKodu { get; set; }

    [Column("itlp_opno")]
    public int? ItlpOpno { get; set; }

    [Column("itlp_stok_kodu")]
    [StringLength(25)]
    public string? ItlpStokKodu { get; set; }

    [Column("itlp_satici_kodu")]
    [StringLength(25)]
    public string? ItlpSaticiKodu { get; set; }

    [Column("itlp_miktari")]
    public double? ItlpMiktari { get; set; }

    [Column("itlp_teslim_miktari")]
    public double? ItlpTeslimMiktari { get; set; }

    [Column("itlp_aciklama")]
    [StringLength(40)]
    public string? ItlpAciklama { get; set; }

    [Column("itlp_depo_no")]
    public int? ItlpDepoNo { get; set; }

    [Column("itlp_cari_grupno")]
    public byte? ItlpCariGrupno { get; set; }

    [Column("itlp_doviz_cinsi")]
    public byte? ItlpDovizCinsi { get; set; }

    [Column("itlp_doviz_kuru")]
    public byte? ItlpDovizKuru { get; set; }

    [Column("itlp_birim_fiyat")]
    public double? ItlpBirimFiyat { get; set; }

    [Column("itlp_fiyat_listeno")]
    public int? ItlpFiyatListeno { get; set; }

    [Column("itlp_tutar")]
    public double? ItlpTutar { get; set; }

    [Column("itlp_kapat_fl")]
    public bool? ItlpKapatFl { get; set; }

    [Column("itlp_projekodu")]
    [StringLength(25)]
    public string? ItlpProjekodu { get; set; }

    [Column("itlp_parti_kodu")]
    [StringLength(25)]
    public string? ItlpPartiKodu { get; set; }

    [Column("itlp_lot_no")]
    public int? ItlpLotNo { get; set; }

    [Column("itlp_onaylayan_kulno")]
    public short? ItlpOnaylayanKulno { get; set; }

    [Column("itlp_cagrilabilir_fl")]
    public bool? ItlpCagrilabilirFl { get; set; }

    [Column("itlp_kapatmanedenkod")]
    [StringLength(25)]
    public string? ItlpKapatmanedenkod { get; set; }
}
