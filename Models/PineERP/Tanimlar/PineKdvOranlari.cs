using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_kdv_oranlari")]
public class PineKdvOranlari : BaseEntity
{
    [Column("kdo_oran")]
    public decimal KdoOran { get; set; }

    [Column("kdo_aciklama")]
    [StringLength(200)]
    public string? KdoAciklama { get; set; }

    [Column("kdo_baslangic_tarihi")]
    public DateTime? KdoBaslangicTarihi { get; set; }

    [Column("kdo_bitis_tarihi")]
    public DateTime? KdoBitisTarihi { get; set; }

    [Column("kdo_aktif")]
    public bool KdoAktif { get; set; } = true;
}
