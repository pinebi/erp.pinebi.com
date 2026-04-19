using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kasalar")]
public class Kasalar
{
    [Column("kas_Guid")]
    public Guid? KasGuid { get; set; }

    [Column("kas_DBCno")]
    public short? KasDBCno { get; set; }

    [Column("kas_SpecRecno")]
    public int? KasSpecRecno { get; set; }

    [Column("kas_iptal")]
    public bool? KasIptal { get; set; }

    [Column("kas_fileid")]
    public short? KasFileid { get; set; }

    [Column("kas_hidden")]
    public bool? KasHidden { get; set; }

    [Column("kas_kilitli")]
    public bool? KasKilitli { get; set; }

    [Column("kas_degisti")]
    public bool? KasDegisti { get; set; }

    [Column("kas_checksum")]
    public int? KasChecksum { get; set; }

    [Column("kas_create_user")]
    public short? KasCreateUser { get; set; }

    [Column("kas_create_date")]
    public DateTime? KasCreateDate { get; set; }

    [Column("kas_lastup_user")]
    public short? KasLastupUser { get; set; }

    [Column("kas_lastup_date")]
    public DateTime? KasLastupDate { get; set; }

    [Column("kas_special1")]
    [StringLength(4)]
    public string? KasSpecial1 { get; set; }

    [Column("kas_special2")]
    [StringLength(4)]
    public string? KasSpecial2 { get; set; }

    [Column("kas_special3")]
    [StringLength(4)]
    public string? KasSpecial3 { get; set; }

    [Column("kas_tip")]
    public byte? KasTip { get; set; }

    [Column("kas_firma_no")]
    public int? KasFirmaNo { get; set; }

    [Column("kas_kod")]
    [StringLength(25)]
    public string? KasKod { get; set; }

    [Column("kas_isim")]
    [StringLength(40)]
    public string? KasIsim { get; set; }

    [Column("kas_muh_kod")]
    [StringLength(40)]
    public string? KasMuhKod { get; set; }

    [Column("kas_doviz_cinsi")]
    public byte? KasDovizCinsi { get; set; }

    [Column("kas_bankakodu")]
    [StringLength(25)]
    public string? KasBankakodu { get; set; }

    [Column("kas_nakakincelenmesi")]
    public bool? KasNakakincelenmesi { get; set; }

    [Column("kas_ufrs_muh_kod")]
    [StringLength(40)]
    public string? KasUfrsMuhKod { get; set; }
}
