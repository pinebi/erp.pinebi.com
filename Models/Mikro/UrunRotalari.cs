using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("urun_rotalari")]
public class UrunRotalari
{
    [Column("URt_Guid")]
    public Guid? URtGuid { get; set; }

    [Column("URt_DBCno")]
    public short? URtDBCno { get; set; }

    [Column("URt_SpecRECNo")]
    public int? URtSpecRECNo { get; set; }

    [Column("URt_iptal")]
    public bool? URtIptal { get; set; }

    [Column("URt_fileid")]
    public short? URtFileid { get; set; }

    [Column("URt_hidden")]
    public bool? URtHidden { get; set; }

    [Column("URt_kilitli")]
    public bool? URtKilitli { get; set; }

    [Column("URt_degisti")]
    public bool? URtDegisti { get; set; }

    [Column("URt_checksum")]
    public int? URtChecksum { get; set; }

    [Column("URt_create_user")]
    public short? URtCreateUser { get; set; }

    [Column("URt_create_date")]
    public DateTime? URtCreateDate { get; set; }

    [Column("URt_lastup_user")]
    public short? URtLastupUser { get; set; }

    [Column("URt_lastup_date")]
    public DateTime? URtLastupDate { get; set; }

    [Column("URt_special1")]
    [StringLength(4)]
    public string? URtSpecial1 { get; set; }

    [Column("URt_special2")]
    [StringLength(4)]
    public string? URtSpecial2 { get; set; }

    [Column("URt_special3")]
    [StringLength(4)]
    public string? URtSpecial3 { get; set; }

    [Column("URt_RotaUrunKodu")]
    [StringLength(25)]
    public string? URtRotaUrunKodu { get; set; }

    [Column("URt_cinsi")]
    public byte? URtCinsi { get; set; }

    [Column("URt_SatirNo")]
    public int? URtSatirNo { get; set; }

    [Column("URt_ID")]
    public short? URtID { get; set; }

    [Column("URt_BagliRotaID")]
    public short? URtBagliRotaID { get; set; }

    [Column("URt_OpKod")]
    [StringLength(25)]
    public string? URtOpKod { get; set; }

    [Column("URt_RotaIsMerkeziveSureTespitTipi")]
    public byte? URtRotaIsMerkeziveSureTespitTipi { get; set; }

    [Column("URt_ismerkezi_tipi")]
    public byte? URtIsmerkeziTipi { get; set; }

    [Column("URt_ismerkeziveyaGrupKod")]
    [StringLength(25)]
    public string? URtIsmerkeziveyaGrupKod { get; set; }

    [Column("URt_SabitHazirlikSuresi")]
    public int? URtSabitHazirlikSuresi { get; set; }

    [Column("URt_DegiskenOperasyonSuresi")]
    public int? URtDegiskenOperasyonSuresi { get; set; }

    [Column("URt_UretimMiktari")]
    public double? URtUretimMiktari { get; set; }

    [Column("URt_SabitOperasyonSuresi")]
    public int? URtSabitOperasyonSuresi { get; set; }

    [Column("URt_CikisPartiMiktari")]
    public double? URtCikisPartiMiktari { get; set; }

    [Column("URt_OperasyonSureCarpani")]
    public double? URtOperasyonSureCarpani { get; set; }

    [Column("URt_OperasyonTekrarSayisi")]
    public byte? URtOperasyonTekrarSayisi { get; set; }

    [Column("URt_Enerji1_miktari")]
    public double? URtEnerji1Miktari { get; set; }

    [Column("URt_Enerji2_miktari")]
    public double? URtEnerji2Miktari { get; set; }

    [Column("URt_Aciklama")]
    [StringLength(80)]
    public string? URtAciklama { get; set; }

    [Column("URt_CalisanSayisi")]
    public short? URtCalisanSayisi { get; set; }

    [Column("URt_KalipKodu")]
    [StringLength(25)]
    public string? URtKalipKodu { get; set; }

    [Column("URt_HazirlikElemanIhtiyaci")]
    public double? URtHazirlikElemanIhtiyaci { get; set; }

    [Column("URt_OperasyonElemanIhtiyaci")]
    public double? URtOperasyonElemanIhtiyaci { get; set; }
}
