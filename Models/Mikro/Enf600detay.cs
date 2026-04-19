using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("enf600detay")]
public class Enf600detay
{
    [Column("e600_Guid")]
    public Guid? E600Guid { get; set; }

    [Column("e600_DBCno")]
    public short? E600DBCno { get; set; }

    [Column("e600_SpecRECNo")]
    public int? E600SpecRECNo { get; set; }

    [Column("e600_iptal")]
    public bool? E600Iptal { get; set; }

    [Column("e600_fileid")]
    public short? E600Fileid { get; set; }

    [Column("e600_hidden")]
    public bool? E600Hidden { get; set; }

    [Column("e600_kilitli")]
    public bool? E600Kilitli { get; set; }

    [Column("e600_degisti")]
    public bool? E600Degisti { get; set; }

    [Column("e600_checksum")]
    public int? E600Checksum { get; set; }

    [Column("e600_create_user")]
    public short? E600CreateUser { get; set; }

    [Column("e600_create_date")]
    public DateTime? E600CreateDate { get; set; }

    [Column("e600_lastup_user")]
    public short? E600LastupUser { get; set; }

    [Column("e600_lastup_date")]
    public DateTime? E600LastupDate { get; set; }

    [Column("e600_special1")]
    [StringLength(4)]
    public string? E600Special1 { get; set; }

    [Column("e600_special2")]
    [StringLength(4)]
    public string? E600Special2 { get; set; }

    [Column("e600_special3")]
    [StringLength(4)]
    public string? E600Special3 { get; set; }

    [Column("e600_hesapkodu")]
    [StringLength(25)]
    public string? E600Hesapkodu { get; set; }

    [Column("e600_endeks")]
    public double? E600Endeks { get; set; }

    [Column("e600_tutar")]
    public double? E600Tutar { get; set; }

    [Column("e600_duzeltilmis_tutar")]
    public double? E600DuzeltilmisTutar { get; set; }

    [Column("e600_parasal_pozisyona_etkisi")]
    public byte? E600ParasalPozisyonaEtkisi { get; set; }
}
