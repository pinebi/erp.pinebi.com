using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("egitim_grup_tanimlari")]
public class EgitimGrupTanimlari
{
    [Column("egr_Guid")]
    public Guid? EgrGuid { get; set; }

    [Column("egr_DBCno")]
    public short? EgrDBCno { get; set; }

    [Column("egr_SpecRECno")]
    public int? EgrSpecRECno { get; set; }

    [Column("egr_iptal")]
    public bool? EgrIptal { get; set; }

    [Column("egr_fileid")]
    public short? EgrFileid { get; set; }

    [Column("egr_hidden")]
    public bool? EgrHidden { get; set; }

    [Column("egr_kilitli")]
    public bool? EgrKilitli { get; set; }

    [Column("egr_degisti")]
    public bool? EgrDegisti { get; set; }

    [Column("egr_checksum")]
    public int? EgrChecksum { get; set; }

    [Column("egr_create_user")]
    public short? EgrCreateUser { get; set; }

    [Column("egr_create_date")]
    public DateTime? EgrCreateDate { get; set; }

    [Column("egr_lastup_user")]
    public short? EgrLastupUser { get; set; }

    [Column("egr_lastup_date")]
    public DateTime? EgrLastupDate { get; set; }

    [Column("egr_special1")]
    [StringLength(4)]
    public string? EgrSpecial1 { get; set; }

    [Column("egr_special2")]
    [StringLength(4)]
    public string? EgrSpecial2 { get; set; }

    [Column("egr_special3")]
    [StringLength(4)]
    public string? EgrSpecial3 { get; set; }

    [Column("egr_firmano")]
    public int? EgrFirmano { get; set; }

    [Column("egr_subeno")]
    public int? EgrSubeno { get; set; }

    [Column("egr_kod")]
    [StringLength(25)]
    public string? EgrKod { get; set; }

    [Column("egr_adi")]
    [StringLength(40)]
    public string? EgrAdi { get; set; }

    [Column("egr_tip_kodu")]
    [StringLength(25)]
    public string? EgrTipKodu { get; set; }

    [Column("egr_egitim_kodu")]
    [StringLength(25)]
    public string? EgrEgitimKodu { get; set; }

    [Column("egr_alt_grup_kodu")]
    [StringLength(25)]
    public string? EgrAltGrupKodu { get; set; }
}
