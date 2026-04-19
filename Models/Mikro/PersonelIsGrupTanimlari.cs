using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_is_grup_tanimlari")]
public class PersonelIsGrupTanimlari
{
    [Column("ig_Guid")]
    public Guid? IgGuid { get; set; }

    [Column("ig_DBCno")]
    public short? IgDBCno { get; set; }

    [Column("ig_SpecRECno")]
    public int? IgSpecRECno { get; set; }

    [Column("ig_iptal")]
    public bool? IgIptal { get; set; }

    [Column("ig_fileid")]
    public short? IgFileid { get; set; }

    [Column("ig_hidden")]
    public bool? IgHidden { get; set; }

    [Column("ig_kilitli")]
    public bool? IgKilitli { get; set; }

    [Column("ig_degisti")]
    public bool? IgDegisti { get; set; }

    [Column("ig_checksum")]
    public int? IgChecksum { get; set; }

    [Column("ig_create_user")]
    public short? IgCreateUser { get; set; }

    [Column("ig_create_date")]
    public DateTime? IgCreateDate { get; set; }

    [Column("ig_lastup_user")]
    public short? IgLastupUser { get; set; }

    [Column("ig_lastup_date")]
    public DateTime? IgLastupDate { get; set; }

    [Column("ig_special1")]
    [StringLength(4)]
    public string? IgSpecial1 { get; set; }

    [Column("ig_special2")]
    [StringLength(4)]
    public string? IgSpecial2 { get; set; }

    [Column("ig_special3")]
    [StringLength(4)]
    public string? IgSpecial3 { get; set; }

    [Column("ig_kod")]
    [StringLength(25)]
    public string? IgKod { get; set; }

    [Column("ig_adi")]
    [StringLength(40)]
    public string? IgAdi { get; set; }
}
