using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_iller")]
public class PineIller : BaseEntity
{
    [Column("il_plaka")]
    public int IlPlaka { get; set; }

    [Column("il_adi")]
    [StringLength(50)]
    public string IlAdi { get; set; } = string.Empty;
}
