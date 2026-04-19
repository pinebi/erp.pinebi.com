using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ekip_tanimlari")]
public class EkipTanimlari
{
    [Column("ekp_Guid")]
    public Guid? EkpGuid { get; set; }

    [Column("ekp_DBCno")]
    public short? EkpDBCno { get; set; }

    [Column("ekp_SpecRECNo")]
    public int? EkpSpecRECNo { get; set; }

    [Column("ekp_iptal")]
    public bool? EkpIptal { get; set; }

    [Column("ekp_fileid")]
    public short? EkpFileid { get; set; }

    [Column("ekp_hidden")]
    public bool? EkpHidden { get; set; }

    [Column("ekp_kilitli")]
    public bool? EkpKilitli { get; set; }

    [Column("ekp_degisti")]
    public bool? EkpDegisti { get; set; }

    [Column("ekp_checksum")]
    public int? EkpChecksum { get; set; }

    [Column("ekp_create_user")]
    public short? EkpCreateUser { get; set; }

    [Column("ekp_create_date")]
    public DateTime? EkpCreateDate { get; set; }

    [Column("ekp_lastup_user")]
    public short? EkpLastupUser { get; set; }

    [Column("ekp_lastup_date")]
    public DateTime? EkpLastupDate { get; set; }

    [Column("ekp_special1")]
    [StringLength(4)]
    public string? EkpSpecial1 { get; set; }

    [Column("ekp_special2")]
    [StringLength(4)]
    public string? EkpSpecial2 { get; set; }

    [Column("ekp_special3")]
    [StringLength(4)]
    public string? EkpSpecial3 { get; set; }

    [Column("ekp_kodu")]
    [StringLength(25)]
    public string? EkpKodu { get; set; }

    [Column("ekp_adi")]
    [StringLength(50)]
    public string? EkpAdi { get; set; }

    [Column("ekp_cari_kodu")]
    [StringLength(25)]
    public string? EkpCariKodu { get; set; }

    [Column("ekp_personel_kodu1")]
    [StringLength(25)]
    public string? EkpPersonelKodu1 { get; set; }

    [Column("ekp_personel_agirlik_puan1")]
    public double? EkpPersonelAgirlikPuan1 { get; set; }

    [Column("ekp_personel_kodu2")]
    [StringLength(25)]
    public string? EkpPersonelKodu2 { get; set; }

    [Column("ekp_personel_agirlik_puan2")]
    public double? EkpPersonelAgirlikPuan2 { get; set; }

    [Column("ekp_personel_kodu3")]
    [StringLength(25)]
    public string? EkpPersonelKodu3 { get; set; }

    [Column("ekp_personel_agirlik_puan3")]
    public double? EkpPersonelAgirlikPuan3 { get; set; }

    [Column("ekp_personel_kodu4")]
    [StringLength(25)]
    public string? EkpPersonelKodu4 { get; set; }

    [Column("ekp_personel_agirlik_puan4")]
    public double? EkpPersonelAgirlikPuan4 { get; set; }

    [Column("ekp_personel_kodu5")]
    [StringLength(25)]
    public string? EkpPersonelKodu5 { get; set; }

    [Column("ekp_personel_agirlik_puan5")]
    public double? EkpPersonelAgirlikPuan5 { get; set; }

    [Column("ekp_personel_kodu6")]
    [StringLength(25)]
    public string? EkpPersonelKodu6 { get; set; }

    [Column("ekp_personel_agirlik_puan6")]
    public double? EkpPersonelAgirlikPuan6 { get; set; }

    [Column("ekp_personel_kodu7")]
    [StringLength(25)]
    public string? EkpPersonelKodu7 { get; set; }

    [Column("ekp_personel_agirlik_puan7")]
    public double? EkpPersonelAgirlikPuan7 { get; set; }

    [Column("ekp_personel_kodu8")]
    [StringLength(25)]
    public string? EkpPersonelKodu8 { get; set; }

    [Column("ekp_personel_agirlik_puan8")]
    public double? EkpPersonelAgirlikPuan8 { get; set; }

    [Column("ekp_personel_kodu9")]
    [StringLength(25)]
    public string? EkpPersonelKodu9 { get; set; }

    [Column("ekp_personel_agirlik_puan9")]
    public double? EkpPersonelAgirlikPuan9 { get; set; }

    [Column("ekp_personel_kodu10")]
    [StringLength(25)]
    public string? EkpPersonelKodu10 { get; set; }

    [Column("ekp_personel_agirlik_puan10")]
    public double? EkpPersonelAgirlikPuan10 { get; set; }
}
