using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("konsinye_hareketleri_ozet")]
public class KonsinyeHareketleriOzet
{
    [Column("kho_RECno")]
    [StringLength(50)]
    public string? KhoRECno { get; set; }

    [Column("kho_firmano")]
    public int? KhoFirmano { get; set; }

    [Column("kho_subeno")]
    public int? KhoSubeno { get; set; }

    [Column("kho_StokKodu")]
    [StringLength(25)]
    public string? KhoStokKodu { get; set; }

    [Column("kho_SrmMerkezi")]
    [StringLength(25)]
    public string? KhoSrmMerkezi { get; set; }

    [Column("kho_ProjeKodu")]
    [StringLength(25)]
    public string? KhoProjeKodu { get; set; }

    [Column("kho_Depo")]
    public int? KhoDepo { get; set; }

    [Column("kho_MaliYil")]
    public int? KhoMaliYil { get; set; }

    [Column("kho_Donem")]
    public byte? KhoDonem { get; set; }

    [Column("kho_HareketCins")]
    public byte? KhoHareketCins { get; set; }

    [Column("kho_GirisNormal")]
    public double? KhoGirisNormal { get; set; }

    [Column("kho_GirisIade")]
    public double? KhoGirisIade { get; set; }

    [Column("kho_CikisNormal")]
    public double? KhoCikisNormal { get; set; }

    [Column("kho_CikisIade")]
    public double? KhoCikisIade { get; set; }

    [Column("kho_GirisNormal_2")]
    public double? KhoGirisNormal2 { get; set; }

    [Column("kho_GirisIade_2")]
    public double? KhoGirisIade2 { get; set; }

    [Column("kho_CikisNormal_2")]
    public double? KhoCikisNormal2 { get; set; }

    [Column("kho_CikisIade_2")]
    public double? KhoCikisIade2 { get; set; }

    [Column("kho_Belge_Ana_Giris")]
    public double? KhoBelgeAnaGiris { get; set; }

    [Column("kho_Belge_Ana_GirisIade")]
    public double? KhoBelgeAnaGirisIade { get; set; }

    [Column("kho_Belge_Ana_Cikis")]
    public double? KhoBelgeAnaCikis { get; set; }

    [Column("kho_Belge_Ana_CikisIade")]
    public double? KhoBelgeAnaCikisIade { get; set; }

    [Column("kho_Belge_Alt_Giris")]
    public double? KhoBelgeAltGiris { get; set; }

    [Column("kho_Belge_Alt_GirisIade")]
    public double? KhoBelgeAltGirisIade { get; set; }

    [Column("kho_Belge_Alt_Cikis")]
    public double? KhoBelgeAltCikis { get; set; }

    [Column("kho_Belge_Alt_CikisIade")]
    public double? KhoBelgeAltCikisIade { get; set; }

    [Column("kho_Belge_Orj_Giris")]
    public double? KhoBelgeOrjGiris { get; set; }

    [Column("kho_Belge_Orj_GirisIade")]
    public double? KhoBelgeOrjGirisIade { get; set; }

    [Column("kho_Belge_Orj_Cikis")]
    public double? KhoBelgeOrjCikis { get; set; }

    [Column("kho_Belge_Orj_CikisIade")]
    public double? KhoBelgeOrjCikisIade { get; set; }

    [Column("kho_FaturalananGirisNormal")]
    public double? KhoFaturalananGirisNormal { get; set; }

    [Column("kho_FaturalananGirisIade")]
    public double? KhoFaturalananGirisIade { get; set; }

    [Column("kho_FaturalananCikisNormal")]
    public double? KhoFaturalananCikisNormal { get; set; }

    [Column("kho_FaturalananCikisIade")]
    public double? KhoFaturalananCikisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Ana_Giris")]
    public double? KhoFaturalananBelgeAnaGiris { get; set; }

    [Column("kho_Faturalanan_Belge_Ana_GirisIade")]
    public double? KhoFaturalananBelgeAnaGirisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Ana_Cikis")]
    public double? KhoFaturalananBelgeAnaCikis { get; set; }

    [Column("kho_Faturalanan_Belge_Ana_CikisIade")]
    public double? KhoFaturalananBelgeAnaCikisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Alt_Giris")]
    public double? KhoFaturalananBelgeAltGiris { get; set; }

    [Column("kho_Faturalanan_Belge_Alt_GirisIade")]
    public double? KhoFaturalananBelgeAltGirisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Alt_Cikis")]
    public double? KhoFaturalananBelgeAltCikis { get; set; }

    [Column("kho_Faturalanan_Belge_Alt_CikisIade")]
    public double? KhoFaturalananBelgeAltCikisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Orj_Giris")]
    public double? KhoFaturalananBelgeOrjGiris { get; set; }

    [Column("kho_Faturalanan_Belge_Orj_GirisIade")]
    public double? KhoFaturalananBelgeOrjGirisIade { get; set; }

    [Column("kho_Faturalanan_Belge_Orj_Cikis")]
    public double? KhoFaturalananBelgeOrjCikis { get; set; }

    [Column("kho_Faturalanan_Belge_Orj_CikisIade")]
    public double? KhoFaturalananBelgeOrjCikisIade { get; set; }

    [Column("kho_IslemGorenGirisNormal")]
    public double? KhoIslemGorenGirisNormal { get; set; }

    [Column("kho_IslemGorenGirisIade")]
    public double? KhoIslemGorenGirisIade { get; set; }

    [Column("kho_IslemGorenCikisNormal")]
    public double? KhoIslemGorenCikisNormal { get; set; }

    [Column("kho_IslemGorenCikisIade")]
    public double? KhoIslemGorenCikisIade { get; set; }

    [Column("kho_IslemGorenGirisNormal_2")]
    public double? KhoIslemGorenGirisNormal2 { get; set; }

    [Column("kho_IslemGorenGirisIade_2")]
    public double? KhoIslemGorenGirisIade2 { get; set; }

    [Column("kho_IslemGorenCikisNormal_2")]
    public double? KhoIslemGorenCikisNormal2 { get; set; }

    [Column("kho_IslemGorenCikisIade_2")]
    public double? KhoIslemGorenCikisIade2 { get; set; }
}
