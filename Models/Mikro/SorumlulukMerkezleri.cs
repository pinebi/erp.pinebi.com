using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("sorumluluk_merkezleri")]
public class SorumlulukMerkezleri
{
    [Column("som_Guid")]
    public Guid SomGuid { get; set; }

    [Column("som_DBCno")]
    public short? SomDBCno { get; set; }

    [Column("som_SpecRECno")]
    public int? SomSpecRECno { get; set; }

    [Column("som_iptal")]
    public bool? SomIptal { get; set; }

    [Column("som_fileid")]
    public short? SomFileid { get; set; }

    [Column("som_hidden")]
    public bool? SomHidden { get; set; }

    [Column("som_kilitli")]
    public bool? SomKilitli { get; set; }

    [Column("som_degisti")]
    public bool? SomDegisti { get; set; }

    [Column("som_checksum")]
    public int? SomChecksum { get; set; }

    [Column("som_create_user")]
    public short? SomCreateUser { get; set; }

    [Column("som_create_date")]
    public DateTime? SomCreateDate { get; set; }

    [Column("som_lastup_user")]
    public short? SomLastupUser { get; set; }

    [Column("som_lastup_date")]
    public DateTime? SomLastupDate { get; set; }

    [Column("som_special1")]
    [StringLength(4)]
    public string? SomSpecial1 { get; set; }

    [Column("som_special2")]
    [StringLength(4)]
    public string? SomSpecial2 { get; set; }

    [Column("som_special3")]
    [StringLength(4)]
    public string? SomSpecial3 { get; set; }

    [Column("som_kod")]
    [StringLength(25)]
    public string SomKod { get; set; }

    [Column("som_isim")]
    [StringLength(40)]
    public string? SomIsim { get; set; }

    [Column("som_DogrudanUrtSrmMrk")]
    public bool? SomDogrudanUrtSrmMrk { get; set; }

    [Column("som_MasrafNereyeYuklenecek")]
    public byte? SomMasrafNereyeYuklenecek { get; set; }

    [Column("som_DagAnahKodu")]
    [StringLength(25)]
    public string? SomDagAnahKodu { get; set; }

    [Column("som_MuhArtikeli")]
    [StringLength(10)]
    public string? SomMuhArtikeli { get; set; }

    [Column("som_MaliyetDagitimSekli")]
    public byte? SomMaliyetDagitimSekli { get; set; }

    [Column("som_MaliyetDagitimKaynak")]
    public byte? SomMaliyetDagitimKaynak { get; set; }

    [Column("som_tipi")]
    public byte? SomTipi { get; set; }

    [Column("som_satis_fiyat_liste_no")]
    public int? SomSatisFiyatListeNo { get; set; }
}
