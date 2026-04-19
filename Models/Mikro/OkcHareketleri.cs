using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("okc_hareketleri")]
public class OkcHareketleri
{
    [Column("okc_Guid")]
    public Guid? OkcGuid { get; set; }

    [Column("okc_DBCno")]
    public short? OkcDBCno { get; set; }

    [Column("okc_SpecRECNo")]
    public int? OkcSpecRECNo { get; set; }

    [Column("okc_iptal")]
    public bool? OkcIptal { get; set; }

    [Column("okc_fileid")]
    public short? OkcFileid { get; set; }

    [Column("okc_hidden")]
    public bool? OkcHidden { get; set; }

    [Column("okc_kilitli")]
    public bool? OkcKilitli { get; set; }

    [Column("okc_degisti")]
    public bool? OkcDegisti { get; set; }

    [Column("okc_checksum")]
    public int? OkcChecksum { get; set; }

    [Column("okc_create_user")]
    public short? OkcCreateUser { get; set; }

    [Column("okc_create_date")]
    public DateTime? OkcCreateDate { get; set; }

    [Column("okc_lastup_user")]
    public short? OkcLastupUser { get; set; }

    [Column("okc_lastup_date")]
    public DateTime? OkcLastupDate { get; set; }

    [Column("okc_special1")]
    [StringLength(4)]
    public string? OkcSpecial1 { get; set; }

    [Column("okc_special2")]
    [StringLength(4)]
    public string? OkcSpecial2 { get; set; }

    [Column("okc_special3")]
    [StringLength(4)]
    public string? OkcSpecial3 { get; set; }

    [Column("okc_fis_no")]
    public int? OkcFisNo { get; set; }

    [Column("okc_fis_tipi")]
    public byte? OkcFisTipi { get; set; }

    [Column("okc_fis_tarihi")]
    public DateTime? OkcFisTarihi { get; set; }

    [Column("okc_Zrapor_no")]
    public int? OkcZraporNo { get; set; }

    [Column("okc_fis_irsaliye_tarihi")]
    public DateTime? OkcFisIrsaliyeTarihi { get; set; }

    [Column("okc_seri_no")]
    [StringLength(25)]
    public string? OkcSeriNo { get; set; }

    [Column("okc_uuid")]
    [StringLength(40)]
    public string? OkcUuid { get; set; }
}
