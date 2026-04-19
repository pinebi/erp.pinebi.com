using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istisna_tanimlari")]
public class IstisnaTanimlari
{
    [Column("ist_Guid")]
    public Guid? IstGuid { get; set; }

    [Column("ist_DBCno")]
    public short? IstDBCno { get; set; }

    [Column("ist_SpecRECno")]
    public int? IstSpecRECno { get; set; }

    [Column("ist_iptal")]
    public bool? IstIptal { get; set; }

    [Column("ist_fileid")]
    public short? IstFileid { get; set; }

    [Column("ist_hidden")]
    public bool? IstHidden { get; set; }

    [Column("ist_kilitli")]
    public bool? IstKilitli { get; set; }

    [Column("ist_degisti")]
    public bool? IstDegisti { get; set; }

    [Column("ist_checksum")]
    public int? IstChecksum { get; set; }

    [Column("ist_create_user")]
    public short? IstCreateUser { get; set; }

    [Column("ist_create_date")]
    public DateTime? IstCreateDate { get; set; }

    [Column("ist_lastup_user")]
    public short? IstLastupUser { get; set; }

    [Column("ist_lastup_date")]
    public DateTime? IstLastupDate { get; set; }

    [Column("ist_special1")]
    [StringLength(4)]
    public string? IstSpecial1 { get; set; }

    [Column("ist_special2")]
    [StringLength(4)]
    public string? IstSpecial2 { get; set; }

    [Column("ist_special3")]
    [StringLength(4)]
    public string? IstSpecial3 { get; set; }

    [Column("ist_kod")]
    [StringLength(5)]
    public string? IstKod { get; set; }

    [Column("ist_aciklama")]
    [StringLength(127)]
    public string? IstAciklama { get; set; }

    [Column("ist_tipi")]
    public byte? IstTipi { get; set; }
}
