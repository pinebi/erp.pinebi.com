using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyon_hareketleri")]
public class UretimOperasyonHareketleri
{
    [Column("OpT_Guid")]
    public Guid? OpTGuid { get; set; }

    [Column("OpT_DBCno")]
    public short? OpTDBCno { get; set; }

    [Column("OpT_SpecRECNo")]
    public int? OpTSpecRECNo { get; set; }

    [Column("OpT_iptal")]
    public bool? OpTIptal { get; set; }

    [Column("OpT_fileid")]
    public short? OpTFileid { get; set; }

    [Column("OpT_hidden")]
    public bool? OpTHidden { get; set; }

    [Column("OpT_kilitli")]
    public bool? OpTKilitli { get; set; }

    [Column("OpT_degisti")]
    public bool? OpTDegisti { get; set; }

    [Column("OpT_CheckSum")]
    public int? OpTCheckSum { get; set; }

    [Column("OpT_create_user")]
    public short? OpTCreateUser { get; set; }

    [Column("OpT_create_date")]
    public DateTime? OpTCreateDate { get; set; }

    [Column("OpT_lastup_user")]
    public short? OpTLastupUser { get; set; }

    [Column("OpT_lastup_date")]
    public DateTime? OpTLastupDate { get; set; }

    [Column("OpT_special1")]
    [StringLength(4)]
    public string? OpTSpecial1 { get; set; }

    [Column("OpT_special2")]
    [StringLength(4)]
    public string? OpTSpecial2 { get; set; }

    [Column("OpT_special3")]
    [StringLength(4)]
    public string? OpTSpecial3 { get; set; }

    [Column("OpT_firmano")]
    public int? OpTFirmano { get; set; }

    [Column("OpT_subeno")]
    public int? OpTSubeno { get; set; }

    [Column("OpT_EvrakNoSeri")]
    [StringLength(50)]
    public string? OpTEvrakNoSeri { get; set; }

    [Column("OpT_EvrakNoSira")]
    public int? OpTEvrakNoSira { get; set; }

    [Column("OpT_EvrakSatirNo")]
    public int? OpTEvrakSatirNo { get; set; }

    [Column("OpT_RotaPlan_uid")]
    public Guid? OpTRotaPlanUid { get; set; }

    [Column("OpT_baslamatarihi")]
    public DateTime? OpTBaslamatarihi { get; set; }

    [Column("OpT_bitis_tarihi")]
    public DateTime? OpTBitisTarihi { get; set; }

    [Column("OpT_IsEmriKodu")]
    [StringLength(25)]
    public string? OpTIsEmriKodu { get; set; }

    [Column("OpT_UrunKodu")]
    [StringLength(25)]
    public string? OpTUrunKodu { get; set; }

    [Column("OpT_OperasyonSafhaNo")]
    public short? OpTOperasyonSafhaNo { get; set; }

    [Column("OpT_OperasyonKodu")]
    [StringLength(25)]
    public string? OpTOperasyonKodu { get; set; }

    [Column("OpT_SonrakiSafhaNo")]
    public short? OpTSonrakiSafhaNo { get; set; }

    [Column("OpT_ismerkezi")]
    [StringLength(25)]
    public string? OpTIsmerkezi { get; set; }

    [Column("OpT_ismerkezi_hizi")]
    public double? OpTIsmerkeziHizi { get; set; }

    [Column("OpT_PersonelKodu")]
    [StringLength(25)]
    public string? OpTPersonelKodu { get; set; }

    [Column("OpT_TamamlananMiktar")]
    public double? OpTTamamlananMiktar { get; set; }

    [Column("OpT_TamamlananMiktar2")]
    public double? OpTTamamlananMiktar2 { get; set; }

    [Column("OpT_TamamlananMiktar3")]
    public double? OpTTamamlananMiktar3 { get; set; }

    [Column("OpT_TamamlananMiktar4")]
    public double? OpTTamamlananMiktar4 { get; set; }

    [Column("OpT_BozukMiktar")]
    public double? OpTBozukMiktar { get; set; }

    [Column("OpT_BozukMiktar2")]
    public double? OpTBozukMiktar2 { get; set; }

    [Column("OpT_BozukMiktar3")]
    public double? OpTBozukMiktar3 { get; set; }

    [Column("OpT_BozukMiktar4")]
    public double? OpTBozukMiktar4 { get; set; }

    [Column("OpT_SetupSuresi")]
    public int? OpTSetupSuresi { get; set; }

    [Column("OpT_TamamlananSure")]
    public int? OpTTamamlananSure { get; set; }

    [Column("Opt_Gecikme_suresi")]
    public int? OptGecikmeSuresi { get; set; }

    [Column("Opt_iscilik_Maliyet_ana")]
    public double? OptIscilikMaliyetAna { get; set; }

    [Column("Opt_iscilik_Maliyet_Alt")]
    public double? OptIscilikMaliyetAlt { get; set; }

    [Column("Opt_iscilik_Maliyet_Orj")]
    public double? OptIscilikMaliyetOrj { get; set; }

    [Column("Opt_Genel_uretim_Maliyet_ana")]
    public double? OptGenelUretimMaliyetAna { get; set; }

    [Column("Opt_Genel_uretim_Maliyet_Alt")]
    public double? OptGenelUretimMaliyetAlt { get; set; }

    [Column("Opt_Genel_uretim_Maliyet_Orj")]
    public double? OptGenelUretimMaliyetOrj { get; set; }

    [Column("Opt_Kapat_fl")]
    public bool? OptKapatFl { get; set; }

    [Column("Opt_calisan_adam")]
    public double? OptCalisanAdam { get; set; }

    [Column("Opt_islenen_alan")]
    public double? OptIslenenAlan { get; set; }

    [Column("Opt_islenen_hacim")]
    public double? OptIslenenHacim { get; set; }

    [Column("Opt_islenen_agirlik")]
    public double? OptIslenenAgirlik { get; set; }

    [Column("Opt_tuketilen_enerji1")]
    public double? OptTuketilenEnerji1 { get; set; }

    [Column("Opt_tuketilen_enerji2")]
    public double? OptTuketilenEnerji2 { get; set; }

    [Column("Opt_aciklama")]
    [StringLength(80)]
    public string? OptAciklama { get; set; }

    [Column("Opt_ufrs_iscilik_maliyet_ana")]
    public double? OptUfrsIscilikMaliyetAna { get; set; }

    [Column("Opt_ufrs_iscilik_maliyet_alt")]
    public double? OptUfrsIscilikMaliyetAlt { get; set; }

    [Column("Opt_ufrs_iscilik_maliyet_orj")]
    public double? OptUfrsIscilikMaliyetOrj { get; set; }

    [Column("Opt_ufrs_genel_uretim_maliyet_ana")]
    public double? OptUfrsGenelUretimMaliyetAna { get; set; }

    [Column("Opt_ufrs_genel_uretim_maliyet_alt")]
    public double? OptUfrsGenelUretimMaliyetAlt { get; set; }

    [Column("Opt_ufrs_genel_uretim_maliyet_orj")]
    public double? OptUfrsGenelUretimMaliyetOrj { get; set; }

    [Column("Opt_kalipkodu")]
    [StringLength(25)]
    public string? OptKalipkodu { get; set; }

    [Column("Opt_HazirlikElemanSayisi")]
    public double? OptHazirlikElemanSayisi { get; set; }

    [Column("Opt_OperasyonElemanSayisi")]
    public double? OptOperasyonElemanSayisi { get; set; }
}
