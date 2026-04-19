using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("okul_tanimlari")]
public class OkulTanimlari
{
    [Column("okl_Guid")]
    public Guid? OklGuid { get; set; }

    [Column("okl_DBCno")]
    public short? OklDBCno { get; set; }

    [Column("okl_SpecRECno")]
    public int? OklSpecRECno { get; set; }

    [Column("okl_iptal")]
    public bool? OklIptal { get; set; }

    [Column("okl_fileid")]
    public short? OklFileid { get; set; }

    [Column("okl_hidden")]
    public bool? OklHidden { get; set; }

    [Column("okl_kilitli")]
    public bool? OklKilitli { get; set; }

    [Column("okl_degisti")]
    public bool? OklDegisti { get; set; }

    [Column("okl_checksum")]
    public int? OklChecksum { get; set; }

    [Column("okl_create_user")]
    public short? OklCreateUser { get; set; }

    [Column("okl_create_date")]
    public DateTime? OklCreateDate { get; set; }

    [Column("okl_lastup_user")]
    public short? OklLastupUser { get; set; }

    [Column("okl_lastup_date")]
    public DateTime? OklLastupDate { get; set; }

    [Column("okl_special1")]
    [StringLength(4)]
    public string? OklSpecial1 { get; set; }

    [Column("okl_special2")]
    [StringLength(4)]
    public string? OklSpecial2 { get; set; }

    [Column("okl_special3")]
    [StringLength(4)]
    public string? OklSpecial3 { get; set; }

    [Column("okl_kod")]
    [StringLength(25)]
    public string? OklKod { get; set; }

    [Column("okl_adi")]
    [StringLength(40)]
    public string? OklAdi { get; set; }

    [Column("okl_tip")]
    public byte? OklTip { get; set; }
}
