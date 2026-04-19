using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_maliyet_devir")]
public class UretimMaliyetDevir
{
    [Column("umd_Guid")]
    public Guid? UmdGuid { get; set; }

    [Column("umd_DBCno")]
    public short? UmdDBCno { get; set; }

    [Column("umd_SpecRECno")]
    public int? UmdSpecRECno { get; set; }

    [Column("umd_iptal")]
    public bool? UmdIptal { get; set; }

    [Column("umd_fileid")]
    public short? UmdFileid { get; set; }

    [Column("umd_hidden")]
    public bool? UmdHidden { get; set; }

    [Column("umd_kilitli")]
    public bool? UmdKilitli { get; set; }

    [Column("umd_degisti")]
    public bool? UmdDegisti { get; set; }

    [Column("umd_CheckSum")]
    public int? UmdCheckSum { get; set; }

    [Column("umd_create_user")]
    public short? UmdCreateUser { get; set; }

    [Column("umd_create_date")]
    public DateTime? UmdCreateDate { get; set; }

    [Column("umd_lastup_user")]
    public short? UmdLastupUser { get; set; }

    [Column("umd_lastup_date")]
    public DateTime? UmdLastupDate { get; set; }

    [Column("umd_special1")]
    [StringLength(4)]
    public string? UmdSpecial1 { get; set; }

    [Column("umd_special2")]
    [StringLength(4)]
    public string? UmdSpecial2 { get; set; }

    [Column("umd_special3")]
    [StringLength(4)]
    public string? UmdSpecial3 { get; set; }

    [Column("umd_isemrikodu")]
    [StringLength(25)]
    public string? UmdIsemrikodu { get; set; }

    [Column("umd_sevkedilen_malzeme")]
    public double? UmdSevkedilenMalzeme { get; set; }

    [Column("umd_urune_yansiyan_malzeme")]
    public double? UmdUruneYansiyanMalzeme { get; set; }

    [Column("umd_urune_yansiyan_direkt_iscilik")]
    public double? UmdUruneYansiyanDirektIscilik { get; set; }

    [Column("umd_gerceklesen_genel_uretim")]
    public double? UmdGerceklesenGenelUretim { get; set; }

    [Column("umd_urune_yansiyan_genel_uretim")]
    public double? UmdUruneYansiyanGenelUretim { get; set; }
}
