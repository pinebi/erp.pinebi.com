using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("zimmet_yerleri")]
public class ZimmetYerleri
{
    [Column("zim_Guid")]
    public Guid? ZimGuid { get; set; }

    [Column("zim_DBCno")]
    public short? ZimDBCno { get; set; }

    [Column("zim_SpecRECno")]
    public int? ZimSpecRECno { get; set; }

    [Column("zim_iptal")]
    public bool? ZimIptal { get; set; }

    [Column("zim_fileid")]
    public short? ZimFileid { get; set; }

    [Column("zim_hidden")]
    public bool? ZimHidden { get; set; }

    [Column("zim_kilitli")]
    public bool? ZimKilitli { get; set; }

    [Column("zim_degisti")]
    public bool? ZimDegisti { get; set; }

    [Column("zim_checksum")]
    public int? ZimChecksum { get; set; }

    [Column("zim_create_user")]
    public short? ZimCreateUser { get; set; }

    [Column("zim_create_date")]
    public DateTime? ZimCreateDate { get; set; }

    [Column("zim_lastup_user")]
    public short? ZimLastupUser { get; set; }

    [Column("zim_lastup_date")]
    public DateTime? ZimLastupDate { get; set; }

    [Column("zim_special1")]
    [StringLength(4)]
    public string? ZimSpecial1 { get; set; }

    [Column("zim_special2")]
    [StringLength(4)]
    public string? ZimSpecial2 { get; set; }

    [Column("zim_special3")]
    [StringLength(4)]
    public string? ZimSpecial3 { get; set; }

    [Column("zim_kod")]
    [StringLength(25)]
    public string? ZimKod { get; set; }

    [Column("zim_ismi")]
    [StringLength(40)]
    public string? ZimIsmi { get; set; }
}
