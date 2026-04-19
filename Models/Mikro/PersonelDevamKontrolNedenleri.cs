using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_devam_kontrol_nedenleri")]
public class PersonelDevamKontrolNedenleri
{
    [Column("pdn_Guid")]
    public Guid? PdnGuid { get; set; }

    [Column("pdn_DBCno")]
    public short? PdnDBCno { get; set; }

    [Column("pdn_SpecRECno")]
    public int? PdnSpecRECno { get; set; }

    [Column("pdn_iptal")]
    public bool? PdnIptal { get; set; }

    [Column("pdn_fileid")]
    public short? PdnFileid { get; set; }

    [Column("pdn_hidden")]
    public bool? PdnHidden { get; set; }

    [Column("pdn_kilitli")]
    public bool? PdnKilitli { get; set; }

    [Column("pdn_degisti")]
    public bool? PdnDegisti { get; set; }

    [Column("pdn_checksum")]
    public int? PdnChecksum { get; set; }

    [Column("pdn_create_user")]
    public short? PdnCreateUser { get; set; }

    [Column("pdn_create_date")]
    public DateTime? PdnCreateDate { get; set; }

    [Column("pdn_lastup_user")]
    public short? PdnLastupUser { get; set; }

    [Column("pdn_lastup_date")]
    public DateTime? PdnLastupDate { get; set; }

    [Column("pdn_special1")]
    [StringLength(4)]
    public string? PdnSpecial1 { get; set; }

    [Column("pdn_special2")]
    [StringLength(4)]
    public string? PdnSpecial2 { get; set; }

    [Column("pdn_special3")]
    [StringLength(4)]
    public string? PdnSpecial3 { get; set; }

    [Column("pdn_neden_kodu")]
    [StringLength(25)]
    public string? PdnNedenKodu { get; set; }

    [Column("pdn_aciklama")]
    [StringLength(40)]
    public string? PdnAciklama { get; set; }
}
