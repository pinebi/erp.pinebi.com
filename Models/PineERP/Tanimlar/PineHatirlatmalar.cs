using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Tanimlar;

[Table("pine_hatirlatmalar")]
public class PineHatirlatmalar : BaseEntity
{
    [Column("htr_personel_kod")]
    [StringLength(25)]
    public string? HtrPersonelKod { get; set; }

    [Column("htr_personel")]
    [StringLength(200)]
    public string? HtrPersonel { get; set; }

    [Column("htr_tarih")]
    public DateTime HtrTarih { get; set; }

    [Column("htr_hatirlatma_tarihi")]
    public DateTime HtrHatirlatmaTarihi { get; set; }

    [Column("htr_aciklama")]
    [StringLength(500)]
    public string? HtrAciklama { get; set; }

    [Column("htr_oncelik")]
    [StringLength(50)]
    public string? HtrOncelik { get; set; }

    [Column("htr_kategori")]
    [StringLength(50)]
    public string? HtrKategori { get; set; }

    [Column("htr_sms_bilgi")]
    public bool HtrSmsBilgi { get; set; }

    [Column("htr_okundu")]
    public bool HtrOkundu { get; set; }

    [Column("htr_gonderildi")]
    public bool HtrGonderildi { get; set; }
}
