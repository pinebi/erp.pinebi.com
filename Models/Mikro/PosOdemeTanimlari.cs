using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("pos_odeme_tanimlari")]
public class PosOdemeTanimlari
{
    [Column("POT_Guid")]
    public Guid? POTGuid { get; set; }

    [Column("POT_DBCno")]
    public short? POTDBCno { get; set; }

    [Column("POT_Spec_Rec_no")]
    public int? POTSpecRecNo { get; set; }

    [Column("POT_iptal")]
    public bool? POTIptal { get; set; }

    [Column("POT_fileid")]
    public short? POTFileid { get; set; }

    [Column("POT_hidden")]
    public bool? POTHidden { get; set; }

    [Column("POT_kilitli")]
    public bool? POTKilitli { get; set; }

    [Column("POT_degisti")]
    public bool? POTDegisti { get; set; }

    [Column("POT_checksum")]
    public int? POTChecksum { get; set; }

    [Column("POT_create_user")]
    public short? POTCreateUser { get; set; }

    [Column("POT_create_date")]
    public DateTime? POTCreateDate { get; set; }

    [Column("POT_lastup_user")]
    public short? POTLastupUser { get; set; }

    [Column("POT_lastup_date")]
    public DateTime? POTLastupDate { get; set; }

    [Column("POT_special1")]
    [StringLength(4)]
    public string? POTSpecial1 { get; set; }

    [Column("POT_special2")]
    [StringLength(4)]
    public string? POTSpecial2 { get; set; }

    [Column("POT_special3")]
    [StringLength(4)]
    public string? POTSpecial3 { get; set; }

    [Column("POT_No")]
    public byte? POTNo { get; set; }

    [Column("POT_Adi")]
    [StringLength(25)]
    public string? POTAdi { get; set; }

    [Column("POT_CariCinsi")]
    public byte? POTCariCinsi { get; set; }

    [Column("POT_CariKodu")]
    [StringLength(25)]
    public string? POTCariKodu { get; set; }

    [Column("POT_DovizCinsi")]
    public byte? POTDovizCinsi { get; set; }

    [Column("POT_Tipi")]
    public byte? POTTipi { get; set; }

    [Column("POT_KrediKartVadesi")]
    public byte? POTKrediKartVadesi { get; set; }

    [Column("POT_TaksitSayisi")]
    public byte? POTTaksitSayisi { get; set; }

    [Column("POT_NixdorfDvz")]
    [StringLength(2)]
    public string? POTNixdorfDvz { get; set; }

    [Column("POT_FiyatKodu")]
    public int? POTFiyatKodu { get; set; }

    [Column("POT_CariGrupKodu")]
    [StringLength(25)]
    public string? POTCariGrupKodu { get; set; }

    [Column("POT_TCMB_Kodu")]
    [StringLength(4)]
    public string? POTTCMBKodu { get; set; }

    [Column("POT_TCMB_Puan")]
    public bool? POTTCMBPuan { get; set; }

    [Column("POT_GuvenlikKontrolu")]
    public byte? POTGuvenlikKontrolu { get; set; }

    [Column("POT_Shop9000_OdemeTipi")]
    public byte? POTShop9000OdemeTipi { get; set; }

    [Column("POT_Genius220_OdemeTipi")]
    public byte? POTGenius220OdemeTipi { get; set; }

    [Column("POT_GeniusIII_OdemeTipi")]
    public byte? POTGeniusIIIOdemeTipi { get; set; }

    [Column("POT_Wincor143_OdemeTipi")]
    public byte? POTWincor143OdemeTipi { get; set; }

    [Column("POT_Wincor148_OdemeTipi")]
    public byte? POTWincor148OdemeTipi { get; set; }

    [Column("POT_Wincor150_OdemeTipi")]
    public byte? POTWincor150OdemeTipi { get; set; }

    [Column("POT_IntPOS_OdemeTipi")]
    public byte? POTIntPOSOdemeTipi { get; set; }

    [Column("POT_IntMPOS2001_OdemeTipi")]
    public byte? POTIntMPOS2001OdemeTipi { get; set; }

    [Column("POT_EsPOS_OdemeTipi")]
    public byte? POTEsPOSOdemeTipi { get; set; }

    [Column("POT_EsPOS4000_OdemeTipi")]
    public byte? POTEsPOS4000OdemeTipi { get; set; }

    [Column("POT_Tera_OdemeTipi")]
    public byte? POTTeraOdemeTipi { get; set; }

    [Column("POT_OLE5700_OdemeTipi")]
    public byte? POTOLE5700OdemeTipi { get; set; }

    [Column("POT_EsPOS5000_OdemeTipi")]
    public byte? POTEsPOS5000OdemeTipi { get; set; }

    [Column("POT_Genius2_SQL_OdemeTipi")]
    public byte? POTGenius2SQLOdemeTipi { get; set; }

    [Column("POT_HuginPOS_OdemeTipi")]
    public byte? POTHuginPOSOdemeTipi { get; set; }

    [Column("POT_Beko_500_OdemeTipi")]
    public byte? POTBeko500OdemeTipi { get; set; }

    [Column("POT_EnPOS_YNOKC_OdemeTipi")]
    public byte? POTEnPOSYNOKCOdemeTipi { get; set; }

    [Column("POT_Olivetti_PBT_OdemeTipi")]
    public byte? POTOlivettiPBTOdemeTipi { get; set; }

    [Column("POT_TaksitTanim1_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim1Adi { get; set; }

    [Column("POT_TaksitTanim1_Odeme")]
    public int? POTTaksitTanim1Odeme { get; set; }

    [Column("POT_TaksitTanim1_FiyatKodu")]
    public int? POTTaksitTanim1FiyatKodu { get; set; }

    [Column("POT_TaksitTanim1_GuvenlikKontrolu")]
    public byte? POTTaksitTanim1GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim1_KKartTaksitSayisi")]
    public byte? POTTaksitTanim1KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim2_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim2Adi { get; set; }

    [Column("POT_TaksitTanim2_Odeme")]
    public int? POTTaksitTanim2Odeme { get; set; }

    [Column("POT_TaksitTanim2_FiyatKodu")]
    public int? POTTaksitTanim2FiyatKodu { get; set; }

    [Column("POT_TaksitTanim2_GuvenlikKontrolu")]
    public byte? POTTaksitTanim2GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim2_KKartTaksitSayisi")]
    public byte? POTTaksitTanim2KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim3_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim3Adi { get; set; }

    [Column("POT_TaksitTanim3_Odeme")]
    public int? POTTaksitTanim3Odeme { get; set; }

    [Column("POT_TaksitTanim3_FiyatKodu")]
    public int? POTTaksitTanim3FiyatKodu { get; set; }

    [Column("POT_TaksitTanim3_GuvenlikKontrolu")]
    public byte? POTTaksitTanim3GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim3_KKartTaksitSayisi")]
    public byte? POTTaksitTanim3KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim4_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim4Adi { get; set; }

    [Column("POT_TaksitTanim4_Odeme")]
    public int? POTTaksitTanim4Odeme { get; set; }

    [Column("POT_TaksitTanim4_FiyatKodu")]
    public int? POTTaksitTanim4FiyatKodu { get; set; }

    [Column("POT_TaksitTanim4_GuvenlikKontrolu")]
    public byte? POTTaksitTanim4GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim4_KKartTaksitSayisi")]
    public byte? POTTaksitTanim4KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim5_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim5Adi { get; set; }

    [Column("POT_TaksitTanim5_Odeme")]
    public int? POTTaksitTanim5Odeme { get; set; }

    [Column("POT_TaksitTanim5_FiyatKodu")]
    public int? POTTaksitTanim5FiyatKodu { get; set; }

    [Column("POT_TaksitTanim5_GuvenlikKontrolu")]
    public byte? POTTaksitTanim5GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim5_KKartTaksitSayisi")]
    public byte? POTTaksitTanim5KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim6_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim6Adi { get; set; }

    [Column("POT_TaksitTanim6_Odeme")]
    public int? POTTaksitTanim6Odeme { get; set; }

    [Column("POT_TaksitTanim6_FiyatKodu")]
    public int? POTTaksitTanim6FiyatKodu { get; set; }

    [Column("POT_TaksitTanim6_GuvenlikKontrolu")]
    public byte? POTTaksitTanim6GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim6_KKartTaksitSayisi")]
    public byte? POTTaksitTanim6KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim7_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim7Adi { get; set; }

    [Column("POT_TaksitTanim7_Odeme")]
    public int? POTTaksitTanim7Odeme { get; set; }

    [Column("POT_TaksitTanim7_FiyatKodu")]
    public int? POTTaksitTanim7FiyatKodu { get; set; }

    [Column("POT_TaksitTanim7_GuvenlikKontrolu")]
    public byte? POTTaksitTanim7GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim7_KKartTaksitSayisi")]
    public byte? POTTaksitTanim7KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim8_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim8Adi { get; set; }

    [Column("POT_TaksitTanim8_Odeme")]
    public int? POTTaksitTanim8Odeme { get; set; }

    [Column("POT_TaksitTanim8_FiyatKodu")]
    public int? POTTaksitTanim8FiyatKodu { get; set; }

    [Column("POT_TaksitTanim8_GuvenlikKontrolu")]
    public byte? POTTaksitTanim8GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim8_KKartTaksitSayisi")]
    public byte? POTTaksitTanim8KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim9_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim9Adi { get; set; }

    [Column("POT_TaksitTanim9_Odeme")]
    public int? POTTaksitTanim9Odeme { get; set; }

    [Column("POT_TaksitTanim9_FiyatKodu")]
    public int? POTTaksitTanim9FiyatKodu { get; set; }

    [Column("POT_TaksitTanim9_GuvenlikKontrolu")]
    public byte? POTTaksitTanim9GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim9_KKartTaksitSayisi")]
    public byte? POTTaksitTanim9KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim10_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim10Adi { get; set; }

    [Column("POT_TaksitTanim10_Odeme")]
    public int? POTTaksitTanim10Odeme { get; set; }

    [Column("POT_TaksitTanim10_FiyatKodu")]
    public int? POTTaksitTanim10FiyatKodu { get; set; }

    [Column("POT_TaksitTanim10_GuvenlikKontrolu")]
    public byte? POTTaksitTanim10GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim10_KKartTaksitSayisi")]
    public byte? POTTaksitTanim10KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim11_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim11Adi { get; set; }

    [Column("POT_TaksitTanim11_Odeme")]
    public int? POTTaksitTanim11Odeme { get; set; }

    [Column("POT_TaksitTanim11_FiyatKodu")]
    public int? POTTaksitTanim11FiyatKodu { get; set; }

    [Column("POT_TaksitTanim11_GuvenlikKontrolu")]
    public byte? POTTaksitTanim11GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim11_KKartTaksitSayisi")]
    public byte? POTTaksitTanim11KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim12_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim12Adi { get; set; }

    [Column("POT_TaksitTanim12_Odeme")]
    public int? POTTaksitTanim12Odeme { get; set; }

    [Column("POT_TaksitTanim12_FiyatKodu")]
    public int? POTTaksitTanim12FiyatKodu { get; set; }

    [Column("POT_TaksitTanim12_GuvenlikKontrolu")]
    public byte? POTTaksitTanim12GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim12_KKartTaksitSayisi")]
    public byte? POTTaksitTanim12KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim13_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim13Adi { get; set; }

    [Column("POT_TaksitTanim13_Odeme")]
    public int? POTTaksitTanim13Odeme { get; set; }

    [Column("POT_TaksitTanim13_FiyatKodu")]
    public int? POTTaksitTanim13FiyatKodu { get; set; }

    [Column("POT_TaksitTanim13_GuvenlikKontrolu")]
    public byte? POTTaksitTanim13GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim13_KKartTaksitSayisi")]
    public byte? POTTaksitTanim13KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim14_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim14Adi { get; set; }

    [Column("POT_TaksitTanim14_Odeme")]
    public int? POTTaksitTanim14Odeme { get; set; }

    [Column("POT_TaksitTanim14_FiyatKodu")]
    public int? POTTaksitTanim14FiyatKodu { get; set; }

    [Column("POT_TaksitTanim14_GuvenlikKontrolu")]
    public byte? POTTaksitTanim14GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim14_KKartTaksitSayisi")]
    public byte? POTTaksitTanim14KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim15_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim15Adi { get; set; }

    [Column("POT_TaksitTanim15_Odeme")]
    public int? POTTaksitTanim15Odeme { get; set; }

    [Column("POT_TaksitTanim15_FiyatKodu")]
    public int? POTTaksitTanim15FiyatKodu { get; set; }

    [Column("POT_TaksitTanim15_GuvenlikKontrolu")]
    public byte? POTTaksitTanim15GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim15_KKartTaksitSayisi")]
    public byte? POTTaksitTanim15KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim16_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim16Adi { get; set; }

    [Column("POT_TaksitTanim16_Odeme")]
    public int? POTTaksitTanim16Odeme { get; set; }

    [Column("POT_TaksitTanim16_FiyatKodu")]
    public int? POTTaksitTanim16FiyatKodu { get; set; }

    [Column("POT_TaksitTanim16_GuvenlikKontrolu")]
    public byte? POTTaksitTanim16GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim16_KKartTaksitSayisi")]
    public byte? POTTaksitTanim16KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim17_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim17Adi { get; set; }

    [Column("POT_TaksitTanim17_Odeme")]
    public int? POTTaksitTanim17Odeme { get; set; }

    [Column("POT_TaksitTanim17_FiyatKodu")]
    public int? POTTaksitTanim17FiyatKodu { get; set; }

    [Column("POT_TaksitTanim17_GuvenlikKontrolu")]
    public byte? POTTaksitTanim17GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim17_KKartTaksitSayisi")]
    public byte? POTTaksitTanim17KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim18_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim18Adi { get; set; }

    [Column("POT_TaksitTanim18_Odeme")]
    public int? POTTaksitTanim18Odeme { get; set; }

    [Column("POT_TaksitTanim18_FiyatKodu")]
    public int? POTTaksitTanim18FiyatKodu { get; set; }

    [Column("POT_TaksitTanim18_GuvenlikKontrolu")]
    public byte? POTTaksitTanim18GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim18_KKartTaksitSayisi")]
    public byte? POTTaksitTanim18KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim19_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim19Adi { get; set; }

    [Column("POT_TaksitTanim19_Odeme")]
    public int? POTTaksitTanim19Odeme { get; set; }

    [Column("POT_TaksitTanim19_FiyatKodu")]
    public int? POTTaksitTanim19FiyatKodu { get; set; }

    [Column("POT_TaksitTanim19_GuvenlikKontrolu")]
    public byte? POTTaksitTanim19GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim19_KKartTaksitSayisi")]
    public byte? POTTaksitTanim19KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim20_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim20Adi { get; set; }

    [Column("POT_TaksitTanim20_Odeme")]
    public int? POTTaksitTanim20Odeme { get; set; }

    [Column("POT_TaksitTanim20_FiyatKodu")]
    public int? POTTaksitTanim20FiyatKodu { get; set; }

    [Column("POT_TaksitTanim20_GuvenlikKontrolu")]
    public byte? POTTaksitTanim20GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim20_KKartTaksitSayisi")]
    public byte? POTTaksitTanim20KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim21_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim21Adi { get; set; }

    [Column("POT_TaksitTanim21_Odeme")]
    public int? POTTaksitTanim21Odeme { get; set; }

    [Column("POT_TaksitTanim21_FiyatKodu")]
    public int? POTTaksitTanim21FiyatKodu { get; set; }

    [Column("POT_TaksitTanim21_GuvenlikKontrolu")]
    public byte? POTTaksitTanim21GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim21_KKartTaksitSayisi")]
    public byte? POTTaksitTanim21KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim22_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim22Adi { get; set; }

    [Column("POT_TaksitTanim22_Odeme")]
    public int? POTTaksitTanim22Odeme { get; set; }

    [Column("POT_TaksitTanim22_FiyatKodu")]
    public int? POTTaksitTanim22FiyatKodu { get; set; }

    [Column("POT_TaksitTanim22_GuvenlikKontrolu")]
    public byte? POTTaksitTanim22GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim22_KKartTaksitSayisi")]
    public byte? POTTaksitTanim22KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim23_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim23Adi { get; set; }

    [Column("POT_TaksitTanim23_Odeme")]
    public int? POTTaksitTanim23Odeme { get; set; }

    [Column("POT_TaksitTanim23_FiyatKodu")]
    public int? POTTaksitTanim23FiyatKodu { get; set; }

    [Column("POT_TaksitTanim23_GuvenlikKontrolu")]
    public byte? POTTaksitTanim23GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim23_KKartTaksitSayisi")]
    public byte? POTTaksitTanim23KKartTaksitSayisi { get; set; }

    [Column("POT_TaksitTanim24_Adi")]
    [StringLength(20)]
    public string? POTTaksitTanim24Adi { get; set; }

    [Column("POT_TaksitTanim24_Odeme")]
    public int? POTTaksitTanim24Odeme { get; set; }

    [Column("POT_TaksitTanim24_FiyatKodu")]
    public int? POTTaksitTanim24FiyatKodu { get; set; }

    [Column("POT_TaksitTanim24_GuvenlikKontrolu")]
    public byte? POTTaksitTanim24GuvenlikKontrolu { get; set; }

    [Column("POT_TaksitTanim24_KKartTaksitSayisi")]
    public byte? POTTaksitTanim24KKartTaksitSayisi { get; set; }
}
