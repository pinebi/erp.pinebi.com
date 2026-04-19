using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("icra_daireleri")]
public class IcraDaireleri
{
    [Column("id_Guid")]
    public Guid? IdGuid { get; set; }

    [Column("id_DBCno")]
    public short? IdDBCno { get; set; }

    [Column("id_SpecRECno")]
    public int? IdSpecRECno { get; set; }

    [Column("id_iptal")]
    public bool? IdIptal { get; set; }

    [Column("id_fileid")]
    public short? IdFileid { get; set; }

    [Column("id_hidden")]
    public bool? IdHidden { get; set; }

    [Column("id_kilitli")]
    public bool? IdKilitli { get; set; }

    [Column("id_degisti")]
    public bool? IdDegisti { get; set; }

    [Column("id_checksum")]
    public int? IdChecksum { get; set; }

    [Column("id_create_user")]
    public short? IdCreateUser { get; set; }

    [Column("id_create_date")]
    public DateTime? IdCreateDate { get; set; }

    [Column("id_lastup_user")]
    public short? IdLastupUser { get; set; }

    [Column("id_lastup_date")]
    public DateTime? IdLastupDate { get; set; }

    [Column("id_special1")]
    [StringLength(4)]
    public string? IdSpecial1 { get; set; }

    [Column("id_special2")]
    [StringLength(4)]
    public string? IdSpecial2 { get; set; }

    [Column("id_special3")]
    [StringLength(4)]
    public string? IdSpecial3 { get; set; }

    [Column("id_kodu")]
    [StringLength(25)]
    public string? IdKodu { get; set; }

    [Column("id_adi")]
    [StringLength(80)]
    public string? IdAdi { get; set; }

    [Column("id_eskiadi")]
    [StringLength(80)]
    public string? IdEskiadi { get; set; }

    [Column("id_vergino")]
    [StringLength(50)]
    public string? IdVergino { get; set; }

    [Column("id_IBAN1")]
    [StringLength(40)]
    public string? IdIBAN1 { get; set; }

    [Column("id_IBAN2")]
    [StringLength(40)]
    public string? IdIBAN2 { get; set; }

    [Column("id_IBAN3")]
    [StringLength(40)]
    public string? IdIBAN3 { get; set; }

    [Column("id_banka_tcmb_kod1")]
    [StringLength(4)]
    public string? IdBankaTcmbKod1 { get; set; }

    [Column("id_banka_tcmb_subekod1")]
    [StringLength(8)]
    public string? IdBankaTcmbSubekod1 { get; set; }

    [Column("id_banka_tcmb_ilkod1")]
    [StringLength(3)]
    public string? IdBankaTcmbIlkod1 { get; set; }

    [Column("id_banka_hesapno1")]
    [StringLength(30)]
    public string? IdBankaHesapno1 { get; set; }

    [Column("id_banka_swiftkodu1")]
    [StringLength(25)]
    public string? IdBankaSwiftkodu1 { get; set; }

    [Column("id_banka_tcmb_kod2")]
    [StringLength(4)]
    public string? IdBankaTcmbKod2 { get; set; }

    [Column("id_banka_tcmb_subekod2")]
    [StringLength(8)]
    public string? IdBankaTcmbSubekod2 { get; set; }

    [Column("id_banka_tcmb_ilkod2")]
    [StringLength(3)]
    public string? IdBankaTcmbIlkod2 { get; set; }

    [Column("id_banka_hesapno2")]
    [StringLength(30)]
    public string? IdBankaHesapno2 { get; set; }

    [Column("id_banka_swiftkodu2")]
    [StringLength(25)]
    public string? IdBankaSwiftkodu2 { get; set; }

    [Column("id_banka_tcmb_kod3")]
    [StringLength(4)]
    public string? IdBankaTcmbKod3 { get; set; }

    [Column("id_banka_tcmb_subekod3")]
    [StringLength(8)]
    public string? IdBankaTcmbSubekod3 { get; set; }

    [Column("id_banka_tcmb_ilkod3")]
    [StringLength(3)]
    public string? IdBankaTcmbIlkod3 { get; set; }

    [Column("id_banka_hesapno3")]
    [StringLength(30)]
    public string? IdBankaHesapno3 { get; set; }

    [Column("id_banka_swiftkodu3")]
    [StringLength(25)]
    public string? IdBankaSwiftkodu3 { get; set; }

    [Column("id_cadde")]
    [StringLength(50)]
    public string? IdCadde { get; set; }

    [Column("id_mahalle")]
    [StringLength(50)]
    public string? IdMahalle { get; set; }

    [Column("id_sokak")]
    [StringLength(50)]
    public string? IdSokak { get; set; }

    [Column("id_Semt")]
    [StringLength(25)]
    public string? IdSemt { get; set; }

    [Column("id_Apt_No")]
    [StringLength(10)]
    public string? IdAptNo { get; set; }

    [Column("id_Daire_No")]
    [StringLength(10)]
    public string? IdDaireNo { get; set; }

    [Column("id_posta_kodu")]
    [StringLength(8)]
    public string? IdPostaKodu { get; set; }

    [Column("id_ilce")]
    [StringLength(50)]
    public string? IdIlce { get; set; }

    [Column("id_il")]
    [StringLength(50)]
    public string? IdIl { get; set; }

    [Column("id_ulke")]
    [StringLength(50)]
    public string? IdUlke { get; set; }

    [Column("id_Adres_kodu")]
    [StringLength(10)]
    public string? IdAdresKodu { get; set; }

    [Column("id_tel_ulke_kodu")]
    [StringLength(5)]
    public string? IdTelUlkeKodu { get; set; }

    [Column("id_tel_bolge_kodu")]
    [StringLength(5)]
    public string? IdTelBolgeKodu { get; set; }

    [Column("id_tel_no1")]
    [StringLength(10)]
    public string? IdTelNo1 { get; set; }

    [Column("id_tel_no2")]
    [StringLength(10)]
    public string? IdTelNo2 { get; set; }

    [Column("id_tel_faxno")]
    [StringLength(10)]
    public string? IdTelFaxno { get; set; }

    [Column("id_tel_modem")]
    [StringLength(10)]
    public string? IdTelModem { get; set; }
}
