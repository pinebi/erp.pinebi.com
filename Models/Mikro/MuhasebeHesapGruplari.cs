using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_hesap_gruplari")]
public class MuhasebeHesapGruplari
{
    [Column("mhg_Guid")]
    public Guid? MhgGuid { get; set; }

    [Column("mhg_DBCno")]
    public short? MhgDBCno { get; set; }

    [Column("mhg_SpecRECno")]
    public int? MhgSpecRECno { get; set; }

    [Column("mhg_iptal")]
    public bool? MhgIptal { get; set; }

    [Column("mhg_fileid")]
    public short? MhgFileid { get; set; }

    [Column("mhg_hidden")]
    public bool? MhgHidden { get; set; }

    [Column("mhg_kilitli")]
    public bool? MhgKilitli { get; set; }

    [Column("mhg_degisti")]
    public bool? MhgDegisti { get; set; }

    [Column("mhg_checksum")]
    public int? MhgChecksum { get; set; }

    [Column("mhg_create_user")]
    public short? MhgCreateUser { get; set; }

    [Column("mhg_create_date")]
    public DateTime? MhgCreateDate { get; set; }

    [Column("mhg_lastup_user")]
    public short? MhgLastupUser { get; set; }

    [Column("mhg_lastup_date")]
    public DateTime? MhgLastupDate { get; set; }

    [Column("mhg_special1")]
    [StringLength(4)]
    public string? MhgSpecial1 { get; set; }

    [Column("mhg_special2")]
    [StringLength(4)]
    public string? MhgSpecial2 { get; set; }

    [Column("mhg_special3")]
    [StringLength(4)]
    public string? MhgSpecial3 { get; set; }

    [Column("mhg_kodu")]
    [StringLength(4)]
    public string? MhgKodu { get; set; }

    [Column("mhg_aciklama")]
    [StringLength(40)]
    public string? MhgAciklama { get; set; }
}
