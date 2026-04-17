using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Fatura;

/// <summary>
/// Faturada gosterilecek banka hesap bilgileri.
/// </summary>
[Table("pine_fatura_banka_bilgileri")]
public class PineFaturaBankaBilgileri : BaseEntity
{
    [Column("fbb_fatura_uid")]
    public Guid FbbFaturaUid { get; set; }

    [Column("fbb_banka_adi")]
    [StringLength(100)]
    public string? FbbBankaAdi { get; set; }

    [Column("fbb_sube_adi")]
    [StringLength(100)]
    public string? FbbSubeAdi { get; set; }

    [Column("fbb_hesap_no")]
    [StringLength(50)]
    public string? FbbHesapNo { get; set; }

    [Column("fbb_iban")]
    [StringLength(50)]
    public string? FbbIban { get; set; }

    [Column("fbb_swift")]
    [StringLength(20)]
    public string? FbbSwift { get; set; }

    [Column("fbb_doviz_cinsi")]
    [StringLength(5)]
    public string? FbbDovizCinsi { get; set; }

    [Column("fbb_sira_no")]
    public int FbbSiraNo { get; set; }

    [Column("fbb_aciklama")]
    [StringLength(500)]
    public string? FbbAciklama { get; set; }
}
