using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("konsinye_hareketleri")]
public class KonsinyeHareketleri
{
    [Column("kon_Guid")]
    public Guid? KonGuid { get; set; }

    [Column("kon_DBCno")]
    public short? KonDBCno { get; set; }

    [Column("kon_SpecRecno")]
    public int? KonSpecRecno { get; set; }

    [Column("kon_iptal")]
    public bool? KonIptal { get; set; }

    [Column("kon_fileid")]
    public short? KonFileid { get; set; }

    [Column("kon_hidden")]
    public bool? KonHidden { get; set; }

    [Column("kon_kilitli")]
    public bool? KonKilitli { get; set; }

    [Column("kon_degisti")]
    public bool? KonDegisti { get; set; }

    [Column("kon_checksum")]
    public int? KonChecksum { get; set; }

    [Column("kon_create_user")]
    public short? KonCreateUser { get; set; }

    [Column("kon_create_date")]
    public DateTime? KonCreateDate { get; set; }

    [Column("kon_lastup_user")]
    public short? KonLastupUser { get; set; }

    [Column("kon_lastup_date")]
    public DateTime? KonLastupDate { get; set; }

    [Column("kon_special1")]
    [StringLength(4)]
    public string? KonSpecial1 { get; set; }

    [Column("kon_special2")]
    [StringLength(4)]
    public string? KonSpecial2 { get; set; }

    [Column("kon_special3")]
    [StringLength(4)]
    public string? KonSpecial3 { get; set; }

    [Column("kon_firmano")]
    public int? KonFirmano { get; set; }

    [Column("kon_subeno")]
    public int? KonSubeno { get; set; }

    [Column("kon_tarih")]
    public DateTime? KonTarih { get; set; }

    [Column("kon_tip")]
    public byte? KonTip { get; set; }

    [Column("kon_normal_iade")]
    public byte? KonNormalIade { get; set; }

    [Column("kon_evrakno_seri")]
    [StringLength(50)]
    public string? KonEvraknoSeri { get; set; }

    [Column("kon_evrakno_sira")]
    public int? KonEvraknoSira { get; set; }

    [Column("kon_satirno")]
    public int? KonSatirno { get; set; }

    [Column("kon_belge_no")]
    [StringLength(50)]
    public string? KonBelgeNo { get; set; }

    [Column("kon_belge_tarih")]
    public DateTime? KonBelgeTarih { get; set; }

    [Column("kon_stok_kod")]
    [StringLength(25)]
    public string? KonStokKod { get; set; }

    [Column("kon_cari_kod")]
    [StringLength(25)]
    public string? KonCariKod { get; set; }

    [Column("kon_satici_kod")]
    [StringLength(25)]
    public string? KonSaticiKod { get; set; }

    [Column("kon_miktar")]
    public double? KonMiktar { get; set; }

    [Column("kon_faturalanan")]
    public double? KonFaturalanan { get; set; }

    [Column("kon_aciklama")]
    [StringLength(50)]
    public string? KonAciklama { get; set; }

    [Column("kon_giris_depo_no")]
    public int? KonGirisDepoNo { get; set; }

    [Column("kon_cikis_depo_no")]
    public int? KonCikisDepoNo { get; set; }

    [Column("kon_malkabul_tarih")]
    public DateTime? KonMalkabulTarih { get; set; }

    [Column("kon_sip_uid")]
    public Guid? KonSipUid { get; set; }

    [Column("kon_islemgoren")]
    public double? KonIslemgoren { get; set; }

    [Column("kon_karkon_uid")]
    public Guid? KonKarkonUid { get; set; }

    [Column("kon_netagirlik")]
    public double? KonNetagirlik { get; set; }

    [Column("kon_brutagirlik")]
    public double? KonBrutagirlik { get; set; }

    [Column("kon_rehinmiktari")]
    public double? KonRehinmiktari { get; set; }

    [Column("kon_rehinfiyati")]
    public double? KonRehinfiyati { get; set; }

    [Column("kon_miktar2")]
    public double? KonMiktar2 { get; set; }

    [Column("kon_islemgoren2")]
    public double? KonIslemgoren2 { get; set; }

    [Column("kon_sandikmiktari")]
    public double? KonSandikmiktari { get; set; }

    [Column("kon_sandikfiyati")]
    public double? KonSandikfiyati { get; set; }

    [Column("kon_sevk_adresno")]
    public short? KonSevkAdresno { get; set; }

    [Column("kon_cari_srm_merkez")]
    [StringLength(25)]
    public string? KonCariSrmMerkez { get; set; }

    [Column("kon_stok_srm_merkez")]
    [StringLength(25)]
    public string? KonStokSrmMerkez { get; set; }

    [Column("kons_parti_kodu")]
    [StringLength(25)]
    public string? KonsPartiKodu { get; set; }

    [Column("kons_lot_no")]
    public int? KonsLotNo { get; set; }

    [Column("kons_projekodu")]
    [StringLength(25)]
    public string? KonsProjekodu { get; set; }

    [Column("kons_har_doviz_cinsi")]
    public byte? KonsHarDovizCinsi { get; set; }

    [Column("kons_har_doviz_kuru")]
    public double? KonsHarDovizKuru { get; set; }

    [Column("kons_alt_doviz_kuru")]
    public double? KonsAltDovizKuru { get; set; }

    [Column("kons_stok_doviz_cinsi")]
    public byte? KonsStokDovizCinsi { get; set; }

    [Column("kons_stok_doviz_kuru")]
    public double? KonsStokDovizKuru { get; set; }

    [Column("kons_odeme_op")]
    public int? KonsOdemeOp { get; set; }

    [Column("kons_birim_pntr")]
    public byte? KonsBirimPntr { get; set; }

    [Column("kons_tutar")]
    public double? KonsTutar { get; set; }

    [Column("kons_isk_mas1")]
    public byte? KonsIskMas1 { get; set; }

    [Column("kons_isk_mas2")]
    public byte? KonsIskMas2 { get; set; }

    [Column("kons_isk_mas3")]
    public byte? KonsIskMas3 { get; set; }

    [Column("kons_isk_mas4")]
    public byte? KonsIskMas4 { get; set; }

    [Column("kons_isk_mas5")]
    public byte? KonsIskMas5 { get; set; }

    [Column("kons_isk_mas6")]
    public byte? KonsIskMas6 { get; set; }

    [Column("kons_isk_mas7")]
    public byte? KonsIskMas7 { get; set; }

    [Column("kons_isk_mas8")]
    public byte? KonsIskMas8 { get; set; }

    [Column("kons_isk_mas9")]
    public byte? KonsIskMas9 { get; set; }

    [Column("kons_isk_mas10")]
    public byte? KonsIskMas10 { get; set; }

    [Column("kons_sat_iskmas1")]
    public bool? KonsSatIskmas1 { get; set; }

    [Column("kons_sat_iskmas2")]
    public bool? KonsSatIskmas2 { get; set; }

    [Column("kons_sat_iskmas3")]
    public bool? KonsSatIskmas3 { get; set; }

    [Column("kons_sat_iskmas4")]
    public bool? KonsSatIskmas4 { get; set; }

    [Column("kons_sat_iskmas5")]
    public bool? KonsSatIskmas5 { get; set; }

    [Column("kons_sat_iskmas6")]
    public bool? KonsSatIskmas6 { get; set; }

    [Column("kons_sat_iskmas7")]
    public bool? KonsSatIskmas7 { get; set; }

    [Column("kons_sat_iskmas8")]
    public bool? KonsSatIskmas8 { get; set; }

    [Column("kons_sat_iskmas9")]
    public bool? KonsSatIskmas9 { get; set; }

    [Column("kons_sat_iskmas10")]
    public bool? KonsSatIskmas10 { get; set; }

    [Column("kons_iskonto1")]
    public double? KonsIskonto1 { get; set; }

    [Column("kons_iskonto2")]
    public double? KonsIskonto2 { get; set; }

    [Column("kons_iskonto3")]
    public double? KonsIskonto3 { get; set; }

    [Column("kons_iskonto4")]
    public double? KonsIskonto4 { get; set; }

    [Column("kons_iskonto5")]
    public double? KonsIskonto5 { get; set; }

    [Column("kons_iskonto6")]
    public double? KonsIskonto6 { get; set; }

    [Column("kons_masraf1")]
    public double? KonsMasraf1 { get; set; }

    [Column("kons_masraf2")]
    public double? KonsMasraf2 { get; set; }

    [Column("kons_masraf3")]
    public double? KonsMasraf3 { get; set; }

    [Column("kons_masraf4")]
    public double? KonsMasraf4 { get; set; }

    [Column("kons_vergi_pntr")]
    public byte? KonsVergiPntr { get; set; }

    [Column("kons_vergi")]
    public double? KonsVergi { get; set; }

    [Column("kons_masraf_vergi_pntr")]
    public byte? KonsMasrafVergiPntr { get; set; }

    [Column("kons_masraf_vergi")]
    public double? KonsMasrafVergi { get; set; }

    [Column("kons_vergisiz_fl")]
    public bool? KonsVergisizFl { get; set; }

    [Column("kons_otv_pntr")]
    public byte? KonsOtvPntr { get; set; }

    [Column("kons_otv_vergi")]
    public double? KonsOtvVergi { get; set; }

    [Column("kons_otvtutari")]
    public double? KonsOtvtutari { get; set; }

    [Column("kons_otvvergisiz_fl")]
    public bool? KonsOtvvergisizFl { get; set; }

    [Column("kons_oiv_pntr")]
    public byte? KonsOivPntr { get; set; }

    [Column("kons_oiv_vergi")]
    public double? KonsOivVergi { get; set; }

    [Column("kons_oivvergisiz_fl")]
    public bool? KonsOivvergisizFl { get; set; }

    [Column("kons_fiyat_liste_no")]
    public int? KonsFiyatListeNo { get; set; }

    [Column("kon_cins")]
    public byte? KonCins { get; set; }

    [Column("kon_evraktip")]
    public byte? KonEvraktip { get; set; }

    [Column("kon_gider_kodu")]
    [StringLength(25)]
    public string? KonGiderKodu { get; set; }

    [Column("kon_oivtutari")]
    public double? KonOivtutari { get; set; }

    [Column("kon_irs_uid")]
    public Guid? KonIrsUid { get; set; }

    [Column("kon_yetkili_uid")]
    public Guid? KonYetkiliUid { get; set; }

    [Column("kon_nakliyedeposu")]
    public int? KonNakliyedeposu { get; set; }

    [Column("kon_nakliyedurumu")]
    public byte? KonNakliyedurumu { get; set; }
}
