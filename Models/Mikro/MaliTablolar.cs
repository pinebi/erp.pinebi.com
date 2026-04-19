using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("mali_tablolar")]
public class MaliTablolar
{
    [Column("mt_Guid")]
    public Guid? MtGuid { get; set; }

    [Column("mt_DBCno")]
    public short? MtDBCno { get; set; }

    [Column("mt_SpecRECNo")]
    public int? MtSpecRECNo { get; set; }

    [Column("mt_iptal")]
    public bool? MtIptal { get; set; }

    [Column("mt_fileid")]
    public short? MtFileid { get; set; }

    [Column("mt_hidden")]
    public bool? MtHidden { get; set; }

    [Column("mt_kilitli")]
    public bool? MtKilitli { get; set; }

    [Column("mt_degisti")]
    public bool? MtDegisti { get; set; }

    [Column("mt_checksum")]
    public int? MtChecksum { get; set; }

    [Column("mt_create_user")]
    public short? MtCreateUser { get; set; }

    [Column("mt_create_date")]
    public DateTime? MtCreateDate { get; set; }

    [Column("mt_lastup_user")]
    public short? MtLastupUser { get; set; }

    [Column("mt_lastup_date")]
    public DateTime? MtLastupDate { get; set; }

    [Column("mt_special1")]
    [StringLength(4)]
    public string? MtSpecial1 { get; set; }

    [Column("mt_special2")]
    [StringLength(4)]
    public string? MtSpecial2 { get; set; }

    [Column("mt_special3")]
    [StringLength(4)]
    public string? MtSpecial3 { get; set; }

    [Column("mt_Tablo")]
    public byte? MtTablo { get; set; }

    [Column("mt_Sirano")]
    public int? MtSirano { get; set; }

    [Column("mt_DilAciklamasiT")]
    [StringLength(127)]
    public string? MtDilAciklamasiT { get; set; }

    [Column("mt_DilAciklamasiE")]
    [StringLength(127)]
    public string? MtDilAciklamasiE { get; set; }

    [Column("mt_DilAciklamasiG")]
    [StringLength(127)]
    public string? MtDilAciklamasiG { get; set; }

    [Column("mt_DilAciklamasiA")]
    [StringLength(127)]
    public string? MtDilAciklamasiA { get; set; }

    [Column("mt_DilAciklamasiR")]
    [StringLength(127)]
    public string? MtDilAciklamasiR { get; set; }

    [Column("mt_DilAciklamasiB")]
    [StringLength(127)]
    public string? MtDilAciklamasiB { get; set; }

    [Column("mt_DilAciklamasiP")]
    [StringLength(127)]
    public string? MtDilAciklamasiP { get; set; }

    [Column("mt_Tipi")]
    public int? MtTipi { get; set; }

    [Column("mt_HesapVeyaFormul")]
    [StringLength(127)]
    public string? MtHesapVeyaFormul { get; set; }

    [Column("mt_Giris")]
    public double? MtGiris { get; set; }

    [Column("mt_EskiDonem")]
    public double? MtEskiDonem { get; set; }

    [Column("mt_Seviye")]
    public int? MtSeviye { get; set; }
}
