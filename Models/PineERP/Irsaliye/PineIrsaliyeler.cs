using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Irsaliye;

/// <summary>
/// Irsaliye ana tablosu.
/// Satis ve satinalma irsaliyeleri bilgilerini tutar.
/// Fatura tablosuyla ayni yapidadir.
/// </summary>
[Table("pine_irsaliyeler")]
public class PineIrsaliyeler : BaseEntity
{
    // ── Type ──────────────────────────────────────────────
    /// <summary>1=Satis, 2=SatisIade, 3=Satinalma, 4=SatinalmaIade</summary>
    [Column("irs_tip")]
    public int IrsTip { get; set; }

    /// <summary>0=Toptan, 1=Perakende</summary>
    [Column("irs_irsaliye_tipi")]
    public int IrsIrsaliyeTipi { get; set; }

    // ── Date ──────────────────────────────────────────────
    [Column("irs_tarih")]
    public DateTime IrsTarih { get; set; }

    [Column("irs_sevk_tarihi")]
    public DateTime? IrsSevkTarihi { get; set; }

    [Column("irs_vade_tarihi")]
    public DateTime? IrsVadeTarihi { get; set; }

    // ── Document ──────────────────────────────────────────
    [Column("irs_evrak_seri")]
    [StringLength(5)]
    public string? IrsEvrakSeri { get; set; }

    [Column("irs_evrak_sira")]
    public int IrsEvrakSira { get; set; }

    [Column("irs_belge_no")]
    [StringLength(25)]
    public string? IrsBelgeNo { get; set; }

    // ── Customer ──────────────────────────────────────────
    [Column("irs_cari_kod")]
    [StringLength(25)]
    public string IrsCariKod { get; set; } = string.Empty;

    [Column("irs_cari_unvan")]
    [StringLength(300)]
    public string? IrsCariUnvan { get; set; }

    // ── Payment ───────────────────────────────────────────
    [Column("irs_odeme_sekli")]
    [StringLength(50)]
    public string? IrsOdemeSekli { get; set; }

    [Column("irs_odeme_tipi")]
    public int IrsOdemeTipi { get; set; }

    // ── Currency ──────────────────────────────────────────
    [Column("irs_doviz_cinsi")]
    [StringLength(5)]
    public string? IrsDovizCinsi { get; set; }

    [Column("irs_doviz_kuru")]
    public decimal IrsDovizKuru { get; set; }

    [Column("irs_alt_doviz_kuru")]
    public decimal IrsAltDovizKuru { get; set; }

    // ── Location ──────────────────────────────────────────
    [Column("irs_depo_no")]
    public int IrsDepoNo { get; set; }

    [Column("irs_isyeri_no")]
    public int IrsIsyeriNo { get; set; }

    // ── Assignment ────────────────────────────────────────
    [Column("irs_plasiyer_kodu")]
    [StringLength(25)]
    public string? IrsPlasiyerKodu { get; set; }

    [Column("irs_proje_kodu")]
    [StringLength(25)]
    public string? IrsProjeKodu { get; set; }

    [Column("irs_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? IrsSorumlulukMerkezi { get; set; }

    // ── Totals (Doviz) ────────────────────────────────────
    [Column("irs_tutar")]
    public decimal IrsTutar { get; set; }

    [Column("irs_toplam_iskonto")]
    public decimal IrsToplamIskonto { get; set; }

    [Column("irs_kdv_matrahi")]
    public decimal IrsKdvMatrahi { get; set; }

    [Column("irs_kdv_tutari")]
    public decimal IrsKdvTutari { get; set; }

    [Column("irs_tevkifat_muafiyeti")]
    public decimal IrsTevkifatMuafiyeti { get; set; }

    [Column("irs_toplam_tutar")]
    public decimal IrsToplamTutar { get; set; }

    [Column("irs_odenecek_tutar")]
    public decimal IrsOdenecekTutar { get; set; }

    // ── TL Totals ─────────────────────────────────────────
    [Column("irs_tl_tutar")]
    public decimal IrsTlTutar { get; set; }

    [Column("irs_tl_kdv_matrahi")]
    public decimal IrsTlKdvMatrahi { get; set; }

    [Column("irs_tl_kdv_tutari")]
    public decimal IrsTlKdvTutari { get; set; }

    [Column("irs_tl_toplam_tutar")]
    public decimal IrsTlToplamTutar { get; set; }

    [Column("irs_tl_odenecek_tutar")]
    public decimal IrsTlOdenecekTutar { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("irs_aciklama1")]
    [StringLength(500)]
    public string? IrsAciklama1 { get; set; }

    [Column("irs_aciklama2")]
    [StringLength(500)]
    public string? IrsAciklama2 { get; set; }

    [Column("irs_aciklama3")]
    [StringLength(500)]
    public string? IrsAciklama3 { get; set; }

    [Column("irs_aciklama4")]
    [StringLength(500)]
    public string? IrsAciklama4 { get; set; }

    [Column("irs_aciklama5")]
    [StringLength(500)]
    public string? IrsAciklama5 { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("irs_ozelkod1")]
    [StringLength(50)]
    public string? IrsOzelkod1 { get; set; }

    [Column("irs_ozelkod2")]
    [StringLength(50)]
    public string? IrsOzelkod2 { get; set; }

    [Column("irs_ozelkod3")]
    [StringLength(50)]
    public string? IrsOzelkod3 { get; set; }

    // ── Status ────────────────────────────────────────────
    [Column("irs_durumu")]
    [StringLength(50)]
    public string? IrsDurumu { get; set; }

    [Column("irs_kapandi_fl")]
    public bool IrsKapandiFl { get; set; }

    [Column("irs_kapanma_tarihi")]
    public DateTime? IrsKapanmaTarihi { get; set; }

    [Column("irs_faturalandi_fl")]
    public bool IrsFaturalandiFl { get; set; }

    [Column("irs_fatura_uid")]
    public Guid? IrsFaturaUid { get; set; }

    // ── E-Irsaliye ────────────────────────────────────────
    [Column("irs_eirsaliye_senaryo")]
    [StringLength(50)]
    public string? IrsEirsaliyeSenaryo { get; set; }

    [Column("irs_eirsaliye_tipi")]
    [StringLength(50)]
    public string? IrsEirsaliyeTipi { get; set; }

    [Column("irs_ettn")]
    [StringLength(100)]
    public string? IrsEttn { get; set; }

    [Column("irs_gib_durumu")]
    [StringLength(50)]
    public string? IrsGibDurumu { get; set; }

    [Column("irs_zarf_durumu")]
    [StringLength(50)]
    public string? IrsZarfDurumu { get; set; }

    [Column("irs_zarf_aciklama")]
    [StringLength(500)]
    public string? IrsZarfAciklama { get; set; }

    // ── Shipping ──────────────────────────────────────────
    [Column("irs_sevk_adres_id")]
    public int? IrsSevkAdresId { get; set; }

    [Column("irs_tasiyici_kodu")]
    [StringLength(25)]
    public string? IrsTasiyiciKodu { get; set; }

    [Column("irs_tasiyici_plaka")]
    [StringLength(20)]
    public string? IrsTasiyiciPlaka { get; set; }

    [Column("irs_sevk_yontemi")]
    [StringLength(50)]
    public string? IrsSevkYontemi { get; set; }
}
