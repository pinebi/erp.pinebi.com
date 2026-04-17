using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Teklif;

/// <summary>
/// Teklif satir detaylari.
/// Her teklifteki urun/hizmet satirlarini tutar.
/// FaturaSatirlari ile ayni yapida + onaylanan miktar alani.
/// </summary>
[Table("pine_teklif_satirlari")]
public class PineTeklifSatirlari : BaseEntity
{
    // ===== BAGLANTI =====

    [Column("tks_teklif_id")]
    public int TksTeklifId { get; set; }

    [Column("tks_teklif_uid")]
    public Guid? TksTeklifUid { get; set; }

    [Column("tks_satir_no")]
    public int TksSatirNo { get; set; } = 0;

    // ===== STOK BILGILERI =====

    [Column("tks_stok_kod")]
    [StringLength(25)]
    public string TksStokKod { get; set; } = string.Empty;

    [Column("tks_stok_isim")]
    [StringLength(200)]
    public string? TksStokIsim { get; set; }

    // ===== MIKTAR / BIRIM =====

    [Column("tks_miktar")]
    public decimal TksMiktar { get; set; } = 0;

    [Column("tks_onaylanan_miktar")]
    public decimal TksOnaylananMiktar { get; set; } = 0;

    [Column("tks_birim")]
    [StringLength(20)]
    public string? TksBirim { get; set; }

    [Column("tks_birim_pntr")]
    public int TksBirimPntr { get; set; } = 1;

    // ===== FIYAT =====

    [Column("tks_birim_fiyat")]
    public decimal TksBirimFiyat { get; set; } = 0;

    [Column("tks_tutar")]
    public decimal TksTutar { get; set; } = 0;

    // ===== ISKONTO =====

    [Column("tks_iskonto1")]
    public decimal TksIskonto1 { get; set; } = 0;

    [Column("tks_iskonto2")]
    public decimal TksIskonto2 { get; set; } = 0;

    [Column("tks_iskonto3")]
    public decimal TksIskonto3 { get; set; } = 0;

    [Column("tks_iskonto4")]
    public decimal TksIskonto4 { get; set; } = 0;

    [Column("tks_iskonto5")]
    public decimal TksIskonto5 { get; set; } = 0;

    [Column("tks_iskonto6")]
    public decimal TksIskonto6 { get; set; } = 0;

    [Column("tks_iskonto_tutari")]
    public decimal TksIskontoTutari { get; set; } = 0;

    // ===== VERGI =====

    [Column("tks_vergi_pntr")]
    public int TksVergiPntr { get; set; } = 0;

    [Column("tks_vergi")]
    public decimal TksVergi { get; set; } = 0;

    [Column("tks_vergi_tutari")]
    public decimal TksVergiTutari { get; set; } = 0;

    [Column("tks_otv_tutari")]
    public decimal TksOtvTutari { get; set; } = 0;

    [Column("tks_tevkifat_kodu")]
    [StringLength(25)]
    public string? TksTevkifatKodu { get; set; }

    [Column("tks_tevkifat_tutari")]
    public decimal TksTevkifatTutari { get; set; } = 0;

    // ===== NET TUTAR =====

    [Column("tks_net_tutar")]
    public decimal TksNetTutar { get; set; } = 0;

    // ===== AGIRLIK =====

    [Column("tks_net_agirlik")]
    public decimal TksNetAgirlik { get; set; } = 0;

    [Column("tks_brut_agirlik")]
    public decimal TksBrutAgirlik { get; set; } = 0;

    // ===== DEPO / LOKASYON =====

    [Column("tks_depo_no")]
    public int TksDepoNo { get; set; } = 0;

    [Column("tks_raf_kodu")]
    [StringLength(25)]
    public string? TksRafKodu { get; set; }

    // ===== DOVIZ =====

    [Column("tks_doviz_cinsi")]
    [StringLength(5)]
    public string? TksDovizCinsi { get; set; }

    [Column("tks_doviz_kuru")]
    public decimal TksDovizKuru { get; set; } = 0;

    // ===== REFERANS =====

    [Column("tks_proje_kodu")]
    [StringLength(25)]
    public string? TksProjeKodu { get; set; }

    [Column("tks_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? TksSorumlulukMerkezi { get; set; }

    // ===== TAKIP =====

    [Column("tks_parti_kodu")]
    [StringLength(50)]
    public string? TksPartiKodu { get; set; }

    [Column("tks_lot_no")]
    [StringLength(50)]
    public string? TksLotNo { get; set; }

    [Column("tks_seri_no")]
    [StringLength(50)]
    public string? TksSeriNo { get; set; }

    // ===== NOTLAR =====

    [Column("tks_aciklama1")]
    [StringLength(500)]
    public string? TksAciklama1 { get; set; }

    [Column("tks_aciklama2")]
    [StringLength(500)]
    public string? TksAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("tks_ozelkod1")]
    [StringLength(50)]
    public string? TksOzelkod1 { get; set; }

    [Column("tks_ozelkod2")]
    [StringLength(50)]
    public string? TksOzelkod2 { get; set; }

    [Column("tks_ozelkod3")]
    [StringLength(50)]
    public string? TksOzelkod3 { get; set; }
}
