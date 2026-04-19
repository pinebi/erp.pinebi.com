using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("enfmizan")]
public class Enfmizan
{
    [Column("emizan_Guid")]
    public Guid? EmizanGuid { get; set; }

    [Column("emizan_DBCno")]
    public short? EmizanDBCno { get; set; }

    [Column("emizan_SpecRECNo")]
    public int? EmizanSpecRECNo { get; set; }

    [Column("emizan_iptal")]
    public bool? EmizanIptal { get; set; }

    [Column("emizan_fileid")]
    public short? EmizanFileid { get; set; }

    [Column("emizan_hidden")]
    public bool? EmizanHidden { get; set; }

    [Column("emizan_kilitli")]
    public bool? EmizanKilitli { get; set; }

    [Column("emizan_degisti")]
    public bool? EmizanDegisti { get; set; }

    [Column("emizan_checksum")]
    public int? EmizanChecksum { get; set; }

    [Column("emizan_create_user")]
    public short? EmizanCreateUser { get; set; }

    [Column("emizan_create_date")]
    public DateTime? EmizanCreateDate { get; set; }

    [Column("emizan_lastup_user")]
    public short? EmizanLastupUser { get; set; }

    [Column("emizan_lastup_date")]
    public DateTime? EmizanLastupDate { get; set; }

    [Column("emizan_special1")]
    [StringLength(4)]
    public string? EmizanSpecial1 { get; set; }

    [Column("emizan_special2")]
    [StringLength(4)]
    public string? EmizanSpecial2 { get; set; }

    [Column("emizan_special3")]
    [StringLength(4)]
    public string? EmizanSpecial3 { get; set; }

    [Column("emizan_hesapkodu")]
    [StringLength(25)]
    public string? EmizanHesapkodu { get; set; }

    [Column("emizan_hesapadi")]
    [StringLength(50)]
    public string? EmizanHesapadi { get; set; }

    [Column("emizan_ilk_endeks")]
    public double? EmizanIlkEndeks { get; set; }

    [Column("emizan_ham_ilk_borc")]
    public double? EmizanHamIlkBorc { get; set; }

    [Column("emizan_ham_ilk_alacak")]
    public double? EmizanHamIlkAlacak { get; set; }

    [Column("emizan_ilk_borc_hareket")]
    public double? EmizanIlkBorcHareket { get; set; }

    [Column("emizan_ilk_alacak_hareket")]
    public double? EmizanIlkAlacakHareket { get; set; }

    [Column("emizan_duzeltmeye_esas_ilk_borc")]
    public double? EmizanDuzeltmeyeEsasIlkBorc { get; set; }

    [Column("emizan_duzeltmeye_esas_ilk_alacak")]
    public double? EmizanDuzeltmeyeEsasIlkAlacak { get; set; }

    [Column("emizan_duzeltilmis_ilk_borc")]
    public double? EmizanDuzeltilmisIlkBorc { get; set; }

    [Column("emizan_duzeltilmis_ilk_alacak")]
    public double? EmizanDuzeltilmisIlkAlacak { get; set; }

    [Column("emizan_son_endeks")]
    public double? EmizanSonEndeks { get; set; }

    [Column("emizan_ham_son_borc")]
    public double? EmizanHamSonBorc { get; set; }

    [Column("emizan_ham_son_alacak")]
    public double? EmizanHamSonAlacak { get; set; }

    [Column("emizan_son_borc_hareket")]
    public double? EmizanSonBorcHareket { get; set; }

    [Column("emizan_son_alacak_hareket")]
    public double? EmizanSonAlacakHareket { get; set; }

    [Column("emizan_duzeltmeye_esas_son_borc")]
    public double? EmizanDuzeltmeyeEsasSonBorc { get; set; }

    [Column("emizan_duzeltmeye_esas_son_alacak")]
    public double? EmizanDuzeltmeyeEsasSonAlacak { get; set; }

    [Column("emizan_duzeltilmis_son_borc")]
    public double? EmizanDuzeltilmisSonBorc { get; set; }

    [Column("emizan_duzeltilmis_son_alacak")]
    public double? EmizanDuzeltilmisSonAlacak { get; set; }

    [Column("emizan_hesap_davranis")]
    public byte? EmizanHesapDavranis { get; set; }

    [Column("emizan_hesap_calisma_sekli")]
    public byte? EmizanHesapCalismaSekli { get; set; }

    [Column("emizan_hesap_detayina_girildi")]
    public byte? EmizanHesapDetayinaGirildi { get; set; }
}
