using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitmenleri")]
public class PersonelEgitmenleri
{
    [Column("egm_Guid")]
    public Guid? EgmGuid { get; set; }

    [Column("egm_DBCno")]
    public short? EgmDBCno { get; set; }

    [Column("egm_SpecRECno")]
    public int? EgmSpecRECno { get; set; }

    [Column("egm_iptal")]
    public bool? EgmIptal { get; set; }

    [Column("egm_fileid")]
    public short? EgmFileid { get; set; }

    [Column("egm_hidden")]
    public bool? EgmHidden { get; set; }

    [Column("egm_kilitli")]
    public bool? EgmKilitli { get; set; }

    [Column("egm_degisti")]
    public bool? EgmDegisti { get; set; }

    [Column("egm_checksum")]
    public int? EgmChecksum { get; set; }

    [Column("egm_create_user")]
    public short? EgmCreateUser { get; set; }

    [Column("egm_create_date")]
    public DateTime? EgmCreateDate { get; set; }

    [Column("egm_lastup_user")]
    public short? EgmLastupUser { get; set; }

    [Column("egm_lastup_date")]
    public DateTime? EgmLastupDate { get; set; }

    [Column("egm_special1")]
    [StringLength(4)]
    public string? EgmSpecial1 { get; set; }

    [Column("egm_special2")]
    [StringLength(4)]
    public string? EgmSpecial2 { get; set; }

    [Column("egm_special3")]
    [StringLength(4)]
    public string? EgmSpecial3 { get; set; }

    [Column("egm_kodu")]
    [StringLength(25)]
    public string? EgmKodu { get; set; }

    [Column("egm_adi")]
    [StringLength(40)]
    public string? EgmAdi { get; set; }

    [Column("egm_firma")]
    [StringLength(40)]
    public string? EgmFirma { get; set; }

    [Column("egm_bagli_cari_kodu")]
    [StringLength(25)]
    public string? EgmBagliCariKodu { get; set; }

    [Column("egm_bagli_pers_kodu")]
    [StringLength(25)]
    public string? EgmBagliPersKodu { get; set; }

    [Column("egm_tipi")]
    public byte? EgmTipi { get; set; }

    [Column("egm_mailadres")]
    [StringLength(50)]
    public string? EgmMailadres { get; set; }

    [Column("egm_Ucret")]
    public double? EgmUcret { get; set; }

    [Column("egm_Ucret_tipi")]
    public byte? EgmUcretTipi { get; set; }

    [Column("egm_doviz_cinsi")]
    public byte? EgmDovizCinsi { get; set; }

    [Column("egm_konu_kodu")]
    [StringLength(25)]
    public string? EgmKonuKodu { get; set; }
}
