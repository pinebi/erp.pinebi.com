using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_satis_fiyat_listeleri")]
public class StokSatisFiyatListeleri
{
    [Column("sfiyat_Guid")]
    public Guid? SfiyatGuid { get; set; }

    [Column("sfiyat_DBCno")]
    public short? SfiyatDBCno { get; set; }

    [Column("sfiyat_SpecRECno")]
    public int? SfiyatSpecRECno { get; set; }

    [Column("sfiyat_iptal")]
    public bool? SfiyatIptal { get; set; }

    [Column("sfiyat_fileid")]
    public short? SfiyatFileid { get; set; }

    [Column("sfiyat_hidden")]
    public bool? SfiyatHidden { get; set; }

    [Column("sfiyat_kilitli")]
    public bool? SfiyatKilitli { get; set; }

    [Column("sfiyat_degisti")]
    public bool? SfiyatDegisti { get; set; }

    [Column("sfiyat_checksum")]
    public int? SfiyatChecksum { get; set; }

    [Column("sfiyat_create_user")]
    public short? SfiyatCreateUser { get; set; }

    [Column("sfiyat_create_date")]
    public DateTime? SfiyatCreateDate { get; set; }

    [Column("sfiyat_lastup_user")]
    public short? SfiyatLastupUser { get; set; }

    [Column("sfiyat_lastup_date")]
    public DateTime? SfiyatLastupDate { get; set; }

    [Column("sfiyat_special1")]
    [StringLength(4)]
    public string? SfiyatSpecial1 { get; set; }

    [Column("sfiyat_special2")]
    [StringLength(4)]
    public string? SfiyatSpecial2 { get; set; }

    [Column("sfiyat_special3")]
    [StringLength(4)]
    public string? SfiyatSpecial3 { get; set; }

    [Column("sfiyat_stokkod")]
    [StringLength(25)]
    public string? SfiyatStokkod { get; set; }

    [Column("sfiyat_listesirano")]
    public int? SfiyatListesirano { get; set; }

    [Column("sfiyat_deposirano")]
    public int? SfiyatDeposirano { get; set; }

    [Column("sfiyat_odemeplan")]
    public int? SfiyatOdemeplan { get; set; }

    [Column("sfiyat_fiyati")]
    public double? SfiyatFiyati { get; set; }

    [Column("sfiyat_doviz")]
    public byte? SfiyatDoviz { get; set; }

    [Column("sfiyat_iskontokod")]
    [StringLength(4)]
    public string? SfiyatIskontokod { get; set; }

    [Column("sfiyat_deg_nedeni")]
    public byte? SfiyatDegNedeni { get; set; }

    [Column("sfiyat_primyuzdesi")]
    public double? SfiyatPrimyuzdesi { get; set; }

    [Column("sfiyat_kampanyakod")]
    [StringLength(50)]
    public string? SfiyatKampanyakod { get; set; }
}
