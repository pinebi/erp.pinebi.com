using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_gruplari")]
public class CariHesapGruplari
{
    [Column("crg_Guid")]
    public Guid CrgGuid { get; set; }

    [Column("crg_DBCno")]
    public short? CrgDBCno { get; set; }

    [Column("crg_SpecRECNo")]
    public int? CrgSpecRECNo { get; set; }

    [Column("crg_iptal")]
    public bool? CrgIptal { get; set; }

    [Column("crg_fileid")]
    public short? CrgFileid { get; set; }

    [Column("crg_hidden")]
    public bool? CrgHidden { get; set; }

    [Column("crg_kilitli")]
    public bool? CrgKilitli { get; set; }

    [Column("crg_degisti")]
    public bool? CrgDegisti { get; set; }

    [Column("crg_CheckSum")]
    public int? CrgCheckSum { get; set; }

    [Column("crg_create_user")]
    public short? CrgCreateUser { get; set; }

    [Column("crg_create_date")]
    public DateTime? CrgCreateDate { get; set; }

    [Column("crg_lastup_user")]
    public short? CrgLastupUser { get; set; }

    [Column("crg_lastup_date")]
    public DateTime? CrgLastupDate { get; set; }

    [Column("crg_special1")]
    [StringLength(4)]
    public string? CrgSpecial1 { get; set; }

    [Column("crg_special2")]
    [StringLength(4)]
    public string? CrgSpecial2 { get; set; }

    [Column("crg_special3")]
    [StringLength(4)]
    public string? CrgSpecial3 { get; set; }

    [Column("crg_kod")]
    [StringLength(25)]
    public string CrgKod { get; set; }

    [Column("crg_isim")]
    [StringLength(40)]
    public string? CrgIsim { get; set; }

    [Column("crg_muhasebe_kodu")]
    [StringLength(4)]
    public string? CrgMuhasebeKodu { get; set; }
}
