using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("evrak_aciklamalari")]
public class EvrakAciklamalari
{
    [Column("egk_Guid")]
    public Guid? EgkGuid { get; set; }

    [Column("egk_DBCno")]
    public short? EgkDBCno { get; set; }

    [Column("egk_SpecRECno")]
    public int? EgkSpecRECno { get; set; }

    [Column("egk_iptal")]
    public bool? EgkIptal { get; set; }

    [Column("egk_fileid")]
    public short? EgkFileid { get; set; }

    [Column("egk_hidden")]
    public bool? EgkHidden { get; set; }

    [Column("egk_kilitli")]
    public bool? EgkKilitli { get; set; }

    [Column("egk_degisti")]
    public bool? EgkDegisti { get; set; }

    [Column("egk_checksum")]
    public int? EgkChecksum { get; set; }

    [Column("egk_create_user")]
    public short? EgkCreateUser { get; set; }

    [Column("egk_create_date")]
    public DateTime? EgkCreateDate { get; set; }

    [Column("egk_lastup_user")]
    public short? EgkLastupUser { get; set; }

    [Column("egk_lastup_date")]
    public DateTime? EgkLastupDate { get; set; }

    [Column("egk_special1")]
    [StringLength(4)]
    public string? EgkSpecial1 { get; set; }

    [Column("egk_special2")]
    [StringLength(4)]
    public string? EgkSpecial2 { get; set; }

    [Column("egk_special3")]
    [StringLength(4)]
    public string? EgkSpecial3 { get; set; }

    [Column("egk_dosyano")]
    public short? EgkDosyano { get; set; }

    [Column("egk_hareket_tip")]
    public byte? EgkHareketTip { get; set; }

    [Column("egk_evr_tip")]
    public byte? EgkEvrTip { get; set; }

    [Column("egk_evr_seri")]
    [StringLength(50)]
    public string? EgkEvrSeri { get; set; }

    [Column("egk_evr_sira")]
    public int? EgkEvrSira { get; set; }

    [Column("egk_evr_ustkod")]
    [StringLength(25)]
    public string? EgkEvrUstkod { get; set; }

    [Column("egk_evr_doksayisi")]
    public short? EgkEvrDoksayisi { get; set; }

    [Column("egk_evracik1")]
    [StringLength(127)]
    public string? EgkEvracik1 { get; set; }

    [Column("egk_evracik2")]
    [StringLength(127)]
    public string? EgkEvracik2 { get; set; }

    [Column("egk_evracik3")]
    [StringLength(127)]
    public string? EgkEvracik3 { get; set; }

    [Column("egk_evracik4")]
    [StringLength(127)]
    public string? EgkEvracik4 { get; set; }

    [Column("egk_evracik5")]
    [StringLength(127)]
    public string? EgkEvracik5 { get; set; }

    [Column("egk_evracik6")]
    [StringLength(127)]
    public string? EgkEvracik6 { get; set; }

    [Column("egk_evracik7")]
    [StringLength(127)]
    public string? EgkEvracik7 { get; set; }

    [Column("egk_evracik8")]
    [StringLength(127)]
    public string? EgkEvracik8 { get; set; }

    [Column("egk_evracik9")]
    [StringLength(127)]
    public string? EgkEvracik9 { get; set; }

    [Column("egk_evracik10")]
    [StringLength(127)]
    public string? EgkEvracik10 { get; set; }

    [Column("egk_sipgenkarorani")]
    public double? EgkSipgenkarorani { get; set; }

    [Column("egk_kargokodu")]
    [StringLength(25)]
    public string? EgkKargokodu { get; set; }

    [Column("egk_kargono")]
    [StringLength(15)]
    public string? EgkKargono { get; set; }

    [Column("egk_tesaltarihi")]
    public DateTime? EgkTesaltarihi { get; set; }

    [Column("egk_tesalkisi")]
    [StringLength(50)]
    public string? EgkTesalkisi { get; set; }

    [Column("egk_prevwiewsayisi")]
    public short? EgkPrevwiewsayisi { get; set; }

    [Column("egk_emailsayisi")]
    public short? EgkEmailsayisi { get; set; }

    [Column("egk_Evrakopno_verildi_fl")]
    public bool? EgkEvrakopnoVerildiFl { get; set; }
}
