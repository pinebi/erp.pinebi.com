using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("satinalma_sartlari")]
public class SatinalmaSartlari
{
    [Column("sas_Guid")]
    public Guid? SasGuid { get; set; }

    [Column("sas_DBCno")]
    public short? SasDBCno { get; set; }

    [Column("sas_SpecRECno")]
    public int? SasSpecRECno { get; set; }

    [Column("sas_iptal")]
    public bool? SasIptal { get; set; }

    [Column("sas_fileid")]
    public short? SasFileid { get; set; }

    [Column("sas_hidden")]
    public bool? SasHidden { get; set; }

    [Column("sas_kilitli")]
    public bool? SasKilitli { get; set; }

    [Column("sas_degisti")]
    public bool? SasDegisti { get; set; }

    [Column("sas_checksum")]
    public int? SasChecksum { get; set; }

    [Column("sas_create_user")]
    public short? SasCreateUser { get; set; }

    [Column("sas_create_date")]
    public DateTime? SasCreateDate { get; set; }

    [Column("sas_lastup_user")]
    public short? SasLastupUser { get; set; }

    [Column("sas_lastup_date")]
    public DateTime? SasLastupDate { get; set; }

    [Column("sas_special1")]
    [StringLength(4)]
    public string? SasSpecial1 { get; set; }

    [Column("sas_special2")]
    [StringLength(4)]
    public string? SasSpecial2 { get; set; }

    [Column("sas_special3")]
    [StringLength(4)]
    public string? SasSpecial3 { get; set; }

    [Column("sas_stok_kod")]
    [StringLength(25)]
    public string? SasStokKod { get; set; }

    [Column("sas_cari_kod")]
    [StringLength(25)]
    public string? SasCariKod { get; set; }

    [Column("sas_evrak_no_seri")]
    [StringLength(50)]
    public string? SasEvrakNoSeri { get; set; }

    [Column("sas_evrak_no_sira")]
    public int? SasEvrakNoSira { get; set; }

    [Column("sas_evrak_tarih")]
    public DateTime? SasEvrakTarih { get; set; }

    [Column("sas_satir_no")]
    public int? SasSatirNo { get; set; }

    [Column("sas_belge_no")]
    [StringLength(50)]
    public string? SasBelgeNo { get; set; }

    [Column("sas_belge_tarih")]
    public DateTime? SasBelgeTarih { get; set; }

    [Column("sas_asgari_miktar")]
    public double? SasAsgariMiktar { get; set; }

    [Column("sas_teslim_sure")]
    public short? SasTeslimSure { get; set; }

    [Column("sas_basla_tarih")]
    public DateTime? SasBaslaTarih { get; set; }

    [Column("sas_bitis_tarih")]
    public DateTime? SasBitisTarih { get; set; }

    [Column("sas_brut_fiyat")]
    public double? SasBrutFiyat { get; set; }

    [Column("sas_isk_acik1")]
    [StringLength(20)]
    public string? SasIskAcik1 { get; set; }

    [Column("sas_isk_uyg1")]
    public byte? SasIskUyg1 { get; set; }

    [Column("sas_isk_durum1")]
    public byte? SasIskDurum1 { get; set; }

    [Column("sas_isk_vergi1")]
    public byte? SasIskVergi1 { get; set; }

    [Column("sas_isk_kriter1")]
    public double? SasIskKriter1 { get; set; }

    [Column("sas_isk_yuzde1")]
    public double? SasIskYuzde1 { get; set; }

    [Column("sas_isk_miktar1")]
    public double? SasIskMiktar1 { get; set; }

    [Column("sas_isk_acik2")]
    [StringLength(20)]
    public string? SasIskAcik2 { get; set; }

    [Column("sas_isk_uyg2")]
    public byte? SasIskUyg2 { get; set; }

    [Column("sas_isk_durum2")]
    public byte? SasIskDurum2 { get; set; }

    [Column("sas_isk_vergi2")]
    public byte? SasIskVergi2 { get; set; }

    [Column("sas_isk_kriter2")]
    public double? SasIskKriter2 { get; set; }

    [Column("sas_isk_yuzde2")]
    public double? SasIskYuzde2 { get; set; }

    [Column("sas_isk_miktar2")]
    public double? SasIskMiktar2 { get; set; }

    [Column("sas_isk_acik3")]
    [StringLength(20)]
    public string? SasIskAcik3 { get; set; }

    [Column("sas_isk_uyg3")]
    public byte? SasIskUyg3 { get; set; }

    [Column("sas_isk_durum3")]
    public byte? SasIskDurum3 { get; set; }

    [Column("sas_isk_vergi3")]
    public byte? SasIskVergi3 { get; set; }

    [Column("sas_isk_kriter3")]
    public double? SasIskKriter3 { get; set; }

    [Column("sas_isk_yuzde3")]
    public double? SasIskYuzde3 { get; set; }

    [Column("sas_isk_miktar3")]
    public double? SasIskMiktar3 { get; set; }

    [Column("sas_isk_acik4")]
    [StringLength(20)]
    public string? SasIskAcik4 { get; set; }

    [Column("sas_isk_uyg4")]
    public byte? SasIskUyg4 { get; set; }

    [Column("sas_isk_durum4")]
    public byte? SasIskDurum4 { get; set; }

    [Column("sas_isk_vergi4")]
    public byte? SasIskVergi4 { get; set; }

    [Column("sas_isk_kriter4")]
    public double? SasIskKriter4 { get; set; }

    [Column("sas_isk_yuzde4")]
    public double? SasIskYuzde4 { get; set; }

    [Column("sas_isk_miktar4")]
    public double? SasIskMiktar4 { get; set; }

    [Column("sas_isk_acik5")]
    [StringLength(20)]
    public string? SasIskAcik5 { get; set; }

    [Column("sas_isk_uyg5")]
    public byte? SasIskUyg5 { get; set; }

    [Column("sas_isk_durum5")]
    public byte? SasIskDurum5 { get; set; }

    [Column("sas_isk_vergi5")]
    public byte? SasIskVergi5 { get; set; }

    [Column("sas_isk_kriter5")]
    public double? SasIskKriter5 { get; set; }

    [Column("sas_isk_yuzde5")]
    public double? SasIskYuzde5 { get; set; }

    [Column("sas_isk_miktar5")]
    public double? SasIskMiktar5 { get; set; }

    [Column("sas_isk_acik6")]
    [StringLength(20)]
    public string? SasIskAcik6 { get; set; }

    [Column("sas_isk_uyg6")]
    public byte? SasIskUyg6 { get; set; }

    [Column("sas_isk_durum6")]
    public byte? SasIskDurum6 { get; set; }

    [Column("sas_isk_vergi6")]
    public byte? SasIskVergi6 { get; set; }

    [Column("sas_isk_kriter6")]
    public double? SasIskKriter6 { get; set; }

    [Column("sas_isk_yuzde6")]
    public double? SasIskYuzde6 { get; set; }

    [Column("sas_isk_miktar6")]
    public double? SasIskMiktar6 { get; set; }

    [Column("sas_mas_acik1")]
    [StringLength(20)]
    public string? SasMasAcik1 { get; set; }

    [Column("sas_mas_uyg1")]
    public byte? SasMasUyg1 { get; set; }

    [Column("sas_mas_durum1")]
    public byte? SasMasDurum1 { get; set; }

    [Column("sas_mas_vergi1")]
    public byte? SasMasVergi1 { get; set; }

    [Column("sas_mas_kriter1")]
    public double? SasMasKriter1 { get; set; }

    [Column("sas_mas_yuzde1")]
    public double? SasMasYuzde1 { get; set; }

    [Column("sas_mas_miktar1")]
    public double? SasMasMiktar1 { get; set; }

    [Column("sas_mas_acik2")]
    [StringLength(20)]
    public string? SasMasAcik2 { get; set; }

    [Column("sas_mas_uyg2")]
    public byte? SasMasUyg2 { get; set; }

    [Column("sas_mas_durum2")]
    public byte? SasMasDurum2 { get; set; }

    [Column("sas_mas_vergi2")]
    public byte? SasMasVergi2 { get; set; }

    [Column("sas_mas_kriter2")]
    public double? SasMasKriter2 { get; set; }

    [Column("sas_mas_yuzde2")]
    public double? SasMasYuzde2 { get; set; }

    [Column("sas_mas_miktar2")]
    public double? SasMasMiktar2 { get; set; }

    [Column("sas_mas_acik3")]
    [StringLength(20)]
    public string? SasMasAcik3 { get; set; }

    [Column("sas_mas_uyg3")]
    public byte? SasMasUyg3 { get; set; }

    [Column("sas_mas_durum3")]
    public byte? SasMasDurum3 { get; set; }

    [Column("sas_mas_vergi3")]
    public byte? SasMasVergi3 { get; set; }

    [Column("sas_mas_kriter3")]
    public double? SasMasKriter3 { get; set; }

    [Column("sas_mas_yuzde3")]
    public double? SasMasYuzde3 { get; set; }

    [Column("sas_mas_miktar3")]
    public double? SasMasMiktar3 { get; set; }

    [Column("sas_mas_acik4")]
    [StringLength(20)]
    public string? SasMasAcik4 { get; set; }

    [Column("sas_mas_uyg4")]
    public byte? SasMasUyg4 { get; set; }

    [Column("sas_mas_durum4")]
    public byte? SasMasDurum4 { get; set; }

    [Column("sas_mas_vergi4")]
    public byte? SasMasVergi4 { get; set; }

    [Column("sas_mas_kriter4")]
    public double? SasMasKriter4 { get; set; }

    [Column("sas_mas_yuzde4")]
    public double? SasMasYuzde4 { get; set; }

    [Column("sas_mas_miktar4")]
    public double? SasMasMiktar4 { get; set; }

    [Column("sas_odeme_plan")]
    public int? SasOdemePlan { get; set; }

    [Column("sas_net_alis_kdvli")]
    public double? SasNetAlisKdvli { get; set; }

    [Column("sas_kar_oran")]
    public double? SasKarOran { get; set; }

    [Column("sas_net_satis_kdvli")]
    public double? SasNetSatisKdvli { get; set; }

    [Column("sas_satis_fiyat")]
    public double? SasSatisFiyat { get; set; }

    [Column("sas_doviz_cinsi")]
    public byte? SasDovizCinsi { get; set; }

    [Column("sas_evrtipi")]
    public byte? SasEvrtipi { get; set; }

    [Column("sas_aciklama")]
    [StringLength(40)]
    public string? SasAciklama { get; set; }

    [Column("sas_depo_no")]
    public int? SasDepoNo { get; set; }

    [Column("sas_maliyette_kullan_fl")]
    public bool? SasMaliyetteKullanFl { get; set; }

    [Column("sas_ilave_maliyet_tutari")]
    public double? SasIlaveMaliyetTutari { get; set; }

    [Column("sas_ilave_maliyet_yuzdesi")]
    public double? SasIlaveMaliyetYuzdesi { get; set; }

    [Column("Sas_Kesinlesti_fl")]
    public bool? SasKesinlestiFl { get; set; }

    [Column("Sas_ProSas_uid")]
    public Guid? SasProSasUid { get; set; }
}
