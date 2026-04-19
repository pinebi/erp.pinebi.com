using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_yetki_tanimlari")]
public class PersonelYetkiTanimlari
{
    [Column("yt_Guid")]
    public Guid? YtGuid { get; set; }

    [Column("yt_DBCno")]
    public short? YtDBCno { get; set; }

    [Column("yt_SpecRECno")]
    public int? YtSpecRECno { get; set; }

    [Column("yt_iptal")]
    public bool? YtIptal { get; set; }

    [Column("yt_fileid")]
    public short? YtFileid { get; set; }

    [Column("yt_hidden")]
    public bool? YtHidden { get; set; }

    [Column("yt_kilitli")]
    public bool? YtKilitli { get; set; }

    [Column("yt_degisti")]
    public bool? YtDegisti { get; set; }

    [Column("yt_checksum")]
    public int? YtChecksum { get; set; }

    [Column("yt_create_user")]
    public short? YtCreateUser { get; set; }

    [Column("yt_create_date")]
    public DateTime? YtCreateDate { get; set; }

    [Column("yt_lastup_user")]
    public short? YtLastupUser { get; set; }

    [Column("yt_lastup_date")]
    public DateTime? YtLastupDate { get; set; }

    [Column("yt_special1")]
    [StringLength(4)]
    public string? YtSpecial1 { get; set; }

    [Column("yt_special2")]
    [StringLength(4)]
    public string? YtSpecial2 { get; set; }

    [Column("yt_special3")]
    [StringLength(4)]
    public string? YtSpecial3 { get; set; }

    [Column("yt_kod")]
    [StringLength(25)]
    public string? YtKod { get; set; }

    [Column("yt_aciklama")]
    [StringLength(40)]
    public string? YtAciklama { get; set; }
}
