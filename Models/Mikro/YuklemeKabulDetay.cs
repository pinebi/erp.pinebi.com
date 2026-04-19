using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yukleme_kabul_detay")]
public class YuklemeKabulDetay
{
    [Column("ykd_Guid")]
    public Guid? YkdGuid { get; set; }

    [Column("ykd_DBCno")]
    public short? YkdDBCno { get; set; }

    [Column("ykd_SpecRECno")]
    public int? YkdSpecRECno { get; set; }

    [Column("ykd_iptal")]
    public bool? YkdIptal { get; set; }

    [Column("ykd_fileid")]
    public short? YkdFileid { get; set; }

    [Column("ykd_hidden")]
    public bool? YkdHidden { get; set; }

    [Column("ykd_kilitli")]
    public bool? YkdKilitli { get; set; }

    [Column("ykd_degisti")]
    public bool? YkdDegisti { get; set; }

    [Column("ykd_checksum")]
    public int? YkdChecksum { get; set; }

    [Column("ykd_create_user")]
    public short? YkdCreateUser { get; set; }

    [Column("ykd_create_date")]
    public DateTime? YkdCreateDate { get; set; }

    [Column("ykd_lastup_user")]
    public short? YkdLastupUser { get; set; }

    [Column("ykd_lastup_date")]
    public DateTime? YkdLastupDate { get; set; }

    [Column("ykd_special1")]
    [StringLength(4)]
    public string? YkdSpecial1 { get; set; }

    [Column("ykd_special2")]
    [StringLength(4)]
    public string? YkdSpecial2 { get; set; }

    [Column("ykd_special3")]
    [StringLength(4)]
    public string? YkdSpecial3 { get; set; }

    [Column("ykd_tipi")]
    public byte? YkdTipi { get; set; }

    [Column("ykd_yukleme_kabul_kodu")]
    [StringLength(25)]
    public string? YkdYuklemeKabulKodu { get; set; }

    [Column("ykd_siparis_uid")]
    public Guid? YkdSiparisUid { get; set; }

    [Column("ykd_miktar")]
    public double? YkdMiktar { get; set; }

    [Column("ykd_parti_kodu")]
    [StringLength(25)]
    public string? YkdPartiKodu { get; set; }

    [Column("ykd_lot_no")]
    public int? YkdLotNo { get; set; }

    [Column("ykd_aciklama")]
    [StringLength(127)]
    public string? YkdAciklama { get; set; }

    [Column("ykd_onaylayan_kullanici")]
    public int? YkdOnaylayanKullanici { get; set; }

    [Column("ykd_durumu")]
    public byte? YkdDurumu { get; set; }

    [Column("ykd_depono")]
    public int? YkdDepono { get; set; }

    [Column("ykd_teslim_miktar")]
    public double? YkdTeslimMiktar { get; set; }

    [Column("ykd_sirano")]
    public int? YkdSirano { get; set; }
}
