using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("faydali_omur_kodlari")]
public class FaydaliOmurKodlari
{
    [Column("FayOmur_Guid")]
    public Guid? FayOmurGuid { get; set; }

    [Column("FayOmur_DBCno")]
    public short? FayOmurDBCno { get; set; }

    [Column("FayOmur_SpecRECno")]
    public int? FayOmurSpecRECno { get; set; }

    [Column("FayOmur_iptal")]
    public bool? FayOmurIptal { get; set; }

    [Column("FayOmur_fileid")]
    public short? FayOmurFileid { get; set; }

    [Column("FayOmur_hidden")]
    public bool? FayOmurHidden { get; set; }

    [Column("FayOmur_kilitli")]
    public bool? FayOmurKilitli { get; set; }

    [Column("FayOmur_degisti")]
    public bool? FayOmurDegisti { get; set; }

    [Column("FayOmur_checksum")]
    public int? FayOmurChecksum { get; set; }

    [Column("FayOmur_create_user")]
    public short? FayOmurCreateUser { get; set; }

    [Column("FayOmur_create_date")]
    public DateTime? FayOmurCreateDate { get; set; }

    [Column("FayOmur_lastup_user")]
    public short? FayOmurLastupUser { get; set; }

    [Column("FayOmur_lastup_date")]
    public DateTime? FayOmurLastupDate { get; set; }

    [Column("FayOmur_special1")]
    [StringLength(4)]
    public string? FayOmurSpecial1 { get; set; }

    [Column("FayOmur_special2")]
    [StringLength(4)]
    public string? FayOmurSpecial2 { get; set; }

    [Column("FayOmur_special3")]
    [StringLength(4)]
    public string? FayOmurSpecial3 { get; set; }

    [Column("FayOmur_kodu")]
    [StringLength(25)]
    public string? FayOmurKodu { get; set; }

    [Column("FayOmur_aciklama")]
    [StringLength(127)]
    public string? FayOmurAciklama { get; set; }

    [Column("FayOmur_aciklama2")]
    [StringLength(127)]
    public string? FayOmurAciklama2 { get; set; }

    [Column("FayOmur_aciklama3")]
    [StringLength(127)]
    public string? FayOmurAciklama3 { get; set; }

    [Column("FayOmur_aciklama4")]
    [StringLength(127)]
    public string? FayOmurAciklama4 { get; set; }

    [Column("FayOmur_aciklama5")]
    [StringLength(127)]
    public string? FayOmurAciklama5 { get; set; }

    [Column("FayOmur_aciklama6")]
    [StringLength(127)]
    public string? FayOmurAciklama6 { get; set; }

    [Column("FayOmur_aciklama7")]
    [StringLength(127)]
    public string? FayOmurAciklama7 { get; set; }

    [Column("FayOmur_aciklama8")]
    [StringLength(127)]
    public string? FayOmurAciklama8 { get; set; }

    [Column("FayOmur_aciklama9")]
    [StringLength(127)]
    public string? FayOmurAciklama9 { get; set; }

    [Column("FayOmur_aciklama10")]
    [StringLength(127)]
    public string? FayOmurAciklama10 { get; set; }

    [Column("FayOmur_sure")]
    public short? FayOmurSure { get; set; }

    [Column("FayOmur_oran")]
    public double? FayOmurOran { get; set; }

    [Column("FayOmur_oran2")]
    public double? FayOmurOran2 { get; set; }

    [Column("FayOmur_oran3")]
    public double? FayOmurOran3 { get; set; }
}
