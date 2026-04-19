using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_yetkileri")]
public class PersonelKadroYetkileri
{
    [Column("ky_Guid")]
    public Guid? KyGuid { get; set; }

    [Column("ky_DBCno")]
    public short? KyDBCno { get; set; }

    [Column("ky_SpecRECno")]
    public int? KySpecRECno { get; set; }

    [Column("ky_iptal")]
    public bool? KyIptal { get; set; }

    [Column("ky_fileid")]
    public short? KyFileid { get; set; }

    [Column("ky_hidden")]
    public bool? KyHidden { get; set; }

    [Column("ky_kilitli")]
    public bool? KyKilitli { get; set; }

    [Column("ky_degisti")]
    public bool? KyDegisti { get; set; }

    [Column("ky_checksum")]
    public int? KyChecksum { get; set; }

    [Column("ky_create_user")]
    public short? KyCreateUser { get; set; }

    [Column("ky_create_date")]
    public DateTime? KyCreateDate { get; set; }

    [Column("ky_lastup_user")]
    public short? KyLastupUser { get; set; }

    [Column("ky_lastup_date")]
    public DateTime? KyLastupDate { get; set; }

    [Column("ky_special1")]
    [StringLength(4)]
    public string? KySpecial1 { get; set; }

    [Column("ky_special2")]
    [StringLength(4)]
    public string? KySpecial2 { get; set; }

    [Column("ky_special3")]
    [StringLength(4)]
    public string? KySpecial3 { get; set; }

    [Column("ky_kadrokod")]
    [StringLength(25)]
    public string? KyKadrokod { get; set; }

    [Column("ky_kadrosirano")]
    public int? KyKadrosirano { get; set; }

    [Column("ky_satirno")]
    public int? KySatirno { get; set; }

    [Column("ky_yetkikod")]
    [StringLength(25)]
    public string? KyYetkikod { get; set; }

    [Column("ky_gecerliliktarihi")]
    public DateTime? KyGecerliliktarihi { get; set; }
}
