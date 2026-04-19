using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_sozlesmeleri")]
public class CariHesapSozlesmeleri
{
    [Column("csoz_Guid")]
    public Guid? CsozGuid { get; set; }

    [Column("csoz_DBCno")]
    public short? CsozDBCno { get; set; }

    [Column("csoz_SpecRECno")]
    public int? CsozSpecRECno { get; set; }

    [Column("csoz_iptal")]
    public bool? CsozIptal { get; set; }

    [Column("csoz_fileid")]
    public short? CsozFileid { get; set; }

    [Column("csoz_hidden")]
    public bool? CsozHidden { get; set; }

    [Column("csoz_kilitli")]
    public bool? CsozKilitli { get; set; }

    [Column("csoz_degisti")]
    public bool? CsozDegisti { get; set; }

    [Column("csoz_checksum")]
    public int? CsozChecksum { get; set; }

    [Column("csoz_create_user")]
    public short? CsozCreateUser { get; set; }

    [Column("csoz_create_date")]
    public DateTime? CsozCreateDate { get; set; }

    [Column("csoz_lastup_user")]
    public short? CsozLastupUser { get; set; }

    [Column("csoz_lastup_date")]
    public DateTime? CsozLastupDate { get; set; }

    [Column("csoz_special1")]
    [StringLength(4)]
    public string? CsozSpecial1 { get; set; }

    [Column("csoz_special2")]
    [StringLength(4)]
    public string? CsozSpecial2 { get; set; }

    [Column("csoz_special3")]
    [StringLength(4)]
    public string? CsozSpecial3 { get; set; }

    [Column("csoz_sozlesmekodu")]
    [StringLength(25)]
    public string? CsozSozlesmekodu { get; set; }

    [Column("csoz_sozlesmeaciklamasi")]
    [StringLength(50)]
    public string? CsozSozlesmeaciklamasi { get; set; }

    [Column("csoz_baglicarikod")]
    [StringLength(25)]
    public string? CsozBaglicarikod { get; set; }

    [Column("csoz_sozlesmebaslamatarihi")]
    public DateTime? CsozSozlesmebaslamatarihi { get; set; }

    [Column("csoz_sozlesmebitistarihi")]
    public DateTime? CsozSozlesmebitistarihi { get; set; }

    [Column("csoz_sozlesmeuygulama")]
    public byte? CsozSozlesmeuygulama { get; set; }
}
