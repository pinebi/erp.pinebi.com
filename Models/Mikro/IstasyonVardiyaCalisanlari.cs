using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_vardiya_calisanlari")]
public class IstasyonVardiyaCalisanlari
{
    [Column("vc_Guid")]
    public Guid? VcGuid { get; set; }

    [Column("vc_DBCno")]
    public short? VcDBCno { get; set; }

    [Column("vc_SpecRECno")]
    public int? VcSpecRECno { get; set; }

    [Column("vc_iptal")]
    public bool? VcIptal { get; set; }

    [Column("vc_fileid")]
    public short? VcFileid { get; set; }

    [Column("vc_hidden")]
    public bool? VcHidden { get; set; }

    [Column("vc_kilitli")]
    public bool? VcKilitli { get; set; }

    [Column("vc_degisti")]
    public bool? VcDegisti { get; set; }

    [Column("vc_checksum")]
    public int? VcChecksum { get; set; }

    [Column("vc_create_user")]
    public short? VcCreateUser { get; set; }

    [Column("vc_create_date")]
    public DateTime? VcCreateDate { get; set; }

    [Column("vc_lastup_user")]
    public short? VcLastupUser { get; set; }

    [Column("vc_lastup_date")]
    public DateTime? VcLastupDate { get; set; }

    [Column("vc_special1")]
    [StringLength(4)]
    public string? VcSpecial1 { get; set; }

    [Column("vc_special2")]
    [StringLength(4)]
    public string? VcSpecial2 { get; set; }

    [Column("vc_special3")]
    [StringLength(4)]
    public string? VcSpecial3 { get; set; }

    [Column("vc_firmano")]
    public int? VcFirmano { get; set; }

    [Column("vc_subeno")]
    public int? VcSubeno { get; set; }

    [Column("vc_vardiyahesaptip")]
    public byte? VcVardiyahesaptip { get; set; }

    [Column("vc_Tarihi")]
    public DateTime? VcTarihi { get; set; }

    [Column("vc_Numarasi")]
    public byte? VcNumarasi { get; set; }

    [Column("vc_pers_kodu")]
    [StringLength(10)]
    public string? VcPersKodu { get; set; }

    [Column("vc_Acik_Kapali")]
    public byte? VcAcikKapali { get; set; }

    [Column("vc_ortak_pers_1")]
    [StringLength(25)]
    public string? VcOrtakPers1 { get; set; }

    [Column("vc_ortak_pers_2")]
    [StringLength(25)]
    public string? VcOrtakPers2 { get; set; }

    [Column("vc_ortak_pers_3")]
    [StringLength(25)]
    public string? VcOrtakPers3 { get; set; }

    [Column("vc_ortak_pers_4")]
    [StringLength(25)]
    public string? VcOrtakPers4 { get; set; }

    [Column("vc_ortak_pers_5")]
    [StringLength(25)]
    public string? VcOrtakPers5 { get; set; }

    [Column("vc_ortak_pers_6")]
    [StringLength(25)]
    public string? VcOrtakPers6 { get; set; }

    [Column("vc_ortak_pers_7")]
    [StringLength(25)]
    public string? VcOrtakPers7 { get; set; }

    [Column("vc_ortak_pers_8")]
    [StringLength(25)]
    public string? VcOrtakPers8 { get; set; }

    [Column("vc_ortak_pers_9")]
    [StringLength(25)]
    public string? VcOrtakPers9 { get; set; }

    [Column("vc_ortak_pers_10")]
    [StringLength(25)]
    public string? VcOrtakPers10 { get; set; }
}
