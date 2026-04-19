using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_hesap_teminatlari")]
public class CariHesapTeminatlari
{
    [Column("ct_Guid")]
    public Guid? CtGuid { get; set; }

    [Column("ct_DBCno")]
    public short? CtDBCno { get; set; }

    [Column("ct_SpecRECno")]
    public int? CtSpecRECno { get; set; }

    [Column("ct_iptal")]
    public bool? CtIptal { get; set; }

    [Column("ct_fileid")]
    public short? CtFileid { get; set; }

    [Column("ct_hidden")]
    public bool? CtHidden { get; set; }

    [Column("ct_kilitli")]
    public bool? CtKilitli { get; set; }

    [Column("ct_degisti")]
    public bool? CtDegisti { get; set; }

    [Column("ct_checksum")]
    public int? CtChecksum { get; set; }

    [Column("ct_create_user")]
    public short? CtCreateUser { get; set; }

    [Column("ct_create_date")]
    public DateTime? CtCreateDate { get; set; }

    [Column("ct_lastup_user")]
    public short? CtLastupUser { get; set; }

    [Column("ct_lastup_date")]
    public DateTime? CtLastupDate { get; set; }

    [Column("ct_special1")]
    [StringLength(4)]
    public string? CtSpecial1 { get; set; }

    [Column("ct_special2")]
    [StringLength(4)]
    public string? CtSpecial2 { get; set; }

    [Column("ct_special3")]
    [StringLength(4)]
    public string? CtSpecial3 { get; set; }

    [Column("ct_carikodu")]
    [StringLength(25)]
    public string? CtCarikodu { get; set; }

    [Column("ct_Aciklama_no")]
    public byte? CtAciklamaNo { get; set; }

    [Column("ct_tutari")]
    public double? CtTutari { get; set; }

    [Column("ct_DovizCinsi")]
    public byte? CtDovizCinsi { get; set; }

    [Column("ct_vade")]
    public DateTime? CtVade { get; set; }

    [Column("ct_icerigi")]
    public byte? CtIcerigi { get; set; }

    [Column("ct_GecerliFirma")]
    public int? CtGecerliFirma { get; set; }

    [Column("ct_GirisTarihi")]
    public DateTime? CtGirisTarihi { get; set; }

    [Column("ct_srmrkkodu")]
    [StringLength(25)]
    public string? CtSrmrkkodu { get; set; }

    [Column("ct_bgevrak_tip")]
    public byte? CtBgevrakTip { get; set; }

    [Column("ct_bgevrakno_seri")]
    [StringLength(50)]
    public string? CtBgevraknoSeri { get; set; }

    [Column("ct_bgevrakno_sira")]
    public int? CtBgevraknoSira { get; set; }
}
