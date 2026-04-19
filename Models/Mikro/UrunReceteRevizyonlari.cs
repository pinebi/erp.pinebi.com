using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("urun_recete_revizyonlari")]
public class UrunReceteRevizyonlari
{
    [Column("urr_Guid")]
    public Guid? UrrGuid { get; set; }

    [Column("urr_DBCno")]
    public short? UrrDBCno { get; set; }

    [Column("urr_SpecRECno")]
    public int? UrrSpecRECno { get; set; }

    [Column("urr_iptal")]
    public bool? UrrIptal { get; set; }

    [Column("urr_fileid")]
    public short? UrrFileid { get; set; }

    [Column("urr_hidden")]
    public bool? UrrHidden { get; set; }

    [Column("urr_kilitli")]
    public bool? UrrKilitli { get; set; }

    [Column("urr_degisti")]
    public bool? UrrDegisti { get; set; }

    [Column("urr_checksum")]
    public int? UrrChecksum { get; set; }

    [Column("urr_create_user")]
    public short? UrrCreateUser { get; set; }

    [Column("urr_create_date")]
    public DateTime? UrrCreateDate { get; set; }

    [Column("urr_lastup_user")]
    public short? UrrLastupUser { get; set; }

    [Column("urr_lastup_date")]
    public DateTime? UrrLastupDate { get; set; }

    [Column("urr_special1")]
    [StringLength(4)]
    public string? UrrSpecial1 { get; set; }

    [Column("urr_special2")]
    [StringLength(4)]
    public string? UrrSpecial2 { get; set; }

    [Column("urr_special3")]
    [StringLength(4)]
    public string? UrrSpecial3 { get; set; }

    [Column("urr_anatipi")]
    public byte? UrrAnatipi { get; set; }

    [Column("urr_anakod")]
    [StringLength(25)]
    public string? UrrAnakod { get; set; }

    [Column("urr_tanimkod")]
    [StringLength(25)]
    public string? UrrTanimkod { get; set; }

    [Column("urr_cinsi")]
    public byte? UrrCinsi { get; set; }

    [Column("urr_recete_degisti")]
    public bool? UrrReceteDegisti { get; set; }

    [Column("urr_rota_degisti")]
    public bool? UrrRotaDegisti { get; set; }

    [Column("urr_recete_revizyon_no")]
    public int? UrrReceteRevizyonNo { get; set; }

    [Column("urr_rota_revizyon_no")]
    public int? UrrRotaRevizyonNo { get; set; }

    [Column("urr_revizyon_tarihi")]
    public DateTime? UrrRevizyonTarihi { get; set; }

    [Column("urr_revizyon_aciklama")]
    [StringLength(127)]
    public string? UrrRevizyonAciklama { get; set; }

    [Column("urr_rec_Guid")]
    public Guid? UrrRecGuid { get; set; }

    [Column("urr_rec_DBCno")]
    public short? UrrRecDBCno { get; set; }

    [Column("urr_rec_SpecRECno")]
    public int? UrrRecSpecRECno { get; set; }

    [Column("urr_rec_iptal")]
    public bool? UrrRecIptal { get; set; }

    [Column("urr_rec_fileid")]
    public short? UrrRecFileid { get; set; }

    [Column("urr_rec_hidden")]
    public bool? UrrRecHidden { get; set; }

    [Column("urr_rec_kilitli")]
    public bool? UrrRecKilitli { get; set; }

    [Column("urr_rec_degisti")]
    public bool? UrrRecDegisti { get; set; }

    [Column("urr_rec_checksum")]
    public int? UrrRecChecksum { get; set; }

    [Column("urr_rec_create_user")]
    public short? UrrRecCreateUser { get; set; }

    [Column("urr_rec_create_date")]
    public DateTime? UrrRecCreateDate { get; set; }

    [Column("urr_rec_lastup_user")]
    public short? UrrRecLastupUser { get; set; }

    [Column("urr_rec_lastup_date")]
    public DateTime? UrrRecLastupDate { get; set; }

    [Column("urr_rec_special1")]
    [StringLength(4)]
    public string? UrrRecSpecial1 { get; set; }

    [Column("urr_rec_special2")]
    [StringLength(4)]
    public string? UrrRecSpecial2 { get; set; }

    [Column("urr_rec_special3")]
    [StringLength(4)]
    public string? UrrRecSpecial3 { get; set; }

    [Column("urr_rec_anatipi")]
    public byte? UrrRecAnatipi { get; set; }

    [Column("urr_rec_anakod")]
    [StringLength(25)]
    public string? UrrRecAnakod { get; set; }

    [Column("urr_rec_tanimkod")]
    [StringLength(25)]
    public string? UrrRecTanimkod { get; set; }

    [Column("urr_rec_cinsi")]
    public byte? UrrRecCinsi { get; set; }

    [Column("urr_tarih")]
    public DateTime? UrrTarih { get; set; }

    [Column("urr_rec_aciklama")]
    [StringLength(127)]
    public string? UrrRecAciklama { get; set; }

    [Column("urr_rec_anabirim")]
    public byte? UrrRecAnabirim { get; set; }

    [Column("urr_anamiktar")]
    public double? UrrAnamiktar { get; set; }

    [Column("urr_rec_tuketim_tur")]
    public byte? UrrRecTuketimTur { get; set; }

    [Column("urr_rec_tuketim_kod")]
    [StringLength(25)]
    public string? UrrRecTuketimKod { get; set; }

    [Column("urr_rec_tuketim_tanim_kodu")]
    [StringLength(25)]
    public string? UrrRecTuketimTanimKodu { get; set; }

    [Column("urr_rec_tuketim_recete_cinsi")]
    public byte? UrrRecTuketimReceteCinsi { get; set; }

    [Column("urr_rec_tuketim_miktar")]
    public double? UrrRecTuketimMiktar { get; set; }

    [Column("urr_rec_tuketim_birim")]
    public byte? UrrRecTuketimBirim { get; set; }

    [Column("urr_rec_uretim_tuketim")]
    public byte? UrrRecUretimTuketim { get; set; }

    [Column("urr_rec_satirno")]
    public int? UrrRecSatirno { get; set; }

    [Column("urr_rec_satir_acik")]
    [StringLength(127)]
    public string? UrrRecSatirAcik { get; set; }

    [Column("urr_rec_depono")]
    public int? UrrRecDepono { get; set; }

    [Column("urr_rec_fireyuzde")]
    public double? UrrRecFireyuzde { get; set; }

    [Column("urr_rec_baslama_tarihi")]
    public DateTime? UrrRecBaslamaTarihi { get; set; }

    [Column("urr_rec_bitis_tarihi")]
    public DateTime? UrrRecBitisTarihi { get; set; }

    [Column("urr_rec_alt_tukkod1")]
    [StringLength(25)]
    public string? UrrRecAltTukkod1 { get; set; }

    [Column("urr_rec_alt_1_katsayi")]
    public double? UrrRecAlt1Katsayi { get; set; }

    [Column("urr_rec_alt_tukkod2")]
    [StringLength(25)]
    public string? UrrRecAltTukkod2 { get; set; }

    [Column("urr_rec_alt_2_katsayi")]
    public double? UrrRecAlt2Katsayi { get; set; }

    [Column("urr_rec_alt_tukkod3")]
    [StringLength(25)]
    public string? UrrRecAltTukkod3 { get; set; }

    [Column("urr_rec_alt_3_katsayi")]
    public double? UrrRecAlt3Katsayi { get; set; }

    [Column("urr_rec_alt_tukkod4")]
    [StringLength(25)]
    public string? UrrRecAltTukkod4 { get; set; }

    [Column("urr_rec_alt_4_katsayi")]
    public double? UrrRecAlt4Katsayi { get; set; }

    [Column("urr_rec_alt_tukkod5")]
    [StringLength(25)]
    public string? UrrRecAltTukkod5 { get; set; }

    [Column("urr_rec_alt_5_katsayi")]
    public double? UrrRecAlt5Katsayi { get; set; }

    [Column("urr_rec_safha_no")]
    public short? UrrRecSafhaNo { get; set; }

    [Column("urr_rec_safha_turu")]
    public byte? UrrRecSafhaTuru { get; set; }

    [Column("urr_rec_ana_renk_no")]
    public byte? UrrRecAnaRenkNo { get; set; }

    [Column("urr_rec_ana_beden_no")]
    public byte? UrrRecAnaBedenNo { get; set; }

    [Column("urr_rec_tuketim_renk_no")]
    public byte? UrrRecTuketimRenkNo { get; set; }

    [Column("urr_rec_tuketim_beden_no")]
    public byte? UrrRecTuketimBedenNo { get; set; }

    [Column("urr_rec_PlanlamaTipi")]
    public byte? UrrRecPlanlamaTipi { get; set; }

    [Column("urr_rec_eklenme_sarti")]
    public byte? UrrRecEklenmeSarti { get; set; }

    [Column("urr_rec_miktar_fonksiyon_adi")]
    [StringLength(70)]
    public string? UrrRecMiktarFonksiyonAdi { get; set; }

    [Column("urr_rec_tuketim_recete_revizyon_no")]
    public int? UrrRecTuketimReceteRevizyonNo { get; set; }

    [Column("urr_rec_tuketim_rota_revizyon_no")]
    public int? UrrRecTuketimRotaRevizyonNo { get; set; }

    [Column("urr_URt_Guid")]
    public Guid? UrrURtGuid { get; set; }

    [Column("urr_URt_DBCno")]
    public short? UrrURtDBCno { get; set; }

    [Column("urr_URt_SpecRECNo")]
    public int? UrrURtSpecRECNo { get; set; }

    [Column("urr_URt_iptal")]
    public bool? UrrURtIptal { get; set; }

    [Column("urr_URt_fileid")]
    public short? UrrURtFileid { get; set; }

    [Column("urr_URt_hidden")]
    public bool? UrrURtHidden { get; set; }

    [Column("urr_URt_kilitli")]
    public bool? UrrURtKilitli { get; set; }

    [Column("urr_URt_degisti")]
    public bool? UrrURtDegisti { get; set; }

    [Column("urr_URt_checksum")]
    public int? UrrURtChecksum { get; set; }

    [Column("urr_URt_create_user")]
    public short? UrrURtCreateUser { get; set; }

    [Column("urr_URt_create_date")]
    public DateTime? UrrURtCreateDate { get; set; }

    [Column("urr_URt_lastup_user")]
    public short? UrrURtLastupUser { get; set; }

    [Column("urr_URt_lastup_date")]
    public DateTime? UrrURtLastupDate { get; set; }

    [Column("urr_URt_special1")]
    [StringLength(4)]
    public string? UrrURtSpecial1 { get; set; }

    [Column("urr_URt_special2")]
    [StringLength(4)]
    public string? UrrURtSpecial2 { get; set; }

    [Column("urr_URt_special3")]
    [StringLength(4)]
    public string? UrrURtSpecial3 { get; set; }

    [Column("urr_URt_RotaUrunKodu")]
    [StringLength(25)]
    public string? UrrURtRotaUrunKodu { get; set; }

    [Column("urr_URt_cinsi")]
    public byte? UrrURtCinsi { get; set; }

    [Column("urr_URt_SatirNo")]
    public int? UrrURtSatirNo { get; set; }

    [Column("urr_URt_ID")]
    public short? UrrURtID { get; set; }

    [Column("urr_URt_BagliRotaID")]
    public short? UrrURtBagliRotaID { get; set; }

    [Column("urr_URt_OpKod")]
    [StringLength(25)]
    public string? UrrURtOpKod { get; set; }

    [Column("urr_URt_RotaIsMerkeziveSureTespitTipi")]
    public byte? UrrURtRotaIsMerkeziveSureTespitTipi { get; set; }

    [Column("urr_URt_ismerkezi_tipi")]
    public byte? UrrURtIsmerkeziTipi { get; set; }

    [Column("urr_URt_ismerkeziveyaGrupKod")]
    [StringLength(25)]
    public string? UrrURtIsmerkeziveyaGrupKod { get; set; }

    [Column("urr_URt_SabitHazirlikSuresi")]
    public int? UrrURtSabitHazirlikSuresi { get; set; }

    [Column("urr_URt_DegiskenOperasyonSuresi")]
    public int? UrrURtDegiskenOperasyonSuresi { get; set; }

    [Column("urr_URt_UretimMiktari")]
    public double? UrrURtUretimMiktari { get; set; }

    [Column("urr_URt_SabitOperasyonSuresi")]
    public int? UrrURtSabitOperasyonSuresi { get; set; }

    [Column("urr_URt_CikisPartiMiktari")]
    public double? UrrURtCikisPartiMiktari { get; set; }

    [Column("urr_URt_OperasyonSureCarpani")]
    public double? UrrURtOperasyonSureCarpani { get; set; }

    [Column("urr_URt_OperasyonTekrarSayisi")]
    public byte? UrrURtOperasyonTekrarSayisi { get; set; }

    [Column("urr_URt_Enerji1_miktari")]
    public double? UrrURtEnerji1Miktari { get; set; }

    [Column("urr_URt_Enerji2_miktari")]
    public double? UrrURtEnerji2Miktari { get; set; }

    [Column("urr_URt_Aciklama")]
    [StringLength(80)]
    public string? UrrURtAciklama { get; set; }

    [Column("urr_URt_CalisanSayisi")]
    public short? UrrURtCalisanSayisi { get; set; }

    [Column("urr_URt_KalipKodu")]
    [StringLength(25)]
    public string? UrrURtKalipKodu { get; set; }

    [Column("urr_URt_HazirlikElemanIhtiyaci")]
    public double? UrrURtHazirlikElemanIhtiyaci { get; set; }

    [Column("urr_URt_OperasyonElemanIhtiyaci")]
    public double? UrrURtOperasyonElemanIhtiyaci { get; set; }

    [Column("urr_rk_Guid")]
    public Guid? UrrRkGuid { get; set; }

    [Column("urr_rk_DBCno")]
    public short? UrrRkDBCno { get; set; }

    [Column("urr_rk_SpecRECno")]
    public int? UrrRkSpecRECno { get; set; }

    [Column("urr_rk_iptal")]
    public bool? UrrRkIptal { get; set; }

    [Column("urr_rk_fileid")]
    public short? UrrRkFileid { get; set; }

    [Column("urr_rk_hidden")]
    public bool? UrrRkHidden { get; set; }

    [Column("urr_rk_kilitli")]
    public bool? UrrRkKilitli { get; set; }

    [Column("urr_rk_degisti")]
    public bool? UrrRkDegisti { get; set; }

    [Column("urr_rk_checksum")]
    public int? UrrRkChecksum { get; set; }

    [Column("urr_rk_create_user")]
    public short? UrrRkCreateUser { get; set; }

    [Column("urr_rk_create_date")]
    public DateTime? UrrRkCreateDate { get; set; }

    [Column("urr_rk_lastup_user")]
    public short? UrrRkLastupUser { get; set; }

    [Column("urr_rk_lastup_date")]
    public DateTime? UrrRkLastupDate { get; set; }

    [Column("urr_rk_special1")]
    [StringLength(4)]
    public string? UrrRkSpecial1 { get; set; }

    [Column("urr_rk_special2")]
    [StringLength(4)]
    public string? UrrRkSpecial2 { get; set; }

    [Column("urr_rk_special3")]
    [StringLength(4)]
    public string? UrrRkSpecial3 { get; set; }

    [Column("urr_rk_recete_uid")]
    public Guid? UrrRkReceteUid { get; set; }

    [Column("urr_rk_satirno")]
    public int? UrrRkSatirno { get; set; }

    [Column("urr_rk_tablo")]
    public byte? UrrRkTablo { get; set; }

    [Column("urr_rk_alan_adi")]
    [StringLength(80)]
    public string? UrrRkAlanAdi { get; set; }

    [Column("urr_rk_islem")]
    public byte? UrrRkIslem { get; set; }

    [Column("urr_rk_stringdata")]
    [StringLength(80)]
    public string? UrrRkStringdata { get; set; }

    [Column("urr_rk_baglanti_tipi")]
    public byte? UrrRkBaglantiTipi { get; set; }

    [Column("urr_urd_Guid")]
    public Guid? UrrUrdGuid { get; set; }

    [Column("urr_urd_DBCno")]
    public short? UrrUrdDBCno { get; set; }

    [Column("urr_urd_SpecRECNo")]
    public int? UrrUrdSpecRECNo { get; set; }

    [Column("urr_urd_iptal")]
    public bool? UrrUrdIptal { get; set; }

    [Column("urr_urd_fileid")]
    public short? UrrUrdFileid { get; set; }

    [Column("urr_urd_hidden")]
    public bool? UrrUrdHidden { get; set; }

    [Column("urr_urd_kilitli")]
    public bool? UrrUrdKilitli { get; set; }

    [Column("urr_urd_degisti")]
    public bool? UrrUrdDegisti { get; set; }

    [Column("urr_urd_checksum")]
    public int? UrrUrdChecksum { get; set; }

    [Column("urr_urd_create_user")]
    public short? UrrUrdCreateUser { get; set; }

    [Column("urr_urd_create_date")]
    public DateTime? UrrUrdCreateDate { get; set; }

    [Column("urr_urd_lastup_user")]
    public short? UrrUrdLastupUser { get; set; }

    [Column("urr_urd_lastup_date")]
    public DateTime? UrrUrdLastupDate { get; set; }

    [Column("urr_urd_special1")]
    [StringLength(4)]
    public string? UrrUrdSpecial1 { get; set; }

    [Column("urr_urd_special2")]
    [StringLength(4)]
    public string? UrrUrdSpecial2 { get; set; }

    [Column("urr_urd_special3")]
    [StringLength(4)]
    public string? UrrUrdSpecial3 { get; set; }

    [Column("urr_urd_BagliRota_uid")]
    public Guid? UrrUrdBagliRotaUid { get; set; }

    [Column("urr_urd_DetaySatirNo")]
    public int? UrrUrdDetaySatirNo { get; set; }

    [Column("urr_urd_KriterDegeri1")]
    public byte? UrrUrdKriterDegeri1 { get; set; }

    [Column("urr_urd_MaxDeger1")]
    public double? UrrUrdMaxDeger1 { get; set; }

    [Column("urr_urd_MinDeger1")]
    public double? UrrUrdMinDeger1 { get; set; }

    [Column("urr_urd_KriterDegeri2")]
    public byte? UrrUrdKriterDegeri2 { get; set; }

    [Column("urr_urd_MaxDeger2")]
    public double? UrrUrdMaxDeger2 { get; set; }

    [Column("urr_urd_MinDeger2")]
    public double? UrrUrdMinDeger2 { get; set; }

    [Column("urr_urd_KriterDegeri3")]
    public byte? UrrUrdKriterDegeri3 { get; set; }

    [Column("urr_urd_MaxDeger3")]
    public double? UrrUrdMaxDeger3 { get; set; }

    [Column("urr_urd_MinDeger3")]
    public double? UrrUrdMinDeger3 { get; set; }

    [Column("urr_urd_ismerkezi_tipi")]
    public byte? UrrUrdIsmerkeziTipi { get; set; }

    [Column("urr_urd_IsmerkeziveyaGrupKod")]
    [StringLength(25)]
    public string? UrrUrdIsmerkeziveyaGrupKod { get; set; }

    [Column("urr_urd_SabitHazirlikSuresi")]
    public int? UrrUrdSabitHazirlikSuresi { get; set; }

    [Column("urr_urd_DegiskenOperasyonSuresi")]
    public int? UrrUrdDegiskenOperasyonSuresi { get; set; }

    [Column("urr_urd_SabitOperasyonSuresi")]
    public int? UrrUrdSabitOperasyonSuresi { get; set; }

    [Column("urr_urd_UretimMiktari")]
    public double? UrrUrdUretimMiktari { get; set; }

    [Column("urr_urd_CikisPartiMiktari")]
    public double? UrrUrdCikisPartiMiktari { get; set; }

    [Column("urr_urd_Enerji1_miktari")]
    public double? UrrUrdEnerji1Miktari { get; set; }

    [Column("urr_urd_Enerji2_miktari")]
    public double? UrrUrdEnerji2Miktari { get; set; }

    [Column("urr_urd_Aciklama")]
    [StringLength(80)]
    public string? UrrUrdAciklama { get; set; }

    [Column("urr_urd_CalisanSayisi")]
    public short? UrrUrdCalisanSayisi { get; set; }

    [Column("urr_urd_KalipKodu")]
    [StringLength(25)]
    public string? UrrUrdKalipKodu { get; set; }

    [Column("urr_urd_HazirlikElemanIhtiyaci")]
    public double? UrrUrdHazirlikElemanIhtiyaci { get; set; }

    [Column("urr_urd_OperasyonElemanIhtiyaci")]
    public double? UrrUrdOperasyonElemanIhtiyaci { get; set; }
}
