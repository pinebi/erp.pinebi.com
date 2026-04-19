using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_dagitim_anahtarlari")]
public class CariDagitimAnahtarlari
{
    [Column("cdaganah_Guid")]
    public Guid? CdaganahGuid { get; set; }

    [Column("cdaganah_DBCno")]
    public short? CdaganahDBCno { get; set; }

    [Column("cdaganah_SpecRECno")]
    public int? CdaganahSpecRECno { get; set; }

    [Column("cdaganah_iptal")]
    public bool? CdaganahIptal { get; set; }

    [Column("cdaganah_fileid")]
    public short? CdaganahFileid { get; set; }

    [Column("cdaganah_hidden")]
    public bool? CdaganahHidden { get; set; }

    [Column("cdaganah_kilitli")]
    public bool? CdaganahKilitli { get; set; }

    [Column("cdaganah_degisti")]
    public bool? CdaganahDegisti { get; set; }

    [Column("cdaganah_checksum")]
    public int? CdaganahChecksum { get; set; }

    [Column("cdaganah_create_user")]
    public short? CdaganahCreateUser { get; set; }

    [Column("cdaganah_create_date")]
    public DateTime? CdaganahCreateDate { get; set; }

    [Column("cdaganah_lastup_user")]
    public short? CdaganahLastupUser { get; set; }

    [Column("cdaganah_lastup_date")]
    public DateTime? CdaganahLastupDate { get; set; }

    [Column("cdaganah_special1")]
    [StringLength(4)]
    public string? CdaganahSpecial1 { get; set; }

    [Column("cdaganah_special2")]
    [StringLength(4)]
    public string? CdaganahSpecial2 { get; set; }

    [Column("cdaganah_special3")]
    [StringLength(4)]
    public string? CdaganahSpecial3 { get; set; }

    [Column("cdaganah_kod")]
    [StringLength(25)]
    public string? CdaganahKod { get; set; }

    [Column("cdaganah_gecerliliktarihi")]
    public DateTime? CdaganahGecerliliktarihi { get; set; }

    [Column("cdaganah_satirno")]
    public int? CdaganahSatirno { get; set; }

    [Column("cdaganah_ismi")]
    [StringLength(50)]
    public string? CdaganahIsmi { get; set; }

    [Column("cdaganah_hesapkodu")]
    [StringLength(25)]
    public string? CdaganahHesapkodu { get; set; }

    [Column("cdaganah_proje")]
    [StringLength(25)]
    public string? CdaganahProje { get; set; }

    [Column("cdaganah_srmmrk")]
    [StringLength(25)]
    public string? CdaganahSrmmrk { get; set; }

    [Column("cdaganah_puan")]
    public double? CdaganahPuan { get; set; }
}
