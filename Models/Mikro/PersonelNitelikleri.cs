using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_nitelikleri")]
public class PersonelNitelikleri
{
    [Column("pn_Guid")]
    public Guid? PnGuid { get; set; }

    [Column("pn_DBCno")]
    public short? PnDBCno { get; set; }

    [Column("pn_SpecRECno")]
    public int? PnSpecRECno { get; set; }

    [Column("pn_iptal")]
    public bool? PnIptal { get; set; }

    [Column("pn_fileid")]
    public short? PnFileid { get; set; }

    [Column("pn_hidden")]
    public bool? PnHidden { get; set; }

    [Column("pn_kilitli")]
    public bool? PnKilitli { get; set; }

    [Column("pn_degisti")]
    public bool? PnDegisti { get; set; }

    [Column("pn_checksum")]
    public int? PnChecksum { get; set; }

    [Column("pn_create_user")]
    public short? PnCreateUser { get; set; }

    [Column("pn_create_date")]
    public DateTime? PnCreateDate { get; set; }

    [Column("pn_lastup_user")]
    public short? PnLastupUser { get; set; }

    [Column("pn_lastup_date")]
    public DateTime? PnLastupDate { get; set; }

    [Column("pn_special1")]
    [StringLength(4)]
    public string? PnSpecial1 { get; set; }

    [Column("pn_special2")]
    [StringLength(4)]
    public string? PnSpecial2 { get; set; }

    [Column("pn_special3")]
    [StringLength(4)]
    public string? PnSpecial3 { get; set; }

    [Column("pn_perskod")]
    [StringLength(25)]
    public string? PnPerskod { get; set; }

    [Column("pn_satirno")]
    public int? PnSatirno { get; set; }

    [Column("pn_nitelikkod")]
    [StringLength(25)]
    public string? PnNitelikkod { get; set; }

    [Column("pn_puan")]
    public double? PnPuan { get; set; }

    [Column("pn_sozelpuan")]
    public byte? PnSozelpuan { get; set; }
}
