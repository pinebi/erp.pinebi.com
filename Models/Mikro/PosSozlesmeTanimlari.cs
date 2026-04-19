using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("pos_sozlesme_tanimlari")]
public class PosSozlesmeTanimlari
{
    [Column("psz_Guid")]
    public Guid? PszGuid { get; set; }

    [Column("psz_DBCno")]
    public short? PszDBCno { get; set; }

    [Column("psz_SpecRECNo")]
    public int? PszSpecRECNo { get; set; }

    [Column("psz_iptal")]
    public bool? PszIptal { get; set; }

    [Column("psz_fileid")]
    public short? PszFileid { get; set; }

    [Column("psz_hidden")]
    public bool? PszHidden { get; set; }

    [Column("psz_kilitli")]
    public bool? PszKilitli { get; set; }

    [Column("psz_degisti")]
    public bool? PszDegisti { get; set; }

    [Column("psz_CheckSum")]
    public int? PszCheckSum { get; set; }

    [Column("psz_create_user")]
    public short? PszCreateUser { get; set; }

    [Column("psz_create_date")]
    public DateTime? PszCreateDate { get; set; }

    [Column("psz_lastup_user")]
    public short? PszLastupUser { get; set; }

    [Column("psz_lastup_date")]
    public DateTime? PszLastupDate { get; set; }

    [Column("psz_special1")]
    [StringLength(4)]
    public string? PszSpecial1 { get; set; }

    [Column("psz_special2")]
    [StringLength(4)]
    public string? PszSpecial2 { get; set; }

    [Column("psz_special3")]
    [StringLength(4)]
    public string? PszSpecial3 { get; set; }

    [Column("psz_uye_isyeri_no")]
    [StringLength(25)]
    public string? PszUyeIsyeriNo { get; set; }

    [Column("psz_uye_isyeri_adi")]
    [StringLength(50)]
    public string? PszUyeIsyeriAdi { get; set; }

    [Column("psz_banka_kodu")]
    [StringLength(25)]
    public string? PszBankaKodu { get; set; }

    [Column("psz_sor_merk_kodu")]
    [StringLength(25)]
    public string? PszSorMerkKodu { get; set; }

    [Column("psz_proje_kodu")]
    [StringLength(25)]
    public string? PszProjeKodu { get; set; }

    [Column("psz_kart_sahip_tipi1")]
    public byte? PszKartSahipTipi1 { get; set; }

    [Column("psz_taksit_sayisi1")]
    public short? PszTaksitSayisi1 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi1")]
    public short? PszFirmayaOdemeTaksitSayisi1 { get; set; }

    [Column("psz_valor_gunu1")]
    public short? PszValorGunu1 { get; set; }

    [Column("psz_komisyon_orani1")]
    public double? PszKomisyonOrani1 { get; set; }

    [Column("psz_odul_katkisi_orani1")]
    public double? PszOdulKatkisiOrani1 { get; set; }

    [Column("psz_erken_odeme_faiz_orani1")]
    public double? PszErkenOdemeFaizOrani1 { get; set; }

    [Column("psz_diger_komisyon_orani1")]
    public double? PszDigerKomisyonOrani1 { get; set; }

    [Column("psz_kart_sahip_tipi2")]
    public byte? PszKartSahipTipi2 { get; set; }

    [Column("psz_taksit_sayisi2")]
    public short? PszTaksitSayisi2 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi2")]
    public short? PszFirmayaOdemeTaksitSayisi2 { get; set; }

    [Column("psz_valor_gunu2")]
    public short? PszValorGunu2 { get; set; }

    [Column("psz_komisyon_orani2")]
    public double? PszKomisyonOrani2 { get; set; }

    [Column("psz_odul_katkisi_orani2")]
    public double? PszOdulKatkisiOrani2 { get; set; }

    [Column("psz_erken_odeme_faiz_orani2")]
    public double? PszErkenOdemeFaizOrani2 { get; set; }

    [Column("psz_diger_komisyon_orani2")]
    public double? PszDigerKomisyonOrani2 { get; set; }

    [Column("psz_kart_sahip_tipi3")]
    public byte? PszKartSahipTipi3 { get; set; }

    [Column("psz_taksit_sayisi3")]
    public short? PszTaksitSayisi3 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi3")]
    public short? PszFirmayaOdemeTaksitSayisi3 { get; set; }

    [Column("psz_valor_gunu3")]
    public short? PszValorGunu3 { get; set; }

    [Column("psz_komisyon_orani3")]
    public double? PszKomisyonOrani3 { get; set; }

    [Column("psz_odul_katkisi_orani3")]
    public double? PszOdulKatkisiOrani3 { get; set; }

    [Column("psz_erken_odeme_faiz_orani3")]
    public double? PszErkenOdemeFaizOrani3 { get; set; }

    [Column("psz_diger_komisyon_orani3")]
    public double? PszDigerKomisyonOrani3 { get; set; }

    [Column("psz_kart_sahip_tipi4")]
    public byte? PszKartSahipTipi4 { get; set; }

    [Column("psz_taksit_sayisi4")]
    public short? PszTaksitSayisi4 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi4")]
    public short? PszFirmayaOdemeTaksitSayisi4 { get; set; }

    [Column("psz_valor_gunu4")]
    public short? PszValorGunu4 { get; set; }

    [Column("psz_komisyon_orani4")]
    public double? PszKomisyonOrani4 { get; set; }

    [Column("psz_odul_katkisi_orani4")]
    public double? PszOdulKatkisiOrani4 { get; set; }

    [Column("psz_erken_odeme_faiz_orani4")]
    public double? PszErkenOdemeFaizOrani4 { get; set; }

    [Column("psz_diger_komisyon_orani4")]
    public double? PszDigerKomisyonOrani4 { get; set; }

    [Column("psz_kart_sahip_tipi5")]
    public byte? PszKartSahipTipi5 { get; set; }

    [Column("psz_taksit_sayisi5")]
    public short? PszTaksitSayisi5 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi5")]
    public short? PszFirmayaOdemeTaksitSayisi5 { get; set; }

    [Column("psz_valor_gunu5")]
    public short? PszValorGunu5 { get; set; }

    [Column("psz_komisyon_orani5")]
    public double? PszKomisyonOrani5 { get; set; }

    [Column("psz_odul_katkisi_orani5")]
    public double? PszOdulKatkisiOrani5 { get; set; }

    [Column("psz_erken_odeme_faiz_orani5")]
    public double? PszErkenOdemeFaizOrani5 { get; set; }

    [Column("psz_diger_komisyon_orani5")]
    public double? PszDigerKomisyonOrani5 { get; set; }

    [Column("psz_kart_sahip_tipi6")]
    public byte? PszKartSahipTipi6 { get; set; }

    [Column("psz_taksit_sayisi6")]
    public short? PszTaksitSayisi6 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi6")]
    public short? PszFirmayaOdemeTaksitSayisi6 { get; set; }

    [Column("psz_valor_gunu6")]
    public short? PszValorGunu6 { get; set; }

    [Column("psz_komisyon_orani6")]
    public double? PszKomisyonOrani6 { get; set; }

    [Column("psz_odul_katkisi_orani6")]
    public double? PszOdulKatkisiOrani6 { get; set; }

    [Column("psz_erken_odeme_faiz_orani6")]
    public double? PszErkenOdemeFaizOrani6 { get; set; }

    [Column("psz_diger_komisyon_orani6")]
    public double? PszDigerKomisyonOrani6 { get; set; }

    [Column("psz_kart_sahip_tipi7")]
    public byte? PszKartSahipTipi7 { get; set; }

    [Column("psz_taksit_sayisi7")]
    public short? PszTaksitSayisi7 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi7")]
    public short? PszFirmayaOdemeTaksitSayisi7 { get; set; }

    [Column("psz_valor_gunu7")]
    public short? PszValorGunu7 { get; set; }

    [Column("psz_komisyon_orani7")]
    public double? PszKomisyonOrani7 { get; set; }

    [Column("psz_odul_katkisi_orani7")]
    public double? PszOdulKatkisiOrani7 { get; set; }

    [Column("psz_erken_odeme_faiz_orani7")]
    public double? PszErkenOdemeFaizOrani7 { get; set; }

    [Column("psz_diger_komisyon_orani7")]
    public double? PszDigerKomisyonOrani7 { get; set; }

    [Column("psz_kart_sahip_tipi8")]
    public byte? PszKartSahipTipi8 { get; set; }

    [Column("psz_taksit_sayisi8")]
    public short? PszTaksitSayisi8 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi8")]
    public short? PszFirmayaOdemeTaksitSayisi8 { get; set; }

    [Column("psz_valor_gunu8")]
    public short? PszValorGunu8 { get; set; }

    [Column("psz_komisyon_orani8")]
    public double? PszKomisyonOrani8 { get; set; }

    [Column("psz_odul_katkisi_orani8")]
    public double? PszOdulKatkisiOrani8 { get; set; }

    [Column("psz_erken_odeme_faiz_orani8")]
    public double? PszErkenOdemeFaizOrani8 { get; set; }

    [Column("psz_diger_komisyon_orani8")]
    public double? PszDigerKomisyonOrani8 { get; set; }

    [Column("psz_kart_sahip_tipi9")]
    public byte? PszKartSahipTipi9 { get; set; }

    [Column("psz_taksit_sayisi9")]
    public short? PszTaksitSayisi9 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi9")]
    public short? PszFirmayaOdemeTaksitSayisi9 { get; set; }

    [Column("psz_valor_gunu9")]
    public short? PszValorGunu9 { get; set; }

    [Column("psz_komisyon_orani9")]
    public double? PszKomisyonOrani9 { get; set; }

    [Column("psz_odul_katkisi_orani9")]
    public double? PszOdulKatkisiOrani9 { get; set; }

    [Column("psz_erken_odeme_faiz_orani9")]
    public double? PszErkenOdemeFaizOrani9 { get; set; }

    [Column("psz_diger_komisyon_orani9")]
    public double? PszDigerKomisyonOrani9 { get; set; }

    [Column("psz_kart_sahip_tipi10")]
    public byte? PszKartSahipTipi10 { get; set; }

    [Column("psz_taksit_sayisi10")]
    public short? PszTaksitSayisi10 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi10")]
    public short? PszFirmayaOdemeTaksitSayisi10 { get; set; }

    [Column("psz_valor_gunu10")]
    public short? PszValorGunu10 { get; set; }

    [Column("psz_komisyon_orani10")]
    public double? PszKomisyonOrani10 { get; set; }

    [Column("psz_odul_katkisi_orani10")]
    public double? PszOdulKatkisiOrani10 { get; set; }

    [Column("psz_erken_odeme_faiz_orani10")]
    public double? PszErkenOdemeFaizOrani10 { get; set; }

    [Column("psz_diger_komisyon_orani10")]
    public double? PszDigerKomisyonOrani10 { get; set; }

    [Column("psz_kart_sahip_tipi11")]
    public byte? PszKartSahipTipi11 { get; set; }

    [Column("psz_taksit_sayisi11")]
    public short? PszTaksitSayisi11 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi11")]
    public short? PszFirmayaOdemeTaksitSayisi11 { get; set; }

    [Column("psz_valor_gunu11")]
    public short? PszValorGunu11 { get; set; }

    [Column("psz_komisyon_orani11")]
    public double? PszKomisyonOrani11 { get; set; }

    [Column("psz_odul_katkisi_orani11")]
    public double? PszOdulKatkisiOrani11 { get; set; }

    [Column("psz_erken_odeme_faiz_orani11")]
    public double? PszErkenOdemeFaizOrani11 { get; set; }

    [Column("psz_diger_komisyon_orani11")]
    public double? PszDigerKomisyonOrani11 { get; set; }

    [Column("psz_kart_sahip_tipi12")]
    public byte? PszKartSahipTipi12 { get; set; }

    [Column("psz_taksit_sayisi12")]
    public short? PszTaksitSayisi12 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi12")]
    public short? PszFirmayaOdemeTaksitSayisi12 { get; set; }

    [Column("psz_valor_gunu12")]
    public short? PszValorGunu12 { get; set; }

    [Column("psz_komisyon_orani12")]
    public double? PszKomisyonOrani12 { get; set; }

    [Column("psz_odul_katkisi_orani12")]
    public double? PszOdulKatkisiOrani12 { get; set; }

    [Column("psz_erken_odeme_faiz_orani12")]
    public double? PszErkenOdemeFaizOrani12 { get; set; }

    [Column("psz_diger_komisyon_orani12")]
    public double? PszDigerKomisyonOrani12 { get; set; }

    [Column("psz_kart_sahip_tipi13")]
    public byte? PszKartSahipTipi13 { get; set; }

    [Column("psz_taksit_sayisi13")]
    public short? PszTaksitSayisi13 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi13")]
    public short? PszFirmayaOdemeTaksitSayisi13 { get; set; }

    [Column("psz_valor_gunu13")]
    public short? PszValorGunu13 { get; set; }

    [Column("psz_komisyon_orani13")]
    public double? PszKomisyonOrani13 { get; set; }

    [Column("psz_odul_katkisi_orani13")]
    public double? PszOdulKatkisiOrani13 { get; set; }

    [Column("psz_erken_odeme_faiz_orani13")]
    public double? PszErkenOdemeFaizOrani13 { get; set; }

    [Column("psz_diger_komisyon_orani13")]
    public double? PszDigerKomisyonOrani13 { get; set; }

    [Column("psz_kart_sahip_tipi14")]
    public byte? PszKartSahipTipi14 { get; set; }

    [Column("psz_taksit_sayisi14")]
    public short? PszTaksitSayisi14 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi14")]
    public short? PszFirmayaOdemeTaksitSayisi14 { get; set; }

    [Column("psz_valor_gunu14")]
    public short? PszValorGunu14 { get; set; }

    [Column("psz_komisyon_orani14")]
    public double? PszKomisyonOrani14 { get; set; }

    [Column("psz_odul_katkisi_orani14")]
    public double? PszOdulKatkisiOrani14 { get; set; }

    [Column("psz_erken_odeme_faiz_orani14")]
    public double? PszErkenOdemeFaizOrani14 { get; set; }

    [Column("psz_diger_komisyon_orani14")]
    public double? PszDigerKomisyonOrani14 { get; set; }

    [Column("psz_kart_sahip_tipi15")]
    public byte? PszKartSahipTipi15 { get; set; }

    [Column("psz_taksit_sayisi15")]
    public short? PszTaksitSayisi15 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi15")]
    public short? PszFirmayaOdemeTaksitSayisi15 { get; set; }

    [Column("psz_valor_gunu15")]
    public short? PszValorGunu15 { get; set; }

    [Column("psz_komisyon_orani15")]
    public double? PszKomisyonOrani15 { get; set; }

    [Column("psz_odul_katkisi_orani15")]
    public double? PszOdulKatkisiOrani15 { get; set; }

    [Column("psz_erken_odeme_faiz_orani15")]
    public double? PszErkenOdemeFaizOrani15 { get; set; }

    [Column("psz_diger_komisyon_orani15")]
    public double? PszDigerKomisyonOrani15 { get; set; }

    [Column("psz_kart_sahip_tipi16")]
    public byte? PszKartSahipTipi16 { get; set; }

    [Column("psz_taksit_sayisi16")]
    public short? PszTaksitSayisi16 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi16")]
    public short? PszFirmayaOdemeTaksitSayisi16 { get; set; }

    [Column("psz_valor_gunu16")]
    public short? PszValorGunu16 { get; set; }

    [Column("psz_komisyon_orani16")]
    public double? PszKomisyonOrani16 { get; set; }

    [Column("psz_odul_katkisi_orani16")]
    public double? PszOdulKatkisiOrani16 { get; set; }

    [Column("psz_erken_odeme_faiz_orani16")]
    public double? PszErkenOdemeFaizOrani16 { get; set; }

    [Column("psz_diger_komisyon_orani16")]
    public double? PszDigerKomisyonOrani16 { get; set; }

    [Column("psz_kart_sahip_tipi17")]
    public byte? PszKartSahipTipi17 { get; set; }

    [Column("psz_taksit_sayisi17")]
    public short? PszTaksitSayisi17 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi17")]
    public short? PszFirmayaOdemeTaksitSayisi17 { get; set; }

    [Column("psz_valor_gunu17")]
    public short? PszValorGunu17 { get; set; }

    [Column("psz_komisyon_orani17")]
    public double? PszKomisyonOrani17 { get; set; }

    [Column("psz_odul_katkisi_orani17")]
    public double? PszOdulKatkisiOrani17 { get; set; }

    [Column("psz_erken_odeme_faiz_orani17")]
    public double? PszErkenOdemeFaizOrani17 { get; set; }

    [Column("psz_diger_komisyon_orani17")]
    public double? PszDigerKomisyonOrani17 { get; set; }

    [Column("psz_kart_sahip_tipi18")]
    public byte? PszKartSahipTipi18 { get; set; }

    [Column("psz_taksit_sayisi18")]
    public short? PszTaksitSayisi18 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi18")]
    public short? PszFirmayaOdemeTaksitSayisi18 { get; set; }

    [Column("psz_valor_gunu18")]
    public short? PszValorGunu18 { get; set; }

    [Column("psz_komisyon_orani18")]
    public double? PszKomisyonOrani18 { get; set; }

    [Column("psz_odul_katkisi_orani18")]
    public double? PszOdulKatkisiOrani18 { get; set; }

    [Column("psz_erken_odeme_faiz_orani18")]
    public double? PszErkenOdemeFaizOrani18 { get; set; }

    [Column("psz_diger_komisyon_orani18")]
    public double? PszDigerKomisyonOrani18 { get; set; }

    [Column("psz_kart_sahip_tipi19")]
    public byte? PszKartSahipTipi19 { get; set; }

    [Column("psz_taksit_sayisi19")]
    public short? PszTaksitSayisi19 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi19")]
    public short? PszFirmayaOdemeTaksitSayisi19 { get; set; }

    [Column("psz_valor_gunu19")]
    public short? PszValorGunu19 { get; set; }

    [Column("psz_komisyon_orani19")]
    public double? PszKomisyonOrani19 { get; set; }

    [Column("psz_odul_katkisi_orani19")]
    public double? PszOdulKatkisiOrani19 { get; set; }

    [Column("psz_erken_odeme_faiz_orani19")]
    public double? PszErkenOdemeFaizOrani19 { get; set; }

    [Column("psz_diger_komisyon_orani19")]
    public double? PszDigerKomisyonOrani19 { get; set; }

    [Column("psz_kart_sahip_tipi20")]
    public byte? PszKartSahipTipi20 { get; set; }

    [Column("psz_taksit_sayisi20")]
    public short? PszTaksitSayisi20 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi20")]
    public short? PszFirmayaOdemeTaksitSayisi20 { get; set; }

    [Column("psz_valor_gunu20")]
    public short? PszValorGunu20 { get; set; }

    [Column("psz_komisyon_orani20")]
    public double? PszKomisyonOrani20 { get; set; }

    [Column("psz_odul_katkisi_orani20")]
    public double? PszOdulKatkisiOrani20 { get; set; }

    [Column("psz_erken_odeme_faiz_orani20")]
    public double? PszErkenOdemeFaizOrani20 { get; set; }

    [Column("psz_diger_komisyon_orani20")]
    public double? PszDigerKomisyonOrani20 { get; set; }

    [Column("psz_kart_sahip_tipi21")]
    public byte? PszKartSahipTipi21 { get; set; }

    [Column("psz_taksit_sayisi21")]
    public short? PszTaksitSayisi21 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi21")]
    public short? PszFirmayaOdemeTaksitSayisi21 { get; set; }

    [Column("psz_valor_gunu21")]
    public short? PszValorGunu21 { get; set; }

    [Column("psz_komisyon_orani21")]
    public double? PszKomisyonOrani21 { get; set; }

    [Column("psz_odul_katkisi_orani21")]
    public double? PszOdulKatkisiOrani21 { get; set; }

    [Column("psz_erken_odeme_faiz_orani21")]
    public double? PszErkenOdemeFaizOrani21 { get; set; }

    [Column("psz_diger_komisyon_orani21")]
    public double? PszDigerKomisyonOrani21 { get; set; }

    [Column("psz_kart_sahip_tipi22")]
    public byte? PszKartSahipTipi22 { get; set; }

    [Column("psz_taksit_sayisi22")]
    public short? PszTaksitSayisi22 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi22")]
    public short? PszFirmayaOdemeTaksitSayisi22 { get; set; }

    [Column("psz_valor_gunu22")]
    public short? PszValorGunu22 { get; set; }

    [Column("psz_komisyon_orani22")]
    public double? PszKomisyonOrani22 { get; set; }

    [Column("psz_odul_katkisi_orani22")]
    public double? PszOdulKatkisiOrani22 { get; set; }

    [Column("psz_erken_odeme_faiz_orani22")]
    public double? PszErkenOdemeFaizOrani22 { get; set; }

    [Column("psz_diger_komisyon_orani22")]
    public double? PszDigerKomisyonOrani22 { get; set; }

    [Column("psz_kart_sahip_tipi23")]
    public byte? PszKartSahipTipi23 { get; set; }

    [Column("psz_taksit_sayisi23")]
    public short? PszTaksitSayisi23 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi23")]
    public short? PszFirmayaOdemeTaksitSayisi23 { get; set; }

    [Column("psz_valor_gunu23")]
    public short? PszValorGunu23 { get; set; }

    [Column("psz_komisyon_orani23")]
    public double? PszKomisyonOrani23 { get; set; }

    [Column("psz_odul_katkisi_orani23")]
    public double? PszOdulKatkisiOrani23 { get; set; }

    [Column("psz_erken_odeme_faiz_orani23")]
    public double? PszErkenOdemeFaizOrani23 { get; set; }

    [Column("psz_diger_komisyon_orani23")]
    public double? PszDigerKomisyonOrani23 { get; set; }

    [Column("psz_kart_sahip_tipi24")]
    public byte? PszKartSahipTipi24 { get; set; }

    [Column("psz_taksit_sayisi24")]
    public short? PszTaksitSayisi24 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi24")]
    public short? PszFirmayaOdemeTaksitSayisi24 { get; set; }

    [Column("psz_valor_gunu24")]
    public short? PszValorGunu24 { get; set; }

    [Column("psz_komisyon_orani24")]
    public double? PszKomisyonOrani24 { get; set; }

    [Column("psz_odul_katkisi_orani24")]
    public double? PszOdulKatkisiOrani24 { get; set; }

    [Column("psz_erken_odeme_faiz_orani24")]
    public double? PszErkenOdemeFaizOrani24 { get; set; }

    [Column("psz_diger_komisyon_orani24")]
    public double? PszDigerKomisyonOrani24 { get; set; }

    [Column("psz_kart_sahip_tipi25")]
    public byte? PszKartSahipTipi25 { get; set; }

    [Column("psz_taksit_sayisi25")]
    public short? PszTaksitSayisi25 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi25")]
    public short? PszFirmayaOdemeTaksitSayisi25 { get; set; }

    [Column("psz_valor_gunu25")]
    public short? PszValorGunu25 { get; set; }

    [Column("psz_komisyon_orani25")]
    public double? PszKomisyonOrani25 { get; set; }

    [Column("psz_odul_katkisi_orani25")]
    public double? PszOdulKatkisiOrani25 { get; set; }

    [Column("psz_erken_odeme_faiz_orani25")]
    public double? PszErkenOdemeFaizOrani25 { get; set; }

    [Column("psz_diger_komisyon_orani25")]
    public double? PszDigerKomisyonOrani25 { get; set; }

    [Column("psz_kart_sahip_tipi26")]
    public byte? PszKartSahipTipi26 { get; set; }

    [Column("psz_taksit_sayisi26")]
    public short? PszTaksitSayisi26 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi26")]
    public short? PszFirmayaOdemeTaksitSayisi26 { get; set; }

    [Column("psz_valor_gunu26")]
    public short? PszValorGunu26 { get; set; }

    [Column("psz_komisyon_orani26")]
    public double? PszKomisyonOrani26 { get; set; }

    [Column("psz_odul_katkisi_orani26")]
    public double? PszOdulKatkisiOrani26 { get; set; }

    [Column("psz_erken_odeme_faiz_orani26")]
    public double? PszErkenOdemeFaizOrani26 { get; set; }

    [Column("psz_diger_komisyon_orani26")]
    public double? PszDigerKomisyonOrani26 { get; set; }

    [Column("psz_kart_sahip_tipi27")]
    public byte? PszKartSahipTipi27 { get; set; }

    [Column("psz_taksit_sayisi27")]
    public short? PszTaksitSayisi27 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi27")]
    public short? PszFirmayaOdemeTaksitSayisi27 { get; set; }

    [Column("psz_valor_gunu27")]
    public short? PszValorGunu27 { get; set; }

    [Column("psz_komisyon_orani27")]
    public double? PszKomisyonOrani27 { get; set; }

    [Column("psz_odul_katkisi_orani27")]
    public double? PszOdulKatkisiOrani27 { get; set; }

    [Column("psz_erken_odeme_faiz_orani27")]
    public double? PszErkenOdemeFaizOrani27 { get; set; }

    [Column("psz_diger_komisyon_orani27")]
    public double? PszDigerKomisyonOrani27 { get; set; }

    [Column("psz_kart_sahip_tipi28")]
    public byte? PszKartSahipTipi28 { get; set; }

    [Column("psz_taksit_sayisi28")]
    public short? PszTaksitSayisi28 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi28")]
    public short? PszFirmayaOdemeTaksitSayisi28 { get; set; }

    [Column("psz_valor_gunu28")]
    public short? PszValorGunu28 { get; set; }

    [Column("psz_komisyon_orani28")]
    public double? PszKomisyonOrani28 { get; set; }

    [Column("psz_odul_katkisi_orani28")]
    public double? PszOdulKatkisiOrani28 { get; set; }

    [Column("psz_erken_odeme_faiz_orani28")]
    public double? PszErkenOdemeFaizOrani28 { get; set; }

    [Column("psz_diger_komisyon_orani28")]
    public double? PszDigerKomisyonOrani28 { get; set; }

    [Column("psz_kart_sahip_tipi29")]
    public byte? PszKartSahipTipi29 { get; set; }

    [Column("psz_taksit_sayisi29")]
    public short? PszTaksitSayisi29 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi29")]
    public short? PszFirmayaOdemeTaksitSayisi29 { get; set; }

    [Column("psz_valor_gunu29")]
    public short? PszValorGunu29 { get; set; }

    [Column("psz_komisyon_orani29")]
    public double? PszKomisyonOrani29 { get; set; }

    [Column("psz_odul_katkisi_orani29")]
    public double? PszOdulKatkisiOrani29 { get; set; }

    [Column("psz_erken_odeme_faiz_orani29")]
    public double? PszErkenOdemeFaizOrani29 { get; set; }

    [Column("psz_diger_komisyon_orani29")]
    public double? PszDigerKomisyonOrani29 { get; set; }

    [Column("psz_kart_sahip_tipi30")]
    public byte? PszKartSahipTipi30 { get; set; }

    [Column("psz_taksit_sayisi30")]
    public short? PszTaksitSayisi30 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi30")]
    public short? PszFirmayaOdemeTaksitSayisi30 { get; set; }

    [Column("psz_valor_gunu30")]
    public short? PszValorGunu30 { get; set; }

    [Column("psz_komisyon_orani30")]
    public double? PszKomisyonOrani30 { get; set; }

    [Column("psz_odul_katkisi_orani30")]
    public double? PszOdulKatkisiOrani30 { get; set; }

    [Column("psz_erken_odeme_faiz_orani30")]
    public double? PszErkenOdemeFaizOrani30 { get; set; }

    [Column("psz_diger_komisyon_orani30")]
    public double? PszDigerKomisyonOrani30 { get; set; }

    [Column("psz_kart_sahip_tipi31")]
    public byte? PszKartSahipTipi31 { get; set; }

    [Column("psz_taksit_sayisi31")]
    public short? PszTaksitSayisi31 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi31")]
    public short? PszFirmayaOdemeTaksitSayisi31 { get; set; }

    [Column("psz_valor_gunu31")]
    public short? PszValorGunu31 { get; set; }

    [Column("psz_komisyon_orani31")]
    public double? PszKomisyonOrani31 { get; set; }

    [Column("psz_odul_katkisi_orani31")]
    public double? PszOdulKatkisiOrani31 { get; set; }

    [Column("psz_erken_odeme_faiz_orani31")]
    public double? PszErkenOdemeFaizOrani31 { get; set; }

    [Column("psz_diger_komisyon_orani31")]
    public double? PszDigerKomisyonOrani31 { get; set; }

    [Column("psz_kart_sahip_tipi32")]
    public byte? PszKartSahipTipi32 { get; set; }

    [Column("psz_taksit_sayisi32")]
    public short? PszTaksitSayisi32 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi32")]
    public short? PszFirmayaOdemeTaksitSayisi32 { get; set; }

    [Column("psz_valor_gunu32")]
    public short? PszValorGunu32 { get; set; }

    [Column("psz_komisyon_orani32")]
    public double? PszKomisyonOrani32 { get; set; }

    [Column("psz_odul_katkisi_orani32")]
    public double? PszOdulKatkisiOrani32 { get; set; }

    [Column("psz_erken_odeme_faiz_orani32")]
    public double? PszErkenOdemeFaizOrani32 { get; set; }

    [Column("psz_diger_komisyon_orani32")]
    public double? PszDigerKomisyonOrani32 { get; set; }

    [Column("psz_kart_sahip_tipi33")]
    public byte? PszKartSahipTipi33 { get; set; }

    [Column("psz_taksit_sayisi33")]
    public short? PszTaksitSayisi33 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi33")]
    public short? PszFirmayaOdemeTaksitSayisi33 { get; set; }

    [Column("psz_valor_gunu33")]
    public short? PszValorGunu33 { get; set; }

    [Column("psz_komisyon_orani33")]
    public double? PszKomisyonOrani33 { get; set; }

    [Column("psz_odul_katkisi_orani33")]
    public double? PszOdulKatkisiOrani33 { get; set; }

    [Column("psz_erken_odeme_faiz_orani33")]
    public double? PszErkenOdemeFaizOrani33 { get; set; }

    [Column("psz_diger_komisyon_orani33")]
    public double? PszDigerKomisyonOrani33 { get; set; }

    [Column("psz_kart_sahip_tipi34")]
    public byte? PszKartSahipTipi34 { get; set; }

    [Column("psz_taksit_sayisi34")]
    public short? PszTaksitSayisi34 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi34")]
    public short? PszFirmayaOdemeTaksitSayisi34 { get; set; }

    [Column("psz_valor_gunu34")]
    public short? PszValorGunu34 { get; set; }

    [Column("psz_komisyon_orani34")]
    public double? PszKomisyonOrani34 { get; set; }

    [Column("psz_odul_katkisi_orani34")]
    public double? PszOdulKatkisiOrani34 { get; set; }

    [Column("psz_erken_odeme_faiz_orani34")]
    public double? PszErkenOdemeFaizOrani34 { get; set; }

    [Column("psz_diger_komisyon_orani34")]
    public double? PszDigerKomisyonOrani34 { get; set; }

    [Column("psz_kart_sahip_tipi35")]
    public byte? PszKartSahipTipi35 { get; set; }

    [Column("psz_taksit_sayisi35")]
    public short? PszTaksitSayisi35 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi35")]
    public short? PszFirmayaOdemeTaksitSayisi35 { get; set; }

    [Column("psz_valor_gunu35")]
    public short? PszValorGunu35 { get; set; }

    [Column("psz_komisyon_orani35")]
    public double? PszKomisyonOrani35 { get; set; }

    [Column("psz_odul_katkisi_orani35")]
    public double? PszOdulKatkisiOrani35 { get; set; }

    [Column("psz_erken_odeme_faiz_orani35")]
    public double? PszErkenOdemeFaizOrani35 { get; set; }

    [Column("psz_diger_komisyon_orani35")]
    public double? PszDigerKomisyonOrani35 { get; set; }

    [Column("psz_kart_sahip_tipi36")]
    public byte? PszKartSahipTipi36 { get; set; }

    [Column("psz_taksit_sayisi36")]
    public short? PszTaksitSayisi36 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi36")]
    public short? PszFirmayaOdemeTaksitSayisi36 { get; set; }

    [Column("psz_valor_gunu36")]
    public short? PszValorGunu36 { get; set; }

    [Column("psz_komisyon_orani36")]
    public double? PszKomisyonOrani36 { get; set; }

    [Column("psz_odul_katkisi_orani36")]
    public double? PszOdulKatkisiOrani36 { get; set; }

    [Column("psz_erken_odeme_faiz_orani36")]
    public double? PszErkenOdemeFaizOrani36 { get; set; }

    [Column("psz_diger_komisyon_orani36")]
    public double? PszDigerKomisyonOrani36 { get; set; }

    [Column("psz_kart_sahip_tipi37")]
    public byte? PszKartSahipTipi37 { get; set; }

    [Column("psz_taksit_sayisi37")]
    public short? PszTaksitSayisi37 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi37")]
    public short? PszFirmayaOdemeTaksitSayisi37 { get; set; }

    [Column("psz_valor_gunu37")]
    public short? PszValorGunu37 { get; set; }

    [Column("psz_komisyon_orani37")]
    public double? PszKomisyonOrani37 { get; set; }

    [Column("psz_odul_katkisi_orani37")]
    public double? PszOdulKatkisiOrani37 { get; set; }

    [Column("psz_erken_odeme_faiz_orani37")]
    public double? PszErkenOdemeFaizOrani37 { get; set; }

    [Column("psz_diger_komisyon_orani37")]
    public double? PszDigerKomisyonOrani37 { get; set; }

    [Column("psz_kart_sahip_tipi38")]
    public byte? PszKartSahipTipi38 { get; set; }

    [Column("psz_taksit_sayisi38")]
    public short? PszTaksitSayisi38 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi38")]
    public short? PszFirmayaOdemeTaksitSayisi38 { get; set; }

    [Column("psz_valor_gunu38")]
    public short? PszValorGunu38 { get; set; }

    [Column("psz_komisyon_orani38")]
    public double? PszKomisyonOrani38 { get; set; }

    [Column("psz_odul_katkisi_orani38")]
    public double? PszOdulKatkisiOrani38 { get; set; }

    [Column("psz_erken_odeme_faiz_orani38")]
    public double? PszErkenOdemeFaizOrani38 { get; set; }

    [Column("psz_diger_komisyon_orani38")]
    public double? PszDigerKomisyonOrani38 { get; set; }

    [Column("psz_kart_sahip_tipi39")]
    public byte? PszKartSahipTipi39 { get; set; }

    [Column("psz_taksit_sayisi39")]
    public short? PszTaksitSayisi39 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi39")]
    public short? PszFirmayaOdemeTaksitSayisi39 { get; set; }

    [Column("psz_valor_gunu39")]
    public short? PszValorGunu39 { get; set; }

    [Column("psz_komisyon_orani39")]
    public double? PszKomisyonOrani39 { get; set; }

    [Column("psz_odul_katkisi_orani39")]
    public double? PszOdulKatkisiOrani39 { get; set; }

    [Column("psz_erken_odeme_faiz_orani39")]
    public double? PszErkenOdemeFaizOrani39 { get; set; }

    [Column("psz_diger_komisyon_orani39")]
    public double? PszDigerKomisyonOrani39 { get; set; }

    [Column("psz_kart_sahip_tipi40")]
    public byte? PszKartSahipTipi40 { get; set; }

    [Column("psz_taksit_sayisi40")]
    public short? PszTaksitSayisi40 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi40")]
    public short? PszFirmayaOdemeTaksitSayisi40 { get; set; }

    [Column("psz_valor_gunu40")]
    public short? PszValorGunu40 { get; set; }

    [Column("psz_komisyon_orani40")]
    public double? PszKomisyonOrani40 { get; set; }

    [Column("psz_odul_katkisi_orani40")]
    public double? PszOdulKatkisiOrani40 { get; set; }

    [Column("psz_erken_odeme_faiz_orani40")]
    public double? PszErkenOdemeFaizOrani40 { get; set; }

    [Column("psz_diger_komisyon_orani40")]
    public double? PszDigerKomisyonOrani40 { get; set; }

    [Column("psz_kart_sahip_tipi41")]
    public byte? PszKartSahipTipi41 { get; set; }

    [Column("psz_taksit_sayisi41")]
    public short? PszTaksitSayisi41 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi41")]
    public short? PszFirmayaOdemeTaksitSayisi41 { get; set; }

    [Column("psz_valor_gunu41")]
    public short? PszValorGunu41 { get; set; }

    [Column("psz_komisyon_orani41")]
    public double? PszKomisyonOrani41 { get; set; }

    [Column("psz_odul_katkisi_orani41")]
    public double? PszOdulKatkisiOrani41 { get; set; }

    [Column("psz_erken_odeme_faiz_orani41")]
    public double? PszErkenOdemeFaizOrani41 { get; set; }

    [Column("psz_diger_komisyon_orani41")]
    public double? PszDigerKomisyonOrani41 { get; set; }

    [Column("psz_kart_sahip_tipi42")]
    public byte? PszKartSahipTipi42 { get; set; }

    [Column("psz_taksit_sayisi42")]
    public short? PszTaksitSayisi42 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi42")]
    public short? PszFirmayaOdemeTaksitSayisi42 { get; set; }

    [Column("psz_valor_gunu42")]
    public short? PszValorGunu42 { get; set; }

    [Column("psz_komisyon_orani42")]
    public double? PszKomisyonOrani42 { get; set; }

    [Column("psz_odul_katkisi_orani42")]
    public double? PszOdulKatkisiOrani42 { get; set; }

    [Column("psz_erken_odeme_faiz_orani42")]
    public double? PszErkenOdemeFaizOrani42 { get; set; }

    [Column("psz_diger_komisyon_orani42")]
    public double? PszDigerKomisyonOrani42 { get; set; }

    [Column("psz_kart_sahip_tipi43")]
    public byte? PszKartSahipTipi43 { get; set; }

    [Column("psz_taksit_sayisi43")]
    public short? PszTaksitSayisi43 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi43")]
    public short? PszFirmayaOdemeTaksitSayisi43 { get; set; }

    [Column("psz_valor_gunu43")]
    public short? PszValorGunu43 { get; set; }

    [Column("psz_komisyon_orani43")]
    public double? PszKomisyonOrani43 { get; set; }

    [Column("psz_odul_katkisi_orani43")]
    public double? PszOdulKatkisiOrani43 { get; set; }

    [Column("psz_erken_odeme_faiz_orani43")]
    public double? PszErkenOdemeFaizOrani43 { get; set; }

    [Column("psz_diger_komisyon_orani43")]
    public double? PszDigerKomisyonOrani43 { get; set; }

    [Column("psz_kart_sahip_tipi44")]
    public byte? PszKartSahipTipi44 { get; set; }

    [Column("psz_taksit_sayisi44")]
    public short? PszTaksitSayisi44 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi44")]
    public short? PszFirmayaOdemeTaksitSayisi44 { get; set; }

    [Column("psz_valor_gunu44")]
    public short? PszValorGunu44 { get; set; }

    [Column("psz_komisyon_orani44")]
    public double? PszKomisyonOrani44 { get; set; }

    [Column("psz_odul_katkisi_orani44")]
    public double? PszOdulKatkisiOrani44 { get; set; }

    [Column("psz_erken_odeme_faiz_orani44")]
    public double? PszErkenOdemeFaizOrani44 { get; set; }

    [Column("psz_diger_komisyon_orani44")]
    public double? PszDigerKomisyonOrani44 { get; set; }

    [Column("psz_kart_sahip_tipi45")]
    public byte? PszKartSahipTipi45 { get; set; }

    [Column("psz_taksit_sayisi45")]
    public short? PszTaksitSayisi45 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi45")]
    public short? PszFirmayaOdemeTaksitSayisi45 { get; set; }

    [Column("psz_valor_gunu45")]
    public short? PszValorGunu45 { get; set; }

    [Column("psz_komisyon_orani45")]
    public double? PszKomisyonOrani45 { get; set; }

    [Column("psz_odul_katkisi_orani45")]
    public double? PszOdulKatkisiOrani45 { get; set; }

    [Column("psz_erken_odeme_faiz_orani45")]
    public double? PszErkenOdemeFaizOrani45 { get; set; }

    [Column("psz_diger_komisyon_orani45")]
    public double? PszDigerKomisyonOrani45 { get; set; }

    [Column("psz_kart_sahip_tipi46")]
    public byte? PszKartSahipTipi46 { get; set; }

    [Column("psz_taksit_sayisi46")]
    public short? PszTaksitSayisi46 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi46")]
    public short? PszFirmayaOdemeTaksitSayisi46 { get; set; }

    [Column("psz_valor_gunu46")]
    public short? PszValorGunu46 { get; set; }

    [Column("psz_komisyon_orani46")]
    public double? PszKomisyonOrani46 { get; set; }

    [Column("psz_odul_katkisi_orani46")]
    public double? PszOdulKatkisiOrani46 { get; set; }

    [Column("psz_erken_odeme_faiz_orani46")]
    public double? PszErkenOdemeFaizOrani46 { get; set; }

    [Column("psz_diger_komisyon_orani46")]
    public double? PszDigerKomisyonOrani46 { get; set; }

    [Column("psz_kart_sahip_tipi47")]
    public byte? PszKartSahipTipi47 { get; set; }

    [Column("psz_taksit_sayisi47")]
    public short? PszTaksitSayisi47 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi47")]
    public short? PszFirmayaOdemeTaksitSayisi47 { get; set; }

    [Column("psz_valor_gunu47")]
    public short? PszValorGunu47 { get; set; }

    [Column("psz_komisyon_orani47")]
    public double? PszKomisyonOrani47 { get; set; }

    [Column("psz_odul_katkisi_orani47")]
    public double? PszOdulKatkisiOrani47 { get; set; }

    [Column("psz_erken_odeme_faiz_orani47")]
    public double? PszErkenOdemeFaizOrani47 { get; set; }

    [Column("psz_diger_komisyon_orani47")]
    public double? PszDigerKomisyonOrani47 { get; set; }

    [Column("psz_kart_sahip_tipi48")]
    public byte? PszKartSahipTipi48 { get; set; }

    [Column("psz_taksit_sayisi48")]
    public short? PszTaksitSayisi48 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi48")]
    public short? PszFirmayaOdemeTaksitSayisi48 { get; set; }

    [Column("psz_valor_gunu48")]
    public short? PszValorGunu48 { get; set; }

    [Column("psz_komisyon_orani48")]
    public double? PszKomisyonOrani48 { get; set; }

    [Column("psz_odul_katkisi_orani48")]
    public double? PszOdulKatkisiOrani48 { get; set; }

    [Column("psz_erken_odeme_faiz_orani48")]
    public double? PszErkenOdemeFaizOrani48 { get; set; }

    [Column("psz_diger_komisyon_orani48")]
    public double? PszDigerKomisyonOrani48 { get; set; }

    [Column("psz_kart_sahip_tipi49")]
    public byte? PszKartSahipTipi49 { get; set; }

    [Column("psz_taksit_sayisi49")]
    public short? PszTaksitSayisi49 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi49")]
    public short? PszFirmayaOdemeTaksitSayisi49 { get; set; }

    [Column("psz_valor_gunu49")]
    public short? PszValorGunu49 { get; set; }

    [Column("psz_komisyon_orani49")]
    public double? PszKomisyonOrani49 { get; set; }

    [Column("psz_odul_katkisi_orani49")]
    public double? PszOdulKatkisiOrani49 { get; set; }

    [Column("psz_erken_odeme_faiz_orani49")]
    public double? PszErkenOdemeFaizOrani49 { get; set; }

    [Column("psz_diger_komisyon_orani49")]
    public double? PszDigerKomisyonOrani49 { get; set; }

    [Column("psz_kart_sahip_tipi50")]
    public byte? PszKartSahipTipi50 { get; set; }

    [Column("psz_taksit_sayisi50")]
    public short? PszTaksitSayisi50 { get; set; }

    [Column("psz_firmaya_odeme_taksit_sayisi50")]
    public short? PszFirmayaOdemeTaksitSayisi50 { get; set; }

    [Column("psz_valor_gunu50")]
    public short? PszValorGunu50 { get; set; }

    [Column("psz_komisyon_orani50")]
    public double? PszKomisyonOrani50 { get; set; }

    [Column("psz_odul_katkisi_orani50")]
    public double? PszOdulKatkisiOrani50 { get; set; }

    [Column("psz_erken_odeme_faiz_orani50")]
    public double? PszErkenOdemeFaizOrani50 { get; set; }

    [Column("psz_diger_komisyon_orani50")]
    public double? PszDigerKomisyonOrani50 { get; set; }

    [Column("psz_taksit_valor_durumu")]
    public byte? PszTaksitValorDurumu { get; set; }

    [Column("psz_servis_komisyon_kesinti_durumu")]
    public byte? PszServisKomisyonKesintiDurumu { get; set; }

    [Column("psz_odul_katkisi_kesinti_durumu")]
    public byte? PszOdulKatkisiKesintiDurumu { get; set; }
}
