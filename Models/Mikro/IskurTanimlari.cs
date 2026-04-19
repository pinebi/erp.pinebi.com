using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("iskur_tanimlari")]
public class IskurTanimlari
{
    [Column("iskur_Guid")]
    public Guid? IskurGuid { get; set; }

    [Column("iskur_DBCno")]
    public short? IskurDBCno { get; set; }

    [Column("iskur_SpecRECno")]
    public int? IskurSpecRECno { get; set; }

    [Column("iskur_iptal")]
    public bool? IskurIptal { get; set; }

    [Column("iskur_fileid")]
    public short? IskurFileid { get; set; }

    [Column("iskur_hidden")]
    public bool? IskurHidden { get; set; }

    [Column("iskur_kilitli")]
    public bool? IskurKilitli { get; set; }

    [Column("iskur_degisti")]
    public bool? IskurDegisti { get; set; }

    [Column("iskur_checksum")]
    public int? IskurChecksum { get; set; }

    [Column("iskur_create_user")]
    public short? IskurCreateUser { get; set; }

    [Column("iskur_create_date")]
    public DateTime? IskurCreateDate { get; set; }

    [Column("iskur_lastup_user")]
    public short? IskurLastupUser { get; set; }

    [Column("iskur_lastup_date")]
    public DateTime? IskurLastupDate { get; set; }

    [Column("iskur_special1")]
    [StringLength(4)]
    public string? IskurSpecial1 { get; set; }

    [Column("iskur_special2")]
    [StringLength(4)]
    public string? IskurSpecial2 { get; set; }

    [Column("iskur_special3")]
    [StringLength(4)]
    public string? IskurSpecial3 { get; set; }

    [Column("iskur_adi")]
    [StringLength(40)]
    public string? IskurAdi { get; set; }

    [Column("iskur_isyerino")]
    [StringLength(25)]
    public string? IskurIsyerino { get; set; }

    [Column("iskur_cadde")]
    [StringLength(50)]
    public string? IskurCadde { get; set; }

    [Column("iskur_mahalle")]
    [StringLength(50)]
    public string? IskurMahalle { get; set; }

    [Column("iskur_sokak")]
    [StringLength(50)]
    public string? IskurSokak { get; set; }

    [Column("iskur_Semt")]
    [StringLength(25)]
    public string? IskurSemt { get; set; }

    [Column("iskur_Apt_No")]
    [StringLength(10)]
    public string? IskurAptNo { get; set; }

    [Column("iskur_Daire_No")]
    [StringLength(10)]
    public string? IskurDaireNo { get; set; }

    [Column("iskur_posta_kodu")]
    [StringLength(8)]
    public string? IskurPostaKodu { get; set; }

    [Column("iskur_ilce")]
    [StringLength(50)]
    public string? IskurIlce { get; set; }

    [Column("iskur_il")]
    [StringLength(50)]
    public string? IskurIl { get; set; }

    [Column("iskur_ulke")]
    [StringLength(50)]
    public string? IskurUlke { get; set; }

    [Column("iskur_adres_kodu")]
    [StringLength(10)]
    public string? IskurAdresKodu { get; set; }

    [Column("iskur_tel_ulke_kodu")]
    [StringLength(5)]
    public string? IskurTelUlkeKodu { get; set; }

    [Column("iskur_tel_bolge_kodu")]
    [StringLength(5)]
    public string? IskurTelBolgeKodu { get; set; }

    [Column("iskur_tel_no1")]
    [StringLength(10)]
    public string? IskurTelNo1 { get; set; }

    [Column("iskur_tel_no2")]
    [StringLength(10)]
    public string? IskurTelNo2 { get; set; }

    [Column("iskur_tel_faxno")]
    [StringLength(10)]
    public string? IskurTelFaxno { get; set; }

    [Column("iskur_tel_modem")]
    [StringLength(10)]
    public string? IskurTelModem { get; set; }
}
