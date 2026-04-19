using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_limitleri")]
public class PersonelKadroLimitleri
{
    [Column("pkl_Guid")]
    public Guid? PklGuid { get; set; }

    [Column("pkl_DBCno")]
    public short? PklDBCno { get; set; }

    [Column("pkl_SpecRECno")]
    public int? PklSpecRECno { get; set; }

    [Column("pkl_iptal")]
    public bool? PklIptal { get; set; }

    [Column("pkl_fileid")]
    public short? PklFileid { get; set; }

    [Column("pkl_hidden")]
    public bool? PklHidden { get; set; }

    [Column("pkl_kilitli")]
    public bool? PklKilitli { get; set; }

    [Column("pkl_degisti")]
    public bool? PklDegisti { get; set; }

    [Column("pkl_checksum")]
    public int? PklChecksum { get; set; }

    [Column("pkl_create_user")]
    public short? PklCreateUser { get; set; }

    [Column("pkl_create_date")]
    public DateTime? PklCreateDate { get; set; }

    [Column("pkl_lastup_user")]
    public short? PklLastupUser { get; set; }

    [Column("pkl_lastup_date")]
    public DateTime? PklLastupDate { get; set; }

    [Column("pkl_special1")]
    [StringLength(4)]
    public string? PklSpecial1 { get; set; }

    [Column("pkl_special2")]
    [StringLength(4)]
    public string? PklSpecial2 { get; set; }

    [Column("pkl_special3")]
    [StringLength(4)]
    public string? PklSpecial3 { get; set; }

    [Column("pkl_tipi")]
    public byte? PklTipi { get; set; }

    [Column("pkl_kadro_kodu")]
    [StringLength(25)]
    public string? PklKadroKodu { get; set; }

    [Column("pkl_kadro_no")]
    public int? PklKadroNo { get; set; }

    [Column("pkl_cinsi")]
    public byte? PklCinsi { get; set; }

    [Column("pkl_kodu")]
    [StringLength(25)]
    public string? PklKodu { get; set; }

    [Column("pkl_periyod")]
    public byte? PklPeriyod { get; set; }

    [Column("pkl_limit")]
    public double? PklLimit { get; set; }
}
