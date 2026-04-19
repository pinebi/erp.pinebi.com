using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ozel_matrah_tanimlari")]
public class OzelMatrahTanimlari
{
    [Column("ozm_Guid")]
    public Guid? OzmGuid { get; set; }

    [Column("ozm_DBCno")]
    public short? OzmDBCno { get; set; }

    [Column("ozm_SpecRECno")]
    public int? OzmSpecRECno { get; set; }

    [Column("ozm_iptal")]
    public bool? OzmIptal { get; set; }

    [Column("ozm_fileid")]
    public short? OzmFileid { get; set; }

    [Column("ozm_hidden")]
    public bool? OzmHidden { get; set; }

    [Column("ozm_kilitli")]
    public bool? OzmKilitli { get; set; }

    [Column("ozm_degisti")]
    public bool? OzmDegisti { get; set; }

    [Column("ozm_checksum")]
    public int? OzmChecksum { get; set; }

    [Column("ozm_create_user")]
    public short? OzmCreateUser { get; set; }

    [Column("ozm_create_date")]
    public DateTime? OzmCreateDate { get; set; }

    [Column("ozm_lastup_user")]
    public short? OzmLastupUser { get; set; }

    [Column("ozm_lastup_date")]
    public DateTime? OzmLastupDate { get; set; }

    [Column("ozm_special1")]
    [StringLength(4)]
    public string? OzmSpecial1 { get; set; }

    [Column("ozm_special2")]
    [StringLength(4)]
    public string? OzmSpecial2 { get; set; }

    [Column("ozm_special3")]
    [StringLength(4)]
    public string? OzmSpecial3 { get; set; }

    [Column("ozm_kod")]
    [StringLength(5)]
    public string? OzmKod { get; set; }

    [Column("ozm_aciklama")]
    [StringLength(127)]
    public string? OzmAciklama { get; set; }
}
