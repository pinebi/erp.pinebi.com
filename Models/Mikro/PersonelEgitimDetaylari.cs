using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitim_detaylari")]
public class PersonelEgitimDetaylari
{
    [Column("edet_Guid")]
    public Guid? EdetGuid { get; set; }

    [Column("edet_DBCno")]
    public short? EdetDBCno { get; set; }

    [Column("edet_SpecRECno")]
    public int? EdetSpecRECno { get; set; }

    [Column("edet_iptal")]
    public bool? EdetIptal { get; set; }

    [Column("edet_fileid")]
    public short? EdetFileid { get; set; }

    [Column("edet_hidden")]
    public bool? EdetHidden { get; set; }

    [Column("edet_kilitli")]
    public bool? EdetKilitli { get; set; }

    [Column("edet_degisti")]
    public bool? EdetDegisti { get; set; }

    [Column("edet_checksum")]
    public int? EdetChecksum { get; set; }

    [Column("edet_create_user")]
    public short? EdetCreateUser { get; set; }

    [Column("edet_create_date")]
    public DateTime? EdetCreateDate { get; set; }

    [Column("edet_lastup_user")]
    public short? EdetLastupUser { get; set; }

    [Column("edet_lastup_date")]
    public DateTime? EdetLastupDate { get; set; }

    [Column("edet_special1")]
    [StringLength(4)]
    public string? EdetSpecial1 { get; set; }

    [Column("edet_special2")]
    [StringLength(4)]
    public string? EdetSpecial2 { get; set; }

    [Column("edet_special3")]
    [StringLength(4)]
    public string? EdetSpecial3 { get; set; }

    [Column("edet_kodu")]
    [StringLength(25)]
    public string? EdetKodu { get; set; }

    [Column("edet_detaytipi")]
    public byte? EdetDetaytipi { get; set; }

    [Column("edet_satirno")]
    public int? EdetSatirno { get; set; }

    [Column("edet_hartipi")]
    public byte? EdetHartipi { get; set; }

    [Column("edet_harkodu")]
    [StringLength(25)]
    public string? EdetHarkodu { get; set; }

    [Column("edet_aciklama")]
    [StringLength(40)]
    public string? EdetAciklama { get; set; }

    [Column("edet_miktar")]
    public double? EdetMiktar { get; set; }

    [Column("edet_birim")]
    public byte? EdetBirim { get; set; }

    [Column("edet_tutar")]
    public double? EdetTutar { get; set; }

    [Column("edet_doviz_cinsi")]
    public byte? EdetDovizCinsi { get; set; }

    [Column("edet_doviz_kuru")]
    public double? EdetDovizKuru { get; set; }

    [Column("edet_aeg_evrakno_seri")]
    [StringLength(50)]
    public string? EdetAegEvraknoSeri { get; set; }

    [Column("edet_aeg_evrakno_sira")]
    public int? EdetAegEvraknoSira { get; set; }
}
