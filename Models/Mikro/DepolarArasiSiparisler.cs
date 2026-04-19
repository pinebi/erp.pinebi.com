using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("depolar_arasi_siparisler")]
public class DepolarArasiSiparisler
{
    [Column("ssip_Guid")]
    public Guid? SsipGuid { get; set; }

    [Column("ssip_DBCno")]
    public short? SsipDBCno { get; set; }

    [Column("ssip_SpecRECno")]
    public int? SsipSpecRECno { get; set; }

    [Column("ssip_iptal")]
    public bool? SsipIptal { get; set; }

    [Column("ssip_fileid")]
    public short? SsipFileid { get; set; }

    [Column("ssip_hidden")]
    public bool? SsipHidden { get; set; }

    [Column("ssip_kilitli")]
    public bool? SsipKilitli { get; set; }

    [Column("ssip_degisti")]
    public bool? SsipDegisti { get; set; }

    [Column("ssip_checksum")]
    public int? SsipChecksum { get; set; }

    [Column("ssip_create_user")]
    public short? SsipCreateUser { get; set; }

    [Column("ssip_create_date")]
    public DateTime? SsipCreateDate { get; set; }

    [Column("ssip_lastup_user")]
    public short? SsipLastupUser { get; set; }

    [Column("ssip_lastup_date")]
    public DateTime? SsipLastupDate { get; set; }

    [Column("ssip_special1")]
    [StringLength(4)]
    public string? SsipSpecial1 { get; set; }

    [Column("ssip_special2")]
    [StringLength(4)]
    public string? SsipSpecial2 { get; set; }

    [Column("ssip_special3")]
    [StringLength(4)]
    public string? SsipSpecial3 { get; set; }

    [Column("ssip_firmano")]
    public int? SsipFirmano { get; set; }

    [Column("ssip_subeno")]
    public int? SsipSubeno { get; set; }

    [Column("ssip_tarih")]
    public DateTime? SsipTarih { get; set; }

    [Column("ssip_teslim_tarih")]
    public DateTime? SsipTeslimTarih { get; set; }

    [Column("ssip_evrakno_seri")]
    [StringLength(50)]
    public string? SsipEvraknoSeri { get; set; }

    [Column("ssip_evrakno_sira")]
    public int? SsipEvraknoSira { get; set; }

    [Column("ssip_satirno")]
    public int? SsipSatirno { get; set; }

    [Column("ssip_belgeno")]
    [StringLength(50)]
    public string? SsipBelgeno { get; set; }

    [Column("ssip_belge_tarih")]
    public DateTime? SsipBelgeTarih { get; set; }

    [Column("ssip_stok_kod")]
    [StringLength(25)]
    public string? SsipStokKod { get; set; }

    [Column("ssip_miktar")]
    public double? SsipMiktar { get; set; }

    [Column("ssip_b_fiyat")]
    public double? SsipBFiyat { get; set; }

    [Column("ssip_tutar")]
    public double? SsipTutar { get; set; }

    [Column("ssip_teslim_miktar")]
    public double? SsipTeslimMiktar { get; set; }

    [Column("ssip_aciklama")]
    [StringLength(50)]
    public string? SsipAciklama { get; set; }

    [Column("ssip_girdepo")]
    public int? SsipGirdepo { get; set; }

    [Column("ssip_cikdepo")]
    public int? SsipCikdepo { get; set; }

    [Column("ssip_kapat_fl")]
    public bool? SsipKapatFl { get; set; }

    [Column("ssip_birim_pntr")]
    public byte? SsipBirimPntr { get; set; }

    [Column("ssip_fiyat_liste_no")]
    public int? SsipFiyatListeNo { get; set; }

    [Column("ssip_stal_uid")]
    public Guid? SsipStalUid { get; set; }

    [Column("ssip_paket_kod")]
    [StringLength(25)]
    public string? SsipPaketKod { get; set; }

    [Column("ssip_kapatmanedenkod")]
    [StringLength(25)]
    public string? SsipKapatmanedenkod { get; set; }

    [Column("ssip_projekodu")]
    [StringLength(25)]
    public string? SsipProjekodu { get; set; }

    [Column("ssip_sormerkezi")]
    [StringLength(25)]
    public string? SsipSormerkezi { get; set; }

    [Column("ssip_gecerlilik_tarihi")]
    public DateTime? SsipGecerlilikTarihi { get; set; }

    [Column("ssip_rezervasyon_miktari")]
    public double? SsipRezervasyonMiktari { get; set; }

    [Column("ssip_rezerveden_teslim_edilen")]
    public double? SsipRezervedenTeslimEdilen { get; set; }
}
