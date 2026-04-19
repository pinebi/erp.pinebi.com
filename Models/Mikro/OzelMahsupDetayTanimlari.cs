using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ozel_mahsup_detay_tanimlari")]
public class OzelMahsupDetayTanimlari
{
    [Column("mp_Guid")]
    public Guid? MpGuid { get; set; }

    [Column("mp_DBCno")]
    public short? MpDBCno { get; set; }

    [Column("mp_SpecRECNo")]
    public int? MpSpecRECNo { get; set; }

    [Column("mp_iptal")]
    public bool? MpIptal { get; set; }

    [Column("mp_fileid")]
    public short? MpFileid { get; set; }

    [Column("mp_hidden")]
    public bool? MpHidden { get; set; }

    [Column("mp_kilitli")]
    public bool? MpKilitli { get; set; }

    [Column("mp_degisti")]
    public bool? MpDegisti { get; set; }

    [Column("mp_checksum")]
    public int? MpChecksum { get; set; }

    [Column("mp_create_user")]
    public short? MpCreateUser { get; set; }

    [Column("mp_create_date")]
    public DateTime? MpCreateDate { get; set; }

    [Column("mp_lastup_user")]
    public short? MpLastupUser { get; set; }

    [Column("mp_lastup_date")]
    public DateTime? MpLastupDate { get; set; }

    [Column("mp_special1")]
    [StringLength(4)]
    public string? MpSpecial1 { get; set; }

    [Column("mp_special2")]
    [StringLength(4)]
    public string? MpSpecial2 { get; set; }

    [Column("mp_special3")]
    [StringLength(4)]
    public string? MpSpecial3 { get; set; }

    [Column("mp_OzMahKodu")]
    [StringLength(25)]
    public string? MpOzMahKodu { get; set; }

    [Column("mp_HesKodu")]
    [StringLength(25)]
    public string? MpHesKodu { get; set; }

    [Column("mp_SatirNo")]
    public int? MpSatirNo { get; set; }

    [Column("mp_Aciklama")]
    [StringLength(65)]
    public string? MpAciklama { get; set; }

    [Column("mp_MahIslTip")]
    public byte? MpMahIslTip { get; set; }

    [Column("mp_Borc")]
    public double? MpBorc { get; set; }

    [Column("mp_Alacak")]
    public double? MpAlacak { get; set; }

    [Column("mp_SrmMrkzKodu")]
    [StringLength(25)]
    public string? MpSrmMrkzKodu { get; set; }

    [Column("mp_ProjeKodu")]
    [StringLength(25)]
    public string? MpProjeKodu { get; set; }
}
