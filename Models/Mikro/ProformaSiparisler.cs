using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("proforma_siparisler")]
public class ProformaSiparisler
{
    [Column("pro_Guid")]
    public Guid? ProGuid { get; set; }

    [Column("pro_DBCno")]
    public short? ProDBCno { get; set; }

    [Column("pro_SpecRecNo")]
    public int? ProSpecRecNo { get; set; }

    [Column("pro_iptal")]
    public bool? ProIptal { get; set; }

    [Column("pro_fileid")]
    public short? ProFileid { get; set; }

    [Column("pro_hidden")]
    public bool? ProHidden { get; set; }

    [Column("pro_kilitli")]
    public bool? ProKilitli { get; set; }

    [Column("pro_degisti")]
    public bool? ProDegisti { get; set; }

    [Column("pro_checksum")]
    public int? ProChecksum { get; set; }

    [Column("pro_create_user")]
    public short? ProCreateUser { get; set; }

    [Column("pro_create_date")]
    public DateTime? ProCreateDate { get; set; }

    [Column("pro_lastup_user")]
    public short? ProLastupUser { get; set; }

    [Column("pro_lastup_date")]
    public DateTime? ProLastupDate { get; set; }

    [Column("pro_special1")]
    [StringLength(4)]
    public string? ProSpecial1 { get; set; }

    [Column("pro_special2")]
    [StringLength(4)]
    public string? ProSpecial2 { get; set; }

    [Column("pro_special3")]
    [StringLength(4)]
    public string? ProSpecial3 { get; set; }

    [Column("pro_firmano")]
    public int? ProFirmano { get; set; }

    [Column("pro_subeno")]
    public int? ProSubeno { get; set; }

    [Column("pro_tarihi")]
    public DateTime? ProTarihi { get; set; }

    [Column("pro_testarihi")]
    public DateTime? ProTestarihi { get; set; }

    [Column("pro_tipi")]
    public byte? ProTipi { get; set; }

    [Column("pro_cinsi")]
    public byte? ProCinsi { get; set; }

    [Column("pro_evrakno_seri")]
    [StringLength(50)]
    public string? ProEvraknoSeri { get; set; }

    [Column("pro_evrakno_sira")]
    public int? ProEvraknoSira { get; set; }

    [Column("pro_satirno")]
    public int? ProSatirno { get; set; }

    [Column("pro_belge_no")]
    [StringLength(50)]
    public string? ProBelgeNo { get; set; }

    [Column("pro_belge_tarihi")]
    public DateTime? ProBelgeTarihi { get; set; }

    [Column("pro_saticikodu")]
    [StringLength(25)]
    public string? ProSaticikodu { get; set; }

    [Column("pro_mustkodu")]
    [StringLength(25)]
    public string? ProMustkodu { get; set; }

    [Column("pro_stokkodu")]
    [StringLength(25)]
    public string? ProStokkodu { get; set; }

    [Column("pro_bfiyati")]
    public double? ProBfiyati { get; set; }

    [Column("pro_miktar")]
    public double? ProMiktar { get; set; }

    [Column("pro_birim_pntr")]
    public byte? ProBirimPntr { get; set; }

    [Column("pro_tesmiktari")]
    public double? ProTesmiktari { get; set; }

    [Column("pro_tutari")]
    public double? ProTutari { get; set; }

    [Column("pro_iskonto1")]
    public double? ProIskonto1 { get; set; }

    [Column("pro_iskonto2")]
    public double? ProIskonto2 { get; set; }

    [Column("pro_iskonto3")]
    public double? ProIskonto3 { get; set; }

    [Column("pro_iskonto4")]
    public double? ProIskonto4 { get; set; }

    [Column("pro_iskonto5")]
    public double? ProIskonto5 { get; set; }

    [Column("pro_iskonto6")]
    public double? ProIskonto6 { get; set; }

    [Column("pro_masraf1")]
    public double? ProMasraf1 { get; set; }

    [Column("pro_masraf2")]
    public double? ProMasraf2 { get; set; }

    [Column("pro_masraf3")]
    public double? ProMasraf3 { get; set; }

    [Column("pro_masraf4")]
    public double? ProMasraf4 { get; set; }

    [Column("pro_vergipntr")]
    public byte? ProVergipntr { get; set; }

    [Column("pro_vergi")]
    public double? ProVergi { get; set; }

    [Column("pro_masrafvergipntr")]
    public byte? ProMasrafvergipntr { get; set; }

    [Column("pro_masrafvergi")]
    public double? ProMasrafvergi { get; set; }

    [Column("pro_opno")]
    public int? ProOpno { get; set; }

    [Column("pro_aciklama")]
    [StringLength(50)]
    public string? ProAciklama { get; set; }

    [Column("pro_aciklama2")]
    [StringLength(50)]
    public string? ProAciklama2 { get; set; }

    [Column("pro_depono")]
    public int? ProDepono { get; set; }

    [Column("pro_onaylayanKul_no")]
    public short? ProOnaylayanKulNo { get; set; }

    [Column("pro_vergisiz")]
    public bool? ProVergisiz { get; set; }

    [Column("pro_kapat")]
    public bool? ProKapat { get; set; }

    [Column("pro_promosyon_fl")]
    public bool? ProPromosyonFl { get; set; }

    [Column("pro_cari_sormerk")]
    [StringLength(25)]
    public string? ProCariSormerk { get; set; }

    [Column("pro_stok_sormerk")]
    [StringLength(25)]
    public string? ProStokSormerk { get; set; }

    [Column("pro_cari_grupno")]
    public byte? ProCariGrupno { get; set; }

    [Column("pro_dovizcinsi")]
    public byte? ProDovizcinsi { get; set; }

    [Column("pro_dovizkuru")]
    public double? ProDovizkuru { get; set; }

    [Column("pro_altdovizkuru")]
    public double? ProAltdovizkuru { get; set; }

    [Column("pro_adresno")]
    public int? ProAdresno { get; set; }

    [Column("pro_teslimturu")]
    [StringLength(4)]
    public string? ProTeslimturu { get; set; }

    [Column("pro_cagrilabilir_fl")]
    public bool? ProCagrilabilirFl { get; set; }

    [Column("pro_sip_uid")]
    public Guid? ProSipUid { get; set; }

    [Column("pro_isk_mas_1")]
    public byte? ProIskMas1 { get; set; }

    [Column("pro_isk_mas_2")]
    public byte? ProIskMas2 { get; set; }

    [Column("pro_isk_mas_3")]
    public byte? ProIskMas3 { get; set; }

    [Column("pro_isk_mas_4")]
    public byte? ProIskMas4 { get; set; }

    [Column("pro_isk_mas_5")]
    public byte? ProIskMas5 { get; set; }

    [Column("pro_isk_mas_6")]
    public byte? ProIskMas6 { get; set; }

    [Column("pro_isk_mas_7")]
    public byte? ProIskMas7 { get; set; }

    [Column("pro_isk_mas_8")]
    public byte? ProIskMas8 { get; set; }

    [Column("pro_isk_mas_9")]
    public byte? ProIskMas9 { get; set; }

    [Column("pro_isk_mas_10")]
    public byte? ProIskMas10 { get; set; }

    [Column("pro_sat_isk_mas1")]
    public bool? ProSatIskMas1 { get; set; }

    [Column("pro_sat_isk_mas2")]
    public bool? ProSatIskMas2 { get; set; }

    [Column("pro_sat_isk_mas3")]
    public bool? ProSatIskMas3 { get; set; }

    [Column("pro_sat_isk_mas4")]
    public bool? ProSatIskMas4 { get; set; }

    [Column("pro_sat_isk_mas5")]
    public bool? ProSatIskMas5 { get; set; }

    [Column("pro_sat_isk_mas6")]
    public bool? ProSatIskMas6 { get; set; }

    [Column("pro_sat_isk_mas7")]
    public bool? ProSatIskMas7 { get; set; }

    [Column("pro_sat_isk_mas8")]
    public bool? ProSatIskMas8 { get; set; }

    [Column("pro_sat_isk_mas9")]
    public bool? ProSatIskMas9 { get; set; }

    [Column("pro_sat_isk_mas10")]
    public bool? ProSatIskMas10 { get; set; }

    [Column("sip_Exp_Imp_Kodu")]
    [StringLength(25)]
    public string? SipExpImpKodu { get; set; }

    [Column("pro_karoani")]
    public double? ProKaroani { get; set; }

    [Column("pro_durumu")]
    public byte? ProDurumu { get; set; }

    [Column("pro_stal_uid")]
    public Guid? ProStalUid { get; set; }

    [Column("pro_planlananmiktar")]
    public double? ProPlanlananmiktar { get; set; }

    [Column("pro_teklif_uid")]
    public Guid? ProTeklifUid { get; set; }

    [Column("pro_parti_kodu")]
    [StringLength(25)]
    public string? ProPartiKodu { get; set; }

    [Column("pro_lot_no")]
    public int? ProLotNo { get; set; }

    [Column("pro_projekodu")]
    [StringLength(25)]
    public string? ProProjekodu { get; set; }

    [Column("pro_fiyat_liste_no")]
    public int? ProFiyatListeNo { get; set; }

    [Column("pro_Otv_Pntr")]
    public byte? ProOtvPntr { get; set; }

    [Column("pro_Otv_Vergi")]
    public double? ProOtvVergi { get; set; }

    [Column("pro_otvtutari")]
    public double? ProOtvtutari { get; set; }

    [Column("pro_OtvVergisiz_Fl")]
    public byte? ProOtvVergisizFl { get; set; }

    [Column("pro_paket_kod")]
    [StringLength(25)]
    public string? ProPaketKod { get; set; }

    [Column("pro_Rez_uid")]
    public Guid? ProRezUid { get; set; }

    [Column("pro_harekettipi")]
    public byte? ProHarekettipi { get; set; }

    [Column("pro_yetkili_uid")]
    public Guid? ProYetkiliUid { get; set; }

    [Column("pro_kapatmanedenkod")]
    [StringLength(25)]
    public string? ProKapatmanedenkod { get; set; }

    [Column("pro_gecerlilik_tarihi")]
    public DateTime? ProGecerlilikTarihi { get; set; }

    [Column("pro_onodeme_evrak_tip")]
    public byte? ProOnodemeEvrakTip { get; set; }

    [Column("pro_onodeme_evrak_seri")]
    [StringLength(50)]
    public string? ProOnodemeEvrakSeri { get; set; }

    [Column("pro_onodeme_evrak_sira")]
    public int? ProOnodemeEvrakSira { get; set; }

    [Column("pro_rezervasyon_miktari")]
    public double? ProRezervasyonMiktari { get; set; }

    [Column("pro_rezerveden_teslim_edilen")]
    public double? ProRezervedenTeslimEdilen { get; set; }
}
