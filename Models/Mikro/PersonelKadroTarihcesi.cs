using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_tarihcesi")]
public class PersonelKadroTarihcesi
{
    [Column("kt_Guid")]
    public Guid? KtGuid { get; set; }

    [Column("kt_DBCno")]
    public short? KtDBCno { get; set; }

    [Column("kt_SpecRECno")]
    public int? KtSpecRECno { get; set; }

    [Column("kt_iptal")]
    public bool? KtIptal { get; set; }

    [Column("kt_fileid")]
    public short? KtFileid { get; set; }

    [Column("kt_hidden")]
    public bool? KtHidden { get; set; }

    [Column("kt_kilitli")]
    public bool? KtKilitli { get; set; }

    [Column("kt_degisti")]
    public bool? KtDegisti { get; set; }

    [Column("kt_checksum")]
    public int? KtChecksum { get; set; }

    [Column("kt_create_user")]
    public short? KtCreateUser { get; set; }

    [Column("kt_create_date")]
    public DateTime? KtCreateDate { get; set; }

    [Column("kt_lastup_user")]
    public short? KtLastupUser { get; set; }

    [Column("kt_lastup_date")]
    public DateTime? KtLastupDate { get; set; }

    [Column("kt_special1")]
    [StringLength(4)]
    public string? KtSpecial1 { get; set; }

    [Column("kt_special2")]
    [StringLength(4)]
    public string? KtSpecial2 { get; set; }

    [Column("kt_special3")]
    [StringLength(4)]
    public string? KtSpecial3 { get; set; }

    [Column("kt_kadrokodu")]
    [StringLength(25)]
    public string? KtKadrokodu { get; set; }

    [Column("kt_sirano")]
    public int? KtSirano { get; set; }

    [Column("kt_personelkodu")]
    [StringLength(25)]
    public string? KtPersonelkodu { get; set; }

    [Column("kt_atamatarihi")]
    public DateTime? KtAtamatarihi { get; set; }

    [Column("kt_ayrilmatarihi")]
    public DateTime? KtAyrilmatarihi { get; set; }

    [Column("kt_ayrilmasebebi")]
    [StringLength(50)]
    public string? KtAyrilmasebebi { get; set; }
}
