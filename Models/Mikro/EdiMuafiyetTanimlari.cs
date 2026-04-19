using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("edi_muafiyet_tanimlari")]
public class EdiMuafiyetTanimlari
{
    [Column("edimuaf_Guid")]
    public Guid? EdimuafGuid { get; set; }

    [Column("edimuaf_DBCno")]
    public short? EdimuafDBCno { get; set; }

    [Column("edimuaf_SpecRECNo")]
    public int? EdimuafSpecRECNo { get; set; }

    [Column("edimuaf_iptal")]
    public bool? EdimuafIptal { get; set; }

    [Column("edimuaf_fileid")]
    public short? EdimuafFileid { get; set; }

    [Column("edimuaf_hidden")]
    public bool? EdimuafHidden { get; set; }

    [Column("edimuaf_kilitli")]
    public bool? EdimuafKilitli { get; set; }

    [Column("edimuaf_degisti")]
    public bool? EdimuafDegisti { get; set; }

    [Column("edimuaf_checksum")]
    public int? EdimuafChecksum { get; set; }

    [Column("edimuaf_create_user")]
    public short? EdimuafCreateUser { get; set; }

    [Column("edimuaf_create_date")]
    public DateTime? EdimuafCreateDate { get; set; }

    [Column("edimuaf_lastup_user")]
    public short? EdimuafLastupUser { get; set; }

    [Column("edimuaf_lastup_date")]
    public DateTime? EdimuafLastupDate { get; set; }

    [Column("edimuaf_special1")]
    [StringLength(4)]
    public string? EdimuafSpecial1 { get; set; }

    [Column("edimuaf_special2")]
    [StringLength(4)]
    public string? EdimuafSpecial2 { get; set; }

    [Column("edimuaf_special3")]
    [StringLength(4)]
    public string? EdimuafSpecial3 { get; set; }

    [Column("edimuaf_kodu")]
    [StringLength(25)]
    public string? EdimuafKodu { get; set; }

    [Column("edimuaf_muafiyet")]
    [StringLength(70)]
    public string? EdimuafMuafiyet { get; set; }
}
