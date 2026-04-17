using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_uretim_operasyonlari")]
public class PineUretimOperasyonlari : BaseEntity
{
    [Column("uop_kod")]
    [StringLength(25)]
    public string? UopKod { get; set; }

    [Column("uop_isim")]
    [StringLength(200)]
    public string? UopIsim { get; set; }

    [Column("uop_is_merkezi")]
    [StringLength(100)]
    public string? UopIsMerkezi { get; set; }

    [Column("uop_standart_sure")]
    public decimal UopStandartSure { get; set; }

    [Column("uop_maliyet")]
    public decimal UopMaliyet { get; set; }

    [Column("uop_aktif")]
    public bool UopAktif { get; set; }
}
