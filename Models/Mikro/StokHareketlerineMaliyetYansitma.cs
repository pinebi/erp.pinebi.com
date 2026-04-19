using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_hareketlerine_maliyet_yansitma")]
public class StokHareketlerineMaliyetYansitma
{
    [Column("shmy_Guid")]
    public Guid? ShmyGuid { get; set; }

    [Column("shmy_DBCno")]
    public short? ShmyDBCno { get; set; }

    [Column("shmy_SpecRECno")]
    public int? ShmySpecRECno { get; set; }

    [Column("shmy_iptal")]
    public bool? ShmyIptal { get; set; }

    [Column("shmy_fileid")]
    public short? ShmyFileid { get; set; }

    [Column("shmy_hidden")]
    public bool? ShmyHidden { get; set; }

    [Column("shmy_kilitli")]
    public bool? ShmyKilitli { get; set; }

    [Column("shmy_degisti")]
    public bool? ShmyDegisti { get; set; }

    [Column("shmy_checksum")]
    public int? ShmyChecksum { get; set; }

    [Column("shmy_create_user")]
    public short? ShmyCreateUser { get; set; }

    [Column("shmy_create_date")]
    public DateTime? ShmyCreateDate { get; set; }

    [Column("shmy_lastup_user")]
    public short? ShmyLastupUser { get; set; }

    [Column("shmy_lastup_date")]
    public DateTime? ShmyLastupDate { get; set; }

    [Column("shmy_special1")]
    [StringLength(4)]
    public string? ShmySpecial1 { get; set; }

    [Column("shmy_special2")]
    [StringLength(4)]
    public string? ShmySpecial2 { get; set; }

    [Column("shmy_special3")]
    [StringLength(4)]
    public string? ShmySpecial3 { get; set; }

    [Column("shmy_tarihi")]
    public DateTime? ShmyTarihi { get; set; }

    [Column("shmy_evrakno_seri")]
    [StringLength(50)]
    public string? ShmyEvraknoSeri { get; set; }

    [Column("shmy_evrakno_sira")]
    public int? ShmyEvraknoSira { get; set; }

    [Column("shmy_satirno")]
    public int? ShmySatirno { get; set; }

    [Column("shmy_har_uid")]
    public Guid? ShmyHarUid { get; set; }

    [Column("shmy_ilave_maliyet_ana")]
    public double? ShmyIlaveMaliyetAna { get; set; }

    [Column("shmy_ilave_maliyet_alt")]
    public double? ShmyIlaveMaliyetAlt { get; set; }

    [Column("shmy_ilave_maliyet_orj")]
    public double? ShmyIlaveMaliyetOrj { get; set; }

    [Column("shmy_aciklama")]
    [StringLength(50)]
    public string? ShmyAciklama { get; set; }
}
