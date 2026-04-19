using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("operasyon_maliyet_detaylari")]
public class OperasyonMaliyetDetaylari
{
    [Column("mkn_Guid")]
    public Guid? MknGuid { get; set; }

    [Column("mkn_DBCno")]
    public short? MknDBCno { get; set; }

    [Column("mkn_SpecRECno")]
    public int? MknSpecRECno { get; set; }

    [Column("mkn_iptal")]
    public bool? MknIptal { get; set; }

    [Column("mkn_fileid")]
    public short? MknFileid { get; set; }

    [Column("mkn_hidden")]
    public bool? MknHidden { get; set; }

    [Column("mkn_kilitli")]
    public bool? MknKilitli { get; set; }

    [Column("mkn_degisti")]
    public bool? MknDegisti { get; set; }

    [Column("mkn_checksum")]
    public int? MknChecksum { get; set; }

    [Column("mkn_create_user")]
    public short? MknCreateUser { get; set; }

    [Column("mkn_create_date")]
    public DateTime? MknCreateDate { get; set; }

    [Column("mkn_lastup_user")]
    public short? MknLastupUser { get; set; }

    [Column("mkn_lastup_date")]
    public DateTime? MknLastupDate { get; set; }

    [Column("mkn_special1")]
    [StringLength(4)]
    public string? MknSpecial1 { get; set; }

    [Column("mkn_special2")]
    [StringLength(4)]
    public string? MknSpecial2 { get; set; }

    [Column("mkn_special3")]
    [StringLength(4)]
    public string? MknSpecial3 { get; set; }

    [Column("mkn_hesap_kodu")]
    [StringLength(25)]
    public string? MknHesapKodu { get; set; }

    [Column("mkn_srm_merkezi")]
    [StringLength(25)]
    public string? MknSrmMerkezi { get; set; }

    [Column("mkn_dagitim_sekli")]
    public byte? MknDagitimSekli { get; set; }

    [Column("mkn_dagitilan_anahtar")]
    public double? MknDagitilanAnahtar { get; set; }

    [Column("mkn_dagitilan_maliyet_ana")]
    public double? MknDagitilanMaliyetAna { get; set; }

    [Column("mkn_dagitilan_maliyet_alt")]
    public double? MknDagitilanMaliyetAlt { get; set; }

    [Column("mkn_dagitilan_maliyet_orj")]
    public double? MknDagitilanMaliyetOrj { get; set; }

    [Column("mkn_optamam_uid")]
    public Guid? MknOptamamUid { get; set; }

    [Column("mkn_masraf_nereye")]
    public byte? MknMasrafNereye { get; set; }
}
