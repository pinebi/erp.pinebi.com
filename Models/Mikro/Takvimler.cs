using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("takvimler")]
public class Takvimler
{
    [Column("takvim_Guid")]
    public Guid? TakvimGuid { get; set; }

    [Column("takvim_DBCno")]
    public short? TakvimDBCno { get; set; }

    [Column("takvim_SpecRECNo")]
    public int? TakvimSpecRECNo { get; set; }

    [Column("takvim_iptal")]
    public bool? TakvimIptal { get; set; }

    [Column("takvim_fileid")]
    public short? TakvimFileid { get; set; }

    [Column("takvim_hidden")]
    public bool? TakvimHidden { get; set; }

    [Column("takvim_kilitli")]
    public bool? TakvimKilitli { get; set; }

    [Column("takvim_degisti")]
    public bool? TakvimDegisti { get; set; }

    [Column("takvim_checksum")]
    public int? TakvimChecksum { get; set; }

    [Column("takvim_create_user")]
    public short? TakvimCreateUser { get; set; }

    [Column("takvim_create_date")]
    public DateTime? TakvimCreateDate { get; set; }

    [Column("takvim_lastup_user")]
    public short? TakvimLastupUser { get; set; }

    [Column("takvim_lastup_date")]
    public DateTime? TakvimLastupDate { get; set; }

    [Column("takvim_special1")]
    [StringLength(4)]
    public string? TakvimSpecial1 { get; set; }

    [Column("takvim_special2")]
    [StringLength(4)]
    public string? TakvimSpecial2 { get; set; }

    [Column("takvim_special3")]
    [StringLength(4)]
    public string? TakvimSpecial3 { get; set; }

    [Column("takvim_kodu")]
    [StringLength(4)]
    public string? TakvimKodu { get; set; }

    [Column("takvim_ismi")]
    [StringLength(40)]
    public string? TakvimIsmi { get; set; }
}
