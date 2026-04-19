using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("finansal_sozlesmeler")]
public class FinansalSozlesmeler
{
    [Column("FS_Guid")]
    public Guid? FSGuid { get; set; }

    [Column("FS_DBCno")]
    public short? FSDBCno { get; set; }

    [Column("FS_Spec_Rec_no")]
    public int? FSSpecRecNo { get; set; }

    [Column("FS_iptal")]
    public bool? FSIptal { get; set; }

    [Column("FS_fileid")]
    public short? FSFileid { get; set; }

    [Column("FS_hidden")]
    public bool? FSHidden { get; set; }

    [Column("FS_kilitli")]
    public bool? FSKilitli { get; set; }

    [Column("FS_degisti")]
    public bool? FSDegisti { get; set; }

    [Column("FS_checksum")]
    public int? FSChecksum { get; set; }

    [Column("FS_create_user")]
    public short? FSCreateUser { get; set; }

    [Column("FS_create_date")]
    public DateTime? FSCreateDate { get; set; }

    [Column("FS_lastup_user")]
    public short? FSLastupUser { get; set; }

    [Column("FS_lastup_date")]
    public DateTime? FSLastupDate { get; set; }

    [Column("FS_special1")]
    [StringLength(4)]
    public string? FSSpecial1 { get; set; }

    [Column("FS_special2")]
    [StringLength(4)]
    public string? FSSpecial2 { get; set; }

    [Column("FS_special3")]
    [StringLength(4)]
    public string? FSSpecial3 { get; set; }

    [Column("FS_firmano")]
    public int? FSFirmano { get; set; }

    [Column("FS_subeno")]
    public int? FSSubeno { get; set; }

    [Column("FS_sozkodu")]
    [StringLength(25)]
    public string? FSSozkodu { get; set; }

    [Column("FS_sozaciklama")]
    [StringLength(50)]
    public string? FSSozaciklama { get; set; }

    [Column("FS_KVertfingidkodu")]
    [StringLength(40)]
    public string? FSKVertfingidkodu { get; set; }

    [Column("FS_UVertfingidkodu")]
    [StringLength(40)]
    public string? FSUVertfingidkodu { get; set; }

    [Column("FS_finasmangidkodu")]
    [StringLength(40)]
    public string? FSFinasmangidkodu { get; set; }

    [Column("FS_KVfinkiraborckodu")]
    [StringLength(40)]
    public string? FSKVfinkiraborckodu { get; set; }

    [Column("FS_UVfinkiraborckodu")]
    [StringLength(40)]
    public string? FSUVfinkiraborckodu { get; set; }

    [Column("FS_TaksitSayisi")]
    public short? FSTaksitSayisi { get; set; }

    [Column("FS_dovizcinsi")]
    public byte? FSDovizcinsi { get; set; }
}
