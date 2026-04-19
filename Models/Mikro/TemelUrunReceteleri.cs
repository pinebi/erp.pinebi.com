using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("temel_urun_receteleri")]
public class TemelUrunReceteleri
{
    [Column("mre_Guid")]
    public Guid? MreGuid { get; set; }

    [Column("mre_DBCno")]
    public short? MreDBCno { get; set; }

    [Column("mre_SpecRECno")]
    public int? MreSpecRECno { get; set; }

    [Column("mre_iptal")]
    public bool? MreIptal { get; set; }

    [Column("mre_fileid")]
    public short? MreFileid { get; set; }

    [Column("mre_hidden")]
    public bool? MreHidden { get; set; }

    [Column("mre_kilitli")]
    public bool? MreKilitli { get; set; }

    [Column("mre_degisti")]
    public bool? MreDegisti { get; set; }

    [Column("mre_checksum")]
    public int? MreChecksum { get; set; }

    [Column("mre_create_user")]
    public short? MreCreateUser { get; set; }

    [Column("mre_create_date")]
    public DateTime? MreCreateDate { get; set; }

    [Column("mre_lastup_user")]
    public short? MreLastupUser { get; set; }

    [Column("mre_lastup_date")]
    public DateTime? MreLastupDate { get; set; }

    [Column("mre_special1")]
    [StringLength(4)]
    public string? MreSpecial1 { get; set; }

    [Column("mre_special2")]
    [StringLength(4)]
    public string? MreSpecial2 { get; set; }

    [Column("mre_special3")]
    [StringLength(4)]
    public string? MreSpecial3 { get; set; }

    [Column("mre_ana_kodu")]
    [StringLength(25)]
    public string? MreAnaKodu { get; set; }

    [Column("mre_tarih")]
    public DateTime? MreTarih { get; set; }

    [Column("mre_aciklama")]
    [StringLength(50)]
    public string? MreAciklama { get; set; }

    [Column("mre_ana_birim")]
    public byte? MreAnaBirim { get; set; }

    [Column("mre_ana_miktar")]
    public double? MreAnaMiktar { get; set; }

    [Column("mre_tuketim_turu")]
    public byte? MreTuketimTuru { get; set; }

    [Column("mre_tuketim_kodu")]
    [StringLength(25)]
    public string? MreTuketimKodu { get; set; }

    [Column("mre_tuketim_miktari")]
    public double? MreTuketimMiktari { get; set; }

    [Column("mre_tuketim_birim")]
    public byte? MreTuketimBirim { get; set; }

    [Column("mre_uretimtuketim")]
    public byte? MreUretimtuketim { get; set; }

    [Column("mre_satirno")]
    public int? MreSatirno { get; set; }

    [Column("mre_strdetay_acik")]
    [StringLength(50)]
    public string? MreStrdetayAcik { get; set; }

    [Column("mre_depono")]
    public int? MreDepono { get; set; }

    [Column("mre_fire_yuzdesi")]
    public double? MreFireYuzdesi { get; set; }

    [Column("mre_PlanlamaTipi")]
    public byte? MrePlanlamaTipi { get; set; }
}
