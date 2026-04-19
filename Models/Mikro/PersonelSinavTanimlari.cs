using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sinav_tanimlari")]
public class PersonelSinavTanimlari
{
    [Column("snv_Guid")]
    public Guid? SnvGuid { get; set; }

    [Column("snv_DBCno")]
    public short? SnvDBCno { get; set; }

    [Column("snv_SpecRECno")]
    public int? SnvSpecRECno { get; set; }

    [Column("snv_iptal")]
    public bool? SnvIptal { get; set; }

    [Column("snv_fileid")]
    public short? SnvFileid { get; set; }

    [Column("snv_hidden")]
    public bool? SnvHidden { get; set; }

    [Column("snv_kilitli")]
    public bool? SnvKilitli { get; set; }

    [Column("snv_degisti")]
    public bool? SnvDegisti { get; set; }

    [Column("snv_checksum")]
    public int? SnvChecksum { get; set; }

    [Column("snv_create_user")]
    public short? SnvCreateUser { get; set; }

    [Column("snv_create_date")]
    public DateTime? SnvCreateDate { get; set; }

    [Column("snv_lastup_user")]
    public short? SnvLastupUser { get; set; }

    [Column("snv_lastup_date")]
    public DateTime? SnvLastupDate { get; set; }

    [Column("snv_special1")]
    [StringLength(4)]
    public string? SnvSpecial1 { get; set; }

    [Column("snv_special2")]
    [StringLength(4)]
    public string? SnvSpecial2 { get; set; }

    [Column("snv_special3")]
    [StringLength(4)]
    public string? SnvSpecial3 { get; set; }

    [Column("snv_kodu")]
    [StringLength(25)]
    public string? SnvKodu { get; set; }

    [Column("snv_adi")]
    [StringLength(40)]
    public string? SnvAdi { get; set; }

    [Column("snv_maxpuan")]
    public double? SnvMaxpuan { get; set; }

    [Column("snv_tipi")]
    public byte? SnvTipi { get; set; }

    [Column("snv_kapsam")]
    public byte? SnvKapsam { get; set; }

    [Column("snv_nitelik")]
    [StringLength(25)]
    public string? SnvNitelik { get; set; }

    [Column("snv_suresi")]
    public int? SnvSuresi { get; set; }
}
