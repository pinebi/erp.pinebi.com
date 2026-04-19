using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kapama_nedenleri_tanimlari")]
public class KapamaNedenleriTanimlari
{
    [Column("Kpm_Guid")]
    public Guid? KpmGuid { get; set; }

    [Column("Kpm_DBCno")]
    public short? KpmDBCno { get; set; }

    [Column("Kpm_SpecRECno")]
    public int? KpmSpecRECno { get; set; }

    [Column("Kpm_iptal")]
    public bool? KpmIptal { get; set; }

    [Column("Kpm_fileid")]
    public short? KpmFileid { get; set; }

    [Column("Kpm_hidden")]
    public bool? KpmHidden { get; set; }

    [Column("Kpm_kilitli")]
    public bool? KpmKilitli { get; set; }

    [Column("Kpm_degisti")]
    public bool? KpmDegisti { get; set; }

    [Column("Kpm_checksum")]
    public int? KpmChecksum { get; set; }

    [Column("Kpm_create_user")]
    public short? KpmCreateUser { get; set; }

    [Column("Kpm_create_date")]
    public DateTime? KpmCreateDate { get; set; }

    [Column("Kpm_lastup_user")]
    public short? KpmLastupUser { get; set; }

    [Column("Kpm_lastup_date")]
    public DateTime? KpmLastupDate { get; set; }

    [Column("Kpm_special1")]
    [StringLength(4)]
    public string? KpmSpecial1 { get; set; }

    [Column("Kpm_special2")]
    [StringLength(4)]
    public string? KpmSpecial2 { get; set; }

    [Column("Kpm_special3")]
    [StringLength(4)]
    public string? KpmSpecial3 { get; set; }

    [Column("Kpm_kod")]
    [StringLength(25)]
    public string? KpmKod { get; set; }

    [Column("Kpm_ismi")]
    [StringLength(50)]
    public string? KpmIsmi { get; set; }

    [Column("Kpm_aciklama")]
    [StringLength(40)]
    public string? KpmAciklama { get; set; }
}
