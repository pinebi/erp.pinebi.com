using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("siparisler")]
public class Siparisler
{
    [Column("sip_Guid")]
    public Guid SipGuid { get; set; }

    [Column("sip_DBCno")]
    public short? SipDBCno { get; set; }

    [Column("sip_SpecRECno")]
    public int? SipSpecRECno { get; set; }

    [Column("sip_iptal")]
    public bool? SipIptal { get; set; }

    [Column("sip_fileid")]
    public short? SipFileid { get; set; }

    [Column("sip_hidden")]
    public bool? SipHidden { get; set; }

    [Column("sip_kilitli")]
    public bool? SipKilitli { get; set; }

    [Column("sip_degisti")]
    public bool? SipDegisti { get; set; }

    [Column("sip_checksum")]
    public int? SipChecksum { get; set; }

    [Column("sip_create_user")]
    public short? SipCreateUser { get; set; }

    [Column("sip_create_date")]
    public DateTime? SipCreateDate { get; set; }

    [Column("sip_lastup_user")]
    public short? SipLastupUser { get; set; }

    [Column("sip_lastup_date")]
    public DateTime? SipLastupDate { get; set; }

    [Column("sip_special1")]
    [StringLength(4)]
    public string? SipSpecial1 { get; set; }

    [Column("sip_special2")]
    [StringLength(4)]
    public string? SipSpecial2 { get; set; }

    [Column("sip_special3")]
    [StringLength(4)]
    public string? SipSpecial3 { get; set; }

    [Column("sip_firmano")]
    public int? SipFirmano { get; set; }

    [Column("sip_subeno")]
    public int? SipSubeno { get; set; }

    [Column("sip_tarih")]
    public DateTime? SipTarih { get; set; }

    [Column("sip_teslim_tarih")]
    public DateTime? SipTeslimTarih { get; set; }

    [Column("sip_tip")]
    public byte? SipTip { get; set; }

    [Column("sip_cins")]
    public byte? SipCins { get; set; }

    [Column("sip_evrakno_seri")]
    [StringLength(5)]
    public string? SipEvraknoSeri { get; set; }

    [Column("sip_evrakno_sira")]
    public int? SipEvraknoSira { get; set; }

    [Column("sip_satirno")]
    public int? SipSatirno { get; set; }

    [Column("sip_belgeno")]
    [StringLength(25)]
    public string? SipBelgeno { get; set; }

    [Column("sip_belge_tarih")]
    public DateTime? SipBelgeTarih { get; set; }

    [Column("sip_satici_kod")]
    [StringLength(25)]
    public string? SipSaticiKod { get; set; }

    [Column("sip_musteri_kod")]
    [StringLength(25)]
    public string? SipMusteriKod { get; set; }

    [Column("sip_stok_kod")]
    [StringLength(25)]
    public string? SipStokKod { get; set; }

    [Column("sip_b_fiyat")]
    public double? SipBFiyat { get; set; }

    [Column("sip_miktar")]
    public double? SipMiktar { get; set; }

    [Column("sip_birim_pntr")]
    public byte? SipBirimPntr { get; set; }

    [Column("sip_teslim_miktar")]
    public double? SipTeslimMiktar { get; set; }

    [Column("sip_tutar")]
    public double? SipTutar { get; set; }

    [Column("sip_iskonto_1")]
    public double? SipIskonto1 { get; set; }

    [Column("sip_iskonto_2")]
    public double? SipIskonto2 { get; set; }

    [Column("sip_iskonto_3")]
    public double? SipIskonto3 { get; set; }

    [Column("sip_iskonto_4")]
    public double? SipIskonto4 { get; set; }

    [Column("sip_iskonto_5")]
    public double? SipIskonto5 { get; set; }

    [Column("sip_iskonto_6")]
    public double? SipIskonto6 { get; set; }

    [Column("sip_masraf_1")]
    public double? SipMasraf1 { get; set; }

    [Column("sip_masraf_2")]
    public double? SipMasraf2 { get; set; }

    [Column("sip_masraf_3")]
    public double? SipMasraf3 { get; set; }

    [Column("sip_masraf_4")]
    public double? SipMasraf4 { get; set; }

    [Column("sip_vergi_pntr")]
    public byte? SipVergiPntr { get; set; }

    [Column("sip_vergi")]
    public double? SipVergi { get; set; }

    [Column("sip_masvergi_pntr")]
    public byte? SipMasvergiPntr { get; set; }

    [Column("sip_masvergi")]
    public double? SipMasvergi { get; set; }

    [Column("sip_opno")]
    public int? SipOpno { get; set; }

    [Column("sip_aciklama")]
    [StringLength(50)]
    public string? SipAciklama { get; set; }

    [Column("sip_aciklama2")]
    [StringLength(50)]
    public string? SipAciklama2 { get; set; }

    [Column("sip_depono")]
    public byte? SipDepono { get; set; }

    [Column("sip_OnaylayanKulNo")]
    public byte? SipOnaylayanKulNo { get; set; }

    [Column("sip_vergisiz_fl")]
    public bool? SipVergisizFl { get; set; }

    [Column("sip_kapat_fl")]
    public bool? SipKapatFl { get; set; }

    [Column("sip_promosyon_fl")]
    public bool? SipPromosyonFl { get; set; }

    [Column("sip_cari_sormerk")]
    [StringLength(25)]
    public string? SipCariSormerk { get; set; }

    [Column("sip_stok_sormerk")]
    [StringLength(25)]
    public string? SipStokSormerk { get; set; }

    [Column("sip_cari_grupno")]
    public byte? SipCariGrupno { get; set; }

    [Column("sip_doviz_cinsi")]
    public byte? SipDovizCinsi { get; set; }

    [Column("sip_doviz_kuru")]
    public double? SipDovizKuru { get; set; }

    [Column("sip_alt_doviz_kuru")]
    public double? SipAltDovizKuru { get; set; }

    [Column("sip_adresno")]
    public int? SipAdresno { get; set; }

    [Column("sip_teslimturu")]
    [StringLength(4)]
    public string? SipTeslimturu { get; set; }

    [Column("sip_cagrilabilir_fl")]
    public bool? SipCagrilabilirFl { get; set; }

    [Column("sip_prosip_uid")]
    public Guid? SipProsipUid { get; set; }

    [Column("sip_iskonto1")]
    public byte? SipIskonto1_2 { get; set; }

    [Column("sip_iskonto2")]
    public byte? SipIskonto2_2 { get; set; }

    [Column("sip_iskonto3")]
    public byte? SipIskonto3_2 { get; set; }

    [Column("sip_iskonto4")]
    public byte? SipIskonto4_2 { get; set; }

    [Column("sip_iskonto5")]
    public byte? SipIskonto5_2 { get; set; }

    [Column("sip_iskonto6")]
    public byte? SipIskonto6_2 { get; set; }

    [Column("sip_masraf1")]
    public byte? SipMasraf1_2 { get; set; }

    [Column("sip_masraf2")]
    public byte? SipMasraf2_2 { get; set; }

    [Column("sip_masraf3")]
    public byte? SipMasraf3_2 { get; set; }

    [Column("sip_masraf4")]
    public byte? SipMasraf4_2 { get; set; }

    [Column("sip_isk1")]
    public bool? SipIsk1 { get; set; }

    [Column("sip_isk2")]
    public bool? SipIsk2 { get; set; }

    [Column("sip_isk3")]
    public bool? SipIsk3 { get; set; }

    [Column("sip_isk4")]
    public bool? SipIsk4 { get; set; }

    [Column("sip_isk5")]
    public bool? SipIsk5 { get; set; }

    [Column("sip_isk6")]
    public bool? SipIsk6 { get; set; }

    [Column("sip_mas1")]
    public bool? SipMas1 { get; set; }

    [Column("sip_mas2")]
    public bool? SipMas2 { get; set; }

    [Column("sip_mas3")]
    public bool? SipMas3 { get; set; }

    [Column("sip_mas4")]
    public bool? SipMas4 { get; set; }

    [Column("sip_Exp_Imp_Kodu")]
    [StringLength(25)]
    public string? SipExpImpKodu { get; set; }

    [Column("sip_kar_orani")]
    public double? SipKarOrani { get; set; }

    [Column("sip_durumu")]
    public byte? SipDurumu { get; set; }

    [Column("sip_stal_uid")]
    public Guid? SipStalUid { get; set; }

    [Column("sip_planlananmiktar")]
    public double? SipPlanlananmiktar { get; set; }

    [Column("sip_teklif_uid")]
    public Guid? SipTeklifUid { get; set; }

    [Column("sip_parti_kodu")]
    [StringLength(25)]
    public string? SipPartiKodu { get; set; }

    [Column("sip_lot_no")]
    public int? SipLotNo { get; set; }

    [Column("sip_projekodu")]
    [StringLength(25)]
    public string? SipProjekodu { get; set; }

    [Column("sip_fiyat_liste_no")]
    public int? SipFiyatListeNo { get; set; }

    [Column("sip_Otv_Pntr")]
    public byte? SipOtvPntr { get; set; }

    [Column("sip_Otv_Vergi")]
    public double? SipOtvVergi { get; set; }

    [Column("sip_otvtutari")]
    public double? SipOtvtutari { get; set; }

    [Column("sip_OtvVergisiz_Fl")]
    public byte? SipOtvVergisizFl { get; set; }

    [Column("sip_paket_kod")]
    [StringLength(25)]
    public string? SipPaketKod { get; set; }

    [Column("sip_Rez_uid")]
    public Guid? SipRezUid { get; set; }

    [Column("sip_harekettipi")]
    public byte? SipHarekettipi { get; set; }

    [Column("sip_yetkili_uid")]
    public Guid? SipYetkiliUid { get; set; }

    [Column("sip_kapatmanedenkod")]
    [StringLength(25)]
    public string? SipKapatmanedenkod { get; set; }

    [Column("sip_gecerlilik_tarihi")]
    public DateTime? SipGecerlilikTarihi { get; set; }

    [Column("sip_onodeme_evrak_tip")]
    public byte? SipOnodemeEvrakTip { get; set; }

    [Column("sip_onodeme_evrak_seri")]
    [StringLength(5)]
    public string? SipOnodemeEvrakSeri { get; set; }

    [Column("sip_onodeme_evrak_sira")]
    public int? SipOnodemeEvrakSira { get; set; }

    [Column("sip_rezervasyon_miktari")]
    public double? SipRezervasyonMiktari { get; set; }

    [Column("sip_rezerveden_teslim_edilen")]
    public double? SipRezervedenTeslimEdilen { get; set; }
}
