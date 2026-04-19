using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_belge_detaylari")]
public class PersonelBelgeDetaylari
{
    [Column("bdt_Guid")]
    public Guid? BdtGuid { get; set; }

    [Column("bdt_DBCno")]
    public short? BdtDBCno { get; set; }

    [Column("bdt_SpecRECno")]
    public int? BdtSpecRECno { get; set; }

    [Column("bdt_iptal")]
    public bool? BdtIptal { get; set; }

    [Column("bdt_fileid")]
    public short? BdtFileid { get; set; }

    [Column("bdt_hidden")]
    public bool? BdtHidden { get; set; }

    [Column("bdt_kilitli")]
    public bool? BdtKilitli { get; set; }

    [Column("bdt_degisti")]
    public bool? BdtDegisti { get; set; }

    [Column("bdt_checksum")]
    public int? BdtChecksum { get; set; }

    [Column("bdt_create_user")]
    public short? BdtCreateUser { get; set; }

    [Column("bdt_create_date")]
    public DateTime? BdtCreateDate { get; set; }

    [Column("bdt_lastup_user")]
    public short? BdtLastupUser { get; set; }

    [Column("bdt_lastup_date")]
    public DateTime? BdtLastupDate { get; set; }

    [Column("bdt_special1")]
    [StringLength(4)]
    public string? BdtSpecial1 { get; set; }

    [Column("bdt_special2")]
    [StringLength(4)]
    public string? BdtSpecial2 { get; set; }

    [Column("bdt_special3")]
    [StringLength(4)]
    public string? BdtSpecial3 { get; set; }

    [Column("bdt_pers_kod")]
    [StringLength(25)]
    public string? BdtPersKod { get; set; }

    [Column("bdt_belge_kod")]
    [StringLength(25)]
    public string? BdtBelgeKod { get; set; }

    [Column("bdt_belge_no")]
    [StringLength(30)]
    public string? BdtBelgeNo { get; set; }

    [Column("bdt_belge_yeri")]
    [StringLength(40)]
    public string? BdtBelgeYeri { get; set; }

    [Column("bdt_ulke_kodu")]
    [StringLength(4)]
    public string? BdtUlkeKodu { get; set; }

    [Column("bdt_belge_baslangic")]
    public DateTime? BdtBelgeBaslangic { get; set; }

    [Column("bdt_belge_bitis")]
    public DateTime? BdtBelgeBitis { get; set; }

    [Column("bdt_pozisyon")]
    public byte? BdtPozisyon { get; set; }

    [Column("bdt_sorumlu")]
    [StringLength(25)]
    public string? BdtSorumlu { get; set; }

    [Column("bdt_pozisyon_degisim_tarihi")]
    public DateTime? BdtPozisyonDegisimTarihi { get; set; }

    [Column("bdt_pozisyon_aciklama")]
    [StringLength(40)]
    public string? BdtPozisyonAciklama { get; set; }
}
