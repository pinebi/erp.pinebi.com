using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("program_loglari")]
public class ProgramLoglari
{
    [Column("log_Guid")]
    public Guid? LogGuid { get; set; }

    [Column("log_DBCno")]
    public short? LogDBCno { get; set; }

    [Column("log_SpecRECno")]
    public int? LogSpecRECno { get; set; }

    [Column("log_iptal")]
    public bool? LogIptal { get; set; }

    [Column("log_fileid")]
    public short? LogFileid { get; set; }

    [Column("log_hidden")]
    public bool? LogHidden { get; set; }

    [Column("log_kilitli")]
    public bool? LogKilitli { get; set; }

    [Column("log_degisti")]
    public bool? LogDegisti { get; set; }

    [Column("log_checksum")]
    public int? LogChecksum { get; set; }

    [Column("log_create_user")]
    public short? LogCreateUser { get; set; }

    [Column("log_create_date")]
    public DateTime? LogCreateDate { get; set; }

    [Column("log_lastup_user")]
    public short? LogLastupUser { get; set; }

    [Column("log_lastup_date")]
    public DateTime? LogLastupDate { get; set; }

    [Column("log_special1")]
    [StringLength(4)]
    public string? LogSpecial1 { get; set; }

    [Column("log_special2")]
    [StringLength(4)]
    public string? LogSpecial2 { get; set; }

    [Column("log_special3")]
    [StringLength(4)]
    public string? LogSpecial3 { get; set; }

    [Column("log_type")]
    public byte? LogType { get; set; }

    [Column("log_firmano")]
    public int? LogFirmano { get; set; }

    [Column("log_subeno")]
    public int? LogSubeno { get; set; }

    [Column("log_tarihi")]
    public DateTime? LogTarihi { get; set; }

    [Column("log_user")]
    public int? LogUser { get; set; }

    [Column("log_prgno")]
    public short? LogPrgno { get; set; }

    [Column("log_menuno")]
    public int? LogMenuno { get; set; }

    [Column("log_aciklama")]
    [StringLength(127)]
    public string? LogAciklama { get; set; }
}
