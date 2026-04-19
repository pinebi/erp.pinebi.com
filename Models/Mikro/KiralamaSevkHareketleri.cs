using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_sevk_hareketleri")]
public class KiralamaSevkHareketleri
{
    [Column("ksvk_Guid")]
    public Guid? KsvkGuid { get; set; }

    [Column("ksvk_DBCno")]
    public short? KsvkDBCno { get; set; }

    [Column("ksvk_Spec_Rec_no")]
    public int? KsvkSpecRecNo { get; set; }

    [Column("ksvk_iptal")]
    public bool? KsvkIptal { get; set; }

    [Column("ksvk_fileid")]
    public short? KsvkFileid { get; set; }

    [Column("ksvk_hidden")]
    public bool? KsvkHidden { get; set; }

    [Column("ksvk_kilitli")]
    public bool? KsvkKilitli { get; set; }

    [Column("ksvk_degisti")]
    public bool? KsvkDegisti { get; set; }

    [Column("ksvk_checksum")]
    public int? KsvkChecksum { get; set; }

    [Column("ksvk_create_user")]
    public short? KsvkCreateUser { get; set; }

    [Column("ksvk_create_date")]
    public DateTime? KsvkCreateDate { get; set; }

    [Column("ksvk_lastup_user")]
    public short? KsvkLastupUser { get; set; }

    [Column("ksvk_lastup_date")]
    public DateTime? KsvkLastupDate { get; set; }

    [Column("ksvk_special1")]
    [StringLength(4)]
    public string? KsvkSpecial1 { get; set; }

    [Column("ksvk_special2")]
    [StringLength(4)]
    public string? KsvkSpecial2 { get; set; }

    [Column("ksvk_special3")]
    [StringLength(4)]
    public string? KsvkSpecial3 { get; set; }

    [Column("ksvk_firmano")]
    public int? KsvkFirmano { get; set; }

    [Column("ksvk_subeno")]
    public int? KsvkSubeno { get; set; }

    [Column("ksvk_tarihi")]
    public DateTime? KsvkTarihi { get; set; }

    [Column("ksvk_evrakno_seri")]
    [StringLength(50)]
    public string? KsvkEvraknoSeri { get; set; }

    [Column("ksvk_evrakno_sira")]
    public int? KsvkEvraknoSira { get; set; }

    [Column("ksvk_satirno")]
    public int? KsvkSatirno { get; set; }

    [Column("ksvk_belgeno")]
    [StringLength(50)]
    public string? KsvkBelgeno { get; set; }

    [Column("ksvk_belge_tarihi")]
    public DateTime? KsvkBelgeTarihi { get; set; }

    [Column("ksvk_cari_kodu")]
    [StringLength(25)]
    public string? KsvkCariKodu { get; set; }

    [Column("ksvk_adres_no")]
    public int? KsvkAdresNo { get; set; }

    [Column("ksvk_kirakodu")]
    [StringLength(25)]
    public string? KsvkKirakodu { get; set; }

    [Column("ksvk_giris_cikis")]
    public byte? KsvkGirisCikis { get; set; }

    [Column("ksvk_depono")]
    public int? KsvkDepono { get; set; }

    [Column("ksvk_nakliye_cari_kodu")]
    [StringLength(25)]
    public string? KsvkNakliyeCariKodu { get; set; }

    [Column("ksvk_hareket_kodu")]
    [StringLength(25)]
    public string? KsvkHareketKodu { get; set; }

    [Column("ksvk_seri_no")]
    [StringLength(25)]
    public string? KsvkSeriNo { get; set; }

    [Column("ksvk_sevktarihi")]
    public DateTime? KsvkSevktarihi { get; set; }

    [Column("ksvk_satir_aciklama")]
    [StringLength(60)]
    public string? KsvkSatirAciklama { get; set; }

    [Column("ksvk_khar_uid")]
    public Guid? KsvkKharUid { get; set; }

    [Column("ksvk_kmsayac")]
    public int? KsvkKmsayac { get; set; }

    [Column("ksvk_sis_uid")]
    public Guid? KsvkSisUid { get; set; }
}
