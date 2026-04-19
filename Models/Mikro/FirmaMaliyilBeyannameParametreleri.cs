using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("firma_maliyil_beyanname_parametreleri")]
public class FirmaMaliyilBeyannameParametreleri
{
    [Column("fmyb_Guid")]
    public Guid? FmybGuid { get; set; }

    [Column("fmyb_DBCno")]
    public short? FmybDBCno { get; set; }

    [Column("fmyb_SpecRECno")]
    public int? FmybSpecRECno { get; set; }

    [Column("fmyb_iptal")]
    public bool? FmybIptal { get; set; }

    [Column("fmyb_fileid")]
    public short? FmybFileid { get; set; }

    [Column("fmyb_hidden")]
    public bool? FmybHidden { get; set; }

    [Column("fmyb_kilitli")]
    public bool? FmybKilitli { get; set; }

    [Column("fmyb_degisti")]
    public bool? FmybDegisti { get; set; }

    [Column("fmyb_checksum")]
    public int? FmybChecksum { get; set; }

    [Column("fmyb_create_user")]
    public short? FmybCreateUser { get; set; }

    [Column("fmyb_create_date")]
    public DateTime? FmybCreateDate { get; set; }

    [Column("fmyb_lastup_user")]
    public short? FmybLastupUser { get; set; }

    [Column("fmyb_lastup_date")]
    public DateTime? FmybLastupDate { get; set; }

    [Column("fmyb_special1")]
    [StringLength(4)]
    public string? FmybSpecial1 { get; set; }

    [Column("fmyb_special2")]
    [StringLength(4)]
    public string? FmybSpecial2 { get; set; }

    [Column("fmyb_special3")]
    [StringLength(4)]
    public string? FmybSpecial3 { get; set; }

    [Column("fmyb_sirano")]
    public int? FmybSirano { get; set; }

    [Column("fmyb_maliyil")]
    public int? FmybMaliyil { get; set; }

    [Column("fmyb_kdv_hesap_sekli")]
    public byte? FmybKdvHesapSekli { get; set; }

    [Column("fmyb_kdv_normal_matrah_vergi1")]
    public byte? FmybKdvNormalMatrahVergi1 { get; set; }

    [Column("fmyb_kdv_normal_matrah_vergi2")]
    public byte? FmybKdvNormalMatrahVergi2 { get; set; }

    [Column("fmyb_kdv_normal_matrah_vergi3")]
    public byte? FmybKdvNormalMatrahVergi3 { get; set; }

    [Column("fmyb_kdv_normal_matrah_vergi4")]
    public byte? FmybKdvNormalMatrahVergi4 { get; set; }

    [Column("fmyb_kdv_tevk_matrah_vergi1")]
    public byte? FmybKdvTevkMatrahVergi1 { get; set; }

    [Column("fmyb_kdv_tevk_matrah_vergi2")]
    public byte? FmybKdvTevkMatrahVergi2 { get; set; }

    [Column("fmyb_kdv_tevk_matrah_vergi3")]
    public byte? FmybKdvTevkMatrahVergi3 { get; set; }

    [Column("fmyb_kdv_tevk_matrah_vergi4")]
    public byte? FmybKdvTevkMatrahVergi4 { get; set; }

    [Column("fmyb_kdv_tevkifat_tipi1")]
    public byte? FmybKdvTevkifatTipi1 { get; set; }

    [Column("fmyb_kdv_tevkifat_tipi2")]
    public byte? FmybKdvTevkifatTipi2 { get; set; }

    [Column("fmyb_kdv_tevkifat_tipi3")]
    public byte? FmybKdvTevkifatTipi3 { get; set; }

    [Column("fmyb_kdv_tevkifat_tipi4")]
    public byte? FmybKdvTevkifatTipi4 { get; set; }

    [Column("fmyb_kdv_isl_tev_hesap_kodu1")]
    [StringLength(25)]
    public string? FmybKdvIslTevHesapKodu1 { get; set; }

    [Column("fmyb_kdv_isl_tev_hesap_kodu2")]
    [StringLength(25)]
    public string? FmybKdvIslTevHesapKodu2 { get; set; }

    [Column("fmyb_kdv_isl_tev_hesap_kodu3")]
    [StringLength(25)]
    public string? FmybKdvIslTevHesapKodu3 { get; set; }

    [Column("fmyb_kdv_isl_tev_hesap_kodu4")]
    [StringLength(25)]
    public string? FmybKdvIslTevHesapKodu4 { get; set; }

    [Column("fmyb_kdv_ihracat_vergi1")]
    public byte? FmybKdvIhracatVergi1 { get; set; }

    [Column("fmyb_kdv_ihracat_vergi2")]
    public byte? FmybKdvIhracatVergi2 { get; set; }

    [Column("fmyb_kdv_ihracat_vergi3")]
    public byte? FmybKdvIhracatVergi3 { get; set; }

    [Column("fmyb_kdv_kismi_ist_index1")]
    public byte? FmybKdvKismiIstIndex1 { get; set; }

    [Column("fmyb_kdv_kismi_ist_matheskod1")]
    [StringLength(25)]
    public string? FmybKdvKismiIstMatheskod1 { get; set; }

    [Column("fmyb_kdv_kismi_ist_yukkdvkod1")]
    [StringLength(25)]
    public string? FmybKdvKismiIstYukkdvkod1 { get; set; }

    [Column("fmyb_kdv_kismi_ist_index2")]
    public byte? FmybKdvKismiIstIndex2 { get; set; }

    [Column("fmyb_kdv_kismi_ist_matheskod2")]
    [StringLength(25)]
    public string? FmybKdvKismiIstMatheskod2 { get; set; }

    [Column("fmyb_kdv_kismi_ist_yukkdvkod2")]
    [StringLength(25)]
    public string? FmybKdvKismiIstYukkdvkod2 { get; set; }

    [Column("fmyb_kdv_kismi_ist_index3")]
    public byte? FmybKdvKismiIstIndex3 { get; set; }

    [Column("fmyb_kdv_kismi_ist_matheskod3")]
    [StringLength(25)]
    public string? FmybKdvKismiIstMatheskod3 { get; set; }

    [Column("fmyb_kdv_kismi_ist_yukkdvkod3")]
    [StringLength(25)]
    public string? FmybKdvKismiIstYukkdvkod3 { get; set; }

    [Column("fmyb_kdv_kismi_ist_index4")]
    public byte? FmybKdvKismiIstIndex4 { get; set; }

    [Column("fmyb_kdv_kismi_ist_matheskod4")]
    [StringLength(25)]
    public string? FmybKdvKismiIstMatheskod4 { get; set; }

    [Column("fmyb_kdv_kismi_ist_yukkdvkod4")]
    [StringLength(25)]
    public string? FmybKdvKismiIstYukkdvkod4 { get; set; }

    [Column("fmyb_kdv_kismi_ist_index5")]
    public byte? FmybKdvKismiIstIndex5 { get; set; }

    [Column("fmyb_kdv_kismi_ist_matheskod5")]
    [StringLength(25)]
    public string? FmybKdvKismiIstMatheskod5 { get; set; }

    [Column("fmyb_kdv_kismi_ist_yukkdvkod5")]
    [StringLength(25)]
    public string? FmybKdvKismiIstYukkdvkod5 { get; set; }

    [Column("fmyb_kdv_tam_ist_index1")]
    public byte? FmybKdvTamIstIndex1 { get; set; }

    [Column("fmyb_kdv_tam_ist_matheskod1")]
    [StringLength(25)]
    public string? FmybKdvTamIstMatheskod1 { get; set; }

    [Column("fmyb_kdv_tam_ist_yukkdvkod1")]
    [StringLength(25)]
    public string? FmybKdvTamIstYukkdvkod1 { get; set; }

    [Column("fmyb_kdv_tam_ist_index2")]
    public byte? FmybKdvTamIstIndex2 { get; set; }

    [Column("fmyb_kdv_diger_ist_index1")]
    public byte? FmybKdvDigerIstIndex1 { get; set; }

    [Column("fmyb_kdv_diger_matheskod1")]
    [StringLength(25)]
    public string? FmybKdvDigerMatheskod1 { get; set; }

    [Column("fmyb_kdv_diger_kdvkod1")]
    [StringLength(25)]
    public string? FmybKdvDigerKdvkod1 { get; set; }

    [Column("fmyb_kdv_diger_matheskod2")]
    [StringLength(25)]
    public string? FmybKdvDigerMatheskod2 { get; set; }

    [Column("fmyb_kdv_diger_kdvkod2")]
    [StringLength(25)]
    public string? FmybKdvDigerKdvkod2 { get; set; }

    [Column("fmyb_kdv_diger_matheskod3")]
    [StringLength(25)]
    public string? FmybKdvDigerMatheskod3 { get; set; }

    [Column("fmyb_kdv_diger_kdvkod3")]
    [StringLength(25)]
    public string? FmybKdvDigerKdvkod3 { get; set; }

    [Column("fmyb_kdv_diger_matheskod4")]
    [StringLength(25)]
    public string? FmybKdvDigerMatheskod4 { get; set; }

    [Column("fmyb_kdv_diger_kdvkod4")]
    [StringLength(25)]
    public string? FmybKdvDigerKdvkod4 { get; set; }

    [Column("fmyb_kdv_ozelmatrah_isk_kodu")]
    [StringLength(25)]
    public string? FmybKdvOzelmatrahIskKodu { get; set; }

    [Column("fmyb_kdv_devreden_kdv_kodu")]
    [StringLength(25)]
    public string? FmybKdvDevredenKdvKodu { get; set; }

    [Column("fmyb_kdv_zmat_dholm_bedel_kodu")]
    [StringLength(25)]
    public string? FmybKdvZmatDholmBedelKodu { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu1")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu1 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu2")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu2 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu3")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu3 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu4")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu4 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu5")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu5 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu6")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu6 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu7")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu7 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu8")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu8 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu9")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu9 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu10")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu10 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu11")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu11 { get; set; }

    [Column("fmyb_kdv_kredi_kart_kodu12")]
    [StringLength(25)]
    public string? FmybKdvKrediKartKodu12 { get; set; }

    [Column("fmyb_kdv_isl_onceki_donemi_oku")]
    public bool? FmybKdvIslOncekiDonemiOku { get; set; }

    [Column("fmyb_dig_ilave_kdv_kodu")]
    [StringLength(25)]
    public string? FmybDigIlaveKdvKodu { get; set; }

    [Column("fmyb_ihracat_donem_iade_Kdv_kodu")]
    [StringLength(25)]
    public string? FmybIhracatDonemIadeKdvKodu { get; set; }

    [Column("fmyb_kdv2_tam_tevk_vergi1")]
    public byte? FmybKdv2TamTevkVergi1 { get; set; }

    [Column("fmyb_kdv2_tam_tevk_vergi2")]
    public byte? FmybKdv2TamTevkVergi2 { get; set; }

    [Column("fmyb_kdv2_tam_tevk_vergi3")]
    public byte? FmybKdv2TamTevkVergi3 { get; set; }

    [Column("fmyb_kdv2_tam_tevk_vergi4")]
    public byte? FmybKdv2TamTevkVergi4 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi1")]
    public byte? FmybKdv2KismiTevkVergi1 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi2")]
    public byte? FmybKdv2KismiTevkVergi2 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi3")]
    public byte? FmybKdv2KismiTevkVergi3 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi4")]
    public byte? FmybKdv2KismiTevkVergi4 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi5")]
    public byte? FmybKdv2KismiTevkVergi5 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_vergi6")]
    public byte? FmybKdv2KismiTevkVergi6 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi1")]
    public byte? FmybKdv2KismiTevkTipi1 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi2")]
    public byte? FmybKdv2KismiTevkTipi2 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi3")]
    public byte? FmybKdv2KismiTevkTipi3 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi4")]
    public byte? FmybKdv2KismiTevkTipi4 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi5")]
    public byte? FmybKdv2KismiTevkTipi5 { get; set; }

    [Column("fmyb_kdv2_kismi_tevk_tipi6")]
    public byte? FmybKdv2KismiTevkTipi6 { get; set; }

    [Column("fmyb_kdv_onceki_donem_hesabi")]
    public byte? FmybKdvOncekiDonemHesabi { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip1")]
    public byte? FmybKanunenKabulEdilmeyenTip1 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap1")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap1 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip2")]
    public byte? FmybKanunenKabulEdilmeyenTip2 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap2")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap2 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip3")]
    public byte? FmybKanunenKabulEdilmeyenTip3 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap3")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap3 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip4")]
    public byte? FmybKanunenKabulEdilmeyenTip4 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap4")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap4 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip5")]
    public byte? FmybKanunenKabulEdilmeyenTip5 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap5")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap5 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip6")]
    public byte? FmybKanunenKabulEdilmeyenTip6 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap6")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap6 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip7")]
    public byte? FmybKanunenKabulEdilmeyenTip7 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap7")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap7 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip8")]
    public byte? FmybKanunenKabulEdilmeyenTip8 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap8")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap8 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip9")]
    public byte? FmybKanunenKabulEdilmeyenTip9 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap9")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap9 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip10")]
    public byte? FmybKanunenKabulEdilmeyenTip10 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap10")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap10 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip11")]
    public byte? FmybKanunenKabulEdilmeyenTip11 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap11")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap11 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip12")]
    public byte? FmybKanunenKabulEdilmeyenTip12 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap12")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap12 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip13")]
    public byte? FmybKanunenKabulEdilmeyenTip13 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap13")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap13 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip14")]
    public byte? FmybKanunenKabulEdilmeyenTip14 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap14")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap14 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_tip15")]
    public byte? FmybKanunenKabulEdilmeyenTip15 { get; set; }

    [Column("fmyb_kanunen_kabul_edilmeyen_hesap15")]
    [StringLength(127)]
    public string? FmybKanunenKabulEdilmeyenHesap15 { get; set; }
}
