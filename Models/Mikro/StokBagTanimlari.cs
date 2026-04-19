using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_bag_tanimlari")]
public class StokBagTanimlari
{
    [Column("bag_Guid")]
    public Guid? BagGuid { get; set; }

    [Column("bag_DBCno")]
    public short? BagDBCno { get; set; }

    [Column("bag_Spec_Rec_no")]
    public int? BagSpecRecNo { get; set; }

    [Column("bag_iptal")]
    public bool? BagIptal { get; set; }

    [Column("bag_fileid")]
    public short? BagFileid { get; set; }

    [Column("bag_hidden")]
    public bool? BagHidden { get; set; }

    [Column("bag_kilitli")]
    public bool? BagKilitli { get; set; }

    [Column("bag_degisti")]
    public bool? BagDegisti { get; set; }

    [Column("bag_checksum")]
    public int? BagChecksum { get; set; }

    [Column("bag_create_user")]
    public short? BagCreateUser { get; set; }

    [Column("bag_create_date")]
    public DateTime? BagCreateDate { get; set; }

    [Column("bag_lastup_user")]
    public short? BagLastupUser { get; set; }

    [Column("bag_lastup_date")]
    public DateTime? BagLastupDate { get; set; }

    [Column("bag_special1")]
    [StringLength(4)]
    public string? BagSpecial1 { get; set; }

    [Column("bag_special2")]
    [StringLength(4)]
    public string? BagSpecial2 { get; set; }

    [Column("bag_special3")]
    [StringLength(4)]
    public string? BagSpecial3 { get; set; }

    [Column("bag_kodu")]
    [StringLength(25)]
    public string? BagKodu { get; set; }

    [Column("bag_stokkodu")]
    [StringLength(25)]
    public string? BagStokkodu { get; set; }

    [Column("bag_partikodu")]
    [StringLength(25)]
    public string? BagPartikodu { get; set; }

    [Column("bag_lotno")]
    public int? BagLotno { get; set; }

    [Column("bag_aciklama1")]
    [StringLength(80)]
    public string? BagAciklama1 { get; set; }

    [Column("bag_aciklama2")]
    [StringLength(80)]
    public string? BagAciklama2 { get; set; }

    [Column("bag_miktar")]
    public double? BagMiktar { get; set; }

    [Column("bag_miktar2")]
    public double? BagMiktar2 { get; set; }

    [Column("bag_Har_uid")]
    public Guid? BagHarUid { get; set; }
}
