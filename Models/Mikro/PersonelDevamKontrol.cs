using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_devam_kontrol")]
public class PersonelDevamKontrol
{
    [Column("pdk_Guid")]
    public Guid? PdkGuid { get; set; }

    [Column("pdk_DBCno")]
    public short? PdkDBCno { get; set; }

    [Column("pdk_SpecRECno")]
    public int? PdkSpecRECno { get; set; }

    [Column("pdk_iptal")]
    public bool? PdkIptal { get; set; }

    [Column("pdk_fileid")]
    public short? PdkFileid { get; set; }

    [Column("pdk_hidden")]
    public bool? PdkHidden { get; set; }

    [Column("pdk_kilitli")]
    public bool? PdkKilitli { get; set; }

    [Column("pdk_degisti")]
    public bool? PdkDegisti { get; set; }

    [Column("pdk_checksum")]
    public int? PdkChecksum { get; set; }

    [Column("pdk_create_user")]
    public short? PdkCreateUser { get; set; }

    [Column("pdk_create_date")]
    public DateTime? PdkCreateDate { get; set; }

    [Column("pdk_lastup_user")]
    public short? PdkLastupUser { get; set; }

    [Column("pdk_lastup_date")]
    public DateTime? PdkLastupDate { get; set; }

    [Column("pdk_special1")]
    [StringLength(4)]
    public string? PdkSpecial1 { get; set; }

    [Column("pdk_special2")]
    [StringLength(4)]
    public string? PdkSpecial2 { get; set; }

    [Column("pdk_special3")]
    [StringLength(4)]
    public string? PdkSpecial3 { get; set; }

    [Column("pdk_kod")]
    [StringLength(25)]
    public string? PdkKod { get; set; }

    [Column("pdk_zaman")]
    public DateTime? PdkZaman { get; set; }

    [Column("pdk_tip")]
    public byte? PdkTip { get; set; }

    [Column("pdk_takvimkodu")]
    [StringLength(4)]
    public string? PdkTakvimkodu { get; set; }

    [Column("pdk_vardiyakodu")]
    [StringLength(25)]
    public string? PdkVardiyakodu { get; set; }

    [Column("pdk_vardiyano")]
    public byte? PdkVardiyano { get; set; }

    [Column("pdk_projekodu")]
    [StringLength(25)]
    public string? PdkProjekodu { get; set; }

    [Column("pdk_sormerkodu")]
    [StringLength(25)]
    public string? PdkSormerkodu { get; set; }

    [Column("pdk_nedenkodu")]
    [StringLength(25)]
    public string? PdkNedenkodu { get; set; }

    [Column("pdk_ismerkezikodu")]
    [StringLength(25)]
    public string? PdkIsmerkezikodu { get; set; }
}
