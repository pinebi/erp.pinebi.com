using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_talepleri")]
public class PersonelTalepleri
{
    [Column("tlp_Guid")]
    public Guid? TlpGuid { get; set; }

    [Column("tlp_DBCno")]
    public short? TlpDBCno { get; set; }

    [Column("tlp_SpecRECno")]
    public int? TlpSpecRECno { get; set; }

    [Column("tlp_iptal")]
    public bool? TlpIptal { get; set; }

    [Column("tlp_fileid")]
    public short? TlpFileid { get; set; }

    [Column("tlp_hidden")]
    public bool? TlpHidden { get; set; }

    [Column("tlp_kilitli")]
    public bool? TlpKilitli { get; set; }

    [Column("tlp_degisti")]
    public bool? TlpDegisti { get; set; }

    [Column("tlp_checksum")]
    public int? TlpChecksum { get; set; }

    [Column("tlp_create_user")]
    public short? TlpCreateUser { get; set; }

    [Column("tlp_create_date")]
    public DateTime? TlpCreateDate { get; set; }

    [Column("tlp_lastup_user")]
    public short? TlpLastupUser { get; set; }

    [Column("tlp_lastup_date")]
    public DateTime? TlpLastupDate { get; set; }

    [Column("tlp_special1")]
    [StringLength(4)]
    public string? TlpSpecial1 { get; set; }

    [Column("tlp_special2")]
    [StringLength(4)]
    public string? TlpSpecial2 { get; set; }

    [Column("tlp_special3")]
    [StringLength(4)]
    public string? TlpSpecial3 { get; set; }

    [Column("tlp_kodu")]
    [StringLength(25)]
    public string? TlpKodu { get; set; }

    [Column("tlp_adi")]
    [StringLength(40)]
    public string? TlpAdi { get; set; }

    [Column("tlp_tarih")]
    public DateTime? TlpTarih { get; set; }

    [Column("tlp_bitistarih")]
    public DateTime? TlpBitistarih { get; set; }

    [Column("tlp_grv_kodu")]
    [StringLength(25)]
    public string? TlpGrvKodu { get; set; }

    [Column("tlp_dpt_kodu")]
    [StringLength(25)]
    public string? TlpDptKodu { get; set; }

    [Column("tlp_eden_per_kodu")]
    [StringLength(25)]
    public string? TlpEdenPerKodu { get; set; }

    [Column("tlp_adet")]
    public short? TlpAdet { get; set; }

    [Column("tlp_durum")]
    public byte? TlpDurum { get; set; }

    [Column("tlp_aciklama1")]
    [StringLength(80)]
    public string? TlpAciklama1 { get; set; }

    [Column("tlp_aciklama2")]
    [StringLength(80)]
    public string? TlpAciklama2 { get; set; }

    [Column("tlp_aciklama3")]
    [StringLength(80)]
    public string? TlpAciklama3 { get; set; }

    [Column("tlp_aciklama4")]
    [StringLength(80)]
    public string? TlpAciklama4 { get; set; }

    [Column("tlp_aciklama5")]
    [StringLength(80)]
    public string? TlpAciklama5 { get; set; }

    [Column("tlp_kadro_kodu")]
    [StringLength(25)]
    public string? TlpKadroKodu { get; set; }

    [Column("tlp_nedeni")]
    public byte? TlpNedeni { get; set; }

    [Column("tlp_cinsiyet")]
    public byte? TlpCinsiyet { get; set; }

    [Column("tlp_medeni_hal")]
    public byte? TlpMedeniHal { get; set; }

    [Column("tlp_minyas")]
    public int? TlpMinyas { get; set; }

    [Column("tlp_maxyas")]
    public int? TlpMaxyas { get; set; }

    [Column("tlp_askerlik")]
    public byte? TlpAskerlik { get; set; }

    [Column("tlp_ehliyet")]
    public byte? TlpEhliyet { get; set; }

    [Column("tlp_tecrube")]
    public int? TlpTecrube { get; set; }

    [Column("tlp_dil_tipi")]
    public byte? TlpDilTipi { get; set; }

    [Column("tlp_dil_seviye")]
    public byte? TlpDilSeviye { get; set; }

    [Column("tlp_dil_konusma")]
    public byte? TlpDilKonusma { get; set; }

    [Column("tlp_ozurderecesi")]
    public byte? TlpOzurderecesi { get; set; }

    [Column("tlp_ozurgrubu")]
    public byte? TlpOzurgrubu { get; set; }
}
