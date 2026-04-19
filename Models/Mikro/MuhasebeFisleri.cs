using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_fisleri")]
public class MuhasebeFisleri
{
    [Column("fis_Guid")]
    public Guid FisGuid { get; set; }

    [Column("fis_DBCno")]
    public short? FisDBCno { get; set; }

    [Column("fis_SpecRECno")]
    public int? FisSpecRECno { get; set; }

    [Column("fis_iptal")]
    public bool? FisIptal { get; set; }

    [Column("fis_fileid")]
    public short? FisFileid { get; set; }

    [Column("fis_hidden")]
    public bool? FisHidden { get; set; }

    [Column("fis_kilitli")]
    public bool? FisKilitli { get; set; }

    [Column("fis_degisti")]
    public bool? FisDegisti { get; set; }

    [Column("fis_checksum")]
    public int? FisChecksum { get; set; }

    [Column("fis_create_user")]
    public short? FisCreateUser { get; set; }

    [Column("fis_create_date")]
    public DateTime? FisCreateDate { get; set; }

    [Column("fis_lastup_user")]
    public short? FisLastupUser { get; set; }

    [Column("fis_lastup_date")]
    public DateTime? FisLastupDate { get; set; }

    [Column("fis_special1")]
    [StringLength(4)]
    public string? FisSpecial1 { get; set; }

    [Column("fis_special2")]
    [StringLength(4)]
    public string? FisSpecial2 { get; set; }

    [Column("fis_special3")]
    [StringLength(4)]
    public string? FisSpecial3 { get; set; }

    [Column("fis_firmano")]
    public int? FisFirmano { get; set; }

    [Column("fis_subeno")]
    public int? FisSubeno { get; set; }

    [Column("fis_maliyil")]
    public int? FisMaliyil { get; set; }

    [Column("fis_tarih")]
    public DateTime? FisTarih { get; set; }

    [Column("fis_sira_no")]
    public int? FisSiraNo { get; set; }

    [Column("fis_tur")]
    public byte? FisTur { get; set; }

    [Column("fis_hesap_kod")]
    [StringLength(25)]
    public string? FisHesapKod { get; set; }

    [Column("fis_satir_no")]
    public int? FisSatirNo { get; set; }

    [Column("fis_aciklama1")]
    [StringLength(127)]
    public string? FisAciklama1 { get; set; }

    [Column("fis_meblag0")]
    public double? FisMeblag0 { get; set; }

    [Column("fis_meblag1")]
    public double? FisMeblag1 { get; set; }

    [Column("fis_meblag2")]
    public double? FisMeblag2 { get; set; }

    [Column("fis_meblag3")]
    public double? FisMeblag3 { get; set; }

    [Column("fis_meblag4")]
    public double? FisMeblag4 { get; set; }

    [Column("fis_meblag5")]
    public double? FisMeblag5 { get; set; }

    [Column("fis_meblag6")]
    public double? FisMeblag6 { get; set; }

    [Column("fis_sorumluluk_kodu")]
    [StringLength(25)]
    public string? FisSorumlulukKodu { get; set; }

    [Column("fis_ticari_tip")]
    public byte? FisTicariTip { get; set; }

    [Column("fis_ticari_uid")]
    public Guid? FisTicariUid { get; set; }

    [Column("fis_kurfarkifl")]
    public bool? FisKurfarkifl { get; set; }

    [Column("fis_ticari_evraktip")]
    public byte? FisTicariEvraktip { get; set; }

    [Column("fis_tic_evrak_seri")]
    [StringLength(5)]
    public string? FisTicEvrakSeri { get; set; }

    [Column("fis_tic_evrak_sira")]
    public int? FisTicEvrakSira { get; set; }

    [Column("fis_tic_belgeno")]
    [StringLength(25)]
    public string? FisTicBelgeno { get; set; }

    [Column("fis_tic_belgetarihi")]
    public DateTime? FisTicBelgetarihi { get; set; }

    [Column("fis_yevmiye_no")]
    public int? FisYevmiyeNo { get; set; }

    [Column("fis_katagori")]
    public short? FisKatagori { get; set; }

    [Column("fis_evrak_DBCno")]
    public short? FisEvrakDBCno { get; set; }

    [Column("fis_fmahsup_tipi")]
    public byte? FisFmahsupTipi { get; set; }

    [Column("fis_fozelmahkod")]
    [StringLength(25)]
    public string? FisFozelmahkod { get; set; }

    [Column("fis_grupkodu")]
    [StringLength(4)]
    public string? FisGrupkodu { get; set; }

    [Column("fis_aktif_pasif")]
    public byte? FisAktifPasif { get; set; }

    [Column("fis_proje_kodu")]
    [StringLength(25)]
    public string? FisProjeKodu { get; set; }
}
