using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_maliyil_uretim_parametreleri")]
public class FirmaMaliyilUretimParametreleri
{
    [Column("fmu_Guid")]
    public Guid? FmuGuid { get; set; }

    [Column("fmu_DBCno")]
    public short? FmuDBCno { get; set; }

    [Column("fmu_SpecRECno")]
    public int? FmuSpecRECno { get; set; }

    [Column("fmu_iptal")]
    public bool? FmuIptal { get; set; }

    [Column("fmu_fileid")]
    public short? FmuFileid { get; set; }

    [Column("fmu_hidden")]
    public bool? FmuHidden { get; set; }

    [Column("fmu_kilitli")]
    public bool? FmuKilitli { get; set; }

    [Column("fmu_degisti")]
    public bool? FmuDegisti { get; set; }

    [Column("fmu_checksum")]
    public int? FmuChecksum { get; set; }

    [Column("fmu_create_user")]
    public short? FmuCreateUser { get; set; }

    [Column("fmu_create_date")]
    public DateTime? FmuCreateDate { get; set; }

    [Column("fmu_lastup_user")]
    public short? FmuLastupUser { get; set; }

    [Column("fmu_lastup_date")]
    public DateTime? FmuLastupDate { get; set; }

    [Column("fmu_special1")]
    [StringLength(4)]
    public string? FmuSpecial1 { get; set; }

    [Column("fmu_special2")]
    [StringLength(4)]
    public string? FmuSpecial2 { get; set; }

    [Column("fmu_special3")]
    [StringLength(4)]
    public string? FmuSpecial3 { get; set; }

    [Column("fmu_sirano")]
    public int? FmuSirano { get; set; }

    [Column("fmu_maliyil")]
    public int? FmuMaliyil { get; set; }

    [Column("fmu_dig_isim_1")]
    [StringLength(20)]
    public string? FmuDigIsim1 { get; set; }

    [Column("fmu_dig_tutar_1_0")]
    public double? FmuDigTutar10 { get; set; }

    [Column("fmu_dig_tutar_1_1")]
    public double? FmuDigTutar11 { get; set; }

    [Column("fmu_dig_tutar_1_2")]
    public double? FmuDigTutar12 { get; set; }

    [Column("fmu_dig_tutar_1_3")]
    public double? FmuDigTutar13 { get; set; }

    [Column("fmu_dig_tutar_1_4")]
    public double? FmuDigTutar14 { get; set; }

    [Column("fmu_dig_tutar_1_5")]
    public double? FmuDigTutar15 { get; set; }

    [Column("fmu_dig_tutar_1_6")]
    public double? FmuDigTutar16 { get; set; }

    [Column("fmu_dig_tutar_1_7")]
    public double? FmuDigTutar17 { get; set; }

    [Column("fmu_dig_tutar_1_8")]
    public double? FmuDigTutar18 { get; set; }

    [Column("fmu_dig_tutar_1_9")]
    public double? FmuDigTutar19 { get; set; }

    [Column("fmu_dig_tutar_1_10")]
    public double? FmuDigTutar110 { get; set; }

    [Column("fmu_dig_tutar_1_11")]
    public double? FmuDigTutar111 { get; set; }

    [Column("fmu_dig_tutar_1_12")]
    public double? FmuDigTutar112 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_1")]
    public double? FmuDigDsBekleyen11 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_2")]
    public double? FmuDigDsBekleyen12 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_3")]
    public double? FmuDigDsBekleyen13 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_4")]
    public double? FmuDigDsBekleyen14 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_5")]
    public double? FmuDigDsBekleyen15 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_6")]
    public double? FmuDigDsBekleyen16 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_7")]
    public double? FmuDigDsBekleyen17 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_8")]
    public double? FmuDigDsBekleyen18 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_9")]
    public double? FmuDigDsBekleyen19 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_10")]
    public double? FmuDigDsBekleyen110 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_11")]
    public double? FmuDigDsBekleyen111 { get; set; }

    [Column("fmu_dig_ds_bekleyen_1_12")]
    public double? FmuDigDsBekleyen112 { get; set; }

    [Column("fmu_dig_birikim_muhkodu_1")]
    [StringLength(25)]
    public string? FmuDigBirikimMuhkodu1 { get; set; }

    [Column("fmu_dig_isim_2")]
    [StringLength(20)]
    public string? FmuDigIsim2 { get; set; }

    [Column("fmu_dig_tutar_2_0")]
    public double? FmuDigTutar20 { get; set; }

    [Column("fmu_dig_tutar_2_1")]
    public double? FmuDigTutar21 { get; set; }

    [Column("fmu_dig_tutar_2_2")]
    public double? FmuDigTutar22 { get; set; }

    [Column("fmu_dig_tutar_2_3")]
    public double? FmuDigTutar23 { get; set; }

    [Column("fmu_dig_tutar_2_4")]
    public double? FmuDigTutar24 { get; set; }

    [Column("fmu_dig_tutar_2_5")]
    public double? FmuDigTutar25 { get; set; }

    [Column("fmu_dig_tutar_2_6")]
    public double? FmuDigTutar26 { get; set; }

    [Column("fmu_dig_tutar_2_7")]
    public double? FmuDigTutar27 { get; set; }

    [Column("fmu_dig_tutar_2_8")]
    public double? FmuDigTutar28 { get; set; }

    [Column("fmu_dig_tutar_2_9")]
    public double? FmuDigTutar29 { get; set; }

    [Column("fmu_dig_tutar_2_10")]
    public double? FmuDigTutar210 { get; set; }

    [Column("fmu_dig_tutar_2_11")]
    public double? FmuDigTutar211 { get; set; }

    [Column("fmu_dig_tutar_2_12")]
    public double? FmuDigTutar212 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_1")]
    public double? FmuDigDsBekleyen21 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_2")]
    public double? FmuDigDsBekleyen22 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_3")]
    public double? FmuDigDsBekleyen23 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_4")]
    public double? FmuDigDsBekleyen24 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_5")]
    public double? FmuDigDsBekleyen25 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_6")]
    public double? FmuDigDsBekleyen26 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_7")]
    public double? FmuDigDsBekleyen27 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_8")]
    public double? FmuDigDsBekleyen28 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_9")]
    public double? FmuDigDsBekleyen29 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_10")]
    public double? FmuDigDsBekleyen210 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_11")]
    public double? FmuDigDsBekleyen211 { get; set; }

    [Column("fmu_dig_ds_bekleyen_2_12")]
    public double? FmuDigDsBekleyen212 { get; set; }

    [Column("fmu_dig_birikim_muhkodu_2")]
    [StringLength(25)]
    public string? FmuDigBirikimMuhkodu2 { get; set; }

    [Column("fmu_dig_isim_3")]
    [StringLength(20)]
    public string? FmuDigIsim3 { get; set; }

    [Column("fmu_dig_tutar_3_0")]
    public double? FmuDigTutar30 { get; set; }

    [Column("fmu_dig_tutar_3_1")]
    public double? FmuDigTutar31 { get; set; }

    [Column("fmu_dig_tutar_3_2")]
    public double? FmuDigTutar32 { get; set; }

    [Column("fmu_dig_tutar_3_3")]
    public double? FmuDigTutar33 { get; set; }

    [Column("fmu_dig_tutar_3_4")]
    public double? FmuDigTutar34 { get; set; }

    [Column("fmu_dig_tutar_3_5")]
    public double? FmuDigTutar35 { get; set; }

    [Column("fmu_dig_tutar_3_6")]
    public double? FmuDigTutar36 { get; set; }

    [Column("fmu_dig_tutar_3_7")]
    public double? FmuDigTutar37 { get; set; }

    [Column("fmu_dig_tutar_3_8")]
    public double? FmuDigTutar38 { get; set; }

    [Column("fmu_dig_tutar_3_9")]
    public double? FmuDigTutar39 { get; set; }

    [Column("fmu_dig_tutar_3_10")]
    public double? FmuDigTutar310 { get; set; }

    [Column("fmu_dig_tutar_3_11")]
    public double? FmuDigTutar311 { get; set; }

    [Column("fmu_dig_tutar_3_12")]
    public double? FmuDigTutar312 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_1")]
    public double? FmuDigDsBekleyen31 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_2")]
    public double? FmuDigDsBekleyen32 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_3")]
    public double? FmuDigDsBekleyen33 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_4")]
    public double? FmuDigDsBekleyen34 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_5")]
    public double? FmuDigDsBekleyen35 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_6")]
    public double? FmuDigDsBekleyen36 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_7")]
    public double? FmuDigDsBekleyen37 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_8")]
    public double? FmuDigDsBekleyen38 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_9")]
    public double? FmuDigDsBekleyen39 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_10")]
    public double? FmuDigDsBekleyen310 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_11")]
    public double? FmuDigDsBekleyen311 { get; set; }

    [Column("fmu_dig_ds_bekleyen_3_12")]
    public double? FmuDigDsBekleyen312 { get; set; }

    [Column("fmu_dig_birikim_muhkodu_3")]
    [StringLength(25)]
    public string? FmuDigBirikimMuhkodu3 { get; set; }

    [Column("fmu_dig_isim_4")]
    [StringLength(20)]
    public string? FmuDigIsim4 { get; set; }

    [Column("fmu_dig_tutar_4_0")]
    public double? FmuDigTutar40 { get; set; }

    [Column("fmu_dig_tutar_4_1")]
    public double? FmuDigTutar41 { get; set; }

    [Column("fmu_dig_tutar_4_2")]
    public double? FmuDigTutar42 { get; set; }

    [Column("fmu_dig_tutar_4_3")]
    public double? FmuDigTutar43 { get; set; }

    [Column("fmu_dig_tutar_4_4")]
    public double? FmuDigTutar44 { get; set; }

    [Column("fmu_dig_tutar_4_5")]
    public double? FmuDigTutar45 { get; set; }

    [Column("fmu_dig_tutar_4_6")]
    public double? FmuDigTutar46 { get; set; }

    [Column("fmu_dig_tutar_4_7")]
    public double? FmuDigTutar47 { get; set; }

    [Column("fmu_dig_tutar_4_8")]
    public double? FmuDigTutar48 { get; set; }

    [Column("fmu_dig_tutar_4_9")]
    public double? FmuDigTutar49 { get; set; }

    [Column("fmu_dig_tutar_4_10")]
    public double? FmuDigTutar410 { get; set; }

    [Column("fmu_dig_tutar_4_11")]
    public double? FmuDigTutar411 { get; set; }

    [Column("fmu_dig_tutar_4_12")]
    public double? FmuDigTutar412 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_1")]
    public double? FmuDigDsBekleyen41 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_2")]
    public double? FmuDigDsBekleyen42 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_3")]
    public double? FmuDigDsBekleyen43 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_4")]
    public double? FmuDigDsBekleyen44 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_5")]
    public double? FmuDigDsBekleyen45 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_6")]
    public double? FmuDigDsBekleyen46 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_7")]
    public double? FmuDigDsBekleyen47 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_8")]
    public double? FmuDigDsBekleyen48 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_9")]
    public double? FmuDigDsBekleyen49 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_10")]
    public double? FmuDigDsBekleyen410 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_11")]
    public double? FmuDigDsBekleyen411 { get; set; }

    [Column("fmu_dig_ds_bekleyen_4_12")]
    public double? FmuDigDsBekleyen412 { get; set; }

    [Column("fmu_dig_birikim_muhkodu_4")]
    [StringLength(25)]
    public string? FmuDigBirikimMuhkodu4 { get; set; }

    [Column("fmu_dig_isim_5")]
    [StringLength(20)]
    public string? FmuDigIsim5 { get; set; }

    [Column("fmu_dig_tutar_5_0")]
    public double? FmuDigTutar50 { get; set; }

    [Column("fmu_dig_tutar_5_1")]
    public double? FmuDigTutar51 { get; set; }

    [Column("fmu_dig_tutar_5_2")]
    public double? FmuDigTutar52 { get; set; }

    [Column("fmu_dig_tutar_5_3")]
    public double? FmuDigTutar53 { get; set; }

    [Column("fmu_dig_tutar_5_4")]
    public double? FmuDigTutar54 { get; set; }

    [Column("fmu_dig_tutar_5_5")]
    public double? FmuDigTutar55 { get; set; }

    [Column("fmu_dig_tutar_5_6")]
    public double? FmuDigTutar56 { get; set; }

    [Column("fmu_dig_tutar_5_7")]
    public double? FmuDigTutar57 { get; set; }

    [Column("fmu_dig_tutar_5_8")]
    public double? FmuDigTutar58 { get; set; }

    [Column("fmu_dig_tutar_5_9")]
    public double? FmuDigTutar59 { get; set; }

    [Column("fmu_dig_tutar_5_10")]
    public double? FmuDigTutar510 { get; set; }

    [Column("fmu_dig_tutar_5_11")]
    public double? FmuDigTutar511 { get; set; }

    [Column("fmu_dig_tutar_5_12")]
    public double? FmuDigTutar512 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_1")]
    public double? FmuDigDsBekleyen51 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_2")]
    public double? FmuDigDsBekleyen52 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_3")]
    public double? FmuDigDsBekleyen53 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_4")]
    public double? FmuDigDsBekleyen54 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_5")]
    public double? FmuDigDsBekleyen55 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_6")]
    public double? FmuDigDsBekleyen56 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_7")]
    public double? FmuDigDsBekleyen57 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_8")]
    public double? FmuDigDsBekleyen58 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_9")]
    public double? FmuDigDsBekleyen59 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_10")]
    public double? FmuDigDsBekleyen510 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_11")]
    public double? FmuDigDsBekleyen511 { get; set; }

    [Column("fmu_dig_ds_bekleyen_5_12")]
    public double? FmuDigDsBekleyen512 { get; set; }

    [Column("fmu_dig_birikim_muhkodu_5")]
    [StringLength(25)]
    public string? FmuDigBirikimMuhkodu5 { get; set; }

    [Column("fmu_gug_isim_1")]
    [StringLength(20)]
    public string? FmuGugIsim1 { get; set; }

    [Column("fmu_gug_tutar_1_0")]
    public double? FmuGugTutar10 { get; set; }

    [Column("fmu_gug_tutar_1_1")]
    public double? FmuGugTutar11 { get; set; }

    [Column("fmu_gug_tutar_1_2")]
    public double? FmuGugTutar12 { get; set; }

    [Column("fmu_gug_tutar_1_3")]
    public double? FmuGugTutar13 { get; set; }

    [Column("fmu_gug_tutar_1_4")]
    public double? FmuGugTutar14 { get; set; }

    [Column("fmu_gug_tutar_1_5")]
    public double? FmuGugTutar15 { get; set; }

    [Column("fmu_gug_tutar_1_6")]
    public double? FmuGugTutar16 { get; set; }

    [Column("fmu_gug_tutar_1_7")]
    public double? FmuGugTutar17 { get; set; }

    [Column("fmu_gug_tutar_1_8")]
    public double? FmuGugTutar18 { get; set; }

    [Column("fmu_gug_tutar_1_9")]
    public double? FmuGugTutar19 { get; set; }

    [Column("fmu_gug_tutar_1_10")]
    public double? FmuGugTutar110 { get; set; }

    [Column("fmu_gug_tutar_1_11")]
    public double? FmuGugTutar111 { get; set; }

    [Column("fmu_gug_tutar_1_12")]
    public double? FmuGugTutar112 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_1")]
    public double? FmuGugDsBekleyen11 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_2")]
    public double? FmuGugDsBekleyen12 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_3")]
    public double? FmuGugDsBekleyen13 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_4")]
    public double? FmuGugDsBekleyen14 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_5")]
    public double? FmuGugDsBekleyen15 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_6")]
    public double? FmuGugDsBekleyen16 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_7")]
    public double? FmuGugDsBekleyen17 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_8")]
    public double? FmuGugDsBekleyen18 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_9")]
    public double? FmuGugDsBekleyen19 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_10")]
    public double? FmuGugDsBekleyen110 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_11")]
    public double? FmuGugDsBekleyen111 { get; set; }

    [Column("fmu_gug_ds_bekleyen_1_12")]
    public double? FmuGugDsBekleyen112 { get; set; }

    [Column("fmu_gug_birikim_muhkodu_1")]
    [StringLength(25)]
    public string? FmuGugBirikimMuhkodu1 { get; set; }

    [Column("fmu_gug_isim_2")]
    [StringLength(20)]
    public string? FmuGugIsim2 { get; set; }

    [Column("fmu_gug_tutar_2_0")]
    public double? FmuGugTutar20 { get; set; }

    [Column("fmu_gug_tutar_2_1")]
    public double? FmuGugTutar21 { get; set; }

    [Column("fmu_gug_tutar_2_2")]
    public double? FmuGugTutar22 { get; set; }

    [Column("fmu_gug_tutar_2_3")]
    public double? FmuGugTutar23 { get; set; }

    [Column("fmu_gug_tutar_2_4")]
    public double? FmuGugTutar24 { get; set; }

    [Column("fmu_gug_tutar_2_5")]
    public double? FmuGugTutar25 { get; set; }

    [Column("fmu_gug_tutar_2_6")]
    public double? FmuGugTutar26 { get; set; }

    [Column("fmu_gug_tutar_2_7")]
    public double? FmuGugTutar27 { get; set; }

    [Column("fmu_gug_tutar_2_8")]
    public double? FmuGugTutar28 { get; set; }

    [Column("fmu_gug_tutar_2_9")]
    public double? FmuGugTutar29 { get; set; }

    [Column("fmu_gug_tutar_2_10")]
    public double? FmuGugTutar210 { get; set; }

    [Column("fmu_gug_tutar_2_11")]
    public double? FmuGugTutar211 { get; set; }

    [Column("fmu_gug_tutar_2_12")]
    public double? FmuGugTutar212 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_1")]
    public double? FmuGugDsBekleyen21 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_2")]
    public double? FmuGugDsBekleyen22 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_3")]
    public double? FmuGugDsBekleyen23 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_4")]
    public double? FmuGugDsBekleyen24 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_5")]
    public double? FmuGugDsBekleyen25 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_6")]
    public double? FmuGugDsBekleyen26 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_7")]
    public double? FmuGugDsBekleyen27 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_8")]
    public double? FmuGugDsBekleyen28 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_9")]
    public double? FmuGugDsBekleyen29 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_10")]
    public double? FmuGugDsBekleyen210 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_11")]
    public double? FmuGugDsBekleyen211 { get; set; }

    [Column("fmu_gug_ds_bekleyen_2_12")]
    public double? FmuGugDsBekleyen212 { get; set; }

    [Column("fmu_gug_birikim_muhkodu_2")]
    [StringLength(25)]
    public string? FmuGugBirikimMuhkodu2 { get; set; }

    [Column("fmu_gug_isim_3")]
    [StringLength(20)]
    public string? FmuGugIsim3 { get; set; }

    [Column("fmu_gug_tutar_3_0")]
    public double? FmuGugTutar30 { get; set; }

    [Column("fmu_gug_tutar_3_1")]
    public double? FmuGugTutar31 { get; set; }

    [Column("fmu_gug_tutar_3_2")]
    public double? FmuGugTutar32 { get; set; }

    [Column("fmu_gug_tutar_3_3")]
    public double? FmuGugTutar33 { get; set; }

    [Column("fmu_gug_tutar_3_4")]
    public double? FmuGugTutar34 { get; set; }

    [Column("fmu_gug_tutar_3_5")]
    public double? FmuGugTutar35 { get; set; }

    [Column("fmu_gug_tutar_3_6")]
    public double? FmuGugTutar36 { get; set; }

    [Column("fmu_gug_tutar_3_7")]
    public double? FmuGugTutar37 { get; set; }

    [Column("fmu_gug_tutar_3_8")]
    public double? FmuGugTutar38 { get; set; }

    [Column("fmu_gug_tutar_3_9")]
    public double? FmuGugTutar39 { get; set; }

    [Column("fmu_gug_tutar_3_10")]
    public double? FmuGugTutar310 { get; set; }

    [Column("fmu_gug_tutar_3_11")]
    public double? FmuGugTutar311 { get; set; }

    [Column("fmu_gug_tutar_3_12")]
    public double? FmuGugTutar312 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_1")]
    public double? FmuGugDsBekleyen31 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_2")]
    public double? FmuGugDsBekleyen32 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_3")]
    public double? FmuGugDsBekleyen33 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_4")]
    public double? FmuGugDsBekleyen34 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_5")]
    public double? FmuGugDsBekleyen35 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_6")]
    public double? FmuGugDsBekleyen36 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_7")]
    public double? FmuGugDsBekleyen37 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_8")]
    public double? FmuGugDsBekleyen38 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_9")]
    public double? FmuGugDsBekleyen39 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_10")]
    public double? FmuGugDsBekleyen310 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_11")]
    public double? FmuGugDsBekleyen311 { get; set; }

    [Column("fmu_gug_ds_bekleyen_3_12")]
    public double? FmuGugDsBekleyen312 { get; set; }

    [Column("fmu_gug_birikim_muhkodu_3")]
    [StringLength(25)]
    public string? FmuGugBirikimMuhkodu3 { get; set; }

    [Column("fmu_gug_isim_4")]
    [StringLength(20)]
    public string? FmuGugIsim4 { get; set; }

    [Column("fmu_gug_tutar_4_0")]
    public double? FmuGugTutar40 { get; set; }

    [Column("fmu_gug_tutar_4_1")]
    public double? FmuGugTutar41 { get; set; }

    [Column("fmu_gug_tutar_4_2")]
    public double? FmuGugTutar42 { get; set; }

    [Column("fmu_gug_tutar_4_3")]
    public double? FmuGugTutar43 { get; set; }

    [Column("fmu_gug_tutar_4_4")]
    public double? FmuGugTutar44 { get; set; }

    [Column("fmu_gug_tutar_4_5")]
    public double? FmuGugTutar45 { get; set; }

    [Column("fmu_gug_tutar_4_6")]
    public double? FmuGugTutar46 { get; set; }

    [Column("fmu_gug_tutar_4_7")]
    public double? FmuGugTutar47 { get; set; }

    [Column("fmu_gug_tutar_4_8")]
    public double? FmuGugTutar48 { get; set; }

    [Column("fmu_gug_tutar_4_9")]
    public double? FmuGugTutar49 { get; set; }

    [Column("fmu_gug_tutar_4_10")]
    public double? FmuGugTutar410 { get; set; }

    [Column("fmu_gug_tutar_4_11")]
    public double? FmuGugTutar411 { get; set; }

    [Column("fmu_gug_tutar_4_12")]
    public double? FmuGugTutar412 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_1")]
    public double? FmuGugDsBekleyen41 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_2")]
    public double? FmuGugDsBekleyen42 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_3")]
    public double? FmuGugDsBekleyen43 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_4")]
    public double? FmuGugDsBekleyen44 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_5")]
    public double? FmuGugDsBekleyen45 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_6")]
    public double? FmuGugDsBekleyen46 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_7")]
    public double? FmuGugDsBekleyen47 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_8")]
    public double? FmuGugDsBekleyen48 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_9")]
    public double? FmuGugDsBekleyen49 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_10")]
    public double? FmuGugDsBekleyen410 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_11")]
    public double? FmuGugDsBekleyen411 { get; set; }

    [Column("fmu_gug_ds_bekleyen_4_12")]
    public double? FmuGugDsBekleyen412 { get; set; }

    [Column("fmu_gug_birikim_muhkodu_4")]
    [StringLength(25)]
    public string? FmuGugBirikimMuhkodu4 { get; set; }

    [Column("fmu_gug_isim_5")]
    [StringLength(20)]
    public string? FmuGugIsim5 { get; set; }

    [Column("fmu_gug_tutar_5_0")]
    public double? FmuGugTutar50 { get; set; }

    [Column("fmu_gug_tutar_5_1")]
    public double? FmuGugTutar51 { get; set; }

    [Column("fmu_gug_tutar_5_2")]
    public double? FmuGugTutar52 { get; set; }

    [Column("fmu_gug_tutar_5_3")]
    public double? FmuGugTutar53 { get; set; }

    [Column("fmu_gug_tutar_5_4")]
    public double? FmuGugTutar54 { get; set; }

    [Column("fmu_gug_tutar_5_5")]
    public double? FmuGugTutar55 { get; set; }

    [Column("fmu_gug_tutar_5_6")]
    public double? FmuGugTutar56 { get; set; }

    [Column("fmu_gug_tutar_5_7")]
    public double? FmuGugTutar57 { get; set; }

    [Column("fmu_gug_tutar_5_8")]
    public double? FmuGugTutar58 { get; set; }

    [Column("fmu_gug_tutar_5_9")]
    public double? FmuGugTutar59 { get; set; }

    [Column("fmu_gug_tutar_5_10")]
    public double? FmuGugTutar510 { get; set; }

    [Column("fmu_gug_tutar_5_11")]
    public double? FmuGugTutar511 { get; set; }

    [Column("fmu_gug_tutar_5_12")]
    public double? FmuGugTutar512 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_1")]
    public double? FmuGugDsBekleyen51 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_2")]
    public double? FmuGugDsBekleyen52 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_3")]
    public double? FmuGugDsBekleyen53 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_4")]
    public double? FmuGugDsBekleyen54 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_5")]
    public double? FmuGugDsBekleyen55 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_6")]
    public double? FmuGugDsBekleyen56 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_7")]
    public double? FmuGugDsBekleyen57 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_8")]
    public double? FmuGugDsBekleyen58 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_9")]
    public double? FmuGugDsBekleyen59 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_10")]
    public double? FmuGugDsBekleyen510 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_11")]
    public double? FmuGugDsBekleyen511 { get; set; }

    [Column("fmu_gug_ds_bekleyen_5_12")]
    public double? FmuGugDsBekleyen512 { get; set; }

    [Column("fmu_gug_birikim_muhkodu_5")]
    [StringLength(25)]
    public string? FmuGugBirikimMuhkodu5 { get; set; }

    [Column("fmu_dfgeneluretimyansitmamuhkodu1")]
    [StringLength(25)]
    public string? FmuDfgeneluretimyansitmamuhkodu1 { get; set; }

    [Column("fmu_dfgeneluretimyansitmamuhkodu2")]
    [StringLength(25)]
    public string? FmuDfgeneluretimyansitmamuhkodu2 { get; set; }

    [Column("fmu_dfgeneluretimyansitmamuhkodu3")]
    [StringLength(25)]
    public string? FmuDfgeneluretimyansitmamuhkodu3 { get; set; }

    [Column("fmu_dfgeneluretimyansitmamuhkodu4")]
    [StringLength(25)]
    public string? FmuDfgeneluretimyansitmamuhkodu4 { get; set; }

    [Column("fmu_dfgeneluretimyansitmamuhkodu5")]
    [StringLength(25)]
    public string? FmuDfgeneluretimyansitmamuhkodu5 { get; set; }

    [Column("fmu_dfstokbirikimmuhkodu")]
    [StringLength(25)]
    public string? FmuDfstokbirikimmuhkodu { get; set; }

    [Column("fmu_dfhizmetbirikimmuhkodu")]
    [StringLength(25)]
    public string? FmuDfhizmetbirikimmuhkodu { get; set; }

    [Column("fmu_dfstokyansitmamuhkodu")]
    [StringLength(25)]
    public string? FmuDfstokyansitmamuhkodu { get; set; }

    [Column("fmu_dfhizmetyansitmamuhkodu")]
    [StringLength(25)]
    public string? FmuDfhizmetyansitmamuhkodu { get; set; }

    [Column("fmu_dfyarimamulbirikimmuhkodu")]
    [StringLength(25)]
    public string? FmuDfyarimamulbirikimmuhkodu { get; set; }

    [Column("fmu_dfyarimamulyansitmamuhkodu")]
    [StringLength(25)]
    public string? FmuDfyarimamulyansitmamuhkodu { get; set; }

    [Column("fmu_dfdirektiscilikyansitmamuhkodu1")]
    [StringLength(25)]
    public string? FmuDfdirektiscilikyansitmamuhkodu1 { get; set; }

    [Column("fmu_dfdirektiscilikyansitmamuhkodu2")]
    [StringLength(25)]
    public string? FmuDfdirektiscilikyansitmamuhkodu2 { get; set; }

    [Column("fmu_dfdirektiscilikyansitmamuhkodu3")]
    [StringLength(25)]
    public string? FmuDfdirektiscilikyansitmamuhkodu3 { get; set; }

    [Column("fmu_dfdirektiscilikyansitmamuhkodu4")]
    [StringLength(25)]
    public string? FmuDfdirektiscilikyansitmamuhkodu4 { get; set; }

    [Column("fmu_dfdirektiscilikyansitmamuhkodu5")]
    [StringLength(25)]
    public string? FmuDfdirektiscilikyansitmamuhkodu5 { get; set; }

    [Column("fmu_dfmakinemaliyetyansitmamuhkodu")]
    [StringLength(25)]
    public string? FmuDfmakinemaliyetyansitmamuhkodu { get; set; }

    [Column("fmu_dfelemanmaliyetyansitmamuhkodu")]
    [StringLength(25)]
    public string? FmuDfelemanmaliyetyansitmamuhkodu { get; set; }

    [Column("fmu_dfyarimamulmuhkodu")]
    [StringLength(25)]
    public string? FmuDfyarimamulmuhkodu { get; set; }

    [Column("fmu_ufrs_uretimmaliyetifarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsUretimmaliyetifarkikodu { get; set; }

    [Column("fmu_ufrs_stokyansitmafarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsStokyansitmafarkikodu { get; set; }

    [Column("fmu_ufrs_yarimamulyansitmafarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsYarimamulyansitmafarkikodu { get; set; }

    [Column("fmu_ufrs_hizmetyansitmafarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsHizmetyansitmafarkikodu { get; set; }

    [Column("fmu_ufrs_elemanmaliyetyansitmafarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsElemanmaliyetyansitmafarkikodu { get; set; }

    [Column("fmu_ufrs_makinemaliyetyansitmafarkikodu")]
    [StringLength(25)]
    public string? FmuUfrsMakinemaliyetyansitmafarkikodu { get; set; }

    [Column("fmu_ilkmadde_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmuIlkmaddeGiderHesapkodu { get; set; }

    [Column("fmu_iscilik_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmuIscilikGiderHesapkodu { get; set; }

    [Column("fmu_geneluretim_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmuGeneluretimGiderHesapkodu { get; set; }

    [Column("fmu_hizmeturetim_gider_hesapkodu")]
    [StringLength(25)]
    public string? FmuHizmeturetimGiderHesapkodu { get; set; }
}
