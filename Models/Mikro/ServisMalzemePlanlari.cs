using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("servis_malzeme_planlari")]
public class ServisMalzemePlanlari
{
    [Column("smpl_Guid")]
    public Guid? SmplGuid { get; set; }

    [Column("smpl_DBCno")]
    public short? SmplDBCno { get; set; }

    [Column("smpl_SpecRECno")]
    public int? SmplSpecRECno { get; set; }

    [Column("smpl_iptal")]
    public bool? SmplIptal { get; set; }

    [Column("smpl_fileid")]
    public short? SmplFileid { get; set; }

    [Column("smpl_hidden")]
    public bool? SmplHidden { get; set; }

    [Column("smpl_kilitli")]
    public bool? SmplKilitli { get; set; }

    [Column("smpl_degisti")]
    public bool? SmplDegisti { get; set; }

    [Column("smpl_checksum")]
    public int? SmplChecksum { get; set; }

    [Column("smpl_create_user")]
    public short? SmplCreateUser { get; set; }

    [Column("smpl_create_date")]
    public DateTime? SmplCreateDate { get; set; }

    [Column("smpl_lastup_user")]
    public short? SmplLastupUser { get; set; }

    [Column("smpl_lastup_date")]
    public DateTime? SmplLastupDate { get; set; }

    [Column("smpl_special1")]
    [StringLength(4)]
    public string? SmplSpecial1 { get; set; }

    [Column("smpl_special2")]
    [StringLength(4)]
    public string? SmplSpecial2 { get; set; }

    [Column("smpl_special3")]
    [StringLength(4)]
    public string? SmplSpecial3 { get; set; }

    [Column("smpl_isemri_kodu")]
    [StringLength(25)]
    public string? SmplIsemriKodu { get; set; }

    [Column("smpl_satirno")]
    public int? SmplSatirno { get; set; }

    [Column("smpl_har_tarih")]
    public DateTime? SmplHarTarih { get; set; }

    [Column("smpl_malzeme_kodu")]
    [StringLength(25)]
    public string? SmplMalzemeKodu { get; set; }

    [Column("smpl_miktar")]
    public double? SmplMiktar { get; set; }

    [Column("smpl_tutar")]
    public double? SmplTutar { get; set; }

    [Column("smpl_iskonto")]
    public double? SmplIskonto { get; set; }

    [Column("smpl_aciklama")]
    [StringLength(80)]
    public string? SmplAciklama { get; set; }

    [Column("smpl_depono")]
    public int? SmplDepono { get; set; }

    [Column("smpl_garanti_dahili_fl")]
    public bool? SmplGarantiDahiliFl { get; set; }

    [Column("smpl_onaylandi_fl")]
    public bool? SmplOnaylandiFl { get; set; }
}
