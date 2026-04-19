using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_nitelikleri")]
public class PersonelKadroNitelikleri
{
    [Column("kn_Guid")]
    public Guid? KnGuid { get; set; }

    [Column("kn_DBCno")]
    public short? KnDBCno { get; set; }

    [Column("kn_SpecRECno")]
    public int? KnSpecRECno { get; set; }

    [Column("kn_iptal")]
    public bool? KnIptal { get; set; }

    [Column("kn_fileid")]
    public short? KnFileid { get; set; }

    [Column("kn_hidden")]
    public bool? KnHidden { get; set; }

    [Column("kn_kilitli")]
    public bool? KnKilitli { get; set; }

    [Column("kn_degisti")]
    public bool? KnDegisti { get; set; }

    [Column("kn_checksum")]
    public int? KnChecksum { get; set; }

    [Column("kn_create_user")]
    public short? KnCreateUser { get; set; }

    [Column("kn_create_date")]
    public DateTime? KnCreateDate { get; set; }

    [Column("kn_lastup_user")]
    public short? KnLastupUser { get; set; }

    [Column("kn_lastup_date")]
    public DateTime? KnLastupDate { get; set; }

    [Column("kn_special1")]
    [StringLength(4)]
    public string? KnSpecial1 { get; set; }

    [Column("kn_special2")]
    [StringLength(4)]
    public string? KnSpecial2 { get; set; }

    [Column("kn_special3")]
    [StringLength(4)]
    public string? KnSpecial3 { get; set; }

    [Column("kn_kadrokod")]
    [StringLength(25)]
    public string? KnKadrokod { get; set; }

    [Column("kn_kadrosirano")]
    public int? KnKadrosirano { get; set; }

    [Column("kn_satirno")]
    public int? KnSatirno { get; set; }

    [Column("kn_nitelikkod")]
    [StringLength(25)]
    public string? KnNitelikkod { get; set; }

    [Column("kn_gecerliliktarihi")]
    public DateTime? KnGecerliliktarihi { get; set; }
}
