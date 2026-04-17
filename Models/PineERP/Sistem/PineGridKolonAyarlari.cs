using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_grid_kolon_ayarlari")]
public class PineGridKolonAyarlari : BaseEntity
{
    [Column("gka_sirket_kodu")]
    public int GkaSirketKodu { get; set; }

    [Column("gka_kullanici_id")]
    public int GkaKullaniciId { get; set; }

    [Column("gka_form_adi")]
    [StringLength(100)]
    public string? GkaFormAdi { get; set; }

    [Column("gka_kolon_id")]
    [StringLength(100)]
    public string? GkaKolonId { get; set; }

    [Column("gka_gorunur")]
    public bool GkaGorunur { get; set; } = true;

    [Column("gka_genislik")]
    public int? GkaGenislik { get; set; }

    [Column("gka_sira")]
    public int? GkaSira { get; set; }
}
