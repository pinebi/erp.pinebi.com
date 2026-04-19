using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_gorev_tanimlari")]
public class PersonelGorevTanimlari
{
    [Column("pgk_Guid")]
    public Guid? PgkGuid { get; set; }

    [Column("pgk_DBCno")]
    public short? PgkDBCno { get; set; }

    [Column("pgk_SpecRECno")]
    public int? PgkSpecRECno { get; set; }

    [Column("pgk_iptal")]
    public bool? PgkIptal { get; set; }

    [Column("pgk_fileid")]
    public short? PgkFileid { get; set; }

    [Column("pgk_hidden")]
    public bool? PgkHidden { get; set; }

    [Column("pgk_kilitli")]
    public bool? PgkKilitli { get; set; }

    [Column("pgk_degisti")]
    public bool? PgkDegisti { get; set; }

    [Column("pgk_checksum")]
    public int? PgkChecksum { get; set; }

    [Column("pgk_create_user")]
    public short? PgkCreateUser { get; set; }

    [Column("pgk_create_date")]
    public DateTime? PgkCreateDate { get; set; }

    [Column("pgk_lastup_user")]
    public short? PgkLastupUser { get; set; }

    [Column("pgk_lastup_date")]
    public DateTime? PgkLastupDate { get; set; }

    [Column("pgk_special1")]
    [StringLength(4)]
    public string? PgkSpecial1 { get; set; }

    [Column("pgk_special2")]
    [StringLength(4)]
    public string? PgkSpecial2 { get; set; }

    [Column("pgk_special3")]
    [StringLength(4)]
    public string? PgkSpecial3 { get; set; }

    [Column("pgk_gorev_kodu")]
    [StringLength(25)]
    public string? PgkGorevKodu { get; set; }

    [Column("pgk_gorev_adi")]
    [StringLength(50)]
    public string? PgkGorevAdi { get; set; }
}
