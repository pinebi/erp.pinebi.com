using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Arac;

[Table("pine_arac_bakim_kayitlari")]
public class PineAracBakimKayitlari : BaseEntity
{
    [Column("abk_plaka")]
    [StringLength(20)]
    public string? AbkPlaka { get; set; }

    [Column("abk_tarih")]
    public DateTime AbkTarih { get; set; }

    [Column("abk_islem")]
    [StringLength(200)]
    public string? AbkIslem { get; set; }

    [Column("abk_tutar")]
    public decimal AbkTutar { get; set; }

    [Column("abk_km")]
    public int? AbkKm { get; set; }

    [Column("abk_firma")]
    [StringLength(200)]
    public string? AbkFirma { get; set; }

    [Column("abk_aciklama")]
    [StringLength(500)]
    public string? AbkAciklama { get; set; }
}
