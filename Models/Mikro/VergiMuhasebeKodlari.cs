using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("vergi_muhasebe_kodlari")]
public class VergiMuhasebeKodlari
{
    [Column("vmk_Guid")]
    public Guid? VmkGuid { get; set; }

    [Column("vmk_DBCno")]
    public short? VmkDBCno { get; set; }

    [Column("vmk_SpecRECno")]
    public int? VmkSpecRECno { get; set; }

    [Column("vmk_iptal")]
    public bool? VmkIptal { get; set; }

    [Column("vmk_fileid")]
    public short? VmkFileid { get; set; }

    [Column("vmk_hidden")]
    public bool? VmkHidden { get; set; }

    [Column("vmk_kilitli")]
    public bool? VmkKilitli { get; set; }

    [Column("vmk_degisti")]
    public bool? VmkDegisti { get; set; }

    [Column("vmk_checksum")]
    public int? VmkChecksum { get; set; }

    [Column("vmk_create_user")]
    public short? VmkCreateUser { get; set; }

    [Column("vmk_create_date")]
    public DateTime? VmkCreateDate { get; set; }

    [Column("vmk_lastup_user")]
    public short? VmkLastupUser { get; set; }

    [Column("vmk_lastup_date")]
    public DateTime? VmkLastupDate { get; set; }

    [Column("vmk_special1")]
    [StringLength(4)]
    public string? VmkSpecial1 { get; set; }

    [Column("vmk_special2")]
    [StringLength(4)]
    public string? VmkSpecial2 { get; set; }

    [Column("vmk_special3")]
    [StringLength(4)]
    public string? VmkSpecial3 { get; set; }

    [Column("vmk_firmano")]
    public int? VmkFirmano { get; set; }

    [Column("vmk_maliyil")]
    public int? VmkMaliyil { get; set; }

    [Column("vmk_kayitID")]
    public int? VmkKayitID { get; set; }

    [Column("vmk_hesaplanankdvmuhkodu")]
    [StringLength(40)]
    public string? VmkHesaplanankdvmuhkodu { get; set; }

    [Column("vmk_indirilenkdvmuhkodu")]
    [StringLength(40)]
    public string? VmkIndirilenkdvmuhkodu { get; set; }

    [Column("vmk_satisiadekdvmuhkodu")]
    [StringLength(40)]
    public string? VmkSatisiadekdvmuhkodu { get; set; }

    [Column("vmk_alisiadekdvmuhkodu")]
    [StringLength(40)]
    public string? VmkAlisiadekdvmuhkodu { get; set; }

    [Column("vmk_indirilenkdvtevmuhkodu")]
    [StringLength(40)]
    public string? VmkIndirilenkdvtevmuhkodu { get; set; }

    [Column("vmk_odenecekkdvmuhkodu")]
    [StringLength(40)]
    public string? VmkOdenecekkdvmuhkodu { get; set; }

    [Column("vmk_ilaveedilecekkdvmuhkodu")]
    [StringLength(40)]
    public string? VmkIlaveedilecekkdvmuhkodu { get; set; }

    [Column("vmk_ihrackarskdvmuhkodu")]
    [StringLength(40)]
    public string? VmkIhrackarskdvmuhkodu { get; set; }

    [Column("vmk_satistevmuhkodut31")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut31 { get; set; }

    [Column("vmk_satistevmuhkodut91")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut91 { get; set; }

    [Column("vmk_satistevmuhkodut21")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut21 { get; set; }

    [Column("vmk_satistevmuhkodut32")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut32 { get; set; }

    [Column("vmk_satistevmuhkodut61")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut61 { get; set; }

    [Column("vmk_satistevmuhkodut45")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut45 { get; set; }

    [Column("vmk_satistevmuhkodutam")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodutam { get; set; }

    [Column("vmk_satistevmuhkodut102")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut102 { get; set; }

    [Column("vmk_satistevmuhkodut105")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut105 { get; set; }

    [Column("vmk_satistevmuhkodut107")]
    [StringLength(40)]
    public string? VmkSatistevmuhkodut107 { get; set; }

    [Column("vmk_alistevmuhkodut31")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut31 { get; set; }

    [Column("vmk_alistevmuhkodut91")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut91 { get; set; }

    [Column("vmk_alistevmuhkodut21")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut21 { get; set; }

    [Column("vmk_alistevmuhkodut32")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut32 { get; set; }

    [Column("vmk_alistevmuhkodut61")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut61 { get; set; }

    [Column("vmk_alistevmuhkodut45")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut45 { get; set; }

    [Column("vmk_alistevmuhkodutam")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodutam { get; set; }

    [Column("vmk_alistevmuhkodut102")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut102 { get; set; }

    [Column("vmk_alistevmuhkodut105")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut105 { get; set; }

    [Column("vmk_alistevmuhkodut107")]
    [StringLength(40)]
    public string? VmkAlistevmuhkodut107 { get; set; }

    [Column("vmk_satistevislemturu102")]
    [StringLength(5)]
    public string? VmkSatistevislemturu102 { get; set; }

    [Column("vmk_satistevislemturu105")]
    [StringLength(5)]
    public string? VmkSatistevislemturu105 { get; set; }

    [Column("vmk_satistevislemturu107")]
    [StringLength(5)]
    public string? VmkSatistevislemturu107 { get; set; }

    [Column("vmk_satistevislemturu91")]
    [StringLength(5)]
    public string? VmkSatistevislemturu91 { get; set; }

    [Column("vmk_alistevislemturu102")]
    [StringLength(5)]
    public string? VmkAlistevislemturu102 { get; set; }

    [Column("vmk_alistevislemturu105")]
    [StringLength(5)]
    public string? VmkAlistevislemturu105 { get; set; }

    [Column("vmk_alistevislemturu107")]
    [StringLength(5)]
    public string? VmkAlistevislemturu107 { get; set; }

    [Column("vmk_alistevislemturu91")]
    [StringLength(5)]
    public string? VmkAlistevislemturu91 { get; set; }

    [Column("vmk_alistevislemturutam")]
    [StringLength(5)]
    public string? VmkAlistevislemturutam { get; set; }

    [Column("vmk_ihrackarsislemturu")]
    [StringLength(5)]
    public string? VmkIhrackarsislemturu { get; set; }
}
