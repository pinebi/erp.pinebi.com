using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kullanicilar")]
public class Kullanicilar
{
    [Column("User_Guid")]
    public Guid? UserGuid { get; set; }

    [Column("User_DBCno")]
    public short? UserDBCno { get; set; }

    [Column("User_SpecRECno")]
    public int? UserSpecRECno { get; set; }

    [Column("User_iptal")]
    public bool? UserIptal { get; set; }

    [Column("User_fileid")]
    public short? UserFileid { get; set; }

    [Column("User_hidden")]
    public bool? UserHidden { get; set; }

    [Column("User_kilitli")]
    public bool? UserKilitli { get; set; }

    [Column("User_degisti")]
    public bool? UserDegisti { get; set; }

    [Column("User_checksum")]
    public int? UserChecksum { get; set; }

    [Column("User_create_user")]
    public short? UserCreateUser { get; set; }

    [Column("User_create_date")]
    public DateTime? UserCreateDate { get; set; }

    [Column("User_lastup_user")]
    public short? UserLastupUser { get; set; }

    [Column("User_lastup_date")]
    public DateTime? UserLastupDate { get; set; }

    [Column("User_special1")]
    [StringLength(4)]
    public string? UserSpecial1 { get; set; }

    [Column("User_special2")]
    [StringLength(4)]
    public string? UserSpecial2 { get; set; }

    [Column("User_special3")]
    [StringLength(4)]
    public string? UserSpecial3 { get; set; }

    [Column("User_no")]
    public int? UserNo { get; set; }

    [Column("User_name")]
    [StringLength(20)]
    public string? UserName { get; set; }

    [Column("User_pw")]
    [StringLength(127)]
    public string? UserPw { get; set; }

    [Column("User_LongName")]
    [StringLength(50)]
    public string? UserLongName { get; set; }

    [Column("User_LoginName")]
    [StringLength(20)]
    public string? UserLoginName { get; set; }

    [Column("User_EMail")]
    [StringLength(50)]
    public string? UserEMail { get; set; }

    [Column("User_InSystem")]
    public bool? UserInSystem { get; set; }

    [Column("User_ProgNo")]
    public byte? UserProgNo { get; set; }

    [Column("User_Modules")]
    public int? UserModules { get; set; }

    [Column("User_random")]
    public int? UserRandom { get; set; }

    [Column("User_DBase")]
    [StringLength(25)]
    public string? UserDBase { get; set; }

    [Column("User_SifreTipi")]
    public byte? UserSifreTipi { get; set; }

    [Column("User_SifreDegisim_date")]
    public DateTime? UserSifreDegisimDate { get; set; }

    [Column("User_pasif")]
    public bool? UserPasif { get; set; }

    [Column("User_FirstIP")]
    [StringLength(15)]
    public string? UserFirstIP { get; set; }

    [Column("User_LastIP")]
    [StringLength(15)]
    public string? UserLastIP { get; set; }

    [Column("User_PrevPW1")]
    [StringLength(127)]
    public string? UserPrevPW1 { get; set; }

    [Column("User_PrevPW2")]
    [StringLength(127)]
    public string? UserPrevPW2 { get; set; }

    [Column("User_PrevPW3")]
    [StringLength(127)]
    public string? UserPrevPW3 { get; set; }

    [Column("User_PrevPW4")]
    [StringLength(127)]
    public string? UserPrevPW4 { get; set; }

    [Column("User_PrevPW5")]
    [StringLength(127)]
    public string? UserPrevPW5 { get; set; }

    [Column("User_DomainAndUserName")]
    [StringLength(120)]
    public string? UserDomainAndUserName { get; set; }

    [Column("User_DefaultDBKod")]
    [StringLength(25)]
    public string? UserDefaultDBKod { get; set; }

    [Column("User_eMikroMail")]
    [StringLength(50)]
    public string? UserEMikroMail { get; set; }

    [Column("User_eMikroSifre")]
    [StringLength(127)]
    public string? UserEMikroSifre { get; set; }

    [Column("User_KEPHesap")]
    [StringLength(50)]
    public string? UserKEPHesap { get; set; }

    [Column("User_KEPCepTelefonu")]
    [StringLength(10)]
    public string? UserKEPCepTelefonu { get; set; }

    [Column("User_KEPSifre")]
    [StringLength(127)]
    public string? UserKEPSifre { get; set; }

    [Column("User_KEPTcNo")]
    [StringLength(11)]
    public string? UserKEPTcNo { get; set; }

    [Column("User_Eimza_tipi")]
    public byte? UserEimzaTipi { get; set; }

    [Column("User_Eimza_surucusu")]
    [StringLength(127)]
    public string? UserEimzaSurucusu { get; set; }

    [Column("User_Eimza_sifre")]
    [StringLength(127)]
    public string? UserEimzaSifre { get; set; }

    [Column("User_SRVfl")]
    public bool? UserSRVfl { get; set; }
}
