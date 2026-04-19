using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ceki_listesi")]
public class CekiListesi
{
    [Column("Ckl_Guid")]
    public Guid? CklGuid { get; set; }

    [Column("Ckl_DBCno")]
    public short? CklDBCno { get; set; }

    [Column("Ckl_SpecRECNo")]
    public int? CklSpecRECNo { get; set; }

    [Column("Ckl_iptal")]
    public bool? CklIptal { get; set; }

    [Column("Ckl_fileid")]
    public short? CklFileid { get; set; }

    [Column("Ckl_hidden")]
    public bool? CklHidden { get; set; }

    [Column("Ckl_kilitli")]
    public bool? CklKilitli { get; set; }

    [Column("Ckl_degisti")]
    public bool? CklDegisti { get; set; }

    [Column("Ckl_CheckSum")]
    public int? CklCheckSum { get; set; }

    [Column("Ckl_create_user")]
    public short? CklCreateUser { get; set; }

    [Column("Ckl_create_date")]
    public DateTime? CklCreateDate { get; set; }

    [Column("Ckl_lastup_user")]
    public short? CklLastupUser { get; set; }

    [Column("Ckl_lastup_date")]
    public DateTime? CklLastupDate { get; set; }

    [Column("Ckl_special1")]
    [StringLength(4)]
    public string? CklSpecial1 { get; set; }

    [Column("Ckl_special2")]
    [StringLength(4)]
    public string? CklSpecial2 { get; set; }

    [Column("Ckl_special3")]
    [StringLength(4)]
    public string? CklSpecial3 { get; set; }

    [Column("Ckl_EvrakTip")]
    public byte? CklEvrakTip { get; set; }

    [Column("Ckl_EvrakSeri")]
    [StringLength(50)]
    public string? CklEvrakSeri { get; set; }

    [Column("Ckl_EvrakSira")]
    public int? CklEvrakSira { get; set; }

    [Column("Ckl_StokKodu")]
    [StringLength(25)]
    public string? CklStokKodu { get; set; }

    [Column("Ckl_BedenPntr")]
    public byte? CklBedenPntr { get; set; }

    [Column("Ckl_Miktari")]
    public double? CklMiktari { get; set; }

    [Column("Ckl_AnaAmbalajNo")]
    public short? CklAnaAmbalajNo { get; set; }

    [Column("Ckl_AltAmbalajNo")]
    public short? CklAltAmbalajNo { get; set; }
}
