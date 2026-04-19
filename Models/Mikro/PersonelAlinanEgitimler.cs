using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_alinan_egitimler")]
public class PersonelAlinanEgitimler
{
    [Column("aeg_Guid")]
    public Guid? AegGuid { get; set; }

    [Column("aeg_DBCno")]
    public short? AegDBCno { get; set; }

    [Column("aeg_SpecRECno")]
    public int? AegSpecRECno { get; set; }

    [Column("aeg_iptal")]
    public bool? AegIptal { get; set; }

    [Column("aeg_fileid")]
    public short? AegFileid { get; set; }

    [Column("aeg_hidden")]
    public bool? AegHidden { get; set; }

    [Column("aeg_kilitli")]
    public bool? AegKilitli { get; set; }

    [Column("aeg_degisti")]
    public bool? AegDegisti { get; set; }

    [Column("aeg_checksum")]
    public int? AegChecksum { get; set; }

    [Column("aeg_create_user")]
    public short? AegCreateUser { get; set; }

    [Column("aeg_create_date")]
    public DateTime? AegCreateDate { get; set; }

    [Column("aeg_lastup_user")]
    public short? AegLastupUser { get; set; }

    [Column("aeg_lastup_date")]
    public DateTime? AegLastupDate { get; set; }

    [Column("aeg_special1")]
    [StringLength(4)]
    public string? AegSpecial1 { get; set; }

    [Column("aeg_special2")]
    [StringLength(4)]
    public string? AegSpecial2 { get; set; }

    [Column("aeg_special3")]
    [StringLength(4)]
    public string? AegSpecial3 { get; set; }

    [Column("aeg_firmano")]
    public int? AegFirmano { get; set; }

    [Column("aeg_subeno")]
    public int? AegSubeno { get; set; }

    [Column("aeg_tarih")]
    public DateTime? AegTarih { get; set; }

    [Column("aeg_evrakno_seri")]
    [StringLength(50)]
    public string? AegEvraknoSeri { get; set; }

    [Column("aeg_evrakno_sira")]
    public int? AegEvraknoSira { get; set; }

    [Column("aeg_egitim_kodu")]
    [StringLength(25)]
    public string? AegEgitimKodu { get; set; }

    [Column("aeg_satirno")]
    public int? AegSatirno { get; set; }

    [Column("aeg_durumu")]
    public byte? AegDurumu { get; set; }

    [Column("aeg_bastar")]
    public DateTime? AegBastar { get; set; }

    [Column("aeg_bitistar")]
    public DateTime? AegBitistar { get; set; }

    [Column("aeg_butce")]
    public double? AegButce { get; set; }

    [Column("aeg_per_kodu")]
    [StringLength(25)]
    public string? AegPerKodu { get; set; }

    [Column("aeg_sinav_puan")]
    public double? AegSinavPuan { get; set; }

    [Column("aeg_Onay_puan1")]
    public double? AegOnayPuan1 { get; set; }

    [Column("aeg_Onay_puan2")]
    public double? AegOnayPuan2 { get; set; }

    [Column("aeg_Onay_puan3")]
    public double? AegOnayPuan3 { get; set; }

    [Column("aeg_aciklama1")]
    [StringLength(80)]
    public string? AegAciklama1 { get; set; }

    [Column("aeg_aciklama2")]
    [StringLength(80)]
    public string? AegAciklama2 { get; set; }

    [Column("aeg_aciklama3")]
    [StringLength(80)]
    public string? AegAciklama3 { get; set; }

    [Column("aeg_bagli_talep_uid")]
    public Guid? AegBagliTalepUid { get; set; }

    [Column("aeg_egitim_grup_kodu")]
    [StringLength(25)]
    public string? AegEgitimGrupKodu { get; set; }

    [Column("aeg_egitim_alt_grup_kodu")]
    [StringLength(25)]
    public string? AegEgitimAltGrupKodu { get; set; }
}
