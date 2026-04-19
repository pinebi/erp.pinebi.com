using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avmkira_odemeleri")]
public class AvmkiraOdemeleri
{
    [Column("Avmko_Guid")]
    public Guid? AvmkoGuid { get; set; }

    [Column("Avmko_DBCno")]
    public short? AvmkoDBCno { get; set; }

    [Column("Avmko_SpecRECno")]
    public int? AvmkoSpecRECno { get; set; }

    [Column("Avmko_iptal")]
    public bool? AvmkoIptal { get; set; }

    [Column("Avmko_fileid")]
    public short? AvmkoFileid { get; set; }

    [Column("Avmko_hidden")]
    public bool? AvmkoHidden { get; set; }

    [Column("Avmko_kilitli")]
    public bool? AvmkoKilitli { get; set; }

    [Column("Avmko_degisti")]
    public bool? AvmkoDegisti { get; set; }

    [Column("Avmko_checksum")]
    public int? AvmkoChecksum { get; set; }

    [Column("Avmko_create_user")]
    public short? AvmkoCreateUser { get; set; }

    [Column("Avmko_create_date")]
    public DateTime? AvmkoCreateDate { get; set; }

    [Column("Avmko_lastup_user")]
    public short? AvmkoLastupUser { get; set; }

    [Column("Avmko_lastup_date")]
    public DateTime? AvmkoLastupDate { get; set; }

    [Column("Avmko_special1")]
    [StringLength(4)]
    public string? AvmkoSpecial1 { get; set; }

    [Column("Avmko_special2")]
    [StringLength(4)]
    public string? AvmkoSpecial2 { get; set; }

    [Column("Avmko_special3")]
    [StringLength(4)]
    public string? AvmkoSpecial3 { get; set; }

    [Column("Avmko_firma_no")]
    public int? AvmkoFirmaNo { get; set; }

    [Column("Avmko_sube_no")]
    public int? AvmkoSubeNo { get; set; }

    [Column("Avmko_tarihi")]
    public DateTime? AvmkoTarihi { get; set; }

    [Column("Avmko_evrakno_seri")]
    [StringLength(50)]
    public string? AvmkoEvraknoSeri { get; set; }

    [Column("Avmko_evrakno_sira")]
    public int? AvmkoEvraknoSira { get; set; }

    [Column("Avmko_satirno")]
    public int? AvmkoSatirno { get; set; }

    [Column("Avmko_belge_no")]
    [StringLength(50)]
    public string? AvmkoBelgeNo { get; set; }

    [Column("Avmko_belge_tarih")]
    public DateTime? AvmkoBelgeTarih { get; set; }

    [Column("Avmko_kirakodu")]
    [StringLength(25)]
    public string? AvmkoKirakodu { get; set; }

    [Column("Avmko_tutar")]
    public double? AvmkoTutar { get; set; }
}
