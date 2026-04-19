using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_gecikme_nedenleri")]
public class UretimGecikmeNedenleri
{
    [Column("GckNdn_Guid")]
    public Guid? GckNdnGuid { get; set; }

    [Column("GckNdn_DBCno")]
    public short? GckNdnDBCno { get; set; }

    [Column("GckNdn_SpecRECNo")]
    public int? GckNdnSpecRECNo { get; set; }

    [Column("GckNdn_iptal")]
    public bool? GckNdnIptal { get; set; }

    [Column("GckNdn_fileid")]
    public short? GckNdnFileid { get; set; }

    [Column("GckNdn_hidden")]
    public bool? GckNdnHidden { get; set; }

    [Column("GckNdn_kilitli")]
    public bool? GckNdnKilitli { get; set; }

    [Column("GckNdn_degistir")]
    public bool? GckNdnDegistir { get; set; }

    [Column("GckNdn_checksum")]
    public int? GckNdnChecksum { get; set; }

    [Column("GckNdn_create_user")]
    public short? GckNdnCreateUser { get; set; }

    [Column("GckNdn_create_date")]
    public DateTime? GckNdnCreateDate { get; set; }

    [Column("GckNdn_lastup_user")]
    public short? GckNdnLastupUser { get; set; }

    [Column("GckNdn_lastup_date")]
    public DateTime? GckNdnLastupDate { get; set; }

    [Column("GckNdn_special1")]
    [StringLength(4)]
    public string? GckNdnSpecial1 { get; set; }

    [Column("GckNdn_special2")]
    [StringLength(4)]
    public string? GckNdnSpecial2 { get; set; }

    [Column("GckNdn_special3")]
    [StringLength(4)]
    public string? GckNdnSpecial3 { get; set; }

    [Column("GckNdn_kod")]
    [StringLength(25)]
    public string? GckNdnKod { get; set; }

    [Column("GckNdn_aciklama")]
    [StringLength(40)]
    public string? GckNdnAciklama { get; set; }

    [Column("GckNdn_PersonelKaynakli_fl")]
    public bool? GckNdnPersonelKaynakliFl { get; set; }

    [Column("GckNdn_MaliyeteEtkiTipi")]
    public byte? GckNdnMaliyeteEtkiTipi { get; set; }
}
