using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sosyalyardim_tanimlari")]
public class PersonelSosyalyardimTanimlari
{
    [Column("PSY_Guid")]
    public Guid? PSYGuid { get; set; }

    [Column("PSY_DBCno")]
    public short? PSYDBCno { get; set; }

    [Column("PSY_SpecRECno")]
    public int? PSYSpecRECno { get; set; }

    [Column("PSY_iptal")]
    public bool? PSYIptal { get; set; }

    [Column("PSY_fileid")]
    public short? PSYFileid { get; set; }

    [Column("PSY_hidden")]
    public bool? PSYHidden { get; set; }

    [Column("PSY_kilitli")]
    public bool? PSYKilitli { get; set; }

    [Column("PSY_degisti")]
    public bool? PSYDegisti { get; set; }

    [Column("PSY_checksum")]
    public int? PSYChecksum { get; set; }

    [Column("PSY_create_user")]
    public short? PSYCreateUser { get; set; }

    [Column("PSY_create_date")]
    public DateTime? PSYCreateDate { get; set; }

    [Column("PSY_lastup_user")]
    public short? PSYLastupUser { get; set; }

    [Column("PSY_lastup_date")]
    public DateTime? PSYLastupDate { get; set; }

    [Column("PSY_special1")]
    [StringLength(4)]
    public string? PSYSpecial1 { get; set; }

    [Column("PSY_special2")]
    [StringLength(4)]
    public string? PSYSpecial2 { get; set; }

    [Column("PSY_special3")]
    [StringLength(4)]
    public string? PSYSpecial3 { get; set; }

    [Column("PSY_Kodu")]
    [StringLength(25)]
    public string? PSYKodu { get; set; }

    [Column("PSY_SiraNo")]
    public short? PSYSiraNo { get; set; }

    [Column("PSY_Tutar1")]
    public double? PSYTutar1 { get; set; }

    [Column("PSY_Tutar2")]
    public double? PSYTutar2 { get; set; }

    [Column("PSY_Tutar3")]
    public double? PSYTutar3 { get; set; }

    [Column("PSY_Tutar4")]
    public double? PSYTutar4 { get; set; }

    [Column("PSY_Tutar5")]
    public double? PSYTutar5 { get; set; }

    [Column("PSY_Tutar6")]
    public double? PSYTutar6 { get; set; }

    [Column("PSY_Tutar7")]
    public double? PSYTutar7 { get; set; }

    [Column("PSY_Tutar8")]
    public double? PSYTutar8 { get; set; }

    [Column("PSY_Tahno")]
    public byte? PSYTahno { get; set; }

    [Column("PSY_GunAy")]
    [StringLength(1)]
    public string? PSYGunAy { get; set; }

    [Column("PSY_BrutNet")]
    public byte? PSYBrutNet { get; set; }

    [Column("PSY_Ssk")]
    public byte? PSYSsk { get; set; }

    [Column("PSY_Gv")]
    public byte? PSYGv { get; set; }

    [Column("PSY_Dv")]
    public byte? PSYDv { get; set; }

    [Column("PSY_Gv_Muaf")]
    public double? PSYGvMuaf { get; set; }

    [Column("PSY_Ssk_Muaf")]
    public double? PSYSskMuaf { get; set; }

    [Column("PSY_Dv_Muaf")]
    public double? PSYDvMuaf { get; set; }

    [Column("PSY_kazancgunhesaplansin1")]
    public byte? PSYKazancgunhesaplansin1 { get; set; }

    [Column("PSY_kazancgunhesaplansin2")]
    public byte? PSYKazancgunhesaplansin2 { get; set; }

    [Column("PSY_kazancgunhesaplansin3")]
    public byte? PSYKazancgunhesaplansin3 { get; set; }

    [Column("PSY_kazancgunhesaplansin4")]
    public byte? PSYKazancgunhesaplansin4 { get; set; }

    [Column("PSY_kazancgunhesaplansin5")]
    public byte? PSYKazancgunhesaplansin5 { get; set; }

    [Column("PSY_kazancgunhesaplansin6")]
    public byte? PSYKazancgunhesaplansin6 { get; set; }
}
