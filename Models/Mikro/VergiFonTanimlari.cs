using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("vergi_fon_tanimlari")]
public class VergiFonTanimlari
{
    [Column("vf_Guid")]
    public Guid? VfGuid { get; set; }

    [Column("vf_DBCno")]
    public short? VfDBCno { get; set; }

    [Column("vf_SpecRECno")]
    public int? VfSpecRECno { get; set; }

    [Column("vf_iptal")]
    public bool? VfIptal { get; set; }

    [Column("vf_fileid")]
    public short? VfFileid { get; set; }

    [Column("vf_hidden")]
    public bool? VfHidden { get; set; }

    [Column("vf_kilitli")]
    public bool? VfKilitli { get; set; }

    [Column("vf_degisti")]
    public bool? VfDegisti { get; set; }

    [Column("vf_checksum")]
    public int? VfChecksum { get; set; }

    [Column("vf_create_user")]
    public short? VfCreateUser { get; set; }

    [Column("vf_create_date")]
    public DateTime? VfCreateDate { get; set; }

    [Column("vf_lastup_user")]
    public short? VfLastupUser { get; set; }

    [Column("vf_lastup_date")]
    public DateTime? VfLastupDate { get; set; }

    [Column("vf_special1")]
    [StringLength(4)]
    public string? VfSpecial1 { get; set; }

    [Column("vf_special2")]
    [StringLength(4)]
    public string? VfSpecial2 { get; set; }

    [Column("vf_special3")]
    [StringLength(4)]
    public string? VfSpecial3 { get; set; }

    [Column("vf_firma_no")]
    public int? VfFirmaNo { get; set; }

    [Column("vf_sira_no")]
    public short? VfSiraNo { get; set; }

    [Column("vf_kodu")]
    [StringLength(5)]
    public string? VfKodu { get; set; }

    [Column("vf_uzun_adi")]
    [StringLength(127)]
    public string? VfUzunAdi { get; set; }

    [Column("vf_kisa_adi")]
    [StringLength(50)]
    public string? VfKisaAdi { get; set; }

    [Column("vf_orani")]
    [StringLength(50)]
    public string? VfOrani { get; set; }

    [Column("vf_sabit_tutar")]
    [StringLength(50)]
    public string? VfSabitTutar { get; set; }

    [Column("vf_giris_masraf_kodu")]
    [StringLength(25)]
    public string? VfGirisMasrafKodu { get; set; }

    [Column("vf_giris_muh_kodu")]
    [StringLength(40)]
    public string? VfGirisMuhKodu { get; set; }

    [Column("vf_cikis_muh_kodu")]
    [StringLength(40)]
    public string? VfCikisMuhKodu { get; set; }

    [Column("vf_kdvli")]
    [StringLength(50)]
    public string? VfKdvli { get; set; }

    [Column("vf_bsbayadahil")]
    [StringLength(50)]
    public string? VfBsbayadahil { get; set; }
}
