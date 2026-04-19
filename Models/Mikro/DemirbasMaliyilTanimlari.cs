using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("demirbas_maliyil_tanimlari")]
public class DemirbasMaliyilTanimlari
{
    [Column("amy_Guid")]
    public Guid? AmyGuid { get; set; }

    [Column("amy_DBCno")]
    public short? AmyDBCno { get; set; }

    [Column("amy_SpecRECno")]
    public int? AmySpecRECno { get; set; }

    [Column("amy_iptal")]
    public bool? AmyIptal { get; set; }

    [Column("amy_fileid")]
    public short? AmyFileid { get; set; }

    [Column("amy_hidden")]
    public bool? AmyHidden { get; set; }

    [Column("amy_kilitli")]
    public bool? AmyKilitli { get; set; }

    [Column("amy_degisti")]
    public bool? AmyDegisti { get; set; }

    [Column("amy_checksum")]
    public int? AmyChecksum { get; set; }

    [Column("amy_create_user")]
    public short? AmyCreateUser { get; set; }

    [Column("amy_create_date")]
    public DateTime? AmyCreateDate { get; set; }

    [Column("amy_lastup_user")]
    public short? AmyLastupUser { get; set; }

    [Column("amy_lastup_date")]
    public DateTime? AmyLastupDate { get; set; }

    [Column("amy_special1")]
    [StringLength(4)]
    public string? AmySpecial1 { get; set; }

    [Column("amy_special2")]
    [StringLength(4)]
    public string? AmySpecial2 { get; set; }

    [Column("amy_special3")]
    [StringLength(4)]
    public string? AmySpecial3 { get; set; }

    [Column("amy_kod")]
    [StringLength(25)]
    public string? AmyKod { get; set; }

    [Column("amy_maliyil")]
    public int? AmyMaliyil { get; set; }

    [Column("amy_dvr_birikmis_amortisman")]
    public double? AmyDvrBirikmisAmortisman { get; set; }

    [Column("amy_dvr_miktar")]
    public double? AmyDvrMiktar { get; set; }

    [Column("amy_dvr_bil_ak_dgr")]
    public double? AmyDvrBilAkDgr { get; set; }

    [Column("amy_dvr_ydf")]
    public double? AmyDvrYdf { get; set; }

    [Column("amy_dvr_sanal_brk_amortisman")]
    public double? AmyDvrSanalBrkAmortisman { get; set; }

    [Column("amy_dvr_emlak_brk_amortisman")]
    public double? AmyDvrEmlakBrkAmortisman { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl1")]
    public bool? AmyYenidenDgrlmYokFl1 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl2")]
    public bool? AmyYenidenDgrlmYokFl2 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl3")]
    public bool? AmyYenidenDgrlmYokFl3 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl4")]
    public bool? AmyYenidenDgrlmYokFl4 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl5")]
    public bool? AmyYenidenDgrlmYokFl5 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl6")]
    public bool? AmyYenidenDgrlmYokFl6 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl7")]
    public bool? AmyYenidenDgrlmYokFl7 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl8")]
    public bool? AmyYenidenDgrlmYokFl8 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl9")]
    public bool? AmyYenidenDgrlmYokFl9 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl10")]
    public bool? AmyYenidenDgrlmYokFl10 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl11")]
    public bool? AmyYenidenDgrlmYokFl11 { get; set; }

    [Column("amy_yeniden_dgrlm_yok_fl12")]
    public bool? AmyYenidenDgrlmYokFl12 { get; set; }

    [Column("amy_satilan_miktar1")]
    public double? AmySatilanMiktar1 { get; set; }

    [Column("amy_satilan_miktar2")]
    public double? AmySatilanMiktar2 { get; set; }

    [Column("amy_satilan_miktar3")]
    public double? AmySatilanMiktar3 { get; set; }

    [Column("amy_satilan_miktar4")]
    public double? AmySatilanMiktar4 { get; set; }

    [Column("amy_satilan_miktar5")]
    public double? AmySatilanMiktar5 { get; set; }

    [Column("amy_satilan_miktar6")]
    public double? AmySatilanMiktar6 { get; set; }

    [Column("amy_satilan_miktar7")]
    public double? AmySatilanMiktar7 { get; set; }

    [Column("amy_satilan_miktar8")]
    public double? AmySatilanMiktar8 { get; set; }

    [Column("amy_satilan_miktar9")]
    public double? AmySatilanMiktar9 { get; set; }

    [Column("amy_satilan_miktar10")]
    public double? AmySatilanMiktar10 { get; set; }

    [Column("amy_satilan_miktar11")]
    public double? AmySatilanMiktar11 { get; set; }

    [Column("amy_satilan_miktar12")]
    public double? AmySatilanMiktar12 { get; set; }

    [Column("amy_srmy_art1")]
    public bool? AmySrmyArt1 { get; set; }

    [Column("amy_srmy_art2")]
    public bool? AmySrmyArt2 { get; set; }

    [Column("amy_srmy_art3")]
    public bool? AmySrmyArt3 { get; set; }

    [Column("amy_srmy_art4")]
    public bool? AmySrmyArt4 { get; set; }

    [Column("amy_srmy_art5")]
    public bool? AmySrmyArt5 { get; set; }

    [Column("amy_srmy_art6")]
    public bool? AmySrmyArt6 { get; set; }

    [Column("amy_srmy_art7")]
    public bool? AmySrmyArt7 { get; set; }

    [Column("amy_srmy_art8")]
    public bool? AmySrmyArt8 { get; set; }

    [Column("amy_srmy_art9")]
    public bool? AmySrmyArt9 { get; set; }

    [Column("amy_srmy_art10")]
    public bool? AmySrmyArt10 { get; set; }

    [Column("amy_srmy_art11")]
    public bool? AmySrmyArt11 { get; set; }

    [Column("amy_srmy_art12")]
    public bool? AmySrmyArt12 { get; set; }

    [Column("amy_dvr_birikmis_amortisman_ufrs")]
    public double? AmyDvrBirikmisAmortismanUfrs { get; set; }

    [Column("amy_dvr_birikmis_amortisman_alt_ufrs")]
    public double? AmyDvrBirikmisAmortismanAltUfrs { get; set; }

    [Column("amy_dvr_birikmis_amortisman_orj_ufrs")]
    public double? AmyDvrBirikmisAmortismanOrjUfrs { get; set; }

    [Column("amy_dvr_bil_ak_dgr_ufrs")]
    public double? AmyDvrBilAkDgrUfrs { get; set; }

    [Column("amy_dvr_bil_ak_dgr_alt_ufrs")]
    public double? AmyDvrBilAkDgrAltUfrs { get; set; }

    [Column("amy_dvr_bil_ak_dgr_orj_ufrs")]
    public double? AmyDvrBilAkDgrOrjUfrs { get; set; }

    [Column("amy_dvr_sanal_brk_amortisman_ufrs")]
    public double? AmyDvrSanalBrkAmortismanUfrs { get; set; }

    [Column("amy_dvr_sanal_brk_amortisman_alt_ufrs")]
    public double? AmyDvrSanalBrkAmortismanAltUfrs { get; set; }

    [Column("amy_dvr_sanal_brk_amortisman_orj_ufrs")]
    public double? AmyDvrSanalBrkAmortismanOrjUfrs { get; set; }

    [Column("amy_dvr_emlak_brk_amortisman_ufrs")]
    public double? AmyDvrEmlakBrkAmortismanUfrs { get; set; }

    [Column("amy_dvr_emlak_brk_amortisman_alt_ufrs")]
    public double? AmyDvrEmlakBrkAmortismanAltUfrs { get; set; }

    [Column("amy_dvr_emlak_brk_amortisman_orj_ufrs")]
    public double? AmyDvrEmlakBrkAmortismanOrjUfrs { get; set; }
}
