using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_nitelik_tanimlari")]
public class PersonelNitelikTanimlari
{
    [Column("nt_Guid")]
    public Guid? NtGuid { get; set; }

    [Column("nt_DBCno")]
    public short? NtDBCno { get; set; }

    [Column("nt_SpecRECno")]
    public int? NtSpecRECno { get; set; }

    [Column("nt_iptal")]
    public bool? NtIptal { get; set; }

    [Column("nt_fileid")]
    public short? NtFileid { get; set; }

    [Column("nt_hidden")]
    public bool? NtHidden { get; set; }

    [Column("nt_kilitli")]
    public bool? NtKilitli { get; set; }

    [Column("nt_degisti")]
    public bool? NtDegisti { get; set; }

    [Column("nt_checksum")]
    public int? NtChecksum { get; set; }

    [Column("nt_create_user")]
    public short? NtCreateUser { get; set; }

    [Column("nt_create_date")]
    public DateTime? NtCreateDate { get; set; }

    [Column("nt_lastup_user")]
    public short? NtLastupUser { get; set; }

    [Column("nt_lastup_date")]
    public DateTime? NtLastupDate { get; set; }

    [Column("nt_special1")]
    [StringLength(4)]
    public string? NtSpecial1 { get; set; }

    [Column("nt_special2")]
    [StringLength(4)]
    public string? NtSpecial2 { get; set; }

    [Column("nt_special3")]
    [StringLength(4)]
    public string? NtSpecial3 { get; set; }

    [Column("nt_kod")]
    [StringLength(25)]
    public string? NtKod { get; set; }

    [Column("nt_aciklama")]
    [StringLength(40)]
    public string? NtAciklama { get; set; }

    [Column("nt_tipi")]
    public byte? NtTipi { get; set; }

    [Column("nt_aktif")]
    public byte? NtAktif { get; set; }

    [Column("nt_maxpuan")]
    public double? NtMaxpuan { get; set; }

    [Column("nt_toplamdakipayi")]
    public double? NtToplamdakipayi { get; set; }

    [Column("nt_sozelpuanlar")]
    [StringLength(127)]
    public string? NtSozelpuanlar { get; set; }
}
