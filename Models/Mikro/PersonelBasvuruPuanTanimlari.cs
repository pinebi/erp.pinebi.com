using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_basvuru_puan_tanimlari")]
public class PersonelBasvuruPuanTanimlari
{
    [Column("bsp_Guid")]
    public Guid? BspGuid { get; set; }

    [Column("bsp_DBCno")]
    public short? BspDBCno { get; set; }

    [Column("bsp_SpecRECno")]
    public int? BspSpecRECno { get; set; }

    [Column("bsp_iptal")]
    public bool? BspIptal { get; set; }

    [Column("bsp_fileid")]
    public short? BspFileid { get; set; }

    [Column("bsp_hidden")]
    public bool? BspHidden { get; set; }

    [Column("bsp_kilitli")]
    public bool? BspKilitli { get; set; }

    [Column("bsp_degisti")]
    public bool? BspDegisti { get; set; }

    [Column("bsp_checksum")]
    public int? BspChecksum { get; set; }

    [Column("bsp_create_user")]
    public short? BspCreateUser { get; set; }

    [Column("bsp_create_date")]
    public DateTime? BspCreateDate { get; set; }

    [Column("bsp_lastup_user")]
    public short? BspLastupUser { get; set; }

    [Column("bsp_lastup_date")]
    public DateTime? BspLastupDate { get; set; }

    [Column("bsp_special1")]
    [StringLength(4)]
    public string? BspSpecial1 { get; set; }

    [Column("bsp_special2")]
    [StringLength(4)]
    public string? BspSpecial2 { get; set; }

    [Column("bsp_special3")]
    [StringLength(4)]
    public string? BspSpecial3 { get; set; }

    [Column("bsp_kodu")]
    [StringLength(25)]
    public string? BspKodu { get; set; }

    [Column("bsp_adi")]
    [StringLength(40)]
    public string? BspAdi { get; set; }

    [Column("bsp_maxpuan")]
    public double? BspMaxpuan { get; set; }

    [Column("bsp_agirlik")]
    public double? BspAgirlik { get; set; }
}
