using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hatirlatmalar")]
public class Hatirlatmalar
{
    [Column("remind_Guid")]
    public Guid? RemindGuid { get; set; }

    [Column("remind_DBCno")]
    public short? RemindDBCno { get; set; }

    [Column("remind_SpecRECno")]
    public int? RemindSpecRECno { get; set; }

    [Column("remind_iptal")]
    public bool? RemindIptal { get; set; }

    [Column("remind_fileid")]
    public short? RemindFileid { get; set; }

    [Column("remind_hidden")]
    public bool? RemindHidden { get; set; }

    [Column("remind_kilitli")]
    public bool? RemindKilitli { get; set; }

    [Column("remind_degisti")]
    public bool? RemindDegisti { get; set; }

    [Column("remind_checksum")]
    public int? RemindChecksum { get; set; }

    [Column("remind_create_user")]
    public short? RemindCreateUser { get; set; }

    [Column("remind_create_date")]
    public DateTime? RemindCreateDate { get; set; }

    [Column("remind_lastup_user")]
    public short? RemindLastupUser { get; set; }

    [Column("remind_lastup_date")]
    public DateTime? RemindLastupDate { get; set; }

    [Column("remind_special1")]
    [StringLength(4)]
    public string? RemindSpecial1 { get; set; }

    [Column("remind_special2")]
    [StringLength(4)]
    public string? RemindSpecial2 { get; set; }

    [Column("remind_special3")]
    [StringLength(4)]
    public string? RemindSpecial3 { get; set; }

    [Column("remind_name")]
    [StringLength(40)]
    public string? RemindName { get; set; }

    [Column("remind_type")]
    public byte? RemindType { get; set; }

    [Column("remind_time")]
    public int? RemindTime { get; set; }

    [Column("remind_date")]
    public int? RemindDate { get; set; }

    [Column("remind_every")]
    public short? RemindEvery { get; set; }

    [Column("remind_note")]
    [StringLength(80)]
    public string? RemindNote { get; set; }

    [Column("remind_user")]
    public short? RemindUser { get; set; }

    [Column("remind_done")]
    public DateTime? RemindDone { get; set; }

    [Column("remind_makro")]
    [StringLength(80)]
    public string? RemindMakro { get; set; }

    [Column("remind_note1")]
    [StringLength(80)]
    public string? RemindNote1 { get; set; }

    [Column("remind_note2")]
    [StringLength(80)]
    public string? RemindNote2 { get; set; }
}
