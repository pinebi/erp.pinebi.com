using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_kadro_calisanlari")]
public class PersonelKadroCalisanlari
{
    [Column("kdrc_Guid")]
    public Guid? KdrcGuid { get; set; }

    [Column("kdrc_DBCno")]
    public short? KdrcDBCno { get; set; }

    [Column("kdrc_SpecRECno")]
    public int? KdrcSpecRECno { get; set; }

    [Column("kdrc_iptal")]
    public bool? KdrcIptal { get; set; }

    [Column("kdrc_fileid")]
    public short? KdrcFileid { get; set; }

    [Column("kdrc_hidden")]
    public bool? KdrcHidden { get; set; }

    [Column("kdrc_kilitli")]
    public bool? KdrcKilitli { get; set; }

    [Column("kdrc_degisti")]
    public bool? KdrcDegisti { get; set; }

    [Column("kdrc_checksum")]
    public int? KdrcChecksum { get; set; }

    [Column("kdrc_create_user")]
    public short? KdrcCreateUser { get; set; }

    [Column("kdrc_create_date")]
    public DateTime? KdrcCreateDate { get; set; }

    [Column("kdrc_lastup_user")]
    public short? KdrcLastupUser { get; set; }

    [Column("kdrc_lastup_date")]
    public DateTime? KdrcLastupDate { get; set; }

    [Column("kdrc_special1")]
    [StringLength(4)]
    public string? KdrcSpecial1 { get; set; }

    [Column("kdrc_special2")]
    [StringLength(4)]
    public string? KdrcSpecial2 { get; set; }

    [Column("kdrc_special3")]
    [StringLength(4)]
    public string? KdrcSpecial3 { get; set; }

    [Column("kdrc_kod")]
    [StringLength(25)]
    public string? KdrcKod { get; set; }

    [Column("kdrc_sirano")]
    public int? KdrcSirano { get; set; }

    [Column("kdrc_personel")]
    [StringLength(25)]
    public string? KdrcPersonel { get; set; }

    [Column("kdrc_pers_asil_vekil")]
    public byte? KdrcPersAsilVekil { get; set; }

    [Column("kdrc_yedek_personel")]
    [StringLength(25)]
    public string? KdrcYedekPersonel { get; set; }

    [Column("kdrc_semada_gosterme")]
    public bool? KdrcSemadaGosterme { get; set; }

    [Column("kdrc_atamatarihi")]
    public DateTime? KdrcAtamatarihi { get; set; }

    [Column("kdrc_idari_amir_no")]
    public int? KdrcIdariAmirNo { get; set; }

    [Column("kdrc_teknik_amir_no")]
    public int? KdrcTeknikAmirNo { get; set; }

    [Column("kdrc_raporlama_yap_kadro_no")]
    public int? KdrcRaporlamaYapKadroNo { get; set; }

    [Column("kdrc_vekalet_kadro_no")]
    [StringLength(25)]
    public string? KdrcVekaletKadroNo { get; set; }

    [Column("kdrc_bolge_kodu")]
    [StringLength(25)]
    public string? KdrcBolgeKodu { get; set; }

    [Column("kdrc_bolum_kodu")]
    [StringLength(25)]
    public string? KdrcBolumKodu { get; set; }

    [Column("kdrc_departman_kodu")]
    [StringLength(25)]
    public string? KdrcDepartmanKodu { get; set; }

    [Column("kdrc_ulke")]
    [StringLength(30)]
    public string? KdrcUlke { get; set; }

    [Column("kdrc_sormrkz")]
    [StringLength(25)]
    public string? KdrcSormrkz { get; set; }

    [Column("kdrc_alt_departman_kodu")]
    [StringLength(25)]
    public string? KdrcAltDepartmanKodu { get; set; }

    [Column("kdrc_butcesi")]
    public double? KdrcButcesi { get; set; }
}
