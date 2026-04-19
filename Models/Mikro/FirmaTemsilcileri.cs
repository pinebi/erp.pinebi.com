using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_temsilcileri")]
public class FirmaTemsilcileri
{
    [Column("tms_Guid")]
    public Guid? TmsGuid { get; set; }

    [Column("tms_DBCno")]
    public short? TmsDBCno { get; set; }

    [Column("tms_SpecRECno")]
    public int? TmsSpecRECno { get; set; }

    [Column("tms_iptal")]
    public bool? TmsIptal { get; set; }

    [Column("tms_fileid")]
    public short? TmsFileid { get; set; }

    [Column("tms_hidden")]
    public bool? TmsHidden { get; set; }

    [Column("tms_kilitli")]
    public bool? TmsKilitli { get; set; }

    [Column("tms_degisti")]
    public bool? TmsDegisti { get; set; }

    [Column("tms_checksum")]
    public int? TmsChecksum { get; set; }

    [Column("tms_create_user")]
    public short? TmsCreateUser { get; set; }

    [Column("tms_create_date")]
    public DateTime? TmsCreateDate { get; set; }

    [Column("tms_lastup_user")]
    public short? TmsLastupUser { get; set; }

    [Column("tms_lastup_date")]
    public DateTime? TmsLastupDate { get; set; }

    [Column("tms_reserved1")]
    [StringLength(4)]
    public string? TmsReserved1 { get; set; }

    [Column("tms_reserved2")]
    [StringLength(4)]
    public string? TmsReserved2 { get; set; }

    [Column("tms_reserved3")]
    [StringLength(4)]
    public string? TmsReserved3 { get; set; }

    [Column("tms_Bag_Firma_No")]
    public int? TmsBagFirmaNo { get; set; }

    [Column("tms_Kodu")]
    [StringLength(25)]
    public string? TmsKodu { get; set; }

    [Column("tms_Adi")]
    [StringLength(40)]
    public string? TmsAdi { get; set; }

    [Column("tms_Soyadi")]
    [StringLength(40)]
    public string? TmsSoyadi { get; set; }

    [Column("tms_Sifat")]
    public byte? TmsSifat { get; set; }

    [Column("tms_VDaire")]
    [StringLength(10)]
    public string? TmsVDaire { get; set; }

    [Column("tms_VKimlikNo")]
    [StringLength(20)]
    public string? TmsVKimlikNo { get; set; }

    [Column("tms_Hisse")]
    public double? TmsHisse { get; set; }

    [Column("tms_TicOdaSicilNo")]
    [StringLength(20)]
    public string? TmsTicOdaSicilNo { get; set; }

    [Column("tms_TcKimlikNo")]
    [StringLength(15)]
    public string? TmsTcKimlikNo { get; set; }

    [Column("tms_Babaadi")]
    [StringLength(25)]
    public string? TmsBabaadi { get; set; }

    [Column("tms_Anneadi")]
    [StringLength(25)]
    public string? TmsAnneadi { get; set; }

    [Column("tms_Dogyeri")]
    [StringLength(25)]
    public string? TmsDogyeri { get; set; }

    [Column("tms_Dogtarihi")]
    public DateTime? TmsDogtarihi { get; set; }

    [Column("tms_Medenihal")]
    public byte? TmsMedenihal { get; set; }

    [Column("tms_Uyruk")]
    [StringLength(15)]
    public string? TmsUyruk { get; set; }

    [Column("tms_Email")]
    [StringLength(80)]
    public string? TmsEmail { get; set; }

    [Column("tms_MobTelUlKod1")]
    [StringLength(5)]
    public string? TmsMobTelUlKod1 { get; set; }

    [Column("tms_MobTelKod1")]
    [StringLength(5)]
    public string? TmsMobTelKod1 { get; set; }

    [Column("tms_MobTelNo1")]
    [StringLength(10)]
    public string? TmsMobTelNo1 { get; set; }

    [Column("tms_MobTelUlKod2")]
    [StringLength(5)]
    public string? TmsMobTelUlKod2 { get; set; }

    [Column("tms_MobTelKod2")]
    [StringLength(5)]
    public string? TmsMobTelKod2 { get; set; }

    [Column("tms_MobTelNo2")]
    [StringLength(10)]
    public string? TmsMobTelNo2 { get; set; }

    [Column("tms_IsTelUlKod")]
    [StringLength(5)]
    public string? TmsIsTelUlKod { get; set; }

    [Column("tms_IsTelKod")]
    [StringLength(5)]
    public string? TmsIsTelKod { get; set; }

    [Column("tms_IsTelNo1")]
    [StringLength(10)]
    public string? TmsIsTelNo1 { get; set; }

    [Column("tms_IsTelNo2")]
    [StringLength(10)]
    public string? TmsIsTelNo2 { get; set; }

    [Column("tms_IsFaxNo")]
    [StringLength(10)]
    public string? TmsIsFaxNo { get; set; }

    [Column("tms_IsModemNo")]
    [StringLength(10)]
    public string? TmsIsModemNo { get; set; }

    [Column("tms_IsCadde")]
    [StringLength(50)]
    public string? TmsIsCadde { get; set; }

    [Column("tms_IsMahalle")]
    [StringLength(50)]
    public string? TmsIsMahalle { get; set; }

    [Column("tms_IsSokak")]
    [StringLength(50)]
    public string? TmsIsSokak { get; set; }

    [Column("tms_IsSemt")]
    [StringLength(25)]
    public string? TmsIsSemt { get; set; }

    [Column("tms_IsApt_No")]
    [StringLength(10)]
    public string? TmsIsAptNo { get; set; }

    [Column("tms_IsDaire_No")]
    [StringLength(10)]
    public string? TmsIsDaireNo { get; set; }

    [Column("tms_IsPosta_Kodu")]
    [StringLength(8)]
    public string? TmsIsPostaKodu { get; set; }

    [Column("tms_IsIlce")]
    [StringLength(50)]
    public string? TmsIsIlce { get; set; }

    [Column("tms_IsIl")]
    [StringLength(50)]
    public string? TmsIsIl { get; set; }

    [Column("tms_IsUlke")]
    [StringLength(50)]
    public string? TmsIsUlke { get; set; }

    [Column("tms_IsAdres_kodu")]
    [StringLength(10)]
    public string? TmsIsAdresKodu { get; set; }

    [Column("tms_IkmTelUlKod")]
    [StringLength(5)]
    public string? TmsIkmTelUlKod { get; set; }

    [Column("tms_IkmTelKod")]
    [StringLength(5)]
    public string? TmsIkmTelKod { get; set; }

    [Column("tms_IkmTelNo")]
    [StringLength(10)]
    public string? TmsIkmTelNo { get; set; }

    [Column("tms_IkmCadde")]
    [StringLength(50)]
    public string? TmsIkmCadde { get; set; }

    [Column("tms_IkmMahalle")]
    [StringLength(50)]
    public string? TmsIkmMahalle { get; set; }

    [Column("tms_IkmSokak")]
    [StringLength(50)]
    public string? TmsIkmSokak { get; set; }

    [Column("tms_IkmSemt")]
    [StringLength(25)]
    public string? TmsIkmSemt { get; set; }

    [Column("tms_IkmApt_No")]
    [StringLength(10)]
    public string? TmsIkmAptNo { get; set; }

    [Column("tms_IkmDaire_No")]
    [StringLength(10)]
    public string? TmsIkmDaireNo { get; set; }

    [Column("tms_IkmPosta_Kodu")]
    [StringLength(8)]
    public string? TmsIkmPostaKodu { get; set; }

    [Column("tms_IkmIlce")]
    [StringLength(50)]
    public string? TmsIkmIlce { get; set; }

    [Column("tms_IkmIl")]
    [StringLength(50)]
    public string? TmsIkmIl { get; set; }

    [Column("tms_IkmUlke")]
    [StringLength(50)]
    public string? TmsIkmUlke { get; set; }

    [Column("tms_IkmAdres_kodu")]
    [StringLength(10)]
    public string? TmsIkmAdresKodu { get; set; }

    [Column("tms_nuf_ciltno")]
    [StringLength(10)]
    public string? TmsNufCiltno { get; set; }

    [Column("tms_nuf_sayfano")]
    [StringLength(10)]
    public string? TmsNufSayfano { get; set; }

    [Column("tms_nuf_kutukno")]
    [StringLength(10)]
    public string? TmsNufKutukno { get; set; }

    [Column("tms_nuf_il")]
    [StringLength(20)]
    public string? TmsNufIl { get; set; }

    [Column("tms_TNB_sifre")]
    [StringLength(127)]
    public string? TmsTNBSifre { get; set; }

    [Column("tms_sozlesme_tarihi")]
    public DateTime? TmsSozlesmeTarihi { get; set; }

    [Column("tms_sozlesme_no")]
    [StringLength(25)]
    public string? TmsSozlesmeNo { get; set; }

    [Column("tms_sozlesme_aciklama")]
    [StringLength(50)]
    public string? TmsSozlesmeAciklama { get; set; }

    [Column("tms_TNB_kullan_fl")]
    public bool? TmsTNBKullanFl { get; set; }

    [Column("tms_TNB_kimlik_tipi")]
    public byte? TmsTNBKimlikTipi { get; set; }
}
