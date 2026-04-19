using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("diib_tanimlari")]
public class DiibTanimlari
{
    [Column("di_Guid")]
    public Guid? DiGuid { get; set; }

    [Column("di_DBCno")]
    public short? DiDBCno { get; set; }

    [Column("di_SpecRecNo")]
    public int? DiSpecRecNo { get; set; }

    [Column("di_iptal")]
    public bool? DiIptal { get; set; }

    [Column("di_fileid")]
    public short? DiFileid { get; set; }

    [Column("di_hidden")]
    public bool? DiHidden { get; set; }

    [Column("di_kilitli")]
    public bool? DiKilitli { get; set; }

    [Column("di_degisti")]
    public bool? DiDegisti { get; set; }

    [Column("di_checksum")]
    public int? DiChecksum { get; set; }

    [Column("di_create_user")]
    public short? DiCreateUser { get; set; }

    [Column("di_create_date")]
    public DateTime? DiCreateDate { get; set; }

    [Column("di_lastup_user")]
    public short? DiLastupUser { get; set; }

    [Column("di_lastup_date")]
    public DateTime? DiLastupDate { get; set; }

    [Column("di_special1")]
    [StringLength(4)]
    public string? DiSpecial1 { get; set; }

    [Column("di_special2")]
    [StringLength(4)]
    public string? DiSpecial2 { get; set; }

    [Column("di_special3")]
    [StringLength(4)]
    public string? DiSpecial3 { get; set; }

    [Column("di_nosu")]
    [StringLength(25)]
    public string? DiNosu { get; set; }

    [Column("di_tarih")]
    public DateTime? DiTarih { get; set; }

    [Column("di_tipi")]
    public byte? DiTipi { get; set; }

    [Column("di_bitis_tarihi")]
    public DateTime? DiBitisTarihi { get; set; }
}
