using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cari_mustahsil_tanimlari")]
public class CariMustahsilTanimlari
{
    [Column("Cm_Guid")]
    public Guid? CmGuid { get; set; }

    [Column("Cm_DBCno")]
    public short? CmDBCno { get; set; }

    [Column("Cm_SpecRECNo")]
    public int? CmSpecRECNo { get; set; }

    [Column("Cm_iptal")]
    public bool? CmIptal { get; set; }

    [Column("Cm_fileid")]
    public short? CmFileid { get; set; }

    [Column("Cm_hidden")]
    public bool? CmHidden { get; set; }

    [Column("Cm_kilitli")]
    public bool? CmKilitli { get; set; }

    [Column("Cm_degisti")]
    public bool? CmDegisti { get; set; }

    [Column("Cm_checksum")]
    public int? CmChecksum { get; set; }

    [Column("Cm_create_user")]
    public short? CmCreateUser { get; set; }

    [Column("Cm_create_date")]
    public DateTime? CmCreateDate { get; set; }

    [Column("Cm_lastup_user")]
    public short? CmLastupUser { get; set; }

    [Column("Cm_lastup_date")]
    public DateTime? CmLastupDate { get; set; }

    [Column("Cm_special1")]
    [StringLength(4)]
    public string? CmSpecial1 { get; set; }

    [Column("Cm_special2")]
    [StringLength(4)]
    public string? CmSpecial2 { get; set; }

    [Column("Cm_special3")]
    [StringLength(4)]
    public string? CmSpecial3 { get; set; }

    [Column("Cm_carikodu")]
    [StringLength(25)]
    public string? CmCarikodu { get; set; }

    [Column("Cm_Bagkurlu")]
    public bool? CmBagkurlu { get; set; }

    [Column("Cm_BagkurBasTar")]
    public DateTime? CmBagkurBasTar { get; set; }

    [Column("Cm_BagkurBitTar")]
    public DateTime? CmBagkurBitTar { get; set; }

    [Column("Cm_BabaAdi")]
    [StringLength(15)]
    public string? CmBabaAdi { get; set; }

    [Column("Cm_DogumYer")]
    [StringLength(15)]
    public string? CmDogumYer { get; set; }

    [Column("Cm_DogumTar")]
    public DateTime? CmDogumTar { get; set; }

    [Column("Cm_SosGuvDurumu")]
    [StringLength(20)]
    public string? CmSosGuvDurumu { get; set; }

    [Column("Cm_Donum")]
    public double? CmDonum { get; set; }

    [Column("Cm_CuzdanNo")]
    [StringLength(20)]
    public string? CmCuzdanNo { get; set; }

    [Column("Cm_FabrikaKodu")]
    [StringLength(20)]
    public string? CmFabrikaKodu { get; set; }

    [Column("Cm_FabrikaAdi")]
    [StringLength(50)]
    public string? CmFabrikaAdi { get; set; }

    [Column("Cm_RuhsatNo")]
    [StringLength(20)]
    public string? CmRuhsatNo { get; set; }

    [Column("Cm_BelgeNo")]
    [StringLength(20)]
    public string? CmBelgeNo { get; set; }

    [Column("Cm_GecerlilikTarihi")]
    public DateTime? CmGecerlilikTarihi { get; set; }

    [Column("Cm_ZiraatOdasi")]
    [StringLength(50)]
    public string? CmZiraatOdasi { get; set; }

    [Column("Cm_BagkurNo")]
    [StringLength(20)]
    public string? CmBagkurNo { get; set; }

    [Column("Cm_TCKimlikNo")]
    [StringLength(20)]
    public string? CmTCKimlikNo { get; set; }

    [Column("Cm_Kooperatif")]
    [StringLength(50)]
    public string? CmKooperatif { get; set; }

    [Column("Cm_UrunBirligi")]
    [StringLength(50)]
    public string? CmUrunBirligi { get; set; }

    [Column("Cm_HastaliktanAriBelgesi")]
    public bool? CmHastaliktanAriBelgesi { get; set; }

    [Column("Cm_ABSertifikasi")]
    public bool? CmABSertifikasi { get; set; }

    [Column("Cm_DamizlikPrimi")]
    public bool? CmDamizlikPrimi { get; set; }

    [Column("Cm_TesvikAliyor")]
    public bool? CmTesvikAliyor { get; set; }

    [Column("Cm_MuafiyetBaslangic")]
    public DateTime? CmMuafiyetBaslangic { get; set; }

    [Column("Cm_MuafiyetBitis")]
    public DateTime? CmMuafiyetBitis { get; set; }
}
