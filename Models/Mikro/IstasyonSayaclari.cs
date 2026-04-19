using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_sayaclari")]
public class IstasyonSayaclari
{
    [Column("s_Guid")]
    public Guid? SGuid { get; set; }

    [Column("s_DBCno")]
    public short? SDBCno { get; set; }

    [Column("s_SpecRECno")]
    public int? SSpecRECno { get; set; }

    [Column("s_iptal")]
    public bool? SIptal { get; set; }

    [Column("s_fileid")]
    public short? SFileid { get; set; }

    [Column("s_hidden")]
    public bool? SHidden { get; set; }

    [Column("s_kilitli")]
    public bool? SKilitli { get; set; }

    [Column("s_degisti")]
    public bool? SDegisti { get; set; }

    [Column("s_checksum")]
    public int? SChecksum { get; set; }

    [Column("s_create_user")]
    public short? SCreateUser { get; set; }

    [Column("s_create_date")]
    public DateTime? SCreateDate { get; set; }

    [Column("s_lastup_user")]
    public short? SLastupUser { get; set; }

    [Column("s_lastup_date")]
    public DateTime? SLastupDate { get; set; }

    [Column("s_special1")]
    [StringLength(4)]
    public string? SSpecial1 { get; set; }

    [Column("s_special2")]
    [StringLength(4)]
    public string? SSpecial2 { get; set; }

    [Column("s_special3")]
    [StringLength(4)]
    public string? SSpecial3 { get; set; }

    [Column("s_kod")]
    [StringLength(25)]
    public string? SKod { get; set; }

    [Column("s_ismi")]
    [StringLength(30)]
    public string? SIsmi { get; set; }

    [Column("s_firma_no")]
    public int? SFirmaNo { get; set; }

    [Column("s_sube_no")]
    public int? SSubeNo { get; set; }

    [Column("s_hareket_tipi")]
    public byte? SHareketTipi { get; set; }

    [Column("s_stokkodu")]
    [StringLength(25)]
    public string? SStokkodu { get; set; }

    [Column("s_adakodu")]
    [StringLength(25)]
    public string? SAdakodu { get; set; }

    [Column("s_aciklama")]
    [StringLength(50)]
    public string? SAciklama { get; set; }

    [Column("s_depono")]
    public int? SDepono { get; set; }

    [Column("s_acilis")]
    public double? SAcilis { get; set; }

    [Column("s_sube_sayackodu")]
    [StringLength(25)]
    public string? SSubeSayackodu { get; set; }
}
