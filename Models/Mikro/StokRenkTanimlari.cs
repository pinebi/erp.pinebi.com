using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_renk_tanimlari")]
public class StokRenkTanimlari
{
    [Column("rnk_Guid")]
    public Guid? RnkGuid { get; set; }

    [Column("rnk_DBCno")]
    public short? RnkDBCno { get; set; }

    [Column("rnk_SpecRECNo")]
    public int? RnkSpecRECNo { get; set; }

    [Column("rnk_iptal")]
    public bool? RnkIptal { get; set; }

    [Column("rnk_fileid")]
    public short? RnkFileid { get; set; }

    [Column("rnk_hidden")]
    public bool? RnkHidden { get; set; }

    [Column("rnk_kilitli")]
    public bool? RnkKilitli { get; set; }

    [Column("rnk_degisti")]
    public bool? RnkDegisti { get; set; }

    [Column("rnk_CheckSum")]
    public int? RnkCheckSum { get; set; }

    [Column("rnk_create_user")]
    public short? RnkCreateUser { get; set; }

    [Column("rnk_create_date")]
    public DateTime? RnkCreateDate { get; set; }

    [Column("rnk_lastup_user")]
    public short? RnkLastupUser { get; set; }

    [Column("rnk_lastup_date")]
    public DateTime? RnkLastupDate { get; set; }

    [Column("rnk_special1")]
    [StringLength(4)]
    public string? RnkSpecial1 { get; set; }

    [Column("rnk_special2")]
    [StringLength(4)]
    public string? RnkSpecial2 { get; set; }

    [Column("rnk_special3")]
    [StringLength(4)]
    public string? RnkSpecial3 { get; set; }

    [Column("rnk_kodu")]
    [StringLength(25)]
    public string? RnkKodu { get; set; }

    [Column("rnk_ismi")]
    [StringLength(40)]
    public string? RnkIsmi { get; set; }

    [Column("rnk_kirilim_1")]
    [StringLength(40)]
    public string? RnkKirilim1 { get; set; }

    [Column("rnk_kirilim_2")]
    [StringLength(40)]
    public string? RnkKirilim2 { get; set; }

    [Column("rnk_kirilim_3")]
    [StringLength(40)]
    public string? RnkKirilim3 { get; set; }

    [Column("rnk_kirilim_4")]
    [StringLength(40)]
    public string? RnkKirilim4 { get; set; }

    [Column("rnk_kirilim_5")]
    [StringLength(40)]
    public string? RnkKirilim5 { get; set; }

    [Column("rnk_kirilim_6")]
    [StringLength(40)]
    public string? RnkKirilim6 { get; set; }

    [Column("rnk_kirilim_7")]
    [StringLength(40)]
    public string? RnkKirilim7 { get; set; }

    [Column("rnk_kirilim_8")]
    [StringLength(40)]
    public string? RnkKirilim8 { get; set; }

    [Column("rnk_kirilim_9")]
    [StringLength(40)]
    public string? RnkKirilim9 { get; set; }

    [Column("rnk_kirilim_10")]
    [StringLength(40)]
    public string? RnkKirilim10 { get; set; }

    [Column("rnk_kirilim_11")]
    [StringLength(40)]
    public string? RnkKirilim11 { get; set; }

    [Column("rnk_kirilim_12")]
    [StringLength(40)]
    public string? RnkKirilim12 { get; set; }

    [Column("rnk_kirilim_13")]
    [StringLength(40)]
    public string? RnkKirilim13 { get; set; }

    [Column("rnk_kirilim_14")]
    [StringLength(40)]
    public string? RnkKirilim14 { get; set; }

    [Column("rnk_kirilim_15")]
    [StringLength(40)]
    public string? RnkKirilim15 { get; set; }

    [Column("rnk_kirilim_16")]
    [StringLength(40)]
    public string? RnkKirilim16 { get; set; }

    [Column("rnk_kirilim_17")]
    [StringLength(40)]
    public string? RnkKirilim17 { get; set; }

    [Column("rnk_kirilim_18")]
    [StringLength(40)]
    public string? RnkKirilim18 { get; set; }

    [Column("rnk_kirilim_19")]
    [StringLength(40)]
    public string? RnkKirilim19 { get; set; }

    [Column("rnk_kirilim_20")]
    [StringLength(40)]
    public string? RnkKirilim20 { get; set; }

    [Column("rnk_kirilim_21")]
    [StringLength(40)]
    public string? RnkKirilim21 { get; set; }

    [Column("rnk_kirilim_22")]
    [StringLength(40)]
    public string? RnkKirilim22 { get; set; }

    [Column("rnk_kirilim_23")]
    [StringLength(40)]
    public string? RnkKirilim23 { get; set; }

    [Column("rnk_kirilim_24")]
    [StringLength(40)]
    public string? RnkKirilim24 { get; set; }

    [Column("rnk_kirilim_25")]
    [StringLength(40)]
    public string? RnkKirilim25 { get; set; }

    [Column("rnk_kirilim_26")]
    [StringLength(40)]
    public string? RnkKirilim26 { get; set; }

    [Column("rnk_kirilim_27")]
    [StringLength(40)]
    public string? RnkKirilim27 { get; set; }

    [Column("rnk_kirilim_28")]
    [StringLength(40)]
    public string? RnkKirilim28 { get; set; }

    [Column("rnk_kirilim_29")]
    [StringLength(40)]
    public string? RnkKirilim29 { get; set; }

    [Column("rnk_kirilim_30")]
    [StringLength(40)]
    public string? RnkKirilim30 { get; set; }

    [Column("rnk_kirilim_31")]
    [StringLength(40)]
    public string? RnkKirilim31 { get; set; }

    [Column("rnk_kirilim_32")]
    [StringLength(40)]
    public string? RnkKirilim32 { get; set; }

    [Column("rnk_kirilim_33")]
    [StringLength(40)]
    public string? RnkKirilim33 { get; set; }

    [Column("rnk_kirilim_34")]
    [StringLength(40)]
    public string? RnkKirilim34 { get; set; }

    [Column("rnk_kirilim_35")]
    [StringLength(40)]
    public string? RnkKirilim35 { get; set; }

    [Column("rnk_kirilim_36")]
    [StringLength(40)]
    public string? RnkKirilim36 { get; set; }

    [Column("rnk_kirilim_37")]
    [StringLength(40)]
    public string? RnkKirilim37 { get; set; }

    [Column("rnk_kirilim_38")]
    [StringLength(40)]
    public string? RnkKirilim38 { get; set; }

    [Column("rnk_kirilim_39")]
    [StringLength(40)]
    public string? RnkKirilim39 { get; set; }

    [Column("rnk_kirilim_40")]
    [StringLength(40)]
    public string? RnkKirilim40 { get; set; }

    [Column("rnk_kirilim_41")]
    [StringLength(40)]
    public string? RnkKirilim41 { get; set; }

    [Column("rnk_kirilim_42")]
    [StringLength(40)]
    public string? RnkKirilim42 { get; set; }

    [Column("rnk_kirilim_43")]
    [StringLength(40)]
    public string? RnkKirilim43 { get; set; }

    [Column("rnk_kirilim_44")]
    [StringLength(40)]
    public string? RnkKirilim44 { get; set; }

    [Column("rnk_kirilim_45")]
    [StringLength(40)]
    public string? RnkKirilim45 { get; set; }

    [Column("rnk_kirilim_46")]
    [StringLength(40)]
    public string? RnkKirilim46 { get; set; }

    [Column("rnk_kirilim_47")]
    [StringLength(40)]
    public string? RnkKirilim47 { get; set; }

    [Column("rnk_kirilim_48")]
    [StringLength(40)]
    public string? RnkKirilim48 { get; set; }

    [Column("rnk_kirilim_49")]
    [StringLength(40)]
    public string? RnkKirilim49 { get; set; }

    [Column("rnk_kirilim_50")]
    [StringLength(40)]
    public string? RnkKirilim50 { get; set; }

    [Column("rnk_kirilim_51")]
    [StringLength(40)]
    public string? RnkKirilim51 { get; set; }

    [Column("rnk_kirilim_52")]
    [StringLength(40)]
    public string? RnkKirilim52 { get; set; }

    [Column("rnk_kirilim_53")]
    [StringLength(40)]
    public string? RnkKirilim53 { get; set; }

    [Column("rnk_kirilim_54")]
    [StringLength(40)]
    public string? RnkKirilim54 { get; set; }

    [Column("rnk_kirilim_55")]
    [StringLength(40)]
    public string? RnkKirilim55 { get; set; }

    [Column("rnk_kirilim_56")]
    [StringLength(40)]
    public string? RnkKirilim56 { get; set; }

    [Column("rnk_kirilim_57")]
    [StringLength(40)]
    public string? RnkKirilim57 { get; set; }

    [Column("rnk_kirilim_58")]
    [StringLength(40)]
    public string? RnkKirilim58 { get; set; }

    [Column("rnk_kirilim_59")]
    [StringLength(40)]
    public string? RnkKirilim59 { get; set; }

    [Column("rnk_kirilim_60")]
    [StringLength(40)]
    public string? RnkKirilim60 { get; set; }
}
