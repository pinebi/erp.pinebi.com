using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isletme_hareketleri")]
public class IsletmeHareketleri
{
    [Column("dfis_Guid")]
    public Guid? DfisGuid { get; set; }

    [Column("dfis_DBCno")]
    public short? DfisDBCno { get; set; }

    [Column("dfis_SpecRECno")]
    public int? DfisSpecRECno { get; set; }

    [Column("dfis_iptal")]
    public bool? DfisIptal { get; set; }

    [Column("dfis_fileid")]
    public short? DfisFileid { get; set; }

    [Column("dfis_hidden")]
    public bool? DfisHidden { get; set; }

    [Column("dfis_kilitli")]
    public bool? DfisKilitli { get; set; }

    [Column("dfis_degisti")]
    public bool? DfisDegisti { get; set; }

    [Column("dfis_checksum")]
    public int? DfisChecksum { get; set; }

    [Column("dfis_create_user")]
    public short? DfisCreateUser { get; set; }

    [Column("dfis_create_date")]
    public DateTime? DfisCreateDate { get; set; }

    [Column("dfis_lastup_user")]
    public short? DfisLastupUser { get; set; }

    [Column("dfis_lastup_date")]
    public DateTime? DfisLastupDate { get; set; }

    [Column("dfis_special1")]
    [StringLength(4)]
    public string? DfisSpecial1 { get; set; }

    [Column("dfis_special2")]
    [StringLength(4)]
    public string? DfisSpecial2 { get; set; }

    [Column("dfis_special3")]
    [StringLength(4)]
    public string? DfisSpecial3 { get; set; }

    [Column("dfis_firmano")]
    public int? DfisFirmano { get; set; }

    [Column("dfis_subeno")]
    public int? DfisSubeno { get; set; }

    [Column("dfis_maliyil")]
    public int? DfisMaliyil { get; set; }

    [Column("dfis_tarih")]
    public DateTime? DfisTarih { get; set; }

    [Column("dfis_hesap_kod")]
    [StringLength(25)]
    public string? DfisHesapKod { get; set; }

    [Column("dfis_aciklama1")]
    [StringLength(65)]
    public string? DfisAciklama1 { get; set; }

    [Column("dfis_meblag0")]
    public double? DfisMeblag0 { get; set; }

    [Column("dfis_meblag1")]
    public double? DfisMeblag1 { get; set; }

    [Column("dfis_meblag2")]
    public double? DfisMeblag2 { get; set; }

    [Column("dfis_meblag3")]
    public double? DfisMeblag3 { get; set; }

    [Column("dfis_meblag4")]
    public double? DfisMeblag4 { get; set; }

    [Column("dfis_meblag5")]
    public double? DfisMeblag5 { get; set; }

    [Column("dfis_meblag6")]
    public double? DfisMeblag6 { get; set; }

    [Column("dfis_fevraktarih")]
    public DateTime? DfisFevraktarih { get; set; }

    [Column("dfis_fcinsi")]
    public byte? DfisFcinsi { get; set; }

    [Column("dfis_fvergipnt")]
    public byte? DfisFvergipnt { get; set; }

    [Column("dfis_Fvergi")]
    public double? DfisFvergi { get; set; }

    [Column("dfis_ftip")]
    public byte? DfisFtip { get; set; }

    [Column("dfis_ticari_tip")]
    public byte? DfisTicariTip { get; set; }

    [Column("dfis_ticari_evraktip")]
    public byte? DfisTicariEvraktip { get; set; }

    [Column("dfis_evrakno_seri")]
    [StringLength(15)]
    public string? DfisEvraknoSeri { get; set; }

    [Column("dfis_evrakno_sira")]
    public int? DfisEvraknoSira { get; set; }

    [Column("dfis_fozelmahkod")]
    [StringLength(25)]
    public string? DfisFozelmahkod { get; set; }

    [Column("dfis_evraktip")]
    public byte? DfisEvraktip { get; set; }

    [Column("dfis_vergiDairesiKodu")]
    [StringLength(10)]
    public string? DfisVergiDairesiKodu { get; set; }

    [Column("dfis_tcknVkn")]
    [StringLength(15)]
    public string? DfisTcknVkn { get; set; }

    [Column("dfis_ad")]
    [StringLength(127)]
    public string? DfisAd { get; set; }

    [Column("dfis_soyad")]
    [StringLength(127)]
    public string? DfisSoyad { get; set; }

    [Column("dfis_adresiGuncelleme")]
    public bool? DfisAdresiGuncelleme { get; set; }

    [Column("dfis_adresBilgisi")]
    [StringLength(127)]
    public string? DfisAdresBilgisi { get; set; }

    [Column("dfis_miktar")]
    public double? DfisMiktar { get; set; }

    [Column("dfis_birimKodu")]
    [StringLength(10)]
    public string? DfisBirimKodu { get; set; }

    [Column("dfis_kismiTevkifatKodu")]
    [StringLength(10)]
    public string? DfisKismiTevkifatKodu { get; set; }

    [Column("dfis_kismiTevkifatOrani")]
    public double? DfisKismiTevkifatOrani { get; set; }

    [Column("dfis_stopajKodu")]
    [StringLength(10)]
    public string? DfisStopajKodu { get; set; }

    [Column("dfis_stopajOrani")]
    public double? DfisStopajOrani { get; set; }

    [Column("dfis_stopajTutari")]
    public double? DfisStopajTutari { get; set; }

    [Column("dfis_giderBelgeTuruKodu")]
    [StringLength(10)]
    public string? DfisGiderBelgeTuruKodu { get; set; }

    [Column("dfis_alisTuruKodu")]
    [StringLength(10)]
    public string? DfisAlisTuruKodu { get; set; }

    [Column("dfis_giderKayitTuruKodu")]
    [StringLength(10)]
    public string? DfisGiderKayitTuruKodu { get; set; }

    [Column("dfis_giderKayitAltTuruKodu")]
    [StringLength(10)]
    public string? DfisGiderKayitAltTuruKodu { get; set; }

    [Column("dfis_odemeTuruKodu")]
    [StringLength(10)]
    public string? DfisOdemeTuruKodu { get; set; }

    [Column("dfis_hesaplamaYontemiKodu")]
    [StringLength(10)]
    public string? DfisHesaplamaYontemiKodu { get; set; }

    [Column("dfis_amortismanYontemiKodu")]
    [StringLength(10)]
    public string? DfisAmortismanYontemiKodu { get; set; }

    [Column("dfis_sabitKiymetTuruKodu")]
    [StringLength(10)]
    public string? DfisSabitKiymetTuruKodu { get; set; }

    [Column("dfis_ozelKodKodu")]
    [StringLength(10)]
    public string? DfisOzelKodKodu { get; set; }

    [Column("dfis_kodu")]
    [StringLength(20)]
    public string? DfisKodu { get; set; }

    [Column("dfis_adi")]
    [StringLength(127)]
    public string? DfisAdi { get; set; }

    [Column("dfis_iktisadiKiymetKodu")]
    [StringLength(10)]
    public string? DfisIktisadiKiymetKodu { get; set; }

    [Column("dfis_periyot")]
    public byte? DfisPeriyot { get; set; }

    [Column("dfis_tevkifatDurumKodu")]
    public byte? DfisTevkifatDurumKodu { get; set; }

    [Column("dfis_damgaVergisiKodu")]
    [StringLength(10)]
    public string? DfisDamgaVergisiKodu { get; set; }

    [Column("dfis_gelirBelgeTuruKodu")]
    [StringLength(10)]
    public string? DfisGelirBelgeTuruKodu { get; set; }

    [Column("dfis_satisTuruKodu")]
    [StringLength(10)]
    public string? DfisSatisTuruKodu { get; set; }

    [Column("dfis_gelirKayitTuruKodu")]
    [StringLength(10)]
    public string? DfisGelirKayitTuruKodu { get; set; }

    [Column("dfis_gelirKayitAltTuruKodu")]
    [StringLength(10)]
    public string? DfisGelirKayitAltTuruKodu { get; set; }

    [Column("dfis_kismiIstisnaKodu")]
    [StringLength(10)]
    public string? DfisKismiIstisnaKodu { get; set; }

    [Column("dfis_kismiIstisnaOrani")]
    public double? DfisKismiIstisnaOrani { get; set; }

    [Column("dfis_tamIstisnaKodu")]
    [StringLength(10)]
    public string? DfisTamIstisnaKodu { get; set; }

    [Column("dfis_tamIstisnaOrani")]
    public double? DfisTamIstisnaOrani { get; set; }

    [Column("dfis_ihracKayitliTeslimKodu")]
    [StringLength(10)]
    public string? DfisIhracKayitliTeslimKodu { get; set; }

    [Column("dfis_ihracKayitliTeslimOrani")]
    public double? DfisIhracKayitliTeslimOrani { get; set; }

    [Column("dfis_digerIadeHakkiKodu")]
    [StringLength(10)]
    public string? DfisDigerIadeHakkiKodu { get; set; }

    [Column("dfis_digerIadeHakkiOrani")]
    public double? DfisDigerIadeHakkiOrani { get; set; }

    [Column("dfis_digerIslemlerKodu")]
    [StringLength(10)]
    public string? DfisDigerIslemlerKodu { get; set; }

    [Column("dfis_digerIslemlerOrani")]
    public double? DfisDigerIslemlerOrani { get; set; }

    [Column("dfis_netDefterDegeri")]
    public double? DfisNetDefterDegeri { get; set; }

    [Column("dfis_sabitKiymetId")]
    [StringLength(10)]
    public string? DfisSabitKiymetId { get; set; }

    [Column("dfis_iadeKismiTevkifatKodu")]
    [StringLength(10)]
    public string? DfisIadeKismiTevkifatKodu { get; set; }

    [Column("dfis_iadeKismiTevkifatOrani")]
    public double? DfisIadeKismiTevkifatOrani { get; set; }

    [Column("dfis_krediKartiTutari")]
    public double? DfisKrediKartiTutari { get; set; }

    [Column("dfis_belgeTutari")]
    public double? DfisBelgeTutari { get; set; }

    [Column("dfis_nihaiTuketici")]
    public bool? DfisNihaiTuketici { get; set; }
}
