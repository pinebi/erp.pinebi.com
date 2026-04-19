using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("egitim_devam_kontrol")]
public class EgitimDevamKontrol
{
    [Column("dk_Guid")]
    public Guid? DkGuid { get; set; }

    [Column("dk_DBCno")]
    public short? DkDBCno { get; set; }

    [Column("dk_SpecRECno")]
    public int? DkSpecRECno { get; set; }

    [Column("dk_iptal")]
    public bool? DkIptal { get; set; }

    [Column("dk_fileid")]
    public short? DkFileid { get; set; }

    [Column("dk_hidden")]
    public bool? DkHidden { get; set; }

    [Column("dk_kilitli")]
    public bool? DkKilitli { get; set; }

    [Column("dk_degisti")]
    public bool? DkDegisti { get; set; }

    [Column("dk_checksum")]
    public int? DkChecksum { get; set; }

    [Column("dk_create_user")]
    public short? DkCreateUser { get; set; }

    [Column("dk_create_date")]
    public DateTime? DkCreateDate { get; set; }

    [Column("dk_lastup_user")]
    public short? DkLastupUser { get; set; }

    [Column("dk_lastup_date")]
    public DateTime? DkLastupDate { get; set; }

    [Column("dk_special1")]
    [StringLength(4)]
    public string? DkSpecial1 { get; set; }

    [Column("dk_special2")]
    [StringLength(4)]
    public string? DkSpecial2 { get; set; }

    [Column("dk_special3")]
    [StringLength(4)]
    public string? DkSpecial3 { get; set; }

    [Column("dk_evrakno_seri")]
    [StringLength(50)]
    public string? DkEvraknoSeri { get; set; }

    [Column("dk_evrakno_sira")]
    public int? DkEvraknoSira { get; set; }

    [Column("dk_satirno")]
    public int? DkSatirno { get; set; }

    [Column("dk_egitimkodu")]
    [StringLength(25)]
    public string? DkEgitimkodu { get; set; }

    [Column("dk_perskod")]
    [StringLength(25)]
    public string? DkPerskod { get; set; }

    [Column("dk_tarih")]
    public DateTime? DkTarih { get; set; }

    [Column("dk_girsaat")]
    public DateTime? DkGirsaat { get; set; }

    [Column("dk_ciksaat")]
    public DateTime? DkCiksaat { get; set; }

    [Column("dk_mazeret")]
    [StringLength(50)]
    public string? DkMazeret { get; set; }
}
