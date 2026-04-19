using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_izinleri")]
public class PersonelIzinleri
{
    [Column("pz_Guid")]
    public Guid? PzGuid { get; set; }

    [Column("pz_DBCno")]
    public short? PzDBCno { get; set; }

    [Column("pz_SpecRECno")]
    public int? PzSpecRECno { get; set; }

    [Column("pz_iptal")]
    public bool? PzIptal { get; set; }

    [Column("pz_fileid")]
    public short? PzFileid { get; set; }

    [Column("pz_hidden")]
    public bool? PzHidden { get; set; }

    [Column("pz_kilitli")]
    public bool? PzKilitli { get; set; }

    [Column("pz_degisti")]
    public bool? PzDegisti { get; set; }

    [Column("pz_checksum")]
    public int? PzChecksum { get; set; }

    [Column("pz_create_user")]
    public short? PzCreateUser { get; set; }

    [Column("pz_create_date")]
    public DateTime? PzCreateDate { get; set; }

    [Column("pz_lastup_user")]
    public short? PzLastupUser { get; set; }

    [Column("pz_lastup_date")]
    public DateTime? PzLastupDate { get; set; }

    [Column("pz_special1")]
    [StringLength(4)]
    public string? PzSpecial1 { get; set; }

    [Column("pz_special2")]
    [StringLength(4)]
    public string? PzSpecial2 { get; set; }

    [Column("pz_special3")]
    [StringLength(4)]
    public string? PzSpecial3 { get; set; }

    [Column("pz_izin_yil")]
    public short? PzIzinYil { get; set; }

    [Column("pz_pers_kod")]
    [StringLength(25)]
    public string? PzPersKod { get; set; }

    [Column("pz_izin_no")]
    public int? PzIzinNo { get; set; }

    [Column("pz_izin_tipi")]
    public byte? PzIzinTipi { get; set; }

    [Column("pz_gun_sayisi")]
    public byte? PzGunSayisi { get; set; }

    [Column("pz_yol_izni")]
    public byte? PzYolIzni { get; set; }

    [Column("pz_baslangictarih")]
    public DateTime? PzBaslangictarih { get; set; }

    [Column("pz_bagli_talep_uid")]
    public Guid? PzBagliTalepUid { get; set; }

    [Column("pz_izin_aciklama")]
    [StringLength(50)]
    public string? PzIzinAciklama { get; set; }

    [Column("pz_gerceklesen_donus_tarihi")]
    public DateTime? PzGerceklesenDonusTarihi { get; set; }

    [Column("pz_izin_detay_tipi")]
    public byte? PzIzinDetayTipi { get; set; }
}
