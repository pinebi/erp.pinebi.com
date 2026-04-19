using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("takvim_vardiya_detaylari")]
public class TakvimVardiyaDetaylari
{
    [Column("takvimhr_Guid")]
    public Guid? TakvimhrGuid { get; set; }

    [Column("takvimhr_DBCno")]
    public short? TakvimhrDBCno { get; set; }

    [Column("takvimhr_SpecRECNo")]
    public int? TakvimhrSpecRECNo { get; set; }

    [Column("takvimhr_iptal")]
    public bool? TakvimhrIptal { get; set; }

    [Column("takvimhr_fileid")]
    public short? TakvimhrFileid { get; set; }

    [Column("takvimhr_hidden")]
    public bool? TakvimhrHidden { get; set; }

    [Column("takvimhr_kilitli")]
    public bool? TakvimhrKilitli { get; set; }

    [Column("takvimhr_degisti")]
    public bool? TakvimhrDegisti { get; set; }

    [Column("takvimhr_checksum")]
    public int? TakvimhrChecksum { get; set; }

    [Column("takvimhr_create_user")]
    public short? TakvimhrCreateUser { get; set; }

    [Column("takvimhr_create_date")]
    public DateTime? TakvimhrCreateDate { get; set; }

    [Column("takvimhr_lastup_user")]
    public short? TakvimhrLastupUser { get; set; }

    [Column("takvimhr_lastup_date")]
    public DateTime? TakvimhrLastupDate { get; set; }

    [Column("takvimhr_special1")]
    [StringLength(4)]
    public string? TakvimhrSpecial1 { get; set; }

    [Column("takvimhr_special2")]
    [StringLength(4)]
    public string? TakvimhrSpecial2 { get; set; }

    [Column("takvimhr_special3")]
    [StringLength(4)]
    public string? TakvimhrSpecial3 { get; set; }

    [Column("takvimhr_takkodu")]
    [StringLength(4)]
    public string? TakvimhrTakkodu { get; set; }

    [Column("takvimhr_tarih")]
    public DateTime? TakvimhrTarih { get; set; }

    [Column("takvimhr_vardkodu")]
    [StringLength(25)]
    public string? TakvimhrVardkodu { get; set; }
}
