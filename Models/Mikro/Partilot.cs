using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("partilot")]
public class Partilot
{
    [Column("pl_Guid")]
    public Guid? PlGuid { get; set; }

    [Column("pl_DBCno")]
    public short? PlDBCno { get; set; }

    [Column("pl_SpecRECno")]
    public int? PlSpecRECno { get; set; }

    [Column("pl_iptal")]
    public bool? PlIptal { get; set; }

    [Column("pl_fileid")]
    public short? PlFileid { get; set; }

    [Column("pl_hidden")]
    public bool? PlHidden { get; set; }

    [Column("pl_kilitli")]
    public bool? PlKilitli { get; set; }

    [Column("pl_degisti")]
    public bool? PlDegisti { get; set; }

    [Column("pl_checksum")]
    public int? PlChecksum { get; set; }

    [Column("pl_create_user")]
    public short? PlCreateUser { get; set; }

    [Column("pl_create_date")]
    public DateTime? PlCreateDate { get; set; }

    [Column("pl_lastup_user")]
    public short? PlLastupUser { get; set; }

    [Column("pl_lastup_date")]
    public DateTime? PlLastupDate { get; set; }

    [Column("pl_ozelkod1")]
    [StringLength(4)]
    public string? PlOzelkod1 { get; set; }

    [Column("pl_ozelkod2")]
    [StringLength(4)]
    public string? PlOzelkod2 { get; set; }

    [Column("pl_ozelkod3")]
    [StringLength(4)]
    public string? PlOzelkod3 { get; set; }

    [Column("pl_partikodu")]
    [StringLength(25)]
    public string? PlPartikodu { get; set; }

    [Column("pl_lotno")]
    public int? PlLotno { get; set; }

    [Column("pl_stokkodu")]
    [StringLength(25)]
    public string? PlStokkodu { get; set; }

    [Column("pl_aciklama")]
    [StringLength(50)]
    public string? PlAciklama { get; set; }

    [Column("pl_olckalkdeg_deg1")]
    public double? PlOlckalkdegDeg1 { get; set; }

    [Column("pl_olckalkdeg_deg2")]
    public double? PlOlckalkdegDeg2 { get; set; }

    [Column("pl_olckalkdeg_deg3")]
    public double? PlOlckalkdegDeg3 { get; set; }

    [Column("pl_olckalkdeg_deg4")]
    public double? PlOlckalkdegDeg4 { get; set; }

    [Column("pl_olckalkdeg_deg5")]
    public double? PlOlckalkdegDeg5 { get; set; }

    [Column("pl_olckalkdeg_deg6")]
    public double? PlOlckalkdegDeg6 { get; set; }

    [Column("pl_olckalkdeg_deg7")]
    public double? PlOlckalkdegDeg7 { get; set; }

    [Column("pl_olckalkdeg_deg8")]
    public double? PlOlckalkdegDeg8 { get; set; }

    [Column("pl_olckalkdeg_deg9")]
    public double? PlOlckalkdegDeg9 { get; set; }

    [Column("pl_olckalkdeg_deg10")]
    public double? PlOlckalkdegDeg10 { get; set; }

    [Column("pl_olckalkdeg_aciklama1")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama1 { get; set; }

    [Column("pl_olckalkdeg_aciklama2")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama2 { get; set; }

    [Column("pl_olckalkdeg_aciklama3")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama3 { get; set; }

    [Column("pl_olckalkdeg_aciklama4")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama4 { get; set; }

    [Column("pl_olckalkdeg_aciklama5")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama5 { get; set; }

    [Column("pl_olckalkdeg_aciklama6")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama6 { get; set; }

    [Column("pl_olckalkdeg_aciklama7")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama7 { get; set; }

    [Column("pl_olckalkdeg_aciklama8")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama8 { get; set; }

    [Column("pl_olckalkdeg_aciklama9")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama9 { get; set; }

    [Column("pl_olckalkdeg_aciklama10")]
    [StringLength(25)]
    public string? PlOlckalkdegAciklama10 { get; set; }

    [Column("pl_son_kullanim_tar")]
    public DateTime? PlSonKullanimTar { get; set; }

    [Column("pl_DaraliKilo")]
    public double? PlDaraliKilo { get; set; }

    [Column("pl_SafiKilo")]
    public double? PlSafiKilo { get; set; }

    [Column("pl_En")]
    public double? PlEn { get; set; }

    [Column("pl_Boy")]
    public double? PlBoy { get; set; }

    [Column("pl_Yukseklik")]
    public double? PlYukseklik { get; set; }

    [Column("pl_OzgulAgirlik")]
    public double? PlOzgulAgirlik { get; set; }

    [Column("pl_kod1")]
    [StringLength(25)]
    public string? PlKod1 { get; set; }

    [Column("pl_kod2")]
    [StringLength(25)]
    public string? PlKod2 { get; set; }

    [Column("pl_kod3")]
    [StringLength(25)]
    public string? PlKod3 { get; set; }

    [Column("pl_kod4")]
    [StringLength(25)]
    public string? PlKod4 { get; set; }

    [Column("pl_kod5")]
    [StringLength(25)]
    public string? PlKod5 { get; set; }

    [Column("pl_kod6")]
    [StringLength(25)]
    public string? PlKod6 { get; set; }

    [Column("pl_kod7")]
    [StringLength(25)]
    public string? PlKod7 { get; set; }

    [Column("pl_kod8")]
    [StringLength(25)]
    public string? PlKod8 { get; set; }

    [Column("pl_kod9")]
    [StringLength(25)]
    public string? PlKod9 { get; set; }

    [Column("pl_kod10")]
    [StringLength(25)]
    public string? PlKod10 { get; set; }
}
