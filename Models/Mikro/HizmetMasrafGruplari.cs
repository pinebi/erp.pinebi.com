using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_masraf_gruplari")]
public class HizmetMasrafGruplari
{
    [Column("hmgrp_Guid")]
    public Guid? HmgrpGuid { get; set; }

    [Column("hmgrp_DBCno")]
    public short? HmgrpDBCno { get; set; }

    [Column("hmgrp_SpecRECno")]
    public int? HmgrpSpecRECno { get; set; }

    [Column("hmgrp_iptal")]
    public bool? HmgrpIptal { get; set; }

    [Column("hmgrp_fileid")]
    public short? HmgrpFileid { get; set; }

    [Column("hmgrp_hidden")]
    public bool? HmgrpHidden { get; set; }

    [Column("hmgrp_kilitli")]
    public bool? HmgrpKilitli { get; set; }

    [Column("hmgrp_degisti")]
    public bool? HmgrpDegisti { get; set; }

    [Column("hmgrp_checksum")]
    public int? HmgrpChecksum { get; set; }

    [Column("hmgrp_create_user")]
    public short? HmgrpCreateUser { get; set; }

    [Column("hmgrp_create_date")]
    public DateTime? HmgrpCreateDate { get; set; }

    [Column("hmgrp_lastup_user")]
    public short? HmgrpLastupUser { get; set; }

    [Column("hmgrp_lastup_date")]
    public DateTime? HmgrpLastupDate { get; set; }

    [Column("hmgrp_special1")]
    [StringLength(4)]
    public string? HmgrpSpecial1 { get; set; }

    [Column("hmgrp_special2")]
    [StringLength(4)]
    public string? HmgrpSpecial2 { get; set; }

    [Column("hmgrp_special3")]
    [StringLength(4)]
    public string? HmgrpSpecial3 { get; set; }

    [Column("hmgrp_kod")]
    [StringLength(25)]
    public string? HmgrpKod { get; set; }

    [Column("hmgrp_ismi")]
    [StringLength(40)]
    public string? HmgrpIsmi { get; set; }
}
