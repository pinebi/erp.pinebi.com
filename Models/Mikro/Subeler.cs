using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("subeler")]
public class Subeler
{
    [Column("Sube_Guid")]
    public Guid? SubeGuid { get; set; }

    [Column("Sube_DBCno")]
    public short? SubeDBCno { get; set; }

    [Column("Sube_SpecRECno")]
    public int? SubeSpecRECno { get; set; }

    [Column("Sube_iptal")]
    public bool? SubeIptal { get; set; }

    [Column("Sube_fileid")]
    public short? SubeFileid { get; set; }

    [Column("Sube_hidden")]
    public bool? SubeHidden { get; set; }

    [Column("Sube_kilitli")]
    public bool? SubeKilitli { get; set; }

    [Column("Sube_degisti")]
    public bool? SubeDegisti { get; set; }

    [Column("Sube_checksum")]
    public int? SubeChecksum { get; set; }

    [Column("Sube_create_user")]
    public short? SubeCreateUser { get; set; }

    [Column("Sube_create_date")]
    public DateTime? SubeCreateDate { get; set; }

    [Column("Sube_lastup_user")]
    public short? SubeLastupUser { get; set; }

    [Column("Sube_lastup_date")]
    public DateTime? SubeLastupDate { get; set; }

    [Column("Sube_special1")]
    [StringLength(4)]
    public string? SubeSpecial1 { get; set; }

    [Column("Sube_special2")]
    [StringLength(4)]
    public string? SubeSpecial2 { get; set; }

    [Column("Sube_special3")]
    [StringLength(4)]
    public string? SubeSpecial3 { get; set; }

    [Column("Sube_bag_firma")]
    public int? SubeBagFirma { get; set; }

    [Column("Sube_no")]
    public int? SubeNo { get; set; }

    [Column("Sube_adi")]
    [StringLength(50)]
    public string? SubeAdi { get; set; }

    [Column("Sube_kodu")]
    [StringLength(15)]
    public string? SubeKodu { get; set; }

    [Column("Sube_MersisNo")]
    [StringLength(25)]
    public string? SubeMersisNo { get; set; }

    [Column("sube_muhgrupkodu")]
    [StringLength(10)]
    public string? SubeMuhgrupkodu { get; set; }

    [Column("sube_muhasebelesmeye")]
    public bool? SubeMuhasebelesmeye { get; set; }

    [Column("sube_Mn_muhfserino")]
    [StringLength(50)]
    public string? SubeMnMuhfserino { get; set; }

    [Column("sube_yetkili_email")]
    [StringLength(50)]
    public string? SubeYetkiliEmail { get; set; }

    [Column("sube_Cadde")]
    [StringLength(50)]
    public string? SubeCadde { get; set; }

    [Column("sube_Mahalle")]
    [StringLength(50)]
    public string? SubeMahalle { get; set; }

    [Column("sube_Sokak")]
    [StringLength(50)]
    public string? SubeSokak { get; set; }

    [Column("sube_Semt")]
    [StringLength(25)]
    public string? SubeSemt { get; set; }

    [Column("sube_Apt_No")]
    [StringLength(10)]
    public string? SubeAptNo { get; set; }

    [Column("sube_Daire_No")]
    [StringLength(10)]
    public string? SubeDaireNo { get; set; }

    [Column("sube_Posta_Kodu")]
    [StringLength(8)]
    public string? SubePostaKodu { get; set; }

    [Column("sube_Ilce")]
    [StringLength(50)]
    public string? SubeIlce { get; set; }

    [Column("sube_Il")]
    [StringLength(50)]
    public string? SubeIl { get; set; }

    [Column("sube_Ulke")]
    [StringLength(50)]
    public string? SubeUlke { get; set; }

    [Column("sube_Adres_kodu")]
    [StringLength(10)]
    public string? SubeAdresKodu { get; set; }

    [Column("sube_gps_enlem")]
    public double? SubeGpsEnlem { get; set; }

    [Column("sube_gps_boylam")]
    public double? SubeGpsBoylam { get; set; }

    [Column("sube_TelUlkeKodu")]
    [StringLength(5)]
    public string? SubeTelUlkeKodu { get; set; }

    [Column("sube_TelBolgeKodu")]
    [StringLength(5)]
    public string? SubeTelBolgeKodu { get; set; }

    [Column("sube_TelNo1")]
    [StringLength(10)]
    public string? SubeTelNo1 { get; set; }

    [Column("sube_TelNo2")]
    [StringLength(10)]
    public string? SubeTelNo2 { get; set; }

    [Column("sube_TelFaxno")]
    [StringLength(10)]
    public string? SubeTelFaxno { get; set; }

    [Column("sube_TelModem")]
    [StringLength(10)]
    public string? SubeTelModem { get; set; }

    [Column("sube_datacenterno")]
    public int? SubeDatacenterno { get; set; }

    [Column("sube_eIskurNo")]
    [StringLength(25)]
    public string? SubeEIskurNo { get; set; }

    [Column("sube_eIskurTCNo")]
    [StringLength(20)]
    public string? SubeEIskurTCNo { get; set; }

    [Column("sube_eIskurSifre")]
    [StringLength(127)]
    public string? SubeEIskurSifre { get; set; }

    [Column("sube_RusumOrani")]
    public double? SubeRusumOrani { get; set; }

    [Column("sube_emutabakatsubekodu")]
    [StringLength(15)]
    public string? SubeEmutabakatsubekodu { get; set; }

    [Column("sube_eFaturaMukellefiyetTipi")]
    public byte? SubeEFaturaMukellefiyetTipi { get; set; }

    [Column("sube_eFaturaMukellefiyetKodu")]
    [StringLength(25)]
    public string? SubeEFaturaMukellefiyetKodu { get; set; }
}
