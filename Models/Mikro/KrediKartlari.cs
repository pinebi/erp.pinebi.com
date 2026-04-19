using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kredi_kartlari")]
public class KrediKartlari
{
    [Column("kka_Guid")]
    public Guid? KkaGuid { get; set; }

    [Column("kka_DBCno")]
    public short? KkaDBCno { get; set; }

    [Column("kka_SpecRECno")]
    public int? KkaSpecRECno { get; set; }

    [Column("kka_iptal")]
    public bool? KkaIptal { get; set; }

    [Column("kka_fileid")]
    public short? KkaFileid { get; set; }

    [Column("kka_hidden")]
    public bool? KkaHidden { get; set; }

    [Column("kka_kilitli")]
    public bool? KkaKilitli { get; set; }

    [Column("kka_degisti")]
    public bool? KkaDegisti { get; set; }

    [Column("kka_checksum")]
    public int? KkaChecksum { get; set; }

    [Column("kka_create_user")]
    public short? KkaCreateUser { get; set; }

    [Column("kka_create_date")]
    public DateTime? KkaCreateDate { get; set; }

    [Column("kka_lastup_user")]
    public short? KkaLastupUser { get; set; }

    [Column("kka_lastup_date")]
    public DateTime? KkaLastupDate { get; set; }

    [Column("kka_special1")]
    [StringLength(4)]
    public string? KkaSpecial1 { get; set; }

    [Column("kka_special2")]
    [StringLength(4)]
    public string? KkaSpecial2 { get; set; }

    [Column("kka_special3")]
    [StringLength(4)]
    public string? KkaSpecial3 { get; set; }

    [Column("kka_yetkili_uid")]
    public Guid? KkaYetkiliUid { get; set; }

    [Column("kka_no")]
    [StringLength(16)]
    public string? KkaNo { get; set; }

    [Column("kka_cvc_no")]
    [StringLength(4)]
    public string? KkaCvcNo { get; set; }

    [Column("kka_sonay")]
    [StringLength(2)]
    public string? KkaSonay { get; set; }

    [Column("kka_sonyil")]
    [StringLength(2)]
    public string? KkaSonyil { get; set; }

    [Column("kka_tipi")]
    public byte? KkaTipi { get; set; }

    [Column("kka_isim")]
    [StringLength(50)]
    public string? KkaIsim { get; set; }

    [Column("kka_BankaKodu")]
    [StringLength(4)]
    public string? KkaBankaKodu { get; set; }
}
