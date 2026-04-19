using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hareket_odeme_vadeleri")]
public class CariHareketOdemeVadeleri
{
    [Column("cop_Guid")]
    public Guid? CopGuid { get; set; }

    [Column("cop_DBCno")]
    public short? CopDBCno { get; set; }

    [Column("cop_SpecRECno")]
    public int? CopSpecRECno { get; set; }

    [Column("cop_iptal")]
    public bool? CopIptal { get; set; }

    [Column("cop_fileid")]
    public short? CopFileid { get; set; }

    [Column("cop_hidden")]
    public bool? CopHidden { get; set; }

    [Column("cop_kilitli")]
    public bool? CopKilitli { get; set; }

    [Column("cop_degisti")]
    public bool? CopDegisti { get; set; }

    [Column("cop_checksum")]
    public int? CopChecksum { get; set; }

    [Column("cop_create_user")]
    public short? CopCreateUser { get; set; }

    [Column("cop_create_date")]
    public DateTime? CopCreateDate { get; set; }

    [Column("cop_lastup_user")]
    public short? CopLastupUser { get; set; }

    [Column("cop_lastup_date")]
    public DateTime? CopLastupDate { get; set; }

    [Column("cop_special1")]
    [StringLength(4)]
    public string? CopSpecial1 { get; set; }

    [Column("cop_special2")]
    [StringLength(4)]
    public string? CopSpecial2 { get; set; }

    [Column("cop_special3")]
    [StringLength(4)]
    public string? CopSpecial3 { get; set; }

    [Column("cop_evrak_tip")]
    public byte? CopEvrakTip { get; set; }

    [Column("cop_evrakno_seri")]
    [StringLength(50)]
    public string? CopEvraknoSeri { get; set; }

    [Column("cop_evrakno_sira")]
    public int? CopEvraknoSira { get; set; }

    [Column("cop_vade")]
    public DateTime? CopVade { get; set; }

    [Column("cop_tutar")]
    public double? CopTutar { get; set; }
}
