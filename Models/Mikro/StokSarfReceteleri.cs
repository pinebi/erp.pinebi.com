using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_sarf_receteleri")]
public class StokSarfReceteleri
{
    [Column("sr_Guid")]
    public Guid? SrGuid { get; set; }

    [Column("sr_DBCno")]
    public short? SrDBCno { get; set; }

    [Column("sr_SpecRECno")]
    public int? SrSpecRECno { get; set; }

    [Column("sr_iptal")]
    public bool? SrIptal { get; set; }

    [Column("sr_fileid")]
    public short? SrFileid { get; set; }

    [Column("sr_hidden")]
    public bool? SrHidden { get; set; }

    [Column("sr_kilitli")]
    public bool? SrKilitli { get; set; }

    [Column("sr_degisti")]
    public bool? SrDegisti { get; set; }

    [Column("sr_checksum")]
    public int? SrChecksum { get; set; }

    [Column("sr_create_user")]
    public short? SrCreateUser { get; set; }

    [Column("sr_create_date")]
    public DateTime? SrCreateDate { get; set; }

    [Column("sr_lastup_user")]
    public short? SrLastupUser { get; set; }

    [Column("sr_lastup_date")]
    public DateTime? SrLastupDate { get; set; }

    [Column("sr_special1")]
    [StringLength(4)]
    public string? SrSpecial1 { get; set; }

    [Column("sr_special2")]
    [StringLength(4)]
    public string? SrSpecial2 { get; set; }

    [Column("sr_special3")]
    [StringLength(4)]
    public string? SrSpecial3 { get; set; }

    [Column("sr_anakod")]
    [StringLength(25)]
    public string? SrAnakod { get; set; }

    [Column("sr_tarih")]
    public DateTime? SrTarih { get; set; }

    [Column("sr_aciklama")]
    [StringLength(50)]
    public string? SrAciklama { get; set; }

    [Column("sr_anabirim")]
    public byte? SrAnabirim { get; set; }

    [Column("sr_anamiktar")]
    public double? SrAnamiktar { get; set; }

    [Column("sr_tuketim_kod")]
    [StringLength(25)]
    public string? SrTuketimKod { get; set; }

    [Column("sr_tuketim_miktar")]
    public double? SrTuketimMiktar { get; set; }

    [Column("sr_tuketim_birim")]
    public byte? SrTuketimBirim { get; set; }

    [Column("sr_satirno")]
    public int? SrSatirno { get; set; }

    [Column("sr_satir_acik")]
    [StringLength(50)]
    public string? SrSatirAcik { get; set; }

    [Column("sr_depono")]
    public byte? SrDepono { get; set; }

    [Column("sr_fireyuzde")]
    public double? SrFireyuzde { get; set; }

    [Column("sr_parti_miktari")]
    public double? SrPartiMiktari { get; set; }

    [Column("sr_recetecinsi")]
    public byte? SrRecetecinsi { get; set; }
}
