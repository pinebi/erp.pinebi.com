using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_demirbas_bakim_kayitlari")]
public class PineDemirbasBakimKayitlari : BaseEntity
{
    [Column("dbk_demirbas_kod")]
    [StringLength(25)]
    public string? DbkDemirbasKod { get; set; }

    [Column("dbk_tarih")]
    public DateTime? DbkTarih { get; set; }

    [Column("dbk_bakim_turu")]
    [StringLength(100)]
    public string? DbkBakimTuru { get; set; }

    [Column("dbk_yapilan_islem")]
    [StringLength(500)]
    public string? DbkYapilanIslem { get; set; }

    [Column("dbk_maliyet")]
    public decimal DbkMaliyet { get; set; }

    [Column("dbk_firma")]
    [StringLength(200)]
    public string? DbkFirma { get; set; }

    [Column("dbk_sonraki_bakim")]
    public DateTime? DbkSonrakiBakim { get; set; }

    [Column("dbk_aciklama")]
    [StringLength(500)]
    public string? DbkAciklama { get; set; }
}
