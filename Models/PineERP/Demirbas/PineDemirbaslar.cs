using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_demirbaslar")]
public class PineDemirbaslar : BaseEntity
{
    [Column("dmr_kod")]
    [StringLength(25)]
    public string? DmrKod { get; set; }

    [Column("dmr_isim")]
    [StringLength(200)]
    public string? DmrIsim { get; set; }

    [Column("dmr_grup_kodu")]
    [StringLength(25)]
    public string? DmrGrupKodu { get; set; }

    [Column("dmr_kategori")]
    [StringLength(100)]
    public string? DmrKategori { get; set; }

    [Column("dmr_marka")]
    [StringLength(100)]
    public string? DmrMarka { get; set; }

    [Column("dmr_model")]
    [StringLength(100)]
    public string? DmrModel { get; set; }

    [Column("dmr_seri_no")]
    [StringLength(100)]
    public string? DmrSeriNo { get; set; }

    [Column("dmr_alis_tarihi")]
    public DateTime? DmrAlisTarihi { get; set; }

    [Column("dmr_alis_fiyati")]
    public decimal DmrAlisFiyati { get; set; }

    [Column("dmr_doviz_cinsi")]
    [StringLength(5)]
    public string? DmrDovizCinsi { get; set; }

    [Column("dmr_amortisman_orani")]
    public decimal DmrAmortismanOrani { get; set; }

    [Column("dmr_amortisman_yontemi")]
    [StringLength(50)]
    public string? DmrAmortismanYontemi { get; set; }

    [Column("dmr_faydali_omur")]
    public int DmrFaydaliOmur { get; set; }

    [Column("dmr_garanti_bitis")]
    public DateTime? DmrGarantiBitis { get; set; }

    [Column("dmr_sorumlu_personel")]
    [StringLength(25)]
    public string? DmrSorumluPersonel { get; set; }

    [Column("dmr_lokasyon")]
    [StringLength(200)]
    public string? DmrLokasyon { get; set; }

    [Column("dmr_depo_no")]
    public int? DmrDepoNo { get; set; }

    [Column("dmr_durum")]
    [StringLength(50)]
    public string? DmrDurum { get; set; }

    [Column("dmr_resim_url")]
    [StringLength(500)]
    public string? DmrResimUrl { get; set; }

    [Column("dmr_aciklama")]
    [StringLength(500)]
    public string? DmrAciklama { get; set; }
}
