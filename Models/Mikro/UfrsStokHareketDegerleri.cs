using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ufrs_stok_hareket_degerleri")]
public class UfrsStokHareketDegerleri
{
    [Column("ushd_Guid")]
    public Guid? UshdGuid { get; set; }

    [Column("ushd_DBCno")]
    public short? UshdDBCno { get; set; }

    [Column("ushd_SpecRECno")]
    public int? UshdSpecRECno { get; set; }

    [Column("ushd_iptal")]
    public bool? UshdIptal { get; set; }

    [Column("ushd_fileid")]
    public short? UshdFileid { get; set; }

    [Column("ushd_hidden")]
    public bool? UshdHidden { get; set; }

    [Column("ushd_kilitli")]
    public bool? UshdKilitli { get; set; }

    [Column("ushd_degisti")]
    public bool? UshdDegisti { get; set; }

    [Column("ushd_checksum")]
    public int? UshdChecksum { get; set; }

    [Column("ushd_create_user")]
    public short? UshdCreateUser { get; set; }

    [Column("ushd_create_date")]
    public DateTime? UshdCreateDate { get; set; }

    [Column("ushd_lastup_user")]
    public short? UshdLastupUser { get; set; }

    [Column("ushd_lastup_date")]
    public DateTime? UshdLastupDate { get; set; }

    [Column("ushd_special1")]
    [StringLength(4)]
    public string? UshdSpecial1 { get; set; }

    [Column("ushd_special2")]
    [StringLength(4)]
    public string? UshdSpecial2 { get; set; }

    [Column("ushd_special3")]
    [StringLength(4)]
    public string? UshdSpecial3 { get; set; }

    [Column("ushd_baglihar_uid")]
    public Guid? UshdBagliharUid { get; set; }

    [Column("ushd_tutar")]
    public double? UshdTutar { get; set; }

    [Column("ushd_iskonto1")]
    public double? UshdIskonto1 { get; set; }

    [Column("ushd_iskonto2")]
    public double? UshdIskonto2 { get; set; }

    [Column("ushd_iskonto3")]
    public double? UshdIskonto3 { get; set; }

    [Column("ushd_iskonto4")]
    public double? UshdIskonto4 { get; set; }

    [Column("ushd_iskonto5")]
    public double? UshdIskonto5 { get; set; }

    [Column("ushd_iskonto6")]
    public double? UshdIskonto6 { get; set; }

    [Column("ushd_masraf1")]
    public double? UshdMasraf1 { get; set; }

    [Column("ushd_masraf2")]
    public double? UshdMasraf2 { get; set; }

    [Column("ushd_masraf3")]
    public double? UshdMasraf3 { get; set; }

    [Column("ushd_masraf4")]
    public double? UshdMasraf4 { get; set; }

    [Column("ushd_maliyet_ana")]
    public double? UshdMaliyetAna { get; set; }

    [Column("ushd_maliyet_alternatif")]
    public double? UshdMaliyetAlternatif { get; set; }

    [Column("ushd_maliyet_orjinal")]
    public double? UshdMaliyetOrjinal { get; set; }

    [Column("ushd_urunilkmaddedegeri")]
    public double? UshdUrunilkmaddedegeri { get; set; }

    [Column("ushd_mamulyarimamuldegeri")]
    public double? UshdMamulyarimamuldegeri { get; set; }

    [Column("ushd_direkt_iscilik_1")]
    public double? UshdDirektIscilik1 { get; set; }

    [Column("ushd_direkt_iscilik_2")]
    public double? UshdDirektIscilik2 { get; set; }

    [Column("ushd_direkt_iscilik_3")]
    public double? UshdDirektIscilik3 { get; set; }

    [Column("ushd_direkt_iscilik_4")]
    public double? UshdDirektIscilik4 { get; set; }

    [Column("ushd_direkt_iscilik_5")]
    public double? UshdDirektIscilik5 { get; set; }

    [Column("ushd_genel_uretim_1")]
    public double? UshdGenelUretim1 { get; set; }

    [Column("ushd_genel_uretim_2")]
    public double? UshdGenelUretim2 { get; set; }

    [Column("ushd_genel_uretim_3")]
    public double? UshdGenelUretim3 { get; set; }

    [Column("ushd_genel_uretim_4")]
    public double? UshdGenelUretim4 { get; set; }

    [Column("ushd_genel_uretim_5")]
    public double? UshdGenelUretim5 { get; set; }

    [Column("ushd_degerfarki")]
    public double? UshdDegerfarki { get; set; }

    [Column("ushd_fat_recid_dbcno")]
    public Guid? UshdFatRecidDbcno { get; set; }

    [Column("ushd_evraktip")]
    public byte? UshdEvraktip { get; set; }

    [Column("ushd_evrakno_seri")]
    [StringLength(50)]
    public string? UshdEvraknoSeri { get; set; }

    [Column("ushd_evrakno_sira")]
    public int? UshdEvraknoSira { get; set; }
}
