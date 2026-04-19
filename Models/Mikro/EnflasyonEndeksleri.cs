using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("enflasyon_endeksleri")]
public class EnflasyonEndeksleri
{
    [Column("end_Guid")]
    public Guid? EndGuid { get; set; }

    [Column("end_DBCno")]
    public short? EndDBCno { get; set; }

    [Column("end_SpecRecNo")]
    public int? EndSpecRecNo { get; set; }

    [Column("end_iptal")]
    public bool? EndIptal { get; set; }

    [Column("end_fileid")]
    public short? EndFileid { get; set; }

    [Column("end_hidden")]
    public bool? EndHidden { get; set; }

    [Column("end_kilitli")]
    public bool? EndKilitli { get; set; }

    [Column("end_degisti")]
    public bool? EndDegisti { get; set; }

    [Column("end_checksum")]
    public int? EndChecksum { get; set; }

    [Column("end_create_user")]
    public short? EndCreateUser { get; set; }

    [Column("end_create_date")]
    public DateTime? EndCreateDate { get; set; }

    [Column("end_lastup_user")]
    public short? EndLastupUser { get; set; }

    [Column("end_lastup_date")]
    public DateTime? EndLastupDate { get; set; }

    [Column("end_special1")]
    [StringLength(4)]
    public string? EndSpecial1 { get; set; }

    [Column("end_special2")]
    [StringLength(4)]
    public string? EndSpecial2 { get; set; }

    [Column("end_special3")]
    [StringLength(4)]
    public string? EndSpecial3 { get; set; }

    [Column("end_no")]
    public byte? EndNo { get; set; }

    [Column("end_yil")]
    public short? EndYil { get; set; }

    [Column("end_ay")]
    public short? EndAy { get; set; }

    [Column("end_deger")]
    public double? EndDeger { get; set; }
}
