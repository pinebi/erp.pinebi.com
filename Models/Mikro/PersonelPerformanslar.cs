using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_performanslar")]
public class PersonelPerformanslar
{
    [Column("aprf_Guid")]
    public Guid? AprfGuid { get; set; }

    [Column("aprf_DBCno")]
    public short? AprfDBCno { get; set; }

    [Column("aprf_SpecRECno")]
    public int? AprfSpecRECno { get; set; }

    [Column("aprf_iptal")]
    public bool? AprfIptal { get; set; }

    [Column("aprf_fileid")]
    public short? AprfFileid { get; set; }

    [Column("aprf_hidden")]
    public bool? AprfHidden { get; set; }

    [Column("aprf_kilitli")]
    public bool? AprfKilitli { get; set; }

    [Column("aprf_degisti")]
    public bool? AprfDegisti { get; set; }

    [Column("aprf_checksum")]
    public int? AprfChecksum { get; set; }

    [Column("aprf_create_user")]
    public short? AprfCreateUser { get; set; }

    [Column("aprf_create_date")]
    public DateTime? AprfCreateDate { get; set; }

    [Column("aprf_lastup_user")]
    public short? AprfLastupUser { get; set; }

    [Column("aprf_lastup_date")]
    public DateTime? AprfLastupDate { get; set; }

    [Column("aprf_special1")]
    [StringLength(4)]
    public string? AprfSpecial1 { get; set; }

    [Column("aprf_special2")]
    [StringLength(4)]
    public string? AprfSpecial2 { get; set; }

    [Column("aprf_special3")]
    [StringLength(4)]
    public string? AprfSpecial3 { get; set; }

    [Column("aprf_firmano")]
    public int? AprfFirmano { get; set; }

    [Column("aprf_subeno")]
    public int? AprfSubeno { get; set; }

    [Column("aprf_tarih")]
    public DateTime? AprfTarih { get; set; }

    [Column("aprf_tip")]
    public byte? AprfTip { get; set; }

    [Column("aprf_evrakno_seri")]
    [StringLength(50)]
    public string? AprfEvraknoSeri { get; set; }

    [Column("aprf_evrakno_sira")]
    public int? AprfEvraknoSira { get; set; }

    [Column("aprf_satirno")]
    public int? AprfSatirno { get; set; }

    [Column("aprf_belgeno")]
    [StringLength(50)]
    public string? AprfBelgeno { get; set; }

    [Column("aprf_belge_tarih")]
    public DateTime? AprfBelgeTarih { get; set; }

    [Column("aprf_veren_pers")]
    [StringLength(25)]
    public string? AprfVerenPers { get; set; }

    [Column("aprf_per_kodu")]
    [StringLength(25)]
    public string? AprfPerKodu { get; set; }

    [Column("aprf_perform_kodu")]
    [StringLength(25)]
    public string? AprfPerformKodu { get; set; }

    [Column("aprf_aciklama")]
    [StringLength(80)]
    public string? AprfAciklama { get; set; }

    [Column("aprf_miktar")]
    public double? AprfMiktar { get; set; }
}
