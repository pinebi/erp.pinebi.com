using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isemirleri")]
public class Isemirleri
{
    [Column("is_Guid")]
    public Guid? IsGuid { get; set; }

    [Column("is_DBCno")]
    public short? IsDBCno { get; set; }

    [Column("is_SpecRecNo")]
    public int? IsSpecRecNo { get; set; }

    [Column("is_iptal")]
    public bool? IsIptal { get; set; }

    [Column("is_fileid")]
    public short? IsFileid { get; set; }

    [Column("is_hidden")]
    public bool? IsHidden { get; set; }

    [Column("is_kilitli")]
    public bool? IsKilitli { get; set; }

    [Column("is_degisti")]
    public bool? IsDegisti { get; set; }

    [Column("is_checksum")]
    public int? IsChecksum { get; set; }

    [Column("is_create_user")]
    public short? IsCreateUser { get; set; }

    [Column("is_create_date")]
    public DateTime? IsCreateDate { get; set; }

    [Column("is_lastup_user")]
    public short? IsLastupUser { get; set; }

    [Column("is_lastup_date")]
    public DateTime? IsLastupDate { get; set; }

    [Column("is_special1")]
    [StringLength(4)]
    public string? IsSpecial1 { get; set; }

    [Column("is_special2")]
    [StringLength(4)]
    public string? IsSpecial2 { get; set; }

    [Column("is_special3")]
    [StringLength(4)]
    public string? IsSpecial3 { get; set; }

    [Column("is_firmano")]
    public int? IsFirmano { get; set; }

    [Column("is_subeno")]
    public int? IsSubeno { get; set; }

    [Column("is_Kod")]
    [StringLength(25)]
    public string? IsKod { get; set; }

    [Column("is_Ismi")]
    [StringLength(40)]
    public string? IsIsmi { get; set; }

    [Column("is_Fason_Fl")]
    public bool? IsFasonFl { get; set; }

    [Column("is_IsemriTipi")]
    public byte? IsIsemriTipi { get; set; }

    [Column("is_BaslangicTarihi")]
    public DateTime? IsBaslangicTarihi { get; set; }

    [Column("is_KapanisTarihi")]
    public DateTime? IsKapanisTarihi { get; set; }

    [Column("is_StokBirikMuhKod")]
    [StringLength(40)]
    public string? IsStokBirikMuhKod { get; set; }

    [Column("is_HizmetBirikMuhKod")]
    [StringLength(40)]
    public string? IsHizmetBirikMuhKod { get; set; }

    [Column("is_StokYansitMuhKod")]
    [StringLength(40)]
    public string? IsStokYansitMuhKod { get; set; }

    [Column("is_HizmetYansitMuhKo")]
    [StringLength(40)]
    public string? IsHizmetYansitMuhKo { get; set; }

    [Column("is_yarimamul_birikim_muhkodu")]
    [StringLength(40)]
    public string? IsYarimamulBirikimMuhkodu { get; set; }

    [Column("is_yarimamul_yansitma_muhkodu")]
    [StringLength(40)]
    public string? IsYarimamulYansitmaMuhkodu { get; set; }

    [Column("is_GenMalYanMuhKod_1")]
    [StringLength(40)]
    public string? IsGenMalYanMuhKod1 { get; set; }

    [Column("is_GenMalYanMuhKod_2")]
    [StringLength(40)]
    public string? IsGenMalYanMuhKod2 { get; set; }

    [Column("is_GenMalYanMuhKod_3")]
    [StringLength(40)]
    public string? IsGenMalYanMuhKod3 { get; set; }

    [Column("is_GenMalYanMuhKod_4")]
    [StringLength(40)]
    public string? IsGenMalYanMuhKod4 { get; set; }

    [Column("is_GenMalYanMuhKod_5")]
    [StringLength(40)]
    public string? IsGenMalYanMuhKod5 { get; set; }

    [Column("is_MakineMalYanMuhKo")]
    [StringLength(40)]
    public string? IsMakineMalYanMuhKo { get; set; }

    [Column("is_ElemanMalYanMuhKo")]
    [StringLength(40)]
    public string? IsElemanMalYanMuhKo { get; set; }

    [Column("is_YariMamulMuhKod")]
    [StringLength(40)]
    public string? IsYariMamulMuhKod { get; set; }

    [Column("is_SiparisNo_Seri")]
    [StringLength(50)]
    public string? IsSiparisNoSeri { get; set; }

    [Column("is_SiparisNo_Sira")]
    public int? IsSiparisNoSira { get; set; }

    [Column("is_SipSatirno")]
    public int? IsSipSatirno { get; set; }

    [Column("is_SipSafha")]
    [StringLength(1)]
    public string? IsSipSafha { get; set; }

    [Column("is_SipBatchId")]
    public short? IsSipBatchId { get; set; }

    [Column("is_EmriDurumu")]
    public byte? IsEmriDurumu { get; set; }

    [Column("is_Emri_AktiflesmeTarihi")]
    public DateTime? IsEmriAktiflesmeTarihi { get; set; }

    [Column("is_Emri_PlanBaslamaTarihi")]
    public DateTime? IsEmriPlanBaslamaTarihi { get; set; }

    [Column("is_Emri_PlanBitisTarihi")]
    public DateTime? IsEmriPlanBitisTarihi { get; set; }

    [Column("is_GenUrtMalYanMuhKod_1")]
    [StringLength(40)]
    public string? IsGenUrtMalYanMuhKod1 { get; set; }

    [Column("is_GenUrtMalYanMuhKod_2")]
    [StringLength(40)]
    public string? IsGenUrtMalYanMuhKod2 { get; set; }

    [Column("is_GenUrtMalYanMuhKod_3")]
    [StringLength(40)]
    public string? IsGenUrtMalYanMuhKod3 { get; set; }

    [Column("is_GenUrtMalYanMuhKod_4")]
    [StringLength(40)]
    public string? IsGenUrtMalYanMuhKod4 { get; set; }

    [Column("is_GenUrtMalYanMuhKod_5")]
    [StringLength(40)]
    public string? IsGenUrtMalYanMuhKod5 { get; set; }

    [Column("is_Muhgrup_kodu")]
    [StringLength(25)]
    public string? IsMuhgrupKodu { get; set; }

    [Column("is_BagliOlduguIsemri")]
    [StringLength(25)]
    public string? IsBagliOlduguIsemri { get; set; }

    [Column("is_BaglantiTipi")]
    public byte? IsBaglantiTipi { get; set; }

    [Column("is_Baglanti_uid")]
    public Guid? IsBaglantiUid { get; set; }

    [Column("is_OnaylayanKulNo")]
    public short? IsOnaylayanKulNo { get; set; }

    [Column("is_Onayli_fl")]
    public bool? IsOnayliFl { get; set; }

    [Column("is_Onceligi")]
    public byte? IsOnceligi { get; set; }

    [Column("is_SorumlulukMerkezi")]
    [StringLength(25)]
    public string? IsSorumlulukMerkezi { get; set; }

    [Column("is_ProjeKodu")]
    [StringLength(25)]
    public string? IsProjeKodu { get; set; }

    [Column("is_Aciklama")]
    [StringLength(40)]
    public string? IsAciklama { get; set; }

    [Column("is_KaynakPlanlamaTerminTarihi")]
    public DateTime? IsKaynakPlanlamaTerminTarihi { get; set; }
}
