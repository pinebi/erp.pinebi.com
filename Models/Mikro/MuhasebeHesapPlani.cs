using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_hesap_plani")]
public class MuhasebeHesapPlani
{
    [Column("muh_Guid")]
    public Guid MuhGuid { get; set; }

    [Column("muh_DBCno")]
    public short? MuhDBCno { get; set; }

    [Column("muh_SpecRECno")]
    public int? MuhSpecRECno { get; set; }

    [Column("muh_iptal")]
    public bool? MuhIptal { get; set; }

    [Column("muh_fileid")]
    public short? MuhFileid { get; set; }

    [Column("muh_hidden")]
    public bool? MuhHidden { get; set; }

    [Column("muh_kilitli")]
    public bool? MuhKilitli { get; set; }

    [Column("muh_degisti")]
    public bool? MuhDegisti { get; set; }

    [Column("muh_checksum")]
    public int? MuhChecksum { get; set; }

    [Column("muh_create_user")]
    public short? MuhCreateUser { get; set; }

    [Column("muh_create_date")]
    public DateTime? MuhCreateDate { get; set; }

    [Column("muh_lastup_user")]
    public short? MuhLastupUser { get; set; }

    [Column("muh_lastup_date")]
    public DateTime? MuhLastupDate { get; set; }

    [Column("muh_special1")]
    [StringLength(4)]
    public string? MuhSpecial1 { get; set; }

    [Column("muh_special2")]
    [StringLength(4)]
    public string? MuhSpecial2 { get; set; }

    [Column("muh_special3")]
    [StringLength(4)]
    public string? MuhSpecial3 { get; set; }

    [Column("muh_hesap_kod")]
    [StringLength(25)]
    public string MuhHesapKod { get; set; }

    [Column("muh_hesap_isim1")]
    [StringLength(40)]
    public string? MuhHesapIsim1 { get; set; }

    [Column("muh_hesap_isim2")]
    [StringLength(40)]
    public string? MuhHesapIsim2 { get; set; }

    [Column("muh_hesap_tip")]
    public byte? MuhHesapTip { get; set; }

    [Column("muh_doviz_cinsi")]
    public byte? MuhDovizCinsi { get; set; }

    [Column("muh_kurfarki_fl")]
    public bool? MuhKurfarkiFl { get; set; }

    [Column("muh_sorum_merk")]
    public byte? MuhSorumMerk { get; set; }

    [Column("muh_kilittarihi")]
    public DateTime? MuhKilittarihi { get; set; }

    [Column("muh_hes_dav_bicimi")]
    public byte? MuhHesDavBicimi { get; set; }

    [Column("muh_kdv_tipi")]
    public byte? MuhKdvTipi { get; set; }

    [Column("muh_calisma_sekli")]
    public byte? MuhCalismaSekli { get; set; }

    [Column("muh_maliyet_dagitim_sekli")]
    public byte? MuhMaliyetDagitimSekli { get; set; }

    [Column("muh_grupkodu")]
    [StringLength(4)]
    public string? MuhGrupkodu { get; set; }

    [Column("muh_enf_fark_maliyet_fl")]
    public bool? MuhEnfFarkMaliyetFl { get; set; }

    [Column("muh_kdv_dagitim_sekli")]
    public byte? MuhKdvDagitimSekli { get; set; }

    [Column("muh_miktar_oto_fl")]
    public bool? MuhMiktarOtoFl { get; set; }

    [Column("muh_ticariden_bilgi_girisi_fl")]
    public bool? MuhTicaridenBilgiGirisiFl { get; set; }

    [Column("muh_proje_detayi")]
    public byte? MuhProjeDetayi { get; set; }

    [Column("muh_kesin_mizan_hesap_kodu")]
    [StringLength(25)]
    public string? MuhKesinMizanHesapKodu { get; set; }
}
