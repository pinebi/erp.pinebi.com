using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("recete_kriterleri")]
public class ReceteKriterleri
{
    [Column("rk_Guid")]
    public Guid? RkGuid { get; set; }

    [Column("rk_DBCno")]
    public short? RkDBCno { get; set; }

    [Column("rk_SpecRECno")]
    public int? RkSpecRECno { get; set; }

    [Column("rk_iptal")]
    public bool? RkIptal { get; set; }

    [Column("rk_fileid")]
    public short? RkFileid { get; set; }

    [Column("rk_hidden")]
    public bool? RkHidden { get; set; }

    [Column("rk_kilitli")]
    public bool? RkKilitli { get; set; }

    [Column("rk_degisti")]
    public bool? RkDegisti { get; set; }

    [Column("rk_checksum")]
    public int? RkChecksum { get; set; }

    [Column("rk_create_user")]
    public short? RkCreateUser { get; set; }

    [Column("rk_create_date")]
    public DateTime? RkCreateDate { get; set; }

    [Column("rk_lastup_user")]
    public short? RkLastupUser { get; set; }

    [Column("rk_lastup_date")]
    public DateTime? RkLastupDate { get; set; }

    [Column("rk_special1")]
    [StringLength(4)]
    public string? RkSpecial1 { get; set; }

    [Column("rk_special2")]
    [StringLength(4)]
    public string? RkSpecial2 { get; set; }

    [Column("rk_special3")]
    [StringLength(4)]
    public string? RkSpecial3 { get; set; }

    [Column("rk_recete_uid")]
    public Guid? RkReceteUid { get; set; }

    [Column("rk_satir_no")]
    public int? RkSatirNo { get; set; }

    [Column("rk_tablo")]
    public byte? RkTablo { get; set; }

    [Column("rk_alan_adi")]
    [StringLength(80)]
    public string? RkAlanAdi { get; set; }

    [Column("rk_islem")]
    public byte? RkIslem { get; set; }

    [Column("rk_stringdata")]
    [StringLength(80)]
    public string? RkStringdata { get; set; }

    [Column("rk_baglanti_tipi")]
    public byte? RkBaglantiTipi { get; set; }
}
