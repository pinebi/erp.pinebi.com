using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyon_detaylari")]
public class UretimOperasyonDetaylari
{
    [Column("Opd_Guid")]
    public Guid? OpdGuid { get; set; }

    [Column("Opd_DBCno")]
    public short? OpdDBCno { get; set; }

    [Column("Opd_SpecRECNo")]
    public int? OpdSpecRECNo { get; set; }

    [Column("Opd_iptal")]
    public bool? OpdIptal { get; set; }

    [Column("Opd_fileid")]
    public short? OpdFileid { get; set; }

    [Column("Opd_hidden")]
    public bool? OpdHidden { get; set; }

    [Column("Opd_kilitli")]
    public bool? OpdKilitli { get; set; }

    [Column("Opd_degisti")]
    public bool? OpdDegisti { get; set; }

    [Column("Opd_CheckSum")]
    public int? OpdCheckSum { get; set; }

    [Column("Opd_create_user")]
    public short? OpdCreateUser { get; set; }

    [Column("Opd_create_date")]
    public DateTime? OpdCreateDate { get; set; }

    [Column("Opd_lastup_user")]
    public short? OpdLastupUser { get; set; }

    [Column("Opd_lastup_date")]
    public DateTime? OpdLastupDate { get; set; }

    [Column("Opd_special1")]
    [StringLength(4)]
    public string? OpdSpecial1 { get; set; }

    [Column("Opd_special2")]
    [StringLength(4)]
    public string? OpdSpecial2 { get; set; }

    [Column("Opd_special3")]
    [StringLength(4)]
    public string? OpdSpecial3 { get; set; }

    [Column("Opd_OpKodu")]
    [StringLength(25)]
    public string? OpdOpKodu { get; set; }

    [Column("Opd_SatirNo")]
    public int? OpdSatirNo { get; set; }

    [Column("Opd_Oncelik")]
    public byte? OpdOncelik { get; set; }

    [Column("Opd_Asgari_Miktar")]
    public double? OpdAsgariMiktar { get; set; }

    [Column("Opd_Azami_Miktar")]
    public double? OpdAzamiMiktar { get; set; }

    [Column("Opd_ismerkezi_tipi")]
    public byte? OpdIsmerkeziTipi { get; set; }

    [Column("Opd_IsmerkeziorGrupKod")]
    [StringLength(25)]
    public string? OpdIsmerkeziorGrupKod { get; set; }

    [Column("Opd_SabitHazirlikSuresi")]
    public int? OpdSabitHazirlikSuresi { get; set; }

    [Column("Opd_OperasyonSuresi")]
    public int? OpdOperasyonSuresi { get; set; }

    [Column("Opd_UretimMiktari")]
    public double? OpdUretimMiktari { get; set; }

    [Column("Opd_SabitOperasyonSuresi")]
    public int? OpdSabitOperasyonSuresi { get; set; }

    [Column("Opd_KalipKodu")]
    [StringLength(25)]
    public string? OpdKalipKodu { get; set; }

    [Column("Opd_HazirlikElemanIhtiyaci")]
    public double? OpdHazirlikElemanIhtiyaci { get; set; }

    [Column("Opd_OperasyonElemanIhtiyaci")]
    public double? OpdOperasyonElemanIhtiyaci { get; set; }
}
