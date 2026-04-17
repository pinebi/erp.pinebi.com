using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok hareketleri tablosu.
/// Mikro ERP STOK_HAREKETLERI tablosuna denk gelir.
/// Tum stok giris/cikis hareketlerini detayli olarak tutar.
/// </summary>
[Table("pine_stok_hareketleri")]
public class PineStokHareketleri : BaseEntity
{
    // ===== SISTEM ALANLARI =====

    [Column("sth_stok_kod")]
    [StringLength(25)]
    public string SthStokKod { get; set; } = string.Empty;

    [Column("sth_tarih")]
    public DateTime SthTarih { get; set; }

    /// <summary>Hareket tipi: 1=Giris, 2=Cikis</summary>
    [Column("sth_tip")]
    public int SthTip { get; set; }

    // ===== HAREKET CINSI =====

    /// <summary>Hareket cinsi: 1=Fatura, 2=Irsaliye, 3=Siparis, 4=Depo Transfer, 5=Sayim, 6=Fire</summary>
    [Column("sth_cins")]
    public int SthCins { get; set; }

    /// <summary>0=Normal, 1=Iade</summary>
    [Column("sth_normal_iade")]
    public int SthNormalIade { get; set; } = 0;

    // ===== EVRAK BILGILERI =====

    [Column("sth_evrak_seri")]
    [StringLength(5)]
    public string? SthEvrakSeri { get; set; }

    [Column("sth_evrak_sira")]
    public int SthEvrakSira { get; set; } = 0;

    [Column("sth_satir_no")]
    public int SthSatirNo { get; set; } = 0;

    [Column("sth_belge_no")]
    [StringLength(25)]
    public string? SthBelgeNo { get; set; }

    [Column("sth_belge_tarih")]
    public DateTime? SthBelgeTarih { get; set; }

    // ===== MIKTAR / BIRIM =====

    [Column("sth_miktar")]
    public decimal SthMiktar { get; set; } = 0;

    [Column("sth_birim")]
    [StringLength(20)]
    public string? SthBirim { get; set; }

    /// <summary>Birim pointer: 1=Birim1, 2=Birim2, 3=Birim3</summary>
    [Column("sth_birim_pntr")]
    public int SthBirimPntr { get; set; } = 1;

    // ===== FIYAT / TUTAR =====

    [Column("sth_tutar")]
    public decimal SthTutar { get; set; } = 0;

    [Column("sth_iskonto1")]
    public decimal SthIskonto1 { get; set; } = 0;

    [Column("sth_iskonto2")]
    public decimal SthIskonto2 { get; set; } = 0;

    [Column("sth_iskonto3")]
    public decimal SthIskonto3 { get; set; } = 0;

    [Column("sth_iskonto4")]
    public decimal SthIskonto4 { get; set; } = 0;

    [Column("sth_iskonto5")]
    public decimal SthIskonto5 { get; set; } = 0;

    [Column("sth_iskonto6")]
    public decimal SthIskonto6 { get; set; } = 0;

    [Column("sth_iskonto_tutari")]
    public decimal SthIskontoTutari { get; set; } = 0;

    // ===== VERGI =====

    /// <summary>Vergi pointer / KDV grubu</summary>
    [Column("sth_vergi_pntr")]
    public int SthVergiPntr { get; set; } = 0;

    [Column("sth_vergi")]
    public decimal SthVergi { get; set; } = 0;

    [Column("sth_vergi_tutari")]
    public decimal SthVergiTutari { get; set; } = 0;

    // ===== AGIRLIK =====

    [Column("sth_net_agirlik")]
    public decimal SthNetAgirlik { get; set; } = 0;

    [Column("sth_brut_agirlik")]
    public decimal SthBrutAgirlik { get; set; } = 0;

    // ===== DEPO / LOKASYON =====

    [Column("sth_depo_no")]
    public int SthDepoNo { get; set; } = 0;

    [Column("sth_raf_kodu")]
    [StringLength(25)]
    public string? SthRafKodu { get; set; }

    // ===== REFERANS BILGILERI =====

    [Column("sth_cari_kod")]
    [StringLength(25)]
    public string? SthCariKod { get; set; }

    [Column("sth_proje_kodu")]
    [StringLength(25)]
    public string? SthProjeKodu { get; set; }

    [Column("sth_sorumluluk_merkezi")]
    [StringLength(25)]
    public string? SthSorumlulukMerkezi { get; set; }

    [Column("sth_plasiyer_kodu")]
    [StringLength(25)]
    public string? SthPlasiyerKodu { get; set; }

    // ===== TAKIP BILGILERI =====

    [Column("sth_parti_kodu")]
    [StringLength(50)]
    public string? SthPartiKodu { get; set; }

    [Column("sth_lot_no")]
    [StringLength(50)]
    public string? SthLotNo { get; set; }

    [Column("sth_seri_no")]
    [StringLength(50)]
    public string? SthSeriNo { get; set; }

    // ===== DOVIZ =====

    [Column("sth_doviz_cinsi")]
    [StringLength(5)]
    public string? SthDovizCinsi { get; set; }

    [Column("sth_doviz_kuru")]
    public decimal SthDovizKuru { get; set; } = 0;

    [Column("sth_alt_doviz_kuru")]
    public decimal SthAltDovizKuru { get; set; } = 0;

    // ===== ILISKILI BELGELER =====

    [Column("sth_fatura_uid")]
    public Guid? SthFaturaUid { get; set; }

    [Column("sth_siparis_uid")]
    public Guid? SthSiparisUid { get; set; }

    [Column("sth_irsaliye_uid")]
    public Guid? SthIrsaliyeUid { get; set; }

    // ===== NOTLAR =====

    [Column("sth_aciklama1")]
    [StringLength(500)]
    public string? SthAciklama1 { get; set; }

    [Column("sth_aciklama2")]
    [StringLength(500)]
    public string? SthAciklama2 { get; set; }

    // ===== OZEL KODLAR =====

    [Column("sth_ozelkod1")]
    [StringLength(50)]
    public string? SthOzelkod1 { get; set; }

    [Column("sth_ozelkod2")]
    [StringLength(50)]
    public string? SthOzelkod2 { get; set; }

    [Column("sth_ozelkod3")]
    [StringLength(50)]
    public string? SthOzelkod3 { get; set; }

    // ===== DIS TICARET =====

    [Column("sth_exim_kodu")]
    [StringLength(25)]
    public string? SthEximKodu { get; set; }

    [Column("sth_gtip_kodu")]
    [StringLength(20)]
    public string? SthGtipKodu { get; set; }
}
