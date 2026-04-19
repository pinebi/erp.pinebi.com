using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_fisleri_ozet")]
public class MuhasebeFisleriOzet
{
    [Column("mfo_RECno")]
    [StringLength(50)]
    public string? MfoRECno { get; set; }

    [Column("mfo_firmano")]
    public int? MfoFirmano { get; set; }

    [Column("mfo_subeno")]
    public int? MfoSubeno { get; set; }

    [Column("mfo_HesapKodu")]
    [StringLength(25)]
    public string? MfoHesapKodu { get; set; }

    [Column("mfo_FisTuru")]
    public byte? MfoFisTuru { get; set; }

    [Column("mfo_ProjeKodu")]
    [StringLength(25)]
    public string? MfoProjeKodu { get; set; }

    [Column("mfo_SrmMerkezi")]
    [StringLength(25)]
    public string? MfoSrmMerkezi { get; set; }

    [Column("mfo_MaliYil")]
    public int? MfoMaliYil { get; set; }

    [Column("mfo_Donem")]
    public byte? MfoDonem { get; set; }

    [Column("mfo_Grp0_B_Meblag")]
    public double? MfoGrp0BMeblag { get; set; }

    [Column("mfo_Grp1_B_Meblag")]
    public double? MfoGrp1BMeblag { get; set; }

    [Column("mfo_Grp2_B_Meblag")]
    public double? MfoGrp2BMeblag { get; set; }

    [Column("mfo_Grp3_B_Meblag")]
    public double? MfoGrp3BMeblag { get; set; }

    [Column("mfo_Grp4_B_Meblag")]
    public double? MfoGrp4BMeblag { get; set; }

    [Column("mfo_Grp5_B_Meblag")]
    public double? MfoGrp5BMeblag { get; set; }

    [Column("mfo_Grp6_B_Meblag")]
    public double? MfoGrp6BMeblag { get; set; }

    [Column("mfo_Grp0_A_Meblag")]
    public double? MfoGrp0AMeblag { get; set; }

    [Column("mfo_Grp1_A_Meblag")]
    public double? MfoGrp1AMeblag { get; set; }

    [Column("mfo_Grp2_A_Meblag")]
    public double? MfoGrp2AMeblag { get; set; }

    [Column("mfo_Grp3_A_Meblag")]
    public double? MfoGrp3AMeblag { get; set; }

    [Column("mfo_Grp4_A_Meblag")]
    public double? MfoGrp4AMeblag { get; set; }

    [Column("mfo_Grp5_A_Meblag")]
    public double? MfoGrp5AMeblag { get; set; }

    [Column("mfo_Grp6_A_Meblag")]
    public double? MfoGrp6AMeblag { get; set; }

    [Column("mfo_Grp0_B_PasifMeblag")]
    public double? MfoGrp0BPasifMeblag { get; set; }

    [Column("mfo_Grp1_B_PasifMeblag")]
    public double? MfoGrp1BPasifMeblag { get; set; }

    [Column("mfo_Grp2_B_PasifMeblag")]
    public double? MfoGrp2BPasifMeblag { get; set; }

    [Column("mfo_Grp3_B_PasifMeblag")]
    public double? MfoGrp3BPasifMeblag { get; set; }

    [Column("mfo_Grp4_B_PasifMeblag")]
    public double? MfoGrp4BPasifMeblag { get; set; }

    [Column("mfo_Grp5_B_PasifMeblag")]
    public double? MfoGrp5BPasifMeblag { get; set; }

    [Column("mfo_Grp6_B_PasifMeblag")]
    public double? MfoGrp6BPasifMeblag { get; set; }

    [Column("mfo_Grp0_A_PasifMeblag")]
    public double? MfoGrp0APasifMeblag { get; set; }

    [Column("mfo_Grp1_A_PasifMeblag")]
    public double? MfoGrp1APasifMeblag { get; set; }

    [Column("mfo_Grp2_A_PasifMeblag")]
    public double? MfoGrp2APasifMeblag { get; set; }

    [Column("mfo_Grp3_A_PasifMeblag")]
    public double? MfoGrp3APasifMeblag { get; set; }

    [Column("mfo_Grp4_A_PasifMeblag")]
    public double? MfoGrp4APasifMeblag { get; set; }

    [Column("mfo_Grp5_A_PasifMeblag")]
    public double? MfoGrp5APasifMeblag { get; set; }

    [Column("mfo_Grp6_A_PasifMeblag")]
    public double? MfoGrp6APasifMeblag { get; set; }
}
