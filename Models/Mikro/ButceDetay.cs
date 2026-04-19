using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("butce_detay")]
public class ButceDetay
{
    [Column("bd_Guid")]
    public Guid? BdGuid { get; set; }

    [Column("bd_DBCno")]
    public short? BdDBCno { get; set; }

    [Column("bd_SpecRECno")]
    public int? BdSpecRECno { get; set; }

    [Column("bd_iptal")]
    public bool? BdIptal { get; set; }

    [Column("bd_fileid")]
    public short? BdFileid { get; set; }

    [Column("bd_hidden")]
    public bool? BdHidden { get; set; }

    [Column("bd_kilitli")]
    public bool? BdKilitli { get; set; }

    [Column("bd_degisti")]
    public bool? BdDegisti { get; set; }

    [Column("bd_checksum")]
    public int? BdChecksum { get; set; }

    [Column("bd_create_user")]
    public short? BdCreateUser { get; set; }

    [Column("bd_create_date")]
    public DateTime? BdCreateDate { get; set; }

    [Column("bd_lastup_user")]
    public short? BdLastupUser { get; set; }

    [Column("bd_lastup_date")]
    public DateTime? BdLastupDate { get; set; }

    [Column("bd_special1")]
    [StringLength(4)]
    public string? BdSpecial1 { get; set; }

    [Column("bd_special2")]
    [StringLength(4)]
    public string? BdSpecial2 { get; set; }

    [Column("bd_special3")]
    [StringLength(4)]
    public string? BdSpecial3 { get; set; }

    [Column("bd_butcekodu")]
    [StringLength(25)]
    public string? BdButcekodu { get; set; }

    [Column("bd_stok_hizmet")]
    public byte? BdStokHizmet { get; set; }

    [Column("bd_sh_detay_kodu")]
    [StringLength(25)]
    public string? BdShDetayKodu { get; set; }

    [Column("bd_masraf_detay_kodu")]
    [StringLength(25)]
    public string? BdMasrafDetayKodu { get; set; }

    [Column("bd_cari_detay_kodu")]
    [StringLength(25)]
    public string? BdCariDetayKodu { get; set; }

    [Column("bd_sorumlu_detay_kodu")]
    [StringLength(25)]
    public string? BdSorumluDetayKodu { get; set; }

    [Column("bd_depo_detay_kodu")]
    [StringLength(25)]
    public string? BdDepoDetayKodu { get; set; }

    [Column("bd_sormrk_detay_kodu")]
    [StringLength(25)]
    public string? BdSormrkDetayKodu { get; set; }

    [Column("bd_proje_detay_kodu")]
    [StringLength(25)]
    public string? BdProjeDetayKodu { get; set; }

    [Column("bd_donem")]
    [StringLength(25)]
    public string? BdDonem { get; set; }

    [Column("bd_deger_hedef1")]
    public double? BdDegerHedef1 { get; set; }

    [Column("bd_deger_durum1")]
    public double? BdDegerDurum1 { get; set; }

    [Column("bd_deger_hedef2")]
    public double? BdDegerHedef2 { get; set; }

    [Column("bd_deger_durum2")]
    public double? BdDegerDurum2 { get; set; }

    [Column("bd_deger_hedef3")]
    public double? BdDegerHedef3 { get; set; }

    [Column("bd_deger_durum3")]
    public double? BdDegerDurum3 { get; set; }

    [Column("bd_deger_hedef4")]
    public double? BdDegerHedef4 { get; set; }

    [Column("bd_deger_durum4")]
    public double? BdDegerDurum4 { get; set; }

    [Column("bd_deger_hedef5")]
    public double? BdDegerHedef5 { get; set; }

    [Column("bd_deger_durum5")]
    public double? BdDegerDurum5 { get; set; }
}
