using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_kod_alternatifleri")]
public class StokKodAlternatifleri
{
    [Column("sak_Guid")]
    public Guid? SakGuid { get; set; }

    [Column("sak_DBCno")]
    public short? SakDBCno { get; set; }

    [Column("sak_SpecRECno")]
    public int? SakSpecRECno { get; set; }

    [Column("sak_iptal")]
    public bool? SakIptal { get; set; }

    [Column("sak_fileid")]
    public short? SakFileid { get; set; }

    [Column("sak_hidden")]
    public bool? SakHidden { get; set; }

    [Column("sak_kilitli")]
    public bool? SakKilitli { get; set; }

    [Column("sak_degisti")]
    public bool? SakDegisti { get; set; }

    [Column("sak_checksum")]
    public int? SakChecksum { get; set; }

    [Column("sak_create_user")]
    public short? SakCreateUser { get; set; }

    [Column("sak_create_date")]
    public DateTime? SakCreateDate { get; set; }

    [Column("sak_lastup_user")]
    public short? SakLastupUser { get; set; }

    [Column("sak_lastup_date")]
    public DateTime? SakLastupDate { get; set; }

    [Column("sak_special1")]
    [StringLength(4)]
    public string? SakSpecial1 { get; set; }

    [Column("sak_special2")]
    [StringLength(4)]
    public string? SakSpecial2 { get; set; }

    [Column("sak_special3")]
    [StringLength(4)]
    public string? SakSpecial3 { get; set; }

    [Column("sak_altgrupno")]
    public short? SakAltgrupno { get; set; }

    [Column("sak_altalanno")]
    public short? SakAltalanno { get; set; }

    [Column("sak_altkodu")]
    [StringLength(25)]
    public string? SakAltkodu { get; set; }

    [Column("sak_altaciklama")]
    [StringLength(50)]
    public string? SakAltaciklama { get; set; }
}
