using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmkapi_tanimlari")]
public class AvmkapiTanimlari
{
    [Column("kapi_Guid")]
    public Guid? KapiGuid { get; set; }

    [Column("kapi_DBCno")]
    public short? KapiDBCno { get; set; }

    [Column("kapi_SpecRECno")]
    public int? KapiSpecRECno { get; set; }

    [Column("kapi_iptal")]
    public bool? KapiIptal { get; set; }

    [Column("kapi_fileid")]
    public short? KapiFileid { get; set; }

    [Column("kapi_hidden")]
    public bool? KapiHidden { get; set; }

    [Column("kapi_kilitli")]
    public bool? KapiKilitli { get; set; }

    [Column("kapi_degisti")]
    public bool? KapiDegisti { get; set; }

    [Column("kapi_checksum")]
    public int? KapiChecksum { get; set; }

    [Column("kapi_create_user")]
    public short? KapiCreateUser { get; set; }

    [Column("kapi_create_date")]
    public DateTime? KapiCreateDate { get; set; }

    [Column("kapi_lastup_user")]
    public short? KapiLastupUser { get; set; }

    [Column("kapi_lastup_date")]
    public DateTime? KapiLastupDate { get; set; }

    [Column("kapi_special1")]
    [StringLength(4)]
    public string? KapiSpecial1 { get; set; }

    [Column("kapi_special2")]
    [StringLength(4)]
    public string? KapiSpecial2 { get; set; }

    [Column("kapi_special3")]
    [StringLength(4)]
    public string? KapiSpecial3 { get; set; }

    [Column("kapi_sitekod")]
    [StringLength(25)]
    public string? KapiSitekod { get; set; }

    [Column("kapi_blokkod")]
    [StringLength(25)]
    public string? KapiBlokkod { get; set; }

    [Column("kapi_katkod")]
    [StringLength(25)]
    public string? KapiKatkod { get; set; }

    [Column("kapi_kod")]
    [StringLength(25)]
    public string? KapiKod { get; set; }

    [Column("kapi_ismi")]
    [StringLength(50)]
    public string? KapiIsmi { get; set; }

    [Column("kapi_turu")]
    public byte? KapiTuru { get; set; }
}
