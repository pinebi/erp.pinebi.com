using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("edi_tcgb_kalemleri")]
public class EdiTcgbKalemleri
{
    [Column("est_Guid")]
    public Guid? EstGuid { get; set; }

    [Column("est_DBCno")]
    public short? EstDBCno { get; set; }

    [Column("est_SpecRECno")]
    public int? EstSpecRECno { get; set; }

    [Column("est_iptal")]
    public bool? EstIptal { get; set; }

    [Column("est_fileid")]
    public short? EstFileid { get; set; }

    [Column("est_hidden")]
    public bool? EstHidden { get; set; }

    [Column("est_kilitli")]
    public bool? EstKilitli { get; set; }

    [Column("est_degisti")]
    public bool? EstDegisti { get; set; }

    [Column("est_checksum")]
    public int? EstChecksum { get; set; }

    [Column("est_create_user")]
    public short? EstCreateUser { get; set; }

    [Column("est_create_date")]
    public DateTime? EstCreateDate { get; set; }

    [Column("est_lastup_user")]
    public short? EstLastupUser { get; set; }

    [Column("est_lastup_date")]
    public DateTime? EstLastupDate { get; set; }

    [Column("est_special1")]
    [StringLength(4)]
    public string? EstSpecial1 { get; set; }

    [Column("est_special2")]
    [StringLength(4)]
    public string? EstSpecial2 { get; set; }

    [Column("est_special3")]
    [StringLength(4)]
    public string? EstSpecial3 { get; set; }

    [Column("est_Har_uid")]
    public Guid? EstHarUid { get; set; }

    [Column("est_kalemkodu")]
    [StringLength(25)]
    public string? EstKalemkodu { get; set; }

    [Column("est_olcukod")]
    [StringLength(4)]
    public string? EstOlcukod { get; set; }

    [Column("est_kapcinsi")]
    [StringLength(5)]
    public string? EstKapcinsi { get; set; }

    [Column("est_kapnumarasi")]
    [StringLength(15)]
    public string? EstKapnumarasi { get; set; }

    [Column("est_kapadedi")]
    public double? EstKapadedi { get; set; }

    [Column("est_kapmarkasi")]
    [StringLength(30)]
    public string? EstKapmarkasi { get; set; }

    [Column("est_odemeadresi")]
    public int? EstOdemeadresi { get; set; }

    [Column("est_imalatci")]
    [StringLength(25)]
    public string? EstImalatci { get; set; }

    [Column("est_muafiyetkod1")]
    [StringLength(25)]
    public string? EstMuafiyetkod1 { get; set; }

    [Column("est_muafiyetref1")]
    [StringLength(12)]
    public string? EstMuafiyetref1 { get; set; }

    [Column("est_muafiyetaciklama1")]
    [StringLength(30)]
    public string? EstMuafiyetaciklama1 { get; set; }

    [Column("est_muafiyetkod2")]
    [StringLength(25)]
    public string? EstMuafiyetkod2 { get; set; }

    [Column("est_muafiyetref2")]
    [StringLength(12)]
    public string? EstMuafiyetref2 { get; set; }

    [Column("est_muafiyetaciklama2")]
    [StringLength(30)]
    public string? EstMuafiyetaciklama2 { get; set; }

    [Column("est_muafiyetkod3")]
    [StringLength(25)]
    public string? EstMuafiyetkod3 { get; set; }

    [Column("est_muafiyetref3")]
    [StringLength(12)]
    public string? EstMuafiyetref3 { get; set; }

    [Column("est_muafiyetaciklama3")]
    [StringLength(30)]
    public string? EstMuafiyetaciklama3 { get; set; }

    [Column("est_ekbelkod1")]
    public short? EstEkbelkod1 { get; set; }

    [Column("est_ekbelreferansno1")]
    [StringLength(12)]
    public string? EstEkbelreferansno1 { get; set; }

    [Column("est_ekbelaciklama1")]
    [StringLength(30)]
    public string? EstEkbelaciklama1 { get; set; }

    [Column("est_ekbelkod2")]
    public short? EstEkbelkod2 { get; set; }

    [Column("est_ekbelreferansno2")]
    [StringLength(12)]
    public string? EstEkbelreferansno2 { get; set; }

    [Column("est_ekbelaciklama2")]
    [StringLength(30)]
    public string? EstEkbelaciklama2 { get; set; }

    [Column("est_ekbelkod3")]
    public short? EstEkbelkod3 { get; set; }

    [Column("est_ekbelreferansno3")]
    [StringLength(12)]
    public string? EstEkbelreferansno3 { get; set; }

    [Column("est_ekbelaciklama3")]
    [StringLength(30)]
    public string? EstEkbelaciklama3 { get; set; }

    [Column("est_ekbelkod4")]
    public short? EstEkbelkod4 { get; set; }

    [Column("est_ekbelreferansno4")]
    [StringLength(12)]
    public string? EstEkbelreferansno4 { get; set; }

    [Column("est_ekbelaciklama4")]
    [StringLength(30)]
    public string? EstEkbelaciklama4 { get; set; }

    [Column("est_ekbelkod5")]
    public short? EstEkbelkod5 { get; set; }

    [Column("est_ekbelreferansno5")]
    [StringLength(12)]
    public string? EstEkbelreferansno5 { get; set; }

    [Column("est_ekbelaciklama5")]
    [StringLength(30)]
    public string? EstEkbelaciklama5 { get; set; }

    [Column("est_dogrulama1")]
    public bool? EstDogrulama1 { get; set; }

    [Column("est_dogrulama2")]
    public bool? EstDogrulama2 { get; set; }

    [Column("est_dogrulama3")]
    public bool? EstDogrulama3 { get; set; }

    [Column("est_dogrulama4")]
    public bool? EstDogrulama4 { get; set; }

    [Column("est_dogrulama5")]
    public bool? EstDogrulama5 { get; set; }

    [Column("est_dogrulama6")]
    public bool? EstDogrulama6 { get; set; }

    [Column("est_dogrulama7")]
    public bool? EstDogrulama7 { get; set; }

    [Column("est_dogrulama8")]
    public bool? EstDogrulama8 { get; set; }

    [Column("est_kotakodu")]
    [StringLength(10)]
    public string? EstKotakodu { get; set; }

    [Column("est_ekkod")]
    [StringLength(4)]
    public string? EstEkkod { get; set; }

    [Column("est_istatislikkiymet")]
    public double? EstIstatislikkiymet { get; set; }

    [Column("est_ebirlikambalajkod")]
    public short? EstEbirlikambalajkod { get; set; }

    [Column("est_ebirlik_iplikkodu")]
    [StringLength(5)]
    public string? EstEbirlikIplikkodu { get; set; }

    [Column("est_bedelsiz")]
    public bool? EstBedelsiz { get; set; }

    [Column("est_beyannameno")]
    [StringLength(30)]
    public string? EstBeyannameno { get; set; }

    [Column("est_beyannametarihi")]
    public DateTime? EstBeyannametarihi { get; set; }

    [Column("est_beyannameSirano")]
    [StringLength(15)]
    public string? EstBeyannameSirano { get; set; }
}
