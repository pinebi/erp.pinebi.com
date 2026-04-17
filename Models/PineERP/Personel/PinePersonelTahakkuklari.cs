using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_tahakkuklari")]
public class PinePersonelTahakkuklari : BaseEntity
{
    [Column("ptk_personel_kod")]
    [StringLength(25)]
    public string? PtkPersonelKod { get; set; }

    [Column("ptk_donem_yil")]
    public int PtkDonemYil { get; set; }

    [Column("ptk_donem_ay")]
    public int PtkDonemAy { get; set; }

    [Column("ptk_brut_maas")]
    public decimal PtkBrutMaas { get; set; }

    [Column("ptk_sgk_isci")]
    public decimal PtkSgkIsci { get; set; }

    [Column("ptk_sgk_isveren")]
    public decimal PtkSgkIsveren { get; set; }

    [Column("ptk_gelir_vergisi")]
    public decimal PtkGelirVergisi { get; set; }

    [Column("ptk_damga_vergisi")]
    public decimal PtkDamgaVergisi { get; set; }

    [Column("ptk_net_maas")]
    public decimal PtkNetMaas { get; set; }

    [Column("ptk_agi")]
    public decimal PtkAgi { get; set; }

    [Column("ptk_toplam_maliyet")]
    public decimal PtkToplamMaliyet { get; set; }

    [Column("ptk_odendi")]
    public bool PtkOdendi { get; set; }
}
