using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isletme_hesap_plani")]
public class IsletmeHesapPlani
{
    [Column("dinm_Guid")]
    public Guid? DinmGuid { get; set; }

    [Column("dinm_DBCno")]
    public short? DinmDBCno { get; set; }

    [Column("dinm_SpecRECno")]
    public int? DinmSpecRECno { get; set; }

    [Column("dinm_iptal")]
    public bool? DinmIptal { get; set; }

    [Column("dinm_fileid")]
    public short? DinmFileid { get; set; }

    [Column("dinm_hidden")]
    public bool? DinmHidden { get; set; }

    [Column("dinm_kilitli")]
    public bool? DinmKilitli { get; set; }

    [Column("dinm_degisti")]
    public bool? DinmDegisti { get; set; }

    [Column("dinm_checksum")]
    public int? DinmChecksum { get; set; }

    [Column("dinm_create_user")]
    public short? DinmCreateUser { get; set; }

    [Column("dinm_create_date")]
    public DateTime? DinmCreateDate { get; set; }

    [Column("dinm_lastup_user")]
    public short? DinmLastupUser { get; set; }

    [Column("dinm_lastup_date")]
    public DateTime? DinmLastupDate { get; set; }

    [Column("dinm_special1")]
    [StringLength(4)]
    public string? DinmSpecial1 { get; set; }

    [Column("dinm_special2")]
    [StringLength(4)]
    public string? DinmSpecial2 { get; set; }

    [Column("dinm_special3")]
    [StringLength(4)]
    public string? DinmSpecial3 { get; set; }

    [Column("dinm_hesap_kod")]
    [StringLength(25)]
    public string? DinmHesapKod { get; set; }

    [Column("dinm_hesap_isim1")]
    [StringLength(40)]
    public string? DinmHesapIsim1 { get; set; }

    [Column("dinm_hesap_isim2")]
    [StringLength(40)]
    public string? DinmHesapIsim2 { get; set; }

    [Column("dinm_doviz_cinsi")]
    public byte? DinmDovizCinsi { get; set; }

    [Column("dinm_kurfarki_fl")]
    public bool? DinmKurfarkiFl { get; set; }

    [Column("dinm_sorum_merk")]
    public byte? DinmSorumMerk { get; set; }

    [Column("dinm_kilittarihi")]
    public DateTime? DinmKilittarihi { get; set; }

    [Column("dinm_hes_dav_bicimi")]
    public byte? DinmHesDavBicimi { get; set; }

    [Column("dinm_Hhtip")]
    public byte? DinmHhtip { get; set; }

    [Column("dinm_HhVtip_fl")]
    public bool? DinmHhVtipFl { get; set; }

    [Column("dinm_HhVergi")]
    public byte? DinmHhVergi { get; set; }

    [Column("dinm_HhAsgKarGrubu")]
    public byte? DinmHhAsgKarGrubu { get; set; }

    [Column("dinm_HHtop_per")]
    public byte? DinmHHtopPer { get; set; }

    [Column("dinm_Hhiademeblag")]
    public double? DinmHhiademeblag { get; set; }

    [Column("dinm_HVergiHesaplama")]
    public byte? DinmHVergiHesaplama { get; set; }

    [Column("dinm_miktar_oto_fl")]
    public bool? DinmMiktarOtoFl { get; set; }
}
