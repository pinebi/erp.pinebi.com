using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("sayim_sonuclari")]
public class SayimSonuclari
{
    [Column("sym_Guid")]
    public Guid? SymGuid { get; set; }

    [Column("sym_DBCno")]
    public short? SymDBCno { get; set; }

    [Column("sym_SpecRECno")]
    public int? SymSpecRECno { get; set; }

    [Column("sym_iptal")]
    public bool? SymIptal { get; set; }

    [Column("sym_fileid")]
    public short? SymFileid { get; set; }

    [Column("sym_hidden")]
    public bool? SymHidden { get; set; }

    [Column("sym_kilitli")]
    public bool? SymKilitli { get; set; }

    [Column("sym_degisti")]
    public bool? SymDegisti { get; set; }

    [Column("sym_checksum")]
    public int? SymChecksum { get; set; }

    [Column("sym_create_user")]
    public short? SymCreateUser { get; set; }

    [Column("sym_create_date")]
    public DateTime? SymCreateDate { get; set; }

    [Column("sym_lastup_user")]
    public short? SymLastupUser { get; set; }

    [Column("sym_lastup_date")]
    public DateTime? SymLastupDate { get; set; }

    [Column("sym_special1")]
    [StringLength(4)]
    public string? SymSpecial1 { get; set; }

    [Column("sym_special2")]
    [StringLength(4)]
    public string? SymSpecial2 { get; set; }

    [Column("sym_special3")]
    [StringLength(4)]
    public string? SymSpecial3 { get; set; }

    [Column("sym_tarihi")]
    public DateTime? SymTarihi { get; set; }

    [Column("sym_depono")]
    public int? SymDepono { get; set; }

    [Column("sym_evrakno")]
    public int? SymEvrakno { get; set; }

    [Column("sym_satirno")]
    public int? SymSatirno { get; set; }

    [Column("sym_Stokkodu")]
    [StringLength(25)]
    public string? SymStokkodu { get; set; }

    [Column("sym_reyonkodu")]
    [StringLength(4)]
    public string? SymReyonkodu { get; set; }

    [Column("sym_koridorkodu")]
    [StringLength(4)]
    public string? SymKoridorkodu { get; set; }

    [Column("sym_rafkodu")]
    [StringLength(4)]
    public string? SymRafkodu { get; set; }

    [Column("sym_miktar1")]
    public double? SymMiktar1 { get; set; }

    [Column("sym_miktar2")]
    public double? SymMiktar2 { get; set; }

    [Column("sym_miktar3")]
    public double? SymMiktar3 { get; set; }

    [Column("sym_miktar4")]
    public double? SymMiktar4 { get; set; }

    [Column("sym_miktar5")]
    public double? SymMiktar5 { get; set; }

    [Column("sym_birim_pntr")]
    public byte? SymBirimPntr { get; set; }

    [Column("sym_barkod")]
    [StringLength(50)]
    public string? SymBarkod { get; set; }

    [Column("sym_renkno")]
    public int? SymRenkno { get; set; }

    [Column("sym_bedenno")]
    public int? SymBedenno { get; set; }

    [Column("sym_parti_kodu")]
    [StringLength(25)]
    public string? SymPartiKodu { get; set; }

    [Column("sym_lot_no")]
    public int? SymLotNo { get; set; }

    [Column("sym_serino")]
    [StringLength(25)]
    public string? SymSerino { get; set; }
}
