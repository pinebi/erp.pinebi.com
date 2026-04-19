using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_fis_grubu_tanimlari")]
public class MuhasebeFisGrubuTanimlari
{
    [Column("mfg_Guid")]
    public Guid? MfgGuid { get; set; }

    [Column("mfg_DBCno")]
    public short? MfgDBCno { get; set; }

    [Column("mfg_SpecRECno")]
    public int? MfgSpecRECno { get; set; }

    [Column("mfg_iptal")]
    public bool? MfgIptal { get; set; }

    [Column("mfg_fileid")]
    public short? MfgFileid { get; set; }

    [Column("mfg_hidden")]
    public bool? MfgHidden { get; set; }

    [Column("mfg_kilitli")]
    public bool? MfgKilitli { get; set; }

    [Column("mfg_degisti")]
    public bool? MfgDegisti { get; set; }

    [Column("mfg_checksum")]
    public int? MfgChecksum { get; set; }

    [Column("mfg_create_user")]
    public short? MfgCreateUser { get; set; }

    [Column("mfg_create_date")]
    public DateTime? MfgCreateDate { get; set; }

    [Column("mfg_lastup_user")]
    public short? MfgLastupUser { get; set; }

    [Column("mfg_lastup_date")]
    public DateTime? MfgLastupDate { get; set; }

    [Column("mfg_special1")]
    [StringLength(4)]
    public string? MfgSpecial1 { get; set; }

    [Column("mfg_special2")]
    [StringLength(4)]
    public string? MfgSpecial2 { get; set; }

    [Column("mfg_special3")]
    [StringLength(4)]
    public string? MfgSpecial3 { get; set; }

    [Column("mfg_kodu")]
    [StringLength(4)]
    public string? MfgKodu { get; set; }

    [Column("mfg_aciklama")]
    [StringLength(30)]
    public string? MfgAciklama { get; set; }
}
