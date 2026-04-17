using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.EFatura;

[Table("pine_efatura_gelen")]
public class PineEFaturaGelen : BaseEntity
{
    [Column("efl_tarih")]
    public DateTime? EflTarih { get; set; }

    [Column("efl_fatura_tipi")]
    public int EflFaturaTipi { get; set; }

    [Column("efl_fatura_no")]
    [StringLength(50)]
    public string? EflFaturaNo { get; set; }

    [Column("efl_tedarikci")]
    [StringLength(300)]
    public string? EflTedarikci { get; set; }

    [Column("efl_vergi_dairesi")]
    [StringLength(200)]
    public string? EflVergiDairesi { get; set; }

    [Column("efl_vergi_no")]
    [StringLength(20)]
    public string? EflVergiNo { get; set; }

    [Column("efl_adres")]
    [StringLength(500)]
    public string? EflAdres { get; set; }

    [Column("efl_sehir")]
    [StringLength(100)]
    public string? EflSehir { get; set; }

    [Column("efl_doviz")]
    [StringLength(10)]
    public string? EflDoviz { get; set; }

    [Column("efl_kdv_matrahi")]
    public decimal EflKdvMatrahi { get; set; }

    [Column("efl_kdv_tutari")]
    public decimal EflKdvTutari { get; set; }

    [Column("efl_toplam_tutar")]
    public decimal EflToplamTutar { get; set; }

    [Column("efl_ettn")]
    [StringLength(100)]
    public string? EflEttn { get; set; }

    [Column("efl_durumu")]
    [StringLength(50)]
    public string? EflDurumu { get; set; }

    [Column("efl_url")]
    [StringLength(500)]
    public string? EflUrl { get; set; }

    [Column("efl_kayit_durumu")]
    [StringLength(50)]
    public string? EflKayitDurumu { get; set; }
}
