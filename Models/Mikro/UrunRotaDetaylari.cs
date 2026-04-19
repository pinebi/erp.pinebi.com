using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("urun_rota_detaylari")]
public class UrunRotaDetaylari
{
    [Column("urd_Guid")]
    public Guid? UrdGuid { get; set; }

    [Column("urd_DBCno")]
    public short? UrdDBCno { get; set; }

    [Column("urd_SpecRECNo")]
    public int? UrdSpecRECNo { get; set; }

    [Column("urd_iptal")]
    public bool? UrdIptal { get; set; }

    [Column("urd_fileid")]
    public short? UrdFileid { get; set; }

    [Column("urd_hidden")]
    public bool? UrdHidden { get; set; }

    [Column("urd_kilitli")]
    public bool? UrdKilitli { get; set; }

    [Column("urd_degisti")]
    public bool? UrdDegisti { get; set; }

    [Column("urd_checksum")]
    public int? UrdChecksum { get; set; }

    [Column("urd_create_user")]
    public short? UrdCreateUser { get; set; }

    [Column("urd_create_date")]
    public DateTime? UrdCreateDate { get; set; }

    [Column("urd_lastup_user")]
    public short? UrdLastupUser { get; set; }

    [Column("urd_lastup_date")]
    public DateTime? UrdLastupDate { get; set; }

    [Column("urd_special1")]
    [StringLength(4)]
    public string? UrdSpecial1 { get; set; }

    [Column("urd_special2")]
    [StringLength(4)]
    public string? UrdSpecial2 { get; set; }

    [Column("urd_special3")]
    [StringLength(4)]
    public string? UrdSpecial3 { get; set; }

    [Column("urd_BagliRota_uid")]
    public Guid? UrdBagliRotaUid { get; set; }

    [Column("urd_DetaySatirNo")]
    public int? UrdDetaySatirNo { get; set; }

    [Column("urd_KriterDegeri1")]
    public byte? UrdKriterDegeri1 { get; set; }

    [Column("urd_MaxDeger1")]
    public double? UrdMaxDeger1 { get; set; }

    [Column("urd_MinDeger1")]
    public double? UrdMinDeger1 { get; set; }

    [Column("urd_KriterDegeri2")]
    public byte? UrdKriterDegeri2 { get; set; }

    [Column("urd_MaxDeger2")]
    public double? UrdMaxDeger2 { get; set; }

    [Column("urd_MinDeger2")]
    public double? UrdMinDeger2 { get; set; }

    [Column("urd_KriterDegeri3")]
    public byte? UrdKriterDegeri3 { get; set; }

    [Column("urd_MaxDeger3")]
    public double? UrdMaxDeger3 { get; set; }

    [Column("urd_MinDeger3")]
    public double? UrdMinDeger3 { get; set; }

    [Column("urd_ismerkezi_tipi")]
    public byte? UrdIsmerkeziTipi { get; set; }

    [Column("urd_IsmerkeziveyaGrupKod")]
    [StringLength(25)]
    public string? UrdIsmerkeziveyaGrupKod { get; set; }

    [Column("urd_SabitHazirlikSuresi")]
    public int? UrdSabitHazirlikSuresi { get; set; }

    [Column("urd_DegiskenOperasyonSuresi")]
    public int? UrdDegiskenOperasyonSuresi { get; set; }

    [Column("urd_SabitOperasyonSuresi")]
    public int? UrdSabitOperasyonSuresi { get; set; }

    [Column("urd_UretimMiktari")]
    public double? UrdUretimMiktari { get; set; }

    [Column("urd_CikisPartiMiktari")]
    public double? UrdCikisPartiMiktari { get; set; }

    [Column("urd_Enerji1_miktari")]
    public double? UrdEnerji1Miktari { get; set; }

    [Column("urd_Enerji2_miktari")]
    public double? UrdEnerji2Miktari { get; set; }

    [Column("urd_Aciklama")]
    [StringLength(80)]
    public string? UrdAciklama { get; set; }

    [Column("urd_CalisanSayisi")]
    public short? UrdCalisanSayisi { get; set; }

    [Column("urd_KalipKodu")]
    [StringLength(25)]
    public string? UrdKalipKodu { get; set; }

    [Column("urd_HazirlikElemanIhtiyaci")]
    public double? UrdHazirlikElemanIhtiyaci { get; set; }

    [Column("urd_OperasyonElemanIhtiyaci")]
    public double? UrdOperasyonElemanIhtiyaci { get; set; }
}
