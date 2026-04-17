using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Stok;

/// <summary>
/// Stok barkodlari - bir stoga birden fazla barkod tanimlanabilir.
/// Mikro: Barkod tanitim karti.
/// </summary>
[Table("pine_stok_barkodlari")]
public class PineStokBarkodlari : BaseEntity
{
    [Column("sbk_stok_id")]
    public int SbkStokId { get; set; }

    [Column("sbk_stok_kod")]
    [StringLength(25)]
    public string SbkStokKod { get; set; } = string.Empty;

    /// <summary>Baglanti tipi: Stok barkodu, Cari barkodu, Hizmet barkodu vs.</summary>
    [Column("sbk_baglanti_tipi")]
    [StringLength(30)]
    public string SbkBaglantiTipi { get; set; } = "Stok barkodu";

    [Column("sbk_parti_kodu")]
    [StringLength(50)]
    public string? SbkPartiKodu { get; set; }

    [Column("sbk_lot_no")]
    [StringLength(50)]
    public string? SbkLotNo { get; set; }

    [Column("sbk_seri_no")]
    [StringLength(50)]
    public string? SbkSeriNo { get; set; }

    [Column("sbk_asorti_kodu")]
    [StringLength(50)]
    public string? SbkAsortiKodu { get; set; }

    /// <summary>EAN-13, EAN-8, UPC-A, Code128, Code39, QR vs.</summary>
    [Column("sbk_barkod_tipi")]
    [StringLength(20)]
    public string SbkBarkodTipi { get; set; } = "EAN-13";

    /// <summary>Kod, Kod+miktar, Kod+birim fiyat, Kod+tutar</summary>
    [Column("sbk_icerik")]
    [StringLength(30)]
    public string SbkIcerik { get; set; } = "Kod";

    [Column("sbk_kodu")]
    [StringLength(50)]
    public string SbkKodu { get; set; } = string.Empty;

    [Column("sbk_birimi")]
    [StringLength(20)]
    public string? SbkBirimi { get; set; }

    [Column("sbk_bedeni")]
    [StringLength(20)]
    public string? SbkBedeni { get; set; }

    [Column("sbk_rengi")]
    [StringLength(20)]
    public string? SbkRengi { get; set; }

    [Column("sbk_master")]
    public bool SbkMaster { get; set; } = false;
}
