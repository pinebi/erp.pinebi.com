using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_serino_tanimlari")]
public class StokSerinoTanimlari
{
    [Column("chz_Guid")]
    public Guid? ChzGuid { get; set; }

    [Column("chz_DBCno")]
    public short? ChzDBCno { get; set; }

    [Column("chz_Spec_Rec_no")]
    public int? ChzSpecRecNo { get; set; }

    [Column("chz_iptal")]
    public bool? ChzIptal { get; set; }

    [Column("chz_fileid")]
    public short? ChzFileid { get; set; }

    [Column("chz_hidden")]
    public bool? ChzHidden { get; set; }

    [Column("chz_kilitli")]
    public bool? ChzKilitli { get; set; }

    [Column("chz_degisti")]
    public bool? ChzDegisti { get; set; }

    [Column("chz_checksum")]
    public int? ChzChecksum { get; set; }

    [Column("chz_create_user")]
    public short? ChzCreateUser { get; set; }

    [Column("chz_create_date")]
    public DateTime? ChzCreateDate { get; set; }

    [Column("chz_lastup_user")]
    public short? ChzLastupUser { get; set; }

    [Column("chz_lastup_date")]
    public DateTime? ChzLastupDate { get; set; }

    [Column("chz_special1")]
    [StringLength(4)]
    public string? ChzSpecial1 { get; set; }

    [Column("chz_special2")]
    [StringLength(4)]
    public string? ChzSpecial2 { get; set; }

    [Column("chz_special3")]
    [StringLength(4)]
    public string? ChzSpecial3 { get; set; }

    [Column("chz_serino")]
    [StringLength(25)]
    public string? ChzSerino { get; set; }

    [Column("chz_stok_kodu")]
    [StringLength(25)]
    public string? ChzStokKodu { get; set; }

    [Column("chz_grup_kodu")]
    [StringLength(25)]
    public string? ChzGrupKodu { get; set; }

    [Column("chz_Tuktckodu")]
    [StringLength(25)]
    public string? ChzTuktckodu { get; set; }

    [Column("chz_GrnBasTarihi")]
    public DateTime? ChzGrnBasTarihi { get; set; }

    [Column("chz_GrnBitTarihi")]
    public DateTime? ChzGrnBitTarihi { get; set; }

    [Column("chz_aciklama1")]
    [StringLength(80)]
    public string? ChzAciklama1 { get; set; }

    [Column("chz_aciklama2")]
    [StringLength(80)]
    public string? ChzAciklama2 { get; set; }

    [Column("chz_aciklama3")]
    [StringLength(80)]
    public string? ChzAciklama3 { get; set; }

    [Column("chz_al_tarih")]
    public DateTime? ChzAlTarih { get; set; }

    [Column("chz_al_evr_seri")]
    [StringLength(50)]
    public string? ChzAlEvrSeri { get; set; }

    [Column("chz_al_evr_sira")]
    public int? ChzAlEvrSira { get; set; }

    [Column("chz_al_cari_kodu")]
    [StringLength(25)]
    public string? ChzAlCariKodu { get; set; }

    [Column("chz_al_wd_tarih")]
    public DateTime? ChzAlWdTarih { get; set; }

    [Column("chz_al_wd_evr_seri")]
    [StringLength(50)]
    public string? ChzAlWdEvrSeri { get; set; }

    [Column("chz_al_wd_evr_sira")]
    public int? ChzAlWdEvrSira { get; set; }

    [Column("chz_st_tarih")]
    public DateTime? ChzStTarih { get; set; }

    [Column("chz_st_evr_seri")]
    [StringLength(50)]
    public string? ChzStEvrSeri { get; set; }

    [Column("chz_st_evr_sira")]
    public int? ChzStEvrSira { get; set; }

    [Column("chz_st_cari_kodu")]
    [StringLength(25)]
    public string? ChzStCariKodu { get; set; }

    [Column("chz_st_wd_tarih")]
    public DateTime? ChzStWdTarih { get; set; }

    [Column("chz_st_wd_evr_seri")]
    [StringLength(50)]
    public string? ChzStWdEvrSeri { get; set; }

    [Column("chz_st_wd_evr_sira")]
    public int? ChzStWdEvrSira { get; set; }

    [Column("chz_brut_fiati")]
    public double? ChzBrutFiati { get; set; }

    [Column("chz_al_fiati_ana")]
    public double? ChzAlFiatiAna { get; set; }

    [Column("chz_al_fiati_alt")]
    public double? ChzAlFiatiAlt { get; set; }

    [Column("chz_al_fiati_orj")]
    public double? ChzAlFiatiOrj { get; set; }

    [Column("chz_st_fiati_ana")]
    public double? ChzStFiatiAna { get; set; }

    [Column("chz_st_fiati_alt")]
    public double? ChzStFiatiAlt { get; set; }

    [Column("chz_st_fiati_orj")]
    public double? ChzStFiatiOrj { get; set; }

    [Column("chz_parca_garantisi")]
    public bool? ChzParcaGarantisi { get; set; }

    [Column("chz_parca_serino")]
    [StringLength(25)]
    public string? ChzParcaSerino { get; set; }

    [Column("chz_parca_garanti_baslangic")]
    public DateTime? ChzParcaGarantiBaslangic { get; set; }

    [Column("chz_parca_garanti_bitis")]
    public DateTime? ChzParcaGarantiBitis { get; set; }

    [Column("chz_makina_tipi")]
    public byte? ChzMakinaTipi { get; set; }

    [Column("chz_model_yili")]
    [StringLength(4)]
    public string? ChzModelYili { get; set; }

    [Column("chz_kiraya_acilma_tarihi")]
    public DateTime? ChzKirayaAcilmaTarihi { get; set; }

    [Column("chz_musteri_garanti_baslangic")]
    public DateTime? ChzMusteriGarantiBaslangic { get; set; }

    [Column("chz_musteri_garanti_bitis")]
    public DateTime? ChzMusteriGarantiBitis { get; set; }

    [Column("chz_demirbas_kodu")]
    [StringLength(25)]
    public string? ChzDemirbasKodu { get; set; }

    [Column("chz_tescil_tarihi")]
    public DateTime? ChzTescilTarihi { get; set; }

    [Column("chz_bakim_tipi")]
    public byte? ChzBakimTipi { get; set; }

    [Column("chz_bakim_tarihi")]
    public DateTime? ChzBakimTarihi { get; set; }

    [Column("chz_ara_bakim_sayisi")]
    public int? ChzAraBakimSayisi { get; set; }

    [Column("chz_bakim_peryodu")]
    public byte? ChzBakimPeryodu { get; set; }
}
