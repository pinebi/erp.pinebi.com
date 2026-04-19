using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_adalari")]
public class IstasyonAdalari
{
    [Column("ada_Guid")]
    public Guid? AdaGuid { get; set; }

    [Column("ada_DBCno")]
    public short? AdaDBCno { get; set; }

    [Column("ada_SpecRECno")]
    public int? AdaSpecRECno { get; set; }

    [Column("ada_iptal")]
    public bool? AdaIptal { get; set; }

    [Column("ada_fileid")]
    public short? AdaFileid { get; set; }

    [Column("ada_hidden")]
    public bool? AdaHidden { get; set; }

    [Column("ada_kilitli")]
    public bool? AdaKilitli { get; set; }

    [Column("ada_degisti")]
    public bool? AdaDegisti { get; set; }

    [Column("ada_checksum")]
    public int? AdaChecksum { get; set; }

    [Column("ada_create_user")]
    public short? AdaCreateUser { get; set; }

    [Column("ada_create_date")]
    public DateTime? AdaCreateDate { get; set; }

    [Column("ada_lastup_user")]
    public short? AdaLastupUser { get; set; }

    [Column("ada_lastup_date")]
    public DateTime? AdaLastupDate { get; set; }

    [Column("ada_special1")]
    [StringLength(4)]
    public string? AdaSpecial1 { get; set; }

    [Column("ada_special2")]
    [StringLength(4)]
    public string? AdaSpecial2 { get; set; }

    [Column("ada_special3")]
    [StringLength(4)]
    public string? AdaSpecial3 { get; set; }

    [Column("ada_kod")]
    [StringLength(25)]
    public string? AdaKod { get; set; }

    [Column("ada_ismi")]
    [StringLength(30)]
    public string? AdaIsmi { get; set; }

    [Column("ada_aciklama")]
    [StringLength(50)]
    public string? AdaAciklama { get; set; }
}
