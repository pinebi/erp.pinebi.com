using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.EFatura;

[Table("pine_efatura_hata_kodlari")]
public class PineEFaturaHataKodlari : BaseEntity
{
    [Column("ehk_kod")]
    [StringLength(20)]
    public string? EhkKod { get; set; }

    [Column("ehk_aciklama")]
    [StringLength(500)]
    public string? EhkAciklama { get; set; }
}
