using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("gider_katilim_sozlesmeleri")]
public class GiderKatilimSozlesmeleri
{
    [Column("gks_Guid")]
    public Guid? GksGuid { get; set; }

    [Column("gks_DBCno")]
    public short? GksDBCno { get; set; }

    [Column("gks_Spec_Rec_no")]
    public int? GksSpecRecNo { get; set; }

    [Column("gks_iptal")]
    public bool? GksIptal { get; set; }

    [Column("gks_fileid")]
    public short? GksFileid { get; set; }

    [Column("gks_hidden")]
    public bool? GksHidden { get; set; }

    [Column("gks_kilitli")]
    public bool? GksKilitli { get; set; }

    [Column("gks_degisti")]
    public bool? GksDegisti { get; set; }

    [Column("gks_CheckSum")]
    public int? GksCheckSum { get; set; }

    [Column("gks_create_user")]
    public short? GksCreateUser { get; set; }

    [Column("gks_create_date")]
    public DateTime? GksCreateDate { get; set; }

    [Column("gks_lastup_user")]
    public short? GksLastupUser { get; set; }

    [Column("gks_lastup_date")]
    public DateTime? GksLastupDate { get; set; }

    [Column("gks_special1")]
    [StringLength(4)]
    public string? GksSpecial1 { get; set; }

    [Column("gks_special2")]
    [StringLength(4)]
    public string? GksSpecial2 { get; set; }

    [Column("gks_special3")]
    [StringLength(4)]
    public string? GksSpecial3 { get; set; }

    [Column("gks_firmano")]
    public int? GksFirmano { get; set; }

    [Column("gks_subeno")]
    public int? GksSubeno { get; set; }

    [Column("gks_evraktarihi")]
    public DateTime? GksEvraktarihi { get; set; }

    [Column("gks_evrakseri")]
    [StringLength(50)]
    public string? GksEvrakseri { get; set; }

    [Column("gks_evraksira")]
    public int? GksEvraksira { get; set; }

    [Column("gks_evraksatir")]
    public int? GksEvraksatir { get; set; }

    [Column("gks_carikodu")]
    [StringLength(25)]
    public string? GksCarikodu { get; set; }

    [Column("gks_grupno")]
    public byte? GksGrupno { get; set; }

    [Column("gks_carisrmmrk")]
    [StringLength(25)]
    public string? GksCarisrmmrk { get; set; }

    [Column("gks_proje")]
    [StringLength(25)]
    public string? GksProje { get; set; }

    [Column("gks_hizmetkodu")]
    [StringLength(25)]
    public string? GksHizmetkodu { get; set; }

    [Column("gks_srmmrkkodu")]
    [StringLength(25)]
    public string? GksSrmmrkkodu { get; set; }

    [Column("gks_gecerliliktarihi")]
    public DateTime? GksGecerliliktarihi { get; set; }

    [Column("gks_aciklama")]
    [StringLength(40)]
    public string? GksAciklama { get; set; }

    [Column("gks_tipi")]
    public byte? GksTipi { get; set; }

    [Column("gks_miktar")]
    public double? GksMiktar { get; set; }

    [Column("gks_karorani")]
    public double? GksKarorani { get; set; }

    [Column("gks_sabittutar")]
    public double? GksSabittutar { get; set; }

    [Column("gks_dagitimanahtari")]
    [StringLength(25)]
    public string? GksDagitimanahtari { get; set; }

    [Column("gks_mintutar")]
    public double? GksMintutar { get; set; }

    [Column("gks_maxtutar")]
    public double? GksMaxtutar { get; set; }

    [Column("gks_opno")]
    public int? GksOpno { get; set; }

    [Column("gks_kesfatseri")]
    [StringLength(50)]
    public string? GksKesfatseri { get; set; }

    [Column("gks_kesfatsira")]
    public int? GksKesfatsira { get; set; }
}
