using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ufrs_cari_hareket_degerleri")]
public class UfrsCariHareketDegerleri
{
    [Column("uchd_Guid")]
    public Guid? UchdGuid { get; set; }

    [Column("uchd_DBCno")]
    public short? UchdDBCno { get; set; }

    [Column("uchd_SpecRECno")]
    public int? UchdSpecRECno { get; set; }

    [Column("uchd_iptal")]
    public bool? UchdIptal { get; set; }

    [Column("uchd_fileid")]
    public short? UchdFileid { get; set; }

    [Column("uchd_hidden")]
    public bool? UchdHidden { get; set; }

    [Column("uchd_kilitli")]
    public bool? UchdKilitli { get; set; }

    [Column("uchd_degisti")]
    public bool? UchdDegisti { get; set; }

    [Column("uchd_checksum")]
    public int? UchdChecksum { get; set; }

    [Column("uchd_create_user")]
    public short? UchdCreateUser { get; set; }

    [Column("uchd_create_date")]
    public DateTime? UchdCreateDate { get; set; }

    [Column("uchd_lastup_user")]
    public short? UchdLastupUser { get; set; }

    [Column("uchd_lastup_date")]
    public DateTime? UchdLastupDate { get; set; }

    [Column("uchd_special1")]
    [StringLength(4)]
    public string? UchdSpecial1 { get; set; }

    [Column("uchd_special2")]
    [StringLength(4)]
    public string? UchdSpecial2 { get; set; }

    [Column("uchd_special3")]
    [StringLength(4)]
    public string? UchdSpecial3 { get; set; }

    [Column("uchd_baglihar_uid")]
    public Guid? UchdBagliharUid { get; set; }

    [Column("uchd_aratoplam")]
    public double? UchdAratoplam { get; set; }

    [Column("uchd_meblag")]
    public double? UchdMeblag { get; set; }

    [Column("uchd_iskonto1")]
    public double? UchdIskonto1 { get; set; }

    [Column("uchd_iskonto2")]
    public double? UchdIskonto2 { get; set; }

    [Column("uchd_iskonto3")]
    public double? UchdIskonto3 { get; set; }

    [Column("uchd_iskonto4")]
    public double? UchdIskonto4 { get; set; }

    [Column("uchd_iskonto5")]
    public double? UchdIskonto5 { get; set; }

    [Column("uchd_iskonto6")]
    public double? UchdIskonto6 { get; set; }

    [Column("uchd_masraf1")]
    public double? UchdMasraf1 { get; set; }

    [Column("uchd_masraf2")]
    public double? UchdMasraf2 { get; set; }

    [Column("uchd_masraf3")]
    public double? UchdMasraf3 { get; set; }

    [Column("uchd_masraf4")]
    public double? UchdMasraf4 { get; set; }

    [Column("uchd_degerfarki")]
    public double? UchdDegerfarki { get; set; }

    [Column("uchd_entegre_olmasin_fl")]
    public bool? UchdEntegreOlmasinFl { get; set; }
}
