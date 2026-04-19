using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("teklif_tanimlari")]
public class TeklifTanimlari
{
    [Column("teklif_Guid")]
    public Guid? TeklifGuid { get; set; }

    [Column("teklif_DBCno")]
    public short? TeklifDBCno { get; set; }

    [Column("teklif_SpecRECno")]
    public int? TeklifSpecRECno { get; set; }

    [Column("teklif_iptal")]
    public bool? TeklifIptal { get; set; }

    [Column("teklif_fileid")]
    public short? TeklifFileid { get; set; }

    [Column("teklif_hidden")]
    public bool? TeklifHidden { get; set; }

    [Column("teklif_kilitli")]
    public bool? TeklifKilitli { get; set; }

    [Column("teklif_degisti")]
    public bool? TeklifDegisti { get; set; }

    [Column("teklif_checksum")]
    public int? TeklifChecksum { get; set; }

    [Column("teklif_create_user")]
    public short? TeklifCreateUser { get; set; }

    [Column("teklif_create_date")]
    public DateTime? TeklifCreateDate { get; set; }

    [Column("teklif_lastup_user")]
    public short? TeklifLastupUser { get; set; }

    [Column("teklif_lastup_date")]
    public DateTime? TeklifLastupDate { get; set; }

    [Column("teklif_special1")]
    [StringLength(4)]
    public string? TeklifSpecial1 { get; set; }

    [Column("teklif_special2")]
    [StringLength(4)]
    public string? TeklifSpecial2 { get; set; }

    [Column("teklif_special3")]
    [StringLength(4)]
    public string? TeklifSpecial3 { get; set; }

    [Column("teklif_kodu")]
    [StringLength(25)]
    public string? TeklifKodu { get; set; }

    [Column("teklif_ismi")]
    [StringLength(50)]
    public string? TeklifIsmi { get; set; }

    [Column("teklif_aciklama")]
    [StringLength(50)]
    public string? TeklifAciklama { get; set; }

    [Column("teklif_proje")]
    [StringLength(25)]
    public string? TeklifProje { get; set; }

    [Column("teklif_srmmrk")]
    [StringLength(25)]
    public string? TeklifSrmmrk { get; set; }

    [Column("teklif_sorumlu")]
    [StringLength(25)]
    public string? TeklifSorumlu { get; set; }

    [Column("teklif_baslangictarihi")]
    public DateTime? TeklifBaslangictarihi { get; set; }

    [Column("teklif_gecerliliksuresi")]
    public DateTime? TeklifGecerliliksuresi { get; set; }

    [Column("teklif_istenenteslimtarihi")]
    public DateTime? TeklifIstenenteslimtarihi { get; set; }
}
