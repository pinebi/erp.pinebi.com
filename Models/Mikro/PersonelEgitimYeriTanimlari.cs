using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitim_yeri_tanimlari")]
public class PersonelEgitimYeriTanimlari
{
    [Column("pey_Guid")]
    public Guid? PeyGuid { get; set; }

    [Column("pey_DBCno")]
    public short? PeyDBCno { get; set; }

    [Column("pey_SpecRECno")]
    public int? PeySpecRECno { get; set; }

    [Column("pey_iptal")]
    public bool? PeyIptal { get; set; }

    [Column("pey_fileid")]
    public short? PeyFileid { get; set; }

    [Column("pey_hidden")]
    public bool? PeyHidden { get; set; }

    [Column("pey_kilitli")]
    public bool? PeyKilitli { get; set; }

    [Column("pey_degisti")]
    public bool? PeyDegisti { get; set; }

    [Column("pey_checksum")]
    public int? PeyChecksum { get; set; }

    [Column("pey_create_user")]
    public short? PeyCreateUser { get; set; }

    [Column("pey_create_date")]
    public DateTime? PeyCreateDate { get; set; }

    [Column("pey_lastup_user")]
    public short? PeyLastupUser { get; set; }

    [Column("pey_lastup_date")]
    public DateTime? PeyLastupDate { get; set; }

    [Column("pey_special1")]
    [StringLength(4)]
    public string? PeySpecial1 { get; set; }

    [Column("pey_special2")]
    [StringLength(4)]
    public string? PeySpecial2 { get; set; }

    [Column("pey_special3")]
    [StringLength(4)]
    public string? PeySpecial3 { get; set; }

    [Column("pey_kod")]
    [StringLength(25)]
    public string? PeyKod { get; set; }

    [Column("pey_adi")]
    [StringLength(40)]
    public string? PeyAdi { get; set; }

    [Column("pey_ucret")]
    public double? PeyUcret { get; set; }

    [Column("pey_doviz_cinsi")]
    public byte? PeyDovizCinsi { get; set; }

    [Column("pey_ucret_birimi")]
    public byte? PeyUcretBirimi { get; set; }

    [Column("pey_bagli_cari_kodu")]
    [StringLength(25)]
    public string? PeyBagliCariKodu { get; set; }
}
