using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("finansal_sozlesme_taksitleri")]
public class FinansalSozlesmeTaksitleri
{
    [Column("FST_Guid")]
    public Guid? FSTGuid { get; set; }

    [Column("FST_DBCno")]
    public short? FSTDBCno { get; set; }

    [Column("FST_Spec_Rec_no")]
    public int? FSTSpecRecNo { get; set; }

    [Column("FST_iptal")]
    public bool? FSTIptal { get; set; }

    [Column("FST_fileid")]
    public short? FSTFileid { get; set; }

    [Column("FST_hidden")]
    public bool? FSTHidden { get; set; }

    [Column("FST_kilitli")]
    public bool? FSTKilitli { get; set; }

    [Column("FST_degisti")]
    public bool? FSTDegisti { get; set; }

    [Column("FST_checksum")]
    public int? FSTChecksum { get; set; }

    [Column("FST_create_user")]
    public short? FSTCreateUser { get; set; }

    [Column("FST_create_date")]
    public DateTime? FSTCreateDate { get; set; }

    [Column("FST_lastup_user")]
    public short? FSTLastupUser { get; set; }

    [Column("FST_lastup_date")]
    public DateTime? FSTLastupDate { get; set; }

    [Column("FST_special1")]
    [StringLength(4)]
    public string? FSTSpecial1 { get; set; }

    [Column("FST_special2")]
    [StringLength(4)]
    public string? FSTSpecial2 { get; set; }

    [Column("FST_special3")]
    [StringLength(4)]
    public string? FSTSpecial3 { get; set; }

    [Column("FST_sozkodu")]
    [StringLength(25)]
    public string? FSTSozkodu { get; set; }

    [Column("FST_taksitno")]
    public short? FSTTaksitno { get; set; }

    [Column("FST_vade")]
    public DateTime? FSTVade { get; set; }

    [Column("FST_anapara")]
    public double? FSTAnapara { get; set; }

    [Column("FST_faiz")]
    public double? FSTFaiz { get; set; }

    [Column("FST_uzunvade")]
    public bool? FSTUzunvade { get; set; }

    [Column("FST_faturaseri")]
    [StringLength(50)]
    public string? FSTFaturaseri { get; set; }

    [Column("FST_faturasira")]
    public int? FSTFaturasira { get; set; }
}
