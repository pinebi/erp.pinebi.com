using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_bankalar")]
public class PineBankalar : BaseEntity
{
    [Column("bnk_kod")]
    [StringLength(10)]
    public string? BnkKod { get; set; }

    [Column("bnk_isim")]
    [StringLength(200)]
    public string? BnkIsim { get; set; }

    [Column("bnk_swift")]
    [StringLength(20)]
    public string? BnkSwift { get; set; }

    [Column("bnk_ulke")]
    [StringLength(50)]
    public string? BnkUlke { get; set; }

    [Column("bnk_web")]
    [StringLength(200)]
    public string? BnkWeb { get; set; }

    [Column("bnk_aktif")]
    public bool BnkAktif { get; set; } = true;
}
