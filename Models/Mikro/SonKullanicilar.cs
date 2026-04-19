using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("son_kullanicilar")]
public class SonKullanicilar
{
    [Column("tuk_Guid")]
    public Guid? TukGuid { get; set; }

    [Column("tuk_DBCno")]
    public short? TukDBCno { get; set; }

    [Column("tuk_Spec_Rec_no")]
    public int? TukSpecRecNo { get; set; }

    [Column("tuk_iptal")]
    public bool? TukIptal { get; set; }

    [Column("tuk_fileid")]
    public short? TukFileid { get; set; }

    [Column("tuk_hidden")]
    public bool? TukHidden { get; set; }

    [Column("tuk_kilitli")]
    public bool? TukKilitli { get; set; }

    [Column("tuk_degisti")]
    public bool? TukDegisti { get; set; }

    [Column("tuk_checksum")]
    public int? TukChecksum { get; set; }

    [Column("tuk_create_user")]
    public short? TukCreateUser { get; set; }

    [Column("tuk_create_date")]
    public DateTime? TukCreateDate { get; set; }

    [Column("tuk_lastup_user")]
    public short? TukLastupUser { get; set; }

    [Column("tuk_lastup_date")]
    public DateTime? TukLastupDate { get; set; }

    [Column("tuk_special1")]
    [StringLength(4)]
    public string? TukSpecial1 { get; set; }

    [Column("tuk_special2")]
    [StringLength(4)]
    public string? TukSpecial2 { get; set; }

    [Column("tuk_special3")]
    [StringLength(4)]
    public string? TukSpecial3 { get; set; }

    [Column("tuk_kodu")]
    [StringLength(25)]
    public string? TukKodu { get; set; }

    [Column("tuk_ismi")]
    [StringLength(30)]
    public string? TukIsmi { get; set; }

    [Column("tuk_Adr1_Cadde")]
    [StringLength(50)]
    public string? TukAdr1Cadde { get; set; }

    [Column("tuk_Adr1_mahalle")]
    [StringLength(50)]
    public string? TukAdr1Mahalle { get; set; }

    [Column("tuk_Adr1_Sokak")]
    [StringLength(50)]
    public string? TukAdr1Sokak { get; set; }

    [Column("tuk_Adr1_Semt")]
    [StringLength(25)]
    public string? TukAdr1Semt { get; set; }

    [Column("tuk_Adr1_Apt_No")]
    [StringLength(10)]
    public string? TukAdr1AptNo { get; set; }

    [Column("tuk_Adr1_Daire_No")]
    [StringLength(10)]
    public string? TukAdr1DaireNo { get; set; }

    [Column("tuk_Adr1_Postakodu")]
    [StringLength(8)]
    public string? TukAdr1Postakodu { get; set; }

    [Column("tuk_Adr1_Ilce")]
    [StringLength(50)]
    public string? TukAdr1Ilce { get; set; }

    [Column("tuk_Adr1_Il")]
    [StringLength(50)]
    public string? TukAdr1Il { get; set; }

    [Column("tuk_Adr1_Ulke")]
    [StringLength(50)]
    public string? TukAdr1Ulke { get; set; }

    [Column("tuk_Adr1_Adres_kodu")]
    [StringLength(10)]
    public string? TukAdr1AdresKodu { get; set; }

    [Column("tuk_Adr2_Cadde")]
    [StringLength(50)]
    public string? TukAdr2Cadde { get; set; }

    [Column("tuk_Adr2_mahalle")]
    [StringLength(50)]
    public string? TukAdr2Mahalle { get; set; }

    [Column("tuk_Adr2_Sokak")]
    [StringLength(50)]
    public string? TukAdr2Sokak { get; set; }

    [Column("tuk_Adr2_Semt")]
    [StringLength(25)]
    public string? TukAdr2Semt { get; set; }

    [Column("tuk_Adr2_Apt_No")]
    [StringLength(10)]
    public string? TukAdr2AptNo { get; set; }

    [Column("tuk_Adr2_Daire_No")]
    [StringLength(10)]
    public string? TukAdr2DaireNo { get; set; }

    [Column("tuk_Adr2_Postakodu")]
    [StringLength(8)]
    public string? TukAdr2Postakodu { get; set; }

    [Column("tuk_Adr2_Ilce")]
    [StringLength(50)]
    public string? TukAdr2Ilce { get; set; }

    [Column("tuk_Adr2_Il")]
    [StringLength(50)]
    public string? TukAdr2Il { get; set; }

    [Column("tuk_Adr2_Ulke")]
    [StringLength(50)]
    public string? TukAdr2Ulke { get; set; }

    [Column("tuk_Adr2_Adres_kodu")]
    [StringLength(10)]
    public string? TukAdr2AdresKodu { get; set; }

    [Column("tuk_Tel1_Ulkekod")]
    [StringLength(5)]
    public string? TukTel1Ulkekod { get; set; }

    [Column("tuk_Tel1_Bolgekod")]
    [StringLength(5)]
    public string? TukTel1Bolgekod { get; set; }

    [Column("tuk_Tel1_TelNo1")]
    [StringLength(10)]
    public string? TukTel1TelNo1 { get; set; }

    [Column("tuk_Tel1_TelNo2")]
    [StringLength(10)]
    public string? TukTel1TelNo2 { get; set; }

    [Column("tuk_Tel1_FaxNo")]
    [StringLength(10)]
    public string? TukTel1FaxNo { get; set; }

    [Column("tuk_Tel1_ModemNo")]
    [StringLength(10)]
    public string? TukTel1ModemNo { get; set; }

    [Column("tuk_Tel2_Ulkekod")]
    [StringLength(5)]
    public string? TukTel2Ulkekod { get; set; }

    [Column("tuk_Tel2_Bolgekod")]
    [StringLength(5)]
    public string? TukTel2Bolgekod { get; set; }

    [Column("tuk_Tel2_TelNo1")]
    [StringLength(10)]
    public string? TukTel2TelNo1 { get; set; }

    [Column("tuk_Tel2_TelNo2")]
    [StringLength(10)]
    public string? TukTel2TelNo2 { get; set; }

    [Column("tuk_Tel2_FaxNo")]
    [StringLength(10)]
    public string? TukTel2FaxNo { get; set; }

    [Column("tuk_Tel2_ModemNo")]
    [StringLength(10)]
    public string? TukTel2ModemNo { get; set; }

    [Column("tuk_yetkili1")]
    [StringLength(50)]
    public string? TukYetkili1 { get; set; }

    [Column("tuk_yetkili2")]
    [StringLength(50)]
    public string? TukYetkili2 { get; set; }

    [Column("tuk_ceptel1")]
    [StringLength(20)]
    public string? TukCeptel1 { get; set; }

    [Column("tuk_ceptel2")]
    [StringLength(20)]
    public string? TukCeptel2 { get; set; }

    [Column("tuk_email1")]
    [StringLength(70)]
    public string? TukEmail1 { get; set; }

    [Column("tuk_email2")]
    [StringLength(70)]
    public string? TukEmail2 { get; set; }

    [Column("tuk_GrpKodu")]
    [StringLength(25)]
    public string? TukGrpKodu { get; set; }

    [Column("tuk_MuhKodu")]
    [StringLength(25)]
    public string? TukMuhKodu { get; set; }

    [Column("tuk_kilitli_flg")]
    public bool? TukKilitliFlg { get; set; }

    [Column("tuk_cari_kodu")]
    [StringLength(25)]
    public string? TukCariKodu { get; set; }

    [Column("tuk_sektor_kodu")]
    [StringLength(25)]
    public string? TukSektorKodu { get; set; }

    [Column("tuk_bolge_kodu")]
    [StringLength(25)]
    public string? TukBolgeKodu { get; set; }
}
