using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_pozisyonlar")]
public class PinePersonelPozisyonlar : BaseEntity
{
    [Column("ppo_kod")]
    [StringLength(25)]
    public string? PpoKod { get; set; }

    [Column("ppo_isim")]
    [StringLength(100)]
    public string? PpoIsim { get; set; }

    [Column("ppo_departman_kod")]
    [StringLength(25)]
    public string? PpoDepartmanKod { get; set; }

    [Column("ppo_aktif")]
    public bool PpoAktif { get; set; }
}
