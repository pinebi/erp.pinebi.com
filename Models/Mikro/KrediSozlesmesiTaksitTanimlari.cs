using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kredi_sozlesmesi_taksit_tanimlari")]
public class KrediSozlesmesiTaksitTanimlari
{
    [Column("krsoztaksit_Guid")]
    public Guid? KrsoztaksitGuid { get; set; }

    [Column("krsoztaksit_DBCno")]
    public short? KrsoztaksitDBCno { get; set; }

    [Column("krsoztaksit_Spec_Rec_no")]
    public int? KrsoztaksitSpecRecNo { get; set; }

    [Column("krsoztaksit_iptal")]
    public bool? KrsoztaksitIptal { get; set; }

    [Column("krsoztaksit_fileid")]
    public short? KrsoztaksitFileid { get; set; }

    [Column("krsoztaksit_hidden")]
    public bool? KrsoztaksitHidden { get; set; }

    [Column("krsoztaksit_kilitli")]
    public bool? KrsoztaksitKilitli { get; set; }

    [Column("krsoztaksit_degisti")]
    public bool? KrsoztaksitDegisti { get; set; }

    [Column("krsoztaksit_checksum")]
    public int? KrsoztaksitChecksum { get; set; }

    [Column("krsoztaksit_create_user")]
    public short? KrsoztaksitCreateUser { get; set; }

    [Column("krsoztaksit_create_date")]
    public DateTime? KrsoztaksitCreateDate { get; set; }

    [Column("krsoztaksit_lastup_user")]
    public short? KrsoztaksitLastupUser { get; set; }

    [Column("krsoztaksit_lastup_date")]
    public DateTime? KrsoztaksitLastupDate { get; set; }

    [Column("krsoztaksit_special1")]
    [StringLength(4)]
    public string? KrsoztaksitSpecial1 { get; set; }

    [Column("krsoztaksit_special2")]
    [StringLength(4)]
    public string? KrsoztaksitSpecial2 { get; set; }

    [Column("krsoztaksit_special3")]
    [StringLength(4)]
    public string? KrsoztaksitSpecial3 { get; set; }

    [Column("krsoztaksit_sozkodu")]
    [StringLength(25)]
    public string? KrsoztaksitSozkodu { get; set; }

    [Column("krsoztaksit_taksitno")]
    public short? KrsoztaksitTaksitno { get; set; }

    [Column("krsoztaksit_vade")]
    public DateTime? KrsoztaksitVade { get; set; }

    [Column("krsoztaksit_taksit")]
    public double? KrsoztaksitTaksit { get; set; }

    [Column("krsoztaksit_anapara")]
    public double? KrsoztaksitAnapara { get; set; }

    [Column("krsoztaksit_faizorani")]
    public double? KrsoztaksitFaizorani { get; set; }

    [Column("krsoztaksit_faiz")]
    public double? KrsoztaksitFaiz { get; set; }

    [Column("krsoztaksit_bsmv")]
    public double? KrsoztaksitBsmv { get; set; }

    [Column("krsoztaksit_kkdf")]
    public double? KrsoztaksitKkdf { get; set; }

    [Column("krsoztaksit_kalananapara")]
    public double? KrsoztaksitKalananapara { get; set; }

    [Column("krsoztaksit_gunlukerkenodemeind")]
    public double? KrsoztaksitGunlukerkenodemeind { get; set; }

    [Column("krsoztaksit_odemeevrakseri")]
    [StringLength(50)]
    public string? KrsoztaksitOdemeevrakseri { get; set; }

    [Column("krsoztaksit_odemeevraksira")]
    public int? KrsoztaksitOdemeevraksira { get; set; }

    [Column("krsoztaksit_odenen_ana")]
    public double? KrsoztaksitOdenenAna { get; set; }

    [Column("krsoztaksit_odenen_alt")]
    public double? KrsoztaksitOdenenAlt { get; set; }

    [Column("krsoztaksit_odenen_orj")]
    public double? KrsoztaksitOdenenOrj { get; set; }
}
