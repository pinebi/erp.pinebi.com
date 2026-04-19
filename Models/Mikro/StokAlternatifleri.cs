using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_alternatifleri")]
public class StokAlternatifleri
{
    [Column("sa_Guid")]
    public Guid? SaGuid { get; set; }

    [Column("sa_DBCno")]
    public short? SaDBCno { get; set; }

    [Column("sa_SpecRECno")]
    public int? SaSpecRECno { get; set; }

    [Column("sa_iptal")]
    public bool? SaIptal { get; set; }

    [Column("sa_fileid")]
    public short? SaFileid { get; set; }

    [Column("sa_hidden")]
    public bool? SaHidden { get; set; }

    [Column("sa_kilitli")]
    public bool? SaKilitli { get; set; }

    [Column("sa_degisti")]
    public bool? SaDegisti { get; set; }

    [Column("sa_checksum")]
    public int? SaChecksum { get; set; }

    [Column("sa_create_user")]
    public short? SaCreateUser { get; set; }

    [Column("sa_create_date")]
    public DateTime? SaCreateDate { get; set; }

    [Column("sa_lastup_user")]
    public short? SaLastupUser { get; set; }

    [Column("sa_lastup_date")]
    public DateTime? SaLastupDate { get; set; }

    [Column("sa_special1")]
    [StringLength(4)]
    public string? SaSpecial1 { get; set; }

    [Column("sa_special2")]
    [StringLength(4)]
    public string? SaSpecial2 { get; set; }

    [Column("sa_special3")]
    [StringLength(4)]
    public string? SaSpecial3 { get; set; }

    [Column("sa_kod")]
    [StringLength(25)]
    public string? SaKod { get; set; }

    [Column("sa_alternatifkod")]
    [StringLength(25)]
    public string? SaAlternatifkod { get; set; }
}
