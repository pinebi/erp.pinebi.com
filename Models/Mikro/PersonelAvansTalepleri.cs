using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_avans_talepleri")]
public class PersonelAvansTalepleri
{
    [Column("pat_Guid")]
    public Guid? PatGuid { get; set; }

    [Column("pat_DBCno")]
    public short? PatDBCno { get; set; }

    [Column("pat_SpecRECno")]
    public int? PatSpecRECno { get; set; }

    [Column("pat_iptal")]
    public bool? PatIptal { get; set; }

    [Column("pat_fileid")]
    public short? PatFileid { get; set; }

    [Column("pat_hidden")]
    public bool? PatHidden { get; set; }

    [Column("pat_kilitli")]
    public bool? PatKilitli { get; set; }

    [Column("pat_degisti")]
    public bool? PatDegisti { get; set; }

    [Column("pat_checksum")]
    public int? PatChecksum { get; set; }

    [Column("pat_create_user")]
    public short? PatCreateUser { get; set; }

    [Column("pat_create_date")]
    public DateTime? PatCreateDate { get; set; }

    [Column("pat_lastup_user")]
    public short? PatLastupUser { get; set; }

    [Column("pat_lastup_date")]
    public DateTime? PatLastupDate { get; set; }

    [Column("pat_special1")]
    [StringLength(4)]
    public string? PatSpecial1 { get; set; }

    [Column("pat_special2")]
    [StringLength(4)]
    public string? PatSpecial2 { get; set; }

    [Column("pat_special3")]
    [StringLength(4)]
    public string? PatSpecial3 { get; set; }

    [Column("pat_personelkod")]
    [StringLength(25)]
    public string? PatPersonelkod { get; set; }

    [Column("pat_maliyil")]
    public int? PatMaliyil { get; set; }

    [Column("pat_satir_no")]
    public int? PatSatirNo { get; set; }

    [Column("pat_avansayi")]
    public byte? PatAvansayi { get; set; }

    [Column("pat_avanstutari")]
    public double? PatAvanstutari { get; set; }

    [Column("pat_aciklamasi")]
    [StringLength(50)]
    public string? PatAciklamasi { get; set; }

    [Column("pat_durum")]
    public byte? PatDurum { get; set; }

    [Column("pat_carihar_evraktip")]
    public byte? PatCariharEvraktip { get; set; }

    [Column("pat_carihar_evrakseri")]
    [StringLength(50)]
    public string? PatCariharEvrakseri { get; set; }

    [Column("pat_carihar_evraksira")]
    public int? PatCariharEvraksira { get; set; }
}
