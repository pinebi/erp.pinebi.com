using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_performans_kriterleri")]
public class CariPerformansKriterleri
{
    [Column("cpk_Guid")]
    public Guid? CpkGuid { get; set; }

    [Column("cpk_DBCno")]
    public short? CpkDBCno { get; set; }

    [Column("cpk_SpecRECno")]
    public int? CpkSpecRECno { get; set; }

    [Column("cpk_iptal")]
    public bool? CpkIptal { get; set; }

    [Column("cpk_fileid")]
    public short? CpkFileid { get; set; }

    [Column("cpk_hidden")]
    public bool? CpkHidden { get; set; }

    [Column("cpk_kilitli")]
    public bool? CpkKilitli { get; set; }

    [Column("cpk_degisti")]
    public bool? CpkDegisti { get; set; }

    [Column("cpk_checksum")]
    public int? CpkChecksum { get; set; }

    [Column("cpk_create_user")]
    public short? CpkCreateUser { get; set; }

    [Column("cpk_create_date")]
    public DateTime? CpkCreateDate { get; set; }

    [Column("cpk_lastup_user")]
    public short? CpkLastupUser { get; set; }

    [Column("cpk_lastup_date")]
    public DateTime? CpkLastupDate { get; set; }

    [Column("cpk_special1")]
    [StringLength(4)]
    public string? CpkSpecial1 { get; set; }

    [Column("cpk_special2")]
    [StringLength(4)]
    public string? CpkSpecial2 { get; set; }

    [Column("cpk_special3")]
    [StringLength(4)]
    public string? CpkSpecial3 { get; set; }

    [Column("cpk_kodu")]
    [StringLength(25)]
    public string? CpkKodu { get; set; }

    [Column("cpk_adi")]
    [StringLength(40)]
    public string? CpkAdi { get; set; }

    [Column("cpk_aciklama1")]
    [StringLength(50)]
    public string? CpkAciklama1 { get; set; }

    [Column("cpk_aciklama2")]
    [StringLength(50)]
    public string? CpkAciklama2 { get; set; }

    [Column("cpk_aktif")]
    public byte? CpkAktif { get; set; }

    [Column("cpk_maxpuan")]
    public double? CpkMaxpuan { get; set; }

    [Column("cpk_toplamdakipayi")]
    public double? CpkToplamdakipayi { get; set; }

    [Column("cpk_sozelpuanlar")]
    [StringLength(127)]
    public string? CpkSozelpuanlar { get; set; }

    [Column("cpk_otoveritipi")]
    public byte? CpkOtoveritipi { get; set; }
}
