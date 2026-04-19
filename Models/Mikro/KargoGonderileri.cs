using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kargo_gonderileri")]
public class KargoGonderileri
{
    [Column("kargo_Guid")]
    public Guid? KargoGuid { get; set; }

    [Column("kargo_DBCno")]
    public short? KargoDBCno { get; set; }

    [Column("kargo_Spec_Rec_no")]
    public int? KargoSpecRecNo { get; set; }

    [Column("kargo_iptal")]
    public bool? KargoIptal { get; set; }

    [Column("kargo_fileid")]
    public short? KargoFileid { get; set; }

    [Column("kargo_hidden")]
    public bool? KargoHidden { get; set; }

    [Column("kargo_kilitli")]
    public bool? KargoKilitli { get; set; }

    [Column("kargo_degisti")]
    public bool? KargoDegisti { get; set; }

    [Column("kargo_checksum")]
    public int? KargoChecksum { get; set; }

    [Column("kargo_create_user")]
    public short? KargoCreateUser { get; set; }

    [Column("kargo_create_date")]
    public DateTime? KargoCreateDate { get; set; }

    [Column("kargo_lastup_user")]
    public short? KargoLastupUser { get; set; }

    [Column("kargo_lastup_date")]
    public DateTime? KargoLastupDate { get; set; }

    [Column("kargo_special1")]
    [StringLength(4)]
    public string? KargoSpecial1 { get; set; }

    [Column("kargo_special2")]
    [StringLength(4)]
    public string? KargoSpecial2 { get; set; }

    [Column("kargo_special3")]
    [StringLength(4)]
    public string? KargoSpecial3 { get; set; }

    [Column("kargo_sirkettipi")]
    public byte? KargoSirkettipi { get; set; }

    [Column("kargo_gonderitarihi")]
    public DateTime? KargoGonderitarihi { get; set; }

    [Column("kargo_alicikodu")]
    [StringLength(25)]
    public string? KargoAlicikodu { get; set; }

    [Column("kargo_aliciadresno")]
    public int? KargoAliciadresno { get; set; }

    [Column("kargo_varisdepono")]
    public int? KargoVarisdepono { get; set; }

    [Column("kargo_evraktabloid")]
    public int? KargoEvraktabloid { get; set; }

    [Column("kargo_evraktipi")]
    public byte? KargoEvraktipi { get; set; }

    [Column("kargo_evrakcinsi")]
    public byte? KargoEvrakcinsi { get; set; }

    [Column("kargo_evraknoseri")]
    [StringLength(50)]
    public string? KargoEvraknoseri { get; set; }

    [Column("kargo_evraknosira")]
    public int? KargoEvraknosira { get; set; }

    [Column("kargo_evrakbelgeno")]
    [StringLength(50)]
    public string? KargoEvrakbelgeno { get; set; }

    [Column("kargo_evrakuid")]
    public Guid? KargoEvrakuid { get; set; }

    [Column("kargo_kargoadedi")]
    public double? KargoKargoadedi { get; set; }

    [Column("kargo_evrakbedeli")]
    public double? KargoEvrakbedeli { get; set; }

    [Column("kargo_evrtahsilattipi")]
    public byte? KargoEvrtahsilattipi { get; set; }

    [Column("kargo_ozelalan")]
    [StringLength(50)]
    public string? KargoOzelalan { get; set; }

    [Column("kargo_gonderiakibeti")]
    public byte? KargoGonderiakibeti { get; set; }

    [Column("kargo_gonderitipi")]
    public byte? KargoGonderitipi { get; set; }

    [Column("kargo_gonderiyikimodeyecek")]
    public byte? KargoGonderiyikimodeyecek { get; set; }

    [Column("kargo_mastergonderino")]
    public Guid? KargoMastergonderino { get; set; }
}
