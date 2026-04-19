using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("diib_receteleri")]
public class DiibReceteleri
{
    [Column("DiibRe_Guid")]
    public Guid? DiibReGuid { get; set; }

    [Column("DiibRe_DBCno")]
    public short? DiibReDBCno { get; set; }

    [Column("DiibRe_SpecRECno")]
    public int? DiibReSpecRECno { get; set; }

    [Column("DiibRe_iptal")]
    public bool? DiibReIptal { get; set; }

    [Column("DiibRe_fileid")]
    public short? DiibReFileid { get; set; }

    [Column("DiibRe_hidden")]
    public bool? DiibReHidden { get; set; }

    [Column("DiibRe_kilitli")]
    public bool? DiibReKilitli { get; set; }

    [Column("DiibRe_degisti")]
    public bool? DiibReDegisti { get; set; }

    [Column("DiibRe_checksum")]
    public int? DiibReChecksum { get; set; }

    [Column("DiibRe_create_user")]
    public short? DiibReCreateUser { get; set; }

    [Column("DiibRe_create_date")]
    public DateTime? DiibReCreateDate { get; set; }

    [Column("DiibRe_lastup_user")]
    public short? DiibReLastupUser { get; set; }

    [Column("DiibRe_lastup_date")]
    public DateTime? DiibReLastupDate { get; set; }

    [Column("DiibRe_special1")]
    [StringLength(4)]
    public string? DiibReSpecial1 { get; set; }

    [Column("DiibRe_special2")]
    [StringLength(4)]
    public string? DiibReSpecial2 { get; set; }

    [Column("DiibRe_special3")]
    [StringLength(4)]
    public string? DiibReSpecial3 { get; set; }

    [Column("DiibRe_diibnosu")]
    [StringLength(25)]
    public string? DiibReDiibnosu { get; set; }

    [Column("DiibRe_Satirno")]
    [StringLength(25)]
    public string? DiibReSatirno { get; set; }

    [Column("DiibRe_Sira")]
    public short? DiibReSira { get; set; }

    [Column("DiibRe_Anamiktar")]
    public double? DiibReAnamiktar { get; set; }

    [Column("DiibRe_ithstok1kulmiktar")]
    public double? DiibReIthstok1kulmiktar { get; set; }

    [Column("DiibRe_ithstok1kulmiktar2")]
    public double? DiibReIthstok1kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok1fireyuzdesi")]
    public double? DiibReIthstok1fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok1aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok1aciklama { get; set; }

    [Column("DiibRe_ithstok2kulmiktar")]
    public double? DiibReIthstok2kulmiktar { get; set; }

    [Column("DiibRe_ithstok2kulmiktar2")]
    public double? DiibReIthstok2kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok2fireyuzdesi")]
    public double? DiibReIthstok2fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok2aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok2aciklama { get; set; }

    [Column("DiibRe_ithstok3kulmiktar")]
    public double? DiibReIthstok3kulmiktar { get; set; }

    [Column("DiibRe_ithstok3kulmiktar2")]
    public double? DiibReIthstok3kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok3fireyuzdesi")]
    public double? DiibReIthstok3fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok3aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok3aciklama { get; set; }

    [Column("DiibRe_ithstok4kulmiktar")]
    public double? DiibReIthstok4kulmiktar { get; set; }

    [Column("DiibRe_ithstok4kulmiktar2")]
    public double? DiibReIthstok4kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok4fireyuzdesi")]
    public double? DiibReIthstok4fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok4aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok4aciklama { get; set; }

    [Column("DiibRe_ithstok5kulmiktar")]
    public double? DiibReIthstok5kulmiktar { get; set; }

    [Column("DiibRe_ithstok5kulmiktar2")]
    public double? DiibReIthstok5kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok5fireyuzdesi")]
    public double? DiibReIthstok5fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok5aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok5aciklama { get; set; }

    [Column("DiibRe_ithstok6kulmiktar")]
    public double? DiibReIthstok6kulmiktar { get; set; }

    [Column("DiibRe_ithstok6kulmiktar2")]
    public double? DiibReIthstok6kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok6fireyuzdesi")]
    public double? DiibReIthstok6fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok6aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok6aciklama { get; set; }

    [Column("DiibRe_ithstok7kulmiktar")]
    public double? DiibReIthstok7kulmiktar { get; set; }

    [Column("DiibRe_ithstok7kulmiktar2")]
    public double? DiibReIthstok7kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok7fireyuzdesi")]
    public double? DiibReIthstok7fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok7aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok7aciklama { get; set; }

    [Column("DiibRe_ithstok8kulmiktar")]
    public double? DiibReIthstok8kulmiktar { get; set; }

    [Column("DiibRe_ithstok8kulmiktar2")]
    public double? DiibReIthstok8kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok8fireyuzdesi")]
    public double? DiibReIthstok8fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok8acikl")]
    [StringLength(50)]
    public string? DiibReIthstok8acikl { get; set; }

    [Column("DiibRe_ithstok9kulmiktar")]
    public double? DiibReIthstok9kulmiktar { get; set; }

    [Column("DiibRe_ithstok9kulmiktar2")]
    public double? DiibReIthstok9kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok9fireyuzdesi")]
    public double? DiibReIthstok9fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok9aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok9aciklama { get; set; }

    [Column("DiibRe_ithstok10kulmiktar")]
    public double? DiibReIthstok10kulmiktar { get; set; }

    [Column("DiibRe_ithstok10kulmiktar2")]
    public double? DiibReIthstok10kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok10fireyuzdesi")]
    public double? DiibReIthstok10fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok10aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok10aciklama { get; set; }

    [Column("DiibRe_ithstok11kulmiktar")]
    public double? DiibReIthstok11kulmiktar { get; set; }

    [Column("DiibRe_ithstok11kulmiktar2")]
    public double? DiibReIthstok11kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok11fireyuzdesi")]
    public double? DiibReIthstok11fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok11aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok11aciklama { get; set; }

    [Column("DiibRe_ithstok12kulmiktar")]
    public double? DiibReIthstok12kulmiktar { get; set; }

    [Column("DiibRe_ithstok12kulmiktar2")]
    public double? DiibReIthstok12kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok12fireyuzdesi")]
    public double? DiibReIthstok12fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok12aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok12aciklama { get; set; }

    [Column("DiibRe_ithstok13kulmiktar")]
    public double? DiibReIthstok13kulmiktar { get; set; }

    [Column("DiibRe_ithstok13kulmiktar2")]
    public double? DiibReIthstok13kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok13fireyuzdesi")]
    public double? DiibReIthstok13fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok13aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok13aciklama { get; set; }

    [Column("DiibRe_ithstok14kulmiktar")]
    public double? DiibReIthstok14kulmiktar { get; set; }

    [Column("DiibRe_ithstok14kulmiktar2")]
    public double? DiibReIthstok14kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok14fireyuzdesi")]
    public double? DiibReIthstok14fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok14aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok14aciklama { get; set; }

    [Column("DiibRe_ithstok15kulmiktar")]
    public double? DiibReIthstok15kulmiktar { get; set; }

    [Column("DiibRe_ithstok15kulmiktar2")]
    public double? DiibReIthstok15kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok15fireyuzdesi")]
    public double? DiibReIthstok15fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok15aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok15aciklama { get; set; }

    [Column("DiibRe_ithstok16kulmiktar")]
    public double? DiibReIthstok16kulmiktar { get; set; }

    [Column("DiibRe_ithstok16kulmiktar2")]
    public double? DiibReIthstok16kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok16fireyuzdesi")]
    public double? DiibReIthstok16fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok16aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok16aciklama { get; set; }

    [Column("DiibRe_ithstok17kulmiktar")]
    public double? DiibReIthstok17kulmiktar { get; set; }

    [Column("DiibRe_ithstok17kulmiktar2")]
    public double? DiibReIthstok17kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok17fireyuzdesi")]
    public double? DiibReIthstok17fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok17aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok17aciklama { get; set; }

    [Column("DiibRe_ithstok18kulmiktar")]
    public double? DiibReIthstok18kulmiktar { get; set; }

    [Column("DiibRe_ithstok18kulmiktar2")]
    public double? DiibReIthstok18kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok18fireyuzdesi")]
    public double? DiibReIthstok18fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok18aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok18aciklama { get; set; }

    [Column("DiibRe_ithstok19kulmiktar")]
    public double? DiibReIthstok19kulmiktar { get; set; }

    [Column("DiibRe_ithstok19kulmiktar2")]
    public double? DiibReIthstok19kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok19fireyuzdesi")]
    public double? DiibReIthstok19fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok19aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok19aciklama { get; set; }

    [Column("DiibRe_ithstok20kulmiktar")]
    public double? DiibReIthstok20kulmiktar { get; set; }

    [Column("DiibRe_ithstok20kulmiktar2")]
    public double? DiibReIthstok20kulmiktar2 { get; set; }

    [Column("DiibRe_ithstok20fireyuzdesi")]
    public double? DiibReIthstok20fireyuzdesi { get; set; }

    [Column("DiibRe_ithstok20aciklama")]
    [StringLength(50)]
    public string? DiibReIthstok20aciklama { get; set; }
}
