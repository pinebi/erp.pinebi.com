using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("okul_bolum_tanimlari")]
public class OkulBolumTanimlari
{
    [Column("obt_Guid")]
    public Guid? ObtGuid { get; set; }

    [Column("obt_DBCno")]
    public short? ObtDBCno { get; set; }

    [Column("obt_SpecRECno")]
    public int? ObtSpecRECno { get; set; }

    [Column("obt_iptal")]
    public bool? ObtIptal { get; set; }

    [Column("obt_fileid")]
    public short? ObtFileid { get; set; }

    [Column("obt_hidden")]
    public bool? ObtHidden { get; set; }

    [Column("obt_kilitli")]
    public bool? ObtKilitli { get; set; }

    [Column("obt_degisti")]
    public bool? ObtDegisti { get; set; }

    [Column("obt_checksum")]
    public int? ObtChecksum { get; set; }

    [Column("obt_create_user")]
    public short? ObtCreateUser { get; set; }

    [Column("obt_create_date")]
    public DateTime? ObtCreateDate { get; set; }

    [Column("obt_lastup_user")]
    public short? ObtLastupUser { get; set; }

    [Column("obt_lastup_date")]
    public DateTime? ObtLastupDate { get; set; }

    [Column("obt_special1")]
    [StringLength(4)]
    public string? ObtSpecial1 { get; set; }

    [Column("obt_special2")]
    [StringLength(4)]
    public string? ObtSpecial2 { get; set; }

    [Column("obt_special3")]
    [StringLength(4)]
    public string? ObtSpecial3 { get; set; }

    [Column("obt_kod")]
    [StringLength(25)]
    public string? ObtKod { get; set; }

    [Column("obt_adi")]
    [StringLength(40)]
    public string? ObtAdi { get; set; }
}
