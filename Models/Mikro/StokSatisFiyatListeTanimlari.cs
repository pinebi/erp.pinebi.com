using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_satis_fiyat_liste_tanimlari")]
public class StokSatisFiyatListeTanimlari
{
    [Column("sfl_Guid")]
    public Guid? SflGuid { get; set; }

    [Column("sfl_DBCno")]
    public short? SflDBCno { get; set; }

    [Column("sfl_SpecRECno")]
    public int? SflSpecRECno { get; set; }

    [Column("sfl_iptal")]
    public bool? SflIptal { get; set; }

    [Column("sfl_fileid")]
    public short? SflFileid { get; set; }

    [Column("sfl_hidden")]
    public bool? SflHidden { get; set; }

    [Column("sfl_kilitli")]
    public bool? SflKilitli { get; set; }

    [Column("sfl_degisti")]
    public bool? SflDegisti { get; set; }

    [Column("sfl_checksum")]
    public int? SflChecksum { get; set; }

    [Column("sfl_create_user")]
    public short? SflCreateUser { get; set; }

    [Column("sfl_create_date")]
    public DateTime? SflCreateDate { get; set; }

    [Column("sfl_lastup_user")]
    public short? SflLastupUser { get; set; }

    [Column("sfl_lastup_date")]
    public DateTime? SflLastupDate { get; set; }

    [Column("sfl_special1")]
    [StringLength(4)]
    public string? SflSpecial1 { get; set; }

    [Column("sfl_special2")]
    [StringLength(4)]
    public string? SflSpecial2 { get; set; }

    [Column("sfl_special3")]
    [StringLength(4)]
    public string? SflSpecial3 { get; set; }

    [Column("sfl_sirano")]
    public int? SflSirano { get; set; }

    [Column("sfl_aciklama")]
    [StringLength(50)]
    public string? SflAciklama { get; set; }

    [Column("sfl_fiyatuygulama")]
    public byte? SflFiyatuygulama { get; set; }

    [Column("sfl_fiyatformul")]
    [StringLength(50)]
    public string? SflFiyatformul { get; set; }

    [Column("sfl_odepluygulama")]
    public byte? SflOdepluygulama { get; set; }

    [Column("sfl_odeplformul")]
    [StringLength(50)]
    public string? SflOdeplformul { get; set; }

    [Column("sfl_sabit_odeme_plani")]
    public int? SflSabitOdemePlani { get; set; }

    [Column("sfl_kdvdahil")]
    public bool? SflKdvdahil { get; set; }

    [Column("sfl_ilktarih")]
    public DateTime? SflIlktarih { get; set; }

    [Column("sfl_sontarih")]
    public DateTime? SflSontarih { get; set; }

    [Column("sfl_yerineuygulanacakfiyat")]
    public int? SflYerineuygulanacakfiyat { get; set; }

    [Column("sfl_kurhesaplamasekli")]
    public byte? SflKurhesaplamasekli { get; set; }

    [Column("sfl_doviz_uygulama")]
    public byte? SflDovizUygulama { get; set; }

    [Column("sfl_sabit_doviz")]
    public byte? SflSabitDoviz { get; set; }

    [Column("sfl_iskonto_uygulama")]
    public byte? SflIskontoUygulama { get; set; }

    [Column("sfl_sabit_iskonto")]
    [StringLength(4)]
    public string? SflSabitIskonto { get; set; }

    [Column("sfl_sabit_kur")]
    public double? SflSabitKur { get; set; }

    [Column("sfl_kampanya_uygulama")]
    public byte? SflKampanyaUygulama { get; set; }

    [Column("sfl_sabit_kampanya")]
    [StringLength(4)]
    public string? SflSabitKampanya { get; set; }

    [Column("sfl_kampanya_vade_gozardi")]
    public bool? SflKampanyaVadeGozardi { get; set; }

    [Column("sfl_kampanya_iskonto_gozardi")]
    public bool? SflKampanyaIskontoGozardi { get; set; }

    [Column("sfl_otvdahil")]
    public bool? SflOtvdahil { get; set; }

    [Column("sfl_oivdahil")]
    public bool? SflOivdahil { get; set; }
}
