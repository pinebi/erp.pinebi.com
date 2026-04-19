using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_serbest_hareket")]
public class FirmaSerbestHareket
{
    [Column("sm_Guid")]
    public Guid? SmGuid { get; set; }

    [Column("sm_DBCno")]
    public short? SmDBCno { get; set; }

    [Column("sm_SpecRECno")]
    public int? SmSpecRECno { get; set; }

    [Column("sm_iptal")]
    public bool? SmIptal { get; set; }

    [Column("sm_fileid")]
    public short? SmFileid { get; set; }

    [Column("sm_hidden")]
    public bool? SmHidden { get; set; }

    [Column("sm_kilitli")]
    public bool? SmKilitli { get; set; }

    [Column("sm_degisti")]
    public bool? SmDegisti { get; set; }

    [Column("sm_checksum")]
    public int? SmChecksum { get; set; }

    [Column("sm_create_user")]
    public short? SmCreateUser { get; set; }

    [Column("sm_create_date")]
    public DateTime? SmCreateDate { get; set; }

    [Column("sm_lastup_user")]
    public short? SmLastupUser { get; set; }

    [Column("sm_lastup_date")]
    public DateTime? SmLastupDate { get; set; }

    [Column("sm_special1")]
    [StringLength(4)]
    public string? SmSpecial1 { get; set; }

    [Column("sm_special2")]
    [StringLength(4)]
    public string? SmSpecial2 { get; set; }

    [Column("sm_special3")]
    [StringLength(4)]
    public string? SmSpecial3 { get; set; }

    [Column("sm_tarih")]
    public DateTime? SmTarih { get; set; }

    [Column("sm_firmano")]
    public int? SmFirmano { get; set; }

    [Column("sm_EvrNo_seri")]
    [StringLength(50)]
    public string? SmEvrNoSeri { get; set; }

    [Column("sm_EvrNo_sira")]
    public int? SmEvrNoSira { get; set; }

    [Column("sm_IB")]
    public byte? SmIB { get; set; }

    [Column("sm_IM")]
    public byte? SmIM { get; set; }

    [Column("sm_pveren")]
    [StringLength(20)]
    public string? SmPveren { get; set; }

    [Column("sm_adr1")]
    [StringLength(127)]
    public string? SmAdr1 { get; set; }

    [Column("sm_adr2")]
    [StringLength(127)]
    public string? SmAdr2 { get; set; }

    [Column("sm_adr3")]
    [StringLength(127)]
    public string? SmAdr3 { get; set; }

    [Column("sm_HesapNo")]
    [StringLength(30)]
    public string? SmHesapNo { get; set; }

    [Column("sm_Brut")]
    public double? SmBrut { get; set; }

    [Column("sm_KDV")]
    public double? SmKDV { get; set; }

    [Column("sm_Stopaj")]
    public double? SmStopaj { get; set; }

    [Column("sm_SSDF")]
    public double? SmSSDF { get; set; }

    [Column("sm_Net")]
    public double? SmNet { get; set; }

    [Column("sm_VD")]
    [StringLength(10)]
    public string? SmVD { get; set; }

    [Column("sm_fistarih")]
    public DateTime? SmFistarih { get; set; }

    [Column("sm_fissirano")]
    public int? SmFissirano { get; set; }

    [Column("sm_Acik")]
    public bool? SmAcik { get; set; }

    [Column("sm_muhkodu")]
    [StringLength(25)]
    public string? SmMuhkodu { get; set; }

    [Column("sm_dbkodu")]
    [StringLength(25)]
    public string? SmDbkodu { get; set; }

    [Column("sm_tckimlikno")]
    [StringLength(15)]
    public string? SmTckimlikno { get; set; }

    [Column("sm_Tevkifat")]
    public double? SmTevkifat { get; set; }
}
