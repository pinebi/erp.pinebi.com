using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_model_tanimlari")]
public class StokModelTanimlari
{
    [Column("mdl_Guid")]
    public Guid? MdlGuid { get; set; }

    [Column("mdl_DBCno")]
    public short? MdlDBCno { get; set; }

    [Column("mdl_SpecRECNo")]
    public int? MdlSpecRECNo { get; set; }

    [Column("mdl_iptal")]
    public bool? MdlIptal { get; set; }

    [Column("mdl_fileid")]
    public short? MdlFileid { get; set; }

    [Column("mdl_hidden")]
    public bool? MdlHidden { get; set; }

    [Column("mdl_kilitli")]
    public bool? MdlKilitli { get; set; }

    [Column("mdl_degisti")]
    public bool? MdlDegisti { get; set; }

    [Column("mdl_CheckSum")]
    public int? MdlCheckSum { get; set; }

    [Column("mdl_create_user")]
    public short? MdlCreateUser { get; set; }

    [Column("mdl_create_date")]
    public DateTime? MdlCreateDate { get; set; }

    [Column("mdl_lastup_user")]
    public short? MdlLastupUser { get; set; }

    [Column("mdl_lastup_date")]
    public DateTime? MdlLastupDate { get; set; }

    [Column("mdl_special1")]
    [StringLength(4)]
    public string? MdlSpecial1 { get; set; }

    [Column("mdl_special2")]
    [StringLength(4)]
    public string? MdlSpecial2 { get; set; }

    [Column("mdl_special3")]
    [StringLength(4)]
    public string? MdlSpecial3 { get; set; }

    [Column("mdl_kodu")]
    [StringLength(25)]
    public string? MdlKodu { get; set; }

    [Column("mdl_ismi")]
    [StringLength(40)]
    public string? MdlIsmi { get; set; }
}
