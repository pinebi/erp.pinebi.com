using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.EFatura;

[Table("pine_efatura_giden")]
public class PineEFaturaGiden : BaseEntity
{
    [Column("efg_fatura_id")]
    public int EfgFaturaId { get; set; }

    [Column("efg_tarih")]
    public DateTime EfgTarih { get; set; }

    [Column("efg_fatura_tipi")]
    [StringLength(50)]
    public string? EfgFaturaTipi { get; set; }

    [Column("efg_fatura_no")]
    [StringLength(50)]
    public string? EfgFaturaNo { get; set; }

    [Column("efg_cari_kod")]
    [StringLength(25)]
    public string? EfgCariKod { get; set; }

    [Column("efg_cari_unvan")]
    [StringLength(300)]
    public string? EfgCariUnvan { get; set; }

    [Column("efg_ettn")]
    [StringLength(100)]
    public string? EfgEttn { get; set; }

    [Column("efg_gib_durumu")]
    [StringLength(50)]
    public string? EfgGibDurumu { get; set; }

    [Column("efg_gib_kodu")]
    [StringLength(50)]
    public string? EfgGibKodu { get; set; }

    [Column("efg_zarf_durumu")]
    [StringLength(50)]
    public string? EfgZarfDurumu { get; set; }

    [Column("efg_zarf_aciklama")]
    [StringLength(500)]
    public string? EfgZarfAciklama { get; set; }

    [Column("efg_onay_durumu")]
    [StringLength(50)]
    public string? EfgOnayDurumu { get; set; }

    [Column("efg_gonderim_tarihi")]
    public DateTime? EfgGonderimTarihi { get; set; }

    [Column("efg_url")]
    [StringLength(500)]
    public string? EfgUrl { get; set; }
}
