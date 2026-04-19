using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_performanslari")]
public class PersonelKadroPerformanslari
{
    [Column("kp_Guid")]
    public Guid? KpGuid { get; set; }

    [Column("kp_DBCno")]
    public short? KpDBCno { get; set; }

    [Column("kp_SpecRECno")]
    public int? KpSpecRECno { get; set; }

    [Column("kp_iptal")]
    public bool? KpIptal { get; set; }

    [Column("kp_fileid")]
    public short? KpFileid { get; set; }

    [Column("kp_hidden")]
    public bool? KpHidden { get; set; }

    [Column("kp_kilitli")]
    public bool? KpKilitli { get; set; }

    [Column("kp_degisti")]
    public bool? KpDegisti { get; set; }

    [Column("kp_checksum")]
    public int? KpChecksum { get; set; }

    [Column("kp_create_user")]
    public short? KpCreateUser { get; set; }

    [Column("kp_create_date")]
    public DateTime? KpCreateDate { get; set; }

    [Column("kp_lastup_user")]
    public short? KpLastupUser { get; set; }

    [Column("kp_lastup_date")]
    public DateTime? KpLastupDate { get; set; }

    [Column("kp_special1")]
    [StringLength(4)]
    public string? KpSpecial1 { get; set; }

    [Column("kp_special2")]
    [StringLength(4)]
    public string? KpSpecial2 { get; set; }

    [Column("kp_special3")]
    [StringLength(4)]
    public string? KpSpecial3 { get; set; }

    [Column("kp_kadrokod")]
    [StringLength(25)]
    public string? KpKadrokod { get; set; }

    [Column("kp_kadrosirano")]
    public int? KpKadrosirano { get; set; }

    [Column("kp_satirno")]
    public int? KpSatirno { get; set; }

    [Column("kp_performanstipi")]
    public byte? KpPerformanstipi { get; set; }

    [Column("kp_performanskod")]
    [StringLength(25)]
    public string? KpPerformanskod { get; set; }

    [Column("kp_gecerliliktarihi")]
    public DateTime? KpGecerliliktarihi { get; set; }
}
