using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_beden_tanimlari")]
public class StokBedenTanimlari
{
    [Column("bdn_Guid")]
    public Guid? BdnGuid { get; set; }

    [Column("bdn_DBCno")]
    public short? BdnDBCno { get; set; }

    [Column("bdn_SpecRECno")]
    public int? BdnSpecRECno { get; set; }

    [Column("bdn_iptal")]
    public bool? BdnIptal { get; set; }

    [Column("bdn_fileid")]
    public short? BdnFileid { get; set; }

    [Column("bdn_hidden")]
    public bool? BdnHidden { get; set; }

    [Column("bdn_kilitli")]
    public bool? BdnKilitli { get; set; }

    [Column("bdn_degisti")]
    public bool? BdnDegisti { get; set; }

    [Column("bdn_checksum")]
    public int? BdnChecksum { get; set; }

    [Column("bdn_create_user")]
    public short? BdnCreateUser { get; set; }

    [Column("bdn_create_date")]
    public DateTime? BdnCreateDate { get; set; }

    [Column("bdn_lastup_user")]
    public short? BdnLastupUser { get; set; }

    [Column("bdn_lastup_date")]
    public DateTime? BdnLastupDate { get; set; }

    [Column("bdn_special1")]
    [StringLength(4)]
    public string? BdnSpecial1 { get; set; }

    [Column("bdn_special2")]
    [StringLength(4)]
    public string? BdnSpecial2 { get; set; }

    [Column("bdn_special3")]
    [StringLength(4)]
    public string? BdnSpecial3 { get; set; }

    [Column("bdn_kodu")]
    [StringLength(25)]
    public string? BdnKodu { get; set; }

    [Column("bdn_ismi")]
    [StringLength(40)]
    public string? BdnIsmi { get; set; }

    [Column("bdn_kirilim_1")]
    [StringLength(10)]
    public string? BdnKirilim1 { get; set; }

    [Column("bdn_kirilim_2")]
    [StringLength(10)]
    public string? BdnKirilim2 { get; set; }

    [Column("bdn_kirilim_3")]
    [StringLength(10)]
    public string? BdnKirilim3 { get; set; }

    [Column("bdn_kirilim_4")]
    [StringLength(10)]
    public string? BdnKirilim4 { get; set; }

    [Column("bdn_kirilim_5")]
    [StringLength(10)]
    public string? BdnKirilim5 { get; set; }

    [Column("bdn_kirilim_6")]
    [StringLength(10)]
    public string? BdnKirilim6 { get; set; }

    [Column("bdn_kirilim_7")]
    [StringLength(10)]
    public string? BdnKirilim7 { get; set; }

    [Column("bdn_kirilim_8")]
    [StringLength(10)]
    public string? BdnKirilim8 { get; set; }

    [Column("bdn_kirilim_9")]
    [StringLength(10)]
    public string? BdnKirilim9 { get; set; }

    [Column("bdn_kirilim_10")]
    [StringLength(10)]
    public string? BdnKirilim10 { get; set; }

    [Column("bdn_kirilim_11")]
    [StringLength(10)]
    public string? BdnKirilim11 { get; set; }

    [Column("bdn_kirilim_12")]
    [StringLength(10)]
    public string? BdnKirilim12 { get; set; }

    [Column("bdn_kirilim_13")]
    [StringLength(10)]
    public string? BdnKirilim13 { get; set; }

    [Column("bdn_kirilim_14")]
    [StringLength(10)]
    public string? BdnKirilim14 { get; set; }

    [Column("bdn_kirilim_15")]
    [StringLength(10)]
    public string? BdnKirilim15 { get; set; }

    [Column("bdn_kirilim_16")]
    [StringLength(10)]
    public string? BdnKirilim16 { get; set; }

    [Column("bdn_kirilim_17")]
    [StringLength(10)]
    public string? BdnKirilim17 { get; set; }

    [Column("bdn_kirilim_18")]
    [StringLength(10)]
    public string? BdnKirilim18 { get; set; }

    [Column("bdn_kirilim_19")]
    [StringLength(10)]
    public string? BdnKirilim19 { get; set; }

    [Column("bdn_kirilim_20")]
    [StringLength(10)]
    public string? BdnKirilim20 { get; set; }

    [Column("bdn_kirilim_21")]
    [StringLength(10)]
    public string? BdnKirilim21 { get; set; }

    [Column("bdn_kirilim_22")]
    [StringLength(10)]
    public string? BdnKirilim22 { get; set; }

    [Column("bdn_kirilim_23")]
    [StringLength(10)]
    public string? BdnKirilim23 { get; set; }

    [Column("bdn_kirilim_24")]
    [StringLength(10)]
    public string? BdnKirilim24 { get; set; }

    [Column("bdn_kirilim_25")]
    [StringLength(10)]
    public string? BdnKirilim25 { get; set; }

    [Column("bdn_kirilim_26")]
    [StringLength(10)]
    public string? BdnKirilim26 { get; set; }

    [Column("bdn_kirilim_27")]
    [StringLength(10)]
    public string? BdnKirilim27 { get; set; }

    [Column("bdn_kirilim_28")]
    [StringLength(10)]
    public string? BdnKirilim28 { get; set; }

    [Column("bdn_kirilim_29")]
    [StringLength(10)]
    public string? BdnKirilim29 { get; set; }

    [Column("bdn_kirilim_30")]
    [StringLength(10)]
    public string? BdnKirilim30 { get; set; }

    [Column("bdn_kirilim_31")]
    [StringLength(10)]
    public string? BdnKirilim31 { get; set; }

    [Column("bdn_kirilim_32")]
    [StringLength(10)]
    public string? BdnKirilim32 { get; set; }

    [Column("bdn_kirilim_33")]
    [StringLength(10)]
    public string? BdnKirilim33 { get; set; }

    [Column("bdn_kirilim_34")]
    [StringLength(10)]
    public string? BdnKirilim34 { get; set; }

    [Column("bdn_kirilim_35")]
    [StringLength(10)]
    public string? BdnKirilim35 { get; set; }

    [Column("bdn_kirilim_36")]
    [StringLength(10)]
    public string? BdnKirilim36 { get; set; }

    [Column("bdn_kirilim_37")]
    [StringLength(10)]
    public string? BdnKirilim37 { get; set; }

    [Column("bdn_kirilim_38")]
    [StringLength(10)]
    public string? BdnKirilim38 { get; set; }

    [Column("bdn_kirilim_39")]
    [StringLength(10)]
    public string? BdnKirilim39 { get; set; }

    [Column("bdn_kirilim_40")]
    [StringLength(10)]
    public string? BdnKirilim40 { get; set; }
}
