using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Arac;

[Table("pine_arac_takip")]
public class PineAracTakip : BaseEntity
{
    [Column("art_plaka")]
    [StringLength(20)]
    public string? ArtPlaka { get; set; }

    [Column("art_marka")]
    [StringLength(100)]
    public string? ArtMarka { get; set; }

    [Column("art_model")]
    [StringLength(100)]
    public string? ArtModel { get; set; }

    [Column("art_yil")]
    public int ArtYil { get; set; }

    [Column("art_renk")]
    [StringLength(50)]
    public string? ArtRenk { get; set; }

    [Column("art_motor_no")]
    [StringLength(50)]
    public string? ArtMotorNo { get; set; }

    [Column("art_sasi_no")]
    [StringLength(50)]
    public string? ArtSasiNo { get; set; }

    [Column("art_ruhsat_no")]
    [StringLength(50)]
    public string? ArtRuhsatNo { get; set; }

    [Column("art_sigorta_baslangic")]
    public DateTime? ArtSigortaBaslangic { get; set; }

    [Column("art_sigorta_bitis")]
    public DateTime? ArtSigortaBitis { get; set; }

    [Column("art_sigorta_tutar")]
    public decimal? ArtSigortaTutar { get; set; }

    [Column("art_kasko_baslangic")]
    public DateTime? ArtKaskoBaslangic { get; set; }

    [Column("art_kasko_bitis")]
    public DateTime? ArtKaskoBitis { get; set; }

    [Column("art_kasko_tutar")]
    public decimal? ArtKaskoTutar { get; set; }

    [Column("art_muayene_tarihi")]
    public DateTime? ArtMuayeneTarihi { get; set; }

    [Column("art_muayene_bitis")]
    public DateTime? ArtMuayeneBitis { get; set; }

    [Column("art_km")]
    public int? ArtKm { get; set; }

    [Column("art_yakit_tipi")]
    [StringLength(50)]
    public string? ArtYakitTipi { get; set; }

    [Column("art_sorumlu_personel")]
    [StringLength(25)]
    public string? ArtSorumluPersonel { get; set; }

    [Column("art_durum")]
    [StringLength(50)]
    public string? ArtDurum { get; set; }

    [Column("art_aciklama")]
    [StringLength(500)]
    public string? ArtAciklama { get; set; }
}
