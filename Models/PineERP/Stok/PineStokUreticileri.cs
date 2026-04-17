using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok uretici tanimlari. Urunlerin uretici/marka bilgilerini tutar.
/// </summary>
[Table("pine_stok_ureticileri")]
public class PineStokUreticileri : BaseEntity
{
    [Column("sur_kod")]
    [StringLength(25)]
    public string SurKod { get; set; } = string.Empty;

    [Column("sur_isim")]
    [StringLength(200)]
    public string SurIsim { get; set; } = string.Empty;

    [Column("sur_ulke")]
    [StringLength(50)]
    public string? SurUlke { get; set; }

    [Column("sur_tel")]
    [StringLength(50)]
    public string? SurTel { get; set; }

    [Column("sur_email")]
    [StringLength(200)]
    public string? SurEmail { get; set; }

    [Column("sur_aktif")]
    public bool SurAktif { get; set; } = true;
}
