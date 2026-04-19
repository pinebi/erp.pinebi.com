using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kisa_mesaj_sablonlari")]
public class KisaMesajSablonlari
{
    [Column("sbl_Guid")]
    public Guid? SblGuid { get; set; }

    [Column("sbl_DBCno")]
    public short? SblDBCno { get; set; }

    [Column("sbl_SpecRECno")]
    public int? SblSpecRECno { get; set; }

    [Column("sbl_iptal")]
    public bool? SblIptal { get; set; }

    [Column("sbl_fileid")]
    public short? SblFileid { get; set; }

    [Column("sbl_hidden")]
    public bool? SblHidden { get; set; }

    [Column("sbl_kilitli")]
    public bool? SblKilitli { get; set; }

    [Column("sbl_degisti")]
    public bool? SblDegisti { get; set; }

    [Column("sbl_checksum")]
    public int? SblChecksum { get; set; }

    [Column("sbl_create_user")]
    public short? SblCreateUser { get; set; }

    [Column("sbl_create_date")]
    public DateTime? SblCreateDate { get; set; }

    [Column("sbl_lastup_user")]
    public short? SblLastupUser { get; set; }

    [Column("sbl_lastup_date")]
    public DateTime? SblLastupDate { get; set; }

    [Column("sbl_special1")]
    [StringLength(4)]
    public string? SblSpecial1 { get; set; }

    [Column("sbl_special2")]
    [StringLength(4)]
    public string? SblSpecial2 { get; set; }

    [Column("sbl_special3")]
    [StringLength(4)]
    public string? SblSpecial3 { get; set; }

    [Column("sbl_kodu")]
    [StringLength(25)]
    public string? SblKodu { get; set; }

    [Column("sbl_adi")]
    [StringLength(40)]
    public string? SblAdi { get; set; }

    [Column("sbl_metni")]
    [StringLength(80)]
    public string? SblMetni { get; set; }

    [Column("sbl_functipi1")]
    public byte? SblFunctipi1 { get; set; }

    [Column("sbl_functipi2")]
    public byte? SblFunctipi2 { get; set; }

    [Column("sbl_functipi3")]
    public byte? SblFunctipi3 { get; set; }

    [Column("sbl_functipi4")]
    public byte? SblFunctipi4 { get; set; }

    [Column("sbl_functipi5")]
    public byte? SblFunctipi5 { get; set; }

    [Column("sbl_functipi6")]
    public byte? SblFunctipi6 { get; set; }

    [Column("sbl_functipi7")]
    public byte? SblFunctipi7 { get; set; }

    [Column("sbl_functipi8")]
    public byte? SblFunctipi8 { get; set; }

    [Column("sbl_functipi9")]
    public byte? SblFunctipi9 { get; set; }

    [Column("sbl_functipi10")]
    public byte? SblFunctipi10 { get; set; }
}
