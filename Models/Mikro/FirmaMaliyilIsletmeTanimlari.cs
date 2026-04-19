using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_maliyil_isletme_tanimlari")]
public class FirmaMaliyilIsletmeTanimlari
{
    [Column("fmit_Guid")]
    public Guid? FmitGuid { get; set; }

    [Column("fmit_DBCno")]
    public short? FmitDBCno { get; set; }

    [Column("fmit_SpecRECno")]
    public int? FmitSpecRECno { get; set; }

    [Column("fmit_iptal")]
    public bool? FmitIptal { get; set; }

    [Column("fmit_fileid")]
    public short? FmitFileid { get; set; }

    [Column("fmit_hidden")]
    public bool? FmitHidden { get; set; }

    [Column("fmit_kilitli")]
    public bool? FmitKilitli { get; set; }

    [Column("fmit_degisti")]
    public bool? FmitDegisti { get; set; }

    [Column("fmit_checksum")]
    public int? FmitChecksum { get; set; }

    [Column("fmit_create_user")]
    public short? FmitCreateUser { get; set; }

    [Column("fmit_create_date")]
    public DateTime? FmitCreateDate { get; set; }

    [Column("fmit_lastup_user")]
    public short? FmitLastupUser { get; set; }

    [Column("fmit_lastup_date")]
    public DateTime? FmitLastupDate { get; set; }

    [Column("fmit_special1")]
    [StringLength(4)]
    public string? FmitSpecial1 { get; set; }

    [Column("fmit_special2")]
    [StringLength(4)]
    public string? FmitSpecial2 { get; set; }

    [Column("fmit_special3")]
    [StringLength(4)]
    public string? FmitSpecial3 { get; set; }

    [Column("fmit_firmasirano")]
    public int? FmitFirmasirano { get; set; }

    [Column("fmit_maliyil")]
    public int? FmitMaliyil { get; set; }

    [Column("fmit_isletme_devir_vergi")]
    public double? FmitIsletmeDevirVergi { get; set; }

    [Column("fmit_isletme_devir_atik_vergi")]
    public double? FmitIsletmeDevirAtikVergi { get; set; }

    [Column("fmit_isletme_atik_kdv_dokulmesin")]
    public bool? FmitIsletmeAtikKdvDokulmesin { get; set; }

    [Column("fmit_isletme_asgarikarhaddi")]
    public double? FmitIsletmeAsgarikarhaddi { get; set; }

    [Column("fmit_amortisman_demirbas")]
    [StringLength(25)]
    public string? FmitAmortismanDemirbas { get; set; }

    [Column("fmit_amortisman_makine")]
    [StringLength(25)]
    public string? FmitAmortismanMakine { get; set; }

    [Column("fmit_brut_ucret_imalat")]
    [StringLength(25)]
    public string? FmitBrutUcretImalat { get; set; }

    [Column("fmit_isveren_sgk_imalat")]
    [StringLength(25)]
    public string? FmitIsverenSgkImalat { get; set; }

    [Column("fmit_isveren_iss_imalat")]
    [StringLength(25)]
    public string? FmitIsverenIssImalat { get; set; }

    [Column("fmit_brut_ucret_pazarlama")]
    [StringLength(25)]
    public string? FmitBrutUcretPazarlama { get; set; }

    [Column("fmit_isveren_sgk_pazarlama")]
    [StringLength(25)]
    public string? FmitIsverenSgkPazarlama { get; set; }

    [Column("fmit_isveren_iss_pazarlama")]
    [StringLength(25)]
    public string? FmitIsverenIssPazarlama { get; set; }

    [Column("fmit_brut_ucret_genel")]
    [StringLength(25)]
    public string? FmitBrutUcretGenel { get; set; }

    [Column("fmit_isveren_sgk_genel")]
    [StringLength(25)]
    public string? FmitIsverenSgkGenel { get; set; }

    [Column("fmit_isveren_iss_genel")]
    [StringLength(25)]
    public string? FmitIsverenIssGenel { get; set; }

    [Column("fmit_isveren_his_tesvik")]
    [StringLength(25)]
    public string? FmitIsverenHisTesvik { get; set; }

    [Column("fmit_demirbas_satis_kar")]
    [StringLength(25)]
    public string? FmitDemirbasSatisKar { get; set; }

    [Column("fmit_demirbas_satis_zarar")]
    [StringLength(25)]
    public string? FmitDemirbasSatisZarar { get; set; }

    [Column("fmit_demirbas_satis_vergi")]
    [StringLength(25)]
    public string? FmitDemirbasSatisVergi { get; set; }

    [Column("fmit_stok_alis_0")]
    [StringLength(25)]
    public string? FmitStokAlis0 { get; set; }

    [Column("fmit_stok_alis_1")]
    [StringLength(25)]
    public string? FmitStokAlis1 { get; set; }

    [Column("fmit_stok_alis_2")]
    [StringLength(25)]
    public string? FmitStokAlis2 { get; set; }

    [Column("fmit_stok_alis_3")]
    [StringLength(25)]
    public string? FmitStokAlis3 { get; set; }

    [Column("fmit_stok_alis_4")]
    [StringLength(25)]
    public string? FmitStokAlis4 { get; set; }

    [Column("fmit_stok_alis_5")]
    [StringLength(25)]
    public string? FmitStokAlis5 { get; set; }

    [Column("fmit_stok_alis_6")]
    [StringLength(25)]
    public string? FmitStokAlis6 { get; set; }

    [Column("fmit_stok_alis_7")]
    [StringLength(25)]
    public string? FmitStokAlis7 { get; set; }

    [Column("fmit_stok_alis_8")]
    [StringLength(25)]
    public string? FmitStokAlis8 { get; set; }

    [Column("fmit_stok_alis_9")]
    [StringLength(25)]
    public string? FmitStokAlis9 { get; set; }

    [Column("fmit_stok_alis_10")]
    [StringLength(25)]
    public string? FmitStokAlis10 { get; set; }

    [Column("fmit_stok_satis_0")]
    [StringLength(25)]
    public string? FmitStokSatis0 { get; set; }

    [Column("fmit_stok_satis_1")]
    [StringLength(25)]
    public string? FmitStokSatis1 { get; set; }

    [Column("fmit_stok_satis_2")]
    [StringLength(25)]
    public string? FmitStokSatis2 { get; set; }

    [Column("fmit_stok_satis_3")]
    [StringLength(25)]
    public string? FmitStokSatis3 { get; set; }

    [Column("fmit_stok_satis_4")]
    [StringLength(25)]
    public string? FmitStokSatis4 { get; set; }

    [Column("fmit_stok_satis_5")]
    [StringLength(25)]
    public string? FmitStokSatis5 { get; set; }

    [Column("fmit_stok_satis_6")]
    [StringLength(25)]
    public string? FmitStokSatis6 { get; set; }

    [Column("fmit_stok_satis_7")]
    [StringLength(25)]
    public string? FmitStokSatis7 { get; set; }

    [Column("fmit_stok_satis_8")]
    [StringLength(25)]
    public string? FmitStokSatis8 { get; set; }

    [Column("fmit_stok_satis_9")]
    [StringLength(25)]
    public string? FmitStokSatis9 { get; set; }

    [Column("fmit_stok_satis_10")]
    [StringLength(25)]
    public string? FmitStokSatis10 { get; set; }

    [Column("fmit_masraf_alis_0")]
    [StringLength(25)]
    public string? FmitMasrafAlis0 { get; set; }

    [Column("fmit_masraf_alis_1")]
    [StringLength(25)]
    public string? FmitMasrafAlis1 { get; set; }

    [Column("fmit_masraf_alis_2")]
    [StringLength(25)]
    public string? FmitMasrafAlis2 { get; set; }

    [Column("fmit_masraf_alis_3")]
    [StringLength(25)]
    public string? FmitMasrafAlis3 { get; set; }

    [Column("fmit_masraf_alis_4")]
    [StringLength(25)]
    public string? FmitMasrafAlis4 { get; set; }

    [Column("fmit_masraf_alis_5")]
    [StringLength(25)]
    public string? FmitMasrafAlis5 { get; set; }

    [Column("fmit_masraf_alis_6")]
    [StringLength(25)]
    public string? FmitMasrafAlis6 { get; set; }

    [Column("fmit_masraf_alis_7")]
    [StringLength(25)]
    public string? FmitMasrafAlis7 { get; set; }

    [Column("fmit_masraf_alis_8")]
    [StringLength(25)]
    public string? FmitMasrafAlis8 { get; set; }

    [Column("fmit_masraf_alis_9")]
    [StringLength(25)]
    public string? FmitMasrafAlis9 { get; set; }

    [Column("fmit_masraf_alis_10")]
    [StringLength(25)]
    public string? FmitMasrafAlis10 { get; set; }

    [Column("fmit_hizmet_satis_0")]
    [StringLength(25)]
    public string? FmitHizmetSatis0 { get; set; }

    [Column("fmit_hizmet_satis_1")]
    [StringLength(25)]
    public string? FmitHizmetSatis1 { get; set; }

    [Column("fmit_hizmet_satis_2")]
    [StringLength(25)]
    public string? FmitHizmetSatis2 { get; set; }

    [Column("fmit_hizmet_satis_3")]
    [StringLength(25)]
    public string? FmitHizmetSatis3 { get; set; }

    [Column("fmit_hizmet_satis_4")]
    [StringLength(25)]
    public string? FmitHizmetSatis4 { get; set; }

    [Column("fmit_hizmet_satis_5")]
    [StringLength(25)]
    public string? FmitHizmetSatis5 { get; set; }

    [Column("fmit_hizmet_satis_6")]
    [StringLength(25)]
    public string? FmitHizmetSatis6 { get; set; }

    [Column("fmit_hizmet_satis_7")]
    [StringLength(25)]
    public string? FmitHizmetSatis7 { get; set; }

    [Column("fmit_hizmet_satis_8")]
    [StringLength(25)]
    public string? FmitHizmetSatis8 { get; set; }

    [Column("fmit_hizmet_satis_9")]
    [StringLength(25)]
    public string? FmitHizmetSatis9 { get; set; }

    [Column("fmit_hizmet_satis_10")]
    [StringLength(25)]
    public string? FmitHizmetSatis10 { get; set; }

    [Column("fmit_smm_alis_0")]
    [StringLength(25)]
    public string? FmitSmmAlis0 { get; set; }

    [Column("fmit_smm_alis_1")]
    [StringLength(25)]
    public string? FmitSmmAlis1 { get; set; }

    [Column("fmit_smm_alis_2")]
    [StringLength(25)]
    public string? FmitSmmAlis2 { get; set; }

    [Column("fmit_smm_alis_3")]
    [StringLength(25)]
    public string? FmitSmmAlis3 { get; set; }

    [Column("fmit_smm_alis_4")]
    [StringLength(25)]
    public string? FmitSmmAlis4 { get; set; }

    [Column("fmit_smm_alis_5")]
    [StringLength(25)]
    public string? FmitSmmAlis5 { get; set; }

    [Column("fmit_smm_alis_6")]
    [StringLength(25)]
    public string? FmitSmmAlis6 { get; set; }

    [Column("fmit_smm_alis_7")]
    [StringLength(25)]
    public string? FmitSmmAlis7 { get; set; }

    [Column("fmit_smm_alis_8")]
    [StringLength(25)]
    public string? FmitSmmAlis8 { get; set; }

    [Column("fmit_smm_alis_9")]
    [StringLength(25)]
    public string? FmitSmmAlis9 { get; set; }

    [Column("fmit_smm_alis_10")]
    [StringLength(25)]
    public string? FmitSmmAlis10 { get; set; }

    [Column("fmit_smm_satis_0")]
    [StringLength(25)]
    public string? FmitSmmSatis0 { get; set; }

    [Column("fmit_smm_satis_1")]
    [StringLength(25)]
    public string? FmitSmmSatis1 { get; set; }

    [Column("fmit_smm_satis_2")]
    [StringLength(25)]
    public string? FmitSmmSatis2 { get; set; }

    [Column("fmit_smm_satis_3")]
    [StringLength(25)]
    public string? FmitSmmSatis3 { get; set; }

    [Column("fmit_smm_satis_4")]
    [StringLength(25)]
    public string? FmitSmmSatis4 { get; set; }

    [Column("fmit_smm_satis_5")]
    [StringLength(25)]
    public string? FmitSmmSatis5 { get; set; }

    [Column("fmit_smm_satis_6")]
    [StringLength(25)]
    public string? FmitSmmSatis6 { get; set; }

    [Column("fmit_smm_satis_7")]
    [StringLength(25)]
    public string? FmitSmmSatis7 { get; set; }

    [Column("fmit_smm_satis_8")]
    [StringLength(25)]
    public string? FmitSmmSatis8 { get; set; }

    [Column("fmit_smm_satis_9")]
    [StringLength(25)]
    public string? FmitSmmSatis9 { get; set; }

    [Column("fmit_smm_satis_10")]
    [StringLength(25)]
    public string? FmitSmmSatis10 { get; set; }

    [Column("fmit_gider_makbuzu_0")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu0 { get; set; }

    [Column("fmit_gider_makbuzu_1")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu1 { get; set; }

    [Column("fmit_gider_makbuzu_2")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu2 { get; set; }

    [Column("fmit_gider_makbuzu_3")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu3 { get; set; }

    [Column("fmit_gider_makbuzu_4")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu4 { get; set; }

    [Column("fmit_gider_makbuzu_5")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu5 { get; set; }

    [Column("fmit_gider_makbuzu_6")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu6 { get; set; }

    [Column("fmit_gider_makbuzu_7")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu7 { get; set; }

    [Column("fmit_gider_makbuzu_8")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu8 { get; set; }

    [Column("fmit_gider_makbuzu_9")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu9 { get; set; }

    [Column("fmit_gider_makbuzu_10")]
    [StringLength(25)]
    public string? FmitGiderMakbuzu10 { get; set; }
}
