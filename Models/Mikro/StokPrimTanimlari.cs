using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_prim_tanimlari")]
public class StokPrimTanimlari
{
    [Column("prim_Guid")]
    public Guid? PrimGuid { get; set; }

    [Column("prim_DBCno")]
    public short? PrimDBCno { get; set; }

    [Column("prim_SpecRECno")]
    public int? PrimSpecRECno { get; set; }

    [Column("prim_iptal")]
    public bool? PrimIptal { get; set; }

    [Column("prim_fileid")]
    public short? PrimFileid { get; set; }

    [Column("prim_hidden")]
    public bool? PrimHidden { get; set; }

    [Column("prim_kilitli")]
    public bool? PrimKilitli { get; set; }

    [Column("prim_degisti")]
    public bool? PrimDegisti { get; set; }

    [Column("prim_checksum")]
    public int? PrimChecksum { get; set; }

    [Column("prim_create_user")]
    public short? PrimCreateUser { get; set; }

    [Column("prim_create_date")]
    public DateTime? PrimCreateDate { get; set; }

    [Column("prim_lastup_user")]
    public short? PrimLastupUser { get; set; }

    [Column("prim_lastup_date")]
    public DateTime? PrimLastupDate { get; set; }

    [Column("prim_special1")]
    [StringLength(4)]
    public string? PrimSpecial1 { get; set; }

    [Column("prim_special2")]
    [StringLength(4)]
    public string? PrimSpecial2 { get; set; }

    [Column("prim_special3")]
    [StringLength(4)]
    public string? PrimSpecial3 { get; set; }

    [Column("prim_kod")]
    [StringLength(25)]
    public string? PrimKod { get; set; }

    [Column("prim_adi")]
    [StringLength(40)]
    public string? PrimAdi { get; set; }

    [Column("prim_satirno")]
    public int? PrimSatirno { get; set; }

    [Column("prim_yuzdesi")]
    public double? PrimYuzdesi { get; set; }

    [Column("prim_min_isk")]
    public double? PrimMinIsk { get; set; }

    [Column("prim_max_isk")]
    public double? PrimMaxIsk { get; set; }

    [Column("prim_min_vade_sapma")]
    public int? PrimMinVadeSapma { get; set; }

    [Column("prim_max_vade_sapma")]
    public int? PrimMaxVadeSapma { get; set; }

    [Column("prim_hesap_sekli")]
    public byte? PrimHesapSekli { get; set; }

    [Column("prim_odemeye_bagli")]
    public bool? PrimOdemeyeBagli { get; set; }
}
