using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Irsaliye;

/// <summary>
/// Irsaliye satir detaylari.
/// Her irsaliye satirindaki stok, miktar, fiyat, iskonto vb. bilgileri tutar.
/// FaturaSatirlari ile ayni yapidadir.
/// </summary>
[Table("pine_irsaliye_satirlari")]
public class PineIrsaliyeSatirlari : BaseEntity
{
    // ── Parent ────────────────────────────────────────────
    [Column("ist_irsaliye_uid")]
    public Guid IstIrsaliyeUid { get; set; }

    [Column("ist_satir_no")]
    public int IstSatirNo { get; set; }

    /// <summary>1=Satis, 2=SatisIade, 3=Satinalma, 4=SatinalmaIade</summary>
    [Column("ist_tip")]
    public int IstTip { get; set; }

    // ── Stock ─────────────────────────────────────────────
    [Column("ist_stok_kod")]
    [StringLength(25)]
    public string IstStokKod { get; set; } = string.Empty;

    [Column("ist_stok_adi")]
    [StringLength(300)]
    public string? IstStokAdi { get; set; }

    /// <summary>0=Stok, 1=Hizmet, 2=Masraf</summary>
    [Column("ist_stok_tipi")]
    public int IstStokTipi { get; set; }

    // ── Quantity ──────────────────────────────────────────
    [Column("ist_miktar")]
    public decimal IstMiktar { get; set; }

    [Column("ist_birim")]
    [StringLength(25)]
    public string? IstBirim { get; set; }

    [Column("ist_miktar2")]
    public decimal IstMiktar2 { get; set; }

    [Column("ist_birim2")]
    [StringLength(25)]
    public string? IstBirim2 { get; set; }

    [Column("ist_cevirme_katsayisi")]
    public decimal IstCevirmeKatsayisi { get; set; }

    // ── Price ─────────────────────────────────────────────
    [Column("ist_birim_fiyat")]
    public decimal IstBirimFiyat { get; set; }

    [Column("ist_tutar")]
    public decimal IstTutar { get; set; }

    // ── Discount ──────────────────────────────────────────
    [Column("ist_iskonto_orani1")]
    public decimal IstIskontoOrani1 { get; set; }

    [Column("ist_iskonto_orani2")]
    public decimal IstIskontoOrani2 { get; set; }

    [Column("ist_iskonto_orani3")]
    public decimal IstIskontoOrani3 { get; set; }

    [Column("ist_iskonto_tutari")]
    public decimal IstIskontoTutari { get; set; }

    [Column("ist_net_tutar")]
    public decimal IstNetTutar { get; set; }

    // ── Tax ───────────────────────────────────────────────
    [Column("ist_kdv_orani")]
    public decimal IstKdvOrani { get; set; }

    [Column("ist_kdv_tutari")]
    public decimal IstKdvTutari { get; set; }

    [Column("ist_otv_orani")]
    public decimal IstOtvOrani { get; set; }

    [Column("ist_otv_tutari")]
    public decimal IstOtvTutari { get; set; }

    [Column("ist_tevkifat_kodu")]
    [StringLength(25)]
    public string? IstTevkifatKodu { get; set; }

    [Column("ist_tevkifat_orani")]
    public decimal IstTevkifatOrani { get; set; }

    [Column("ist_tevkifat_tutari")]
    public decimal IstTevkifatTutari { get; set; }

    // ── Totals ────────────────────────────────────────────
    [Column("ist_satir_toplami")]
    public decimal IstSatirToplami { get; set; }

    // ── Currency ──────────────────────────────────────────
    [Column("ist_doviz_cinsi")]
    [StringLength(5)]
    public string? IstDovizCinsi { get; set; }

    [Column("ist_doviz_kuru")]
    public decimal IstDovizKuru { get; set; }

    [Column("ist_tl_tutar")]
    public decimal IstTlTutar { get; set; }

    [Column("ist_tl_net_tutar")]
    public decimal IstTlNetTutar { get; set; }

    [Column("ist_tl_kdv_tutari")]
    public decimal IstTlKdvTutari { get; set; }

    [Column("ist_tl_satir_toplami")]
    public decimal IstTlSatirToplami { get; set; }

    // ── Location ──────────────────────────────────────────
    [Column("ist_depo_no")]
    public int IstDepoNo { get; set; }

    // ── Reference ─────────────────────────────────────────
    [Column("ist_proje_kodu")]
    [StringLength(25)]
    public string? IstProjeKodu { get; set; }

    [Column("ist_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? IstSorumlulukMerkezi { get; set; }

    [Column("ist_siparis_uid")]
    public Guid? IstSiparisUid { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("ist_aciklama")]
    [StringLength(500)]
    public string? IstAciklama { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("ist_ozelkod1")]
    [StringLength(50)]
    public string? IstOzelkod1 { get; set; }

    [Column("ist_ozelkod2")]
    [StringLength(50)]
    public string? IstOzelkod2 { get; set; }
}
