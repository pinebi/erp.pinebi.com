using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Depo tanimlari. Birden fazla depo/ambar tanimlanabilir.
/// Adresli depo ozelligi ile raf/koridor bazli takip yapilabilir.
/// </summary>
[Table("pine_depolar")]
public class PineDepolar : BaseEntity
{
    [Column("dep_kod")]
    [StringLength(20)]
    public string DepKod { get; set; } = string.Empty;

    [Column("dep_isim")]
    [StringLength(100)]
    public string DepIsim { get; set; } = string.Empty;

    [Column("dep_adres")]
    [StringLength(500)]
    public string? DepAdres { get; set; }

    [Column("dep_sehir")]
    [StringLength(50)]
    public string? DepSehir { get; set; }

    [Column("dep_ilce")]
    [StringLength(50)]
    public string? DepIlce { get; set; }

    [Column("dep_sorumlu")]
    [StringLength(100)]
    public string? DepSorumlu { get; set; }

    [Column("dep_tel")]
    [StringLength(50)]
    public string? DepTel { get; set; }

    [Column("dep_aktif")]
    public bool DepAktif { get; set; } = true;

    /// <summary>Adresli depo (raf/koridor bazli takip)</summary>
    [Column("dep_adresli_depo")]
    public bool DepAdresliDepo { get; set; } = false;
}
