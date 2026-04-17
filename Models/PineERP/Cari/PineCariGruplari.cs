using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesap grup tanimlari.
/// </summary>
[Table("pine_cari_gruplari")]
public class PineCariGruplari : BaseEntity
{
    [Column("cgr_kod")]
    [StringLength(25)]
    public string CgrKod { get; set; } = string.Empty;

    [Column("cgr_adi")]
    [StringLength(200)]
    public string? CgrAdi { get; set; }

    [Column("cgr_ust_grup_kodu")]
    [StringLength(25)]
    public string? CgrUstGrupKodu { get; set; }

    /// <summary>1=Ana Grup, 2=Alt Grup</summary>
    [Column("cgr_seviye")]
    public int CgrSeviye { get; set; }

    [Column("cgr_sira_no")]
    public int CgrSiraNo { get; set; }

    [Column("cgr_pasif_fl")]
    public bool CgrPasifFl { get; set; }

    [Column("cgr_aciklama")]
    [StringLength(500)]
    public string? CgrAciklama { get; set; }
}
