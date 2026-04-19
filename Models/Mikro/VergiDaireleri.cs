using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("vergi_daireleri")]
public class VergiDaireleri
{
    [Column("Vgd_Guid")]
    public Guid? VgdGuid { get; set; }

    [Column("Vgd_DBCno")]
    public short? VgdDBCno { get; set; }

    [Column("Vgd_SpecRECno")]
    public int? VgdSpecRECno { get; set; }

    [Column("Vgd_iptal")]
    public bool? VgdIptal { get; set; }

    [Column("Vgd_fileid")]
    public short? VgdFileid { get; set; }

    [Column("Vgd_hidden")]
    public bool? VgdHidden { get; set; }

    [Column("Vgd_kilitli")]
    public bool? VgdKilitli { get; set; }

    [Column("Vgd_degisti")]
    public bool? VgdDegisti { get; set; }

    [Column("Vgd_checksum")]
    public int? VgdChecksum { get; set; }

    [Column("Vgd_create_user")]
    public short? VgdCreateUser { get; set; }

    [Column("Vgd_create_date")]
    public DateTime? VgdCreateDate { get; set; }

    [Column("Vgd_lastup_user")]
    public short? VgdLastupUser { get; set; }

    [Column("Vgd_lastup_date")]
    public DateTime? VgdLastupDate { get; set; }

    [Column("Vgd_special1")]
    [StringLength(4)]
    public string? VgdSpecial1 { get; set; }

    [Column("Vgd_special2")]
    [StringLength(4)]
    public string? VgdSpecial2 { get; set; }

    [Column("Vgd_special3")]
    [StringLength(4)]
    public string? VgdSpecial3 { get; set; }

    [Column("Vgd_orj_kod")]
    [StringLength(10)]
    public string? VgdOrjKod { get; set; }

    [Column("Vgd_adi")]
    [StringLength(50)]
    public string? VgdAdi { get; set; }

    [Column("Vgd_cadde")]
    [StringLength(50)]
    public string? VgdCadde { get; set; }

    [Column("Vgd_mahalle")]
    [StringLength(50)]
    public string? VgdMahalle { get; set; }

    [Column("Vgd_sokak")]
    [StringLength(50)]
    public string? VgdSokak { get; set; }

    [Column("Vgd_Semt")]
    [StringLength(25)]
    public string? VgdSemt { get; set; }

    [Column("Vgd_Apt_No")]
    [StringLength(10)]
    public string? VgdAptNo { get; set; }

    [Column("Vgd_Daire_No")]
    [StringLength(10)]
    public string? VgdDaireNo { get; set; }

    [Column("Vgd_posta_Kodu")]
    [StringLength(8)]
    public string? VgdPostaKodu { get; set; }

    [Column("Vgd_Ilce")]
    [StringLength(50)]
    public string? VgdIlce { get; set; }

    [Column("Vgd_Il")]
    [StringLength(50)]
    public string? VgdIl { get; set; }

    [Column("Vgd_Ulke")]
    [StringLength(50)]
    public string? VgdUlke { get; set; }

    [Column("Vgd_Adres_kodu")]
    [StringLength(10)]
    public string? VgdAdresKodu { get; set; }

    [Column("Vgd_TelUlkeKodu")]
    [StringLength(5)]
    public string? VgdTelUlkeKodu { get; set; }

    [Column("Vgd_TelBolgeKodu")]
    [StringLength(5)]
    public string? VgdTelBolgeKodu { get; set; }

    [Column("Vgd_TelNo1")]
    [StringLength(10)]
    public string? VgdTelNo1 { get; set; }

    [Column("Vgd_TelNo2")]
    [StringLength(10)]
    public string? VgdTelNo2 { get; set; }

    [Column("Vgd_FaxNo")]
    [StringLength(10)]
    public string? VgdFaxNo { get; set; }

    [Column("Vgd_ModemNo")]
    [StringLength(10)]
    public string? VgdModemNo { get; set; }

    [Column("Vgd_Kodu")]
    [StringLength(5)]
    public string? VgdKodu { get; set; }

    [Column("Vgd_vrgsrm_adi")]
    [StringLength(25)]
    public string? VgdVrgsrmAdi { get; set; }

    [Column("Vgd_vrgsrm_Soyadi")]
    [StringLength(25)]
    public string? VgdVrgsrmSoyadi { get; set; }
}
