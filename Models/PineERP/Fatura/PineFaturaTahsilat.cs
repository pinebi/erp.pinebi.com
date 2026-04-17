using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura tahsilat/odeme kayitlari.
/// Bir faturaya yapilan tahsilat veya odeme islemleri.
/// </summary>
[Table("pine_fatura_tahsilat")]
public class PineFaturaTahsilat : BaseEntity
{
    [Column("fth_fatura_uid")]
    public Guid FthFaturaUid { get; set; }

    [Column("fth_tarih")]
    public DateTime FthTarih { get; set; }

    /// <summary>0=Tahsilat, 1=Odeme</summary>
    [Column("fth_tip")]
    public int FthTip { get; set; }

    /// <summary>1=Nakit, 2=Havale, 3=KrediKarti, 4=Cek, 5=Senet</summary>
    [Column("fth_odeme_sekli")]
    public int FthOdemeSekli { get; set; }

    [Column("fth_tutar")]
    public decimal FthTutar { get; set; }

    [Column("fth_doviz_cinsi")]
    [StringLength(5)]
    public string? FthDovizCinsi { get; set; }

    [Column("fth_doviz_kuru")]
    public decimal FthDovizKuru { get; set; }

    [Column("fth_tl_tutar")]
    public decimal FthTlTutar { get; set; }

    [Column("fth_kasa_kodu")]
    [StringLength(25)]
    public string? FthKasaKodu { get; set; }

    [Column("fth_banka_kodu")]
    [StringLength(25)]
    public string? FthBankaKodu { get; set; }

    [Column("fth_belge_no")]
    [StringLength(25)]
    public string? FthBelgeNo { get; set; }

    [Column("fth_vade_tarihi")]
    public DateTime? FthVadeTarihi { get; set; }

    [Column("fth_cari_hareket_uid")]
    public Guid? FthCariHareketUid { get; set; }

    [Column("fth_aciklama")]
    [StringLength(500)]
    public string? FthAciklama { get; set; }
}
