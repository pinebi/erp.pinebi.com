using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_plasiyerler")]
public class PinePlasiyerler : BaseEntity
{
    [Column("pls_kod")]
    [StringLength(25)]
    public string? PlsKod { get; set; }

    [Column("pls_isim")]
    [StringLength(200)]
    public string? PlsIsim { get; set; }

    [Column("pls_tel")]
    [StringLength(50)]
    public string? PlsTel { get; set; }

    [Column("pls_email")]
    [StringLength(200)]
    public string? PlsEmail { get; set; }

    [Column("pls_bolge")]
    [StringLength(100)]
    public string? PlsBolge { get; set; }

    [Column("pls_hedef_satis")]
    public decimal? PlsHedefSatis { get; set; }

    [Column("pls_aciklama")]
    [StringLength(500)]
    public string? PlsAciklama { get; set; }

    [Column("pls_aktif")]
    public bool PlsAktif { get; set; } = true;
}
