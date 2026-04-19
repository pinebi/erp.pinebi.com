using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("transfer_siparisleri")]
public class TransferSiparisleri
{
    [Column("transsip_Guid")]
    public Guid? TranssipGuid { get; set; }

    [Column("transsip_DBCno")]
    public short? TranssipDBCno { get; set; }

    [Column("transsip_SpecRECno")]
    public int? TranssipSpecRECno { get; set; }

    [Column("transsip_iptal")]
    public bool? TranssipIptal { get; set; }

    [Column("transsip_fileid")]
    public short? TranssipFileid { get; set; }

    [Column("transsip_hidden")]
    public bool? TranssipHidden { get; set; }

    [Column("transsip_kilitli")]
    public bool? TranssipKilitli { get; set; }

    [Column("transsip_degisti")]
    public bool? TranssipDegisti { get; set; }

    [Column("transsip_checksum")]
    public int? TranssipChecksum { get; set; }

    [Column("transsip_create_user")]
    public short? TranssipCreateUser { get; set; }

    [Column("transsip_create_date")]
    public DateTime? TranssipCreateDate { get; set; }

    [Column("transsip_lastup_user")]
    public short? TranssipLastupUser { get; set; }

    [Column("transsip_lastup_date")]
    public DateTime? TranssipLastupDate { get; set; }

    [Column("transsip_special1")]
    [StringLength(4)]
    public string? TranssipSpecial1 { get; set; }

    [Column("transsip_special2")]
    [StringLength(4)]
    public string? TranssipSpecial2 { get; set; }

    [Column("transsip_special3")]
    [StringLength(4)]
    public string? TranssipSpecial3 { get; set; }

    [Column("transsip_firmano")]
    public int? TranssipFirmano { get; set; }

    [Column("transsip_subeno")]
    public int? TranssipSubeno { get; set; }

    [Column("transsip_tarih")]
    public DateTime? TranssipTarih { get; set; }

    [Column("transsip_teslim_tarih")]
    public DateTime? TranssipTeslimTarih { get; set; }

    [Column("transsip_evrakno_seri")]
    [StringLength(50)]
    public string? TranssipEvraknoSeri { get; set; }

    [Column("transsip_evrakno_sira")]
    public int? TranssipEvraknoSira { get; set; }

    [Column("transsip_satirno")]
    public int? TranssipSatirno { get; set; }

    [Column("transsip_belgeno")]
    [StringLength(50)]
    public string? TranssipBelgeno { get; set; }

    [Column("transsip_belge_tarih")]
    public DateTime? TranssipBelgeTarih { get; set; }

    [Column("transsip_talepcarikodu")]
    [StringLength(25)]
    public string? TranssipTalepcarikodu { get; set; }

    [Column("transsip_talepcariadresno")]
    public int? TranssipTalepcariadresno { get; set; }

    [Column("transsip_temincarikodu")]
    [StringLength(25)]
    public string? TranssipTemincarikodu { get; set; }

    [Column("transsip_temincariadresno")]
    public int? TranssipTemincariadresno { get; set; }

    [Column("transsip_plasiyer_kodu")]
    [StringLength(25)]
    public string? TranssipPlasiyerKodu { get; set; }

    [Column("transsip_stok_kod")]
    [StringLength(25)]
    public string? TranssipStokKod { get; set; }

    [Column("transsip_b_fiyat")]
    public double? TranssipBFiyat { get; set; }

    [Column("transsip_miktar")]
    public double? TranssipMiktar { get; set; }

    [Column("transsip_birim_pntr")]
    public byte? TranssipBirimPntr { get; set; }

    [Column("transsip_teslim_miktar")]
    public double? TranssipTeslimMiktar { get; set; }

    [Column("transsip_tutar")]
    public double? TranssipTutar { get; set; }

    [Column("transsip_iskonto_1")]
    public double? TranssipIskonto1 { get; set; }

    [Column("transsip_iskonto_2")]
    public double? TranssipIskonto2 { get; set; }

    [Column("transsip_iskonto_3")]
    public double? TranssipIskonto3 { get; set; }

    [Column("transsip_iskonto_4")]
    public double? TranssipIskonto4 { get; set; }

    [Column("transsip_iskonto_5")]
    public double? TranssipIskonto5 { get; set; }

    [Column("transsip_iskonto_6")]
    public double? TranssipIskonto6 { get; set; }

    [Column("transsip_masraf_1")]
    public double? TranssipMasraf1 { get; set; }

    [Column("transsip_masraf_2")]
    public double? TranssipMasraf2 { get; set; }

    [Column("transsip_masraf_3")]
    public double? TranssipMasraf3 { get; set; }

    [Column("transsip_masraf_4")]
    public double? TranssipMasraf4 { get; set; }

    [Column("transsip_vergi_pntr")]
    public byte? TranssipVergiPntr { get; set; }

    [Column("transsip_vergi")]
    public double? TranssipVergi { get; set; }

    [Column("transsip_masvergi_pntr")]
    public byte? TranssipMasvergiPntr { get; set; }

    [Column("transsip_masvergi")]
    public double? TranssipMasvergi { get; set; }

    [Column("transsip_opno")]
    public int? TranssipOpno { get; set; }

    [Column("transsip_aciklama")]
    [StringLength(40)]
    public string? TranssipAciklama { get; set; }

    [Column("transsip_OnaylayanKulNo")]
    public short? TranssipOnaylayanKulNo { get; set; }

    [Column("transsip_vergisiz_fl")]
    public bool? TranssipVergisizFl { get; set; }

    [Column("transsip_kapat_fl")]
    public bool? TranssipKapatFl { get; set; }

    [Column("transsip_cari_sormerk")]
    [StringLength(25)]
    public string? TranssipCariSormerk { get; set; }

    [Column("transsip_stok_sormerk")]
    [StringLength(25)]
    public string? TranssipStokSormerk { get; set; }

    [Column("transsip_doviz_cinsi")]
    public byte? TranssipDovizCinsi { get; set; }

    [Column("transsip_doviz_kuru")]
    public double? TranssipDovizKuru { get; set; }

    [Column("transsip_alt_doviz_kuru")]
    public double? TranssipAltDovizKuru { get; set; }

    [Column("transsip_teslimturu")]
    [StringLength(4)]
    public string? TranssipTeslimturu { get; set; }

    [Column("transsip_cagrilabilir_fl")]
    public bool? TranssipCagrilabilirFl { get; set; }

    [Column("transsip_iskonto1")]
    public byte? TranssipIskonto1_2 { get; set; }

    [Column("transsip_iskonto2")]
    public byte? TranssipIskonto2_2 { get; set; }

    [Column("transsip_iskonto3")]
    public byte? TranssipIskonto3_2 { get; set; }

    [Column("transsip_iskonto4")]
    public byte? TranssipIskonto4_2 { get; set; }

    [Column("transsip_iskonto5")]
    public byte? TranssipIskonto5_2 { get; set; }

    [Column("transsip_iskonto6")]
    public byte? TranssipIskonto6_2 { get; set; }

    [Column("transsip_masraf1")]
    public byte? TranssipMasraf1_2 { get; set; }

    [Column("transsip_masraf2")]
    public byte? TranssipMasraf2_2 { get; set; }

    [Column("transsip_masraf3")]
    public byte? TranssipMasraf3_2 { get; set; }

    [Column("transsip_masraf4")]
    public byte? TranssipMasraf4_2 { get; set; }

    [Column("transsip_isk1")]
    public bool? TranssipIsk1 { get; set; }

    [Column("transsip_isk2")]
    public bool? TranssipIsk2 { get; set; }

    [Column("transsip_isk3")]
    public bool? TranssipIsk3 { get; set; }

    [Column("transsip_isk4")]
    public bool? TranssipIsk4 { get; set; }

    [Column("transsip_isk5")]
    public bool? TranssipIsk5 { get; set; }

    [Column("transsip_isk6")]
    public bool? TranssipIsk6 { get; set; }

    [Column("transsip_mas1")]
    public bool? TranssipMas1 { get; set; }

    [Column("transsip_mas2")]
    public bool? TranssipMas2 { get; set; }

    [Column("transsip_mas3")]
    public bool? TranssipMas3 { get; set; }

    [Column("transsip_mas4")]
    public bool? TranssipMas4 { get; set; }

    [Column("transsip_aciklama2")]
    [StringLength(40)]
    public string? TranssipAciklama2 { get; set; }

    [Column("transsip_kar_orani")]
    public double? TranssipKarOrani { get; set; }

    [Column("transsip_durumu")]
    public byte? TranssipDurumu { get; set; }

    [Column("transsip_parti_kodu")]
    [StringLength(25)]
    public string? TranssipPartiKodu { get; set; }

    [Column("transsip_lot_no")]
    public int? TranssipLotNo { get; set; }

    [Column("transsip_projekodu")]
    [StringLength(25)]
    public string? TranssipProjekodu { get; set; }

    [Column("transsip_fiyat_liste_no")]
    public int? TranssipFiyatListeNo { get; set; }

    [Column("transsip_otvpntr")]
    public byte? TranssipOtvpntr { get; set; }

    [Column("transsip_otvvergi")]
    public double? TranssipOtvvergi { get; set; }

    [Column("transsip_otvtutari")]
    public double? TranssipOtvtutari { get; set; }

    [Column("transsip_otvvergisiz_fl")]
    public byte? TranssipOtvvergisizFl { get; set; }

    [Column("transsip_paket_kodu")]
    [StringLength(25)]
    public string? TranssipPaketKodu { get; set; }

    [Column("transsip_kapatmanedenkod")]
    [StringLength(25)]
    public string? TranssipKapatmanedenkod { get; set; }
}
