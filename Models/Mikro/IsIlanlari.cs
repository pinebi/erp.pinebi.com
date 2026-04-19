using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("is_ilanlari")]
public class IsIlanlari
{
    [Column("iln_Guid")]
    public Guid? IlnGuid { get; set; }

    [Column("iln_DBCno")]
    public short? IlnDBCno { get; set; }

    [Column("iln_SpecRECno")]
    public int? IlnSpecRECno { get; set; }

    [Column("iln_iptal")]
    public bool? IlnIptal { get; set; }

    [Column("iln_fileid")]
    public short? IlnFileid { get; set; }

    [Column("iln_hidden")]
    public bool? IlnHidden { get; set; }

    [Column("iln_kilitli")]
    public bool? IlnKilitli { get; set; }

    [Column("iln_degisti")]
    public bool? IlnDegisti { get; set; }

    [Column("iln_checksum")]
    public int? IlnChecksum { get; set; }

    [Column("iln_create_user")]
    public short? IlnCreateUser { get; set; }

    [Column("iln_create_date")]
    public DateTime? IlnCreateDate { get; set; }

    [Column("iln_lastup_user")]
    public short? IlnLastupUser { get; set; }

    [Column("iln_lastup_date")]
    public DateTime? IlnLastupDate { get; set; }

    [Column("iln_special1")]
    [StringLength(4)]
    public string? IlnSpecial1 { get; set; }

    [Column("iln_special2")]
    [StringLength(4)]
    public string? IlnSpecial2 { get; set; }

    [Column("iln_special3")]
    [StringLength(4)]
    public string? IlnSpecial3 { get; set; }

    [Column("iln_kodu")]
    [StringLength(25)]
    public string? IlnKodu { get; set; }

    [Column("iln_aciklama")]
    [StringLength(50)]
    public string? IlnAciklama { get; set; }

    [Column("iln_tecrube")]
    public short? IlnTecrube { get; set; }

    [Column("iln_cinsiyet")]
    public byte? IlnCinsiyet { get; set; }

    [Column("iln_net_ucret")]
    public double? IlnNetUcret { get; set; }

    [Column("iln_doviz_cinsi")]
    public byte? IlnDovizCinsi { get; set; }

    [Column("iln_ilk_tarih")]
    public DateTime? IlnIlkTarih { get; set; }

    [Column("iln_son_tarih")]
    public DateTime? IlnSonTarih { get; set; }

    [Column("iln_kisi_sayisi")]
    public short? IlnKisiSayisi { get; set; }
}
