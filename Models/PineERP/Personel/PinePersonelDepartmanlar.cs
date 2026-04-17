using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_departmanlar")]
public class PinePersonelDepartmanlar : BaseEntity
{
    [Column("pde_kod")]
    [StringLength(25)]
    public string? PdeKod { get; set; }

    [Column("pde_isim")]
    [StringLength(100)]
    public string? PdeIsim { get; set; }

    [Column("pde_ust_kod")]
    [StringLength(25)]
    public string? PdeUstKod { get; set; }

    [Column("pde_sorumlu")]
    [StringLength(100)]
    public string? PdeSorumlu { get; set; }

    [Column("pde_aktif")]
    public bool PdeAktif { get; set; }
}
