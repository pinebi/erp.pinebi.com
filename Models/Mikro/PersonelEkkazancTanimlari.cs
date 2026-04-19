using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_ekkazanc_tanimlari")]
public class PersonelEkkazancTanimlari
{
    [Column("PEK_Guid")]
    public Guid? PEKGuid { get; set; }

    [Column("PEK_DBCno")]
    public short? PEKDBCno { get; set; }

    [Column("PEK_SpecRECno")]
    public int? PEKSpecRECno { get; set; }

    [Column("PEK_iptal")]
    public bool? PEKIptal { get; set; }

    [Column("PEK_fileid")]
    public short? PEKFileid { get; set; }

    [Column("PEK_hidden")]
    public bool? PEKHidden { get; set; }

    [Column("PEK_kilitli")]
    public bool? PEKKilitli { get; set; }

    [Column("PEK_degisti")]
    public bool? PEKDegisti { get; set; }

    [Column("PEK_checksum")]
    public int? PEKChecksum { get; set; }

    [Column("PEK_create_user")]
    public short? PEKCreateUser { get; set; }

    [Column("PEK_create_date")]
    public DateTime? PEKCreateDate { get; set; }

    [Column("PEK_lastup_user")]
    public short? PEKLastupUser { get; set; }

    [Column("PEK_lastup_date")]
    public DateTime? PEKLastupDate { get; set; }

    [Column("PEK_special1")]
    [StringLength(4)]
    public string? PEKSpecial1 { get; set; }

    [Column("PEK_special2")]
    [StringLength(4)]
    public string? PEKSpecial2 { get; set; }

    [Column("PEK_special3")]
    [StringLength(4)]
    public string? PEKSpecial3 { get; set; }

    [Column("PEK_Kodu")]
    [StringLength(25)]
    public string? PEKKodu { get; set; }

    [Column("PEK_SiraNo")]
    public short? PEKSiraNo { get; set; }

    [Column("PEK_Carpan")]
    public double? PEKCarpan { get; set; }

    [Column("PEK_Sabit")]
    public double? PEKSabit { get; set; }

    [Column("PEK_Ssk")]
    public byte? PEKSsk { get; set; }

    [Column("PEK_Gv")]
    public byte? PEKGv { get; set; }

    [Column("PEK_Gv_Muaf")]
    public double? PEKGvMuaf { get; set; }

    [Column("PEK_Ssk_Muaf")]
    public double? PEKSskMuaf { get; set; }

    [Column("PEK_SabitUcret")]
    public double? PEKSabitUcret { get; set; }

    [Column("PEK_SabitUcretIsleyisi")]
    public byte? PEKSabitUcretIsleyisi { get; set; }

    [Column("PEK_CarpanBolenIliskisi")]
    public byte? PEKCarpanBolenIliskisi { get; set; }

    [Column("PEK_yardimekle_1")]
    public bool? PEKYardimekle1 { get; set; }

    [Column("PEK_yardimekle_2")]
    public bool? PEKYardimekle2 { get; set; }

    [Column("PEK_yardimekle_3")]
    public bool? PEKYardimekle3 { get; set; }

    [Column("PEK_yardimekle_4")]
    public bool? PEKYardimekle4 { get; set; }

    [Column("PEK_yardimekle_5")]
    public bool? PEKYardimekle5 { get; set; }

    [Column("PEK_yardimekle_6")]
    public bool? PEKYardimekle6 { get; set; }

    [Column("PEK_yardimekle_7")]
    public bool? PEKYardimekle7 { get; set; }

    [Column("PEK_yardimekle_8")]
    public bool? PEKYardimekle8 { get; set; }

    [Column("PEK_yardimekle_9")]
    public bool? PEKYardimekle9 { get; set; }

    [Column("PEK_yardimekle_10")]
    public bool? PEKYardimekle10 { get; set; }

    [Column("PEK_yardimekle_11")]
    public bool? PEKYardimekle11 { get; set; }

    [Column("PEK_yardimekle_12")]
    public bool? PEKYardimekle12 { get; set; }

    [Column("PEK_yardimekle_13")]
    public bool? PEKYardimekle13 { get; set; }

    [Column("PEK_yardimekle_14")]
    public bool? PEKYardimekle14 { get; set; }

    [Column("PEK_yardimekle_15")]
    public bool? PEKYardimekle15 { get; set; }

    [Column("PEK_yardimekle_16")]
    public bool? PEKYardimekle16 { get; set; }

    [Column("PEK_yardimekle_17")]
    public bool? PEKYardimekle17 { get; set; }

    [Column("PEK_yardimekle_18")]
    public bool? PEKYardimekle18 { get; set; }

    [Column("PEK_yardimekle_19")]
    public bool? PEKYardimekle19 { get; set; }

    [Column("PEK_yardimekle_20")]
    public bool? PEKYardimekle20 { get; set; }

    [Column("PEK_yardimekle_21")]
    public bool? PEKYardimekle21 { get; set; }

    [Column("PEK_yardimekle_22")]
    public bool? PEKYardimekle22 { get; set; }

    [Column("PEK_yardimekle_23")]
    public bool? PEKYardimekle23 { get; set; }

    [Column("PEK_yardimekle_24")]
    public bool? PEKYardimekle24 { get; set; }

    [Column("PEK_yardimekle_25")]
    public bool? PEKYardimekle25 { get; set; }

    [Column("PEK_yardimekle_26")]
    public bool? PEKYardimekle26 { get; set; }

    [Column("PEK_yardimekle_27")]
    public bool? PEKYardimekle27 { get; set; }

    [Column("PEK_yardimekle_28")]
    public bool? PEKYardimekle28 { get; set; }

    [Column("PEK_yardimekle_29")]
    public bool? PEKYardimekle29 { get; set; }

    [Column("PEK_yardimekle_30")]
    public bool? PEKYardimekle30 { get; set; }

    [Column("PEK_yardimekle_31")]
    public bool? PEKYardimekle31 { get; set; }

    [Column("PEK_yardimekle_32")]
    public bool? PEKYardimekle32 { get; set; }

    [Column("PEK_Dv")]
    public byte? PEKDv { get; set; }

    [Column("PEK_Dv_Muaf")]
    public double? PEKDvMuaf { get; set; }
}
