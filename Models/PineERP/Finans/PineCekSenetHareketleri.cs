using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Finans;

/// <summary>
/// Cek ve senet hareketleri tablosu.
/// Alinan/Verilen cek ve senetlerin tum yasam dongusunu tutar.
/// </summary>
[Table("pine_cek_senet_hareketleri")]
public class PineCekSenetHareketleri : BaseEntity
{
    // ===== TIP / CINS =====

    /// <summary>Tip: A=Alinan, V=Verilen</summary>
    [Column("csh_tip")]
    public char CshTip { get; set; }

    /// <summary>Cins: C=Cek, S=Senet</summary>
    [Column("csh_cins")]
    public char CshCins { get; set; }

    // ===== TARIH =====

    [Column("csh_tarih")]
    public DateTime CshTarih { get; set; }

    [Column("csh_vade_tarihi")]
    public DateTime? CshVadeTarihi { get; set; }

    // ===== CARI =====

    [Column("csh_cari_kod")]
    [StringLength(25)]
    public string? CshCariKod { get; set; }

    // ===== BANKA / SERI =====

    [Column("csh_banka")]
    [StringLength(100)]
    public string? CshBanka { get; set; }

    [Column("csh_sube")]
    [StringLength(100)]
    public string? CshSube { get; set; }

    [Column("csh_seri_no")]
    [StringLength(50)]
    public string? CshSeriNo { get; set; }

    // ===== TUTAR =====

    [Column("csh_tutar")]
    public decimal CshTutar { get; set; } = 0;

    // ===== DOVIZ =====

    [Column("csh_doviz_cinsi")]
    [StringLength(5)]
    public string? CshDovizCinsi { get; set; }

    [Column("csh_doviz_kuru")]
    public decimal CshDovizKuru { get; set; } = 0;

    // ===== DURUM =====

    /// <summary>Portfoyde, Tahsile, Teminata, Ciroya, TahsilEdildi, Karsilansiz</summary>
    [Column("csh_durumu")]
    [StringLength(50)]
    public string? CshDurumu { get; set; }

    // ===== CIRO BILGILERI =====

    [Column("csh_ciro_cari_kod")]
    [StringLength(25)]
    public string? CshCiroCariKod { get; set; }

    [Column("csh_ciro_tarih")]
    public DateTime? CshCiroTarih { get; set; }

    // ===== EVRAK BILGILERI =====

    [Column("csh_evrak_seri")]
    [StringLength(5)]
    public string? CshEvrakSeri { get; set; }

    [Column("csh_evrak_sira")]
    public int CshEvrakSira { get; set; } = 0;

    [Column("csh_belge_no")]
    [StringLength(25)]
    public string? CshBelgeNo { get; set; }

    [Column("csh_belge_tarih")]
    public DateTime? CshBelgeTarih { get; set; }

    // ===== REFERANS =====

    [Column("csh_proje_kodu")]
    [StringLength(25)]
    public string? CshProjeKodu { get; set; }

    [Column("csh_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? CshSorumlulukMerkezi { get; set; }

    [Column("csh_banka_hesap_kod")]
    [StringLength(25)]
    public string? CshBankaHesapKod { get; set; }

    // ===== BORDRO =====

    [Column("csh_bordro_no")]
    [StringLength(25)]
    public string? CshBordroNo { get; set; }

    [Column("csh_bordro_tarih")]
    public DateTime? CshBordroTarih { get; set; }

    // ===== KESIDE =====

    [Column("csh_keside_yeri")]
    [StringLength(100)]
    public string? CshKesideYeri { get; set; }

    [Column("csh_keside_tarihi")]
    public DateTime? CshKesideTarihi { get; set; }

    [Column("csh_kesideci")]
    [StringLength(200)]
    public string? CshKesideci { get; set; }

    // ===== ILISKILI BELGE =====

    [Column("csh_fatura_uid")]
    public Guid? CshFaturaUid { get; set; }

    // ===== ACIKLAMALAR =====

    [Column("csh_aciklama1")]
    [StringLength(500)]
    public string? CshAciklama1 { get; set; }

    [Column("csh_aciklama2")]
    [StringLength(500)]
    public string? CshAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("csh_ozelkod1")]
    [StringLength(50)]
    public string? CshOzelkod1 { get; set; }

    [Column("csh_ozelkod2")]
    [StringLength(50)]
    public string? CshOzelkod2 { get; set; }

    [Column("csh_ozelkod3")]
    [StringLength(50)]
    public string? CshOzelkod3 { get; set; }
}
