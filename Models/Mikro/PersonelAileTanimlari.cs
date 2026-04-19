using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_aile_tanimlari")]
public class PersonelAileTanimlari
{
    [Column("PA_Guid")]
    public Guid? PAGuid { get; set; }

    [Column("PA_DBCno")]
    public short? PADBCno { get; set; }

    [Column("PA_SpecRECno")]
    public int? PASpecRECno { get; set; }

    [Column("PA_iptal")]
    public bool? PAIptal { get; set; }

    [Column("PA_fileid")]
    public short? PAFileid { get; set; }

    [Column("PA_hidden")]
    public bool? PAHidden { get; set; }

    [Column("PA_kilitli")]
    public bool? PAKilitli { get; set; }

    [Column("PA_degisti")]
    public bool? PADegisti { get; set; }

    [Column("PA_checksum")]
    public int? PAChecksum { get; set; }

    [Column("PA_create_user")]
    public short? PACreateUser { get; set; }

    [Column("PA_create_date")]
    public DateTime? PACreateDate { get; set; }

    [Column("PA_lastup_user")]
    public short? PALastupUser { get; set; }

    [Column("PA_lastup_date")]
    public DateTime? PALastupDate { get; set; }

    [Column("PA_special1")]
    [StringLength(4)]
    public string? PASpecial1 { get; set; }

    [Column("PA_special2")]
    [StringLength(4)]
    public string? PASpecial2 { get; set; }

    [Column("PA_special3")]
    [StringLength(4)]
    public string? PASpecial3 { get; set; }

    [Column("PA_PerKodu")]
    [StringLength(25)]
    public string? PAPerKodu { get; set; }

    [Column("PA_Yakinlik")]
    public byte? PAYakinlik { get; set; }

    [Column("PA_CocukSiraNo")]
    public short? PACocukSiraNo { get; set; }

    [Column("PA_Ad")]
    [StringLength(40)]
    public string? PAAd { get; set; }

    [Column("PA_Soyad")]
    [StringLength(40)]
    public string? PASoyad { get; set; }

    [Column("PA_IlkSoyad")]
    [StringLength(40)]
    public string? PAIlkSoyad { get; set; }

    [Column("PA_TcKimlik")]
    [StringLength(25)]
    public string? PATcKimlik { get; set; }

    [Column("PA_Cinsiyet")]
    public byte? PACinsiyet { get; set; }

    [Column("PA_DogumTar")]
    public DateTime? PADogumTar { get; set; }

    [Column("PA_DogumYer")]
    [StringLength(40)]
    public string? PADogumYer { get; set; }

    [Column("PA_Ucretli")]
    public byte? PAUcretli { get; set; }

    [Column("PA_Tahsili")]
    public byte? PATahsili { get; set; }

    [Column("PA_Sakatlik")]
    public byte? PASakatlik { get; set; }

    [Column("PA_Cadde")]
    [StringLength(50)]
    public string? PACadde { get; set; }

    [Column("PA_Mahalle")]
    [StringLength(50)]
    public string? PAMahalle { get; set; }

    [Column("PA_Sokak")]
    [StringLength(50)]
    public string? PASokak { get; set; }

    [Column("PA_Semt")]
    [StringLength(25)]
    public string? PASemt { get; set; }

    [Column("PA_Apt_No")]
    [StringLength(10)]
    public string? PAAptNo { get; set; }

    [Column("PA_Daire_No")]
    [StringLength(10)]
    public string? PADaireNo { get; set; }

    [Column("PA_Posta_Kodu")]
    [StringLength(8)]
    public string? PAPostaKodu { get; set; }

    [Column("PA_Ilce")]
    [StringLength(50)]
    public string? PAIlce { get; set; }

    [Column("PA_Il")]
    [StringLength(50)]
    public string? PAIl { get; set; }

    [Column("PA_Ulke")]
    [StringLength(50)]
    public string? PAUlke { get; set; }

    [Column("PA_Adres_kodu")]
    [StringLength(10)]
    public string? PAAdresKodu { get; set; }

    [Column("PA_TelUlkeKodu")]
    [StringLength(5)]
    public string? PATelUlkeKodu { get; set; }

    [Column("PA_TelBolgeKodu")]
    [StringLength(5)]
    public string? PATelBolgeKodu { get; set; }

    [Column("PA_TelNo1")]
    [StringLength(10)]
    public string? PATelNo1 { get; set; }

    [Column("PA_EvlilikTarihi")]
    public DateTime? PAEvlilikTarihi { get; set; }

    [Column("PA_agine_tabii")]
    public byte? PAAgineTabii { get; set; }

    [Column("PA_OgrenimeDevamEdiyor")]
    public bool? PAOgrenimeDevamEdiyor { get; set; }

    [Column("PA_maas_banka")]
    public byte? PAMaasBanka { get; set; }

    [Column("PA_banka_hesapno")]
    [StringLength(30)]
    public string? PABankaHesapno { get; set; }
}
