using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP;

[Table("pine_personel_yetkileri")]
public class PinePersonelYetkileri : BaseEntity
{
    [Column("pye_personel_kod")]
    [StringLength(25)]
    public string? PyePersonelKod { get; set; }

    [Column("pye_modul")]
    [StringLength(50)]
    public string? PyeModul { get; set; }

    [Column("pye_yetki_tipi")]
    [StringLength(50)]
    public string? PyeYetkiTipi { get; set; }

    [Column("pye_okuma")]
    public bool PyeOkuma { get; set; }

    [Column("pye_yazma")]
    public bool PyeYazma { get; set; }

    [Column("pye_silme")]
    public bool PyeSilme { get; set; }

    [Column("pye_onay")]
    public bool PyeOnay { get; set; }
}
