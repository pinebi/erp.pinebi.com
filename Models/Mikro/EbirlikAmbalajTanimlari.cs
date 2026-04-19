using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ebirlik_ambalaj_tanimlari")]
public class EbirlikAmbalajTanimlari
{
    [Column("ebramb_Guid")]
    public Guid? EbrambGuid { get; set; }

    [Column("ebramb_DBCno")]
    public short? EbrambDBCno { get; set; }

    [Column("ebramb_SpecRECNo")]
    public int? EbrambSpecRECNo { get; set; }

    [Column("ebramb_iptal")]
    public bool? EbrambIptal { get; set; }

    [Column("ebramb_fileid")]
    public short? EbrambFileid { get; set; }

    [Column("ebramb_hidden")]
    public bool? EbrambHidden { get; set; }

    [Column("ebramb_kilitli")]
    public bool? EbrambKilitli { get; set; }

    [Column("ebramb_degisti")]
    public bool? EbrambDegisti { get; set; }

    [Column("ebramb_checksum")]
    public int? EbrambChecksum { get; set; }

    [Column("ebramb_create_user")]
    public short? EbrambCreateUser { get; set; }

    [Column("ebramb_create_date")]
    public DateTime? EbrambCreateDate { get; set; }

    [Column("ebramb_lastup_user")]
    public short? EbrambLastupUser { get; set; }

    [Column("ebramb_lastup_date")]
    public DateTime? EbrambLastupDate { get; set; }

    [Column("ebramb_special1")]
    [StringLength(4)]
    public string? EbrambSpecial1 { get; set; }

    [Column("ebramb_special2")]
    [StringLength(4)]
    public string? EbrambSpecial2 { get; set; }

    [Column("ebramb_special3")]
    [StringLength(4)]
    public string? EbrambSpecial3 { get; set; }

    [Column("ebramb_kodu")]
    public short? EbrambKodu { get; set; }

    [Column("ebramb_aciklama")]
    [StringLength(25)]
    public string? EbrambAciklama { get; set; }
}
