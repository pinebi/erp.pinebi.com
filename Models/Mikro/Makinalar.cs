using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("makinalar")]
public class Makinalar
{
    [Column("mak_Guid")]
    public Guid? MakGuid { get; set; }

    [Column("mak_DBCno")]
    public short? MakDBCno { get; set; }

    [Column("mak_SpecRecno")]
    public int? MakSpecRecno { get; set; }

    [Column("mak_iptal")]
    public bool? MakIptal { get; set; }

    [Column("mak_fileid")]
    public short? MakFileid { get; set; }

    [Column("mak_hidden")]
    public bool? MakHidden { get; set; }

    [Column("mak_kilitli")]
    public bool? MakKilitli { get; set; }

    [Column("mak_degisti")]
    public bool? MakDegisti { get; set; }

    [Column("mak_checksum")]
    public int? MakChecksum { get; set; }

    [Column("mak_create_user")]
    public short? MakCreateUser { get; set; }

    [Column("mak_create_date")]
    public DateTime? MakCreateDate { get; set; }

    [Column("mak_lastup_user")]
    public short? MakLastupUser { get; set; }

    [Column("mak_lastup_date")]
    public DateTime? MakLastupDate { get; set; }

    [Column("mak_special1")]
    [StringLength(4)]
    public string? MakSpecial1 { get; set; }

    [Column("mak_special2")]
    [StringLength(4)]
    public string? MakSpecial2 { get; set; }

    [Column("mak_special3")]
    [StringLength(4)]
    public string? MakSpecial3 { get; set; }

    [Column("mak_kod")]
    [StringLength(25)]
    public string? MakKod { get; set; }

    [Column("mak_ozel_isim")]
    [StringLength(40)]
    public string? MakOzelIsim { get; set; }

    [Column("mak_grup_kod")]
    [StringLength(25)]
    public string? MakGrupKod { get; set; }

    [Column("mak_altar")]
    public DateTime? MakAltar { get; set; }

    [Column("mak_fiat")]
    public double? MakFiat { get; set; }

    [Column("mak_bakim")]
    public double? MakBakim { get; set; }

    [Column("mak_sonbakim_tarih")]
    public DateTime? MakSonbakimTarih { get; set; }

    [Column("mak_bakim_sure")]
    public short? MakBakimSure { get; set; }

    [Column("mak_ariza")]
    public bool? MakAriza { get; set; }

    [Column("mak_mesgul_sure")]
    public double? MakMesgulSure { get; set; }

    [Column("mak_topcal_sure")]
    public double? MakTopcalSure { get; set; }

    [Column("mak_servis_kod")]
    [StringLength(25)]
    public string? MakServisKod { get; set; }

    [Column("mak_atik_kod")]
    [StringLength(25)]
    public string? MakAtikKod { get; set; }

    [Column("mak_masraf")]
    public double? MakMasraf { get; set; }

    [Column("mak_son_reserv")]
    public short? MakSonReserv { get; set; }

    [Column("mak_bek_sure")]
    public double? MakBekSure { get; set; }

    [Column("mak_aciklama")]
    [StringLength(127)]
    public string? MakAciklama { get; set; }
}
