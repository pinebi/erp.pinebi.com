using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok karti fiyat tanimlari.
/// Her stok icin farkli fiyat gruplari tanimlanabilir (Perakende, Toptan, Bayi vb.)
/// </summary>
[Table("pine_stok_fiyatlari")]
public class PineStokFiyatlari : BaseEntity
{
    // ===== ILISKI =====

    [Column("sfy_stok_kod")]
    [StringLength(25)]
    public string SfyStokKod { get; set; } = string.Empty;

    [Column("sfy_fiyat_grubu")]
    public int SfyFiyatGrubu { get; set; } = 1;

    /// <summary>Depo kodu - NULL veya "" = genel fiyat, "DEPO-1" = depoya ozel</summary>
    [Column("sfy_depo_kod")]
    [StringLength(20)]
    public string? SfyDepoKod { get; set; }

    // ===== FIYAT BILGILERI =====

    [Column("sfy_fiyat")]
    public decimal SfyFiyat { get; set; } = 0;

    [Column("sfy_eski_fiyat")]
    public decimal SfyEskiFiyat { get; set; } = 0;

    [Column("sfy_min_fiyat")]
    public decimal SfyMinFiyat { get; set; } = 0;

    [Column("sfy_max_fiyat")]
    public decimal SfyMaxFiyat { get; set; } = 0;

    [Column("sfy_kar_marji")]
    public decimal SfyKarMarji { get; set; } = 0;

    [Column("sfy_alis_fiyati")]
    public decimal SfyAlisFiyati { get; set; } = 0;

    // ===== DOVIZ =====

    [Column("sfy_doviz_kodu")]
    [StringLength(10)]
    public string SfyDovizKodu { get; set; } = "TL";

    [Column("sfy_doviz_kuru")]
    public decimal SfyDovizKuru { get; set; } = 1;

    [Column("sfy_tl_karsiligi")]
    public decimal SfyTlKarsiligi { get; set; } = 0;

    // ===== KDV =====

    [Column("sfy_kdv_dahil")]
    public bool SfyKdvDahil { get; set; } = false;

    [Column("sfy_kdv_orani")]
    public decimal SfyKdvOrani { get; set; } = 0;

    [Column("sfy_kdv_tutari")]
    public decimal SfyKdvTutari { get; set; } = 0;

    [Column("sfy_kdv_dahil_fiyat")]
    public decimal SfyKdvDahilFiyat { get; set; } = 0;

    [Column("sfy_kdv_haric_fiyat")]
    public decimal SfyKdvHaricFiyat { get; set; } = 0;

    // ===== ISKONTO =====

    [Column("sfy_iskonto_orani1")]
    public decimal SfyIskontoOrani1 { get; set; } = 0;

    [Column("sfy_iskonto_orani2")]
    public decimal SfyIskontoOrani2 { get; set; } = 0;

    [Column("sfy_iskonto_orani3")]
    public decimal SfyIskontoOrani3 { get; set; } = 0;

    [Column("sfy_iskonto_tutari")]
    public decimal SfyIskontoTutari { get; set; } = 0;

    [Column("sfy_net_fiyat")]
    public decimal SfyNetFiyat { get; set; } = 0;

    // ===== GECERLILIK =====

    [Column("sfy_gecerlilik_baslangic")]
    public DateTime? SfyGecerlilikBaslangic { get; set; }

    [Column("sfy_gecerlilik_bitis")]
    public DateTime? SfyGecerlilikBitis { get; set; }

    [Column("sfy_aktif")]
    public bool SfyAktif { get; set; } = true;

    // ===== BIRIM FIYAT =====

    [Column("sfy_birim_kodu")]
    [StringLength(20)]
    public string? SfyBirimKodu { get; set; }

    [Column("sfy_birim_carpani")]
    public decimal SfyBirimCarpani { get; set; } = 1;

    // ===== MIKTAR BAZLI FIYAT =====

    [Column("sfy_min_miktar")]
    public decimal SfyMinMiktar { get; set; } = 0;

    [Column("sfy_max_miktar")]
    public decimal SfyMaxMiktar { get; set; } = 0;

    // ===== KAMPANYA =====

    [Column("sfy_kampanya_fiyati")]
    public bool SfyKampanyaFiyati { get; set; } = false;

    [Column("sfy_kampanya_kodu")]
    [StringLength(25)]
    public string? SfyKampanyaKodu { get; set; }

    [Column("sfy_kampanya_aciklama")]
    [StringLength(200)]
    public string? SfyKampanyaAciklama { get; set; }

    // ===== NOTLAR =====

    [Column("sfy_aciklama")]
    [StringLength(500)]
    public string? SfyAciklama { get; set; }

    [Column("sfy_not1")]
    [StringLength(500)]
    public string? SfyNot1 { get; set; }

    [Column("sfy_not2")]
    [StringLength(500)]
    public string? SfyNot2 { get; set; }

    // ===== ONAY =====

    [Column("sfy_onaylandi")]
    public bool SfyOnaylandi { get; set; } = false;

    [Column("sfy_onaylayan_kullanici")]
    [StringLength(200)]
    public string? SfyOnaylayanKullanici { get; set; }

    [Column("sfy_onay_tarihi")]
    public DateTime? SfyOnayTarihi { get; set; }
}
