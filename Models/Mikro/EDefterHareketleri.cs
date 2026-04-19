using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("e_defter_hareketleri")]
public class EDefterHareketleri
{
    [Column("edefter_Guid")]
    public Guid? EdefterGuid { get; set; }

    [Column("edefter_DBCno")]
    public short? EdefterDBCno { get; set; }

    [Column("edefter_Spec_Rec_no")]
    public int? EdefterSpecRecNo { get; set; }

    [Column("edefter_iptal")]
    public bool? EdefterIptal { get; set; }

    [Column("edefter_fileid")]
    public short? EdefterFileid { get; set; }

    [Column("edefter_hidden")]
    public bool? EdefterHidden { get; set; }

    [Column("edefter_kilitli")]
    public bool? EdefterKilitli { get; set; }

    [Column("edefter_degisti")]
    public bool? EdefterDegisti { get; set; }

    [Column("edefter_checksum")]
    public int? EdefterChecksum { get; set; }

    [Column("edefter_create_user")]
    public short? EdefterCreateUser { get; set; }

    [Column("edefter_create_date")]
    public DateTime? EdefterCreateDate { get; set; }

    [Column("edefter_lastup_user")]
    public short? EdefterLastupUser { get; set; }

    [Column("edefter_lastup_date")]
    public DateTime? EdefterLastupDate { get; set; }

    [Column("edefter_special1")]
    [StringLength(4)]
    public string? EdefterSpecial1 { get; set; }

    [Column("edefter_special2")]
    [StringLength(4)]
    public string? EdefterSpecial2 { get; set; }

    [Column("edefter_special3")]
    [StringLength(4)]
    public string? EdefterSpecial3 { get; set; }

    [Column("edefter_firmano")]
    public int? EdefterFirmano { get; set; }

    [Column("edefter_maliyil")]
    public int? EdefterMaliyil { get; set; }

    [Column("edefter_malidonem")]
    public int? EdefterMalidonem { get; set; }

    [Column("edefter_donemsirano")]
    public int? EdefterDonemsirano { get; set; }

    [Column("edefter_maliyilsirano")]
    public int? EdefterMaliyilsirano { get; set; }

    [Column("edefter_dosyalamaperiyodu")]
    public byte? EdefterDosyalamaperiyodu { get; set; }

    [Column("edefter_aktifgrup")]
    public byte? EdefterAktifgrup { get; set; }

    [Column("edefter_aciklama")]
    [StringLength(50)]
    public string? EdefterAciklama { get; set; }

    [Column("edefter_zamandamgasifl")]
    public bool? EdefterZamandamgasifl { get; set; }

    [Column("edefter_ilktarih")]
    public DateTime? EdefterIlktarih { get; set; }

    [Column("edefter_sontarih")]
    public DateTime? EdefterSontarih { get; set; }

    [Column("edefter_ilkyevmiye")]
    public int? EdefterIlkyevmiye { get; set; }

    [Column("edefter_sonyevmiye")]
    public int? EdefterSonyevmiye { get; set; }

    [Column("edefter_dosyaboyutu")]
    public double? EdefterDosyaboyutu { get; set; }

    [Column("edefter_olusturuldu")]
    public bool? EdefterOlusturuldu { get; set; }

    [Column("edefter_onayliberatalindi")]
    public bool? EdefterOnayliberatalindi { get; set; }

    [Column("edefter_olusturulsun")]
    public byte? EdefterOlusturulsun { get; set; }

    [Column("edefter_ilkmuteselsilno")]
    public int? EdefterIlkmuteselsilno { get; set; }

    [Column("edefter_sonmuteselsilno")]
    public int? EdefterSonmuteselsilno { get; set; }

    [Column("edefter_sube_adi")]
    [StringLength(127)]
    public string? EdefterSubeAdi { get; set; }

    [Column("edefter_sube_no")]
    public int? EdefterSubeNo { get; set; }

    [Column("edefter_doviz_tipi")]
    public byte? EdefterDovizTipi { get; set; }

    [Column("edefter_gib_yev_durum_kod")]
    [StringLength(5)]
    public string? EdefterGibYevDurumKod { get; set; }

    [Column("edefter_gib_yev_durum_aciklama")]
    [StringLength(120)]
    public string? EdefterGibYevDurumAciklama { get; set; }

    [Column("edefter_gib_keb_durum_kod")]
    [StringLength(5)]
    public string? EdefterGibKebDurumKod { get; set; }

    [Column("edefter_gib_keb_durum_aciklama")]
    [StringLength(120)]
    public string? EdefterGibKebDurumAciklama { get; set; }

    [Column("edefter_mye_yev_yuklendi")]
    public bool? EdefterMyeYevYuklendi { get; set; }

    [Column("edefter_mye_keb_yuklendi")]
    public bool? EdefterMyeKebYuklendi { get; set; }

    [Column("edefter_mye_yev_berat_yuklendi")]
    public bool? EdefterMyeYevBeratYuklendi { get; set; }

    [Column("edefter_mye_keb_berat_yuklendi")]
    public bool? EdefterMyeKebBeratYuklendi { get; set; }

    [Column("edefter_mye_yev_gib_berat_yuklendi")]
    public bool? EdefterMyeYevGibBeratYuklendi { get; set; }

    [Column("edefter_mye_keb_gib_berat_yuklendi")]
    public bool? EdefterMyeKebGibBeratYuklendi { get; set; }

    [Column("edefter_borc_toplam")]
    public double? EdefterBorcToplam { get; set; }

    [Column("edefter_alacak_toplam")]
    public double? EdefterAlacakToplam { get; set; }

    [Column("edefter_yevmiye_hash")]
    [StringLength(50)]
    public string? EdefterYevmiyeHash { get; set; }

    [Column("edefter_yevmiye_zip_hash")]
    [StringLength(50)]
    public string? EdefterYevmiyeZipHash { get; set; }

    [Column("edefter_yevmiye_berat_hash")]
    [StringLength(50)]
    public string? EdefterYevmiyeBeratHash { get; set; }

    [Column("edefter_yevmiye_berat_zip_hash")]
    [StringLength(50)]
    public string? EdefterYevmiyeBeratZipHash { get; set; }

    [Column("edefter_kebir_hash")]
    [StringLength(50)]
    public string? EdefterKebirHash { get; set; }

    [Column("edefter_kebir_zip_hash")]
    [StringLength(50)]
    public string? EdefterKebirZipHash { get; set; }

    [Column("edefter_kebir_berat_hash")]
    [StringLength(50)]
    public string? EdefterKebirBeratHash { get; set; }

    [Column("edefter_kebir_berat_zip_hash")]
    [StringLength(50)]
    public string? EdefterKebirBeratZipHash { get; set; }

    [Column("edefter_maliyil_baslangic_ayi")]
    public byte? EdefterMaliyilBaslangicAyi { get; set; }

    [Column("edefter_maliyil_takvim_bitisyili")]
    public bool? EdefterMaliyilTakvimBitisyili { get; set; }

    [Column("edefter_maliyil_baslangic_gunu")]
    public byte? EdefterMaliyilBaslangicGunu { get; set; }

    [Column("edefter_yevmiye_berat_uid")]
    public Guid? EdefterYevmiyeBeratUid { get; set; }

    [Column("edefter_kebir_berat_uid")]
    public Guid? EdefterKebirBeratUid { get; set; }
}
