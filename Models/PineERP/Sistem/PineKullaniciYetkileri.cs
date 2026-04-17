using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_kullanici_yetkileri")]
public class PineKullaniciYetkileri : BaseEntity
{
    [Column("kye_kullanici_id")]
    public int KyeKullaniciId { get; set; }

    [Column("kye_modul")]
    [StringLength(50)]
    public string? KyeModul { get; set; }

    [Column("kye_sayfa")]
    [StringLength(100)]
    public string? KyeSayfa { get; set; }

    [Column("kye_okuma")]
    public bool KyeOkuma { get; set; }

    [Column("kye_yazma")]
    public bool KyeYazma { get; set; }

    [Column("kye_silme")]
    public bool KyeSilme { get; set; }

    [Column("kye_onay")]
    public bool KyeOnay { get; set; }

    [Column("kye_yazdir")]
    public bool KyeYazdir { get; set; }
}
