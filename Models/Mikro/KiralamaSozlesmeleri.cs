using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_sozlesmeleri")]
public class KiralamaSozlesmeleri
{
    [Column("ksoz_Guid")]
    public Guid? KsozGuid { get; set; }

    [Column("ksoz_DBCno")]
    public short? KsozDBCno { get; set; }

    [Column("ksoz_SpecRECno")]
    public int? KsozSpecRECno { get; set; }

    [Column("ksoz_iptal")]
    public bool? KsozIptal { get; set; }

    [Column("ksoz_fileid")]
    public short? KsozFileid { get; set; }

    [Column("ksoz_hidden")]
    public bool? KsozHidden { get; set; }

    [Column("ksoz_kilitli")]
    public bool? KsozKilitli { get; set; }

    [Column("ksoz_degisti")]
    public bool? KsozDegisti { get; set; }

    [Column("ksoz_checksum")]
    public int? KsozChecksum { get; set; }

    [Column("ksoz_create_user")]
    public short? KsozCreateUser { get; set; }

    [Column("ksoz_create_date")]
    public DateTime? KsozCreateDate { get; set; }

    [Column("ksoz_lastup_user")]
    public short? KsozLastupUser { get; set; }

    [Column("ksoz_lastup_date")]
    public DateTime? KsozLastupDate { get; set; }

    [Column("ksoz_special1")]
    [StringLength(4)]
    public string? KsozSpecial1 { get; set; }

    [Column("ksoz_special2")]
    [StringLength(4)]
    public string? KsozSpecial2 { get; set; }

    [Column("ksoz_special3")]
    [StringLength(4)]
    public string? KsozSpecial3 { get; set; }

    [Column("ksoz_kodu")]
    [StringLength(25)]
    public string? KsozKodu { get; set; }

    [Column("ksoz_tarihi")]
    public DateTime? KsozTarihi { get; set; }

    [Column("ksoz_carikodu")]
    [StringLength(25)]
    public string? KsozCarikodu { get; set; }

    [Column("ksoz_bastar")]
    public DateTime? KsozBastar { get; set; }

    [Column("ksoz_bittar")]
    public DateTime? KsozBittar { get; set; }
}
