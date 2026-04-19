using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_egitimleri")]
public class PersonelKadroEgitimleri
{
    [Column("ke_Guid")]
    public Guid? KeGuid { get; set; }

    [Column("ke_DBCno")]
    public short? KeDBCno { get; set; }

    [Column("ke_SpecRECno")]
    public int? KeSpecRECno { get; set; }

    [Column("ke_iptal")]
    public bool? KeIptal { get; set; }

    [Column("ke_fileid")]
    public short? KeFileid { get; set; }

    [Column("ke_hidden")]
    public bool? KeHidden { get; set; }

    [Column("ke_kilitli")]
    public bool? KeKilitli { get; set; }

    [Column("ke_degisti")]
    public bool? KeDegisti { get; set; }

    [Column("ke_checksum")]
    public int? KeChecksum { get; set; }

    [Column("ke_create_user")]
    public short? KeCreateUser { get; set; }

    [Column("ke_create_date")]
    public DateTime? KeCreateDate { get; set; }

    [Column("ke_lastup_user")]
    public short? KeLastupUser { get; set; }

    [Column("ke_lastup_date")]
    public DateTime? KeLastupDate { get; set; }

    [Column("ke_special1")]
    [StringLength(4)]
    public string? KeSpecial1 { get; set; }

    [Column("ke_special2")]
    [StringLength(4)]
    public string? KeSpecial2 { get; set; }

    [Column("ke_special3")]
    [StringLength(4)]
    public string? KeSpecial3 { get; set; }

    [Column("ke_kadrokod")]
    [StringLength(25)]
    public string? KeKadrokod { get; set; }

    [Column("ke_kadrosirano")]
    public int? KeKadrosirano { get; set; }

    [Column("ke_satirno")]
    public int? KeSatirno { get; set; }

    [Column("ke_tipi")]
    public byte? KeTipi { get; set; }

    [Column("ke_egitimkod")]
    [StringLength(25)]
    public string? KeEgitimkod { get; set; }

    [Column("ke_gecerliliktarihi")]
    public DateTime? KeGecerliliktarihi { get; set; }

    [Column("ke_tamamlama_suresi")]
    public int? KeTamamlamaSuresi { get; set; }
}
