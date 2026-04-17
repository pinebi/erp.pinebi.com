using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_alinan_egitimler")]
public class PinePersonelAlinanEgitimler : BaseEntity
{
    [Column("pae_personel_kod")]
    [StringLength(25)]
    public string? PaePersonelKod { get; set; }

    [Column("pae_egitim_kod")]
    [StringLength(25)]
    public string? PaeEgitimKod { get; set; }

    [Column("pae_tarih")]
    public DateTime PaeTarih { get; set; }

    [Column("pae_egitimci")]
    [StringLength(200)]
    public string? PaeEgitimci { get; set; }

    [Column("pae_sonuc")]
    [StringLength(50)]
    public string? PaeSonuc { get; set; }

    [Column("pae_puan")]
    public decimal? PaePuan { get; set; }

    [Column("pae_sertifika_no")]
    [StringLength(50)]
    public string? PaeSertifikaNo { get; set; }

    [Column("pae_gecerlilik")]
    public DateTime? PaeGecerlilik { get; set; }

    [Column("pae_aciklama")]
    [StringLength(500)]
    public string? PaeAciklama { get; set; }
}
