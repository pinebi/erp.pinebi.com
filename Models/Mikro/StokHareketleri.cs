using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_hareketleri")]
public class StokHareketleri
{
    [Column("sth_Guid")]
    public Guid SthGuid { get; set; }

    [Column("sth_DBCno")]
    public short? SthDBCno { get; set; }

    [Column("sth_SpecRECno")]
    public int? SthSpecRECno { get; set; }

    [Column("sth_iptal")]
    public bool? SthIptal { get; set; }

    [Column("sth_fileid")]
    public short? SthFileid { get; set; }

    [Column("sth_hidden")]
    public bool? SthHidden { get; set; }

    [Column("sth_kilitli")]
    public bool? SthKilitli { get; set; }

    [Column("sth_degisti")]
    public bool? SthDegisti { get; set; }

    [Column("sth_checksum")]
    public int? SthChecksum { get; set; }

    [Column("sth_create_user")]
    public short? SthCreateUser { get; set; }

    [Column("sth_create_date")]
    public DateTime? SthCreateDate { get; set; }

    [Column("sth_lastup_user")]
    public short? SthLastupUser { get; set; }

    [Column("sth_lastup_date")]
    public DateTime? SthLastupDate { get; set; }

    [Column("sth_special1")]
    [StringLength(4)]
    public string? SthSpecial1 { get; set; }

    [Column("sth_special2")]
    [StringLength(4)]
    public string? SthSpecial2 { get; set; }

    [Column("sth_special3")]
    [StringLength(4)]
    public string? SthSpecial3 { get; set; }

    [Column("sth_firmano")]
    public int? SthFirmano { get; set; }

    [Column("sth_subeno")]
    public int? SthSubeno { get; set; }

    [Column("sth_tarih")]
    public DateTime? SthTarih { get; set; }

    [Column("sth_tip")]
    public byte? SthTip { get; set; }

    [Column("sth_cins")]
    public byte? SthCins { get; set; }

    [Column("sth_normal_iade")]
    public byte? SthNormalIade { get; set; }

    [Column("sth_evraktip")]
    public byte? SthEvraktip { get; set; }

    [Column("sth_evrakno_seri")]
    [StringLength(5)]
    public string? SthEvraknoSeri { get; set; }

    [Column("sth_evrakno_sira")]
    public int? SthEvraknoSira { get; set; }

    [Column("sth_satirno")]
    public int? SthSatirno { get; set; }

    [Column("sth_belge_no")]
    [StringLength(25)]
    public string? SthBelgeNo { get; set; }

    [Column("sth_belge_tarih")]
    public DateTime? SthBelgeTarih { get; set; }

    [Column("sth_stok_kod")]
    [StringLength(25)]
    public string? SthStokKod { get; set; }

    [Column("sth_isk_mas1")]
    public byte? SthIskMas1 { get; set; }

    [Column("sth_isk_mas2")]
    public byte? SthIskMas2 { get; set; }

    [Column("sth_isk_mas3")]
    public byte? SthIskMas3 { get; set; }

    [Column("sth_isk_mas4")]
    public byte? SthIskMas4 { get; set; }

    [Column("sth_isk_mas5")]
    public byte? SthIskMas5 { get; set; }

    [Column("sth_isk_mas6")]
    public byte? SthIskMas6 { get; set; }

    [Column("sth_isk_mas7")]
    public byte? SthIskMas7 { get; set; }

    [Column("sth_isk_mas8")]
    public byte? SthIskMas8 { get; set; }

    [Column("sth_isk_mas9")]
    public byte? SthIskMas9 { get; set; }

    [Column("sth_isk_mas10")]
    public byte? SthIskMas10 { get; set; }

    [Column("sth_sat_iskmas1")]
    public bool? SthSatIskmas1 { get; set; }

    [Column("sth_sat_iskmas2")]
    public bool? SthSatIskmas2 { get; set; }

    [Column("sth_sat_iskmas3")]
    public bool? SthSatIskmas3 { get; set; }

    [Column("sth_sat_iskmas4")]
    public bool? SthSatIskmas4 { get; set; }

    [Column("sth_sat_iskmas5")]
    public bool? SthSatIskmas5 { get; set; }

    [Column("sth_sat_iskmas6")]
    public bool? SthSatIskmas6 { get; set; }

    [Column("sth_sat_iskmas7")]
    public bool? SthSatIskmas7 { get; set; }

    [Column("sth_sat_iskmas8")]
    public bool? SthSatIskmas8 { get; set; }

    [Column("sth_sat_iskmas9")]
    public bool? SthSatIskmas9 { get; set; }

    [Column("sth_sat_iskmas10")]
    public bool? SthSatIskmas10 { get; set; }

    [Column("sth_pos_satis")]
    public bool? SthPosSatis { get; set; }

    [Column("sth_promosyon_fl")]
    public bool? SthPromosyonFl { get; set; }

    [Column("sth_cari_cinsi")]
    public byte? SthCariCinsi { get; set; }

    [Column("sth_cari_kodu")]
    [StringLength(25)]
    public string? SthCariKodu { get; set; }

    [Column("sth_cari_grup_no")]
    public byte? SthCariGrupNo { get; set; }

    [Column("sth_isemri_gider_kodu")]
    [StringLength(10)]
    public string? SthIsemriGiderKodu { get; set; }

    [Column("sth_plasiyer_kodu")]
    [StringLength(25)]
    public string? SthPlasiyerKodu { get; set; }

    [Column("sth_har_doviz_cinsi")]
    public byte? SthHarDovizCinsi { get; set; }

    [Column("sth_har_doviz_kuru")]
    public double? SthHarDovizKuru { get; set; }

    [Column("sth_alt_doviz_kuru")]
    public double? SthAltDovizKuru { get; set; }

    [Column("sth_stok_doviz_cinsi")]
    public byte? SthStokDovizCinsi { get; set; }

    [Column("sth_stok_doviz_kuru")]
    public double? SthStokDovizKuru { get; set; }

    [Column("sth_miktar")]
    public double? SthMiktar { get; set; }

    [Column("sth_miktar2")]
    public double? SthMiktar2 { get; set; }

    [Column("sth_birim_pntr")]
    public byte? SthBirimPntr { get; set; }

    [Column("sth_tutar")]
    public double? SthTutar { get; set; }

    [Column("sth_iskonto1")]
    public double? SthIskonto1 { get; set; }

    [Column("sth_iskonto2")]
    public double? SthIskonto2 { get; set; }

    [Column("sth_iskonto3")]
    public double? SthIskonto3 { get; set; }

    [Column("sth_iskonto4")]
    public double? SthIskonto4 { get; set; }

    [Column("sth_iskonto5")]
    public double? SthIskonto5 { get; set; }

    [Column("sth_iskonto6")]
    public double? SthIskonto6 { get; set; }

    [Column("sth_masraf1")]
    public double? SthMasraf1 { get; set; }

    [Column("sth_masraf2")]
    public double? SthMasraf2 { get; set; }

    [Column("sth_masraf3")]
    public double? SthMasraf3 { get; set; }

    [Column("sth_masraf4")]
    public double? SthMasraf4 { get; set; }

    [Column("sth_vergi_pntr")]
    public byte? SthVergiPntr { get; set; }

    [Column("sth_vergi")]
    public double? SthVergi { get; set; }

    [Column("sth_masraf_vergi_pntr")]
    public byte? SthMasrafVergiPntr { get; set; }

    [Column("sth_masraf_vergi")]
    public double? SthMasrafVergi { get; set; }

    [Column("sth_netagirlik")]
    public double? SthNetagirlik { get; set; }

    [Column("sth_odeme_op")]
    public int? SthOdemeOp { get; set; }

    [Column("sth_aciklama")]
    [StringLength(50)]
    public string? SthAciklama { get; set; }

    [Column("sth_sip_uid")]
    public Guid? SthSipUid { get; set; }

    [Column("sth_fat_uid")]
    public Guid? SthFatUid { get; set; }

    [Column("sth_giris_depo_no")]
    public int? SthGirisDepoNo { get; set; }

    [Column("sth_cikis_depo_no")]
    public int? SthCikisDepoNo { get; set; }

    [Column("sth_malkbl_sevk_tarihi")]
    public DateTime? SthMalkblSevkTarihi { get; set; }

    [Column("sth_cari_srm_merkezi")]
    [StringLength(25)]
    public string? SthCariSrmMerkezi { get; set; }

    [Column("sth_stok_srm_merkezi")]
    [StringLength(25)]
    public string? SthStokSrmMerkezi { get; set; }

    [Column("sth_fis_tarihi")]
    public DateTime? SthFisTarihi { get; set; }

    [Column("sth_fis_sirano")]
    public int? SthFisSirano { get; set; }

    [Column("sth_vergisiz_fl")]
    public bool? SthVergisizFl { get; set; }

    [Column("sth_maliyet_ana")]
    public double? SthMaliyetAna { get; set; }

    [Column("sth_maliyet_alternatif")]
    public double? SthMaliyetAlternatif { get; set; }

    [Column("sth_maliyet_orjinal")]
    public double? SthMaliyetOrjinal { get; set; }

    [Column("sth_adres_no")]
    public int? SthAdresNo { get; set; }

    [Column("sth_parti_kodu")]
    [StringLength(25)]
    public string? SthPartiKodu { get; set; }

    [Column("sth_lot_no")]
    public int? SthLotNo { get; set; }

    [Column("sth_kons_uid")]
    public Guid? SthKonsUid { get; set; }

    [Column("sth_proje_kodu")]
    [StringLength(25)]
    public string? SthProjeKodu { get; set; }

    [Column("sth_exim_kodu")]
    [StringLength(25)]
    public string? SthEximKodu { get; set; }

    [Column("sth_otv_pntr")]
    public byte? SthOtvPntr { get; set; }

    [Column("sth_otv_vergi")]
    public double? SthOtvVergi { get; set; }

    [Column("sth_brutagirlik")]
    public double? SthBrutagirlik { get; set; }

    [Column("sth_disticaret_turu")]
    public byte? SthDisticaretTuru { get; set; }

    [Column("sth_otvtutari")]
    public double? SthOtvtutari { get; set; }

    [Column("sth_otvvergisiz_fl")]
    public bool? SthOtvvergisizFl { get; set; }

    [Column("sth_oiv_pntr")]
    public byte? SthOivPntr { get; set; }

    [Column("sth_oiv_vergi")]
    public double? SthOivVergi { get; set; }

    [Column("sth_oivvergisiz_fl")]
    public bool? SthOivvergisizFl { get; set; }

    [Column("sth_fiyat_liste_no")]
    public int? SthFiyatListeNo { get; set; }

    [Column("sth_oivtutari")]
    public double? SthOivtutari { get; set; }

    [Column("sth_Tevkifat_turu")]
    public byte? SthTevkifatTuru { get; set; }

    [Column("sth_nakliyedeposu")]
    public int? SthNakliyedeposu { get; set; }

    [Column("sth_nakliyedurumu")]
    public byte? SthNakliyedurumu { get; set; }

    [Column("sth_yetkili_uid")]
    public Guid? SthYetkiliUid { get; set; }

    [Column("sth_taxfree_fl")]
    public bool? SthTaxfreeFl { get; set; }

    [Column("sth_ilave_edilecek_kdv")]
    public double? SthIlaveEdilecekKdv { get; set; }

    [Column("sth_ismerkezi_kodu")]
    [StringLength(25)]
    public string? SthIsmerkeziKodu { get; set; }
}
