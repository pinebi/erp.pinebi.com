using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("edi_tcgb_olcu_birimleri")]
public class EdiTcgbOlcuBirimleri
{
    [Column("ediolc_Guid")]
    public Guid? EdiolcGuid { get; set; }

    [Column("ediolc_DBCno")]
    public short? EdiolcDBCno { get; set; }

    [Column("ediolc_SpecRECNo")]
    public int? EdiolcSpecRECNo { get; set; }

    [Column("ediolc_iptal")]
    public bool? EdiolcIptal { get; set; }

    [Column("ediolc_fileid")]
    public short? EdiolcFileid { get; set; }

    [Column("ediolc_hidden")]
    public bool? EdiolcHidden { get; set; }

    [Column("ediolc_kilitli")]
    public bool? EdiolcKilitli { get; set; }

    [Column("ediolc_degisti")]
    public bool? EdiolcDegisti { get; set; }

    [Column("ediolc_checksum")]
    public int? EdiolcChecksum { get; set; }

    [Column("ediolc_create_user")]
    public short? EdiolcCreateUser { get; set; }

    [Column("ediolc_create_date")]
    public DateTime? EdiolcCreateDate { get; set; }

    [Column("ediolc_lastup_user")]
    public short? EdiolcLastupUser { get; set; }

    [Column("ediolc_lastup_date")]
    public DateTime? EdiolcLastupDate { get; set; }

    [Column("ediolc_special1")]
    [StringLength(4)]
    public string? EdiolcSpecial1 { get; set; }

    [Column("ediolc_special2")]
    [StringLength(4)]
    public string? EdiolcSpecial2 { get; set; }

    [Column("ediolc_special3")]
    [StringLength(4)]
    public string? EdiolcSpecial3 { get; set; }

    [Column("ediolc_kodu")]
    [StringLength(4)]
    public string? EdiolcKodu { get; set; }

    [Column("ediolc_birimadi")]
    [StringLength(35)]
    public string? EdiolcBirimadi { get; set; }
}
