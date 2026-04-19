using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("teraziler")]
public class Teraziler
{
    [Column("terazi_Guid")]
    public Guid? TeraziGuid { get; set; }

    [Column("terazi_DBCno")]
    public short? TeraziDBCno { get; set; }

    [Column("terazi_SpecRECno")]
    public int? TeraziSpecRECno { get; set; }

    [Column("terazi_iptal")]
    public bool? TeraziIptal { get; set; }

    [Column("terazi_fileid")]
    public short? TeraziFileid { get; set; }

    [Column("terazi_hidden")]
    public bool? TeraziHidden { get; set; }

    [Column("terazi_kilitli")]
    public bool? TeraziKilitli { get; set; }

    [Column("terazi_degisti")]
    public bool? TeraziDegisti { get; set; }

    [Column("terazi_CheckSum")]
    public int? TeraziCheckSum { get; set; }

    [Column("terazi_create_user")]
    public short? TeraziCreateUser { get; set; }

    [Column("terazi_create_date")]
    public DateTime? TeraziCreateDate { get; set; }

    [Column("terazi_lastup_user")]
    public short? TeraziLastupUser { get; set; }

    [Column("terazi_lastup_date")]
    public DateTime? TeraziLastupDate { get; set; }

    [Column("terazi_special1")]
    [StringLength(4)]
    public string? TeraziSpecial1 { get; set; }

    [Column("terazi_special2")]
    [StringLength(4)]
    public string? TeraziSpecial2 { get; set; }

    [Column("terazi_special3")]
    [StringLength(4)]
    public string? TeraziSpecial3 { get; set; }

    [Column("terazi_sirano")]
    public int? TeraziSirano { get; set; }

    [Column("terazi_ismi")]
    [StringLength(40)]
    public string? TeraziIsmi { get; set; }

    [Column("terazi_calisma_mode")]
    public byte? TeraziCalismaMode { get; set; }

    [Column("terazi_comstopbit")]
    public byte? TeraziComstopbit { get; set; }

    [Column("terazi_comparity")]
    public byte? TeraziComparity { get; set; }

    [Column("terazi_combaudrate")]
    public byte? TeraziCombaudrate { get; set; }

    [Column("terazi_comdatabits")]
    public byte? TeraziComdatabits { get; set; }

    [Column("terazi_comportno")]
    public byte? TeraziComportno { get; set; }

    [Column("terazi_okunacak_karakter")]
    public byte? TeraziOkunacakKarakter { get; set; }

    [Column("terazi_baslangic_karakteri")]
    public byte? TeraziBaslangicKarakteri { get; set; }

    [Column("terazi_bilgi_uzunlugu")]
    public byte? TeraziBilgiUzunlugu { get; set; }
}
