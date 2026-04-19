using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("asorti_tanimlari")]
public class AsortiTanimlari
{
    [Column("Asorti_Guid")]
    public Guid? AsortiGuid { get; set; }

    [Column("Asorti_DBCno")]
    public short? AsortiDBCno { get; set; }

    [Column("Asorti_SpecRECno")]
    public int? AsortiSpecRECno { get; set; }

    [Column("Asorti_iptal")]
    public bool? AsortiIptal { get; set; }

    [Column("Asorti_fileid")]
    public short? AsortiFileid { get; set; }

    [Column("Asorti_hidden")]
    public bool? AsortiHidden { get; set; }

    [Column("Asorti_kilitli")]
    public bool? AsortiKilitli { get; set; }

    [Column("Asorti_degisti")]
    public bool? AsortiDegisti { get; set; }

    [Column("Asorti_checksum")]
    public int? AsortiChecksum { get; set; }

    [Column("Asorti_create_user")]
    public short? AsortiCreateUser { get; set; }

    [Column("Asorti_create_date")]
    public DateTime? AsortiCreateDate { get; set; }

    [Column("Asorti_lastup_user")]
    public short? AsortiLastupUser { get; set; }

    [Column("Asorti_lastup_date")]
    public DateTime? AsortiLastupDate { get; set; }

    [Column("Asorti_special1")]
    [StringLength(4)]
    public string? AsortiSpecial1 { get; set; }

    [Column("Asorti_special2")]
    [StringLength(4)]
    public string? AsortiSpecial2 { get; set; }

    [Column("Asorti_special3")]
    [StringLength(4)]
    public string? AsortiSpecial3 { get; set; }

    [Column("Asorti_StokKodu")]
    [StringLength(25)]
    public string? AsortiStokKodu { get; set; }

    [Column("Asorti_TanimKodu")]
    [StringLength(25)]
    public string? AsortiTanimKodu { get; set; }

    [Column("Asorti_BedenNo")]
    public short? AsortiBedenNo { get; set; }

    [Column("Asorti_Miktar")]
    public double? AsortiMiktar { get; set; }
}
