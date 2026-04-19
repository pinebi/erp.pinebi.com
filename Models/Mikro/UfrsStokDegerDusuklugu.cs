using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ufrs_stok_deger_dusuklugu")]
public class UfrsStokDegerDusuklugu
{
    [Column("usdd_Guid")]
    public Guid? UsddGuid { get; set; }

    [Column("usdd_DBCno")]
    public short? UsddDBCno { get; set; }

    [Column("usdd_SpecRECno")]
    public int? UsddSpecRECno { get; set; }

    [Column("usdd_iptal")]
    public bool? UsddIptal { get; set; }

    [Column("usdd_fileid")]
    public short? UsddFileid { get; set; }

    [Column("usdd_hidden")]
    public bool? UsddHidden { get; set; }

    [Column("usdd_kilitli")]
    public bool? UsddKilitli { get; set; }

    [Column("usdd_degisti")]
    public bool? UsddDegisti { get; set; }

    [Column("usdd_CheckSum")]
    public int? UsddCheckSum { get; set; }

    [Column("usdd_create_user")]
    public short? UsddCreateUser { get; set; }

    [Column("usdd_create_date")]
    public DateTime? UsddCreateDate { get; set; }

    [Column("usdd_lastup_user")]
    public short? UsddLastupUser { get; set; }

    [Column("usdd_lastup_date")]
    public DateTime? UsddLastupDate { get; set; }

    [Column("usdd_special1")]
    [StringLength(4)]
    public string? UsddSpecial1 { get; set; }

    [Column("usdd_special2")]
    [StringLength(4)]
    public string? UsddSpecial2 { get; set; }

    [Column("usdd_special3")]
    [StringLength(4)]
    public string? UsddSpecial3 { get; set; }

    [Column("usdd_tarih")]
    public DateTime? UsddTarih { get; set; }

    [Column("usdd_satirno")]
    public int? UsddSatirno { get; set; }

    [Column("usdd_stokkodu")]
    [StringLength(25)]
    public string? UsddStokkodu { get; set; }

    [Column("usdd_depono")]
    public int? UsddDepono { get; set; }

    [Column("usdd_envantermiktar")]
    public double? UsddEnvantermiktar { get; set; }

    [Column("usdd_envanterdeger")]
    public double? UsddEnvanterdeger { get; set; }

    [Column("usdd_piyasadegeri")]
    public double? UsddPiyasadegeri { get; set; }

    [Column("usdd_degerfarki")]
    public double? UsddDegerfarki { get; set; }

    [Column("usdd_stokdcinsi")]
    public byte? UsddStokdcinsi { get; set; }

    [Column("usdd_stokdkur")]
    public double? UsddStokdkur { get; set; }

    [Column("usdd_hardcinsi")]
    public byte? UsddHardcinsi { get; set; }

    [Column("usdd_hardkur")]
    public double? UsddHardkur { get; set; }

    [Column("usdd_altdkur")]
    public double? UsddAltdkur { get; set; }
}
