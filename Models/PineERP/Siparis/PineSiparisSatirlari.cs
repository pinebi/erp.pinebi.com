using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Siparis;

/// <summary>
/// Siparis satir detaylari.
/// Her siparisteki urun/hizmet satirlarini tutar.
/// FaturaSatirlari ile ayni yapida.
/// </summary>
[Table("pine_siparis_satirlari")]
public class PineSiparisSatirlari : BaseEntity
{
    // ===== BAGLANTI =====

    [Column("sst_siparis_id")]
    public int SstSiparisId { get; set; }

    [Column("sst_siparis_uid")]
    public Guid? SstSiparisUid { get; set; }

    [Column("sst_satir_no")]
    public int SstSatirNo { get; set; } = 0;

    // ===== STOK BILGILERI =====

    [Column("sst_stok_kod")]
    [StringLength(25)]
    public string SstStokKod { get; set; } = string.Empty;

    [Column("sst_stok_isim")]
    [StringLength(200)]
    public string? SstStokIsim { get; set; }

    // ===== MIKTAR / BIRIM =====

    [Column("sst_miktar")]
    public decimal SstMiktar { get; set; } = 0;

    [Column("sst_teslim_miktar")]
    public decimal SstTeslimMiktar { get; set; } = 0;

    [Column("sst_kalan_miktar")]
    public decimal SstKalanMiktar { get; set; } = 0;

    [Column("sst_birim")]
    [StringLength(20)]
    public string? SstBirim { get; set; }

    [Column("sst_birim_pntr")]
    public int SstBirimPntr { get; set; } = 1;

    // ===== FIYAT =====

    [Column("sst_birim_fiyat")]
    public decimal SstBirimFiyat { get; set; } = 0;

    [Column("sst_tutar")]
    public decimal SstTutar { get; set; } = 0;

    // ===== ISKONTO =====

    [Column("sst_iskonto1")]
    public decimal SstIskonto1 { get; set; } = 0;

    [Column("sst_iskonto2")]
    public decimal SstIskonto2 { get; set; } = 0;

    [Column("sst_iskonto3")]
    public decimal SstIskonto3 { get; set; } = 0;

    [Column("sst_iskonto4")]
    public decimal SstIskonto4 { get; set; } = 0;

    [Column("sst_iskonto5")]
    public decimal SstIskonto5 { get; set; } = 0;

    [Column("sst_iskonto6")]
    public decimal SstIskonto6 { get; set; } = 0;

    [Column("sst_iskonto_tutari")]
    public decimal SstIskontoTutari { get; set; } = 0;

    // ===== VERGI =====

    [Column("sst_vergi_pntr")]
    public int SstVergiPntr { get; set; } = 0;

    [Column("sst_vergi")]
    public decimal SstVergi { get; set; } = 0;

    [Column("sst_vergi_tutari")]
    public decimal SstVergiTutari { get; set; } = 0;

    [Column("sst_otv_tutari")]
    public decimal SstOtvTutari { get; set; } = 0;

    [Column("sst_tevkifat_kodu")]
    [StringLength(25)]
    public string? SstTevkifatKodu { get; set; }

    [Column("sst_tevkifat_tutari")]
    public decimal SstTevkifatTutari { get; set; } = 0;

    // ===== NET TUTAR =====

    [Column("sst_net_tutar")]
    public decimal SstNetTutar { get; set; } = 0;

    // ===== AGIRLIK =====

    [Column("sst_net_agirlik")]
    public decimal SstNetAgirlik { get; set; } = 0;

    [Column("sst_brut_agirlik")]
    public decimal SstBrutAgirlik { get; set; } = 0;

    // ===== DEPO / LOKASYON =====

    [Column("sst_depo_no")]
    public int SstDepoNo { get; set; } = 0;

    [Column("sst_raf_kodu")]
    [StringLength(25)]
    public string? SstRafKodu { get; set; }

    // ===== DOVIZ =====

    [Column("sst_doviz_cinsi")]
    [StringLength(5)]
    public string? SstDovizCinsi { get; set; }

    [Column("sst_doviz_kuru")]
    public decimal SstDovizKuru { get; set; } = 0;

    // ===== REFERANS =====

    [Column("sst_proje_kodu")]
    [StringLength(25)]
    public string? SstProjeKodu { get; set; }

    [Column("sst_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? SstSorumlulukMerkezi { get; set; }

    // ===== TAKIP =====

    [Column("sst_parti_kodu")]
    [StringLength(50)]
    public string? SstPartiKodu { get; set; }

    [Column("sst_lot_no")]
    [StringLength(50)]
    public string? SstLotNo { get; set; }

    [Column("sst_seri_no")]
    [StringLength(50)]
    public string? SstSeriNo { get; set; }

    // ===== NOTLAR =====

    [Column("sst_aciklama1")]
    [StringLength(500)]
    public string? SstAciklama1 { get; set; }

    [Column("sst_aciklama2")]
    [StringLength(500)]
    public string? SstAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("sst_ozelkod1")]
    [StringLength(50)]
    public string? SstOzelkod1 { get; set; }

    [Column("sst_ozelkod2")]
    [StringLength(50)]
    public string? SstOzelkod2 { get; set; }

    [Column("sst_ozelkod3")]
    [StringLength(50)]
    public string? SstOzelkod3 { get; set; }
}
