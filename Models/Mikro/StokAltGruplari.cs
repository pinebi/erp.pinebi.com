using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_alt_gruplari")]
public class StokAltGruplari
{
    [Column("sta_Guid")]
    public Guid StaGuid { get; set; }

    [Column("sta_DBCno")]
    public short? StaDBCno { get; set; }

    [Column("sta_SpecRECno")]
    public int? StaSpecRECno { get; set; }

    [Column("sta_iptal")]
    public bool? StaIptal { get; set; }

    [Column("sta_fileid")]
    public short? StaFileid { get; set; }

    [Column("sta_hidden")]
    public bool? StaHidden { get; set; }

    [Column("sta_kilitli")]
    public bool? StaKilitli { get; set; }

    [Column("sta_degisti")]
    public bool? StaDegisti { get; set; }

    [Column("sta_checksum")]
    public int? StaChecksum { get; set; }

    [Column("sta_create_user")]
    public short? StaCreateUser { get; set; }

    [Column("sta_create_date")]
    public DateTime? StaCreateDate { get; set; }

    [Column("sta_lastup_user")]
    public short? StaLastupUser { get; set; }

    [Column("sta_lastup_date")]
    public DateTime? StaLastupDate { get; set; }

    [Column("sta_special1")]
    [StringLength(4)]
    public string? StaSpecial1 { get; set; }

    [Column("sta_special2")]
    [StringLength(4)]
    public string? StaSpecial2 { get; set; }

    [Column("sta_special3")]
    [StringLength(4)]
    public string? StaSpecial3 { get; set; }

    [Column("sta_kod")]
    [StringLength(25)]
    public string? StaKod { get; set; }

    [Column("sta_isim")]
    [StringLength(40)]
    public string? StaIsim { get; set; }

    [Column("sta_ana_grup_kod")]
    [StringLength(25)]
    public string? StaAnaGrupKod { get; set; }
}
