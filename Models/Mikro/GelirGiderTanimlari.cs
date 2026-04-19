using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("gelir_gider_tanimlari")]
public class GelirGiderTanimlari
{
    [Column("ggt_Guid")]
    public Guid? GgtGuid { get; set; }

    [Column("ggt_DBCno")]
    public short? GgtDBCno { get; set; }

    [Column("ggt_Spec_Rec_no")]
    public int? GgtSpecRecNo { get; set; }

    [Column("ggt_iptal")]
    public bool? GgtIptal { get; set; }

    [Column("ggt_fileid")]
    public short? GgtFileid { get; set; }

    [Column("ggt_hidden")]
    public bool? GgtHidden { get; set; }

    [Column("ggt_kilitli")]
    public bool? GgtKilitli { get; set; }

    [Column("ggt_degisti")]
    public bool? GgtDegisti { get; set; }

    [Column("ggt_checksum")]
    public int? GgtChecksum { get; set; }

    [Column("ggt_create_user")]
    public short? GgtCreateUser { get; set; }

    [Column("ggt_create_date")]
    public DateTime? GgtCreateDate { get; set; }

    [Column("ggt_lastup_user")]
    public short? GgtLastupUser { get; set; }

    [Column("ggt_lastup_date")]
    public DateTime? GgtLastupDate { get; set; }

    [Column("ggt_special1")]
    [StringLength(4)]
    public string? GgtSpecial1 { get; set; }

    [Column("ggt_special2")]
    [StringLength(4)]
    public string? GgtSpecial2 { get; set; }

    [Column("ggt_special3")]
    [StringLength(4)]
    public string? GgtSpecial3 { get; set; }

    [Column("ggt_hesap_kod")]
    [StringLength(25)]
    public string? GgtHesapKod { get; set; }

    [Column("ggt_srm_kod")]
    [StringLength(25)]
    public string? GgtSrmKod { get; set; }

    [Column("ggt_borc")]
    public double? GgtBorc { get; set; }

    [Column("ggt_alacak")]
    public double? GgtAlacak { get; set; }
}
