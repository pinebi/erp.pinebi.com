using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kullanici_aksiyonlari")]
public class KullaniciAksiyonlari
{
    [Column("UsrAct_Guid")]
    public Guid? UsrActGuid { get; set; }

    [Column("UsrAct_DBCno")]
    public short? UsrActDBCno { get; set; }

    [Column("UsrAct_SpecRECno")]
    public int? UsrActSpecRECno { get; set; }

    [Column("UsrAct_iptal")]
    public bool? UsrActIptal { get; set; }

    [Column("UsrAct_fileid")]
    public short? UsrActFileid { get; set; }

    [Column("UsrAct_hidden")]
    public bool? UsrActHidden { get; set; }

    [Column("UsrAct_kilitli")]
    public bool? UsrActKilitli { get; set; }

    [Column("UsrAct_degisti")]
    public bool? UsrActDegisti { get; set; }

    [Column("UsrAct_checksum")]
    public int? UsrActChecksum { get; set; }

    [Column("UsrAct_create_user")]
    public short? UsrActCreateUser { get; set; }

    [Column("UsrAct_create_date")]
    public DateTime? UsrActCreateDate { get; set; }

    [Column("UsrAct_lastup_user")]
    public short? UsrActLastupUser { get; set; }

    [Column("UsrAct_lastup_date")]
    public DateTime? UsrActLastupDate { get; set; }

    [Column("UsrAct_special1")]
    [StringLength(4)]
    public string? UsrActSpecial1 { get; set; }

    [Column("UsrAct_special2")]
    [StringLength(4)]
    public string? UsrActSpecial2 { get; set; }

    [Column("UsrAct_special3")]
    [StringLength(4)]
    public string? UsrActSpecial3 { get; set; }

    [Column("UsrAct_no")]
    public int? UsrActNo { get; set; }

    [Column("UsrAct_login_date")]
    public DateTime? UsrActLoginDate { get; set; }

    [Column("UsrAct_DBase")]
    [StringLength(25)]
    public string? UsrActDBase { get; set; }

    [Column("UsrAct_year")]
    public short? UsrActYear { get; set; }

    [Column("UsrAct_IP")]
    [StringLength(15)]
    public string? UsrActIP { get; set; }

    [Column("UsrAct_PC")]
    [StringLength(15)]
    public string? UsrActPC { get; set; }

    [Column("UsrAct_Domain")]
    [StringLength(15)]
    public string? UsrActDomain { get; set; }

    [Column("UsrAct_logout_date")]
    public DateTime? UsrActLogoutDate { get; set; }

    [Column("UsrAct_Keys")]
    public short? UsrActKeys { get; set; }

    [Column("UsrAct_RecInsert")]
    public short? UsrActRecInsert { get; set; }

    [Column("UsrAct_RecDelete")]
    public short? UsrActRecDelete { get; set; }

    [Column("UsrAct_RecUpdate")]
    public short? UsrActRecUpdate { get; set; }

    [Column("UsrAct_VchrNew")]
    public short? UsrActVchrNew { get; set; }

    [Column("UsrAct_VchrDelete")]
    public short? UsrActVchrDelete { get; set; }

    [Column("UsrAct_VchrUpdate")]
    public short? UsrActVchrUpdate { get; set; }

    [Column("UsrAct_IdleTime")]
    public int? UsrActIdleTime { get; set; }

    [Column("UsrAct_NoOfMenus")]
    public short? UsrActNoOfMenus { get; set; }

    [Column("UsrAct_NoOfReports")]
    public short? UsrActNoOfReports { get; set; }

    [Column("UsrAct_NoOfMacros")]
    public short? UsrActNoOfMacros { get; set; }

    [Column("UsrAct_Program")]
    [StringLength(15)]
    public string? UsrActProgram { get; set; }
}
