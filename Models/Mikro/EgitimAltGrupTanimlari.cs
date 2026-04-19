using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("egitim_alt_grup_tanimlari")]
public class EgitimAltGrupTanimlari
{
    [Column("eag_Guid")]
    public Guid? EagGuid { get; set; }

    [Column("eag__DBCno")]
    public short? EagDBCno { get; set; }

    [Column("eag_SpecRECno")]
    public int? EagSpecRECno { get; set; }

    [Column("eag_iptal")]
    public bool? EagIptal { get; set; }

    [Column("eag_fileid")]
    public short? EagFileid { get; set; }

    [Column("eag_hidden")]
    public bool? EagHidden { get; set; }

    [Column("eag_kilitli")]
    public bool? EagKilitli { get; set; }

    [Column("eag_degisti")]
    public bool? EagDegisti { get; set; }

    [Column("eag_checksum")]
    public int? EagChecksum { get; set; }

    [Column("eag_create_user")]
    public short? EagCreateUser { get; set; }

    [Column("eag_create_date")]
    public DateTime? EagCreateDate { get; set; }

    [Column("eag_lastup_user")]
    public short? EagLastupUser { get; set; }

    [Column("eag_lastup_date")]
    public DateTime? EagLastupDate { get; set; }

    [Column("eag_special1")]
    [StringLength(4)]
    public string? EagSpecial1 { get; set; }

    [Column("eag_special2")]
    [StringLength(4)]
    public string? EagSpecial2 { get; set; }

    [Column("eag_special3")]
    [StringLength(4)]
    public string? EagSpecial3 { get; set; }

    [Column("eag_firmano")]
    public int? EagFirmano { get; set; }

    [Column("eag_subeno")]
    public int? EagSubeno { get; set; }

    [Column("eag_kod")]
    [StringLength(25)]
    public string? EagKod { get; set; }

    [Column("eag_adi")]
    [StringLength(40)]
    public string? EagAdi { get; set; }

    [Column("eag_egitim_kodu")]
    [StringLength(25)]
    public string? EagEgitimKodu { get; set; }
}
