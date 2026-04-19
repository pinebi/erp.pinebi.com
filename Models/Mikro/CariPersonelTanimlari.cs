using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_personel_tanimlari")]
public class CariPersonelTanimlari
{
    [Column("cari_per_Guid")]
    public Guid? CariPerGuid { get; set; }

    [Column("cari_per_DBCno")]
    public short? CariPerDBCno { get; set; }

    [Column("cari_per_SpecRECno")]
    public int? CariPerSpecRECno { get; set; }

    [Column("cari_per_iptal")]
    public bool? CariPerIptal { get; set; }

    [Column("cari_per_fileid")]
    public short? CariPerFileid { get; set; }

    [Column("cari_per_hidden")]
    public bool? CariPerHidden { get; set; }

    [Column("cari_per_kilitli")]
    public bool? CariPerKilitli { get; set; }

    [Column("cari_per_degisti")]
    public bool? CariPerDegisti { get; set; }

    [Column("cari_per_checksum")]
    public int? CariPerChecksum { get; set; }

    [Column("cari_per_create_user")]
    public short? CariPerCreateUser { get; set; }

    [Column("cari_per_create_date")]
    public DateTime? CariPerCreateDate { get; set; }

    [Column("cari_per_lastup_user")]
    public short? CariPerLastupUser { get; set; }

    [Column("cari_per_lastup_date")]
    public DateTime? CariPerLastupDate { get; set; }

    [Column("cari_per_special1")]
    [StringLength(4)]
    public string? CariPerSpecial1 { get; set; }

    [Column("cari_per_special2")]
    [StringLength(4)]
    public string? CariPerSpecial2 { get; set; }

    [Column("cari_per_special3")]
    [StringLength(4)]
    public string? CariPerSpecial3 { get; set; }

    [Column("cari_per_kod")]
    [StringLength(25)]
    public string? CariPerKod { get; set; }

    [Column("cari_per_adi")]
    [StringLength(50)]
    public string? CariPerAdi { get; set; }

    [Column("cari_per_soyadi")]
    [StringLength(50)]
    public string? CariPerSoyadi { get; set; }

    [Column("cari_per_tip")]
    public byte? CariPerTip { get; set; }

    [Column("cari_per_doviz_cinsi")]
    public byte? CariPerDovizCinsi { get; set; }

    [Column("cari_per_muhkod0")]
    [StringLength(40)]
    public string? CariPerMuhkod0 { get; set; }

    [Column("cari_per_muhkod1")]
    [StringLength(40)]
    public string? CariPerMuhkod1 { get; set; }

    [Column("cari_per_muhkod2")]
    [StringLength(40)]
    public string? CariPerMuhkod2 { get; set; }

    [Column("cari_per_muhkod3")]
    [StringLength(40)]
    public string? CariPerMuhkod3 { get; set; }

    [Column("cari_per_muhkod4")]
    [StringLength(40)]
    public string? CariPerMuhkod4 { get; set; }

    [Column("cari_per_banka_tcmb_kod")]
    [StringLength(4)]
    public string? CariPerBankaTcmbKod { get; set; }

    [Column("cari_per_banka_tcmb_subekod")]
    [StringLength(8)]
    public string? CariPerBankaTcmbSubekod { get; set; }

    [Column("cari_per_banka_tcmb_ilkod")]
    [StringLength(3)]
    public string? CariPerBankaTcmbIlkod { get; set; }

    [Column("cari_per_banka_hesapno")]
    [StringLength(30)]
    public string? CariPerBankaHesapno { get; set; }

    [Column("cari_per_banka_swiftkodu")]
    [StringLength(25)]
    public string? CariPerBankaSwiftkodu { get; set; }

    [Column("cari_per_prim_adet")]
    public double? CariPerPrimAdet { get; set; }

    [Column("cari_per_prim_yuzde")]
    public double? CariPerPrimYuzde { get; set; }

    [Column("cari_per_prim_carpani")]
    public double? CariPerPrimCarpani { get; set; }

    [Column("cari_per_basmprimcirotav1")]
    public double? CariPerBasmprimcirotav1 { get; set; }

    [Column("cari_per_basmprimyuz1")]
    public double? CariPerBasmprimyuz1 { get; set; }

    [Column("cari_per_basmprimcirotav2")]
    public double? CariPerBasmprimcirotav2 { get; set; }

    [Column("cari_per_basmprimyuz2")]
    public double? CariPerBasmprimyuz2 { get; set; }

    [Column("cari_per_basmprimcirotav3")]
    public double? CariPerBasmprimcirotav3 { get; set; }

    [Column("cari_per_basmprimyuz3")]
    public double? CariPerBasmprimyuz3 { get; set; }

    [Column("cari_per_basmprimcirotav4")]
    public double? CariPerBasmprimcirotav4 { get; set; }

    [Column("cari_per_basmprimyuz4")]
    public double? CariPerBasmprimyuz4 { get; set; }

    [Column("cari_per_basmprimcirotav5")]
    public double? CariPerBasmprimcirotav5 { get; set; }

    [Column("cari_per_basmprimyuz5")]
    public double? CariPerBasmprimyuz5 { get; set; }

    [Column("cari_per_kasiyerkodu")]
    [StringLength(25)]
    public string? CariPerKasiyerkodu { get; set; }

    [Column("cari_per_kasiyersifresi")]
    [StringLength(127)]
    public string? CariPerKasiyersifresi { get; set; }

    [Column("cari_per_kasiyerAmiri")]
    [StringLength(25)]
    public string? CariPerKasiyerAmiri { get; set; }

    [Column("cari_per_userno")]
    public int? CariPerUserno { get; set; }

    [Column("cari_per_depono")]
    public int? CariPerDepono { get; set; }

    [Column("cari_per_cepno")]
    [StringLength(15)]
    public string? CariPerCepno { get; set; }

    [Column("cari_per_mail")]
    [StringLength(50)]
    public string? CariPerMail { get; set; }

    [Column("cari_takvim_kodu")]
    [StringLength(4)]
    public string? CariTakvimKodu { get; set; }

    [Column("cari_per_kasiyerfirmaid")]
    [StringLength(15)]
    public string? CariPerKasiyerfirmaid { get; set; }

    [Column("cari_per_KEP_adresi")]
    [StringLength(80)]
    public string? CariPerKEPAdresi { get; set; }
}
