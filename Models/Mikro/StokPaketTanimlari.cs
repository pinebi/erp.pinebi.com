using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_paket_tanimlari")]
public class StokPaketTanimlari
{
    [Column("pak_Guid")]
    public Guid? PakGuid { get; set; }

    [Column("pak_DBCno")]
    public short? PakDBCno { get; set; }

    [Column("pak_SpecRECno")]
    public int? PakSpecRECno { get; set; }

    [Column("pak_iptal")]
    public bool? PakIptal { get; set; }

    [Column("pak_fileid")]
    public short? PakFileid { get; set; }

    [Column("pak_hidden")]
    public bool? PakHidden { get; set; }

    [Column("pak_kilitli")]
    public bool? PakKilitli { get; set; }

    [Column("pak_degisti")]
    public bool? PakDegisti { get; set; }

    [Column("pak_checksum")]
    public int? PakChecksum { get; set; }

    [Column("pak_create_user")]
    public short? PakCreateUser { get; set; }

    [Column("pak_create_date")]
    public DateTime? PakCreateDate { get; set; }

    [Column("pak_lastup_user")]
    public short? PakLastupUser { get; set; }

    [Column("pak_lastup_date")]
    public DateTime? PakLastupDate { get; set; }

    [Column("pak_special1")]
    [StringLength(4)]
    public string? PakSpecial1 { get; set; }

    [Column("pak_special2")]
    [StringLength(4)]
    public string? PakSpecial2 { get; set; }

    [Column("pak_special3")]
    [StringLength(4)]
    public string? PakSpecial3 { get; set; }

    [Column("pak_kod")]
    [StringLength(25)]
    public string? PakKod { get; set; }

    [Column("pak_stokkod")]
    [StringLength(25)]
    public string? PakStokkod { get; set; }

    [Column("pak_miktar")]
    public double? PakMiktar { get; set; }

    [Column("pak_aciklama")]
    [StringLength(50)]
    public string? PakAciklama { get; set; }

    [Column("pak_satirno")]
    public int? PakSatirno { get; set; }

    [Column("pak_fiyat")]
    public double? PakFiyat { get; set; }

    [Column("pak_vergidahilfl")]
    public byte? PakVergidahilfl { get; set; }

    [Column("pak_master_tip")]
    public byte? PakMasterTip { get; set; }

    [Column("pak_detay_tip")]
    public byte? PakDetayTip { get; set; }

    [Column("pak_doviz_cins")]
    public byte? PakDovizCins { get; set; }

    [Column("pak_ve_veya")]
    public byte? PakVeVeya { get; set; }

    [Column("pak_ismi")]
    [StringLength(50)]
    public string? PakIsmi { get; set; }
}
