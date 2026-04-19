using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hareket_borc_alacak_esleme")]
public class CariHareketBorcAlacakEsleme
{
    [Column("chk_Guid")]
    public Guid? ChkGuid { get; set; }

    [Column("chk_DBCno")]
    public short? ChkDBCno { get; set; }

    [Column("chk_SpecRECno")]
    public int? ChkSpecRECno { get; set; }

    [Column("chk_iptal")]
    public bool? ChkIptal { get; set; }

    [Column("chk_fileid")]
    public short? ChkFileid { get; set; }

    [Column("chk_hidden")]
    public bool? ChkHidden { get; set; }

    [Column("chk_kilitli")]
    public bool? ChkKilitli { get; set; }

    [Column("chk_degisti")]
    public bool? ChkDegisti { get; set; }

    [Column("chk_checksum")]
    public int? ChkChecksum { get; set; }

    [Column("chk_create_user")]
    public short? ChkCreateUser { get; set; }

    [Column("chk_create_date")]
    public DateTime? ChkCreateDate { get; set; }

    [Column("chk_lastup_user")]
    public short? ChkLastupUser { get; set; }

    [Column("chk_lastup_date")]
    public DateTime? ChkLastupDate { get; set; }

    [Column("chk_special1")]
    [StringLength(4)]
    public string? ChkSpecial1 { get; set; }

    [Column("chk_special2")]
    [StringLength(4)]
    public string? ChkSpecial2 { get; set; }

    [Column("chk_special3")]
    [StringLength(4)]
    public string? ChkSpecial3 { get; set; }

    [Column("chk_ChCinsi")]
    public byte? ChkChCinsi { get; set; }

    [Column("chk_ChKodu")]
    [StringLength(25)]
    public string? ChkChKodu { get; set; }

    [Column("chk_Borc_uid")]
    public Guid? ChkBorcUid { get; set; }

    [Column("chk_BorcVade")]
    public DateTime? ChkBorcVade { get; set; }

    [Column("chk_Tutar")]
    public double? ChkTutar { get; set; }

    [Column("chk_Alc_uid")]
    public Guid? ChkAlcUid { get; set; }

    [Column("chk_Alacakvade")]
    public DateTime? ChkAlacakvade { get; set; }

    [Column("chk_Aciklama1")]
    [StringLength(80)]
    public string? ChkAciklama1 { get; set; }

    [Column("chk_Aciklama2")]
    [StringLength(80)]
    public string? ChkAciklama2 { get; set; }

    [Column("chk_OrjBorcTutar")]
    public double? ChkOrjBorcTutar { get; set; }

    [Column("chk_OrjAlacakTutar")]
    public double? ChkOrjAlacakTutar { get; set; }
}
