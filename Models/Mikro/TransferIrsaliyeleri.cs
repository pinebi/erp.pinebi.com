using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("transfer_irsaliyeleri")]
public class TransferIrsaliyeleri
{
    [Column("transirs_Guid")]
    public Guid? TransirsGuid { get; set; }

    [Column("transirs_DBCno")]
    public short? TransirsDBCno { get; set; }

    [Column("transirs_SpecRECno")]
    public int? TransirsSpecRECno { get; set; }

    [Column("transirs_iptal")]
    public bool? TransirsIptal { get; set; }

    [Column("transirs_fileid")]
    public short? TransirsFileid { get; set; }

    [Column("transirs_hidden")]
    public bool? TransirsHidden { get; set; }

    [Column("transirs_kilitli")]
    public bool? TransirsKilitli { get; set; }

    [Column("transirs_degisti")]
    public bool? TransirsDegisti { get; set; }

    [Column("transirs_checksum")]
    public int? TransirsChecksum { get; set; }

    [Column("transirs_create_user")]
    public short? TransirsCreateUser { get; set; }

    [Column("transirs_create_date")]
    public DateTime? TransirsCreateDate { get; set; }

    [Column("transirs_lastup_user")]
    public short? TransirsLastupUser { get; set; }

    [Column("transirs_lastup_date")]
    public DateTime? TransirsLastupDate { get; set; }

    [Column("transirs_special1")]
    [StringLength(4)]
    public string? TransirsSpecial1 { get; set; }

    [Column("transirs_special2")]
    [StringLength(4)]
    public string? TransirsSpecial2 { get; set; }

    [Column("transirs_special3")]
    [StringLength(4)]
    public string? TransirsSpecial3 { get; set; }

    [Column("transirs_firmano")]
    public int? TransirsFirmano { get; set; }

    [Column("transirs_subeno")]
    public int? TransirsSubeno { get; set; }

    [Column("transirs_tarih")]
    public DateTime? TransirsTarih { get; set; }

    [Column("transirs_evrakno_seri")]
    [StringLength(50)]
    public string? TransirsEvraknoSeri { get; set; }

    [Column("transirs_evrakno_sira")]
    public int? TransirsEvraknoSira { get; set; }

    [Column("transirs_satirno")]
    public int? TransirsSatirno { get; set; }

    [Column("transirs_belge_no")]
    [StringLength(50)]
    public string? TransirsBelgeNo { get; set; }

    [Column("transirs_belge_tarih")]
    public DateTime? TransirsBelgeTarih { get; set; }

    [Column("transirs_talepcarikodu")]
    [StringLength(25)]
    public string? TransirsTalepcarikodu { get; set; }

    [Column("transirs_talepcarigrupno")]
    public byte? TransirsTalepcarigrupno { get; set; }

    [Column("transirs_talepcariadresno")]
    public int? TransirsTalepcariadresno { get; set; }

    [Column("transirs_temincarikodu")]
    [StringLength(25)]
    public string? TransirsTemincarikodu { get; set; }

    [Column("transirs_temincarigrupno")]
    public byte? TransirsTemincarigrupno { get; set; }

    [Column("transirs_temincariadresno")]
    public int? TransirsTemincariadresno { get; set; }

    [Column("transirs_plasiyer_kodu")]
    [StringLength(25)]
    public string? TransirsPlasiyerKodu { get; set; }

    [Column("transirs_stok_kod")]
    [StringLength(25)]
    public string? TransirsStokKod { get; set; }

    [Column("transirs_isk_mas1")]
    public byte? TransirsIskMas1 { get; set; }

    [Column("transirs_isk_mas2")]
    public byte? TransirsIskMas2 { get; set; }

    [Column("transirs_isk_mas3")]
    public byte? TransirsIskMas3 { get; set; }

    [Column("transirs_isk_mas4")]
    public byte? TransirsIskMas4 { get; set; }

    [Column("transirs_isk_mas5")]
    public byte? TransirsIskMas5 { get; set; }

    [Column("transirs_isk_mas6")]
    public byte? TransirsIskMas6 { get; set; }

    [Column("transirs_isk_mas7")]
    public byte? TransirsIskMas7 { get; set; }

    [Column("transirs_isk_mas8")]
    public byte? TransirsIskMas8 { get; set; }

    [Column("transirs_isk_mas9")]
    public byte? TransirsIskMas9 { get; set; }

    [Column("transirs_isk_mas10")]
    public byte? TransirsIskMas10 { get; set; }

    [Column("transirs_sat_iskmas1")]
    public bool? TransirsSatIskmas1 { get; set; }

    [Column("transirs_sat_iskmas2")]
    public bool? TransirsSatIskmas2 { get; set; }

    [Column("transirs_sat_iskmas3")]
    public bool? TransirsSatIskmas3 { get; set; }

    [Column("transirs_sat_iskmas4")]
    public bool? TransirsSatIskmas4 { get; set; }

    [Column("transirs_sat_iskmas5")]
    public bool? TransirsSatIskmas5 { get; set; }

    [Column("transirs_sat_iskmas6")]
    public bool? TransirsSatIskmas6 { get; set; }

    [Column("transirs_sat_iskmas7")]
    public bool? TransirsSatIskmas7 { get; set; }

    [Column("transirs_sat_iskmas8")]
    public bool? TransirsSatIskmas8 { get; set; }

    [Column("transirs_sat_iskmas9")]
    public bool? TransirsSatIskmas9 { get; set; }

    [Column("transirs_sat_iskmas10")]
    public bool? TransirsSatIskmas10 { get; set; }

    [Column("transirs_paket_kodu")]
    [StringLength(25)]
    public string? TransirsPaketKodu { get; set; }

    [Column("transirs_har_doviz_cinsi")]
    public byte? TransirsHarDovizCinsi { get; set; }

    [Column("transirs_har_doviz_kuru")]
    public double? TransirsHarDovizKuru { get; set; }

    [Column("transirs_alt_doviz_kuru")]
    public double? TransirsAltDovizKuru { get; set; }

    [Column("transirs_stok_doviz_cinsi")]
    public byte? TransirsStokDovizCinsi { get; set; }

    [Column("transirs_stok_doviz_kuru")]
    public double? TransirsStokDovizKuru { get; set; }

    [Column("transirs_miktar")]
    public double? TransirsMiktar { get; set; }

    [Column("transirs_miktar2")]
    public double? TransirsMiktar2 { get; set; }

    [Column("transirs_birim_pntr")]
    public byte? TransirsBirimPntr { get; set; }

    [Column("transirs_birimfiyati")]
    public double? TransirsBirimfiyati { get; set; }

    [Column("transirs_tutar")]
    public double? TransirsTutar { get; set; }

    [Column("transirs_iskonto1")]
    public double? TransirsIskonto1 { get; set; }

    [Column("transirs_iskonto2")]
    public double? TransirsIskonto2 { get; set; }

    [Column("transirs_iskonto3")]
    public double? TransirsIskonto3 { get; set; }

    [Column("transirs_iskonto4")]
    public double? TransirsIskonto4 { get; set; }

    [Column("transirs_iskonto5")]
    public double? TransirsIskonto5 { get; set; }

    [Column("transirs_iskonto6")]
    public double? TransirsIskonto6 { get; set; }

    [Column("transirs_masraf1")]
    public double? TransirsMasraf1 { get; set; }

    [Column("transirs_masraf2")]
    public double? TransirsMasraf2 { get; set; }

    [Column("transirs_masraf3")]
    public double? TransirsMasraf3 { get; set; }

    [Column("transirs_masraf4")]
    public double? TransirsMasraf4 { get; set; }

    [Column("transirs_vergi_pntr")]
    public byte? TransirsVergiPntr { get; set; }

    [Column("transirs_vergi")]
    public double? TransirsVergi { get; set; }

    [Column("transirs_masraf_vergi_pntr")]
    public byte? TransirsMasrafVergiPntr { get; set; }

    [Column("transirs_masraf_vergi")]
    public double? TransirsMasrafVergi { get; set; }

    [Column("transirs_netagirlik")]
    public double? TransirsNetagirlik { get; set; }

    [Column("transirs_odeme_op")]
    public int? TransirsOdemeOp { get; set; }

    [Column("transirs_aciklama")]
    [StringLength(50)]
    public string? TransirsAciklama { get; set; }

    [Column("transirs_sip_uid")]
    public Guid? TransirsSipUid { get; set; }

    [Column("transirs_malkbl_sevk_tarihi")]
    public DateTime? TransirsMalkblSevkTarihi { get; set; }

    [Column("transirs_cari_srm_merkezi")]
    [StringLength(25)]
    public string? TransirsCariSrmMerkezi { get; set; }

    [Column("transirs_stok_srm_merkezi")]
    [StringLength(25)]
    public string? TransirsStokSrmMerkezi { get; set; }

    [Column("transirs_vergisiz_fl")]
    public bool? TransirsVergisizFl { get; set; }

    [Column("transirs_maliyet_ana")]
    public double? TransirsMaliyetAna { get; set; }

    [Column("transirs_maliyet_alternatif")]
    public double? TransirsMaliyetAlternatif { get; set; }

    [Column("transirs_maliyet_orjinal")]
    public double? TransirsMaliyetOrjinal { get; set; }

    [Column("transirs_parti_kodu")]
    [StringLength(25)]
    public string? TransirsPartiKodu { get; set; }

    [Column("transirs_lot_no")]
    public int? TransirsLotNo { get; set; }

    [Column("transirs_proje_kodu")]
    [StringLength(25)]
    public string? TransirsProjeKodu { get; set; }

    [Column("transirs_otv_pntr")]
    public byte? TransirsOtvPntr { get; set; }

    [Column("transirs_otv_vergi")]
    public double? TransirsOtvVergi { get; set; }

    [Column("transirs_brutagirlik")]
    public double? TransirsBrutagirlik { get; set; }

    [Column("transirs_otvtutari")]
    public double? TransirsOtvtutari { get; set; }

    [Column("transirs_otvvergisiz_fl")]
    public bool? TransirsOtvvergisizFl { get; set; }

    [Column("transirs_oiv_pntr")]
    public byte? TransirsOivPntr { get; set; }

    [Column("transirs_oiv_tutar")]
    public double? TransirsOivTutar { get; set; }

    [Column("transirs_oiv_vergi")]
    public double? TransirsOivVergi { get; set; }

    [Column("transirs_oivvergisiz_fl")]
    public bool? TransirsOivvergisizFl { get; set; }

    [Column("transirs_fiyat_liste_no")]
    public int? TransirsFiyatListeNo { get; set; }

    [Column("transirs_talepkomfat_uid")]
    public Guid? TransirsTalepkomfatUid { get; set; }

    [Column("transirs_teminkomfat_uid")]
    public Guid? TransirsTeminkomfatUid { get; set; }
}
