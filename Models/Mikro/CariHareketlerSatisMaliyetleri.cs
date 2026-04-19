using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hareketler_satis_maliyetleri")]
public class CariHareketlerSatisMaliyetleri
{
    [Column("stmly_Guid")]
    public Guid? StmlyGuid { get; set; }

    [Column("stmly_DBCno")]
    public short? StmlyDBCno { get; set; }

    [Column("stmly_SpecRECno")]
    public int? StmlySpecRECno { get; set; }

    [Column("stmly_iptal")]
    public bool? StmlyIptal { get; set; }

    [Column("stmly_fileid")]
    public short? StmlyFileid { get; set; }

    [Column("stmly_hidden")]
    public bool? StmlyHidden { get; set; }

    [Column("stmly_kilitli")]
    public bool? StmlyKilitli { get; set; }

    [Column("stmly_degisti")]
    public bool? StmlyDegisti { get; set; }

    [Column("stmly_checksum")]
    public int? StmlyChecksum { get; set; }

    [Column("stmly_create_user")]
    public short? StmlyCreateUser { get; set; }

    [Column("stmly_create_date")]
    public DateTime? StmlyCreateDate { get; set; }

    [Column("stmly_lastup_user")]
    public short? StmlyLastupUser { get; set; }

    [Column("stmly_lastup_date")]
    public DateTime? StmlyLastupDate { get; set; }

    [Column("stmly_special1")]
    [StringLength(4)]
    public string? StmlySpecial1 { get; set; }

    [Column("stmly_special2")]
    [StringLength(4)]
    public string? StmlySpecial2 { get; set; }

    [Column("stmly_special3")]
    [StringLength(4)]
    public string? StmlySpecial3 { get; set; }

    [Column("stmly_ch_uid")]
    public Guid? StmlyChUid { get; set; }

    [Column("stmly_uretim_ana")]
    public double? StmlyUretimAna { get; set; }

    [Column("stmly_uretim_alt")]
    public double? StmlyUretimAlt { get; set; }

    [Column("stmly_arastirmagelistirme_750_ana")]
    public double? StmlyArastirmagelistirme750Ana { get; set; }

    [Column("stmly_arastirmagelistirme_750_alt")]
    public double? StmlyArastirmagelistirme750Alt { get; set; }

    [Column("stmly_pazarlamasatis_760_ana")]
    public double? StmlyPazarlamasatis760Ana { get; set; }

    [Column("stmly_pazarlamasatis_760_alt")]
    public double? StmlyPazarlamasatis760Alt { get; set; }

    [Column("stmly_genelyonetim_770_ana")]
    public double? StmlyGenelyonetim770Ana { get; set; }

    [Column("stmly_genelyonetim_770_alt")]
    public double? StmlyGenelyonetim770Alt { get; set; }

    [Column("stmly_finansman_780_ana")]
    public double? StmlyFinansman780Ana { get; set; }

    [Column("stmly_finansman_780_alt")]
    public double? StmlyFinansman780Alt { get; set; }

    [Column("stmly_diger_ana")]
    public double? StmlyDigerAna { get; set; }

    [Column("stmly_diger_alt")]
    public double? StmlyDigerAlt { get; set; }
}
