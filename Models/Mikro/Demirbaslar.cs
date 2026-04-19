using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("demirbaslar")]
public class Demirbaslar
{
    [Column("dem_Guid")]
    public Guid? DemGuid { get; set; }

    [Column("dem_DBCno")]
    public short? DemDBCno { get; set; }

    [Column("dem_SpecRECno")]
    public int? DemSpecRECno { get; set; }

    [Column("dem_iptal")]
    public bool? DemIptal { get; set; }

    [Column("dem_fileid")]
    public short? DemFileid { get; set; }

    [Column("dem_hidden")]
    public bool? DemHidden { get; set; }

    [Column("dem_kilitli")]
    public bool? DemKilitli { get; set; }

    [Column("dem_degisti")]
    public bool? DemDegisti { get; set; }

    [Column("dem_checksum")]
    public int? DemChecksum { get; set; }

    [Column("dem_create_user")]
    public short? DemCreateUser { get; set; }

    [Column("dem_create_date")]
    public DateTime? DemCreateDate { get; set; }

    [Column("dem_lastup_user")]
    public short? DemLastupUser { get; set; }

    [Column("dem_lastup_date")]
    public DateTime? DemLastupDate { get; set; }

    [Column("dem_special1")]
    [StringLength(4)]
    public string? DemSpecial1 { get; set; }

    [Column("dem_special2")]
    [StringLength(4)]
    public string? DemSpecial2 { get; set; }

    [Column("dem_special3")]
    [StringLength(4)]
    public string? DemSpecial3 { get; set; }

    [Column("dem_firmano")]
    public int? DemFirmano { get; set; }

    [Column("dem_subeno")]
    public int? DemSubeno { get; set; }

    [Column("dem_kod")]
    [StringLength(25)]
    public string? DemKod { get; set; }

    [Column("dem_isim")]
    [StringLength(50)]
    public string? DemIsim { get; set; }

    [Column("dem_aciklama")]
    [StringLength(50)]
    public string? DemAciklama { get; set; }

    [Column("dem_doviz_cinsi")]
    public byte? DemDovizCinsi { get; set; }

    [Column("dem_vergi")]
    public byte? DemVergi { get; set; }

    [Column("dem_amortoran")]
    public double? DemAmortoran { get; set; }

    [Column("dem_amortip")]
    public byte? DemAmortip { get; set; }

    [Column("dem_birim")]
    [StringLength(10)]
    public string? DemBirim { get; set; }

    [Column("dem_fatura_tarihi")]
    public DateTime? DemFaturaTarihi { get; set; }

    [Column("dem_fatura_seri")]
    [StringLength(50)]
    public string? DemFaturaSeri { get; set; }

    [Column("dem_fatura_sira")]
    public int? DemFaturaSira { get; set; }

    [Column("dem_tutar")]
    public double? DemTutar { get; set; }

    [Column("dem_tutar_alternatif")]
    public double? DemTutarAlternatif { get; set; }

    [Column("dem_tutar_orjinal")]
    public double? DemTutarOrjinal { get; set; }

    [Column("dem_miktar")]
    public double? DemMiktar { get; set; }

    [Column("dem_dagankodu")]
    [StringLength(25)]
    public string? DemDagankodu { get; set; }

    [Column("dem_sozlesmekodu")]
    [StringLength(25)]
    public string? DemSozlesmekodu { get; set; }

    [Column("dem_muh_kodu")]
    [StringLength(40)]
    public string? DemMuhKodu { get; set; }

    [Column("dem_birik_amort_muh")]
    [StringLength(40)]
    public string? DemBirikAmortMuh { get; set; }

    [Column("dem_ydf_muh_kod")]
    [StringLength(40)]
    public string? DemYdfMuhKod { get; set; }

    [Column("dem_amorgider_muhkod")]
    [StringLength(40)]
    public string? DemAmorgiderMuhkod { get; set; }

    [Column("dem_maliyet_artis_mu")]
    [StringLength(40)]
    public string? DemMaliyetArtisMu { get; set; }

    [Column("dem_satis_kar_muhkod")]
    [StringLength(40)]
    public string? DemSatisKarMuhkod { get; set; }

    [Column("dem_satis_zarar_muhk")]
    [StringLength(40)]
    public string? DemSatisZararMuhk { get; set; }

    [Column("dem_yeni_fon_muhkodu")]
    [StringLength(40)]
    public string? DemYeniFonMuhkodu { get; set; }

    [Column("dem_SermEkgmStsKaz_m")]
    [StringLength(40)]
    public string? DemSermEkgmStsKazM { get; set; }

    [Column("dem_amorgidkar_muhkod")]
    [StringLength(40)]
    public string? DemAmorgidkarMuhkod { get; set; }

    [Column("dem_yatirimtes_muhkod")]
    [StringLength(40)]
    public string? DemYatirimtesMuhkod { get; set; }

    [Column("dem_amort_masraf_kodu")]
    [StringLength(25)]
    public string? DemAmortMasrafKodu { get; set; }

    [Column("dem_isl_demirbas_kodu")]
    [StringLength(25)]
    public string? DemIslDemirbasKodu { get; set; }

    [Column("dem_makinetesis_fl")]
    public bool? DemMakinetesisFl { get; set; }

    [Column("dem_emlak_fl")]
    public bool? DemEmlakFl { get; set; }

    [Column("dem_izdusum_fl")]
    public bool? DemIzdusumFl { get; set; }

    [Column("dem_yeni_degyo_fl")]
    public bool? DemYeniDegyoFl { get; set; }

    [Column("dem_kistas_fl")]
    public bool? DemKistasFl { get; set; }

    [Column("dem_tesfik_fl")]
    public bool? DemTesfikFl { get; set; }

    [Column("dem_atikizdeger_dusu")]
    public double? DemAtikizdegerDusu { get; set; }

    [Column("dem_zimmetyeri")]
    [StringLength(25)]
    public string? DemZimmetyeri { get; set; }

    [Column("dem_zimmetcaripers")]
    [StringLength(25)]
    public string? DemZimmetcaripers { get; set; }

    [Column("dem_grupkodu")]
    [StringLength(25)]
    public string? DemGrupkodu { get; set; }

    [Column("dem_SrmmMrkKodu")]
    [StringLength(25)]
    public string? DemSrmmMrkKodu { get; set; }

    [Column("dem_enf_tabii")]
    public byte? DemEnfTabii { get; set; }

    [Column("dem_muhgrup_kodu")]
    [StringLength(25)]
    public string? DemMuhgrupKodu { get; set; }

    [Column("dem_mkod_artik")]
    [StringLength(10)]
    public string? DemMkodArtik { get; set; }

    [Column("dem_faydaliOmur_kodu")]
    [StringLength(25)]
    public string? DemFaydaliOmurKodu { get; set; }

    [Column("dem_ProjeKodu")]
    [StringLength(25)]
    public string? DemProjeKodu { get; set; }

    [Column("dem_altfaydali_omur_kodu")]
    [StringLength(25)]
    public string? DemAltfaydaliOmurKodu { get; set; }

    [Column("dem_alternatif_amortoran")]
    public double? DemAlternatifAmortoran { get; set; }

    [Column("dem_ufrstutar")]
    public double? DemUfrstutar { get; set; }

    [Column("dem_ufrstutar_alternatif")]
    public double? DemUfrstutarAlternatif { get; set; }

    [Column("dem_ufrstutar_orjinal")]
    public double? DemUfrstutarOrjinal { get; set; }

    [Column("dem_ufrsamortip")]
    public byte? DemUfrsamortip { get; set; }

    [Column("dem_ufrs_omur_kodu")]
    [StringLength(25)]
    public string? DemUfrsOmurKodu { get; set; }

    [Column("dem_ufrsamortoran")]
    public double? DemUfrsamortoran { get; set; }

    [Column("dem_ufrskistas_fl")]
    public bool? DemUfrskistasFl { get; set; }

    [Column("dem_ufrsfark_muh_kodu")]
    [StringLength(40)]
    public string? DemUfrsfarkMuhKodu { get; set; }

    [Column("dem_birik_amort_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemBirikAmortUfrsfarkKodu { get; set; }

    [Column("dem_ydf_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemYdfUfrsfarkKodu { get; set; }

    [Column("dem_amorgider_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemAmorgiderUfrsfarkKodu { get; set; }

    [Column("dem_maliyet_artis_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemMaliyetArtisUfrsfarkKodu { get; set; }

    [Column("dem_satis_kar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemSatisKarUfrsfarkKodu { get; set; }

    [Column("dem_satis_zarar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemSatisZararUfrsfarkKodu { get; set; }

    [Column("dem_yeni_fon_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemYeniFonUfrsfarkKodu { get; set; }

    [Column("dem_SermEkgmStsKaz_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemSermEkgmStsKazUfrsfarkKodu { get; set; }

    [Column("dem_amorgidkar_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemAmorgidkarUfrsfarkKodu { get; set; }

    [Column("dem_yatirimtes_ufrsfark_kodu")]
    [StringLength(40)]
    public string? DemYatirimtesUfrsfarkKodu { get; set; }

    [Column("dem_otv_tutar")]
    public double? DemOtvTutar { get; set; }

    [Column("dem_otv_maliyete_eklensin_fl")]
    public bool? DemOtvMaliyeteEklensinFl { get; set; }
}
