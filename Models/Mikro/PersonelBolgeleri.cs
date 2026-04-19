using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_bolgeleri")]
public class PersonelBolgeleri
{
    [Column("pbl_Guid")]
    public Guid? PblGuid { get; set; }

    [Column("pbl_DBCno")]
    public short? PblDBCno { get; set; }

    [Column("pbl_SpecRECno")]
    public int? PblSpecRECno { get; set; }

    [Column("pbl_iptal")]
    public bool? PblIptal { get; set; }

    [Column("pbl_fileid")]
    public short? PblFileid { get; set; }

    [Column("pbl_hidden")]
    public bool? PblHidden { get; set; }

    [Column("pbl_kilitli")]
    public bool? PblKilitli { get; set; }

    [Column("pbl_degisti")]
    public bool? PblDegisti { get; set; }

    [Column("pbl_checksum")]
    public int? PblChecksum { get; set; }

    [Column("pbl_create_user")]
    public short? PblCreateUser { get; set; }

    [Column("pbl_create_date")]
    public DateTime? PblCreateDate { get; set; }

    [Column("pbl_lastup_user")]
    public short? PblLastupUser { get; set; }

    [Column("pbl_lastup_date")]
    public DateTime? PblLastupDate { get; set; }

    [Column("pbl_special1")]
    [StringLength(4)]
    public string? PblSpecial1 { get; set; }

    [Column("pbl_special2")]
    [StringLength(4)]
    public string? PblSpecial2 { get; set; }

    [Column("pbl_special3")]
    [StringLength(4)]
    public string? PblSpecial3 { get; set; }

    [Column("pbl_bolge_kodu")]
    [StringLength(25)]
    public string? PblBolgeKodu { get; set; }

    [Column("pbl_bolge_adi")]
    [StringLength(30)]
    public string? PblBolgeAdi { get; set; }
}
