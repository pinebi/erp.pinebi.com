using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_sinav_listesi")]
public class PersonelSinavListesi
{
    [Column("slt_Guid")]
    public Guid? SltGuid { get; set; }

    [Column("slt_DBCno")]
    public short? SltDBCno { get; set; }

    [Column("slt_SpecRECno")]
    public int? SltSpecRECno { get; set; }

    [Column("slt_iptal")]
    public bool? SltIptal { get; set; }

    [Column("slt_fileid")]
    public short? SltFileid { get; set; }

    [Column("slt_hidden")]
    public bool? SltHidden { get; set; }

    [Column("slt_kilitli")]
    public bool? SltKilitli { get; set; }

    [Column("slt_degisti")]
    public bool? SltDegisti { get; set; }

    [Column("slt_checksum")]
    public int? SltChecksum { get; set; }

    [Column("slt_create_user")]
    public short? SltCreateUser { get; set; }

    [Column("slt_create_date")]
    public DateTime? SltCreateDate { get; set; }

    [Column("slt_lastup_user")]
    public short? SltLastupUser { get; set; }

    [Column("slt_lastup_date")]
    public DateTime? SltLastupDate { get; set; }

    [Column("slt_special1")]
    [StringLength(4)]
    public string? SltSpecial1 { get; set; }

    [Column("slt_special2")]
    [StringLength(4)]
    public string? SltSpecial2 { get; set; }

    [Column("slt_special3")]
    [StringLength(4)]
    public string? SltSpecial3 { get; set; }

    [Column("slt_tarih")]
    public DateTime? SltTarih { get; set; }

    [Column("slt_sinav_kodu")]
    [StringLength(25)]
    public string? SltSinavKodu { get; set; }

    [Column("slt_katilmadi")]
    public bool? SltKatilmadi { get; set; }

    [Column("slt_kapsam")]
    public byte? SltKapsam { get; set; }

    [Column("slt_kapsam_kodu")]
    [StringLength(25)]
    public string? SltKapsamKodu { get; set; }

    [Column("slt_aciklama")]
    [StringLength(80)]
    public string? SltAciklama { get; set; }
}
