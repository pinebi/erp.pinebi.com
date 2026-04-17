using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_isemri_stok_tuketimleri")]
public class PineIsEmriStokTuketimleri : BaseEntity
{
    [Column("ist_isemri_id")]
    public int IstIsemriId { get; set; }

    [Column("ist_stok_kod")]
    [StringLength(25)]
    public string? IstStokKod { get; set; }

    [Column("ist_miktar")]
    public decimal IstMiktar { get; set; }

    [Column("ist_birim")]
    [StringLength(20)]
    public string? IstBirim { get; set; }

    [Column("ist_tarih")]
    public DateTime? IstTarih { get; set; }

    [Column("ist_aciklama")]
    [StringLength(500)]
    public string? IstAciklama { get; set; }
}
