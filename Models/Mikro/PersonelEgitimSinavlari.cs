using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitim_sinavlari")]
public class PersonelEgitimSinavlari
{
    [Column("pes_Guid")]
    public Guid? PesGuid { get; set; }

    [Column("pes_DBCno")]
    public short? PesDBCno { get; set; }

    [Column("pes_SpecRECno")]
    public int? PesSpecRECno { get; set; }

    [Column("pes_iptal")]
    public bool? PesIptal { get; set; }

    [Column("pes_fileid")]
    public short? PesFileid { get; set; }

    [Column("pes_hidden")]
    public bool? PesHidden { get; set; }

    [Column("pes_kilitli")]
    public bool? PesKilitli { get; set; }

    [Column("pes_degisti")]
    public bool? PesDegisti { get; set; }

    [Column("pes_checksum")]
    public int? PesChecksum { get; set; }

    [Column("pes_create_user")]
    public short? PesCreateUser { get; set; }

    [Column("pes_create_date")]
    public DateTime? PesCreateDate { get; set; }

    [Column("pes_lastup_user")]
    public short? PesLastupUser { get; set; }

    [Column("pes_lastup_date")]
    public DateTime? PesLastupDate { get; set; }

    [Column("pes_special1")]
    [StringLength(4)]
    public string? PesSpecial1 { get; set; }

    [Column("pes_special2")]
    [StringLength(4)]
    public string? PesSpecial2 { get; set; }

    [Column("pes_special3")]
    [StringLength(4)]
    public string? PesSpecial3 { get; set; }

    [Column("pes_tipi")]
    public byte? PesTipi { get; set; }

    [Column("pes_kodu")]
    [StringLength(25)]
    public string? PesKodu { get; set; }

    [Column("pes_sinavkodu")]
    [StringLength(25)]
    public string? PesSinavkodu { get; set; }

    [Column("pes_sirano")]
    public int? PesSirano { get; set; }

    [Column("pes_puan")]
    public double? PesPuan { get; set; }
}
