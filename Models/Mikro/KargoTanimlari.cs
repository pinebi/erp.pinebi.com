using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kargo_tanimlari")]
public class KargoTanimlari
{
    [Column("krg_Guid")]
    public Guid? KrgGuid { get; set; }

    [Column("krg_DBCno")]
    public short? KrgDBCno { get; set; }

    [Column("krg_SpecRECNo")]
    public int? KrgSpecRECNo { get; set; }

    [Column("krg_iptal")]
    public bool? KrgIptal { get; set; }

    [Column("krg_fileid")]
    public short? KrgFileid { get; set; }

    [Column("krg_hidden")]
    public bool? KrgHidden { get; set; }

    [Column("krg_kilitli")]
    public bool? KrgKilitli { get; set; }

    [Column("krg_degisti")]
    public bool? KrgDegisti { get; set; }

    [Column("krg_CheckSum")]
    public int? KrgCheckSum { get; set; }

    [Column("krg_create_user")]
    public short? KrgCreateUser { get; set; }

    [Column("krg_create_date")]
    public DateTime? KrgCreateDate { get; set; }

    [Column("krg_lastup_user")]
    public short? KrgLastupUser { get; set; }

    [Column("krg_lastup_date")]
    public DateTime? KrgLastupDate { get; set; }

    [Column("krg_special1")]
    [StringLength(4)]
    public string? KrgSpecial1 { get; set; }

    [Column("krg_special2")]
    [StringLength(4)]
    public string? KrgSpecial2 { get; set; }

    [Column("krg_special3")]
    [StringLength(4)]
    public string? KrgSpecial3 { get; set; }

    [Column("krg_kodu")]
    [StringLength(25)]
    public string? KrgKodu { get; set; }

    [Column("krg_adi")]
    [StringLength(50)]
    public string? KrgAdi { get; set; }

    [Column("krg_tipi")]
    public byte? KrgTipi { get; set; }

    [Column("krg_yetkili")]
    [StringLength(30)]
    public string? KrgYetkili { get; set; }

    [Column("krg_tel")]
    [StringLength(15)]
    public string? KrgTel { get; set; }

    [Column("krg_fax")]
    [StringLength(15)]
    public string? KrgFax { get; set; }

    [Column("krg_email")]
    [StringLength(50)]
    public string? KrgEmail { get; set; }
}
