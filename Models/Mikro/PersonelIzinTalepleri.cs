using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_izin_talepleri")]
public class PersonelIzinTalepleri
{
    [Column("pit_Guid")]
    public Guid? PitGuid { get; set; }

    [Column("pit_DBCno")]
    public short? PitDBCno { get; set; }

    [Column("pit_SpecRECno")]
    public int? PitSpecRECno { get; set; }

    [Column("pit_iptal")]
    public bool? PitIptal { get; set; }

    [Column("pit_fileid")]
    public short? PitFileid { get; set; }

    [Column("pit_hidden")]
    public bool? PitHidden { get; set; }

    [Column("pit_kilitli")]
    public bool? PitKilitli { get; set; }

    [Column("pit_degisti")]
    public bool? PitDegisti { get; set; }

    [Column("pit_checksum")]
    public int? PitChecksum { get; set; }

    [Column("pit_create_user")]
    public short? PitCreateUser { get; set; }

    [Column("pit_create_date")]
    public DateTime? PitCreateDate { get; set; }

    [Column("pit_lastup_user")]
    public short? PitLastupUser { get; set; }

    [Column("pit_lastup_date")]
    public DateTime? PitLastupDate { get; set; }

    [Column("pit_special1")]
    [StringLength(4)]
    public string? PitSpecial1 { get; set; }

    [Column("pit_special2")]
    [StringLength(4)]
    public string? PitSpecial2 { get; set; }

    [Column("pit_special3")]
    [StringLength(4)]
    public string? PitSpecial3 { get; set; }

    [Column("pit_pers_kod")]
    [StringLength(25)]
    public string? PitPersKod { get; set; }

    [Column("pit_mali_yil")]
    public int? PitMaliYil { get; set; }

    [Column("pit_satir_no")]
    public int? PitSatirNo { get; set; }

    [Column("pit_talep_tarihi")]
    public DateTime? PitTalepTarihi { get; set; }

    [Column("pit_izin_tipi")]
    public byte? PitIzinTipi { get; set; }

    [Column("pit_gun_sayisi")]
    public byte? PitGunSayisi { get; set; }

    [Column("pit_yol_izni")]
    public byte? PitYolIzni { get; set; }

    [Column("pit_baslangictarih")]
    public DateTime? PitBaslangictarih { get; set; }

    [Column("pit_izin_durum")]
    public byte? PitIzinDurum { get; set; }

    [Column("pit_onaylayan_kullanici")]
    public int? PitOnaylayanKullanici { get; set; }

    [Column("pit_cadde")]
    [StringLength(50)]
    public string? PitCadde { get; set; }

    [Column("pit_mahalle")]
    [StringLength(50)]
    public string? PitMahalle { get; set; }

    [Column("pit_sokak")]
    [StringLength(50)]
    public string? PitSokak { get; set; }

    [Column("pit_Semt")]
    [StringLength(25)]
    public string? PitSemt { get; set; }

    [Column("pit_Apt_No")]
    [StringLength(10)]
    public string? PitAptNo { get; set; }

    [Column("pit_Daire_No")]
    [StringLength(10)]
    public string? PitDaireNo { get; set; }

    [Column("pit_posta_kodu")]
    [StringLength(8)]
    public string? PitPostaKodu { get; set; }

    [Column("pit_ilce")]
    [StringLength(50)]
    public string? PitIlce { get; set; }

    [Column("pit_il")]
    [StringLength(50)]
    public string? PitIl { get; set; }

    [Column("pit_ulke")]
    [StringLength(50)]
    public string? PitUlke { get; set; }

    [Column("pit_adres_kodu")]
    [StringLength(10)]
    public string? PitAdresKodu { get; set; }

    [Column("pit_tel1")]
    [StringLength(15)]
    public string? PitTel1 { get; set; }

    [Column("pit_tel2")]
    [StringLength(15)]
    public string? PitTel2 { get; set; }

    [Column("pit_email")]
    [StringLength(50)]
    public string? PitEmail { get; set; }

    [Column("pit_amac")]
    [StringLength(50)]
    public string? PitAmac { get; set; }

    [Column("pit_aciklama1")]
    [StringLength(50)]
    public string? PitAciklama1 { get; set; }

    [Column("pit_aciklama2")]
    [StringLength(50)]
    public string? PitAciklama2 { get; set; }
}
