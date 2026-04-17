using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_puantaj_gunluk")]
public class PinePersonelPuantajGunluk : BaseEntity
{
    [Column("ppg_puantaj_id")]
    public int PpgPuantajId { get; set; }

    [Column("ppg_gun")]
    public int PpgGun { get; set; }

    [Column("ppg_durum")]
    [StringLength(5)]
    public string? PpgDurum { get; set; }

    [Column("ppg_saat")]
    public decimal? PpgSaat { get; set; }

    [Column("ppg_mesai")]
    public decimal? PpgMesai { get; set; }

    [Column("ppg_aciklama")]
    [StringLength(200)]
    public string? PpgAciklama { get; set; }
}
