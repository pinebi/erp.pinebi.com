using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("vergi_tahakkuklari")]
public class VergiTahakkuklari
{
    [Column("fh_Guid")]
    public Guid? FhGuid { get; set; }

    [Column("fh_DBCno")]
    public short? FhDBCno { get; set; }

    [Column("fh_SpecRECno")]
    public int? FhSpecRECno { get; set; }

    [Column("fh_iptal")]
    public bool? FhIptal { get; set; }

    [Column("fh_fileid")]
    public short? FhFileid { get; set; }

    [Column("fh_hidden")]
    public bool? FhHidden { get; set; }

    [Column("fh_kilitli")]
    public bool? FhKilitli { get; set; }

    [Column("fh_degisti")]
    public bool? FhDegisti { get; set; }

    [Column("fh_checksum")]
    public int? FhChecksum { get; set; }

    [Column("fh_create_user")]
    public short? FhCreateUser { get; set; }

    [Column("fh_create_date")]
    public DateTime? FhCreateDate { get; set; }

    [Column("fh_lastup_user")]
    public short? FhLastupUser { get; set; }

    [Column("fh_lastup_date")]
    public DateTime? FhLastupDate { get; set; }

    [Column("fh_special1")]
    [StringLength(4)]
    public string? FhSpecial1 { get; set; }

    [Column("fh_special2")]
    [StringLength(4)]
    public string? FhSpecial2 { get; set; }

    [Column("fh_special3")]
    [StringLength(4)]
    public string? FhSpecial3 { get; set; }

    [Column("fh_firmano")]
    public int? FhFirmano { get; set; }

    [Column("fh_tarih")]
    public DateTime? FhTarih { get; set; }

    [Column("fh_islem")]
    public short? FhIslem { get; set; }

    [Column("fh_donem")]
    public short? FhDonem { get; set; }

    [Column("fh_tutar")]
    public double? FhTutar { get; set; }

    [Column("fh_tip")]
    public byte? FhTip { get; set; }

    [Column("fh_evrno_seri")]
    [StringLength(50)]
    public string? FhEvrnoSeri { get; set; }

    [Column("fh_evrno_sira")]
    public int? FhEvrnoSira { get; set; }

    [Column("fh_sekli")]
    public byte? FhSekli { get; set; }

    [Column("fh_aciklama")]
    [StringLength(20)]
    public string? FhAciklama { get; set; }

    [Column("fh_yeri")]
    [StringLength(20)]
    public string? FhYeri { get; set; }

    [Column("fh_matrah")]
    public double? FhMatrah { get; set; }

    [Column("fh_mahsup")]
    public double? FhMahsup { get; set; }

    [Column("fh_SatirNo")]
    public int? FhSatirNo { get; set; }

    [Column("fh_Vade")]
    public DateTime? FhVade { get; set; }

    [Column("fh_OdemeNo")]
    [StringLength(8)]
    public string? FhOdemeNo { get; set; }

    [Column("fh_TahakkukNo")]
    [StringLength(25)]
    public string? FhTahakkukNo { get; set; }

    [Column("fh_dbkodu")]
    [StringLength(25)]
    public string? FhDbkodu { get; set; }
}
