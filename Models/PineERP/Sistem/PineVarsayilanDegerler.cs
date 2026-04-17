using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_varsayilan_degerler")]
public class PineVarsayilanDegerler : BaseEntity
{
    [Column("vrs_ulke")]
    public int VrsUlke { get; set; }

    [Column("vrs_sehir")]
    public int VrsSehir { get; set; }

    [Column("vrs_para_birimi")]
    [StringLength(10)]
    public string? VrsParaBirimi { get; set; }

    [Column("vrs_cari_takibi")]
    public bool VrsCariTakibi { get; set; }

    [Column("vrs_stok_takibi")]
    public bool VrsStokTakibi { get; set; }

    [Column("vrs_depo_no")]
    public int VrsDepoNo { get; set; }

    [Column("vrs_isyeri_no")]
    public int VrsIsyeriNo { get; set; }

    [Column("vrs_kasa_kodu")]
    [StringLength(25)]
    public string? VrsKasaKodu { get; set; }

    [Column("vrs_banka_kodu")]
    [StringLength(25)]
    public string? VrsBankaKodu { get; set; }
}
