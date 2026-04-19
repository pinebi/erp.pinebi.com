using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("nakit_akis_tablosu")]
public class NakitAkisTablosu
{
    [Column("Nakak_Guid")]
    public Guid? NakakGuid { get; set; }

    [Column("Nakak_DBCno")]
    public short? NakakDBCno { get; set; }

    [Column("Nakak_SpecRECNo")]
    public int? NakakSpecRECNo { get; set; }

    [Column("Nakak_iptal")]
    public bool? NakakIptal { get; set; }

    [Column("Nakak_fileid")]
    public short? NakakFileid { get; set; }

    [Column("Nakak_hidden")]
    public bool? NakakHidden { get; set; }

    [Column("Nakak_kilitli")]
    public bool? NakakKilitli { get; set; }

    [Column("Nakak_degisti")]
    public bool? NakakDegisti { get; set; }

    [Column("Nakak_checksum")]
    public int? NakakChecksum { get; set; }

    [Column("Nakak_create_user")]
    public short? NakakCreateUser { get; set; }

    [Column("Nakak_create_date")]
    public DateTime? NakakCreateDate { get; set; }

    [Column("Nakak_lastup_user")]
    public short? NakakLastupUser { get; set; }

    [Column("Nakak_lastup_date")]
    public DateTime? NakakLastupDate { get; set; }

    [Column("Nakak_special1")]
    [StringLength(4)]
    public string? NakakSpecial1 { get; set; }

    [Column("Nakak_special2")]
    [StringLength(4)]
    public string? NakakSpecial2 { get; set; }

    [Column("Nakak_special3")]
    [StringLength(4)]
    public string? NakakSpecial3 { get; set; }

    [Column("Nakak_naveritabani")]
    [StringLength(25)]
    public string? NakakNaveritabani { get; set; }

    [Column("Nakak_nafirmano")]
    public int? NakakNafirmano { get; set; }

    [Column("Nakak_navade")]
    public int? NakakNavade { get; set; }

    [Column("Nakak_natip")]
    public byte? NakakNatip { get; set; }

    [Column("Nakak_naref")]
    [StringLength(25)]
    public string? NakakNaref { get; set; }

    [Column("Nakak_naaciklama")]
    [StringLength(120)]
    public string? NakakNaaciklama { get; set; }

    [Column("Nakak_natutar")]
    public double? NakakNatutar { get; set; }

    [Column("Nakak_naAltDovTutar")]
    public double? NakakNaAltDovTutar { get; set; }

    [Column("Nakak_naOrjDovTutar")]
    public double? NakakNaOrjDovTutar { get; set; }

    [Column("Nakak_nacaricins")]
    public byte? NakakNacaricins { get; set; }

    [Column("Nakak_nakod")]
    [StringLength(25)]
    public string? NakakNakod { get; set; }

    [Column("Nakak_naisim")]
    [StringLength(30)]
    public string? NakakNaisim { get; set; }

    [Column("Nakak_naOrjDovCinsi")]
    public byte? NakakNaOrjDovCinsi { get; set; }

    [Column("Nakak_proje")]
    [StringLength(25)]
    public string? NakakProje { get; set; }

    [Column("Nakak_srmmrk")]
    [StringLength(25)]
    public string? NakakSrmmrk { get; set; }
}
