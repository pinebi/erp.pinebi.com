using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("e_fatura_detaylari")]
public class EFaturaDetaylari
{
    [Column("efd_Guid")]
    public Guid? EfdGuid { get; set; }

    [Column("efd_DBCno")]
    public short? EfdDBCno { get; set; }

    [Column("efd_SpecRECno")]
    public int? EfdSpecRECno { get; set; }

    [Column("efd_iptal")]
    public bool? EfdIptal { get; set; }

    [Column("efd_fileid")]
    public short? EfdFileid { get; set; }

    [Column("efd_hidden")]
    public bool? EfdHidden { get; set; }

    [Column("efd_kilitli")]
    public bool? EfdKilitli { get; set; }

    [Column("efd_degisti")]
    public bool? EfdDegisti { get; set; }

    [Column("efd_checksum")]
    public int? EfdChecksum { get; set; }

    [Column("efd_create_user")]
    public short? EfdCreateUser { get; set; }

    [Column("efd_create_date")]
    public DateTime? EfdCreateDate { get; set; }

    [Column("efd_lastup_user")]
    public short? EfdLastupUser { get; set; }

    [Column("efd_lastup_date")]
    public DateTime? EfdLastupDate { get; set; }

    [Column("efd_special1")]
    [StringLength(4)]
    public string? EfdSpecial1 { get; set; }

    [Column("efd_special2")]
    [StringLength(4)]
    public string? EfdSpecial2 { get; set; }

    [Column("efd_special3")]
    [StringLength(4)]
    public string? EfdSpecial3 { get; set; }

    [Column("efd_firmano")]
    public int? EfdFirmano { get; set; }

    [Column("efd_tipi")]
    public byte? EfdTipi { get; set; }

    [Column("efd_gib_seri")]
    [StringLength(10)]
    public string? EfdGibSeri { get; set; }

    [Column("efd_gib_sira")]
    public int? EfdGibSira { get; set; }

    [Column("efd_uuid")]
    [StringLength(40)]
    public string? EfdUuid { get; set; }

    [Column("efd_fat_uid")]
    public Guid? EfdFatUid { get; set; }

    [Column("efd_pozisyon")]
    public byte? EfdPozisyon { get; set; }

    [Column("efd_mVkn")]
    [StringLength(15)]
    public string? EfdMVkn { get; set; }
}
