using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmkapi_hareketleri")]
public class AvmkapiHareketleri
{
    [Column("kapih_Guid")]
    public Guid? KapihGuid { get; set; }

    [Column("kapih_DBCno")]
    public short? KapihDBCno { get; set; }

    [Column("kapih_Spec_Rec_no")]
    public int? KapihSpecRecNo { get; set; }

    [Column("kapih_iptal")]
    public bool? KapihIptal { get; set; }

    [Column("kapih_fileid")]
    public short? KapihFileid { get; set; }

    [Column("kapih_hidden")]
    public bool? KapihHidden { get; set; }

    [Column("kapih_kilitli")]
    public bool? KapihKilitli { get; set; }

    [Column("kapih_degisti")]
    public bool? KapihDegisti { get; set; }

    [Column("kapih_checksum")]
    public int? KapihChecksum { get; set; }

    [Column("kapih_create_user")]
    public short? KapihCreateUser { get; set; }

    [Column("kapih_create_date")]
    public DateTime? KapihCreateDate { get; set; }

    [Column("kapih_lastup_user")]
    public short? KapihLastupUser { get; set; }

    [Column("kapih_lastup_date")]
    public DateTime? KapihLastupDate { get; set; }

    [Column("kapih_special1")]
    [StringLength(4)]
    public string? KapihSpecial1 { get; set; }

    [Column("kapih_special2")]
    [StringLength(4)]
    public string? KapihSpecial2 { get; set; }

    [Column("kapih_special3")]
    [StringLength(4)]
    public string? KapihSpecial3 { get; set; }

    [Column("kapih_firmano")]
    public int? KapihFirmano { get; set; }

    [Column("kapih_subeno")]
    public int? KapihSubeno { get; set; }

    [Column("kapih_kapikodu")]
    [StringLength(25)]
    public string? KapihKapikodu { get; set; }

    [Column("kapih_tarih")]
    public DateTime? KapihTarih { get; set; }

    [Column("kapih_ziyaretci_sayisi")]
    public int? KapihZiyaretciSayisi { get; set; }
}
