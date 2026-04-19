using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_rota_planlari")]
public class UretimRotaPlanlari
{
    [Column("RtP_Guid")]
    public Guid? RtPGuid { get; set; }

    [Column("RtP_DBCno")]
    public short? RtPDBCno { get; set; }

    [Column("RtP_SpecRECNo")]
    public int? RtPSpecRECNo { get; set; }

    [Column("RtP_iptal")]
    public bool? RtPIptal { get; set; }

    [Column("RtP_fileid")]
    public short? RtPFileid { get; set; }

    [Column("RtP_hidden")]
    public bool? RtPHidden { get; set; }

    [Column("RtP_kilitli")]
    public bool? RtPKilitli { get; set; }

    [Column("RtP_degistir")]
    public bool? RtPDegistir { get; set; }

    [Column("RtP_checksum")]
    public int? RtPChecksum { get; set; }

    [Column("RtP_create_user")]
    public short? RtPCreateUser { get; set; }

    [Column("RtP_create_date")]
    public DateTime? RtPCreateDate { get; set; }

    [Column("RtP_lastup_user")]
    public short? RtPLastupUser { get; set; }

    [Column("RtP_lastup_date")]
    public DateTime? RtPLastupDate { get; set; }

    [Column("RtP_special1")]
    [StringLength(4)]
    public string? RtPSpecial1 { get; set; }

    [Column("RtP_special2")]
    [StringLength(4)]
    public string? RtPSpecial2 { get; set; }

    [Column("RtP_special3")]
    [StringLength(4)]
    public string? RtPSpecial3 { get; set; }

    [Column("RtP_IsEmriKodu")]
    [StringLength(25)]
    public string? RtPIsEmriKodu { get; set; }

    [Column("RtP_SatirNo")]
    public int? RtPSatirNo { get; set; }

    [Column("RtP_UrunKodu")]
    [StringLength(25)]
    public string? RtPUrunKodu { get; set; }

    [Column("RtP_OperasyonSafhaNo")]
    public short? RtPOperasyonSafhaNo { get; set; }

    [Column("RtP_OperasyonKodu")]
    [StringLength(25)]
    public string? RtPOperasyonKodu { get; set; }

    [Column("RtP_PlanlananSure")]
    public int? RtPPlanlananSure { get; set; }

    [Column("RtP_TamamlananSure")]
    public int? RtPTamamlananSure { get; set; }

    [Column("RtP_PlanlananMiktar")]
    public double? RtPPlanlananMiktar { get; set; }

    [Column("RtP_TamamlananMiktar")]
    public double? RtPTamamlananMiktar { get; set; }

    [Column("Rtp_PlanlananBaslamaTarihi")]
    public DateTime? RtpPlanlananBaslamaTarihi { get; set; }

    [Column("RtP_PlanlananIsMerkezi")]
    [StringLength(25)]
    public string? RtPPlanlananIsMerkezi { get; set; }

    [Column("RtP_OperasyonDetayPtr")]
    public int? RtPOperasyonDetayPtr { get; set; }

    [Column("RtP_BozukMiktar")]
    public double? RtPBozukMiktar { get; set; }

    [Column("RtP_SonrakiSafhaNo")]
    public short? RtPSonrakiSafhaNo { get; set; }

    [Column("RtP_PlanlananSetupSuresi")]
    public int? RtPPlanlananSetupSuresi { get; set; }

    [Column("RtP_TamamlananSetupSuresi")]
    public int? RtPTamamlananSetupSuresi { get; set; }

    [Column("RtP_Kapandi_fl")]
    public bool? RtPKapandiFl { get; set; }

    [Column("RtP_Aciklama")]
    [StringLength(80)]
    public string? RtPAciklama { get; set; }

    [Column("RtP_PlanlananEnerji1")]
    public double? RtPPlanlananEnerji1 { get; set; }

    [Column("RtP_TuketilenEnerji1")]
    public double? RtPTuketilenEnerji1 { get; set; }

    [Column("RtP_PlanlananEnerji2")]
    public double? RtPPlanlananEnerji2 { get; set; }

    [Column("RtP_TuketilenEnerji2")]
    public double? RtPTuketilenEnerji2 { get; set; }

    [Column("RtP_CikisPartiMiktari")]
    public double? RtPCikisPartiMiktari { get; set; }

    [Column("RtP_CalisanSayisi")]
    public short? RtPCalisanSayisi { get; set; }

    [Column("RtP_PlanlananKalipKodu")]
    [StringLength(25)]
    public string? RtPPlanlananKalipKodu { get; set; }

    [Column("RtP_PlanlananHazirlikElemanIhtiyaci")]
    public double? RtPPlanlananHazirlikElemanIhtiyaci { get; set; }

    [Column("RtP_PlanlananOperasyonElemanIhtiyaci")]
    public double? RtPPlanlananOperasyonElemanIhtiyaci { get; set; }

    [Column("RtP_Kilitli_fl")]
    public bool? RtPKilitliFl { get; set; }

    [Column("RtP_Is_Zamani_Belirli_fl")]
    public bool? RtPIsZamaniBelirliFl { get; set; }

    [Column("RtP_Basladi_fl")]
    public bool? RtPBasladiFl { get; set; }

    [Column("RtP_Setup_Bitti_fl")]
    public bool? RtPSetupBittiFl { get; set; }

    [Column("RtP_Bitti_fl")]
    public bool? RtPBittiFl { get; set; }

    [Column("RtP_PlanlananBitisTarihi")]
    public DateTime? RtPPlanlananBitisTarihi { get; set; }
}
