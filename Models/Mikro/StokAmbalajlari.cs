using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_ambalajlari")]
public class StokAmbalajlari
{
    [Column("amb_Guid")]
    public Guid AmbGuid { get; set; }

    [Column("amb_DBCno")]
    public short? AmbDBCno { get; set; }

    [Column("amb_SpecRECno")]
    public int? AmbSpecRECno { get; set; }

    [Column("amb_iptal")]
    public bool? AmbIptal { get; set; }

    [Column("amb_fileid")]
    public short? AmbFileid { get; set; }

    [Column("amb_hidden")]
    public bool? AmbHidden { get; set; }

    [Column("amb_kilitli")]
    public bool? AmbKilitli { get; set; }

    [Column("amb_degisti")]
    public bool? AmbDegisti { get; set; }

    [Column("amb_checksum")]
    public int? AmbChecksum { get; set; }

    [Column("amb_create_user")]
    public short? AmbCreateUser { get; set; }

    [Column("amb_create_date")]
    public DateTime? AmbCreateDate { get; set; }

    [Column("amb_lastup_user")]
    public short? AmbLastupUser { get; set; }

    [Column("amb_lastup_date")]
    public DateTime? AmbLastupDate { get; set; }

    [Column("amb_special1")]
    [StringLength(4)]
    public string? AmbSpecial1 { get; set; }

    [Column("amb_special2")]
    [StringLength(4)]
    public string? AmbSpecial2 { get; set; }

    [Column("amb_special3")]
    [StringLength(4)]
    public string? AmbSpecial3 { get; set; }

    [Column("amb_kod")]
    [StringLength(25)]
    public string? AmbKod { get; set; }

    [Column("amb_ismi")]
    [StringLength(40)]
    public string? AmbIsmi { get; set; }

    [Column("amb_miktar")]
    public double? AmbMiktar { get; set; }

    [Column("amb_dara")]
    public double? AmbDara { get; set; }
}
