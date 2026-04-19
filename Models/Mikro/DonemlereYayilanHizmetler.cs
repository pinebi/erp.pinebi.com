using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("donemlere_yayilan_hizmetler")]
public class DonemlereYayilanHizmetler
{
    [Column("dyh_Guid")]
    public Guid? DyhGuid { get; set; }

    [Column("dyh_DBCno")]
    public short? DyhDBCno { get; set; }

    [Column("dyh_Spec_Rec_no")]
    public int? DyhSpecRecNo { get; set; }

    [Column("dyh_iptal")]
    public bool? DyhIptal { get; set; }

    [Column("dyh_fileid")]
    public short? DyhFileid { get; set; }

    [Column("dyh_hidden")]
    public bool? DyhHidden { get; set; }

    [Column("dyh_kilitli")]
    public bool? DyhKilitli { get; set; }

    [Column("dyh_degisti")]
    public bool? DyhDegisti { get; set; }

    [Column("dyh_checksum")]
    public int? DyhChecksum { get; set; }

    [Column("dyh_create_user")]
    public short? DyhCreateUser { get; set; }

    [Column("dyh_create_date")]
    public DateTime? DyhCreateDate { get; set; }

    [Column("dyh_lastup_user")]
    public short? DyhLastupUser { get; set; }

    [Column("dyh_lastup_date")]
    public DateTime? DyhLastupDate { get; set; }

    [Column("dyh_special1")]
    [StringLength(4)]
    public string? DyhSpecial1 { get; set; }

    [Column("dyh_special2")]
    [StringLength(4)]
    public string? DyhSpecial2 { get; set; }

    [Column("dyh_special3")]
    [StringLength(4)]
    public string? DyhSpecial3 { get; set; }

    [Column("dyh_kodu")]
    [StringLength(25)]
    public string? DyhKodu { get; set; }

    [Column("dyh_ismi")]
    [StringLength(50)]
    public string? DyhIsmi { get; set; }

    [Column("dyh_aciklama")]
    [StringLength(50)]
    public string? DyhAciklama { get; set; }

    [Column("dyh_tipi")]
    public byte? DyhTipi { get; set; }

    [Column("dyh_firmano")]
    public int? DyhFirmano { get; set; }

    [Column("dyh_subeno")]
    public int? DyhSubeno { get; set; }

    [Column("dyh_tipkod")]
    [StringLength(25)]
    public string? DyhTipkod { get; set; }

    [Column("dyh_sinifkod")]
    [StringLength(25)]
    public string? DyhSinifkod { get; set; }

    [Column("dyh_grupkod")]
    [StringLength(25)]
    public string? DyhGrupkod { get; set; }

    [Column("dyh_carikodu")]
    [StringLength(25)]
    public string? DyhCarikodu { get; set; }

    [Column("dyh_belgeno")]
    [StringLength(30)]
    public string? DyhBelgeno { get; set; }

    [Column("dyh_baslangictarihi")]
    public DateTime? DyhBaslangictarihi { get; set; }

    [Column("dyh_bitistarihi")]
    public DateTime? DyhBitistarihi { get; set; }

    [Column("dyh_dovizcinsi")]
    public byte? DyhDovizcinsi { get; set; }

    [Column("dyh_tutari")]
    public double? DyhTutari { get; set; }

    [Column("dyh_kdvpntr")]
    public byte? DyhKdvpntr { get; set; }

    [Column("dyh_stopajfonpntr")]
    public byte? DyhStopajfonpntr { get; set; }

    [Column("dyh_muhkod1")]
    [StringLength(40)]
    public string? DyhMuhkod1 { get; set; }

    [Column("dyh_muhkod2")]
    [StringLength(40)]
    public string? DyhMuhkod2 { get; set; }

    [Column("dyh_hizmetmasrafkodu")]
    [StringLength(25)]
    public string? DyhHizmetmasrafkodu { get; set; }

    [Column("dyh_dagitimanahtarkodu")]
    [StringLength(25)]
    public string? DyhDagitimanahtarkodu { get; set; }

    [Column("dyh_ufrs_tutari")]
    public double? DyhUfrsTutari { get; set; }

    [Column("dyh_ufrs_fark_muhkod1")]
    [StringLength(40)]
    public string? DyhUfrsFarkMuhkod1 { get; set; }

    [Column("dyh_ufrs_fark_muhkod2")]
    [StringLength(40)]
    public string? DyhUfrsFarkMuhkod2 { get; set; }

    [Column("dyh_projekodu")]
    [StringLength(25)]
    public string? DyhProjekodu { get; set; }

    [Column("dyh_srmmrkkodu")]
    [StringLength(25)]
    public string? DyhSrmmrkkodu { get; set; }

    [Column("dyh_hesaplamatipi")]
    public byte? DyhHesaplamatipi { get; set; }
}
