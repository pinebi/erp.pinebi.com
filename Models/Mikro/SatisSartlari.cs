using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("satis_sartlari")]
public class SatisSartlari
{
    [Column("sat_Guid")]
    public Guid? SatGuid { get; set; }

    [Column("sat_DBCno")]
    public short? SatDBCno { get; set; }

    [Column("sat_SpecRECno")]
    public int? SatSpecRECno { get; set; }

    [Column("sat_iptal")]
    public bool? SatIptal { get; set; }

    [Column("sat_fileid")]
    public short? SatFileid { get; set; }

    [Column("sat_hidden")]
    public bool? SatHidden { get; set; }

    [Column("sat_kilitli")]
    public bool? SatKilitli { get; set; }

    [Column("sat_degisti")]
    public bool? SatDegisti { get; set; }

    [Column("sat_checksum")]
    public int? SatChecksum { get; set; }

    [Column("sat_create_user")]
    public short? SatCreateUser { get; set; }

    [Column("sat_create_date")]
    public DateTime? SatCreateDate { get; set; }

    [Column("sat_lastup_user")]
    public short? SatLastupUser { get; set; }

    [Column("sat_lastup_date")]
    public DateTime? SatLastupDate { get; set; }

    [Column("sat_special1")]
    [StringLength(4)]
    public string? SatSpecial1 { get; set; }

    [Column("sat_special2")]
    [StringLength(4)]
    public string? SatSpecial2 { get; set; }

    [Column("sat_special3")]
    [StringLength(4)]
    public string? SatSpecial3 { get; set; }

    [Column("sat_stok_kod")]
    [StringLength(25)]
    public string? SatStokKod { get; set; }

    [Column("sat_cari_kod")]
    [StringLength(25)]
    public string? SatCariKod { get; set; }

    [Column("sat_evrakno_seri")]
    [StringLength(50)]
    public string? SatEvraknoSeri { get; set; }

    [Column("sat_evrakno_sira")]
    public int? SatEvraknoSira { get; set; }

    [Column("sat_evrak_tarih")]
    public DateTime? SatEvrakTarih { get; set; }

    [Column("sat_satirno")]
    public int? SatSatirno { get; set; }

    [Column("sat_belgeno")]
    [StringLength(50)]
    public string? SatBelgeno { get; set; }

    [Column("sat_belge_tarih")]
    public DateTime? SatBelgeTarih { get; set; }

    [Column("sat_asgari_miktar")]
    public double? SatAsgariMiktar { get; set; }

    [Column("sat_teslimat_sure")]
    public short? SatTeslimatSure { get; set; }

    [Column("sat_basla_tarih")]
    public DateTime? SatBaslaTarih { get; set; }

    [Column("sat_bitis_tarih")]
    public DateTime? SatBitisTarih { get; set; }

    [Column("sat_brut_fiyat")]
    public double? SatBrutFiyat { get; set; }

    [Column("sat_det_isk_acik1")]
    [StringLength(20)]
    public string? SatDetIskAcik1 { get; set; }

    [Column("sat_det_isk_uyg1")]
    public byte? SatDetIskUyg1 { get; set; }

    [Column("sat_det_isk_durum1")]
    public byte? SatDetIskDurum1 { get; set; }

    [Column("sat_det_isk_vergi1")]
    public byte? SatDetIskVergi1 { get; set; }

    [Column("sat_det_isk_kriter1")]
    public double? SatDetIskKriter1 { get; set; }

    [Column("sat_det_isk_yuzde1")]
    public double? SatDetIskYuzde1 { get; set; }

    [Column("sat_det_isk_miktar1")]
    public double? SatDetIskMiktar1 { get; set; }

    [Column("sat_det_isk_acik2")]
    [StringLength(20)]
    public string? SatDetIskAcik2 { get; set; }

    [Column("sat_det_isk_uyg2")]
    public byte? SatDetIskUyg2 { get; set; }

    [Column("sat_det_isk_durum2")]
    public byte? SatDetIskDurum2 { get; set; }

    [Column("sat_det_isk_vergi2")]
    public byte? SatDetIskVergi2 { get; set; }

    [Column("sat_det_isk_kriter2")]
    public double? SatDetIskKriter2 { get; set; }

    [Column("sat_det_isk_yuzde2")]
    public double? SatDetIskYuzde2 { get; set; }

    [Column("sat_det_isk_miktar2")]
    public double? SatDetIskMiktar2 { get; set; }

    [Column("sat_det_isk_acik3")]
    [StringLength(20)]
    public string? SatDetIskAcik3 { get; set; }

    [Column("sat_det_isk_uyg3")]
    public byte? SatDetIskUyg3 { get; set; }

    [Column("sat_det_isk_durum3")]
    public byte? SatDetIskDurum3 { get; set; }

    [Column("sat_det_isk_vergi3")]
    public byte? SatDetIskVergi3 { get; set; }

    [Column("sat_det_isk_kriter3")]
    public double? SatDetIskKriter3 { get; set; }

    [Column("sat_det_isk_yuzde3")]
    public double? SatDetIskYuzde3 { get; set; }

    [Column("sat_det_isk_miktar3")]
    public double? SatDetIskMiktar3 { get; set; }

    [Column("sat_det_isk_acik4")]
    [StringLength(20)]
    public string? SatDetIskAcik4 { get; set; }

    [Column("sat_det_isk_uyg4")]
    public byte? SatDetIskUyg4 { get; set; }

    [Column("sat_det_isk_durum4")]
    public byte? SatDetIskDurum4 { get; set; }

    [Column("sat_det_isk_vergi4")]
    public byte? SatDetIskVergi4 { get; set; }

    [Column("sat_det_isk_kriter4")]
    public double? SatDetIskKriter4 { get; set; }

    [Column("sat_det_isk_yuzde4")]
    public double? SatDetIskYuzde4 { get; set; }

    [Column("sat_det_isk_miktar4")]
    public double? SatDetIskMiktar4 { get; set; }

    [Column("sat_det_isk_acik5")]
    [StringLength(20)]
    public string? SatDetIskAcik5 { get; set; }

    [Column("sat_det_isk_uyg5")]
    public byte? SatDetIskUyg5 { get; set; }

    [Column("sat_det_isk_durum5")]
    public byte? SatDetIskDurum5 { get; set; }

    [Column("sat_det_isk_vergi5")]
    public byte? SatDetIskVergi5 { get; set; }

    [Column("sat_det_isk_kriter5")]
    public double? SatDetIskKriter5 { get; set; }

    [Column("sat_det_isk_yuzde5")]
    public double? SatDetIskYuzde5 { get; set; }

    [Column("sat_det_isk_miktar5")]
    public double? SatDetIskMiktar5 { get; set; }

    [Column("sat_det_isk_acik6")]
    [StringLength(20)]
    public string? SatDetIskAcik6 { get; set; }

    [Column("sat_det_isk_uyg6")]
    public byte? SatDetIskUyg6 { get; set; }

    [Column("sat_det_isk_durum6")]
    public byte? SatDetIskDurum6 { get; set; }

    [Column("sat_det_isk_vergi6")]
    public byte? SatDetIskVergi6 { get; set; }

    [Column("sat_det_isk_kriter6")]
    public double? SatDetIskKriter6 { get; set; }

    [Column("sat_det_isk_yuzde6")]
    public double? SatDetIskYuzde6 { get; set; }

    [Column("sat_det_isk_miktar6")]
    public double? SatDetIskMiktar6 { get; set; }

    [Column("sat_det_mas_acik1")]
    [StringLength(20)]
    public string? SatDetMasAcik1 { get; set; }

    [Column("sat_det_mas_uyg1")]
    public byte? SatDetMasUyg1 { get; set; }

    [Column("sat_det_mas_durum1")]
    public byte? SatDetMasDurum1 { get; set; }

    [Column("sas_det_mas_vergi1")]
    public byte? SasDetMasVergi1 { get; set; }

    [Column("sat_det_mas_kriter1")]
    public double? SatDetMasKriter1 { get; set; }

    [Column("sat_det_mas_yuzde1")]
    public double? SatDetMasYuzde1 { get; set; }

    [Column("sat_det_mas_miktar1")]
    public double? SatDetMasMiktar1 { get; set; }

    [Column("sat_det_mas_acik2")]
    [StringLength(20)]
    public string? SatDetMasAcik2 { get; set; }

    [Column("sat_det_mas_uyg2")]
    public byte? SatDetMasUyg2 { get; set; }

    [Column("sat_det_mas_durum2")]
    public byte? SatDetMasDurum2 { get; set; }

    [Column("sas_det_mas_vergi2")]
    public byte? SasDetMasVergi2 { get; set; }

    [Column("sat_det_mas_kriter2")]
    public double? SatDetMasKriter2 { get; set; }

    [Column("sat_det_mas_yuzde2")]
    public double? SatDetMasYuzde2 { get; set; }

    [Column("sat_det_mas_miktar2")]
    public double? SatDetMasMiktar2 { get; set; }

    [Column("sat_det_mas_acik3")]
    [StringLength(20)]
    public string? SatDetMasAcik3 { get; set; }

    [Column("sat_det_mas_uyg3")]
    public byte? SatDetMasUyg3 { get; set; }

    [Column("sat_det_mas_durum3")]
    public byte? SatDetMasDurum3 { get; set; }

    [Column("sas_det_mas_vergi3")]
    public byte? SasDetMasVergi3 { get; set; }

    [Column("sat_det_mas_kriter3")]
    public double? SatDetMasKriter3 { get; set; }

    [Column("sat_det_mas_yuzde3")]
    public double? SatDetMasYuzde3 { get; set; }

    [Column("sat_det_mas_miktar3")]
    public double? SatDetMasMiktar3 { get; set; }

    [Column("sat_det_mas_acik4")]
    [StringLength(20)]
    public string? SatDetMasAcik4 { get; set; }

    [Column("sat_det_mas_uyg4")]
    public byte? SatDetMasUyg4 { get; set; }

    [Column("sat_det_mas_durum4")]
    public byte? SatDetMasDurum4 { get; set; }

    [Column("sas_det_mas_vergi4")]
    public byte? SasDetMasVergi4 { get; set; }

    [Column("sat_det_mas_kriter4")]
    public double? SatDetMasKriter4 { get; set; }

    [Column("sat_det_mas_yuzde4")]
    public double? SatDetMasYuzde4 { get; set; }

    [Column("sat_det_mas_miktar4")]
    public double? SatDetMasMiktar4 { get; set; }

    [Column("sat_odeme_plan")]
    public int? SatOdemePlan { get; set; }

    [Column("sat_doviz_cinsi")]
    public byte? SatDovizCinsi { get; set; }

    [Column("sat_depo_no")]
    public int? SatDepoNo { get; set; }

    [Column("sat_fiyat_liste_no")]
    public int? SatFiyatListeNo { get; set; }
}
