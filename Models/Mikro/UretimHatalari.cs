using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_hatalari")]
public class UretimHatalari
{
    [Column("uh_Guid")]
    public Guid? UhGuid { get; set; }

    [Column("uh_DBCno")]
    public short? UhDBCno { get; set; }

    [Column("uh_SpecRECNo")]
    public int? UhSpecRECNo { get; set; }

    [Column("uh_iptal")]
    public bool? UhIptal { get; set; }

    [Column("uh_fileid")]
    public short? UhFileid { get; set; }

    [Column("uh_hidden")]
    public bool? UhHidden { get; set; }

    [Column("uh_kilitli")]
    public bool? UhKilitli { get; set; }

    [Column("uh_degisti")]
    public bool? UhDegisti { get; set; }

    [Column("uh_CheckSum")]
    public int? UhCheckSum { get; set; }

    [Column("uh_create_user")]
    public short? UhCreateUser { get; set; }

    [Column("uh_create_date")]
    public DateTime? UhCreateDate { get; set; }

    [Column("uh_lastup_user")]
    public short? UhLastupUser { get; set; }

    [Column("uh_lastup_date")]
    public DateTime? UhLastupDate { get; set; }

    [Column("uh_special1")]
    [StringLength(4)]
    public string? UhSpecial1 { get; set; }

    [Column("uh_special2")]
    [StringLength(4)]
    public string? UhSpecial2 { get; set; }

    [Column("uh_special3")]
    [StringLength(4)]
    public string? UhSpecial3 { get; set; }

    [Column("uh_kod")]
    [StringLength(25)]
    public string? UhKod { get; set; }

    [Column("uh_aciklama")]
    [StringLength(40)]
    public string? UhAciklama { get; set; }
}
