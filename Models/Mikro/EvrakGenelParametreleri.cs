using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("evrak_genel_parametreleri")]
public class EvrakGenelParametreleri
{
    [Column("egp_Guid")]
    public Guid? EgpGuid { get; set; }

    [Column("egp_DBCno")]
    public short? EgpDBCno { get; set; }

    [Column("egp_SpecRECno")]
    public int? EgpSpecRECno { get; set; }

    [Column("egp_iptal")]
    public bool? EgpIptal { get; set; }

    [Column("egp_fileid")]
    public short? EgpFileid { get; set; }

    [Column("egp_hidden")]
    public bool? EgpHidden { get; set; }

    [Column("egp_kilitli")]
    public bool? EgpKilitli { get; set; }

    [Column("egp_degisti")]
    public bool? EgpDegisti { get; set; }

    [Column("egp_checksum")]
    public int? EgpChecksum { get; set; }

    [Column("egp_create_user")]
    public short? EgpCreateUser { get; set; }

    [Column("egp_create_date")]
    public DateTime? EgpCreateDate { get; set; }

    [Column("egp_lastup_user")]
    public short? EgpLastupUser { get; set; }

    [Column("egp_lastup_date")]
    public DateTime? EgpLastupDate { get; set; }

    [Column("egp_special1")]
    [StringLength(4)]
    public string? EgpSpecial1 { get; set; }

    [Column("egp_special2")]
    [StringLength(4)]
    public string? EgpSpecial2 { get; set; }

    [Column("egp_special3")]
    [StringLength(4)]
    public string? EgpSpecial3 { get; set; }

    [Column("egp_program_no")]
    public int? EgpProgramNo { get; set; }

    [Column("egp_aciklama_baslik_1")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik1 { get; set; }

    [Column("egp_aciklama_baslik_2")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik2 { get; set; }

    [Column("egp_aciklama_baslik_3")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik3 { get; set; }

    [Column("egp_aciklama_baslik_4")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik4 { get; set; }

    [Column("egp_aciklama_baslik_5")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik5 { get; set; }

    [Column("egp_aciklama_baslik_6")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik6 { get; set; }

    [Column("egp_aciklama_baslik_7")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik7 { get; set; }

    [Column("egp_aciklama_baslik_8")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik8 { get; set; }

    [Column("egp_aciklama_baslik_9")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik9 { get; set; }

    [Column("egp_aciklama_baslik_10")]
    [StringLength(40)]
    public string? EgpAciklamaBaslik10 { get; set; }

    [Column("egp_form_adi")]
    [StringLength(127)]
    public string? EgpFormAdi { get; set; }

    [Column("egp_tarih_kontrolu_pasif_fl")]
    public bool? EgpTarihKontroluPasifFl { get; set; }

    [Column("egp_kilit_kaydedince_fl")]
    public bool? EgpKilitKaydedinceFl { get; set; }

    [Column("egp_kilit_dokunce_fl")]
    public bool? EgpKilitDokunceFl { get; set; }

    [Column("egp_kilit_mail_fl")]
    public bool? EgpKilitMailFl { get; set; }

    [Column("egp_kilit_onzileme_fl")]
    public bool? EgpKilitOnzilemeFl { get; set; }

    [Column("egp_kilitli_dok_fl")]
    public bool? EgpKilitliDokFl { get; set; }

    [Column("egp_kilitli_mail_fl")]
    public bool? EgpKilitliMailFl { get; set; }

    [Column("egp_kilitli_ozizle_fl")]
    public bool? EgpKilitliOzizleFl { get; set; }
}
