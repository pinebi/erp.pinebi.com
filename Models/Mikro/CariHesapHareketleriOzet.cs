using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_hareketleri_ozet")]
public class CariHesapHareketleriOzet
{
    [Column("cho_RECno")]
    [StringLength(50)]
    public string? ChoRECno { get; set; }

    [Column("cho_firmano")]
    public int? ChoFirmano { get; set; }

    [Column("cho_subeno")]
    public int? ChoSubeno { get; set; }

    [Column("cho_Cinsi")]
    public byte? ChoCinsi { get; set; }

    [Column("cho_CariKodu")]
    [StringLength(25)]
    public string? ChoCariKodu { get; set; }

    [Column("cho_ProjeKodu")]
    [StringLength(25)]
    public string? ChoProjeKodu { get; set; }

    [Column("cho_SrmMerkezi")]
    [StringLength(25)]
    public string? ChoSrmMerkezi { get; set; }

    [Column("cho_GrupNo")]
    public byte? ChoGrupNo { get; set; }

    [Column("cho_MaliYil")]
    public int? ChoMaliYil { get; set; }

    [Column("cho_Donem")]
    public byte? ChoDonem { get; set; }

    [Column("cho_HareketCins")]
    public byte? ChoHareketCins { get; set; }

    [Column("cho_Ana_Borc")]
    public double? ChoAnaBorc { get; set; }

    [Column("cho_Ana_Alacak")]
    public double? ChoAnaAlacak { get; set; }

    [Column("cho_Alt_Borc")]
    public double? ChoAltBorc { get; set; }

    [Column("cho_Alt_Alacak")]
    public double? ChoAltAlacak { get; set; }

    [Column("cho_Orj_Borc")]
    public double? ChoOrjBorc { get; set; }

    [Column("cho_Orj_Alacak")]
    public double? ChoOrjAlacak { get; set; }
}
