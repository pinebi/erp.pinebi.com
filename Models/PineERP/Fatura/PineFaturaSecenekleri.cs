using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Fatura gorsel secenekleri ve yazdirma ayarlari.
/// </summary>
[Table("pine_fatura_secenekleri")]
public class PineFaturaSecenekleri : BaseEntity
{
    [Column("fsc_kod")]
    [StringLength(25)]
    public string FscKod { get; set; } = string.Empty;

    [Column("fsc_adi")]
    [StringLength(200)]
    public string? FscAdi { get; set; }

    /// <summary>1=Satis, 2=Satinalma, 3=Proforma, 4=Irsaliye</summary>
    [Column("fsc_fatura_tipi")]
    public int FscFaturaTipi { get; set; }

    [Column("fsc_sablon_adi")]
    [StringLength(200)]
    public string? FscSablonAdi { get; set; }

    [Column("fsc_logo_goster_fl")]
    public bool FscLogoGosterFl { get; set; } = true;

    [Column("fsc_banka_goster_fl")]
    public bool FscBankaGosterFl { get; set; } = true;

    [Column("fsc_notlar_goster_fl")]
    public bool FscNotlarGosterFl { get; set; } = true;

    [Column("fsc_imza_goster_fl")]
    public bool FscImzaGosterFl { get; set; }

    [Column("fsc_kagit_boyutu")]
    [StringLength(20)]
    public string? FscKagitBoyutu { get; set; }

    [Column("fsc_kopya_sayisi")]
    public int FscKopyaSayisi { get; set; } = 1;

    [Column("fsc_alt_not")]
    [StringLength(500)]
    public string? FscAltNot { get; set; }

    [Column("fsc_varsayilan_fl")]
    public bool FscVarsayilanFl { get; set; }

    [Column("fsc_aciklama")]
    [StringLength(500)]
    public string? FscAciklama { get; set; }
}
