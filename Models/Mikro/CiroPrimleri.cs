using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ciro_primleri")]
public class CiroPrimleri
{
    [Column("cpr_Guid")]
    public Guid? CprGuid { get; set; }

    [Column("cpr_DBCno")]
    public short? CprDBCno { get; set; }

    [Column("cpr_SpecRECno")]
    public int? CprSpecRECno { get; set; }

    [Column("cpr_iptal")]
    public bool? CprIptal { get; set; }

    [Column("cpr_fileid")]
    public short? CprFileid { get; set; }

    [Column("cpr_hidden")]
    public bool? CprHidden { get; set; }

    [Column("cpr_kilitli")]
    public bool? CprKilitli { get; set; }

    [Column("cpr_degisti")]
    public bool? CprDegisti { get; set; }

    [Column("cpr_checksum")]
    public int? CprChecksum { get; set; }

    [Column("cpr_create_user")]
    public short? CprCreateUser { get; set; }

    [Column("cpr_create_date")]
    public DateTime? CprCreateDate { get; set; }

    [Column("cpr_lastup_user")]
    public short? CprLastupUser { get; set; }

    [Column("cpr_lastup_date")]
    public DateTime? CprLastupDate { get; set; }

    [Column("cpr_special1")]
    [StringLength(4)]
    public string? CprSpecial1 { get; set; }

    [Column("cpr_special2")]
    [StringLength(4)]
    public string? CprSpecial2 { get; set; }

    [Column("cpr_special3")]
    [StringLength(4)]
    public string? CprSpecial3 { get; set; }

    [Column("cpr_firmano")]
    public int? CprFirmano { get; set; }

    [Column("cpr_subeno")]
    public int? CprSubeno { get; set; }

    [Column("cpr_baglicarikod")]
    [StringLength(25)]
    public string? CprBaglicarikod { get; set; }

    [Column("cpr_numarasi")]
    public int? CprNumarasi { get; set; }

    [Column("cpr_carisozlesmekodu")]
    [StringLength(25)]
    public string? CprCarisozlesmekodu { get; set; }

    [Column("cpr_satirno")]
    public int? CprSatirno { get; set; }

    [Column("cpr_tarihi")]
    public DateTime? CprTarihi { get; set; }

    [Column("cpr_aciklama")]
    [StringLength(50)]
    public string? CprAciklama { get; set; }

    [Column("cpr_uygulamasekli")]
    public byte? CprUygulamasekli { get; set; }

    [Column("cpr_iadelergozardi")]
    public byte? CprIadelergozardi { get; set; }

    [Column("cpr_hesapsekli")]
    public byte? CprHesapsekli { get; set; }

    [Column("cpr_stokindex")]
    public byte? CprStokindex { get; set; }

    [Column("cpr_stokbaglantikodu")]
    [StringLength(25)]
    public string? CprStokbaglantikodu { get; set; }

    [Column("cpr_stokindex2")]
    public byte? CprStokindex2 { get; set; }

    [Column("cpr_stokbaglantikodu2")]
    [StringLength(25)]
    public string? CprStokbaglantikodu2 { get; set; }

    [Column("cpr_stokindex3")]
    public byte? CprStokindex3 { get; set; }

    [Column("cpr_stokbaglantikodu3")]
    [StringLength(25)]
    public string? CprStokbaglantikodu3 { get; set; }

    [Column("cpr_stokindex4")]
    public byte? CprStokindex4 { get; set; }

    [Column("cpr_stokbaglantikodu4")]
    [StringLength(25)]
    public string? CprStokbaglantikodu4 { get; set; }

    [Column("cpr_stokindex5")]
    public byte? CprStokindex5 { get; set; }

    [Column("cpr_stokbaglantikodu5")]
    [StringLength(25)]
    public string? CprStokbaglantikodu5 { get; set; }

    [Column("cpr_srmmrkkodu")]
    [StringLength(25)]
    public string? CprSrmmrkkodu { get; set; }

    [Column("cpr_stoksrmmrkkodu")]
    [StringLength(25)]
    public string? CprStoksrmmrkkodu { get; set; }

    [Column("cpr_hizmetkodu")]
    [StringLength(25)]
    public string? CprHizmetkodu { get; set; }

    [Column("cpr_baslangictarihi")]
    public DateTime? CprBaslangictarihi { get; set; }

    [Column("cpr_bitistarihi")]
    public DateTime? CprBitistarihi { get; set; }

    [Column("cpr_primeesasdeger1")]
    public double? CprPrimeesasdeger1 { get; set; }

    [Column("cpr_primeesasdeger2")]
    public double? CprPrimeesasdeger2 { get; set; }

    [Column("cpr_primeesasdeger3")]
    public double? CprPrimeesasdeger3 { get; set; }

    [Column("cpr_primeesasdeger4")]
    public double? CprPrimeesasdeger4 { get; set; }

    [Column("cpr_primeesasdeger5")]
    public double? CprPrimeesasdeger5 { get; set; }

    [Column("cpr_primorani1")]
    public double? CprPrimorani1 { get; set; }

    [Column("cpr_primorani2")]
    public double? CprPrimorani2 { get; set; }

    [Column("cpr_primorani3")]
    public double? CprPrimorani3 { get; set; }

    [Column("cpr_primorani4")]
    public double? CprPrimorani4 { get; set; }

    [Column("cpr_primorani5")]
    public double? CprPrimorani5 { get; set; }

    [Column("cpr_faturaseri")]
    [StringLength(50)]
    public string? CprFaturaseri { get; set; }

    [Column("cpr_faturasira")]
    public int? CprFaturasira { get; set; }

    [Column("cpr_primisrmmrkleredagit")]
    public byte? CprPrimisrmmrkleredagit { get; set; }

    [Column("cpr_odemeplani")]
    public int? CprOdemeplani { get; set; }

    [Column("cpr_altcaridegerlendir")]
    public bool? CprAltcaridegerlendir { get; set; }

    [Column("cpr_fiyatfarkidegerlendirme")]
    public bool? CprFiyatfarkidegerlendirme { get; set; }

    [Column("cpr_ciroprimfaturatipi")]
    public byte? CprCiroprimfaturatipi { get; set; }

    [Column("cpr_miktarsaltavancarpantipi")]
    public byte? CprMiktarsaltavancarpantipi { get; set; }

    [Column("cpr_primeesastavantipi")]
    public byte? CprPrimeesastavantipi { get; set; }

    [Column("cpr_primevergidahil")]
    public bool? CprPrimevergidahil { get; set; }

    [Column("cpr_depono")]
    public int? CprDepono { get; set; }

    [Column("cpr_primvergidetayli")]
    public bool? CprPrimvergidetayli { get; set; }

    [Column("cpr_hesapfaturatarihinden")]
    public bool? CprHesapfaturatarihinden { get; set; }

    [Column("cpr_depobaglantitip1")]
    public byte? CprDepobaglantitip1 { get; set; }

    [Column("cpr_depobaglantino1")]
    public int? CprDepobaglantino1 { get; set; }

    [Column("cpr_depobaglantikodu1")]
    [StringLength(25)]
    public string? CprDepobaglantikodu1 { get; set; }

    [Column("cpr_depobaglantitip2")]
    public byte? CprDepobaglantitip2 { get; set; }

    [Column("cpr_depobaglantino2")]
    public int? CprDepobaglantino2 { get; set; }

    [Column("cpr_depobaglantikodu2")]
    [StringLength(25)]
    public string? CprDepobaglantikodu2 { get; set; }

    [Column("cpr_depobaglantitip3")]
    public byte? CprDepobaglantitip3 { get; set; }

    [Column("cpr_depobaglantino3")]
    public int? CprDepobaglantino3 { get; set; }

    [Column("cpr_depobaglantikodu3")]
    [StringLength(25)]
    public string? CprDepobaglantikodu3 { get; set; }

    [Column("cpr_irseliyedegerlendir")]
    public bool? CprIrseliyedegerlendir { get; set; }
}
