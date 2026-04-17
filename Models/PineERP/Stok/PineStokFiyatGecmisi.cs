using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok fiyat degisiklik gecmisi.
/// Her fiyat degisikligi loglanir, eski/yeni fiyat ve degisim orani saklanir.
/// </summary>
[Table("pine_stok_fiyat_gecmisi")]
public class PineStokFiyatGecmisi : BaseEntity
{
    [Column("sfg_stok_kod")]
    [StringLength(25)]
    public string SfgStokKod { get; set; } = string.Empty;

    [Column("sfg_fiyat_grubu")]
    public int SfgFiyatGrubu { get; set; }

    [Column("sfg_eski_fiyat")]
    public decimal SfgEskiFiyat { get; set; } = 0;

    [Column("sfg_yeni_fiyat")]
    public decimal SfgYeniFiyat { get; set; } = 0;

    [Column("sfg_degisim_orani")]
    public decimal SfgDegisimOrani { get; set; } = 0;

    [Column("sfg_doviz_kodu")]
    [StringLength(10)]
    public string? SfgDovizKodu { get; set; }

    [Column("sfg_degisiklik_nedeni")]
    [StringLength(500)]
    public string? SfgDegisiklikNedeni { get; set; }

    [Column("sfg_degisiklik_tarihi")]
    public DateTime SfgDegisiklikTarihi { get; set; } = DateTime.Now;

    [Column("sfg_degistiren_kullanici")]
    [StringLength(200)]
    public string? SfgDegistirenKullanici { get; set; }
}
