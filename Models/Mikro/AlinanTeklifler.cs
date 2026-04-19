using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("alinan_teklifler")]
public class AlinanTeklifler
{
    [Column("altkl_Guid")]
    public Guid? AltklGuid { get; set; }

    [Column("altkl_DBCno")]
    public short? AltklDBCno { get; set; }

    [Column("altkl_SpecRECno")]
    public int? AltklSpecRECno { get; set; }

    [Column("altkl_iptal")]
    public bool? AltklIptal { get; set; }

    [Column("altkl_fileid")]
    public short? AltklFileid { get; set; }

    [Column("altkl_hidden")]
    public bool? AltklHidden { get; set; }

    [Column("altkl_kilitli")]
    public bool? AltklKilitli { get; set; }

    [Column("altkl_degisti")]
    public bool? AltklDegisti { get; set; }

    [Column("altkl_checksum")]
    public int? AltklChecksum { get; set; }

    [Column("altkl_create_user")]
    public short? AltklCreateUser { get; set; }

    [Column("altkl_create_date")]
    public DateTime? AltklCreateDate { get; set; }

    [Column("altkl_lastup_user")]
    public short? AltklLastupUser { get; set; }

    [Column("altkl_lastup_date")]
    public DateTime? AltklLastupDate { get; set; }

    [Column("altkl_special1")]
    [StringLength(4)]
    public string? AltklSpecial1 { get; set; }

    [Column("altkl_special2")]
    [StringLength(4)]
    public string? AltklSpecial2 { get; set; }

    [Column("altkl_special3")]
    [StringLength(4)]
    public string? AltklSpecial3 { get; set; }

    [Column("altkl_firmano")]
    public int? AltklFirmano { get; set; }

    [Column("altkl_subeno")]
    public int? AltklSubeno { get; set; }

    [Column("altkl_teklif_kodu")]
    [StringLength(25)]
    public string? AltklTeklifKodu { get; set; }

    [Column("altkl_sira_no")]
    public int? AltklSiraNo { get; set; }

    [Column("altkl_satirno")]
    public int? AltklSatirno { get; set; }

    [Column("altkl_tarihi")]
    public DateTime? AltklTarihi { get; set; }

    [Column("altkl_belge_no")]
    [StringLength(50)]
    public string? AltklBelgeNo { get; set; }

    [Column("altkl_belge_tarih")]
    public DateTime? AltklBelgeTarih { get; set; }

    [Column("altkl_cari_kodu")]
    [StringLength(25)]
    public string? AltklCariKodu { get; set; }

    [Column("altkl_cari_adres_no")]
    public int? AltklCariAdresNo { get; set; }

    [Column("altkl_cari_yetkili_uid")]
    public Guid? AltklCariYetkiliUid { get; set; }

    [Column("altkl_teslimat_tarihi")]
    public DateTime? AltklTeslimatTarihi { get; set; }

    [Column("altkl_odeme_plani")]
    public int? AltklOdemePlani { get; set; }

    [Column("altkl_teslim_turu")]
    [StringLength(4)]
    public string? AltklTeslimTuru { get; set; }

    [Column("altkl_proje_kodu")]
    [StringLength(25)]
    public string? AltklProjeKodu { get; set; }

    [Column("altkl_srmmrk_kodu")]
    [StringLength(25)]
    public string? AltklSrmmrkKodu { get; set; }

    [Column("altkl_sorumlu_kodu")]
    [StringLength(25)]
    public string? AltklSorumluKodu { get; set; }

    [Column("altkl_hareket_tipi")]
    public byte? AltklHareketTipi { get; set; }

    [Column("altkl_hareket_kodu")]
    [StringLength(25)]
    public string? AltklHareketKodu { get; set; }

    [Column("altkl_miktar")]
    public double? AltklMiktar { get; set; }

    [Column("altkl_birim_fiyati")]
    public double? AltklBirimFiyati { get; set; }

    [Column("altkl_tutar")]
    public double? AltklTutar { get; set; }

    [Column("altkl_doviz_cins")]
    public byte? AltklDovizCins { get; set; }

    [Column("altkl_doviz_kur")]
    public double? AltklDovizKur { get; set; }

    [Column("altkl_alt_doviz_kur")]
    public double? AltklAltDovizKur { get; set; }

    [Column("altkl_Iskonto1")]
    public double? AltklIskonto1 { get; set; }

    [Column("altkl_Iskonto2")]
    public double? AltklIskonto2 { get; set; }

    [Column("altkl_Iskonto3")]
    public double? AltklIskonto3 { get; set; }

    [Column("altkl_Iskonto4")]
    public double? AltklIskonto4 { get; set; }

    [Column("altkl_Iskonto5")]
    public double? AltklIskonto5 { get; set; }

    [Column("altkl_Iskonto6")]
    public double? AltklIskonto6 { get; set; }

    [Column("altkl_masraf1")]
    public double? AltklMasraf1 { get; set; }

    [Column("altkl_masraf2")]
    public double? AltklMasraf2 { get; set; }

    [Column("altkl_masraf3")]
    public double? AltklMasraf3 { get; set; }

    [Column("altkl_masraf4")]
    public double? AltklMasraf4 { get; set; }

    [Column("altkl_vergi_pntr")]
    public byte? AltklVergiPntr { get; set; }

    [Column("altkl_vergi")]
    public double? AltklVergi { get; set; }

    [Column("altkl_masraf_vergi_pnt")]
    public byte? AltklMasrafVergiPnt { get; set; }

    [Column("altkl_masraf_vergi")]
    public double? AltklMasrafVergi { get; set; }

    [Column("altkl_isk_mas1")]
    public byte? AltklIskMas1 { get; set; }

    [Column("altkl_isk_mas2")]
    public byte? AltklIskMas2 { get; set; }

    [Column("altkl_isk_mas3")]
    public byte? AltklIskMas3 { get; set; }

    [Column("altkl_isk_mas4")]
    public byte? AltklIskMas4 { get; set; }

    [Column("altkl_isk_mas5")]
    public byte? AltklIskMas5 { get; set; }

    [Column("altkl_isk_mas6")]
    public byte? AltklIskMas6 { get; set; }

    [Column("altkl_isk_mas7")]
    public byte? AltklIskMas7 { get; set; }

    [Column("altkl_isk_mas8")]
    public byte? AltklIskMas8 { get; set; }

    [Column("altkl_isk_mas9")]
    public byte? AltklIskMas9 { get; set; }

    [Column("altkl_isk_mas10")]
    public byte? AltklIskMas10 { get; set; }

    [Column("altkl_sat_iskmas1")]
    public bool? AltklSatIskmas1 { get; set; }

    [Column("altkl_sat_iskmas2")]
    public bool? AltklSatIskmas2 { get; set; }

    [Column("altkl_sat_iskmas3")]
    public bool? AltklSatIskmas3 { get; set; }

    [Column("altkl_sat_iskmas4")]
    public bool? AltklSatIskmas4 { get; set; }

    [Column("altkl_sat_iskmas5")]
    public bool? AltklSatIskmas5 { get; set; }

    [Column("altkl_sat_iskmas6")]
    public bool? AltklSatIskmas6 { get; set; }

    [Column("altkl_sat_iskmas7")]
    public bool? AltklSatIskmas7 { get; set; }

    [Column("altkl_sat_iskmas8")]
    public bool? AltklSatIskmas8 { get; set; }

    [Column("altkl_sat_iskmas9")]
    public bool? AltklSatIskmas9 { get; set; }

    [Column("altkl_sat_iskmas10")]
    public bool? AltklSatIskmas10 { get; set; }

    [Column("altkl_vergisiz_fl")]
    public bool? AltklVergisizFl { get; set; }

    [Column("altkl_fiyat_liste_no")]
    public int? AltklFiyatListeNo { get; set; }

    [Column("altkl_paket_kod")]
    [StringLength(25)]
    public string? AltklPaketKod { get; set; }

    [Column("altkl_teslimdepo")]
    public int? AltklTeslimdepo { get; set; }

    [Column("altkl_aciklama")]
    [StringLength(50)]
    public string? AltklAciklama { get; set; }

    [Column("altkl_onaylayan_kullanici")]
    public short? AltklOnaylayanKullanici { get; set; }

    [Column("altkl_durumu")]
    public byte? AltklDurumu { get; set; }

    [Column("altkl_satal_talep_uid")]
    public Guid? AltklSatalTalepUid { get; set; }

    [Column("altkl_siparis_uid")]
    public Guid? AltklSiparisUid { get; set; }

    [Column("altkl_prosiparis_uId")]
    public Guid? AltklProsiparisUId { get; set; }

    [Column("altkl_birim_pntr")]
    public byte? AltklBirimPntr { get; set; }

    [Column("altkl_cari_tipi")]
    public byte? AltklCariTipi { get; set; }
}
