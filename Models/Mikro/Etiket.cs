using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("etiket")]
public class Etiket
{
    [Column("te_Guid")]
    public Guid? TeGuid { get; set; }

    [Column("te_DBCno")]
    public short? TeDBCno { get; set; }

    [Column("te_SpecRECno")]
    public int? TeSpecRECno { get; set; }

    [Column("te_iptal")]
    public bool? TeIptal { get; set; }

    [Column("te_fileid")]
    public short? TeFileid { get; set; }

    [Column("te_hidden")]
    public bool? TeHidden { get; set; }

    [Column("te_kilitli")]
    public bool? TeKilitli { get; set; }

    [Column("te_degisti")]
    public bool? TeDegisti { get; set; }

    [Column("te_checksum")]
    public int? TeChecksum { get; set; }

    [Column("te_create_user")]
    public short? TeCreateUser { get; set; }

    [Column("te_create_date")]
    public DateTime? TeCreateDate { get; set; }

    [Column("te_lastup_user")]
    public short? TeLastupUser { get; set; }

    [Column("te_lastup_date")]
    public DateTime? TeLastupDate { get; set; }

    [Column("te_special1")]
    [StringLength(4)]
    public string? TeSpecial1 { get; set; }

    [Column("te_special2")]
    [StringLength(4)]
    public string? TeSpecial2 { get; set; }

    [Column("te_special3")]
    [StringLength(4)]
    public string? TeSpecial3 { get; set; }

    [Column("te_StokKodu")]
    [StringLength(25)]
    public string? TeStokKodu { get; set; }

    [Column("te_RenkPntr")]
    public byte? TeRenkPntr { get; set; }

    [Column("te_BedenPntr")]
    public byte? TeBedenPntr { get; set; }

    [Column("te_EtiketMiktari")]
    public int? TeEtiketMiktari { get; set; }

    [Column("te_nedeni")]
    public byte? TeNedeni { get; set; }
}
