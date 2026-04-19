using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yasakli_veritabanlari")]
public class YasakliVeritabanlari
{
    [Column("yv_Guid")]
    public Guid? YvGuid { get; set; }

    [Column("yv_DBCno")]
    public short? YvDBCno { get; set; }

    [Column("yv_SpecRECno")]
    public int? YvSpecRECno { get; set; }

    [Column("yv_iptal")]
    public bool? YvIptal { get; set; }

    [Column("yv_fileid")]
    public short? YvFileid { get; set; }

    [Column("yv_hidden")]
    public bool? YvHidden { get; set; }

    [Column("yv_kilitli")]
    public bool? YvKilitli { get; set; }

    [Column("yv_degisti")]
    public bool? YvDegisti { get; set; }

    [Column("yv_checksum")]
    public int? YvChecksum { get; set; }

    [Column("yv_create_user")]
    public short? YvCreateUser { get; set; }

    [Column("yv_create_date")]
    public DateTime? YvCreateDate { get; set; }

    [Column("yv_lastup_user")]
    public short? YvLastupUser { get; set; }

    [Column("yv_lastup_date")]
    public DateTime? YvLastupDate { get; set; }

    [Column("yv_special1")]
    [StringLength(4)]
    public string? YvSpecial1 { get; set; }

    [Column("yv_special2")]
    [StringLength(4)]
    public string? YvSpecial2 { get; set; }

    [Column("yv_special3")]
    [StringLength(4)]
    public string? YvSpecial3 { get; set; }

    [Column("yv_kullanici_no")]
    public int? YvKullaniciNo { get; set; }

    [Column("yv_tablono")]
    public short? YvTablono { get; set; }

    [Column("yv_kayitid")]
    public Guid? YvKayitid { get; set; }
}
