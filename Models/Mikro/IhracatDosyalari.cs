using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ihracat_dosyalari")]
public class IhracatDosyalari
{
    [Column("ihr_Guid")]
    public Guid? IhrGuid { get; set; }

    [Column("ihr_DBCno")]
    public short? IhrDBCno { get; set; }

    [Column("ihr_SpecRecNo")]
    public int? IhrSpecRecNo { get; set; }

    [Column("ihr_iptal")]
    public bool? IhrIptal { get; set; }

    [Column("ihr_fileid")]
    public short? IhrFileid { get; set; }

    [Column("ihr_hidden")]
    public bool? IhrHidden { get; set; }

    [Column("ihr_kilitli")]
    public bool? IhrKilitli { get; set; }

    [Column("ihr_degisti")]
    public bool? IhrDegisti { get; set; }

    [Column("ihr_checksum")]
    public int? IhrChecksum { get; set; }

    [Column("ihr_create_user")]
    public short? IhrCreateUser { get; set; }

    [Column("ihr_create_date")]
    public DateTime? IhrCreateDate { get; set; }

    [Column("ihr_lastup_user")]
    public short? IhrLastupUser { get; set; }

    [Column("ihr_lastup_date")]
    public DateTime? IhrLastupDate { get; set; }

    [Column("ihr_special1")]
    [StringLength(4)]
    public string? IhrSpecial1 { get; set; }

    [Column("ihr_special2")]
    [StringLength(4)]
    public string? IhrSpecial2 { get; set; }

    [Column("ihr_special3")]
    [StringLength(4)]
    public string? IhrSpecial3 { get; set; }

    [Column("ihr_firmano")]
    public int? IhrFirmano { get; set; }

    [Column("ihr_subeno")]
    public int? IhrSubeno { get; set; }

    [Column("ihr_kodu")]
    [StringLength(25)]
    public string? IhrKodu { get; set; }

    [Column("ihr_ismi")]
    [StringLength(40)]
    public string? IhrIsmi { get; set; }

    [Column("ihr_Satici")]
    [StringLength(25)]
    public string? IhrSatici { get; set; }

    [Column("ihr_UlkeTipi")]
    public byte? IhrUlkeTipi { get; set; }

    [Column("ihr_UlkeKodu")]
    [StringLength(4)]
    public string? IhrUlkeKodu { get; set; }

    [Column("ihr_GumrukKodu")]
    [StringLength(4)]
    public string? IhrGumrukKodu { get; set; }

    [Column("ihr_TeslimSekli")]
    [StringLength(4)]
    public string? IhrTeslimSekli { get; set; }

    [Column("ihr_OdemeSekli")]
    public byte? IhrOdemeSekli { get; set; }

    [Column("ihr_DovizCinsi")]
    public byte? IhrDovizCinsi { get; set; }

    [Column("ihr_carigrupno")]
    public byte? IhrCarigrupno { get; set; }

    [Column("ihr_AraciBanka")]
    [StringLength(25)]
    public string? IhrAraciBanka { get; set; }

    [Column("ihr_GCB_Tarihi")]
    public DateTime? IhrGCBTarihi { get; set; }

    [Column("ihr_GCB_No")]
    [StringLength(30)]
    public string? IhrGCBNo { get; set; }

    [Column("ihr_Tasima")]
    public byte? IhrTasima { get; set; }

    [Column("ihr_VasitaNo")]
    [StringLength(25)]
    public string? IhrVasitaNo { get; set; }

    [Column("ihr_Nakliyeci")]
    public DateTime? IhrNakliyeci { get; set; }

    [Column("ihr_GumrukMusaviri")]
    [StringLength(25)]
    public string? IhrGumrukMusaviri { get; set; }

    [Column("ihr_Intac_Tarihi")]
    public DateTime? IhrIntacTarihi { get; set; }

    [Column("ihr_Cikis_UlkeTipi")]
    public byte? IhrCikisUlkeTipi { get; set; }

    [Column("ihr_Cikis_ulkekodu")]
    [StringLength(4)]
    public string? IhrCikisUlkekodu { get; set; }

    [Column("ihr_Mense_UlkeTipi")]
    public byte? IhrMenseUlkeTipi { get; set; }

    [Column("ihr_Mense_ulkekodu")]
    [StringLength(4)]
    public string? IhrMenseUlkekodu { get; set; }

    [Column("ihr_Araci_CariKodu")]
    [StringLength(25)]
    public string? IhrAraciCariKodu { get; set; }

    [Column("ihr_Akreditif")]
    [StringLength(25)]
    public string? IhrAkreditif { get; set; }
}
