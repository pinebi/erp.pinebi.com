using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isletme_hareket_detayi")]
public class IsletmeHareketDetayi
{
    [Column("dtfis_Guid")]
    public Guid? DtfisGuid { get; set; }

    [Column("dtfis_DBCno")]
    public short? DtfisDBCno { get; set; }

    [Column("dtfis_SpecRECno")]
    public int? DtfisSpecRECno { get; set; }

    [Column("dtfis_iptal")]
    public bool? DtfisIptal { get; set; }

    [Column("dtfis_fileid")]
    public short? DtfisFileid { get; set; }

    [Column("dtfis_hidden")]
    public bool? DtfisHidden { get; set; }

    [Column("dtfis_kilitli")]
    public bool? DtfisKilitli { get; set; }

    [Column("dtfis_degisti")]
    public bool? DtfisDegisti { get; set; }

    [Column("dtfis_checksum")]
    public int? DtfisChecksum { get; set; }

    [Column("dtfis_create_user")]
    public short? DtfisCreateUser { get; set; }

    [Column("dtfis_create_date")]
    public DateTime? DtfisCreateDate { get; set; }

    [Column("dtfis_lastup_user")]
    public short? DtfisLastupUser { get; set; }

    [Column("dtfis_lastup_date")]
    public DateTime? DtfisLastupDate { get; set; }

    [Column("dtfis_special1")]
    [StringLength(4)]
    public string? DtfisSpecial1 { get; set; }

    [Column("dtfis_special2")]
    [StringLength(4)]
    public string? DtfisSpecial2 { get; set; }

    [Column("dtfis_special3")]
    [StringLength(4)]
    public string? DtfisSpecial3 { get; set; }

    [Column("dtfis_har_uid")]
    public Guid? DtfisHarUid { get; set; }

    [Column("dtfis_satirno")]
    public int? DtfisSatirno { get; set; }

    [Column("dtfis_stok_ismi")]
    [StringLength(50)]
    public string? DtfisStokIsmi { get; set; }

    [Column("dtfis_aciklama")]
    [StringLength(50)]
    public string? DtfisAciklama { get; set; }

    [Column("dtfis_miktar")]
    public double? DtfisMiktar { get; set; }

    [Column("dtfis_tutar")]
    public double? DtfisTutar { get; set; }
}
