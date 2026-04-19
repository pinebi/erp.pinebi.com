using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avm_sayaclari")]
public class AvmSayaclari
{
    [Column("Avmsyc_Guid")]
    public Guid? AvmsycGuid { get; set; }

    [Column("Avmsyc_DBCno")]
    public short? AvmsycDBCno { get; set; }

    [Column("Avmsyc_SpecRECno")]
    public int? AvmsycSpecRECno { get; set; }

    [Column("Avmsyc_iptal")]
    public bool? AvmsycIptal { get; set; }

    [Column("Avmsyc_fileid")]
    public short? AvmsycFileid { get; set; }

    [Column("Avmsyc_hidden")]
    public bool? AvmsycHidden { get; set; }

    [Column("Avmsyc_kilitli")]
    public bool? AvmsycKilitli { get; set; }

    [Column("Avmsyc_degisti")]
    public bool? AvmsycDegisti { get; set; }

    [Column("Avmsyc_checksum")]
    public int? AvmsycChecksum { get; set; }

    [Column("Avmsyc_create_user")]
    public short? AvmsycCreateUser { get; set; }

    [Column("Avmsyc_create_date")]
    public DateTime? AvmsycCreateDate { get; set; }

    [Column("Avmsyc_lastup_user")]
    public short? AvmsycLastupUser { get; set; }

    [Column("Avmsyc_lastup_date")]
    public DateTime? AvmsycLastupDate { get; set; }

    [Column("Avmsyc_special1")]
    [StringLength(4)]
    public string? AvmsycSpecial1 { get; set; }

    [Column("Avmsyc_special2")]
    [StringLength(4)]
    public string? AvmsycSpecial2 { get; set; }

    [Column("Avmsyc_special3")]
    [StringLength(4)]
    public string? AvmsycSpecial3 { get; set; }

    [Column("Avmsyc_turu")]
    public byte? AvmsycTuru { get; set; }

    [Column("Avmsyc_cinsi")]
    public byte? AvmsycCinsi { get; set; }

    [Column("Avmsyc_tipi")]
    public byte? AvmsycTipi { get; set; }

    [Column("Avmsyc_kod")]
    [StringLength(25)]
    public string? AvmsycKod { get; set; }

    [Column("Avmsyc_ismi")]
    [StringLength(50)]
    public string? AvmsycIsmi { get; set; }

    [Column("Avmsyc_sayacno")]
    [StringLength(25)]
    public string? AvmsycSayacno { get; set; }

    [Column("Avmsyc_sozlesmeno")]
    [StringLength(20)]
    public string? AvmsycSozlesmeno { get; set; }

    [Column("Avmsyc_blmkodu")]
    [StringLength(25)]
    public string? AvmsycBlmkodu { get; set; }

    [Column("Avmsyc_masrafhizmetkodu")]
    [StringLength(25)]
    public string? AvmsycMasrafhizmetkodu { get; set; }

    [Column("Avmsyc_merkezisayackodu")]
    [StringLength(25)]
    public string? AvmsycMerkezisayackodu { get; set; }
}
