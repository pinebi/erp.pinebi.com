using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("yasakli_kayitlar")]
public class YasakliKayitlar
{
    [Column("yk_Guid")]
    public Guid? YkGuid { get; set; }

    [Column("yk_DBCno")]
    public short? YkDBCno { get; set; }

    [Column("yk_SpecRECno")]
    public int? YkSpecRECno { get; set; }

    [Column("yk_iptal")]
    public bool? YkIptal { get; set; }

    [Column("yk_fileid")]
    public short? YkFileid { get; set; }

    [Column("yk_hidden")]
    public bool? YkHidden { get; set; }

    [Column("yk_kilitli")]
    public bool? YkKilitli { get; set; }

    [Column("yk_degisti")]
    public bool? YkDegisti { get; set; }

    [Column("yk_checksum")]
    public int? YkChecksum { get; set; }

    [Column("yk_create_user")]
    public short? YkCreateUser { get; set; }

    [Column("yk_create_date")]
    public DateTime? YkCreateDate { get; set; }

    [Column("yk_lastup_user")]
    public short? YkLastupUser { get; set; }

    [Column("yk_lastup_date")]
    public DateTime? YkLastupDate { get; set; }

    [Column("yk_special1")]
    [StringLength(4)]
    public string? YkSpecial1 { get; set; }

    [Column("yk_special2")]
    [StringLength(4)]
    public string? YkSpecial2 { get; set; }

    [Column("yk_special3")]
    [StringLength(4)]
    public string? YkSpecial3 { get; set; }

    [Column("yk_kullanicino")]
    public int? YkKullanicino { get; set; }

    [Column("yk_tablono")]
    public short? YkTablono { get; set; }

    [Column("yk_kayitid")]
    public Guid? YkKayitid { get; set; }
}
