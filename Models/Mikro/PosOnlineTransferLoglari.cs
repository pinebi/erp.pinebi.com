using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("pos_online_transfer_loglari")]
public class PosOnlineTransferLoglari
{
    [Column("potl_Guid")]
    public Guid? PotlGuid { get; set; }

    [Column("potl_DBCno")]
    public short? PotlDBCno { get; set; }

    [Column("potl_Spec_Rec_no")]
    public int? PotlSpecRecNo { get; set; }

    [Column("potl_iptal")]
    public bool? PotlIptal { get; set; }

    [Column("potl_fileid")]
    public short? PotlFileid { get; set; }

    [Column("potl_hidden")]
    public bool? PotlHidden { get; set; }

    [Column("potl_kilitli")]
    public bool? PotlKilitli { get; set; }

    [Column("potl_degisti")]
    public bool? PotlDegisti { get; set; }

    [Column("potl_checksum")]
    public int? PotlChecksum { get; set; }

    [Column("potl_create_user")]
    public short? PotlCreateUser { get; set; }

    [Column("potl_create_date")]
    public DateTime? PotlCreateDate { get; set; }

    [Column("potl_lastup_user")]
    public short? PotlLastupUser { get; set; }

    [Column("potl_lastup_date")]
    public DateTime? PotlLastupDate { get; set; }

    [Column("potl_special1")]
    [StringLength(4)]
    public string? PotlSpecial1 { get; set; }

    [Column("potl_special2")]
    [StringLength(4)]
    public string? PotlSpecial2 { get; set; }

    [Column("potl_special3")]
    [StringLength(4)]
    public string? PotlSpecial3 { get; set; }

    [Column("potl_tarih")]
    public DateTime? PotlTarih { get; set; }

    [Column("potl_depo_no")]
    public short? PotlDepoNo { get; set; }

    [Column("potl_normal_iade")]
    public byte? PotlNormalIade { get; set; }

    [Column("potl_son_recno")]
    public int? PotlSonRecno { get; set; }

    [Column("potl_son_efat_recno")]
    public int? PotlSonEfatRecno { get; set; }
}
