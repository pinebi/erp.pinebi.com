using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kiralama_mmo_tanimlari")]
public class KiralamaMmoTanimlari
{
    [Column("kmmo_Guid")]
    public Guid? KmmoGuid { get; set; }

    [Column("kmmo_DBCno")]
    public short? KmmoDBCno { get; set; }

    [Column("kmmo_SpecRECno")]
    public int? KmmoSpecRECno { get; set; }

    [Column("kmmo_iptal")]
    public bool? KmmoIptal { get; set; }

    [Column("kmmo_fileid")]
    public short? KmmoFileid { get; set; }

    [Column("kmmo_hidden")]
    public bool? KmmoHidden { get; set; }

    [Column("kmmo_kilitli")]
    public bool? KmmoKilitli { get; set; }

    [Column("kmmo_degisti")]
    public bool? KmmoDegisti { get; set; }

    [Column("kmmo_checksum")]
    public int? KmmoChecksum { get; set; }

    [Column("kmmo_create_user")]
    public short? KmmoCreateUser { get; set; }

    [Column("kmmo_create_date")]
    public DateTime? KmmoCreateDate { get; set; }

    [Column("kmmo_lastup_user")]
    public short? KmmoLastupUser { get; set; }

    [Column("kmmo_lastup_date")]
    public DateTime? KmmoLastupDate { get; set; }

    [Column("kmmo_special1")]
    [StringLength(4)]
    public string? KmmoSpecial1 { get; set; }

    [Column("kmmo_special2")]
    [StringLength(4)]
    public string? KmmoSpecial2 { get; set; }

    [Column("kmmo_special3")]
    [StringLength(4)]
    public string? KmmoSpecial3 { get; set; }

    [Column("kmmo_rapor_tipi")]
    public byte? KmmoRaporTipi { get; set; }

    [Column("kmmo_rapor_kodu")]
    [StringLength(25)]
    public string? KmmoRaporKodu { get; set; }

    [Column("kmmo_kontrol_tarihi")]
    public DateTime? KmmoKontrolTarihi { get; set; }

    [Column("kmmo_rap_tarihi")]
    public DateTime? KmmoRapTarihi { get; set; }

    [Column("kmmo_rap_no")]
    [StringLength(25)]
    public string? KmmoRapNo { get; set; }

    [Column("kmmo_gecerlilik_tarihi")]
    public DateTime? KmmoGecerlilikTarihi { get; set; }

    [Column("kmmo_stok_kodu")]
    [StringLength(25)]
    public string? KmmoStokKodu { get; set; }

    [Column("kmmo_cihaz_seri")]
    [StringLength(25)]
    public string? KmmoCihazSeri { get; set; }

    [Column("kmmo_carikodu")]
    [StringLength(25)]
    public string? KmmoCarikodu { get; set; }

    [Column("kmmo_fatura_seri")]
    [StringLength(50)]
    public string? KmmoFaturaSeri { get; set; }

    [Column("kmmo_fatura_sira")]
    public int? KmmoFaturaSira { get; set; }

    [Column("kmmo_fatura_tarihi")]
    public DateTime? KmmoFaturaTarihi { get; set; }

    [Column("kmmo_tutar")]
    public double? KmmoTutar { get; set; }

    [Column("kmmo_aciklama")]
    [StringLength(60)]
    public string? KmmoAciklama { get; set; }
}
