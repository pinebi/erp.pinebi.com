using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_uretim_operasyon_hareketleri")]
public class PineUretimOperasyonHareketleri : BaseEntity
{
    [Column("uoh_isemri_id")]
    public int UohIsemriId { get; set; }

    [Column("uoh_operasyon_kod")]
    [StringLength(25)]
    public string? UohOperasyonKod { get; set; }

    [Column("uoh_baslangic")]
    public DateTime UohBaslangic { get; set; }

    [Column("uoh_bitis")]
    public DateTime? UohBitis { get; set; }

    [Column("uoh_sure")]
    public decimal UohSure { get; set; }

    [Column("uoh_personel_kod")]
    [StringLength(25)]
    public string? UohPersonelKod { get; set; }

    [Column("uoh_durum")]
    [StringLength(50)]
    public string? UohDurum { get; set; }
}
