using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_bolum_tanimlari")]
public class PersonelBolumTanimlari
{
    [Column("bl_Guid")]
    public Guid? BlGuid { get; set; }

    [Column("bl_DBCno")]
    public short? BlDBCno { get; set; }

    [Column("bl_SpecRECno")]
    public int? BlSpecRECno { get; set; }

    [Column("bl_iptal")]
    public bool? BlIptal { get; set; }

    [Column("bl_fileid")]
    public short? BlFileid { get; set; }

    [Column("bl_hidden")]
    public bool? BlHidden { get; set; }

    [Column("bl_kilitli")]
    public bool? BlKilitli { get; set; }

    [Column("bl_degisti")]
    public bool? BlDegisti { get; set; }

    [Column("bl_checksum")]
    public int? BlChecksum { get; set; }

    [Column("bl_create_user")]
    public short? BlCreateUser { get; set; }

    [Column("bl_create_date")]
    public DateTime? BlCreateDate { get; set; }

    [Column("bl_lastup_user")]
    public short? BlLastupUser { get; set; }

    [Column("bl_lastup_date")]
    public DateTime? BlLastupDate { get; set; }

    [Column("bl_special1")]
    [StringLength(4)]
    public string? BlSpecial1 { get; set; }

    [Column("bl_special2")]
    [StringLength(4)]
    public string? BlSpecial2 { get; set; }

    [Column("bl_special3")]
    [StringLength(4)]
    public string? BlSpecial3 { get; set; }

    [Column("bl_kod")]
    [StringLength(25)]
    public string? BlKod { get; set; }

    [Column("bl_adi")]
    [StringLength(60)]
    public string? BlAdi { get; set; }
}
