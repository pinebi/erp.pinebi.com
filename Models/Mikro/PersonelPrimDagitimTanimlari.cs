using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_prim_dagitim_tanimlari")]
public class PersonelPrimDagitimTanimlari
{
    [Column("prprm_Guid")]
    public Guid? PrprmGuid { get; set; }

    [Column("prprm_DBCno")]
    public short? PrprmDBCno { get; set; }

    [Column("prprm_SpecRECno")]
    public int? PrprmSpecRECno { get; set; }

    [Column("prprm_iptal")]
    public bool? PrprmIptal { get; set; }

    [Column("prprm_fileid")]
    public short? PrprmFileid { get; set; }

    [Column("prprm_hidden")]
    public bool? PrprmHidden { get; set; }

    [Column("prprm_kilitli")]
    public bool? PrprmKilitli { get; set; }

    [Column("prprm_degisti")]
    public bool? PrprmDegisti { get; set; }

    [Column("prprm_checksum")]
    public int? PrprmChecksum { get; set; }

    [Column("prprm_create_user")]
    public short? PrprmCreateUser { get; set; }

    [Column("prprm_create_date")]
    public DateTime? PrprmCreateDate { get; set; }

    [Column("prprm_lastup_user")]
    public short? PrprmLastupUser { get; set; }

    [Column("prprm_lastup_date")]
    public DateTime? PrprmLastupDate { get; set; }

    [Column("prprm_special1")]
    [StringLength(4)]
    public string? PrprmSpecial1 { get; set; }

    [Column("prprm_special2")]
    [StringLength(4)]
    public string? PrprmSpecial2 { get; set; }

    [Column("prprm_special3")]
    [StringLength(4)]
    public string? PrprmSpecial3 { get; set; }

    [Column("prprm_per_kod")]
    [StringLength(25)]
    public string? PrprmPerKod { get; set; }

    [Column("prprm_dgt_yuzde1")]
    public double? PrprmDgtYuzde1 { get; set; }

    [Column("prprm_dgt_tip1")]
    public byte? PrprmDgtTip1 { get; set; }

    [Column("prprm_dgt_per_kod1")]
    [StringLength(25)]
    public string? PrprmDgtPerKod1 { get; set; }

    [Column("prprm_dgt_yuzde2")]
    public double? PrprmDgtYuzde2 { get; set; }

    [Column("prprm_dgt_tip2")]
    public byte? PrprmDgtTip2 { get; set; }

    [Column("prprm_dgt_per_kod2")]
    [StringLength(25)]
    public string? PrprmDgtPerKod2 { get; set; }

    [Column("prprm_dgt_yuzde3")]
    public double? PrprmDgtYuzde3 { get; set; }

    [Column("prprm_dgt_tip3")]
    public byte? PrprmDgtTip3 { get; set; }

    [Column("prprm_dgt_per_kod3")]
    [StringLength(25)]
    public string? PrprmDgtPerKod3 { get; set; }

    [Column("prprm_dgt_yuzde4")]
    public double? PrprmDgtYuzde4 { get; set; }

    [Column("prprm_dgt_tip4")]
    public byte? PrprmDgtTip4 { get; set; }

    [Column("prprm_dgt_per_kod4")]
    [StringLength(25)]
    public string? PrprmDgtPerKod4 { get; set; }

    [Column("prprm_dgt_yuzde5")]
    public double? PrprmDgtYuzde5 { get; set; }

    [Column("prprm_dgt_tip5")]
    public byte? PrprmDgtTip5 { get; set; }

    [Column("prprm_dgt_per_kod5")]
    [StringLength(25)]
    public string? PrprmDgtPerKod5 { get; set; }
}
