using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_kalkon")]
public class StokKalkon
{
    [Column("skk_Guid")]
    public Guid? SkkGuid { get; set; }

    [Column("skk_DBCno")]
    public short? SkkDBCno { get; set; }

    [Column("skk_SpecRECno")]
    public int? SkkSpecRECno { get; set; }

    [Column("skk_iptal")]
    public bool? SkkIptal { get; set; }

    [Column("skk_fileid")]
    public short? SkkFileid { get; set; }

    [Column("skk_hidden")]
    public bool? SkkHidden { get; set; }

    [Column("skk_kilitli")]
    public bool? SkkKilitli { get; set; }

    [Column("skk_degisti")]
    public bool? SkkDegisti { get; set; }

    [Column("skk_checksum")]
    public int? SkkChecksum { get; set; }

    [Column("skk_create_user")]
    public short? SkkCreateUser { get; set; }

    [Column("skk_create_date")]
    public DateTime? SkkCreateDate { get; set; }

    [Column("skk_lastup_user")]
    public short? SkkLastupUser { get; set; }

    [Column("skk_lastup_date")]
    public DateTime? SkkLastupDate { get; set; }

    [Column("skk_special1")]
    [StringLength(4)]
    public string? SkkSpecial1 { get; set; }

    [Column("skk_special2")]
    [StringLength(4)]
    public string? SkkSpecial2 { get; set; }

    [Column("skk_special3")]
    [StringLength(4)]
    public string? SkkSpecial3 { get; set; }

    [Column("skk_tipi")]
    public byte? SkkTipi { get; set; }

    [Column("skk_kodu")]
    [StringLength(25)]
    public string? SkkKodu { get; set; }

    [Column("skk_olcadi1")]
    [StringLength(25)]
    public string? SkkOlcadi1 { get; set; }

    [Column("skk_olcmin1")]
    public double? SkkOlcmin1 { get; set; }

    [Column("skk_olcmax1")]
    public double? SkkOlcmax1 { get; set; }

    [Column("skk_olcideal1")]
    public double? SkkOlcideal1 { get; set; }

    [Column("skk_olcaciklama1")]
    [StringLength(25)]
    public string? SkkOlcaciklama1 { get; set; }

    [Column("skk_olcadi2")]
    [StringLength(25)]
    public string? SkkOlcadi2 { get; set; }

    [Column("skk_olcmin2")]
    public double? SkkOlcmin2 { get; set; }

    [Column("skk_olcmax2")]
    public double? SkkOlcmax2 { get; set; }

    [Column("skk_olcideal2")]
    public double? SkkOlcideal2 { get; set; }

    [Column("skk_olcaciklama2")]
    [StringLength(25)]
    public string? SkkOlcaciklama2 { get; set; }

    [Column("skk_olcadi3")]
    [StringLength(25)]
    public string? SkkOlcadi3 { get; set; }

    [Column("skk_olcmin3")]
    public double? SkkOlcmin3 { get; set; }

    [Column("skk_olcmax3")]
    public double? SkkOlcmax3 { get; set; }

    [Column("skk_olcideal3")]
    public double? SkkOlcideal3 { get; set; }

    [Column("skk_olcaciklama3")]
    [StringLength(25)]
    public string? SkkOlcaciklama3 { get; set; }

    [Column("skk_olcadi4")]
    [StringLength(25)]
    public string? SkkOlcadi4 { get; set; }

    [Column("skk_olcmin4")]
    public double? SkkOlcmin4 { get; set; }

    [Column("skk_olcmax4")]
    public double? SkkOlcmax4 { get; set; }

    [Column("skk_olcideal4")]
    public double? SkkOlcideal4 { get; set; }

    [Column("skk_olcaciklama4")]
    [StringLength(25)]
    public string? SkkOlcaciklama4 { get; set; }

    [Column("skk_olcadi5")]
    [StringLength(25)]
    public string? SkkOlcadi5 { get; set; }

    [Column("skk_olcmin5")]
    public double? SkkOlcmin5 { get; set; }

    [Column("skk_olcmax5")]
    public double? SkkOlcmax5 { get; set; }

    [Column("skk_olcideal5")]
    public double? SkkOlcideal5 { get; set; }

    [Column("skk_olcaciklama5")]
    [StringLength(25)]
    public string? SkkOlcaciklama5 { get; set; }

    [Column("skk_olcadi6")]
    [StringLength(25)]
    public string? SkkOlcadi6 { get; set; }

    [Column("skk_olcmin6")]
    public double? SkkOlcmin6 { get; set; }

    [Column("skk_olcmax6")]
    public double? SkkOlcmax6 { get; set; }

    [Column("skk_olcideal6")]
    public double? SkkOlcideal6 { get; set; }

    [Column("skk_olcaciklama6")]
    [StringLength(25)]
    public string? SkkOlcaciklama6 { get; set; }

    [Column("skk_olcadi7")]
    [StringLength(25)]
    public string? SkkOlcadi7 { get; set; }

    [Column("skk_olcmin7")]
    public double? SkkOlcmin7 { get; set; }

    [Column("skk_olcmax7")]
    public double? SkkOlcmax7 { get; set; }

    [Column("skk_olcideal7")]
    public double? SkkOlcideal7 { get; set; }

    [Column("skk_olcaciklama7")]
    [StringLength(25)]
    public string? SkkOlcaciklama7 { get; set; }

    [Column("skk_olcadi8")]
    [StringLength(25)]
    public string? SkkOlcadi8 { get; set; }

    [Column("skk_olcmin8")]
    public double? SkkOlcmin8 { get; set; }

    [Column("skk_olcmax8")]
    public double? SkkOlcmax8 { get; set; }

    [Column("skk_olcideal8")]
    public double? SkkOlcideal8 { get; set; }

    [Column("skk_olcaciklama8")]
    [StringLength(25)]
    public string? SkkOlcaciklama8 { get; set; }

    [Column("skk_olcadi9")]
    [StringLength(25)]
    public string? SkkOlcadi9 { get; set; }

    [Column("skk_olcmin9")]
    public double? SkkOlcmin9 { get; set; }

    [Column("skk_olcmax9")]
    public double? SkkOlcmax9 { get; set; }

    [Column("skk_olcideal9")]
    public double? SkkOlcideal9 { get; set; }

    [Column("skk_olcadi10")]
    [StringLength(25)]
    public string? SkkOlcadi10 { get; set; }

    [Column("skk_olcmin10")]
    public double? SkkOlcmin10 { get; set; }

    [Column("skk_olcmax10")]
    public double? SkkOlcmax10 { get; set; }

    [Column("skk_olcideal10")]
    public double? SkkOlcideal10 { get; set; }

    [Column("skk_olcaciklama10")]
    [StringLength(25)]
    public string? SkkOlcaciklama10 { get; set; }
}
