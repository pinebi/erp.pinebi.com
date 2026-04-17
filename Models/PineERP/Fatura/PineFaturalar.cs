using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura ana tablosu.
/// Satis, satis iade, satinalma, satinalma iade ve proforma fatura bilgilerini tutar.
/// </summary>
[Table("pine_faturalar")]
public class PineFaturalar : BaseEntity
{
    // ── Type ──────────────────────────────────────────────
    /// <summary>1=Satis, 2=SatisIade, 3=Satinalma, 4=SatinalmaIade, 5=Proforma</summary>
    [Column("fat_tip")]
    public int FatTip { get; set; }

    /// <summary>0=Toptan, 1=Perakende</summary>
    [Column("fat_fatura_tipi")]
    public int FatFaturaTipi { get; set; }

    // ── Date ──────────────────────────────────────────────
    [Column("fat_tarih")]
    public DateTime FatTarih { get; set; }

    [Column("fat_sevk_tarihi")]
    public DateTime? FatSevkTarihi { get; set; }

    [Column("fat_vade_tarihi")]
    public DateTime? FatVadeTarihi { get; set; }

    // ── Document ──────────────────────────────────────────
    [Column("fat_evrak_seri")]
    [StringLength(5)]
    public string? FatEvrakSeri { get; set; }

    [Column("fat_evrak_sira")]
    public int FatEvrakSira { get; set; }

    [Column("fat_belge_no")]
    [StringLength(25)]
    public string? FatBelgeNo { get; set; }

    // ── Customer ──────────────────────────────────────────
    [Column("fat_cari_kod")]
    [StringLength(25)]
    public string FatCariKod { get; set; } = string.Empty;

    [Column("fat_cari_unvan")]
    [StringLength(300)]
    public string? FatCariUnvan { get; set; }

    // ── Payment ───────────────────────────────────────────
    [Column("fat_odeme_sekli")]
    [StringLength(50)]
    public string? FatOdemeSekli { get; set; }

    [Column("fat_odeme_tipi")]
    public int FatOdemeTipi { get; set; }

    // ── Currency ──────────────────────────────────────────
    [Column("fat_doviz_cinsi")]
    [StringLength(5)]
    public string? FatDovizCinsi { get; set; }

    [Column("fat_doviz_kuru")]
    public decimal FatDovizKuru { get; set; }

    [Column("fat_alt_doviz_kuru")]
    public decimal FatAltDovizKuru { get; set; }

    // ── Location ──────────────────────────────────────────
    [Column("fat_depo_no")]
    public int FatDepoNo { get; set; }

    [Column("fat_isyeri_no")]
    public int FatIsyeriNo { get; set; }

    // ── Assignment ────────────────────────────────────────
    [Column("fat_plasiyer_kodu")]
    [StringLength(25)]
    public string? FatPlasiyerKodu { get; set; }

    [Column("fat_proje_kodu")]
    [StringLength(25)]
    public string? FatProjeKodu { get; set; }

    [Column("fat_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? FatSorumlulukMerkezi { get; set; }

    // ── Totals (Doviz) ────────────────────────────────────
    [Column("fat_tutar")]
    public decimal FatTutar { get; set; }

    [Column("fat_toplam_iskonto")]
    public decimal FatToplamIskonto { get; set; }

    [Column("fat_kdv_matrahi")]
    public decimal FatKdvMatrahi { get; set; }

    [Column("fat_kdv_tutari")]
    public decimal FatKdvTutari { get; set; }

    [Column("fat_tevkifat_muafiyeti")]
    public decimal FatTevkifatMuafiyeti { get; set; }

    [Column("fat_toplam_tutar")]
    public decimal FatToplamTutar { get; set; }

    [Column("fat_odenecek_tutar")]
    public decimal FatOdenecekTutar { get; set; }

    // ── TL Totals ─────────────────────────────────────────
    [Column("fat_tl_tutar")]
    public decimal FatTlTutar { get; set; }

    [Column("fat_tl_kdv_matrahi")]
    public decimal FatTlKdvMatrahi { get; set; }

    [Column("fat_tl_kdv_tutari")]
    public decimal FatTlKdvTutari { get; set; }

    [Column("fat_tl_toplam_tutar")]
    public decimal FatTlToplamTutar { get; set; }

    [Column("fat_tl_odenecek_tutar")]
    public decimal FatTlOdenecekTutar { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("fat_aciklama1")]
    [StringLength(500)]
    public string? FatAciklama1 { get; set; }

    [Column("fat_aciklama2")]
    [StringLength(500)]
    public string? FatAciklama2 { get; set; }

    [Column("fat_aciklama3")]
    [StringLength(500)]
    public string? FatAciklama3 { get; set; }

    [Column("fat_aciklama4")]
    [StringLength(500)]
    public string? FatAciklama4 { get; set; }

    [Column("fat_aciklama5")]
    [StringLength(500)]
    public string? FatAciklama5 { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("fat_ozelkod1")]
    [StringLength(50)]
    public string? FatOzelkod1 { get; set; }

    [Column("fat_ozelkod2")]
    [StringLength(50)]
    public string? FatOzelkod2 { get; set; }

    [Column("fat_ozelkod3")]
    [StringLength(50)]
    public string? FatOzelkod3 { get; set; }

    // ── Status ────────────────────────────────────────────
    [Column("fat_durumu")]
    [StringLength(50)]
    public string? FatDurumu { get; set; }

    [Column("fat_kapandi_fl")]
    public bool FatKapandiFl { get; set; }

    [Column("fat_kapanma_tarihi")]
    public DateTime? FatKapanmaTarihi { get; set; }

    // ── E-Invoice ─────────────────────────────────────────
    [Column("fat_efatura_senaryo")]
    [StringLength(50)]
    public string? FatEfaturaSenaryo { get; set; }

    [Column("fat_efatura_tipi")]
    [StringLength(50)]
    public string? FatEfaturaTipi { get; set; }

    [Column("fat_ettn")]
    [StringLength(100)]
    public string? FatEttn { get; set; }

    [Column("fat_gib_durumu")]
    [StringLength(50)]
    public string? FatGibDurumu { get; set; }

    [Column("fat_zarf_durumu")]
    [StringLength(50)]
    public string? FatZarfDurumu { get; set; }

    [Column("fat_zarf_aciklama")]
    [StringLength(500)]
    public string? FatZarfAciklama { get; set; }

    // ── Shipping ──────────────────────────────────────────
    [Column("fat_sevk_adres_id")]
    public int? FatSevkAdresId { get; set; }

    [Column("fat_tasiyici_kodu")]
    [StringLength(25)]
    public string? FatTasiyiciKodu { get; set; }

    [Column("fat_tasiyici_plaka")]
    [StringLength(20)]
    public string? FatTasiyiciPlaka { get; set; }

    [Column("fat_sevk_yontemi")]
    [StringLength(50)]
    public string? FatSevkYontemi { get; set; }
}
