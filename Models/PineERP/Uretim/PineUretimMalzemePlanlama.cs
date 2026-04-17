using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_uretim_malzeme_planlama")]
public class PineUretimMalzemePlanlama : BaseEntity
{
    [Column("ump_stok_kod")]
    [StringLength(25)]
    public string? UmpStokKod { get; set; }

    [Column("ump_gerekli_miktar")]
    public decimal UmpGerekliMiktar { get; set; }

    [Column("ump_mevcut_miktar")]
    public decimal UmpMevcutMiktar { get; set; }

    [Column("ump_eksik_miktar")]
    public decimal UmpEksikMiktar { get; set; }

    [Column("ump_siparis_tarihi")]
    public DateTime? UmpSiparisTarihi { get; set; }

    [Column("ump_termin_tarihi")]
    public DateTime? UmpTerminTarihi { get; set; }
}
