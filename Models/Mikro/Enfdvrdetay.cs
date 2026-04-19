using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("enfdvrdetay")]
public class Enfdvrdetay
{
    [Column("edev_Guid")]
    public Guid? EdevGuid { get; set; }

    [Column("edev_DBCno")]
    public short? EdevDBCno { get; set; }

    [Column("edev_SpecRECNo")]
    public int? EdevSpecRECNo { get; set; }

    [Column("edev_iptal")]
    public bool? EdevIptal { get; set; }

    [Column("edev_fileid")]
    public short? EdevFileid { get; set; }

    [Column("edev_hidden")]
    public bool? EdevHidden { get; set; }

    [Column("edev_kilitli")]
    public bool? EdevKilitli { get; set; }

    [Column("edev_degisti")]
    public bool? EdevDegisti { get; set; }

    [Column("edev_checksum")]
    public int? EdevChecksum { get; set; }

    [Column("edev_create_user")]
    public short? EdevCreateUser { get; set; }

    [Column("edev_create_date")]
    public DateTime? EdevCreateDate { get; set; }

    [Column("edev_lastup_user")]
    public short? EdevLastupUser { get; set; }

    [Column("edev_lastup_date")]
    public DateTime? EdevLastupDate { get; set; }

    [Column("edev_special1")]
    [StringLength(4)]
    public string? EdevSpecial1 { get; set; }

    [Column("edev_special2")]
    [StringLength(4)]
    public string? EdevSpecial2 { get; set; }

    [Column("edev_special3")]
    [StringLength(4)]
    public string? EdevSpecial3 { get; set; }

    [Column("edev_hesapkodu")]
    [StringLength(25)]
    public string? EdevHesapkodu { get; set; }

    [Column("edev_endeks")]
    public double? EdevEndeks { get; set; }

    [Column("edev_devreden")]
    public double? EdevDevreden { get; set; }

    [Column("edev_duzeltilmis_devreden")]
    public double? EdevDuzeltilmisDevreden { get; set; }

    [Column("edev_cikan")]
    public double? EdevCikan { get; set; }

    [Column("edev_duzeltilmis_cikan")]
    public double? EdevDuzeltilmisCikan { get; set; }

    [Column("edev_kalan")]
    public double? EdevKalan { get; set; }

    [Column("edev_duzeltilmis_kalan")]
    public double? EdevDuzeltilmisKalan { get; set; }

    [Column("edev_satis_endeksi")]
    public double? EdevSatisEndeksi { get; set; }

    [Column("edev_satis_tutari")]
    public double? EdevSatisTutari { get; set; }

    [Column("edev_duzeltilmis_satis_tutari")]
    public double? EdevDuzeltilmisSatisTutari { get; set; }

    [Column("edev_parasal_pozisyona_etkisi")]
    public byte? EdevParasalPozisyonaEtkisi { get; set; }

    [Column("edev_cikan_tutar_duzelt_tabii")]
    public byte? EdevCikanTutarDuzeltTabii { get; set; }
}
