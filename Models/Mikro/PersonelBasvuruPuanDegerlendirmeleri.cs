using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_basvuru_puan_degerlendirmeleri")]
public class PersonelBasvuruPuanDegerlendirmeleri
{
    [Column("bsd_Guid")]
    public Guid? BsdGuid { get; set; }

    [Column("bsd_DBCno")]
    public short? BsdDBCno { get; set; }

    [Column("bsd_SpecRECno")]
    public int? BsdSpecRECno { get; set; }

    [Column("bsd_iptal")]
    public bool? BsdIptal { get; set; }

    [Column("bsd_fileid")]
    public short? BsdFileid { get; set; }

    [Column("bsd_hidden")]
    public bool? BsdHidden { get; set; }

    [Column("bsd_kilitli")]
    public bool? BsdKilitli { get; set; }

    [Column("bsd_degisti")]
    public bool? BsdDegisti { get; set; }

    [Column("bsd_checksum")]
    public int? BsdChecksum { get; set; }

    [Column("bsd_create_user")]
    public short? BsdCreateUser { get; set; }

    [Column("bsd_create_date")]
    public DateTime? BsdCreateDate { get; set; }

    [Column("bsd_lastup_user")]
    public short? BsdLastupUser { get; set; }

    [Column("bsd_lastup_date")]
    public DateTime? BsdLastupDate { get; set; }

    [Column("bsd_special1")]
    [StringLength(4)]
    public string? BsdSpecial1 { get; set; }

    [Column("bsd_special2")]
    [StringLength(4)]
    public string? BsdSpecial2 { get; set; }

    [Column("bsd_special3")]
    [StringLength(4)]
    public string? BsdSpecial3 { get; set; }

    [Column("bsd_tarih")]
    public DateTime? BsdTarih { get; set; }

    [Column("bsd_per_kodu")]
    [StringLength(25)]
    public string? BsdPerKodu { get; set; }

    [Column("bsd_bas_uid")]
    public Guid? BsdBasUid { get; set; }

    [Column("bsd_puan_kodu")]
    [StringLength(25)]
    public string? BsdPuanKodu { get; set; }

    [Column("bsd_puan")]
    public double? BsdPuan { get; set; }

    [Column("bsd_aciklama")]
    [StringLength(80)]
    public string? BsdAciklama { get; set; }
}
