using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura satir detaylari.
/// Her fatura satirindaki stok, miktar, fiyat, iskonto vb. bilgileri tutar.
/// </summary>
[Table("pine_fatura_satirlari")]
public class PineFaturaSatirlari : BaseEntity
{
    // ── Parent ────────────────────────────────────────────
    [Column("fts_fatura_uid")]
    public Guid FtsFaturaUid { get; set; }

    [Column("fts_satir_no")]
    public int FtsSatirNo { get; set; }

    /// <summary>1=Satis, 2=SatisIade, 3=Satinalma, 4=SatinalmaIade, 5=Proforma</summary>
    [Column("fts_tip")]
    public int FtsTip { get; set; }

    // ── Stock ─────────────────────────────────────────────
    [Column("fts_stok_kod")]
    [StringLength(25)]
    public string FtsStokKod { get; set; } = string.Empty;

    [Column("fts_stok_adi")]
    [StringLength(300)]
    public string? FtsStokAdi { get; set; }

    /// <summary>0=Stok, 1=Hizmet, 2=Masraf</summary>
    [Column("fts_stok_tipi")]
    public int FtsStokTipi { get; set; }

    // ── Quantity ──────────────────────────────────────────
    [Column("fts_miktar")]
    public decimal FtsMiktar { get; set; }

    [Column("fts_birim")]
    [StringLength(25)]
    public string? FtsBirim { get; set; }

    [Column("fts_miktar2")]
    public decimal FtsMiktar2 { get; set; }

    [Column("fts_birim2")]
    [StringLength(25)]
    public string? FtsBirim2 { get; set; }

    [Column("fts_cevirme_katsayisi")]
    public decimal FtsCevirmeKatsayisi { get; set; }

    // ── Price ─────────────────────────────────────────────
    [Column("fts_birim_fiyat")]
    public decimal FtsBirimFiyat { get; set; }

    [Column("fts_tutar")]
    public decimal FtsTutar { get; set; }

    // ── Discount ──────────────────────────────────────────
    [Column("fts_iskonto_orani1")]
    public decimal FtsIskontoOrani1 { get; set; }

    [Column("fts_iskonto_orani2")]
    public decimal FtsIskontoOrani2 { get; set; }

    [Column("fts_iskonto_orani3")]
    public decimal FtsIskontoOrani3 { get; set; }

    [Column("fts_iskonto_tutari")]
    public decimal FtsIskontoTutari { get; set; }

    [Column("fts_net_tutar")]
    public decimal FtsNetTutar { get; set; }

    // ── Tax ───────────────────────────────────────────────
    [Column("fts_kdv_orani")]
    public decimal FtsKdvOrani { get; set; }

    [Column("fts_kdv_tutari")]
    public decimal FtsKdvTutari { get; set; }

    [Column("fts_otv_orani")]
    public decimal FtsOtvOrani { get; set; }

    [Column("fts_otv_tutari")]
    public decimal FtsOtvTutari { get; set; }

    [Column("fts_tevkifat_kodu")]
    [StringLength(25)]
    public string? FtsTevkifatKodu { get; set; }

    [Column("fts_tevkifat_orani")]
    public decimal FtsTevkifatOrani { get; set; }

    [Column("fts_tevkifat_tutari")]
    public decimal FtsTevkifatTutari { get; set; }

    // ── Totals ────────────────────────────────────────────
    [Column("fts_satir_toplami")]
    public decimal FtsSatirToplami { get; set; }

    // ── Currency ──────────────────────────────────────────
    [Column("fts_doviz_cinsi")]
    [StringLength(5)]
    public string? FtsDovizCinsi { get; set; }

    [Column("fts_doviz_kuru")]
    public decimal FtsDovizKuru { get; set; }

    [Column("fts_tl_tutar")]
    public decimal FtsTlTutar { get; set; }

    [Column("fts_tl_net_tutar")]
    public decimal FtsTlNetTutar { get; set; }

    [Column("fts_tl_kdv_tutari")]
    public decimal FtsTlKdvTutari { get; set; }

    [Column("fts_tl_satir_toplami")]
    public decimal FtsTlSatirToplami { get; set; }

    // ── Location ──────────────────────────────────────────
    [Column("fts_depo_no")]
    public int FtsDepoNo { get; set; }

    // ── Reference ─────────────────────────────────────────
    [Column("fts_proje_kodu")]
    [StringLength(25)]
    public string? FtsProjeKodu { get; set; }

    [Column("fts_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? FtsSorumlulukMerkezi { get; set; }

    [Column("fts_siparis_uid")]
    public Guid? FtsSiparisUid { get; set; }

    [Column("fts_irsaliye_uid")]
    public Guid? FtsIrsaliyeUid { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("fts_aciklama")]
    [StringLength(500)]
    public string? FtsAciklama { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("fts_ozelkod1")]
    [StringLength(50)]
    public string? FtsOzelkod1 { get; set; }

    [Column("fts_ozelkod2")]
    [StringLength(50)]
    public string? FtsOzelkod2 { get; set; }
}
