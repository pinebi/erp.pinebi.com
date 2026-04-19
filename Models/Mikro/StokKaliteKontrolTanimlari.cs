using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_kalite_kontrol_tanimlari")]
public class StokKaliteKontrolTanimlari
{
    [Column("KKon_Guid")]
    public Guid? KKonGuid { get; set; }

    [Column("KKon_DBCno")]
    public short? KKonDBCno { get; set; }

    [Column("KKon_SpecRecno")]
    public int? KKonSpecRecno { get; set; }

    [Column("KKon_iptal")]
    public bool? KKonIptal { get; set; }

    [Column("KKon_fileid")]
    public short? KKonFileid { get; set; }

    [Column("KKon_hidden")]
    public bool? KKonHidden { get; set; }

    [Column("KKon_kilitli")]
    public bool? KKonKilitli { get; set; }

    [Column("KKon_degisti")]
    public bool? KKonDegisti { get; set; }

    [Column("KKon_checksum")]
    public int? KKonChecksum { get; set; }

    [Column("KKon_create_user")]
    public short? KKonCreateUser { get; set; }

    [Column("KKon_create_date")]
    public DateTime? KKonCreateDate { get; set; }

    [Column("KKon_lastup_user")]
    public short? KKonLastupUser { get; set; }

    [Column("KKon_lastup_date")]
    public DateTime? KKonLastupDate { get; set; }

    [Column("KKon_special1")]
    [StringLength(4)]
    public string? KKonSpecial1 { get; set; }

    [Column("KKon_special2")]
    [StringLength(4)]
    public string? KKonSpecial2 { get; set; }

    [Column("KKon_special3")]
    [StringLength(4)]
    public string? KKonSpecial3 { get; set; }

    [Column("KKon_kod")]
    [StringLength(25)]
    public string? KKonKod { get; set; }

    [Column("KKon_ismi")]
    [StringLength(40)]
    public string? KKonIsmi { get; set; }
}
