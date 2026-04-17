using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_fiyat_gruplari")]
public class PineFiyatGruplari : BaseEntity
{
    [Column("fgr_grup_no")]
    public int FgrGrupNo { get; set; }

    [Column("fgr_isim")]
    [StringLength(100)]
    public string? FgrIsim { get; set; }

    [Column("fgr_aciklama")]
    [StringLength(500)]
    public string? FgrAciklama { get; set; }

    [Column("fgr_varsayilan_iskonto")]
    public decimal? FgrVarsayilanIskonto { get; set; }

    [Column("fgr_varsayilan_doviz")]
    [StringLength(5)]
    public string? FgrVarsayilanDoviz { get; set; }

    [Column("fgr_kdv_dahil")]
    public bool FgrKdvDahil { get; set; }

    [Column("fgr_oncelik_sirasi")]
    public int? FgrOncelikSirasi { get; set; }

    [Column("fgr_aktif")]
    public bool FgrAktif { get; set; } = true;
}
