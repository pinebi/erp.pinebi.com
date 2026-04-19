using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("tcgb_ekkod_tanimlari")]
public class TcgbEkkodTanimlari
{
    [Column("ediek_Guid")]
    public Guid? EdiekGuid { get; set; }

    [Column("ediek_DBCno")]
    public short? EdiekDBCno { get; set; }

    [Column("ediek_SpecRECNo")]
    public int? EdiekSpecRECNo { get; set; }

    [Column("ediek_iptal")]
    public bool? EdiekIptal { get; set; }

    [Column("ediek_fileid")]
    public short? EdiekFileid { get; set; }

    [Column("ediek_hidden")]
    public bool? EdiekHidden { get; set; }

    [Column("ediek_kilitli")]
    public bool? EdiekKilitli { get; set; }

    [Column("ediek_degisti")]
    public bool? EdiekDegisti { get; set; }

    [Column("ediek_checksum")]
    public int? EdiekChecksum { get; set; }

    [Column("ediek_create_user")]
    public short? EdiekCreateUser { get; set; }

    [Column("ediek_create_date")]
    public DateTime? EdiekCreateDate { get; set; }

    [Column("ediek_lastup_user")]
    public short? EdiekLastupUser { get; set; }

    [Column("ediek_lastup_date")]
    public DateTime? EdiekLastupDate { get; set; }

    [Column("ediek_special1")]
    [StringLength(4)]
    public string? EdiekSpecial1 { get; set; }

    [Column("ediek_special2")]
    [StringLength(4)]
    public string? EdiekSpecial2 { get; set; }

    [Column("ediek_special3")]
    [StringLength(4)]
    public string? EdiekSpecial3 { get; set; }

    [Column("ediek_ekkodu")]
    [StringLength(4)]
    public string? EdiekEkkodu { get; set; }

    [Column("ediek_ekaciklama")]
    [StringLength(45)]
    public string? EdiekEkaciklama { get; set; }
}
