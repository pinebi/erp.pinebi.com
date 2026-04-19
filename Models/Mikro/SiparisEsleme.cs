using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("siparis_esleme")]
public class SiparisEsleme
{
    [Column("se_Guid")]
    public Guid? SeGuid { get; set; }

    [Column("se_DBCno")]
    public short? SeDBCno { get; set; }

    [Column("se_SpecRECno")]
    public int? SeSpecRECno { get; set; }

    [Column("se_iptal")]
    public bool? SeIptal { get; set; }

    [Column("se_fileid")]
    public short? SeFileid { get; set; }

    [Column("se_hidden")]
    public bool? SeHidden { get; set; }

    [Column("se_kilitli")]
    public bool? SeKilitli { get; set; }

    [Column("se_degisti")]
    [StringLength(9)]
    public string? SeDegisti { get; set; }

    [Column("se_checksum")]
    public int? SeChecksum { get; set; }

    [Column("se_create_user")]
    public short? SeCreateUser { get; set; }

    [Column("se_create_date")]
    public DateTime? SeCreateDate { get; set; }

    [Column("se_lastup_user")]
    public short? SeLastupUser { get; set; }

    [Column("se_lastup_date")]
    public DateTime? SeLastupDate { get; set; }

    [Column("se_special1")]
    [StringLength(4)]
    public string? SeSpecial1 { get; set; }

    [Column("se_special2")]
    [StringLength(4)]
    public string? SeSpecial2 { get; set; }

    [Column("se_special3")]
    [StringLength(4)]
    public string? SeSpecial3 { get; set; }

    [Column("se_Talep_TabloId")]
    public byte? SeTalepTabloId { get; set; }

    [Column("se_Talep_uid")]
    public Guid? SeTalepUid { get; set; }

    [Column("se_Temin_TabloId")]
    public byte? SeTeminTabloId { get; set; }

    [Column("se_Temin_uid")]
    public Guid? SeTeminUid { get; set; }

    [Column("se_eslesen_miktar")]
    public double? SeEslesenMiktar { get; set; }

    [Column("se_aciklama")]
    [StringLength(80)]
    public string? SeAciklama { get; set; }

    [Column("se_teslim_miktar")]
    public double? SeTeslimMiktar { get; set; }

    [Column("se_kayit_tipi")]
    public byte? SeKayitTipi { get; set; }
}
