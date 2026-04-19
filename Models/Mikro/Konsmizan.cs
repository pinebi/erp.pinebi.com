using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("konsmizan")]
public class Konsmizan
{
    [Column("kmizan_Guid")]
    public Guid? KmizanGuid { get; set; }

    [Column("kmizan_DBCno")]
    public short? KmizanDBCno { get; set; }

    [Column("kmizan_SpecRECNo")]
    public int? KmizanSpecRECNo { get; set; }

    [Column("kmizan_iptal")]
    public bool? KmizanIptal { get; set; }

    [Column("kmizan_fileid")]
    public short? KmizanFileid { get; set; }

    [Column("kmizan_hidden")]
    public bool? KmizanHidden { get; set; }

    [Column("kmizan_kilitli")]
    public bool? KmizanKilitli { get; set; }

    [Column("kmizan_degisti")]
    public bool? KmizanDegisti { get; set; }

    [Column("kmizan_checksum")]
    public int? KmizanChecksum { get; set; }

    [Column("kmizan_create_user")]
    public short? KmizanCreateUser { get; set; }

    [Column("kmizan_create_date")]
    public DateTime? KmizanCreateDate { get; set; }

    [Column("kmizan_lastup_user")]
    public short? KmizanLastupUser { get; set; }

    [Column("kmizan_lastup_date")]
    public DateTime? KmizanLastupDate { get; set; }

    [Column("kmizan_special1")]
    [StringLength(4)]
    public string? KmizanSpecial1 { get; set; }

    [Column("kmizan_special2")]
    [StringLength(4)]
    public string? KmizanSpecial2 { get; set; }

    [Column("kmizan_special3")]
    [StringLength(4)]
    public string? KmizanSpecial3 { get; set; }

    [Column("kmizan_kodu")]
    [StringLength(25)]
    public string? KmizanKodu { get; set; }

    [Column("kmizan_hesapadi")]
    [StringLength(50)]
    public string? KmizanHesapadi { get; set; }

    [Column("kmizan_ham_ilk_borc")]
    public double? KmizanHamIlkBorc { get; set; }

    [Column("kmizan_ham_ilk_alacak")]
    public double? KmizanHamIlkAlacak { get; set; }

    [Column("kmizan_ilk_borc_hareket")]
    public double? KmizanIlkBorcHareket { get; set; }

    [Column("kmizan_ilk_alacak_hareket")]
    public double? KmizanIlkAlacakHareket { get; set; }

    [Column("kmizan_duzeltilmis_ilk_borc")]
    public double? KmizanDuzeltilmisIlkBorc { get; set; }

    [Column("kmizan_duzeltilmis_ilk_alacak")]
    public double? KmizanDuzeltilmisIlkAlacak { get; set; }

    [Column("kmizan_ham_son_borc")]
    public double? KmizanHamSonBorc { get; set; }

    [Column("kmizan_ham_son_alacak")]
    public double? KmizanHamSonAlacak { get; set; }

    [Column("kmizan_son_borc_hareket")]
    public double? KmizanSonBorcHareket { get; set; }

    [Column("kmizan_son_alacak_hareket")]
    public double? KmizanSonAlacakHareket { get; set; }

    [Column("kmizan_duzeltilmis_son_borc")]
    public double? KmizanDuzeltilmisSonBorc { get; set; }

    [Column("kmizan_duzeltilmis_son_alacak")]
    public double? KmizanDuzeltilmisSonAlacak { get; set; }

    [Column("kmizan_konsolide_borc")]
    public double? KmizanKonsolideBorc { get; set; }

    [Column("kmizan_konsolide_alacak")]
    public double? KmizanKonsolideAlacak { get; set; }

    [Column("kmizan_hesap_detayina_girildi")]
    public byte? KmizanHesapDetayinaGirildi { get; set; }

    [Column("kmizan_queryy_ilk_borc")]
    [StringLength(125)]
    public string? KmizanQueryyIlkBorc { get; set; }

    [Column("kmizan_queryy_ilk_alacak")]
    [StringLength(125)]
    public string? KmizanQueryyIlkAlacak { get; set; }

    [Column("kmizan_queryy_son_borc")]
    [StringLength(125)]
    public string? KmizanQueryySonBorc { get; set; }

    [Column("kmizan_queryy_son_alacak")]
    [StringLength(125)]
    public string? KmizanQueryySonAlacak { get; set; }
}
