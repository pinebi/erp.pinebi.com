using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_puantaj")]
public class PinePersonelPuantaj : BaseEntity
{
    [Column("ppu_personel_kod")]
    [StringLength(25)]
    public string? PpuPersonelKod { get; set; }

    [Column("ppu_personel")]
    [StringLength(200)]
    public string? PpuPersonel { get; set; }

    [Column("ppu_yil")]
    public int PpuYil { get; set; }

    [Column("ppu_ay")]
    public int PpuAy { get; set; }

    [Column("ppu_ay_adi")]
    [StringLength(20)]
    public string? PpuAyAdi { get; set; }

    [Column("ppu_ay_gun")]
    public int PpuAyGun { get; set; }
}
