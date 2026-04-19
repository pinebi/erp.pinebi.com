using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("barkod_etiket_tanimlari")]
public class BarkodEtiketTanimlari
{
    [Column("BEP_Guid")]
    public Guid? BEPGuid { get; set; }

    [Column("BEP_DBCno")]
    public short? BEPDBCno { get; set; }

    [Column("BEP_Spec_Rec_no")]
    public int? BEPSpecRecNo { get; set; }

    [Column("BEP_iptal")]
    public bool? BEPIptal { get; set; }

    [Column("BEP_fileid")]
    public short? BEPFileid { get; set; }

    [Column("BEP_hidden")]
    public bool? BEPHidden { get; set; }

    [Column("BEP_kilitli")]
    public bool? BEPKilitli { get; set; }

    [Column("BEP_degisti")]
    public bool? BEPDegisti { get; set; }

    [Column("BEP_checksum")]
    public int? BEPChecksum { get; set; }

    [Column("BEP_create_user")]
    public short? BEPCreateUser { get; set; }

    [Column("BEP_create_date")]
    public DateTime? BEPCreateDate { get; set; }

    [Column("BEP_lastup_user")]
    public short? BEPLastupUser { get; set; }

    [Column("BEP_lastup_date")]
    public DateTime? BEPLastupDate { get; set; }

    [Column("BEP_special1")]
    [StringLength(4)]
    public string? BEPSpecial1 { get; set; }

    [Column("BEP_special2")]
    [StringLength(4)]
    public string? BEPSpecial2 { get; set; }

    [Column("BEP_special3")]
    [StringLength(4)]
    public string? BEPSpecial3 { get; set; }

    [Column("BEP_No")]
    public int? BEPNo { get; set; }

    [Column("BEP_Aciklama")]
    [StringLength(20)]
    public string? BEPAciklama { get; set; }

    [Column("BEP_EtiketYolAdi")]
    public byte? BEPEtiketYolAdi { get; set; }

    [Column("BEP_BasimAdedi")]
    public short? BEPBasimAdedi { get; set; }

    [Column("BEP_DisProgram")]
    [StringLength(12)]
    public string? BEPDisProgram { get; set; }

    [Column("BEP_DisProgramParam")]
    [StringLength(15)]
    public string? BEPDisProgramParam { get; set; }

    [Column("BEP_EAN13_DosyaAdi")]
    [StringLength(40)]
    public string? BEPEAN13DosyaAdi { get; set; }

    [Column("BEP_EAN8_DosyaAdi")]
    [StringLength(40)]
    public string? BEPEAN8DosyaAdi { get; set; }

    [Column("BEP_Ascii_DosyaAdi")]
    [StringLength(40)]
    public string? BEPAsciiDosyaAdi { get; set; }

    [Column("BEP_UPCA_DosyaAdi")]
    [StringLength(40)]
    public string? BEPUPCADosyaAdi { get; set; }

    [Column("BEP_UPCE_DosyaAdi")]
    [StringLength(40)]
    public string? BEPUPCEDosyaAdi { get; set; }

    [Column("BEP_Code39_DosyaAdi")]
    [StringLength(40)]
    public string? BEPCode39DosyaAdi { get; set; }

    [Column("BEP_KarakterCevir_fl")]
    public bool? BEPKarakterCevirFl { get; set; }

    [Column("BEP_BasimBeklemeSuresi")]
    public byte? BEPBasimBeklemeSuresi { get; set; }

    [Column("BEP_YTLCevir_fl")]
    public bool? BEPYTLCevirFl { get; set; }

    [Column("BEP_DosyaAdi")]
    [StringLength(25)]
    public string? BEPDosyaAdi { get; set; }
}
