using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isemri_stok_tuketimleri")]
public class IsemriStokTuketimleri
{
    [Column("tkt_Guid")]
    public Guid? TktGuid { get; set; }

    [Column("tkt_DBCno")]
    public short? TktDBCno { get; set; }

    [Column("tkt_SpecRECno")]
    public int? TktSpecRECno { get; set; }

    [Column("tkt_iptal")]
    public bool? TktIptal { get; set; }

    [Column("tkt_fileid")]
    public short? TktFileid { get; set; }

    [Column("tkt_hidden")]
    public bool? TktHidden { get; set; }

    [Column("tkt_kilitli")]
    public bool? TktKilitli { get; set; }

    [Column("tkt_degisti")]
    public bool? TktDegisti { get; set; }

    [Column("tkt_checksum")]
    public int? TktChecksum { get; set; }

    [Column("tkt_create_user")]
    public short? TktCreateUser { get; set; }

    [Column("tkt_create_date")]
    public DateTime? TktCreateDate { get; set; }

    [Column("tkt_lastup_user")]
    public short? TktLastupUser { get; set; }

    [Column("tkt_lastup_date")]
    public DateTime? TktLastupDate { get; set; }

    [Column("tkt_special1")]
    [StringLength(4)]
    public string? TktSpecial1 { get; set; }

    [Column("tkt_special2")]
    [StringLength(4)]
    public string? TktSpecial2 { get; set; }

    [Column("tkt_special3")]
    [StringLength(4)]
    public string? TktSpecial3 { get; set; }

    [Column("tkt_isemri")]
    [StringLength(25)]
    public string? TktIsemri { get; set; }

    [Column("tkt_satirno")]
    public int? TktSatirno { get; set; }

    [Column("tkt_stokkodu")]
    [StringLength(25)]
    public string? TktStokkodu { get; set; }

    [Column("tkt_fasoncukodu")]
    [StringLength(25)]
    public string? TktFasoncukodu { get; set; }

    [Column("tkt_IsmerkeziKodu")]
    [StringLength(25)]
    public string? TktIsmerkeziKodu { get; set; }

    [Column("tkt_miktari")]
    public double? TktMiktari { get; set; }

    [Column("tkt_DegerAna")]
    public double? TktDegerAna { get; set; }

    [Column("tkt_DegerAlt")]
    public double? TktDegerAlt { get; set; }

    [Column("tkt_DegerOrj")]
    public double? TktDegerOrj { get; set; }

    [Column("tkt_UretimStokKodu")]
    [StringLength(25)]
    public string? TktUretimStokKodu { get; set; }

    [Column("tkt_UretimMiktari")]
    public double? TktUretimMiktari { get; set; }

    [Column("tkt_birimpntr")]
    public byte? TktBirimpntr { get; set; }

    [Column("tkt_Uretimbirimpntr")]
    public byte? TktUretimbirimpntr { get; set; }
}
