using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bakim_hareketleri")]
public class BakimHareketleri
{
    [Column("bkm_Guid")]
    public Guid? BkmGuid { get; set; }

    [Column("bkm_DBCno")]
    public short? BkmDBCno { get; set; }

    [Column("bkm_Spec_Rec_no")]
    public int? BkmSpecRecNo { get; set; }

    [Column("bkm_iptal")]
    public bool? BkmIptal { get; set; }

    [Column("bkm_fileid")]
    public short? BkmFileid { get; set; }

    [Column("bkm_hidden")]
    public bool? BkmHidden { get; set; }

    [Column("bkm_kilitli")]
    public bool? BkmKilitli { get; set; }

    [Column("bkm_degisti")]
    public bool? BkmDegisti { get; set; }

    [Column("bkm_checksum")]
    public int? BkmChecksum { get; set; }

    [Column("bkm_create_user")]
    public short? BkmCreateUser { get; set; }

    [Column("bkm_create_date")]
    public DateTime? BkmCreateDate { get; set; }

    [Column("bkm_lastup_user")]
    public short? BkmLastupUser { get; set; }

    [Column("bkm_lastup_date")]
    public DateTime? BkmLastupDate { get; set; }

    [Column("bkm_special1")]
    [StringLength(4)]
    public string? BkmSpecial1 { get; set; }

    [Column("bkm_special2")]
    [StringLength(4)]
    public string? BkmSpecial2 { get; set; }

    [Column("bkm_special3")]
    [StringLength(4)]
    public string? BkmSpecial3 { get; set; }

    [Column("bkm_firmano")]
    public int? BkmFirmano { get; set; }

    [Column("bkm_subeno")]
    public int? BkmSubeno { get; set; }

    [Column("bkm_tarihi")]
    public DateTime? BkmTarihi { get; set; }

    [Column("bkm_evrakno_seri")]
    [StringLength(50)]
    public string? BkmEvraknoSeri { get; set; }

    [Column("bkm_evrakno_sira")]
    public int? BkmEvraknoSira { get; set; }

    [Column("bkm_satirno")]
    public int? BkmSatirno { get; set; }

    [Column("bkm_belgeno")]
    [StringLength(50)]
    public string? BkmBelgeno { get; set; }

    [Column("bkm_belge_tarihi")]
    public DateTime? BkmBelgeTarihi { get; set; }

    [Column("bkm_tuketici_kodu")]
    [StringLength(25)]
    public string? BkmTuketiciKodu { get; set; }

    [Column("bkm_cihaz_serino")]
    [StringLength(25)]
    public string? BkmCihazSerino { get; set; }

    [Column("bkm_fis_stok_kodu")]
    [StringLength(25)]
    public string? BkmFisStokKodu { get; set; }

    [Column("bkm_teslim_alinma_tarihi")]
    public DateTime? BkmTeslimAlinmaTarihi { get; set; }

    [Column("bkm_teslim_edilme_tarihi")]
    public DateTime? BkmTeslimEdilmeTarihi { get; set; }

    [Column("bkm_teslim_edilme_sekli")]
    public byte? BkmTeslimEdilmeSekli { get; set; }

    [Column("bkm_ariza_kodu1")]
    [StringLength(25)]
    public string? BkmArizaKodu1 { get; set; }

    [Column("bkm_ariza_kodu2")]
    [StringLength(25)]
    public string? BkmArizaKodu2 { get; set; }

    [Column("bkm_ariza_kodu3")]
    [StringLength(25)]
    public string? BkmArizaKodu3 { get; set; }

    [Column("bkm_ariza_kodu4")]
    [StringLength(25)]
    public string? BkmArizaKodu4 { get; set; }

    [Column("bkm_ariza_kodu5")]
    [StringLength(25)]
    public string? BkmArizaKodu5 { get; set; }

    [Column("bkm_ariza_kodu6")]
    [StringLength(25)]
    public string? BkmArizaKodu6 { get; set; }

    [Column("bkm_ariza_kodu7")]
    [StringLength(25)]
    public string? BkmArizaKodu7 { get; set; }

    [Column("bkm_ariza_kodu8")]
    [StringLength(25)]
    public string? BkmArizaKodu8 { get; set; }

    [Column("bkm_ariza_kodu9")]
    [StringLength(25)]
    public string? BkmArizaKodu9 { get; set; }

    [Column("bkm_ariza_kodu10")]
    [StringLength(25)]
    public string? BkmArizaKodu10 { get; set; }

    [Column("bkm_ekip_kodu")]
    [StringLength(25)]
    public string? BkmEkipKodu { get; set; }

    [Column("bkm_depono")]
    public int? BkmDepono { get; set; }

    [Column("bkm_aciklama")]
    [StringLength(80)]
    public string? BkmAciklama { get; set; }

    [Column("bkm_hareket_tipi")]
    public byte? BkmHareketTipi { get; set; }

    [Column("bkm_stok_hizmet_kodu")]
    [StringLength(25)]
    public string? BkmStokHizmetKodu { get; set; }

    [Column("bkm_miktari")]
    public double? BkmMiktari { get; set; }

    [Column("bkm_birim_fiyati")]
    public double? BkmBirimFiyati { get; set; }

    [Column("bkm_tutari")]
    public double? BkmTutari { get; set; }

    [Column("bkm_İskonto1")]
    public double? BkmIskonto1 { get; set; }

    [Column("bkm_İskonto2")]
    public double? BkmIskonto2 { get; set; }

    [Column("bkm_İskonto3")]
    public double? BkmIskonto3 { get; set; }

    [Column("bkm_İskonto4")]
    public double? BkmIskonto4 { get; set; }

    [Column("bkm_İskonto5")]
    public double? BkmIskonto5 { get; set; }

    [Column("bkm_İskonto6")]
    public double? BkmIskonto6 { get; set; }

    [Column("bkm_masraf1")]
    public double? BkmMasraf1 { get; set; }

    [Column("bkm_masraf2")]
    public double? BkmMasraf2 { get; set; }

    [Column("bkm_masraf3")]
    public double? BkmMasraf3 { get; set; }

    [Column("bkm_masraf4")]
    public double? BkmMasraf4 { get; set; }

    [Column("bkm_vergi_pntr")]
    public byte? BkmVergiPntr { get; set; }

    [Column("bkm_vergi")]
    public double? BkmVergi { get; set; }

    [Column("bkm_masraf_vergi_pnt")]
    public byte? BkmMasrafVergiPnt { get; set; }

    [Column("bkm_masraf_vergi")]
    public double? BkmMasrafVergi { get; set; }

    [Column("bkm_isk_mas1")]
    public byte? BkmIskMas1 { get; set; }

    [Column("bkm_isk_mas2")]
    public byte? BkmIskMas2 { get; set; }

    [Column("bkm_isk_mas3")]
    public byte? BkmIskMas3 { get; set; }

    [Column("bkm_isk_mas4")]
    public byte? BkmIskMas4 { get; set; }

    [Column("bkm_isk_mas5")]
    public byte? BkmIskMas5 { get; set; }

    [Column("bkm_isk_mas6")]
    public byte? BkmIskMas6 { get; set; }

    [Column("bkm_isk_mas7")]
    public byte? BkmIskMas7 { get; set; }

    [Column("bkm_isk_mas8")]
    public byte? BkmIskMas8 { get; set; }

    [Column("bkm_isk_mas9")]
    public byte? BkmIskMas9 { get; set; }

    [Column("bkm_isk_mas10")]
    public byte? BkmIskMas10 { get; set; }

    [Column("bkm_sat_isk_mas1")]
    public bool? BkmSatIskMas1 { get; set; }

    [Column("bkm_sat_isk_mas2")]
    public bool? BkmSatIskMas2 { get; set; }

    [Column("bkm_sat_isk_mas3")]
    public bool? BkmSatIskMas3 { get; set; }

    [Column("bkm_sat_isk_mas4")]
    public bool? BkmSatIskMas4 { get; set; }

    [Column("bkm_sat_isk_mas5")]
    public bool? BkmSatIskMas5 { get; set; }

    [Column("bkm_sat_isk_mas6")]
    public bool? BkmSatIskMas6 { get; set; }

    [Column("bkm_sat_isk_mas7")]
    public bool? BkmSatIskMas7 { get; set; }

    [Column("bkm_sat_isk_mas8")]
    public bool? BkmSatIskMas8 { get; set; }

    [Column("bkm_sat_isk_mas9")]
    public bool? BkmSatIskMas9 { get; set; }

    [Column("bkm_sat_isk_mas10")]
    public bool? BkmSatIskMas10 { get; set; }

    [Column("bkm_doviz_cins")]
    public byte? BkmDovizCins { get; set; }

    [Column("bkm_doviz_kur")]
    public double? BkmDovizKur { get; set; }

    [Column("bkm_alt_doviz_kur")]
    public double? BkmAltDovizKur { get; set; }

    [Column("bkm_vergisiz_fl")]
    public bool? BkmVergisizFl { get; set; }

    [Column("bkm_satir_aciklama")]
    [StringLength(50)]
    public string? BkmSatirAciklama { get; set; }

    [Column("bkm_faturalandi_fl")]
    public bool? BkmFaturalandiFl { get; set; }

    [Column("bkm_ziyaret_kodu")]
    [StringLength(25)]
    public string? BkmZiyaretKodu { get; set; }

    [Column("bkm_ziy_ac_tar")]
    public DateTime? BkmZiyAcTar { get; set; }

    [Column("bkm_ziy_cik_zmn")]
    public DateTime? BkmZiyCikZmn { get; set; }

    [Column("bkm_ziy_bas_zmn")]
    public DateTime? BkmZiyBasZmn { get; set; }

    [Column("bkm_ziy_son_zmn")]
    public DateTime? BkmZiySonZmn { get; set; }

    [Column("bkm_ziy_don_zmn")]
    public DateTime? BkmZiyDonZmn { get; set; }

    [Column("bkm_kabul_uid")]
    public Guid? BkmKabulUid { get; set; }

    [Column("bkm_isemri_uid")]
    public Guid? BkmIsemriUid { get; set; }

    [Column("bkm_cihazdurumbastarihi1")]
    public DateTime? BkmCihazdurumbastarihi1 { get; set; }

    [Column("bkm_cihazdurumbittarihi1")]
    public DateTime? BkmCihazdurumbittarihi1 { get; set; }

    [Column("bkm_cihazdurumkodu1")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu1 { get; set; }

    [Column("bkm_cihazserviselemanikodu1")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu1 { get; set; }

    [Column("bkm_cihazdurumbastarihi2")]
    public DateTime? BkmCihazdurumbastarihi2 { get; set; }

    [Column("bkm_cihazdurumbittarihi2")]
    public DateTime? BkmCihazdurumbittarihi2 { get; set; }

    [Column("bkm_cihazdurumkodu2")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu2 { get; set; }

    [Column("bkm_cihazserviselemanikodu2")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu2 { get; set; }

    [Column("bkm_cihazdurumbastarihi3")]
    public DateTime? BkmCihazdurumbastarihi3 { get; set; }

    [Column("bkm_cihazdurumbittarihi3")]
    public DateTime? BkmCihazdurumbittarihi3 { get; set; }

    [Column("bkm_cihazdurumkodu3")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu3 { get; set; }

    [Column("bkm_cihazserviselemanikodu3")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu3 { get; set; }

    [Column("bkm_cihazdurumbastarihi4")]
    public DateTime? BkmCihazdurumbastarihi4 { get; set; }

    [Column("bkm_cihazdurumbittarihi4")]
    public DateTime? BkmCihazdurumbittarihi4 { get; set; }

    [Column("bkm_cihazdurumkodu4")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu4 { get; set; }

    [Column("bkm_cihazserviselemanikodu4")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu4 { get; set; }

    [Column("bkm_cihazdurumbastarihi5")]
    public DateTime? BkmCihazdurumbastarihi5 { get; set; }

    [Column("bkm_cihazdurumbittarihi5")]
    public DateTime? BkmCihazdurumbittarihi5 { get; set; }

    [Column("bkm_cihazdurumkodu5")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu5 { get; set; }

    [Column("bkm_cihazserviselemanikodu5")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu5 { get; set; }

    [Column("bkm_cihazdurumbastarihi6")]
    public DateTime? BkmCihazdurumbastarihi6 { get; set; }

    [Column("bkm_cihazdurumbittarihi6")]
    public DateTime? BkmCihazdurumbittarihi6 { get; set; }

    [Column("bkm_cihazdurumkodu6")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu6 { get; set; }

    [Column("bkm_cihazserviselemanikodu6")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu6 { get; set; }

    [Column("bkm_cihazdurumbastarihi7")]
    public DateTime? BkmCihazdurumbastarihi7 { get; set; }

    [Column("bkm_cihazdurumbittarihi7")]
    public DateTime? BkmCihazdurumbittarihi7 { get; set; }

    [Column("bkm_cihazdurumkodu7")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu7 { get; set; }

    [Column("bkm_cihazserviselemanikodu7")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu7 { get; set; }

    [Column("bkm_cihazdurumbastarihi8")]
    public DateTime? BkmCihazdurumbastarihi8 { get; set; }

    [Column("bkm_cihazdurumbittarihi8")]
    public DateTime? BkmCihazdurumbittarihi8 { get; set; }

    [Column("bkm_cihazdurumkodu8")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu8 { get; set; }

    [Column("bkm_cihazserviselemanikodu8")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu8 { get; set; }

    [Column("bkm_cihazdurumbastarihi9")]
    public DateTime? BkmCihazdurumbastarihi9 { get; set; }

    [Column("bkm_cihazdurumbittarihi9")]
    public DateTime? BkmCihazdurumbittarihi9 { get; set; }

    [Column("bkm_cihazdurumkodu9")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu9 { get; set; }

    [Column("bkm_cihazserviselemanikodu9")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu9 { get; set; }

    [Column("bkm_cihazdurumbastarihi10")]
    public DateTime? BkmCihazdurumbastarihi10 { get; set; }

    [Column("bkm_cihazdurumbittarihi10")]
    public DateTime? BkmCihazdurumbittarihi10 { get; set; }

    [Column("bkm_cihazdurumkodu10")]
    [StringLength(25)]
    public string? BkmCihazdurumkodu10 { get; set; }

    [Column("bkm_cihazserviselemanikodu10")]
    [StringLength(25)]
    public string? BkmCihazserviselemanikodu10 { get; set; }

    [Column("bkm_fiyat_liste_no")]
    public int? BkmFiyatListeNo { get; set; }

    [Column("bkm_parti_kodu")]
    [StringLength(25)]
    public string? BkmPartiKodu { get; set; }

    [Column("bkm_lot_no")]
    public int? BkmLotNo { get; set; }

    [Column("bkm_servis_turu")]
    public byte? BkmServisTuru { get; set; }

    [Column("bkm_prj_kodu")]
    [StringLength(25)]
    public string? BkmPrjKodu { get; set; }

    [Column("bkm_srm_kodu")]
    [StringLength(25)]
    public string? BkmSrmKodu { get; set; }

    [Column("bkm_adres_no")]
    public int? BkmAdresNo { get; set; }
}
