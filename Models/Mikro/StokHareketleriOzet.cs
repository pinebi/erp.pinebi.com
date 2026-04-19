using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_hareketleri_ozet")]
public class StokHareketleriOzet
{
    [Column("sho_RECno")]
    [StringLength(50)]
    public string? ShoRECno { get; set; }

    [Column("sho_firmano")]
    public int? ShoFirmano { get; set; }

    [Column("sho_subeno")]
    public int? ShoSubeno { get; set; }

    [Column("sho_StokKodu")]
    [StringLength(25)]
    public string? ShoStokKodu { get; set; }

    [Column("sho_SrmMerkezi")]
    [StringLength(25)]
    public string? ShoSrmMerkezi { get; set; }

    [Column("sho_ProjeKodu")]
    [StringLength(25)]
    public string? ShoProjeKodu { get; set; }

    [Column("sho_Depo")]
    public int? ShoDepo { get; set; }

    [Column("sho_MaliYil")]
    public int? ShoMaliYil { get; set; }

    [Column("sho_Donem")]
    public byte? ShoDonem { get; set; }

    [Column("sho_HareketCins")]
    public byte? ShoHareketCins { get; set; }

    [Column("sho_GirisNormal")]
    public double? ShoGirisNormal { get; set; }

    [Column("sho_GirisIade")]
    public double? ShoGirisIade { get; set; }

    [Column("sho_CikisNormal")]
    public double? ShoCikisNormal { get; set; }

    [Column("sho_CikisIade")]
    public double? ShoCikisIade { get; set; }

    [Column("sho_GirisNormal_2")]
    public double? ShoGirisNormal2 { get; set; }

    [Column("sho_GirisIade_2")]
    public double? ShoGirisIade2 { get; set; }

    [Column("sho_CikisNormal_2")]
    public double? ShoCikisNormal2 { get; set; }

    [Column("sho_CikisIade_2")]
    public double? ShoCikisIade2 { get; set; }

    [Column("sho_Maliyet_Ana_Giris")]
    public double? ShoMaliyetAnaGiris { get; set; }

    [Column("sho_Maliyet_Ana_GirisIade")]
    public double? ShoMaliyetAnaGirisIade { get; set; }

    [Column("sho_Maliyet_Ana_Cikis")]
    public double? ShoMaliyetAnaCikis { get; set; }

    [Column("sho_Maliyet_Ana_CikisIade")]
    public double? ShoMaliyetAnaCikisIade { get; set; }

    [Column("sho_Maliyet_Alt_Giris")]
    public double? ShoMaliyetAltGiris { get; set; }

    [Column("sho_Maliyet_Alt_GirisIade")]
    public double? ShoMaliyetAltGirisIade { get; set; }

    [Column("sho_Maliyet_Alt_Cikis")]
    public double? ShoMaliyetAltCikis { get; set; }

    [Column("sho_Maliyet_Alt_CikisIade")]
    public double? ShoMaliyetAltCikisIade { get; set; }

    [Column("sho_Maliyet_Orj_Giris")]
    public double? ShoMaliyetOrjGiris { get; set; }

    [Column("sho_Maliyet_Orj_GirisIade")]
    public double? ShoMaliyetOrjGirisIade { get; set; }

    [Column("sho_Maliyet_Orj_Cikis")]
    public double? ShoMaliyetOrjCikis { get; set; }

    [Column("sho_Maliyet_Orj_CikisIade")]
    public double? ShoMaliyetOrjCikisIade { get; set; }

    [Column("sho_Belge_Ana_Giris")]
    public double? ShoBelgeAnaGiris { get; set; }

    [Column("sho_Belge_Ana_GirisIade")]
    public double? ShoBelgeAnaGirisIade { get; set; }

    [Column("sho_Belge_Ana_Cikis")]
    public double? ShoBelgeAnaCikis { get; set; }

    [Column("sho_Belge_Ana_CikisIade")]
    public double? ShoBelgeAnaCikisIade { get; set; }

    [Column("sho_Belge_Alt_Giris")]
    public double? ShoBelgeAltGiris { get; set; }

    [Column("sho_Belge_Alt_GirisIade")]
    public double? ShoBelgeAltGirisIade { get; set; }

    [Column("sho_Belge_Alt_Cikis")]
    public double? ShoBelgeAltCikis { get; set; }

    [Column("sho_Belge_Alt_CikisIade")]
    public double? ShoBelgeAltCikisIade { get; set; }

    [Column("sho_Belge_Orj_Giris")]
    public double? ShoBelgeOrjGiris { get; set; }

    [Column("sho_Belge_Orj_GirisIade")]
    public double? ShoBelgeOrjGirisIade { get; set; }

    [Column("sho_Belge_Orj_Cikis")]
    public double? ShoBelgeOrjCikis { get; set; }

    [Column("sho_Belge_Orj_CikisIade")]
    public double? ShoBelgeOrjCikisIade { get; set; }
}
