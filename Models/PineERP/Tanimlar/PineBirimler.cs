using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_birimler")]
public class PineBirimler : BaseEntity
{
    [Column("bir_kod")]
    [StringLength(20)]
    public string? BirKod { get; set; }

    [Column("bir_isim")]
    [StringLength(50)]
    public string? BirIsim { get; set; }

    [Column("bir_aciklama")]
    [StringLength(200)]
    public string? BirAciklama { get; set; }

    [Column("bir_carpan_ana")]
    public decimal? BirCarpanAna { get; set; }

    [Column("bir_aktif")]
    public bool BirAktif { get; set; } = true;
}
