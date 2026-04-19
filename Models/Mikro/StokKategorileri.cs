using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_kategorileri")]
public class StokKategorileri
{
    [Column("ktg_Guid")]
    public Guid? KtgGuid { get; set; }

    [Column("ktg_DBCno")]
    public short? KtgDBCno { get; set; }

    [Column("ktg_SpecRECno")]
    public int? KtgSpecRECno { get; set; }

    [Column("ktg_iptal")]
    public bool? KtgIptal { get; set; }

    [Column("ktg_fileid")]
    public short? KtgFileid { get; set; }

    [Column("ktg_hidden")]
    public bool? KtgHidden { get; set; }

    [Column("ktg_kilitli")]
    public bool? KtgKilitli { get; set; }

    [Column("ktg_degisti")]
    public bool? KtgDegisti { get; set; }

    [Column("ktg_checksum")]
    public int? KtgChecksum { get; set; }

    [Column("ktg_create_user")]
    public short? KtgCreateUser { get; set; }

    [Column("ktg_create_date")]
    public DateTime? KtgCreateDate { get; set; }

    [Column("ktg_lastup_user")]
    public short? KtgLastupUser { get; set; }

    [Column("ktg_lastup_date")]
    public DateTime? KtgLastupDate { get; set; }

    [Column("ktg_special1")]
    [StringLength(4)]
    public string? KtgSpecial1 { get; set; }

    [Column("ktg_special2")]
    [StringLength(4)]
    public string? KtgSpecial2 { get; set; }

    [Column("ktg_special3")]
    [StringLength(4)]
    public string? KtgSpecial3 { get; set; }

    [Column("ktg_kod")]
    [StringLength(25)]
    public string? KtgKod { get; set; }

    [Column("ktg_isim")]
    [StringLength(50)]
    public string? KtgIsim { get; set; }

    [Column("ktg_aciklama")]
    [StringLength(50)]
    public string? KtgAciklama { get; set; }
}
