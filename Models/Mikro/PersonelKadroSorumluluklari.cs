using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_sorumluluklari")]
public class PersonelKadroSorumluluklari
{
    [Column("ks_Guid")]
    public Guid? KsGuid { get; set; }

    [Column("ks_DBCno")]
    public short? KsDBCno { get; set; }

    [Column("ks_SpecRECno")]
    public int? KsSpecRECno { get; set; }

    [Column("ks_iptal")]
    public bool? KsIptal { get; set; }

    [Column("ks_fileid")]
    public short? KsFileid { get; set; }

    [Column("ks_hidden")]
    public bool? KsHidden { get; set; }

    [Column("ks_kilitli")]
    public bool? KsKilitli { get; set; }

    [Column("ks_degisti")]
    public bool? KsDegisti { get; set; }

    [Column("ks_checksum")]
    public int? KsChecksum { get; set; }

    [Column("ks_create_user")]
    public short? KsCreateUser { get; set; }

    [Column("ks_create_date")]
    public DateTime? KsCreateDate { get; set; }

    [Column("ks_lastup_user")]
    public short? KsLastupUser { get; set; }

    [Column("ks_lastup_date")]
    public DateTime? KsLastupDate { get; set; }

    [Column("ks_special1")]
    [StringLength(4)]
    public string? KsSpecial1 { get; set; }

    [Column("ks_special2")]
    [StringLength(4)]
    public string? KsSpecial2 { get; set; }

    [Column("ks_special3")]
    [StringLength(4)]
    public string? KsSpecial3 { get; set; }

    [Column("ks_kadrokod")]
    [StringLength(25)]
    public string? KsKadrokod { get; set; }

    [Column("ks_kadrosirano")]
    public int? KsKadrosirano { get; set; }

    [Column("ks_satirno")]
    public int? KsSatirno { get; set; }

    [Column("ks_sorumlulukkod")]
    [StringLength(25)]
    public string? KsSorumlulukkod { get; set; }

    [Column("ks_gecerliliktarihi")]
    public DateTime? KsGecerliliktarihi { get; set; }
}
