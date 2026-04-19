using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("enfcardetay")]
public class Enfcardetay
{
    [Column("ecari_Guid")]
    public Guid? EcariGuid { get; set; }

    [Column("ecari_DBCno")]
    public short? EcariDBCno { get; set; }

    [Column("ecari_SpecRECNo")]
    public int? EcariSpecRECNo { get; set; }

    [Column("ecari_iptal")]
    public bool? EcariIptal { get; set; }

    [Column("ecari_fileid")]
    public short? EcariFileid { get; set; }

    [Column("ecari_hidden")]
    public bool? EcariHidden { get; set; }

    [Column("ecari_kilitli")]
    public bool? EcariKilitli { get; set; }

    [Column("ecari_degisti")]
    public bool? EcariDegisti { get; set; }

    [Column("ecari_checksum")]
    public int? EcariChecksum { get; set; }

    [Column("ecari_create_user")]
    public short? EcariCreateUser { get; set; }

    [Column("ecari_create_date")]
    public DateTime? EcariCreateDate { get; set; }

    [Column("ecari_lastup_user")]
    public short? EcariLastupUser { get; set; }

    [Column("ecari_lastup_date")]
    public DateTime? EcariLastupDate { get; set; }

    [Column("ecari_special1")]
    [StringLength(4)]
    public string? EcariSpecial1 { get; set; }

    [Column("ecari_special2")]
    [StringLength(4)]
    public string? EcariSpecial2 { get; set; }

    [Column("ecari_special3")]
    [StringLength(4)]
    public string? EcariSpecial3 { get; set; }

    [Column("ecari_hesapkodu")]
    [StringLength(25)]
    public string? EcariHesapkodu { get; set; }

    [Column("ecari_endeks")]
    public double? EcariEndeks { get; set; }

    [Column("ecari_devreden")]
    public double? EcariDevreden { get; set; }

    [Column("ecari_duzeltilmis_devreden")]
    public double? EcariDuzeltilmisDevreden { get; set; }

    [Column("ecari_cikan")]
    public double? EcariCikan { get; set; }

    [Column("ecari_duzeltilmis_cikan")]
    public double? EcariDuzeltilmisCikan { get; set; }

    [Column("ecari_kalan")]
    public double? EcariKalan { get; set; }

    [Column("ecari_duzeltilmis_kalan")]
    public double? EcariDuzeltilmisKalan { get; set; }

    [Column("ecari_satis_endeksi")]
    public double? EcariSatisEndeksi { get; set; }

    [Column("ecari_satis_tutari")]
    public double? EcariSatisTutari { get; set; }

    [Column("ecari_duzeltilmis_satis_tutari")]
    public double? EcariDuzeltilmisSatisTutari { get; set; }

    [Column("ecari_parasal_pozisyona_etkisi")]
    public byte? EcariParasalPozisyonaEtkisi { get; set; }

    [Column("ecari_cikan_tutar_duzelt_tabii")]
    public byte? EcariCikanTutarDuzeltTabii { get; set; }
}
