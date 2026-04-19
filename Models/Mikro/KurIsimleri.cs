using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kur_isimleri")]
public class KurIsimleri
{
    [Column("Kur_Guid")]
    public Guid? KurGuid { get; set; }

    [Column("Kur_DBCno")]
    public short? KurDBCno { get; set; }

    [Column("Kur_SpecRECno")]
    public int? KurSpecRECno { get; set; }

    [Column("Kur_iptal")]
    public bool? KurIptal { get; set; }

    [Column("Kur_fileid")]
    public short? KurFileid { get; set; }

    [Column("Kur_hidden")]
    public bool? KurHidden { get; set; }

    [Column("Kur_kilitli")]
    public bool? KurKilitli { get; set; }

    [Column("Kur_degisti")]
    public bool? KurDegisti { get; set; }

    [Column("Kur_checksum")]
    public int? KurChecksum { get; set; }

    [Column("Kur_create_user")]
    public short? KurCreateUser { get; set; }

    [Column("Kur_create_date")]
    public DateTime? KurCreateDate { get; set; }

    [Column("Kur_lastup_user")]
    public short? KurLastupUser { get; set; }

    [Column("Kur_lastup_date")]
    public DateTime? KurLastupDate { get; set; }

    [Column("Kur_special1")]
    [StringLength(4)]
    public string? KurSpecial1 { get; set; }

    [Column("Kur_special2")]
    [StringLength(4)]
    public string? KurSpecial2 { get; set; }

    [Column("Kur_special3")]
    [StringLength(4)]
    public string? KurSpecial3 { get; set; }

    [Column("Kur_Tip")]
    [StringLength(3)]
    public string? KurTip { get; set; }

    [Column("Kur_sembol")]
    [StringLength(3)]
    public string? KurSembol { get; set; }

    [Column("Kur_adi")]
    [StringLength(50)]
    public string? KurAdi { get; set; }

    [Column("Kur_orjAdi")]
    [StringLength(50)]
    public string? KurOrjAdi { get; set; }

    [Column("Kur_kusurat_isim")]
    [StringLength(10)]
    public string? KurKusuratIsim { get; set; }

    [Column("Kur_decimal")]
    public byte? KurDecimal { get; set; }

    [Column("Kur_kusurat_sembol")]
    [StringLength(3)]
    public string? KurKusuratSembol { get; set; }
}
