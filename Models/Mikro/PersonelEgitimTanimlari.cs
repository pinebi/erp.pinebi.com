using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitim_tanimlari")]
public class PersonelEgitimTanimlari
{
    [Column("egt_Guid")]
    public Guid? EgtGuid { get; set; }

    [Column("egt_DBCno")]
    public short? EgtDBCno { get; set; }

    [Column("egt_SpecRECno")]
    public int? EgtSpecRECno { get; set; }

    [Column("egt_iptal")]
    public bool? EgtIptal { get; set; }

    [Column("egt_fileid")]
    public short? EgtFileid { get; set; }

    [Column("egt_hidden")]
    public bool? EgtHidden { get; set; }

    [Column("egt_kilitli")]
    public bool? EgtKilitli { get; set; }

    [Column("egt_degisti")]
    public bool? EgtDegisti { get; set; }

    [Column("egt_checksum")]
    public int? EgtChecksum { get; set; }

    [Column("egt_create_user")]
    public short? EgtCreateUser { get; set; }

    [Column("egt_create_date")]
    public DateTime? EgtCreateDate { get; set; }

    [Column("egt_lastup_user")]
    public short? EgtLastupUser { get; set; }

    [Column("egt_lastup_date")]
    public DateTime? EgtLastupDate { get; set; }

    [Column("egt_special1")]
    [StringLength(4)]
    public string? EgtSpecial1 { get; set; }

    [Column("egt_special2")]
    [StringLength(4)]
    public string? EgtSpecial2 { get; set; }

    [Column("egt_special3")]
    [StringLength(4)]
    public string? EgtSpecial3 { get; set; }

    [Column("egt_kodu")]
    [StringLength(25)]
    public string? EgtKodu { get; set; }

    [Column("egt_adi")]
    [StringLength(40)]
    public string? EgtAdi { get; set; }

    [Column("egt_tipi")]
    public byte? EgtTipi { get; set; }

    [Column("egt_puan")]
    public double? EgtPuan { get; set; }

    [Column("egt_suresi")]
    public int? EgtSuresi { get; set; }

    [Column("egt_peryodu")]
    public byte? EgtPeryodu { get; set; }

    [Column("egt_peryotgunu")]
    public double? EgtPeryotgunu { get; set; }

    [Column("egt_perhaftasi")]
    public byte? EgtPerhaftasi { get; set; }

    [Column("egt_pergunu2_1")]
    public bool? EgtPergunu21 { get; set; }

    [Column("egt_pergunu2_2")]
    public bool? EgtPergunu22 { get; set; }

    [Column("egt_pergunu2_3")]
    public bool? EgtPergunu23 { get; set; }

    [Column("egt_pergunu2_4")]
    public bool? EgtPergunu24 { get; set; }

    [Column("egt_pergunu2_5")]
    public bool? EgtPergunu25 { get; set; }

    [Column("egt_pergunu2_6")]
    public bool? EgtPergunu26 { get; set; }

    [Column("egt_pergunu2_7")]
    public bool? EgtPergunu27 { get; set; }

    [Column("egt_bastar")]
    public DateTime? EgtBastar { get; set; }

    [Column("egt_bitistar")]
    public DateTime? EgtBitistar { get; set; }

    [Column("egt_plan_butce")]
    public double? EgtPlanButce { get; set; }

    [Column("egt_doviz_cinsi")]
    public byte? EgtDovizCinsi { get; set; }

    [Column("egt_doviz_kuru")]
    public double? EgtDovizKuru { get; set; }

    [Column("egt_egitim_yer_kodu")]
    [StringLength(25)]
    public string? EgtEgitimYerKodu { get; set; }

    [Column("egt_konu_kodu")]
    [StringLength(25)]
    public string? EgtKonuKodu { get; set; }

    [Column("egt_amac_kodu")]
    [StringLength(25)]
    public string? EgtAmacKodu { get; set; }

    [Column("egt_aciklama1")]
    [StringLength(120)]
    public string? EgtAciklama1 { get; set; }

    [Column("egt_aciklama2")]
    [StringLength(120)]
    public string? EgtAciklama2 { get; set; }

    [Column("egt_aciklama3")]
    [StringLength(120)]
    public string? EgtAciklama3 { get; set; }

    [Column("egt_maxKatilimci")]
    public int? EgtMaxKatilimci { get; set; }

    [Column("egt_sertifika_fl")]
    public bool? EgtSertifikaFl { get; set; }
}
