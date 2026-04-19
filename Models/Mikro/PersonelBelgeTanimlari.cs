using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_belge_tanimlari")]
public class PersonelBelgeTanimlari
{
    [Column("bel_Guid")]
    public Guid? BelGuid { get; set; }

    [Column("bel_DBCno")]
    public short? BelDBCno { get; set; }

    [Column("bel_SpecRECno")]
    public int? BelSpecRECno { get; set; }

    [Column("bel_iptal")]
    public bool? BelIptal { get; set; }

    [Column("bel_fileid")]
    public short? BelFileid { get; set; }

    [Column("bel_hidden")]
    public bool? BelHidden { get; set; }

    [Column("bel_kilitli")]
    public bool? BelKilitli { get; set; }

    [Column("bel_degisti")]
    public bool? BelDegisti { get; set; }

    [Column("bel_checksum")]
    public int? BelChecksum { get; set; }

    [Column("bel_create_user")]
    public short? BelCreateUser { get; set; }

    [Column("bel_create_date")]
    public DateTime? BelCreateDate { get; set; }

    [Column("bel_lastup_user")]
    public short? BelLastupUser { get; set; }

    [Column("bel_lastup_date")]
    public DateTime? BelLastupDate { get; set; }

    [Column("bel_special1")]
    [StringLength(4)]
    public string? BelSpecial1 { get; set; }

    [Column("bel_special2")]
    [StringLength(4)]
    public string? BelSpecial2 { get; set; }

    [Column("bel_special3")]
    [StringLength(4)]
    public string? BelSpecial3 { get; set; }

    [Column("bel_kod")]
    [StringLength(25)]
    public string? BelKod { get; set; }

    [Column("bel_isim")]
    [StringLength(40)]
    public string? BelIsim { get; set; }
}
