using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bagimsiz_bolum_tanimlari")]
public class BagimsizBolumTanimlari
{
    [Column("blm_Guid")]
    public Guid? BlmGuid { get; set; }

    [Column("blm_DBCno")]
    public short? BlmDBCno { get; set; }

    [Column("blm_SpecRECno")]
    public int? BlmSpecRECno { get; set; }

    [Column("blm_iptal")]
    public bool? BlmIptal { get; set; }

    [Column("blm_fileid")]
    public short? BlmFileid { get; set; }

    [Column("blm_hidden")]
    public bool? BlmHidden { get; set; }

    [Column("blm_kilitli")]
    public bool? BlmKilitli { get; set; }

    [Column("blm_degisti")]
    public bool? BlmDegisti { get; set; }

    [Column("blm_checksum")]
    public int? BlmChecksum { get; set; }

    [Column("blm_create_user")]
    public short? BlmCreateUser { get; set; }

    [Column("blm_create_date")]
    public DateTime? BlmCreateDate { get; set; }

    [Column("blm_lastup_user")]
    public short? BlmLastupUser { get; set; }

    [Column("blm_lastup_date")]
    public DateTime? BlmLastupDate { get; set; }

    [Column("blm_special1")]
    [StringLength(4)]
    public string? BlmSpecial1 { get; set; }

    [Column("blm_special2")]
    [StringLength(4)]
    public string? BlmSpecial2 { get; set; }

    [Column("blm_special3")]
    [StringLength(4)]
    public string? BlmSpecial3 { get; set; }

    [Column("blm_sitekod")]
    [StringLength(25)]
    public string? BlmSitekod { get; set; }

    [Column("blm_blokkod")]
    [StringLength(25)]
    public string? BlmBlokkod { get; set; }

    [Column("blm_katkod")]
    [StringLength(25)]
    public string? BlmKatkod { get; set; }

    [Column("blm_kod")]
    [StringLength(25)]
    public string? BlmKod { get; set; }

    [Column("blm_ismi")]
    [StringLength(50)]
    public string? BlmIsmi { get; set; }

    [Column("blm_acikkapali")]
    public byte? BlmAcikkapali { get; set; }

    [Column("blm_turu")]
    public byte? BlmTuru { get; set; }

    [Column("blm_iccephe")]
    public double? BlmIccephe { get; set; }

    [Column("blm_discephe")]
    public double? BlmDiscephe { get; set; }

    [Column("blm_vitrinsinifi")]
    public double? BlmVitrinsinifi { get; set; }

    [Column("blm_brutalan")]
    public double? BlmBrutalan { get; set; }

    [Column("blm_netalan")]
    public double? BlmNetalan { get; set; }

    [Column("blm_Cinsi")]
    public byte? BlmCinsi { get; set; }

    [Column("blm_KiraHizmetKodu")]
    [StringLength(25)]
    public string? BlmKiraHizmetKodu { get; set; }

    [Column("blm_OrtakGiderHizmetKodu")]
    [StringLength(25)]
    public string? BlmOrtakGiderHizmetKodu { get; set; }
}
