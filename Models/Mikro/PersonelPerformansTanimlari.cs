using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_performans_tanimlari")]
public class PersonelPerformansTanimlari
{
    [Column("prf_Guid")]
    public Guid? PrfGuid { get; set; }

    [Column("prf_DBCno")]
    public short? PrfDBCno { get; set; }

    [Column("prf_SpecRECno")]
    public int? PrfSpecRECno { get; set; }

    [Column("prf_iptal")]
    public bool? PrfIptal { get; set; }

    [Column("prf_fileid")]
    public short? PrfFileid { get; set; }

    [Column("prf_hidden")]
    public bool? PrfHidden { get; set; }

    [Column("prf_kilitli")]
    public bool? PrfKilitli { get; set; }

    [Column("prf_degisti")]
    public bool? PrfDegisti { get; set; }

    [Column("prf_checksum")]
    public int? PrfChecksum { get; set; }

    [Column("prf_create_user")]
    public short? PrfCreateUser { get; set; }

    [Column("prf_create_date")]
    public DateTime? PrfCreateDate { get; set; }

    [Column("prf_lastup_user")]
    public short? PrfLastupUser { get; set; }

    [Column("prf_lastup_date")]
    public DateTime? PrfLastupDate { get; set; }

    [Column("prf_special1")]
    [StringLength(4)]
    public string? PrfSpecial1 { get; set; }

    [Column("prf_special2")]
    [StringLength(4)]
    public string? PrfSpecial2 { get; set; }

    [Column("prf_special3")]
    [StringLength(4)]
    public string? PrfSpecial3 { get; set; }

    [Column("prf_kodu")]
    [StringLength(25)]
    public string? PrfKodu { get; set; }

    [Column("prf_adi")]
    [StringLength(40)]
    public string? PrfAdi { get; set; }

    [Column("prf_tip")]
    public byte? PrfTip { get; set; }

    [Column("prf_sekil")]
    public byte? PrfSekil { get; set; }

    [Column("prf_birim")]
    public byte? PrfBirim { get; set; }

    [Column("prf_sosyrdmksntmo")]
    public byte? PrfSosyrdmksntmo { get; set; }

    [Column("prf_maxmiktar")]
    public double? PrfMaxmiktar { get; set; }

    [Column("prf_degerlendir_fl")]
    public bool? PrfDegerlendirFl { get; set; }
}
