using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_plan_matrisi_detay")]
public class UretimPlanMatrisiDetay
{
    [Column("upmd_Guid")]
    public Guid? UpmdGuid { get; set; }

    [Column("upmd_DBCno")]
    public short? UpmdDBCno { get; set; }

    [Column("upmd_SpecRECno")]
    public int? UpmdSpecRECno { get; set; }

    [Column("upmd_iptal")]
    public bool? UpmdIptal { get; set; }

    [Column("upmd_fileid")]
    public short? UpmdFileid { get; set; }

    [Column("upmd_hidden")]
    public bool? UpmdHidden { get; set; }

    [Column("upmd_kilitli")]
    public bool? UpmdKilitli { get; set; }

    [Column("upmd_degisti")]
    public bool? UpmdDegisti { get; set; }

    [Column("upmd_checksum")]
    public int? UpmdChecksum { get; set; }

    [Column("upmd_create_user")]
    public short? UpmdCreateUser { get; set; }

    [Column("upmd_create_date")]
    public DateTime? UpmdCreateDate { get; set; }

    [Column("upmd_lastup_user")]
    public short? UpmdLastupUser { get; set; }

    [Column("upmd_lastup_date")]
    public DateTime? UpmdLastupDate { get; set; }

    [Column("upmd_special1")]
    [StringLength(4)]
    public string? UpmdSpecial1 { get; set; }

    [Column("upmd_special2")]
    [StringLength(4)]
    public string? UpmdSpecial2 { get; set; }

    [Column("upmd_special3")]
    [StringLength(4)]
    public string? UpmdSpecial3 { get; set; }

    [Column("upmd_matriskodu")]
    [StringLength(25)]
    public string? UpmdMatriskodu { get; set; }

    [Column("upmd_stokkodu")]
    [StringLength(25)]
    public string? UpmdStokkodu { get; set; }

    [Column("upmd_donemno")]
    public byte? UpmdDonemno { get; set; }

    [Column("upmd_miktar")]
    public double? UpmdMiktar { get; set; }
}
