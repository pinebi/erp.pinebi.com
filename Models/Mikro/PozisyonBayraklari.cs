using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("pozisyon_bayraklari")]
public class PozisyonBayraklari
{
    [Column("pb_Guid")]
    public Guid? PbGuid { get; set; }

    [Column("pb_DBCno")]
    public short? PbDBCno { get; set; }

    [Column("pb_SpecRECno")]
    public int? PbSpecRECno { get; set; }

    [Column("pb_iptal")]
    public bool? PbIptal { get; set; }

    [Column("pb_fileid")]
    public short? PbFileid { get; set; }

    [Column("pb_hidden")]
    public bool? PbHidden { get; set; }

    [Column("pb_kilitli")]
    public bool? PbKilitli { get; set; }

    [Column("pb_degisti")]
    public bool? PbDegisti { get; set; }

    [Column("pb_checksum")]
    public int? PbChecksum { get; set; }

    [Column("pb_create_user")]
    public short? PbCreateUser { get; set; }

    [Column("pb_create_date")]
    public DateTime? PbCreateDate { get; set; }

    [Column("pb_lastup_user")]
    public short? PbLastupUser { get; set; }

    [Column("pb_lastup_date")]
    public DateTime? PbLastupDate { get; set; }

    [Column("pb_special1")]
    [StringLength(4)]
    public string? PbSpecial1 { get; set; }

    [Column("pb_special2")]
    [StringLength(4)]
    public string? PbSpecial2 { get; set; }

    [Column("pb_special3")]
    [StringLength(4)]
    public string? PbSpecial3 { get; set; }

    [Column("pb_kod")]
    [StringLength(25)]
    public string? PbKod { get; set; }

    [Column("pb_ismi")]
    [StringLength(50)]
    public string? PbIsmi { get; set; }

    [Column("pb_detay_takip")]
    public byte? PbDetayTakip { get; set; }

    [Column("pb_satis_dursun")]
    public byte? PbSatisDursun { get; set; }

    [Column("pb_siparis_dursun")]
    public byte? PbSiparisDursun { get; set; }

    [Column("pb_malkabul_dursun")]
    public byte? PbMalkabulDursun { get; set; }

    [Column("pb_malkabul_gun1")]
    public bool? PbMalkabulGun1 { get; set; }

    [Column("pb_malkabul_gun2")]
    public bool? PbMalkabulGun2 { get; set; }

    [Column("pb_malkabul_gun3")]
    public bool? PbMalkabulGun3 { get; set; }

    [Column("pb_malkabul_gun4")]
    public bool? PbMalkabulGun4 { get; set; }

    [Column("pb_malkabul_gun5")]
    public bool? PbMalkabulGun5 { get; set; }

    [Column("pb_malkabul_gun6")]
    public bool? PbMalkabulGun6 { get; set; }

    [Column("pb_malkabul_gun7")]
    public bool? PbMalkabulGun7 { get; set; }

    [Column("pb_siparis_gun1")]
    public bool? PbSiparisGun1 { get; set; }

    [Column("pb_siparis_gun2")]
    public bool? PbSiparisGun2 { get; set; }

    [Column("pb_siparis_gun3")]
    public bool? PbSiparisGun3 { get; set; }

    [Column("pb_siparis_gun4")]
    public bool? PbSiparisGun4 { get; set; }

    [Column("pb_siparis_gun5")]
    public bool? PbSiparisGun5 { get; set; }

    [Column("pb_siparis_gun6")]
    public bool? PbSiparisGun6 { get; set; }

    [Column("pb_siparis_gun7")]
    public bool? PbSiparisGun7 { get; set; }

    [Column("pb_yer_kod")]
    [StringLength(25)]
    public string? PbYerKod { get; set; }

    [Column("pb_pasif_fl")]
    public bool? PbPasifFl { get; set; }

    [Column("pb_etiket_bas")]
    public byte? PbEtiketBas { get; set; }

    [Column("pb_elk_etk_tipi")]
    public byte? PbElkEtkTipi { get; set; }

    [Column("pb_raf_etiketli")]
    public byte? PbRafEtiketli { get; set; }

    [Column("pb_RafOmru")]
    public short? PbRafOmru { get; set; }
}
