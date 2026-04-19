using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_hareketleri_ek")]
public class StokHareketleriEk
{
    [Column("sthek_Guid")]
    public Guid? SthekGuid { get; set; }

    [Column("sthek_DBCno")]
    public short? SthekDBCno { get; set; }

    [Column("sthek_SpecRECno")]
    public int? SthekSpecRECno { get; set; }

    [Column("sthek_iptal")]
    public bool? SthekIptal { get; set; }

    [Column("sthek_fileid")]
    public short? SthekFileid { get; set; }

    [Column("sthek_hidden")]
    public bool? SthekHidden { get; set; }

    [Column("sthek_kilitli")]
    public bool? SthekKilitli { get; set; }

    [Column("sthek_degisti")]
    public bool? SthekDegisti { get; set; }

    [Column("sthek_checksum")]
    public int? SthekChecksum { get; set; }

    [Column("sthek_create_user")]
    public short? SthekCreateUser { get; set; }

    [Column("sthek_create_date")]
    public DateTime? SthekCreateDate { get; set; }

    [Column("sthek_lastup_user")]
    public short? SthekLastupUser { get; set; }

    [Column("sthek_lastup_date")]
    public DateTime? SthekLastupDate { get; set; }

    [Column("sthek_special1")]
    [StringLength(4)]
    public string? SthekSpecial1 { get; set; }

    [Column("sthek_special2")]
    [StringLength(4)]
    public string? SthekSpecial2 { get; set; }

    [Column("sthek_special3")]
    [StringLength(4)]
    public string? SthekSpecial3 { get; set; }

    [Column("sthek_related_uid")]
    public Guid? SthekRelatedUid { get; set; }

    [Column("sth_subesip_uid")]
    public Guid? SthSubesipUid { get; set; }

    [Column("sth_bkm_uid")]
    public Guid? SthBkmUid { get; set; }

    [Column("sth_karsikons_uid")]
    public Guid? SthKarsikonsUid { get; set; }

    [Column("sth_rez_uid")]
    public Guid? SthRezUid { get; set; }

    [Column("sth_optamam_uid")]
    public Guid? SthOptamamUid { get; set; }

    [Column("sth_iadeTlp_uid")]
    public Guid? SthIadeTlpUid { get; set; }

    [Column("sth_HalSatis_uid")]
    public Guid? SthHalSatisUid { get; set; }

    [Column("sth_ciroprim_uid")]
    public Guid? SthCiroprimUid { get; set; }

    [Column("sth_iade_evrak_seri")]
    [StringLength(50)]
    public string? SthIadeEvrakSeri { get; set; }

    [Column("sth_iade_evrak_sira")]
    public int? SthIadeEvrakSira { get; set; }

    [Column("sth_yat_tes_kodu")]
    [StringLength(25)]
    public string? SthYatTesKodu { get; set; }

    [Column("sth_ihracat_kredi_kodu")]
    [StringLength(4)]
    public string? SthIhracatKrediKodu { get; set; }

    [Column("sth_diib_belge_no")]
    [StringLength(25)]
    public string? SthDiibBelgeNo { get; set; }

    [Column("sth_diib_satir_no")]
    public byte? SthDiibSatirNo { get; set; }

    [Column("sth_mensey_ulke_tipi")]
    public byte? SthMenseyUlkeTipi { get; set; }

    [Column("sth_mensey_ulke_kodu")]
    [StringLength(4)]
    public string? SthMenseyUlkeKodu { get; set; }

    [Column("sth_halrehmiktari")]
    public double? SthHalrehmiktari { get; set; }

    [Column("sth_halrehfiyati")]
    public double? SthHalrehfiyati { get; set; }

    [Column("sth_halsandikmiktari")]
    public double? SthHalsandikmiktari { get; set; }

    [Column("sth_halsandikfiyati")]
    public double? SthHalsandikfiyati { get; set; }

    [Column("sth_halsandikkdvtutari")]
    public double? SthHalsandikkdvtutari { get; set; }

    [Column("sth_HalKomisyonuKdv")]
    public double? SthHalKomisyonuKdv { get; set; }

    [Column("sth_HalRusum")]
    public double? SthHalRusum { get; set; }

    [Column("sth_satistipi")]
    public byte? SthSatistipi { get; set; }

    [Column("sth_vardiya_tarihi")]
    public DateTime? SthVardiyaTarihi { get; set; }

    [Column("sth_vardiya_no")]
    public byte? SthVardiyaNo { get; set; }

    [Column("sth_direkt_iscilik_1")]
    public double? SthDirektIscilik1 { get; set; }

    [Column("sth_direkt_iscilik_2")]
    public double? SthDirektIscilik2 { get; set; }

    [Column("sth_direkt_iscilik_3")]
    public double? SthDirektIscilik3 { get; set; }

    [Column("sth_direkt_iscilik_4")]
    public double? SthDirektIscilik4 { get; set; }

    [Column("sth_direkt_iscilik_5")]
    public double? SthDirektIscilik5 { get; set; }

    [Column("sth_genel_uretim_1")]
    public double? SthGenelUretim1 { get; set; }

    [Column("sth_genel_uretim_2")]
    public double? SthGenelUretim2 { get; set; }

    [Column("sth_genel_uretim_3")]
    public double? SthGenelUretim3 { get; set; }

    [Column("sth_genel_uretim_4")]
    public double? SthGenelUretim4 { get; set; }

    [Column("sth_genel_uretim_5")]
    public double? SthGenelUretim5 { get; set; }

    [Column("sth_fis_tarihi2")]
    public DateTime? SthFisTarihi2 { get; set; }

    [Column("sth_fis_sirano2")]
    public int? SthFisSirano2 { get; set; }

    [Column("sth_fiyfark_esas_evrak_seri")]
    [StringLength(50)]
    public string? SthFiyfarkEsasEvrakSeri { get; set; }

    [Column("sth_fiyfark_esas_evrak_sira")]
    public int? SthFiyfarkEsasEvrakSira { get; set; }

    [Column("sth_fiyfark_esas_satir_no")]
    public int? SthFiyfarkEsasSatirNo { get; set; }

    [Column("sth_istisna")]
    [StringLength(5)]
    public string? SthIstisna { get; set; }

    [Column("sth_otv_tevkifat_turu")]
    public byte? SthOtvTevkifatTuru { get; set; }

    [Column("sth_otv_tevkifat_tutari")]
    public double? SthOtvTevkifatTutari { get; set; }

    [Column("sth_servishar_uid")]
    public Guid? SthServisharUid { get; set; }

    [Column("sth_bakimsarf_uid")]
    public Guid? SthBakimsarfUid { get; set; }
}
