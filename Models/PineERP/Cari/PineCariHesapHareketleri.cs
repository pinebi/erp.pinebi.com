using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesap hareketleri.
/// Borc/alacak islemleri, fatura, tahsilat, odeme vb. hareketleri tutar.
/// </summary>
[Table("pine_cari_hesap_hareketleri")]
public class PineCariHesapHareketleri : BaseEntity
{
    // ── Core ──────────────────────────────────────────────
    [Column("cha_cari_kod")]
    [StringLength(25)]
    public string ChaCariKod { get; set; } = string.Empty;

    [Column("cha_tarih")]
    public DateTime ChaTarih { get; set; }

    /// <summary>0=Borc, 1=Alacak</summary>
    [Column("cha_tip")]
    public int ChaTip { get; set; }

    // ── Type ──────────────────────────────────────────────
    /// <summary>1=Nakit, 2=Havale, 3=KrediKarti, 4=Cek, 5=Senet, 6=Fatura, 7=Virman</summary>
    [Column("cha_cins")]
    public int ChaCins { get; set; }

    // ── Document ──────────────────────────────────────────
    [Column("cha_evrak_seri")]
    [StringLength(5)]
    public string? ChaEvrakSeri { get; set; }

    [Column("cha_evrak_sira")]
    public int ChaEvrakSira { get; set; }

    [Column("cha_satir_no")]
    public int ChaSatirNo { get; set; }

    [Column("cha_belge_no")]
    [StringLength(25)]
    public string? ChaBelgeNo { get; set; }

    [Column("cha_belge_tarih")]
    public DateTime? ChaBelgeTarih { get; set; }

    [Column("cha_vade_tarihi")]
    public DateTime? ChaVadeTarihi { get; set; }

    // ── Amount ────────────────────────────────────────────
    [Column("cha_meblag")]
    public decimal ChaMeblag { get; set; }

    [Column("cha_meblag_doviz")]
    public decimal ChaMeblagDoviz { get; set; }

    // ── Currency ──────────────────────────────────────────
    [Column("cha_doviz_cinsi")]
    [StringLength(5)]
    public string? ChaDovizCinsi { get; set; }

    [Column("cha_doviz_kuru")]
    public decimal ChaDovizKuru { get; set; }

    [Column("cha_alt_doviz_kuru")]
    public decimal ChaAltDovizKuru { get; set; }

    // ── Reference ─────────────────────────────────────────
    [Column("cha_kasa_kodu")]
    [StringLength(25)]
    public string? ChaKasaKodu { get; set; }

    [Column("cha_banka_kodu")]
    [StringLength(25)]
    public string? ChaBankaKodu { get; set; }

    [Column("cha_proje_kodu")]
    [StringLength(25)]
    public string? ChaProjeKodu { get; set; }

    [Column("cha_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? ChaSorumlulukMerkezi { get; set; }

    [Column("cha_plasiyer_kodu")]
    [StringLength(25)]
    public string? ChaPlasiyerKodu { get; set; }

    // ── Location ──────────────────────────────────────────
    [Column("cha_depo_no")]
    public int ChaDepoNo { get; set; }

    [Column("cha_isyeri_no")]
    public int ChaIsyeriNo { get; set; }

    // ── Links ─────────────────────────────────────────────
    [Column("cha_fatura_uid")]
    public Guid? ChaFaturaUid { get; set; }

    [Column("cha_siparis_uid")]
    public Guid? ChaSiparisUid { get; set; }

    // ── Notes ─────────────────────────────────────────────
    [Column("cha_aciklama1")]
    [StringLength(500)]
    public string? ChaAciklama1 { get; set; }

    [Column("cha_aciklama2")]
    [StringLength(500)]
    public string? ChaAciklama2 { get; set; }

    // ── Custom ────────────────────────────────────────────
    [Column("cha_ozelkod1")]
    [StringLength(50)]
    public string? ChaOzelkod1 { get; set; }

    [Column("cha_ozelkod2")]
    [StringLength(50)]
    public string? ChaOzelkod2 { get; set; }

    [Column("cha_ozelkod3")]
    [StringLength(50)]
    public string? ChaOzelkod3 { get; set; }
}
