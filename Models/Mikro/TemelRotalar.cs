using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("temel_rotalar")]
public class TemelRotalar
{
    [Column("Rt_Guid")]
    public Guid? RtGuid { get; set; }

    [Column("Rt_DBCno")]
    public short? RtDBCno { get; set; }

    [Column("Rt_SpecRECNo")]
    public int? RtSpecRECNo { get; set; }

    [Column("Rt_iptal")]
    public bool? RtIptal { get; set; }

    [Column("Rt_fileid")]
    public short? RtFileid { get; set; }

    [Column("Rt_hidden")]
    public bool? RtHidden { get; set; }

    [Column("Rt_kilitli")]
    public bool? RtKilitli { get; set; }

    [Column("Rt_degisti")]
    public bool? RtDegisti { get; set; }

    [Column("Rt_checksum")]
    public int? RtChecksum { get; set; }

    [Column("Rt_create_user")]
    public short? RtCreateUser { get; set; }

    [Column("Rt_create_date")]
    public DateTime? RtCreateDate { get; set; }

    [Column("Rt_lastup_user")]
    public short? RtLastupUser { get; set; }

    [Column("Rt_lastup_date")]
    public DateTime? RtLastupDate { get; set; }

    [Column("Rt_special1")]
    [StringLength(4)]
    public string? RtSpecial1 { get; set; }

    [Column("Rt_special2")]
    [StringLength(4)]
    public string? RtSpecial2 { get; set; }

    [Column("Rt_special3")]
    [StringLength(4)]
    public string? RtSpecial3 { get; set; }

    [Column("Rt_RotaUrunKodu")]
    [StringLength(25)]
    public string? RtRotaUrunKodu { get; set; }

    [Column("Rt_UstAciklama")]
    [StringLength(50)]
    public string? RtUstAciklama { get; set; }

    [Column("Rt_SatirNo")]
    public int? RtSatirNo { get; set; }

    [Column("Rt_ID")]
    public short? RtID { get; set; }

    [Column("Rt_BagliRotaID")]
    public short? RtBagliRotaID { get; set; }

    [Column("Rt_OpKod")]
    [StringLength(25)]
    public string? RtOpKod { get; set; }

    [Column("Rt_RotaIsMerkeziveSureTespitTipi")]
    public byte? RtRotaIsMerkeziveSureTespitTipi { get; set; }

    [Column("Rt_ismerkezi_tipi")]
    public byte? RtIsmerkeziTipi { get; set; }

    [Column("Rt_ismerkeziveyaGrupKod")]
    [StringLength(25)]
    public string? RtIsmerkeziveyaGrupKod { get; set; }

    [Column("Rt_SabitHazirlikSuresi")]
    public int? RtSabitHazirlikSuresi { get; set; }

    [Column("Rt_DegiskenOperasyonSuresi")]
    public int? RtDegiskenOperasyonSuresi { get; set; }

    [Column("Rt_UretimMiktari")]
    public double? RtUretimMiktari { get; set; }

    [Column("Rt_SabitOperasyonSuresi")]
    public int? RtSabitOperasyonSuresi { get; set; }

    [Column("Rt_CikisPartiMiktari")]
    public double? RtCikisPartiMiktari { get; set; }

    [Column("Rt_OperasyonSureCarpani")]
    public double? RtOperasyonSureCarpani { get; set; }

    [Column("Rt_OperasyonTekrarSayisi")]
    public byte? RtOperasyonTekrarSayisi { get; set; }

    [Column("Rt_Enerji1_Miktari")]
    public double? RtEnerji1Miktari { get; set; }

    [Column("Rt_Enerji2_Miktari")]
    public double? RtEnerji2Miktari { get; set; }

    [Column("Rt_Aciklama")]
    [StringLength(80)]
    public string? RtAciklama { get; set; }

    [Column("Rt_CalisanSayisi")]
    public short? RtCalisanSayisi { get; set; }

    [Column("Rt_KalipKodu")]
    [StringLength(25)]
    public string? RtKalipKodu { get; set; }

    [Column("Rt_HazirlikElemanIhtiyaci")]
    public double? RtHazirlikElemanIhtiyaci { get; set; }

    [Column("Rt_OperasyonElemanIhtiyaci")]
    public double? RtOperasyonElemanIhtiyaci { get; set; }
}
