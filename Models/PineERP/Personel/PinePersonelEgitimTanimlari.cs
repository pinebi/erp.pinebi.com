using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_egitim_tanimlari")]
public class PinePersonelEgitimTanimlari : BaseEntity
{
    [Column("pet_kod")]
    [StringLength(25)]
    public string? PetKod { get; set; }

    [Column("pet_isim")]
    [StringLength(200)]
    public string? PetIsim { get; set; }

    [Column("pet_kategori")]
    [StringLength(100)]
    public string? PetKategori { get; set; }

    [Column("pet_sure_saat")]
    public int PetSureSaat { get; set; }

    [Column("pet_aciklama")]
    [StringLength(500)]
    public string? PetAciklama { get; set; }

    [Column("pet_aktif")]
    public bool PetAktif { get; set; }
}
