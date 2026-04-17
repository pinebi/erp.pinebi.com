using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_satinalma_talepleri")]
public class PineSatinalmaTalepleri : BaseEntity
{
    [Column("stl_no")]
    [StringLength(25)]
    public string? StlNo { get; set; }

    [Column("stl_tarih")]
    public DateTime? StlTarih { get; set; }

    [Column("stl_proje_kod")]
    [StringLength(25)]
    public string? StlProjeKod { get; set; }

    [Column("stl_talep_eden")]
    [StringLength(200)]
    public string? StlTalepEden { get; set; }

    [Column("stl_departman")]
    [StringLength(100)]
    public string? StlDepartman { get; set; }

    [Column("stl_oncelik")]
    [StringLength(50)]
    public string? StlOncelik { get; set; }

    [Column("stl_durum")]
    [StringLength(50)]
    public string? StlDurum { get; set; }

    [Column("stl_onay_durumu")]
    [StringLength(50)]
    public string? StlOnayDurumu { get; set; }

    [Column("stl_termin_tarihi")]
    public DateTime? StlTerminTarihi { get; set; }

    [Column("stl_aciklama")]
    [StringLength(500)]
    public string? StlAciklama { get; set; }
}
