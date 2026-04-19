using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_hareket_maliyet_detaylari")]
public class StokHareketMaliyetDetaylari
{
    [Column("shd_Guid")]
    public Guid? ShdGuid { get; set; }

    [Column("shd_DBCno")]
    public short? ShdDBCno { get; set; }

    [Column("shd_SpecRECno")]
    public int? ShdSpecRECno { get; set; }

    [Column("shd_iptal")]
    public bool? ShdIptal { get; set; }

    [Column("shd_fileid")]
    public short? ShdFileid { get; set; }

    [Column("shd_hidden")]
    public bool? ShdHidden { get; set; }

    [Column("shd_kilitli")]
    public bool? ShdKilitli { get; set; }

    [Column("shd_degisti")]
    public bool? ShdDegisti { get; set; }

    [Column("shd_checksum")]
    public int? ShdChecksum { get; set; }

    [Column("shd_create_user")]
    public short? ShdCreateUser { get; set; }

    [Column("shd_create_date")]
    public DateTime? ShdCreateDate { get; set; }

    [Column("shd_lastup_user")]
    public short? ShdLastupUser { get; set; }

    [Column("shd_lastup_date")]
    public DateTime? ShdLastupDate { get; set; }

    [Column("shd_special1")]
    [StringLength(4)]
    public string? ShdSpecial1 { get; set; }

    [Column("shd_special2")]
    [StringLength(4)]
    public string? ShdSpecial2 { get; set; }

    [Column("shd_special3")]
    [StringLength(4)]
    public string? ShdSpecial3 { get; set; }

    [Column("shd_tipi")]
    public byte? ShdTipi { get; set; }

    [Column("shd_hesap_kodu")]
    [StringLength(25)]
    public string? ShdHesapKodu { get; set; }

    [Column("shd_srm_merkezi")]
    [StringLength(25)]
    public string? ShdSrmMerkezi { get; set; }

    [Column("shd_yuklenen_maliyet_ana")]
    public double? ShdYuklenenMaliyetAna { get; set; }

    [Column("shd_yuklenen_maliyet_alt")]
    public double? ShdYuklenenMaliyetAlt { get; set; }

    [Column("shd_yuklenen_maliyet_orj")]
    public double? ShdYuklenenMaliyetOrj { get; set; }

    [Column("shd_stok_hareket_uid")]
    public Guid? ShdStokHareketUid { get; set; }

    [Column("shd_tuketim_stok_giris_recno")]
    public int? ShdTuketimStokGirisRecno { get; set; }

    [Column("shd_tuketim_stok_miktari")]
    public double? ShdTuketimStokMiktari { get; set; }
}
