using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("atik_muhasebe_gruplari")]
public class AtikMuhasebeGruplari
{
    [Column("atkmuh_Guid")]
    public Guid? AtkmuhGuid { get; set; }

    [Column("atkmuh_DBCno")]
    public short? AtkmuhDBCno { get; set; }

    [Column("atkmuh_SpecRECno")]
    public int? AtkmuhSpecRECno { get; set; }

    [Column("atkmuh_iptal")]
    public bool? AtkmuhIptal { get; set; }

    [Column("atkmuh_fileid")]
    public short? AtkmuhFileid { get; set; }

    [Column("atkmuh_hidden")]
    public bool? AtkmuhHidden { get; set; }

    [Column("atkmuh_kilitli")]
    public bool? AtkmuhKilitli { get; set; }

    [Column("atkmuh_degisti")]
    public bool? AtkmuhDegisti { get; set; }

    [Column("atkmuh_checksum")]
    public int? AtkmuhChecksum { get; set; }

    [Column("atkmuh_create_user")]
    public short? AtkmuhCreateUser { get; set; }

    [Column("atkmuh_create_date")]
    public DateTime? AtkmuhCreateDate { get; set; }

    [Column("atkmuh_lastup_user")]
    public short? AtkmuhLastupUser { get; set; }

    [Column("atkmuh_lastup_date")]
    public DateTime? AtkmuhLastupDate { get; set; }

    [Column("atkmuh_special1")]
    [StringLength(4)]
    public string? AtkmuhSpecial1 { get; set; }

    [Column("atkmuh_special2")]
    [StringLength(4)]
    public string? AtkmuhSpecial2 { get; set; }

    [Column("atkmuh_special3")]
    [StringLength(4)]
    public string? AtkmuhSpecial3 { get; set; }

    [Column("atkmuh_kod")]
    [StringLength(25)]
    public string? AtkmuhKod { get; set; }

    [Column("atkmuh_ismi")]
    [StringLength(50)]
    public string? AtkmuhIsmi { get; set; }

    [Column("atkmuh_muh_kod")]
    [StringLength(40)]
    public string? AtkmuhMuhKod { get; set; }

    [Column("atkmuh_birik_amort_muh")]
    [StringLength(40)]
    public string? AtkmuhBirikAmortMuh { get; set; }

    [Column("atkmuh_ydf_muh_kod")]
    [StringLength(40)]
    public string? AtkmuhYdfMuhKod { get; set; }

    [Column("atkmuh_amorgider_muhkod")]
    [StringLength(40)]
    public string? AtkmuhAmorgiderMuhkod { get; set; }

    [Column("atkmuh_maliyet_artis_mu")]
    [StringLength(40)]
    public string? AtkmuhMaliyetArtisMu { get; set; }

    [Column("atkmuh_satis_kar_muhkod")]
    [StringLength(40)]
    public string? AtkmuhSatisKarMuhkod { get; set; }

    [Column("atkmuh_satis_zarar_muhk")]
    [StringLength(40)]
    public string? AtkmuhSatisZararMuhk { get; set; }

    [Column("atkmuh_yeni_fon_muhkodu")]
    [StringLength(40)]
    public string? AtkmuhYeniFonMuhkodu { get; set; }

    [Column("atkmuh_SermEkgmStsKaz_m")]
    [StringLength(40)]
    public string? AtkmuhSermEkgmStsKazM { get; set; }

    [Column("atkmuh_amorgidkar_muhkod")]
    [StringLength(40)]
    public string? AtkmuhAmorgidkarMuhkod { get; set; }

    [Column("atkmuh_yatirimtes_muhkod")]
    [StringLength(40)]
    public string? AtkmuhYatirimtesMuhkod { get; set; }

    [Column("atkmuh_amort_masraf_kodu")]
    [StringLength(25)]
    public string? AtkmuhAmortMasrafKodu { get; set; }

    [Column("atkmuh_ufrsfark_muh_kodu")]
    [StringLength(40)]
    public string? AtkmuhUfrsfarkMuhKodu { get; set; }

    [Column("atkmuh_birik_amort_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhBirikAmortUfrsfarkKodu { get; set; }

    [Column("atkmuh_yds_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhYdsUfrsfarkKodu { get; set; }

    [Column("atkmuh_amorgider_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhAmorgiderUfrsfarkKodu { get; set; }

    [Column("atkmuh_maliyet_artis_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhMaliyetArtisUfrsfarkKodu { get; set; }

    [Column("atkmuh_satis_kar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhSatisKarUfrsfarkKodu { get; set; }

    [Column("atkmuh_satis_zarar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhSatisZararUfrsfarkKodu { get; set; }

    [Column("atkmuh_yeni_fon_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhYeniFonUfrsfarkKodu { get; set; }

    [Column("atkmuh_SermEkgmStsKaz_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhSermEkgmStsKazUfrsfarkKodu { get; set; }

    [Column("atkmuh_amorgidkar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhAmorgidkarUfrsfarkKodu { get; set; }

    [Column("atkmuh_yatirimtes_ufrsfark_kodu")]
    [StringLength(40)]
    public string? AtkmuhYatirimtesUfrsfarkKodu { get; set; }
}
